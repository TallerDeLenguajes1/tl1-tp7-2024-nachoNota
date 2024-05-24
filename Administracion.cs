
namespace AdministracionPersonal{
    enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista, 
        Investigador
    }

    public class Empleado{
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

   
        public double Antiguedad(){
            DateTime hoy = DateTime.Now;

            double antiguedad = hoy.Year - FechaIngreso.Year;
            
            return antiguedad;
        }

        public double Edad(){
            DateTime hoy = DateTime.Now;

            double edad = hoy.Year - FechaNac.Year;

            return edad;
        }

        public double AniosParaJubilarse(){

            double jubil = 65 - Edad();

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

    }
}