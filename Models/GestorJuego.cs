using System.Collections.Generic;

namespace PM___Semana_6.Models
{
    public class GestorJuego
    {
        private List<Juego> _Juegos;
        
        public GestorJuego(){

            _Juegos = new List<Juego>();
            
            _Juegos.Add(new Juego{ID = 1, Nombre = "Dota", Precio = 20, Genero = "Moba"});  
            _Juegos.Add(new Juego{ID = 2, Nombre = "Dota 2", Precio = 30, Genero = "Moba"});  
            _Juegos.Add(new Juego{ID = 3, Nombre = "Half Life", Precio = 20, Genero = "RPG"});  
            _Juegos.Add(new Juego{ID = 4, Nombre = "Half Life 2", Precio = 30, Genero = "RPG"});  
            _Juegos.Add(new Juego{ID = 5, Nombre = "Half Life 3", Precio = 50, Genero = "RPG"});  

        } 
    }
}