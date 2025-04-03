Album albumGuns = new Album("Appetite for destruction");
Banda gunsNroses  = new ("Guns N Roses");

Musica musica1 = new Musica(gunsNroses, "Welcome to the jungle")
{
    Duracao = 273,
    Disponivel = true,
};

Musica musica2 = new Musica(gunsNroses, "Paradise City")
{
    Duracao = 406,
    Disponivel = false
};

albumGuns.AddMusica(musica1);
albumGuns.AddMusica(musica2);
gunsNroses.AdicionarAlbum(albumGuns);



musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumGuns.ListarMusicasDoAlbum();
gunsNroses.ListarAlbuns();