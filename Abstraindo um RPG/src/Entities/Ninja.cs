namespace Abstraindo_um_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

            public string Attack (int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + ": Usou suriken de chakara super efetivo com critico de: +" + Bonus;
            }
            else
            {
                return this.Name + "Usou kunai de fogo com cirtico de: +" + Bonus;
            }
        }

    }
}