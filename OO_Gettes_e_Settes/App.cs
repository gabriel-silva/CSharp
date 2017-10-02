public class Carro{
    
    // //1 ==> forma
    // private string marca;
    // private string modelo;
    // private int ano;

    // public void setMarca(string marca){
    //     this.marca = marca;
    // }

    // public void setModelo(string modelo){
    //     this.modelo = modelo;
    // }

    // public void setAno(int ano){
    //     this.ano = ano;
    // }

    // public string getMarca(){
    //     return this.marca;
    // }

    // public string getModelo(){
    //     return this.modelo;
    // }

    // public int getAno(){
    //     return this.ano;
    // }

    //2 ==> forma
    private string marca;
    private string modelo;
    private int ano;

    public string Marca{
        set{
            marca = value;
        }
        get{
            return marca;
        }
    }

    public string Modelo{
        set{
            modelo = value;
        }
        get{
            return modelo;
        }
    }

    public int Ano{
        set{
            ano = value;
        }
        get{
            return ano;
        }
    }


}

public class App{
    public static void Main(string[] args){
        
        Carro c = new Carro();
        c.Marca = "Honda";
        c.Modelo = "Civic";
        c.Ano = 2017;

        System.Console.WriteLine(""+ c.Marca);
        System.Console.WriteLine(""+c.Modelo);
        System.Console.WriteLine(""+c.Ano);

    }
}