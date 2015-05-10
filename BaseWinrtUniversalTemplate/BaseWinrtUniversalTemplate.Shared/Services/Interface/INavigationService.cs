using System;
using System.Collections.Generic;
using System.Text;
using BaseWinrtUniversalTemplate.Data;

namespace BaseWinrtUniversalTemplate.Services.Interface
{
  public interface INavigationService
  {
    void NavigateTo(eView view);
    void GoBack();
  }
}
