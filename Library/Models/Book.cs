using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Isbn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdAuthor { get; set; }

    public int IdGenre { get; set; }

    public int IdPublisher { get; set; }

    public int PublicYear { get; set; }

    public int PagesAmount { get; set; }

    public int ExamplesAmount { get; set; }

    public int Available { get; set; }

    public string Annotation { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Author IdAuthorNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual Publisher IdPublisherNavigation { get; set; } = null!;
}
