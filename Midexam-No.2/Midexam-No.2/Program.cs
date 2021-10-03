using System;

namespace TestMidTerm_02
{
    enum first_page
    {
        Login = 1,
        Register
    }
    enum User_Type
    {
        Student = 1,
        Employee
    }
    enum Student
    {
        Borrowbook = 1
    }
    enum Employee
    {
        ShowStockBook = 1
    }
    enum detailofbooks
    {
        Now_I_understand = 1,
        Revolutionary_Wealth,
        Six_Degrees,
        Les_Vacances
    }
    class Program
    {
        static void Main(string[] args)
        {
            firstPage();
            MenuScreen();
        }
        static void firstPage()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.Write("Select Menu : ");
        }
        static void ShowRegister()
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("--------------------");
        }

        static void ShowEmployee()
        {
            Console.Write("Employee ID : ");
        }
        public static User_Type user_type()
        {
            User_Type user_type = (User_Type)(int.Parse(Console.ReadLine()));
            return user_type;
        }
        static void Input_User_Type()
        {
            Console.Write("Input name : ");
            string Name = Console.ReadLine();
            Console.Write("Input Password : ");
            string Password = Console.ReadLine();
            Console.Write("Input User Type : ");
            Console.Write("Input ID : ");
            string ID = Console.ReadLine();
            Register register = new Register(Name, Password, user_type(), ID);
        }

        static void MenuScreen()
        {
            first_page firstpage = (first_page)(int.Parse(Console.ReadLine()));
            PresentMenu(firstpage);
        }
        static void PresentMenu(first_page frist_page)
        {
            if (frist_page == first_page.Login)
            {

            }
            else if (frist_page == first_page.Register)
            {
                if (frist_page == first_page.Login)
                {

                }
                else if (frist_page == first_page.Register)
                {
                    ShowRegister();//register
                    Input_User_Type(); //name&password&type
                }
        }
    }
    class Register
    {
        public string name;
        public string password;
        public User_Type user_type;
        public string id;
        public Register(string Name, string Password, User_Type UserType, string ID)
        {
            this.name = Name;
            this.password = Password;
            this.user_type = UserType;
            this.id = ID;
        }
    }
}