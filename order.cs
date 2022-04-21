//Tāāāātad es sāku domāt par mūsu tēmu/ darbu, saratu ka izvēlējāmies tādu huiņu, nespēju piebraukt kāpēc mums tādi mainīgie ir vispar, kada jega no viņiem un kapec viņus. 
// Liels liels mess lūgums pārdomāt visu, jo vienīga lieta kas ir normali ir klients.

/*using System;
using System.IO;
using System.Collections.Generic;

public class Order{
  public int ID_order = 0;
  public string Food_name;
  public double Price;
  
  public Order(int id_order, string food_name, double price){
    this.ID_order = id_order;
    this.Food_name = food_name;
    this.Price = price;
  }

  //Datu pievienošana
  public void MenuPievienosana(){
    Console.Clear();
    ID_order = ID_order + 1;
    Console.Write("Name of the food: ");
    Food_name = Console.ReadLine();
    Console.Write("Price: ");
    Price = Convert.ToDouble(Console.ReadLine());

    string path = "Menu.dat";

    Order[] orders = {
      new Order(ID_order, Food_name, Price)
    };

    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append))){
      foreach (Order order in orders){
        writer.Write(order.ID_order);
        writer.Write(order.Food_name);
        writer.Write(order.Price);
        writer.Write(Environment.NewLine);
      }
      Console.WriteLine("Succes! Press any key to continue!");
      Console.ReadKey();
    }
  }
}*/