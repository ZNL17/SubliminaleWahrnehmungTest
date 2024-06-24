using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    internal class ModelSubTest : IModelSubTest
    {
        ViewSubTest viewSubTest;
        IControllerSubTest controllerSubTest;

        IViewSubTest IModelSubTest.SetView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IControllerSubTest IModelSubTest.SetController { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CheckProband(int idProband, int pwd)
        {
            throw new NotImplementedException();
        }

        public void Save(Testergebnis testergebnis)
        {
            throw new NotImplementedException();
        }
    }
}
