using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SpiritLimitConfig
	/// </summary>
    public partial class RSpiritLimitConfig : RMember //
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
		/// System.Int32 nextEquip
		/// </summary>
		protected RField r_nextEquip;
		public virtual RField RnextEquip
		{
			get
			{
				if(r_nextEquip == null)
				{
					r_nextEquip = new(this, "nextEquip");
					r_nextEquip.SetBelong(this.instance);
				}
				return r_nextEquip;
			}
		}

		/// <summary>
		/// System.Int32 nextLevel
		/// </summary>
		protected RField r_nextLevel;
		public virtual RField RnextLevel
		{
			get
			{
				if(r_nextLevel == null)
				{
					r_nextLevel = new(this, "nextLevel");
					r_nextLevel.SetBelong(this.instance);
				}
				return r_nextLevel;
			}
		}

		/// <summary>
		/// System.Int32 spiritEquip
		/// </summary>
		protected RField r_spiritEquip;
		public virtual RField RspiritEquip
		{
			get
			{
				if(r_spiritEquip == null)
				{
					r_spiritEquip = new(this, "spiritEquip");
					r_spiritEquip.SetBelong(this.instance);
				}
				return r_spiritEquip;
			}
		}

		/// <summary>
		/// System.Int32 spiritLevel
		/// </summary>
		protected RField r_spiritLevel;
		public virtual RField RspiritLevel
		{
			get
			{
				if(r_spiritLevel == null)
				{
					r_spiritLevel = new(this, "spiritLevel");
					r_spiritLevel.SetBelong(this.instance);
				}
				return r_spiritLevel;
			}
		}

		/// <summary>
		/// System.Int32 buyChipGoldexPrice
		/// </summary>
		protected RField r_buyChipGoldexPrice;
		public virtual RField RbuyChipGoldexPrice
		{
			get
			{
				if(r_buyChipGoldexPrice == null)
				{
					r_buyChipGoldexPrice = new(this, "buyChipGoldexPrice");
					r_buyChipGoldexPrice.SetBelong(this.instance);
				}
				return r_buyChipGoldexPrice;
			}
		}

		/// <summary>
		/// System.Int32 buyChipGoldPrice
		/// </summary>
		protected RField r_buyChipGoldPrice;
		public virtual RField RbuyChipGoldPrice
		{
			get
			{
				if(r_buyChipGoldPrice == null)
				{
					r_buyChipGoldPrice = new(this, "buyChipGoldPrice");
					r_buyChipGoldPrice.SetBelong(this.instance);
				}
				return r_buyChipGoldPrice;
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


        public RSpiritLimitConfig() : base("SpiritLimitConfig")
        {
        }

        public RSpiritLimitConfig(System.Object instance) : base("SpiritLimitConfig")
		{
            SetInstance(instance);
		}

        public RSpiritLimitConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpiritLimitConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
