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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadTcx_OnClick(object sender, RoutedEventArgs e)
        {
            TrainingCenterDatabase trainingCenterDatabase = TcxReader.Read(@"D:\Source.temp\TcxVisualizer\Data\RUN20160107.tcx");
            ConvertTrainingCenterDatabase.ToCsv(trainingCenterDatabase, @"D:\Source.temp\TcxVisualizer\Data\RUN20160107.csv");
            
        }
    }
}
