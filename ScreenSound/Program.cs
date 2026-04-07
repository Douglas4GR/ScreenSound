Album albumDoMisfits = new Album();
albumDoMisfits.Nome = "Famous Monsters";

Musica musica1 = new Musica();
musica1.nome = "Scream";
musica1.artista = "Misfits";
musica1.duracao = 180;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "Astro Zombies";
musica2.artista = "Misfits";
musica2.duracao = 210;
musica2.disponivel = false;

albumDoMisfits.AdicionarMusica(musica1);
albumDoMisfits.AdicionarMusica(musica2);