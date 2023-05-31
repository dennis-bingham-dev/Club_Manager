using System.Collections;
using System.Collections.Generic;
using System.IO;
using club_manager.BusinessLogic.Members;
using club_manager.Interface;
using club_manager.Model;
using club_manager.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        [HttpPost]
        public IActionResult PostedToMembers([FromBody] dynamic body, [FromHeader] TestHeaders headers)
        {
            System.Console.WriteLine(body);
            System.Console.WriteLine($"apiKey: {headers.XApartmentsOSAPIKey} apiSignature: {headers.XApartmentsOSSignature}");

            return Ok();
        }
    }
}