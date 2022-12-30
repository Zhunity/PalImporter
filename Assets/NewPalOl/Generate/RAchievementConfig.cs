using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AchievementConfig
	/// </summary>
    public partial class RAchievementConfig : RMember //
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
		/// System.Int32 point
		/// </summary>
		protected RField r_point;
		public virtual RField Rpoint
		{
			get
			{
				if(r_point == null)
				{
					r_point = new(this, "point");
					r_point.SetBelong(this.instance);
				}
				return r_point;
			}
		}

		/// <summary>
		/// System.Int32 previd
		/// </summary>
		protected RField r_previd;
		public virtual RField Rprevid
		{
			get
			{
				if(r_previd == null)
				{
					r_previd = new(this, "previd");
					r_previd.SetBelong(this.instance);
				}
				return r_previd;
			}
		}

		/// <summary>
		/// System.Int32 ishide
		/// </summary>
		protected RField r_ishide;
		public virtual RField Rishide
		{
			get
			{
				if(r_ishide == null)
				{
					r_ishide = new(this, "ishide");
					r_ishide.SetBelong(this.instance);
				}
				return r_ishide;
			}
		}

		/// <summary>
		/// System.Int32 maxvalue
		/// </summary>
		protected RField r_maxvalue;
		public virtual RField Rmaxvalue
		{
			get
			{
				if(r_maxvalue == null)
				{
					r_maxvalue = new(this, "maxvalue");
					r_maxvalue.SetBelong(this.instance);
				}
				return r_maxvalue;
			}
		}

		/// <summary>
		/// System.Int32 isServer
		/// </summary>
		protected RField r_isServer;
		public virtual RField RisServer
		{
			get
			{
				if(r_isServer == null)
				{
					r_isServer = new(this, "isServer");
					r_isServer.SetBelong(this.instance);
				}
				return r_isServer;
			}
		}

		/// <summary>
		/// System.Int32 prize1
		/// </summary>
		protected RField r_prize1;
		public virtual RField Rprize1
		{
			get
			{
				if(r_prize1 == null)
				{
					r_prize1 = new(this, "prize1");
					r_prize1.SetBelong(this.instance);
				}
				return r_prize1;
			}
		}

		/// <summary>
		/// System.Int32 prize2
		/// </summary>
		protected RField r_prize2;
		public virtual RField Rprize2
		{
			get
			{
				if(r_prize2 == null)
				{
					r_prize2 = new(this, "prize2");
					r_prize2.SetBelong(this.instance);
				}
				return r_prize2;
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
		/// System.String typeicon
		/// </summary>
		protected RField r_typeicon;
		public virtual RField Rtypeicon
		{
			get
			{
				if(r_typeicon == null)
				{
					r_typeicon = new(this, "typeicon");
					r_typeicon.SetBelong(this.instance);
				}
				return r_typeicon;
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


        public RAchievementConfig() : base("AchievementConfig")
        {
        }

        public RAchievementConfig(System.Object instance) : base("AchievementConfig")
		{
            SetInstance(instance);
		}

        public RAchievementConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAchievementConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
