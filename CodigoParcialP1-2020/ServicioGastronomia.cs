public class ServicioGastronomia : Servicio
{
    public override double Costo()
    {
        double costo=0.0;
        
        if(esDeBebidasAlcoholicas){
            costo=1891.0;
        }

        return costo;
    }
}