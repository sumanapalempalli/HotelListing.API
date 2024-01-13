﻿using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repositories
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListAPIDbContext context) : base(context)
        {
        }
    }
}
