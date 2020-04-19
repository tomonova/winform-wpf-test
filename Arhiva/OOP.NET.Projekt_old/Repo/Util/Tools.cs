using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Repo.Util
{
    public class Tools
    {
        private static Random rnd;

        static Tools()
        {
            rnd = new Random();
        }

        public static Color GetRandomColor()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
    }
}
