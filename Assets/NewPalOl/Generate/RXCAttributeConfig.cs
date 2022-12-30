using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// XCAttributeConfig
	/// </summary>
    public partial class RXCAttributeConfig : RMember //
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
		/// System.Int32 lv
		/// </summary>
		protected RField r_lv;
		public virtual RField Rlv
		{
			get
			{
				if(r_lv == null)
				{
					r_lv = new(this, "lv");
					r_lv.SetBelong(this.instance);
				}
				return r_lv;
			}
		}

		/// <summary>
		/// System.Int32 star
		/// </summary>
		protected RField r_star;
		public virtual RField Rstar
		{
			get
			{
				if(r_star == null)
				{
					r_star = new(this, "star");
					r_star.SetBelong(this.instance);
				}
				return r_star;
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
		/// System.Int32 hp
		/// </summary>
		protected RField r_hp;
		public virtual RField Rhp
		{
			get
			{
				if(r_hp == null)
				{
					r_hp = new(this, "hp");
					r_hp.SetBelong(this.instance);
				}
				return r_hp;
			}
		}

		/// <summary>
		/// System.Int32 atk
		/// </summary>
		protected RField r_atk;
		public virtual RField Ratk
		{
			get
			{
				if(r_atk == null)
				{
					r_atk = new(this, "atk");
					r_atk.SetBelong(this.instance);
				}
				return r_atk;
			}
		}

		/// <summary>
		/// System.Int32 arm
		/// </summary>
		protected RField r_arm;
		public virtual RField Rarm
		{
			get
			{
				if(r_arm == null)
				{
					r_arm = new(this, "arm");
					r_arm.SetBelong(this.instance);
				}
				return r_arm;
			}
		}

		/// <summary>
		/// System.Int32 block
		/// </summary>
		protected RField r_block;
		public virtual RField Rblock
		{
			get
			{
				if(r_block == null)
				{
					r_block = new(this, "block");
					r_block.SetBelong(this.instance);
				}
				return r_block;
			}
		}

		/// <summary>
		/// System.Int32 accurate
		/// </summary>
		protected RField r_accurate;
		public virtual RField Raccurate
		{
			get
			{
				if(r_accurate == null)
				{
					r_accurate = new(this, "accurate");
					r_accurate.SetBelong(this.instance);
				}
				return r_accurate;
			}
		}

		/// <summary>
		/// System.Int32 critical
		/// </summary>
		protected RField r_critical;
		public virtual RField Rcritical
		{
			get
			{
				if(r_critical == null)
				{
					r_critical = new(this, "critical");
					r_critical.SetBelong(this.instance);
				}
				return r_critical;
			}
		}

		/// <summary>
		/// System.Int32 dodge
		/// </summary>
		protected RField r_dodge;
		public virtual RField Rdodge
		{
			get
			{
				if(r_dodge == null)
				{
					r_dodge = new(this, "dodge");
					r_dodge.SetBelong(this.instance);
				}
				return r_dodge;
			}
		}

		/// <summary>
		/// System.Int32 wreck
		/// </summary>
		protected RField r_wreck;
		public virtual RField Rwreck
		{
			get
			{
				if(r_wreck == null)
				{
					r_wreck = new(this, "wreck");
					r_wreck.SetBelong(this.instance);
				}
				return r_wreck;
			}
		}

		/// <summary>
		/// System.Int32 tough
		/// </summary>
		protected RField r_tough;
		public virtual RField Rtough
		{
			get
			{
				if(r_tough == null)
				{
					r_tough = new(this, "tough");
					r_tough.SetBelong(this.instance);
				}
				return r_tough;
			}
		}

		/// <summary>
		/// System.Int32 equipid
		/// </summary>
		protected RField r_equipid;
		public virtual RField Requipid
		{
			get
			{
				if(r_equipid == null)
				{
					r_equipid = new(this, "equipid");
					r_equipid.SetBelong(this.instance);
				}
				return r_equipid;
			}
		}

		/// <summary>
		/// System.Int32 exp
		/// </summary>
		protected RField r_exp;
		public virtual RField Rexp
		{
			get
			{
				if(r_exp == null)
				{
					r_exp = new(this, "exp");
					r_exp.SetBelong(this.instance);
				}
				return r_exp;
			}
		}

		/// <summary>
		/// System.Int32 buffid
		/// </summary>
		protected RField r_buffid;
		public virtual RField Rbuffid
		{
			get
			{
				if(r_buffid == null)
				{
					r_buffid = new(this, "buffid");
					r_buffid.SetBelong(this.instance);
				}
				return r_buffid;
			}
		}

		/// <summary>
		/// System.String bufftips
		/// </summary>
		protected RField r_bufftips;
		public virtual RField Rbufftips
		{
			get
			{
				if(r_bufftips == null)
				{
					r_bufftips = new(this, "bufftips");
					r_bufftips.SetBelong(this.instance);
				}
				return r_bufftips;
			}
		}

		/// <summary>
		/// System.String tips
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
		/// System.Int32 speid
		/// </summary>
		protected RField r_speid;
		public virtual RField Rspeid
		{
			get
			{
				if(r_speid == null)
				{
					r_speid = new(this, "speid");
					r_speid.SetBelong(this.instance);
				}
				return r_speid;
			}
		}

		/// <summary>
		/// System.Int32 spevalue
		/// </summary>
		protected RField r_spevalue;
		public virtual RField Rspevalue
		{
			get
			{
				if(r_spevalue == null)
				{
					r_spevalue = new(this, "spevalue");
					r_spevalue.SetBelong(this.instance);
				}
				return r_spevalue;
			}
		}

		/// <summary>
		/// System.String freeitem
		/// </summary>
		protected RField r_freeitem;
		public virtual RField Rfreeitem
		{
			get
			{
				if(r_freeitem == null)
				{
					r_freeitem = new(this, "freeitem");
					r_freeitem.SetBelong(this.instance);
				}
				return r_freeitem;
			}
		}

		/// <summary>
		/// System.Int32 evoid
		/// </summary>
		protected RField r_evoid;
		public virtual RField Revoid
		{
			get
			{
				if(r_evoid == null)
				{
					r_evoid = new(this, "evoid");
					r_evoid.SetBelong(this.instance);
				}
				return r_evoid;
			}
		}

		/// <summary>
		/// System.Int32 resourceid
		/// </summary>
		protected RField r_resourceid;
		public virtual RField Rresourceid
		{
			get
			{
				if(r_resourceid == null)
				{
					r_resourceid = new(this, "resourceid");
					r_resourceid.SetBelong(this.instance);
				}
				return r_resourceid;
			}
		}

		/// <summary>
		/// System.Int32 evoexp
		/// </summary>
		protected RField r_evoexp;
		public virtual RField Revoexp
		{
			get
			{
				if(r_evoexp == null)
				{
					r_evoexp = new(this, "evoexp");
					r_evoexp.SetBelong(this.instance);
				}
				return r_evoexp;
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


        public RXCAttributeConfig() : base("XCAttributeConfig")
        {
        }

        public RXCAttributeConfig(System.Object instance) : base("XCAttributeConfig")
		{
            SetInstance(instance);
		}

        public RXCAttributeConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXCAttributeConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
