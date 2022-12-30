using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAssetBundleDownloader
{
	
	/// <summary>
	/// AssetBundleDownloader+AB_DOWNLOADER_ARGS
	/// </summary>
    public partial class RAB_DOWNLOADER_ARGS : RMember //
    {

		/// <summary>
		/// GameDefineType.ID mSceneID
		/// </summary>
		protected RGameDefineType.RID r_mSceneID;
		public virtual RGameDefineType.RID RmSceneID
		{
			get
			{
				if(r_mSceneID == null)
				{
					r_mSceneID = new(this, "mSceneID");
					r_mSceneID.SetBelong(this.instance);
				}
				return r_mSceneID;
			}
		}

		/// <summary>
		/// System.String[] urls
		/// </summary>
		protected RFieldArray<RField> r_urls;
		public virtual RFieldArray<RField> Rurls
		{
			get
			{
				if(r_urls == null)
				{
					r_urls = new(this, "urls");
					r_urls.SetBelong(this.instance);
				}
				return r_urls;
			}
		}

		/// <summary>
		/// System.Boolean Async
		/// </summary>
		protected RField r_Async;
		public virtual RField RAsync
		{
			get
			{
				if(r_Async == null)
				{
					r_Async = new(this, "Async");
					r_Async.SetBelong(this.instance);
				}
				return r_Async;
			}
		}

		/// <summary>
		/// AssetBundleDownloader+ABLoadCallBack mCallBack
		/// </summary>
		protected RAssetBundleDownloader.RABLoadCallBack r_mCallBack;
		public virtual RAssetBundleDownloader.RABLoadCallBack RmCallBack
		{
			get
			{
				if(r_mCallBack == null)
				{
					r_mCallBack = new(this, "mCallBack");
					r_mCallBack.SetBelong(this.instance);
				}
				return r_mCallBack;
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
		/// System.Int32 priority
		/// </summary>
		protected RField r_priority;
		public virtual RField Rpriority
		{
			get
			{
				if(r_priority == null)
				{
					r_priority = new(this, "priority");
					r_priority.SetBelong(this.instance);
				}
				return r_priority;
			}
		}

		/// <summary>
		/// UnityEngine.ThreadPriority threadPriority
		/// </summary>
		protected RField r_threadPriority;
		public virtual RField RthreadPriority
		{
			get
			{
				if(r_threadPriority == null)
				{
					r_threadPriority = new(this, "threadPriority");
					r_threadPriority.SetBelong(this.instance);
				}
				return r_threadPriority;
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


        public RAB_DOWNLOADER_ARGS() : base("AssetBundleDownloader+AB_DOWNLOADER_ARGS")
        {
        }

        public RAB_DOWNLOADER_ARGS(System.Object instance) : base("AssetBundleDownloader+AB_DOWNLOADER_ARGS")
		{
            SetInstance(instance);
		}

        public RAB_DOWNLOADER_ARGS(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAB_DOWNLOADER_ARGS(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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