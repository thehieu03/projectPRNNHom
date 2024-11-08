using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class LateFee
{
    public int LateFreeId { get; set; }

    public int? Id { get; set; }

    public int? BookRegistrationForm { get; set; }

    public double? FineAmount { get; set; }

    public DateOnly? DueDate { get; set; }

    public virtual BookBorrowingRegistrationForm? BookRegistrationFormNavigation { get; set; }

    public virtual User? IdNavigation { get; set; }
}
