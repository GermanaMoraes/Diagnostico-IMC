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
            Console.WriteLine("Digite F para Feminino ou M para Masculino");
            string sexo= Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura em metros");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso");
            double peso= double.Parse(Console.ReadLine());


            //Imprimindo o Cabeçalho
            Console.WriteLine("Diagnóstico Prévio");
            Console.WriteLine($"Nome:{nome}");

            //Imprimindo o sexo(olhar como fazer)
            
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura:{altura}"); //olhar pq está imprimindo inteiro
            Console.WriteLine($"Peso: {peso}");
            
            //Calculando a categoria
            if (idade < 12)
            { Console.WriteLine("Categoria: Infantil"); }
            if (idade >= 12 && idade <= 20)
            { Console.WriteLine("Categoria: Juvenil");  }
            if(idade >= 21 && idade <= 65 )
            { Console.WriteLine("Categoria: Adulto");   }
            else
            { Console.WriteLine("Categoria: Idoso");    }

            //Resultado desejável
            Console.WriteLine("IMC Desejável: entre 20 e 24");

            //Calculando o IMC
            double imc = (peso) / (altura * altura);
            Console.WriteLine($"Resultado do IMC: {imc}");

            //riscos

            //recomendações
                          
        }
        
        
    }
}
