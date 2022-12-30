using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlTextEncoder
	/// </summary>
    public partial class RXmlTextEncoder : RMember //
    {

		/// <summary>
		/// System.IO.TextWriter textWriter
		/// </summary>
		protected RSystem.RIO.RTextWriter r_textWriter;
		public virtual RSystem.RIO.RTextWriter RtextWriter
		{
			get
			{
				if(r_textWriter == null)
				{
					r_textWriter = new(this, "textWriter");
					r_textWriter.SetBelong(this.instance);
				}
				return r_textWriter;
			}
		}

		/// <summary>
		/// System.Boolean inAttribute
		/// </summary>
		protected RField r_inAttribute;
		public virtual RField RinAttribute
		{
			get
			{
				if(r_inAttribute == null)
				{
					r_inAttribute = new(this, "inAttribute");
					r_inAttribute.SetBelong(this.instance);
				}
				return r_inAttribute;
			}
		}

		/// <summary>
		/// System.Char quoteChar
		/// </summary>
		protected RField r_quoteChar;
		public virtual RField RquoteChar
		{
			get
			{
				if(r_quoteChar == null)
				{
					r_quoteChar = new(this, "quoteChar");
					r_quoteChar.SetBelong(this.instance);
				}
				return r_quoteChar;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder attrValue
		/// </summary>
		protected RSystem.RText.RStringBuilder r_attrValue;
		public virtual RSystem.RText.RStringBuilder RattrValue
		{
			get
			{
				if(r_attrValue == null)
				{
					r_attrValue = new(this, "attrValue");
					r_attrValue.SetBelong(this.instance);
				}
				return r_attrValue;
			}
		}

		/// <summary>
		/// System.Boolean cacheAttrValue
		/// </summary>
		protected RField r_cacheAttrValue;
		public virtual RField RcacheAttrValue
		{
			get
			{
				if(r_cacheAttrValue == null)
				{
					r_cacheAttrValue = new(this, "cacheAttrValue");
					r_cacheAttrValue.SetBelong(this.instance);
				}
				return r_cacheAttrValue;
			}
		}

		/// <summary>
		/// System.Xml.XmlCharType xmlCharType
		/// </summary>
		protected RSystem.RXml.RXmlCharType r_xmlCharType;
		public virtual RSystem.RXml.RXmlCharType RxmlCharType
		{
			get
			{
				if(r_xmlCharType == null)
				{
					r_xmlCharType = new(this, "xmlCharType");
					r_xmlCharType.SetBelong(this.instance);
				}
				return r_xmlCharType;
			}
		}

		/// <summary>
		/// Char QuoteChar
		/// </summary>
		protected RProperty r_QuoteChar_Char;
		public virtual RProperty RQuoteChar_Char
		{
			get
			{
				if(r_QuoteChar_Char == null)
				{
					r_QuoteChar_Char = new(this, "QuoteChar", -1, typeof(System.Char));
					r_QuoteChar_Char.SetBelong(this.instance);
				}
				return r_QuoteChar_Char;
			}
		}

		/// <summary>
		/// System.String AttributeValue
		/// </summary>
		protected RProperty r_AttributeValue;
		public virtual RProperty RAttributeValue
		{
			get
			{
				if(r_AttributeValue == null)
				{
					r_AttributeValue = new(this, "AttributeValue", -1);
					r_AttributeValue.SetBelong(this.instance);
				}
				return r_AttributeValue;
			}
		}

		/// <summary>
		/// Void StartAttribute(Boolean)
		/// </summary>
		protected RMethod r_RStartAttribute_Boolean;
		public virtual RMethod RStartAttribute_Boolean
		{
			get
			{
				if(r_RStartAttribute_Boolean == null)
				{
					r_RStartAttribute_Boolean = new(this, "StartAttribute", 0, typeof(System.Boolean));
					r_RStartAttribute_Boolean.SetBelong(this.instance);
				}
				return r_RStartAttribute_Boolean;
			}
		}

		/// <summary>
		/// Void EndAttribute()
		/// </summary>
		protected RMethod r_REndAttribute;
		public virtual RMethod REndAttribute
		{
			get
			{
				if(r_REndAttribute == null)
				{
					r_REndAttribute = new(this, "EndAttribute", 0);
					r_REndAttribute.SetBelong(this.instance);
				}
				return r_REndAttribute;
			}
		}

		/// <summary>
		/// Void WriteSurrogateChar(Char, Char)
		/// </summary>
		protected RMethod r_RWriteSurrogateChar_Char_Char;
		public virtual RMethod RWriteSurrogateChar_Char_Char
		{
			get
			{
				if(r_RWriteSurrogateChar_Char_Char == null)
				{
					r_RWriteSurrogateChar_Char_Char = new(this, "WriteSurrogateChar", 0, typeof(System.Char), typeof(System.Char));
					r_RWriteSurrogateChar_Char_Char.SetBelong(this.instance);
				}
				return r_RWriteSurrogateChar_Char_Char;
			}
		}

		/// <summary>
		/// Void Write(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWrite_CharArray_Int32_Int32;
		public virtual RMethod RWrite_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWrite_CharArray_Int32_Int32 == null)
				{
					r_RWrite_CharArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWrite_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWrite_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteSurrogateCharEntity(Char, Char)
		/// </summary>
		protected RMethod r_RWriteSurrogateCharEntity_Char_Char;
		public virtual RMethod RWriteSurrogateCharEntity_Char_Char
		{
			get
			{
				if(r_RWriteSurrogateCharEntity_Char_Char == null)
				{
					r_RWriteSurrogateCharEntity_Char_Char = new(this, "WriteSurrogateCharEntity", 0, typeof(System.Char), typeof(System.Char));
					r_RWriteSurrogateCharEntity_Char_Char.SetBelong(this.instance);
				}
				return r_RWriteSurrogateCharEntity_Char_Char;
			}
		}

		/// <summary>
		/// Void Write(System.String)
		/// </summary>
		protected RMethod r_RWrite_String;
		public virtual RMethod RWrite_String
		{
			get
			{
				if(r_RWrite_String == null)
				{
					r_RWrite_String = new(this, "Write", 0, typeof(System.String));
					r_RWrite_String.SetBelong(this.instance);
				}
				return r_RWrite_String;
			}
		}

		/// <summary>
		/// Void WriteRawWithSurrogateChecking(System.String)
		/// </summary>
		protected RMethod r_RWriteRawWithSurrogateChecking_String;
		public virtual RMethod RWriteRawWithSurrogateChecking_String
		{
			get
			{
				if(r_RWriteRawWithSurrogateChecking_String == null)
				{
					r_RWriteRawWithSurrogateChecking_String = new(this, "WriteRawWithSurrogateChecking", 0, typeof(System.String));
					r_RWriteRawWithSurrogateChecking_String.SetBelong(this.instance);
				}
				return r_RWriteRawWithSurrogateChecking_String;
			}
		}

		/// <summary>
		/// Void WriteRaw(System.String)
		/// </summary>
		protected RMethod r_RWriteRaw_String;
		public virtual RMethod RWriteRaw_String
		{
			get
			{
				if(r_RWriteRaw_String == null)
				{
					r_RWriteRaw_String = new(this, "WriteRaw", 0, typeof(System.String));
					r_RWriteRaw_String.SetBelong(this.instance);
				}
				return r_RWriteRaw_String;
			}
		}

		/// <summary>
		/// Void WriteRaw(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteRaw_CharArray_Int32_Int32;
		public virtual RMethod RWriteRaw_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteRaw_CharArray_Int32_Int32 == null)
				{
					r_RWriteRaw_CharArray_Int32_Int32 = new(this, "WriteRaw", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteRaw_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteRaw_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteCharEntity(Char)
		/// </summary>
		protected RMethod r_RWriteCharEntity_Char;
		public virtual RMethod RWriteCharEntity_Char
		{
			get
			{
				if(r_RWriteCharEntity_Char == null)
				{
					r_RWriteCharEntity_Char = new(this, "WriteCharEntity", 0, typeof(System.Char));
					r_RWriteCharEntity_Char.SetBelong(this.instance);
				}
				return r_RWriteCharEntity_Char;
			}
		}

		/// <summary>
		/// Void WriteEntityRef(System.String)
		/// </summary>
		protected RMethod r_RWriteEntityRef_String;
		public virtual RMethod RWriteEntityRef_String
		{
			get
			{
				if(r_RWriteEntityRef_String == null)
				{
					r_RWriteEntityRef_String = new(this, "WriteEntityRef", 0, typeof(System.String));
					r_RWriteEntityRef_String.SetBelong(this.instance);
				}
				return r_RWriteEntityRef_String;
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
		/// Void WriteStringFragment(System.String, Int32, Int32, Char[])
		/// </summary>
		protected RMethod r_RWriteStringFragment_String_Int32_Int32_CharArray;
		public virtual RMethod RWriteStringFragment_String_Int32_Int32_CharArray
		{
			get
			{
				if(r_RWriteStringFragment_String_Int32_Int32_CharArray == null)
				{
					r_RWriteStringFragment_String_Int32_Int32_CharArray = new(this, "WriteStringFragment", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType());
					r_RWriteStringFragment_String_Int32_Int32_CharArray.SetBelong(this.instance);
				}
				return r_RWriteStringFragment_String_Int32_Int32_CharArray;
			}
		}

		/// <summary>
		/// Void WriteCharEntityImpl(Char)
		/// </summary>
		protected RMethod r_RWriteCharEntityImpl_Char;
		public virtual RMethod RWriteCharEntityImpl_Char
		{
			get
			{
				if(r_RWriteCharEntityImpl_Char == null)
				{
					r_RWriteCharEntityImpl_Char = new(this, "WriteCharEntityImpl", 0, typeof(System.Char));
					r_RWriteCharEntityImpl_Char.SetBelong(this.instance);
				}
				return r_RWriteCharEntityImpl_Char;
			}
		}

		/// <summary>
		/// Void WriteCharEntityImpl(System.String)
		/// </summary>
		protected RMethod r_RWriteCharEntityImpl_String;
		public virtual RMethod RWriteCharEntityImpl_String
		{
			get
			{
				if(r_RWriteCharEntityImpl_String == null)
				{
					r_RWriteCharEntityImpl_String = new(this, "WriteCharEntityImpl", 0, typeof(System.String));
					r_RWriteCharEntityImpl_String.SetBelong(this.instance);
				}
				return r_RWriteCharEntityImpl_String;
			}
		}

		/// <summary>
		/// Void WriteEntityRefImpl(System.String)
		/// </summary>
		protected RMethod r_RWriteEntityRefImpl_String;
		public virtual RMethod RWriteEntityRefImpl_String
		{
			get
			{
				if(r_RWriteEntityRefImpl_String == null)
				{
					r_RWriteEntityRefImpl_String = new(this, "WriteEntityRefImpl", 0, typeof(System.String));
					r_RWriteEntityRefImpl_String.SetBelong(this.instance);
				}
				return r_RWriteEntityRefImpl_String;
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


        public RXmlTextEncoder() : base("System.Xml.XmlTextEncoder")
        {
        }

        public RXmlTextEncoder(System.Object instance) : base("System.Xml.XmlTextEncoder")
		{
            SetInstance(instance);
		}

        public RXmlTextEncoder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlTextEncoder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void StartAttribute(System.Boolean  @cacheAttrValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cacheAttrValue};
            var ___result = RStartAttribute_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteSurrogateChar(System.Char  @lowChar, System.Char  @highChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowChar, @highChar};
            var ___result = RWriteSurrogateChar_Char_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[]  @array, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RWrite_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteSurrogateCharEntity(System.Char  @lowChar, System.Char  @highChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowChar, @highChar};
            var ___result = RWriteSurrogateCharEntity_Char_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWrite_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRawWithSurrogateChecking(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RWriteRawWithSurrogateChecking_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRaw(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteRaw_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRaw(System.Char[]  @array, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RWriteRaw_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteCharEntity(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RWriteCharEntity_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEntityRef(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteEntityRef_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteStringFragment(System.String  @str, System.Int32  @offset, System.Int32  @count, System.Char[]  @helperBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @offset, @count, @helperBuffer};
            var ___result = RWriteStringFragment_String_Int32_Int32_CharArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteCharEntityImpl(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RWriteCharEntityImpl_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteCharEntityImpl(System.String  @strVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strVal};
            var ___result = RWriteCharEntityImpl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteEntityRefImpl(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RWriteEntityRefImpl_String.Invoke(___genericsType, ___parameters);

            
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
