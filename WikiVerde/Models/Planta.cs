﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WikiVerde.Models
{
    public class Planta
    {
        public Guid Id { get; set; }
        [DefaultValue(false)]
        [Display(Name = "Pendente")]
        public bool IsPendente { get; set; }
         public string Regiao { get; set; }
         public double MaxPeso { get; set; }
         public double MaxAltura { get; set; }
         public double MinPeso { get; set; }
         public double MinAltura { get; set; }
        [Display(Name = "Média de preço")]
        public double Price { get; set; }
        [DefaultValue(false)]
        [Display(Name = "Perene")]
        public bool IsPerene { get; set; }
         public int QtdRegasSemanais { get; set; }
        [Required(ErrorMessage = "O campo Nome cientifíco é obrigatório.")]
        [Display(Name = "Nome cientifíco")]
        public string NomeCientifico { get; set; }
        [Display(Name = "Nome popular")]
        public string NomePopular { get; set; }
        [Display(Name = "Descrição da Espécie")]
        [DataType(DataType.MultilineText)]
        public string DscEspecie { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descrição do manejo")]
        public string DscManejo { get; set; }
        [Display(Name = "Como produzir mudas")]
        public string DscMuda { get; set; }
        public string PastaFotos { get; set; }
        public string LinksReferencias { get; set; }
        [DefaultValue(false)]
        [Display(Name = "Meia sombra")]
        public bool IsMeiaSombra { get; set; }
        [DefaultValue(false)]
        [Display(Name = "Sol pleno")]
        public bool IsSolPleno { get; set; }

    }
}
