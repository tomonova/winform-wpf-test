﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Models
{
    public class AwayTeamEvent
    {
        public int id { get; set; }
        public string type_of_event { get; set; }
        public string player { get; set; }
        public string time { get; set; }
    }
}
