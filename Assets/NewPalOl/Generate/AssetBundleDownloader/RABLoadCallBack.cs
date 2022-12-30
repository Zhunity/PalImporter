using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAssetBundleDownloader
{
	
	/// <summary>
	/// AssetBundleDownloader+ABLoadCallBack
	/// </summary>
    public partial class RABLoadCallBack : RMember //
    {

		/// <summary>
		/// AssetBundleDownloader+ABLoadedHandler mLoadedHandler
		/// </summary>
		protected RAssetBundleDownloader.RABLoadedHandler r_mLoadedHandler;
		public virtual RAssetBundleDownloader.RABLoadedHandler RmLoadedHandler
		{
			get
			{
				if(r_mLoadedHandler == null)
				{
					r_mLoadedHandler = new(this, "mLoadedHandler");
					r_mLoadedHandler.SetBelong(this.instance);
				}
				return r_mLoadedHandler;
			}
		}

		/// <summary>
		/// AssetBundleDownloader+ABLoadingHandler mLoadingHandler
		/// </summary>
		protected RAssetBundleDownloader.RABLoadingHandler r_mLoadingHandler;
		public virtual RAssetBundleDownloader.RABLoadingHandler RmLoadingHandler
		{
			get
			{
				if(r_mLoadingHandler == null)
				{
					r_mLoadingHandler = new(this, "mLoadingHandler");
					r_mLoadingHandler.SetBelong(this.instance);
				}
				return r_mLoadingHandler;
			}
		}

		/// <summary>
		/// AssetBundleDownloader+ABLoadedHandler mAllLoadedHandler
		/// </summary>
		protected RAssetBundleDownloader.RABLoadedHandler r_mAllLoadedHandler;
		public virtual RAssetBundleDownloader.RABLoadedHandler RmAllLoadedHandler
		{
			get
			{
				if(r_mAllLoadedHandler == null)
				{
					r_mAllLoadedHandler = new(this, "mAllLoadedHandler");
					r_mAllLoadedHandler.SetBelong(this.instance);
				}
				return r_mAllLoadedHandler;
			}
		}

		/// <summary>
		/// Void DispatchOnLoaded(GameDefineType.ID, UnityEngine.WWW, System.Object)
		/// </summary>
		protected RMethod r_RDispatchOnLoaded_ID_WWW_Object;
		public virtual RMethod RDispatchOnLoaded_ID_WWW_Object
		{
			get
			{
				if(r_RDispatchOnLoaded_ID_WWW_Object == null)
				{
					r_RDispatchOnLoaded_ID_WWW_Object = new(this, "DispatchOnLoaded", 0, typeof(GameDefineType.ID), typeof(UnityEngine.WWW), typeof(System.Object));
					r_RDispatchOnLoaded_ID_WWW_Object.SetBelong(this.instance);
				}
				return r_RDispatchOnLoaded_ID_WWW_Object;
			}
		}

		/// <summary>
		/// Void DispatchOnLoaded(GameDefineType.ID, System.String, System.Object)
		/// </summary>
		protected RMethod r_RDispatchOnLoaded_ID_String_Object;
		public virtual RMethod RDispatchOnLoaded_ID_String_Object
		{
			get
			{
				if(r_RDispatchOnLoaded_ID_String_Object == null)
				{
					r_RDispatchOnLoaded_ID_String_Object = new(this, "DispatchOnLoaded", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(System.Object));
					r_RDispatchOnLoaded_ID_String_Object.SetBelong(this.instance);
				}
				return r_RDispatchOnLoaded_ID_String_Object;
			}
		}

		/// <summary>
		/// Void GroupLoadedCheck(System.String[])
		/// </summary>
		protected RMethod r_RGroupLoadedCheck_StringArray;
		public virtual RMethod RGroupLoadedCheck_StringArray
		{
			get
			{
				if(r_RGroupLoadedCheck_StringArray == null)
				{
					r_RGroupLoadedCheck_StringArray = new(this, "GroupLoadedCheck", 0, typeof(System.String).MakeArrayType());
					r_RGroupLoadedCheck_StringArray.SetBelong(this.instance);
				}
				return r_RGroupLoadedCheck_StringArray;
			}
		}

		/// <summary>
		/// Void DispatchOnLoading(GameDefineType.ID, UnityEngine.WWW, System.Object)
		/// </summary>
		protected RMethod r_RDispatchOnLoading_ID_WWW_Object;
		public virtual RMethod RDispatchOnLoading_ID_WWW_Object
		{
			get
			{
				if(r_RDispatchOnLoading_ID_WWW_Object == null)
				{
					r_RDispatchOnLoading_ID_WWW_Object = new(this, "DispatchOnLoading", 0, typeof(GameDefineType.ID), typeof(UnityEngine.WWW), typeof(System.Object));
					r_RDispatchOnLoading_ID_WWW_Object.SetBelong(this.instance);
				}
				return r_RDispatchOnLoading_ID_WWW_Object;
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


        public RABLoadCallBack() : base("AssetBundleDownloader+ABLoadCallBack")
        {
        }

        public RABLoadCallBack(System.Object instance) : base("AssetBundleDownloader+ABLoadCallBack")
		{
            SetInstance(instance);
		}

        public RABLoadCallBack(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RABLoadCallBack(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void DispatchOnLoaded(GameDefineType.ID  @id, UnityEngine.WWW  @www, System.Object  @exArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @www, @exArgs};
            var ___result = RDispatchOnLoaded_ID_WWW_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchOnLoaded(GameDefineType.ID  @id, System.String  @url, System.Object  @exArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @url, @exArgs};
            var ___result = RDispatchOnLoaded_ID_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GroupLoadedCheck(System.String[]  @urls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@urls};
            var ___result = RGroupLoadedCheck_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchOnLoading(GameDefineType.ID  @id, UnityEngine.WWW  @www, System.Object  @exArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @www, @exArgs};
            var ___result = RDispatchOnLoading_ID_WWW_Object.Invoke(___genericsType, ___parameters);

            
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