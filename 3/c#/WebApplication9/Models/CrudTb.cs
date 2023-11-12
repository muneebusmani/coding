using System;
using System.Collections.Generic;

namespace WebApplication9.Models;

public partial class CrudTb
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Gender { get; set; } = null!;
}
