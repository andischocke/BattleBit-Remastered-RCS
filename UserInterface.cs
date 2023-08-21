namespace BattleBit_Remastered_RCS
{
    public partial class UserInterface : Form
    {
        // Properties
        private Game CurrentGame { get; set; }
        private Weapon CurrentWeapon { get; set; }

        // Constructor
        public UserInterface()
        {
            InitializeComponent();
            LoadGame();
        }

        private void LoadGame()
        {
            Weapon[] weapons =
            {
                // Assault Rifles
                new Weapon("AK74", 670, 1.5f),
                new Weapon("M4A1", 700, 1.5f),
                new Weapon("AK15", 540, 1.6f),
                new Weapon("SCAR-H", 500, 1.6f),
                new Weapon("AUG A3", 500, 1.2f),
                new Weapon("SG550", 700, 0.9f),
                new Weapon("FAMAS", 900, 1.4f),
                new Weapon("ACR", 700, 1.4f),
                new Weapon("G36C", 750, 1.4f),
                new Weapon("HK419", 660, 1.4f),
                new Weapon("FAL", 650, 2.02f),
                new Weapon("AK5C", 600, 2.13f),
                // Submachine Guns
                new Weapon("MP7", 950, 1.0f),
                new Weapon("UMP-45", 700, 0.9f),
                new Weapon("PP2000", 900, 1.2f),
                new Weapon("PP19", 750, 0.9f),
                new Weapon("Kriss Vector", 1200, 1.0f),
                new Weapon("MP5", 800, 0.9f),
                // Personal Defense Weapons
                new Weapon("Honey Badger", 800, 1.5f),
                new Weapon("GROZA", 650, 1.2f),
                new Weapon("P90", 800, 1.16f),
                // Carbines
                new Weapon("AS VAL", 800, 1.5f),
                new Weapon("Scorpion EVO", 1200, 2.7f),
                // Light Machine Guns
                new Weapon("L86A1", 775, 1.4f),
                new Weapon("MG36", 600, 1.8f),
                new Weapon("M249", 700, 1.1f),
                new Weapon("Ultimax 100", 600, 1.5f)
            };
            (int min, int max, int current, int preset) fieldOfView = (60, 120, 90, 90);
            (int min, int max, int current, int preset) sensitivity = (1, 500, 100, 100);
            CurrentGame = new Game("BattleBit Remastered", fieldOfView, sensitivity, weapons);

            // Fill the user interface with the game data
            GameNameLabel.Text = CurrentGame.Name;
            // Set the values for the FieldOfViewNumericUpDown
            FieldOfViewNumericUpDown.Minimum = CurrentGame.FieldOfView.min;
            FieldOfViewNumericUpDown.Maximum = CurrentGame.FieldOfView.max;
            FieldOfViewNumericUpDown.Value = CurrentGame.FieldOfView.current;
            // Set the values for the SensitivityNumericUpDown
            SensitivityNumericUpDown.Minimum = CurrentGame.Sensitivity.min;
            SensitivityNumericUpDown.Maximum = CurrentGame.Sensitivity.max;
            SensitivityNumericUpDown.Value = CurrentGame.Sensitivity.current;
            // Load the weapons into the WeaponsListBox
            foreach (Weapon weapon in CurrentGame.Weapons)
            {
                WeaponListBox.Items.Add(weapon.Name);
            }
            CurrentWeapon = CurrentGame.Weapons[0];
            LoadWeapon();
        }
        private void LoadWeapon()
        {
            WeaponNameLabel.Text = CurrentWeapon.Name;
            FireRateNumericUpDown.Value = CurrentWeapon.FireRate;
            VerticalRecoilNumericUpDown.Value = (decimal)CurrentWeapon.VerticalRecoil;
        }
        // Change the current weapon to the selected weapon in the WeaponListBox
        private void WeaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentWeapon = CurrentGame.Weapons[WeaponListBox.SelectedIndex];
            LoadWeapon();
        }
    }
}