﻿using System;
using System.Collections.Generic;
namespace bookingApi.classes
{
    public partial class Hotels
    {
        public Hotels()
        {
            HotelBookingDdds = new HashSet<HotelBookingDdds>();
            HotelFacilities = new HashSet<HotelFacilities>();
            HotelImageGallery = new
            HashSet<HotelImageGallery>();
            HotelRooms = new HashSet<HotelRooms>();
        }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Description { get; set; }
        public string HotelPolicy { get; set; }
        public int? Ratings { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string PrimaryContactPerson { get; set; }
        public string Address { get; set; }
        public int? CategoryId { get; set; }
        public HotelCategories Category { get; set; }
        public ICollection<HotelBookingDdds>
        HotelBookingDdds
        { get; set; }
        public ICollection<HotelFacilities> HotelFacilities
        { get; set; }
        public ICollection<HotelImageGallery>
        HotelImageGallery
        { get; set; }
        public ICollection<HotelRooms> HotelRooms
        { get; set; }
    }
}
}

