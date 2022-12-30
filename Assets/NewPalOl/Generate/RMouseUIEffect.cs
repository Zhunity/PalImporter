using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MouseUIEffect
	/// </summary>
    public partial class RMouseUIEffect : RMember //
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
		/// System.Int32 platformid
		/// </summary>
		protected RField r_platformid;
		public virtual RField Rplatformid
		{
			get
			{
				if(r_platformid == null)
				{
					r_platformid = new(this, "platformid");
					r_platformid.SetBelong(this.instance);
				}
				return r_platformid;
			}
		}

		/// <summary>
		/// System.String touchurl
		/// </summary>
		protected RField r_touchurl;
		public virtual RField Rtouchurl
		{
			get
			{
				if(r_touchurl == null)
				{
					r_touchurl = new(this, "touchurl");
					r_touchurl.SetBelong(this.instance);
				}
				return r_touchurl;
			}
		}

		/// <summary>
		/// System.String tractionurl
		/// </summary>
		protected RField r_tractionurl;
		public virtual RField Rtractionurl
		{
			get
			{
				if(r_tractionurl == null)
				{
					r_tractionurl = new(this, "tractionurl");
					r_tractionurl.SetBelong(this.instance);
				}
				return r_tractionurl;
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
		/// System.String bubblestyle
		/// </summary>
		protected RField r_bubblestyle;
		public virtual RField Rbubblestyle
		{
			get
			{
				if(r_bubblestyle == null)
				{
					r_bubblestyle = new(this, "bubblestyle");
					r_bubblestyle.SetBelong(this.instance);
				}
				return r_bubblestyle;
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


        public RMouseUIEffect() : base("MouseUIEffect")
        {
        }

        public RMouseUIEffect(System.Object instance) : base("MouseUIEffect")
		{
            SetInstance(instance);
		}

        public RMouseUIEffect(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMouseUIEffect(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
