﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Ubicacion
    {
        [Key, ForeignKey(nameof(UbicacionDelEcosistema))]
        public string? NombreEcosistema { get; set; }
        public decimal? Latitud { get; set;}
        public decimal? Longitud { get; set;}
        public EcosistemaMarino? UbicacionDelEcosistema {get; set;}
    }
}
