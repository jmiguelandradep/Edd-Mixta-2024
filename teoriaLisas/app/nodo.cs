public class nodo{
    private int id;
    private String name;
    nodo atras;
    nodo adelante;

    public nodo(int id, String name){
        this.id = id;
        this.name = name;
        this.atras = null;
        this.adelante = null;
    }   
    public int getId() { return id;   }
    public void setId(int id){ this.id = id; }
    public String getName() { return name; }
    public void setName(String name) { this.name=name; }
    public nodo getAtras(){return this.atras;}
    public nodo getAdelante(){return this.adelante;}
    public void setAtras(nodo tmp){ this.atras = tmp;}
    public void setAdelante(nodo tmp){ this.adelante=tmp;}

    public override string ToString()
    {
        return "id: " + id + "\n Nombre: " + name;
    }
    public bool equals(nodo obj){
        if(this.name.Equals(obj.getName()))
            return true;
        return false;
    }

}