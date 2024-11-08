using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BussinessObject.Models;

public partial class ProjectPrn211Context : DbContext
{
    public ProjectPrn211Context()
    {
    }

    public ProjectPrn211Context(DbContextOptions<ProjectPrn211Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookBorrowingRegistrationForm> BookBorrowingRegistrationForms { get; set; }

    public virtual DbSet<CategoryBook> CategoryBooks { get; set; }

    public virtual DbSet<LateFee> LateFees { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HIEU;Initial Catalog=ProjectPrn211;Persist Security Info=True;User ID=sa;Password=123;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.ToTable("Author");

            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(50)
                .HasColumnName("author_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.BookDescription).HasColumnName("book_description");
            entity.Property(e => e.BookImg).HasColumnName("book_img");
            entity.Property(e => e.BookName)
                .HasMaxLength(50)
                .HasColumnName("book_name");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_Book_Author");

            entity.HasOne(d => d.Category).WithMany(p => p.Books)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Book_CategoryBook");
        });

        modelBuilder.Entity<BookBorrowingRegistrationForm>(entity =>
        {
            entity.HasKey(e => e.BookRegistrationForm);

            entity.ToTable("BookBorrowingRegistrationForm");

            entity.Property(e => e.BookRegistrationForm).HasColumnName("book_registration_form");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LoanBorowing).HasColumnName("loan_borowing");
            entity.Property(e => e.PaymentDate).HasColumnName("payment_date");

            entity.HasOne(d => d.Book).WithMany(p => p.BookBorrowingRegistrationForms)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_BookBorrowingRegistrationForm_Book");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.BookBorrowingRegistrationForms)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_BookBorrowingRegistrationForm_User");
        });

        modelBuilder.Entity<CategoryBook>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("CategoryBook");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<LateFee>(entity =>
        {
            entity.HasKey(e => e.LateFreeId);

            entity.ToTable("LateFee");

            entity.Property(e => e.LateFreeId).HasColumnName("lateFree_id");
            entity.Property(e => e.BookRegistrationForm).HasColumnName("book_registration_form");
            entity.Property(e => e.DueDate).HasColumnName("due_date");
            entity.Property(e => e.FineAmount).HasColumnName("fine_amount");
            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.BookRegistrationFormNavigation).WithMany(p => p.LateFees)
                .HasForeignKey(d => d.BookRegistrationForm)
                .HasConstraintName("FK_LateFee_BookBorrowingRegistrationForm");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.LateFees)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_LateFee_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.PassWord).HasColumnName("pass_word");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserAddress)
                .HasMaxLength(100)
                .HasColumnName("user_address");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
