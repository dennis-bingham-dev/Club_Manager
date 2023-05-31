using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using club_manager.BusinessLogic.EnumTest.Model;
using PropertyManagementSync.ApartmentsDotCom.TourTypes.Models;

namespace club_manager.BusinessLogic.EnumTest
{
  public class TestEnumBLL
  {
    public TourTypeReturnPayload TestEnumTheory() => new TourTypeReturnPayload
    {
      InPerson = (int)TourTypeMappingEnum.InPerson,
      SelfGuided = (int)TourTypeMappingEnum.SelfGuided,
      PersonalOnline = (int)TourTypeMappingEnum.PersonalOnline
    };

    public dynamic TestEnumLookupTheory(int id)
    {
      if (Enum.IsDefined(typeof(TourTypeMappingEnum), id))
      {
        var item = (TourTypeMappingEnum)id;
        Console.WriteLine(item);
        return item;
      }

      return -1;
    }

    public string TestSerializationOfClass()
    {
      var testTourTypePayload = new TourTypePayload
      {
        ProviderPropertyId = "Provider property ID",
        CommunityGroupId = "Community Group ID",
        GroupIdentifier = "Group Identifier",
        ClientSubDomain = "Client Sub Domain",
        TourType = new List<int> { 1, 2 }.ToArray(),
        ActionId = 1
      };
      return testTourTypePayload.Serialize();
    }

    public string TestDeserializationOfClass(string payload)
    {
      return TourTypePayload.Deserialize<TourTypePayload>(payload);
    }
    
    public string TestSignatureCreation()
    {
      var testTourTypePayload = new TourTypePayload
      {
        ProviderPropertyId = "Provider property ID 2",
        CommunityGroupId = "Community Group ID 2",
        GroupIdentifier = "Group Identifier 2",
        ClientSubDomain = "Client Sub Domain 2",
        TourType = new List<int> { 1, 2 }.ToArray(),
        ActionId = 1
      };
      var payload = testTourTypePayload.Serialize();
      return ApartmentSignatureCreator.ComputeSignature(payload);
    }
    
    public class ApartmentSignatureCreator
    {
      public static string ComputeSignature( string payload) {
        //remove any whitespace including \r\n
        var payloadNoWhitespace = Regex.Replace(payload, @" \s+ " , string .Empty); var encoder = new UTF8Encoding();
        var body = encoder.GetBytes(payloadNoWhitespace);
        var secret = encoder.GetBytes( "SECRET_KEY_test_new" );
        var hashBytes = new HMACSHA1(secret).ComputeHash(body);
        return String.Format( "sha1= {0} " , BitConverter.ToString(hashBytes).Replace( "-" , "" ).ToLower());
      }
    }
  }
}
