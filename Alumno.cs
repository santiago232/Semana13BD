using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13BDk
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Telefono { get; set; }
        public int IdCarrera { get; set; }

        public string NombreCarrera { get; set; }
    }
}

