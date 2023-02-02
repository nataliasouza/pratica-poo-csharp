﻿//Em um país imaginário Lisarb, todos os habitantes ficam felizes em pagar seus impostos,
//pois sabem que nele não existem políticos corruptos e os recursos arrecadador são utilizados em 
//benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo o símbolo é o R$.

//Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb.  Em seguida,
//calcule e mostre o valor que esta pessoa deve pagar de imposto de Renda, segundo a tabela abaixo.

//RENDA -------------------------------------IMPOSTO
//De 0.00 a R$ 2000.00 --------------------- Isento
//De R$ 2000.01 até R$ 3000.00 ------------- 8%
//De R$ 3000.01 até R$ 4500.00 ------------- 18%
//Acima de R$ 4500.00 ---------------------- 28%

//Lembre que, se o salário for R$3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa
//de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo),
//a taxa é de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.
//O valor deve ser impresso com duas casas decimais.

//ENTRADA ------------------------------------- SAIDA
//3002.00 ------------------------------------- R$ 80.36
//1701.12 ------------------------------------- Isento
//4520.00 ------------------------------------- R$ 355.60

using System.Globalization;

namespace curso.LogicaProgramacao.ExerciciosPropostos
{
    public class Exercicio08
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========== Calculo do Imposto de Renda =========");
            Console.Write("Digite o valor do seu salário R$: ");
   
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.Clear();
               
                Console.WriteLine("========== Calculo do Imposto de Renda =========");
                Console.WriteLine("\nValor do seu salário: " + salario);
                Console.WriteLine("O valor do Imposto de Renda a pagar R$: Isento");
                Console.WriteLine("\n==============================================");

                Console.ReadKey();
            }
            else
            {
                Console.Clear();                
                Console.WriteLine("========= Calculo do Imposto de Renda ==========");
                Console.WriteLine("\nValor do seu salário: " + salario);
                Console.WriteLine("O valor do Imposto de Renda a pagar R$:  "
                    + imposto.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("\n===============================================");

                Console.ReadKey();  
            }
        }
    }
}
