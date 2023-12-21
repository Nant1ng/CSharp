using System;
using System.Collections.Generic;

namespace LSO.Data;

public partial class Kur
{
    public int Id { get; set; }

    public string? Namn { get; set; }

    public bool IsActive { get; set; } = true;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
