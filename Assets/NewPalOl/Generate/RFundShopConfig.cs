using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FundShopConfig
	/// </summary>
    public partial class RFundShopConfig : RMember //
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
		/// System.Int32 itemid
		/// </summary>
		protected RField r_itemid;
		public virtual RField Ritemid
		{
			get
			{
				if(r_itemid == null)
				{
					r_itemid = new(this, "itemid");
					r_itemid.SetBelong(this.instance);
				}
				return r_itemid;
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
		/// System.Int32 oldprice
		/// </summary>
		protected RField r_oldprice;
		public virtual RField Roldprice
		{
			get
			{
				if(r_oldprice == null)
				{
					r_oldprice = new(this, "oldprice");
					r_oldprice.SetBelong(this.instance);
				}
				return r_oldprice;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RField r_count;
		public virtual RField Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.Int32 pricetype
		/// </summary>
		protected RField r_pricetype;
		public virtual RField Rpricetype
		{
			get
			{
				if(r_pricetype == null)
				{
					r_pricetype = new(this, "pricetype");
					r_pricetype.SetBelong(this.instance);
				}
				return r_pricetype;
			}
		}

		/// <summary>
		/// System.Int32 israre
		/// </summary>
		protected RField r_israre;
		public virtual RField Risrare
		{
			get
			{
				if(r_israre == null)
				{
					r_israre = new(this, "israre");
					r_israre.SetBelong(this.instance);
				}
				return r_israre;
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


        public RFundShopConfig() : base("FundShopConfig")
        {
        }

        public RFundShopConfig(System.Object instance) : base("FundShopConfig")
		{
            SetInstance(instance);
		}

        public RFundShopConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFundShopConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
