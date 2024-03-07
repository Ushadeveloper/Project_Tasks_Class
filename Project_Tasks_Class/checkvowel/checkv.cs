using System;

namespace Project_Tasks_Class.checkvowel
{
    class checkv
    {
        public void checkvnc()
        {
            try
            {
                Console.WriteLine("Input a Character = ");
                char ch = Convert.ToChar(Console.ReadLine().ToLower());

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("Character is Vowel.");
                }
                else if ((ch >= '0') && (ch <= '9'))
                {
                    Console.WriteLine("Characteer is Digit");
                }
                else
                {
                    Console.WriteLine("Any Symbol");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Symbolvowel()
        {
            try
            {
                int n = 1;
                
                while (n > 0)
                    
                {
                    char ch;  // Declaration of a character variable to store the input

                    Console.Write("\n\n");  // Printing new lines
                    Console.Write("check whether the input alphabet is a vowel or not:\n");  // Displaying the purpose of the program
                    Console.Write("-----------------------------------------------------");  // Displaying a separator
                    Console.Write("\n\n");

                    Console.Write("Input an Alphabet (A-Z or a-z) : ");  // Prompting user to input an alphabet
                    ch = Convert.ToChar(Console.ReadLine().ToLower());  // Reading the input and converting it to lowercase

                    int i = ch;  // Converting the character to its corresponding ASCII value

                    if (i >= 48 && i <= 57)  // Checking if the input is a number
                    {
                        Console.Write("You entered a number, Please enter an alphabet.");  // Prompting user to enter an alphabet
                    }
                    else
                    {
                        switch (ch)  // Switch statement to check for vowels
                        {
                            case 'a':
                                Console.WriteLine("The Alphabet is vowel");  // Printing a message if 'a' is entered
                                break;
                            case 'i':
                                Console.WriteLine("The Alphabet is vowel");  // Printing a message if 'i' is entered
                                break;
                            case 'o':
                                Console.WriteLine("The Alphabet is vowel");  // Printing a message if 'o' is entered
                                break;
                            case 'u':
                                Console.WriteLine("The Alphabet is vowel");  // Printing a message if 'u' is entered
                                break;
                            case 'e':
                                Console.WriteLine("The Alphabet is vowel");  // Printing a message if 'e' is entered
                                break;
                            default:
                                Console.WriteLine("The Alphabet is not a vowel");  // Printing a message for non-vowel characters
                                break;
                        }
                    }

                    Console.WriteLine("Do you Want to run again (y/n) : ");
                    string st = Console.ReadLine();
                    if (st == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
