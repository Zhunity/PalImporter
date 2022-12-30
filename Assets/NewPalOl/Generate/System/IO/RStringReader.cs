using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.StringReader
	/// </summary>
    public partial class RStringReader : RMember //
    {

		/// <summary>
		/// System.String _s
		/// </summary>
		protected RField r__s;
		public virtual RField R_s
		{
			get
			{
				if(r__s == null)
				{
					r__s = new(this, "_s");
					r__s.SetBelong(this.instance);
				}
				return r__s;
			}
		}

		/// <summary>
		/// System.Int32 _pos
		/// </summary>
		protected RField r__pos;
		public virtual RField R_pos
		{
			get
			{
				if(r__pos == null)
				{
					r__pos = new(this, "_pos");
					r__pos.SetBelong(this.instance);
				}
				return r__pos;
			}
		}

		/// <summary>
		/// System.Int32 _length
		/// </summary>
		protected RField r__length;
		public virtual RField R_length
		{
			get
			{
				if(r__length == null)
				{
					r__length = new(this, "_length");
					r__length.SetBelong(this.instance);
				}
				return r__length;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Int32 Peek()
		/// </summary>
		protected RMethod r_RPeek;
		public virtual RMethod RPeek
		{
			get
			{
				if(r_RPeek == null)
				{
					r_RPeek = new(this, "Peek", 0);
					r_RPeek.SetBelong(this.instance);
				}
				return r_RPeek;
			}
		}

		/// <summary>
		/// Int32 Read()
		/// </summary>
		protected RMethod r_RRead;
		public virtual RMethod RRead
		{
			get
			{
				if(r_RRead == null)
				{
					r_RRead = new(this, "Read", 0);
					r_RRead.SetBelong(this.instance);
				}
				return r_RRead;
			}
		}

		/// <summary>
		/// Int32 Read(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRead_CharArray_Int32_Int32;
		public virtual RMethod RRead_CharArray_Int32_Int32
		{
			get
			{
				if(r_RRead_CharArray_Int32_Int32 == null)
				{
					r_RRead_CharArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRead_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRead_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ReadToEnd()
		/// </summary>
		protected RMethod r_RReadToEnd;
		public virtual RMethod RReadToEnd
		{
			get
			{
				if(r_RReadToEnd == null)
				{
					r_RReadToEnd = new(this, "ReadToEnd", 0);
					r_RReadToEnd.SetBelong(this.instance);
				}
				return r_RReadToEnd;
			}
		}

		/// <summary>
		/// System.String ReadLine()
		/// </summary>
		protected RMethod r_RReadLine;
		public virtual RMethod RReadLine
		{
			get
			{
				if(r_RReadLine == null)
				{
					r_RReadLine = new(this, "ReadLine", 0);
					r_RReadLine.SetBelong(this.instance);
				}
				return r_RReadLine;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadLineAsync()
		/// </summary>
		protected RMethod r_RReadLineAsync;
		public virtual RMethod RReadLineAsync
		{
			get
			{
				if(r_RReadLineAsync == null)
				{
					r_RReadLineAsync = new(this, "ReadLineAsync", 0);
					r_RReadLineAsync.SetBelong(this.instance);
				}
				return r_RReadLineAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadToEndAsync()
		/// </summary>
		protected RMethod r_RReadToEndAsync;
		public virtual RMethod RReadToEndAsync
		{
			get
			{
				if(r_RReadToEndAsync == null)
				{
					r_RReadToEndAsync = new(this, "ReadToEndAsync", 0);
					r_RReadToEndAsync.SetBelong(this.instance);
				}
				return r_RReadToEndAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadBlockAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBlockAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadBlockAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadBlockAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadBlockAsync_CharArray_Int32_Int32 = new(this, "ReadBlockAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBlockAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBlockAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadAsync_CharArray_Int32_Int32 = new(this, "ReadAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RRead_Span_d_Char_p_;
		public virtual RMethod RRead_Span_d_Char_p_
		{
			get
			{
				if(r_RRead_Span_d_Char_p_ == null)
				{
					r_RRead_Span_d_Char_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RRead_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RRead_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 ReadBlock(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBlock_CharArray_Int32_Int32;
		public virtual RMethod RReadBlock_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadBlock_CharArray_Int32_Int32 == null)
				{
					r_RReadBlock_CharArray_Int32_Int32 = new(this, "ReadBlock", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBlock_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBlock_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBlock(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RReadBlock_Span_d_Char_p_;
		public virtual RMethod RReadBlock_Span_d_Char_p_
		{
			get
			{
				if(r_RReadBlock_Span_d_Char_p_ == null)
				{
					r_RReadBlock_Span_d_Char_p_ = new(this, "ReadBlock", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RReadBlock_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RReadBlock_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsync(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsync_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadAsync_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadAsync_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadAsync_Memory_d_Char_p__CancellationToken = new(this, "ReadAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadAsync_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsync_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsyncInternal(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadAsyncInternal_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken = new(this, "ReadAsyncInternal", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadBlockAsync(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadBlockAsync_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadBlockAsync_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadBlockAsync_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadBlockAsync_Memory_d_Char_p__CancellationToken = new(this, "ReadBlockAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadBlockAsync_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadBlockAsync_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadBlockAsyncInternal(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken = new(this, "ReadBlockAsyncInternal", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_RGetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_RGetLifetimeService == null)
				{
					r_RGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_RGetLifetimeService.SetBelong(this.instance);
				}
				return r_RGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_RInitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_RInitializeLifetimeService == null)
				{
					r_RInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_RInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_RInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_RMemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_RMemberwiseClone_Boolean == null)
				{
					r_RMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_RMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_RMemberwiseClone_Boolean;
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


        public RStringReader() : base("System.IO.StringReader")
        {
        }

        public RStringReader(System.Object instance) : base("System.IO.StringReader")
		{
            SetInstance(instance);
		}

        public RStringReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStringReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeek.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RRead_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ReadToEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadToEnd.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadLine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLine.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadLineAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLineAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadToEndAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadToEndAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadBlockAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadBlockAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Int32 ReadBlock(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadBlock_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsync_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncInternal(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsyncInternal_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadBlockAsync(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadBlockAsync_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadBlockAsyncInternal(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
