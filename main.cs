using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    //Personagem

    Personagem paladino = new Personagem();

    //Loja

    Loja Dimitrescu = new Loja("Dimitrescu's", "Província de Dimitrescu");

    //Itens

    Item ElixirCura = new Item("Elixir de cura", 5, "Poção", "Revigorante. Esta poção cura 15 HP.");
    Item ElixirDano = new Item("Elixir de dano", 10, "Poção", "Torne-se ainda mais poderoso. Esta poção que dobra o dano de qualquer ataque por 3 rodadas.");
    Item EspadaVibora = new Item("Espada da Víbora", 45, "Arma corpo-a-corpo", "Corte traiçoeiro, como o bote de uma víbora. Envenene seus inimigos atacados por 2 rodadas (2 pontos de dano por rodada)");
    Item EspadaDragao = new Item("Espada do Dragão", 60, "Arma corpo-a-corpo", "Feroz e bela, como um dragão. Dê 3 pontos de dano extra na próxima rodada ao queimar o inimigo.");
    Item ArcoHárpia = new Item("Arco da Hárpia", 35, "Arma de longo alcance", "Imponente e gracioso, como uma grande hárpia. Deixe seu arco potencializar ao máximo o poder de sua flecha com mais 50% de chance de um dano crítico");
    Item MachadoBehemoth = new Item("Machado do Behemoth", 75, "Arma corpo-a-corpo", "Forte e bestial, como um behemoth. Com essa arma pesada, seu dano geral aumenta em 75%, mas a velocidade de ataque diminui 50%.");
    Item EspadaFerro = new Item("Espada de Ferro", 20, "Arma corpo-a-corpo", "Afiada, porém simples.");
    Item EscudoAngelical = new Item("Escudo Angelical", 55, "Escudo", "Como um anjo da guarda, este escudo absorve 50% de qualquerataque inimigo.");
    Item Broquel = new Item("Broquel", 30, "Escudo", "Protege seu usuário, mas pode ser usada para um contra-ataque rápido.");
    Item EscudoCavaleiro = new Item("Escudo do Cavaleiro", 15, "Escudo", "Útil, porém não oferece proteção de qualidade.");

    //Início

    Console.WriteLine("|''||''| '||               '||'''|,         '||`             ||`               ");
    Console.WriteLine("   ||     ||                ||   ||          ||              ||   ''           ");
    Console.WriteLine("   ||     ||''|, .|''|,     ||...|'  '''|.   ||   '''|.  .|''||   ||  `||''|,  ");
    Console.WriteLine("   ||     ||  || ||..||     ||      .|''||   ||  .|''||  ||  ||   ||   ||  ||  ");
    Console.WriteLine("  .||.   .||  || `|...     .||      `|..||. .||. `|..||. `|..||. .||. .||  ||. ");

    Console.WriteLine("A Game made by Marcos Gabriel");

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("*O paladino desperta de seu profundo sono em meio a uma taverna*");
    Console.WriteLine("*Há uma grande confusão ocorrendo ao redor. O que causou isso?*");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Guarda Real: Ei, você aí! Qual o seu nome?");

    Console.Write("Insira o nome do seu personagem: ");
    paladino.Nome = Convert.ToString(Console.ReadLine());

    Console.WriteLine("{0}, né? Então, venha comigo. É você mesmo que estão procurando...", paladino.Nome);



    Console.ReadKey();
  }
}

