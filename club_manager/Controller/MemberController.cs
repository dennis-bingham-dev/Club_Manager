using System.Collections;
using System.Collections.Generic;
using club_manager.Interface;
using club_manager.Model;
using club_manager.Repository;
using Microsoft.AspNetCore.Mvc;

namespace club_manager.Controller
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMembers _members = new MembersRepository();

        [HttpGet]
        public ActionResult<List<Member>> GetAllMembers() => _members.GetAllMembers();

        [HttpGet("{id}")]
        public ActionResult<Member> GetMemberById(int id) => _members.GetMember(id);

        [HttpGet]
        public ActionResult<double> GetNumberOfMembers() => _members.GetAllMembers().Count;
    }
}