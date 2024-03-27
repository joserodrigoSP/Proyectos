class Program{
static void Main(string[] args){
Licuado objlicuado = new Licuado();
Cliente objcliente = new Cliente();
int opcion=0;
int resp;
string tipoazucar =""; 
int cdaz=0;
Console.WriteLine("Qué acción desea realizar \n 1) Elegir azucar \n 2) Elegir Leche \n 3) Agrandar el pedido \n 4) Agregar datos del cliente \n 5) Finalizar pedido");
int.TryParse(Console.ReadLine(), out opcion);
switch(opcion){
case 1:

Console.WriteLine("Qué tipo de azucar le gustaria agregar: \n 1) Azucar blanca \n 2) Azucar morena \n 3) Suplemento \n 4) No agregar");
int respp; int.TryParse(Console.ReadLine(), out respp);
switch(respp){
case 1:
tipoazucar = "azucar blanca";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
break; 
case 2:
tipoazucar = "azucar morena";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
break; 
case 3:
tipoazucar = "suplemento";
do{
Console.WriteLine("Cuantas cucharaditas desea agregar? (no mas de 3)");
int.TryParse(Console.ReadLine(), out cdaz);
}while(cdaz>=4);
cdaz=0;
break;
}

objlicuado.definirAzucar(cdaz, tipoazucar);

break;

case 2:

break;
case 3:

break;
case 4:
Console.WriteLine("Ingrese el nombre del cliente: ");
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
break;
case 5:

break;



}
}
}