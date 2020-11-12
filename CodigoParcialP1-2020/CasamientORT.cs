public class CasamientORT
{
    // PARTE A)

    public List<Cliente> ClientesConMenosFiestas()
    {
        List<Cliente> clientesBuscados = new List<Cliente>();
        int menorCantidadFiestas = Integer.MAX_VALUE;

        foreach (Cliente cli in listaClientes)
        {
            if (cli.Fiestas.Count() < menorCantidadFiestas)
            {
                clientesBuscados.Clear();
                clientesBuscados.Add (cli);
                menorCantidadFiestas = cli.Fiestas.Count();
            }
            else if (cli.Fiestas.Count() == menorCantidadFiestas)
            {
                clientesBuscados.Add (cli);
            }
        }

        return clientesBuscados;
    }

    // PARTE B)
    // Otra forma podria habar sido agregando una listaDeClientes en la clase servicio
    // buscando el servicion con la funcion BuscarServicio
    // y recorrer la listaDeClientes del servicio buscado
    public List<Cliente> ClientesQueContrataronUnServicio(string nombreServicio)
    {
        List<Cliente> clientesBuscados = new List<Cliente>();
        foreach (Cliente cli in listaClientes)
        {
            foreach (Fiesta f in cli.Fiestas)
            {
                foreach (Servicio s in f.Servicios)
                {
                    if (s = BuscarServicio(nombreServicio) && !clientesBuscados.Contains(cli))
                    {
                        clientesBuscados.Add (cli);
                    }
                }
            }
        }

        return clientesBuscados;
    }

    public Servicio BuscarServicio(string nombreServicio)
    {
        Servicio unServicio = new Servicio();
        foreach (Servicio s in listaServicios)
        {
            if (s.Nombre == nombreServicio)
            {
                unServicio = s;
            }
        }
    }


    // PARTE C

    public double ImporteTotalDeTodasLasFiestasClientesReferentes(){
        double importeTotal=0.0;
        foreach(Fiesta f in listaFiestas){
            if(f.UnCliente.EsReferente){
                importeTotal+= f.CostoTotal();
            }
        }
        return importeTotal;
    }



}
