//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class city
    {
        public city()
        {
            this.properties = new HashSet<property>();
            this.users = new HashSet<user>();
        }
        [Required(ErrorMessage = "The City Name is required")]
        public int cityID { get; set; }
        public string cityName { get; set; }
    
        public virtual ICollection<property> properties { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}
