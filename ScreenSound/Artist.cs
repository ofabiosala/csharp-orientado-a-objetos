class Artist
{
    public Artist(string title)
    {
        Title = title;
    }

    private List<Album> albuns = new List<Album>();
    public string Title { get; set; }

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ShowAlbuns()
    {
        Console.WriteLine($"Discografia - {Title}");

        foreach (Album album in albuns)
        {
            Console.WriteLine($"- {album.Title}");
        }

    }
}