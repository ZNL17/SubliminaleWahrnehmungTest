using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    internal interface IControllerSubTest
    {
        void setModel(IModelSubTest modelSubTest);
        void setView(IViewSubTest ViewSubTest);

        void saveTestergebnis();
        void showZiffern();
        void showBilder();
        bool checkProband(int idProband, int pwd);
    }
}
