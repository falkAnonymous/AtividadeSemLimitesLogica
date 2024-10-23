using System; // Importa o namespace System
using System.Collections.Generic; // Importa o namespace Generic Collections
using System.Threading; // Importa o namespace Threading

namespace AtividadeSemLimitesLogica.Classes // Define o namespace do projeto
{
    internal static class AnagramaDePalindromo // Define uma classe estática chamada AnagramaDePalindromo
    {
        #region Anagrama de Palíndromo Funções 

        public static void MenuPalindromo() // Define um método público estático chamado MenuPalindromo
        {
            Console.Clear(); // Limpa o console
            Console.Write("Escreva uma palavra ou digite números: "); // Solicita ao usuário que insira uma palavra ou números
            string palavra = Console.ReadLine(); // Lê a entrada do usuário
            bool resultado = PodeSerPalindromo(palavra); // Chama o método PodeSerPalindromo para verificar se pode formar um palíndromo
            Console.WriteLine($"A string ou número \"{palavra}\" pode ser reorganizada para formar um palíndromo? {resultado}"); // Exibe o resultado

            // Verifica o resultado e solicita ao usuário se deseja continuar
            switch (resultado)
            {
                case true:
                    Console.WriteLine("Deseja Continuar?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("2) Não");
                    int Res = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro
                    if (Res == 1)
                    {
                        Environment.ExitCode = 0; // Define o código de saída para 0
                        MenuPalindromo(); // Chama o método MenuPalindromo novamente
                    }
                    else
                    {
                        Console.WriteLine("Voltando para o Menu...");
                        Thread.Sleep(500); // Espera meio segundo
                        Console.Clear(); // Limpa o console
                        Environment.ExitCode = 0; // Define o código de saída para 0
                        MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
                    }
                    break;
                case false:
                    Console.WriteLine("Deseja Continuar?");
                    Console.WriteLine("1) Sim");
                    Console.WriteLine("2) Não");
                    Res = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro
                    if (Res == 1)
                    {
                        Environment.ExitCode = 0; // Define o código de saída para 0
                        MenuPalindromo(); // Chama o método MenuPalindromo novamente
                    }
                    else
                    {
                        Console.WriteLine("Voltando para o Menu...");
                        Thread.Sleep(500); // Espera meio segundo
                        Console.Clear(); // Limpa o console
                        Environment.ExitCode = 0; // Define o código de saída para 0
                        MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
                    }
                    break;
                default:
                    Console.WriteLine("Voltando para o Menu...");
                    Thread.Sleep(500); // Espera meio segundo
                    Console.Clear(); // Limpa o console
                    Environment.ExitCode = 0; // Define o código de saída para 0
                    MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
                    break;
            }
        }

        static bool PodeSerPalindromo(string str) // Define um método estático chamado PodeSerPalindromo
        {
            Dictionary<char, int> contagemCaracteres = new Dictionary<char, int>(); // Cria um dicionário para armazenar a contagem de caracteres

            // Conta a frequência de cada caractere na string
            foreach (char c in str)
            {
                if (contagemCaracteres.ContainsKey(c))
                {
                    contagemCaracteres[c]++; // Se a chave já existe, incrementa o valor
                }
                else
                {
                    contagemCaracteres[c] = 1; // Se a chave não existe, cria uma nova entrada
                }
            }

            int contagemImpar = 0; // Inicializa a contagem de caracteres ímpares

            // Verifica quantos caracteres têm contagem ímpar
            foreach (int contagem in contagemCaracteres.Values)
            {
                if (contagem % 2 != 0)
                {
                    contagemImpar++; // Incrementa a contagem de caracteres ímpares
                }
            }

            // Se mais de um caractere tiver contagem ímpar, não pode ser um palíndromo
            return contagemImpar <= 1;
        }

        #endregion
    }
}
