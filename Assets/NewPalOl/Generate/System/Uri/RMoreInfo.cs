using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RUri
{
	
	/// <summary>
	/// System.Uri+MoreInfo
	/// </summary>
    public partial class RMoreInfo : RMember //
    {

		/// <summary>
		/// System.String Path
		/// </summary>
		protected RField r_Path;
		public virtual RField RPath
		{
			get
			{
				if(r_Path == null)
				{
					r_Path = new(this, "Path");
					r_Path.SetBelong(this.instance);
				}
				return r_Path;
			}
		}

		/// <summary>
		/// System.String Query
		/// </summary>
		protected RField r_Query;
		public virtual RField RQuery
		{
			get
			{
				if(r_Query == null)
				{
					r_Query = new(this, "Query");
					r_Query.SetBelong(this.instance);
				}
				return r_Query;
			}
		}

		/// <summary>
		/// System.String Fragment
		/// </summary>
		protected RField r_Fragment;
		public virtual RField RFragment
		{
			get
			{
				if(r_Fragment == null)
				{
					r_Fragment = new(this, "Fragment");
					r_Fragment.SetBelong(this.instance);
				}
				return r_Fragment;
			}
		}

		/// <summary>
		/// System.String AbsoluteUri
		/// </summary>
		protected RField r_AbsoluteUri;
		public virtual RField RAbsoluteUri
		{
			get
			{
				if(r_AbsoluteUri == null)
				{
					r_AbsoluteUri = new(this, "AbsoluteUri");
					r_AbsoluteUri.SetBelong(this.instance);
				}
				return r_AbsoluteUri;
			}
		}

		/// <summary>
		/// System.Int32 Hash
		/// </summary>
		protected RField r_Hash;
		public virtual RField RHash
		{
			get
			{
				if(r_Hash == null)
				{
					r_Hash = new(this, "Hash");
					r_Hash.SetBelong(this.instance);
				}
				return r_Hash;
			}
		}

		/// <summary>
		/// System.String RemoteUrl
		/// </summary>
		protected RField r_RemoteUrl;
		public virtual RField RemoteUrl
		{
			get
			{
				if(r_RemoteUrl == null)
				{
					r_RemoteUrl = new(this, "RemoteUrl");
					r_RemoteUrl.SetBelong(this.instance);
				}
				return r_RemoteUrl;
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


        public RMoreInfo() : base("System.Uri+MoreInfo")
        {
        }

        public RMoreInfo(System.Object instance) : base("System.Uri+MoreInfo")
		{
            SetInstance(instance);
		}

        public RMoreInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMoreInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}