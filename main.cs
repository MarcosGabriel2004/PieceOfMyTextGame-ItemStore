using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

  Menu();





  }

  //Estruturas

  public static void Menu(){
    //Título do jogo (The Paladin) em ASCII

    linha("|''||''| '||               '||'''|,         '||`             ||`               ");
    linha("   ||     ||                ||   ||          ||              ||   ''           ");
    linha("   ||     ||''|, .|''|,     ||...|'  '''|.   ||   '''|.  .|''||   ||  `||''|,  ");
    linha("   ||     ||  || ||..||     ||      .|''||   ||  .|''||  ||  ||   ||   ||  ||  ");
    linha("  .||.   .||  || `|...     .||      `|..||. .||. `|..||. `|..||. .||. .||  ||. ");

    plinha("A Game made by Marcos Gabriel");



    linha("Iniciar");
    linha("Opções");
    plinha("Encerrar");

  }

  //Funções

  

  //Funções para agilizar a digitação

  public static void plinha(string line){
    Console.WriteLine(line + "\n");
  }
  public static void linha(string line){
    Console.WriteLine(line);
  }
  public static void mlinha(string line){
    Console.Write(line);
  }
}

