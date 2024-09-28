class Program{
public static void Main(string[] args){
    personaControler pc = new personaControler();
    String nombre,telefono,rfc;
    int opc;
    while(true){
        Console.WriteLine("<=== Menu Memoria Dinamica ===>");
        Console.WriteLine("1.- Agregar");
        Console.WriteLine("2.- Mostrar todos");
        Console.WriteLine("3.- Buscar");
        Console.WriteLine("4.- Actualizar");
        Console.WriteLine("5.- Eliminar");
        Console.WriteLine("0.- Salir");
        opc=int.Parse( Console.ReadLine());
        switch(opc){
            case 1: //agregar
            Console.WriteLine("Ingresa Nombre");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingresa RFC");
            rfc=Console.ReadLine();
            Console.WriteLine("Ingresa telefonoo");
            telefono=Console.ReadLine();
            pc.addPersona(new persona(nombre,telefono,rfc));
            Console.WriteLine("Persona Agregada");
            break;
            case 2: //mostrar todos
            pc.MostrarTodos();
            break;
            case 3: //buscar
            Console.WriteLine("Ingresa Nombre");
            nombre=Console.ReadLine();
            persona p = pc.buscar(new persona(nombre,"",""));
            if(p==null)
                Console.WriteLine("La persona a buscar no existe");
            else
                Console.WriteLine(p.ToString());
            break;
            case 4://actualizar
            Console.WriteLine("Ingresa Nombre");
            nombre=Console.ReadLine();
            
            bool actualiado=pc.actualizarP(new persona(nombre,"",""));
            if(actualiado==true)
                Console.WriteLine("Persona Actualizada");
             else
                   Console.WriteLine("Persona No existe");
            break;
            case 5://eliminar
            Console.WriteLine("Ingresa Nombre");
            nombre=Console.ReadLine();
            
            bool eliminado=pc.eliminarP(new persona(nombre,"",""));
            if(eliminado==true)
                Console.WriteLine("Persona Eliminada");
             else
                   Console.WriteLine("Persona No existe");
            break;
            break;
            case 0:
                return;
            
            default:
            Console.WriteLine("Opcion Invalida");
            break;
            
        }
        Console.ReadKey();
        Console.Clear();


    }


}


}
