using System.Collections.Generic;
using club_manager.Model;

namespace club_manager.Interface
{
    public interface IMembers
    {
        List<Member> GetAllMembers();
        Member GetMember(int id);
    }
}