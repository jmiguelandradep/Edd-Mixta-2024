public class Program{
    public static void Main(string[] args){
        pila PILA= new pila();
        int van=0;
        String  nombre;
        //ver el tope, sale vacia
        PILA.verTope();
        PILA.pop();  // sale vacia porque no podemos scar
        PILA.push(new nodo(van++,"Juan Miguel")); //metemos uno
        PILA.verTope(); //sale juan miguel
        PILA.push(new nodo(van++,"Edgar")); //metemos edgar
        PILA.push(new nodo(van++,"Luis")); //metemos luis
        PILA.verTope(); //imprime Luis
        Console.ReadKey();
        Console.Clear(); 
        PILA.recorrer(); //impri 3 elementos
        Console.ReadLine();
        PILA.pop();//sacamoms 1
        PILA.pop();//sacamos 2
        PILA.pop();// sacamos 3
        PILA.pop(); // sale pila vacia
        PILA.recorrer(); //sale pila vacia


    }
}