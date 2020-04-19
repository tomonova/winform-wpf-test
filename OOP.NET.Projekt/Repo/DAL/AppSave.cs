﻿using System;
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

        public static void TeamSave(Team teamSave)
        {
            serializer = new JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(_teamSave,false))
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
            Team savedTeam = new Team();

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
                    if (!(savedTeam is Team)||savedTeam==null)
                    {
                        savedTeam = new Team("none", "none");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return savedTeam;
        }
    }
}
