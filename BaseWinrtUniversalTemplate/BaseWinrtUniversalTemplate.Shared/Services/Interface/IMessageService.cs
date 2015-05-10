using System;
using System.Collections.Generic;
using System.Text;

namespace BaseWinrtUniversalTemplate.Services.Interface
{
  public interface IMessageService
  {
    void ShowMessage(string message);
    void ShowMessage(string message, string title);
  }
}
