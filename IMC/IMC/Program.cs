using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {                    
            //Pedir os dados do problema

            Console.WriteLine("Vamos calcular sua ficha diagnóstica! A seguir digite alguns dados seus para mim.");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            
            //validar nome
            if(string.IsNullOrEmpty(nome))//ver questão de número
            { Console.WriteLine("Erro. Digite seu nome novamente:");
               nome= Convert.ToString(Console.ReadLine()); ;
            }

            //Sexo
            Console.WriteLine("Digite");
            Console.WriteLine("1- Feminino");
            Console.WriteLine("2-Masculino");
            int sexo= int.Parse(Console.ReadLine());
            
            //Validação do Sexo
            if (sexo>2)
            { Console.WriteLine("Sexo Inválido! Digite novamente!");
             Console.ReadLine();
            }
               
            

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            //validação de idade
            
            Console.WriteLine("Digite sua altura em metros");
            double altura = double.Parse(Console.ReadLine());
            //validação da altura

            Console.WriteLine("Digite seu peso");
            double peso= double.Parse(Console.ReadLine());
            //validação do peso

            //colocar um limpa telas

            //Imprimindo o Cabeçalho
            Console.WriteLine("Diagnóstico Prévio");
            Console.WriteLine($"Nome:{nome}");

            //Imprimindo o sexo
            if(sexo==1)
            { Console.WriteLine("Sexo: Feminino."); }
            if (sexo==2)
            { Console.WriteLine("Sexo: Masculino"); }
                        
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura:{altura}"); 
            Console.WriteLine($"Peso: {peso}");
            
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
            Console.WriteLine("IMC Desejável: entre 20 e 24.");

            //Calculando o IMC
            double imc = (peso) / (altura * altura);
            Console.WriteLine($"Resultado do IMC: {imc}");

            //riscos
            if(imc<20)
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


            //recomendações

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
