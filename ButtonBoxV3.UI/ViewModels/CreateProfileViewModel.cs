using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace ButtonBoxV3.UI.ViewModels
{
    public partial class CreateProfileViewModel : ViewModelBase
    {
        private bool _isInitialized = false;

        private void InitializeViewModel()
        {


        }

        #region Fields
        

        #endregion

        #region Properties

        [ObservableProperty]
        private int _timesNavigated2;
        
        #endregion


        public void OnNavigatedTo()
        {
            //todo: currently there are seperate threads create for each press of +
            TimesNavigated2++;
            Debug.WriteLine(TimesNavigated2);
            if (!_isInitialized) { InitializeViewModel(); return; }
            
            

        }

        public void OnNavigatedFrom()
        {
            ClearAll();
        }

        private void ClearAll()
        {
            //todo: clear all fields of the create profile when navigated from
        }
    }
}
