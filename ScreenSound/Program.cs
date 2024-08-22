// Artistas

Artist artistOne = new Artist("The Beatles");

// Gêneros

Genre genreOne = new Genre("Rock");

// Músicas

Music musicOne = new Music("Yesterday", artistOne, genreOne, 123, true);
Music musicTwo = new Music("Ticket To Ride", artistOne, genreOne, 190, true);
Music musicThree = new Music("Let It Be", artistOne, genreOne, 243, true);
Music musicFour = new Music("Come Together", artistOne, genreOne, 259, true);

// Álbuns

Album albumOne = new Album("Help!", artistOne, genreOne, 1965);
Album albumTwo = new Album("Let It Be", artistOne, genreOne, 1970);
Album albumThree = new Album("Abbey Road", artistOne, genreOne, 1969);

// Músicas X Álbuns

albumOne.AddMusic(musicOne);
albumOne.AddMusic(musicTwo);

albumTwo.AddMusic(musicThree);

albumThree.AddMusic(musicFour);

// Artistas X Álbuns

artistOne.AddAlbum(albumOne);
artistOne.AddAlbum(albumTwo);
artistOne.AddAlbum(albumThree);

// Informações de Álbuns

albumOne.ShowAlbumInfo();
albumTwo.ShowAlbumInfo();
albumThree.ShowAlbumInfo();

// Discografia do Artista

artistOne.ShowAlbuns();