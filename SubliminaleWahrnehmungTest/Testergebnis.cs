using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    public class Testergebnis
    {

        private int idProband = -1;
        private int idBild = -1;
        private int gezeigteZiffer = -1;
        private TimeSpan time = TimeSpan.Zero;
        private bool correct = false;

        public Testergebnis() { }
        public Testergebnis(int idProband, int idBild, int gezeigteZiffer, TimeSpan time, bool correct)
        {
            this.idProband = idProband;
            this.idBild = idBild;
            this.time = time;
            this.correct = correct;
            this.gezeigteZiffer = gezeigteZiffer;
        }

        public global::System.Int32 IdProband { get => idProband; set => idProband = value; }
        public global::System.Int32 IdBild { get => idBild; set => idBild = value; }
        public global::System.Int32 GezeigteZiffer { get => gezeigteZiffer; set => gezeigteZiffer = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public global::System.Boolean Correct { get => correct; set => correct = value; }
    }
}
