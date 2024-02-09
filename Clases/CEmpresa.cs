class CEmpresa
{
    //Atributos
    public string? Puesto { get; set; }
    public double Salario { get; set; }
    public bool Estatus { get; set; }
    public CCandidatos? candidatos;
    
    //Constructor
    public CEmpresa(string? puesto, double salario, bool estatus, CCandidatos? cCandidatos, string area)
    {
        Puesto = puesto;
        Salario = salario;
        Estatus = estatus;
        candidatos = cCandidatos;
    }
    public CEmpresa() {}
    
    //List
    public List<IInteresados> Candidatos = new();
    
    public static List<string> Area = new() {
        "Programador",
        "Conductor",
        "Docente",
        "Pintor",
        "Chef"
    };

    //Metodos
    public void Suscribir(IInteresados interesados) 
    {
        Candidatos.Add(interesados);
    }

    public void Desuscribir(IInteresados interesados) 
    {
        Candidatos.Remove(interesados);
    }

    public void Notificar() 
    {
        if (Estatus == true)
        {
            foreach (var elemento in Candidatos)
            {
                elemento.actualizar();
            }
        }
        else
        {
            Console.WriteLine("No hay vacantes disponibles");
        }   
    }
}

