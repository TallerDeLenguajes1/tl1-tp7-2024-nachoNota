using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();

int seguir = 0;

do{
    System.Console.WriteLine("1- Sumar");
    System.Console.WriteLine("2- Restar");
    System.Console.WriteLine("3- Multiplicar");
    System.Console.WriteLine("4- Dividir");
    System.Console.WriteLine("5- Limpiar");
    System.Console.WriteLine("Opcion: ");
    int opcion = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Ingrese numero: ");
    int num = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: miCalculadora.Sumar(num);
            break;
        case 2: miCalculadora.Restar(num);
            break;
        case 3: miCalculadora.Multiplicar(num);
            break;
        case 4: if(num != 0){
                    miCalculadora.Dividir(num);
                } else {
                    System.Console.WriteLine("No se puede dividir en 0");
                }
            break;
        case 5: miCalculadora.Limpiar();
            break;
        default: System.Console.WriteLine("Opcion no valida");
            break;
    }

    System.Console.WriteLine("Realizar otra operacion? 1=si, 0=no");
    seguir = int.Parse(Console.ReadLine());
    
}while(seguir == 1);

System.Console.WriteLine($"Resultado: {miCalculadora.Resultado}");