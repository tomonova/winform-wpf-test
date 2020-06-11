using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Repo.Models;

namespace Repo.DAL
{
    public class AppSave
    {
        private static readonly string _sizeFile = "size.properties";
        private static readonly string _languageFile = "language.properties";
        private static readonly string _teamSave = "SavedTeam.json";
        private static JsonSerializer serializer;
        public static void LanguageConfSave(string language)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_languageFile))
                {
                    sw.Write(language);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static string LanguageConfLoad()
        {
            string language;
            if (File.Exists(_languageFile))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(_languageFile))
                    {
                        language = sr.ReadLine();
                    }
                    if (language == "hr-HR" || language == "en-US")
                    {
                        return language;
                    }
                    return $"error";
                }
                catch (FileNotFoundException ex)
                {

                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }
            return "error";
        }

        public static void TeamSave(Team teamSave)
        {
            serializer = new JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(_teamSave, false))
                {
                    sw.Write("");
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Formatting = Formatting.Indented;
                        serializer.Serialize(writer, teamSave);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static Team TeamLoad()
        {
            Team savedTeam = new Team("none", "none");
            savedTeam.Players = new List<Player>();

            try
            {
                string savedGameFromJson;
                if (File.Exists(_teamSave))
                {
                    using (StreamReader sw = new StreamReader(_teamSave))
                    {
                        savedGameFromJson = sw.ReadToEnd();
                    }
                    savedTeam = JsonConvert.DeserializeObject<Team>(savedGameFromJson);
                    if (!(savedTeam is Team) || savedTeam == null)
                    {
                        savedTeam = new Team("none", "none");
                        savedTeam.Players = new List<Player>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return savedTeam;
        }

        public static void ScreenSave(string size)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_sizeFile))
                {
                    sw.Write(size);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static string SizeConfLoad()
        {
            string size;
            if (File.Exists(_sizeFile))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(_sizeFile))
                    {
                        size = sr.ReadLine();
                    }
                    if (size == "medium" || size == "minmum" || size == "fullscreen")
                    {
                        return size;
                    }
                    return "minimum";
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }
            else
            {
                return "minimum";
            }
        }
    }
}
