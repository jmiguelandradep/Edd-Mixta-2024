public class pila{
    nodo TOPE;

    public pila(){
        TOPE = null;
    }
    /*
    1 push agrear un nodo
    2 pop extraer un nodo
    3 isEmpty verificar si esta vacia
    4 getTope ver el tope de la pila
    5 recorrer la pila --> 
    */
    public bool isEmpty(){
        if(TOPE==null)
            return true;
        return false;
        //return (TOPE == null);

    }
    public void push(nodo temp){
        if(isEmpty())
            TOPE=temp;
        else
        {
            temp.setAtras(TOPE);
            TOPE = temp;
        }
    }
    public void pop(){
        if(isEmpty()){
            Console.WriteLine("Pila Vacia!!!");
            return;
        }
        //tomamos la direcicon del nodo
        nodo tmp = TOPE;
        //movemos el tope al elemento anterior
        TOPE=TOPE.getAtras();
        //rompemos el enlace del nodo
        tmp.setAtras(null);
        Console.WriteLine("Elemento Eliminado");
    }   
    public void verTope(){
        if(isEmpty()){
            Console.WriteLine("Pila vacia!!!");
            return;
        }
        Console.WriteLine(TOPE.ToString());
    }

    public void recorrer(){
        if(isEmpty()) { 
            Console.WriteLine("Pila Vacia!!!");
            return;
        }
        nodo aux=TOPE;
        while(aux!=null){
            Console.WriteLine(aux.ToString());
            aux = aux.getAtras();
        }
    }

}