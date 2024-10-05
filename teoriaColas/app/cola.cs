public class cola{
    nodo INICIO;
    nodo FINAL;
    public cola(){
        INICIO = null;
        FINAL = null;
    }
    public bool isEmpty() {
        if(INICIO == null)
        return true;
    return false;
    }
    public void agregar(nodo tmp){
        if(isEmpty())
        {
          INICIO=tmp;
          FINAL=tmp;      
        }
        else{
            //creamos el enlace
            FINAL.setAtras(tmp);
            //movemos el final
            FINAL=tmp;

        }
        Console.WriteLine("Elemento Agregado!!!");
    }
    public void extraer(){
        if(isEmpty()){
            Console.WriteLine("Cola Vacia!!!");
            return;
        }
        else{
            if(INICIO == FINAL) //solo hay un elemento
            {
                INICIO=null;
                FINAL=null;

            }
            else{
                nodo tmp = INICIO;
                INICIO= INICIO.getAtras();
                tmp.setAtras(null);

            }
            Console.WriteLine("Elemento Eliminado!!!");
        }

    }
    public void recorrer(){
        if(isEmpty())
        {
            Console.WriteLine("Cola Vacia");
            return;
        }
        nodo aux=INICIO;
        while(aux!=null){
            Console.WriteLine(aux.ToString());
            aux=aux.getAtras();
        }
    }
    
    public void buscar(nodo tmp){
            if(isEmpty())
                {
                    Console.WriteLine("Cola Vacia");
                    return;
                }
            nodo aux=INICIO;
            while(aux!= null){
                if(aux.Equals(tmp)){
                    Console.WriteLine("Elemento encontrado");
                    Console.WriteLine(aux.ToString());
                    return;
                }
                aux=aux.getAtras();
            }
            Console.WriteLine("Elemento no fue encotrado");

    }
}