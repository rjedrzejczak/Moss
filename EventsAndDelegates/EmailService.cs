using System;

namespace EventsAndDelegates
{
    public class EmailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending email..." + e.Video.Title); 
        }
    }
}