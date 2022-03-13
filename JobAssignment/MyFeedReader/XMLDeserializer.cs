using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyFeedReader
{
    class XMLDeserializer
    {//made use of generics in case of different emergence of new types in the feed, and to allow for easy maintenance.
        public static T Deserializer<T>(T i_TypeOfObjectToDeserialize) 
        {
            using (HttpClient client = new HttpClient())
            {
                string endPoint = "https://wallashopsfilestest.blob.core.windows.net/upload/FeedExample.xml";
                using (var xmlResult = client.GetStreamAsync(endPoint).Result)
                {
                    XmlSerializer deSerializerXml = new XmlSerializer(i_TypeOfObjectToDeserialize.GetType());
                    T feed = (T)deSerializerXml.Deserialize(xmlResult);
                    return feed;
                }
            }
        }
    }
}
