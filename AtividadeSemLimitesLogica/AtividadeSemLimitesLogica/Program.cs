using AtividadeSemLimitesLogica.Classes; // Importa o namespace AtividadeSemLimitesLogica.Classes
using System; // Importa o namespace System

namespace AtividadeSemLimitesLogica // Define o namespace do projeto
{
    internal class Program // Define uma classe chamada Program
    {
        static void Main(string[] args) // Método estático Main, ponto de entrada do programa
        {
            MenuOpecoes.MenuOpcoes(); // Chama o método MenuOpcoes da classe MenuOpecoes
            Console.ReadKey(); // Aguarda que uma tecla seja pressionada antes de encerrar
        }
    }
}

