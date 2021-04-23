using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    //Itens

    Item ElixirCura = new Item("Elixir de cura", 5, "Poção", "Revigorante. Esta poção cura 15 HP.");
    Item ElixirDano = new Item("Elixir de dano", 10, "Poção", "Torne-se ainda mais poderoso. Esta poção que dobra o dano de qualquer ataque por 3 rodadas.");
    Item EspadaVibora = new Item("Espada da Víbora", 45, "Arma corpo-a-corpo", "Corte traiçoeiro, como o bote de uma víbora. Envenene seus inimigos atacados por 2 rodadas (2 pontos de dano por rodada)");
    Item EspadaDragao = new Item("Espada do Dragão", 60, "Arma corpo-a-corpo", "Feroz e bela, como um dragão. Dê 3 pontos de dano extra na próxima rodada ao queimar o inimigo.");
    Item ArcoHarpia = new Item("Arco da Hárpia", 35, "Arma de longo alcance", "Imponente e gracioso, como uma grande hárpia. Deixe seu arco potencializar ao máximo o poder de sua flecha com mais 50% de chance de um dano crítico");
    Item MachadoBehemoth = new Item("Machado do Behemoth", 75, "Arma corpo-a-corpo", "Forte e bestial, como um behemoth. Com essa arma pesada, seu dano geral aumenta em 75%, mas a velocidade de ataque diminui 50%.");
    Item EspadaFerro = new Item("Espada de Ferro", 20, "Arma corpo-a-corpo", "Afiada, porém simples.");
    Item EscudoAngelical = new Item("Escudo Angelical", 55, "Escudo", "Como um anjo da guarda, este escudo absorve 50% de qualquerataque inimigo.");
    Item Broquel = new Item("Broquel", 30, "Escudo", "Protege seu usuário, mas pode ser usada para um contra-ataque rápido.");
    Item EscudoCavaleiro = new Item("Escudo do Cavaleiro", 15, "Escudo", "Útil, porém não oferece proteção de qualidade.");

    //Personagem

    Personagem paladino = new Personagem("Paladino", 15);
    Personagem guarda1 = new Personagem("General Constanze", 45);

    guarda1.Possui(EspadaFerro);
    guarda1.Possui(ElixirCura);

    //Loja

    Loja Dimitrescu = new Loja("Dimitrescu's", "Província de Dimitrescu");
    Dimitrescu.AdicionarCat(ElixirCura);
    Dimitrescu.AdicionarCat(ElixirDano);
    Dimitrescu.AdicionarCat(EspadaVibora);
    Dimitrescu.AdicionarCat(EspadaDragao);
    Dimitrescu.AdicionarCat(ArcoHarpia);
    Dimitrescu.AdicionarCat(EspadaFerro);
    Dimitrescu.AdicionarCat(MachadoBehemoth);
    Dimitrescu.AdicionarCat(EscudoAngelical);
    Dimitrescu.AdicionarCat(Broquel);
    Dimitrescu.AdicionarCat(EscudoCavaleiro);

    //Início

    Console.WriteLine("|''||''| '||               '||'''|,         '||`             ||`               ");
    Console.WriteLine("   ||     ||                ||   ||          ||              ||   ''           ");
    Console.WriteLine("   ||     ||''|, .|''|,     ||...|'  '''|.   ||   '''|.  .|''||   ||  `||''|,  ");
    Console.WriteLine("   ||     ||  || ||..||     ||      .|''||   ||  .|''||  ||  ||   ||   ||  ||  ");
    Console.WriteLine("  .||.   .||  || `|...     .||      `|..||. .||. `|..||. `|..||. .||. .||  ||. ");

    Console.WriteLine("A game made by Marcos Gabriel (in development...)");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("*O paladino desperta de seu profundo sono em meio a uma taverna* \n");
    Console.WriteLine("*Há uma grande confusão ocorrendo ao redor. O que causou isso?*");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Guarda Real: Ei, você aí! Qual o seu nome? \n");

    Console.Write("Insira o nome do seu personagem: ");
    paladino.Nome = Convert.ToString(Console.ReadLine());
    paladino.InfoPersonagem();

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("{0}: {1}, né? Então, venha comigo. É você mesmo que estão procurando. \n", guarda1.Nome, paladino.Nome);
    Console.WriteLine("{0}: Para onde vocês acham que vão me levar? Já não trabalho mais para eles... \n", paladino.Nome);
    Console.WriteLine("{0}: Você acha que tem escolha?", guarda1.Nome);

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("*Na rua* \n");
    Console.WriteLine("{0}: Posso passar na Dimitrescu's bem rápido? Preciso de alguns equipamentos. \n", paladino.Nome);
    Console.WriteLine("{0}: Pra quê? \n", guarda1.Nome);
    Console.WriteLine("{0}: Nunca se sabe... \n", paladino.Nome);
    paladino.RoubarDinheiro(guarda1);
    Console.WriteLine("{0}: Ei! Volte aqui com meu dinheiro agora! Ainda bem que não levou meu elixir...", guarda1.Nome);
    guarda1.InfoPersonagem();

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("*Na loja* \n");

    paladino.InfoPersonagem();
    paladino.Comprar(Dimitrescu);
    paladino.InfoPersonagem();

    Console.WriteLine("A história de {0} continua... \nAguarde para mais informações sobre o desenvolvimento do jogo!", paladino.Nome);
  }
}