using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Vowel
{
    class VowelContant
    {
        public void CountVowelCon()
        {
            string inputstring;
            int i, len, vowels, consonants;
            Console.Write("Enter the string = ");
            
            inputstring = Console.ReadLine();
            vowels = 0;
            consonants = 0;
            len = inputstring.Length;

            // Iterating the string from left to right
            for (i = 0; i < len; i++)
            {
                //aeih
                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                //else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                //         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                else
                {

                    // Increment the consonants
                    consonants++;
                }
            }

            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        

    }
    }
}
