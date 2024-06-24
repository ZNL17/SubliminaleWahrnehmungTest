using System;
using System.Windows.Forms;

namespace SubliminaleWahrnehmungTest
{
    public partial class ViewSubTest : Form, IViewSubTest
    {
        private IModelSubTest modelSubTest;
        private IControllerSubTest controllerSubTest;

        public ViewSubTest()
        {
            InitializeComponent();
        }

        IModelSubTest IViewSubTest.setModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IControllerSubTest IViewSubTest.setController { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show(string imagePath)
        {

        }

        public void Show(int Ziffer)
        {

        }

        public Testergebnis Show()
        {
            return new Testergebnis();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        void IViewSubTest.show(string BildPfad)
        {
            throw new NotImplementedException();
        }

        void IViewSubTest.show(int Ziffer)
        {
            throw new NotImplementedException();
        }

        Testergebnis IViewSubTest.show()
        {
            throw new NotImplementedException();
        }

        private void ViewSubTest_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
