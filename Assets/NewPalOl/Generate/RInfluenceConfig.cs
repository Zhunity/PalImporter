using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// InfluenceConfig
	/// </summary>
    public partial class RInfluenceConfig : RMember //
    {

		/// <summary>
		/// System.String DEFAULT_ICON_URL
		/// </summary>
		protected static RField r_DEFAULT_ICON_URL;
		public static RField RDEFAULT_ICON_URL
		{
			get
			{
				if(r_DEFAULT_ICON_URL == null)
				{
					r_DEFAULT_ICON_URL = new(typeof(InfluenceConfig), "DEFAULT_ICON_URL");
					r_DEFAULT_ICON_URL.SetBelong(null);
				}
				return r_DEFAULT_ICON_URL;
			}
		}

		/// <summary>
		/// System.String camp_id
		/// </summary>
		protected RField r_camp_id;
		public virtual RField Rcamp_id
		{
			get
			{
				if(r_camp_id == null)
				{
					r_camp_id = new(this, "camp_id");
					r_camp_id.SetBelong(this.instance);
				}
				return r_camp_id;
			}
		}

		/// <summary>
		/// System.String camp_name
		/// </summary>
		protected RField r_camp_name;
		public virtual RField Rcamp_name
		{
			get
			{
				if(r_camp_name == null)
				{
					r_camp_name = new(this, "camp_name");
					r_camp_name.SetBelong(this.instance);
				}
				return r_camp_name;
			}
		}

		/// <summary>
		/// System.String belong_area
		/// </summary>
		protected RField r_belong_area;
		public virtual RField Rbelong_area
		{
			get
			{
				if(r_belong_area == null)
				{
					r_belong_area = new(this, "belong_area");
					r_belong_area.SetBelong(this.instance);
				}
				return r_belong_area;
			}
		}

		/// <summary>
		/// InfluenceConfig+CAMP_EXP_LEVEL default_relation
		/// </summary>
		protected RField r_default_relation;
		public virtual RField Rdefault_relation
		{
			get
			{
				if(r_default_relation == null)
				{
					r_default_relation = new(this, "default_relation");
					r_default_relation.SetBelong(this.instance);
				}
				return r_default_relation;
			}
		}

		/// <summary>
		/// System.String[] warring_groups
		/// </summary>
		protected RFieldArray<RField> r_warring_groups;
		public virtual RFieldArray<RField> Rwarring_groups
		{
			get
			{
				if(r_warring_groups == null)
				{
					r_warring_groups = new(this, "warring_groups");
					r_warring_groups.SetBelong(this.instance);
				}
				return r_warring_groups;
			}
		}

		/// <summary>
		/// System.String[] league_groups
		/// </summary>
		protected RFieldArray<RField> r_league_groups;
		public virtual RFieldArray<RField> Rleague_groups
		{
			get
			{
				if(r_league_groups == null)
				{
					r_league_groups = new(this, "league_groups");
					r_league_groups.SetBelong(this.instance);
				}
				return r_league_groups;
			}
		}

		/// <summary>
		/// System.String introduction
		/// </summary>
		protected RField r_introduction;
		public virtual RField Rintroduction
		{
			get
			{
				if(r_introduction == null)
				{
					r_introduction = new(this, "introduction");
					r_introduction.SetBelong(this.instance);
				}
				return r_introduction;
			}
		}

		/// <summary>
		/// System.String icon
		/// </summary>
		protected RField r_icon;
		public virtual RField Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon");
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// System.String IconUrl
		/// </summary>
		protected RProperty r_IconUrl;
		public virtual RProperty RIconUrl
		{
			get
			{
				if(r_IconUrl == null)
				{
					r_IconUrl = new(this, "IconUrl", -1);
					r_IconUrl.SetBelong(this.instance);
				}
				return r_IconUrl;
			}
		}

		/// <summary>
		/// Int32[] GetWarringIDs()
		/// </summary>
		protected RMethod r_RGetWarringIDs;
		public virtual RMethod RGetWarringIDs
		{
			get
			{
				if(r_RGetWarringIDs == null)
				{
					r_RGetWarringIDs = new(this, "GetWarringIDs", 0);
					r_RGetWarringIDs.SetBelong(this.instance);
				}
				return r_RGetWarringIDs;
			}
		}

		/// <summary>
		/// Int32[] GetLeagueIDs()
		/// </summary>
		protected RMethod r_RGetLeagueIDs;
		public virtual RMethod RGetLeagueIDs
		{
			get
			{
				if(r_RGetLeagueIDs == null)
				{
					r_RGetLeagueIDs = new(this, "GetLeagueIDs", 0);
					r_RGetLeagueIDs.SetBelong(this.instance);
				}
				return r_RGetLeagueIDs;
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


        public RInfluenceConfig() : base("InfluenceConfig")
        {
        }

        public RInfluenceConfig(System.Object instance) : base("InfluenceConfig")
		{
            SetInstance(instance);
		}

        public RInfluenceConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInfluenceConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32[] GetWarringIDs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWarringIDs.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetLeagueIDs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLeagueIDs.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
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
