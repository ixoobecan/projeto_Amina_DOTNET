﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AminaApi.Src.Modelos
{
    [Table("tb_grupo")]
    public class Grupo
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Topico { get; set; }

        public string Midia { get; set; }

        [ForeignKey("fk_usuario")]
        public Usuario Usuario { get; set; }
        #endregion
    }
}
