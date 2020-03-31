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
    class FileRepo : IRepo
    {
        private string _Path = @"D:\Tomo\Documents\OOP.NET\Projekt\Matches.json";
        public List<Match> GetMatches()
        {
            using (StreamReader sr = new StreamReader(_Path))
            {
                try
                {
                    //Dohvati JSON 
                    string rawJSON = sr.ReadToEnd();
                    List<Match> matchcollection = JsonConvert.DeserializeObject<List<Match>>(rawJSON);
                    return matchcollection;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
