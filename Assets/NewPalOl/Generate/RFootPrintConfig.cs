using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FootPrintConfig
	/// </summary>
    public partial class RFootPrintConfig : RMember //
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
		/// System.String effecturl
		/// </summary>
		protected RField r_effecturl;
		public virtual RField Reffecturl
		{
			get
			{
				if(r_effecturl == null)
				{
					r_effecturl = new(this, "effecturl");
					r_effecturl.SetBelong(this.instance);
				}
				return r_effecturl;
			}
		}

		/// <summary>
		/// System.String pic
		/// </summary>
		protected RField r_pic;
		public virtual RField Rpic
		{
			get
			{
				if(r_pic == null)
				{
					r_pic = new(this, "pic");
					r_pic.SetBelong(this.instance);
				}
				return r_pic;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] pricelist
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_pricelist;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rpricelist
		{
			get
			{
				if(r_pricelist == null)
				{
					r_pricelist = new(this, "pricelist");
					r_pricelist.SetBelong(this.instance);
				}
				return r_pricelist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] timelist
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_timelist;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rtimelist
		{
			get
			{
				if(r_timelist == null)
				{
					r_timelist = new(this, "timelist");
					r_timelist.SetBelong(this.instance);
				}
				return r_timelist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] itemidlist
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_itemidlist;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Ritemidlist
		{
			get
			{
				if(r_itemidlist == null)
				{
					r_itemidlist = new(this, "itemidlist");
					r_itemidlist.SetBelong(this.instance);
				}
				return r_itemidlist;
			}
		}

		/// <summary>
		/// System.Int32 platform
		/// </summary>
		protected RField r_platform;
		public virtual RField Rplatform
		{
			get
			{
				if(r_platform == null)
				{
					r_platform = new(this, "platform");
					r_platform.SetBelong(this.instance);
				}
				return r_platform;
			}
		}

		/// <summary>
		/// System.String playername
		/// </summary>
		protected RField r_playername;
		public virtual RField Rplayername
		{
			get
			{
				if(r_playername == null)
				{
					r_playername = new(this, "playername");
					r_playername.SetBelong(this.instance);
				}
				return r_playername;
			}
		}

		/// <summary>
		/// System.Single timeInt
		/// </summary>
		protected RField r_timeInt;
		public virtual RField RtimeInt
		{
			get
			{
				if(r_timeInt == null)
				{
					r_timeInt = new(this, "timeInt");
					r_timeInt.SetBelong(this.instance);
				}
				return r_timeInt;
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


        public RFootPrintConfig() : base("FootPrintConfig")
        {
        }

        public RFootPrintConfig(System.Object instance) : base("FootPrintConfig")
		{
            SetInstance(instance);
		}

        public RFootPrintConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFootPrintConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
