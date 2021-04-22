using System;
using System.Collections.Generic;

public class Personagem{
  public string Nome;
  public int Saldo = 15;
  public List<Item> Inventario = new List<Item>();

  public void InfoPersonagem(){
    Console.WriteLine("Nome: {0}", this.Nome);
    Console.WriteLine("Saldo: {0} moedas", this.Saldo);
    Console.WriteLine("Inventário: ");
    foreach(var item in Inventario){
      Console.Write(item.Nome + " | ");
    }
  }

  public void Coletar(Item item){
    this.Inventario.Add(item);
  }

  public void Comprar(Item item){
    Console.WriteLine("Confirmar compra? \n [1] Sim \n [2] Não");
    int confcompra = Convert.ToInt32(Console.ReadLine());

    if(confcompra == 1){
      if(this.Saldo >= item.Preco){
        this.Saldo = this.Saldo - item.Preco;
        this.Coletar(item);
      }
      else{
        Console.WriteLine("Saldo insuficiente");
      }
    }
    else{
      Console.WriteLine("Compra cancelada");
    }
  }
}