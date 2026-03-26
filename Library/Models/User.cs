using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string ReadTicket { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
