using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// XJTargetChapterInfo
	/// </summary>
    public partial class RXJTargetChapterInfo : RMember //
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
		/// System.Int32 day
		/// </summary>
		protected RField r_day;
		public virtual RField Rday
		{
			get
			{
				if(r_day == null)
				{
					r_day = new(this, "day");
					r_day.SetBelong(this.instance);
				}
				return r_day;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] taskids
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_taskids;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rtaskids
		{
			get
			{
				if(r_taskids == null)
				{
					r_taskids = new(this, "taskids");
					r_taskids.SetBelong(this.instance);
				}
				return r_taskids;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] itemids
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_itemids;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Ritemids
		{
			get
			{
				if(r_itemids == null)
				{
					r_itemids = new(this, "itemids");
					r_itemids.SetBelong(this.instance);
				}
				return r_itemids;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] counts
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_counts;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rcounts
		{
			get
			{
				if(r_counts == null)
				{
					r_counts = new(this, "counts");
					r_counts.SetBelong(this.instance);
				}
				return r_counts;
			}
		}

		/// <summary>
		/// System.String logo
		/// </summary>
		protected RField r_logo;
		public virtual RField Rlogo
		{
			get
			{
				if(r_logo == null)
				{
					r_logo = new(this, "logo");
					r_logo.SetBelong(this.instance);
				}
				return r_logo;
			}
		}

		/// <summary>
		/// System.String logo2
		/// </summary>
		protected RField r_logo2;
		public virtual RField Rlogo2
		{
			get
			{
				if(r_logo2 == null)
				{
					r_logo2 = new(this, "logo2");
					r_logo2.SetBelong(this.instance);
				}
				return r_logo2;
			}
		}

		/// <summary>
		/// System.String icon0
		/// </summary>
		protected RField r_icon0;
		public virtual RField Ricon0
		{
			get
			{
				if(r_icon0 == null)
				{
					r_icon0 = new(this, "icon0");
					r_icon0.SetBelong(this.instance);
				}
				return r_icon0;
			}
		}

		/// <summary>
		/// System.String icon1
		/// </summary>
		protected RField r_icon1;
		public virtual RField Ricon1
		{
			get
			{
				if(r_icon1 == null)
				{
					r_icon1 = new(this, "icon1");
					r_icon1.SetBelong(this.instance);
				}
				return r_icon1;
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


        public RXJTargetChapterInfo() : base("XJTargetChapterInfo")
        {
        }

        public RXJTargetChapterInfo(System.Object instance) : base("XJTargetChapterInfo")
		{
            SetInstance(instance);
		}

        public RXJTargetChapterInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXJTargetChapterInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
