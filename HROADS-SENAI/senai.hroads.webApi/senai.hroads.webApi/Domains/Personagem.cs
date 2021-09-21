
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Domains
{
    /// <summary>
    /// Classe que representa a entidade classe habilidade.
    /// </summary>
    ///
    
    //PROPRIEDADES

    // idPersonagem
    // idClasse
    // NomePersonagem
    // capacidadeDeVidaMax
    // capacidadeDeManaMax
    // dataUtilizacao
    // dataCriacao

    [Table("Personagem")]
    public class Personagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersonagem { get; set; }

        public int idClasse { get; set; }

        [Column(TypeName = "VARCHAR(70)" )] //tipo de dado da coluna
        [Required(ErrorMessage ="O campo é obrigatório !")] //not null
        public string NomePersongaem { get; set; }
           
        [Column(TypeName = "SMALLINT")]
        [Required(ErrorMessage = "O campo é obrigatório !")]
        public int capacidadeDeVidaMax { get; set; }

        [Column(TypeName = "TINYINT")]
        [Required(ErrorMessage = "O campo é obrigatório !")]
        public int capacidadeDeManaMax { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = " O campo é obrigatório !")]
        public DateTime dataUtilizacao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "O campo é obrigatório !")]
        public DateTime dataCriacao { get; set; }

        [ForeignKey("idClasse")]
        public Classe classe { get; set; }

       
    }
}
