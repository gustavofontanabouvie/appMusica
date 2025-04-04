class Genero
{
    public string Nome { get; set; }

    public List<Artista> artistasAssociados = new List<Artista>();
    public Genero(string nome)
    {
        Nome = nome;
    }
}