using System.Threading.Tasks;
using MailingList.API.Models;

namespace MailingList.API.Data
{
    public interface ISignupRepository
    {
        Task<Member> Signup(Member member);
        Task<bool> EmailExists(string email);
    }
}