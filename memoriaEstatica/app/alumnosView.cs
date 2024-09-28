public class alumnosView{
    AlumnosController al;
    String nombre,email;
    int edad;

    public alumnosView(){
        int tam;
        Console.WriteLine("Tamaño de tu arreglo");
        tam = int.Parse(Console.ReadLine());
        al=new AlumnosController(tam);
        menu();
    }
    private void menu(){
     int opc;
     
    while(true){
        Console.Clear();
        Console.WriteLine("<==== Menu Alumnos ====>");
        Console.WriteLine("1.- Agregar");
        Console.WriteLine("2.- Mostrar Todos");
        Console.WriteLine("3.- Buscar Registro");
        Console.WriteLine("4.- Actualizar Registro");
        Console.WriteLine("5.- Elminar");
        Console.WriteLine("0.- Salir");
        opc=int.Parse(Console.ReadLine());
        switch(opc){
            case 1:
                Console.WriteLine("Nombre:");
                nombre=Console.ReadLine();
                Console.WriteLine("Email:");
                email=Console.ReadLine();
                Console.WriteLine("edad:");
                edad = int.Parse(Console.ReadLine());
                al.addAlumno(new Alumno(edad,nombre,email));
               
            break;
            case 2:
                al.showData();
            break;
            case 3:
                Console.WriteLine("Ingresa el nombre a buscar");
                nombre = Console.ReadLine();
                int pos = al.searchData(new Alumno(0,nombre,""));
                if(pos==-1)
                    Console.WriteLine("Registro no existe");
                else
                    al.show(pos);                
            break;
            case 4:
                Console.WriteLine("Ingrese el nombre a modificar");
                nombre = Console.ReadLine();
                al.UpdateData(new Alumno(0,nombre,""));

            break;
            case 5:
                Console.WriteLine("Ingrese el nombre a Eliminar");
                nombre = Console.ReadLine();
                al.DeleteData(new Alumno(0,nombre,""));

            break;
            case 0:
                return;
            default:
                Console.WriteLine("Opcion No Valida!!");
            break;

        }
        Console.ReadKey();
    }


    }



}