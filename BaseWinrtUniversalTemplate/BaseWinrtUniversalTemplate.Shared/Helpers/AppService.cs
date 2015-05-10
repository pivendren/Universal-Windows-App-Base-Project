using System;
using System.Collections.Generic;
using System.Text;
using BaseWinrtUniversalTemplate.Services.Interface;
using Microsoft.Practices.ServiceLocation;

namespace BaseWinrtUniversalTemplate.Helpers
{
  //This is a convient way of calling services and viewmodels
  public static class AppService
  {
    public static INavigationService NavigationService
    {
      get { return ServiceLocator.Current.GetInstance<INavigationService>(); }
    }

    public static IMessageService MessageService
    {
      get { return ServiceLocator.Current.GetInstance<IMessageService>(); }
    }
  }
}
