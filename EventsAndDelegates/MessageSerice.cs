using System;

namespace EventsAndDelegates
{
    public class MessageSerice
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending text message..." + args.Video.Title);
        }
    }
}