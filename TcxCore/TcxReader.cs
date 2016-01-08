using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;
using TcxCore.XmlToCSharpTcxModels;

namespace TcxCore
{
    public class TcxReader
    {
        public static TrainingCenterDatabase Read(string file)
        {
            TrainingCenterDatabase trainingCenterDatabase = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (TrainingCenterDatabase));
                StreamReader reader = new StreamReader(file);
                trainingCenterDatabase = (TrainingCenterDatabase)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return trainingCenterDatabase;
        }
    }
}
