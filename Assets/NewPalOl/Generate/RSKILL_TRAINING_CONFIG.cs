using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SKILL_TRAINING_CONFIG
	/// </summary>
    public partial class RSKILL_TRAINING_CONFIG : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Int32 gold
		/// </summary>
		protected RField r_gold;
		public virtual RField Rgold
		{
			get
			{
				if(r_gold == null)
				{
					r_gold = new(this, "gold");
					r_gold.SetBelong(this.instance);
				}
				return r_gold;
			}
		}

		/// <summary>
		/// System.Int32 goldex
		/// </summary>
		protected RField r_goldex;
		public virtual RField Rgoldex
		{
			get
			{
				if(r_goldex == null)
				{
					r_goldex = new(this, "goldex");
					r_goldex.SetBelong(this.instance);
				}
				return r_goldex;
			}
		}

		/// <summary>
		/// System.Int32 effect
		/// </summary>
		protected RField r_effect;
		public virtual RField Reffect
		{
			get
			{
				if(r_effect == null)
				{
					r_effect = new(this, "effect");
					r_effect.SetBelong(this.instance);
				}
				return r_effect;
			}
		}

		/// <summary>
		/// System.Int32 level_effect
		/// </summary>
		protected RField r_level_effect;
		public virtual RField Rlevel_effect
		{
			get
			{
				if(r_level_effect == null)
				{
					r_level_effect = new(this, "level_effect");
					r_level_effect.SetBelong(this.instance);
				}
				return r_level_effect;
			}
		}

		/// <summary>
		/// System.Int32 open_queue
		/// </summary>
		protected RField r_open_queue;
		public virtual RField Ropen_queue
		{
			get
			{
				if(r_open_queue == null)
				{
					r_open_queue = new(this, "open_queue");
					r_open_queue.SetBelong(this.instance);
				}
				return r_open_queue;
			}
		}

		/// <summary>
		/// System.Int32 queue_up
		/// </summary>
		protected RField r_queue_up;
		public virtual RField Rqueue_up
		{
			get
			{
				if(r_queue_up == null)
				{
					r_queue_up = new(this, "queue_up");
					r_queue_up.SetBelong(this.instance);
				}
				return r_queue_up;
			}
		}

		/// <summary>
		/// System.Int32 time
		/// </summary>
		protected RField r_time;
		public virtual RField Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time");
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// System.String beizhu
		/// </summary>
		protected RField r_beizhu;
		public virtual RField Rbeizhu
		{
			get
			{
				if(r_beizhu == null)
				{
					r_beizhu = new(this, "beizhu");
					r_beizhu.SetBelong(this.instance);
				}
				return r_beizhu;
			}
		}

		/// <summary>
		/// System.Int32 needvip
		/// </summary>
		protected RField r_needvip;
		public virtual RField Rneedvip
		{
			get
			{
				if(r_needvip == null)
				{
					r_needvip = new(this, "needvip");
					r_needvip.SetBelong(this.instance);
				}
				return r_needvip;
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


        public RSKILL_TRAINING_CONFIG() : base("SKILL_TRAINING_CONFIG")
        {
        }

        public RSKILL_TRAINING_CONFIG(System.Object instance) : base("SKILL_TRAINING_CONFIG")
		{
            SetInstance(instance);
		}

        public RSKILL_TRAINING_CONFIG(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSKILL_TRAINING_CONFIG(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
