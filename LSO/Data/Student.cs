using System;
using System.Collections.Generic;

namespace LSO.Data;

public partial class Student
{
    public int Id { get; set; }

    public string? Fornamn { get; set; }

    public string? Efternamn { get; set; }

    public DateTime? Birthdate { get; set; }

    public int? KursId { get; set; }

    public bool IsActive { get; set; }

    public virtual Kur? Kurs { get; set; }
}
