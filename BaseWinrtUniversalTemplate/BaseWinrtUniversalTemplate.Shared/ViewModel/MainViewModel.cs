using System;
using BaseWinrtUniversalTemplate.Data;
using BaseWinrtUniversalTemplate.Helpers;
using BaseWinrtUniversalTemplate.Services.Implementation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BaseWinrtUniversalTemplate.ViewModel
{
  /// <summary>
  /// This class contains properties that the main View can data bind to.
  /// <para>
  /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
  /// </para>
  /// <para>
  /// You can also use Blend to data bind with the tool's support.
  /// </para>
  /// <para>
  /// See http://www.galasoft.ch/mvvm
  /// </para>
  /// </summary>
  public class MainViewModel : ViewModelBase
  {
    /// <summary>
    /// Initializes a new instance of the MainViewModel class.
    /// </summary>

    #region Properties
    /// <summary>
    /// The <see cref="Date" /> property's name.
    /// </summary>
    public const string DatePropertyName = "Date";

    private string _date = "";

    /// <summary>
    /// Sets and gets the Date property.
    /// Changes to that property's value raise the PropertyChanged event. 
    /// </summary>
    public string Date
    {
      get
      {
        return _date;
      }
      set
      {
        Set(DatePropertyName, ref _date, value);
      }
    }
    #endregion

    #region Commands
    private RelayCommand _navToPage1Command;

    /// <summary>
    /// A RelayCommand that calls the navigation service.
    /// </summary>
    public RelayCommand NavToPage1Command
    {
      get
      {
        return _navToPage1Command
          ?? (_navToPage1Command = new RelayCommand(
            () => AppService.NavigationService.NavigateTo(eView.Page1),
              () => true));
      }
    }
    #endregion

    public MainViewModel()
    {
      if (IsInDesignMode)
      {
        Date = "Design - " + DateTime.Now.ToString("F"); //Design time dummy data
      }
      else
      {
        Date = "For reals - " + DateTime.Now.ToString("F"); //For reals data
      }
    }
  }
}