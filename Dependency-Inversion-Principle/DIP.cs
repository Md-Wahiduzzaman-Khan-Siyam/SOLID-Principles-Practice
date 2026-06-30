// High level module should not depend on low level module

using System;

class DIP
{
    public interface IMessageService
    {
        void send();
    }
    
    // concrete class or low level module
    public class EmailService : IMessageService
    {
        public void send()
        {
            Console.WriteLine("Email sent");
        }
    }
    public class SmsService : IMessageService
    {
        public void send()
        {
            Console.WriteLine("Sms sent");
        }
    }
    
    // business logic class or high level module
    public class NotificationService
    {
        IMessageService _messageService;

        public NotificationService(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Notify()
        {
            _messageService.send();
        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SmsService smsService = new SmsService();
            emailService.send();
            smsService.send();
        }
    }
}