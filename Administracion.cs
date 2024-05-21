using System.Security.Cryptography;

namespace AdministracionPersonal;
enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista, 
    Investigador
}

public class Empleado{
    private string Nombre;
    private string Apellido;
    private DateTime FechaNac;
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;

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

        if(empleado.cargo == Cargos.Ingeniero || empleado.cargo == Cargos.Especialista){
            Adicional *= 1.50;
        }

        if(empleado.EstadoCivil == 'C'){
            Adicional += 150000;
        }

        double salario = SueldoBasico + Adicional;
    
        return salario;
    }

}