using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// shenshouItem
	/// </summary>
    public partial class RshenshouItem : RMember //
    {

		/// <summary>
		/// System.String rune1
		/// </summary>
		protected RField r_rune1;
		public virtual RField Rrune1
		{
			get
			{
				if(r_rune1 == null)
				{
					r_rune1 = new(this, "rune1");
					r_rune1.SetBelong(this.instance);
				}
				return r_rune1;
			}
		}

		/// <summary>
		/// System.String rune2
		/// </summary>
		protected RField r_rune2;
		public virtual RField Rrune2
		{
			get
			{
				if(r_rune2 == null)
				{
					r_rune2 = new(this, "rune2");
					r_rune2.SetBelong(this.instance);
				}
				return r_rune2;
			}
		}

		/// <summary>
		/// System.String rune3
		/// </summary>
		protected RField r_rune3;
		public virtual RField Rrune3
		{
			get
			{
				if(r_rune3 == null)
				{
					r_rune3 = new(this, "rune3");
					r_rune3.SetBelong(this.instance);
				}
				return r_rune3;
			}
		}

		/// <summary>
		/// System.Int32 m_limit_level1
		/// </summary>
		protected RField r_m_limit_level1;
		public virtual RField Rm_limit_level1
		{
			get
			{
				if(r_m_limit_level1 == null)
				{
					r_m_limit_level1 = new(this, "m_limit_level1");
					r_m_limit_level1.SetBelong(this.instance);
				}
				return r_m_limit_level1;
			}
		}

		/// <summary>
		/// System.Int32 m_limit_level2
		/// </summary>
		protected RField r_m_limit_level2;
		public virtual RField Rm_limit_level2
		{
			get
			{
				if(r_m_limit_level2 == null)
				{
					r_m_limit_level2 = new(this, "m_limit_level2");
					r_m_limit_level2.SetBelong(this.instance);
				}
				return r_m_limit_level2;
			}
		}

		/// <summary>
		/// System.Int32 m_limit_level3
		/// </summary>
		protected RField r_m_limit_level3;
		public virtual RField Rm_limit_level3
		{
			get
			{
				if(r_m_limit_level3 == null)
				{
					r_m_limit_level3 = new(this, "m_limit_level3");
					r_m_limit_level3.SetBelong(this.instance);
				}
				return r_m_limit_level3;
			}
		}

		/// <summary>
		/// System.Int32 m_resourceID
		/// </summary>
		protected RField r_m_resourceID;
		public virtual RField Rm_resourceID
		{
			get
			{
				if(r_m_resourceID == null)
				{
					r_m_resourceID = new(this, "m_resourceID");
					r_m_resourceID.SetBelong(this.instance);
				}
				return r_m_resourceID;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected RField r_m_name;
		public virtual RField Rm_name
		{
			get
			{
				if(r_m_name == null)
				{
					r_m_name = new(this, "m_name");
					r_m_name.SetBelong(this.instance);
				}
				return r_m_name;
			}
		}

		/// <summary>
		/// System.String m_skillIcon
		/// </summary>
		protected RField r_m_skillIcon;
		public virtual RField Rm_skillIcon
		{
			get
			{
				if(r_m_skillIcon == null)
				{
					r_m_skillIcon = new(this, "m_skillIcon");
					r_m_skillIcon.SetBelong(this.instance);
				}
				return r_m_skillIcon;
			}
		}

		/// <summary>
		/// System.Int32 m_shenshouID
		/// </summary>
		protected RField r_m_shenshouID;
		public virtual RField Rm_shenshouID
		{
			get
			{
				if(r_m_shenshouID == null)
				{
					r_m_shenshouID = new(this, "m_shenshouID");
					r_m_shenshouID.SetBelong(this.instance);
				}
				return r_m_shenshouID;
			}
		}

		/// <summary>
		/// System.Int32 m_skill_id
		/// </summary>
		protected RField r_m_skill_id;
		public virtual RField Rm_skill_id
		{
			get
			{
				if(r_m_skill_id == null)
				{
					r_m_skill_id = new(this, "m_skill_id");
					r_m_skill_id.SetBelong(this.instance);
				}
				return r_m_skill_id;
			}
		}

		/// <summary>
		/// System.String m_skill_lv2
		/// </summary>
		protected RField r_m_skill_lv2;
		public virtual RField Rm_skill_lv2
		{
			get
			{
				if(r_m_skill_lv2 == null)
				{
					r_m_skill_lv2 = new(this, "m_skill_lv2");
					r_m_skill_lv2.SetBelong(this.instance);
				}
				return r_m_skill_lv2;
			}
		}

		/// <summary>
		/// System.String m_skill_lv3
		/// </summary>
		protected RField r_m_skill_lv3;
		public virtual RField Rm_skill_lv3
		{
			get
			{
				if(r_m_skill_lv3 == null)
				{
					r_m_skill_lv3 = new(this, "m_skill_lv3");
					r_m_skill_lv3.SetBelong(this.instance);
				}
				return r_m_skill_lv3;
			}
		}

		/// <summary>
		/// System.String m_skill_lv4
		/// </summary>
		protected RField r_m_skill_lv4;
		public virtual RField Rm_skill_lv4
		{
			get
			{
				if(r_m_skill_lv4 == null)
				{
					r_m_skill_lv4 = new(this, "m_skill_lv4");
					r_m_skill_lv4.SetBelong(this.instance);
				}
				return r_m_skill_lv4;
			}
		}

		/// <summary>
		/// System.String m_skill_lv5
		/// </summary>
		protected RField r_m_skill_lv5;
		public virtual RField Rm_skill_lv5
		{
			get
			{
				if(r_m_skill_lv5 == null)
				{
					r_m_skill_lv5 = new(this, "m_skill_lv5");
					r_m_skill_lv5.SetBelong(this.instance);
				}
				return r_m_skill_lv5;
			}
		}

		/// <summary>
		/// System.String m_skill_lv6
		/// </summary>
		protected RField r_m_skill_lv6;
		public virtual RField Rm_skill_lv6
		{
			get
			{
				if(r_m_skill_lv6 == null)
				{
					r_m_skill_lv6 = new(this, "m_skill_lv6");
					r_m_skill_lv6.SetBelong(this.instance);
				}
				return r_m_skill_lv6;
			}
		}

		/// <summary>
		/// System.String m_skill_lv7
		/// </summary>
		protected RField r_m_skill_lv7;
		public virtual RField Rm_skill_lv7
		{
			get
			{
				if(r_m_skill_lv7 == null)
				{
					r_m_skill_lv7 = new(this, "m_skill_lv7");
					r_m_skill_lv7.SetBelong(this.instance);
				}
				return r_m_skill_lv7;
			}
		}

		/// <summary>
		/// System.String m_skill_lv8
		/// </summary>
		protected RField r_m_skill_lv8;
		public virtual RField Rm_skill_lv8
		{
			get
			{
				if(r_m_skill_lv8 == null)
				{
					r_m_skill_lv8 = new(this, "m_skill_lv8");
					r_m_skill_lv8.SetBelong(this.instance);
				}
				return r_m_skill_lv8;
			}
		}

		/// <summary>
		/// System.String m_skill_lv9
		/// </summary>
		protected RField r_m_skill_lv9;
		public virtual RField Rm_skill_lv9
		{
			get
			{
				if(r_m_skill_lv9 == null)
				{
					r_m_skill_lv9 = new(this, "m_skill_lv9");
					r_m_skill_lv9.SetBelong(this.instance);
				}
				return r_m_skill_lv9;
			}
		}

		/// <summary>
		/// System.String m_skill_lv10
		/// </summary>
		protected RField r_m_skill_lv10;
		public virtual RField Rm_skill_lv10
		{
			get
			{
				if(r_m_skill_lv10 == null)
				{
					r_m_skill_lv10 = new(this, "m_skill_lv10");
					r_m_skill_lv10.SetBelong(this.instance);
				}
				return r_m_skill_lv10;
			}
		}

		/// <summary>
		/// System.String m_btn_position1
		/// </summary>
		protected RField r_m_btn_position1;
		public virtual RField Rm_btn_position1
		{
			get
			{
				if(r_m_btn_position1 == null)
				{
					r_m_btn_position1 = new(this, "m_btn_position1");
					r_m_btn_position1.SetBelong(this.instance);
				}
				return r_m_btn_position1;
			}
		}

		/// <summary>
		/// System.String m_btn_position2
		/// </summary>
		protected RField r_m_btn_position2;
		public virtual RField Rm_btn_position2
		{
			get
			{
				if(r_m_btn_position2 == null)
				{
					r_m_btn_position2 = new(this, "m_btn_position2");
					r_m_btn_position2.SetBelong(this.instance);
				}
				return r_m_btn_position2;
			}
		}

		/// <summary>
		/// System.String m_btn_position3
		/// </summary>
		protected RField r_m_btn_position3;
		public virtual RField Rm_btn_position3
		{
			get
			{
				if(r_m_btn_position3 == null)
				{
					r_m_btn_position3 = new(this, "m_btn_position3");
					r_m_btn_position3.SetBelong(this.instance);
				}
				return r_m_btn_position3;
			}
		}

		/// <summary>
		/// System.String m_btn_position4
		/// </summary>
		protected RField r_m_btn_position4;
		public virtual RField Rm_btn_position4
		{
			get
			{
				if(r_m_btn_position4 == null)
				{
					r_m_btn_position4 = new(this, "m_btn_position4");
					r_m_btn_position4.SetBelong(this.instance);
				}
				return r_m_btn_position4;
			}
		}

		/// <summary>
		/// System.String m_btn_position5
		/// </summary>
		protected RField r_m_btn_position5;
		public virtual RField Rm_btn_position5
		{
			get
			{
				if(r_m_btn_position5 == null)
				{
					r_m_btn_position5 = new(this, "m_btn_position5");
					r_m_btn_position5.SetBelong(this.instance);
				}
				return r_m_btn_position5;
			}
		}

		/// <summary>
		/// System.String m_btn_position6
		/// </summary>
		protected RField r_m_btn_position6;
		public virtual RField Rm_btn_position6
		{
			get
			{
				if(r_m_btn_position6 == null)
				{
					r_m_btn_position6 = new(this, "m_btn_position6");
					r_m_btn_position6.SetBelong(this.instance);
				}
				return r_m_btn_position6;
			}
		}

		/// <summary>
		/// System.String m_btn_position7
		/// </summary>
		protected RField r_m_btn_position7;
		public virtual RField Rm_btn_position7
		{
			get
			{
				if(r_m_btn_position7 == null)
				{
					r_m_btn_position7 = new(this, "m_btn_position7");
					r_m_btn_position7.SetBelong(this.instance);
				}
				return r_m_btn_position7;
			}
		}

		/// <summary>
		/// System.String m_label_Link1
		/// </summary>
		protected RField r_m_label_Link1;
		public virtual RField Rm_label_Link1
		{
			get
			{
				if(r_m_label_Link1 == null)
				{
					r_m_label_Link1 = new(this, "m_label_Link1");
					r_m_label_Link1.SetBelong(this.instance);
				}
				return r_m_label_Link1;
			}
		}

		/// <summary>
		/// System.String m_label_Link2
		/// </summary>
		protected RField r_m_label_Link2;
		public virtual RField Rm_label_Link2
		{
			get
			{
				if(r_m_label_Link2 == null)
				{
					r_m_label_Link2 = new(this, "m_label_Link2");
					r_m_label_Link2.SetBelong(this.instance);
				}
				return r_m_label_Link2;
			}
		}

		/// <summary>
		/// System.String m_label_Link3
		/// </summary>
		protected RField r_m_label_Link3;
		public virtual RField Rm_label_Link3
		{
			get
			{
				if(r_m_label_Link3 == null)
				{
					r_m_label_Link3 = new(this, "m_label_Link3");
					r_m_label_Link3.SetBelong(this.instance);
				}
				return r_m_label_Link3;
			}
		}

		/// <summary>
		/// System.String m_label_Link4
		/// </summary>
		protected RField r_m_label_Link4;
		public virtual RField Rm_label_Link4
		{
			get
			{
				if(r_m_label_Link4 == null)
				{
					r_m_label_Link4 = new(this, "m_label_Link4");
					r_m_label_Link4.SetBelong(this.instance);
				}
				return r_m_label_Link4;
			}
		}

		/// <summary>
		/// System.String m_label_Link5
		/// </summary>
		protected RField r_m_label_Link5;
		public virtual RField Rm_label_Link5
		{
			get
			{
				if(r_m_label_Link5 == null)
				{
					r_m_label_Link5 = new(this, "m_label_Link5");
					r_m_label_Link5.SetBelong(this.instance);
				}
				return r_m_label_Link5;
			}
		}

		/// <summary>
		/// System.String m_label_Link6
		/// </summary>
		protected RField r_m_label_Link6;
		public virtual RField Rm_label_Link6
		{
			get
			{
				if(r_m_label_Link6 == null)
				{
					r_m_label_Link6 = new(this, "m_label_Link6");
					r_m_label_Link6.SetBelong(this.instance);
				}
				return r_m_label_Link6;
			}
		}

		/// <summary>
		/// System.Int32 active_item
		/// </summary>
		protected RField r_active_item;
		public virtual RField Ractive_item
		{
			get
			{
				if(r_active_item == null)
				{
					r_active_item = new(this, "active_item");
					r_active_item.SetBelong(this.instance);
				}
				return r_active_item;
			}
		}

		/// <summary>
		/// System.Int32 active_num
		/// </summary>
		protected RField r_active_num;
		public virtual RField Ractive_num
		{
			get
			{
				if(r_active_num == null)
				{
					r_active_num = new(this, "active_num");
					r_active_num.SetBelong(this.instance);
				}
				return r_active_num;
			}
		}

		/// <summary>
		/// Int32 runewords
		/// </summary>
		protected RProperty r_runewords;
		public virtual RProperty Rrunewords
		{
			get
			{
				if(r_runewords == null)
				{
					r_runewords = new(this, "runewords", -1);
					r_runewords.SetBelong(this.instance);
				}
				return r_runewords;
			}
		}

		/// <summary>
		/// Int32 #Onl(System.String)
		/// </summary>
		protected RMethod r_R__0__Onl_String;
		public virtual RMethod R__0__Onl_String
		{
			get
			{
				if(r_R__0__Onl_String == null)
				{
					r_R__0__Onl_String = new(this, "#Onl", 0, typeof(System.String));
					r_R__0__Onl_String.SetBelong(this.instance);
				}
				return r_R__0__Onl_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetBtnPosition(Int32)
		/// </summary>
		protected RMethod r_RGetBtnPosition_Int32;
		public virtual RMethod RGetBtnPosition_Int32
		{
			get
			{
				if(r_RGetBtnPosition_Int32 == null)
				{
					r_RGetBtnPosition_Int32 = new(this, "GetBtnPosition", 0, typeof(System.Int32));
					r_RGetBtnPosition_Int32.SetBelong(this.instance);
				}
				return r_RGetBtnPosition_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetLabelRect(Int32)
		/// </summary>
		protected RMethod r_RGetLabelRect_Int32;
		public virtual RMethod RGetLabelRect_Int32
		{
			get
			{
				if(r_RGetLabelRect_Int32 == null)
				{
					r_RGetLabelRect_Int32 = new(this, "GetLabelRect", 0, typeof(System.Int32));
					r_RGetLabelRect_Int32.SetBelong(this.instance);
				}
				return r_RGetLabelRect_Int32;
			}
		}

		/// <summary>
		/// Single GetLabelRotation(Int32)
		/// </summary>
		protected RMethod r_RGetLabelRotation_Int32;
		public virtual RMethod RGetLabelRotation_Int32
		{
			get
			{
				if(r_RGetLabelRotation_Int32 == null)
				{
					r_RGetLabelRotation_Int32 = new(this, "GetLabelRotation", 0, typeof(System.Int32));
					r_RGetLabelRotation_Int32.SetBelong(this.instance);
				}
				return r_RGetLabelRotation_Int32;
			}
		}

		/// <summary>
		/// System.String GetSkillLvNeed(Int32)
		/// </summary>
		protected RMethod r_RGetSkillLvNeed_Int32;
		public virtual RMethod RGetSkillLvNeed_Int32
		{
			get
			{
				if(r_RGetSkillLvNeed_Int32 == null)
				{
					r_RGetSkillLvNeed_Int32 = new(this, "GetSkillLvNeed", 0, typeof(System.Int32));
					r_RGetSkillLvNeed_Int32.SetBelong(this.instance);
				}
				return r_RGetSkillLvNeed_Int32;
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


        public RshenshouItem() : base("shenshouItem")
        {
        }

        public RshenshouItem(System.Object instance) : base("shenshouItem")
		{
            SetInstance(instance);
		}

        public RshenshouItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RshenshouItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 __0__Onl(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__Onl_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector2 GetBtnPosition(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetBtnPosition_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Rect GetLabelRect(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetLabelRect_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Single GetLabelRotation(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetLabelRotation_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.String GetSkillLvNeed(System.Int32  @skillLv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillLv};
            var ___result = RGetSkillLvNeed_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
