using Core.Services;

namespace Core
{
    internal class Homepage
    {
        private readonly IAuth _rep;

        public Homepage(IAuth rep)
        {
            _rep = rep;
        }

        public void Run ()
        {
            Console.WriteLine("Welcome to Gavic Microfinance Bank");
           
            Console.WriteLine("Press 1 to Register");
            

            Console.WriteLine("Press 2 to Login");
            Console.WriteLine("Press 3 to exit");

            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
                _rep.SignUp();
                //var rep = new Auth();
                //rep.SignUp();
            }
            else if (Choice == "2")
            {
                _rep.Login();
            }
            else if (Choice == "3")
            {
                Environment.Exit(0);    
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have entered an invalid Message");
                Console.ReadKey();  
                Run();
            }
        }
    }
}
