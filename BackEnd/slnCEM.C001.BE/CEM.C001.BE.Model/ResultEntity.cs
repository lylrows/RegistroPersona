using System;
using System.Runtime.Serialization;

namespace CEM.C001.BE.Model
{
    public class ResultEntity
    {
        [DataMember]
        public int resultado { get; set; }
        [DataMember]
        public string mensaje { get; set; }
    }
}
