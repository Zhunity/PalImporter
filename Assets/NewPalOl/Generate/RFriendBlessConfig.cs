using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FriendBlessConfig
	/// </summary>
    public partial class RFriendBlessConfig : RMember //
    {

		/// <summary>
		/// System.Int32 level
		/// </summary>
		protected RField r_level;
		public virtual RField Rlevel
		{
			get
			{
				if(r_level == null)
				{
					r_level = new(this, "level");
					r_level.SetBelong(this.instance);
				}
				return r_level;
			}
		}

		/// <summary>
		/// System.Int32 blessing_money1
		/// </summary>
		protected RField r_blessing_money1;
		public virtual RField Rblessing_money1
		{
			get
			{
				if(r_blessing_money1 == null)
				{
					r_blessing_money1 = new(this, "blessing_money1");
					r_blessing_money1.SetBelong(this.instance);
				}
				return r_blessing_money1;
			}
		}

		/// <summary>
		/// System.Int32 blessing_money2
		/// </summary>
		protected RField r_blessing_money2;
		public virtual RField Rblessing_money2
		{
			get
			{
				if(r_blessing_money2 == null)
				{
					r_blessing_money2 = new(this, "blessing_money2");
					r_blessing_money2.SetBelong(this.instance);
				}
				return r_blessing_money2;
			}
		}

		/// <summary>
		/// System.Int32 blessing_money3
		/// </summary>
		protected RField r_blessing_money3;
		public virtual RField Rblessing_money3
		{
			get
			{
				if(r_blessing_money3 == null)
				{
					r_blessing_money3 = new(this, "blessing_money3");
					r_blessing_money3.SetBelong(this.instance);
				}
				return r_blessing_money3;
			}
		}

		/// <summary>
		/// System.Int32 cost1
		/// </summary>
		protected RField r_cost1;
		public virtual RField Rcost1
		{
			get
			{
				if(r_cost1 == null)
				{
					r_cost1 = new(this, "cost1");
					r_cost1.SetBelong(this.instance);
				}
				return r_cost1;
			}
		}

		/// <summary>
		/// System.Int32 cost2
		/// </summary>
		protected RField r_cost2;
		public virtual RField Rcost2
		{
			get
			{
				if(r_cost2 == null)
				{
					r_cost2 = new(this, "cost2");
					r_cost2.SetBelong(this.instance);
				}
				return r_cost2;
			}
		}

		/// <summary>
		/// System.Int32 cost3
		/// </summary>
		protected RField r_cost3;
		public virtual RField Rcost3
		{
			get
			{
				if(r_cost3 == null)
				{
					r_cost3 = new(this, "cost3");
					r_cost3.SetBelong(this.instance);
				}
				return r_cost3;
			}
		}

		/// <summary>
		/// System.Int32 goldcost
		/// </summary>
		protected RField r_goldcost;
		public virtual RField Rgoldcost
		{
			get
			{
				if(r_goldcost == null)
				{
					r_goldcost = new(this, "goldcost");
					r_goldcost.SetBelong(this.instance);
				}
				return r_goldcost;
			}
		}

		/// <summary>
		/// System.Int32 exp1
		/// </summary>
		protected RField r_exp1;
		public virtual RField Rexp1
		{
			get
			{
				if(r_exp1 == null)
				{
					r_exp1 = new(this, "exp1");
					r_exp1.SetBelong(this.instance);
				}
				return r_exp1;
			}
		}

		/// <summary>
		/// System.Int32 exp2
		/// </summary>
		protected RField r_exp2;
		public virtual RField Rexp2
		{
			get
			{
				if(r_exp2 == null)
				{
					r_exp2 = new(this, "exp2");
					r_exp2.SetBelong(this.instance);
				}
				return r_exp2;
			}
		}

		/// <summary>
		/// System.Int32 exp3
		/// </summary>
		protected RField r_exp3;
		public virtual RField Rexp3
		{
			get
			{
				if(r_exp3 == null)
				{
					r_exp3 = new(this, "exp3");
					r_exp3.SetBelong(this.instance);
				}
				return r_exp3;
			}
		}

		/// <summary>
		/// System.Int32 goldexp
		/// </summary>
		protected RField r_goldexp;
		public virtual RField Rgoldexp
		{
			get
			{
				if(r_goldexp == null)
				{
					r_goldexp = new(this, "goldexp");
					r_goldexp.SetBelong(this.instance);
				}
				return r_goldexp;
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


        public RFriendBlessConfig() : base("FriendBlessConfig")
        {
        }

        public RFriendBlessConfig(System.Object instance) : base("FriendBlessConfig")
		{
            SetInstance(instance);
		}

        public RFriendBlessConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFriendBlessConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
