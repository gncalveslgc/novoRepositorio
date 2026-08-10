using System; //Imports: Chamadas de métodos prontos 
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Exercicios
{
    class Program 
    {
        static void Main(string[] args)
        {
            ExercicioControle controle = new ExercicioControle();//Acessando a controle
            controle.EcecutarMenu();
        } // Fim do método Main
    } //Classe 
} //Fim do projeto 
