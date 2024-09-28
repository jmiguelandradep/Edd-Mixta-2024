//modelo o model
public class Alumno{
    int edad;
    String Nombre;
    String email;

    public Alumno(){
        edad = 0;
        Nombre="";
        email="";
    }
    //sobrecarcar
    public Alumno(int edad,String Nombre, String email) {
        this.edad = edad;
        this.Nombre = Nombre;
        this.email = email;
    }
    //setter
    public void setEdad(int edad){
        this.edad = edad;   
    }
    public void setNombre(String Nombre){
        this.Nombre = Nombre;
    }
    public void setEmail(String email){
        this.email = email;
    }   
    //gettet
    public int getEdad(){ return edad;}
    public String getNombre(){ return Nombre;}
    public String getEmail(){ return email;}

    public override string ToString()
    {
        return "Nombre: \t" + Nombre + "\n" +
        "Edad: \t"+edad + "\n" + 
        "Email:\t"+email; 
    }

    public bool Equals(Alumno a){
        if(this.Nombre.Equals(a.Nombre))
            return true;
        return false;
    }
}
