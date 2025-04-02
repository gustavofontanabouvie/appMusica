//Musica
class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição resumida: {DescricaoResumida}");
        if (Disponivel)
        {
            Console.WriteLine("A musica esta disponivel");
        }
        else
        {
            Console.WriteLine("A musica não esta disponivel");
        }
    }
};