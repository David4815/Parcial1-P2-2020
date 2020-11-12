public class ServicioDiversion : Servicio
{
    public override double Costo()
    {
        double costo = 500.0;
        if (cantidadAnimadores == 2)
        {
            costo = 1000.0;
        }
        else if (cantidadAnimadores >= 3)
        {
            costo = 1500.0;
        }
        return costo;
    }
}
