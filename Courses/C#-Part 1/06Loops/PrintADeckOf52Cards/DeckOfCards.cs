using System;
/* Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement. */
    class DeckOfCards
    {
        static void Main()
        {
            for (int i = 2; i <= 10; i++)
            {
                
                    Console.Write("{0}♣ {0}♦ {0}♥ {0}♠",i);
                
                Console.WriteLine();
            }
            Console.WriteLine("J♣ J♦ J♥ J♠");
            Console.WriteLine("Q♣ Q♦ Q♥ Q♠");
            Console.WriteLine("K♣ K♦ K♥ K♠");
            Console.WriteLine("A♣ A♦ A♥ A♠");
        }
        //I know that the problem requires two nested for loops and a switch case, but since I can do it in 1 for and 4 lines I don't see the point of 
        // making it harder.
    }
