using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// InfluenceEventConfig
	/// </summary>
    public partial class RInfluenceEventConfig : RMember //
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
		/// System.Int32 camp_id
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
		/// System.Int32 hordeLevel
		/// </summary>
		protected RField r_hordeLevel;
		public virtual RField RhordeLevel
		{
			get
			{
				if(r_hordeLevel == null)
				{
					r_hordeLevel = new(this, "hordeLevel");
					r_hordeLevel.SetBelong(this.instance);
				}
				return r_hordeLevel;
			}
		}

		/// <summary>
		/// System.String eventInfo
		/// </summary>
		protected RField r_eventInfo;
		public virtual RField ReventInfo
		{
			get
			{
				if(r_eventInfo == null)
				{
					r_eventInfo = new(this, "eventInfo");
					r_eventInfo.SetBelong(this.instance);
				}
				return r_eventInfo;
			}
		}

		/// <summary>
		/// System.String endInfo
		/// </summary>
		protected RField r_endInfo;
		public virtual RField RendInfo
		{
			get
			{
				if(r_endInfo == null)
				{
					r_endInfo = new(this, "endInfo");
					r_endInfo.SetBelong(this.instance);
				}
				return r_endInfo;
			}
		}

		/// <summary>
		/// System.Int32 shop_id
		/// </summary>
		protected RField r_shop_id;
		public virtual RField Rshop_id
		{
			get
			{
				if(r_shop_id == null)
				{
					r_shop_id = new(this, "shop_id");
					r_shop_id.SetBelong(this.instance);
				}
				return r_shop_id;
			}
		}

		/// <summary>
		/// System.String beginPathFind
		/// </summary>
		protected RField r_beginPathFind;
		public virtual RField RbeginPathFind
		{
			get
			{
				if(r_beginPathFind == null)
				{
					r_beginPathFind = new(this, "beginPathFind");
					r_beginPathFind.SetBelong(this.instance);
				}
				return r_beginPathFind;
			}
		}

		/// <summary>
		/// System.String endPathFind
		/// </summary>
		protected RField r_endPathFind;
		public virtual RField RendPathFind
		{
			get
			{
				if(r_endPathFind == null)
				{
					r_endPathFind = new(this, "endPathFind");
					r_endPathFind.SetBelong(this.instance);
				}
				return r_endPathFind;
			}
		}

		/// <summary>
		/// System.String GetFullIconUrl(System.String)
		/// </summary>
		protected static RMethod r_RGetFullIconUrl_String;
		public static RMethod RGetFullIconUrl_String
		{
			get
			{
				if(r_RGetFullIconUrl_String == null)
				{
					r_RGetFullIconUrl_String = new(typeof(InfluenceEventConfig), "GetFullIconUrl", 0, typeof(System.String));
					r_RGetFullIconUrl_String.SetBelong(null);
				}
				return r_RGetFullIconUrl_String;
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


        public RInfluenceEventConfig() : base("InfluenceEventConfig")
        {
        }

        public RInfluenceEventConfig(System.Object instance) : base("InfluenceEventConfig")
		{
            SetInstance(instance);
		}

        public RInfluenceEventConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInfluenceEventConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String GetFullIconUrl(System.String  @icon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@icon};
            var ___result = RGetFullIconUrl_String.Invoke(___genericsType, ___parameters);

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
