using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// HomeSeedConfig
	/// </summary>
    public partial class RHomeSeedConfig : RMember //
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
		/// System.Int32 price_gold
		/// </summary>
		protected RField r_price_gold;
		public virtual RField Rprice_gold
		{
			get
			{
				if(r_price_gold == null)
				{
					r_price_gold = new(this, "price_gold");
					r_price_gold.SetBelong(this.instance);
				}
				return r_price_gold;
			}
		}

		/// <summary>
		/// System.Int32 price_goldex
		/// </summary>
		protected RField r_price_goldex;
		public virtual RField Rprice_goldex
		{
			get
			{
				if(r_price_goldex == null)
				{
					r_price_goldex = new(this, "price_goldex");
					r_price_goldex.SetBelong(this.instance);
				}
				return r_price_goldex;
			}
		}

		/// <summary>
		/// System.Int32 product
		/// </summary>
		protected RField r_product;
		public virtual RField Rproduct
		{
			get
			{
				if(r_product == null)
				{
					r_product = new(this, "product");
					r_product.SetBelong(this.instance);
				}
				return r_product;
			}
		}

		/// <summary>
		/// System.String seedpic
		/// </summary>
		protected RField r_seedpic;
		public virtual RField Rseedpic
		{
			get
			{
				if(r_seedpic == null)
				{
					r_seedpic = new(this, "seedpic");
					r_seedpic.SetBelong(this.instance);
				}
				return r_seedpic;
			}
		}

		/// <summary>
		/// System.String growpic
		/// </summary>
		protected RField r_growpic;
		public virtual RField Rgrowpic
		{
			get
			{
				if(r_growpic == null)
				{
					r_growpic = new(this, "growpic");
					r_growpic.SetBelong(this.instance);
				}
				return r_growpic;
			}
		}

		/// <summary>
		/// System.String harvestpic
		/// </summary>
		protected RField r_harvestpic;
		public virtual RField Rharvestpic
		{
			get
			{
				if(r_harvestpic == null)
				{
					r_harvestpic = new(this, "harvestpic");
					r_harvestpic.SetBelong(this.instance);
				}
				return r_harvestpic;
			}
		}

		/// <summary>
		/// System.Int32 isSold
		/// </summary>
		protected RField r_isSold;
		public virtual RField RisSold
		{
			get
			{
				if(r_isSold == null)
				{
					r_isSold = new(this, "isSold");
					r_isSold.SetBelong(this.instance);
				}
				return r_isSold;
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


        public RHomeSeedConfig() : base("HomeSeedConfig")
        {
        }

        public RHomeSeedConfig(System.Object instance) : base("HomeSeedConfig")
		{
            SetInstance(instance);
		}

        public RHomeSeedConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHomeSeedConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
