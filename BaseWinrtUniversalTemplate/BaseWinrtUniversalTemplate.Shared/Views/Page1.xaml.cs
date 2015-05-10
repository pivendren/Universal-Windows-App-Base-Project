using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using BaseWinrtUniversalTemplate.Data;
using BaseWinrtUniversalTemplate.Helpers;
using BaseWinrtUniversalTemplate.Services.Implementation;

namespace BaseWinrtUniversalTemplate.Views
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class Page1 : Page
  {
    public Page1()
    {
      this.InitializeComponent();
    }

    private void NavButton_OnClick(object sender, RoutedEventArgs e)
    {
      //Regular click event used to call the navigation service.
      AppService.NavigationService.NavigateTo(eView.MainPage);
    }

    private void MessageButton_OnClick(object sender, RoutedEventArgs e)
    {
      AppService.MessageService.ShowMessage("Hello :)");
    }
  }
}
