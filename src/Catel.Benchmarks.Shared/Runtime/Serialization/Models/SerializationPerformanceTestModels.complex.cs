// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTestModels.complex.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Catel.Data;

    public enum SortDirection
    {
        Ascending,

        Descending
    }

    public static class ComplexSerializationHierarchy
    {
        #region Methods
        public static ScheduleAssistantSettings CreateComplexHierarchy()
        {
            var settings = new ScheduleAssistantSettings();

            settings.SelectedResource = "Resource 1";

            // main grid
            settings.GridSettings.ColumnSettings = new List<ColumnSettings>()
            {
                new ColumnSettings {ColumnName = "Col1", IsHidden = false, Width = 100},
                new ColumnSettings {ColumnName = "Col2", IsHidden = true, Width = 100},
                new ColumnSettings {ColumnName = "Col3", IsHidden = false, Width = 80},
                new ColumnSettings {ColumnName = "Col4", IsHidden = false, Width = 60}
            };

            settings.GridSettings.SortSettings = new List<SortSetting>()
            {
                new SortSetting {ColumnName = "Col1", SortDirection = SortDirection.Ascending},
                new SortSetting {ColumnName = "Col4", SortDirection = SortDirection.Descending},
            };

            settings.GridSettings.GroupingOrder = new List<string>()
            {
                "Col1"
            };

            // pending grid
            settings.PendingGridSettings.ColumnSettings = new List<ColumnSettings>()
            {
                new ColumnSettings {ColumnName = "Col1", IsHidden = false, Width = 100},
                new ColumnSettings {ColumnName = "Col2", IsHidden = true, Width = 100},
                new ColumnSettings {ColumnName = "Col3", IsHidden = false, Width = 80},
                new ColumnSettings {ColumnName = "Col4", IsHidden = false, Width = 60}
            };

            settings.PendingGridSettings.SortSettings = new List<SortSetting>()
            {
                new SortSetting {ColumnName = "Col3", SortDirection = SortDirection.Ascending},
                new SortSetting {ColumnName = "Col2", SortDirection = SortDirection.Descending},
            };

            settings.PendingGridSettings.GroupingOrder = new List<string>()
            {
                "Col2"
            };

            // scheduled grid
            settings.ScheduledGridSettings.ColumnSettings = new List<ColumnSettings>()
            {
                new ColumnSettings {ColumnName = "Col1", IsHidden = false, Width = 100},
                new ColumnSettings {ColumnName = "Col2", IsHidden = true, Width = 100},
                new ColumnSettings {ColumnName = "Col3", IsHidden = false, Width = 80},
                new ColumnSettings {ColumnName = "Col4", IsHidden = false, Width = 60}
            };

            settings.ScheduledGridSettings.SortSettings = new List<SortSetting>()
            {
                new SortSetting {ColumnName = "Col4", SortDirection = SortDirection.Ascending},
            };

            settings.ScheduledGridSettings.GroupingOrder = new List<string>()
            {
                "Col1"
            };

            return settings;
        }
        #endregion
    }

    [Serializable]
    public class ScheduleAssistantSettings : SavableModelBase<ScheduleAssistantSettings>
    {
        #region Constructors
        public ScheduleAssistantSettings()
        {
            GridSettings = new GridSettings();
            PendingGridSettings = new GridSettings();
            ScheduledGridSettings = new GridSettings();
        }

#if CATEL_5
        protected ScheduleAssistantSettings(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion

        public string SelectedResource { get; set; }

        public GridSettings GridSettings { get; set; }

        public GridSettings PendingGridSettings { get; set; }

        public GridSettings ScheduledGridSettings { get; set; }
    }

    [Serializable]
    public class GridSettings : ModelBase
    {
        #region Constructors
        public GridSettings()
        {
            SortSettings = new List<SortSetting>();
            GroupingOrder = new List<string>();
            ColumnSettings = new List<ColumnSettings>();
        }

#if CATEL_5
        protected GridSettings(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion

        public List<SortSetting> SortSettings { get; set; }

        public List<string> GroupingOrder { get; set; }

        public List<ColumnSettings> ColumnSettings { get; set; }
    }

    [Serializable]
    public class SortSetting
    {
        #region Properties
        public string ColumnName { get; set; }
        public SortDirection SortDirection { get; set; }
        #endregion

        #region Methods
        protected bool Equals(SortSetting other)
        {
            return string.Equals(ColumnName, other.ColumnName) && SortDirection == other.SortDirection;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ColumnName != null ? ColumnName.GetHashCode() : 0) * 397) ^ (int)SortDirection;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((SortSetting)obj);
        }
        #endregion
    }

    [Serializable]
    public class ColumnSettings
    {
        #region Properties
        public string ColumnName { get; set; }
        public double Width { get; set; }
        public bool IsHidden { get; set; }
        #endregion

        #region Methods
        protected bool Equals(ColumnSettings other)
        {
            return string.Equals(ColumnName, other.ColumnName) && Width.Equals(other.Width) && IsHidden.Equals(other.IsHidden);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (ColumnName != null ? ColumnName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Width.GetHashCode();
                hashCode = (hashCode * 397) ^ IsHidden.GetHashCode();
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((ColumnSettings)obj);
        }
        #endregion
    }
}
