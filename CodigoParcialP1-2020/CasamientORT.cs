public class CasamientORT
{
    // PARTE A)
    public List<Cliente> ClientesConMenosFiestas()
    {
        List<Cliente> clientesBuscados = new List<Cliente>();
        int menorCantidadFiestas = Integer.MAX_VALUE;

        foreach (Cliente cli in listaClientes)
        {
            if (cli.fiestas.Count() < menorCantidadFiestas)
            {
                clientesBuscados.Clear();
                clientesBuscados.Add (cli);
                menorCantidadFiestas = cli.fiestas.Count();
            }
            else if (cli.fiestas.Count() == menorCantidadFiestas)
            {
                clientesBuscados.Add (cli);
            }
        }
        
        return clientesBuscados;
    }




}
