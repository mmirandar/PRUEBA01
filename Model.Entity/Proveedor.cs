using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Proveedor
    {
        private long idProveedor;
        private string nombre;
        [Display(Name = "Apelido Materno")]
        private string apmaterno;

        private string appaterno;
        private string ruc;
        private string direccion;
        private string telefono;
        private int estado;

        public int Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}
