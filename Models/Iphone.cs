namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public sealed override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado em seu Iphone!");
        }

        public sealed override string ToString()
        {
            return Modelo;
        }
    }
}