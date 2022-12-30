using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RAID_SERIES_INFO
	/// </summary>
    public partial class RRAID_SERIES_INFO : RMember //
    {

		/// <summary>
		/// System.String id
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
		/// System.String idset
		/// </summary>
		protected RField r_idset;
		public virtual RField Ridset
		{
			get
			{
				if(r_idset == null)
				{
					r_idset = new(this, "idset");
					r_idset.SetBelong(this.instance);
				}
				return r_idset;
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
		/// System.String normal_equip
		/// </summary>
		protected RField r_normal_equip;
		public virtual RField Rnormal_equip
		{
			get
			{
				if(r_normal_equip == null)
				{
					r_normal_equip = new(this, "normal_equip");
					r_normal_equip.SetBelong(this.instance);
				}
				return r_normal_equip;
			}
		}

		/// <summary>
		/// System.String normal_gold
		/// </summary>
		protected RField r_normal_gold;
		public virtual RField Rnormal_gold
		{
			get
			{
				if(r_normal_gold == null)
				{
					r_normal_gold = new(this, "normal_gold");
					r_normal_gold.SetBelong(this.instance);
				}
				return r_normal_gold;
			}
		}

		/// <summary>
		/// System.String normal_item
		/// </summary>
		protected RField r_normal_item;
		public virtual RField Rnormal_item
		{
			get
			{
				if(r_normal_item == null)
				{
					r_normal_item = new(this, "normal_item");
					r_normal_item.SetBelong(this.instance);
				}
				return r_normal_item;
			}
		}

		/// <summary>
		/// System.String perfect_equip
		/// </summary>
		protected RField r_perfect_equip;
		public virtual RField Rperfect_equip
		{
			get
			{
				if(r_perfect_equip == null)
				{
					r_perfect_equip = new(this, "perfect_equip");
					r_perfect_equip.SetBelong(this.instance);
				}
				return r_perfect_equip;
			}
		}

		/// <summary>
		/// System.String perfect_gold
		/// </summary>
		protected RField r_perfect_gold;
		public virtual RField Rperfect_gold
		{
			get
			{
				if(r_perfect_gold == null)
				{
					r_perfect_gold = new(this, "perfect_gold");
					r_perfect_gold.SetBelong(this.instance);
				}
				return r_perfect_gold;
			}
		}

		/// <summary>
		/// System.String perfect_item
		/// </summary>
		protected RField r_perfect_item;
		public virtual RField Rperfect_item
		{
			get
			{
				if(r_perfect_item == null)
				{
					r_perfect_item = new(this, "perfect_item");
					r_perfect_item.SetBelong(this.instance);
				}
				return r_perfect_item;
			}
		}

		/// <summary>
		/// System.String series_desc
		/// </summary>
		protected RField r_series_desc;
		public virtual RField Rseries_desc
		{
			get
			{
				if(r_series_desc == null)
				{
					r_series_desc = new(this, "series_desc");
					r_series_desc.SetBelong(this.instance);
				}
				return r_series_desc;
			}
		}

		/// <summary>
		/// System.Boolean bNormalPass
		/// </summary>
		protected RField r_bNormalPass;
		public virtual RField RbNormalPass
		{
			get
			{
				if(r_bNormalPass == null)
				{
					r_bNormalPass = new(this, "bNormalPass");
					r_bNormalPass.SetBelong(this.instance);
				}
				return r_bNormalPass;
			}
		}

		/// <summary>
		/// System.Boolean bPerfectPass
		/// </summary>
		protected RField r_bPerfectPass;
		public virtual RField RbPerfectPass
		{
			get
			{
				if(r_bPerfectPass == null)
				{
					r_bPerfectPass = new(this, "bPerfectPass");
					r_bPerfectPass.SetBelong(this.instance);
				}
				return r_bPerfectPass;
			}
		}

		/// <summary>
		/// System.Boolean bNormalRewarded
		/// </summary>
		protected RField r_bNormalRewarded;
		public virtual RField RbNormalRewarded
		{
			get
			{
				if(r_bNormalRewarded == null)
				{
					r_bNormalRewarded = new(this, "bNormalRewarded");
					r_bNormalRewarded.SetBelong(this.instance);
				}
				return r_bNormalRewarded;
			}
		}

		/// <summary>
		/// System.Boolean bPerfectRewarded
		/// </summary>
		protected RField r_bPerfectRewarded;
		public virtual RField RbPerfectRewarded
		{
			get
			{
				if(r_bPerfectRewarded == null)
				{
					r_bPerfectRewarded = new(this, "bPerfectRewarded");
					r_bPerfectRewarded.SetBelong(this.instance);
				}
				return r_bPerfectRewarded;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] raidList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_raidList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RraidList
		{
			get
			{
				if(r_raidList == null)
				{
					r_raidList = new(this, "raidList");
					r_raidList.SetBelong(this.instance);
				}
				return r_raidList;
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


        public RRAID_SERIES_INFO() : base("RAID_SERIES_INFO")
        {
        }

        public RRAID_SERIES_INFO(System.Object instance) : base("RAID_SERIES_INFO")
		{
            SetInstance(instance);
		}

        public RRAID_SERIES_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRAID_SERIES_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
