using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using BaseWinrtUniversalTemplate.Data;
using BaseWinrtUniversalTemplate.Services.Interface;
using BaseWinrtUniversalTemplate.Views;

namespace BaseWinrtUniversalTemplate.Services.Implementation
{
  public class NavigationService : INavigationService
  {
    private Type _currentPageType = null;
    private Frame _mainFrame = ((Frame)Window.Current.Content);

    public void NavigateTo(Type viewType)
    {
      if (EnsureMainFrame())
      {
        if (_mainFrame.BackStack.Any(v => v.SourcePageType == viewType))
        {
          foreach (var item in _mainFrame.BackStack.ToList())
          {
            if (item.SourcePageType != viewType)
            {
              (_mainFrame.Content as Frame).BackStack.Remove(item);
            }
            else
            {
              break;
            }
          }
          _mainFrame.GoBack();
        }
        else
        {
          _mainFrame.Navigate(viewType);
        }
      }
    }

    public void NavigateTo(eView view)
    {
      //List all navigation paths here
      switch (view)
      {
        case eView.MainPage:
          _currentPageType = typeof(MainPage);
          NavigateTo(_currentPageType);
          break;
        case eView.Page1:
          _currentPageType = typeof(Page1);
          NavigateTo(_currentPageType);
          break;
      }
    }

    public void GoBack()
    {
      _currentPageType = null;
      ((Frame)Window.Current.Content).GoBack();
    }

    private bool EnsureMainFrame()
    {
      if (_mainFrame != null)
      {
        return true;
      }
      _mainFrame = Window.Current.Content as Frame;
      return _mainFrame != null;
    }
  }
}
