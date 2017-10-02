public class App{
    
    public static int __fn2(int num, int num2){
        return num + num2;
    }
    
    public static void __fn(int num, int num2){
        System.Console.WriteLine("a soma dos numeros: {0} + {1} é: {2}", num, num2, (num + num2));
    }

    public static void fn(){
        System.Console.WriteLine("Hello!");
    }
    
    public static void Main(string[] args){
        fn();
        __fn(5, 5);
        System.Console.WriteLine("a soma dos numeros: {0} + {1} é: {2}", 5, 6, __fn2(5, 6));
    }
}