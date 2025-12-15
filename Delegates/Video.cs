public class Video
{
    private string Title;
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder(); //publisher
        var mailService = new MailService(); //subscriber 
        var messageservice = new MessageService(); //subscriber 



        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageservice.OnVideoEncoded;
        
        videoEncoder.Encode(video);
    }

}


