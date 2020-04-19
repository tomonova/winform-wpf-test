using System;

namespace Repo.Models
{
    public class Team : IComparable<Team>
    {
        public Team(string country,string code)
        {
            this.country = country;
            this.code = code;
        }
        public string country { get; set; }
        public string code { get; set; }
        public override string ToString() => $"{country} {code}";
        public override int GetHashCode() => country.GetHashCode() ^ code.GetHashCode();
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
            Team thisTeam = obj as Team;
            return thisTeam.country == this.country && thisTeam.code == this.code;
        }

        //public int CompareTo(object other)
        //{
        //    Team otherTeam = other as Team;
        //    return this.country.CompareTo(otherTeam.country);
        //}

        public int CompareTo(Team other)
        {
            return this.country.CompareTo(other.country);
        }
    }
}
