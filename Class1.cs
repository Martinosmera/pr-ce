using System;


namespace knihovna
{
    public class GameCharacter
    {
        private string name;
        private int level = 1;
        private int positionX = 0;
        private int positionY = 0;


        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Příliš dlouhé jméno!");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Level
        {
            get { return level; }
        }

        public int PositionX
        {
            get { return positionX; }
        }

        public int PositionY
        {
            get { return positionY; }
        }

        public GameCharacter(string name)
        {
            this.name = name;
        }

        public void ChangePosition(int mouseX, int mouseY)
        {
            // Přepočítání pozice X a Y souřadnic postavy na základě kliknutí levým tlačítkem myši
            positionX = mouseX;
            positionY = mouseY;
        }

        public override string ToString()
        {
            return $"Jméno: {name}, Level: {level}, Pozice X: {positionX}, Pozice Y: {positionY}";
        }

        private string specializace;

        public string Specializace
        {
            get { return specializace; }
            set
            {
                // Pouze povolené hodnoty pro specializaci
                string[] allowedSpecializations = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                if (Array.IndexOf(allowedSpecializations, value) != -1)
                {
                    specializace = value;
                }
            }
        }

        public enum FaceType
        {
            VelkyNos,
            Ushoplesk,
            Makeup
        }

        public enum HairStyle
        {
            Drdol,
            Culik,
            Pleska
        }

        public enum HairColor
        {
            Kashtanova,
            Blond,
            Cervena
        }

        public class Player : GameCharacter
        {
            private string specializace;
            private FaceType oblicej;
            private HairStyle vlasy;
            private HairColor barvaVlasu;
            public int XP { get; private set; }

            public Player(string jmeno, string specializace, FaceType oblicej, HairStyle vlasy, HairColor barvaVlasu) : base(jmeno)
            {
                this.specializace = specializace;
                this.oblicej = oblicej;
                this.vlasy = vlasy;
                this.barvaVlasu = barvaVlasu;
            }

            public override string ToString()
            {
                return base.ToString() +
                    $", Specializace: {specializace}, XP: {XP}, Obličej: {oblicej}, Vlasy: {vlasy}, Barva vlasů: {barvaVlasu}";
            }
        }

    }


 
}
