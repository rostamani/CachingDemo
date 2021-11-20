using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Cache.DistributedCache.Helper
{
    public static class Serialization
    {
        public static byte[] ToByteArray(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            var strObj = JsonConvert.SerializeObject(obj);
            return Encoding.UTF8.GetBytes(strObj);
        }

        public static T FromByteArray<T>(this byte[] byteArray) where T : class
        {
            if (byteArray == null)
            {
                return default(T);
            }

            var strObj = Encoding.UTF8.GetString(byteArray);
            var jsonResult = JsonConvert.DeserializeObject<T>(strObj);
            return jsonResult;
        }

    }
}
