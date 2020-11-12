public class ServicioDiversion : Servicio
{
    public override double Costo()
    {
        double costo = 500;
        if (cantidadAnimadores == 2)
        {
            costo = 1000;
        }
        else if (cantidadAnimadores >= 3)
        {
            costo = 1500;
        }
        return costo;
    }
}
