using System;
using System.Diagnostics;

public class SayaMusicTrack
{
	int id;
	int playCount;
	string title;
	public SayaMusicTrack(string title)
	{
        Debug.Assert(title != null, "Precondition gagal: Judul track tidak boleh null.");
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(10000, 100000);
		this.playCount = 0;

    }

	public void IncreasePlayCount(int count)
	{
        Debug.Assert(count <= 10000000, "Precondition gagal: Input penambahan maksimal 10.000.000 per pemanggilan.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("\n[Exception Caught]: Penambahan play count gagal karena melebihi batas maksimum integer (Overflow)!");
        }
	}
    public void PrintTrackDetails()
    {
		Console.WriteLine("title: " + this.title + "\n id: " + this.id + "\nplay count: " + this.playCount);
    }
}

