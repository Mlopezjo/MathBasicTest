using System;
using Ihm;

namespace Operators
{
    class Division
    {
        public static void Run()
        {
            Random rand = new Random();
            int score = 0, count = 0, exo = 2;
            double[] terms = new double[10];
            string stringTerm1 = "";

            while (stringTerm1 == "")
            {
                int resultI;
                float resultF;
                double resultD;
                Console.WriteLine("Choisissez le diviseur : ");
                stringTerm1 = Console.ReadLine();
                if (!int.TryParse(stringTerm1, out resultI) && !float.TryParse(stringTerm1, out resultF) && !double.TryParse(stringTerm1, out resultD))
                {
                    stringTerm1 = "";
                }
            }

            double term1 = double.Parse(stringTerm1);
            Console.WriteLine($"Division par {term1} !");

            while(count < 10)
            {
                double term2 = rand.Next(1, 201), finalAnswer = 0;
                while (Array.IndexOf(terms, term2) > -1)
                {
                    term2 = rand.Next(1, 201);
                }
                terms[count] = term2;
                for (int i = 0; i < terms.Length; i++)
                {
                    Console.Write(terms[i]);
                }
                double result = term2/term1;
                
                string answer = "";
                while (answer == "")
                {
                    int resultI;
                    float resultF;
                    double resultD;
                    Console.Write($"Calculez {term2} / {term1} : ");
                    answer = Console.ReadLine();
                    Console.WriteLine(answer);
                    if (!int.TryParse(answer, out resultI) && !float.TryParse(answer, out resultF) && !double.TryParse(answer, out resultD))
                    {
                        Console.WriteLine(0);
                        answer = "";
                        Console.WriteLine("So "+answer);
                    }else
                    {
                        Console.Write(1);
                        Console.Write(answer);
                        answer = answer.Replace('.', ',');
                        finalAnswer = double.Parse(answer);
                        Console.Write(finalAnswer);
                    }
                }
                
                if (finalAnswer == result) {
                    score++;
                }

                count++;
            }

            Views.Appreciation(score);
            Views.TryAgain(exo);
        }
    }
}
