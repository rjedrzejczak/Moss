namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var emailService = new EmailService(); //subscriber
            var messageService = new MessageSerice(); //subscriber

            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}