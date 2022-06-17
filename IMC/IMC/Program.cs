using System;

namespace IMC
{
    internal class Program
    {
        /// <summary>
        /// Função para imprimir mensagem de erro
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   //Função que avisa quando há algo errado.
            static void AlertarErro()
            { Console.WriteLine("Ops! Você informou o dado errado. Digite Novamente"); }
            
            //Perguntando o Nome
            Console.WriteLine("Vamos calcular sua Ficha Diagnóstica do IMC!" +
                " A seguir digite alguns dados.");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
                        
            //validar nome se o usuário não digitar nada
            while (string.IsNullOrEmpty(nome)) 
            {
                AlertarErro();
                nome= Convert.ToString(Console.ReadLine()); ;
            }

           
            //Perguntando o Sexo
            Console.WriteLine("Digite");
            Console.WriteLine("1- Feminino");
            Console.WriteLine("2-Masculino");
            int sexo= int.Parse(Console.ReadLine());

            //Validação do Sexo
            while ( sexo<=0 || sexo>2)
            { AlertarErro();
              sexo=Convert.ToInt32(Console.ReadLine()); ;
            }
            
           //Perguntando a Idade 
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            
            //validação de idade
            while (idade <0 || idade>120 )
            {
                AlertarErro() ;
                idade = Convert.ToInt32(Console.ReadLine());
             }

            // Perguntando altura
            Console.WriteLine("Digite sua altura em metros.(Por Exemplo: 1,45)");
            double altura = double.Parse(Console.ReadLine());
            
            //validação da altura
            while (altura<0 || altura >3)
            {
                AlertarErro();
                altura = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Digite seu peso");
            double peso= double.Parse(Console.ReadLine());
            //validação do peso
          
            while(peso<0 || peso>500)
            { AlertarErro();
                peso = double.Parse(Console.ReadLine()); ;
            }

            Console.Clear();

            
            //Imprimindo o Cabeçalho
            Console.WriteLine("Diagnóstico Prévio");
            Console.WriteLine($"\nNome:{nome}");

            //Imprimindo o sexo
            if(sexo==1)
            { Console.WriteLine("Sexo: Feminino."); }
            if (sexo==2)
            { Console.WriteLine("Sexo: Masculino"); }
                        
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura:{altura} metros."); 
            Console.WriteLine($"Peso: {peso} kg.");
            
            //Calculando a categoria
            if (idade < 12)
            { Console.WriteLine("Categoria: Infantil."); }
            if (idade >= 12 && idade <= 20)
            { Console.WriteLine("Categoria: Juvenil.");  }
            if(idade >= 21 && idade <= 65 )
            { Console.WriteLine("Categoria: Adulto.");   }
            if(idade>65)
            { Console.WriteLine("Categoria: Idoso.");    }

            //Resultado desejável
            Console.WriteLine("\nIMC Desejável: entre 20 e 24.");

            //Calculando o IMC
            double imc = Convert.ToDouble(peso) / (altura * altura);
            Console.WriteLine($"\nResultado do IMC: {Math.Round(imc, 2)}");
          
            // Calculando os riscos de acordo com o imc
            if (imc<20)
            {
                Console.WriteLine("Riscos: Muitas complicações de saúde como doenças pulmonares" +
                " e cardiovasculares podem estar associadas ao baixo peso.");
            }
            if(imc>=20 && imc<25)
            { Console.WriteLine("Riscos: Seu peso está ideal para suas referências."); }
            if(imc>=25 && imc<30)
            { Console.WriteLine("Riscos: Aumento de peso apresenta risco moderado para outras doença crônicas e cardiovasculares."); }
            if (imc>=30 && imc<=35)
            { Console.WriteLine("Riscos: Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade."); }
            if(imc>35)
            { Console.WriteLine("Riscos: O obeso mórbito vive menos, tem alto risco de mortalidade geral por diversas causas."); }


            //Imprimindo a recomendação de acordo com o imc.

            if (imc < 20)
            {
                Console.WriteLine("Recomendação inicial: Inclua carboidratos simples em sua dieta, além de proteínas " +
                    "indispensáveis para ganho de massa magra. Procure um profissional.");
            }
            if (imc >= 20 && imc < 25)
            { Console.WriteLine("Recomendação inicial: Mantenha uma dieta saudável e faça seus exames periódicos."); }
            if (imc >= 25 && imc < 30)
            { Console.WriteLine("Recomendação inicial:Adote um tratamento baseado em dieta balanceada, exercício fisíco e medicação." +
                "A ajuda de um profissional pode ser interessante."); }
            if (imc >= 30 && imc <36)
            { Console.WriteLine("Recomendação inicial: Adote uma dieta alimentar rigorosa, com acompanhamento" +
                "de um nutricionista e um médico especialista(encocríno)."); }
            if(imc>=36)
            { Console.WriteLine("Recomendação inicial: Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endocríno)."); }
        }
                
    }
}
