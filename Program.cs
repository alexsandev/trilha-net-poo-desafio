using DesafioPOO.Models;

namespace DesafioPOO
{
    public class Program
    {
        static void Main()
        {
            Smartphone iphone = new Iphone("11940028922","Iphone 15 Pro Max","123456-78-910111-2",8);
            Smartphone nokia = new Nokia("11940028933","Nokia G60","121110-98-765432-1",6);

            TestarSmartphone(iphone);
            TestarSmartphone(nokia);
        }

        static void TestarSmartphone(Smartphone smartphone)
        {
            Console.WriteLine("Modelo: " + smartphone);
            Console.WriteLine("Número: " + smartphone.Numero);
            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo("Whatsapp");
            Console.WriteLine();
        }
    }
}