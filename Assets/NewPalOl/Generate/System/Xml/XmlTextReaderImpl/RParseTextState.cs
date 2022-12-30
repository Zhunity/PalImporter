using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlTextReaderImpl+ParseTextState
	/// </summary>
    public partial class RParseTextState : RMember //
    {

		/// <summary>
		/// System.Int32 outOrChars
		/// </summary>
		protected RField r_outOrChars;
		public virtual RField RoutOrChars
		{
			get
			{
				if(r_outOrChars == null)
				{
					r_outOrChars = new(this, "outOrChars");
					r_outOrChars.SetBelong(this.instance);
				}
				return r_outOrChars;
			}
		}

		/// <summary>
		/// System.Char[] chars
		/// </summary>
		protected RFieldArray<RField> r_chars;
		public virtual RFieldArray<RField> Rchars
		{
			get
			{
				if(r_chars == null)
				{
					r_chars = new(this, "chars");
					r_chars.SetBelong(this.instance);
				}
				return r_chars;
			}
		}

		/// <summary>
		/// System.Int32 pos
		/// </summary>
		protected RField r_pos;
		public virtual RField Rpos
		{
			get
			{
				if(r_pos == null)
				{
					r_pos = new(this, "pos");
					r_pos.SetBelong(this.instance);
				}
				return r_pos;
			}
		}

		/// <summary>
		/// System.Int32 rcount
		/// </summary>
		protected RField r_rcount;
		public virtual RField Rrcount
		{
			get
			{
				if(r_rcount == null)
				{
					r_rcount = new(this, "rcount");
					r_rcount.SetBelong(this.instance);
				}
				return r_rcount;
			}
		}

		/// <summary>
		/// System.Int32 rpos
		/// </summary>
		protected RField r_rpos;
		public virtual RField Rrpos
		{
			get
			{
				if(r_rpos == null)
				{
					r_rpos = new(this, "rpos");
					r_rpos.SetBelong(this.instance);
				}
				return r_rpos;
			}
		}

		/// <summary>
		/// System.Int32 orChars
		/// </summary>
		protected RField r_orChars;
		public virtual RField RorChars
		{
			get
			{
				if(r_orChars == null)
				{
					r_orChars = new(this, "orChars");
					r_orChars.SetBelong(this.instance);
				}
				return r_orChars;
			}
		}

		/// <summary>
		/// System.Char c
		/// </summary>
		protected RField r_c;
		public virtual RField Rc
		{
			get
			{
				if(r_c == null)
				{
					r_c = new(this, "c");
					r_c.SetBelong(this.instance);
				}
				return r_c;
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


        public RParseTextState() : base("System.Xml.XmlTextReaderImpl+ParseTextState")
        {
        }

        public RParseTextState(System.Object instance) : base("System.Xml.XmlTextReaderImpl+ParseTextState")
		{
            SetInstance(instance);
		}

        public RParseTextState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParseTextState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}