using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TipoDocumento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
