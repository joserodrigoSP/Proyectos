using System.Globalization;
using System.Threading;
class Program{
static void Main(string[] args){
Licuado objlicuado = new Licuado();
Cliente objcliente = new Cliente();
DateTime fecha1 = DateTime.Now;

int opcion=0;
int respdow=0;
int resp;
double precio=0;
string tipoazucar =""; 
string tipoleche = "";
int cdaz=0;
Console.WriteLine("Hora de inicio: "+fecha1);
do{
Console.WriteLine(" \n \n Qué acción desea realizar \n 1) Elegir azucar \n 2) Elegir Leche \n 3) Agrandar el pedido \n 4) Agregar datos del cliente \n 5) Finalizar pedido ");
int.TryParse(Console.ReadLine(), out opcion);
switch(opcion){
case 1:

Console.WriteLine(" \n \n Qué tipo de azucar le gustaria agregar: \n 1) Azucar blanca \n 2) Azucar morena \n 3) Suplemento \n 4) No agregar");
int respp; int.TryParse(Console.ReadLine(), out respp);
switch(respp){
case 1:
tipoazucar = "azucar blanca";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
objlicuado.definirAzucar(cdaz, tipoazucar);
break; 
case 2:
tipoazucar = "azucar morena";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
objlicuado.definirAzucar(cdaz, tipoazucar);
break; 
case 3:
tipoazucar = "suplemento";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
objlicuado.definirAzucar(cdaz, tipoazucar);
break;
}
Console.WriteLine(objlicuado.MostrarAzucar());
break;


case 2:
Console.WriteLine("\n \n Qué tipo de leche le gustaria agregar? \n 1) Leche deslactosada \n 2) Leche entera \n 3) Leche de soya \n 4) Agua");
int res; int.TryParse(Console.ReadLine(), out res);
switch(res){
case 1:
tipoleche = "leche deslactosada";
break;
case 2:
tipoleche = "leche entera";
break;
case 3:
tipoleche = "leche de soya";
break;
case 4:
tipoleche = "agua";
break;
}
objlicuado.definirLeche(tipoleche);
Console.WriteLine(objlicuado.MostrarLeche());
break;

case 3:
Console.WriteLine(" \n \n Desea agrandar el pedido? 1) si   2) no");
int re; int.TryParse(Console.ReadLine(), out re);
if(re==1){objlicuado.Agrandar();Console.WriteLine(objlicuado.MostrarAgrandado());}else{Console.WriteLine(objlicuado.MostrarAgrandado());} 
break;
case 4:
Console.WriteLine(" \n \n Ingrese el nombre del cliente: ");
objcliente.definirNombre(Console.ReadLine());
Console.WriteLine("¿Desea ingresar NIT? 1) SI   2) NO");
int.TryParse(Console.ReadLine(), out resp);
if(resp==1){
objcliente.cambiarEstadoNit();
Console.WriteLine("Cual es el NIT del cliente?");
objcliente.definirNit(Console.ReadLine());
}else{
Console.WriteLine("CF");
}
Console.WriteLine(objcliente.MostrarNit());
break;
case 5:
precio = objlicuado.MostrarPrecio();
Console.WriteLine("\n \n Te gustaria confirmar el pedido? 1) si  2) no");
int.TryParse(Console.ReadLine(), out respdow);
if(respdow==1){
precio = objlicuado.MostrarPrecio();
DateTime fecha2 = DateTime.Now;
Console.WriteLine(" \n \n | Fecha de inicio: "+fecha1+" \n | Fecha de finalización del pedido: "+fecha2+"\n | Nombre del cliente: "+objcliente.MostrarNombre()+".\n | NIT: "+ objcliente.MostrarNit()+"\n | Pedido: Licuado de fresa con "+ objlicuado.MostrarLeche()+"\n | Agregó "+objlicuado.MostrarcantAzucar()+" cucharaditas de "+objlicuado.MostrarAzucar()+" \n"+objlicuado.MostrarAgrandado()+"\n | El precio total es de Q."+precio);
}
break;


}
}while(respdow!=1);


}
}