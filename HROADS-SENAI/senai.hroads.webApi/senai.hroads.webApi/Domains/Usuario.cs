using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade Usuario
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }
        public int idTpoUsuario { get; set; }

        [Column("varchar(100)")]
        [Required(ErrorMessage ="O nome de usuário é obrigatório!")]
        public string nomeUsuario { get; set; }

        [Column("varchar(256)")]
        [Required(ErrorMessage = "O email do usuário é obrigatório!")]
        public string email { get; set; }

        [Column("varchar(12)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatório!")]
        [StringLength(12,MinimumLength =8, ErrorMessage ="A senha deve conter entre 8 e 12 caracteres")]
        public string senha { get; set; }

        [ForeignKey("idTipoUsuario")]
        public TiposUsuario tipoUsuario { get; set; }
    }
}
