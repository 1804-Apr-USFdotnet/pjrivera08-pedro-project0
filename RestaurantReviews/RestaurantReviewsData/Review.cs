//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantReviewsData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ID { get; set; }
        public int restaurantID { get; set; }
        public string reviewerName { get; set; }
        public string reviewText { get; set; }
        public double reviewScore { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
