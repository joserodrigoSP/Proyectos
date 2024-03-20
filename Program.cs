class Program{
static void Main(string[] args){

int resp = 0 ;


Console.WriteLine("¿Qué tipo de leche quisiera agregar?");
Console.WriteLine("1) Sin leche (agua)");
Console.WriteLine("2) Leche deslactosada");
Console.WriteLine("3) Leche entera");
Console.WriteLine("4) Leche de soya");
int.TryParse(Console.ReadLine(), out resp);



}
}