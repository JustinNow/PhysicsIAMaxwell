using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxwell_IA
{
    public static class Program
    {
        public static Maxwell maxwell = new Maxwell();
        public struct Particles
        {
            public int vel;
            public float chanceOfHit;
            public bool doesCollide;
        }
        public struct WallParticles
        {
            public int vel;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(maxwell);
        }
    }
}

