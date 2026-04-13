class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }
    public Album(string nome)
    {
        Nome = nome;
    }
    public void AdicionarMusica(Musica musica)
    {
        if (musicas == null)
        {
            musicas.Add(musica);
        }

        Console.WriteLine($"Música '{musica.Nome}' adicionada ao álbum '{Nome}'.");
    }
}