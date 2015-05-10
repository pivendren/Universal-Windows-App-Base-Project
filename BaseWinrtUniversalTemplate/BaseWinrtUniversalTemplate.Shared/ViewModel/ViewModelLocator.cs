/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:BaseWinrtUniversalTemplate"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using BaseWinrtUniversalTemplate.Services.Design;
using BaseWinrtUniversalTemplate.Services.Implementation;
using BaseWinrtUniversalTemplate.Services.Interface;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BaseWinrtUniversalTemplate.ViewModel
{
  /// <summary>
  /// This class contains static references to all the view models in the
  /// application and provides an entry point for the bindings.
  /// </summary>
  public class ViewModelLocator
  {
    /// <summary>
    /// Initializes a new instance of the ViewModelLocator class.
    /// </summary>
    public ViewModelLocator()
    {
      ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

      //Below you register your services and viewmodels
      if (ViewModelBase.IsInDesignModeStatic)
      {
        SimpleIoc.Default.Unregister<INavigationService>();
        SimpleIoc.Default.Register<IMessageService, DesignMessageService>();
        SimpleIoc.Default.Register<INavigationService, DesignNavigationService>();
      }
      else
      {
        // Create run time view services and models
        SimpleIoc.Default.Register<IMessageService, MessageService>();
        SimpleIoc.Default.Register<INavigationService, NavigationService>();
      }

      SimpleIoc.Default.Register<MainViewModel>();
    }

    public MainViewModel Main
    {
      get
      {
        return ServiceLocator.Current.GetInstance<MainViewModel>();
      }
    }

    public static void Cleanup()
    {
    }
  }
}