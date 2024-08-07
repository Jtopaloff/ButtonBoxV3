using System.Windows.Input;

namespace ButtonBoxApp.UI.Models
{
    /// <summary>
    /// Button Box Button
    ///  Set it up, bitch
    /// </summary>
    public class BoxButton
    {

        public BoxButton(string name, int ID)
        {
            Name = name;
            _id = ID;
        }


        #region Fields

        private string _name;
        private int _id;
        private KeyBinding _keyBinding;
        private Key _key;
        private int _pinNumber;
        private string _filePath;


        #endregion

        #region Properties

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public KeyBinding KeyBinding { get => _keyBinding; set => _keyBinding = value; }
        public Key Key { get => _key; set => _key = value; }
        public int PinNumber { get => _pinNumber; set => _pinNumber = value; }
        public string FilePath;



        #endregion

        #region Methods

        //public async Key GetandSetKeyBind(Key key)
        //{

        //}

        //public async AssignKey()
        //{
        //    Key = new Key();



        //    this.Key = key;
        //}

        #endregion



    }

    public class ButtonSettings
    {

        public ButtonSettings()
        {

        }




    }
}

