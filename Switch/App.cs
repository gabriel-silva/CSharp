using System;

class App{
    public static void Main(string[] args){

        System.Console.WriteLine("Informe um número: ");
        int num = int.Parse(System.Console.ReadLine());
        switch(num){
            case 10:
                System.Console.WriteLine("{0} é igual a 10", num);
            break;
            case 20:
                System.Console.WriteLine("{0} é igual a 20", num);
            break;
            default :
                System.Console.WriteLine("{0} não é igual a nenhuma das opções", num);
            break;
        }
    }
}