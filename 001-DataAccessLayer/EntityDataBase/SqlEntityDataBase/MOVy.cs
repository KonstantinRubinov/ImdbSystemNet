//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImdbSystem.EntityDataBase.SqlEntityDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOVy
    {
        public string movieImdbID { get; set; }
        public string movieTitle { get; set; }
        public string moviePoster { get; set; }
        public int movieYear { get; set; }
        public string userID { get; set; }
    
        public virtual MOVIEEXTEND MOVIEEXTEND { get; set; }
        public virtual USER USER { get; set; }
    }
}