using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAssetBundleDownloader
{
	
	/// <summary>
	/// AssetBundleDownloader+ABLoadedArgs
	/// </summary>
    public partial class RABLoadedArgs : RMember //
    {

		/// <summary>
		/// GameDefineType.ID mID
		/// </summary>
		protected RGameDefineType.RID r_mID;
		public virtual RGameDefineType.RID RmID
		{
			get
			{
				if(r_mID == null)
				{
					r_mID = new(this, "mID");
					r_mID.SetBelong(this.instance);
				}
				return r_mID;
			}
		}

		/// <summary>
		/// System.String www_url
		/// </summary>
		protected RField r_www_url;
		public virtual RField Rwww_url
		{
			get
			{
				if(r_www_url == null)
				{
					r_www_url = new(this, "www_url");
					r_www_url.SetBelong(this.instance);
				}
				return r_www_url;
			}
		}

		/// <summary>
		/// UnityEngine.Object _mainAsset
		/// </summary>
		protected RUnityEngine.RObject r__mainAsset;
		public virtual RUnityEngine.RObject R_mainAsset
		{
			get
			{
				if(r__mainAsset == null)
				{
					r__mainAsset = new(this, "_mainAsset");
					r__mainAsset.SetBelong(this.instance);
				}
				return r__mainAsset;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle _assetbundle
		/// </summary>
		protected RUnityEngine.RAssetBundle r__assetbundle;
		public virtual RUnityEngine.RAssetBundle R_assetbundle
		{
			get
			{
				if(r__assetbundle == null)
				{
					r__assetbundle = new(this, "_assetbundle");
					r__assetbundle.SetBelong(this.instance);
				}
				return r__assetbundle;
			}
		}

		/// <summary>
		/// System.Object mExArgs
		/// </summary>
		protected RSystem.RObject r_mExArgs;
		public virtual RSystem.RObject RmExArgs
		{
			get
			{
				if(r_mExArgs == null)
				{
					r_mExArgs = new(this, "mExArgs");
					r_mExArgs.SetBelong(this.instance);
				}
				return r_mExArgs;
			}
		}

		/// <summary>
		/// System.String mWWW_url
		/// </summary>
		protected RProperty r_mWWW_url;
		public virtual RProperty RmWWW_url
		{
			get
			{
				if(r_mWWW_url == null)
				{
					r_mWWW_url = new(this, "mWWW_url", -1);
					r_mWWW_url.SetBelong(this.instance);
				}
				return r_mWWW_url;
			}
		}

		/// <summary>
		/// UnityEngine.Object mainAsset
		/// </summary>
		protected RUnityEngine.RObject r_mainAsset;
		public virtual RUnityEngine.RObject RmainAsset
		{
			get
			{
				if(r_mainAsset == null)
				{
					r_mainAsset = new(this, "mainAsset", -1);
					r_mainAsset.SetBelong(this.instance);
				}
				return r_mainAsset;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle assetBundle
		/// </summary>
		protected RUnityEngine.RAssetBundle r_assetBundle;
		public virtual RUnityEngine.RAssetBundle RassetBundle
		{
			get
			{
				if(r_assetBundle == null)
				{
					r_assetBundle = new(this, "assetBundle", -1);
					r_assetBundle.SetBelong(this.instance);
				}
				return r_assetBundle;
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


        public RABLoadedArgs() : base("AssetBundleDownloader+ABLoadedArgs")
        {
        }

        public RABLoadedArgs(System.Object instance) : base("AssetBundleDownloader+ABLoadedArgs")
		{
            SetInstance(instance);
		}

        public RABLoadedArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RABLoadedArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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