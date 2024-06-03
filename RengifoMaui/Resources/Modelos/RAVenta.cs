using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RengifoMaui.Resources.Modelos
{
    internal class RAVenta
    {
        //variables
        public string ? Nombres { get; set; }
        public int ? Telefono { get; set; }
        public List<string> Companias = new List<string>() { "Movistar", "Claro", "Tuenti" };
        public string ? Operador { get; set; }
        
        
        //constructores
        public RAVenta() 
        
        {
            Nombres = null;
            Telefono =0;
            this.Operador = null;
        }

        public RAVenta( string _Nombres,int _Telefono,string _Operador) 
        { 
           this.Nombres = _Nombres;
            this.Telefono = _Telefono;
            this.Operador = _Operador;
        }
        // metodos


    }
}
