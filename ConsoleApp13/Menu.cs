using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;


namespace ConsoleApp13.UserInterface
{
    class Menu
    {
        public void MenuRun()
        {
            Controller c = new Controller();
            bool runningBool = true;
            while (runningBool)
            {
                Console.Clear();
                Console.WriteLine("Press 1 to enter pet into database");
                Console.WriteLine("Press 2 to Show all pets");
                Console.WriteLine("Press 3 to insert an Owner");
                Console.WriteLine("Press 4 to find an owner by last name");
                Console.WriteLine("Press 5 to find an owner by email");
                Console.WriteLine("Press 6 to get pet info by entering owner ID");
                string MenuString = Console.ReadLine();

                switch (MenuString)
                {
                    case "1":
                        c.InsertPet();
                        break;
                    case "2":
                        c.ShowPets();
                        break;
                    case "3":
                        c.ShowPets();
                        break;
                    case "4":
                        c.SearchByOwnerLastName();
                        break;
                    case "5":
                        c.SearchByOwnerEmail();
                            break;
                    case "6":
                        c.SearchOwnerPetInfoByOwnerID();
                        break;

                }

            }

        }

    }
}

