using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Variváveis
            // Int - -156 como 32584
            // Float - -15.6 como 232.123 ==> Double | Decimal
            // Bool - true e false
            // String - "texto"
            // Char - 'a' ==> É para apenas um caractere

            // 1ª Maneira de Declarar uma Variável - Maneira mais utilizada
            // Tipo | Nome | Valor
            int segundaGuerraMundial = 1942;
            string cor_favorita = "Azul";
            float velocidadeF1 = 294.48f; //Na variável float, colocar "f" no final
            bool segundaGuerraMundial_existencia = true;

            //Utilizando as variáveis
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundial_existencia);

            // 2ª Maneira de Declarar uma Variável - Forma Preguiçosa
            var cor_favorita_teste = "Vermelho";
            var ano_teste = 2323;

            // 3ª Maneira de Declarar uma Variável - Mais avançado - 
            // Não é recomendável utilizar, pois fosse do padrão estabelecido pelo C#.
            // Temos menos desempenho e sendo utilizado para situações mais específicas.
            dynamic variavelDinamica = "Dado como texto";
            Console.WriteLine(variavelDinamica);
            variavelDinamica = 245;
            Console.WriteLine(variavelDinamica);
            */

            //Console.WriteLine("Hello World!");  // Comando para escrever na tela
            // Equivalente - Console.Write("Hello World! \n");
            //Console.Write("Meu nome é Gabriel Marques \n");
            //Console.ReadLine();             // Aguardar o usuário digitar


            // Constantes - Definido o valor apenas uma vez
            // constante | tipo | nome | valor
            //const float PI = 3.14f;
            //Console.WriteLine(PI);

            /*
            // Coletando informações do usuário
            string nome = "";
            Console.WriteLine("Escreve o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            */

            /*
            int a = 10;
            int b = 20;
            int c = 2;

            // && (E ou AND) e || (OU/OR)

            if (a > b)
            {
                Console.WriteLine("É verdade! ");
            }
            else if (a > c)
            {
                Console.WriteLine("Execultou o Elseif!");
            }
            else
            {
                Console.WriteLine("É mentira!");
            }
            */


            /*
             Console.WriteLine("Digite a sua idade");
             // Console.ReadLine(); - Coleta uma string
             int idade = int.Parse(Console.ReadLine()); //- Convertendo de string para int

             if (idade >=0 && idade <= 11)
             {
                 Console.WriteLine("Você é uma criança!");
             } else if (idade >= 12 && idade <= 18)
             {
                 Console.WriteLine("Você é um adolescente!");
             } else if (idade>= 19 && idade <= 60)
             {
                 Console.WriteLine("Você é uma adulto!");
             }
             else
             {
                 Console.WriteLine("Você é um idoso!");
             } */

            //Usando funções
            /*
            ExibirMsg();
            GerarPreco(60, "Computador");

            Console.WriteLine(Somar(10, 20, 30));
            */

            // ARRAY
            /*
            string[] produtos = new string[5]
            {
                "See of thieves", //0
                "FIFA",         //1
                "Minecraft",    //2
                "Half-life",    //3
                "Portal"        //4
            };

            int[] valores = { 40, 50, 60, 70, 80 }; //Forma mais simples de definir um array
            */

            //função SWITCH
            string cor = "Azul";
            cor = "Amarelo";

            switch (cor) //Utilizado apenas para IGUALDADE
            {
                case "Vermelho":
                    Console.WriteLine("A cor e Vermelho!");
                    break;
                case "Azul":
                    Console.WriteLine("A cor é Azul!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei!");
                    break;
            }


            Console.ReadLine();
        }

        // static - Será abordado quando for estudar Orientação Objeto
        // Criando uma função
        // ? | retorno | nome           void - Vazio ==> Função não retorna nada
        //                              int - Iremos retonar um valor inteiro
        //                              string  Retonar um valor string.
        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }

        static void GerarPreco(int preco, string nome)
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine(preco);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }


    }
}
