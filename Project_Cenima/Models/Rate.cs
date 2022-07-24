using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project_Cenima.Models
{
    public partial class Rate
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Comment { get; set; }

        [Range(0, 10, ErrorMessage = " Điểm đánh giá 0.0 - 10.0")]
        public double? NumericRating { get; set; }
        public DateTime? Time { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
    }
}
