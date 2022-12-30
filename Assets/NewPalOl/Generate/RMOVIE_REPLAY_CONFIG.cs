using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MOVIE_REPLAY_CONFIG
	/// </summary>
    public partial class RMOVIE_REPLAY_CONFIG : RMember //
    {

		/// <summary>
		/// System.Int32 idx
		/// </summary>
		protected RField r_idx;
		public virtual RField Ridx
		{
			get
			{
				if(r_idx == null)
				{
					r_idx = new(this, "idx");
					r_idx.SetBelong(this.instance);
				}
				return r_idx;
			}
		}

		/// <summary>
		/// System.String showname
		/// </summary>
		protected RField r_showname;
		public virtual RField Rshowname
		{
			get
			{
				if(r_showname == null)
				{
					r_showname = new(this, "showname");
					r_showname.SetBelong(this.instance);
				}
				return r_showname;
			}
		}

		/// <summary>
		/// System.String clipname
		/// </summary>
		protected RField r_clipname;
		public virtual RField Rclipname
		{
			get
			{
				if(r_clipname == null)
				{
					r_clipname = new(this, "clipname");
					r_clipname.SetBelong(this.instance);
				}
				return r_clipname;
			}
		}

		/// <summary>
		/// System.String sceneid
		/// </summary>
		protected RField r_sceneid;
		public virtual RField Rsceneid
		{
			get
			{
				if(r_sceneid == null)
				{
					r_sceneid = new(this, "sceneid");
					r_sceneid.SetBelong(this.instance);
				}
				return r_sceneid;
			}
		}

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


        public RMOVIE_REPLAY_CONFIG() : base("MOVIE_REPLAY_CONFIG")
        {
        }

        public RMOVIE_REPLAY_CONFIG(System.Object instance) : base("MOVIE_REPLAY_CONFIG")
		{
            SetInstance(instance);
		}

        public RMOVIE_REPLAY_CONFIG(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMOVIE_REPLAY_CONFIG(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
