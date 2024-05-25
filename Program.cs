using AdministracionPersonal;
var empleados = new Empleado[3];

            empleados[0] = new Empleado
            {
                Nombre = "Nacho",
                Apellido = "Nota",
                FechaNac = new DateTime(1980, 5, 20),
                EstadoCivil = 'C',
                FechaIngreso = new DateTime(2005, 3, 15),
                SueldoBasico = 50000,
                Cargo = Cargos.Ingeniero
            };

            empleados[1] = new Empleado
            {
                Nombre = "Vegetta",
                Apellido = "777",
                FechaNac = new DateTime(1990, 7, 10),
                EstadoCivil = 'S',
                FechaIngreso = new DateTime(2015, 6, 1),
                SueldoBasico = 40000,
                Cargo = Cargos.Administrativo
            };

            empleados[2] = new Empleado
            {
                Nombre = "Carlos",
                Apellido = "Menem",
                FechaNac = new DateTime(1975, 2, 28),
                EstadoCivil = 'C',
                FechaIngreso = new DateTime(2000, 9, 20),
                SueldoBasico = 60000,
                Cargo = Cargos.Especialista
            };

            foreach (Empleado emp in empleados) //muestro todos los empleados
            {
                System.Console.WriteLine(emp.MostrarCliente());
                System.Console.WriteLine("\n---------------------\n");
            }

            double sum_salario = 0;
            Empleado MasCercaJubilacion = empleados[0];

            foreach (Empleado emp in empleados)
            {
                if (emp.AniosParaJubilarse() < MasCercaJubilacion.AniosParaJubilarse())
                {
                    MasCercaJubilacion = emp;
                }
                sum_salario += emp.SalarioTotal(emp);
            }

            System.Console.WriteLine($"Monto total en concepto de salarios: ${sum_salario}");
            System.Console.WriteLine("Empleado mas cerca de la jubilacion: \n" + MasCercaJubilacion.MostrarCliente());
