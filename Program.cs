namespace _9._5._rapportmodule;
class Program
{
    static void Main(string[] args)
    {
        Rapport mijnPunten = new Rapport();
        mijnPunten.Percentage = 80;
        mijnPunten.PrintGraad();
    }

    // Classes
    public class Rapport
    {
        public int Percentage { get; set; }
        

        public void PrintGraad()
        {
            switch(Percentage)
            {
                case int i when i< 50:
                    Console.WriteLine("Niet geslaagd");
                    break;
                case int i when i >= 50 && i < 69:
                    Console.WriteLine("Voldoende");
                    break;
                case int i when i >=69 && i < 76:
                    Console.WriteLine("Onderscheiding");
                    break;
                case int i when i >=76 && i < 86:
                    Console.WriteLine("Grote onderscheiding");
                    break;
                default:
                    Console.WriteLine("Grootste onderscheiding");
                    break;
            }
          
        }
    }


       
        
}
