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
                new Estaciones{id=2,nombre="Estación Estadio",direccion= "Calle 98 56 36",Coord_x= 12.859,Coord_y= 45.896, tipo= "Secundaria"},
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

        //Esto se pego acá nuevo y lo paso el profe 
        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.Coord_x = newEstacion.Coord_x;
                estacion.Coord_y = newEstacion.Coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;
        }

        public Estaciones Create(Estaciones newEstacion)
        {
           if(estaciones.Count > 0){
           newEstacion.id=estaciones.Max(r => r.id) +1; 
            }else{
               newEstacion.id = 1; 
            }
           estaciones.Add(newEstacion);
           return newEstacion;
        }

        public Estaciones Delete(int id)
        {
            var estacion= estaciones.SingleOrDefault(e => e.id == id);
            estaciones.Remove(estacion);
            return estacion;
        }






    }
}
