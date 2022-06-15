using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Vamos calcular sua ficha diagnóstica! A seguir digite alguns dados seus para mim.");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());


            //Imprimindo o Cabeçalho
            Console.WriteLine("Diagnóstico Prévio");
            Console.Write();

            //Calculando a categoria
            if (idade < 12)
            { Console.WriteLine("Categoria: Infantil"); }
            if (idade >= 12 && idade <= 20)
            { Console.WriteLine("Categoria: Juvenil");  }
            if(idade >= 21 && idade <= 65 )
            { Console.WriteLine("Categoria: Adulto");   }
            else
            { Console.WriteLine("Categoria: Idoso");    }


                          
        }
        
        
    }
}
