using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Version
	/// </summary>
    public partial class RVersion : RMember //
    {

		/// <summary>
		/// System.Int32 _Major
		/// </summary>
		protected RField r__Major;
		public virtual RField R_Major
		{
			get
			{
				if(r__Major == null)
				{
					r__Major = new(this, "_Major");
					r__Major.SetBelong(this.instance);
				}
				return r__Major;
			}
		}

		/// <summary>
		/// System.Int32 _Minor
		/// </summary>
		protected RField r__Minor;
		public virtual RField R_Minor
		{
			get
			{
				if(r__Minor == null)
				{
					r__Minor = new(this, "_Minor");
					r__Minor.SetBelong(this.instance);
				}
				return r__Minor;
			}
		}

		/// <summary>
		/// System.Int32 _Build
		/// </summary>
		protected RField r__Build;
		public virtual RField R_Build
		{
			get
			{
				if(r__Build == null)
				{
					r__Build = new(this, "_Build");
					r__Build.SetBelong(this.instance);
				}
				return r__Build;
			}
		}

		/// <summary>
		/// System.Int32 _Revision
		/// </summary>
		protected RField r__Revision;
		public virtual RField R_Revision
		{
			get
			{
				if(r__Revision == null)
				{
					r__Revision = new(this, "_Revision");
					r__Revision.SetBelong(this.instance);
				}
				return r__Revision;
			}
		}

		/// <summary>
		/// Int32 Major
		/// </summary>
		protected RProperty r_Major;
		public virtual RProperty RMajor
		{
			get
			{
				if(r_Major == null)
				{
					r_Major = new(this, "Major", -1);
					r_Major.SetBelong(this.instance);
				}
				return r_Major;
			}
		}

		/// <summary>
		/// Int32 Minor
		/// </summary>
		protected RProperty r_Minor;
		public virtual RProperty RMinor
		{
			get
			{
				if(r_Minor == null)
				{
					r_Minor = new(this, "Minor", -1);
					r_Minor.SetBelong(this.instance);
				}
				return r_Minor;
			}
		}

		/// <summary>
		/// Int32 Build
		/// </summary>
		protected RProperty r_Build;
		public virtual RProperty RBuild
		{
			get
			{
				if(r_Build == null)
				{
					r_Build = new(this, "Build", -1);
					r_Build.SetBelong(this.instance);
				}
				return r_Build;
			}
		}

		/// <summary>
		/// Int32 Revision
		/// </summary>
		protected RProperty r_Revision;
		public virtual RProperty Revision
		{
			get
			{
				if(r_Revision == null)
				{
					r_Revision = new(this, "Revision", -1);
					r_Revision.SetBelong(this.instance);
				}
				return r_Revision;
			}
		}

		/// <summary>
		/// Int16 MajorRevision
		/// </summary>
		protected RProperty r_MajorRevision;
		public virtual RProperty RMajorRevision
		{
			get
			{
				if(r_MajorRevision == null)
				{
					r_MajorRevision = new(this, "MajorRevision", -1);
					r_MajorRevision.SetBelong(this.instance);
				}
				return r_MajorRevision;
			}
		}

		/// <summary>
		/// Int16 MinorRevision
		/// </summary>
		protected RProperty r_MinorRevision;
		public virtual RProperty RMinorRevision
		{
			get
			{
				if(r_MinorRevision == null)
				{
					r_MinorRevision = new(this, "MinorRevision", -1);
					r_MinorRevision.SetBelong(this.instance);
				}
				return r_MinorRevision;
			}
		}

		/// <summary>
		/// Int32 DefaultFormatFieldCount
		/// </summary>
		protected RProperty r_DefaultFormatFieldCount;
		public virtual RProperty RDefaultFormatFieldCount
		{
			get
			{
				if(r_DefaultFormatFieldCount == null)
				{
					r_DefaultFormatFieldCount = new(this, "DefaultFormatFieldCount", -1);
					r_DefaultFormatFieldCount.SetBelong(this.instance);
				}
				return r_DefaultFormatFieldCount;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Version)
		/// </summary>
		protected RMethod r_RCompareTo_Version;
		public virtual RMethod RCompareTo_Version
		{
			get
			{
				if(r_RCompareTo_Version == null)
				{
					r_RCompareTo_Version = new(this, "CompareTo", 0, typeof(System.Version));
					r_RCompareTo_Version.SetBelong(this.instance);
				}
				return r_RCompareTo_Version;
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
		/// Boolean Equals(System.Version)
		/// </summary>
		protected RMethod r_REquals_Version;
		public virtual RMethod REquals_Version
		{
			get
			{
				if(r_REquals_Version == null)
				{
					r_REquals_Version = new(this, "Equals", 0, typeof(System.Version));
					r_REquals_Version.SetBelong(this.instance);
				}
				return r_REquals_Version;
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
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryFormat_Span_d_Char_p__Out_Int32;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32
		{
			get
			{
				if(r_RTryFormat_Span_d_Char_p__Out_Int32 == null)
				{
					r_RTryFormat_Span_d_Char_p__Out_Int32 = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType());
					r_RTryFormat_Span_d_Char_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryFormat_Span_d_Char_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryFormat_Span_d_Char_p__Int32_Out_Int32;
		public virtual RMethod RTryFormat_Span_d_Char_p__Int32_Out_Int32
		{
			get
			{
				if(r_RTryFormat_Span_d_Char_p__Int32_Out_Int32 == null)
				{
					r_RTryFormat_Span_d_Char_p__Int32_Out_Int32 = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RTryFormat_Span_d_Char_p__Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RTryFormat_Span_d_Char_p__Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean System.ISpanFormattable.TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "System.ISpanFormattable.TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_RSystem__1__ISpanFormattable__1__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder ToCachedStringBuilder(Int32)
		/// </summary>
		protected RMethod r_RToCachedStringBuilder_Int32;
		public virtual RMethod RToCachedStringBuilder_Int32
		{
			get
			{
				if(r_RToCachedStringBuilder_Int32 == null)
				{
					r_RToCachedStringBuilder_Int32 = new(this, "ToCachedStringBuilder", 0, typeof(System.Int32));
					r_RToCachedStringBuilder_Int32.SetBelong(this.instance);
				}
				return r_RToCachedStringBuilder_Int32;
			}
		}

		/// <summary>
		/// System.Version Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(System.Version), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// System.Version Parse(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_RParse_ReadOnlySpan_d_Char_p_;
		public static RMethod RParse_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RParse_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RParse_ReadOnlySpan_d_Char_p_ = new(typeof(System.Version), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RParse_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_RParse_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Version ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_Out_Version;
		public static RMethod RTryParse_String_Out_Version
		{
			get
			{
				if(r_RTryParse_String_Out_Version == null)
				{
					r_RTryParse_String_Out_Version = new(typeof(System.Version), "TryParse", 0, typeof(System.String), typeof(System.Version).MakeByRefType());
					r_RTryParse_String_Out_Version.SetBelong(null);
				}
				return r_RTryParse_String_Out_Version;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Version ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__Out_Version;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_Version
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__Out_Version == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_Version = new(typeof(System.Version), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Version).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_Version.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__Out_Version;
			}
		}

		/// <summary>
		/// System.Version ParseVersion(System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected static RMethod r_RParseVersion_ReadOnlySpan_d_Char_p__Boolean;
		public static RMethod RParseVersion_ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_RParseVersion_ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_RParseVersion_ReadOnlySpan_d_Char_p__Boolean = new(typeof(System.Version), "ParseVersion", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_RParseVersion_ReadOnlySpan_d_Char_p__Boolean.SetBelong(null);
				}
				return r_RParseVersion_ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean TryParseComponent(System.ReadOnlySpan`1[System.Char], System.String, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32;
		public static RMethod RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32
		{
			get
			{
				if(r_RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32 == null)
				{
					r_RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32 = new(typeof(System.Version), "TryParseComponent", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_Equality_Version_Version;
		public static RMethod Rop_Equality_Version_Version
		{
			get
			{
				if(r_Rop_Equality_Version_Version == null)
				{
					r_Rop_Equality_Version_Version = new(typeof(System.Version), "op_Equality", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_Equality_Version_Version.SetBelong(null);
				}
				return r_Rop_Equality_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Version_Version;
		public static RMethod Rop_Inequality_Version_Version
		{
			get
			{
				if(r_Rop_Inequality_Version_Version == null)
				{
					r_Rop_Inequality_Version_Version = new(typeof(System.Version), "op_Inequality", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_Inequality_Version_Version.SetBelong(null);
				}
				return r_Rop_Inequality_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_LessThan_Version_Version;
		public static RMethod Rop_LessThan_Version_Version
		{
			get
			{
				if(r_Rop_LessThan_Version_Version == null)
				{
					r_Rop_LessThan_Version_Version = new(typeof(System.Version), "op_LessThan", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_LessThan_Version_Version.SetBelong(null);
				}
				return r_Rop_LessThan_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_LessThanOrEqual_Version_Version;
		public static RMethod Rop_LessThanOrEqual_Version_Version
		{
			get
			{
				if(r_Rop_LessThanOrEqual_Version_Version == null)
				{
					r_Rop_LessThanOrEqual_Version_Version = new(typeof(System.Version), "op_LessThanOrEqual", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_LessThanOrEqual_Version_Version.SetBelong(null);
				}
				return r_Rop_LessThanOrEqual_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_GreaterThan_Version_Version;
		public static RMethod Rop_GreaterThan_Version_Version
		{
			get
			{
				if(r_Rop_GreaterThan_Version_Version == null)
				{
					r_Rop_GreaterThan_Version_Version = new(typeof(System.Version), "op_GreaterThan", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_GreaterThan_Version_Version.SetBelong(null);
				}
				return r_Rop_GreaterThan_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Rop_GreaterThanOrEqual_Version_Version;
		public static RMethod Rop_GreaterThanOrEqual_Version_Version
		{
			get
			{
				if(r_Rop_GreaterThanOrEqual_Version_Version == null)
				{
					r_Rop_GreaterThanOrEqual_Version_Version = new(typeof(System.Version), "op_GreaterThanOrEqual", 0, typeof(System.Version), typeof(System.Version));
					r_Rop_GreaterThanOrEqual_Version_Version.SetBelong(null);
				}
				return r_Rop_GreaterThanOrEqual_Version_Version;
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


        public RVersion() : base("System.Version")
        {
        }

        public RVersion(System.Object instance) : base("System.Version")
		{
            SetInstance(instance);
		}

        public RVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 CompareTo(System.Object  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Version  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Version.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Version  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Int32  @fieldCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldCount};
            var ___result = RToString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual System.Text.StringBuilder ToCachedStringBuilder(System.Int32  @fieldCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldCount};
            var ___result = RToCachedStringBuilder_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public static System.Version Parse(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Version)___result;
        }



        public static System.Boolean TryParse(System.String  @input, out System.Version  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RTryParse_String_Out_Version.Invoke(___genericsType, ___parameters);
			result = (System.Version)___parameters[1];

            return (System.Boolean)___result;
        }





        public static System.Boolean op_Equality(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_Equality_Version_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_Inequality_Version_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThan(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_LessThan_Version_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_LessThanOrEqual(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_LessThanOrEqual_Version_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThan(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_GreaterThan_Version_Version.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Version  @v1, System.Version  @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = Rop_GreaterThanOrEqual_Version_Version.Invoke(___genericsType, ___parameters);

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
