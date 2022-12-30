using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BattleSpot
	/// </summary>
    public partial class RBattleSpot : RMember //
    {

		/// <summary>
		/// System.String mSpotid
		/// </summary>
		protected RField r_mSpotid;
		public virtual RField RmSpotid
		{
			get
			{
				if(r_mSpotid == null)
				{
					r_mSpotid = new(this, "mSpotid");
					r_mSpotid.SetBelong(this.instance);
				}
				return r_mSpotid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SceneSoundConfig] mBattleBGSoundList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> r_mBattleBGSoundList;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> RmBattleBGSoundList
		{
			get
			{
				if(r_mBattleBGSoundList == null)
				{
					r_mBattleBGSoundList = new(this, "mBattleBGSoundList");
					r_mBattleBGSoundList.SetBelong(this.instance);
				}
				return r_mBattleBGSoundList;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RField r_url;
		public virtual RField Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url");
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// UnityEngine.Object mBattleSpotResObj
		/// </summary>
		protected RUnityEngine.RObject r_mBattleSpotResObj;
		public virtual RUnityEngine.RObject RmBattleSpotResObj
		{
			get
			{
				if(r_mBattleSpotResObj == null)
				{
					r_mBattleSpotResObj = new(this, "mBattleSpotResObj");
					r_mBattleSpotResObj.SetBelong(this.instance);
				}
				return r_mBattleSpotResObj;
			}
		}

		/// <summary>
		/// System.Boolean Fog
		/// </summary>
		protected RField r_Fog;
		public virtual RField RFog
		{
			get
			{
				if(r_Fog == null)
				{
					r_Fog = new(this, "Fog");
					r_Fog.SetBelong(this.instance);
				}
				return r_Fog;
			}
		}

		/// <summary>
		/// UnityEngine.Color FogColor
		/// </summary>
		protected RUnityEngine.RColor r_FogColor;
		public virtual RUnityEngine.RColor RFogColor
		{
			get
			{
				if(r_FogColor == null)
				{
					r_FogColor = new(this, "FogColor");
					r_FogColor.SetBelong(this.instance);
				}
				return r_FogColor;
			}
		}

		/// <summary>
		/// System.Single FogDensity
		/// </summary>
		protected RField r_FogDensity;
		public virtual RField RFogDensity
		{
			get
			{
				if(r_FogDensity == null)
				{
					r_FogDensity = new(this, "FogDensity");
					r_FogDensity.SetBelong(this.instance);
				}
				return r_FogDensity;
			}
		}

		/// <summary>
		/// UnityEngine.Color AmbientLight
		/// </summary>
		protected RUnityEngine.RColor r_AmbientLight;
		public virtual RUnityEngine.RColor RAmbientLight
		{
			get
			{
				if(r_AmbientLight == null)
				{
					r_AmbientLight = new(this, "AmbientLight");
					r_AmbientLight.SetBelong(this.instance);
				}
				return r_AmbientLight;
			}
		}

		/// <summary>
		/// System.Int32 FogMode
		/// </summary>
		protected RField r_FogMode;
		public virtual RField RFogMode
		{
			get
			{
				if(r_FogMode == null)
				{
					r_FogMode = new(this, "FogMode");
					r_FogMode.SetBelong(this.instance);
				}
				return r_FogMode;
			}
		}

		/// <summary>
		/// System.Single LinearFogStart
		/// </summary>
		protected RField r_LinearFogStart;
		public virtual RField RLinearFogStart
		{
			get
			{
				if(r_LinearFogStart == null)
				{
					r_LinearFogStart = new(this, "LinearFogStart");
					r_LinearFogStart.SetBelong(this.instance);
				}
				return r_LinearFogStart;
			}
		}

		/// <summary>
		/// System.Single LinearFogEnd
		/// </summary>
		protected RField r_LinearFogEnd;
		public virtual RField RLinearFogEnd
		{
			get
			{
				if(r_LinearFogEnd == null)
				{
					r_LinearFogEnd = new(this, "LinearFogEnd");
					r_LinearFogEnd.SetBelong(this.instance);
				}
				return r_LinearFogEnd;
			}
		}

		/// <summary>
		/// System.Single fieldOfView
		/// </summary>
		protected RField r_fieldOfView;
		public virtual RField RfieldOfView
		{
			get
			{
				if(r_fieldOfView == null)
				{
					r_fieldOfView = new(this, "fieldOfView");
					r_fieldOfView.SetBelong(this.instance);
				}
				return r_fieldOfView;
			}
		}

		/// <summary>
		/// System.String mBattleSpotRes_url
		/// </summary>
		protected RProperty r_mBattleSpotRes_url;
		public virtual RProperty RmBattleSpotRes_url
		{
			get
			{
				if(r_mBattleSpotRes_url == null)
				{
					r_mBattleSpotRes_url = new(this, "mBattleSpotRes_url", -1);
					r_mBattleSpotRes_url.SetBelong(this.instance);
				}
				return r_mBattleSpotRes_url;
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


        public RBattleSpot() : base("BattleSpot")
        {
        }

        public RBattleSpot(System.Object instance) : base("BattleSpot")
		{
            SetInstance(instance);
		}

        public RBattleSpot(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBattleSpot(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
