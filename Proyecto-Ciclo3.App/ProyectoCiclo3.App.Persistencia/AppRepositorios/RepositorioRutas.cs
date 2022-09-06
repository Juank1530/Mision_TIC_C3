using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;


namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen= "Norte",destino= "Occidente" ,tiempo_estimado= 400},
                new Rutas{id=2,origen= "Sur",destino= "Oeste",tiempo_estimado= 450},
                new Rutas{id=3,origen= "Oriente",destino= "Sur Occidente",tiempo_estimado= 600}
            };
        }

        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }

        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
    }
}
