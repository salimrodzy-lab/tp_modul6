class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack music_track = new SayaMusicTrack("fortnite battlepass");
        SayaMusicTrack music_track0 = new SayaMusicTrack("");

        for (int i = 0; i < 220; i++)
        {
            music_track.IncreasePlayCount(10000000);
            music_track.PrintTrackDetails();
        }

    } 
}
