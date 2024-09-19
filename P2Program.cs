int contadorVerde = 0;
int contadorAzul = 0;
int contadorRojo = 0;
    while (true)
    {
        Console.Write("Ingrese el último dígito de la placa del automóvil (o 'F' para finalizar): ");
        string entrada = Console.ReadLine();
        if (entrada.ToUpper() == "F")
        {
            break;
        }
        if (int.TryParse(entrada, out int digito))
        {
            if (digito >= 0 && digito <= 3)
            {
                contadorVerde++;
            }
            else if (digito >= 4 && digito <= 6)
            {
                contadorAzul++;
            }
            else if (digito >= 7 && digito <= 9)
            {
                contadorRojo++;
            }
            else
            {
                Console.WriteLine("El dígito debe estar entre 0 y 9.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ser un dígito o 'F' para finalizar.");
        }
    }
Console.WriteLine($"Autos con calcomanía verde: {contadorVerde}");
Console.WriteLine($"Autos con calcomanía azul: {contadorAzul}");
Console.WriteLine($"Autos con calcomanía roja: {contadorRojo}");
Console.ReadKey();


