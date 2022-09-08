using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softcaribbeanPruebaTecnica.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cddocumento { get; set; }
        public string Dsnombres { get; set; }
        public string Dsapellidos { get; set; }
        public string Fenacimiento { get; set; }
        public string Cdgenero { get; set; }
        public string Feregistro { get; set; }
        public string Febaja { get; set; }
        public string Cdusuario { get; set; }
        public string Dsdireccion { get; set; }
        public string Dsphoto { get; set; }
        public string Cdtelefono_Fijo { get; set; }
        public string Cdtelefono_Movil { get; set; }
        public string Dsemail { get; set; }
        public string Dseps { get; set; }
        public string Dsarl { get; set; }
        public string Dscondicion { get; set; }
        public int Cdtipo { get; set; }
    }
}
