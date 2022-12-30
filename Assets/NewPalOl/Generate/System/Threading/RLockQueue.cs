using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.LockQueue
	/// </summary>
    public partial class RLockQueue : RMember //
    {

		/// <summary>
		/// System.Threading.ReaderWriterLock rwlock
		/// </summary>
		protected RSystem.RThreading.RReaderWriterLock r_rwlock;
		public virtual RSystem.RThreading.RReaderWriterLock Rrwlock
		{
			get
			{
				if(r_rwlock == null)
				{
					r_rwlock = new(this, "rwlock");
					r_rwlock.SetBelong(this.instance);
				}
				return r_rwlock;
			}
		}

		/// <summary>
		/// System.Int32 lockCount
		/// </summary>
		protected RField r_lockCount;
		public virtual RField RlockCount
		{
			get
			{
				if(r_lockCount == null)
				{
					r_lockCount = new(this, "lockCount");
					r_lockCount.SetBelong(this.instance);
				}
				return r_lockCount;
			}
		}

		/// <summary>
		/// Boolean IsEmpty
		/// </summary>
		protected RProperty r_IsEmpty;
		public virtual RProperty RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", -1);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
			}
		}

		/// <summary>
		/// Boolean Wait(Int32)
		/// </summary>
		protected RMethod r_RWait_Int32;
		public virtual RMethod RWait_Int32
		{
			get
			{
				if(r_RWait_Int32 == null)
				{
					r_RWait_Int32 = new(this, "Wait", 0, typeof(System.Int32));
					r_RWait_Int32.SetBelong(this.instance);
				}
				return r_RWait_Int32;
			}
		}

		/// <summary>
		/// Void Pulse()
		/// </summary>
		protected RMethod r_RPulse;
		public virtual RMethod RPulse
		{
			get
			{
				if(r_RPulse == null)
				{
					r_RPulse = new(this, "Pulse", 0);
					r_RPulse.SetBelong(this.instance);
				}
				return r_RPulse;
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


        public RLockQueue() : base("System.Threading.LockQueue")
        {
        }

        public RLockQueue(System.Object instance) : base("System.Threading.LockQueue")
		{
            SetInstance(instance);
		}

        public RLockQueue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLockQueue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Wait(System.Int32  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RWait_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Pulse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPulse.Invoke(___genericsType, ___parameters);

            
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
