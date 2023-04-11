using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfighter
{
    internal class Help
    {
        public string name { get; set; }

        public int heal { get; set; } = 20;

        public int block { get; set; } = 0;

        public int health { get; set; } = 200;

        public int healthBoss { get; set; } = 200;

        public int attack { get; set; } = 20;

        public int attackBoss { get; set; } = 15;

        public int shield { get; set; }

        public string winner { get; set; }

        public int cisloLevelu { get; set; }

        public static Help ins;
        public Help()
        {
            ins = this;
        }
    }
}
