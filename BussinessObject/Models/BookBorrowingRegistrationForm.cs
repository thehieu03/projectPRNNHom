using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class BookBorrowingRegistrationForm
{
    public int BookRegistrationForm { get; set; }

    public int? Id { get; set; }

    public int? BookId { get; set; }

    public DateOnly? LoanBorowing { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual User? IdNavigation { get; set; }

    public virtual ICollection<LateFee> LateFees { get; set; } = new List<LateFee>();
}
