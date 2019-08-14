using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Repo.Models;

namespace Repo.DAL
{
    public class WebRepo : IRepo
    {
        List<Match> IRepo.GetMatches()
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    //Dohvati JSON 
                    string rawJSON = webClient.DownloadString("http://world-cup-json-2018.herokuapp.com/matches");
                    List<Match> matchcollection = JsonConvert.DeserializeObject<List<Match>>(rawJSON);
                    return matchcollection;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
