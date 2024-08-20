Genre genreOne = new Genre();

genreOne.Title = "Rock";

Music musicOne = new Music();

musicOne.Title = "Yesterday";
musicOne.Artist = "The Beatles";
musicOne.Genre = genreOne;
musicOne.Duration = 123;
musicOne.Active = true;

Music musicTwo = new Music();

musicTwo.Title = "Ticket To Ride";
musicTwo.Artist = "The Beatles";
musicTwo.Genre = genreOne;
musicTwo.Duration = 190;
musicTwo.Active = true;

Album albumOne = new Album();

albumOne.Title = "Help!";
albumOne.Artist = "The Beatles";
albumOne.Genre = genreOne;
albumOne.Year = 1965;

albumOne.AddMusic(musicOne);
albumOne.AddMusic(musicTwo);

albumOne.ShowAlbumInfo();