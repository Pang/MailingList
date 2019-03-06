using System.Threading.Tasks;
using MailingList.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MailingList.API.Data
{
    public class SignupRepository : ISignupRepository
    {
        private readonly DataContext _context;
        public SignupRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Member> Signup(Member member)
        {
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();

            return member;
        }

        public async Task<bool> EmailExists(string email)
        {
            if (await _context.Members.AnyAsync(x => x.Email == email))
                return true;

            return false;
        }
    }
}