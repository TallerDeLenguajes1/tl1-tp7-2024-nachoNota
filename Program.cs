using AdministracionPersonal;

Empleado[] empleados_array = new Empleado[3];

empleados_array[0] = new Empleado("Juan", "Perez", new DateTime(1985, 3, 23), 'C', new DateTime(2010, 6, 15), 50000, Cargos.Ingeniero);
empleados_array[1] = new Empleado("Maria", "Gomez", new DateTime(1990, 8, 12), 'S', new DateTime(2015, 9, 30), 40000, Cargos.Administrativo);
empleados_array[2] = new Empleado("Carlos", "Lopez", new DateTime(1975, 1, 5), 'C', new DateTime(2000, 1, 10), 60000, Cargos.Especialista);

foreach (Empleado empleado in empleados_array)
{
    MostrarEmpleado();
}

DateTime dateTime;
