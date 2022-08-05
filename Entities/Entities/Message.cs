using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_MESSAGE")]
    public class Message : Notifies
    {
        [Column("MSM_ID")]
        public int Id { get; set; }

        [Column("MSM_TITULO")]
        public string Title { get; set; }

        [Column("MSM_ATIVO")]
        public bool Ativo { get; set; }

        [Column("MSM_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("MSM_DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [ForeignKey("AplicationUser")]
        [Column(Order =1)]
        public string UserId { get; set; }

        //fazendo a ligação da tabelas
        public virtual AplicationUser AplicationUser { get; set; }
    }
}
