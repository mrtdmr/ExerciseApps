using System;
using System.Threading;

namespace Events
{
    class Program
    {
        // A mechanism for communication between objects. Tell when call another object.
        // Used in building loosely coupled apps.
        // Helps extending apps.
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncode(video);
        }
    }
    class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending and email..." + e.Video.Title);
        }
    }
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending and email..." + e.Video.Title);
        }
    }
    class Video
    {
        public string Title { get; set; }
    }
    class VideoEncoder
    {
        // 1- Define a delegate to tell subscrbler method ended.
        // 2- Define an event based on that delegate
        // 3- Raise the event
        //public delegate void VideoEncodedEventHander(object source, EventArgs args);
        //public delegate void VideoEncodedEventHander(object source, VideoEventArgs args);

        //public event VideoEncodedEventHander VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; // Delegate tanımlamaya gerek yok

        public void VideoEncode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            //VideoEncoded?.Invoke(this, EventArgs.Empty); // VideoEncoded? kontrolü subscrible olup olmadığını kontror eder.
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
