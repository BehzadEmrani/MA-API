using System;
using Microsoft.AspNetCore.Identity;

public class ApplicationRole : IdentityRole<int>
{
    public string Description { get; set; }
}
