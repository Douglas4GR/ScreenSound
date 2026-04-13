Banda bandaMisfits = new Banda("Misfits");

Album albumDoMisfits = new Album("Famous Monters");

Musica musica1 = new Musica("Scream!", bandaMisfits, 300, true);
albumDoMisfits.AdicionarMusica(musica1);

Musica musica2 = new Musica("Helena", bandaMisfits, 410, false);
albumDoMisfits.AdicionarMusica(musica2);

bandaMisfits.AdicionarAlbum(albumDoMisfits);
bandaMisfits.ExibirDiscografia();