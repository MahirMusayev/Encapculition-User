namespace User_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("mAhir   ", "   mUsayev", "mahir123");
            user.ChangePassword("mahir123", "musayev123");

            Console.WriteLine(user.UserName);
        }
    }
}
