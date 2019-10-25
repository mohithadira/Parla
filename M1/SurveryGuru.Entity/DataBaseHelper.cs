using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataBaseHelper
    {
        public DataBaseHelper()
        {
            this.voters = new List<Voter>();
        }
        public List<Voter> voters { get; set; }
    }

    /// <summary>
    /// Class for serializing,deserializing and saving data in a file named data.txt
    /// </summary>
    public class fileIO
    {
        public List<Voter> VoterSerialize(List<Voter> voters)
        {
            Stream stream = File.Open(@"C:\Users\Administrator\Desktop\SurveryGuru\data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, voters);
            stream.Close();

            return voters;
        }
        int check = 0;
        public List<Voter> VoterDeserialize()
        {
            check++;
            Stream stream = File.Open(@"C:\Users\Administrator\Desktop\SurveryGuru\data.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Voter> temp = new List<Voter>();
            if(check == 0)
            {
                return temp;
            }
            else
            {
                temp = (List<Voter>)formatter.Deserialize(stream);
                stream.Close();
                return temp;
            }
        }
    }
}
