//Tāāāātad es sāku domāt par mūsu tēmu/ darbu, saratu ka izvēlējāmies tādu huiņu, nespēju piebraukt kāpēc mums tādi mainīgie ir vispar, kada jega no viņiem un kapec viņus. 
// Liels liels mess lūgums pārdomāt visu, jo vienīga lieta kas ir normali ir klients.
//Karantina
/*using System;
using System.IO;
using System.Collections.Generic;

public class Menu{
  public int ID_menu = 0;
  public string Food_name;
  public double Price;
  
  public Menu(int id_menu, string food_name, double price){
    this.ID_menu = id_menu;
    this.Food_name = food_name;
    this.Price = price;
  }

  //Datu pievienošana
  public void MenuPievienosana(){
    Console.Clear();
    ID_menu = ID_menu + 1;
    Console.Write("Name of the food: ");
    Food_name = Console.ReadLine();
    Console.Write("Price: ");
    Price = Convert.ToDouble(Console.ReadLine());

    string path = "Menu.dat";

    Menu[] menus = {
      new Menu(ID_menu, Food_name, Price)
    };

    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append))){
      foreach (Menu menu in menus){
        writer.Write(menu.ID_menu);
        writer.Write(menu.Food_name);
        writer.Write(menu.Price);
        writer.Write(Environment.NewLine);
      }
      Console.WriteLine("Succes! Press any key to continue!");
      Console.ReadKey();
    }
  }
}*/