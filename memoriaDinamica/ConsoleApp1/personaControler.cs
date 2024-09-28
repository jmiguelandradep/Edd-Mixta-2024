using System.Collections;

public class personaControler{

    private ArrayList misPersonas;

    public personaControler(){
        misPersonas = new ArrayList();
    }

    public void addPersona(persona p){
        misPersonas.Add(p);
    }
    public void MostrarTodos(){
        if(misPersonas.Count==0){
            Console.WriteLine("Coleccion Vacia");
            return;
        }
        foreach(persona p in misPersonas){
            Console.WriteLine(""+p.ToString());
        }
    }

    public persona buscar(persona p){
        foreach(persona t in misPersonas)
            if(t.getNombre().Equals(p.getNombre()))
                {
                    return t;    
                }
        return null;
            
    }

    public bool eliminarP(persona p)
        {
            p=buscar(p);
            if(p==null){
                return false;
            }
            misPersonas.Remove(p);
            return true;
        }
    public bool actualizarP(persona p){
        p=buscar(p);
            if(p==null)
                return false;
        Console.WriteLine("Nombre");    
        String nombre = Console.ReadLine();
        p.setNombre(nombre);
        Console.WriteLine("rfc");
        String rfc = Console.ReadLine();    
        p.setRfc(rfc);
        Console.WriteLine("telefono");
        String telefono = Console.ReadLine();
        p.setTelefono(telefono);
        return true;    
    }



}//clase