//Fig. 10: EmpleadoPorComision.cs
//La clase EmpleadoPorComision representa a un empleado por comision.
public class EmpleadoPorComision : object
{
    private string primerNombre;
    private string apellidoPaterno;
    private string numeroSeguroSocial;
    private decimal ventasBrutas; //ventas semanales totales
    private decimal tarifaComision; //porcentaje de comision

    //constructor con cinco parametros
    public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
    {
        //la llamada implicita al constructor del objeto ocurre aqui
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        ventasBrutas = ventas; //valida las ventas brutas mediante una propiedad
        tarifaComision = tarifa; //valida la tarifa de comision mediante una propiedad
    } //fin del constructor de EmpleadoPorComision con cinco parametros

    //propiedad e solo lectura que obtiene el primer nombre del empleado por comision
    public string PrimerNombre
    {
        get
        {
            return primerNombre;
        }
    }

    public string ApellidoPaterno
    {
        get
        {
            return apellidoPaterno;
        }
    }

    public string NumeroSeguroSocial
    {
        get
        {
            return numeroSeguroSocial;
        }
    }

    public decimal VentasBrutas
    {
        get
        {
            return ventasBrutas;
        }
        set
        {
            ventasBrutas = (value < 0) ? 0 : value;
        }
    }

    public decimal tarifaComision
    {
        get
        {
            return tarifaComision
        }
        set
        {
            tarifaComision = (value > && value < 1) ? value : 0;
        }
    }

    //calcula el saladio del empleado por comision
    public decimal Ingresos()
    {
        return tarifaComision * ventasBrutas;
    }

    //devuelve la rrepresentacion string del objeto EmpleadoPorComision
    public override string ToString()
    {
        return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "numero de seguro social", NumeroSeguroSocial,
            "ventas brutas", Ventas Brutas, "tarifa de comison", TarifaComusion);
    }
}