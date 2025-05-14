using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IMusicPlayer
{
    public void Play(string song);

    public void Pause();

    public void Stop();

}

class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"playing {song} on spotify");
    }

    public void Pause()
    {
        Console.WriteLine("spotify playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}

class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"playing {song} on Apple Music Player");
    }

    public void Pause()
    {
        Console.WriteLine(" Apple Music Player playback paused");
    }

    public void Stop()
    {
        Console.WriteLine(" Apple Music Player playback stopped");
    }
}

class Program

{
    static void Main()
    {
        IMusicPlayer player;

        player = new SpotifyPlayer();
        player.Play("Na Na Hyrana");
        player.Pause();
        player.Stop();

        Console.WriteLine();

        player = new AppleMusicPlayer();
        player.Play("Panja Title track");
        player.Pause();
        player.Stop();
    }


}