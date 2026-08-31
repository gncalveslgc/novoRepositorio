using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variável globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;
        public string[] nomes;

 
        public int[] vet;//criando vetor
        //Método Construtor: Instancia as variávesis na mémoria
        public ExercicioModel()
        {
            SetNum1(0);
            setnum2(0);
            SetResultado(0);
        }//Fim do método construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            setnum2(num2);
            SetResultado(0);
        }//Fim do método construtor 

        public ExercicioModel(double num1, double num2)
        {
            Setnum3(num1);
            Setnum4(num2);
        }//fim do metodo construtor 

        //Métodos GETS e SETS
        // GETS = pegar,obter,consultar
        //SET = Alterar, Modificar, Configurar

        public int GetNum1()
        {
            return this.num1;
        }// fim do getNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do setNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do getNum2

        public void setnum2(int num2)
        {
            this.num2 = num2;
        }//fim do setNum2

        public double GetNum3()
        {
            return this.num3;
        }

        public double GetNum4()
        {
            return this.num4;
        }

        public void Setnum3(double num3)
        {
            this.num3 = num3;
        }

        public void Setnum4(double num4)
        {
            this.num4 = num4;

        }


        public int soma()
        {
            return this.num1 + this.num2;
        }// fim da soma 

        public int GetResultado()
        {
            return this.resultado;
        }//fim do metodo

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;
        }//fim do metodo setResultado

        public int Subtarir()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();

        }//Fim do método subtrair 

        public int multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }//fim do multiplicador     

        public double Dividir()
        {
            if (GetNum2() < 0)
            {
                return -2;
            }
            else if (GetNum2() == 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();

            }//fim do if
        }//fim do dividir

        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }//fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//fim raiz 

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum3());
        }
        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }

        public string Exercicio01(int ano)
        {
            if (ano % 4 == 0)
            {
                return ano + " É bissexto!";
            }
            else
            {
                return ano + " Não é Bissexto";
            }
        }//fim do ano Bissexto 

        public int Exercicio02(int numero)
        {
            if (numero >= 100 && numero <= 200)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }//fim do Exercicio02

        public string Exercicio03(int idade)
        {
            if (idade >= 16 && idade <= 17)
            {
                return "Pode votar, porem não é obrigatorio ";
            }
            else if (idade >= 18)
            {
                return "É obrigado a votar";
            }
            else
            {
                return "Não pode votar";
            }
        }//Fim do Exercicio03

        public string Exercicio04(int numero1, int numero2, int numero3)
        {
            if (numero1 >= numero2 && numero1 <= numero3)
            {
                return "o numero esta no intervalo ";
            }
            else
            {
                return "o número não esta no intervalo";
            }
        }//Fim do exercicio04

        public string Exercicio05(double num1, double num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10, int buscar)
        {
            if (buscar == num1 && buscar == num2 && buscar == num3 && buscar == num4 && buscar == num5 && buscar == num6 && buscar == num7 && buscar == num8 && buscar == num9 && buscar == num10)
            {
                return "esta entre os 10";
            }
            else
            {
                return "o numero não esta entre os 10";
            }
        }//Fm do Exercicio05

        public string Exercicio06(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                return "é triangulo equilatero!";
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {

                return "é triangulo escaleno!";
            }
            else
            {
                return "triangulo isósceles!";
            }
        }//Fim do Exercicio06


        public string Exercicio07(int dia)
        {
            if (1 == dia)
            {
                return "Domingo";
            }
            else if (2 == dia)
            {
                return "Segunda-Feira";
            }
            else if (3 == dia)
            {
                return "Terça-Feira";
            }
            else if (4 == dia)
            {
                return "Quarta-Feira";
            }
            else if (5 == dia)
            {
                return "Quinta-Feira";
            }
            else if (6 == dia)
            {
                return "Sexta-Feira";
            }
            else if (7 == dia)
            {
                return "Sabado";
            }
            else
            {
                return "Dia invalido";
            }
        }//Fim do Exercicio07

        public string Exercicio08(string SenhaBD)
        {
            if (SenhaBD == "1234")
            {
                return "Seja bem-vindo";
            }
            else
            {
                return "Senha incorreta";
            }
        }//Fim do Exercicio08

        public string Exercicio09(DateTime horario1, DateTime horario2)
        {
            if (horario1 >= horario2)
            {
                return "o horario 1 é maior ";
            }
            else
            {
                return "o horario 2 é maior";
            }
        }//Fim do Exercicio09

        public string Exercicio10(int numero1, int numero2)
        {
            if (numero1 >= numero2)
            {
                return "o " + numero1 + "é maior ";
            }
            else
            {
                return "o " + numero2 + " é maior";
            }
        }//Fim do exercicio10

        public string Exercicio11(double num1, double num2, double num3, double num4, double num5)
        {
            double media = (num1 + num2 + num3 + num4 + num5) / 5;
            return "a média é:  " + media;
        }//Fim do exercicio11

        //Leai um número inteiro e retorna todos os múltiplos  menores que 100

        public string multiplo(int numero)
        {
            //contador
            int i = 1;//criando o contador e definindo o ponto de partida
            string resultado = "";
            while (i < 100) 
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";

                }
                //Rodar o meu contador
                i++;
            }//Fim do while
            return resultado;
        }//fim do método

        public string multiploFor(int numero)
        {
            string resultado = "";
            for (int i = 1; i < 100; i++)
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";
                }
            }
            return resultado;
        }//fim do método

        //leia um número e verefique se ele é palíndromo ele é palíndromo(ex: 121, 1331, 1441, 0660)

        public bool EhPalindromo(int numero)
        {
            string Palin = numero + "";
            int fim = Palin.Length - 1;//meço oo tamanho de um conjunto de caracteres 
            int inicio = 0;


            while (inicio < fim)
            {
                if (Palin.Substring(inicio, 1) != Palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;

            }
            return true;
        }//Fim do método

        //solicite ao usuário 10 números e conte os pares e ímpares
        public void ContarParImpar()
        {
            int contarPar = 0;
            int contarImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " número");
                int num = Convert.ToInt32(Console.ReadLine());
                //comparação
                if (num % 2 == 0)
                {
                    contarPar++;
                }
                else
                {
                    contarImpar++;
                }//fim If
            }//Fim for
            Console.WriteLine("A quantidade de pares é: " + contarPar + "\nA quantidade de ímpares é " + contarImpar);
        }//fim do método




        //vetores
        //preencher vetor
        public void preencherVetor()
        {
            this.vet = new int[10];//instanciando 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "a Posição");
                this.vet[i] = Convert.ToInt32(Console.ReadLine());

            }//fim do for
        }//fim do preencherVetor

        public void mostrarVetor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " a Posição: " + this.vet[i]);
            }//fim do for
        }//fim do metodo

        public string ProcurarNumero(int num)
        {
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] == num)
                {
                    return " O número está na posição: " + (i + 1);
                }
            }//fim do for
            return "O " + num + "não foi encontrado no vetor";
        }//fim do metodo



        public void mostrarInverso()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª posição " + this.vet[i]);
            }//fim do for 
        }//fim do metodo

        public void mostraPares()
        {
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine("os numeros pares são: " + this.vet[i]);
                }
               
            }//fim do for 
        }//fim do metodo

        public double fazerMedia()
        {
            double soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += this.vet[i];
            }
            return soma / 10;
        }//fim do metodo

        public void nomesComA()
        {
            this.nomes = new string[10];
                for(int i =0; i<10; i++)
            {
                Console.WriteLine(i + 1 + "nome: ");
                this.nomes[i] = Console.ReadLine();
            }//fim do for 
        }//fim do metodo

        public void procurarNomes(string nome)
        {
            for (int i = 0;i < 10;i++)
            {
                if (nomes[i] == nome)
                {
                    Console.WriteLine(nome[i]);
                }
            }//fim do for
            Console.WriteLine("O" + nomes + "não foi encontrado");
        }//fim do metodo

        public string ProcurarNomeA(string letraA)
        {
            for (int i = 0; i < 10; i++)
            {
                if (nomes[i] == letraA)
                {
                    return " O nome está: " + (i + 1);
                }
            }//fim do for
            return "O " + letraA + "não foi encontrado no vetor";
        }//fim do metodo

    }
}//Fim do projeto




