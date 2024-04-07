using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtTokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly LetterDBContext _context;

        public JwtTokenController(IConfiguration configuration , LetterDBContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        //[HttpPost]
        //public async Task<IActionResult> GenerateToken(User user)
        //{
        //    if (user !=null && user.UserName !=null && user.Password != null)
        //    {
        //        var userDate = await GetUserInfo(user.UserName, user.Password);
        //        var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
        //        if (user != null)
        //        {
        //            var claims = new[]
        //            {
        //                new Claim(JwtRegisteredClaimNames.Sub , jwt.Subject),
        //                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
        //                new Claim(JwtRegisteredClaimNames.Iat , DateTime.UtcNow.ToString()),
        //                new Claim("Id" , user.UserId.ToString()),
        //                new Claim("UserName" , user.UserName),
        //                new Claim("Password" , user.Password)



        //            };
        //            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
        //            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //            var token = new JwtSecurityToken(
        //                jwt.Issuer,
        //                jwt.Audience,
        //                claims,
        //                expires: DateTime.Now.AddDays(20),
        //                signingCredentials: signIn
        //                );
        //            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

        //        }
        //        else
        //        {
        //            return BadRequest("Incorrect Credentials");

        //        }
        //    }
        //    else
        //    {
        //        return BadRequest("Incorrect Credentials");
        //    }
        //}


        [HttpPost]
        public async Task<IActionResult> GenerateToken(User user)
        {
            if (user != null && !string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password))
            {
                // Retrieve user information from the database based on username and password
                var userData = await GetUserInfo(user.UserName, user.Password);

                if (userData != null)
                {
                    // Include user role determination logic here

                    // Hardcoded role for demonstration purposes
                    var role = "Admin";

                    var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

                    var claims = new[]
                    {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Id", userData.UserId.ToString()),
                new Claim("UserName", userData.UserName),
                new Claim(ClaimTypes.Role, role) // Include hardcoded role claim
            };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        jwt.Issuer,
                        jwt.Audience,
                        claims,
                        expires: DateTime.Now.AddDays(20),
                        signingCredentials: signIn
                    );

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Incorrect Credentials");
                }
            }
            else
            {
                return BadRequest("Incorrect Credentials");
            }
        }


        [HttpGet]
        public async Task<User> GetUserInfo(string username ,string password)
        {
            return await _context.UserInfo.FirstOrDefaultAsync(x => x.UserName == username && x.Password == password);
        }
    }
}
