using System;

class Program {
  
  static int Izvele(){
    while (true){
      try {
        int number = Convert.ToInt32(Console.ReadLine());
        return number; 
      }
      catch {
        Cafe.WrongInput();
      }
    }
  }

  public static void WrongInput(){
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.WriteLine("                                                                      ");
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.Write("Choice not in range! Enter Your choice: ");
  }

  public static void Banner(){
    Console.Clear();
    Console.WriteLine(@"
===================================================
        KAFEJNICAS PARVALDIBAS SISTEMA
===================================================");
  }

  public static void Footer(){
    Console.WriteLine("____________________________________________________");
    Console.Write("Enter Your choice: ");
  }
  
  //Main menu
  public static void MainMenu(){
    Banner();
    Console.WriteLine(@"
Main Menu:
- 1 - Add data
- 2 - View data
- 3 - Delete data
- 4 - Search data
- 5 - Summary
- 6 - Sort
- 7 - Exit");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
      case 1:
        Program.Menu1();
          break;
      case 2:
        Program.Menu2();
          break;
      case 3:
        Program.Menu3();
          break;
      case 4:
        Program.Menu4();
          break;
      case 5:
        Program.Menu5();
          break;
      case 6:
        Program.Menu6();
          break;
      case 7:
        Environment.Exit(0);
          break;
      default:
          success = false;
          WrongInput();
					break;
      }
    }
  }
  
  //Add Data Menu
  public static void Menu1(){
    Banner();
    Console.WriteLine(@"
Add Data Menu:
- 1 - Client
- 2 - Menu
- 3 - Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Client.ClientAdd();
          MainMenu();
            break;
        case 2:
          Menu.MenuAdd();
          MainMenu();
            break;
        case 3:
          Order.OrderAdd();
          MainMenu();
            break;
        case 4:
          MainMenu();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //View Data Menu
  public static void Menu2(){
    Banner();
    Console.WriteLine(@"
View Data Menu:
- 1 - View Client
- 2 - View Menu
- 3 - View Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Client.ClientView();
          MainMenu();
            break;
        case 2:
          Menu.MenuView();
          MainMenu();
            break;
        case 3:
          Order.OrderView();
          MainMenu();
            break;
        case 4:
          MainMenu();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Delete Data Menu
  public static void Menu3(){
    Banner();
    Console.WriteLine(@"
Delete Data Menu:
- 1 - Delete Client
- 2 - Delete Menu
- 3 - Delete Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Client.DeleteClientData();
          Client.ClientView();
          MainMenu();
            break;
        case 2:
          Menu.DeleteMenuData();
          Menu.MenuView();
          MainMenu();
            break;
        case 3:
          Order.DeleteOrderData();
          Order.OrderView();
          MainMenu();
            break;
        case 4:
          MainMenu();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Search Data Menu
  public static void Menu4(){
    Banner();
    Console.WriteLine(@"
Search Data Menu:
- 1 - Search Client
- 2 - Search Menu
- 3 - Search Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Client.SearchClientData();
          MainMenu();
            break;
        case 2:
          Menu.SearchMenuData();
          MainMenu();
            break;
        case 3:
          Order.SearchOrderData();
          MainMenu();
            break;
        case 4:
         MainMenu();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Summary Menu 
  public static void Menu5(){
    Summary.Info();
  }

  //Sort Data Menu
  public static void Menu6(){
    Banner();
    Console.WriteLine(@"
Sort Data Menu:
- 1 - Sort Client
- 2 - Sort Menu
- 3 - Sort Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Client.SortClientData();
          MainMenu();
            break;
        case 2:
          Menu.SortMenuData();
          MainMenu();
            break;
        case 3:
          Order.SortOrderData();
          MainMenu();
            break;
        case 4:
          MainMenu();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }
  public static void Main (string[] args){
    Program program = new Program();
    Program.MainMenu();
  }
}