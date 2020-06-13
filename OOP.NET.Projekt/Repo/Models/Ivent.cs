using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class Ivent
    {
        public int id { get; set; }
        public string type_of_event { get; set; }
        public string player { get; set; }
        public string time { get; set; }

        public Ivent(string player, string type_of_event)
        {
            this.type_of_event = type_of_event;
            this.player = player;
        }
        public Ivent(string player, string type_of_event,string time)
        {
            this.type_of_event = type_of_event;
            this.player = player;
            this.time = time;
        }
        public override string ToString() => $"{player} {type_of_event}";
        public override int GetHashCode() => type_of_event.GetHashCode() ^ player.GetHashCode() ^ time.GetHashCode();
    }
}
