using System;
using System.IO;

public class Order{
  public string Name;
  public string Surname;
  public int Phone_nr;

  public Order(string name, string surname, int phone_nr){
    this.Name = name;
    this.Surname = surname;
    this.Phone_nr = phone_nr;
  }

  public void OrderAdd(){
    Console.Clear();

  }
 
  public void OrderView(){
    Console.Clear();

  }

  //Delete Data
  public void DeleteOrderData(){
    Console.Clear();

  }
  
  //Search Data
  public void SearchOrderData(){
    Console.Clear();

  }
    
  //Summary
    
  public void SummaryOrderData(){
    Console.Clear();
    
  }
  //Sort

  public void SortOrderData(){
    Console.Clear();
    
  }
}