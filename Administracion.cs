
namespace AdministracionPersonal;

    public class Empleado{
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

    public global::System.String Nombre { get => nombre; set => nombre = value; }
    public global::System.String Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public global::System.Char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public global::System.Double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal Cargos Cargo { get => cargo; set => cargo = value; }

    public double Antiguedad(){
            DateTime hoy = DateTime.Now;

            double antiguedad = hoy.Year - FechaIngreso.Year;
            
            return antiguedad;
        }

        public int Edad(){
            DateTime hoy = DateTime.Now;

            int edad = hoy.Year - FechaNac.Year;

            return edad;
        }

        public int AniosParaJubilarse(){

            int jubil = 65 - Edad();

            return jubil;
        }

        public double SalarioTotal(Empleado empleado){

            double Adicional = 0;

            if(Antiguedad() < 20){
                Adicional = SueldoBasico * (Antiguedad() * 0.01); 
            } else {
                Adicional = SueldoBasico * 0.25;
            }

            if(empleado.Cargo == Cargos.Ingeniero || empleado.Cargo == Cargos.Especialista){
                Adicional *= 1.50;
            }

            if(empleado.EstadoCivil == 'C'){
                Adicional += 150000;
            }

            double salario = SueldoBasico + Adicional;
        
            return salario;
        }

        public string MostrarCliente(){
             return "Nombre: " + Nombre + " | " +
                   "Apellido: " + Apellido + " | " +
                   "Fecha de Nacimiento: " + FechaNac.ToShortDateString() + " | " +
                   "Estado Civil: " + EstadoCivil + " | " +
                   "Fecha de Ingreso: " + FechaIngreso.ToShortDateString() + " | " +
                   "Sueldo Básico: " + SueldoBasico + " | " +
                   "Cargo: " + Cargo + " | " +
                   "Antigüedad: " + Antiguedad() + " años " + " | " +
                   "Edad: " + Edad() + " años " + " | " +
                   "Años para Jubilarse: " + AniosParaJubilarse() + " años" + " | " +
                   "Salario Total: $" + SalarioTotal(this);
            }

    }
