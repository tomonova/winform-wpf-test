using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class Player : Team 
    {
        public enum Position
        {
            Unknown,
            Goalie,
            Defender,
            Midfield,
            Forward
        }
        public string Name { get; set; }
        public bool Captain { get; set; }
        public int ShirtNumber { get; set; }
        public Position position { get; set; }
        public bool Favorite { get; set; }
        public string ProfilePic { get; set; }
        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set { _gamesPlayed += value; }
        }
        private int _gamesPlayed = 0;
        public int Goals
        {
            get { return _goals; }
            set { _goals+=value; }
        }
        private int _goals = 0;
        public int YellowCards
        {
            get { return _yellowCards; }
            set { _yellowCards+=value; }
        }
        private int _yellowCards = 0;

        public Player()
        {

        }

        public Player(string country, string code,string name,bool captian,int shirtNumber, Position position) : base(country, code)
        {
            Name = name;
            Captain = captian;
            ShirtNumber = shirtNumber;
            this.position = position;
        }
        public Player(string country, string code, string name, bool favorite) : base(country, code)
        {
            Name = name;
            Favorite = favorite;

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Player thisPlayer = obj as Player;
            return thisPlayer.country == this.country && thisPlayer.Name ==this.Name && thisPlayer.ShirtNumber==this.ShirtNumber;
        }

        public override int GetHashCode()=> country.GetHashCode() ^ ShirtNumber.GetHashCode() ^ Name.GetHashCode();

        public override string ToString()=>$" Name: {Name}, {(Captain==true? " Captain, " : "")} " +
            $"Number: {ShirtNumber}, Position: {position}, Country: {code}";

        public int CompareTo(Player other)
        {
            return this.ShirtNumber.CompareTo(other.ShirtNumber);
        }
    }
}
