using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCharacterDownloader
{
	
	/// <summary>
	/// CharacterDownloader+CGLoadArgs
	/// </summary>
    public partial class RCGLoadArgs : RMember //
    {

		/// <summary>
		/// System.String mConfig
		/// </summary>
		protected RField r_mConfig;
		public virtual RField RmConfig
		{
			get
			{
				if(r_mConfig == null)
				{
					r_mConfig = new(this, "mConfig");
					r_mConfig.SetBelong(this.instance);
				}
				return r_mConfig;
			}
		}

		/// <summary>
		/// GameDefineType.ID idWeapon
		/// </summary>
		protected RGameDefineType.RID r_idWeapon;
		public virtual RGameDefineType.RID RidWeapon
		{
			get
			{
				if(r_idWeapon == null)
				{
					r_idWeapon = new(this, "idWeapon");
					r_idWeapon.SetBelong(this.instance);
				}
				return r_idWeapon;
			}
		}

		/// <summary>
		/// System.Boolean hasCombatAniClip
		/// </summary>
		protected RField r_hasCombatAniClip;
		public virtual RField RhasCombatAniClip
		{
			get
			{
				if(r_hasCombatAniClip == null)
				{
					r_hasCombatAniClip = new(this, "hasCombatAniClip");
					r_hasCombatAniClip.SetBelong(this.instance);
				}
				return r_hasCombatAniClip;
			}
		}

		/// <summary>
		/// CharacterDownloader+CGLoadedHandler mLoadedHandler
		/// </summary>
		protected RCharacterDownloader.RCGLoadedHandler r_mLoadedHandler;
		public virtual RCharacterDownloader.RCGLoadedHandler RmLoadedHandler
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
		/// CharacterDownloader+CGLoadingHandler mLoadingHandler
		/// </summary>
		protected RCharacterDownloader.RCGLoadingHandler r_mLoadingHandler;
		public virtual RCharacterDownloader.RCGLoadingHandler RmLoadingHandler
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
		/// Void DispatchOnLoaded(System.Object, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RDispatchOnLoaded_Object_GameObject;
		public virtual RMethod RDispatchOnLoaded_Object_GameObject
		{
			get
			{
				if(r_RDispatchOnLoaded_Object_GameObject == null)
				{
					r_RDispatchOnLoaded_Object_GameObject = new(this, "DispatchOnLoaded", 0, typeof(System.Object), typeof(UnityEngine.GameObject));
					r_RDispatchOnLoaded_Object_GameObject.SetBelong(this.instance);
				}
				return r_RDispatchOnLoaded_Object_GameObject;
			}
		}

		/// <summary>
		/// Void DispatchOnLoading(System.Object, Single)
		/// </summary>
		protected RMethod r_RDispatchOnLoading_Object_Single;
		public virtual RMethod RDispatchOnLoading_Object_Single
		{
			get
			{
				if(r_RDispatchOnLoading_Object_Single == null)
				{
					r_RDispatchOnLoading_Object_Single = new(this, "DispatchOnLoading", 0, typeof(System.Object), typeof(System.Single));
					r_RDispatchOnLoading_Object_Single.SetBelong(this.instance);
				}
				return r_RDispatchOnLoading_Object_Single;
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


        public RCGLoadArgs() : base("CharacterDownloader+CGLoadArgs")
        {
        }

        public RCGLoadArgs(System.Object instance) : base("CharacterDownloader+CGLoadArgs")
		{
            SetInstance(instance);
		}

        public RCGLoadArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCGLoadArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void DispatchOnLoaded(System.Object  @arg, UnityEngine.GameObject  @gameObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @gameObj};
            var ___result = RDispatchOnLoaded_Object_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DispatchOnLoading(System.Object  @arg, System.Single  @process)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @process};
            var ___result = RDispatchOnLoading_Object_Single.Invoke(___genericsType, ___parameters);

            
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