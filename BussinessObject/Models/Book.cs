using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public byte[]? BookImg { get; set; }

    public string? BookDescription { get; set; }

    public int? AuthorId { get; set; }

    public int? Quantity { get; set; }

    public int? CategoryId { get; set; }

    public int? Count { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<BookBorrowingRegistrationForm> BookBorrowingRegistrationForms { get; set; } = new List<BookBorrowingRegistrationForm>();

    public virtual CategoryBook? Category { get; set; }
}
