using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetItemDiscountConfig
	/// </summary>
    public partial class RPetItemDiscountConfig : RMember //
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
		/// System.Int32 expense
		/// </summary>
		protected RField r_expense;
		public virtual RField Rexpense
		{
			get
			{
				if(r_expense == null)
				{
					r_expense = new(this, "expense");
					r_expense.SetBelong(this.instance);
				}
				return r_expense;
			}
		}

		/// <summary>
		/// System.Int32 horse_id
		/// </summary>
		protected RField r_horse_id;
		public virtual RField Rhorse_id
		{
			get
			{
				if(r_horse_id == null)
				{
					r_horse_id = new(this, "horse_id");
					r_horse_id.SetBelong(this.instance);
				}
				return r_horse_id;
			}
		}

		/// <summary>
		/// System.String item
		/// </summary>
		protected RField r_item;
		public virtual RField Ritem
		{
			get
			{
				if(r_item == null)
				{
					r_item = new(this, "item");
					r_item.SetBelong(this.instance);
				}
				return r_item;
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
		/// System.Int32 price_discount
		/// </summary>
		protected RField r_price_discount;
		public virtual RField Rprice_discount
		{
			get
			{
				if(r_price_discount == null)
				{
					r_price_discount = new(this, "price_discount");
					r_price_discount.SetBelong(this.instance);
				}
				return r_price_discount;
			}
		}

		/// <summary>
		/// System.Int32 type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Int32 tips
		/// </summary>
		protected RField r_tips;
		public virtual RField Rtips
		{
			get
			{
				if(r_tips == null)
				{
					r_tips = new(this, "tips");
					r_tips.SetBelong(this.instance);
				}
				return r_tips;
			}
		}

		/// <summary>
		/// System.Int32 tips2
		/// </summary>
		protected RField r_tips2;
		public virtual RField Rtips2
		{
			get
			{
				if(r_tips2 == null)
				{
					r_tips2 = new(this, "tips2");
					r_tips2.SetBelong(this.instance);
				}
				return r_tips2;
			}
		}

		/// <summary>
		/// System.Int32 loopNums
		/// </summary>
		protected RField r_loopNums;
		public virtual RField RloopNums
		{
			get
			{
				if(r_loopNums == null)
				{
					r_loopNums = new(this, "loopNums");
					r_loopNums.SetBelong(this.instance);
				}
				return r_loopNums;
			}
		}

		/// <summary>
		/// System.Int32 buyConfirm
		/// </summary>
		protected RField r_buyConfirm;
		public virtual RField RbuyConfirm
		{
			get
			{
				if(r_buyConfirm == null)
				{
					r_buyConfirm = new(this, "buyConfirm");
					r_buyConfirm.SetBelong(this.instance);
				}
				return r_buyConfirm;
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


        public RPetItemDiscountConfig() : base("PetItemDiscountConfig")
        {
        }

        public RPetItemDiscountConfig(System.Object instance) : base("PetItemDiscountConfig")
		{
            SetInstance(instance);
		}

        public RPetItemDiscountConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetItemDiscountConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
