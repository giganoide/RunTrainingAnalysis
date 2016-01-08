using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcxCore.VisualStudioPasteSpecialTcxModels
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", IsNullable = false)]
    public partial class TrainingCenterDatabase
    {

        private TrainingCenterDatabaseActivities activitiesField;

        /// <remarks/>
        public TrainingCenterDatabaseActivities Activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivities
    {

        private TrainingCenterDatabaseActivitiesActivity activityField;

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivity Activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivity
    {

        private System.DateTime idField;

        private TrainingCenterDatabaseActivitiesActivityLap lapField;

        private TrainingCenterDatabaseActivitiesActivityCreator creatorField;

        private string sportField;

        /// <remarks/>
        public System.DateTime Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLap Lap
        {
            get
            {
                return this.lapField;
            }
            set
            {
                this.lapField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityCreator Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLap
    {

        private ushort totalTimeSecondsField;

        private decimal distanceMetersField;

        private decimal maximumSpeedField;

        private ushort caloriesField;

        private TrainingCenterDatabaseActivitiesActivityLapAverageHeartRateBpm averageHeartRateBpmField;

        private TrainingCenterDatabaseActivitiesActivityLapMaximumHeartRateBpm maximumHeartRateBpmField;

        private string intensityField;

        private string triggerMethodField;

        private TrainingCenterDatabaseActivitiesActivityLapTrack trackField;

        private System.DateTime startTimeField;

        /// <remarks/>
        public ushort TotalTimeSeconds
        {
            get
            {
                return this.totalTimeSecondsField;
            }
            set
            {
                this.totalTimeSecondsField = value;
            }
        }

        /// <remarks/>
        public decimal DistanceMeters
        {
            get
            {
                return this.distanceMetersField;
            }
            set
            {
                this.distanceMetersField = value;
            }
        }

        /// <remarks/>
        public decimal MaximumSpeed
        {
            get
            {
                return this.maximumSpeedField;
            }
            set
            {
                this.maximumSpeedField = value;
            }
        }

        /// <remarks/>
        public ushort Calories
        {
            get
            {
                return this.caloriesField;
            }
            set
            {
                this.caloriesField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapAverageHeartRateBpm AverageHeartRateBpm
        {
            get
            {
                return this.averageHeartRateBpmField;
            }
            set
            {
                this.averageHeartRateBpmField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapMaximumHeartRateBpm MaximumHeartRateBpm
        {
            get
            {
                return this.maximumHeartRateBpmField;
            }
            set
            {
                this.maximumHeartRateBpmField = value;
            }
        }

        /// <remarks/>
        public string Intensity
        {
            get
            {
                return this.intensityField;
            }
            set
            {
                this.intensityField = value;
            }
        }

        /// <remarks/>
        public string TriggerMethod
        {
            get
            {
                return this.triggerMethodField;
            }
            set
            {
                this.triggerMethodField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapTrack Track
        {
            get
            {
                return this.trackField;
            }
            set
            {
                this.trackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapAverageHeartRateBpm
    {

        private byte valueField;

        /// <remarks/>
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapMaximumHeartRateBpm
    {

        private byte valueField;

        /// <remarks/>
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrack
    {

        private TrainingCenterDatabaseActivitiesActivityLapTrackTrackpoint[] trackpointField;

        private TrainingCenterDatabaseActivitiesActivityLapTrackExtensions extensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Trackpoint")]
        public TrainingCenterDatabaseActivitiesActivityLapTrackTrackpoint[] Trackpoint
        {
            get
            {
                return this.trackpointField;
            }
            set
            {
                this.trackpointField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapTrackExtensions Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrackTrackpoint
    {

        private System.DateTime timeField;

        private TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointPosition positionField;

        private byte altitudeMetersField;

        private decimal distanceMetersField;

        private TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointHeartRateBpm heartRateBpmField;

        private TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointExtensions extensionsField;

        /// <remarks/>
        public System.DateTime Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public byte AltitudeMeters
        {
            get
            {
                return this.altitudeMetersField;
            }
            set
            {
                this.altitudeMetersField = value;
            }
        }

        /// <remarks/>
        public decimal DistanceMeters
        {
            get
            {
                return this.distanceMetersField;
            }
            set
            {
                this.distanceMetersField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointHeartRateBpm HeartRateBpm
        {
            get
            {
                return this.heartRateBpmField;
            }
            set
            {
                this.heartRateBpmField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointExtensions Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointPosition
    {

        private decimal latitudeDegreesField;

        private decimal longitudeDegreesField;

        /// <remarks/>
        public decimal LatitudeDegrees
        {
            get
            {
                return this.latitudeDegreesField;
            }
            set
            {
                this.latitudeDegreesField = value;
            }
        }

        /// <remarks/>
        public decimal LongitudeDegrees
        {
            get
            {
                return this.longitudeDegreesField;
            }
            set
            {
                this.longitudeDegreesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointHeartRateBpm
    {

        private byte valueField;

        /// <remarks/>
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrackTrackpointExtensions
    {

        private TPX tPXField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2")]
        public TPX TPX
        {
            get
            {
                return this.tPXField;
            }
            set
            {
                this.tPXField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2", IsNullable = false)]
    public partial class TPX
    {

        private decimal speedField;

        /// <remarks/>
        public decimal Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityLapTrackExtensions
    {

        private LX lxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2")]
        public LX LX
        {
            get
            {
                return this.lxField;
            }
            set
            {
                this.lxField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.garmin.com/xmlschemas/ActivityExtension/v2", IsNullable = false)]
    public partial class LX
    {

        private decimal avgSpeedField;

        /// <remarks/>
        public decimal AvgSpeed
        {
            get
            {
                return this.avgSpeedField;
            }
            set
            {
                this.avgSpeedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityCreator
    {

        private string nameField;

        private byte unitIdField;

        private byte productIDField;

        private TrainingCenterDatabaseActivitiesActivityCreatorVersion versionField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
            }
        }

        /// <remarks/>
        public byte ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public TrainingCenterDatabaseActivitiesActivityCreatorVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")]
    public partial class TrainingCenterDatabaseActivitiesActivityCreatorVersion
    {

        private byte versionMajorField;

        private byte versionMinorField;

        private byte buildMajorField;

        private byte buildMinorField;

        /// <remarks/>
        public byte VersionMajor
        {
            get
            {
                return this.versionMajorField;
            }
            set
            {
                this.versionMajorField = value;
            }
        }

        /// <remarks/>
        public byte VersionMinor
        {
            get
            {
                return this.versionMinorField;
            }
            set
            {
                this.versionMinorField = value;
            }
        }

        /// <remarks/>
        public byte BuildMajor
        {
            get
            {
                return this.buildMajorField;
            }
            set
            {
                this.buildMajorField = value;
            }
        }

        /// <remarks/>
        public byte BuildMinor
        {
            get
            {
                return this.buildMinorField;
            }
            set
            {
                this.buildMinorField = value;
            }
        }
    }


}
