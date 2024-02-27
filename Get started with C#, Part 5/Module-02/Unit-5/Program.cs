using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/5-exercise-use-named-optional-parameters
            // Exercise - Methods with optional parameters

            // Create an RSVP application
            string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
            string[] rsvps = new string[10];
            int count = 0;

            void RSVP(string name, int partySize, string allergies, bool inviteOnly)
            {
                if (inviteOnly)
                {
                    // search guestList before adding rsvp
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }
        }
    }
}
