public class ServicioGastronomia : Servicio
{
    public override double Costo()
    {
        double costo=0;
        
        if(esDeBebidasAlcoholicas){
            costo=1891;
        }

        return costo;
    }
}