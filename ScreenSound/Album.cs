class Album
{
    private List<Music> musics = new List<Music>();
    public string Title { get; set; }
    public string Artist { get; set; }
    public Genre Genre { get; set; }
    public int Year { get; set; }
    public string Duration
    {
        get
        {
            int durationInSeconds = musics.Sum(music => music.Duration);
            
            return $"{durationInSeconds / 60}:{(durationInSeconds % 60).ToString("D2")}";

            /*
                Formatação "D2"
                O método ToString("D2") formata o número como um inteiro com pelo menos dois dígitos.
                Se o número for menor que 10, ele será preenchido com um zero à esquerda.
            */
        }
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumInfo()
    {
        Console.WriteLine("Informações do Álbum");
        Console.WriteLine($"Nome: {Title}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Gênero: {Genre.Title}");
        Console.WriteLine($"Duração: {Duration}");
        Console.WriteLine("Faixas:");

        foreach (Music music in musics)
        {
            Console.WriteLine($"- {music.Title} - {music.DurationInMinutes}");
        }
    }
}