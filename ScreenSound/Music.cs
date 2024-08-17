class Music
{
    public string title;
    public string artist;
    public string genre;
    public string album;
    public int year;
    public int duration;
    private bool active;

    public bool getActive()
    {
        return active;
    }

    public void setActive(bool value)
    {
        active = value;
    }
    public void ShowMusicInfo()
    {
        Console.WriteLine($"{title} - {artist}");
        Console.WriteLine($"{album} ({year}) - {genre}");
        Console.WriteLine($"{duration} segundos");

        if (getActive())
        {
            Console.WriteLine("Ativa");
        }
        else
        {
            Console.WriteLine("Inativa");
        }
    }
}