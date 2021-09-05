using Domainzzz.enums;
using Newtonsoft.Json;
using System;

namespace Domainzzz
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Empleado
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        [JsonRequired]
        public string Dni { get; set; }
        [JsonProperty]
        public string Names { get; set; }
        [JsonProperty]
        public string Lastnames { get; set; }
        [JsonProperty]
        public decimal Wage { get; set; }
        [JsonProperty]
        public NivelAcademico nivelAcademico { get; set; }
        [JsonIgnore]
        public Genero genero { get; set; }
        //public class EmpleadoSalarioComparer : IComparer<Empleado>
        //{
            
        //}
       
    }
}
