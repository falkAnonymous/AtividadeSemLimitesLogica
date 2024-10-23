using System; // Importa o namespace System
using System.Threading; // Importa o namespace Threading

namespace AtividadeSemLimitesLogica.Classes // Define o namespace do projeto
{
    internal static class SomaDosNumeros // Define uma classe estática chamada SomaDosNumeros
    {
        public static void MenuNumeros() // Define um método público estático chamado MenuNumeros
        {
            Console.Clear(); // Limpa o console
            Console.Write("Digite um numero: "); // Solicita ao usuário que insira um número
            int numeroDigitado = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro
            int guardarResultado = 0; // Inicializa a variável para guardar o resultado
            Console.WriteLine("\x0022Resultados\x0022"); // Exibe a palavra "Resultados"

            // Loop para calcular a soma dos números
            for (int i = 1; i <= numeroDigitado; i++)
            {
                if (i % 2 != 0) // Verifica se o número é ímpar
                {
                    Console.WriteLine("================="); // Exibe uma linha separadora
                    Console.WriteLine($"{i} + {i} = {i + i}"); // Exibe o cálculo da soma
                    Console.WriteLine("Não Agrega soma"); // Indica que não agrega à soma total
                    Console.WriteLine("================="); // Exibe outra linha separadora
                }
                else // Se o número for par
                {
                    Console.WriteLine($"{i} + {i} = {i + i}"); // Exibe o cálculo da soma
                    Console.WriteLine("Agrega soma"); // Indica que agrega à soma total
                    guardarResultado += i + i; // Adiciona o resultado à soma total
                }
            }

            Console.WriteLine($"Soma total : {guardarResultado}"); // Exibe a soma total
            Console.WriteLine("Aguarde 5s "); // Informa ao usuário para aguardar 5 segundos
            Thread.Sleep(5000); // Espera 5 segundos
            Console.WriteLine("Voltado para o Menu..."); // Informa que está voltando para o menu
            Thread.Sleep(500); // Espera meio segundo
            Console.Clear(); // Limpa o console
            Environment.ExitCode = 0; // Define o código de saída para 0
            MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
        }
    }
}
