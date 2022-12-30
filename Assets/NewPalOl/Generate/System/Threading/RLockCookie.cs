using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.LockCookie
	/// </summary>
    public partial class RLockCookie : RMember //
    {

		/// <summary>
		/// System.Int32 ThreadId
		/// </summary>
		protected RField r_ThreadId;
		public virtual RField RThreadId
		{
			get
			{
				if(r_ThreadId == null)
				{
					r_ThreadId = new(this, "ThreadId");
					r_ThreadId.SetBelong(this.instance);
				}
				return r_ThreadId;
			}
		}

		/// <summary>
		/// System.Int32 ReaderLocks
		/// </summary>
		protected RField r_ReaderLocks;
		public virtual RField ReaderLocks
		{
			get
			{
				if(r_ReaderLocks == null)
				{
					r_ReaderLocks = new(this, "ReaderLocks");
					r_ReaderLocks.SetBelong(this.instance);
				}
				return r_ReaderLocks;
			}
		}

		/// <summary>
		/// System.Int32 WriterLocks
		/// </summary>
		protected RField r_WriterLocks;
		public virtual RField RWriterLocks
		{
			get
			{
				if(r_WriterLocks == null)
				{
					r_WriterLocks = new(this, "WriterLocks");
					r_WriterLocks.SetBelong(this.instance);
				}
				return r_WriterLocks;
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
		/// Boolean Equals(System.Threading.LockCookie)
		/// </summary>
		protected RMethod r_REquals_LockCookie;
		public virtual RMethod REquals_LockCookie
		{
			get
			{
				if(r_REquals_LockCookie == null)
				{
					r_REquals_LockCookie = new(this, "Equals", 0, typeof(System.Threading.LockCookie));
					r_REquals_LockCookie.SetBelong(this.instance);
				}
				return r_REquals_LockCookie;
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
		/// Boolean op_Equality(System.Threading.LockCookie, System.Threading.LockCookie)
		/// </summary>
		protected static RMethod r_Rop_Equality_LockCookie_LockCookie;
		public static RMethod Rop_Equality_LockCookie_LockCookie
		{
			get
			{
				if(r_Rop_Equality_LockCookie_LockCookie == null)
				{
					r_Rop_Equality_LockCookie_LockCookie = new(typeof(System.Threading.LockCookie), "op_Equality", 0, typeof(System.Threading.LockCookie), typeof(System.Threading.LockCookie));
					r_Rop_Equality_LockCookie_LockCookie.SetBelong(null);
				}
				return r_Rop_Equality_LockCookie_LockCookie;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.LockCookie, System.Threading.LockCookie)
		/// </summary>
		protected static RMethod r_Rop_Inequality_LockCookie_LockCookie;
		public static RMethod Rop_Inequality_LockCookie_LockCookie
		{
			get
			{
				if(r_Rop_Inequality_LockCookie_LockCookie == null)
				{
					r_Rop_Inequality_LockCookie_LockCookie = new(typeof(System.Threading.LockCookie), "op_Inequality", 0, typeof(System.Threading.LockCookie), typeof(System.Threading.LockCookie));
					r_Rop_Inequality_LockCookie_LockCookie.SetBelong(null);
				}
				return r_Rop_Inequality_LockCookie_LockCookie;
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


        public RLockCookie() : base("System.Threading.LockCookie")
        {
        }

        public RLockCookie(System.Object instance) : base("System.Threading.LockCookie")
		{
            SetInstance(instance);
		}

        public RLockCookie(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLockCookie(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Threading.LockCookie  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_LockCookie.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.LockCookie  @a, System.Threading.LockCookie  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_LockCookie_LockCookie.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.LockCookie  @a, System.Threading.LockCookie  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_LockCookie_LockCookie.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
