Album albumGuns = new Album("Appetite for destruction");
Artista gunsNroses  = new ("Guns N Roses");
Genero rock = new Genero("Rock");

Musica musica1 = new Musica(gunsNroses, "Welcome to the jungle",rock)
{
    Duracao = 273,
    Disponivel = true,
};

Musica musica2 = new Musica(gunsNroses, "Paradise City", rock)
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

Console.WriteLine("\n");

Podcast podcast1 = new Podcast("Gustavo","PodcastTeste");

Episodios episodio5 = new Episodios(2.44, 5 ,"Podcast de teste5",podcast1);
Episodios episodio1 = new Episodios(2.75, 1,"podcast de teste1",podcast1);

podcast1.AdicionarEpisodio(episodio5);
podcast1.AdicionarEpisodio(episodio1);

podcast1.ExibirDetalhes();

episodio5.AdicionarConvidado("Silvio Santos");
episodio5.AdicionarConvidado("Camile");
episodio5.AdicionarConvidado("Gustavo");


Console.WriteLine(episodio5.Resumo); 