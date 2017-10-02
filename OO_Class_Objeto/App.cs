public class Carro{
    public string marca;
    public string modelo;
}
public class App{
    public static void Main(string[] args){
        Carro c = new Carro();
        System.Console.WriteLine("Informe a marca do carro: ");
        c.marca = System.Console.ReadLine();
        System.Console.WriteLine("Informe o modelo do carro: ");
        c.modelo = System.Console.ReadLine();
        System.Console.WriteLine("Marca: {0} e Modelo: {1} do carro.", c.marca, c.modelo);

    }
}