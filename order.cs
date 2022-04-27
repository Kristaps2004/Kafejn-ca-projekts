using System;
using System.IO;

public class Order : Cafe{
  public int Food;
  public double Total_price;

  public Order(int food, double total_price){
    this.Food = food;
    this.Total_price = total_price;
  }
  
  //Datu pievienošana
  public void OrderAdd(){
    Console.Clear();

    string path = @"txt/Order.txt";

    Console.Write("Food's ID: ");
    int Food = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Total price: ");
    //double Total_price = Convert.ToDouble(Console.ReadLine());

    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Food}\n{Total_price}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  int ID_order(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }

  //Datu apskate
  public void OrderView(){
    Console.Clear();
    string path = @"txt/Order.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      if (1 > ID_order(path)){
        Console.WriteLine($"No Data to View!");
      }
      else{
        for(int i = 1; i <= ID_order(path) / 2; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Food: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Total price: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
    }
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }

  //Delete Data
  public void DeleteOrderData(){
    Console.Clear();

    string tempFile = Path.GetTempFileName();
    string path = @"txt/Order.txt";
    if (1 > ID_order(path)){
      Console.WriteLine($"No Data to delete!");
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
    else{
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
        for(int i = 1; i <= ID_order(path) / 2; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Food: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Total price: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
      Console.Write("Enter ID of order you want to remove: ");
      int number = Izvele();
      int obj = 1 + (2*(number-1));
      Console.WriteLine(obj);
      int line_number = 0;
      string line;
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default))
      using(StreamWriter streamWriter = new StreamWriter(tempFile)){
        while((line = streamreader.ReadLine()) != null) {
          line_number++;
          if (line_number < obj || line_number > obj+1){
            streamWriter.WriteLine(line);
          }
        }
      }
      File.Delete("txt/Order.txt");
      File.Move(tempFile, "txt/Order.txt");
    }
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