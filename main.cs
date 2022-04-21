
using System;

class Program {

  Client client = new Client("", "", 1);
  //Menu menu = new Menu(1,"",1);
  
  static int Izvele(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
  }

  public void Banner(){
    Console.Clear();
    Console.WriteLine(@"
===================================================
        KAFEJNICAS PARVALDIBAS SISTEMA
===================================================");
  }

  public void Footer(){
    Console.WriteLine("____________________________________________________");
    Console.Write("Enter Your choice: ");
  }

  public void WrongInput(){
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.WriteLine("                                                    ");
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.Write("Choice not in range! Enter Your choice: ");
  }
  
  //Main menu
  public void Main(){
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
        Menu1();
          break;
      case 2:
        Menu2();
          break;
      case 3:
        Menu3();
          break;
      case 4:
        Menu4();
          break;
      case 5:
        Menu5();
          break;
      case 6:
        Menu6();
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
  public void Menu1(){
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
          client.ClientAdd();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //View Data Menu
  public void Menu2(){
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
          client.ClientView();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Delete Data Menu
  public void Menu3(){
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
          client.DeleteClientData();
          client.ClientView();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Search Data Menu
  public void Menu4(){
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
          client.SearchClientData();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Summary Menu
  public void Menu5(){
    Banner();
    Console.WriteLine(@"
Summary Menu:
- 1 - Summary Client
- 2 - Summary Menu
- 3 - Summary Order
- 4 - Back");
    Footer();
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          client.SummaryClientData();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          WrongInput();
					break;
      }
    }
  }

  //Sort Data Menu
  public void Menu6(){
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
          client.SortClientData();
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
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
    program.Main();
  }
}
