using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;


namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
    public RepositorioBuses()
        {
            buses= new List<Buses>()
            {
                new Buses{id=1,marca="Mercedes Benz",modelo= 2000,kilometraje= 4000,num_asientos= 40, placa= "ACB458"},
                new Buses{id=2,marca="KIA",modelo= 2015,kilometraje= 4500,num_asientos= 45, placa= "SDE852"},
                new Buses{id=3,marca="Ford",modelo= 2022,kilometraje= 6000,num_asientos= 60, placa= "WSA545"}
            };
        }

        public IEnumerable<Buses> GetAll()
        {
            return buses;
        }

        public Buses GetWithId(int id){
            return buses.SingleOrDefault(b => b.id == id);
        }
    }
}