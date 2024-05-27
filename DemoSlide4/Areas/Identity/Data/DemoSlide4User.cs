using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DemoSlide4.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DemoSlide4User class
public class DemoSlide4User : IdentityUser
{
    [PersonalData]
    [Column(TypeName ="nvarchar(50)")]
    public string firstName {  get; set; }

    [PersonalData]
    [Column(TypeName ="NVARCHAR(50)")]
    public string lastName { get; set; }


}

