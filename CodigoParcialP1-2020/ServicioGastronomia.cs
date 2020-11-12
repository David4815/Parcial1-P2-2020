public class ServicioGastronomia : Servicio
{
    public override double Costo()
    {
        double costo=0;
        
        if(esDeBebidasAlcoholicas){
            costo=500
        }
        
        return costo;
    }
}