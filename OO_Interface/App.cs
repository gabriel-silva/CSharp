interface View1{
    void interface1();
}

interface View2{
    void interface2();
}

//implementação de duas interfaces
public class App : View1, View2{
    
    void View1.interface1(){
        System.Console.WriteLine("Interface view1!");        
    }

    void View2.interface2(){
        System.Console.WriteLine("Interface View2!");
    }


    public static void Main(string[] args){
        View1 view1 = new App();
        view1.interface1();

        View2 view2 = new App();
        view2.interface2();
    }
}