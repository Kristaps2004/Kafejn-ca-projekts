using System;

public abstract class Cafe {

  //Dati par klientu - Data about client
  protected string name;
  public string Name
  {
    get {return name;}
  }
  protected string surname;
  public string Surname
  {
    get {return surname;}
  }
  protected int phone_nr;
  public int Phone_NR
  {
    get {return phone_nr;}
  }

  //Dati par ēdienkarti - Data about menu
  protected string food;
  public string Food
  {
    get {return food;}
  }
  protected string drinks;
  public string Drinks
  {
    get {return drinks;}
  }
  protected double price;
  public double Price
  {
    get {return price;}
  }
  protected int amount;
  public int Amount
  {
    get {return amount;}
  }

  //Dati par pasūtījumu - Data about order
  protected double total_price;
  public double Total_price
  {
    get {return total_price;}
  }
  protected int check_nr;
  public int Check_NR
  {
    get {return check_nr;}
  }
  protected int table_nr;
  public int Table_NR
  {
    get {return table_nr;}
  }
}