namespace SubliminaleWahrnehmungTest
{
    internal interface IModelSubTest
    {
        IViewSubTest SetView { get; set; }
        IControllerSubTest SetController { get; set; }

        void Save(Testergebnis testergebnis);

        bool CheckProband(int idProband, int pwd);
    }
}
