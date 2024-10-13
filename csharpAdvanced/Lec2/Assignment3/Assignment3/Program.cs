namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();


            mediaPlayer.Media = new Audio();
            mediaPlayer.Play();
            mediaPlayer.Stop();

            mediaPlayer.Media = new Video();
            mediaPlayer.Play();
            mediaPlayer.Stop();
        }
    }
}
