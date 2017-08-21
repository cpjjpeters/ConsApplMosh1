namespace EventsAndDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "New vid 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber 2

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            // just comment
            //more comment

        }
    }
}
