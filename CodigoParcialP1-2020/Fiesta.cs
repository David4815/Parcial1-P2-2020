public class Fiesta
{
    public double CostoTotal()
    {
        double costo = cantidadPersonas * servicios.Count();
       
        foreach (Servicio s in servicios)
        {
            costo += s.Costo();
        }

         if (unCliente.EsReferente)
        {
            costo *= 0.95;
        }
        return costo;
    }
}

