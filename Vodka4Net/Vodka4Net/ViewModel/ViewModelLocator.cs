using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Autofac;

namespace Vodka4Net.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            //ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //ÈÝÆ÷builder
            ContainerBuilder MainVMbuilder = new ContainerBuilder();

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
                //SimpleIoc.Default.Register<IDataService, DesignDataService>();
            }
            else
            {
                // Create run time view services and models
                //SimpleIoc.Default.Register<IDataService, DataService>();
            }

            //SimpleIoc.Default.Register<MainViewModel>();
            MainVMbuilder.RegisterType<MainViewModel>();
            MainVMContainer = MainVMbuilder.Build();
        }
        #region ViewModelÊµÀý
        //public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public MainViewModel Main => MainVMContainer.BeginLifetimeScope().Resolve<MainViewModel>();
        #endregion
        #region ÈÝÆ÷½Ó¿Ú
        static IContainer MainVMContainer { get; set; }
        //static IContainer MyClientContainer { get; set; }
        #endregion
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}