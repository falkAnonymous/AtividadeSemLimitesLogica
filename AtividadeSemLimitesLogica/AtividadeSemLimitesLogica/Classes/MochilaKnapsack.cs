using System; // Importa o namespace System
using System.Collections.Generic; // Importa o namespace Generic Collections
using System.Threading; // Importa o namespace Threading

namespace AtividadeSemLimitesLogica.Classes // Define o namespace do projeto
{
    internal static class MochilaKnapsack // Define uma classe estática chamada MochilaKnapsack
    {
        public static double Mochila { get; set; } = 15.0; // Propriedade pública estática para armazenar o peso da mochila, com valor inicial 15.0kg

        public static void Menu(double x) // Define um método público estático chamado Menu, que aceita um parâmetro double
        {
            // Exibe o menu de opções no console
            Console.WriteLine($"Voce tem uma mochila que pesa 15kg\n Espaço disponivel {x.ToString("f2")}kg");
            Console.WriteLine("1 - Adicionar itens a mochila");
            Console.WriteLine("2 - Voltar");
            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro

            // Verifica qual opção o usuário escolheu
            switch (opcao)
            {
                case 1:
                    Console.Clear(); // Limpa o console
                    // Exibe a lista de objetos disponíveis para adicionar à mochila
                    Console.WriteLine("*-------------------------------------------------");
                    Console.WriteLine("*| Objeto          | Peso (kg)                    |");
                    Console.WriteLine("*-------------------------------------------------");
                    Console.WriteLine("01| Livro           | 1.0                          |");
                    Console.WriteLine("02| Laptop          | 2.5                          |");
                    Console.WriteLine("03| GarrafaDeAgua   | 0.5                          |");
                    Console.WriteLine("04| Lanche          | 0.2                          |");
                    Console.WriteLine("05| Celular         | 0.3                          |");
                    Console.WriteLine("06| Carregador      | 0.2                          |");
                    Console.WriteLine("07| Jaqueta         | 1.0                          |");
                    Console.WriteLine("08| Caderno         | 0.6                          |");
                    Console.WriteLine("09| Caneta          | 0.1                          |");
                    Console.WriteLine("10| Lanterna        | 0.4                          |");
                    Console.WriteLine("11| FoneDeOuvido    | 0.1                          |");
                    Console.WriteLine("12| MochilaExtra    | 1.5                          |");
                    Console.WriteLine("13| Chave           | 0.05                         |");
                    Console.WriteLine("14| Relogio         | 0.1                          |");
                    Console.WriteLine("15| ÓculosEscuros   | 0.2                          |");
                    Console.WriteLine("16| RoupaExtra      | 0.8                          |");
                    Console.WriteLine("17| Mapa            | 0.1                          |");
                    Console.WriteLine("18| GuardaChuva     | 0.3                          |");
                    Console.WriteLine("19| BolsaDeDormir   | 1.8                          |");
                    Console.WriteLine("20| Camera          | 0.9                          |");
                    Console.WriteLine("*-------------------------------------------------\n");
                    Console.Write("Digte o numero do Objeto: ");
                    int NumeroObjeto = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro
                    if (x >= 0.5 )
                    {
                        CalcMochila(ref x, NumeroObjeto); // Chama o método CalcMochila para calcular o peso da mochila
                        Menu(x); // Chama o menu novamente para continuar adicionando itens
                    }
                    if(x <=0.0)
                    {
                        Console.Clear();
                        Console.WriteLine("Mochila Cheia");
                        Thread.Sleep(1000);
                        Console.WriteLine("Resetando o Programa");
                        Thread.Sleep(500);
                        Console.Clear();
                        Mochila = 15.0;
                        Menu(Mochila);
                    }
                    break;
                case 2:
                    Console.WriteLine("Voltado para o Menu..."); // Informa que está voltando para o menu
                    Thread.Sleep(500); // Espera meio segundo
                    Console.Clear(); // Limpa o console
                    Environment.ExitCode = 0; // Define o código de saída para 0
                    MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
                    Environment.Exit(0); // Encerra a aplicação
                    break;
            }
        }

        static void CalcMochila(ref double mochila, int idNumero) // Define um método estático chamado CalcMochila
        {
            // Cria uma lista de objetos com peso e nome
            List<Objeto> listaDeObjeto = new List<Objeto>
            {
                new Objeto(01,"Livro", 1.0),
                new Objeto(02,"Laptop", 2.5),
                new Objeto(03,"GarrafaDeAgua", 0.5),
                new Objeto(04,"Lanche", 0.2),
                new Objeto(05,"Celular", 0.3),
                new Objeto(06,"Carregador", 0.2),
                new Objeto(07,"Jaqueta", 1.0),
                new Objeto(08,"Caderno", 0.6),
                new Objeto(09,"Caneta", 0.1),
                new Objeto(10,"Lanterna", 0.4),
                new Objeto(11,"FoneDeOuvido", 0.1),
                new Objeto(12,"MochilaExtra", 1.5),
                new Objeto(13,"Chave", 0.05),
                new Objeto(14,"Relogio", 0.1),
                new Objeto(15,"ÓculosEscuros", 0.2),
                new Objeto(16,"RoupaExtra", 0.8),
                new Objeto(17,"Mapa", 0.1),
                new Objeto(18,"GuardaChuva", 0.3),
                new Objeto(19,"BolsaDeDormir", 1.8),
                new Objeto(20,"Camera", 0.9)
            };

            // Loop para verificar se o objeto está na lista e calcular o peso
            foreach (Objeto obj in listaDeObjeto)
            {
                if (idNumero == obj.Id)
                {
                    mochila -= obj.Peso; // Subtrai o peso do objeto do total da mochila
                    Console.WriteLine($"{obj.Nome} adicionado! Peso restante: {mochila.ToString("f2")}kg"); // Informa que o objeto foi adicionado e o peso restante
                    break;
                }
            }
        }
    }
}
