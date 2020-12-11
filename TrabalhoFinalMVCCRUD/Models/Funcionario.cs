using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinalMVCCRUD.Models
{
    public class Funcionario
    {
        
        [Key]
        public int IdFuncionario { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Esse campo é obrigatório.")]

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Esse campo é obrigatório.")]

        [DisplayName("Nome Login")]
        public string NomeLogin { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Esse campo é obrigatório.")]

        [DisplayName("Cargo")]
        public string Cargo { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        public string Localizacao { get; set; }
    }


}
