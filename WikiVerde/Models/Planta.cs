﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WikiVerde.Models
{
    public class Planta
    {
        public Guid Id { get; set; }
       /* [Required]
        public bool IsPendente { get; set; }
        public string Regiao { get; set; }
        public double MaxPeso { get; set; }
        public double MaxAltura { get; set; }
        public double MinPeso { get; set; }
        public double MinAltura { get; set; }
        [Required]
        public bool IsPerene { get; set; }
        public int QtdRegasSemanais { get; set; }*/
        [Required]
        public string NomeCientifico { get; set; }
        public string DscEspecie { get; set; }
        public string DscManejo { get; set; }
        /*public string DscMuda { get; set; }
        public string DscReproducao { get; set; }
        public string PastaFotos { get; set; }
        public string LinksReferencias { get; set; }
        [Required]
        public bool IsMeiaSombra { get; set; }
        [Required]
        public bool IsSolPleno { get; set; }*/

    }
}