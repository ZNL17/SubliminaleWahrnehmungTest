namespace SubliminaleWahrnehmungTest
{
    internal interface IModelSubTest
    {
        IViewSubTest SetView { get; set; }
        IControllerSubTest SetController { get; set; }

        public void Save(Testergebnis testergebnis)
        {

        }
        
        public bool CheckProband(int idProband, int pwd)
        {
            return true;
        }
    }
}
