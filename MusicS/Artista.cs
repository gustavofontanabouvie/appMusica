class Artista
{
    public string Nome { get; }
    private List<Album> albuns = new List<Album>();

    public Artista(string nome)
    {
        Nome = nome;
    }
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ListarAlbuns()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome}(Duração: {album.DuracaoTotal})");
        }
    }
}