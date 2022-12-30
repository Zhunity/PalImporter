using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RAID_MAP_CONFIG
	/// </summary>
    public partial class RRAID_MAP_CONFIG : RMember //
    {

		/// <summary>
		/// System.String mapid
		/// </summary>
		protected RField r_mapid;
		public virtual RField Rmapid
		{
			get
			{
				if(r_mapid == null)
				{
					r_mapid = new(this, "mapid");
					r_mapid.SetBelong(this.instance);
				}
				return r_mapid;
			}
		}

		/// <summary>
		/// System.String bgUrl
		/// </summary>
		protected RField r_bgUrl;
		public virtual RField RbgUrl
		{
			get
			{
				if(r_bgUrl == null)
				{
					r_bgUrl = new(this, "bgUrl");
					r_bgUrl.SetBelong(this.instance);
				}
				return r_bgUrl;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_ICON_STRUCT] listIcons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RRAID_ICON_STRUCT> r_listIcons;
		public virtual RSystem.RCollections.RGeneric.RList<RRAID_ICON_STRUCT> RlistIcons
		{
			get
			{
				if(r_listIcons == null)
				{
					r_listIcons = new(this, "listIcons");
					r_listIcons.SetBelong(this.instance);
				}
				return r_listIcons;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_LINE_STRUCT] listLines
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RRAID_LINE_STRUCT> r_listLines;
		public virtual RSystem.RCollections.RGeneric.RList<RRAID_LINE_STRUCT> RlistLines
		{
			get
			{
				if(r_listLines == null)
				{
					r_listLines = new(this, "listLines");
					r_listLines.SetBelong(this.instance);
				}
				return r_listLines;
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


        public RRAID_MAP_CONFIG() : base("RAID_MAP_CONFIG")
        {
        }

        public RRAID_MAP_CONFIG(System.Object instance) : base("RAID_MAP_CONFIG")
		{
            SetInstance(instance);
		}

        public RRAID_MAP_CONFIG(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRAID_MAP_CONFIG(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
