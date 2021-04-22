using System;

public class Item{
  public string Nome;
  public int Preco;
  public string Categoria;
  public string Descricao;

  public Item(string Nome, int Preco, string Categoria, string Descricao){
    this.Nome = Nome;
    this.Preco = Preco;
    this.Categoria = Categoria;
    this.Descricao = Descricao;
  }

  public void InfoItem(){
    Console.WriteLine("Nome: {0}", this.Nome);
    Console.WriteLine("Preço: {0} moedas", this.Preco);
    Console.WriteLine("Categoria: {0}", this.Categoria);
    Console.WriteLine("Descrição: {0} \n", this.Descricao);
  }
}