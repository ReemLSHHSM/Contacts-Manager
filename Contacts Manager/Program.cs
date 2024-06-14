namespace Contacts_Manager
{
    public class Program
    {

        static List<Tuple<string, string>> contacts = new List<Tuple<string, string>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Contacts, you could do the following servecis, please choose one \n");

            ContactsManager();

            Console.WriteLine("Thank you for using our Contact manager ;)");

        }


        //ContactsManager
        public static void ContactsManager()
        {

            string answer = "yes";
            string name = "";
            string number = "";

            while (answer.ToLower() != "no")
            {
                Console.WriteLine("What service would you like to have? \n");
                Console.WriteLine("1-Add contact \t 2-Remove contact \t 3-View all contacts \t 4-Search contact \n\n write the first word of the service you wish to have to confirm \n");

                string service = Console.ReadLine();
                if (service.ToLower() == "add" || service.ToLower() == "remove" || service.ToLower() == "view" || service.ToLower() == "search")
                {
                    if (service.ToLower() == "add")
                    {
                        Console.WriteLine("Please enter the Name of the contact and the number! \n");

                        name = "";
                        number = "";

                        while (true)
                        {
                            Console.WriteLine("Enter contacts name: \n");
                            name = Console.ReadLine();
                            bool name_checker = Int32.TryParse(name, out int name_output);

                            if (name.Length < 2 || name_checker == true)
                            {
                                Console.WriteLine("Please make sure the name is more than 2 letters and that it's valid.\n");
                                continue;
                            }

                            Console.WriteLine("Enter contacts number: \n");
                            number = Console.ReadLine();
                            bool number_checker = Int64.TryParse(number, out long number_output);

                            if (number.Length != 10 || number_checker == false)
                            {
                                Console.WriteLine("Please make sure the number is 10 digits and that it's valid.\n");
                                continue;
                            }

                            break;
                        }

                        AddContact(name, number);
                    }
                    else if (service.ToLower() == "remove")
                    {
                        name = "";

                        while (true)
                        {
                            Console.WriteLine("Enter contacts name: \n");
                            name = Console.ReadLine();
                            bool name_checker = Int32.TryParse(name, out int name_output);

                            if (name.Length < 2 || name_checker == true)
                            {
                                Console.WriteLine("Please make sure the name is more than 2 letters and that it's valid.\n");
                                continue;
                            }

                            break;
                        }

                        RemoveContact(name);
                    }


                    else if (service.ToLower() == "search")
                    {
                        Searchcontact(name);
                    }

                    else if (service.ToLower() == "view")
                    {
                        ViewAllContacts();
                    }

                }//------>big if 

                else
                {
                    Console.WriteLine("Sorry, we don't provide this service at the moment. :(\n");
                }

                Console.WriteLine("Would you like to have another service? (yes/no)\n");
                answer = Console.ReadLine();
            }
        }

        //Add Contact
        public static string AddContact(string name, string number)
        {
            bool check_name = contacts.Any(tuple =>  //this line checks if name exists

                tuple.Item1 == name
            );

            bool check_number = contacts.Any(tuple =>  //this line checks if number exists
            tuple.Item2 == number);

            if (check_name == true)
            {

                Console.WriteLine("Contact already exist! \n");
                return "Contact already exist!";//added return for testing
            }
            else
            {
                contacts.Add(Tuple.Create(name, number));  //this line adds a tuple to a list
                Console.WriteLine($"Contact {name} added successfully :) \n");
                return $"Contact {name} added successfully :)";//added return for testing
            }

            return "";
        }

        //Remove
        public static string RemoveContact(string name)
        {

            bool check_name = contacts.Any(tuple =>
            tuple.Item1 == name);

            if (check_name == true)
            {
                var contact = contacts.Where(tuple => //this line looks for tuple based on one of the items
                tuple.Item1 == name);

                contacts.RemoveAll(tuple =>
                 tuple.Item1 == name);
                Console.WriteLine("Contact removed successfully :| \n");
                return "Contact removed successfully :|";
            }

            else
            {
                Console.WriteLine("Contact does not exist :/ \n");
                return "Contact does not exist :/";
            }

            return "";
        }

        public static List<Tuple<string, string>> ViewAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("You dont have any contacts go to the Add service to add some \n");
            }
            else
            {
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine($"Name: {contacts[i].Item1}, Number: {contacts[i].Item2} \n");
                }
            }
            return contacts;

        }

        //Search
        public static List<Tuple<string, string>> Searchcontact(string name)
        {
            Console.WriteLine("Write the name of the contact you're looking for \n");
            name = Console.ReadLine();
            bool check_name = contacts.Any(tuple =>  //this line checks if number exists
            tuple.Item1 == name);
            if (check_name == true)
            {
                var contact = contacts.FirstOrDefault(tuple => tuple.Item1 == name);//this line returns the first match 
                Console.WriteLine($"The contact you're looking for is here {contact.Item1} {contact.Item2} \n");
            }
            else
            {
                Console.WriteLine("Sorry, the contact you're looking for does'nt exist :( \n");
            }


            return contacts;
        }
    }
}
