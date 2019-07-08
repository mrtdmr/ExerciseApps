using System;
using System.Threading;

namespace Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder();
            MessageService messageService = new MessageService();
            videoEncoder.VideoEncoded = messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
    class MessageService
    {
        public void OnVideoEncoded(object sender,VideoEventArgs e)
        {
            Console.WriteLine($"{e.Video.Title} encoded...");
        }
    }
    class VideoEncoder
    {
        public EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        public void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
    class Video
    {
        public string Title { get; set; }
    }
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
