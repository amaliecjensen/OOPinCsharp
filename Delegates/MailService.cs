public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        System.Console.WriteLine("mailservice sending an email" + e.Video);
        
    }
}