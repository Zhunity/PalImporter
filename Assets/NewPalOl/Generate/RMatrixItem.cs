using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MatrixItem
	/// </summary>
    public partial class RMatrixItem : RMember //
    {

		/// <summary>
		/// System.Int32 matrixID
		/// </summary>
		protected RField r_matrixID;
		public virtual RField RmatrixID
		{
			get
			{
				if(r_matrixID == null)
				{
					r_matrixID = new(this, "matrixID");
					r_matrixID.SetBelong(this.instance);
				}
				return r_matrixID;
			}
		}

		/// <summary>
		/// System.Int32 fighter_Count
		/// </summary>
		protected RField r_fighter_Count;
		public virtual RField Rfighter_Count
		{
			get
			{
				if(r_fighter_Count == null)
				{
					r_fighter_Count = new(this, "fighter_Count");
					r_fighter_Count.SetBelong(this.instance);
				}
				return r_fighter_Count;
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
		/// System.Int32 nag_rune
		/// </summary>
		protected RField r_nag_rune;
		public virtual RField Rnag_rune
		{
			get
			{
				if(r_nag_rune == null)
				{
					r_nag_rune = new(this, "nag_rune");
					r_nag_rune.SetBelong(this.instance);
				}
				return r_nag_rune;
			}
		}

		/// <summary>
		/// System.Int32 need_linli
		/// </summary>
		protected RField r_need_linli;
		public virtual RField Rneed_linli
		{
			get
			{
				if(r_need_linli == null)
				{
					r_need_linli = new(this, "need_linli");
					r_need_linli.SetBelong(this.instance);
				}
				return r_need_linli;
			}
		}

		/// <summary>
		/// System.Int32 need_player_lv
		/// </summary>
		protected RField r_need_player_lv;
		public virtual RField Rneed_player_lv
		{
			get
			{
				if(r_need_player_lv == null)
				{
					r_need_player_lv = new(this, "need_player_lv");
					r_need_player_lv.SetBelong(this.instance);
				}
				return r_need_player_lv;
			}
		}

		/// <summary>
		/// System.Int32 rune_num
		/// </summary>
		protected RField r_rune_num;
		public virtual RField Rrune_num
		{
			get
			{
				if(r_rune_num == null)
				{
					r_rune_num = new(this, "rune_num");
					r_rune_num.SetBelong(this.instance);
				}
				return r_rune_num;
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


        public RMatrixItem() : base("MatrixItem")
        {
        }

        public RMatrixItem(System.Object instance) : base("MatrixItem")
		{
            SetInstance(instance);
		}

        public RMatrixItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatrixItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
