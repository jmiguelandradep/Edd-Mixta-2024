public class nodo{
    private int id;
    private String name;
    nodo atras;
    public nodo(int id,String name){
       this.id = id;
       this.name = name;
       atras=null;
    }
    public int getId() { return id; }
    public String getName() { return name; }
    public nodo getAtras(){ return atras ; }
    public void setId(int id) { this.id = id; }
    public void setName(String name) {this.name = name;}
    public void setAtras(nodo atras){this.atras = atras;}
    public override string ToString()
    {
        return "id: " + this.id+"\n"+"Nombre: "+this.name;
    }
}