using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
	 public class BDInformaticSecuriy:DbContext
	{
		public BDInformaticSecuriy():base(Conexion.ConexionString(true)){}
		 public virtual DbSet<Formularios> Formularios{get;set;}
		 public virtual DbSet<Permisos> Permisos{get;set;}
		 public virtual DbSet<Roles> Roles{get;set;}
		 public virtual DbSet<RolFormulario> RolFormulario{get;set;}
		 public virtual DbSet<RolPermiso> RolPermiso{get;set;}
		 public virtual DbSet<Usuarios> Usuarios{get;set;}
		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Formularios>().Property(e => e.NombreFormulario).IsUnicode(false);
			modelBuilder.Entity<Permisos>().Property(e => e.NombrePermiso).IsUnicode(false);
			modelBuilder.Entity<Roles>().Property(e => e.NombreRol).IsUnicode(false);
			modelBuilder.Entity<Usuarios>().Property(e => e.NombreCompleto).IsUnicode(false);
			modelBuilder.Entity<Usuarios>().Property(e => e.Correo).IsUnicode(false);
			modelBuilder.Entity<Usuarios>().Property(e => e.NombreUsuario).IsUnicode(false);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			 base.OnModelCreating(modelBuilder);
		}
		}
	}
