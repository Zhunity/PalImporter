using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieManager
	/// </summary>
    public partial class RSceneMovieManager : RMember //
    {

		/// <summary>
		/// System.Boolean _bEnableFollow
		/// </summary>
		protected RField r__bEnableFollow;
		public virtual RField R_bEnableFollow
		{
			get
			{
				if(r__bEnableFollow == null)
				{
					r__bEnableFollow = new(this, "_bEnableFollow");
					r__bEnableFollow.SetBelong(this.instance);
				}
				return r__bEnableFollow;
			}
		}

		/// <summary>
		/// System.Int32 MOVIE_CULL_LAYER
		/// </summary>
		protected static RField r_MOVIE_CULL_LAYER;
		public static RField RMOVIE_CULL_LAYER
		{
			get
			{
				if(r_MOVIE_CULL_LAYER == null)
				{
					r_MOVIE_CULL_LAYER = new( ReleactionUtils.GetType("SceneMovieManager"), "MOVIE_CULL_LAYER");
					r_MOVIE_CULL_LAYER.SetBelong(null);
				}
				return r_MOVIE_CULL_LAYER;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_UnitsNode
		/// </summary>
		protected RUnityEngine.RGameObject r_m_UnitsNode;
		public virtual RUnityEngine.RGameObject Rm_UnitsNode
		{
			get
			{
				if(r_m_UnitsNode == null)
				{
					r_m_UnitsNode = new(this, "m_UnitsNode");
					r_m_UnitsNode.SetBelong(this.instance);
				}
				return r_m_UnitsNode;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_SceneMovieNode
		/// </summary>
		protected RUnityEngine.RGameObject r_m_SceneMovieNode;
		public virtual RUnityEngine.RGameObject Rm_SceneMovieNode
		{
			get
			{
				if(r_m_SceneMovieNode == null)
				{
					r_m_SceneMovieNode = new(this, "m_SceneMovieNode");
					r_m_SceneMovieNode.SetBelong(this.instance);
				}
				return r_m_SceneMovieNode;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_DialogNode
		/// </summary>
		protected RUnityEngine.RGameObject r_m_DialogNode;
		public virtual RUnityEngine.RGameObject Rm_DialogNode
		{
			get
			{
				if(r_m_DialogNode == null)
				{
					r_m_DialogNode = new(this, "m_DialogNode");
					r_m_DialogNode.SetBelong(this.instance);
				}
				return r_m_DialogNode;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_WeaponNode
		/// </summary>
		protected RUnityEngine.RGameObject r_m_WeaponNode;
		public virtual RUnityEngine.RGameObject Rm_WeaponNode
		{
			get
			{
				if(r_m_WeaponNode == null)
				{
					r_m_WeaponNode = new(this, "m_WeaponNode");
					r_m_WeaponNode.SetBelong(this.instance);
				}
				return r_m_WeaponNode;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_LocalPlayer
		/// </summary>
		protected RUnityEngine.RGameObject r_m_LocalPlayer;
		public virtual RUnityEngine.RGameObject Rm_LocalPlayer
		{
			get
			{
				if(r_m_LocalPlayer == null)
				{
					r_m_LocalPlayer = new(this, "m_LocalPlayer");
					r_m_LocalPlayer.SetBelong(this.instance);
				}
				return r_m_LocalPlayer;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_RainEff
		/// </summary>
		protected RUnityEngine.RGameObject r_m_RainEff;
		public virtual RUnityEngine.RGameObject Rm_RainEff
		{
			get
			{
				if(r_m_RainEff == null)
				{
					r_m_RainEff = new(this, "m_RainEff");
					r_m_RainEff.SetBelong(this.instance);
				}
				return r_m_RainEff;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_bakPlayerPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_m_bakPlayerPosition;
		public virtual RUnityEngine.RVector3 Rm_bakPlayerPosition
		{
			get
			{
				if(r_m_bakPlayerPosition == null)
				{
					r_m_bakPlayerPosition = new(this, "m_bakPlayerPosition");
					r_m_bakPlayerPosition.SetBelong(this.instance);
				}
				return r_m_bakPlayerPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion m_bakPlayerRotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_m_bakPlayerRotation;
		public virtual RUnityEngine.RQuaternion Rm_bakPlayerRotation
		{
			get
			{
				if(r_m_bakPlayerRotation == null)
				{
					r_m_bakPlayerRotation = new(this, "m_bakPlayerRotation");
					r_m_bakPlayerRotation.SetBelong(this.instance);
				}
				return r_m_bakPlayerRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion m_BakCameraRotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_m_BakCameraRotation;
		public virtual RUnityEngine.RQuaternion Rm_BakCameraRotation
		{
			get
			{
				if(r_m_BakCameraRotation == null)
				{
					r_m_BakCameraRotation = new(this, "m_BakCameraRotation");
					r_m_BakCameraRotation.SetBelong(this.instance);
				}
				return r_m_BakCameraRotation;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[UnityEngine.AnimationClip]] m_MovieNpcAnimLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RAnimationClip>> r_m_MovieNpcAnimLib;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RAnimationClip>> Rm_MovieNpcAnimLib
		{
			get
			{
				if(r_m_MovieNpcAnimLib == null)
				{
					r_m_MovieNpcAnimLib = new(this, "m_MovieNpcAnimLib");
					r_m_MovieNpcAnimLib.SetBelong(this.instance);
				}
				return r_m_MovieNpcAnimLib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.GameObject] m_MovieAssetLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> r_m_MovieAssetLib;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> Rm_MovieAssetLib
		{
			get
			{
				if(r_m_MovieAssetLib == null)
				{
					r_m_MovieAssetLib = new(this, "m_MovieAssetLib");
					r_m_MovieAssetLib.SetBelong(this.instance);
				}
				return r_m_MovieAssetLib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,SceneMovieManager+WeaponAsset] m_WeaponAssetsLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSceneMovieManager.RWeaponAsset> r_m_WeaponAssetsLib;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSceneMovieManager.RWeaponAsset> Rm_WeaponAssetsLib
		{
			get
			{
				if(r_m_WeaponAssetsLib == null)
				{
					r_m_WeaponAssetsLib = new(this, "m_WeaponAssetsLib");
					r_m_WeaponAssetsLib.SetBelong(this.instance);
				}
				return r_m_WeaponAssetsLib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_NeedToUnload
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_NeedToUnload;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_NeedToUnload
		{
			get
			{
				if(r_m_NeedToUnload == null)
				{
					r_m_NeedToUnload = new(this, "m_NeedToUnload");
					r_m_NeedToUnload.SetBelong(this.instance);
				}
				return r_m_NeedToUnload;
			}
		}

		/// <summary>
		/// SceneMovieConfig m_MovieConfig
		/// </summary>
		protected RSceneMovieConfig r_m_MovieConfig;
		public virtual RSceneMovieConfig Rm_MovieConfig
		{
			get
			{
				if(r_m_MovieConfig == null)
				{
					r_m_MovieConfig = new(this, "m_MovieConfig");
					r_m_MovieConfig.SetBelong(this.instance);
				}
				return r_m_MovieConfig;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_curShowWnds
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_curShowWnds;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_curShowWnds
		{
			get
			{
				if(r_m_curShowWnds == null)
				{
					r_m_curShowWnds = new(this, "m_curShowWnds");
					r_m_curShowWnds.SetBelong(this.instance);
				}
				return r_m_curShowWnds;
			}
		}

		/// <summary>
		/// System.Int32 m_nCurrCmdIdx
		/// </summary>
		protected RField r_m_nCurrCmdIdx;
		public virtual RField Rm_nCurrCmdIdx
		{
			get
			{
				if(r_m_nCurrCmdIdx == null)
				{
					r_m_nCurrCmdIdx = new(this, "m_nCurrCmdIdx");
					r_m_nCurrCmdIdx.SetBelong(this.instance);
				}
				return r_m_nCurrCmdIdx;
			}
		}

		/// <summary>
		/// System.Single m_TimeCurrCmdUse
		/// </summary>
		protected RField r_m_TimeCurrCmdUse;
		public virtual RField Rm_TimeCurrCmdUse
		{
			get
			{
				if(r_m_TimeCurrCmdUse == null)
				{
					r_m_TimeCurrCmdUse = new(this, "m_TimeCurrCmdUse");
					r_m_TimeCurrCmdUse.SetBelong(this.instance);
				}
				return r_m_TimeCurrCmdUse;
			}
		}

		/// <summary>
		/// System.Int32 m_nOriFieldOfView
		/// </summary>
		protected RField r_m_nOriFieldOfView;
		public virtual RField Rm_nOriFieldOfView
		{
			get
			{
				if(r_m_nOriFieldOfView == null)
				{
					r_m_nOriFieldOfView = new(this, "m_nOriFieldOfView");
					r_m_nOriFieldOfView.SetBelong(this.instance);
				}
				return r_m_nOriFieldOfView;
			}
		}

		/// <summary>
		/// System.Single m_fOriCameraFarClip
		/// </summary>
		protected RField r_m_fOriCameraFarClip;
		public virtual RField Rm_fOriCameraFarClip
		{
			get
			{
				if(r_m_fOriCameraFarClip == null)
				{
					r_m_fOriCameraFarClip = new(this, "m_fOriCameraFarClip");
					r_m_fOriCameraFarClip.SetBelong(this.instance);
				}
				return r_m_fOriCameraFarClip;
			}
		}

		/// <summary>
		/// System.Boolean m_bBakFog
		/// </summary>
		protected RField r_m_bBakFog;
		public virtual RField Rm_bBakFog
		{
			get
			{
				if(r_m_bBakFog == null)
				{
					r_m_bBakFog = new(this, "m_bBakFog");
					r_m_bBakFog.SetBelong(this.instance);
				}
				return r_m_bBakFog;
			}
		}

		/// <summary>
		/// System.Boolean m_bEndBlack
		/// </summary>
		protected RField r_m_bEndBlack;
		public virtual RField Rm_bEndBlack
		{
			get
			{
				if(r_m_bEndBlack == null)
				{
					r_m_bEndBlack = new(this, "m_bEndBlack");
					r_m_bEndBlack.SetBelong(this.instance);
				}
				return r_m_bEndBlack;
			}
		}

		/// <summary>
		/// System.Boolean m_bBeginBlack
		/// </summary>
		protected RField r_m_bBeginBlack;
		public virtual RField Rm_bBeginBlack
		{
			get
			{
				if(r_m_bBeginBlack == null)
				{
					r_m_bBeginBlack = new(this, "m_bBeginBlack");
					r_m_bBeginBlack.SetBelong(this.instance);
				}
				return r_m_bBeginBlack;
			}
		}

		/// <summary>
		/// System.Boolean m_bForceEnd
		/// </summary>
		protected RField r_m_bForceEnd;
		public virtual RField Rm_bForceEnd
		{
			get
			{
				if(r_m_bForceEnd == null)
				{
					r_m_bForceEnd = new(this, "m_bForceEnd");
					r_m_bForceEnd.SetBelong(this.instance);
				}
				return r_m_bForceEnd;
			}
		}

		/// <summary>
		/// System.Boolean m_bMovieIdle
		/// </summary>
		protected RField r_m_bMovieIdle;
		public virtual RField Rm_bMovieIdle
		{
			get
			{
				if(r_m_bMovieIdle == null)
				{
					r_m_bMovieIdle = new(this, "m_bMovieIdle");
					r_m_bMovieIdle.SetBelong(this.instance);
				}
				return r_m_bMovieIdle;
			}
		}

		/// <summary>
		/// System.Boolean m_bPressSKIP
		/// </summary>
		protected RField r_m_bPressSKIP;
		public virtual RField Rm_bPressSKIP
		{
			get
			{
				if(r_m_bPressSKIP == null)
				{
					r_m_bPressSKIP = new(this, "m_bPressSKIP");
					r_m_bPressSKIP.SetBelong(this.instance);
				}
				return r_m_bPressSKIP;
			}
		}

		/// <summary>
		/// System.String m_CurrentMovieEventName
		/// </summary>
		protected RField r_m_CurrentMovieEventName;
		public virtual RField Rm_CurrentMovieEventName
		{
			get
			{
				if(r_m_CurrentMovieEventName == null)
				{
					r_m_CurrentMovieEventName = new(this, "m_CurrentMovieEventName");
					r_m_CurrentMovieEventName.SetBelong(this.instance);
				}
				return r_m_CurrentMovieEventName;
			}
		}

		/// <summary>
		/// System.String m_CurrentMovieName
		/// </summary>
		protected RField r_m_CurrentMovieName;
		public virtual RField Rm_CurrentMovieName
		{
			get
			{
				if(r_m_CurrentMovieName == null)
				{
					r_m_CurrentMovieName = new(this, "m_CurrentMovieName");
					r_m_CurrentMovieName.SetBelong(this.instance);
				}
				return r_m_CurrentMovieName;
			}
		}

		/// <summary>
		/// System.String m_CurrentMusicName
		/// </summary>
		protected RField r_m_CurrentMusicName;
		public virtual RField Rm_CurrentMusicName
		{
			get
			{
				if(r_m_CurrentMusicName == null)
				{
					r_m_CurrentMusicName = new(this, "m_CurrentMusicName");
					r_m_CurrentMusicName.SetBelong(this.instance);
				}
				return r_m_CurrentMusicName;
			}
		}

		/// <summary>
		/// SceneMovieClip m_CurrentClip
		/// </summary>
		protected RSceneMovieClip r_m_CurrentClip;
		public virtual RSceneMovieClip Rm_CurrentClip
		{
			get
			{
				if(r_m_CurrentClip == null)
				{
					r_m_CurrentClip = new(this, "m_CurrentClip");
					r_m_CurrentClip.SetBelong(this.instance);
				}
				return r_m_CurrentClip;
			}
		}

		/// <summary>
		/// SceneMovieCommand m_CurrentCmd
		/// </summary>
		protected RSceneMovieCommand r_m_CurrentCmd;
		public virtual RSceneMovieCommand Rm_CurrentCmd
		{
			get
			{
				if(r_m_CurrentCmd == null)
				{
					r_m_CurrentCmd = new(this, "m_CurrentCmd");
					r_m_CurrentCmd.SetBelong(this.instance);
				}
				return r_m_CurrentCmd;
			}
		}

		/// <summary>
		/// SceneMovieUnitManager m_UnitManager
		/// </summary>
		protected RSceneMovieUnitManager r_m_UnitManager;
		public virtual RSceneMovieUnitManager Rm_UnitManager
		{
			get
			{
				if(r_m_UnitManager == null)
				{
					r_m_UnitManager = new(this, "m_UnitManager");
					r_m_UnitManager.SetBelong(this.instance);
				}
				return r_m_UnitManager;
			}
		}

		/// <summary>
		/// SceneMovieEffectManager m_EffectManager
		/// </summary>
		protected RSceneMovieEffectManager r_m_EffectManager;
		public virtual RSceneMovieEffectManager Rm_EffectManager
		{
			get
			{
				if(r_m_EffectManager == null)
				{
					r_m_EffectManager = new(this, "m_EffectManager");
					r_m_EffectManager.SetBelong(this.instance);
				}
				return r_m_EffectManager;
			}
		}

		/// <summary>
		/// SceneMovieDialogManager m_DialogManager
		/// </summary>
		protected RSceneMovieDialogManager r_m_DialogManager;
		public virtual RSceneMovieDialogManager Rm_DialogManager
		{
			get
			{
				if(r_m_DialogManager == null)
				{
					r_m_DialogManager = new(this, "m_DialogManager");
					r_m_DialogManager.SetBelong(this.instance);
				}
				return r_m_DialogManager;
			}
		}

		/// <summary>
		/// SceneMovieCameraEffManager m_CameraEffManager
		/// </summary>
		protected RSceneMovieCameraEffManager r_m_CameraEffManager;
		public virtual RSceneMovieCameraEffManager Rm_CameraEffManager
		{
			get
			{
				if(r_m_CameraEffManager == null)
				{
					r_m_CameraEffManager = new(this, "m_CameraEffManager");
					r_m_CameraEffManager.SetBelong(this.instance);
				}
				return r_m_CameraEffManager;
			}
		}

		/// <summary>
		/// SceneMovieManager+SceneMovieState m_CurrentState
		/// </summary>
		protected RField r_m_CurrentState;
		public virtual RField Rm_CurrentState
		{
			get
			{
				if(r_m_CurrentState == null)
				{
					r_m_CurrentState = new(this, "m_CurrentState");
					r_m_CurrentState.SetBelong(this.instance);
				}
				return r_m_CurrentState;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_AssetUrls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_AssetUrls;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_AssetUrls
		{
			get
			{
				if(r_m_AssetUrls == null)
				{
					r_m_AssetUrls = new(this, "m_AssetUrls");
					r_m_AssetUrls.SetBelong(this.instance);
				}
				return r_m_AssetUrls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_AssetLoadedUrls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_AssetLoadedUrls;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_AssetLoadedUrls
		{
			get
			{
				if(r_m_AssetLoadedUrls == null)
				{
					r_m_AssetLoadedUrls = new(this, "m_AssetLoadedUrls");
					r_m_AssetLoadedUrls.SetBelong(this.instance);
				}
				return r_m_AssetLoadedUrls;
			}
		}

		/// <summary>
		/// System.Boolean m_bLoadDefaultWeapon
		/// </summary>
		protected RField r_m_bLoadDefaultWeapon;
		public virtual RField Rm_bLoadDefaultWeapon
		{
			get
			{
				if(r_m_bLoadDefaultWeapon == null)
				{
					r_m_bLoadDefaultWeapon = new(this, "m_bLoadDefaultWeapon");
					r_m_bLoadDefaultWeapon.SetBelong(this.instance);
				}
				return r_m_bLoadDefaultWeapon;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[CAMERA_PARAM]] m_CameraGroups
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RCAMERA_PARAM>> r_m_CameraGroups;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RCAMERA_PARAM>> Rm_CameraGroups
		{
			get
			{
				if(r_m_CameraGroups == null)
				{
					r_m_CameraGroups = new(this, "m_CameraGroups");
					r_m_CameraGroups.SetBelong(this.instance);
				}
				return r_m_CameraGroups;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_PlayedMovieList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_PlayedMovieList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_PlayedMovieList
		{
			get
			{
				if(r_m_PlayedMovieList == null)
				{
					r_m_PlayedMovieList = new(this, "m_PlayedMovieList");
					r_m_PlayedMovieList.SetBelong(this.instance);
				}
				return r_m_PlayedMovieList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,MOVIE_REPLAY_CONFIG] m_MovieReplayList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RMOVIE_REPLAY_CONFIG> r_m_MovieReplayList;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RMOVIE_REPLAY_CONFIG> Rm_MovieReplayList
		{
			get
			{
				if(r_m_MovieReplayList == null)
				{
					r_m_MovieReplayList = new(this, "m_MovieReplayList");
					r_m_MovieReplayList.SetBelong(this.instance);
				}
				return r_m_MovieReplayList;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_TmpCameraEffectObj
		/// </summary>
		protected RUnityEngine.RGameObject r_m_TmpCameraEffectObj;
		public virtual RUnityEngine.RGameObject Rm_TmpCameraEffectObj
		{
			get
			{
				if(r_m_TmpCameraEffectObj == null)
				{
					r_m_TmpCameraEffectObj = new(this, "m_TmpCameraEffectObj");
					r_m_TmpCameraEffectObj.SetBelong(this.instance);
				}
				return r_m_TmpCameraEffectObj;
			}
		}

		/// <summary>
		/// System.Boolean m_bSkip
		/// </summary>
		protected RField r_m_bSkip;
		public virtual RField Rm_bSkip
		{
			get
			{
				if(r_m_bSkip == null)
				{
					r_m_bSkip = new(this, "m_bSkip");
					r_m_bSkip.SetBelong(this.instance);
				}
				return r_m_bSkip;
			}
		}

		/// <summary>
		/// System.String m_CurrCameraGroupName
		/// </summary>
		protected RField r_m_CurrCameraGroupName;
		public virtual RField Rm_CurrCameraGroupName
		{
			get
			{
				if(r_m_CurrCameraGroupName == null)
				{
					r_m_CurrCameraGroupName = new(this, "m_CurrCameraGroupName");
					r_m_CurrCameraGroupName.SetBelong(this.instance);
				}
				return r_m_CurrCameraGroupName;
			}
		}

		/// <summary>
		/// System.Int32 m_nFrameCount
		/// </summary>
		protected RField r_m_nFrameCount;
		public virtual RField Rm_nFrameCount
		{
			get
			{
				if(r_m_nFrameCount == null)
				{
					r_m_nFrameCount = new(this, "m_nFrameCount");
					r_m_nFrameCount.SetBelong(this.instance);
				}
				return r_m_nFrameCount;
			}
		}

		/// <summary>
		/// System.Single m_Accum
		/// </summary>
		protected RField r_m_Accum;
		public virtual RField Rm_Accum
		{
			get
			{
				if(r_m_Accum == null)
				{
					r_m_Accum = new(this, "m_Accum");
					r_m_Accum.SetBelong(this.instance);
				}
				return r_m_Accum;
			}
		}

		/// <summary>
		/// System.Single m_fLastSample
		/// </summary>
		protected RField r_m_fLastSample;
		public virtual RField Rm_fLastSample
		{
			get
			{
				if(r_m_fLastSample == null)
				{
					r_m_fLastSample = new(this, "m_fLastSample");
					r_m_fLastSample.SetBelong(this.instance);
				}
				return r_m_fLastSample;
			}
		}

		/// <summary>
		/// System.Single m_fTimeLeft
		/// </summary>
		protected RField r_m_fTimeLeft;
		public virtual RField Rm_fTimeLeft
		{
			get
			{
				if(r_m_fTimeLeft == null)
				{
					r_m_fTimeLeft = new(this, "m_fTimeLeft");
					r_m_fTimeLeft.SetBelong(this.instance);
				}
				return r_m_fTimeLeft;
			}
		}

		/// <summary>
		/// System.Single m_fFPS
		/// </summary>
		protected RField r_m_fFPS;
		public virtual RField Rm_fFPS
		{
			get
			{
				if(r_m_fFPS == null)
				{
					r_m_fFPS = new(this, "m_fFPS");
					r_m_fFPS.SetBelong(this.instance);
				}
				return r_m_fFPS;
			}
		}

		/// <summary>
		/// System.Boolean m_bStopInBattle
		/// </summary>
		protected RField r_m_bStopInBattle;
		public virtual RField Rm_bStopInBattle
		{
			get
			{
				if(r_m_bStopInBattle == null)
				{
					r_m_bStopInBattle = new(this, "m_bStopInBattle");
					r_m_bStopInBattle.SetBelong(this.instance);
				}
				return r_m_bStopInBattle;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_ReplaySceneID
		/// </summary>
		protected RGameDefineType.RID r_m_ReplaySceneID;
		public virtual RGameDefineType.RID Rm_ReplaySceneID
		{
			get
			{
				if(r_m_ReplaySceneID == null)
				{
					r_m_ReplaySceneID = new(this, "m_ReplaySceneID");
					r_m_ReplaySceneID.SetBelong(this.instance);
				}
				return r_m_ReplaySceneID;
			}
		}

		/// <summary>
		/// System.Boolean m_bReplayMovie
		/// </summary>
		protected RField r_m_bReplayMovie;
		public virtual RField Rm_bReplayMovie
		{
			get
			{
				if(r_m_bReplayMovie == null)
				{
					r_m_bReplayMovie = new(this, "m_bReplayMovie");
					r_m_bReplayMovie.SetBelong(this.instance);
				}
				return r_m_bReplayMovie;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_ReplayNode
		/// </summary>
		protected RUnityEngine.RGameObject r_m_ReplayNode;
		public virtual RUnityEngine.RGameObject Rm_ReplayNode
		{
			get
			{
				if(r_m_ReplayNode == null)
				{
					r_m_ReplayNode = new(this, "m_ReplayNode");
					r_m_ReplayNode.SetBelong(this.instance);
				}
				return r_m_ReplayNode;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_SkipStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_SkipStyle;
		public virtual RUnityEngine.RGUIStyle Rm_SkipStyle
		{
			get
			{
				if(r_m_SkipStyle == null)
				{
					r_m_SkipStyle = new(this, "m_SkipStyle");
					r_m_SkipStyle.SetBelong(this.instance);
				}
				return r_m_SkipStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_SkipBtnSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_SkipBtnSize;
		public virtual RUnityEngine.RVector2 Rm_SkipBtnSize
		{
			get
			{
				if(r_m_SkipBtnSize == null)
				{
					r_m_SkipBtnSize = new(this, "m_SkipBtnSize");
					r_m_SkipBtnSize.SetBelong(this.instance);
				}
				return r_m_SkipBtnSize;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_RectSkipBtn
		/// </summary>
		protected RUnityEngine.RRect r_m_RectSkipBtn;
		public virtual RUnityEngine.RRect Rm_RectSkipBtn
		{
			get
			{
				if(r_m_RectSkipBtn == null)
				{
					r_m_RectSkipBtn = new(this, "m_RectSkipBtn");
					r_m_RectSkipBtn.SetBelong(this.instance);
				}
				return r_m_RectSkipBtn;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map33
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map33;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map33
		{
			get
			{
				if(r___2____4__f__switch__9__map33 == null)
				{
					r___2____4__f__switch__9__map33 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map33");
					r___2____4__f__switch__9__map33.SetBelong(null);
				}
				return r___2____4__f__switch__9__map33;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map34
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map34;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map34
		{
			get
			{
				if(r___2____4__f__switch__9__map34 == null)
				{
					r___2____4__f__switch__9__map34 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map34");
					r___2____4__f__switch__9__map34.SetBelong(null);
				}
				return r___2____4__f__switch__9__map34;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map35
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map35;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map35
		{
			get
			{
				if(r___2____4__f__switch__9__map35 == null)
				{
					r___2____4__f__switch__9__map35 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map35");
					r___2____4__f__switch__9__map35.SetBelong(null);
				}
				return r___2____4__f__switch__9__map35;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map36
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map36;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map36
		{
			get
			{
				if(r___2____4__f__switch__9__map36 == null)
				{
					r___2____4__f__switch__9__map36 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map36");
					r___2____4__f__switch__9__map36.SetBelong(null);
				}
				return r___2____4__f__switch__9__map36;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map37
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map37;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map37
		{
			get
			{
				if(r___2____4__f__switch__9__map37 == null)
				{
					r___2____4__f__switch__9__map37 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map37");
					r___2____4__f__switch__9__map37.SetBelong(null);
				}
				return r___2____4__f__switch__9__map37;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map38
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map38;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map38
		{
			get
			{
				if(r___2____4__f__switch__9__map38 == null)
				{
					r___2____4__f__switch__9__map38 = new( ReleactionUtils.GetType("SceneMovieManager"), "<>f__switch$map38");
					r___2____4__f__switch__9__map38.SetBelong(null);
				}
				return r___2____4__f__switch__9__map38;
			}
		}

		/// <summary>
		/// Boolean EnableFollow
		/// </summary>
		protected RProperty r_EnableFollow;
		public virtual RProperty REnableFollow
		{
			get
			{
				if(r_EnableFollow == null)
				{
					r_EnableFollow = new(this, "EnableFollow", -1);
					r_EnableFollow.SetBelong(this.instance);
				}
				return r_EnableFollow;
			}
		}

		/// <summary>
		/// Boolean IsSceneMoviePlaying
		/// </summary>
		protected RProperty r_IsSceneMoviePlaying;
		public virtual RProperty RIsSceneMoviePlaying
		{
			get
			{
				if(r_IsSceneMoviePlaying == null)
				{
					r_IsSceneMoviePlaying = new(this, "IsSceneMoviePlaying", -1);
					r_IsSceneMoviePlaying.SetBelong(this.instance);
				}
				return r_IsSceneMoviePlaying;
			}
		}

		/// <summary>
		/// Boolean IsSceneMoviePlayingAndWaiting
		/// </summary>
		protected RProperty r_IsSceneMoviePlayingAndWaiting;
		public virtual RProperty RIsSceneMoviePlayingAndWaiting
		{
			get
			{
				if(r_IsSceneMoviePlayingAndWaiting == null)
				{
					r_IsSceneMoviePlayingAndWaiting = new(this, "IsSceneMoviePlayingAndWaiting", -1);
					r_IsSceneMoviePlayingAndWaiting.SetBelong(this.instance);
				}
				return r_IsSceneMoviePlayingAndWaiting;
			}
		}

		/// <summary>
		/// Boolean IsSceneMovieLoading
		/// </summary>
		protected RProperty r_IsSceneMovieLoading;
		public virtual RProperty RIsSceneMovieLoading
		{
			get
			{
				if(r_IsSceneMovieLoading == null)
				{
					r_IsSceneMovieLoading = new(this, "IsSceneMovieLoading", -1);
					r_IsSceneMovieLoading.SetBelong(this.instance);
				}
				return r_IsSceneMovieLoading;
			}
		}

		/// <summary>
		/// Boolean IsReadyToUse
		/// </summary>
		protected RProperty r_IsReadyToUse;
		public virtual RProperty RIsReadyToUse
		{
			get
			{
				if(r_IsReadyToUse == null)
				{
					r_IsReadyToUse = new(this, "IsReadyToUse", -1);
					r_IsReadyToUse.SetBelong(this.instance);
				}
				return r_IsReadyToUse;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken destroyCancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_destroyCancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RdestroyCancellationToken
		{
			get
			{
				if(r_destroyCancellationToken == null)
				{
					r_destroyCancellationToken = new(this, "destroyCancellationToken", -1);
					r_destroyCancellationToken.SetBelong(this.instance);
				}
				return r_destroyCancellationToken;
			}
		}

		/// <summary>
		/// Boolean useGUILayout
		/// </summary>
		protected RProperty r_useGUILayout;
		public virtual RProperty RuseGUILayout
		{
			get
			{
				if(r_useGUILayout == null)
				{
					r_useGUILayout = new(this, "useGUILayout", -1);
					r_useGUILayout.SetBelong(this.instance);
				}
				return r_useGUILayout;
			}
		}

		/// <summary>
		/// Boolean runInEditMode
		/// </summary>
		protected RProperty r_runInEditMode;
		public virtual RProperty RrunInEditMode
		{
			get
			{
				if(r_runInEditMode == null)
				{
					r_runInEditMode = new(this, "runInEditMode", -1);
					r_runInEditMode.SetBelong(this.instance);
				}
				return r_runInEditMode;
			}
		}

		/// <summary>
		/// Boolean allowPrefabModeInPlayMode
		/// </summary>
		protected RProperty r_allowPrefabModeInPlayMode;
		public virtual RProperty RallowPrefabModeInPlayMode
		{
			get
			{
				if(r_allowPrefabModeInPlayMode == null)
				{
					r_allowPrefabModeInPlayMode = new(this, "allowPrefabModeInPlayMode", -1);
					r_allowPrefabModeInPlayMode.SetBelong(this.instance);
				}
				return r_allowPrefabModeInPlayMode;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected RProperty r_isActiveAndEnabled;
		public virtual RProperty RisActiveAndEnabled
		{
			get
			{
				if(r_isActiveAndEnabled == null)
				{
					r_isActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
					r_isActiveAndEnabled.SetBelong(this.instance);
				}
				return r_isActiveAndEnabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_transform;
		public virtual RUnityEngine.RTransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_gameObject;
		public virtual RUnityEngine.RGameObject RgameObject
		{
			get
			{
				if(r_gameObject == null)
				{
					r_gameObject = new(this, "gameObject", -1);
					r_gameObject.SetBelong(this.instance);
				}
				return r_gameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected RProperty r_tag;
		public virtual RProperty Rtag
		{
			get
			{
				if(r_tag == null)
				{
					r_tag = new(this, "tag", -1);
					r_tag.SetBelong(this.instance);
				}
				return r_tag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody;
		public virtual RUnityEngine.RComponent Rrigidbody
		{
			get
			{
				if(r_rigidbody == null)
				{
					r_rigidbody = new(this, "rigidbody", -1);
					r_rigidbody.SetBelong(this.instance);
				}
				return r_rigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody2D;
		public virtual RUnityEngine.RComponent Rrigidbody2D
		{
			get
			{
				if(r_rigidbody2D == null)
				{
					r_rigidbody2D = new(this, "rigidbody2D", -1);
					r_rigidbody2D.SetBelong(this.instance);
				}
				return r_rigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected RUnityEngine.RComponent r_camera;
		public virtual RUnityEngine.RComponent Rcamera
		{
			get
			{
				if(r_camera == null)
				{
					r_camera = new(this, "camera", -1);
					r_camera.SetBelong(this.instance);
				}
				return r_camera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected RUnityEngine.RComponent r_light;
		public virtual RUnityEngine.RComponent Rlight
		{
			get
			{
				if(r_light == null)
				{
					r_light = new(this, "light", -1);
					r_light.SetBelong(this.instance);
				}
				return r_light;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected RUnityEngine.RComponent r_animation;
		public virtual RUnityEngine.RComponent Ranimation
		{
			get
			{
				if(r_animation == null)
				{
					r_animation = new(this, "animation", -1);
					r_animation.SetBelong(this.instance);
				}
				return r_animation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected RUnityEngine.RComponent r_constantForce;
		public virtual RUnityEngine.RComponent RconstantForce
		{
			get
			{
				if(r_constantForce == null)
				{
					r_constantForce = new(this, "constantForce", -1);
					r_constantForce.SetBelong(this.instance);
				}
				return r_constantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected RUnityEngine.RComponent r_renderer;
		public virtual RUnityEngine.RComponent Rrenderer
		{
			get
			{
				if(r_renderer == null)
				{
					r_renderer = new(this, "renderer", -1);
					r_renderer.SetBelong(this.instance);
				}
				return r_renderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected RUnityEngine.RComponent r_audio;
		public virtual RUnityEngine.RComponent Raudio
		{
			get
			{
				if(r_audio == null)
				{
					r_audio = new(this, "audio", -1);
					r_audio.SetBelong(this.instance);
				}
				return r_audio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected RUnityEngine.RComponent r_networkView;
		public virtual RUnityEngine.RComponent RnetworkView
		{
			get
			{
				if(r_networkView == null)
				{
					r_networkView = new(this, "networkView", -1);
					r_networkView.SetBelong(this.instance);
				}
				return r_networkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected RUnityEngine.RComponent r_collider;
		public virtual RUnityEngine.RComponent Rcollider
		{
			get
			{
				if(r_collider == null)
				{
					r_collider = new(this, "collider", -1);
					r_collider.SetBelong(this.instance);
				}
				return r_collider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected RUnityEngine.RComponent r_collider2D;
		public virtual RUnityEngine.RComponent Rcollider2D
		{
			get
			{
				if(r_collider2D == null)
				{
					r_collider2D = new(this, "collider2D", -1);
					r_collider2D.SetBelong(this.instance);
				}
				return r_collider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected RUnityEngine.RComponent r_hingeJoint;
		public virtual RUnityEngine.RComponent RhingeJoint
		{
			get
			{
				if(r_hingeJoint == null)
				{
					r_hingeJoint = new(this, "hingeJoint", -1);
					r_hingeJoint.SetBelong(this.instance);
				}
				return r_hingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected RUnityEngine.RComponent r_particleSystem;
		public virtual RUnityEngine.RComponent RparticleSystem
		{
			get
			{
				if(r_particleSystem == null)
				{
					r_particleSystem = new(this, "particleSystem", -1);
					r_particleSystem.SetBelong(this.instance);
				}
				return r_particleSystem;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Boolean IsDebugMovie()
		/// </summary>
		protected RMethod r_RIsDebugMovie;
		public virtual RMethod RIsDebugMovie
		{
			get
			{
				if(r_RIsDebugMovie == null)
				{
					r_RIsDebugMovie = new(this, "IsDebugMovie", 0);
					r_RIsDebugMovie.SetBelong(this.instance);
				}
				return r_RIsDebugMovie;
			}
		}

		/// <summary>
		/// Boolean IsCurrentClipNull()
		/// </summary>
		protected RMethod r_RIsCurrentClipNull;
		public virtual RMethod RIsCurrentClipNull
		{
			get
			{
				if(r_RIsCurrentClipNull == null)
				{
					r_RIsCurrentClipNull = new(this, "IsCurrentClipNull", 0);
					r_RIsCurrentClipNull.SetBelong(this.instance);
				}
				return r_RIsCurrentClipNull;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_RStart;
		public virtual RMethod RStart
		{
			get
			{
				if(r_RStart == null)
				{
					r_RStart = new(this, "Start", 0);
					r_RStart.SetBelong(this.instance);
				}
				return r_RStart;
			}
		}

		/// <summary>
		/// Void EnableMovieManagers(Boolean)
		/// </summary>
		protected RMethod r_REnableMovieManagers_Boolean;
		public virtual RMethod REnableMovieManagers_Boolean
		{
			get
			{
				if(r_REnableMovieManagers_Boolean == null)
				{
					r_REnableMovieManagers_Boolean = new(this, "EnableMovieManagers", 0, typeof(System.Boolean));
					r_REnableMovieManagers_Boolean.SetBelong(this.instance);
				}
				return r_REnableMovieManagers_Boolean;
			}
		}

		/// <summary>
		/// System.String[] GetMovieAssetUrls()
		/// </summary>
		protected RMethod r_RGetMovieAssetUrls;
		public virtual RMethod RGetMovieAssetUrls
		{
			get
			{
				if(r_RGetMovieAssetUrls == null)
				{
					r_RGetMovieAssetUrls = new(this, "GetMovieAssetUrls", 0);
					r_RGetMovieAssetUrls.SetBelong(this.instance);
				}
				return r_RGetMovieAssetUrls;
			}
		}

		/// <summary>
		/// Void AddUrlsToUrlsList(System.String[])
		/// </summary>
		protected RMethod r_RAddUrlsToUrlsList_StringArray;
		public virtual RMethod RAddUrlsToUrlsList_StringArray
		{
			get
			{
				if(r_RAddUrlsToUrlsList_StringArray == null)
				{
					r_RAddUrlsToUrlsList_StringArray = new(this, "AddUrlsToUrlsList", 0, typeof(System.String).MakeArrayType());
					r_RAddUrlsToUrlsList_StringArray.SetBelong(this.instance);
				}
				return r_RAddUrlsToUrlsList_StringArray;
			}
		}

		/// <summary>
		/// Void LoadSingleMovieAsset(SceneMovieClip, GameDefineType.ID, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler = new(this, "LoadSingleMovieAsset", 0, typeof(SceneMovieClip), typeof(GameDefineType.ID),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RLoadSingleMovieAsset_SceneMovieClip_ID_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// GameDefineType.ID GetWeddingNpcID(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetWeddingNpcID_ID;
		public virtual RMethod RGetWeddingNpcID_ID
		{
			get
			{
				if(r_RGetWeddingNpcID_ID == null)
				{
					r_RGetWeddingNpcID_ID = new(this, "GetWeddingNpcID", 0, typeof(GameDefineType.ID));
					r_RGetWeddingNpcID_ID.SetBelong(this.instance);
				}
				return r_RGetWeddingNpcID_ID;
			}
		}

		/// <summary>
		/// System.String GetPortraitName(System.String)
		/// </summary>
		protected RMethod r_RGetPortraitName_String;
		public virtual RMethod RGetPortraitName_String
		{
			get
			{
				if(r_RGetPortraitName_String == null)
				{
					r_RGetPortraitName_String = new(this, "GetPortraitName", 0, typeof(System.String));
					r_RGetPortraitName_String.SetBelong(this.instance);
				}
				return r_RGetPortraitName_String;
			}
		}

		/// <summary>
		/// Void LoadDefaultWeapons()
		/// </summary>
		protected RMethod r_RLoadDefaultWeapons;
		public virtual RMethod RLoadDefaultWeapons
		{
			get
			{
				if(r_RLoadDefaultWeapons == null)
				{
					r_RLoadDefaultWeapons = new(this, "LoadDefaultWeapons", 0);
					r_RLoadDefaultWeapons.SetBelong(this.instance);
				}
				return r_RLoadDefaultWeapons;
			}
		}

		/// <summary>
		/// Void OnGetWeaponRes(System.Object, UnityEngine.GameObject, UnityEngine.GameObject, System.Object)
		/// </summary>
		protected RMethod r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
		public virtual RMethod ROnGetWeaponRes_Object_GameObject_GameObject_Object
		{
			get
			{
				if(r_ROnGetWeaponRes_Object_GameObject_GameObject_Object == null)
				{
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object = new(this, "OnGetWeaponRes", 0, typeof(System.Object), typeof(UnityEngine.GameObject), typeof(UnityEngine.GameObject), typeof(System.Object));
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object.SetBelong(this.instance);
				}
				return r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
			}
		}

		/// <summary>
		/// Void ResetAllWeapon()
		/// </summary>
		protected RMethod r_RResetAllWeapon;
		public virtual RMethod RResetAllWeapon
		{
			get
			{
				if(r_RResetAllWeapon == null)
				{
					r_RResetAllWeapon = new(this, "ResetAllWeapon", 0);
					r_RResetAllWeapon.SetBelong(this.instance);
				}
				return r_RResetAllWeapon;
			}
		}

		/// <summary>
		/// WeaponAsset GetWeaponAsset(System.String)
		/// </summary>
		protected RMethod r_RGetWeaponAsset_String;
		public virtual RMethod RGetWeaponAsset_String
		{
			get
			{
				if(r_RGetWeaponAsset_String == null)
				{
					r_RGetWeaponAsset_String = new(this, "GetWeaponAsset", 0, typeof(System.String));
					r_RGetWeaponAsset_String.SetBelong(this.instance);
				}
				return r_RGetWeaponAsset_String;
			}
		}

		/// <summary>
		/// Void LoadNpcAnimAsset(System.String, System.String, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler = new(this, "LoadNpcAnimAsset", 0, typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RLoadNpcAnimAsset_String_String_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void OnLoadSceneMovieConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadSceneMovieConfig_Object;
		public virtual RMethod ROnLoadSceneMovieConfig_Object
		{
			get
			{
				if(r_ROnLoadSceneMovieConfig_Object == null)
				{
					r_ROnLoadSceneMovieConfig_Object = new(this, "OnLoadSceneMovieConfig", 0, typeof(System.Object));
					r_ROnLoadSceneMovieConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadSceneMovieConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadCameraGroupsConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadCameraGroupsConfig_Object;
		public virtual RMethod ROnLoadCameraGroupsConfig_Object
		{
			get
			{
				if(r_ROnLoadCameraGroupsConfig_Object == null)
				{
					r_ROnLoadCameraGroupsConfig_Object = new(this, "OnLoadCameraGroupsConfig", 0, typeof(System.Object));
					r_ROnLoadCameraGroupsConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadCameraGroupsConfig_Object;
			}
		}

		/// <summary>
		/// Void SetPlayedMovieList(System.String)
		/// </summary>
		protected RMethod r_RSetPlayedMovieList_String;
		public virtual RMethod RSetPlayedMovieList_String
		{
			get
			{
				if(r_RSetPlayedMovieList_String == null)
				{
					r_RSetPlayedMovieList_String = new(this, "SetPlayedMovieList", 0, typeof(System.String));
					r_RSetPlayedMovieList_String.SetBelong(this.instance);
				}
				return r_RSetPlayedMovieList_String;
			}
		}

		/// <summary>
		/// Boolean IsMoviePlayed(Int32)
		/// </summary>
		protected RMethod r_RIsMoviePlayed_Int32;
		public virtual RMethod RIsMoviePlayed_Int32
		{
			get
			{
				if(r_RIsMoviePlayed_Int32 == null)
				{
					r_RIsMoviePlayed_Int32 = new(this, "IsMoviePlayed", 0, typeof(System.Int32));
					r_RIsMoviePlayed_Int32.SetBelong(this.instance);
				}
				return r_RIsMoviePlayed_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadMovieReplayConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadMovieReplayConfig_Object;
		public virtual RMethod ROnLoadMovieReplayConfig_Object
		{
			get
			{
				if(r_ROnLoadMovieReplayConfig_Object == null)
				{
					r_ROnLoadMovieReplayConfig_Object = new(this, "OnLoadMovieReplayConfig", 0, typeof(System.Object));
					r_ROnLoadMovieReplayConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadMovieReplayConfig_Object;
			}
		}

		/// <summary>
		/// Void LoadMovieConfig(SceneMovieNetConfig)
		/// </summary>
		protected RMethod r_RLoadMovieConfig_SceneMovieNetConfig;
		public virtual RMethod RLoadMovieConfig_SceneMovieNetConfig
		{
			get
			{
				if(r_RLoadMovieConfig_SceneMovieNetConfig == null)
				{
					r_RLoadMovieConfig_SceneMovieNetConfig = new(this, "LoadMovieConfig", 0, typeof(SceneMovieNetConfig));
					r_RLoadMovieConfig_SceneMovieNetConfig.SetBelong(this.instance);
				}
				return r_RLoadMovieConfig_SceneMovieNetConfig;
			}
		}

		/// <summary>
		/// Void OnLoadUnit(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadUnit_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadUnit_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadUnit_Object_CGLoadedArgs == null)
				{
					r_ROnLoadUnit_Object_CGLoadedArgs = new(this, "OnLoadUnit", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadUnit_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadUnit_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadNpc(System.Object, #u.#egb)
		/// </summary>
		protected RMethod r_ROnLoadNpc_Object___0__egb;
		public virtual RMethod ROnLoadNpc_Object___0__egb
		{
			get
			{
				if(r_ROnLoadNpc_Object___0__egb == null)
				{
					r_ROnLoadNpc_Object___0__egb = new(this, "OnLoadNpc", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#egb"));
					r_ROnLoadNpc_Object___0__egb.SetBelong(this.instance);
				}
				return r_ROnLoadNpc_Object___0__egb;
			}
		}

		/// <summary>
		/// Void OnLoadNpcAnimAsset(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadNpcAnimAsset_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadNpcAnimAsset_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadNpcAnimAsset_Object_ABLoadedArgs == null)
				{
					r_ROnLoadNpcAnimAsset_Object_ABLoadedArgs = new(this, "OnLoadNpcAnimAsset", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadNpcAnimAsset_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadNpcAnimAsset_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void PrepareNpcAnims()
		/// </summary>
		protected RMethod r_RPrepareNpcAnims;
		public virtual RMethod RPrepareNpcAnims
		{
			get
			{
				if(r_RPrepareNpcAnims == null)
				{
					r_RPrepareNpcAnims = new(this, "PrepareNpcAnims", 0);
					r_RPrepareNpcAnims.SetBelong(this.instance);
				}
				return r_RPrepareNpcAnims;
			}
		}

		/// <summary>
		/// Boolean IsPressEsc()
		/// </summary>
		protected RMethod r_RIsPressEsc;
		public virtual RMethod RIsPressEsc
		{
			get
			{
				if(r_RIsPressEsc == null)
				{
					r_RIsPressEsc = new(this, "IsPressEsc", 0);
					r_RIsPressEsc.SetBelong(this.instance);
				}
				return r_RIsPressEsc;
			}
		}

		/// <summary>
		/// Void ShowMyGUIWindows()
		/// </summary>
		protected RMethod r_RShowMyGUIWindows;
		public virtual RMethod RShowMyGUIWindows
		{
			get
			{
				if(r_RShowMyGUIWindows == null)
				{
					r_RShowMyGUIWindows = new(this, "ShowMyGUIWindows", 0);
					r_RShowMyGUIWindows.SetBelong(this.instance);
				}
				return r_RShowMyGUIWindows;
			}
		}

		/// <summary>
		/// Void CloseMyGUIWindows()
		/// </summary>
		protected RMethod r_RCloseMyGUIWindows;
		public virtual RMethod RCloseMyGUIWindows
		{
			get
			{
				if(r_RCloseMyGUIWindows == null)
				{
					r_RCloseMyGUIWindows = new(this, "CloseMyGUIWindows", 0);
					r_RCloseMyGUIWindows.SetBelong(this.instance);
				}
				return r_RCloseMyGUIWindows;
			}
		}

		/// <summary>
		/// Void AddWndToShowWnds(System.String)
		/// </summary>
		protected RMethod r_RAddWndToShowWnds_String;
		public virtual RMethod RAddWndToShowWnds_String
		{
			get
			{
				if(r_RAddWndToShowWnds_String == null)
				{
					r_RAddWndToShowWnds_String = new(this, "AddWndToShowWnds", 0, typeof(System.String));
					r_RAddWndToShowWnds_String.SetBelong(this.instance);
				}
				return r_RAddWndToShowWnds_String;
			}
		}

		/// <summary>
		/// Void EnablePlayerCtrl(Boolean)
		/// </summary>
		protected RMethod r_REnablePlayerCtrl_Boolean;
		public virtual RMethod REnablePlayerCtrl_Boolean
		{
			get
			{
				if(r_REnablePlayerCtrl_Boolean == null)
				{
					r_REnablePlayerCtrl_Boolean = new(this, "EnablePlayerCtrl", 0, typeof(System.Boolean));
					r_REnablePlayerCtrl_Boolean.SetBelong(this.instance);
				}
				return r_REnablePlayerCtrl_Boolean;
			}
		}

		/// <summary>
		/// Void DestroyAllMovieAsset()
		/// </summary>
		protected RMethod r_RDestroyAllMovieAsset;
		public virtual RMethod RDestroyAllMovieAsset
		{
			get
			{
				if(r_RDestroyAllMovieAsset == null)
				{
					r_RDestroyAllMovieAsset = new(this, "DestroyAllMovieAsset", 0);
					r_RDestroyAllMovieAsset.SetBelong(this.instance);
				}
				return r_RDestroyAllMovieAsset;
			}
		}

		/// <summary>
		/// Void CheckNpcResourceExist()
		/// </summary>
		protected RMethod r_RCheckNpcResourceExist;
		public virtual RMethod RCheckNpcResourceExist
		{
			get
			{
				if(r_RCheckNpcResourceExist == null)
				{
					r_RCheckNpcResourceExist = new(this, "CheckNpcResourceExist", 0);
					r_RCheckNpcResourceExist.SetBelong(this.instance);
				}
				return r_RCheckNpcResourceExist;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D GetTexturforUIMovie(System.String)
		/// </summary>
		protected RMethod r_RGetTexturforUIMovie_String;
		public virtual RMethod RGetTexturforUIMovie_String
		{
			get
			{
				if(r_RGetTexturforUIMovie_String == null)
				{
					r_RGetTexturforUIMovie_String = new(this, "GetTexturforUIMovie", 0, typeof(System.String));
					r_RGetTexturforUIMovie_String.SetBelong(this.instance);
				}
				return r_RGetTexturforUIMovie_String;
			}
		}

		/// <summary>
		/// Void OnPlayMovie(Message.SCNetMsgPlayMovieNty)
		/// </summary>
		protected RMethod r_ROnPlayMovie_SCNetMsgPlayMovieNty;
		public virtual RMethod ROnPlayMovie_SCNetMsgPlayMovieNty
		{
			get
			{
				if(r_ROnPlayMovie_SCNetMsgPlayMovieNty == null)
				{
					r_ROnPlayMovie_SCNetMsgPlayMovieNty = new(this, "OnPlayMovie", 0,  ReleactionUtils.GetType("Message.SCNetMsgPlayMovieNty"));
					r_ROnPlayMovie_SCNetMsgPlayMovieNty.SetBelong(this.instance);
				}
				return r_ROnPlayMovie_SCNetMsgPlayMovieNty;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator PlayMovie(Message.SCNetMsgPlayMovieNty)
		/// </summary>
		protected RMethod r_RPlayMovie_SCNetMsgPlayMovieNty;
		public virtual RMethod RPlayMovie_SCNetMsgPlayMovieNty
		{
			get
			{
				if(r_RPlayMovie_SCNetMsgPlayMovieNty == null)
				{
					r_RPlayMovie_SCNetMsgPlayMovieNty = new(this, "PlayMovie", 0,  ReleactionUtils.GetType("Message.SCNetMsgPlayMovieNty"));
					r_RPlayMovie_SCNetMsgPlayMovieNty.SetBelong(this.instance);
				}
				return r_RPlayMovie_SCNetMsgPlayMovieNty;
			}
		}

		/// <summary>
		/// Void PlayMovieImm(Message.SCNetMsgPlayMovieNty)
		/// </summary>
		protected RMethod r_RPlayMovieImm_SCNetMsgPlayMovieNty;
		public virtual RMethod RPlayMovieImm_SCNetMsgPlayMovieNty
		{
			get
			{
				if(r_RPlayMovieImm_SCNetMsgPlayMovieNty == null)
				{
					r_RPlayMovieImm_SCNetMsgPlayMovieNty = new(this, "PlayMovieImm", 0,  ReleactionUtils.GetType("Message.SCNetMsgPlayMovieNty"));
					r_RPlayMovieImm_SCNetMsgPlayMovieNty.SetBelong(this.instance);
				}
				return r_RPlayMovieImm_SCNetMsgPlayMovieNty;
			}
		}

		/// <summary>
		/// Void PlaySceneMovie(System.String)
		/// </summary>
		protected RMethod r_RPlaySceneMovie_String;
		public virtual RMethod RPlaySceneMovie_String
		{
			get
			{
				if(r_RPlaySceneMovie_String == null)
				{
					r_RPlaySceneMovie_String = new(this, "PlaySceneMovie", 0, typeof(System.String));
					r_RPlaySceneMovie_String.SetBelong(this.instance);
				}
				return r_RPlaySceneMovie_String;
			}
		}

		/// <summary>
		/// Void PrepareReplay()
		/// </summary>
		protected RMethod r_RPrepareReplay;
		public virtual RMethod RPrepareReplay
		{
			get
			{
				if(r_RPrepareReplay == null)
				{
					r_RPrepareReplay = new(this, "PrepareReplay", 0);
					r_RPrepareReplay.SetBelong(this.instance);
				}
				return r_RPrepareReplay;
			}
		}

		/// <summary>
		/// Void PrepareMovie()
		/// </summary>
		protected RMethod r_RPrepareMovie;
		public virtual RMethod RPrepareMovie
		{
			get
			{
				if(r_RPrepareMovie == null)
				{
					r_RPrepareMovie = new(this, "PrepareMovie", 0);
					r_RPrepareMovie.SetBelong(this.instance);
				}
				return r_RPrepareMovie;
			}
		}

		/// <summary>
		/// Void ReadyForEnd()
		/// </summary>
		protected RMethod r_RReadyForEnd;
		public virtual RMethod RReadyForEnd
		{
			get
			{
				if(r_RReadyForEnd == null)
				{
					r_RReadyForEnd = new(this, "ReadyForEnd", 0);
					r_RReadyForEnd.SetBelong(this.instance);
				}
				return r_RReadyForEnd;
			}
		}

		/// <summary>
		/// Void ExitReplay()
		/// </summary>
		protected RMethod r_RExitReplay;
		public virtual RMethod RExitReplay
		{
			get
			{
				if(r_RExitReplay == null)
				{
					r_RExitReplay = new(this, "ExitReplay", 0);
					r_RExitReplay.SetBelong(this.instance);
				}
				return r_RExitReplay;
			}
		}

		/// <summary>
		/// Void HideOtherPlayers()
		/// </summary>
		protected RMethod r_RHideOtherPlayers;
		public virtual RMethod RHideOtherPlayers
		{
			get
			{
				if(r_RHideOtherPlayers == null)
				{
					r_RHideOtherPlayers = new(this, "HideOtherPlayers", 0);
					r_RHideOtherPlayers.SetBelong(this.instance);
				}
				return r_RHideOtherPlayers;
			}
		}

		/// <summary>
		/// Boolean CheckCanSkip()
		/// </summary>
		protected RMethod r_RCheckCanSkip;
		public virtual RMethod RCheckCanSkip
		{
			get
			{
				if(r_RCheckCanSkip == null)
				{
					r_RCheckCanSkip = new(this, "CheckCanSkip", 0);
					r_RCheckCanSkip.SetBelong(this.instance);
				}
				return r_RCheckCanSkip;
			}
		}

		/// <summary>
		/// Void UpdatePlaying()
		/// </summary>
		protected RMethod r_RUpdatePlaying;
		public virtual RMethod RUpdatePlaying
		{
			get
			{
				if(r_RUpdatePlaying == null)
				{
					r_RUpdatePlaying = new(this, "UpdatePlaying", 0);
					r_RUpdatePlaying.SetBelong(this.instance);
				}
				return r_RUpdatePlaying;
			}
		}

		/// <summary>
		/// Boolean IsPlayerInCombat()
		/// </summary>
		protected RMethod r_RIsPlayerInCombat;
		public virtual RMethod RIsPlayerInCombat
		{
			get
			{
				if(r_RIsPlayerInCombat == null)
				{
					r_RIsPlayerInCombat = new(this, "IsPlayerInCombat", 0);
					r_RIsPlayerInCombat.SetBelong(this.instance);
				}
				return r_RIsPlayerInCombat;
			}
		}

		/// <summary>
		/// Void ShowNpc(Boolean)
		/// </summary>
		protected RMethod r_RShowNpc_Boolean;
		public virtual RMethod RShowNpc_Boolean
		{
			get
			{
				if(r_RShowNpc_Boolean == null)
				{
					r_RShowNpc_Boolean = new(this, "ShowNpc", 0, typeof(System.Boolean));
					r_RShowNpc_Boolean.SetBelong(this.instance);
				}
				return r_RShowNpc_Boolean;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator PostponeExecCommand(Single, Int32)
		/// </summary>
		protected RMethod r_RPostponeExecCommand_Single_Int32;
		public virtual RMethod RPostponeExecCommand_Single_Int32
		{
			get
			{
				if(r_RPostponeExecCommand_Single_Int32 == null)
				{
					r_RPostponeExecCommand_Single_Int32 = new(this, "PostponeExecCommand", 0, typeof(System.Single), typeof(System.Int32));
					r_RPostponeExecCommand_Single_Int32.SetBelong(this.instance);
				}
				return r_RPostponeExecCommand_Single_Int32;
			}
		}

		/// <summary>
		/// Void ExecCommandImme(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecCommandImme_SceneMovieCommand;
		public virtual RMethod RExecCommandImme_SceneMovieCommand
		{
			get
			{
				if(r_RExecCommandImme_SceneMovieCommand == null)
				{
					r_RExecCommandImme_SceneMovieCommand = new(this, "ExecCommandImme", 0, typeof(SceneMovieCommand));
					r_RExecCommandImme_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCommandImme_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecTimeScale(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecTimeScale_SceneMovieCommand;
		public virtual RMethod RExecTimeScale_SceneMovieCommand
		{
			get
			{
				if(r_RExecTimeScale_SceneMovieCommand == null)
				{
					r_RExecTimeScale_SceneMovieCommand = new(this, "ExecTimeScale", 0, typeof(SceneMovieCommand));
					r_RExecTimeScale_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecTimeScale_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecCombatCmd(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecCombatCmd_SceneMovieCommand;
		public virtual RMethod RExecCombatCmd_SceneMovieCommand
		{
			get
			{
				if(r_RExecCombatCmd_SceneMovieCommand == null)
				{
					r_RExecCombatCmd_SceneMovieCommand = new(this, "ExecCombatCmd", 0, typeof(SceneMovieCommand));
					r_RExecCombatCmd_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCombatCmd_SceneMovieCommand;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator WaifForReplayCombat()
		/// </summary>
		protected RMethod r_RWaifForReplayCombat;
		public virtual RMethod RWaifForReplayCombat
		{
			get
			{
				if(r_RWaifForReplayCombat == null)
				{
					r_RWaifForReplayCombat = new(this, "WaifForReplayCombat", 0);
					r_RWaifForReplayCombat.SetBelong(this.instance);
				}
				return r_RWaifForReplayCombat;
			}
		}

		/// <summary>
		/// Void ExecCmdWait(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecCmdWait_SceneMovieCommand;
		public virtual RMethod RExecCmdWait_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdWait_SceneMovieCommand == null)
				{
					r_RExecCmdWait_SceneMovieCommand = new(this, "ExecCmdWait", 0, typeof(SceneMovieCommand));
					r_RExecCmdWait_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdWait_SceneMovieCommand;
			}
		}

		/// <summary>
		/// System.String ReplacePlayerSex(System.String)
		/// </summary>
		protected RMethod r_RReplacePlayerSex_String;
		public virtual RMethod RReplacePlayerSex_String
		{
			get
			{
				if(r_RReplacePlayerSex_String == null)
				{
					r_RReplacePlayerSex_String = new(this, "ReplacePlayerSex", 0, typeof(System.String));
					r_RReplacePlayerSex_String.SetBelong(this.instance);
				}
				return r_RReplacePlayerSex_String;
			}
		}

		/// <summary>
		/// Void ExecCmdDialog(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecCmdDialog_SceneMovieCommand;
		public virtual RMethod RExecCmdDialog_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdDialog_SceneMovieCommand == null)
				{
					r_RExecCmdDialog_SceneMovieCommand = new(this, "ExecCmdDialog", 0, typeof(SceneMovieCommand));
					r_RExecCmdDialog_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdDialog_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecCmdCamera(SceneMovieCommand ByRef)
		/// </summary>
		protected RMethod r_RExecCmdCamera_Ref_SceneMovieCommand;
		public virtual RMethod RExecCmdCamera_Ref_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdCamera_Ref_SceneMovieCommand == null)
				{
					r_RExecCmdCamera_Ref_SceneMovieCommand = new(this, "ExecCmdCamera", 0, typeof(SceneMovieCommand).MakeByRefType());
					r_RExecCmdCamera_Ref_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdCamera_Ref_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecCmdMusic(SceneMovieCommand ByRef)
		/// </summary>
		protected RMethod r_RExecCmdMusic_Ref_SceneMovieCommand;
		public virtual RMethod RExecCmdMusic_Ref_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdMusic_Ref_SceneMovieCommand == null)
				{
					r_RExecCmdMusic_Ref_SceneMovieCommand = new(this, "ExecCmdMusic", 0, typeof(SceneMovieCommand).MakeByRefType());
					r_RExecCmdMusic_Ref_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdMusic_Ref_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecCmdUnit(SceneMovieCommand ByRef)
		/// </summary>
		protected RMethod r_RExecCmdUnit_Ref_SceneMovieCommand;
		public virtual RMethod RExecCmdUnit_Ref_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdUnit_Ref_SceneMovieCommand == null)
				{
					r_RExecCmdUnit_Ref_SceneMovieCommand = new(this, "ExecCmdUnit", 0, typeof(SceneMovieCommand).MakeByRefType());
					r_RExecCmdUnit_Ref_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdUnit_Ref_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void ExecCmdLockPlayer(SceneMoviePlayerLock)
		/// </summary>
		protected RMethod r_RExecCmdLockPlayer_SceneMoviePlayerLock;
		public virtual RMethod RExecCmdLockPlayer_SceneMoviePlayerLock
		{
			get
			{
				if(r_RExecCmdLockPlayer_SceneMoviePlayerLock == null)
				{
					r_RExecCmdLockPlayer_SceneMoviePlayerLock = new(this, "ExecCmdLockPlayer", 0, typeof(SceneMoviePlayerLock));
					r_RExecCmdLockPlayer_SceneMoviePlayerLock.SetBelong(this.instance);
				}
				return r_RExecCmdLockPlayer_SceneMoviePlayerLock;
			}
		}

		/// <summary>
		/// Void ExecCmdEffect(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RExecCmdEffect_SceneMovieCommand;
		public virtual RMethod RExecCmdEffect_SceneMovieCommand
		{
			get
			{
				if(r_RExecCmdEffect_SceneMovieCommand == null)
				{
					r_RExecCmdEffect_SceneMovieCommand = new(this, "ExecCmdEffect", 0, typeof(SceneMovieCommand));
					r_RExecCmdEffect_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RExecCmdEffect_SceneMovieCommand;
			}
		}

		/// <summary>
		/// Void SetCurrentCmdWaitTime(Single)
		/// </summary>
		protected RMethod r_RSetCurrentCmdWaitTime_Single;
		public virtual RMethod RSetCurrentCmdWaitTime_Single
		{
			get
			{
				if(r_RSetCurrentCmdWaitTime_Single == null)
				{
					r_RSetCurrentCmdWaitTime_Single = new(this, "SetCurrentCmdWaitTime", 0, typeof(System.Single));
					r_RSetCurrentCmdWaitTime_Single.SetBelong(this.instance);
				}
				return r_RSetCurrentCmdWaitTime_Single;
			}
		}

		/// <summary>
		/// Void PrintDebugString(System.String)
		/// </summary>
		protected RMethod r_RPrintDebugString_String;
		public virtual RMethod RPrintDebugString_String
		{
			get
			{
				if(r_RPrintDebugString_String == null)
				{
					r_RPrintDebugString_String = new(this, "PrintDebugString", 0, typeof(System.String));
					r_RPrintDebugString_String.SetBelong(this.instance);
				}
				return r_RPrintDebugString_String;
			}
		}

		/// <summary>
		/// Void ForceStopMovie()
		/// </summary>
		protected RMethod r_RForceStopMovie;
		public virtual RMethod RForceStopMovie
		{
			get
			{
				if(r_RForceStopMovie == null)
				{
					r_RForceStopMovie = new(this, "ForceStopMovie", 0);
					r_RForceStopMovie.SetBelong(this.instance);
				}
				return r_RForceStopMovie;
			}
		}

		/// <summary>
		/// Void SetCurrentState(SceneMovieState)
		/// </summary>
		protected RMethod r_RSetCurrentState_SceneMovieState;
		public virtual RMethod RSetCurrentState_SceneMovieState
		{
			get
			{
				if(r_RSetCurrentState_SceneMovieState == null)
				{
					r_RSetCurrentState_SceneMovieState = new(this, "SetCurrentState", 0,  ReleactionUtils.GetType("SceneMovieManager+SceneMovieState"));
					r_RSetCurrentState_SceneMovieState.SetBelong(this.instance);
				}
				return r_RSetCurrentState_SceneMovieState;
			}
		}

		/// <summary>
		/// Void ResetFPS()
		/// </summary>
		protected RMethod r_RResetFPS;
		public virtual RMethod RResetFPS
		{
			get
			{
				if(r_RResetFPS == null)
				{
					r_RResetFPS = new(this, "ResetFPS", 0);
					r_RResetFPS.SetBelong(this.instance);
				}
				return r_RResetFPS;
			}
		}

		/// <summary>
		/// Void UpdateFPS()
		/// </summary>
		protected RMethod r_RUpdateFPS;
		public virtual RMethod RUpdateFPS
		{
			get
			{
				if(r_RUpdateFPS == null)
				{
					r_RUpdateFPS = new(this, "UpdateFPS", 0);
					r_RUpdateFPS.SetBelong(this.instance);
				}
				return r_RUpdateFPS;
			}
		}

		/// <summary>
		/// Single GetMovieFPS()
		/// </summary>
		protected RMethod r_RGetMovieFPS;
		public virtual RMethod RGetMovieFPS
		{
			get
			{
				if(r_RGetMovieFPS == null)
				{
					r_RGetMovieFPS = new(this, "GetMovieFPS", 0);
					r_RGetMovieFPS.SetBelong(this.instance);
				}
				return r_RGetMovieFPS;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ProcessMovieMusicPlay()
		/// </summary>
		protected RMethod r_RProcessMovieMusicPlay;
		public virtual RMethod RProcessMovieMusicPlay
		{
			get
			{
				if(r_RProcessMovieMusicPlay == null)
				{
					r_RProcessMovieMusicPlay = new(this, "ProcessMovieMusicPlay", 0);
					r_RProcessMovieMusicPlay.SetBelong(this.instance);
				}
				return r_RProcessMovieMusicPlay;
			}
		}

		/// <summary>
		/// Void StopMovieMusic()
		/// </summary>
		protected RMethod r_RStopMovieMusic;
		public virtual RMethod RStopMovieMusic
		{
			get
			{
				if(r_RStopMovieMusic == null)
				{
					r_RStopMovieMusic = new(this, "StopMovieMusic", 0);
					r_RStopMovieMusic.SetBelong(this.instance);
				}
				return r_RStopMovieMusic;
			}
		}

		/// <summary>
		/// Void LoadCameraGroups()
		/// </summary>
		protected RMethod r_RLoadCameraGroups;
		public virtual RMethod RLoadCameraGroups
		{
			get
			{
				if(r_RLoadCameraGroups == null)
				{
					r_RLoadCameraGroups = new(this, "LoadCameraGroups", 0);
					r_RLoadCameraGroups.SetBelong(this.instance);
				}
				return r_RLoadCameraGroups;
			}
		}

		/// <summary>
		/// Void OnMovieAssetsLoaded(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnMovieAssetsLoaded_Object_ABLoadedArgs;
		public virtual RMethod ROnMovieAssetsLoaded_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnMovieAssetsLoaded_Object_ABLoadedArgs == null)
				{
					r_ROnMovieAssetsLoaded_Object_ABLoadedArgs = new(this, "OnMovieAssetsLoaded", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnMovieAssetsLoaded_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnMovieAssetsLoaded_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Boolean CheckAllLoaded()
		/// </summary>
		protected RMethod r_RCheckAllLoaded;
		public virtual RMethod RCheckAllLoaded
		{
			get
			{
				if(r_RCheckAllLoaded == null)
				{
					r_RCheckAllLoaded = new(this, "CheckAllLoaded", 0);
					r_RCheckAllLoaded.SetBelong(this.instance);
				}
				return r_RCheckAllLoaded;
			}
		}

		/// <summary>
		/// Boolean GetMovieNpcShow()
		/// </summary>
		protected RMethod r_RGetMovieNpcShow;
		public virtual RMethod RGetMovieNpcShow
		{
			get
			{
				if(r_RGetMovieNpcShow == null)
				{
					r_RGetMovieNpcShow = new(this, "GetMovieNpcShow", 0);
					r_RGetMovieNpcShow.SetBelong(this.instance);
				}
				return r_RGetMovieNpcShow;
			}
		}

		/// <summary>
		/// Void ReplayMovie(Int32)
		/// </summary>
		protected RMethod r_RReplayMovie_Int32;
		public virtual RMethod RReplayMovie_Int32
		{
			get
			{
				if(r_RReplayMovie_Int32 == null)
				{
					r_RReplayMovie_Int32 = new(this, "ReplayMovie", 0, typeof(System.Int32));
					r_RReplayMovie_Int32.SetBelong(this.instance);
				}
				return r_RReplayMovie_Int32;
			}
		}

		/// <summary>
		/// Void LoadReplayScene(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RLoadReplayScene_ID;
		public virtual RMethod RLoadReplayScene_ID
		{
			get
			{
				if(r_RLoadReplayScene_ID == null)
				{
					r_RLoadReplayScene_ID = new(this, "LoadReplayScene", 0, typeof(GameDefineType.ID));
					r_RLoadReplayScene_ID.SetBelong(this.instance);
				}
				return r_RLoadReplayScene_ID;
			}
		}

		/// <summary>
		/// Void OnLoadSceneObj(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadSceneObj_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadSceneObj_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadSceneObj_Object_ABLoadedArgs == null)
				{
					r_ROnLoadSceneObj_Object_ABLoadedArgs = new(this, "OnLoadSceneObj", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadSceneObj_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadSceneObj_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_ROnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_ROnGUI == null)
				{
					r_ROnGUI = new(this, "OnGUI", 0);
					r_ROnGUI.SetBelong(this.instance);
				}
				return r_ROnGUI;
			}
		}

		/// <summary>
		/// Void InitSkipStyle()
		/// </summary>
		protected RMethod r_RInitSkipStyle;
		public virtual RMethod RInitSkipStyle
		{
			get
			{
				if(r_RInitSkipStyle == null)
				{
					r_RInitSkipStyle = new(this, "InitSkipStyle", 0);
					r_RInitSkipStyle.SetBelong(this.instance);
				}
				return r_RInitSkipStyle;
			}
		}

		/// <summary>
		/// Void DrawSkipBtn()
		/// </summary>
		protected RMethod r_RDrawSkipBtn;
		public virtual RMethod RDrawSkipBtn
		{
			get
			{
				if(r_RDrawSkipBtn == null)
				{
					r_RDrawSkipBtn = new(this, "DrawSkipBtn", 0);
					r_RDrawSkipBtn.SetBelong(this.instance);
				}
				return r_RDrawSkipBtn;
			}
		}

		/// <summary>
		/// Void StopDownloading()
		/// </summary>
		protected RMethod r_RStopDownloading;
		public virtual RMethod RStopDownloading
		{
			get
			{
				if(r_RStopDownloading == null)
				{
					r_RStopDownloading = new(this, "StopDownloading", 0);
					r_RStopDownloading.SetBelong(this.instance);
				}
				return r_RStopDownloading;
			}
		}

		/// <summary>
		/// Void SetSkipBtnRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetSkipBtnRect_Rect;
		public virtual RMethod RSetSkipBtnRect_Rect
		{
			get
			{
				if(r_RSetSkipBtnRect_Rect == null)
				{
					r_RSetSkipBtnRect_Rect = new(this, "SetSkipBtnRect", 0, typeof(UnityEngine.Rect));
					r_RSetSkipBtnRect_Rect.SetBelong(this.instance);
				}
				return r_RSetSkipBtnRect_Rect;
			}
		}

		/// <summary>
		/// Void SendReplayMovie(Int32, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RSendReplayMovie_Int32_ID_String;
		public virtual RMethod RSendReplayMovie_Int32_ID_String
		{
			get
			{
				if(r_RSendReplayMovie_Int32_ID_String == null)
				{
					r_RSendReplayMovie_Int32_ID_String = new(this, "SendReplayMovie", 0, typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.String));
					r_RSendReplayMovie_Int32_ID_String.SetBelong(this.instance);
				}
				return r_RSendReplayMovie_Int32_ID_String;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_RAwake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_RAwake == null)
				{
					r_RAwake = new(this, "Awake", 0);
					r_RAwake.SetBelong(this.instance);
				}
				return r_RAwake;
			}
		}

		/// <summary>
		/// Void RestSingleton()
		/// </summary>
		protected RMethod r_RRestSingleton;
		public virtual RMethod RRestSingleton
		{
			get
			{
				if(r_RRestSingleton == null)
				{
					r_RRestSingleton = new(this, "RestSingleton", 0);
					r_RRestSingleton.SetBelong(this.instance);
				}
				return r_RRestSingleton;
			}
		}

		/// <summary>
		/// Boolean IsInvoking()
		/// </summary>
		protected RMethod r_RIsInvoking;
		public virtual RMethod RIsInvoking
		{
			get
			{
				if(r_RIsInvoking == null)
				{
					r_RIsInvoking = new(this, "IsInvoking", 0);
					r_RIsInvoking.SetBelong(this.instance);
				}
				return r_RIsInvoking;
			}
		}

		/// <summary>
		/// Void CancelInvoke()
		/// </summary>
		protected RMethod r_RCancelInvoke;
		public virtual RMethod RCancelInvoke
		{
			get
			{
				if(r_RCancelInvoke == null)
				{
					r_RCancelInvoke = new(this, "CancelInvoke", 0);
					r_RCancelInvoke.SetBelong(this.instance);
				}
				return r_RCancelInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, Single)
		/// </summary>
		protected RMethod r_RInvoke_String_Single;
		public virtual RMethod RInvoke_String_Single
		{
			get
			{
				if(r_RInvoke_String_Single == null)
				{
					r_RInvoke_String_Single = new(this, "Invoke", 0, typeof(System.String), typeof(System.Single));
					r_RInvoke_String_Single.SetBelong(this.instance);
				}
				return r_RInvoke_String_Single;
			}
		}

		/// <summary>
		/// Void InvokeRepeating(System.String, Single, Single)
		/// </summary>
		protected RMethod r_RInvokeRepeating_String_Single_Single;
		public virtual RMethod RInvokeRepeating_String_Single_Single
		{
			get
			{
				if(r_RInvokeRepeating_String_Single_Single == null)
				{
					r_RInvokeRepeating_String_Single_Single = new(this, "InvokeRepeating", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_RInvokeRepeating_String_Single_Single.SetBelong(this.instance);
				}
				return r_RInvokeRepeating_String_Single_Single;
			}
		}

		/// <summary>
		/// Void CancelInvoke(System.String)
		/// </summary>
		protected RMethod r_RCancelInvoke_String;
		public virtual RMethod RCancelInvoke_String
		{
			get
			{
				if(r_RCancelInvoke_String == null)
				{
					r_RCancelInvoke_String = new(this, "CancelInvoke", 0, typeof(System.String));
					r_RCancelInvoke_String.SetBelong(this.instance);
				}
				return r_RCancelInvoke_String;
			}
		}

		/// <summary>
		/// Boolean IsInvoking(System.String)
		/// </summary>
		protected RMethod r_RIsInvoking_String;
		public virtual RMethod RIsInvoking_String
		{
			get
			{
				if(r_RIsInvoking_String == null)
				{
					r_RIsInvoking_String = new(this, "IsInvoking", 0, typeof(System.String));
					r_RIsInvoking_String.SetBelong(this.instance);
				}
				return r_RIsInvoking_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStartCoroutine_String;
		public virtual RMethod RStartCoroutine_String
		{
			get
			{
				if(r_RStartCoroutine_String == null)
				{
					r_RStartCoroutine_String = new(this, "StartCoroutine", 0, typeof(System.String));
					r_RStartCoroutine_String.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String, System.Object)
		/// </summary>
		protected RMethod r_RStartCoroutine_String_Object;
		public virtual RMethod RStartCoroutine_String_Object
		{
			get
			{
				if(r_RStartCoroutine_String_Object == null)
				{
					r_RStartCoroutine_String_Object = new(this, "StartCoroutine", 0, typeof(System.String), typeof(System.Object));
					r_RStartCoroutine_String_Object.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_IEnumerator;
		public virtual RMethod RStartCoroutine_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_IEnumerator == null)
				{
					r_RStartCoroutine_IEnumerator = new(this, "StartCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_Auto_IEnumerator;
		public virtual RMethod RStartCoroutine_Auto_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_Auto_IEnumerator == null)
				{
					r_RStartCoroutine_Auto_IEnumerator = new(this, "StartCoroutine_Auto", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_Auto_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_Auto_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStopCoroutine_IEnumerator;
		public virtual RMethod RStopCoroutine_IEnumerator
		{
			get
			{
				if(r_RStopCoroutine_IEnumerator == null)
				{
					r_RStopCoroutine_IEnumerator = new(this, "StopCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStopCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStopCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(UnityEngine.Coroutine)
		/// </summary>
		protected RMethod r_RStopCoroutine_Coroutine;
		public virtual RMethod RStopCoroutine_Coroutine
		{
			get
			{
				if(r_RStopCoroutine_Coroutine == null)
				{
					r_RStopCoroutine_Coroutine = new(this, "StopCoroutine", 0, typeof(UnityEngine.Coroutine));
					r_RStopCoroutine_Coroutine.SetBelong(this.instance);
				}
				return r_RStopCoroutine_Coroutine;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStopCoroutine_String;
		public virtual RMethod RStopCoroutine_String
		{
			get
			{
				if(r_RStopCoroutine_String == null)
				{
					r_RStopCoroutine_String = new(this, "StopCoroutine", 0, typeof(System.String));
					r_RStopCoroutine_String.SetBelong(this.instance);
				}
				return r_RStopCoroutine_String;
			}
		}

		/// <summary>
		/// Void StopAllCoroutines()
		/// </summary>
		protected RMethod r_RStopAllCoroutines;
		public virtual RMethod RStopAllCoroutines
		{
			get
			{
				if(r_RStopAllCoroutines == null)
				{
					r_RStopAllCoroutines = new(this, "StopAllCoroutines", 0);
					r_RStopAllCoroutines.SetBelong(this.instance);
				}
				return r_RStopAllCoroutines;
			}
		}

		/// <summary>
		/// System.String GetScriptClassName()
		/// </summary>
		protected RMethod r_RGetScriptClassName;
		public virtual RMethod RGetScriptClassName
		{
			get
			{
				if(r_RGetScriptClassName == null)
				{
					r_RGetScriptClassName = new(this, "GetScriptClassName", 0);
					r_RGetScriptClassName.SetBelong(this.instance);
				}
				return r_RGetScriptClassName;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponent_Type;
		public virtual RMethod RGetComponent_Type
		{
			get
			{
				if(r_RGetComponent_Type == null)
				{
					r_RGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
					r_RGetComponent_Type.SetBelong(this.instance);
				}
				return r_RGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_RGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_RGetComponentFastPath_Type_IntPtr == null)
				{
					r_RGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_RGetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_RGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_RGetComponent_GT;
		public virtual RMethod RGetComponent_GT
		{
			get
			{
				if(r_RGetComponent_GT == null)
				{
					r_RGetComponent_GT = new(this, "GetComponent", 1);
					r_RGetComponent_GT.SetBelong(this.instance);
				}
				return r_RGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_Type_Out_Component;
		public virtual RMethod RTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_RTryGetComponent_Type_Out_Component == null)
				{
					r_RTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
					r_RTryGetComponent_Type_Out_Component.SetBelong(this.instance);
				}
				return r_RTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_GT_Out_T;
		public virtual RMethod RTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_RTryGetComponent_GT_Out_T == null)
				{
					r_RTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetComponent_GT_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_RGetComponent_String;
		public virtual RMethod RGetComponent_String
		{
			get
			{
				if(r_RGetComponent_String == null)
				{
					r_RGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
					r_RGetComponent_String.SetBelong(this.instance);
				}
				return r_RGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type_Boolean;
		public virtual RMethod RGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_Type_Boolean == null)
				{
					r_RGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type;
		public virtual RMethod RGetComponentInChildren_Type
		{
			get
			{
				if(r_RGetComponentInChildren_Type == null)
				{
					r_RGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
					r_RGetComponentInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT_Boolean;
		public virtual RMethod RGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_GT_Boolean == null)
				{
					r_RGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
					r_RGetComponentInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT;
		public virtual RMethod RGetComponentInChildren_GT
		{
			get
			{
				if(r_RGetComponentInChildren_GT == null)
				{
					r_RGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
					r_RGetComponentInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_Type_Boolean == null)
				{
					r_RGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type;
		public virtual RMethod RGetComponentsInChildren_Type
		{
			get
			{
				if(r_RGetComponentsInChildren_Type == null)
				{
					r_RGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
					r_RGetComponentsInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean == null)
				{
					r_RGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
					r_RGetComponentsInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT;
		public virtual RMethod RGetComponentsInChildren_GT
		{
			get
			{
				if(r_RGetComponentsInChildren_GT == null)
				{
					r_RGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
					r_RGetComponentsInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type_Boolean;
		public virtual RMethod RGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_Type_Boolean == null)
				{
					r_RGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type;
		public virtual RMethod RGetComponentInParent_Type
		{
			get
			{
				if(r_RGetComponentInParent_Type == null)
				{
					r_RGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
					r_RGetComponentInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT_Boolean;
		public virtual RMethod RGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_GT_Boolean == null)
				{
					r_RGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
					r_RGetComponentInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT;
		public virtual RMethod RGetComponentInParent_GT
		{
			get
			{
				if(r_RGetComponentInParent_GT == null)
				{
					r_RGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
					r_RGetComponentInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type_Boolean;
		public virtual RMethod RGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_Type_Boolean == null)
				{
					r_RGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type;
		public virtual RMethod RGetComponentsInParent_Type
		{
			get
			{
				if(r_RGetComponentsInParent_Type == null)
				{
					r_RGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
					r_RGetComponentsInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean;
		public virtual RMethod RGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean == null)
				{
					r_RGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
					r_RGetComponentsInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT;
		public virtual RMethod RGetComponentsInParent_GT
		{
			get
			{
				if(r_RGetComponentsInParent_GT == null)
				{
					r_RGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
					r_RGetComponentsInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_RGetComponents_Type;
		public virtual RMethod RGetComponents_Type
		{
			get
			{
				if(r_RGetComponents_Type == null)
				{
					r_RGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
					r_RGetComponents_Type.SetBelong(this.instance);
				}
				return r_RGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_RGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_RGetComponents_Type_List_d_Component_p_ == null)
				{
					r_RGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
					r_RGetComponents_Type_List_d_Component_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponents_GT_List_d_T_p_;
		public virtual RMethod RGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponents_GT_List_d_T_p_ == null)
				{
					r_RGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponents_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_RGetComponents_GT;
		public virtual RMethod RGetComponents_GT
		{
			get
			{
				if(r_RGetComponents_GT == null)
				{
					r_RGetComponents_GT = new(this, "GetComponents", 1);
					r_RGetComponents_GT.SetBelong(this.instance);
				}
				return r_RGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_RCompareTag_String;
		public virtual RMethod RCompareTag_String
		{
			get
			{
				if(r_RCompareTag_String == null)
				{
					r_RCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
					r_RCompareTag_String.SetBelong(this.instance);
				}
				return r_RCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_RGetCoupledComponent;
		public virtual RMethod RGetCoupledComponent
		{
			get
			{
				if(r_RGetCoupledComponent == null)
				{
					r_RGetCoupledComponent = new(this, "GetCoupledComponent", 0);
					r_RGetCoupledComponent.SetBelong(this.instance);
				}
				return r_RGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_RIsCoupledComponent;
		public virtual RMethod RIsCoupledComponent
		{
			get
			{
				if(r_RIsCoupledComponent == null)
				{
					r_RIsCoupledComponent = new(this, "IsCoupledComponent", 0);
					r_RIsCoupledComponent.SetBelong(this.instance);
				}
				return r_RIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object;
		public virtual RMethod RSendMessageUpwards_String_Object
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object == null)
				{
					r_RSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessageUpwards_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String;
		public virtual RMethod RSendMessageUpwards_String
		{
			get
			{
				if(r_RSendMessageUpwards_String == null)
				{
					r_RSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
					r_RSendMessageUpwards_String.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object;
		public virtual RMethod RSendMessage_String_Object
		{
			get
			{
				if(r_RSendMessage_String_Object == null)
				{
					r_RSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessage_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_RSendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_RSendMessage_String == null)
				{
					r_RSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_RSendMessage_String.SetBelong(this.instance);
				}
				return r_RSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_Object_SendMessageOptions == null)
				{
					r_RSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_SendMessageOptions;
		public virtual RMethod RSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_SendMessageOptions == null)
				{
					r_RSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object;
		public virtual RMethod RBroadcastMessage_String_Object
		{
			get
			{
				if(r_RBroadcastMessage_String_Object == null)
				{
					r_RBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
					r_RBroadcastMessage_String_Object.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String;
		public virtual RMethod RBroadcastMessage_String
		{
			get
			{
				if(r_RBroadcastMessage_String == null)
				{
					r_RBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
					r_RBroadcastMessage_String.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RSceneMovieManager() : base("SceneMovieManager")
        {
        }

        public RSceneMovieManager(System.Object instance) : base("SceneMovieManager")
		{
            SetInstance(instance);
		}

        public RSceneMovieManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsDebugMovie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDebugMovie.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCurrentClipNull()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCurrentClipNull.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableMovieManagers(System.Boolean  @bEnable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable};
            var ___result = REnableMovieManagers_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] GetMovieAssetUrls()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMovieAssetUrls.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void AddUrlsToUrlsList(System.String[]  @urls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@urls};
            var ___result = RAddUrlsToUrlsList_StringArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual GameDefineType.ID GetWeddingNpcID(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetWeddingNpcID_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.String GetPortraitName(System.String  @oriName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oriName};
            var ___result = RGetPortraitName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void LoadDefaultWeapons()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadDefaultWeapons.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGetWeaponRes(System.Object  @sender, UnityEngine.GameObject  @weapon0, UnityEngine.GameObject  @weapon1, System.Object  @exArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @weapon0, @weapon1, @exArgs};
            var ___result = ROnGetWeaponRes_Object_GameObject_GameObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAllWeapon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetAllWeapon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetWeaponAsset(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetWeaponAsset_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void OnLoadSceneMovieConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadSceneMovieConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadCameraGroupsConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadCameraGroupsConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayedMovieList(System.String  @ids)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ids};
            var ___result = RSetPlayedMovieList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsMoviePlayed(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RIsMoviePlayed_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnLoadMovieReplayConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadMovieReplayConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadMovieConfig(SceneMovieNetConfig  @netconfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@netconfig};
            var ___result = RLoadMovieConfig_SceneMovieNetConfig.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void PrepareNpcAnims()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareNpcAnims.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPressEsc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPressEsc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowMyGUIWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowMyGUIWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseMyGUIWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseMyGUIWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddWndToShowWnds(System.String  @wndName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndName};
            var ___result = RAddWndToShowWnds_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnablePlayerCtrl(System.Boolean  @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enable};
            var ___result = REnablePlayerCtrl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyAllMovieAsset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroyAllMovieAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNpcResourceExist()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNpcResourceExist.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Texture2D GetTexturforUIMovie(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTexturforUIMovie_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }





        public virtual void PlaySceneMovie(System.String  @movieName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@movieName};
            var ___result = RPlaySceneMovie_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareReplay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareReplay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareMovie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareMovie.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadyForEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadyForEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExitReplay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExitReplay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideOtherPlayers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideOtherPlayers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckCanSkip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckCanSkip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdatePlaying()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdatePlaying.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPlayerInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPlayerInCombat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowNpc(System.Boolean  @bShow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bShow};
            var ___result = RShowNpc_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator PostponeExecCommand(System.Single  @fPostpone, System.Int32  @cmdIdx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fPostpone, @cmdIdx};
            var ___result = RPostponeExecCommand_Single_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void ExecCommandImme(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCommandImme_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecTimeScale(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecTimeScale_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecCombatCmd(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCombatCmd_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator WaifForReplayCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaifForReplayCombat.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void ExecCmdWait(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdWait_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ReplacePlayerSex(System.String  @inText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inText};
            var ___result = RReplacePlayerSex_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ExecCmdDialog(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdDialog_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecCmdCamera(ref SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdCamera_Ref_SceneMovieCommand.Invoke(___genericsType, ___parameters);
			cmd = (SceneMovieCommand)___parameters[0];

            
        }


        public virtual void ExecCmdMusic(ref SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdMusic_Ref_SceneMovieCommand.Invoke(___genericsType, ___parameters);
			cmd = (SceneMovieCommand)___parameters[0];

            
        }


        public virtual void ExecCmdUnit(ref SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdUnit_Ref_SceneMovieCommand.Invoke(___genericsType, ___parameters);
			cmd = (SceneMovieCommand)___parameters[0];

            
        }


        public virtual void ExecCmdLockPlayer(SceneMoviePlayerLock  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdLockPlayer_SceneMoviePlayerLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecCmdEffect(SceneMovieCommand  @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd};
            var ___result = RExecCmdEffect_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCurrentCmdWaitTime(System.Single  @waitTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitTime};
            var ___result = RSetCurrentCmdWaitTime_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrintDebugString(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RPrintDebugString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceStopMovie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RForceStopMovie.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ResetFPS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetFPS.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateFPS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFPS.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetMovieFPS()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMovieFPS.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Collections.IEnumerator ProcessMovieMusicPlay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessMovieMusicPlay.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void StopMovieMusic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopMovieMusic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadCameraGroups()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadCameraGroups.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean CheckAllLoaded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckAllLoaded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetMovieNpcShow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMovieNpcShow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReplayMovie(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReplayMovie_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadReplayScene(GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID};
            var ___result = RLoadReplayScene_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitSkipStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitSkipStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawSkipBtn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawSkipBtn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopDownloading()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopDownloading.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSkipBtnRect(UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RSetSkipBtnRect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendReplayMovie(System.Int32  @idx, GameDefineType.ID  @sceneID, System.String  @moviename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @sceneID, @moviename};
            var ___result = RSendReplayMovie_Int32_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestSingleton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestSingleton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInvoking.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CancelInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancelInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time};
            var ___result = RInvoke_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRepeating(System.String  @methodName, System.Single  @time, System.Single  @repeatRate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time, @repeatRate};
            var ___result = RInvokeRepeating_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelInvoke(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCancelInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RIsInvoking_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStartCoroutine_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RStartCoroutine_String_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_Auto_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void StopCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(UnityEngine.Coroutine  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_Coroutine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStopCoroutine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopAllCoroutines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopAllCoroutines.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetScriptClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScriptClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void GetComponentFastPath(System.Type  @type, System.IntPtr  @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryGetComponent(System.Type  @type, out UnityEngine.Component  @component)
        {
			component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			component = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
            var ___result = RGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponents(System.Type  @type, System.Collections.Generic.List<UnityEngine.Component>  @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean CompareTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
