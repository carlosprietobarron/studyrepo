using System;
using System.Collections.Generic;
namespace bookingApi.classes
{
    public partial class HotelBookings
    {
        public int BookingId { get; set; }
        public int? HotelId { get; set; }
        public DateTime? ChekInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? UserId { get; set; }
        public string PaymentMode { get; set; }
        public string InvoiveNumber { get; set; }
        public DateTime? BookingDate { get; set; }
        public decimal? Amount { get; set; }
        public Hotels Hotel { get; set; }
    }
}

