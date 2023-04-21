namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;
        
        // Construtor
        public Foe (string name)
        {
            this.name = name; // name oculta this.name
            health = 100;
            shield = 0 ; 
        }
    }

}
