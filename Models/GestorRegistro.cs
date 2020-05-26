using System.Collections.Generic;

namespace PM___Semana_6.Models
{
    public class GestorRegistro
    {
        private List<Registro> _Registro;

        public GestorRegistro(){
            _Registro = new List<Registro>();

            _Registro.Add(new Registro{ID = 1,Nombre ="Mauricio", Usuario="Roco Popo"});
            _Registro.Add(new Registro{ID = 2,Nombre ="Mario", Usuario="Kkaricio"});
            _Registro.Add(new Registro{ID = 3,Nombre ="Mamiro", Usuario="Uke"});
        }
    }
}