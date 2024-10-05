public class Program{

//funcion que se invoca a si misma 
public static void recursiva1(int veces, String mensaje){
        if(veces>9)
            return; //rompe la funcion 
    Console.WriteLine(mensaje);
    recursiva1(++veces,mensaje);
}

public static int factorial(int numero){
        if(numero==1)
            return 1;
    return numero*factorial(--numero); //7*
}
    public static void Main(string[] args) {
        int veces =0;
        String mensaje ="Hola mundo";
        //recursiva1(veces,mensaje);
        int numero=0;
        Console.WriteLine("ingresa el numero para el factorial");
        numero =  int.Parse(Console.ReadLine());
        Console.WriteLine(factorial(numero));
    }
}
