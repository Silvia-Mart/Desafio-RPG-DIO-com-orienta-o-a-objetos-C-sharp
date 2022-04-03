namespace RPG_Usando_Orientação_a_Objetos_com_C_sharp
{
     public class Ninja : Character
     {
    
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

          public override string Attack(){
              return this.Name + " Atacou o seu oponente ";

          }  
          public string Attack(int Bonus){
            
            if(Bonus > 6 ){
                return this.Name + " Atacou Topapa com seus melhores golpes de Ninja com bonus de attack " + Bonus; 
             }else{
                 return this.Name + " Atacou Topapa com seus golpes com bonus de attack " + Bonus;
             }
        
        }
    }
}