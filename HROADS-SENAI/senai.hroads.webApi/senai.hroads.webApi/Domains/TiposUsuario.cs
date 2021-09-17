using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade TiposUsuario
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoUsuario { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required(ErrorMessage ="O título de tipo usuário é obrigatório!")]
        public string tituloTipoUsuario { get; set; }
    }
}
