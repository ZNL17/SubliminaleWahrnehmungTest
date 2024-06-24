using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    internal class ControllerSubTest : IControllerSubTest
    {
        private IModelSubTest modelSubTest;
        private IViewSubTest viewSubTest;

        void IControllerSubTest.setModel(IModelSubTest modelSubTest)
        {
            throw new NotImplementedException();
        }

        void IControllerSubTest.setView(IViewSubTest ViewSubTest)
        {
            throw new NotImplementedException();
        }

        void IControllerSubTest.saveTestergebnis()
        {
            throw new NotImplementedException();
        }

        void IControllerSubTest.showZiffern()
        {
            throw new NotImplementedException();
        }

        void IControllerSubTest.showBilder()
        {
            throw new NotImplementedException();
        }

        bool IControllerSubTest.checkProband(int idProband, int pwd)
        {
            throw new NotImplementedException();
        }
    }
}
