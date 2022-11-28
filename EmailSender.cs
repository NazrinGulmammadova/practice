namespace ConsoleApp18
{
    class EmailSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("must be sending with Email"); 
        }
    }
}
