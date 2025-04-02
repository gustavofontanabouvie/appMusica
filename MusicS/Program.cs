Album albumGuns = new Album();

albumGuns.Nome = "Appetite for destruction";

Musica musica1 = new Musica();
musica1.Nome = "Welcome to the jungle";
musica1.Duracao = 273;

Musica musica2 = new Musica();
musica2.Nome = "Paradise City";
musica2.Duracao = 406;

albumGuns.AddMusica(musica1);
albumGuns.AddMusica(musica2);

albumGuns.ListarMusicasDoAlbum();