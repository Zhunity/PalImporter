using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// InfluenceItemInfo
	/// </summary>
    public partial class RInfluenceItemInfo : RMember //
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
		/// System.Int32 horde_id
		/// </summary>
		protected RField r_horde_id;
		public virtual RField Rhorde_id
		{
			get
			{
				if(r_horde_id == null)
				{
					r_horde_id = new(this, "horde_id");
					r_horde_id.SetBelong(this.instance);
				}
				return r_horde_id;
			}
		}

		/// <summary>
		/// System.Int32 item_id
		/// </summary>
		protected RField r_item_id;
		public virtual RField Ritem_id
		{
			get
			{
				if(r_item_id == null)
				{
					r_item_id = new(this, "item_id");
					r_item_id.SetBelong(this.instance);
				}
				return r_item_id;
			}
		}

		/// <summary>
		/// System.Int32 item_type
		/// </summary>
		protected RField r_item_type;
		public virtual RField Ritem_type
		{
			get
			{
				if(r_item_type == null)
				{
					r_item_type = new(this, "item_type");
					r_item_type.SetBelong(this.instance);
				}
				return r_item_type;
			}
		}

		/// <summary>
		/// System.Int32 need_career
		/// </summary>
		protected RField r_need_career;
		public virtual RField Rneed_career
		{
			get
			{
				if(r_need_career == null)
				{
					r_need_career = new(this, "need_career");
					r_need_career.SetBelong(this.instance);
				}
				return r_need_career;
			}
		}

		/// <summary>
		/// System.Int32 need_credit
		/// </summary>
		protected RField r_need_credit;
		public virtual RField Rneed_credit
		{
			get
			{
				if(r_need_credit == null)
				{
					r_need_credit = new(this, "need_credit");
					r_need_credit.SetBelong(this.instance);
				}
				return r_need_credit;
			}
		}

		/// <summary>
		/// System.Int32 need_level
		/// </summary>
		protected RField r_need_level;
		public virtual RField Rneed_level
		{
			get
			{
				if(r_need_level == null)
				{
					r_need_level = new(this, "need_level");
					r_need_level.SetBelong(this.instance);
				}
				return r_need_level;
			}
		}

		/// <summary>
		/// System.Int32 type_id
		/// </summary>
		protected RField r_type_id;
		public virtual RField Rtype_id
		{
			get
			{
				if(r_type_id == null)
				{
					r_type_id = new(this, "type_id");
					r_type_id.SetBelong(this.instance);
				}
				return r_type_id;
			}
		}

		/// <summary>
		/// Int32 ShopId
		/// </summary>
		protected RProperty r_ShopId;
		public virtual RProperty RShopId
		{
			get
			{
				if(r_ShopId == null)
				{
					r_ShopId = new(this, "ShopId", -1);
					r_ShopId.SetBelong(this.instance);
				}
				return r_ShopId;
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


        public RInfluenceItemInfo() : base("InfluenceItemInfo")
        {
        }

        public RInfluenceItemInfo(System.Object instance) : base("InfluenceItemInfo")
		{
            SetInstance(instance);
		}

        public RInfluenceItemInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInfluenceItemInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
