using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlValueConverter
	/// </summary>
    public partial class RXmlValueConverter : RMember //
    {

		/// <summary>
		/// Boolean ToBoolean(Boolean)
		/// </summary>
		protected RMethod r_RToBoolean_Boolean;
		public virtual RMethod RToBoolean_Boolean
		{
			get
			{
				if(r_RToBoolean_Boolean == null)
				{
					r_RToBoolean_Boolean = new(this, "ToBoolean", 0, typeof(System.Boolean));
					r_RToBoolean_Boolean.SetBelong(this.instance);
				}
				return r_RToBoolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(Int64)
		/// </summary>
		protected RMethod r_RToBoolean_Int64;
		public virtual RMethod RToBoolean_Int64
		{
			get
			{
				if(r_RToBoolean_Int64 == null)
				{
					r_RToBoolean_Int64 = new(this, "ToBoolean", 0, typeof(System.Int64));
					r_RToBoolean_Int64.SetBelong(this.instance);
				}
				return r_RToBoolean_Int64;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(Int32)
		/// </summary>
		protected RMethod r_RToBoolean_Int32;
		public virtual RMethod RToBoolean_Int32
		{
			get
			{
				if(r_RToBoolean_Int32 == null)
				{
					r_RToBoolean_Int32 = new(this, "ToBoolean", 0, typeof(System.Int32));
					r_RToBoolean_Int32.SetBelong(this.instance);
				}
				return r_RToBoolean_Int32;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.Decimal)
		/// </summary>
		protected RMethod r_RToBoolean_Decimal;
		public virtual RMethod RToBoolean_Decimal
		{
			get
			{
				if(r_RToBoolean_Decimal == null)
				{
					r_RToBoolean_Decimal = new(this, "ToBoolean", 0, typeof(System.Decimal));
					r_RToBoolean_Decimal.SetBelong(this.instance);
				}
				return r_RToBoolean_Decimal;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(Single)
		/// </summary>
		protected RMethod r_RToBoolean_Single;
		public virtual RMethod RToBoolean_Single
		{
			get
			{
				if(r_RToBoolean_Single == null)
				{
					r_RToBoolean_Single = new(this, "ToBoolean", 0, typeof(System.Single));
					r_RToBoolean_Single.SetBelong(this.instance);
				}
				return r_RToBoolean_Single;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(Double)
		/// </summary>
		protected RMethod r_RToBoolean_Double;
		public virtual RMethod RToBoolean_Double
		{
			get
			{
				if(r_RToBoolean_Double == null)
				{
					r_RToBoolean_Double = new(this, "ToBoolean", 0, typeof(System.Double));
					r_RToBoolean_Double.SetBelong(this.instance);
				}
				return r_RToBoolean_Double;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.DateTime)
		/// </summary>
		protected RMethod r_RToBoolean_DateTime;
		public virtual RMethod RToBoolean_DateTime
		{
			get
			{
				if(r_RToBoolean_DateTime == null)
				{
					r_RToBoolean_DateTime = new(this, "ToBoolean", 0, typeof(System.DateTime));
					r_RToBoolean_DateTime.SetBelong(this.instance);
				}
				return r_RToBoolean_DateTime;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToBoolean_DateTimeOffset;
		public virtual RMethod RToBoolean_DateTimeOffset
		{
			get
			{
				if(r_RToBoolean_DateTimeOffset == null)
				{
					r_RToBoolean_DateTimeOffset = new(this, "ToBoolean", 0, typeof(System.DateTimeOffset));
					r_RToBoolean_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToBoolean_DateTimeOffset;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.String)
		/// </summary>
		protected RMethod r_RToBoolean_String;
		public virtual RMethod RToBoolean_String
		{
			get
			{
				if(r_RToBoolean_String == null)
				{
					r_RToBoolean_String = new(this, "ToBoolean", 0, typeof(System.String));
					r_RToBoolean_String.SetBelong(this.instance);
				}
				return r_RToBoolean_String;
			}
		}

		/// <summary>
		/// Boolean ToBoolean(System.Object)
		/// </summary>
		protected RMethod r_RToBoolean_Object;
		public virtual RMethod RToBoolean_Object
		{
			get
			{
				if(r_RToBoolean_Object == null)
				{
					r_RToBoolean_Object = new(this, "ToBoolean", 0, typeof(System.Object));
					r_RToBoolean_Object.SetBelong(this.instance);
				}
				return r_RToBoolean_Object;
			}
		}

		/// <summary>
		/// Int32 ToInt32(Boolean)
		/// </summary>
		protected RMethod r_RToInt32_Boolean;
		public virtual RMethod RToInt32_Boolean
		{
			get
			{
				if(r_RToInt32_Boolean == null)
				{
					r_RToInt32_Boolean = new(this, "ToInt32", 0, typeof(System.Boolean));
					r_RToInt32_Boolean.SetBelong(this.instance);
				}
				return r_RToInt32_Boolean;
			}
		}

		/// <summary>
		/// Int32 ToInt32(Int32)
		/// </summary>
		protected RMethod r_RToInt32_Int32;
		public virtual RMethod RToInt32_Int32
		{
			get
			{
				if(r_RToInt32_Int32 == null)
				{
					r_RToInt32_Int32 = new(this, "ToInt32", 0, typeof(System.Int32));
					r_RToInt32_Int32.SetBelong(this.instance);
				}
				return r_RToInt32_Int32;
			}
		}

		/// <summary>
		/// Int32 ToInt32(Int64)
		/// </summary>
		protected RMethod r_RToInt32_Int64;
		public virtual RMethod RToInt32_Int64
		{
			get
			{
				if(r_RToInt32_Int64 == null)
				{
					r_RToInt32_Int64 = new(this, "ToInt32", 0, typeof(System.Int64));
					r_RToInt32_Int64.SetBelong(this.instance);
				}
				return r_RToInt32_Int64;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Decimal)
		/// </summary>
		protected RMethod r_RToInt32_Decimal;
		public virtual RMethod RToInt32_Decimal
		{
			get
			{
				if(r_RToInt32_Decimal == null)
				{
					r_RToInt32_Decimal = new(this, "ToInt32", 0, typeof(System.Decimal));
					r_RToInt32_Decimal.SetBelong(this.instance);
				}
				return r_RToInt32_Decimal;
			}
		}

		/// <summary>
		/// Int32 ToInt32(Single)
		/// </summary>
		protected RMethod r_RToInt32_Single;
		public virtual RMethod RToInt32_Single
		{
			get
			{
				if(r_RToInt32_Single == null)
				{
					r_RToInt32_Single = new(this, "ToInt32", 0, typeof(System.Single));
					r_RToInt32_Single.SetBelong(this.instance);
				}
				return r_RToInt32_Single;
			}
		}

		/// <summary>
		/// Int32 ToInt32(Double)
		/// </summary>
		protected RMethod r_RToInt32_Double;
		public virtual RMethod RToInt32_Double
		{
			get
			{
				if(r_RToInt32_Double == null)
				{
					r_RToInt32_Double = new(this, "ToInt32", 0, typeof(System.Double));
					r_RToInt32_Double.SetBelong(this.instance);
				}
				return r_RToInt32_Double;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.DateTime)
		/// </summary>
		protected RMethod r_RToInt32_DateTime;
		public virtual RMethod RToInt32_DateTime
		{
			get
			{
				if(r_RToInt32_DateTime == null)
				{
					r_RToInt32_DateTime = new(this, "ToInt32", 0, typeof(System.DateTime));
					r_RToInt32_DateTime.SetBelong(this.instance);
				}
				return r_RToInt32_DateTime;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToInt32_DateTimeOffset;
		public virtual RMethod RToInt32_DateTimeOffset
		{
			get
			{
				if(r_RToInt32_DateTimeOffset == null)
				{
					r_RToInt32_DateTimeOffset = new(this, "ToInt32", 0, typeof(System.DateTimeOffset));
					r_RToInt32_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToInt32_DateTimeOffset;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.String)
		/// </summary>
		protected RMethod r_RToInt32_String;
		public virtual RMethod RToInt32_String
		{
			get
			{
				if(r_RToInt32_String == null)
				{
					r_RToInt32_String = new(this, "ToInt32", 0, typeof(System.String));
					r_RToInt32_String.SetBelong(this.instance);
				}
				return r_RToInt32_String;
			}
		}

		/// <summary>
		/// Int32 ToInt32(System.Object)
		/// </summary>
		protected RMethod r_RToInt32_Object;
		public virtual RMethod RToInt32_Object
		{
			get
			{
				if(r_RToInt32_Object == null)
				{
					r_RToInt32_Object = new(this, "ToInt32", 0, typeof(System.Object));
					r_RToInt32_Object.SetBelong(this.instance);
				}
				return r_RToInt32_Object;
			}
		}

		/// <summary>
		/// Int64 ToInt64(Boolean)
		/// </summary>
		protected RMethod r_RToInt64_Boolean;
		public virtual RMethod RToInt64_Boolean
		{
			get
			{
				if(r_RToInt64_Boolean == null)
				{
					r_RToInt64_Boolean = new(this, "ToInt64", 0, typeof(System.Boolean));
					r_RToInt64_Boolean.SetBelong(this.instance);
				}
				return r_RToInt64_Boolean;
			}
		}

		/// <summary>
		/// Int64 ToInt64(Int32)
		/// </summary>
		protected RMethod r_RToInt64_Int32;
		public virtual RMethod RToInt64_Int32
		{
			get
			{
				if(r_RToInt64_Int32 == null)
				{
					r_RToInt64_Int32 = new(this, "ToInt64", 0, typeof(System.Int32));
					r_RToInt64_Int32.SetBelong(this.instance);
				}
				return r_RToInt64_Int32;
			}
		}

		/// <summary>
		/// Int64 ToInt64(Int64)
		/// </summary>
		protected RMethod r_RToInt64_Int64;
		public virtual RMethod RToInt64_Int64
		{
			get
			{
				if(r_RToInt64_Int64 == null)
				{
					r_RToInt64_Int64 = new(this, "ToInt64", 0, typeof(System.Int64));
					r_RToInt64_Int64.SetBelong(this.instance);
				}
				return r_RToInt64_Int64;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Decimal)
		/// </summary>
		protected RMethod r_RToInt64_Decimal;
		public virtual RMethod RToInt64_Decimal
		{
			get
			{
				if(r_RToInt64_Decimal == null)
				{
					r_RToInt64_Decimal = new(this, "ToInt64", 0, typeof(System.Decimal));
					r_RToInt64_Decimal.SetBelong(this.instance);
				}
				return r_RToInt64_Decimal;
			}
		}

		/// <summary>
		/// Int64 ToInt64(Single)
		/// </summary>
		protected RMethod r_RToInt64_Single;
		public virtual RMethod RToInt64_Single
		{
			get
			{
				if(r_RToInt64_Single == null)
				{
					r_RToInt64_Single = new(this, "ToInt64", 0, typeof(System.Single));
					r_RToInt64_Single.SetBelong(this.instance);
				}
				return r_RToInt64_Single;
			}
		}

		/// <summary>
		/// Int64 ToInt64(Double)
		/// </summary>
		protected RMethod r_RToInt64_Double;
		public virtual RMethod RToInt64_Double
		{
			get
			{
				if(r_RToInt64_Double == null)
				{
					r_RToInt64_Double = new(this, "ToInt64", 0, typeof(System.Double));
					r_RToInt64_Double.SetBelong(this.instance);
				}
				return r_RToInt64_Double;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.DateTime)
		/// </summary>
		protected RMethod r_RToInt64_DateTime;
		public virtual RMethod RToInt64_DateTime
		{
			get
			{
				if(r_RToInt64_DateTime == null)
				{
					r_RToInt64_DateTime = new(this, "ToInt64", 0, typeof(System.DateTime));
					r_RToInt64_DateTime.SetBelong(this.instance);
				}
				return r_RToInt64_DateTime;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToInt64_DateTimeOffset;
		public virtual RMethod RToInt64_DateTimeOffset
		{
			get
			{
				if(r_RToInt64_DateTimeOffset == null)
				{
					r_RToInt64_DateTimeOffset = new(this, "ToInt64", 0, typeof(System.DateTimeOffset));
					r_RToInt64_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToInt64_DateTimeOffset;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.String)
		/// </summary>
		protected RMethod r_RToInt64_String;
		public virtual RMethod RToInt64_String
		{
			get
			{
				if(r_RToInt64_String == null)
				{
					r_RToInt64_String = new(this, "ToInt64", 0, typeof(System.String));
					r_RToInt64_String.SetBelong(this.instance);
				}
				return r_RToInt64_String;
			}
		}

		/// <summary>
		/// Int64 ToInt64(System.Object)
		/// </summary>
		protected RMethod r_RToInt64_Object;
		public virtual RMethod RToInt64_Object
		{
			get
			{
				if(r_RToInt64_Object == null)
				{
					r_RToInt64_Object = new(this, "ToInt64", 0, typeof(System.Object));
					r_RToInt64_Object.SetBelong(this.instance);
				}
				return r_RToInt64_Object;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Boolean)
		/// </summary>
		protected RMethod r_RToDecimal_Boolean;
		public virtual RMethod RToDecimal_Boolean
		{
			get
			{
				if(r_RToDecimal_Boolean == null)
				{
					r_RToDecimal_Boolean = new(this, "ToDecimal", 0, typeof(System.Boolean));
					r_RToDecimal_Boolean.SetBelong(this.instance);
				}
				return r_RToDecimal_Boolean;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Int32)
		/// </summary>
		protected RMethod r_RToDecimal_Int32;
		public virtual RMethod RToDecimal_Int32
		{
			get
			{
				if(r_RToDecimal_Int32 == null)
				{
					r_RToDecimal_Int32 = new(this, "ToDecimal", 0, typeof(System.Int32));
					r_RToDecimal_Int32.SetBelong(this.instance);
				}
				return r_RToDecimal_Int32;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Int64)
		/// </summary>
		protected RMethod r_RToDecimal_Int64;
		public virtual RMethod RToDecimal_Int64
		{
			get
			{
				if(r_RToDecimal_Int64 == null)
				{
					r_RToDecimal_Int64 = new(this, "ToDecimal", 0, typeof(System.Int64));
					r_RToDecimal_Int64.SetBelong(this.instance);
				}
				return r_RToDecimal_Int64;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.Decimal)
		/// </summary>
		protected RMethod r_RToDecimal_Decimal;
		public virtual RMethod RToDecimal_Decimal
		{
			get
			{
				if(r_RToDecimal_Decimal == null)
				{
					r_RToDecimal_Decimal = new(this, "ToDecimal", 0, typeof(System.Decimal));
					r_RToDecimal_Decimal.SetBelong(this.instance);
				}
				return r_RToDecimal_Decimal;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Single)
		/// </summary>
		protected RMethod r_RToDecimal_Single;
		public virtual RMethod RToDecimal_Single
		{
			get
			{
				if(r_RToDecimal_Single == null)
				{
					r_RToDecimal_Single = new(this, "ToDecimal", 0, typeof(System.Single));
					r_RToDecimal_Single.SetBelong(this.instance);
				}
				return r_RToDecimal_Single;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(Double)
		/// </summary>
		protected RMethod r_RToDecimal_Double;
		public virtual RMethod RToDecimal_Double
		{
			get
			{
				if(r_RToDecimal_Double == null)
				{
					r_RToDecimal_Double = new(this, "ToDecimal", 0, typeof(System.Double));
					r_RToDecimal_Double.SetBelong(this.instance);
				}
				return r_RToDecimal_Double;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.DateTime)
		/// </summary>
		protected RMethod r_RToDecimal_DateTime;
		public virtual RMethod RToDecimal_DateTime
		{
			get
			{
				if(r_RToDecimal_DateTime == null)
				{
					r_RToDecimal_DateTime = new(this, "ToDecimal", 0, typeof(System.DateTime));
					r_RToDecimal_DateTime.SetBelong(this.instance);
				}
				return r_RToDecimal_DateTime;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToDecimal_DateTimeOffset;
		public virtual RMethod RToDecimal_DateTimeOffset
		{
			get
			{
				if(r_RToDecimal_DateTimeOffset == null)
				{
					r_RToDecimal_DateTimeOffset = new(this, "ToDecimal", 0, typeof(System.DateTimeOffset));
					r_RToDecimal_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToDecimal_DateTimeOffset;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.String)
		/// </summary>
		protected RMethod r_RToDecimal_String;
		public virtual RMethod RToDecimal_String
		{
			get
			{
				if(r_RToDecimal_String == null)
				{
					r_RToDecimal_String = new(this, "ToDecimal", 0, typeof(System.String));
					r_RToDecimal_String.SetBelong(this.instance);
				}
				return r_RToDecimal_String;
			}
		}

		/// <summary>
		/// System.Decimal ToDecimal(System.Object)
		/// </summary>
		protected RMethod r_RToDecimal_Object;
		public virtual RMethod RToDecimal_Object
		{
			get
			{
				if(r_RToDecimal_Object == null)
				{
					r_RToDecimal_Object = new(this, "ToDecimal", 0, typeof(System.Object));
					r_RToDecimal_Object.SetBelong(this.instance);
				}
				return r_RToDecimal_Object;
			}
		}

		/// <summary>
		/// Double ToDouble(Boolean)
		/// </summary>
		protected RMethod r_RToDouble_Boolean;
		public virtual RMethod RToDouble_Boolean
		{
			get
			{
				if(r_RToDouble_Boolean == null)
				{
					r_RToDouble_Boolean = new(this, "ToDouble", 0, typeof(System.Boolean));
					r_RToDouble_Boolean.SetBelong(this.instance);
				}
				return r_RToDouble_Boolean;
			}
		}

		/// <summary>
		/// Double ToDouble(Int32)
		/// </summary>
		protected RMethod r_RToDouble_Int32;
		public virtual RMethod RToDouble_Int32
		{
			get
			{
				if(r_RToDouble_Int32 == null)
				{
					r_RToDouble_Int32 = new(this, "ToDouble", 0, typeof(System.Int32));
					r_RToDouble_Int32.SetBelong(this.instance);
				}
				return r_RToDouble_Int32;
			}
		}

		/// <summary>
		/// Double ToDouble(Int64)
		/// </summary>
		protected RMethod r_RToDouble_Int64;
		public virtual RMethod RToDouble_Int64
		{
			get
			{
				if(r_RToDouble_Int64 == null)
				{
					r_RToDouble_Int64 = new(this, "ToDouble", 0, typeof(System.Int64));
					r_RToDouble_Int64.SetBelong(this.instance);
				}
				return r_RToDouble_Int64;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Decimal)
		/// </summary>
		protected RMethod r_RToDouble_Decimal;
		public virtual RMethod RToDouble_Decimal
		{
			get
			{
				if(r_RToDouble_Decimal == null)
				{
					r_RToDouble_Decimal = new(this, "ToDouble", 0, typeof(System.Decimal));
					r_RToDouble_Decimal.SetBelong(this.instance);
				}
				return r_RToDouble_Decimal;
			}
		}

		/// <summary>
		/// Double ToDouble(Single)
		/// </summary>
		protected RMethod r_RToDouble_Single;
		public virtual RMethod RToDouble_Single
		{
			get
			{
				if(r_RToDouble_Single == null)
				{
					r_RToDouble_Single = new(this, "ToDouble", 0, typeof(System.Single));
					r_RToDouble_Single.SetBelong(this.instance);
				}
				return r_RToDouble_Single;
			}
		}

		/// <summary>
		/// Double ToDouble(Double)
		/// </summary>
		protected RMethod r_RToDouble_Double;
		public virtual RMethod RToDouble_Double
		{
			get
			{
				if(r_RToDouble_Double == null)
				{
					r_RToDouble_Double = new(this, "ToDouble", 0, typeof(System.Double));
					r_RToDouble_Double.SetBelong(this.instance);
				}
				return r_RToDouble_Double;
			}
		}

		/// <summary>
		/// Double ToDouble(System.DateTime)
		/// </summary>
		protected RMethod r_RToDouble_DateTime;
		public virtual RMethod RToDouble_DateTime
		{
			get
			{
				if(r_RToDouble_DateTime == null)
				{
					r_RToDouble_DateTime = new(this, "ToDouble", 0, typeof(System.DateTime));
					r_RToDouble_DateTime.SetBelong(this.instance);
				}
				return r_RToDouble_DateTime;
			}
		}

		/// <summary>
		/// Double ToDouble(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToDouble_DateTimeOffset;
		public virtual RMethod RToDouble_DateTimeOffset
		{
			get
			{
				if(r_RToDouble_DateTimeOffset == null)
				{
					r_RToDouble_DateTimeOffset = new(this, "ToDouble", 0, typeof(System.DateTimeOffset));
					r_RToDouble_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToDouble_DateTimeOffset;
			}
		}

		/// <summary>
		/// Double ToDouble(System.String)
		/// </summary>
		protected RMethod r_RToDouble_String;
		public virtual RMethod RToDouble_String
		{
			get
			{
				if(r_RToDouble_String == null)
				{
					r_RToDouble_String = new(this, "ToDouble", 0, typeof(System.String));
					r_RToDouble_String.SetBelong(this.instance);
				}
				return r_RToDouble_String;
			}
		}

		/// <summary>
		/// Double ToDouble(System.Object)
		/// </summary>
		protected RMethod r_RToDouble_Object;
		public virtual RMethod RToDouble_Object
		{
			get
			{
				if(r_RToDouble_Object == null)
				{
					r_RToDouble_Object = new(this, "ToDouble", 0, typeof(System.Object));
					r_RToDouble_Object.SetBelong(this.instance);
				}
				return r_RToDouble_Object;
			}
		}

		/// <summary>
		/// Single ToSingle(Boolean)
		/// </summary>
		protected RMethod r_RToSingle_Boolean;
		public virtual RMethod RToSingle_Boolean
		{
			get
			{
				if(r_RToSingle_Boolean == null)
				{
					r_RToSingle_Boolean = new(this, "ToSingle", 0, typeof(System.Boolean));
					r_RToSingle_Boolean.SetBelong(this.instance);
				}
				return r_RToSingle_Boolean;
			}
		}

		/// <summary>
		/// Single ToSingle(Int32)
		/// </summary>
		protected RMethod r_RToSingle_Int32;
		public virtual RMethod RToSingle_Int32
		{
			get
			{
				if(r_RToSingle_Int32 == null)
				{
					r_RToSingle_Int32 = new(this, "ToSingle", 0, typeof(System.Int32));
					r_RToSingle_Int32.SetBelong(this.instance);
				}
				return r_RToSingle_Int32;
			}
		}

		/// <summary>
		/// Single ToSingle(Int64)
		/// </summary>
		protected RMethod r_RToSingle_Int64;
		public virtual RMethod RToSingle_Int64
		{
			get
			{
				if(r_RToSingle_Int64 == null)
				{
					r_RToSingle_Int64 = new(this, "ToSingle", 0, typeof(System.Int64));
					r_RToSingle_Int64.SetBelong(this.instance);
				}
				return r_RToSingle_Int64;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Decimal)
		/// </summary>
		protected RMethod r_RToSingle_Decimal;
		public virtual RMethod RToSingle_Decimal
		{
			get
			{
				if(r_RToSingle_Decimal == null)
				{
					r_RToSingle_Decimal = new(this, "ToSingle", 0, typeof(System.Decimal));
					r_RToSingle_Decimal.SetBelong(this.instance);
				}
				return r_RToSingle_Decimal;
			}
		}

		/// <summary>
		/// Single ToSingle(Single)
		/// </summary>
		protected RMethod r_RToSingle_Single;
		public virtual RMethod RToSingle_Single
		{
			get
			{
				if(r_RToSingle_Single == null)
				{
					r_RToSingle_Single = new(this, "ToSingle", 0, typeof(System.Single));
					r_RToSingle_Single.SetBelong(this.instance);
				}
				return r_RToSingle_Single;
			}
		}

		/// <summary>
		/// Single ToSingle(Double)
		/// </summary>
		protected RMethod r_RToSingle_Double;
		public virtual RMethod RToSingle_Double
		{
			get
			{
				if(r_RToSingle_Double == null)
				{
					r_RToSingle_Double = new(this, "ToSingle", 0, typeof(System.Double));
					r_RToSingle_Double.SetBelong(this.instance);
				}
				return r_RToSingle_Double;
			}
		}

		/// <summary>
		/// Single ToSingle(System.DateTime)
		/// </summary>
		protected RMethod r_RToSingle_DateTime;
		public virtual RMethod RToSingle_DateTime
		{
			get
			{
				if(r_RToSingle_DateTime == null)
				{
					r_RToSingle_DateTime = new(this, "ToSingle", 0, typeof(System.DateTime));
					r_RToSingle_DateTime.SetBelong(this.instance);
				}
				return r_RToSingle_DateTime;
			}
		}

		/// <summary>
		/// Single ToSingle(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToSingle_DateTimeOffset;
		public virtual RMethod RToSingle_DateTimeOffset
		{
			get
			{
				if(r_RToSingle_DateTimeOffset == null)
				{
					r_RToSingle_DateTimeOffset = new(this, "ToSingle", 0, typeof(System.DateTimeOffset));
					r_RToSingle_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToSingle_DateTimeOffset;
			}
		}

		/// <summary>
		/// Single ToSingle(System.String)
		/// </summary>
		protected RMethod r_RToSingle_String;
		public virtual RMethod RToSingle_String
		{
			get
			{
				if(r_RToSingle_String == null)
				{
					r_RToSingle_String = new(this, "ToSingle", 0, typeof(System.String));
					r_RToSingle_String.SetBelong(this.instance);
				}
				return r_RToSingle_String;
			}
		}

		/// <summary>
		/// Single ToSingle(System.Object)
		/// </summary>
		protected RMethod r_RToSingle_Object;
		public virtual RMethod RToSingle_Object
		{
			get
			{
				if(r_RToSingle_Object == null)
				{
					r_RToSingle_Object = new(this, "ToSingle", 0, typeof(System.Object));
					r_RToSingle_Object.SetBelong(this.instance);
				}
				return r_RToSingle_Object;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Boolean)
		/// </summary>
		protected RMethod r_RToDateTime_Boolean;
		public virtual RMethod RToDateTime_Boolean
		{
			get
			{
				if(r_RToDateTime_Boolean == null)
				{
					r_RToDateTime_Boolean = new(this, "ToDateTime", 0, typeof(System.Boolean));
					r_RToDateTime_Boolean.SetBelong(this.instance);
				}
				return r_RToDateTime_Boolean;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int32)
		/// </summary>
		protected RMethod r_RToDateTime_Int32;
		public virtual RMethod RToDateTime_Int32
		{
			get
			{
				if(r_RToDateTime_Int32 == null)
				{
					r_RToDateTime_Int32 = new(this, "ToDateTime", 0, typeof(System.Int32));
					r_RToDateTime_Int32.SetBelong(this.instance);
				}
				return r_RToDateTime_Int32;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Int64)
		/// </summary>
		protected RMethod r_RToDateTime_Int64;
		public virtual RMethod RToDateTime_Int64
		{
			get
			{
				if(r_RToDateTime_Int64 == null)
				{
					r_RToDateTime_Int64 = new(this, "ToDateTime", 0, typeof(System.Int64));
					r_RToDateTime_Int64.SetBelong(this.instance);
				}
				return r_RToDateTime_Int64;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.Decimal)
		/// </summary>
		protected RMethod r_RToDateTime_Decimal;
		public virtual RMethod RToDateTime_Decimal
		{
			get
			{
				if(r_RToDateTime_Decimal == null)
				{
					r_RToDateTime_Decimal = new(this, "ToDateTime", 0, typeof(System.Decimal));
					r_RToDateTime_Decimal.SetBelong(this.instance);
				}
				return r_RToDateTime_Decimal;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Single)
		/// </summary>
		protected RMethod r_RToDateTime_Single;
		public virtual RMethod RToDateTime_Single
		{
			get
			{
				if(r_RToDateTime_Single == null)
				{
					r_RToDateTime_Single = new(this, "ToDateTime", 0, typeof(System.Single));
					r_RToDateTime_Single.SetBelong(this.instance);
				}
				return r_RToDateTime_Single;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(Double)
		/// </summary>
		protected RMethod r_RToDateTime_Double;
		public virtual RMethod RToDateTime_Double
		{
			get
			{
				if(r_RToDateTime_Double == null)
				{
					r_RToDateTime_Double = new(this, "ToDateTime", 0, typeof(System.Double));
					r_RToDateTime_Double.SetBelong(this.instance);
				}
				return r_RToDateTime_Double;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.DateTime)
		/// </summary>
		protected RMethod r_RToDateTime_DateTime;
		public virtual RMethod RToDateTime_DateTime
		{
			get
			{
				if(r_RToDateTime_DateTime == null)
				{
					r_RToDateTime_DateTime = new(this, "ToDateTime", 0, typeof(System.DateTime));
					r_RToDateTime_DateTime.SetBelong(this.instance);
				}
				return r_RToDateTime_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToDateTime_DateTimeOffset;
		public virtual RMethod RToDateTime_DateTimeOffset
		{
			get
			{
				if(r_RToDateTime_DateTimeOffset == null)
				{
					r_RToDateTime_DateTimeOffset = new(this, "ToDateTime", 0, typeof(System.DateTimeOffset));
					r_RToDateTime_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToDateTime_DateTimeOffset;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.String)
		/// </summary>
		protected RMethod r_RToDateTime_String;
		public virtual RMethod RToDateTime_String
		{
			get
			{
				if(r_RToDateTime_String == null)
				{
					r_RToDateTime_String = new(this, "ToDateTime", 0, typeof(System.String));
					r_RToDateTime_String.SetBelong(this.instance);
				}
				return r_RToDateTime_String;
			}
		}

		/// <summary>
		/// System.DateTime ToDateTime(System.Object)
		/// </summary>
		protected RMethod r_RToDateTime_Object;
		public virtual RMethod RToDateTime_Object
		{
			get
			{
				if(r_RToDateTime_Object == null)
				{
					r_RToDateTime_Object = new(this, "ToDateTime", 0, typeof(System.Object));
					r_RToDateTime_Object.SetBelong(this.instance);
				}
				return r_RToDateTime_Object;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(Boolean)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Boolean;
		public virtual RMethod RToDateTimeOffset_Boolean
		{
			get
			{
				if(r_RToDateTimeOffset_Boolean == null)
				{
					r_RToDateTimeOffset_Boolean = new(this, "ToDateTimeOffset", 0, typeof(System.Boolean));
					r_RToDateTimeOffset_Boolean.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Boolean;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(Int32)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Int32;
		public virtual RMethod RToDateTimeOffset_Int32
		{
			get
			{
				if(r_RToDateTimeOffset_Int32 == null)
				{
					r_RToDateTimeOffset_Int32 = new(this, "ToDateTimeOffset", 0, typeof(System.Int32));
					r_RToDateTimeOffset_Int32.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Int32;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(Int64)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Int64;
		public virtual RMethod RToDateTimeOffset_Int64
		{
			get
			{
				if(r_RToDateTimeOffset_Int64 == null)
				{
					r_RToDateTimeOffset_Int64 = new(this, "ToDateTimeOffset", 0, typeof(System.Int64));
					r_RToDateTimeOffset_Int64.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Int64;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(System.Decimal)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Decimal;
		public virtual RMethod RToDateTimeOffset_Decimal
		{
			get
			{
				if(r_RToDateTimeOffset_Decimal == null)
				{
					r_RToDateTimeOffset_Decimal = new(this, "ToDateTimeOffset", 0, typeof(System.Decimal));
					r_RToDateTimeOffset_Decimal.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Decimal;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(Single)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Single;
		public virtual RMethod RToDateTimeOffset_Single
		{
			get
			{
				if(r_RToDateTimeOffset_Single == null)
				{
					r_RToDateTimeOffset_Single = new(this, "ToDateTimeOffset", 0, typeof(System.Single));
					r_RToDateTimeOffset_Single.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Single;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(Double)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Double;
		public virtual RMethod RToDateTimeOffset_Double
		{
			get
			{
				if(r_RToDateTimeOffset_Double == null)
				{
					r_RToDateTimeOffset_Double = new(this, "ToDateTimeOffset", 0, typeof(System.Double));
					r_RToDateTimeOffset_Double.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Double;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(System.DateTime)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_DateTime;
		public virtual RMethod RToDateTimeOffset_DateTime
		{
			get
			{
				if(r_RToDateTimeOffset_DateTime == null)
				{
					r_RToDateTimeOffset_DateTime = new(this, "ToDateTimeOffset", 0, typeof(System.DateTime));
					r_RToDateTimeOffset_DateTime.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_DateTime;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_DateTimeOffset;
		public virtual RMethod RToDateTimeOffset_DateTimeOffset
		{
			get
			{
				if(r_RToDateTimeOffset_DateTimeOffset == null)
				{
					r_RToDateTimeOffset_DateTimeOffset = new(this, "ToDateTimeOffset", 0, typeof(System.DateTimeOffset));
					r_RToDateTimeOffset_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_DateTimeOffset;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(System.String)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_String;
		public virtual RMethod RToDateTimeOffset_String
		{
			get
			{
				if(r_RToDateTimeOffset_String == null)
				{
					r_RToDateTimeOffset_String = new(this, "ToDateTimeOffset", 0, typeof(System.String));
					r_RToDateTimeOffset_String.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_String;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ToDateTimeOffset(System.Object)
		/// </summary>
		protected RMethod r_RToDateTimeOffset_Object;
		public virtual RMethod RToDateTimeOffset_Object
		{
			get
			{
				if(r_RToDateTimeOffset_Object == null)
				{
					r_RToDateTimeOffset_Object = new(this, "ToDateTimeOffset", 0, typeof(System.Object));
					r_RToDateTimeOffset_Object.SetBelong(this.instance);
				}
				return r_RToDateTimeOffset_Object;
			}
		}

		/// <summary>
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_RToString_Boolean;
		public virtual RMethod RToString_Boolean
		{
			get
			{
				if(r_RToString_Boolean == null)
				{
					r_RToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
					r_RToString_Boolean.SetBelong(this.instance);
				}
				return r_RToString_Boolean;
			}
		}

		/// <summary>
		/// System.String ToString(Int32)
		/// </summary>
		protected RMethod r_RToString_Int32;
		public virtual RMethod RToString_Int32
		{
			get
			{
				if(r_RToString_Int32 == null)
				{
					r_RToString_Int32 = new(this, "ToString", 0, typeof(System.Int32));
					r_RToString_Int32.SetBelong(this.instance);
				}
				return r_RToString_Int32;
			}
		}

		/// <summary>
		/// System.String ToString(Int64)
		/// </summary>
		protected RMethod r_RToString_Int64;
		public virtual RMethod RToString_Int64
		{
			get
			{
				if(r_RToString_Int64 == null)
				{
					r_RToString_Int64 = new(this, "ToString", 0, typeof(System.Int64));
					r_RToString_Int64.SetBelong(this.instance);
				}
				return r_RToString_Int64;
			}
		}

		/// <summary>
		/// System.String ToString(System.Decimal)
		/// </summary>
		protected RMethod r_RToString_Decimal;
		public virtual RMethod RToString_Decimal
		{
			get
			{
				if(r_RToString_Decimal == null)
				{
					r_RToString_Decimal = new(this, "ToString", 0, typeof(System.Decimal));
					r_RToString_Decimal.SetBelong(this.instance);
				}
				return r_RToString_Decimal;
			}
		}

		/// <summary>
		/// System.String ToString(Single)
		/// </summary>
		protected RMethod r_RToString_Single;
		public virtual RMethod RToString_Single
		{
			get
			{
				if(r_RToString_Single == null)
				{
					r_RToString_Single = new(this, "ToString", 0, typeof(System.Single));
					r_RToString_Single.SetBelong(this.instance);
				}
				return r_RToString_Single;
			}
		}

		/// <summary>
		/// System.String ToString(Double)
		/// </summary>
		protected RMethod r_RToString_Double;
		public virtual RMethod RToString_Double
		{
			get
			{
				if(r_RToString_Double == null)
				{
					r_RToString_Double = new(this, "ToString", 0, typeof(System.Double));
					r_RToString_Double.SetBelong(this.instance);
				}
				return r_RToString_Double;
			}
		}

		/// <summary>
		/// System.String ToString(System.DateTime)
		/// </summary>
		protected RMethod r_RToString_DateTime;
		public virtual RMethod RToString_DateTime
		{
			get
			{
				if(r_RToString_DateTime == null)
				{
					r_RToString_DateTime = new(this, "ToString", 0, typeof(System.DateTime));
					r_RToString_DateTime.SetBelong(this.instance);
				}
				return r_RToString_DateTime;
			}
		}

		/// <summary>
		/// System.String ToString(System.DateTimeOffset)
		/// </summary>
		protected RMethod r_RToString_DateTimeOffset;
		public virtual RMethod RToString_DateTimeOffset
		{
			get
			{
				if(r_RToString_DateTimeOffset == null)
				{
					r_RToString_DateTimeOffset = new(this, "ToString", 0, typeof(System.DateTimeOffset));
					r_RToString_DateTimeOffset.SetBelong(this.instance);
				}
				return r_RToString_DateTimeOffset;
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
		/// System.String ToString(System.String, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RToString_String_IXmlNamespaceResolver;
		public virtual RMethod RToString_String_IXmlNamespaceResolver
		{
			get
			{
				if(r_RToString_String_IXmlNamespaceResolver == null)
				{
					r_RToString_String_IXmlNamespaceResolver = new(this, "ToString", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver));
					r_RToString_String_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RToString_String_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.String ToString(System.Object)
		/// </summary>
		protected RMethod r_RToString_Object;
		public virtual RMethod RToString_Object
		{
			get
			{
				if(r_RToString_Object == null)
				{
					r_RToString_Object = new(this, "ToString", 0, typeof(System.Object));
					r_RToString_Object.SetBelong(this.instance);
				}
				return r_RToString_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.Object, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RToString_Object_IXmlNamespaceResolver;
		public virtual RMethod RToString_Object_IXmlNamespaceResolver
		{
			get
			{
				if(r_RToString_Object_IXmlNamespaceResolver == null)
				{
					r_RToString_Object_IXmlNamespaceResolver = new(this, "ToString", 0, typeof(System.Object), typeof(System.Xml.IXmlNamespaceResolver));
					r_RToString_Object_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RToString_Object_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ChangeType(Boolean, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Boolean_Type;
		public virtual RMethod RChangeType_Boolean_Type
		{
			get
			{
				if(r_RChangeType_Boolean_Type == null)
				{
					r_RChangeType_Boolean_Type = new(this, "ChangeType", 0, typeof(System.Boolean), typeof(System.Type));
					r_RChangeType_Boolean_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(Int32, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Int32_Type;
		public virtual RMethod RChangeType_Int32_Type
		{
			get
			{
				if(r_RChangeType_Int32_Type == null)
				{
					r_RChangeType_Int32_Type = new(this, "ChangeType", 0, typeof(System.Int32), typeof(System.Type));
					r_RChangeType_Int32_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Int32_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(Int64, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Int64_Type;
		public virtual RMethod RChangeType_Int64_Type
		{
			get
			{
				if(r_RChangeType_Int64_Type == null)
				{
					r_RChangeType_Int64_Type = new(this, "ChangeType", 0, typeof(System.Int64), typeof(System.Type));
					r_RChangeType_Int64_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Int64_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Decimal, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Decimal_Type;
		public virtual RMethod RChangeType_Decimal_Type
		{
			get
			{
				if(r_RChangeType_Decimal_Type == null)
				{
					r_RChangeType_Decimal_Type = new(this, "ChangeType", 0, typeof(System.Decimal), typeof(System.Type));
					r_RChangeType_Decimal_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Decimal_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(Single, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Single_Type;
		public virtual RMethod RChangeType_Single_Type
		{
			get
			{
				if(r_RChangeType_Single_Type == null)
				{
					r_RChangeType_Single_Type = new(this, "ChangeType", 0, typeof(System.Single), typeof(System.Type));
					r_RChangeType_Single_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Single_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(Double, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Double_Type;
		public virtual RMethod RChangeType_Double_Type
		{
			get
			{
				if(r_RChangeType_Double_Type == null)
				{
					r_RChangeType_Double_Type = new(this, "ChangeType", 0, typeof(System.Double), typeof(System.Type));
					r_RChangeType_Double_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Double_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.DateTime, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_DateTime_Type;
		public virtual RMethod RChangeType_DateTime_Type
		{
			get
			{
				if(r_RChangeType_DateTime_Type == null)
				{
					r_RChangeType_DateTime_Type = new(this, "ChangeType", 0, typeof(System.DateTime), typeof(System.Type));
					r_RChangeType_DateTime_Type.SetBelong(this.instance);
				}
				return r_RChangeType_DateTime_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.DateTimeOffset, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_DateTimeOffset_Type;
		public virtual RMethod RChangeType_DateTimeOffset_Type
		{
			get
			{
				if(r_RChangeType_DateTimeOffset_Type == null)
				{
					r_RChangeType_DateTimeOffset_Type = new(this, "ChangeType", 0, typeof(System.DateTimeOffset), typeof(System.Type));
					r_RChangeType_DateTimeOffset_Type.SetBelong(this.instance);
				}
				return r_RChangeType_DateTimeOffset_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.String, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_String_Type;
		public virtual RMethod RChangeType_String_Type
		{
			get
			{
				if(r_RChangeType_String_Type == null)
				{
					r_RChangeType_String_Type = new(this, "ChangeType", 0, typeof(System.String), typeof(System.Type));
					r_RChangeType_String_Type.SetBelong(this.instance);
				}
				return r_RChangeType_String_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.String, System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RChangeType_String_Type_IXmlNamespaceResolver;
		public virtual RMethod RChangeType_String_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RChangeType_String_Type_IXmlNamespaceResolver == null)
				{
					r_RChangeType_String_Type_IXmlNamespaceResolver = new(this, "ChangeType", 0, typeof(System.String), typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RChangeType_String_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RChangeType_String_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Object_Type;
		public virtual RMethod RChangeType_Object_Type
		{
			get
			{
				if(r_RChangeType_Object_Type == null)
				{
					r_RChangeType_Object_Type = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type));
					r_RChangeType_Object_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Object_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RChangeType_Object_Type_IXmlNamespaceResolver;
		public virtual RMethod RChangeType_Object_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RChangeType_Object_Type_IXmlNamespaceResolver == null)
				{
					r_RChangeType_Object_Type_IXmlNamespaceResolver = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RChangeType_Object_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RChangeType_Object_Type_IXmlNamespaceResolver;
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


        public RXmlValueConverter() : base("System.Xml.Schema.XmlValueConverter")
        {
        }

        public RXmlValueConverter(System.Object instance) : base("System.Xml.Schema.XmlValueConverter")
		{
            SetInstance(instance);
		}

        public RXmlValueConverter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlValueConverter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean ToBoolean(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Int64.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Double.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ToBoolean(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToBoolean_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 ToInt32(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Double.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ToInt32(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt32_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ToInt64(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Single.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Double.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_String.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ToInt64(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToInt64_Object.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Decimal ToDecimal(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Int64.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Single.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Double.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ToDecimal(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDecimal_Object.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Double ToDouble(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Int32.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Int64.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Single.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Double.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ToDouble(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDouble_Object.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Single ToSingle(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Int64.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Double.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_DateTime.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ToSingle(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToSingle_Object.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.DateTime ToDateTime(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Boolean.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Decimal.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Single.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_DateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ToDateTime(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTime_Object.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Boolean.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Int32.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Int64.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Decimal.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Single.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Double.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_DateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_String.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.DateTimeOffset ToDateTimeOffset(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToDateTimeOffset_Object.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.String ToString(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Int64.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Decimal.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Single.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Double.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_DateTime.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.DateTimeOffset  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_DateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @value, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @nsResolver};
            var ___result = RToString_String_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RToString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Object  @value, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @nsResolver};
            var ___result = RToString_Object_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ChangeType(System.Boolean  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Int32  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Int32_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Int64  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Int64_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Decimal  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Decimal_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Single  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Single_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Double  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Double_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.DateTime  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_DateTime_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.DateTimeOffset  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_DateTimeOffset_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.String  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.String  @value, System.Type  @destinationType, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType, @nsResolver};
            var ___result = RChangeType_String_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Object  @value, System.Type  @destinationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType};
            var ___result = RChangeType_Object_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Object  @value, System.Type  @destinationType, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @destinationType, @nsResolver};
            var ___result = RChangeType_Object_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
