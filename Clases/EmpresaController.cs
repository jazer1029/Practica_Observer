class EmpresaController
{
    public static CEmpresa obEmpresa = new();

    public static List<CEmpresa> Vacantes = new();

    public static void guardarVacante(CEmpresa empresa)
    {
        Vacantes.Add(empresa);
    }
    public static void BorrarVacante(CEmpresa empresa)
    {
        Vacantes.Remove(empresa);
    }

    public static string MostrarVacantes()
    {
        string text = "Lista \n";
        foreach(CEmpresa obEmpresa in Vacantes)
        {
            text += "Puesto: \n" + obEmpresa.Puesto + "\n" +
                    "Salario: \n" + obEmpresa.Salario + "\n" +
                    "Estatus: \n" + obEmpresa.Estatus + "\n";
        }

        return text;
    }

    public static double salarioPromedio()
    {
        double salarioDisp = 0;
        foreach (CEmpresa empresa in Vacantes)
        {
            salarioDisp = Convert.ToDouble(empresa.Salario);
        }

        return salarioDisp;
    }
    public static void CambíarEstatus(bool valor)
    {
        obEmpresa.Estatus = valor;
       System.Console.WriteLine(MostrarVacantes()); 
        obEmpresa.Notificar();
    }
}

