public class Program {
    
    public static void Main(string[] args){ 
        lista L = new lista();
        L.leer();
        int opc=0;
        int id=0;
        String nombre="";

        while(true){
            Console.Clear();
            Console.WriteLine("<==== Menu de opciones ====>");
            Console.WriteLine("1.- Agrear Nodo");
            Console.WriteLine("2.- Mostrar Lista");
            Console.WriteLine("3.- Buscar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Vaciar Lista");
            Console.WriteLine("0.- Salir");
            Console.WriteLine("Opcion:");
            opc = int.Parse(Console.ReadLine());
            switch(opc){
                case 1:
                    Console.WriteLine("Nombre");
                    nombre= Console.ReadLine();
                    Console.WriteLine("ID");
                    id=int.Parse(Console.ReadLine());
                    L.agregar( new nodo(id,nombre));
                break;
                case 2:
                    L.mostrar();
                break;
                case 3://buscar
                    Console.WriteLine("Nombre a buscar");
                    nombre=Console.ReadLine();
                    L.buscar(new nodo(-1,nombre));
                break;
                case 4: //eliminar
                    Console.WriteLine("Nombre a buscar");
                    nombre=Console.ReadLine();
                    L.eliminar(new nodo(-1,nombre));
                break;
                case 5: //vaciar lista
                    L.vaciar();
                break;
                case 0:
                    L.escribir();
                    return;
                break;
                default:
                    Console.WriteLine("Opcion No valida!!!");
                break;
                
            }//switch
            Console.ReadKey();
            

        }//whie
    }//main
}//class