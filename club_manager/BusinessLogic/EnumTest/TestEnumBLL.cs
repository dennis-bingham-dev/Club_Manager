using club_manager.BusinessLogic.EnumTest.Model;

namespace club_manager.BusinessLogic.EnumTest
{
  public class TestEnumBLL
  {
    public dynamic TestEnumTheory() => new TourTypeReturnPayload
    {
      Default = (int)TourTypeMappingEnum.Default,
      InPerson = (int)TourTypeMappingEnum.InPerson,
      SelfGuided = (int)TourTypeMappingEnum.SelfGuided,
      PersonalOnline = (int)TourTypeMappingEnum.PersonalOnline
    };
  }
}