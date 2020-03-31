using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class Match
    {
        public string venue { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public string fifa_id { get; set; }
        public Weather weather { get; set; }
        public string attendance { get; set; }
        public IList<string> officials { get; set; }
        public string stage_name { get; set; }
        public string home_team_country { get; set; }
        public string away_team_country { get; set; }
        public DateTime datetime { get; set; }
        public string winner { get; set; }
        public string winner_code { get; set; }
        public HomeTeam home_team { get; set; }
        public AwayTeam away_team { get; set; }
        public IList<HomeTeamEvent> home_team_events { get; set; }
        public IList<AwayTeamEvent> away_team_events { get; set; }
        public HomeTeamStatistics home_team_statistics { get; set; }
        public AwayTeamStatistics away_team_statistics { get; set; }
        public DateTime last_event_update_at { get; set; }
        public DateTime? last_score_update_at { get; set; }
    }
}
