using System;
using System.Collections.Generic;

public class Loja{
  public string Nome;
  public string Localidade;
  public List<Item> Catalogo;

  public Loja(string nome, string localidade){
    this.Nome = nome;
    this.Localidade = localidade;
    this.Catalogo = new List<Item>();
  }

  public void AdicionarCat(Item item){
    this.Catalogo.Add(item);
  }

  public void InfoCatalogo(){
    foreach(var item in Catalogo){
      item.InfoItem();
    }
  }

  public void CompraLoja(Personagem p){
    Console.WriteLine("Seja bem-vindo(a) a {0}", loja.Nome);

    int e = 0;

    do{
      Console.WriteLine("Aqui está nosso catálogo: \n");
      loja.InfoCatalogo();

      Console.Write("Escreva o nome do produto que você deseja conforme está no catálogo: ");
      string i = Convert.ToString(Console.ReadLine());

      p.ComprarItem();

      Console.WriteLine("Mais alguma coisa? \n [1] Sim \n [2] Não");
      e = Convert.ToInt32(Console.ReadLine());

      if(e == 2)
        Console.WriteLine("Até a próxima! Obrigado pela preferência!");

    }while (e != 2);
  }
}