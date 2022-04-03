namespace RPG_Usando_Orientação_a_Objetos_com_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja hero = new Ninja("Wedge", 5, "Ninja");
            BlackWizard badhero = new BlackWizard("Topapa", 5, "Black Wizard");

            Console.WriteLine(hero.Attack(9));
            Console.WriteLine(badhero.Attack(7));
        }
    }
}