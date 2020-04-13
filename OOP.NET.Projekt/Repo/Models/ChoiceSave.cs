using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Repo.Models
{
    [Serializable()]
    public class ChoiceSave : ISerializable
    {
        public Dictionary<string,List<Player>> Save { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Save", Save);
        }

        public ChoiceSave(SerializationInfo info,StreamingContext context)
        {
            Save = (Dictionary<string, List<Player>>)info.GetValue("Save", typeof(Dictionary<string, List<Player>>));
            
        }
    }
}
