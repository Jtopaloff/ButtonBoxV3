using ButtonBoxApp.Brain.Profile;
using ButtonBoxV3.Brain.Profile;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows.Controls;

namespace ButtonBoxV3.UI.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private bool _isInitialized = false;

        private void InitializeViewModel()
        {

            if (CurrentProfile == null)
            {
                CurrentProfileName = CurrentProfile?.ProfileName ?? "No Profile Selected...";
            }

            CurrentProfile = ProfileManager.InitializeCurrentProfile();
            _isInitialized = true;

        }

        #region ObservableProperties

        [ObservableProperty]
        private string? _currentProfileName;

        [ObservableProperty]
        private LayoutProfile? _currentProfile;

        [ObservableProperty]
        private ProfileManager _profileManager = new();





        #endregion

        #region RelayCommands

        [RelayCommand]
        private void LoadProfiles()
        {
            if (_isInitialized) { InitializeViewModel(); }

            if (string.IsNullOrEmpty(CurrentProfileName) == true)
            { Debug.WriteLine("The fucking name is empty for some reason"); }


        }

        [RelayCommand]
        public void CreateNewProfile()
        {

            var newProfileWindow = new CreateProfileView();
            
            newProfileWindow.Show();


            Debug.WriteLine("Create New Profile Button Clicked");
            return;
        }

        #endregion


        

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        public void OnNavigatedFrom()
        {

        }
    }
}
