using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Persona
{
    public string Id { get; set; } = null!;

    public string? Nombre { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? IdDocumento { get; set; }

    public virtual TipoDocumento? IdDocumentoNavigation { get; set; }

    public virtual ICollection<UbicacionPersona> UbicacionPersonas { get; set; } = new List<UbicacionPersona>();
}
