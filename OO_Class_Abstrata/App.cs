public abstract class Carro{
    abstract public void imprimir();
}

public class App : Carro{
    
    public override void imprimir(){
        System.Console.WriteLine("Hello");
    }

    public static void Main(string[] args){
        App p = new App();
        p.imprimir();
        
    }

}