Music musicOne = new Music();

musicOne.title = "Yesterday";
musicOne.artist = "The Beatles";
musicOne.genre = "Rock";
musicOne.album = "Help!";
musicOne.year = 1965;
musicOne.duration = 123;
musicOne.active = true;

Console.WriteLine($"{musicOne.title} - {musicOne.artist}");
Console.WriteLine($"{musicOne.album} ({musicOne.year}) - {musicOne.genre}");
Console.WriteLine($"{musicOne.duration} segundos");

if (musicOne.active)
{
    Console.WriteLine("Ativa");
}
else
{
    Console.WriteLine("Inativa");
}