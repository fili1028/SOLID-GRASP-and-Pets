using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToDataBase;

namespace Application
{
    class Controller
    {
            DatabaseSearchCommands d = new DatabaseSearchCommands();
            Pet P = new Pet();
            PetOwner O = new PetOwner();
       public void InsertPet()
        {

                        Console.WriteLine("Insert Pet Name");
                        P.PetName = Console.ReadLine();
                        Console.WriteLine("Insert Pet Type");
                        P.PetType = Console.ReadLine();
                        Console.WriteLine("Insert Breed");
                        P.PetBreed = Console.ReadLine();
                        Console.WriteLine("Insert PetDOB");
                        P.PetDOB = Console.ReadLine();
                        Console.WriteLine("Insert Pet Weight");
                        P.PetWeight = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insert OwnerID");
                        P.OwnerID = Int32.Parse(Console.ReadLine());
                        d.InsertPet(P);
        }
        public void ShowPets()
        {
                        d.ShowPets();
        }
        public void InsertOwner()
        {
                        Console.WriteLine("Insert Owner Last Name");
                        O.OwnerLastName = Console.ReadLine();
                        Console.WriteLine("Insert Owner First Name");
                        O.OwnerFirstName = Console.ReadLine();
                        Console.WriteLine("Insert Owner Phone");
                        O.OwnerPhone = Console.ReadLine();
                        Console.WriteLine("Insert Owner Email");
                        O.OwnerEmail = Console.ReadLine();
                        d.InsertOwner(O);

        }
        public void SearchByOwnerLastName()
        {
                        Console.WriteLine("Insert owner Last Name");
                        O.OwnerLastName = Console.ReadLine();
                        d.SearchByOwnerLastName(O);
                        
        }
        public void SearchByOwnerEmail()
        {
                        Console.WriteLine("Insert owner Email");
                        O.OwnerEmail = Console.ReadLine();
                        d.SearchOwnerByEmail(O);
        }
        public SearchOwnerPetInfoByOwnerID()
        {
                        Console.WriteLine("Insert owner ID");
                        O.OwnerID = int.Parse(Console.ReadLine());
                        d.SearchOwnerPetInfoByOwnerID(O);
        }
                        break;

                }

            }

        }
    }
}
