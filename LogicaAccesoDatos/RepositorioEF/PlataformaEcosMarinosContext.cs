using LogicaNegocio.Entidades;
using LogicaNegocioUsuario.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.RepositorioEF
{
    public class PlataformaEcosMarinosContext : DbContext
    {
        public DbSet<EspecieMarina> EspeciesMarinas { get; set; }
        public DbSet<EcosistemaMarino> EcosistemasMarinos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Amenaza> Amenazas { get; set; }
        public DbSet<EstadoDeConservacion> EstadosDeConservacion { get; set; }
        public DbSet<DataModificationBank> DataModificacionBank { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion = @"SERVER=(LocalDb)\MsSqlLocalDb;DATABASE=PlataformaEcosistemaMarino2023V01;INTEGRATED SECURITY=TRUE;ENCRYPT=FALSE";
            optionsBuilder.UseSqlServer(cadenaConexion);
        }

    }
}
