using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlTextReaderImpl+LaterInitParam
	/// </summary>
    public partial class RLaterInitParam : RMember //
    {

		/// <summary>
		/// System.Boolean useAsync
		/// </summary>
		protected RField r_useAsync;
		public virtual RField RuseAsync
		{
			get
			{
				if(r_useAsync == null)
				{
					r_useAsync = new(this, "useAsync");
					r_useAsync.SetBelong(this.instance);
				}
				return r_useAsync;
			}
		}

		/// <summary>
		/// System.IO.Stream inputStream
		/// </summary>
		protected RSystem.RIO.RStream r_inputStream;
		public virtual RSystem.RIO.RStream RinputStream
		{
			get
			{
				if(r_inputStream == null)
				{
					r_inputStream = new(this, "inputStream");
					r_inputStream.SetBelong(this.instance);
				}
				return r_inputStream;
			}
		}

		/// <summary>
		/// System.Byte[] inputBytes
		/// </summary>
		protected RFieldArray<RField> r_inputBytes;
		public virtual RFieldArray<RField> RinputBytes
		{
			get
			{
				if(r_inputBytes == null)
				{
					r_inputBytes = new(this, "inputBytes");
					r_inputBytes.SetBelong(this.instance);
				}
				return r_inputBytes;
			}
		}

		/// <summary>
		/// System.Int32 inputByteCount
		/// </summary>
		protected RField r_inputByteCount;
		public virtual RField RinputByteCount
		{
			get
			{
				if(r_inputByteCount == null)
				{
					r_inputByteCount = new(this, "inputByteCount");
					r_inputByteCount.SetBelong(this.instance);
				}
				return r_inputByteCount;
			}
		}

		/// <summary>
		/// System.Uri inputbaseUri
		/// </summary>
		protected RSystem.RUri r_inputbaseUri;
		public virtual RSystem.RUri RinputbaseUri
		{
			get
			{
				if(r_inputbaseUri == null)
				{
					r_inputbaseUri = new(this, "inputbaseUri");
					r_inputbaseUri.SetBelong(this.instance);
				}
				return r_inputbaseUri;
			}
		}

		/// <summary>
		/// System.String inputUriStr
		/// </summary>
		protected RField r_inputUriStr;
		public virtual RField RinputUriStr
		{
			get
			{
				if(r_inputUriStr == null)
				{
					r_inputUriStr = new(this, "inputUriStr");
					r_inputUriStr.SetBelong(this.instance);
				}
				return r_inputUriStr;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver inputUriResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_inputUriResolver;
		public virtual RSystem.RXml.RXmlResolver RinputUriResolver
		{
			get
			{
				if(r_inputUriResolver == null)
				{
					r_inputUriResolver = new(this, "inputUriResolver");
					r_inputUriResolver.SetBelong(this.instance);
				}
				return r_inputUriResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlParserContext inputContext
		/// </summary>
		protected RSystem.RXml.RXmlParserContext r_inputContext;
		public virtual RSystem.RXml.RXmlParserContext RinputContext
		{
			get
			{
				if(r_inputContext == null)
				{
					r_inputContext = new(this, "inputContext");
					r_inputContext.SetBelong(this.instance);
				}
				return r_inputContext;
			}
		}

		/// <summary>
		/// System.IO.TextReader inputTextReader
		/// </summary>
		protected RSystem.RIO.RTextReader r_inputTextReader;
		public virtual RSystem.RIO.RTextReader RinputTextReader
		{
			get
			{
				if(r_inputTextReader == null)
				{
					r_inputTextReader = new(this, "inputTextReader");
					r_inputTextReader.SetBelong(this.instance);
				}
				return r_inputTextReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+InitInputType initType
		/// </summary>
		protected RField r_initType;
		public virtual RField RinitType
		{
			get
			{
				if(r_initType == null)
				{
					r_initType = new(this, "initType");
					r_initType.SetBelong(this.instance);
				}
				return r_initType;
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


        public RLaterInitParam() : base("System.Xml.XmlTextReaderImpl+LaterInitParam")
        {
        }

        public RLaterInitParam(System.Object instance) : base("System.Xml.XmlTextReaderImpl+LaterInitParam")
		{
            SetInstance(instance);
		}

        public RLaterInitParam(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLaterInitParam(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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