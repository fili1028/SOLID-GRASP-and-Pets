using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;


namespace UserInterface
{
    class Menu
    {
        public void MenuRun()
        {
            Controller c = new Controller();
            bool runningBool = true;
            //DatabaseSearchCommands d = new DatabaseSearchCommands();
            //Pet P = new Pet();
            //PetOwner O = new PetOwner();


            while (runningBool)
            {
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
                       
                        break;
                    case "2":
                        d.ShowPets();
                        break;
                    case "3":
                        Console.WriteLine("Insert Owner Last Name");
                        O.OwnerLastName = Console.ReadLine();
                        Console.WriteLine("Insert Owner First Name");
                        O.OwnerFirstName = Console.ReadLine();
                        Console.WriteLine("Insert Owner Phone");
                        O.OwnerPhone = Console.ReadLine();
                        Console.WriteLine("Insert Owner Email");
                        O.OwnerEmail = Console.ReadLine();
                        d.InsertOwner(O);
                        break;
                    case "4":
                        Console.WriteLine("Insert owner Last Name");
                        O.OwnerLastName = Console.ReadLine();
                        d.SearchByOwnerLastName(O);
                        break;
                    case "5":
                        Console.WriteLine("Insert owner Email");
                        O.OwnerEmail = Console.ReadLine();
                        d.SearchOwnerByEmail(O);

                        break;
                    case "6":
                        Console.WriteLine("Insert owner ID");
                        O.OwnerID = int.Parse(Console.ReadLine());
                        d.SearchOwnerPetInfoByOwnerID(O);
                        break;

                }

            }

        }

    }
}

