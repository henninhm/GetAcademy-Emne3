namespace Klasser2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            //var k = new PrintWelcomeMessage();
            //k();
            p.PrintWelcomeMessage();

        }

        public string Message = "Hei og velkommen";

        //public void PrintWelcomeMessage()
        //{
        //    Console.WriteLine(Message);
        //}

        public void PrintWelcomeMessage(string message = "Du er snill!")
        {
            Message += ". ";
            Message += message;
            Console.WriteLine(Message);
        }
    }
}
