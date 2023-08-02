using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código Artículo")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        //public int IdMarca { get; set; }
        //public int IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public Categoria Categoria  { get; set; }
        public Marca Marca { get; set; }
        public decimal Precio { get; set; }
        
    }
}
