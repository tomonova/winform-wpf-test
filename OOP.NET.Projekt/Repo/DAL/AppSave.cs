using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.DAL
{
    public class AppSave
    {
        private static string _languageFile = "language.properties";
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
    }
}
