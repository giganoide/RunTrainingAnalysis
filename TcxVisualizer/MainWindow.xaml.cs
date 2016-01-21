using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using TcxCore;
using TcxCore.XmlToCSharpTcxModels;

namespace TcxVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Trackpoint> Trackpoints { get; set; }
        public List<Track> TrackList { get; set; }

        public string StrTest { get; set; }

        public MainWindow()
        {
            StrTest = "Ciao";

            TrainingCenterDatabase trainingCenterDatabase = TcxReader.Read(@"D:\SourceGit\RunTrainingAnalysis\TcxVisualizer\Data\RUN20160107.tcx");
            Trackpoints = trainingCenterDatabase.Activities.Activity.Lap.Track.Trackpoint;


            TrackList = new List<Track>();
            DateTime startTime = DateTime.ParseExact(Trackpoints[0].Time, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture);
            foreach (Trackpoint trackpoint in Trackpoints)
            {
                DateTime trackTime = DateTime.ParseExact(trackpoint.Time, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture);
                TrackList.Add(new Track((trackTime - startTime).TotalSeconds,Convert.ToInt32(trackpoint.HeartRateBpm == null ? "0" : trackpoint.HeartRateBpm.Value)));
            }

            //DataContext = this;

            InitializeComponent();
            /*
            chart.DataContext = TrackList;
            foreach (Track track in TrackList)
            {
                areaSeries.LinePoints.Add(new Point(track.Second,track.Bpm));    
            }
            */
        }

        private void ReadTcx_OnClick(object sender, RoutedEventArgs e)
        {
            TrainingCenterDatabase trainingCenterDatabase = TcxReader.Read(@"D:\SourceGit\RunTrainingAnalysis\TcxVisualizer\Data\RUN20160107.tcx");
            ConvertTrainingCenterDatabase.ToCsv(trainingCenterDatabase, @"D:\SourceGit\RunTrainingAnalysis\TcxVisualizer\Data\RUN20160107.csv");
        }
    }

    public class Track
    {
        public double Second { get; private set; }
        public int Bpm { get; private set; }

        public Track(double second, int bpm)
        {
            Second = second;
            Bpm = bpm;
        }
        
    }
}
