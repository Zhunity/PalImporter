using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCountdownManager
{
	
	/// <summary>
	/// CountdownManager+Countdown
	/// </summary>
    public partial class RCountdown : RMember //
    {

		/// <summary>
		/// CountdownType _type
		/// </summary>
		protected RField r__type;
		public virtual RField R_type
		{
			get
			{
				if(r__type == null)
				{
					r__type = new(this, "_type");
					r__type.SetBelong(this.instance);
				}
				return r__type;
			}
		}

		/// <summary>
		/// CountdownManager+Handler _hander
		/// </summary>
		protected RCountdownManager.RHandler r__hander;
		public virtual RCountdownManager.RHandler R_hander
		{
			get
			{
				if(r__hander == null)
				{
					r__hander = new(this, "_hander");
					r__hander.SetBelong(this.instance);
				}
				return r__hander;
			}
		}

		/// <summary>
		/// System.Single _CooldownTime
		/// </summary>
		protected RField r__CooldownTime;
		public virtual RField R_CooldownTime
		{
			get
			{
				if(r__CooldownTime == null)
				{
					r__CooldownTime = new(this, "_CooldownTime");
					r__CooldownTime.SetBelong(this.instance);
				}
				return r__CooldownTime;
			}
		}

		/// <summary>
		/// System.Single _timeSinceStartup
		/// </summary>
		protected RField r__timeSinceStartup;
		public virtual RField R_timeSinceStartup
		{
			get
			{
				if(r__timeSinceStartup == null)
				{
					r__timeSinceStartup = new(this, "_timeSinceStartup");
					r__timeSinceStartup.SetBelong(this.instance);
				}
				return r__timeSinceStartup;
			}
		}

		/// <summary>
		/// System.Boolean _bStop
		/// </summary>
		protected RField r__bStop;
		public virtual RField R_bStop
		{
			get
			{
				if(r__bStop == null)
				{
					r__bStop = new(this, "_bStop");
					r__bStop.SetBelong(this.instance);
				}
				return r__bStop;
			}
		}

		/// <summary>
		/// System.Object _data
		/// </summary>
		protected RSystem.RObject r__data;
		public virtual RSystem.RObject R_data
		{
			get
			{
				if(r__data == null)
				{
					r__data = new(this, "_data");
					r__data.SetBelong(this.instance);
				}
				return r__data;
			}
		}

		/// <summary>
		/// Single GetRemainTime()
		/// </summary>
		protected RMethod r_RGetRemainTime;
		public virtual RMethod RGetRemainTime
		{
			get
			{
				if(r_RGetRemainTime == null)
				{
					r_RGetRemainTime = new(this, "GetRemainTime", 0);
					r_RGetRemainTime.SetBelong(this.instance);
				}
				return r_RGetRemainTime;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
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


        public RCountdown() : base("CountdownManager+Countdown")
        {
        }

        public RCountdown(System.Object instance) : base("CountdownManager+Countdown")
		{
            SetInstance(instance);
		}

        public RCountdown(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCountdown(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Single GetRemainTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRemainTime.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
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