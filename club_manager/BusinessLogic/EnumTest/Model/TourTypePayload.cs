using System.Collections.Generic;
using Newtonsoft.Json;

namespace PropertyManagementSync.ApartmentsDotCom.TourTypes.Models
{
  public class TourTypePayload
  {
    public string ProviderPropertyId { get; set; }
    public string CommunityGroupId { get; set; }
    public string GroupIdentifier { get; set; }
    public string ClientSubDomain { get; set; }
    public int[] TourType { get; set; }
    public int ActionId { get; set; }

    public string Serialize() => JsonConvert.SerializeObject(this);
    public static dynamic Deserialize<T>(string payload) => JsonConvert.DeserializeObject<T>(payload);

    public static string SerializeTourTypePayload(TourTypePayload tourTypePayload) => JsonConvert.SerializeObject(tourTypePayload);

    public static TourTypePayload DeserializeTourTypePayload(string tourTypePayload) =>
      JsonConvert.DeserializeObject<TourTypePayload>(tourTypePayload);
  }
}