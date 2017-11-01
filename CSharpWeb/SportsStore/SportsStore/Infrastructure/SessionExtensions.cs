using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

//c Add SessionExtensions.cs and add SetJson(), GetJson() extension methods which extend funtionalities of ISession interface by adding these extension methods into interface. 1)GetJson() is used to extract JSON string which is keyed by "Cart" from HttpContext.Session(On server memory) and deserialize this "Cart" keyed JSON string to Cart type object. 2)SetJson() is used to serialize Cart object to JSON type and sets key of this JSON string to "Cart" string.

namespace SportsStore.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}