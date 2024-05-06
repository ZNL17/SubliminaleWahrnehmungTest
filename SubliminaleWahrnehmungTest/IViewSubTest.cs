using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    internal interface IViewSubTest
    {
        IModelSubTest setModel { get; set; }
        IControllerSubTest setController { get; set; }
        void show(string BildPfad);
        void show(int Ziffer);
        Testergebnis show();

        //fjdslkfj
        //test
    }
}
