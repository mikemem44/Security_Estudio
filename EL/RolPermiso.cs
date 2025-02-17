using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolPermiso")]
	public class RolPermiso
	 {
		[Key]
		public int IdRolPermiso { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public int IdPermiso { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int IdUsuarioRegistra { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? IdUsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}
