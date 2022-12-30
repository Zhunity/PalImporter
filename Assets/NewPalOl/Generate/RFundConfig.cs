using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FundConfig
	/// </summary>
    public partial class RFundConfig : RMember //
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
		/// System.Int32 reward
		/// </summary>
		protected RField r_reward;
		public virtual RField Rreward
		{
			get
			{
				if(r_reward == null)
				{
					r_reward = new(this, "reward");
					r_reward.SetBelong(this.instance);
				}
				return r_reward;
			}
		}

		/// <summary>
		/// System.Int32 price
		/// </summary>
		protected RField r_price;
		public virtual RField Rprice
		{
			get
			{
				if(r_price == null)
				{
					r_price = new(this, "price");
					r_price.SetBelong(this.instance);
				}
				return r_price;
			}
		}

		/// <summary>
		/// System.Int32 rate
		/// </summary>
		protected RField r_rate;
		public virtual RField Rrate
		{
			get
			{
				if(r_rate == null)
				{
					r_rate = new(this, "rate");
					r_rate.SetBelong(this.instance);
				}
				return r_rate;
			}
		}

		/// <summary>
		/// System.Int32 day1
		/// </summary>
		protected RField r_day1;
		public virtual RField Rday1
		{
			get
			{
				if(r_day1 == null)
				{
					r_day1 = new(this, "day1");
					r_day1.SetBelong(this.instance);
				}
				return r_day1;
			}
		}

		/// <summary>
		/// System.Int32 day2
		/// </summary>
		protected RField r_day2;
		public virtual RField Rday2
		{
			get
			{
				if(r_day2 == null)
				{
					r_day2 = new(this, "day2");
					r_day2.SetBelong(this.instance);
				}
				return r_day2;
			}
		}

		/// <summary>
		/// System.Int32 day3
		/// </summary>
		protected RField r_day3;
		public virtual RField Rday3
		{
			get
			{
				if(r_day3 == null)
				{
					r_day3 = new(this, "day3");
					r_day3.SetBelong(this.instance);
				}
				return r_day3;
			}
		}

		/// <summary>
		/// System.Int32 day4
		/// </summary>
		protected RField r_day4;
		public virtual RField Rday4
		{
			get
			{
				if(r_day4 == null)
				{
					r_day4 = new(this, "day4");
					r_day4.SetBelong(this.instance);
				}
				return r_day4;
			}
		}

		/// <summary>
		/// System.Int32 day7
		/// </summary>
		protected RField r_day7;
		public virtual RField Rday7
		{
			get
			{
				if(r_day7 == null)
				{
					r_day7 = new(this, "day7");
					r_day7.SetBelong(this.instance);
				}
				return r_day7;
			}
		}

		/// <summary>
		/// System.Int32 day14
		/// </summary>
		protected RField r_day14;
		public virtual RField Rday14
		{
			get
			{
				if(r_day14 == null)
				{
					r_day14 = new(this, "day14");
					r_day14.SetBelong(this.instance);
				}
				return r_day14;
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


        public RFundConfig() : base("FundConfig")
        {
        }

        public RFundConfig(System.Object instance) : base("FundConfig")
		{
            SetInstance(instance);
		}

        public RFundConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFundConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
