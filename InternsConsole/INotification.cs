using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsConsole
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }

}
