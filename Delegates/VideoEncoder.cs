public class VideoEncoder
{
    //define a delegate
    public delegate void VideoEncodedEventHandler(object source, EventArgs args);


    //define an event based on the delegate
    public event VideoEncodedEventHandler VideoEncoded;

    //public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }

    //raise the event
    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            VideoEncoded(this, new VideoEventArgs() {Video = video});
    }
}