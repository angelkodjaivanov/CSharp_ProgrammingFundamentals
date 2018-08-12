using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                string licensePlate = "";
                if (input[0] == "register") {
                    licensePlate = input[2];
                }
                string userName = input[1];
                bool weHaveUser = false;
                bool weHavePlate = false;

                if (input[0] == "register")
                {
                    if (Plate(licensePlate))
                    {
                        foreach (var user in users.Keys)
                        {
                            if (user == userName)
                            {
                                weHaveUser = true;
                            }
                            if (users[user] == licensePlate)
                            {
                                
                                weHavePlate = true;
                            }
                        }

                        if ( weHaveUser)
                        {
                            Console.WriteLine("ERROR: already registered with plate number {0}", users[userName]);
                        }
                        else if ( weHavePlate )
                        {
                            Console.WriteLine("ERROR: license plate {0} is busy", licensePlate);
                        }
                        else
                        {
                            Console.WriteLine("{0} registered {1} successfully", userName, licensePlate);
                            users[userName] = licensePlate;
                        }

                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", licensePlate);
                    }
                }
                else if (input[0] == "unregister")
                {
                    foreach (var user in users.Keys)
                    {
                        if (user == userName)
                        {
                            weHaveUser = true;
                        }
                    }
                    if (weHaveUser)
                    {
                        Console.WriteLine("user {0} unregistered successfully", userName);
                        users.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found", userName);
                    }
                }

            }

            foreach (var user in users.Keys)
            {
                Console.WriteLine("{0} => {1}", user, users[user]);
            }


        }

        static bool Plate(string plate)
        {
            bool works = false;

            if (plate.Length == 8 && plate[0] >= 65 && plate[0] <= 90 && plate[1] >= 65 && plate[1] <= 90 
                && plate[plate.Length - 1] >= 65 && plate[plate.Length - 1] <= 90 && plate[plate.Length - 2] >= 65 && plate[plate.Length - 2] <= 90
                && plate[2] >= 48 && plate[2] <= 57 && plate[3] >= 48 && plate[3] <= 57 
                && plate[4] >= 48 && plate[4] <= 57 && plate[5] >= 48 && plate[5] <= 57)
            {
                works = true;
            }

            return works;
        }
    }
}
