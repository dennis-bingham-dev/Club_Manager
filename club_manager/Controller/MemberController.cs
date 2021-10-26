using System.Collections;
using System.Collections.Generic;
using club_manager.Interface;
using club_manager.Model;
using club_manager.Repository;
using Microsoft.AspNetCore.Mvc;

namespace club_manager.Controller
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMembers _members = new MembersRepository();

        [HttpGet]
        public ActionResult<List<Member>> GetAllMembers() => _members.GetAllMembers();

        [HttpGet("{id}")]
        public ActionResult<Member> GetMemberById(int id) => _members.GetMember(id);
    }
}