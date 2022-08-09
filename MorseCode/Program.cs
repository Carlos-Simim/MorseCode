using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    internal class Program
    {
        static void Main()
        {
            bool continuar = true;

            while (continuar == true)
            {
                Console.Clear();
                Console.Write("Insira a frase que você deseja traduzir para morse: ");
                string input = Console.ReadLine();
                input = input.ToUpper();
                string output = "";
                try
                {
                    output = Dictionary.StringToMorse(input.ToCharArray());
                }catch (Exception ex)
                {
                    Console.WriteLine("Entrada inválida!");
                }
                Console.WriteLine("Código morse: " + output);
                Console.WriteLine("\n" + "Você deseja traduzir mais alguma frase?");
                Console.WriteLine("Resposta (S para Sim/N para Não): ");

                bool erro = true;
                while(erro == true)
                {
                    string inputContinuar = Console.ReadLine();                    
                    if(inputContinuar == "S" || inputContinuar == "N")
                    {
                        erro = false;
                        if(inputContinuar == "S") continuar = true;
                        if(inputContinuar == "N") continuar = false;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, responda apenas com S para Sim ou N para Não: ");
                    }
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para fechar o programa!");
            Console.ReadKey();
        }
    }
}
