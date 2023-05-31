using Microsoft.AspNetCore.Mvc;

namespace club_manager.BusinessLogic.Members
{
  public class TestHeaders
  {
    [FromHeader]
    public string XApartmentsOSAPIKey { get; set; }
    
    [FromHeader]
    public string XApartmentsOSSignature { get; set; }
  }
}