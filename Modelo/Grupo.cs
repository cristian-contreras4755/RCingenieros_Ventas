using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Grupo")]
    public partial class Grupo
    {


        public Grupo()
        {
            Cliente = new HashSet<Cliente>();
        }

        [Key]
        public int IdGrupo { get; set; }

        [StringLength(100)]
        public string NombreGrupo { get; set; }
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(20)]
        public string NroDocumento { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

    }
}
