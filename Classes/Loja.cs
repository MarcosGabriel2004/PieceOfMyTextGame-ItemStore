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
}