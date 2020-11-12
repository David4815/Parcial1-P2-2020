public class Fiesta{

public double CostoTotal(){

    double costo=cantidadPersonas * servicios.Count();
     if(unCliente.esReferente){
         costo*= 0.95;
     }
     foreach(Servicio s in servicios){
         costo+=s.Costo();
     }

    return costo;
}

}


// public class Fiesta{

// public double CostoTotal(){

//     double costo=cantidadPersonas * servicios.Count();
//     if(unCliente.esReferente){
//         costo*= 0.95;
//     }

//     costo+= 

//     return costo;
// }

// }