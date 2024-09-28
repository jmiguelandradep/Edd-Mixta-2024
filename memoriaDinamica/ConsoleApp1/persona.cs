public class persona{
String nombre;
String rfc;
String telefono;

public persona(String nombre, String rfc,String telefono) {
    this.nombre = nombre;
    this.rfc = rfc;
    this.telefono = telefono;
}
public String getNombre() {return nombre;}
public String getRfc(){return rfc;}
public String getTelefono() {return telefono;}
public void setNombre(String nombre){
    this.nombre=nombre;
}
public void setRfc (String rfc) {
    this.rfc = rfc;
}
public void setTelefono(String telefono){
    this.telefono=telefono;
}

    public override string ToString()
    {
        return "Nombre:\t" + this.nombre + "\n" +
        "RFC:\t " + this.rfc + "\n" + 
        "Telfono:\t " + this.telefono + "\n";
    }

}