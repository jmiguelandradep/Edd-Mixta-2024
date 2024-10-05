public class lista{
    nodo INICIO;
    nodo FINAL;
    lista(){
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
        //es el primero
        //va al final
        //va enmedio
    }
}