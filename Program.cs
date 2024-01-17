using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que solicite nome, idade, peso, altura e sexo,
             e ao final mostre o cálculo do IMC e um texto de apresentação
            IMC = peso / (altura * altura)
            */

            // 1 - Solicitar os dados
            string nome;
            int idade;
            decimal peso;
            decimal altura;
            string sexo;

            Console.WriteLine("Bem vindo a academia malhados do verão. Favor digitar seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(nome +  " favor informar sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("e qual seu peso??");
            peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("informe também sua altura: ");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine(nome + " favor informar seu sexo: ");
            sexo = Console.ReadLine();

            // 2 - Calcular o IMC
            decimal imc;
            imc = peso / (altura * altura);

            // Apaga as informações digitadas:
            Console.Clear();

            // 3 - Apresentar os resultados
            Console.WriteLine(nome + " bem vindo a academia MALHADOS DO VERÃO!! Baseado em seu peso e sua altura, seu IMC é:" + imc);
            Console.WriteLine("Vamos iniciar seu projeto, MALHADOS DO VERÃO??");

            // Espera o usuário finalizar o programa
            Console.ReadKey();
        }
    }
}
