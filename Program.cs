using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  string firstName = "Hope";
              int lengthOfName = firstName.Length;
              Console.WriteLine(firstName);
              Console.WriteLine(lengthOfName);

              //string myFaveQuote=


              //  string escapeString = 



              Console.WriteLine("User one, please type something");

              string userOneInput = Console.ReadLine();
              Console.WriteLine("User two, please type something");
              string userTwoInput = Console.ReadLine();

              if(userOneInput == userTwoInput)
              {

                  Console.WriteLine("asdfas");
              }
              else
              {
                  Console.WriteLine("dwhalfhdsalk");
              }

              if (userOneInput.Equals (userTwoInput))
              {

                  Console.WriteLine("asdfas");
              }
              else
              {
                  Console.WriteLine("dwhalfhdsalk");
              }

              string startOfSentence = "My best friends's name is";
              string endOfSentence = "Bethany.";
              string fullSentence = string.Concat(startOfSentence, endOfSentence);

              // string fullSentence = startOfSentence + endOfSentence;
              // Console.WriteLine(fullSentence);

              Console.WriteLine("My friend" + endOfSentence + "has a cute kid.");
              Console.WriteLine("My friend {0} has a cute kid.", endOfSentence); 
           //   "The first part of my sentence was {0}, the second was {1}, and the third was {2}",startOfSentence,endOfSentence,fullSentence;

              Console.WriteLine(startOfSentence + endOfSentence);
              Console.WriteLine("My best friend's name is " + "Bethany");
              Console.Write(startOfSentence);
              Console.Write(endOfSentence); */


           // Find the length of your first name and print it.
            string myFirstName = "Hope";
            //int lengthOfName = myFirstName.Length;
            Console.WriteLine(myFirstName.Length);

            //Find the length of your last name and print it.
            string myLastName = "Love";
            // int lengthOfLast = myLastName.Length;
            Console.WriteLine(myLastName);


            //If the first name is longer than the last name, print "First is longer."
            //comparing .lengths

            if (myFirstName.Length > myLastName.Length)
            {

                Console.WriteLine("First Name is longer");
            }

            //  If the first name and last name are the same length, print "Samsis!"

            else if (myFirstName.Length.Equals(myLastName.Length))
            {
                Console.WriteLine("Samsis!");
            }



        }
    }
}
