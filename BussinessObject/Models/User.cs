using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? PassWord { get; set; }

    public string? Email { get; set; }

    public bool? Gender { get; set; }

    public int? RoleId { get; set; }

    public string? UserAddress { get; set; }

    public virtual ICollection<BookBorrowingRegistrationForm> BookBorrowingRegistrationForms { get; set; } = new List<BookBorrowingRegistrationForm>();

    public virtual ICollection<LateFee> LateFees { get; set; } = new List<LateFee>();
}
