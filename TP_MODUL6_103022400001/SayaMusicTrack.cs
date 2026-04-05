using System;

public class SayaMusicTrack
{
	int id;
	int playCount;
	string title;
	public SayaMusicTrack(string title)
	{
		this.title = title;
        Random rand = new Random();
        this.id = rand.Next(10000, 100000);
		this.playCount = 0;

    }

	public void IncreasePlayCount(int count)
	{
		this.playCount += count;
	}
    public void PrintTrackDetails()
    {
		Console.WriteLine("title: " + this.title + "\n id: " + this.id + "\nplay count: " + this.playCount);
    }
}

