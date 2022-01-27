namespace Abstraindo_um_RPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
        {
            return this.Name + ": Usou bola de fogo";
        }

        public string Attack (int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + ": Usou bola de fogo super efetivo com critico de: +" + Bonus;
            }
            else
            {
                return this.Name + ": Usou bola de fogo com cirtico de: +" + Bonus;
            }

            
        }
    }
}