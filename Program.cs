using System;

namespace Akishev_Laboratorna_2
{   

    // Завдання 1
    class Person
    {
        public static int count = 0;
        public Person()
        {
            count++;
        }
        public static void GetInfo()
        {
            System.Console.WriteLine($"{count} objects were created");

        }

        // Завдання 2
        class User
        {
            public string id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string age { get; set; }

            public User(string ID, string Name, string Surname, string Age)
            {
                id = ID;
                name = Name;
                surname = Surname;
                age = Age;
            }


            // Завдання 3
            class Workman
            {
                public double sum { get; set; }
                public static double operator +(Workman salary, double bonus)
                {
                    return salary.sum + bonus;
                }
            }

            // Завдання 4
            class Personality
            {
                public string id { get; set; }
                public string name { get; set; }
                public string surname { get; set; }
                public string age { get; set; }

                public Personality(string Id, string Name, string Surname, string Age)
                {
                    id = Id;
                    name = Name;
                    surname = Surname;
                    age = Age;
                }
                public Personality()
                {
                    id = "0";
                    name = "DefaultName";
                    surname = "DefaultSurname";
                    age = "0";
                }
                public Personality(string ID, string NAME)
                {
                    id = ID;
                    name = NAME;
                    surname = "DefaultSurname";
                    age = "0";
                }
                public void GetInfo()
                {
                    Console.WriteLine($"Id: {id}; Name: {name}; Surname: {surname};  Age: {age}. ");
                }

                // Завдання 5

                class Users
                {
                    private static int id { get; } = 0;
                    private static string name { get; } = "John";
                    private static string surname { get; } = "Miller";
                    public static void GetUsersInfo()
                    {
                        System.Console.WriteLine($"User #{id} have name: {name}, and surname: {surname}");

                    }
                }

                // Завдання 6
                class Client
                {
                    public static string name { get; set; }
                    public static string surname { get; set; }
                    public static string card { get; set; }
                    public static string age { get; set; }
                    public static double order { get; set; }
                    public static bool salecard { get; set; }
                    public static void createBuy()
                    {
                        Console.Write($"Enter your name: ");
                        name = Console.ReadLine();
                        Console.Write($"Enter your surname: ");
                        surname = Console.ReadLine();
                        Console.Write($"Enter your card: ");
                        card = Console.ReadLine();
                        Console.Write($"Enter your age: ");
                        age = Console.ReadLine();
                        Console.Write($"Enter sum of your order: ");
                        order = double.Parse(Console.ReadLine());
                        Console.Write($"Do you have sale card?(+ or -): ");
                        string sales = Console.ReadLine();
                        if (sales == "+") { salecard = true; }
                        else { salecard = false; }

                    }
                    public static void getInfo()
                    {
                        Console.WriteLine($"Name: {name}; Surname: {surname};  Age: {age}; Card: {card}; Sum of the order {order} ");
                    }
                    public static void sale()
                    {
                        if (salecard == true)
                        {
                            order = order - (order * 0.08); // Знижка 8%
                        }
                    }

                }


                class Program
                {
                    static void Main(string[] args)
                    {
                        // Завдання 1
                        Console.WriteLine("Task 1");

                        Person Alex = new Person();
                        Person Peter = new Person();
                        Person John = new Person();
                        Person James = new Person();
                        Person Richard = new Person();
                        Person.GetInfo();

                        // Завдання 2
                        Console.WriteLine("Task 2");

                        bool c = true;
                        User Pet = new User("1", "Peter", "Smith", "25");
                        User Max = new User("2", "Max", "Jackson", "28");
                        User Jon = new User("3", "John", "Jones", "34");
                        User Ste = new User("4", "Stephen", "Miller", "25");

                        //
                        User[] arr = new User[4];
                        arr[0] = Pet;
                        arr[1] = Max;
                        arr[2] = Jon;
                        arr[3] = Ste;

                        string str_search = Console.ReadLine();
                        foreach (User u in arr)
                        {
                            if (u.id == str_search || u.name == str_search || u.surname == str_search || u.age == str_search)
                            {
                                c = false;
                                Console.WriteLine($"ID: {u.id}, Name: {u.name}, Surname: {u.surname}, Age: {u.age}");
                            }
                        }
                        if (c == true)
                        {
                            Console.WriteLine($"This user was not found.");
                        }
                        Console.WriteLine(" ");

                        // Завдання 3
                        Console.WriteLine("Task 3");

                        double bonus = 1000;
                        Workman salary = new Workman { sum = 12000 };
                        double result = salary + bonus;
                        Console.WriteLine($"Total salary: {result}$");
                        Console.WriteLine(" ");

                        // Завдання 4
                        Console.WriteLine("Task 4");

                        Personality Def = new Personality();
                        Personality Jos = new Personality("1", "Josh", "Jackson", "35");
                        Personality Jem = new Personality("2", "Jeremy");
                        
                        Def.GetInfo();
                        Jos.GetInfo();
                        Jem.GetInfo();
                        Console.WriteLine(" ");

                        // Завдання 5
                        Console.WriteLine("Task 5");


                        Users sam = new Users();
                        Users.GetUsersInfo();
                        Console.WriteLine(" ");

                        // Завдання 6
                        Console.WriteLine("Task 6");

                        Client obj = new Client();
                        Client.createBuy();
                        Client.sale();
                        Client.getInfo();



                    }
                }
            }
        }
    }
}


