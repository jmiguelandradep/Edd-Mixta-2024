public class lista{
    nodo INICIO;
    nodo FINAL;
    public lista(){
        INICIO = null;
        FINAL = null;
    }
    public bool isEmpty(){ return (INICIO == null);  }
    public void mostrar(){
        if (isEmpty()){
            Console.WriteLine("Lista Vacia!!!");
            return;   
        }
        nodo aux=INICIO;
        while (aux != null){
            Console.WriteLine(aux.ToString());
            aux= aux.getAtras(); 
        }
    }
    public void agregar(nodo nuevo){
        Console.WriteLine("Agregando...");
        //es el primero
        if(isEmpty()){
            INICIO=nuevo;
            FINAL=nuevo;
            return;
        }
        //buscamos el lugar donde va el nuevo nodo
        nodo aux=INICIO;
        while(aux!=null){
            if(aux.getId()>nuevo.getId())
                break;
            aux= aux.getAtras();
        }
        //nuevo inicio
        if(aux==INICIO){
            INICIO.setAdelante(nuevo);
            nuevo.setAtras(INICIO);
            INICIO=nuevo;
            return;
        }
        //va al final
        if(aux==null)
        {
            FINAL.setAtras(nuevo);
            nuevo.setAdelante(FINAL);
            FINAL=nuevo;
            return;
        }
        //va enmedio
        if(aux!=null){
            nodo aux1 = aux.getAdelante();
            nuevo.setAdelante(aux1);
            nuevo.setAtras(aux);
            aux1.setAtras(nuevo);
            aux.setAdelante(nuevo);
        }//if de enmedio
    }
    
    private nodo encontrar(nodo tmp){
        nodo aux=INICIO;
        while(aux!=null){
            if(aux.equals(tmp))
                return aux;
            aux = aux.getAtras();
        }//while
        return null;
    }//encontrar
    public void buscar(nodo tmp){
        if(isEmpty()){
            Console.WriteLine("Lista Vacia!!");
            return;
        }
        tmp = encontrar(tmp);
        if(tmp==null){
            Console.WriteLine("El nodo no existe");
            return;
        }
        Console.WriteLine("Nodo encontrado!!");
        Console.WriteLine(tmp.ToString());
    }//buscar
    public void eliminar(nodo tmp){
        if(isEmpty()){
            Console.WriteLine("Lista Vacia!!!");
            return;
        }
        tmp = encontrar(tmp);
        if(tmp==null){
            Console.WriteLine("El nodo no existe!!!");
            return;
        }
        //validamos si solo es 1 nodo en la lista
        if(INICIO == FINAL){
            INICIO =null;
            FINAL = null;
            return;
        }
        //validamos si es el inicio
        if(tmp==INICIO){
                INICIO=INICIO.getAtras();
                tmp.setAtras(null);
                INICIO.setAdelante(null);
                return;
        }
        //validamos si es el final
        if(tmp==FINAL){
            FINAL = FINAL.getAdelante();
            FINAL.setAtras(null);
            tmp.setAdelante(null);
            return;
        }
        //va enmedio
        nodo aux1 = tmp.getAdelante();
        nodo aux2 = tmp.getAtras();
        //generamos los nuevos enlaces
        aux1.setAtras(aux2);
        aux2.setAdelante(aux1);
        //rompemos los enlaces del nodo eliminado 
        tmp.setAtras(null);
        tmp.setAdelante(null);
        return;
    }
    public void vaciar(){
        if(isEmpty()){
            Console.WriteLine("Lista Vacia");
            return;
        }
        INICIO=null;
        FINAL= null;
    }
    public void escribir() {
        if(isEmpty())
            return;
        
        string rutaArchivo="agenda.txt";
        try{
            StreamWriter sw = new StreamWriter(rutaArchivo);
            nodo aux=INICIO;
            while(aux!=null){
                sw.WriteLine(aux.getId());
                sw.WriteLine(aux.getName());
            aux=aux.getAtras();
            }//while
            sw.Close();
        }//try
        catch(Exception ex){
         Console.WriteLine("Error al escrbiri "+ex.Message); 
        }//catch
        
    }//metodo
    public void leer(){
        string rutaArchivo="agenda.txt";
        try{
            StreamReader sr = new StreamReader(rutaArchivo);
            string id;
            string nombre;
            while( (id = sr.ReadLine()) != null ){
               // Console.WriteLine("Cargando datos");
                nombre= sr.ReadLine();
                agregar(new nodo(int.Parse(id) ,nombre ));

            }
            sr.Close();
        
        }
        catch(Exception ex){
            Console.WriteLine ("Error al lerr "+ex.Message);
        }
    }
}