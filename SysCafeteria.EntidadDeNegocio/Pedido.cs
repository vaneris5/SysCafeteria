using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SysCafeteria.EntidadesDeNegocio;

namespace SysCafeteria.EntidadDeNegocio;

public partial class Pedido
{
    [Key]
    public int Id { get; set; }

	[ForeignKey("IdUsuario")]
	[Required(ErrorMessage = "Usuario es obligatorio")]
	[Display(Name = "Usuario")]
	public int IdUsuario { get; set; }
	public Usuario Usuario { get; set; }

	[Required(ErrorMessage = "Fecha es obligatoria")]
	[Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

	[ForeignKey("IdProducto")]
	[Required(ErrorMessage = "Producto es obligatorio")]
	[Display(Name = "Producto")]
	public int IdProducto { get; set; }
	public Producto Producto { get; set; }

	[Required(ErrorMessage = "Cantidad es obligatoria")]
	[Range(0, 100)]
	public int Cantidad { get; set; }

	[Required(ErrorMessage = "Precio Unitario es obligatoria")]
	[Column(TypeName = "decimal(10, 2)")]
    public decimal PrecioUnitario { get; set; }

	[Required(ErrorMessage = "Ubicación de entrega es obligatoria")]
	[StringLength(100, ErrorMessage = "Maximo 100 caracteres para la ubicación")]
    public string Ubicacion { get; set; } = null!;

	[Required(ErrorMessage = "Telefono es obligatorio")]
	[StringLength(9, ErrorMessage = "Maximo 9 caracteres para el telefono (incluido el guión: -")]
    public string Telefono { get; set; } = null!;

	[Required(ErrorMessage = "Costo de Delivery es obligatorio")]
	[Column(TypeName = "decimal(10, 2)")]
    public decimal CostoDelivery { get; set; }
	[NotMapped]
	public int Top_Aux { get; set; }
}
