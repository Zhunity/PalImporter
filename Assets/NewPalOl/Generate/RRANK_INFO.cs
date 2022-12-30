using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RANK_INFO
	/// </summary>
    public partial class RRANK_INFO : RMember //
    {

		/// <summary>
		/// System.String type
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
		/// System.String category
		/// </summary>
		protected RField r_category;
		public virtual RField Rcategory
		{
			get
			{
				if(r_category == null)
				{
					r_category = new(this, "category");
					r_category.SetBelong(this.instance);
				}
				return r_category;
			}
		}

		/// <summary>
		/// System.String desc
		/// </summary>
		protected RField r_desc;
		public virtual RField Rdesc
		{
			get
			{
				if(r_desc == null)
				{
					r_desc = new(this, "desc");
					r_desc.SetBelong(this.instance);
				}
				return r_desc;
			}
		}

		/// <summary>
		/// System.String reward
		/// </summary>
		protected RField r_reward;
		public virtual RField Rreward
		{
			get
			{
				if(r_reward == null)
				{
					r_reward = new(this, "reward");
					r_reward.SetBelong(this.instance);
				}
				return r_reward;
			}
		}

		/// <summary>
		/// System.Int32 sortby
		/// </summary>
		protected RField r_sortby;
		public virtual RField Rsortby
		{
			get
			{
				if(r_sortby == null)
				{
					r_sortby = new(this, "sortby");
					r_sortby.SetBelong(this.instance);
				}
				return r_sortby;
			}
		}

		/// <summary>
		/// System.Int32 tribe
		/// </summary>
		protected RField r_tribe;
		public virtual RField Rtribe
		{
			get
			{
				if(r_tribe == null)
				{
					r_tribe = new(this, "tribe");
					r_tribe.SetBelong(this.instance);
				}
				return r_tribe;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] columns
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_columns;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rcolumns
		{
			get
			{
				if(r_columns == null)
				{
					r_columns = new(this, "columns");
					r_columns.SetBelong(this.instance);
				}
				return r_columns;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] width
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_width;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
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


        public RRANK_INFO() : base("RANK_INFO")
        {
        }

        public RRANK_INFO(System.Object instance) : base("RANK_INFO")
		{
            SetInstance(instance);
		}

        public RRANK_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRANK_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
