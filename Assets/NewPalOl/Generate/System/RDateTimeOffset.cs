using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.DateTimeOffset
	/// </summary>
    public partial class RDateTimeOffset : RMember //
    {

		/// <summary>
		/// System.Int64 MaxOffset
		/// </summary>
		protected static RField r_MaxOffset;
		public static RField RMaxOffset
		{
			get
			{
				if(r_MaxOffset == null)
				{
					r_MaxOffset = new(typeof(System.DateTimeOffset), "MaxOffset");
					r_MaxOffset.SetBelong(null);
				}
				return r_MaxOffset;
			}
		}

		/// <summary>
		/// System.Int64 MinOffset
		/// </summary>
		protected static RField r_MinOffset;
		public static RField RMinOffset
		{
			get
			{
				if(r_MinOffset == null)
				{
					r_MinOffset = new(typeof(System.DateTimeOffset), "MinOffset");
					r_MinOffset.SetBelong(null);
				}
				return r_MinOffset;
			}
		}

		/// <summary>
		/// System.Int64 UnixEpochSeconds
		/// </summary>
		protected static RField r_UnixEpochSeconds;
		public static RField RUnixEpochSeconds
		{
			get
			{
				if(r_UnixEpochSeconds == null)
				{
					r_UnixEpochSeconds = new(typeof(System.DateTimeOffset), "UnixEpochSeconds");
					r_UnixEpochSeconds.SetBelong(null);
				}
				return r_UnixEpochSeconds;
			}
		}

		/// <summary>
		/// System.Int64 UnixEpochMilliseconds
		/// </summary>
		protected static RField r_UnixEpochMilliseconds;
		public static RField RUnixEpochMilliseconds
		{
			get
			{
				if(r_UnixEpochMilliseconds == null)
				{
					r_UnixEpochMilliseconds = new(typeof(System.DateTimeOffset), "UnixEpochMilliseconds");
					r_UnixEpochMilliseconds.SetBelong(null);
				}
				return r_UnixEpochMilliseconds;
			}
		}

		/// <summary>
		/// System.Int64 UnixMinSeconds
		/// </summary>
		protected static RField r_UnixMinSeconds;
		public static RField RUnixMinSeconds
		{
			get
			{
				if(r_UnixMinSeconds == null)
				{
					r_UnixMinSeconds = new(typeof(System.DateTimeOffset), "UnixMinSeconds");
					r_UnixMinSeconds.SetBelong(null);
				}
				return r_UnixMinSeconds;
			}
		}

		/// <summary>
		/// System.Int64 UnixMaxSeconds
		/// </summary>
		protected static RField r_UnixMaxSeconds;
		public static RField RUnixMaxSeconds
		{
			get
			{
				if(r_UnixMaxSeconds == null)
				{
					r_UnixMaxSeconds = new(typeof(System.DateTimeOffset), "UnixMaxSeconds");
					r_UnixMaxSeconds.SetBelong(null);
				}
				return r_UnixMaxSeconds;
			}
		}

		/// <summary>
		/// System.DateTimeOffset MinValue
		/// </summary>
		protected static RSystem.RDateTimeOffset r_MinValue;
		public static RSystem.RDateTimeOffset RMinValue
		{
			get
			{
				if(r_MinValue == null)
				{
					r_MinValue = new(typeof(System.DateTimeOffset), "MinValue");
					r_MinValue.SetBelong(null);
				}
				return r_MinValue;
			}
		}

		/// <summary>
		/// System.DateTimeOffset MaxValue
		/// </summary>
		protected static RSystem.RDateTimeOffset r_MaxValue;
		public static RSystem.RDateTimeOffset RMaxValue
		{
			get
			{
				if(r_MaxValue == null)
				{
					r_MaxValue = new(typeof(System.DateTimeOffset), "MaxValue");
					r_MaxValue.SetBelong(null);
				}
				return r_MaxValue;
			}
		}

		/// <summary>
		/// System.DateTimeOffset UnixEpoch
		/// </summary>
		protected static RSystem.RDateTimeOffset r_UnixEpoch;
		public static RSystem.RDateTimeOffset RUnixEpoch
		{
			get
			{
				if(r_UnixEpoch == null)
				{
					r_UnixEpoch = new(typeof(System.DateTimeOffset), "UnixEpoch");
					r_UnixEpoch.SetBelong(null);
				}
				return r_UnixEpoch;
			}
		}

		/// <summary>
		/// System.DateTime _dateTime
		/// </summary>
		protected RSystem.RDateTime r__dateTime;
		public virtual RSystem.RDateTime R_dateTime
		{
			get
			{
				if(r__dateTime == null)
				{
					r__dateTime = new(this, "_dateTime");
					r__dateTime.SetBelong(this.instance);
				}
				return r__dateTime;
			}
		}

		/// <summary>
		/// System.Int16 _offsetMinutes
		/// </summary>
		protected RField r__offsetMinutes;
		public virtual RField R_offsetMinutes
		{
			get
			{
				if(r__offsetMinutes == null)
				{
					r__offsetMinutes = new(this, "_offsetMinutes");
					r__offsetMinutes.SetBelong(this.instance);
				}
				return r__offsetMinutes;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Now
		/// </summary>
		protected static RSystem.RDateTimeOffset r_Now;
		public static RSystem.RDateTimeOffset RNow
		{
			get
			{
				if(r_Now == null)
				{
					r_Now = new(typeof(System.DateTimeOffset), "Now", -1);
					r_Now.SetBelong(null);
				}
				return r_Now;
			}
		}

		/// <summary>
		/// System.DateTimeOffset UtcNow
		/// </summary>
		protected static RSystem.RDateTimeOffset r_UtcNow;
		public static RSystem.RDateTimeOffset RUtcNow
		{
			get
			{
				if(r_UtcNow == null)
				{
					r_UtcNow = new(typeof(System.DateTimeOffset), "UtcNow", -1);
					r_UtcNow.SetBelong(null);
				}
				return r_UtcNow;
			}
		}

		/// <summary>
		/// System.DateTime DateTime
		/// </summary>
		protected RSystem.RDateTime r_DateTime;
		public virtual RSystem.RDateTime RDateTime
		{
			get
			{
				if(r_DateTime == null)
				{
					r_DateTime = new(this, "DateTime", -1);
					r_DateTime.SetBelong(this.instance);
				}
				return r_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime UtcDateTime
		/// </summary>
		protected RSystem.RDateTime r_UtcDateTime;
		public virtual RSystem.RDateTime RUtcDateTime
		{
			get
			{
				if(r_UtcDateTime == null)
				{
					r_UtcDateTime = new(this, "UtcDateTime", -1);
					r_UtcDateTime.SetBelong(this.instance);
				}
				return r_UtcDateTime;
			}
		}

		/// <summary>
		/// System.DateTime LocalDateTime
		/// </summary>
		protected RSystem.RDateTime r_LocalDateTime;
		public virtual RSystem.RDateTime RLocalDateTime
		{
			get
			{
				if(r_LocalDateTime == null)
				{
					r_LocalDateTime = new(this, "LocalDateTime", -1);
					r_LocalDateTime.SetBelong(this.instance);
				}
				return r_LocalDateTime;
			}
		}

		/// <summary>
		/// System.DateTime ClockDateTime
		/// </summary>
		protected RSystem.RDateTime r_ClockDateTime;
		public virtual RSystem.RDateTime RClockDateTime
		{
			get
			{
				if(r_ClockDateTime == null)
				{
					r_ClockDateTime = new(this, "ClockDateTime", -1);
					r_ClockDateTime.SetBelong(this.instance);
				}
				return r_ClockDateTime;
			}
		}

		/// <summary>
		/// System.DateTime Date
		/// </summary>
		protected RSystem.RDateTime r_Date;
		public virtual RSystem.RDateTime RDate
		{
			get
			{
				if(r_Date == null)
				{
					r_Date = new(this, "Date", -1);
					r_Date.SetBelong(this.instance);
				}
				return r_Date;
			}
		}

		/// <summary>
		/// Int32 Day
		/// </summary>
		protected RProperty r_Day;
		public virtual RProperty RDay
		{
			get
			{
				if(r_Day == null)
				{
					r_Day = new(this, "Day", -1);
					r_Day.SetBelong(this.instance);
				}
				return r_Day;
			}
		}

		/// <summary>
		/// System.DayOfWeek DayOfWeek
		/// </summary>
		protected RProperty r_DayOfWeek;
		public virtual RProperty RDayOfWeek
		{
			get
			{
				if(r_DayOfWeek == null)
				{
					r_DayOfWeek = new(this, "DayOfWeek", -1);
					r_DayOfWeek.SetBelong(this.instance);
				}
				return r_DayOfWeek;
			}
		}

		/// <summary>
		/// Int32 DayOfYear
		/// </summary>
		protected RProperty r_DayOfYear;
		public virtual RProperty RDayOfYear
		{
			get
			{
				if(r_DayOfYear == null)
				{
					r_DayOfYear = new(this, "DayOfYear", -1);
					r_DayOfYear.SetBelong(this.instance);
				}
				return r_DayOfYear;
			}
		}

		/// <summary>
		/// Int32 Hour
		/// </summary>
		protected RProperty r_Hour;
		public virtual RProperty RHour
		{
			get
			{
				if(r_Hour == null)
				{
					r_Hour = new(this, "Hour", -1);
					r_Hour.SetBelong(this.instance);
				}
				return r_Hour;
			}
		}

		/// <summary>
		/// Int32 Millisecond
		/// </summary>
		protected RProperty r_Millisecond;
		public virtual RProperty RMillisecond
		{
			get
			{
				if(r_Millisecond == null)
				{
					r_Millisecond = new(this, "Millisecond", -1);
					r_Millisecond.SetBelong(this.instance);
				}
				return r_Millisecond;
			}
		}

		/// <summary>
		/// Int32 Minute
		/// </summary>
		protected RProperty r_Minute;
		public virtual RProperty RMinute
		{
			get
			{
				if(r_Minute == null)
				{
					r_Minute = new(this, "Minute", -1);
					r_Minute.SetBelong(this.instance);
				}
				return r_Minute;
			}
		}

		/// <summary>
		/// Int32 Month
		/// </summary>
		protected RProperty r_Month;
		public virtual RProperty RMonth
		{
			get
			{
				if(r_Month == null)
				{
					r_Month = new(this, "Month", -1);
					r_Month.SetBelong(this.instance);
				}
				return r_Month;
			}
		}

		/// <summary>
		/// System.TimeSpan Offset
		/// </summary>
		protected RSystem.RTimeSpan r_Offset;
		public virtual RSystem.RTimeSpan ROffset
		{
			get
			{
				if(r_Offset == null)
				{
					r_Offset = new(this, "Offset", -1);
					r_Offset.SetBelong(this.instance);
				}
				return r_Offset;
			}
		}

		/// <summary>
		/// Int32 Second
		/// </summary>
		protected RProperty r_Second;
		public virtual RProperty RSecond
		{
			get
			{
				if(r_Second == null)
				{
					r_Second = new(this, "Second", -1);
					r_Second.SetBelong(this.instance);
				}
				return r_Second;
			}
		}

		/// <summary>
		/// Int64 Ticks
		/// </summary>
		protected RProperty r_Ticks;
		public virtual RProperty RTicks
		{
			get
			{
				if(r_Ticks == null)
				{
					r_Ticks = new(this, "Ticks", -1);
					r_Ticks.SetBelong(this.instance);
				}
				return r_Ticks;
			}
		}

		/// <summary>
		/// Int64 UtcTicks
		/// </summary>
		protected RProperty r_UtcTicks;
		public virtual RProperty RUtcTicks
		{
			get
			{
				if(r_UtcTicks == null)
				{
					r_UtcTicks = new(this, "UtcTicks", -1);
					r_UtcTicks.SetBelong(this.instance);
				}
				return r_UtcTicks;
			}
		}

		/// <summary>
		/// System.TimeSpan TimeOfDay
		/// </summary>
		protected RSystem.RTimeSpan r_TimeOfDay;
		public virtual RSystem.RTimeSpan RTimeOfDay
		{
			get
			{
				if(r_TimeOfDay == null)
				{
					r_TimeOfDay = new(this, "TimeOfDay", -1);
					r_TimeOfDay.SetBelong(this.instance);
				}
				return r_TimeOfDay;
			}
		}

		/// <summary>
		/// Int32 Year
		/// </summary>
		protected RProperty r_Year;
		public virtual RProperty RYear
		{
			get
			{
				if(r_Year == null)
				{
					r_Year = new(this, "Year", -1);
					r_Year.SetBelong(this.instance);
				}
				return r_Year;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToOffset(System.TimeSpan)
		/// </summary>
		protected RMethod r_RToOffset_TimeSpan;
		public virtual RMethod RToOffset_TimeSpan
		{
			get
			{
				if(r_RToOffset_TimeSpan == null)
				{
					r_RToOffset_TimeSpan = new(this, "ToOffset", 0, typeof(System.TimeSpan));
					r_RToOffset_TimeSpan.SetBelong(this.instance);
				}
				return r_RToOffset_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Add(System.TimeSpan)
		/// </summary>
		protected RMethod r_RAdd_TimeSpan;
		public virtual RMethod RAdd_TimeSpan
		{
			get
			{
				if(r_RAdd_TimeSpan == null)
				{
					r_RAdd_TimeSpan = new(this, "Add", 0, typeof(System.TimeSpan));
					r_RAdd_TimeSpan.SetBelong(this.instance);
				}
				return r_RAdd_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddDays(Double)
		/// </summary>
		protected RMethod r_RAddDays_Double;
		public virtual RMethod RAddDays_Double
		{
			get
			{
				if(r_RAddDays_Double == null)
				{
					r_RAddDays_Double = new(this, "AddDays", 0, typeof(System.Double));
					r_RAddDays_Double.SetBelong(this.instance);
				}
				return r_RAddDays_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddHours(Double)
		/// </summary>
		protected RMethod r_RAddHours_Double;
		public virtual RMethod RAddHours_Double
		{
			get
			{
				if(r_RAddHours_Double == null)
				{
					r_RAddHours_Double = new(this, "AddHours", 0, typeof(System.Double));
					r_RAddHours_Double.SetBelong(this.instance);
				}
				return r_RAddHours_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddMilliseconds(Double)
		/// </summary>
		protected RMethod r_RAddMilliseconds_Double;
		public virtual RMethod RAddMilliseconds_Double
		{
			get
			{
				if(r_RAddMilliseconds_Double == null)
				{
					r_RAddMilliseconds_Double = new(this, "AddMilliseconds", 0, typeof(System.Double));
					r_RAddMilliseconds_Double.SetBelong(this.instance);
				}
				return r_RAddMilliseconds_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddMinutes(Double)
		/// </summary>
		protected RMethod r_RAddMinutes_Double;
		public virtual RMethod RAddMinutes_Double
		{
			get
			{
				if(r_RAddMinutes_Double == null)
				{
					r_RAddMinutes_Double = new(this, "AddMinutes", 0, typeof(System.Double));
					r_RAddMinutes_Double.SetBelong(this.instance);
				}
				return r_RAddMinutes_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddMonths(Int32)
		/// </summary>
		protected RMethod r_RAddMonths_Int32;
		public virtual RMethod RAddMonths_Int32
		{
			get
			{
				if(r_RAddMonths_Int32 == null)
				{
					r_RAddMonths_Int32 = new(this, "AddMonths", 0, typeof(System.Int32));
					r_RAddMonths_Int32.SetBelong(this.instance);
				}
				return r_RAddMonths_Int32;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddSeconds(Double)
		/// </summary>
		protected RMethod r_RAddSeconds_Double;
		public virtual RMethod RAddSeconds_Double
		{
			get
			{
				if(r_RAddSeconds_Double == null)
				{
					r_RAddSeconds_Double = new(this, "AddSeconds", 0, typeof(System.Double));
					r_RAddSeconds_Double.SetBelong(this.instance);
				}
				return r_RAddSeconds_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddTicks(Int64)
		/// </summary>
		protected RMethod r_RAddTicks_Int64;
		public virtual RMethod RAddTicks_Int64
		{
			get
			{
				if(r_RAddTicks_Int64 == null)
				{
					r_RAddTicks_Int64 = new(this, "AddTicks", 0, typeof(System.Int64));
					r_RAddTicks_Int64.SetBelong(this.instance);
				}
				return r_RAddTicks_Int64;
			}
		}

		/// <summary>
		/// System.DateTimeOffset AddYears(Int32)
		/// </summary>
		protected RMethod r_RAddYears_Int32;
		public virtual RMethod RAddYears_Int32
		{
			get
			{
				if(r_RAddYears_Int32 == null)
				{
					r_RAddYears_Int32 = new(this, "AddYears", 0, typeof(System.Int32));
					r_RAddYears_Int32.SetBelong(this.instance);
				}
				return r_RAddYears_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_RCompare_DateTimeOffset_DateTimeOffset;
		public static RMethod RCompare_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_RCompare_DateTimeOffset_DateTimeOffset == null)
				{
					r_RCompare_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "Compare", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_RCompare_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_RCompare_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Int32 System.IComparable.CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__IComparable__1__CompareTo_Object;
		public virtual RMethod RSystem__1__IComparable__1__CompareTo_Object
		{
			get
			{
				if(r_RSystem__1__IComparable__1__CompareTo_Object == null)
				{
					r_RSystem__1__IComparable__1__CompareTo_Object = new(this, "System.IComparable.CompareTo", 0, typeof(System.Object));
					r_RSystem__1__IComparable__1__CompareTo_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__IComparable__1__CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RCompareTo_DateTimeOffset;
		public virtual RMethod RCompareTo_DateTimeOffset
		{
			get
			{
				if(r_RCompareTo_DateTimeOffset == null)
				{
					r_RCompareTo_DateTimeOffset = new(this, "CompareTo", 0, typeof(System.DateTimeOffset));
					r_RCompareTo_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RCompareTo_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_REquals_DateTimeOffset;
		public virtual RMethod REquals_DateTimeOffset
		{
			get
			{
				if(r_REquals_DateTimeOffset == null)
				{
					r_REquals_DateTimeOffset = new(this, "Equals", 0, typeof(System.DateTimeOffset));
					r_REquals_DateTimeOffset.SetBelong(this.instance);
				}
				return r_REquals_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean EqualsExact(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_REqualsExact_DateTimeOffset;
		public virtual RMethod REqualsExact_DateTimeOffset
		{
			get
			{
				if(r_REqualsExact_DateTimeOffset == null)
				{
					r_REqualsExact_DateTimeOffset = new(this, "EqualsExact", 0, typeof(System.DateTimeOffset));
					r_REqualsExact_DateTimeOffset.SetBelong(this.instance);
				}
				return r_REqualsExact_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean Equals(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_REquals_DateTimeOffset_DateTimeOffset;
		public static RMethod REquals_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_REquals_DateTimeOffset_DateTimeOffset == null)
				{
					r_REquals_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "Equals", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_REquals_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_REquals_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// System.DateTimeOffset FromFileTime(Int64)
		/// </summary>
		protected static RMethod r_RFromFileTime_Int64;
		public static RMethod RFromFileTime_Int64
		{
			get
			{
				if(r_RFromFileTime_Int64 == null)
				{
					r_RFromFileTime_Int64 = new(typeof(System.DateTimeOffset), "FromFileTime", 0, typeof(System.Int64));
					r_RFromFileTime_Int64.SetBelong(null);
				}
				return r_RFromFileTime_Int64;
			}
		}

		/// <summary>
		/// System.DateTimeOffset FromUnixTimeSeconds(Int64)
		/// </summary>
		protected static RMethod r_RFromUnixTimeSeconds_Int64;
		public static RMethod RFromUnixTimeSeconds_Int64
		{
			get
			{
				if(r_RFromUnixTimeSeconds_Int64 == null)
				{
					r_RFromUnixTimeSeconds_Int64 = new(typeof(System.DateTimeOffset), "FromUnixTimeSeconds", 0, typeof(System.Int64));
					r_RFromUnixTimeSeconds_Int64.SetBelong(null);
				}
				return r_RFromUnixTimeSeconds_Int64;
			}
		}

		/// <summary>
		/// System.DateTimeOffset FromUnixTimeMilliseconds(Int64)
		/// </summary>
		protected static RMethod r_RFromUnixTimeMilliseconds_Int64;
		public static RMethod RFromUnixTimeMilliseconds_Int64
		{
			get
			{
				if(r_RFromUnixTimeMilliseconds_Int64 == null)
				{
					r_RFromUnixTimeMilliseconds_Int64 = new(typeof(System.DateTimeOffset), "FromUnixTimeMilliseconds", 0, typeof(System.Int64));
					r_RFromUnixTimeMilliseconds_Int64.SetBelong(null);
				}
				return r_RFromUnixTimeMilliseconds_Int64;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object;
		public virtual RMethod RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object == null)
				{
					r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(System.DateTimeOffset), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Parse(System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RParse_String_IFormatProvider;
		public static RMethod RParse_String_IFormatProvider
		{
			get
			{
				if(r_RParse_String_IFormatProvider == null)
				{
					r_RParse_String_IFormatProvider = new(typeof(System.DateTimeOffset), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RParse_String_IFormatProvider.SetBelong(null);
				}
				return r_RParse_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Parse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParse_String_IFormatProvider_DateTimeStyles;
		public static RMethod RParse_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParse_String_IFormatProvider_DateTimeStyles == null)
				{
					r_RParse_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "Parse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParse_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParse_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Parse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ParseExact(System.String, System.String, System.IFormatProvider)
		/// </summary>
		protected static RMethod r_RParseExact_String_String_IFormatProvider;
		public static RMethod RParseExact_String_String_IFormatProvider
		{
			get
			{
				if(r_RParseExact_String_String_IFormatProvider == null)
				{
					r_RParseExact_String_String_IFormatProvider = new(typeof(System.DateTimeOffset), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider));
					r_RParseExact_String_String_IFormatProvider.SetBelong(null);
				}
				return r_RParseExact_String_String_IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParseExact_String_String_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_String_String_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParseExact_String_String_IFormatProvider_DateTimeStyles == null)
				{
					r_RParseExact_String_String_IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "ParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParseExact_String_String_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParseExact_String_String_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles == null)
				{
					r_RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_String_StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParseExact_String_StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_RParseExact_String_StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "ParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParseExact_String_StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParseExact_String_StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles)
		/// </summary>
		protected static RMethod r_RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles
		{
			get
			{
				if(r_RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles == null)
				{
					r_RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles = new(typeof(System.DateTimeOffset), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles));
					r_RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles.SetBelong(null);
				}
				return r_RParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles;
			}
		}

		/// <summary>
		/// System.TimeSpan Subtract(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RSubtract_DateTimeOffset;
		public virtual RMethod RSubtract_DateTimeOffset
		{
			get
			{
				if(r_RSubtract_DateTimeOffset == null)
				{
					r_RSubtract_DateTimeOffset = new(this, "Subtract", 0, typeof(System.DateTimeOffset));
					r_RSubtract_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RSubtract_DateTimeOffset;
			}
		}

		/// <summary>
		/// System.DateTimeOffset Subtract(System.TimeSpan)
		/// </summary>
		protected RMethod r_RSubtract_TimeSpan;
		public virtual RMethod RSubtract_TimeSpan
		{
			get
			{
				if(r_RSubtract_TimeSpan == null)
				{
					r_RSubtract_TimeSpan = new(this, "Subtract", 0, typeof(System.TimeSpan));
					r_RSubtract_TimeSpan.SetBelong(this.instance);
				}
				return r_RSubtract_TimeSpan;
			}
		}

		/// <summary>
		/// Int64 ToFileTime()
		/// </summary>
		protected RMethod r_RToFileTime;
		public virtual RMethod RToFileTime
		{
			get
			{
				if(r_RToFileTime == null)
				{
					r_RToFileTime = new(this, "ToFileTime", 0);
					r_RToFileTime.SetBelong(this.instance);
				}
				return r_RToFileTime;
			}
		}

		/// <summary>
		/// Int64 ToUnixTimeSeconds()
		/// </summary>
		protected RMethod r_RToUnixTimeSeconds;
		public virtual RMethod RToUnixTimeSeconds
		{
			get
			{
				if(r_RToUnixTimeSeconds == null)
				{
					r_RToUnixTimeSeconds = new(this, "ToUnixTimeSeconds", 0);
					r_RToUnixTimeSeconds.SetBelong(this.instance);
				}
				return r_RToUnixTimeSeconds;
			}
		}

		/// <summary>
		/// Int64 ToUnixTimeMilliseconds()
		/// </summary>
		protected RMethod r_RToUnixTimeMilliseconds;
		public virtual RMethod RToUnixTimeMilliseconds
		{
			get
			{
				if(r_RToUnixTimeMilliseconds == null)
				{
					r_RToUnixTimeMilliseconds = new(this, "ToUnixTimeMilliseconds", 0);
					r_RToUnixTimeMilliseconds.SetBelong(this.instance);
				}
				return r_RToUnixTimeMilliseconds;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToLocalTime()
		/// </summary>
		protected RMethod r_RToLocalTime;
		public virtual RMethod RToLocalTime
		{
			get
			{
				if(r_RToLocalTime == null)
				{
					r_RToLocalTime = new(this, "ToLocalTime", 0);
					r_RToLocalTime.SetBelong(this.instance);
				}
				return r_RToLocalTime;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToLocalTime(Boolean)
		/// </summary>
		protected RMethod r_RToLocalTime_Boolean;
		public virtual RMethod RToLocalTime_Boolean
		{
			get
			{
				if(r_RToLocalTime_Boolean == null)
				{
					r_RToLocalTime_Boolean = new(this, "ToLocalTime", 0, typeof(System.Boolean));
					r_RToLocalTime_Boolean.SetBelong(this.instance);
				}
				return r_RToLocalTime_Boolean;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_RToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_RToString_String == null)
				{
					r_RToString_String = new(this, "ToString", 0, typeof(System.String));
					r_RToString_String.SetBelong(this.instance);
				}
				return r_RToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_IFormatProvider;
		public virtual RMethod RToString_IFormatProvider
		{
			get
			{
				if(r_RToString_IFormatProvider == null)
				{
					r_RToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_RToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_IFormatProvider;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_RToString_String_IFormatProvider == null)
				{
					r_RToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToUniversalTime()
		/// </summary>
		protected RMethod r_RToUniversalTime;
		public virtual RMethod RToUniversalTime
		{
			get
			{
				if(r_RToUniversalTime == null)
				{
					r_RToUniversalTime = new(this, "ToUniversalTime", 0);
					r_RToUniversalTime.SetBelong(this.instance);
				}
				return r_RToUniversalTime;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_Out_DateTimeOffset;
		public static RMethod RTryParse_String_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParse_String_Out_DateTimeOffset == null)
				{
					r_RTryParse_String_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParse", 0, typeof(System.String), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParse_String_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParse_String_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParse", 0, typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParseExact", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.String[], System.IFormatProvider, System.Globalization.DateTimeStyles, System.DateTimeOffset ByRef)
		/// </summary>
		protected static RMethod r_RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset
		{
			get
			{
				if(r_RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset == null)
				{
					r_RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset = new(typeof(System.DateTimeOffset), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String).MakeArrayType(), typeof(System.IFormatProvider), typeof(System.Globalization.DateTimeStyles), typeof(System.DateTimeOffset).MakeByRefType());
					r_RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.SetBelong(null);
				}
				return r_RTryParseExact_ReadOnlySpan_d_Char_p__StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset;
			}
		}

		/// <summary>
		/// Int16 ValidateOffset(System.TimeSpan)
		/// </summary>
		protected static RMethod r_RValidateOffset_TimeSpan;
		public static RMethod RValidateOffset_TimeSpan
		{
			get
			{
				if(r_RValidateOffset_TimeSpan == null)
				{
					r_RValidateOffset_TimeSpan = new(typeof(System.DateTimeOffset), "ValidateOffset", 0, typeof(System.TimeSpan));
					r_RValidateOffset_TimeSpan.SetBelong(null);
				}
				return r_RValidateOffset_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTime ValidateDate(System.DateTime, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RValidateDate_DateTime_TimeSpan;
		public static RMethod RValidateDate_DateTime_TimeSpan
		{
			get
			{
				if(r_RValidateDate_DateTime_TimeSpan == null)
				{
					r_RValidateDate_DateTime_TimeSpan = new(typeof(System.DateTimeOffset), "ValidateDate", 0, typeof(System.DateTime), typeof(System.TimeSpan));
					r_RValidateDate_DateTime_TimeSpan.SetBelong(null);
				}
				return r_RValidateDate_DateTime_TimeSpan;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeStyles ValidateStyles(System.Globalization.DateTimeStyles, System.String)
		/// </summary>
		protected static RMethod r_RValidateStyles_DateTimeStyles_String;
		public static RMethod RValidateStyles_DateTimeStyles_String
		{
			get
			{
				if(r_RValidateStyles_DateTimeStyles_String == null)
				{
					r_RValidateStyles_DateTimeStyles_String = new(typeof(System.DateTimeOffset), "ValidateStyles", 0, typeof(System.Globalization.DateTimeStyles), typeof(System.String));
					r_RValidateStyles_DateTimeStyles_String.SetBelong(null);
				}
				return r_RValidateStyles_DateTimeStyles_String;
			}
		}

		/// <summary>
		/// System.DateTimeOffset op_Implicit(System.DateTime)
		/// </summary>
		protected static RMethod r_Rop_Implicit_DateTime;
		public static RMethod Rop_Implicit_DateTime
		{
			get
			{
				if(r_Rop_Implicit_DateTime == null)
				{
					r_Rop_Implicit_DateTime = new(typeof(System.DateTimeOffset), "op_Implicit", 0, typeof(System.DateTime));
					r_Rop_Implicit_DateTime.SetBelong(null);
				}
				return r_Rop_Implicit_DateTime;
			}
		}

		/// <summary>
		/// System.DateTimeOffset op_Addition(System.DateTimeOffset, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Rop_Addition_DateTimeOffset_TimeSpan;
		public static RMethod Rop_Addition_DateTimeOffset_TimeSpan
		{
			get
			{
				if(r_Rop_Addition_DateTimeOffset_TimeSpan == null)
				{
					r_Rop_Addition_DateTimeOffset_TimeSpan = new(typeof(System.DateTimeOffset), "op_Addition", 0, typeof(System.DateTimeOffset), typeof(System.TimeSpan));
					r_Rop_Addition_DateTimeOffset_TimeSpan.SetBelong(null);
				}
				return r_Rop_Addition_DateTimeOffset_TimeSpan;
			}
		}

		/// <summary>
		/// System.DateTimeOffset op_Subtraction(System.DateTimeOffset, System.TimeSpan)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_DateTimeOffset_TimeSpan;
		public static RMethod Rop_Subtraction_DateTimeOffset_TimeSpan
		{
			get
			{
				if(r_Rop_Subtraction_DateTimeOffset_TimeSpan == null)
				{
					r_Rop_Subtraction_DateTimeOffset_TimeSpan = new(typeof(System.DateTimeOffset), "op_Subtraction", 0, typeof(System.DateTimeOffset), typeof(System.TimeSpan));
					r_Rop_Subtraction_DateTimeOffset_TimeSpan.SetBelong(null);
				}
				return r_Rop_Subtraction_DateTimeOffset_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan op_Subtraction(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_Subtraction_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_Subtraction_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_Subtraction_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_Subtraction", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_Subtraction_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_Subtraction_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_Equality_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_Equality_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_Equality_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_Equality_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_Equality", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_Equality_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_Equality_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_Inequality_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_Inequality_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_Inequality_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_Inequality_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_Inequality", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_Inequality_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_Inequality_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_LessThan_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_LessThan_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_LessThan_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_LessThan_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_LessThan", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_LessThan_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_LessThan_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_LessThanOrEqual", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_GreaterThan_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_GreaterThan_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_GreaterThan_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_GreaterThan_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_GreaterThan", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_GreaterThan_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_GreaterThan_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.DateTimeOffset, System.DateTimeOffset)
		/// </summary>
		protected static RMethod r_Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset;
		public static RMethod Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset == null)
				{
					r_Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset = new(typeof(System.DateTimeOffset), "op_GreaterThanOrEqual", 0, typeof(System.DateTimeOffset), typeof(System.DateTimeOffset));
					r_Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset.SetBelong(null);
				}
				return r_Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RDateTimeOffset() : base("System.DateTimeOffset")
        {
        }

        public RDateTimeOffset(System.Object instance) : base("System.DateTimeOffset")
		{
            SetInstance(instance);
		}

        public RDateTimeOffset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDateTimeOffset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.DateTimeOffset ToOffset(System.TimeSpan  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RToOffset_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset Add(System.TimeSpan  @timeSpan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSpan};
            var ___result = RAdd_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddDays(System.Double  @days)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@days};
            var ___result = RAddDays_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddHours(System.Double  @hours)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hours};
            var ___result = RAddHours_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddMilliseconds(System.Double  @milliseconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@milliseconds};
            var ___result = RAddMilliseconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddMinutes(System.Double  @minutes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minutes};
            var ___result = RAddMinutes_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddMonths(System.Int32  @months)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@months};
            var ___result = RAddMonths_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddSeconds(System.Double  @seconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@seconds};
            var ___result = RAddSeconds_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddTicks(System.Int64  @ticks)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ticks};
            var ___result = RAddTicks_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset AddYears(System.Int32  @years)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@years};
            var ___result = RAddYears_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.Int32 Compare(System.DateTimeOffset  @first, System.DateTimeOffset  @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@first, @second};
            var ___result = RCompare_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__1__IComparable__1__CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RSystem__1__IComparable__1__CompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.DateTimeOffset  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.DateTimeOffset  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EqualsExact(System.DateTimeOffset  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REqualsExact_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.DateTimeOffset  @first, System.DateTimeOffset  @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@first, @second};
            var ___result = REquals_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.DateTimeOffset FromFileTime(System.Int64  @fileTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileTime};
            var ___result = RFromFileTime_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset FromUnixTimeSeconds(System.Int64  @seconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@seconds};
            var ___result = RFromUnixTimeSeconds_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset FromUnixTimeMilliseconds(System.Int64  @milliseconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@milliseconds};
            var ___result = RFromUnixTimeMilliseconds_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual void System__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.DateTimeOffset Parse(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset Parse(System.String  @input, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider};
            var ___result = RParse_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset Parse(System.String  @input, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider, @styles};
            var ___result = RParse_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }



        public static System.DateTimeOffset ParseExact(System.String  @input, System.String  @format, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider};
            var ___result = RParseExact_String_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset ParseExact(System.String  @input, System.String  @format, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles};
            var ___result = RParseExact_String_String_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }



        public static System.DateTimeOffset ParseExact(System.String  @input, System.String[]  @formats, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles};
            var ___result = RParseExact_String_StringArray_IFormatProvider_DateTimeStyles.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }



        public virtual System.TimeSpan Subtract(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSubtract_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual System.DateTimeOffset Subtract(System.TimeSpan  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSubtract_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.Int64 ToFileTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToFileTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToUnixTimeSeconds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUnixTimeSeconds.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToUnixTimeMilliseconds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUnixTimeMilliseconds.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.DateTimeOffset ToLocalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToLocalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToLocalTime(System.Boolean  @throwOnOverflow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@throwOnOverflow};
            var ___result = RToLocalTime_Boolean.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatProvider};
            var ___result = RToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.DateTimeOffset ToUniversalTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUniversalTime.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.Boolean TryParse(System.String  @input, out System.DateTimeOffset  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RTryParse_String_Out_DateTimeOffset.Invoke(___genericsType, ___parameters);
			result = (System.DateTimeOffset)___parameters[1];

            return (System.Boolean)___result;
        }



        public static System.Boolean TryParse(System.String  @input, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles, out System.DateTimeOffset  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formatProvider, @styles, @result};
            var ___result = RTryParse_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.Invoke(___genericsType, ___parameters);
			result = (System.DateTimeOffset)___parameters[3];

            return (System.Boolean)___result;
        }



        public static System.Boolean TryParseExact(System.String  @input, System.String  @format, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles, out System.DateTimeOffset  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_String_String_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.Invoke(___genericsType, ___parameters);
			result = (System.DateTimeOffset)___parameters[4];

            return (System.Boolean)___result;
        }



        public static System.Boolean TryParseExact(System.String  @input, System.String[]  @formats, System.IFormatProvider  @formatProvider, System.Globalization.DateTimeStyles  @styles, out System.DateTimeOffset  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @formats, @formatProvider, @styles, @result};
            var ___result = RTryParseExact_String_StringArray_IFormatProvider_DateTimeStyles_Out_DateTimeOffset.Invoke(___genericsType, ___parameters);
			result = (System.DateTimeOffset)___parameters[4];

            return (System.Boolean)___result;
        }



        public static System.Int16 ValidateOffset(System.TimeSpan  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset};
            var ___result = RValidateOffset_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public static System.DateTime ValidateDate(System.DateTime  @dateTime, System.TimeSpan  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateTime, @offset};
            var ___result = RValidateDate_DateTime_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public static System.Globalization.DateTimeStyles ValidateStyles(System.Globalization.DateTimeStyles  @style, System.String  @parameterName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style, @parameterName};
            var ___result = RValidateStyles_DateTimeStyles_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.DateTimeStyles)___result;
        }


        public static System.DateTimeOffset op_Implicit(System.DateTime  @dateTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateTime};
            var ___result = Rop_Implicit_DateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset op_Addition(System.DateTimeOffset  @dateTimeOffset, System.TimeSpan  @timeSpan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateTimeOffset, @timeSpan};
            var ___result = Rop_Addition_DateTimeOffset_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.DateTimeOffset op_Subtraction(System.DateTimeOffset  @dateTimeOffset, System.TimeSpan  @timeSpan)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dateTimeOffset, @timeSpan};
            var ___result = Rop_Subtraction_DateTimeOffset_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public static System.TimeSpan op_Subtraction(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Subtraction_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public static System.Boolean op_Equality(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThan_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_LessThanOrEqual_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThan_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.DateTimeOffset  @left, System.DateTimeOffset  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_GreaterThanOrEqual_DateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
