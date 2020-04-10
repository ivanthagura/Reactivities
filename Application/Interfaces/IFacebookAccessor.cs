using System.Threading.Tasks;
using Application.User;

namespace Application.Interfaces
{
    public interface IFacebookAccessor
    {
        Task<FacebookUserIfo> FacebookLogin(string accessToken);
    }
}