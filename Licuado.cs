using System.Runtime.CompilerServices;

class Licuado{
double precio; 
int cdAzucar;

string ScAzucar;

int tipoLeche;
string StipoLeche;
int agrandado;
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

public void definirLeche(){
    
}



}