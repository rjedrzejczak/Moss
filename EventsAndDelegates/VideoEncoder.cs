using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define delegate
        // 2 - define event based on that delegate
        // 3 - raise the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // above commented because we added public event EventHandler<VideoEventArgs> VideoEncoded;
        
        // EventHandler
        // EventHandler<TEventArgs>

        // public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding vide...");
            Thread.Sleep(1000);
            
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}