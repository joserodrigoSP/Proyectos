using System.Runtime.CompilerServices;
class Licuado{
double precio; 
int cdAzucar;

string ScAzucar;
int cantidadL;
int tipoLeche;
string StipoLeche;
int agrandado;
bool estAgrandado= false;
double total;



public Licuado(double pre = 20, int cdazucar=0, string tipole="deslactosada"){
precio = pre;
cdAzucar = cdazucar;
StipoLeche = tipole;
}
public void definirAzucar(int czucar, string Scazucar){
cdAzucar = czucar;
ScAzucar=Scazucar;
switch(ScAzucar){
    case "azucar blanca":
    precio = precio + (0.6 * cdAzucar);
    break;
    case "azucar morena":
    precio = precio + (0.4 * cdAzucar);
    break;
    case "suplemento":
    precio = precio + (0.9 * cdAzucar);
    break;
}
}
public void definirCant(int cant){

cantidadL = cant;

}
public void definirLeche(string tipole){
StipoLeche = tipole;
switch(tipole){
case "agua":
precio = precio -3;
break;
case "leche de soya":
precio = precio +2;
break;
}
}
public void Agrandar(){
estAgrandado = !estAgrandado;
}
public string MostrarAgrandado(){

    if(estAgrandado == true){
        precio = precio + (precio * 0.07);
        return " | Su pedido está agrandado";
    }else{
        precio = precio + 0;
        return " | El pedido no es agrandado";
    }

}
public string MostrarLeche(){
    return StipoLeche;
}
public string MostrarAzucar(){
    return ScAzucar;
}
public int MostrarcantAzucar(){
    return cdAzucar;
}
public double MostrarPrecio(){
    return precio;
}
public int MostrarCant(){
    return cantidadL;
}
}