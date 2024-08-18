class Music
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
    public int Year { get; set; }
    public int Duration { get; set; }

    public bool Active { get; set; }

    public string DurationInMinutes
    {
        get
        {
            return $"{Duration / 60}:{(Duration % 60).ToString("D2")}";
            
            /*
                Formatação "D2"
                O método ToString("D2") formata o número como um inteiro com pelo menos dois dígitos.
                Se o número for menor que 10, ele será preenchido com um zero à esquerda.
            */
        }
    }

    public string Status => Active ? "Ativa" : "Inativa";

    public void ShowMusicInfo()
    {
        Console.WriteLine($"{Title} - {Artist}");
        Console.WriteLine($"{Album} - {Year} - {Genre}");
        Console.WriteLine($"{DurationInMinutes} - {Status}");
    }
}