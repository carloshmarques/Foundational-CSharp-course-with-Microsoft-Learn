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


            RSVP("Rebecca");
            RSVP("Nadia", 2, "Nuts");
            RSVP(name: "Linh", partySize: 2, inviteOnly: false);
            RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
            RSVP("Noor", 4, inviteOnly: false);
            RSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVPs();


            // Declare optional parameters
            //void RSVP(string name, int partySize, string allergies, bool inviteOnly)
            void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
            {
                if (inviteOnly)
                {
                    // search guestList before adding rsvp
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
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

            /*
             * Recap
                Here's what you've learned about optional and named arguments so far:

                Parameters are made optional by setting a default value in the method signature.
                Named arguments are specified with the parameter name, followed by a colon and the argument value.
                When combining named and positional arguments, you must use the correct order of parameters.
             */
        }
    }
}
