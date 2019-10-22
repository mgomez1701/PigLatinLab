using System;

namespace CapStoneAssignment
{
    class Program
    {
        public static char [] vowels = "aeiou".ToCharArray(); // universal array so we can use in any method// 
        static void Main(string[] args)
        {
            bool answer = true;
            while (answer == true)
            {
                Console.WriteLine("Please enter a word...");         
             string word = Console.ReadLine();

                foreach (char c in vowels) // for(int i = 0: i < vowels.Length; i++//
                {
                    if (word.StartsWith(c)) //if(word.StartsWith(c)) vowel[i])))
                    {
                        Console.WriteLine(StartsWithVowel(word));
                        
                    }
                }
               

                    DoesNotStartWithaVowels(word);
                    

                    Console.WriteLine("Do you want to go again");
                    answer = TranslateAnotherOne(Console.ReadLine());
                

            }
        }
        public static void DoesNotStartWithaVowels(string word)
        {
            word = word.ToLower();
            int index = word.IndexOfAny(vowels);
            string firstPart = word.Substring(index);
            string secondPart = word.Substring(3, index);

            
                {

                    Console.WriteLine($"{firstPart}{secondPart}ay");
                    
                
                }
            
        }
        
      public static string StartsWithVowel (string word)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                word.ToLower();
                if (word.StartsWith(vowels[i]))
                {
                    return $"{word}way";
                }
            }
            return word + "way";
        }   
        public static bool TranslateAnotherOne(string response)
        {
            if (response == "y" || response == "yes")
            {
                return true;
            }
            else
                return false;
        }
    }

}
