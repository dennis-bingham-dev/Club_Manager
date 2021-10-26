using System.Collections.Generic;
using System.Linq;
using club_manager.Interface;
using club_manager.Model;

namespace club_manager.Repository
{
    public class MembersRepository : IMembers
    {
        private List<Member> listMembers = new List<Member>
        {
            new Member{ MemberId = 1, FirstName = "John", LastName = "Doe", Address = "1690 International Way", City = "Idaho Falls", ZipCode = "83402", PhoneNumber = "(505) 798-6324"},
            new Member{ MemberId = 2, FirstName = "Jane", LastName = "Doe", Address = "1690 International Way", City = "Idaho Falls", ZipCode = "83402", PhoneNumber = "(505) 798-6354"},
            new Member{ MemberId = 3, FirstName = "Ron", LastName = "Dung", Address = "1732 Wallibee Way", City = "Sydney", ZipCode = "12356", PhoneNumber = "(987) 456-9513"},
            new Member{ MemberId = 4, FirstName = "Rita", LastName = "Dung", Address = "1732 Wallibee Way", City = "Sydney", ZipCode = "12356", PhoneNumber = "(987) 456-9984"}
        };

        public List<Member> GetAllMembers() => listMembers;
        public Member GetMember(int id) => listMembers.FirstOrDefault(m => m.MemberId.Equals(id));
    }
}