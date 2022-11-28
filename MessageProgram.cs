using ConsoleApp18;
while(true)
{
    Console.WriteLine("menu: " + "1. Send message by email   " + "2. Send message by sms   " + "0. Quit");
    int processes=int.Parse(Console.ReadLine());
    if(processes == 1)
    {
        EmailSender EmailSender = new();
        EmailSender.SendMessage();
        break;
    }
    if(processes == 2)
    {
        SmsSender SmsSender = new();
        SmsSender.SendMessage();
        break;
    }
    if (processes == 0)
    {
        break;
    }
}