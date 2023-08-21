namespace BattleBit_Remastered_RCS
{
    public class Game
    {
        // Properties
        public string Name { get; set; }
        public (int min, int max, int current, int preset) FieldOfView { get; set; }
        public (int min, int max, int current, int preset) Sensitivity { get; set; }
        public Weapon[] Weapons { get; set; }

        // Constructor that takes name, field of view, sensitivity and weapons
        public Game(string name, (int min, int max, int current, int preset) fieldOfView, (int min, int max, int current, int preset) sensitivity, Weapon[] weapons)
        {
            Name = name;
            FieldOfView = fieldOfView;
            Sensitivity = sensitivity;
            Weapons = weapons;
        }
    }
    public class Weapon
    {
        // Properties
        public string Name { get; set; }
        public int FireRate { get; set; }
        public double VerticalRecoil { get; set; }
        // Constructor
        public Weapon(string name, int fireRate, double verticalRecoil)
        {
            Name = name;
            FireRate = fireRate;
            VerticalRecoil = verticalRecoil;
        }
    }
}