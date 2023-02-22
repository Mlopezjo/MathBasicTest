using System;
using Ihm;


namespace Operators
{
    class Addition
    {
         
        public static void Run()
        {
            Random rand = new Random();
            int score = 0, count = 0, exo = 3;
            int[] terms = new int[10];
            string stringTerm1 = "";
            
            while (stringTerm1 == "")
            {
                stringTerm1 = Views.ChoiceTerm1(exo, stringTerm1);
            }
            
            int term1 = int.Parse(stringTerm1);
            Console.WriteLine($"Vous avez choisit le terme basique d'addition {term1} !");
            
            while(count < 10)
            {
                
                int term2 = Core.GenerateRandomNumber(rand, terms, 1, 11, count);
                
                int answer = Views.GetAnswerTo(term1, term2, exo);

                int result = term1+term2;

                if (answer == result) {
                    score++;
                }

                count++;
            }

            Views.Appreciation(score);
            Views.TryAgain(exo);
        }

        
    }
}
