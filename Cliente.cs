class Cliente{

string nombre;
string NIT;
bool Cnit;

public Cliente(string nom="", bool cn=false){
nombre =nom ;
Cnit= cn;
}

public void definirNombre(string nomb){
nombre = nomb; 
}
public void cambiarEstadoNit(){
    Cnit = !Cnit;
}
public string MostrarNit(){
    if(Cnit == true){
        return "El Nit es: "+NIT;
    }else{
        return "CF";
    }
}
public void definirNit(string n){
NIT= n;
}
public string MostrarNombre(){
    return nombre;
}




}