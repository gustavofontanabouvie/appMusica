﻿
class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public Album(string nome)
    {
        Nome=nome;
    }

    public string Nome {  get; }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);
    public void AddMusica(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }
    public void ListarMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}: \n");
        foreach (var musica in listaDeMusicas)
        {
        Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nEste album tem {DuracaoTotal} segundos");
    }
}