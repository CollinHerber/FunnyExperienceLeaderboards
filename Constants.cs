using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FunnyExperience;
public static class Constants
{
    public static class Json
    {
        public static JsonSerializerSettings SnakeCaseSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            },
            NullValueHandling = NullValueHandling.Ignore
        };



        public static JsonSerializerSettings CamelCaseSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
    }
}