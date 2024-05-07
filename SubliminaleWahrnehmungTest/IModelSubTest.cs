namespace SubliminaleWahrnehmungTest
{
    internal interface IModelSubTest
    {
        public IViewSubTest SetView { get; set; }
        public IControllerSubTest SetController { get; set; }

        public void Save(Testergebnis testergebnis)
        {

        }

        public bool CheckProband(int idProband, int pwd)
        {
            return true;
        }
    }
}
