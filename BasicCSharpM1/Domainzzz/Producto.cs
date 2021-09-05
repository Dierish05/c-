using Domainzzz.enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domainzzz
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Producto
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public decimal Quantity { get; set; }
        [JsonProperty]
        public decimal Price { get; set; }
        [JsonProperty]
        public DateTime  CaducityDate { get; set; }
        [JsonProperty]
        public UnidadMedida unidadMedida { get; set; }
    }
}
