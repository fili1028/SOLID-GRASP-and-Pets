using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectToDataBase
{
    public class DatabaseSearchCommands
    {

        private static string connectionString =
            "Server=EALSQL1.eal.local; Database= DB2017_C08; User Id=USER_C08; Password=SesamLukOp_08";


        public void InsertPet(Pet pet)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertPet", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@PetName", pet.PetName));
                    cmd1.Parameters.Add(new SqlParameter("@PetType", pet.PetType));
                    cmd1.Parameters.Add(new SqlParameter("@PetBreed", pet.PetBreed));
                    cmd1.Parameters.Add(new SqlParameter("@PetDOB", pet.PetDOB));
                    cmd1.Parameters.Add(new SqlParameter("@PetWeight", pet.PetWeight));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerID", pet.OwnerID));

                    cmd1.ExecuteNonQuery();

                }
                catch (SqlException e)
                {

                    Console.WriteLine(e);
                }

            }
        }
        public void InsertOwner(PetOwner owner)

        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("spInsertOwner", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@OwnerLastName", owner.OwnerLastName));
                    cmd2.Parameters.Add(new SqlParameter("@OwnerFirstName", owner.OwnerFirstName));
                    cmd2.Parameters.Add(new SqlParameter("@OwnerPhone", owner.OwnerPhone));
                    cmd2.Parameters.Add(new SqlParameter("@OwnerEmail", owner.OwnerEmail));

                    cmd2.ExecuteNonQuery();

                }
                catch (SqlException e)
                {

                    Console.WriteLine(e);
                }

            }
        }
        public void ShowPets()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("spGetPets", con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd3.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string PetID = reader["PetID"].ToString();
                            string PetName = reader["PetName"].ToString();
                            string PetType = reader["PetType"].ToString();
                            string PetBreed = reader["PetBreed"].ToString();
                            string PetDOB = reader["PetDOB"].ToString();
                            string PetWeight = reader["PetWeight"].ToString();
                            string OwnerID = reader["OwnerID"].ToString();
                            Console.WriteLine(PetID + " " + PetName + " " + PetType + " " + PetBreed + " " + PetDOB + " " + PetWeight + " " + OwnerID);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine(e);
                }

            }
        }
        public void SearchByOwnerLastName(PetOwner owner)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("spGetOwnerByLastName", con);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.Add(new SqlParameter("@OwnerLastName", owner.OwnerLastName));
                    SqlDataReader reader = cmd4.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string OwnerLastName = reader["OwnerLastName"].ToString();
                            string OwnerFirstName = reader["OwnerFirstName"].ToString();
                            string OwnerPhone = reader["OwnerPhone"].ToString();
                            string OwnerEmail = reader["OwnerEmail"].ToString();

                            Console.WriteLine(OwnerLastName + " " + OwnerFirstName + " " + OwnerPhone + " " + OwnerEmail);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine(e);
                }


            }



        }
        public void SearchOwnerByEmail(PetOwner owner)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd5 = new SqlCommand("spGetOwnerByEmail", con);
                    cmd5.CommandType = CommandType.StoredProcedure;
                    cmd5.Parameters.Add(new SqlParameter("@OwnerEmail", owner.OwnerEmail));
                    SqlDataReader reader = cmd5.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string OwnerLastName = reader["OwnerLastName"].ToString();
                            string OwnerFirstName = reader["OwnerFirstName"].ToString();
                            string OwnerPhone = reader["OwnerPhone"].ToString();
                            string OwnerEmail = reader["OwnerEmail"].ToString();

                            Console.WriteLine(OwnerLastName + " " + OwnerFirstName + " " + OwnerPhone + " " + OwnerEmail);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine(e);
                }


            }



        }
        public void SearchOwnerPetInfoByOwnerID(PetOwner owner)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd6 = new SqlCommand("spGetOwnerPetInfoByID", con);
                    cmd6.CommandType = CommandType.StoredProcedure;
                    cmd6.Parameters.Add(new SqlParameter("@OwnerID", owner.OwnerID));
                    SqlDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string OwnerName = reader["OwnerName"].ToString();
                            
                            string PetName = reader["PetName"].ToString();
                            string PetType = reader["PetType"].ToString();
                            string PetBreed = reader["PetBreed"].ToString();
                            string PetAverageLifeExpectancy= reader["AverageLifeExpectancy"].ToString();

                            Console.WriteLine(OwnerName + " " + PetName + " " + PetType + " " + PetBreed + " " + PetAverageLifeExpectancy);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine(e);
                }


            }



        }

    }
}
