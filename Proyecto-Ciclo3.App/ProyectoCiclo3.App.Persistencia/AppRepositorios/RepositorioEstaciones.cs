using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;


namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Estación Centro",direccion= "Calle 36 98 56",Coord_x= 10.458,Coord_y= 25.654, tipo= "Principal"},
                new Estaciones{id=2,nombre="Estación Estadio",direccion= "Calle 98 56 36",Coord_x= 12.859,Coord_y= 45.896, tipo= "Secundario"},
                new Estaciones{id=3,nombre="Estación Terminal",direccion= "Carrera 78 59 78",Coord_x= 15.547,Coord_y= 58.658, tipo= "Principal"}
            };
        }

        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }

        public Estaciones GetWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}
