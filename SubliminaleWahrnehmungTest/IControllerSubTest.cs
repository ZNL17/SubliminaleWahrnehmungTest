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
        public void setModel(IModelSubTest modelSubTest);
        public void setView(IViewSubTest ViewSubTest);

        public void saveTestergebnis();
        public void showZiffern();
        public void showBilder();
        public bool checkProband(int idProband, int pwd);
    }
}
