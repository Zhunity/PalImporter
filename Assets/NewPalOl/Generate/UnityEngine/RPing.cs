using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Ping
	/// </summary>
    public partial class RPing : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// Boolean isDone
		/// </summary>
		protected RProperty r_isDone;
		public virtual RProperty RisDone
		{
			get
			{
				if(r_isDone == null)
				{
					r_isDone = new(this, "isDone", -1);
					r_isDone.SetBelong(this.instance);
				}
				return r_isDone;
			}
		}

		/// <summary>
		/// Int32 time
		/// </summary>
		protected RProperty r_time;
		public virtual RProperty Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time", -1);
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// System.String ip
		/// </summary>
		protected RProperty r_ip;
		public virtual RProperty Rip
		{
			get
			{
				if(r_ip == null)
				{
					r_ip = new(this, "ip", -1);
					r_ip.SetBelong(this.instance);
				}
				return r_ip;
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
		/// Void DestroyPing()
		/// </summary>
		protected RMethod r_RDestroyPing;
		public virtual RMethod RDestroyPing
		{
			get
			{
				if(r_RDestroyPing == null)
				{
					r_RDestroyPing = new(this, "DestroyPing", 0);
					r_RDestroyPing.SetBelong(this.instance);
				}
				return r_RDestroyPing;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_Destroy_IntPtr;
		public static RMethod RInternal_Destroy_IntPtr
		{
			get
			{
				if(r_RInternal_Destroy_IntPtr == null)
				{
					r_RInternal_Destroy_IntPtr = new(typeof(UnityEngine.Ping), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_RInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(System.String)
		/// </summary>
		protected static RMethod r_RInternal_Create_String;
		public static RMethod RInternal_Create_String
		{
			get
			{
				if(r_RInternal_Create_String == null)
				{
					r_RInternal_Create_String = new(typeof(UnityEngine.Ping), "Internal_Create", 0, typeof(System.String));
					r_RInternal_Create_String.SetBelong(null);
				}
				return r_RInternal_Create_String;
			}
		}

		/// <summary>
		/// Boolean Internal_IsDone()
		/// </summary>
		protected RMethod r_RInternal_IsDone;
		public virtual RMethod RInternal_IsDone
		{
			get
			{
				if(r_RInternal_IsDone == null)
				{
					r_RInternal_IsDone = new(this, "Internal_IsDone", 0);
					r_RInternal_IsDone.SetBelong(this.instance);
				}
				return r_RInternal_IsDone;
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


        public RPing() : base("UnityEngine.Ping")
        {
        }

        public RPing(System.Object instance) : base("UnityEngine.Ping")
		{
            SetInstance(instance);
		}

        public RPing(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPing(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyPing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroyPing.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Destroy(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(System.String  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RInternal_Create_String.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Boolean Internal_IsDone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_IsDone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
