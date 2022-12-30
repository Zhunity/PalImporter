using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CombineSkillLevelInfo
	/// </summary>
    public partial class RCombineSkillLevelInfo : RMember //
    {

		/// <summary>
		/// System.Int32 itemActivateId
		/// </summary>
		protected RField r_itemActivateId;
		public virtual RField RitemActivateId
		{
			get
			{
				if(r_itemActivateId == null)
				{
					r_itemActivateId = new(this, "itemActivateId");
					r_itemActivateId.SetBelong(this.instance);
				}
				return r_itemActivateId;
			}
		}

		/// <summary>
		/// System.Int32 itemActivateCost
		/// </summary>
		protected RField r_itemActivateCost;
		public virtual RField RitemActivateCost
		{
			get
			{
				if(r_itemActivateCost == null)
				{
					r_itemActivateCost = new(this, "itemActivateCost");
					r_itemActivateCost.SetBelong(this.instance);
				}
				return r_itemActivateCost;
			}
		}

		/// <summary>
		/// System.Int32 itemUpgradeId
		/// </summary>
		protected RField r_itemUpgradeId;
		public virtual RField RitemUpgradeId
		{
			get
			{
				if(r_itemUpgradeId == null)
				{
					r_itemUpgradeId = new(this, "itemUpgradeId");
					r_itemUpgradeId.SetBelong(this.instance);
				}
				return r_itemUpgradeId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] listItemUpgradeCost
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_listItemUpgradeCost;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RlistItemUpgradeCost
		{
			get
			{
				if(r_listItemUpgradeCost == null)
				{
					r_listItemUpgradeCost = new(this, "listItemUpgradeCost");
					r_listItemUpgradeCost.SetBelong(this.instance);
				}
				return r_listItemUpgradeCost;
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


        public RCombineSkillLevelInfo() : base("CombineSkillLevelInfo")
        {
        }

        public RCombineSkillLevelInfo(System.Object instance) : base("CombineSkillLevelInfo")
		{
            SetInstance(instance);
		}

        public RCombineSkillLevelInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombineSkillLevelInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
