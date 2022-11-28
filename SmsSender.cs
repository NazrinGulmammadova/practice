namespace ConsoleApp18
{
    class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("must be sending with SMS");
        }
    }
}
