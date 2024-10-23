using System; // Importa o namespace System
using System.Linq; // Importa o namespace Linq
using System.Threading; // Importa o namespace Threading

namespace AtividadeSemLimitesLogica.Classes // Define o namespace do projeto
{
    internal static class MenuOpecoes // Define uma classe estática chamada MenuOpecoes
    {
        public static void MenuOpcoes() // Define um método público estático chamado MenuOpcoes
        {
            try // Início do bloco try para capturar exceções
            {
                // Exibe o menu de opções no console
                Console.WriteLine("     |***********************************|");
                Console.WriteLine("     |               MENU                |");
                Console.WriteLine("     |***********************************|");
                Console.WriteLine("     | 1) Soma dos Números Pares         |");
                Console.WriteLine("     | 2) Anagrama de Palíndromo         |");
                Console.WriteLine("     | 3) Problema da Mochila            |");
                Console.WriteLine("     | 4) Sair                           |");
                Console.WriteLine("     |===================================|\n");

                int nOpcao; // Declara uma variável inteira para armazenar a opção escolhida
                bool entradaValida = false; // Declara uma variável booleana para verificar a entrada
                string entrada; // Declara uma variável de string para armazenar a entrada do usuário

                // Loop para garantir que a entrada seja válida
                while (!entradaValida)
                {
                    Console.Write("    Digite o Numero da Opção: "); // Solicita ao usuário que insira a opção
                    entrada = Console.ReadLine(); // Lê a entrada do usuário

                    if (int.TryParse(entrada, out nOpcao) && !entrada.Contains(';')) // Verifica se a entrada é um número inteiro válido e não contém ponto e vírgula
                    {
                        entradaValida = true; // Define a entrada como válida

                        switch (nOpcao) // Verifica qual opção o usuário escolheu
                        {
                            case 1:
                                SomaDosNumeros.MenuNumeros(); // Chama o método MenuNumeros da classe SomaDosNumeros
                                break;
                            case 2:
                                AnagramaDePalindromo.MenuPalindromo(); // Chama o método MenuPalindromo da classe AnagramaDePalindromo
                                break;
                            case 3:
                                MochilaKnapsack.Menu(MochilaKnapsack.Mochila); // Chama o método Menu da classe MochilaKnapsack
                                break;
                            case 4:
                                Environment.Exit(1); // Encerra a aplicação
                                break;
                            default:
                                Console.WriteLine("Opcão Não encontrada...."); // Informa ao usuário que a opção não foi encontrada
                                Thread.Sleep(500); // Espera por 500 milissegundos
                                Console.Clear(); // Limpa o console
                                Console.WriteLine("Aguarde..."); // Exibe a mensagem "Aguarde..."
                                Thread.Sleep(500); // Espera por 500 milissegundos
                                Console.Clear(); // Limpa o console novamente
                                MenuOpcoes(); // Chama o método MenuOpcoes novamente
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número válido."); // Informa ao usuário que a entrada é inválida
                    }
                }
            }
            catch (Exception e) // Captura qualquer exceção que possa ocorrer
            {
                Console.WriteLine($"Erro Inesperado: {e}"); // Exibe a mensagem de erro
            }
            finally // Bloco finally que sempre será executado
            {
                Console.WriteLine("Aplicação Encerra em 5s"); // Informa ao usuário que a aplicação encerrará em 5 segundos
                Thread.Sleep(5000); // Espera por 5000 milissegundos (5 segundos)
                Environment.Exit(0); // Encerra a aplicação
            }
        }
    }
}
