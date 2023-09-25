using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Ciudad
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? IddepartamentoFk { get; set; }

    public virtual Departamento? IddepartamentoFkNavigation { get; set; }

    public virtual ICollection<UbicacionPersona> UbicacionPersonas { get; set; } = new List<UbicacionPersona>();
}
