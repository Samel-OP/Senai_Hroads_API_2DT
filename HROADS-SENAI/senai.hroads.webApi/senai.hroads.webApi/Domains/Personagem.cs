
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




    [Table("Habilidade")]
    public class Personagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersonagem { get; set; }

        public int idClasse { get; set; }
    }
}
