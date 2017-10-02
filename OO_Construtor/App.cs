public class Carro{
    private string marca;
    private string modelo;
    private int ano;

    public Carro(string marca, string modelo, int ano){
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    public Carro(string marca, string modelo){
        this.marca = marca;
        this.modelo = modelo;
    }

    public void imprimir(){
        System.Console.WriteLine("Marca: {0}, Modelo: {1}", this.marca, this.modelo);
    }

    public void _imprimir(){
        System.Console.WriteLine("Marca: {0}, Modelo: {1}, Ano: {2}", this.marca, this.modelo, this.ano);
    }   

}

public class App{
    public static void Main(string[] args){
        Carro c = new Carro("Honda", "Civic");
        c.imprimir();
        Carro c2 = new Carro("Honda", "Civic", 2017);
        c2._imprimir();
    }
}