using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SendBulletEffect
	/// </summary>
    public partial class RSendBulletEffect : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Single sendTime
		/// </summary>
		protected RField r_sendTime;
		public virtual RField RsendTime
		{
			get
			{
				if(r_sendTime == null)
				{
					r_sendTime = new(this, "sendTime");
					r_sendTime.SetBelong(this.instance);
				}
				return r_sendTime;
			}
		}

		/// <summary>
		/// System.Single duration
		/// </summary>
		protected RField r_duration;
		public virtual RField Rduration
		{
			get
			{
				if(r_duration == null)
				{
					r_duration = new(this, "duration");
					r_duration.SetBelong(this.instance);
				}
				return r_duration;
			}
		}

		/// <summary>
		/// System.Single mDelayDistance
		/// </summary>
		protected RField r_mDelayDistance;
		public virtual RField RmDelayDistance
		{
			get
			{
				if(r_mDelayDistance == null)
				{
					r_mDelayDistance = new(this, "mDelayDistance");
					r_mDelayDistance.SetBelong(this.instance);
				}
				return r_mDelayDistance;
			}
		}

		/// <summary>
		/// System.Single xAxes
		/// </summary>
		protected RField r_xAxes;
		public virtual RField RxAxes
		{
			get
			{
				if(r_xAxes == null)
				{
					r_xAxes = new(this, "xAxes");
					r_xAxes.SetBelong(this.instance);
				}
				return r_xAxes;
			}
		}

		/// <summary>
		/// System.Single yAxes
		/// </summary>
		protected RField r_yAxes;
		public virtual RField RyAxes
		{
			get
			{
				if(r_yAxes == null)
				{
					r_yAxes = new(this, "yAxes");
					r_yAxes.SetBelong(this.instance);
				}
				return r_yAxes;
			}
		}

		/// <summary>
		/// System.Single zAxes
		/// </summary>
		protected RField r_zAxes;
		public virtual RField RzAxes
		{
			get
			{
				if(r_zAxes == null)
				{
					r_zAxes = new(this, "zAxes");
					r_zAxes.SetBelong(this.instance);
				}
				return r_zAxes;
			}
		}

		/// <summary>
		/// System.Int32 rotatMode
		/// </summary>
		protected RField r_rotatMode;
		public virtual RField RrotatMode
		{
			get
			{
				if(r_rotatMode == null)
				{
					r_rotatMode = new(this, "rotatMode");
					r_rotatMode.SetBelong(this.instance);
				}
				return r_rotatMode;
			}
		}

		/// <summary>
		/// System.Single rotatSpd
		/// </summary>
		protected RField r_rotatSpd;
		public virtual RField RrotatSpd
		{
			get
			{
				if(r_rotatSpd == null)
				{
					r_rotatSpd = new(this, "rotatSpd");
					r_rotatSpd.SetBelong(this.instance);
				}
				return r_rotatSpd;
			}
		}

		/// <summary>
		/// System.String mType
		/// </summary>
		protected RField r_mType;
		public virtual RField RmType
		{
			get
			{
				if(r_mType == null)
				{
					r_mType = new(this, "mType");
					r_mType.SetBelong(this.instance);
				}
				return r_mType;
			}
		}

		/// <summary>
		/// System.Single mFireTime
		/// </summary>
		protected RField r_mFireTime;
		public virtual RField RmFireTime
		{
			get
			{
				if(r_mFireTime == null)
				{
					r_mFireTime = new(this, "mFireTime");
					r_mFireTime.SetBelong(this.instance);
				}
				return r_mFireTime;
			}
		}

		/// <summary>
		/// Void SetBattleAction(BattleAction)
		/// </summary>
		protected RMethod r_RSetBattleAction_BattleAction;
		public virtual RMethod RSetBattleAction_BattleAction
		{
			get
			{
				if(r_RSetBattleAction_BattleAction == null)
				{
					r_RSetBattleAction_BattleAction = new(this, "SetBattleAction", 0,  ReleactionUtils.GetType("BattleAction"));
					r_RSetBattleAction_BattleAction.SetBelong(this.instance);
				}
				return r_RSetBattleAction_BattleAction;
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


        public RSendBulletEffect() : base("SendBulletEffect")
        {
        }

        public RSendBulletEffect(System.Object instance) : base("SendBulletEffect")
		{
            SetInstance(instance);
		}

        public RSendBulletEffect(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSendBulletEffect(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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