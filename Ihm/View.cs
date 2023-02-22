using System;
using Operators;


namespace Ihm
{
    class Views
    {
         
        public static void Home()
        {
            Console.WriteLine("Test de mathématique simple !");
            Console.WriteLine("Veuillez choisir un programme :");
            Console.WriteLine("1 - Multiplication");
            Console.WriteLine("2 - Division");
            Console.WriteLine("3 - Addition");
            Console.WriteLine("4 - Soustraction");
            Console.WriteLine("5 - Quitter");

            string choix = Input.GetKeybordEntry();

            switch (choix)
            {
                case "1":
                    Multiplication.Run();
                    break;
                case "2":
                    Division.Run();
                    break;
                case "3":
                    Addition.Run();
                    break;
                case "4":
                    Division.Run();
                    break;
                case "5":
                    Console.WriteLine("Au Revoir.");
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    Home();
                    break;
            }

            //Console.WriteLine("Appuyez sur une touche pour quitter.");
            //Console.ReadKey();
        }

        public static string ChoiceTerm1(int exo, string s)
        {
            switch (exo)
            {
                case 1:
                    Console.WriteLine("Choisissez la table voulue : ");
                    break;
                case 2:
                    Console.WriteLine("Choisissez le diviseur : ");
                    break;
                case 3:
                    Console.WriteLine("Choisissez le terme basique d'addition : ");
                    break;
                case 4:
                    Console.WriteLine("Choisissez le terme basique de soustraction : ");
                    break;
                default:
                    break;
            }
            s = Input.GetKeybordEntry();
            if (s.Contains("."))
            {
                s = s.Replace(".", ",");
            }
            int resultI;
            float resultF;
            double resultD;
            if (!int.TryParse(s, out resultI) && !float.TryParse(s, out resultF) && !double.TryParse(s, out resultD))
            {
                s = "";
            }
            return s;
        }

        // public static int GenerateRandomNumber(Random rand, int[] terms, int min, int max, int count)
        // {
        //         int term = rand.Next(1, 11);
        //         while (Array.IndexOf(terms, term) > -1)
        //         {
        //             term = rand.Next(1, 11);
        //         }
        //         terms[count] = term;
        //         return term;
        // }

        public static void GetQuestion(int exo, int term1, int term2)
        {
            switch (exo)
            {
                case 1:
                    Console.Write($"Calculez {term1} x {term2} : ");
                    break;
                case 2:
                    Console.Write($"Calculez {term2} / {term1} : ");
                    break;
                case 3:
                    Console.Write($"Calculez {term1} + {term2} : ");
                    break;
                case 4:
                    Console.Write($"Calculez {term1} - {term2} : ");
                    break;
                default:
                    break;
            }
        }

        public static int GetAnswerTo(int term1, int term2, int exo)
        {
            string answer = "";
            while (answer == "")
            {
                int resultI;
                float resultF;
                double resultD;
                GetQuestion(exo, term1, term2);
                answer = Input.GetKeybordEntry();
                if (!int.TryParse(answer, out resultI) && !float.TryParse(answer, out resultF) && !double.TryParse(answer, out resultD))
                {
                    answer = "";
                }
            }
            
            return int.Parse(answer);
            
            
        }

        public static void Appreciation(int score)
        {
            Console.WriteLine($"Votre scrore : {score} ");
            switch (score)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Pas térible!");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Moyen");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Bien");
                    break;
                case 10:
                    Console.WriteLine("Parfait");
                    break;
                default:
                    break;
            }
        }

        public static void TryAgain(int exo)
        {
            Console.WriteLine("Souhaitez-vous recommencer ? (O ou o pour Oui || N'importe quelle touche pour sortir)");
            
            string tryAgain = Console.ReadLine();
            
            if (tryAgain == "O" || tryAgain == "o"){
                switch (exo)
                {
                    case 1:
                        Multiplication.Run();
                        break;
                    case 2:
                        Division.Run();
                        break;
                    case 3:
                        Addition.Run();
                        break;
                    case 4:
                        Division.Run();
                        break;
                    default:
                        break;
                }
            }
            else{
                Home();
            }
        }

    }
}
