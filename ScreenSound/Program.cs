Banda bandaMisfits = new Banda();
bandaMisfits.Nome = "Misfits";

Album albumDoMisfits = new Album();
albumDoMisfits.Nome = "Famous Monsters";

Musica musica1 = new Musica("Scream!", bandaMisfits, 3, true);
albumDoMisfits.AdicionarMusica(musica1);

Musica musica2 = new Musica("Helena", bandaMisfits, 4, true);
albumDoMisfits.AdicionarMusica(musica2);

bandaMisfits.AdicionarAlbum(albumDoMisfits);
bandaMisfits.ExibirDiscografia();