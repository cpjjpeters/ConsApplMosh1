using System;

namespace EventsAndDelegates
{
    partial class Program
    {
        public class MailService
        {
            public void OnVideoEncoded(object source, EventArgs e)
            {
                Console.WriteLine("Mailservice: sending an email...");
            }
        }
    }
}