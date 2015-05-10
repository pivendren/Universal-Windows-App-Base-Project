using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Popups;
using BaseWinrtUniversalTemplate.Services.Interface;

namespace BaseWinrtUniversalTemplate.Services.Implementation
{
  public class MessageService : IMessageService
  {
    public void ShowMessage(string message)
    {
      var m = new MessageDialog(message);
      m.ShowAsync();
    }

    public void ShowMessage(string message, string title)
    {
      var m = new MessageDialog(message, title);
      m.ShowAsync();
    }
  }
}
