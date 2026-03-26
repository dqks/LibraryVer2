using System;
using System.Collections.Generic;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library;

public partial class LibraryShtinContext : DbContext
{
    public LibraryShtinContext()
    {
    }

    public LibraryShtinContext(DbContextOptions<LibraryShtinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookLoan> BookLoans { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=library_shtin;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("authors_pkey");

            entity.ToTable("authors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorName).HasColumnName("author_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annotation).HasColumnName("annotation");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.ExamplesAmount).HasColumnName("examples_amount");
            entity.Property(e => e.IdAuthor).HasColumnName("id_author");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");
            entity.Property(e => e.IdPublisher).HasColumnName("id_publisher");
            entity.Property(e => e.Isbn).HasColumnName("isbn");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PagesAmount).HasColumnName("pages_amount");
            entity.Property(e => e.PublicYear).HasColumnName("public_year");

            entity.HasOne(d => d.IdAuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_author_fkey");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_genre_fkey");

            entity.HasOne(d => d.IdPublisherNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPublisher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("books_id_publisher_fkey");
        });

        modelBuilder.Entity<BookLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("book_loans_pkey");

            entity.ToTable("book_loans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualReturnDate).HasColumnName("actual_return_date");
            entity.Property(e => e.GiveDate).HasColumnName("give_date");
            entity.Property(e => e.IdBook).HasColumnName("id_book");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.PlannedReturnDate).HasColumnName("planned_return_date");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("book_loans_id_book_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("book_loans_id_user_fkey");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreName).HasColumnName("genre_name");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("publishers_pkey");

            entity.ToTable("publishers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PublisherName).HasColumnName("publisher_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.ReadTicket).HasColumnName("read_ticket");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
