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
            Thread recoil = new(RecoilCompensation) { IsBackground = true };
            recoil.Start();
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
            // Fill the user interface with the weapon data
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

        private void ActivationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the ActivationCheckBox is checked
            if (ActivationCheckBox.Checked)
            {
                ActivationCheckBox.Text = "Activated";
                ActivationCheckBox.ForeColor = Color.Green;
            }
            else
            {
                ActivationCheckBox.Text = "Deactivated";
                ActivationCheckBox.ForeColor = Color.Red;
            }
        }

        // Recoil Compensation algorithm
        private void RecoilCompensation()
        {
            Random random = new Random();
            float accumulatedVerticalRecoil = 0;
            float accumulatedFireInterval = 0;
            while (true)
            {
                // Adjust the vertical recoil based on the field of view and sensitivity
                float adjustedFieldOfView = CurrentGame.FieldOfView.current / CurrentGame.FieldOfView.preset;
                float adjustedSensitivity = CurrentGame.Sensitivity.current / CurrentGame.Sensitivity.preset;
                float adjustedVerticalRecoil = CurrentWeapon.VerticalRecoil * 19.5f * adjustedFieldOfView / adjustedSensitivity;
                // Apply smoothing to the recoil
                adjustedVerticalRecoil = adjustedVerticalRecoil / (float)SmoothingNumericUpDown.Value;
                // Convert fire rate which is in rounds per minute to fire interval which is the time between each round in milliseconds
                float fireInterval = (60000f / CurrentWeapon.FireRate);
                // Apply smoothing to the fire interval
                fireInterval = fireInterval / (float)SmoothingNumericUpDown.Value;

                // Only run the recoil compensation algorithm if the ActivationCheckBox is checked and the left mouse button and right mouse button are pressed
                while (ActivationCheckBox.Checked && MouseHook.IsKeyPressed(Keys.LButton) && MouseHook.IsKeyPressed(Keys.RButton))
                {
                    // Add the adjusted vertical recoil to the accumulated vertical recoil from the previous loop
                    accumulatedVerticalRecoil = accumulatedVerticalRecoil + adjustedVerticalRecoil;
                    // Convert accumulate vertical recoil to the distance to move the mouse
                    int distanceY = (int)(accumulatedVerticalRecoil + 0.5f);
                    // Random Y axis movement has a 50% chance to move -2 or 2 pixels
                    distanceY = distanceY + (random.NextDouble() < 0.5 ? random.Next(-2, 3) : 0);
                    // Subtract the distance moved from the accumulated recoil
                    accumulatedVerticalRecoil = accumulatedVerticalRecoil - distanceY;
                    // Random X axis movement has a 25% chance to move -1 or 1 pixels
                    int distanceX = random.NextDouble() < 0.25 ? random.Next(-1, 2) : 0;
                    // Move the mouse
                    MouseHook.RelativeMove(distanceX, distanceY);

                    // Add the fire interval to the accumulated fire interval from the previous loop
                    accumulatedFireInterval = accumulatedFireInterval + fireInterval;
                    // Convert fire interval to delay to sleep
                    int integerDelay = (int)accumulatedFireInterval;
                    // Subtract the delay from the accumulated fire interval
                    accumulatedFireInterval = accumulatedFireInterval - integerDelay;
                    // Sleep the thread
                    Thread.Sleep(integerDelay);
                }
            }
        }
    }
}