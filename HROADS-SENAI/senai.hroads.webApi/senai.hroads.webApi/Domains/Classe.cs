using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade Classe do personagem
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("Classe")]
    public class Classe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClasse { get; set; }

        [Column(TypeName ="varchar(75)")]
        [Required(ErrorMessage ="O nome da classe é obrigatório!")]
        public string nomeClasse { get; set; }
    }
}
