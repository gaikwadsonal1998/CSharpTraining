using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;



namespace ConsoleApp1_Serialize
{
    [DataContract]
    class Product
    {
        [DataMember]
        public int productId { get; set; }
        [DataMember]
        public string productname { get; set; }
        [DataMember]
        public double price { get; set; }




        public void jsonserializer()
        {
            Product p = new Product() { productId = 101, productname = "Robertmachine", price = 2345 };
            FileStream fs = new FileStream("D:\\myfilejson.txt", FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, p);
                }
            }
        }
    }
}