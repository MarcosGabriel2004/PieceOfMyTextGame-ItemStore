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

  public void InfoCatalogo(Item item){
    foreach(var Item in Catalogo){
      Console.WriteLine(item.Nome);
    }
  }
}