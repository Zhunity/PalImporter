using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RuneItem
	/// </summary>
    public partial class RRuneItem : RMember //
    {

		/// <summary>
		/// System.Int32 runeID
		/// </summary>
		protected RField r_runeID;
		public virtual RField RruneID
		{
			get
			{
				if(r_runeID == null)
				{
					r_runeID = new(this, "runeID");
					r_runeID.SetBelong(this.instance);
				}
				return r_runeID;
			}
		}

		/// <summary>
		/// System.String armor_add
		/// </summary>
		protected RField r_armor_add;
		public virtual RField Rarmor_add
		{
			get
			{
				if(r_armor_add == null)
				{
					r_armor_add = new(this, "armor_add");
					r_armor_add.SetBelong(this.instance);
				}
				return r_armor_add;
			}
		}

		/// <summary>
		/// System.String attack_add
		/// </summary>
		protected RField r_attack_add;
		public virtual RField Rattack_add
		{
			get
			{
				if(r_attack_add == null)
				{
					r_attack_add = new(this, "attack_add");
					r_attack_add.SetBelong(this.instance);
				}
				return r_attack_add;
			}
		}

		/// <summary>
		/// System.String hp_add
		/// </summary>
		protected RField r_hp_add;
		public virtual RField Rhp_add
		{
			get
			{
				if(r_hp_add == null)
				{
					r_hp_add = new(this, "hp_add");
					r_hp_add.SetBelong(this.instance);
				}
				return r_hp_add;
			}
		}

		/// <summary>
		/// System.Int32 need_matrix_lv
		/// </summary>
		protected RField r_need_matrix_lv;
		public virtual RField Rneed_matrix_lv
		{
			get
			{
				if(r_need_matrix_lv == null)
				{
					r_need_matrix_lv = new(this, "need_matrix_lv");
					r_need_matrix_lv.SetBelong(this.instance);
				}
				return r_need_matrix_lv;
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
		/// System.String needitem
		/// </summary>
		protected RField r_needitem;
		public virtual RField Rneeditem
		{
			get
			{
				if(r_needitem == null)
				{
					r_needitem = new(this, "needitem");
					r_needitem.SetBelong(this.instance);
				}
				return r_needitem;
			}
		}

		/// <summary>
		/// System.String devil_desc
		/// </summary>
		protected RField r_devil_desc;
		public virtual RField Rdevil_desc
		{
			get
			{
				if(r_devil_desc == null)
				{
					r_devil_desc = new(this, "devil_desc");
					r_devil_desc.SetBelong(this.instance);
				}
				return r_devil_desc;
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


        public RRuneItem() : base("RuneItem")
        {
        }

        public RRuneItem(System.Object instance) : base("RuneItem")
		{
            SetInstance(instance);
		}

        public RRuneItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuneItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
