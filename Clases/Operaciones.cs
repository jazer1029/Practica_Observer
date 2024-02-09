
class Operaciones
{
    public static CCandidatos cCandidatos = new();
    public static CEmpresa objEmp = EmpresaController.obEmpresa;

    public static void Menú()
    {
        bool ciclo = false;
        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------¿Que desea realizar-----------");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("[1] - Crear un Puesto Laboral \n");
            Console.WriteLine("[2] - Crear un a Candidato \n");
            Console.WriteLine("[3] - Editar un Puesto Laboral \n");
            Console.WriteLine("[4] - Mostrar los Puestos Laborales \n");
            Console.WriteLine("[5] - Suscribir candidatos a determinados puestos\n");
            Console.WriteLine("[6] - Desuscribir candidatos a determinados puestos\n");

            int opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones)
            {
                //Crear los metodos
                case 1:
                    CreacionPuestoLaboral();
                    Program.Main();
                    break;

                case 2:
                    CreacionCandidato();
                    Program.Main();
                    break;

                case 3:
                    bool x =objEmp.Estatus;
                    bool y = true;
                    if(x == false)
                    {
                        EmpresaController.CambíarEstatus(y);
                    }
                    Program.Main();
                    break;

                case 4:
                    MostrarPuestosLaborales();
                    Program.Main();
                    break;

                case 5:

                    objEmp.Suscribir(cCandidatos);
                    Program.Main();
                    break;

                case 6:

                    objEmp.Desuscribir(cCandidatos);
                    Program.Main();
                    break;

                default:
                    Console.WriteLine("Gracias Por Usar Nuestros Servicios");
                    Thread.Sleep(3000);
                    Program.Main();
                    break;
            }
        } while (ciclo);
    }
    public static void CreacionPuestoLaboral()
    {
        int index;
        bool estado = true;
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("-----------Completa Los Siguientes Campos-----------");
        Console.WriteLine("--------------------------------------------------\n");
        Console.WriteLine("Ingresa El Nombre del Puesto\n");
        string? puesto = Console.ReadLine();
        Console.WriteLine("Ingresa el Salario del puesto\n");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seleccione el Area del puesto\n");
        Console.WriteLine("[0]" + CEmpresa.Area.ElementAt(0) + "\n");
        Console.WriteLine("[1]" + CEmpresa.Area.ElementAt(1) + "\n");
        Console.WriteLine("[2]" + CEmpresa.Area.ElementAt(2) + "\n");
        Console.WriteLine("[3]" + CEmpresa.Area.ElementAt(3) + "\n");
        Console.WriteLine("[4]" + CEmpresa.Area.ElementAt(4) + "\n");
        index = Convert.ToInt16(Console.ReadLine());
        string area = CEmpresa.Area.ElementAt(index);
        Console.WriteLine("Su Puesto ha sido creado correctamente y esta disponible \n");
        Console.WriteLine("Preciones [1] Si desea guardar el Puesto creado \n"
                        + "Preciones [2] para Cancelar el guardado el Puesto creado");
        objEmp = new(puesto, salario, estado, null, area);
        int opcion = Convert.ToInt16(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                EmpresaController.guardarVacante(objEmp);
                break;

            default:
                Program.Main();
                break;
        }
        Program.Main();
    }
    public static void CreacionCandidato()
    {
        int index;
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("-----------Completa Los Siguientes Campos-----------");
        Console.WriteLine("--------------------------------------------------\n");
        Console.WriteLine("Ingresa la cedula del Candidato\n");
        string? Cedula = Console.ReadLine();
        Console.WriteLine("Ingresa el Nombre del Candidato\n");
        string? Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad Salarial que desea ganar");
        double AspiracionSalarial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el correo del Candidato");
        string? Correo = Console.ReadLine();
        Console.WriteLine("Seleccione el Area del puesto\n");
        Console.WriteLine("[0]" + CEmpresa.Area.ElementAt(0) + "\n");
        Console.WriteLine("[1]" + CEmpresa.Area.ElementAt(1) + "\n");
        Console.WriteLine("[2]" + CEmpresa.Area.ElementAt(2) + "\n");
        Console.WriteLine("[3]" + CEmpresa.Area.ElementAt(3) + "\n");
        Console.WriteLine("[4]" + CEmpresa.Area.ElementAt(4) + "\n");
        index = Convert.ToInt16(Console.ReadLine());
        string AreaEspecializada = CEmpresa.Area.ElementAt(index);
        cCandidatos.Cedula = Cedula;
        cCandidatos.Nombre =Nombre; 
         cCandidatos.Correo =Correo!; 
         cCandidatos.AspiracionSalarial = AspiracionSalarial;  
         cCandidatos.Empresa = null;
         cCandidatos.AreaEspecializada=AreaEspecializada;
        Program.Main(); 
    }
    public static void MostrarPuestosLaborales()
    {
        Console.WriteLine (EmpresaController.MostrarVacantes());
        Console.ReadKey();
    }
}

