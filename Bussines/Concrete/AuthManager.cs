using Bussines.Abstract;
using Bussines.BussinesAspects.Autofac;
using Bussines.Constans;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IRefreshTokenService _refreshToken;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IRefreshTokenService refreshToken)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _refreshToken = refreshToken;
        }
        [SecuredOperation("Admin")]
        public IResultData<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                UserName = userForRegisterDto.UserName,
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true,
                BranchId= userForRegisterDto.BranchId,
                OrganizationId = userForRegisterDto.OrganizationId,
                JopId = userForRegisterDto.JopId

            };
            _userService.Add(user);
            return new SuccessResultData<User>(user, Messages.UserRegistered);
        }

        public IResultData<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorResultData<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorResultData<User>(Messages.PasswordError);
            }

            return new SuccessResultData<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(false,Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IResultData<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user.Id);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            Result result =setRefreshToken(user.Id, accessToken.RefreshToken);
            if (result.IsValid)
            {
                return new SuccessResultData<AccessToken>(accessToken, Messages.AccessTokenCreated);
            }
            else
            {
                return new ErrorResultData<AccessToken>(null, result.Message);
            }
        }
        public bool getRefreshTokenControl(int userId, string lastRefreshToken)
        {
            bool lastToken = _refreshToken.getRefreshTokenControl(userId, lastRefreshToken);
            return lastToken;
        }
        public IResultData<AccessToken> setNewRefreshToken(int userId)
        {
          
            User user = _userService.GetUser(userId);
            return CreateAccessToken(user);

        }
        public Result setRefreshToken(int userId,string token)
        {
            try
            {
               int refreshId= _refreshToken.Insert(userId, token);
                _userService.SetRefreshTokenId(userId, refreshId);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
           
        }
    }
}
