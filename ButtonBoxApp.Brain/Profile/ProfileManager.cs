using ButtonBoxV3.Brain.Profile;
using Newtonsoft.Json;
using System.IO;


namespace ButtonBoxApp.Brain.Profile
{
    public partial class ProfileManager : ObservableObject
    {
        //todo if no json exists, make a new one



        public ProfileManager()
        {
            ProfileList = LoadProfileList();
        }

        [ObservableProperty]
        private List<LayoutProfile>? _profileList;

        private readonly string _profilesFilePath = "\\ButtonBoxApp.Brain\\Json\\Profiles.json";

        private List<LayoutProfile> LoadProfileList()
        {
            if (File.Exists(_profilesFilePath))
            {
                var json = File.ReadAllText(_profilesFilePath);
                return JsonConvert.DeserializeObject<List<LayoutProfile>>(json) ?? new List<LayoutProfile>();
            }
            return new List<LayoutProfile>();
        }

        [RelayCommand]
        public void SaveProfileList()
        {
            var json = JsonConvert.SerializeObject(ProfileList, Formatting.Indented);
            File.WriteAllText(_profilesFilePath, json);
        }

        [RelayCommand]
        public void AddLayoutProfile(LayoutProfile LayoutProfile)
        {
            ProfileList.Add(LayoutProfile);
            SaveProfileList();
        }

        [RelayCommand]
        public void RemoveLayoutProfile(LayoutProfile LayoutProfile)
        {
            ProfileList.Remove(LayoutProfile);
            SaveProfileList();
        }
      
        public LayoutProfile? InitializeCurrentProfile()
        {

            if (ProfileList != null && ProfileList.Count < 1) return new LayoutProfile("No Profile Selected...");

            else return ProfileList?.FirstOrDefault();

        }


    }
}
