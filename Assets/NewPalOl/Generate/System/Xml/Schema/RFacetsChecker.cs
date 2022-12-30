using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.FacetsChecker
	/// </summary>
    public partial class RFacetsChecker : RMember //
    {

		/// <summary>
		/// System.Exception CheckLexicalFacets(System.String ByRef, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckLexicalFacets_Ref_String_XmlSchemaDatatype;
		public virtual RMethod RCheckLexicalFacets_Ref_String_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckLexicalFacets_Ref_String_XmlSchemaDatatype == null)
				{
					r_RCheckLexicalFacets_Ref_String_XmlSchemaDatatype = new(this, "CheckLexicalFacets", 0, typeof(System.String).MakeByRefType(), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckLexicalFacets_Ref_String_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckLexicalFacets_Ref_String_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.Object, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Object_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Object_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Object_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Object_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Object), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Object_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Object_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.Decimal, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Decimal_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Decimal_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Decimal_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Decimal_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Decimal), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Decimal_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Decimal_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Int64, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Int64_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Int64_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Int64_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Int64_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Int64), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Int64_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Int64_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Int32, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Int32_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Int32_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Int32_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Int32_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Int32), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Int32_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Int32_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Int16, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Int16_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Int16_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Int16_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Int16_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Int16), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Int16_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Int16_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Byte, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Byte_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Byte_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Byte_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Byte_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Byte), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Byte_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Byte_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.DateTime, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_DateTime_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_DateTime_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_DateTime_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_DateTime_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.DateTime), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_DateTime_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_DateTime_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Double, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Double_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Double_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Double_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Double_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Double), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Double_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Double_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Single, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_Single_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_Single_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_Single_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_Single_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Single), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_Single_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_Single_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.String, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_String_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_String_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_String_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_String_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.String), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_String_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_String_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(Byte[], System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_ByteArray_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_ByteArray_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_ByteArray_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_ByteArray_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_ByteArray_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_ByteArray_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.TimeSpan, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_TimeSpan_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_TimeSpan_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_TimeSpan_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_TimeSpan_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.TimeSpan), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_TimeSpan_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_TimeSpan_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckValueFacets(System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype;
		public virtual RMethod RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype == null)
				{
					r_RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype = new(this, "CheckValueFacets", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// Void CheckWhitespaceFacets(System.String ByRef, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype;
		public virtual RMethod RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype
		{
			get
			{
				if(r_RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype == null)
				{
					r_RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype = new(this, "CheckWhitespaceFacets", 0, typeof(System.String).MakeByRefType(), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets, System.String)
		/// </summary>
		protected RMethod r_RCheckPatternFacets_RestrictionFacets_String;
		public virtual RMethod RCheckPatternFacets_RestrictionFacets_String
		{
			get
			{
				if(r_RCheckPatternFacets_RestrictionFacets_String == null)
				{
					r_RCheckPatternFacets_RestrictionFacets_String = new(this, "CheckPatternFacets", 0,  ReleactionUtils.GetType("System.Xml.Schema.RestrictionFacets"), typeof(System.String));
					r_RCheckPatternFacets_RestrictionFacets_String.SetBelong(this.instance);
				}
				return r_RCheckPatternFacets_RestrictionFacets_String;
			}
		}

		/// <summary>
		/// Boolean MatchEnumeration(System.Object, System.Collections.ArrayList, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype;
		public virtual RMethod RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype
		{
			get
			{
				if(r_RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype == null)
				{
					r_RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype = new(this, "MatchEnumeration", 0, typeof(System.Object), typeof(System.Collections.ArrayList), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation, System.Xml.Schema.XmlSchemaObjectCollection, System.Xml.XmlNameTable)
		/// </summary>
		protected RMethod r_RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable;
		public virtual RMethod RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable
		{
			get
			{
				if(r_RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable == null)
				{
					r_RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable = new(this, "ConstructRestriction", 0,  ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Xml.XmlNameTable));
					r_RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable.SetBelong(this.instance);
				}
				return r_RConstructRestriction_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable;
			}
		}

		/// <summary>
		/// System.Decimal Power(Int32, Int32)
		/// </summary>
		protected static RMethod r_RPower_Int32_Int32;
		public static RMethod RPower_Int32_Int32
		{
			get
			{
				if(r_RPower_Int32_Int32 == null)
				{
					r_RPower_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.Schema.FacetsChecker"), "Power", 0, typeof(System.Int32), typeof(System.Int32));
					r_RPower_Int32_Int32.SetBelong(null);
				}
				return r_RPower_Int32_Int32;
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


        public RFacetsChecker() : base("System.Xml.Schema.FacetsChecker")
        {
        }

        public RFacetsChecker(System.Object instance) : base("System.Xml.Schema.FacetsChecker")
		{
            SetInstance(instance);
		}

        public RFacetsChecker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFacetsChecker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Exception CheckLexicalFacets(ref System.String  @parseString, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parseString, @datatype};
            var ___result = RCheckLexicalFacets_Ref_String_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);
			parseString = (System.String)___parameters[0];

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Object  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Object_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Decimal  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Decimal_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Int64  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Int64_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Int32  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Int32_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Int16  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Int16_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Byte  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Byte_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.DateTime  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_DateTime_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Double  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Double_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Single  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_Single_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.String  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_String_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Byte[]  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_ByteArray_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.TimeSpan  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_TimeSpan_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CheckValueFacets(System.Xml.XmlQualifiedName  @value, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @datatype};
            var ___result = RCheckValueFacets_XmlQualifiedName_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void CheckWhitespaceFacets(ref System.String  @s, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @datatype};
            var ___result = RCheckWhitespaceFacets_Ref_String_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);
			s = (System.String)___parameters[0];

            
        }



        public virtual System.Boolean MatchEnumeration(System.Object  @value, System.Collections.ArrayList  @enumeration, System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @enumeration, @datatype};
            var ___result = RMatchEnumeration_Object_ArrayList_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public static System.Decimal Power(System.Int32  @x, System.Int32  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RPower_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
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
