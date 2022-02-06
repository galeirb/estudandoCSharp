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





            Console.WriteLine("Hello World!");  // Comando para escrever na tela
            // Equivalente - Console.Write("Hello World! \n");
            Console.Write("Meu nome é Gabriel Marques \n");
            Console.ReadLine();             // Aguardar o usuário digitar



        }
    }
}
