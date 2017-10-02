// {} ==> interpolação em C#
// int.Parse conversão para int
//System.Console.ReadLine() ==> pegando valor digitado
class App{
    public static void Main(string[] args){
        int num = int.Parse(System.Console.ReadLine());
        if(num == 10){
            System.Console.WriteLine("{0} é igual a 10", num);
        }else{
            System.Console.WriteLine("{0} não é igual 10", num);
        }

    }
}