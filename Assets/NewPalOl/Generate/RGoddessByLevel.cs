using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// GoddessByLevel
	/// </summary>
    public partial class RGoddessByLevel : RMember //
    {

		/// <summary>
		/// System.Int32 level
		/// </summary>
		protected RField r_level;
		public virtual RField Rlevel
		{
			get
			{
				if(r_level == null)
				{
					r_level = new(this, "level");
					r_level.SetBelong(this.instance);
				}
				return r_level;
			}
		}

		/// <summary>
		/// System.Int32 lingshiNeed
		/// </summary>
		protected RField r_lingshiNeed;
		public virtual RField RlingshiNeed
		{
			get
			{
				if(r_lingshiNeed == null)
				{
					r_lingshiNeed = new(this, "lingshiNeed");
					r_lingshiNeed.SetBelong(this.instance);
				}
				return r_lingshiNeed;
			}
		}

		/// <summary>
		/// System.Int32 exp_Acc
		/// </summary>
		protected RField r_exp_Acc;
		public virtual RField Rexp_Acc
		{
			get
			{
				if(r_exp_Acc == null)
				{
					r_exp_Acc = new(this, "exp_Acc");
					r_exp_Acc.SetBelong(this.instance);
				}
				return r_exp_Acc;
			}
		}

		/// <summary>
		/// System.Int32 exp_Upgrade
		/// </summary>
		protected RField r_exp_Upgrade;
		public virtual RField Rexp_Upgrade
		{
			get
			{
				if(r_exp_Upgrade == null)
				{
					r_exp_Upgrade = new(this, "exp_Upgrade");
					r_exp_Upgrade.SetBelong(this.instance);
				}
				return r_exp_Upgrade;
			}
		}

		/// <summary>
		/// System.Int32 skill_id
		/// </summary>
		protected RField r_skill_id;
		public virtual RField Rskill_id
		{
			get
			{
				if(r_skill_id == null)
				{
					r_skill_id = new(this, "skill_id");
					r_skill_id.SetBelong(this.instance);
				}
				return r_skill_id;
			}
		}

		/// <summary>
		/// System.Int32 skill_lvl
		/// </summary>
		protected RField r_skill_lvl;
		public virtual RField Rskill_lvl
		{
			get
			{
				if(r_skill_lvl == null)
				{
					r_skill_lvl = new(this, "skill_lvl");
					r_skill_lvl.SetBelong(this.instance);
				}
				return r_skill_lvl;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] attr
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_attr;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rattr
		{
			get
			{
				if(r_attr == null)
				{
					r_attr = new(this, "attr");
					r_attr.SetBelong(this.instance);
				}
				return r_attr;
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
		/// System.String res_icon
		/// </summary>
		protected RField r_res_icon;
		public virtual RField Rres_icon
		{
			get
			{
				if(r_res_icon == null)
				{
					r_res_icon = new(this, "res_icon");
					r_res_icon.SetBelong(this.instance);
				}
				return r_res_icon;
			}
		}

		/// <summary>
		/// System.String res_bigIcon
		/// </summary>
		protected RField r_res_bigIcon;
		public virtual RField Rres_bigIcon
		{
			get
			{
				if(r_res_bigIcon == null)
				{
					r_res_bigIcon = new(this, "res_bigIcon");
					r_res_bigIcon.SetBelong(this.instance);
				}
				return r_res_bigIcon;
			}
		}

		/// <summary>
		/// System.String res_name
		/// </summary>
		protected RField r_res_name;
		public virtual RField Rres_name
		{
			get
			{
				if(r_res_name == null)
				{
					r_res_name = new(this, "res_name");
					r_res_name.SetBelong(this.instance);
				}
				return r_res_name;
			}
		}

		/// <summary>
		/// System.String res_skillIcon
		/// </summary>
		protected RField r_res_skillIcon;
		public virtual RField Rres_skillIcon
		{
			get
			{
				if(r_res_skillIcon == null)
				{
					r_res_skillIcon = new(this, "res_skillIcon");
					r_res_skillIcon.SetBelong(this.instance);
				}
				return r_res_skillIcon;
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


        public RGoddessByLevel() : base("GoddessByLevel")
        {
        }

        public RGoddessByLevel(System.Object instance) : base("GoddessByLevel")
		{
            SetInstance(instance);
		}

        public RGoddessByLevel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGoddessByLevel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
