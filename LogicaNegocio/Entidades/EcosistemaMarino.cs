using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class EcosistemaMarino
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? DetalleUbicacionGeo { get; set; }

        public int AreaEcosistema { get; set; }

        public string? DescripcionSusCaracteristicasUnicas { get; set; }

        private List<EspecieMarina>? EspeciesQueAbitan { get; set; }

        public List<Amenaza>? AmenazasAesteEcosistenma { get; set; }

        public byte ImagenEcosistema { get; set; }
    }
}
