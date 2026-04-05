class Program
{
    static void Main(string[] args)
        {
        SayaMusicTrack music_track = new SayaMusicTrack("fortnite battlepass");

        music_track.IncreasePlayCount(1);
        music_track.PrintTrackDetails();
        }

    }
