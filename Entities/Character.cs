namespace RPG_Usando_Orientação_a_Objetos_com_C_sharp
{
    public class Character
    {
        
          public Character(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
         return this.Name + " " + this.Level + " " + this.HeroType + " ";
        }

         public virtual string Attack(){
              return this.Name + " Atacou o seu oponente ";
        }

    }
}