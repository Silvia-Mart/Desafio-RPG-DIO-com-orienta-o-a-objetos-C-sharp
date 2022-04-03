namespace RPG_Usando_Orientação_a_Objetos_com_C_sharp
{
    public class BlackWizard : Character
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
           return this.Name + " Atacou com sua magia negra "; 
        }
         public string Attack(int Bonus){
            
            if(Bonus > 6 ){
                return this.Name + " Lançou sua melhor magia negra em Wedge com bonus de attack " + Bonus; 
             }else{
                 return this.Name + " Lançou sua magia negra em Wedge com bonus de attack " + Bonus;
             }
         }
    }
}