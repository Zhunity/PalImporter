using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PhysicalConfig
	/// </summary>
    public partial class RPhysicalConfig : RMember //
    {

		/// <summary>
		/// System.Int32 frequency
		/// </summary>
		protected RField r_frequency;
		public virtual RField Rfrequency
		{
			get
			{
				if(r_frequency == null)
				{
					r_frequency = new(this, "frequency");
					r_frequency.SetBelong(this.instance);
				}
				return r_frequency;
			}
		}

		/// <summary>
		/// System.Int32 goldNeed
		/// </summary>
		protected RField r_goldNeed;
		public virtual RField RgoldNeed
		{
			get
			{
				if(r_goldNeed == null)
				{
					r_goldNeed = new(this, "goldNeed");
					r_goldNeed.SetBelong(this.instance);
				}
				return r_goldNeed;
			}
		}

		/// <summary>
		/// System.Int32 tili
		/// </summary>
		protected RField r_tili;
		public virtual RField Rtili
		{
			get
			{
				if(r_tili == null)
				{
					r_tili = new(this, "tili");
					r_tili.SetBelong(this.instance);
				}
				return r_tili;
			}
		}

		/// <summary>
		/// System.Int32 coefficient
		/// </summary>
		protected RField r_coefficient;
		public virtual RField Rcoefficient
		{
			get
			{
				if(r_coefficient == null)
				{
					r_coefficient = new(this, "coefficient");
					r_coefficient.SetBelong(this.instance);
				}
				return r_coefficient;
			}
		}

		/// <summary>
		/// System.Int32 coefficient_1
		/// </summary>
		protected RField r_coefficient_1;
		public virtual RField Rcoefficient_1
		{
			get
			{
				if(r_coefficient_1 == null)
				{
					r_coefficient_1 = new(this, "coefficient_1");
					r_coefficient_1.SetBelong(this.instance);
				}
				return r_coefficient_1;
			}
		}

		/// <summary>
		/// System.Int32 costgold
		/// </summary>
		protected RField r_costgold;
		public virtual RField Rcostgold
		{
			get
			{
				if(r_costgold == null)
				{
					r_costgold = new(this, "costgold");
					r_costgold.SetBelong(this.instance);
				}
				return r_costgold;
			}
		}

		/// <summary>
		/// System.Int32 param
		/// </summary>
		protected RField r_param;
		public virtual RField Rparam
		{
			get
			{
				if(r_param == null)
				{
					r_param = new(this, "param");
					r_param.SetBelong(this.instance);
				}
				return r_param;
			}
		}

		/// <summary>
		/// System.Int32 basemoney
		/// </summary>
		protected RField r_basemoney;
		public virtual RField Rbasemoney
		{
			get
			{
				if(r_basemoney == null)
				{
					r_basemoney = new(this, "basemoney");
					r_basemoney.SetBelong(this.instance);
				}
				return r_basemoney;
			}
		}

		/// <summary>
		/// System.Int32 baselingli
		/// </summary>
		protected RField r_baselingli;
		public virtual RField Rbaselingli
		{
			get
			{
				if(r_baselingli == null)
				{
					r_baselingli = new(this, "baselingli");
					r_baselingli.SetBelong(this.instance);
				}
				return r_baselingli;
			}
		}

		/// <summary>
		/// System.Int32 chuanguancount
		/// </summary>
		protected RField r_chuanguancount;
		public virtual RField Rchuanguancount
		{
			get
			{
				if(r_chuanguancount == null)
				{
					r_chuanguancount = new(this, "chuanguancount");
					r_chuanguancount.SetBelong(this.instance);
				}
				return r_chuanguancount;
			}
		}

		/// <summary>
		/// System.Int32 hechenggold
		/// </summary>
		protected RField r_hechenggold;
		public virtual RField Rhechenggold
		{
			get
			{
				if(r_hechenggold == null)
				{
					r_hechenggold = new(this, "hechenggold");
					r_hechenggold.SetBelong(this.instance);
				}
				return r_hechenggold;
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


        public RPhysicalConfig() : base("PhysicalConfig")
        {
        }

        public RPhysicalConfig(System.Object instance) : base("PhysicalConfig")
		{
            SetInstance(instance);
		}

        public RPhysicalConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPhysicalConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
