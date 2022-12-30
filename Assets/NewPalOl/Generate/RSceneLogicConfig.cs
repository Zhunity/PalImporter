using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneLogicConfig
	/// </summary>
    public partial class RSceneLogicConfig : RMember //
    {

		/// <summary>
		/// System.String idScene
		/// </summary>
		protected RField r_idScene;
		public virtual RField RidScene
		{
			get
			{
				if(r_idScene == null)
				{
					r_idScene = new(this, "idScene");
					r_idScene.SetBelong(this.instance);
				}
				return r_idScene;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Int32 SceneLightStyle
		/// </summary>
		protected RField r_SceneLightStyle;
		public virtual RField RSceneLightStyle
		{
			get
			{
				if(r_SceneLightStyle == null)
				{
					r_SceneLightStyle = new(this, "SceneLightStyle");
					r_SceneLightStyle.SetBelong(this.instance);
				}
				return r_SceneLightStyle;
			}
		}

		/// <summary>
		/// System.Int32 PK_Type
		/// </summary>
		protected RField r_PK_Type;
		public virtual RField RPK_Type
		{
			get
			{
				if(r_PK_Type == null)
				{
					r_PK_Type = new(this, "PK_Type");
					r_PK_Type.SetBelong(this.instance);
				}
				return r_PK_Type;
			}
		}

		/// <summary>
		/// System.Boolean ShowLeaveButton
		/// </summary>
		protected RField r_ShowLeaveButton;
		public virtual RField RShowLeaveButton
		{
			get
			{
				if(r_ShowLeaveButton == null)
				{
					r_ShowLeaveButton = new(this, "ShowLeaveButton");
					r_ShowLeaveButton.SetBelong(this.instance);
				}
				return r_ShowLeaveButton;
			}
		}

		/// <summary>
		/// System.Boolean CanOpenWorldMap
		/// </summary>
		protected RField r_CanOpenWorldMap;
		public virtual RField RCanOpenWorldMap
		{
			get
			{
				if(r_CanOpenWorldMap == null)
				{
					r_CanOpenWorldMap = new(this, "CanOpenWorldMap");
					r_CanOpenWorldMap.SetBelong(this.instance);
				}
				return r_CanOpenWorldMap;
			}
		}

		/// <summary>
		/// System.Boolean HideHorse
		/// </summary>
		protected RField r_HideHorse;
		public virtual RField RHideHorse
		{
			get
			{
				if(r_HideHorse == null)
				{
					r_HideHorse = new(this, "HideHorse");
					r_HideHorse.SetBelong(this.instance);
				}
				return r_HideHorse;
			}
		}

		/// <summary>
		/// SceneLogicConfig+PlayerVisibleType ShowPlayerType
		/// </summary>
		protected RField r_ShowPlayerType;
		public virtual RField RShowPlayerType
		{
			get
			{
				if(r_ShowPlayerType == null)
				{
					r_ShowPlayerType = new(this, "ShowPlayerType");
					r_ShowPlayerType.SetBelong(this.instance);
				}
				return r_ShowPlayerType;
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
		/// SceneLogicConfig+MapType maptype
		/// </summary>
		protected RField r_maptype;
		public virtual RField Rmaptype
		{
			get
			{
				if(r_maptype == null)
				{
					r_maptype = new(this, "maptype");
					r_maptype.SetBelong(this.instance);
				}
				return r_maptype;
			}
		}

		/// <summary>
		/// System.Int32 mapstorage
		/// </summary>
		protected RField r_mapstorage;
		public virtual RField Rmapstorage
		{
			get
			{
				if(r_mapstorage == null)
				{
					r_mapstorage = new(this, "mapstorage");
					r_mapstorage.SetBelong(this.instance);
				}
				return r_mapstorage;
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
		/// UnityEngine.Vector3 NorthEastPos
		/// </summary>
		protected RUnityEngine.RVector3 r_NorthEastPos;
		public virtual RUnityEngine.RVector3 RNorthEastPos
		{
			get
			{
				if(r_NorthEastPos == null)
				{
					r_NorthEastPos = new(this, "NorthEastPos");
					r_NorthEastPos.SetBelong(this.instance);
				}
				return r_NorthEastPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 SouthWestPos
		/// </summary>
		protected RUnityEngine.RVector3 r_SouthWestPos;
		public virtual RUnityEngine.RVector3 RSouthWestPos
		{
			get
			{
				if(r_SouthWestPos == null)
				{
					r_SouthWestPos = new(this, "SouthWestPos");
					r_SouthWestPos.SetBelong(this.instance);
				}
				return r_SouthWestPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MinMapNorthEastPos
		/// </summary>
		protected RUnityEngine.RVector2 r_MinMapNorthEastPos;
		public virtual RUnityEngine.RVector2 RMinMapNorthEastPos
		{
			get
			{
				if(r_MinMapNorthEastPos == null)
				{
					r_MinMapNorthEastPos = new(this, "MinMapNorthEastPos");
					r_MinMapNorthEastPos.SetBelong(this.instance);
				}
				return r_MinMapNorthEastPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MinMapSouthWestPos
		/// </summary>
		protected RUnityEngine.RVector2 r_MinMapSouthWestPos;
		public virtual RUnityEngine.RVector2 RMinMapSouthWestPos
		{
			get
			{
				if(r_MinMapSouthWestPos == null)
				{
					r_MinMapSouthWestPos = new(this, "MinMapSouthWestPos");
					r_MinMapSouthWestPos.SetBelong(this.instance);
				}
				return r_MinMapSouthWestPos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SceneSoundConfig] mScenePositionSound
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> r_mScenePositionSound;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> RmScenePositionSound
		{
			get
			{
				if(r_mScenePositionSound == null)
				{
					r_mScenePositionSound = new(this, "mScenePositionSound");
					r_mScenePositionSound.SetBelong(this.instance);
				}
				return r_mScenePositionSound;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SceneSoundConfig] mSceneBGSoundList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> r_mSceneBGSoundList;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneSoundConfig> RmSceneBGSoundList
		{
			get
			{
				if(r_mSceneBGSoundList == null)
				{
					r_mSceneBGSoundList = new(this, "mSceneBGSoundList");
					r_mSceneBGSoundList.SetBelong(this.instance);
				}
				return r_mSceneBGSoundList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleSpot] mBattleSpot
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleSpot> r_mBattleSpot;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleSpot> RmBattleSpot
		{
			get
			{
				if(r_mBattleSpot == null)
				{
					r_mBattleSpot = new(this, "mBattleSpot");
					r_mBattleSpot.SetBelong(this.instance);
				}
				return r_mBattleSpot;
			}
		}

		/// <summary>
		/// SceneMapResource mMiniMapRes
		/// </summary>
		protected RSceneMapResource r_mMiniMapRes;
		public virtual RSceneMapResource RmMiniMapRes
		{
			get
			{
				if(r_mMiniMapRes == null)
				{
					r_mMiniMapRes = new(this, "mMiniMapRes");
					r_mMiniMapRes.SetBelong(this.instance);
				}
				return r_mMiniMapRes;
			}
		}

		/// <summary>
		/// SceneMapResource mAreaMapRes
		/// </summary>
		protected RSceneMapResource r_mAreaMapRes;
		public virtual RSceneMapResource RmAreaMapRes
		{
			get
			{
				if(r_mAreaMapRes == null)
				{
					r_mAreaMapRes = new(this, "mAreaMapRes");
					r_mAreaMapRes.SetBelong(this.instance);
				}
				return r_mAreaMapRes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,TransformInfo] mTransPoins
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTransformInfo> r_mTransPoins;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTransformInfo> RmTransPoins
		{
			get
			{
				if(r_mTransPoins == null)
				{
					r_mTransPoins = new(this, "mTransPoins");
					r_mTransPoins.SetBelong(this.instance);
				}
				return r_mTransPoins;
			}
		}

		/// <summary>
		/// System.Boolean HasLoadingBG
		/// </summary>
		protected RField r_HasLoadingBG;
		public virtual RField RHasLoadingBG
		{
			get
			{
				if(r_HasLoadingBG == null)
				{
					r_HasLoadingBG = new(this, "HasLoadingBG");
					r_HasLoadingBG.SetBelong(this.instance);
				}
				return r_HasLoadingBG;
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


        public RSceneLogicConfig() : base("SceneLogicConfig")
        {
        }

        public RSceneLogicConfig(System.Object instance) : base("SceneLogicConfig")
		{
            SetInstance(instance);
		}

        public RSceneLogicConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneLogicConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
