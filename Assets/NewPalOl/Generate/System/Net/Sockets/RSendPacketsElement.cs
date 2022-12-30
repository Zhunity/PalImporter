using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SendPacketsElement
	/// </summary>
    public partial class RSendPacketsElement : RMember //
    {

		/// <summary>
		/// System.String m_FilePath
		/// </summary>
		protected RField r_m_FilePath;
		public virtual RField Rm_FilePath
		{
			get
			{
				if(r_m_FilePath == null)
				{
					r_m_FilePath = new(this, "m_FilePath");
					r_m_FilePath.SetBelong(this.instance);
				}
				return r_m_FilePath;
			}
		}

		/// <summary>
		/// System.Byte[] m_Buffer
		/// </summary>
		protected RFieldArray<RField> r_m_Buffer;
		public virtual RFieldArray<RField> Rm_Buffer
		{
			get
			{
				if(r_m_Buffer == null)
				{
					r_m_Buffer = new(this, "m_Buffer");
					r_m_Buffer.SetBelong(this.instance);
				}
				return r_m_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Offset
		/// </summary>
		protected RField r_m_Offset;
		public virtual RField Rm_Offset
		{
			get
			{
				if(r_m_Offset == null)
				{
					r_m_Offset = new(this, "m_Offset");
					r_m_Offset.SetBelong(this.instance);
				}
				return r_m_Offset;
			}
		}

		/// <summary>
		/// System.Int32 m_Count
		/// </summary>
		protected RField r_m_Count;
		public virtual RField Rm_Count
		{
			get
			{
				if(r_m_Count == null)
				{
					r_m_Count = new(this, "m_Count");
					r_m_Count.SetBelong(this.instance);
				}
				return r_m_Count;
			}
		}

		/// <summary>
		/// System.Boolean m_endOfPacket
		/// </summary>
		protected RField r_m_endOfPacket;
		public virtual RField Rm_endOfPacket
		{
			get
			{
				if(r_m_endOfPacket == null)
				{
					r_m_endOfPacket = new(this, "m_endOfPacket");
					r_m_endOfPacket.SetBelong(this.instance);
				}
				return r_m_endOfPacket;
			}
		}

		/// <summary>
		/// System.String FilePath
		/// </summary>
		protected RProperty r_FilePath;
		public virtual RProperty RFilePath
		{
			get
			{
				if(r_FilePath == null)
				{
					r_FilePath = new(this, "FilePath", -1);
					r_FilePath.SetBelong(this.instance);
				}
				return r_FilePath;
			}
		}

		/// <summary>
		/// Byte[] Buffer
		/// </summary>
		protected RPropertyArray<RProperty> r_Buffer;
		public virtual RPropertyArray<RProperty> RBuffer
		{
			get
			{
				if(r_Buffer == null)
				{
					r_Buffer = new(this, "Buffer", -1);
					r_Buffer.SetBelong(this.instance);
				}
				return r_Buffer;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Int32 Offset
		/// </summary>
		protected RProperty r_Offset;
		public virtual RProperty ROffset
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
		/// Boolean EndOfPacket
		/// </summary>
		protected RProperty r_EndOfPacket;
		public virtual RProperty REndOfPacket
		{
			get
			{
				if(r_EndOfPacket == null)
				{
					r_EndOfPacket = new(this, "EndOfPacket", -1);
					r_EndOfPacket.SetBelong(this.instance);
				}
				return r_EndOfPacket;
			}
		}

		/// <summary>
		/// Void Initialize(System.String, Byte[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInitialize_String_ByteArray_Int32_Int32_Boolean;
		public virtual RMethod RInitialize_String_ByteArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_RInitialize_String_ByteArray_Int32_Int32_Boolean == null)
				{
					r_RInitialize_String_ByteArray_Int32_Int32_Boolean = new(this, "Initialize", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RInitialize_String_ByteArray_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInitialize_String_ByteArray_Int32_Int32_Boolean;
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


        public RSendPacketsElement() : base("System.Net.Sockets.SendPacketsElement")
        {
        }

        public RSendPacketsElement(System.Object instance) : base("System.Net.Sockets.SendPacketsElement")
		{
            SetInstance(instance);
		}

        public RSendPacketsElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSendPacketsElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initialize(System.String  @filePath, System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.Boolean  @endOfPacket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath, @buffer, @offset, @count, @endOfPacket};
            var ___result = RInitialize_String_ByteArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
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
