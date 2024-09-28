public class AlumnosController{
    private Alumno[] misAlumnos;
    private int misAlumnosCount; //ver cuantos registros van agregados
    public AlumnosController(int t){
        misAlumnos = new Alumno[t];
        misAlumnosCount=0;
    }           
    public void addAlumno(Alumno a){ 
            if(misAlumnosCount==misAlumnos.Length){
                Console.WriteLine("Arreglo Lleno");
                return;
            }
            misAlumnos[misAlumnosCount]=a;
            misAlumnosCount++;
            Console.WriteLine("Alumno Agregado");
    }

    public void showData(){
        if(misAlumnosCount==0){
            Console.WriteLine("Arreglo Vacio!!!");
            return;
        }
        //foreach(Alumno tmp in misAlumnos)
        for(int i=0; i< misAlumnosCount;i++){
            Console.WriteLine(misAlumnos[i].ToString());
        }
    }
    public int searchData(Alumno f){
        if(misAlumnosCount==0)
            return -1;
        else
        {
            
            for(int i=0;i<misAlumnosCount;i++)
                    if(misAlumnos[i].Equals(f))
                        return i;
            return -1;
        }
    }

    public void show(int pos)
    {
        Console.WriteLine(misAlumnos[pos].ToString());
    }

    public void UpdateData(Alumno a){
        int esta = searchData(a);
        if(esta == -1 ){
            Console.WriteLine("Registro No existe");
            return;
        }
        //actualizar
        Console.WriteLine("Ingresa el nombre");
        String nombre=Console.ReadLine();
        misAlumnos[esta].setNombre(nombre);
        Console.WriteLine("Ingresa el correo");
        String email = Console.ReadLine();
        misAlumnos[esta].setEmail(email);
        Console.WriteLine("Ingresa la edad");
        int edad = int.Parse(Console.ReadLine());
        misAlumnos[esta].setEdad(edad);
        Console.WriteLine("Datos Actualizados");

    }

    public void DeleteData(Alumno a){
        int esta = searchData(a);
        if(esta==-1)
            {
                Console.WriteLine("No existe el registro");
                return;
            }
       misAlumnos[esta].setEdad(0);
       misAlumnos[esta].setNombre("");
       misAlumnos[esta].setEmail("");
       //recorremos los elementos
       //misAlumnosCount-=1; 
       Console.WriteLine("Alumno Eliminado");
       /*if(esta==0) return;
       for(int i=esta;i<misAlumnos.Length;i++){
            misAlumnos[i].setNombre(misAlumnos[i+1].getNombre());
            misAlumnos[i].setEmail(misAlumnos[i+1].getEmail());
            misAlumnos[i].setEdad(misAlumnos[i+1].getEdad());
       }*/
       
       
    }

}//clase