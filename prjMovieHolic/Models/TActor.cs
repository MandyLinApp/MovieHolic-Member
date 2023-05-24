using System;
using System.Collections.Generic;

namespace prjMovieHolic.Models;

public partial class TActor
{
    public int FId { get; set; }

    public string? FNameCht { get; set; }

    public string? FNameEng { get; set; }

    public string? FImagePath { get; set; }

    public virtual ICollection<TActorList> TActorLists { get; set; } = new List<TActorList>();
}
