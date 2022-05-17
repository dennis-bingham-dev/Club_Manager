using club_manager.BusinessLogic.EnumTest;
using club_manager.BusinessLogic.EnumTest.Model;
using Microsoft.AspNetCore.Mvc;

namespace club_manager.Controller
{
  [Route("api/v1/[controller]/[action]")]
  [ApiController]
  public class EnumTestController : ControllerBase
  {
    private readonly TestEnumBLL _testEnumBll;

    public EnumTestController(TestEnumBLL testEnumBll)
    {
      _testEnumBll = testEnumBll;
    }
    
    [HttpPost]
    public ActionResult<TourTypeReturnPayload> TestEnumTheory() => _testEnumBll.TestEnumTheory();

    [HttpGet("{id}")]
    public ActionResult<dynamic> TestWhatComesOutTheory(int id) => _testEnumBll.TestEnumLookupTheory(id);

    [HttpGet]
    public ActionResult<string> TestSerializationOfClass() => _testEnumBll.TestSerializationOfClass();

    [HttpPost]
    public ActionResult<string> TestDeserializationOfClass() => _testEnumBll.TestSignatureCreation();
  }
}