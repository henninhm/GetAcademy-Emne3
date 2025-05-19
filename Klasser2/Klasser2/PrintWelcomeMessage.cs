namespace Klasser2
{
    internal class PrintWelcomeMessage
    {
        public string Message = "Hei og velkommen";

        public PrintWelcomeMessage()
        {
            Console.WriteLine(Message);
        }

        public PrintWelcomeMessage(string message = "Du er snill!")
        {
            Message += ". ";
            Message += message;
            Console.WriteLine(Message);
        }
    }
}
