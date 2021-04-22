using System;
using System.Collections.Generic;

public class Personagem{
  public string Nome;
  public int Saldo;
  public List<Item> Inventario = new List<Item>();

  public Personagem(string nome, int saldo){
    this.Nome = nome;
    this.Saldo = saldo;
  }

  public void InfoPersonagem(){
    Console.WriteLine("");
    Console.WriteLine("Informações de {0} \n", this.Nome);
    Console.WriteLine("Nome: {0}", this.Nome);
    Console.WriteLine("Saldo: {0} moedas", this.Saldo);
    Console.WriteLine("Inventário: ");
    foreach(var item in Inventario){
      Console.Write(item.Nome + " | ");
    }
    Console.WriteLine("");
  }

  public void Possui(Item item){
    this.Inventario.Add(item);
  }

  public void Coletar(Item item){
    this.Inventario.Add(item);
    Console.WriteLine("{0} coletou {1}! \n", this.Nome, item.Nome);
    item.InfoItem();
  }

  public void Comprar(Loja loja){
    Console.WriteLine("Seja bem-vindo(a) a {0}", loja.Nome);

    int e = 0;

    do{
      Console.WriteLine("Aqui está nosso catálogo: \n");
      loja.InfoCatalogo();

      Console.Write("Escreva o nome do produto que você deseja exatamente como está no catálogo: ");
      string i = Convert.ToString(Console.ReadLine());

      foreach(Item item in loja.Catalogo){

        if(i == item.Nome){
          if(this.Saldo >= item.Preco){
            Console.WriteLine("Confirmar compra? \n [1] Sim \n [2] Não");
            int confcompra = Convert.ToInt32(Console.ReadLine());
            
            if(confcompra == 1){
              this.Saldo = this.Saldo - item.Preco;
              this.Inventario.Add(item);
              //loja.Catalogo.Remove(item);
              Console.WriteLine("Compra concluída! \n");
            }
            else
              Console.WriteLine("Compra cancelada \n");
          }
          else
            Console.WriteLine("Saldo insuficiente \n");
        }
      }

      Console.WriteLine("Mais alguma coisa? \n [1] Sim \n [2] Não");
      e = Convert.ToInt32(Console.ReadLine());

      if(e == 2)
        Console.WriteLine("Até a próxima! Obrigado pela preferência!");

    }while (e != 2);
  }

  public void RoubarDinheiro(Personagem inimigo){
    this.Saldo = this.Saldo + inimigo.Saldo;
    Console.WriteLine("*{0} roubou {1} moedas de {2}* \n", this.Nome, inimigo.Saldo, inimigo.Nome);
    inimigo.Saldo = 0;
    Console.WriteLine("Saldo atual de {0}: {1} moedas \n", this.Nome, this.Saldo);
  }
}