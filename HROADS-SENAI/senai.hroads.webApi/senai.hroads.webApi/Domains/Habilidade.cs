using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade Habilidade
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("Habilidade")]
    public class Habilidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idHabilidade { get; set; }

        public int idTipoHabilidade { get; set; }

        [Column(TypeName ="varchar(100)")]
        [Required(ErrorMessage ="O nome da habilidade é obrigatório!")]
        public string nomeHabilidade { get; set; }

        [ForeignKey("idTipoHabilidade")]
        public TiposHabilidade tiposHabilidade { get; set; }
    }
}
