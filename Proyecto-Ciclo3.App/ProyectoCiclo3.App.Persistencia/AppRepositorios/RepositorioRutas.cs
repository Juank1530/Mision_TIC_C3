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
                new Rutas{id=1,origen= "Norte",destino= "Occidente" ,tiempo_estimado= 4.0},
                new Rutas{id=2,origen= "Sur",destino= "Oeste",tiempo_estimado= 3.0},
                new Rutas{id=3,origen= "Oriente",destino= "Sur Occidente",tiempo_estimado= 6.0}
            };
        }

        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }

        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        //Esto se pego acá nuevo y lo paso el profe 
        public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
            }
        return ruta;
        }


    }
}
