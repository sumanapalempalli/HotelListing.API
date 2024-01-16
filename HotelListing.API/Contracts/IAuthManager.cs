using HotelListing.API.Models.ApiUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto apiUserDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
