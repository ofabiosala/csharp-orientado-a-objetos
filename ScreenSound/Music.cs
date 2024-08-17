class Music
{
    public string title;
    public string artist;
    public string genre;
    public string album;
    public int year;
    public int duration;
    public bool Active { get; set; }

    public void ShowMusicInfo()
    {
        Console.WriteLine($"{title} - {artist}");
        Console.WriteLine($"{album} ({year}) - {genre}");
        Console.WriteLine($"{duration} segundos");

        if (Active)
        {
            Console.WriteLine("Ativa");
        }
        else
        {
            Console.WriteLine("Inativa");
        }
    }
}