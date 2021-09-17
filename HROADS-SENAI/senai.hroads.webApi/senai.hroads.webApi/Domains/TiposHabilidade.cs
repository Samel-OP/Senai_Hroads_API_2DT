using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade TiposHabilidade
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("TiposHabilidade")]
    public class TiposHabilidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoHabilidade { get; set; }

        [Column(TypeName ="varchar(100)")]
        [Required(ErrorMessage ="O título de tipo habilidade é obrigatório")]
        public string tituloTipoHabilidade { get; set; }
    }
}
