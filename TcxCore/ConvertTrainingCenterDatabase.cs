using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcxCore.XmlToCSharpTcxModels
{
    public class ConvertTrainingCenterDatabase
    {
        public static void ToCsv(TrainingCenterDatabase trainingCenterDatabase, string fileCsv)
        {
            using (StreamWriter writer = new StreamWriter(fileCsv))
            {
                foreach (Trackpoint trackpoint in trainingCenterDatabase.Activities.Activity.Lap.Track.Trackpoint)
                {
                    string[] array = new string[] { trackpoint.Time, trackpoint.DistanceMeters, trackpoint.Extensions.TPX.Speed, trackpoint.HeartRateBpm != null ? trackpoint.HeartRateBpm.Value : "0" };
                    writer.WriteLine(String.Join(";",array));
                }
            }
        }
    }
}
