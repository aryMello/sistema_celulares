namespace ProjetoCelular
{
    public class GenericPhone : Smartphone
    {
        public GenericPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo '{nome}' no dispositivo genérico.");
        }
    }
}
