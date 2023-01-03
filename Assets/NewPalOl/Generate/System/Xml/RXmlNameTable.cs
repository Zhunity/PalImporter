using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlNameTable
	/// </summary>
    public partial class RXmlNameTable : RMember //
    {

		/// <summary>
		/// System.String Get(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGet_CharArray_Int32_Int32;
		public virtual RMethod RGet_CharArray_Int32_Int32
		{
			get
			{
				if(r_RGet_CharArray_Int32_Int32 == null)
				{
					r_RGet_CharArray_Int32_Int32 = new(this, "Get", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGet_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGet_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Get(System.String)
		/// </summary>
		protected RMethod r_RGet_String;
		public virtual RMethod RGet_String
		{
			get
			{
				if(r_RGet_String == null)
				{
					r_RGet_String = new(this, "Get", 0, typeof(System.String));
					r_RGet_String.SetBelong(this.instance);
				}
				return r_RGet_String;
			}
		}

		/// <summary>
		/// System.String Add(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RAdd_CharArray_Int32_Int32;
		public virtual RMethod RAdd_CharArray_Int32_Int32
		{
			get
			{
				if(r_RAdd_CharArray_Int32_Int32 == null)
				{
					r_RAdd_CharArray_Int32_Int32 = new(this, "Add", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RAdd_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAdd_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Add(System.String)
		/// </summary>
		protected RMethod r_RAdd_String;
		public virtual RMethod RAdd_String
		{
			get
			{
				if(r_RAdd_String == null)
				{
					r_RAdd_String = new(this, "Add", 0, typeof(System.String));
					r_RAdd_String.SetBelong(this.instance);
				}
				return r_RAdd_String;
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


        public RXmlNameTable() : base("System.Xml.XmlNameTable")
        {
        }

        public RXmlNameTable(System.Object instance) : base("System.Xml.XmlNameTable")
		{
            SetInstance(instance);
		}

        public RXmlNameTable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlNameTable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String Get(System.Char[]  @array, System.Int32  @offset, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @length};
            var ___result = RGet_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Get(System.String  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RGet_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Add(System.Char[]  @array, System.Int32  @offset, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @length};
            var ___result = RAdd_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Add(System.String  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RAdd_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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