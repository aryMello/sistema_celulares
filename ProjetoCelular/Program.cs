using ProjetoCelular;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o tipo de smartphone:");
        Console.WriteLine("1 - Nokia");
        Console.WriteLine("2 - iPhone");
        Console.WriteLine("3 - Outro dispositivo");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        Smartphone celular;

        switch (opcao)
        {
            case "1":
                celular = new Nokia("111111", "Nokia Tijolão", "IMEI12345", 32);
                break;

            case "2":
                celular = new Iphone("222222", "iPhone 15", "IMEI54321", 128);
                break;

            case "3":
                Console.Write("Digite o número do celular: ");
                string numero = Console.ReadLine();

                Console.Write("Digite o modelo do celular: ");
                string modelo = Console.ReadLine();

                Console.Write("Digite o IMEI: ");
                string imei = Console.ReadLine();

                Console.Write("Digite a memória (em GB): ");
                int memoria = int.Parse(Console.ReadLine());

                celular = new GenericPhone(numero, modelo, imei, memoria);
                break;

            default:
                Console.WriteLine("Opção inválida. Encerrando o programa.");
                return;
        }

        Console.Write("Digite o nome do aplicativo que deseja instalar: ");
        string aplicativo = Console.ReadLine();

        Console.WriteLine("\nExecutando ações no smartphone...\n");

        celular.Ligar();
        celular.ReceberLigacao();
        celular.InstalarAplicativo(aplicativo);

        Console.WriteLine("\nOperação finalizada.");
    }
}
