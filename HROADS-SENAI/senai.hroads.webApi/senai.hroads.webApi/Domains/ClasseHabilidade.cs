using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade ClasseHabilidade
    /// </summary>
    /// 

    //Nome da tabela que será criada no banco de dados
    [Table("ClasseHabilidade")]
    public class ClasseHabilidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClasseHabilidade { get; set; }

        public int idClasse { get; set; }

        public int idHabilidade { get; set; }

        [ForeignKey("idClasse")]
        public Classe classe { get; set; }

        [ForeignKey("idHabilidade")]
        public Habilidade habilidade { get; set; }
    }
}
