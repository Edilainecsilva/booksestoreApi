using System;
using System.Collections.Generic;

namespace booksestoreApi.Models;

public partial class Resume
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Description { get; set; }
}
