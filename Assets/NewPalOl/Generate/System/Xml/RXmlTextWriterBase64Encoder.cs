using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlTextWriterBase64Encoder
	/// </summary>
    public partial class RXmlTextWriterBase64Encoder : RMember //
    {

		/// <summary>
		/// System.Xml.XmlTextEncoder xmlTextEncoder
		/// </summary>
		protected RSystem.RXml.RXmlTextEncoder r_xmlTextEncoder;
		public virtual RSystem.RXml.RXmlTextEncoder RxmlTextEncoder
		{
			get
			{
				if(r_xmlTextEncoder == null)
				{
					r_xmlTextEncoder = new(this, "xmlTextEncoder");
					r_xmlTextEncoder.SetBelong(this.instance);
				}
				return r_xmlTextEncoder;
			}
		}

		/// <summary>
		/// Void WriteChars(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteChars_CharArray_Int32_Int32;
		public virtual RMethod RWriteChars_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteChars_CharArray_Int32_Int32 == null)
				{
					r_RWriteChars_CharArray_Int32_Int32 = new(this, "WriteChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteChars_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteChars_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteCharsAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteCharsAsync_CharArray_Int32_Int32;
		public virtual RMethod RWriteCharsAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteCharsAsync_CharArray_Int32_Int32 == null)
				{
					r_RWriteCharsAsync_CharArray_Int32_Int32 = new(this, "WriteCharsAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteCharsAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteCharsAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Encode(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_REncode_ByteArray_Int32_Int32;
		public virtual RMethod REncode_ByteArray_Int32_Int32
		{
			get
			{
				if(r_REncode_ByteArray_Int32_Int32 == null)
				{
					r_REncode_ByteArray_Int32_Int32 = new(this, "Encode", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_REncode_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_REncode_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task EncodeAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_REncodeAsync_ByteArray_Int32_Int32;
		public virtual RMethod REncodeAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_REncodeAsync_ByteArray_Int32_Int32 == null)
				{
					r_REncodeAsync_ByteArray_Int32_Int32 = new(this, "EncodeAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_REncodeAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_REncodeAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_RFlushAsync;
		public virtual RMethod RFlushAsync
		{
			get
			{
				if(r_RFlushAsync == null)
				{
					r_RFlushAsync = new(this, "FlushAsync", 0);
					r_RFlushAsync.SetBelong(this.instance);
				}
				return r_RFlushAsync;
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


        public RXmlTextWriterBase64Encoder() : base("System.Xml.XmlTextWriterBase64Encoder")
        {
        }

        public RXmlTextWriterBase64Encoder(System.Object instance) : base("System.Xml.XmlTextWriterBase64Encoder")
		{
            SetInstance(instance);
		}

        public RXmlTextWriterBase64Encoder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlTextWriterBase64Encoder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void WriteChars(System.Char[]  @chars, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RWriteChars_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task WriteCharsAsync(System.Char[]  @chars, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RWriteCharsAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual void Encode(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = REncode_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task EncodeAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = REncodeAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
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
