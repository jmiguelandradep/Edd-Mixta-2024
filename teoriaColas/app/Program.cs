public class Program{

    public static void Main(string[] args){
        int van=0;
        String nombre;
        cola COLA=new cola();
        Console.WriteLine("Nombre");
        nombre = Console.ReadLine();
        COLA.agregar(new nodo(van++,nombre));
        Console.WriteLine("Nombre");
        nombre = Console.ReadLine();
        COLA.agregar(new nodo(van++,nombre));
        Console.WriteLine("Nombre");
        nombre = Console.ReadLine();
        COLA.agregar(new nodo(van++,nombre));
        Console.WriteLine("Nombre");
        nombre = Console.ReadLine();
        COLA.agregar(new nodo(van++,nombre));
        COLA.recorrer();
        Console.ReadLine();
        COLA.extraer();COLA.extraer();
        Console.ReadKey();
        Console.Clear();
        COLA.recorrer();
        Console.ReadLine();
        Console.WriteLine("Nombre a buscar");
        nombre = Console.ReadLine();
        COLA.buscar(new nodo(-1,nombre));
        Console.ReadLine();
        Console.WriteLine("Nombre a buscar");
        nombre = Console.ReadLine();
        COLA.buscar(new nodo(-1,nombre));
        Console.ReadLine();
    }


}
