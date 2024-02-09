
internal class CCandidatos : IInteresados
{
    //Propiedades de los Candidatos
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string Correo { get; set; } = string.Empty;
    public double? AspiracionSalarial { get; set; }
    public CEmpresa? Empresa { get; set; }
    public string? AreaEspecializada { get; set; }

    //Metodos
    public void actualizar()
    {
        double x = EmpresaController.salarioPromedio();
        if (AspiracionSalarial > x)
        {
            string puesto = EmpresaController.MostrarVacantes();
            CCorreo obCorreo = new CCorreo();
            var body = @"<style>
                        h1{color:dodgerblue;}
                        h2{color:darkorange;}
                        </style>"
                            + "<h1> Nueva Vacante Disponible</h1> </br>"
                            + "<h2> Puesto:" + puesto + "</h2>";
            obCorreo.sendMail(Correo, "Vacante Disponible", body);
        }
    }
}

