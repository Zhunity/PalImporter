using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SKILL_CFG
	/// </summary>
    public partial class RSKILL_CFG : RMember //
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
		/// System.String description
		/// </summary>
		protected RField r_description;
		public virtual RField Rdescription
		{
			get
			{
				if(r_description == null)
				{
					r_description = new(this, "description");
					r_description.SetBelong(this.instance);
				}
				return r_description;
			}
		}

		/// <summary>
		/// System.String property
		/// </summary>
		protected RField r_property;
		public virtual RField Rproperty
		{
			get
			{
				if(r_property == null)
				{
					r_property = new(this, "property");
					r_property.SetBelong(this.instance);
				}
				return r_property;
			}
		}

		/// <summary>
		/// System.String origin_desc
		/// </summary>
		protected RField r_origin_desc;
		public virtual RField Rorigin_desc
		{
			get
			{
				if(r_origin_desc == null)
				{
					r_origin_desc = new(this, "origin_desc");
					r_origin_desc.SetBelong(this.instance);
				}
				return r_origin_desc;
			}
		}

		/// <summary>
		/// System.String target_icon
		/// </summary>
		protected RField r_target_icon;
		public virtual RField Rtarget_icon
		{
			get
			{
				if(r_target_icon == null)
				{
					r_target_icon = new(this, "target_icon");
					r_target_icon.SetBelong(this.instance);
				}
				return r_target_icon;
			}
		}

		/// <summary>
		/// eSkillType type
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
		/// System.Int32 limit_level
		/// </summary>
		protected RField r_limit_level;
		public virtual RField Rlimit_level
		{
			get
			{
				if(r_limit_level == null)
				{
					r_limit_level = new(this, "limit_level");
					r_limit_level.SetBelong(this.instance);
				}
				return r_limit_level;
			}
		}

		/// <summary>
		/// System.String qtedesc
		/// </summary>
		protected RField r_qtedesc;
		public virtual RField Rqtedesc
		{
			get
			{
				if(r_qtedesc == null)
				{
					r_qtedesc = new(this, "qtedesc");
					r_qtedesc.SetBelong(this.instance);
				}
				return r_qtedesc;
			}
		}

		/// <summary>
		/// System.Int32 ws_nq
		/// </summary>
		protected RField r_ws_nq;
		public virtual RField Rws_nq
		{
			get
			{
				if(r_ws_nq == null)
				{
					r_ws_nq = new(this, "ws_nq");
					r_ws_nq.SetBelong(this.instance);
				}
				return r_ws_nq;
			}
		}

		/// <summary>
		/// System.String ws_nqdesc
		/// </summary>
		protected RField r_ws_nqdesc;
		public virtual RField Rws_nqdesc
		{
			get
			{
				if(r_ws_nqdesc == null)
				{
					r_ws_nqdesc = new(this, "ws_nqdesc");
					r_ws_nqdesc.SetBelong(this.instance);
				}
				return r_ws_nqdesc;
			}
		}

		/// <summary>
		/// System.String ws_qte
		/// </summary>
		protected RField r_ws_qte;
		public virtual RField Rws_qte
		{
			get
			{
				if(r_ws_qte == null)
				{
					r_ws_qte = new(this, "ws_qte");
					r_ws_qte.SetBelong(this.instance);
				}
				return r_ws_qte;
			}
		}

		/// <summary>
		/// System.Int32 qte_icon
		/// </summary>
		protected RField r_qte_icon;
		public virtual RField Rqte_icon
		{
			get
			{
				if(r_qte_icon == null)
				{
					r_qte_icon = new(this, "qte_icon");
					r_qte_icon.SetBelong(this.instance);
				}
				return r_qte_icon;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] need_level
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_need_level;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rneed_level
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
		/// System.Collections.Generic.List`1[System.Int32] need_lingli
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_need_lingli;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rneed_lingli
		{
			get
			{
				if(r_need_lingli == null)
				{
					r_need_lingli = new(this, "need_lingli");
					r_need_lingli.SetBelong(this.instance);
				}
				return r_need_lingli;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] need_cd
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_need_cd;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rneed_cd
		{
			get
			{
				if(r_need_cd == null)
				{
					r_need_cd = new(this, "need_cd");
					r_need_cd.SetBelong(this.instance);
				}
				return r_need_cd;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] need_exp
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_need_exp;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rneed_exp
		{
			get
			{
				if(r_need_exp == null)
				{
					r_need_exp = new(this, "need_exp");
					r_need_exp.SetBelong(this.instance);
				}
				return r_need_exp;
			}
		}

		/// <summary>
		/// System.Int32 gezi
		/// </summary>
		protected RField r_gezi;
		public virtual RField Rgezi
		{
			get
			{
				if(r_gezi == null)
				{
					r_gezi = new(this, "gezi");
					r_gezi.SetBelong(this.instance);
				}
				return r_gezi;
			}
		}

		/// <summary>
		/// System.Int32 costitem
		/// </summary>
		protected RField r_costitem;
		public virtual RField Rcostitem
		{
			get
			{
				if(r_costitem == null)
				{
					r_costitem = new(this, "costitem");
					r_costitem.SetBelong(this.instance);
				}
				return r_costitem;
			}
		}

		/// <summary>
		/// GameDefineType.ID SkillID
		/// </summary>
		protected RGameDefineType.RID r_SkillID;
		public virtual RGameDefineType.RID RSkillID
		{
			get
			{
				if(r_SkillID == null)
				{
					r_SkillID = new(this, "SkillID", -1);
					r_SkillID.SetBelong(this.instance);
				}
				return r_SkillID;
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


        public RSKILL_CFG() : base("SKILL_CFG")
        {
        }

        public RSKILL_CFG(System.Object instance) : base("SKILL_CFG")
		{
            SetInstance(instance);
		}

        public RSKILL_CFG(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSKILL_CFG(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
