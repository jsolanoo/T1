double salarioBruto, ventas, comision, totalg, descuento, salarioNeto;
int anosemp;
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese su salario bruto del mes: ");
salarioBruto=double.Parse(Console.ReadLine());
Console.Write("Ingrese las ventas realizadas: ");
ventas=double.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de años en la empresa: ");
anosemp=int.Parse(Console.ReadLine());
//PROCESO

{
    if (ventas <= 600)
    {
        comision = ventas * 0.05;
    }
    else if (ventas > 600 && ventas <= 3000)
    {
        comision = ventas * 0.07;
    }
    else
    {
        comision = 300 + ventas * 0.06;
    }
    totalg = salarioBruto + comision;
}
if(anosemp<=3)
{
    descuento = 0.065 * totalg;
}
else
{
    descuento = 0.045 * totalg;
}

salarioNeto = totalg - descuento;
//RESULT
Console.WriteLine("Nombre: "+nombre);
Console.WriteLine("Total ganado: S/. "+totalg);
Console.WriteLine("Descuento en dinero: S/. "+descuento);
Console.WriteLine("Salario neto que recibirá: S/. "+salarioNeto);
Console.ReadKey();