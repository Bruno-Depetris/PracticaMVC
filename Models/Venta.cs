using System;
using System.Collections.Generic;

namespace PracticaMVC.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public int ClienteId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
}
