using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IncrementalReadCharsDecoder
	/// </summary>
    public partial class RIncrementalReadCharsDecoder : RMember //
    {

		/// <summary>
		/// System.Char[] buffer
		/// </summary>
		protected RFieldArray<RField> r_buffer;
		public virtual RFieldArray<RField> Rbuffer
		{
			get
			{
				if(r_buffer == null)
				{
					r_buffer = new(this, "buffer");
					r_buffer.SetBelong(this.instance);
				}
				return r_buffer;
			}
		}

		/// <summary>
		/// System.Int32 startIndex
		/// </summary>
		protected RField r_startIndex;
		public virtual RField RstartIndex
		{
			get
			{
				if(r_startIndex == null)
				{
					r_startIndex = new(this, "startIndex");
					r_startIndex.SetBelong(this.instance);
				}
				return r_startIndex;
			}
		}

		/// <summary>
		/// System.Int32 curIndex
		/// </summary>
		protected RField r_curIndex;
		public virtual RField RcurIndex
		{
			get
			{
				if(r_curIndex == null)
				{
					r_curIndex = new(this, "curIndex");
					r_curIndex.SetBelong(this.instance);
				}
				return r_curIndex;
			}
		}

		/// <summary>
		/// System.Int32 endIndex
		/// </summary>
		protected RField r_endIndex;
		public virtual RField RendIndex
		{
			get
			{
				if(r_endIndex == null)
				{
					r_endIndex = new(this, "endIndex");
					r_endIndex.SetBelong(this.instance);
				}
				return r_endIndex;
			}
		}

		/// <summary>
		/// Int32 DecodedCount
		/// </summary>
		protected RProperty r_DecodedCount;
		public virtual RProperty RDecodedCount
		{
			get
			{
				if(r_DecodedCount == null)
				{
					r_DecodedCount = new(this, "DecodedCount", -1);
					r_DecodedCount.SetBelong(this.instance);
				}
				return r_DecodedCount;
			}
		}

		/// <summary>
		/// Boolean IsFull
		/// </summary>
		protected RProperty r_IsFull;
		public virtual RProperty RIsFull
		{
			get
			{
				if(r_IsFull == null)
				{
					r_IsFull = new(this, "IsFull", -1);
					r_IsFull.SetBelong(this.instance);
				}
				return r_IsFull;
			}
		}

		/// <summary>
		/// Int32 Decode(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RDecode_CharArray_Int32_Int32;
		public virtual RMethod RDecode_CharArray_Int32_Int32
		{
			get
			{
				if(r_RDecode_CharArray_Int32_Int32 == null)
				{
					r_RDecode_CharArray_Int32_Int32 = new(this, "Decode", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RDecode_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDecode_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Decode(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RDecode_String_Int32_Int32;
		public virtual RMethod RDecode_String_Int32_Int32
		{
			get
			{
				if(r_RDecode_String_Int32_Int32 == null)
				{
					r_RDecode_String_Int32_Int32 = new(this, "Decode", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RDecode_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDecode_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void SetNextOutputBuffer(System.Array, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetNextOutputBuffer_Array_Int32_Int32;
		public virtual RMethod RSetNextOutputBuffer_Array_Int32_Int32
		{
			get
			{
				if(r_RSetNextOutputBuffer_Array_Int32_Int32 == null)
				{
					r_RSetNextOutputBuffer_Array_Int32_Int32 = new(this, "SetNextOutputBuffer", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_RSetNextOutputBuffer_Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetNextOutputBuffer_Array_Int32_Int32;
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


        public RIncrementalReadCharsDecoder() : base("System.Xml.IncrementalReadCharsDecoder")
        {
        }

        public RIncrementalReadCharsDecoder(System.Object instance) : base("System.Xml.IncrementalReadCharsDecoder")
		{
            SetInstance(instance);
		}

        public RIncrementalReadCharsDecoder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIncrementalReadCharsDecoder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 Decode(System.Char[]  @chars, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @startPos, @len};
            var ___result = RDecode_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Decode(System.String  @str, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @startPos, @len};
            var ___result = RDecode_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNextOutputBuffer(System.Array  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RSetNextOutputBuffer_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
