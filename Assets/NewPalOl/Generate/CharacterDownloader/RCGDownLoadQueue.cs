using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCharacterDownloader
{
	
	/// <summary>
	/// CharacterDownloader+CGDownLoadQueue
	/// </summary>
    public partial class RCGDownLoadQueue : RMember //
    {

		/// <summary>
		/// System.String config
		/// </summary>
		protected RField r_config;
		public virtual RField Rconfig
		{
			get
			{
				if(r_config == null)
				{
					r_config = new(this, "config");
					r_config.SetBelong(this.instance);
				}
				return r_config;
			}
		}

		/// <summary>
		/// GameDefineType.ID careerID
		/// </summary>
		protected RGameDefineType.RID r_careerID;
		public virtual RGameDefineType.RID RcareerID
		{
			get
			{
				if(r_careerID == null)
				{
					r_careerID = new(this, "careerID");
					r_careerID.SetBelong(this.instance);
				}
				return r_careerID;
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
		/// System.Object param
		/// </summary>
		protected RSystem.RObject r_param;
		public virtual RSystem.RObject Rparam
		{
			get
			{
				if(r_param == null)
				{
					r_param = new(this, "param");
					r_param.SetBelong(this.instance);
				}
				return r_param;
			}
		}

		/// <summary>
		/// System.Boolean hasCombatAnimClip
		/// </summary>
		protected RField r_hasCombatAnimClip;
		public virtual RField RhasCombatAnimClip
		{
			get
			{
				if(r_hasCombatAnimClip == null)
				{
					r_hasCombatAnimClip = new(this, "hasCombatAnimClip");
					r_hasCombatAnimClip.SetBelong(this.instance);
				}
				return r_hasCombatAnimClip;
			}
		}

		/// <summary>
		/// CharacterDownloader+CGLoadingHandler loadingHandler
		/// </summary>
		protected RCharacterDownloader.RCGLoadingHandler r_loadingHandler;
		public virtual RCharacterDownloader.RCGLoadingHandler RloadingHandler
		{
			get
			{
				if(r_loadingHandler == null)
				{
					r_loadingHandler = new(this, "loadingHandler");
					r_loadingHandler.SetBelong(this.instance);
				}
				return r_loadingHandler;
			}
		}

		/// <summary>
		/// CharacterDownloader+CGLoadedHandler loadedHandler
		/// </summary>
		protected RCharacterDownloader.RCGLoadedHandler r_loadedHandler;
		public virtual RCharacterDownloader.RCGLoadedHandler RloadedHandler
		{
			get
			{
				if(r_loadedHandler == null)
				{
					r_loadedHandler = new(this, "loadedHandler");
					r_loadedHandler.SetBelong(this.instance);
				}
				return r_loadedHandler;
			}
		}

		/// <summary>
		/// System.Boolean bNeedInstantiate
		/// </summary>
		protected RField r_bNeedInstantiate;
		public virtual RField RbNeedInstantiate
		{
			get
			{
				if(r_bNeedInstantiate == null)
				{
					r_bNeedInstantiate = new(this, "bNeedInstantiate");
					r_bNeedInstantiate.SetBelong(this.instance);
				}
				return r_bNeedInstantiate;
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


        public RCGDownLoadQueue() : base("CharacterDownloader+CGDownLoadQueue")
        {
        }

        public RCGDownLoadQueue(System.Object instance) : base("CharacterDownloader+CGDownLoadQueue")
		{
            SetInstance(instance);
		}

        public RCGDownLoadQueue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCGDownLoadQueue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}