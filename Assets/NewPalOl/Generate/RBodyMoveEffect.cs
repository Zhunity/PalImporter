using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BodyMoveEffect
	/// </summary>
    public partial class RBodyMoveEffect : RMember //
    {

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
		/// System.Single moveToTime
		/// </summary>
		protected RField r_moveToTime;
		public virtual RField RmoveToTime
		{
			get
			{
				if(r_moveToTime == null)
				{
					r_moveToTime = new(this, "moveToTime");
					r_moveToTime.SetBelong(this.instance);
				}
				return r_moveToTime;
			}
		}

		/// <summary>
		/// System.Single moveBackTime
		/// </summary>
		protected RField r_moveBackTime;
		public virtual RField RmoveBackTime
		{
			get
			{
				if(r_moveBackTime == null)
				{
					r_moveBackTime = new(this, "moveBackTime");
					r_moveBackTime.SetBelong(this.instance);
				}
				return r_moveBackTime;
			}
		}

		/// <summary>
		/// System.Int32 movedir
		/// </summary>
		protected RField r_movedir;
		public virtual RField Rmovedir
		{
			get
			{
				if(r_movedir == null)
				{
					r_movedir = new(this, "movedir");
					r_movedir.SetBelong(this.instance);
				}
				return r_movedir;
			}
		}

		/// <summary>
		/// System.Single distance
		/// </summary>
		protected RField r_distance;
		public virtual RField Rdistance
		{
			get
			{
				if(r_distance == null)
				{
					r_distance = new(this, "distance");
					r_distance.SetBelong(this.instance);
				}
				return r_distance;
			}
		}

		/// <summary>
		/// System.Int32 itweenTyp
		/// </summary>
		protected RField r_itweenTyp;
		public virtual RField RitweenTyp
		{
			get
			{
				if(r_itweenTyp == null)
				{
					r_itweenTyp = new(this, "itweenTyp");
					r_itweenTyp.SetBelong(this.instance);
				}
				return r_itweenTyp;
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


        public RBodyMoveEffect() : base("BodyMoveEffect")
        {
        }

        public RBodyMoveEffect(System.Object instance) : base("BodyMoveEffect")
		{
            SetInstance(instance);
		}

        public RBodyMoveEffect(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBodyMoveEffect(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
