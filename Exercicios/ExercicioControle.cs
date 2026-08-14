using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioControle
    {
        ExercicioModel modelo;//conectando a Classe Model  e Contro
        private int opcao;

        public ExercicioControle()
        {
            this.modelo = new ExercicioModel();
            SetOpcao(0);
        }//construtor Padrão
        public int GetOpcao()
        {
            return this.opcao;
        }//fim do getOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }//Fim do set


        public void Coletar()
        {
            //Peguei os dois
            Console.WriteLine("informe o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infor,e o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //vou passar para o construtor com parâmetro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletor = pegar os dois números digitados 

        //mostrar as opções de operação na tela 

        public void ColetarReal()
        {
            //pegar dois numeros
            Console.WriteLine("informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo numerp; ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Chmar construtor que recebe reais 
            this.modelo = new ExercicioModel(num1, num2);
        }

        public void Menu()
        {
            Console.WriteLine("\n Escolha uma das opções abaixo: \n" +

                          "0. Sair\n" +
                          "1. Soma \n" +
                          "2. Subtração \n" +
                          "3. Divisão \n" +
                          "4. Multiplicação \n" +
                          "5. Potencia \n" +
                          "6. Potencia  com parâmetros\n" +
                          "7. Raiz \n" +
                          "8. Raiz com parâmetros \n" +
                          "9. Exercicio 01 \n" +
                         "10. Exercicio 02 \n" +
                         "11. Exercicio 03 \n" +
                         "12. Exercicio 04 \n" +
                         "13. Exercicio 05 \n" +
                         "14. Exercicio 06 \n" +
                         "15. Exercicio 07 \n" +
                         "16. Exercicio 08 \n" +
                         "17. Exercicio09 \n" +
                         "18. Exercicio10 \n" +
                         "19. Exercicio11 \n" +
                         "20. multiplo \n"+
                         "21. multiploFor \n"+
                         "22. EhPalindromo \n"+
                         "23. ContarParImpar \n");

            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//limpar o console
        }//Fim do menu

        //Executar o menu
        public void EcecutarMenu()
        {
            do
            {


                Menu();//mostrat as opções
                switch (GetOpcao())
                {
                    case 1:
                        Coletar();//pegar dois números 
                        Console.WriteLine("A soma é: " + this.modelo.soma());
                        break; //finalizar a case

                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração é: " + this.modelo.Subtarir());
                        break;//fim a case

                    case 3:
                        Coletar();
                        if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine("imposível dividir por número negativo!");
                        }
                        else if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é:" + this.modelo.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é: " + this.modelo.multiplicar());
                        break;

                    case 5:
                        ColetarReal();
                        Console.WriteLine("A Potencia é: " + this.modelo.Potencia());
                        break;

                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostre o resultado da operação 
                        Console.WriteLine("A potencia é: " + this.modelo.Potencia(bas, expoente));
                        break;

                    case 7:
                        ColetarReal();
                        Console.WriteLine("\n A raiz do primeiro número é: " + this.modelo.RaizNum3());
                        Console.WriteLine("\n A raiz do seguinte numero é: " + this.modelo.RaizNum4());
                        break;

                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar o método que calcula a Raiz
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("a raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;

                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado 
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;

                    case 10:
                        Console.WriteLine("informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        if (this.modelo.Exercicio02(numero) == -1)
                        {
                            Console.WriteLine("Esta no intervalo");
                        }
                        else
                        {
                            Console.WriteLine("Não está no intervalo");
                        }
                        break;

                    case 11:
                        Console.WriteLine("informe sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio03(idade));
                        break;

                    case 12:
                        Console.WriteLine("Informe um numero:");
                        int numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o fim");
                        int numero3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o numero que deseja procurar:");
                        int numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio04(numero1,numero2,numero3));
                        break;

                    case 13:
                        Console.WriteLine("informe o primeiro numero");
                         num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o segundo numero");
                         num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o terceiro numero");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o quarto numero");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o quinto numero");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o sexto numero");
                        int num6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o setimo numero");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o oitavo numero");
                        int num8 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o nono numero");
                        int num9 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o decimo numero");
                        int num10 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe o numero que deseja procurar");
                        int buscar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio05(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, buscar));
                        break;

                    case 14:
                        Console.WriteLine("informe o primeiro lado");
                        double lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe o segundo lado");
                        double lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe o terceiro lado");
                        double lado3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio06(lado1,lado2,lado3));
                        break;

                    case 15:
                        Console.WriteLine("Informe um numero de 1 a 7");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio07(dia));
                     break;

                    case 16:
                        Console.WriteLine("insira sua senha");
                        string SenhaBD =Convert.ToString(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio08(SenhaBD));
                        break;

                    case 17:
                        Console.WriteLine("informe o horario");
                        DateTime horario1 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("informe o segundo horario");
                        DateTime horario2 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio09(horario1,horario2));
                        break;

                    case 18:
                        Console.WriteLine("Informe o primeiro numero");
                         numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo numero");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio10(numero1, numero2));
                        break;

                    case 19:
                        Console.WriteLine("Informe a primeira nota ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a segunda nota");
                         num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a terceira nota");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a quarta nota");
                         num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("informe a quinta nota");
                         num5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio11(num1, num2, num3, num4, num5));  
                        break;

                    case 20:
                        Console.WriteLine("informe um numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //mostrar o resultado da operação
                        Console.WriteLine(this.modelo.multiplo(num));
                        break;

                    case 21:
                        Console.WriteLine("Informe um número");
                         numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.multiploFor(numero));
                        break;

                    case 22:
                        Console.WriteLine("Informe um número");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if(this.modelo.EhPalindromo(numero) == false)
                        {
                            Console.WriteLine("Não é Palíndromo");
                        }
                        else
                        {
                            Console.WriteLine("Não é palindromo");
                        }
                            break;

                    case 23:
                        this.modelo.ContarParImpar();
                        break;


                }//fim do metodo excutar menu
               
            } while (GetOpcao() != 0);//fim do método executar menu
        }
    }//fila da classe
}//fim do projeto
