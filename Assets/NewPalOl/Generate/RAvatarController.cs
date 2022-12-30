using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AvatarController
	/// </summary>
    public partial class RAvatarController : RMember //
    {

		/// <summary>
		/// System.Boolean effectHideFlag
		/// </summary>
		protected static RField r_effectHideFlag;
		public static RField ReffectHideFlag
		{
			get
			{
				if(r_effectHideFlag == null)
				{
					r_effectHideFlag = new( ReleactionUtils.GetType("AvatarController"), "effectHideFlag");
					r_effectHideFlag.SetBelong(null);
				}
				return r_effectHideFlag;
			}
		}

		/// <summary>
		/// System.String rightholding
		/// </summary>
		protected static RField r_rightholding;
		public static RField Rrightholding
		{
			get
			{
				if(r_rightholding == null)
				{
					r_rightholding = new( ReleactionUtils.GetType("AvatarController"), "rightholding");
					r_rightholding.SetBelong(null);
				}
				return r_rightholding;
			}
		}

		/// <summary>
		/// System.String leftholding
		/// </summary>
		protected static RField r_leftholding;
		public static RField Rleftholding
		{
			get
			{
				if(r_leftholding == null)
				{
					r_leftholding = new( ReleactionUtils.GetType("AvatarController"), "leftholding");
					r_leftholding.SetBelong(null);
				}
				return r_leftholding;
			}
		}

		/// <summary>
		/// System.String weaponholding
		/// </summary>
		protected static RField r_weaponholding;
		public static RField Rweaponholding
		{
			get
			{
				if(r_weaponholding == null)
				{
					r_weaponholding = new( ReleactionUtils.GetType("AvatarController"), "weaponholding");
					r_weaponholding.SetBelong(null);
				}
				return r_weaponholding;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Transform] mWeaponPoints
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTransform> r_mWeaponPoints;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTransform> RmWeaponPoints
		{
			get
			{
				if(r_mWeaponPoints == null)
				{
					r_mWeaponPoints = new(this, "mWeaponPoints");
					r_mWeaponPoints.SetBelong(this.instance);
				}
				return r_mWeaponPoints;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mWeaponRes
		/// </summary>
		protected RUnityEngine.RGameObject r_mWeaponRes;
		public virtual RUnityEngine.RGameObject RmWeaponRes
		{
			get
			{
				if(r_mWeaponRes == null)
				{
					r_mWeaponRes = new(this, "mWeaponRes");
					r_mWeaponRes.SetBelong(this.instance);
				}
				return r_mWeaponRes;
			}
		}

		/// <summary>
		/// AvatarController+weaponInfo mCurrentWeapon
		/// </summary>
		protected RAvatarController.RweaponInfo r_mCurrentWeapon;
		public virtual RAvatarController.RweaponInfo RmCurrentWeapon
		{
			get
			{
				if(r_mCurrentWeapon == null)
				{
					r_mCurrentWeapon = new(this, "mCurrentWeapon");
					r_mCurrentWeapon.SetBelong(this.instance);
				}
				return r_mCurrentWeapon;
			}
		}

		/// <summary>
		/// GameDefineType.ID bodyTypItem
		/// </summary>
		protected RGameDefineType.RID r_bodyTypItem;
		public virtual RGameDefineType.RID RbodyTypItem
		{
			get
			{
				if(r_bodyTypItem == null)
				{
					r_bodyTypItem = new(this, "bodyTypItem");
					r_bodyTypItem.SetBelong(this.instance);
				}
				return r_bodyTypItem;
			}
		}

		/// <summary>
		/// Pawn _pawn
		/// </summary>
		protected RPawn r__pawn;
		public virtual RPawn R_pawn
		{
			get
			{
				if(r__pawn == null)
				{
					r__pawn = new(this, "_pawn");
					r__pawn.SetBelong(this.instance);
				}
				return r__pawn;
			}
		}

		/// <summary>
		/// CombatController _mCC
		/// </summary>
		protected RCombatController r__mCC;
		public virtual RCombatController R_mCC
		{
			get
			{
				if(r__mCC == null)
				{
					r__mCC = new(this, "_mCC");
					r__mCC.SetBelong(this.instance);
				}
				return r__mCC;
			}
		}

		/// <summary>
		/// System.Boolean isVisible
		/// </summary>
		protected RField r_isVisible;
		public virtual RField RisVisible
		{
			get
			{
				if(r_isVisible == null)
				{
					r_isVisible = new(this, "isVisible");
					r_isVisible.SetBelong(this.instance);
				}
				return r_isVisible;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.GameObject] m_SuitEffectLib
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> r_m_SuitEffectLib;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> Rm_SuitEffectLib
		{
			get
			{
				if(r_m_SuitEffectLib == null)
				{
					r_m_SuitEffectLib = new( ReleactionUtils.GetType("AvatarController"), "m_SuitEffectLib");
					r_m_SuitEffectLib.SetBelong(null);
				}
				return r_m_SuitEffectLib;
			}
		}

		/// <summary>
		/// AvatarController+SuitEffectInfo m_suitEffect
		/// </summary>
		protected RAvatarController.RSuitEffectInfo r_m_suitEffect;
		public virtual RAvatarController.RSuitEffectInfo Rm_suitEffect
		{
			get
			{
				if(r_m_suitEffect == null)
				{
					r_m_suitEffect = new(this, "m_suitEffect");
					r_m_suitEffect.SetBelong(this.instance);
				}
				return r_m_suitEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_FollowPlayerObject
		/// </summary>
		protected RUnityEngine.RGameObject r_m_FollowPlayerObject;
		public virtual RUnityEngine.RGameObject Rm_FollowPlayerObject
		{
			get
			{
				if(r_m_FollowPlayerObject == null)
				{
					r_m_FollowPlayerObject = new(this, "m_FollowPlayerObject");
					r_m_FollowPlayerObject.SetBelong(this.instance);
				}
				return r_m_FollowPlayerObject;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[AvatarController+TASK_EFFECT,AvatarController+TaskEffectInfo] m_TaskEffect
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RAvatarController.RTaskEffectInfo> r_m_TaskEffect;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RAvatarController.RTaskEffectInfo> Rm_TaskEffect
		{
			get
			{
				if(r_m_TaskEffect == null)
				{
					r_m_TaskEffect = new(this, "m_TaskEffect");
					r_m_TaskEffect.SetBelong(this.instance);
				}
				return r_m_TaskEffect;
			}
		}

		/// <summary>
		/// Pawn mPawn
		/// </summary>
		protected RPawn r_mPawn;
		public virtual RPawn RmPawn
		{
			get
			{
				if(r_mPawn == null)
				{
					r_mPawn = new(this, "mPawn", -1);
					r_mPawn.SetBelong(this.instance);
				}
				return r_mPawn;
			}
		}

		/// <summary>
		/// CombatController mCC
		/// </summary>
		protected RCombatController r_mCC;
		public virtual RCombatController RmCC
		{
			get
			{
				if(r_mCC == null)
				{
					r_mCC = new(this, "mCC", -1);
					r_mCC.SetBelong(this.instance);
				}
				return r_mCC;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject FollowPlayerObject
		/// </summary>
		protected RUnityEngine.RGameObject r_FollowPlayerObject;
		public virtual RUnityEngine.RGameObject RFollowPlayerObject
		{
			get
			{
				if(r_FollowPlayerObject == null)
				{
					r_FollowPlayerObject = new(this, "FollowPlayerObject", -1);
					r_FollowPlayerObject.SetBelong(this.instance);
				}
				return r_FollowPlayerObject;
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
		/// Int32 GetDefaultWeaponType(UInt32)
		/// </summary>
		protected static RMethod r_RGetDefaultWeaponType_UInt32;
		public static RMethod RGetDefaultWeaponType_UInt32
		{
			get
			{
				if(r_RGetDefaultWeaponType_UInt32 == null)
				{
					r_RGetDefaultWeaponType_UInt32 = new( ReleactionUtils.GetType("AvatarController"), "GetDefaultWeaponType", 0, typeof(System.UInt32));
					r_RGetDefaultWeaponType_UInt32.SetBelong(null);
				}
				return r_RGetDefaultWeaponType_UInt32;
			}
		}

		/// <summary>
		/// System.String GetAnimationWeaponTypeName(UInt32)
		/// </summary>
		protected RMethod r_RGetAnimationWeaponTypeName_UInt32;
		public virtual RMethod RGetAnimationWeaponTypeName_UInt32
		{
			get
			{
				if(r_RGetAnimationWeaponTypeName_UInt32 == null)
				{
					r_RGetAnimationWeaponTypeName_UInt32 = new(this, "GetAnimationWeaponTypeName", 0, typeof(System.UInt32));
					r_RGetAnimationWeaponTypeName_UInt32.SetBelong(this.instance);
				}
				return r_RGetAnimationWeaponTypeName_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject InstantiateEffect(System.String)
		/// </summary>
		protected static RMethod r_RInstantiateEffect_String;
		public static RMethod RInstantiateEffect_String
		{
			get
			{
				if(r_RInstantiateEffect_String == null)
				{
					r_RInstantiateEffect_String = new( ReleactionUtils.GetType("AvatarController"), "InstantiateEffect", 0, typeof(System.String));
					r_RInstantiateEffect_String.SetBelong(null);
				}
				return r_RInstantiateEffect_String;
			}
		}

		/// <summary>
		/// Boolean IsSuitEffectLibExist(System.String)
		/// </summary>
		protected static RMethod r_RIsSuitEffectLibExist_String;
		public static RMethod RIsSuitEffectLibExist_String
		{
			get
			{
				if(r_RIsSuitEffectLibExist_String == null)
				{
					r_RIsSuitEffectLibExist_String = new( ReleactionUtils.GetType("AvatarController"), "IsSuitEffectLibExist", 0, typeof(System.String));
					r_RIsSuitEffectLibExist_String.SetBelong(null);
				}
				return r_RIsSuitEffectLibExist_String;
			}
		}

		/// <summary>
		/// Void LoadSuitEffect(System.String, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected static RMethod r_RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler;
		public static RMethod RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler = new( ReleactionUtils.GetType("AvatarController"), "LoadSuitEffect", 0, typeof(System.String),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler.SetBelong(null);
				}
				return r_RLoadSuitEffect_String_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void LoadSuitEffect(System.String, System.Object, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected static RMethod r_RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler;
		public static RMethod RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler = new( ReleactionUtils.GetType("AvatarController"), "LoadSuitEffect", 0, typeof(System.String), typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler.SetBelong(null);
				}
				return r_RLoadSuitEffect_String_Object_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void AddToSuitEffectLib(System.String, UnityEngine.GameObject)
		/// </summary>
		protected static RMethod r_RAddToSuitEffectLib_String_GameObject;
		public static RMethod RAddToSuitEffectLib_String_GameObject
		{
			get
			{
				if(r_RAddToSuitEffectLib_String_GameObject == null)
				{
					r_RAddToSuitEffectLib_String_GameObject = new( ReleactionUtils.GetType("AvatarController"), "AddToSuitEffectLib", 0, typeof(System.String), typeof(UnityEngine.GameObject));
					r_RAddToSuitEffectLib_String_GameObject.SetBelong(null);
				}
				return r_RAddToSuitEffectLib_String_GameObject;
			}
		}

		/// <summary>
		/// Void OnLoadSuitEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected static RMethod r_ROnLoadSuitEffect_Object_ABLoadedArgs;
		public static RMethod ROnLoadSuitEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadSuitEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadSuitEffect_Object_ABLoadedArgs = new( ReleactionUtils.GetType("AvatarController"), "OnLoadSuitEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadSuitEffect_Object_ABLoadedArgs.SetBelong(null);
				}
				return r_ROnLoadSuitEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void EmbedSuitEffectUpdate()
		/// </summary>
		protected RMethod r_REmbedSuitEffectUpdate;
		public virtual RMethod REmbedSuitEffectUpdate
		{
			get
			{
				if(r_REmbedSuitEffectUpdate == null)
				{
					r_REmbedSuitEffectUpdate = new(this, "EmbedSuitEffectUpdate", 0);
					r_REmbedSuitEffectUpdate.SetBelong(this.instance);
				}
				return r_REmbedSuitEffectUpdate;
			}
		}

		/// <summary>
		/// Void _EmbedSuitEffectUpdate(System.String)
		/// </summary>
		protected RMethod r_R_EmbedSuitEffectUpdate_String;
		public virtual RMethod R_EmbedSuitEffectUpdate_String
		{
			get
			{
				if(r_R_EmbedSuitEffectUpdate_String == null)
				{
					r_R_EmbedSuitEffectUpdate_String = new(this, "_EmbedSuitEffectUpdate", 0, typeof(System.String));
					r_R_EmbedSuitEffectUpdate_String.SetBelong(this.instance);
				}
				return r_R_EmbedSuitEffectUpdate_String;
			}
		}

		/// <summary>
		/// Void StarSuitEffectUpdate()
		/// </summary>
		protected RMethod r_RStarSuitEffectUpdate;
		public virtual RMethod RStarSuitEffectUpdate
		{
			get
			{
				if(r_RStarSuitEffectUpdate == null)
				{
					r_RStarSuitEffectUpdate = new(this, "StarSuitEffectUpdate", 0);
					r_RStarSuitEffectUpdate.SetBelong(this.instance);
				}
				return r_RStarSuitEffectUpdate;
			}
		}

		/// <summary>
		/// Void _StarSuitEffectUpdate(System.String)
		/// </summary>
		protected RMethod r_R_StarSuitEffectUpdate_String;
		public virtual RMethod R_StarSuitEffectUpdate_String
		{
			get
			{
				if(r_R_StarSuitEffectUpdate_String == null)
				{
					r_R_StarSuitEffectUpdate_String = new(this, "_StarSuitEffectUpdate", 0, typeof(System.String));
					r_R_StarSuitEffectUpdate_String.SetBelong(this.instance);
				}
				return r_R_StarSuitEffectUpdate_String;
			}
		}

		/// <summary>
		/// Void GodSuitEffectUpdate()
		/// </summary>
		protected RMethod r_RGodSuitEffectUpdate;
		public virtual RMethod RGodSuitEffectUpdate
		{
			get
			{
				if(r_RGodSuitEffectUpdate == null)
				{
					r_RGodSuitEffectUpdate = new(this, "GodSuitEffectUpdate", 0);
					r_RGodSuitEffectUpdate.SetBelong(this.instance);
				}
				return r_RGodSuitEffectUpdate;
			}
		}

		/// <summary>
		/// Void _GodSuitEffectUpdate(System.String)
		/// </summary>
		protected RMethod r_R_GodSuitEffectUpdate_String;
		public virtual RMethod R_GodSuitEffectUpdate_String
		{
			get
			{
				if(r_R_GodSuitEffectUpdate_String == null)
				{
					r_R_GodSuitEffectUpdate_String = new(this, "_GodSuitEffectUpdate", 0, typeof(System.String));
					r_R_GodSuitEffectUpdate_String.SetBelong(this.instance);
				}
				return r_R_GodSuitEffectUpdate_String;
			}
		}

		/// <summary>
		/// Void UpdateSuitEffect()
		/// </summary>
		protected RMethod r_RUpdateSuitEffect;
		public virtual RMethod RUpdateSuitEffect
		{
			get
			{
				if(r_RUpdateSuitEffect == null)
				{
					r_RUpdateSuitEffect = new(this, "UpdateSuitEffect", 0);
					r_RUpdateSuitEffect.SetBelong(this.instance);
				}
				return r_RUpdateSuitEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject InstantiateEffect(System.String, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RInstantiateEffect_String_GameObject;
		public virtual RMethod RInstantiateEffect_String_GameObject
		{
			get
			{
				if(r_RInstantiateEffect_String_GameObject == null)
				{
					r_RInstantiateEffect_String_GameObject = new(this, "InstantiateEffect", 0, typeof(System.String), typeof(UnityEngine.GameObject));
					r_RInstantiateEffect_String_GameObject.SetBelong(this.instance);
				}
				return r_RInstantiateEffect_String_GameObject;
			}
		}

		/// <summary>
		/// Void OnSuitEffectLoaded(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnSuitEffectLoaded_Object_ABLoadedArgs;
		public virtual RMethod ROnSuitEffectLoaded_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnSuitEffectLoaded_Object_ABLoadedArgs == null)
				{
					r_ROnSuitEffectLoaded_Object_ABLoadedArgs = new(this, "OnSuitEffectLoaded", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnSuitEffectLoaded_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnSuitEffectLoaded_Object_ABLoadedArgs;
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
		/// Void SetWeapon(Boolean)
		/// </summary>
		protected RMethod r_RSetWeapon_Boolean;
		public virtual RMethod RSetWeapon_Boolean
		{
			get
			{
				if(r_RSetWeapon_Boolean == null)
				{
					r_RSetWeapon_Boolean = new(this, "SetWeapon", 0, typeof(System.Boolean));
					r_RSetWeapon_Boolean.SetBelong(this.instance);
				}
				return r_RSetWeapon_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetWeaponPointTransform(System.String)
		/// </summary>
		protected RMethod r_RGetWeaponPointTransform_String;
		public virtual RMethod RGetWeaponPointTransform_String
		{
			get
			{
				if(r_RGetWeaponPointTransform_String == null)
				{
					r_RGetWeaponPointTransform_String = new(this, "GetWeaponPointTransform", 0, typeof(System.String));
					r_RGetWeaponPointTransform_String.SetBelong(this.instance);
				}
				return r_RGetWeaponPointTransform_String;
			}
		}

		/// <summary>
		/// Void ShowErrorMsg(System.String)
		/// </summary>
		protected RMethod r_RShowErrorMsg_String;
		public virtual RMethod RShowErrorMsg_String
		{
			get
			{
				if(r_RShowErrorMsg_String == null)
				{
					r_RShowErrorMsg_String = new(this, "ShowErrorMsg", 0, typeof(System.String));
					r_RShowErrorMsg_String.SetBelong(this.instance);
				}
				return r_RShowErrorMsg_String;
			}
		}

		/// <summary>
		/// Void ChangePositionByName(UnityEngine.GameObject, System.String)
		/// </summary>
		protected RMethod r_RChangePositionByName_GameObject_String;
		public virtual RMethod RChangePositionByName_GameObject_String
		{
			get
			{
				if(r_RChangePositionByName_GameObject_String == null)
				{
					r_RChangePositionByName_GameObject_String = new(this, "ChangePositionByName", 0, typeof(UnityEngine.GameObject), typeof(System.String));
					r_RChangePositionByName_GameObject_String.SetBelong(this.instance);
				}
				return r_RChangePositionByName_GameObject_String;
			}
		}

		/// <summary>
		/// System.String GetWeaponPointName()
		/// </summary>
		protected RMethod r_RGetWeaponPointName;
		public virtual RMethod RGetWeaponPointName
		{
			get
			{
				if(r_RGetWeaponPointName == null)
				{
					r_RGetWeaponPointName = new(this, "GetWeaponPointName", 0);
					r_RGetWeaponPointName.SetBelong(this.instance);
				}
				return r_RGetWeaponPointName;
			}
		}

		/// <summary>
		/// Void ClearWeapon()
		/// </summary>
		protected RMethod r_RClearWeapon;
		public virtual RMethod RClearWeapon
		{
			get
			{
				if(r_RClearWeapon == null)
				{
					r_RClearWeapon = new(this, "ClearWeapon", 0);
					r_RClearWeapon.SetBelong(this.instance);
				}
				return r_RClearWeapon;
			}
		}

		/// <summary>
		/// Void _LeaveCombat()
		/// </summary>
		protected RMethod r_R_LeaveCombat;
		public virtual RMethod R_LeaveCombat
		{
			get
			{
				if(r_R_LeaveCombat == null)
				{
					r_R_LeaveCombat = new(this, "_LeaveCombat", 0);
					r_R_LeaveCombat.SetBelong(this.instance);
				}
				return r_R_LeaveCombat;
			}
		}

		/// <summary>
		/// Void AddWeapon()
		/// </summary>
		protected RMethod r_RAddWeapon;
		public virtual RMethod RAddWeapon
		{
			get
			{
				if(r_RAddWeapon == null)
				{
					r_RAddWeapon = new(this, "AddWeapon", 0);
					r_RAddWeapon.SetBelong(this.instance);
				}
				return r_RAddWeapon;
			}
		}

		/// <summary>
		/// Void RefreshMyWeaponModle(weaponInfo)
		/// </summary>
		protected RMethod r_RRefreshMyWeaponModle_weaponInfo;
		public virtual RMethod RRefreshMyWeaponModle_weaponInfo
		{
			get
			{
				if(r_RRefreshMyWeaponModle_weaponInfo == null)
				{
					r_RRefreshMyWeaponModle_weaponInfo = new(this, "RefreshMyWeaponModle", 0,  ReleactionUtils.GetType("AvatarController+weaponInfo"));
					r_RRefreshMyWeaponModle_weaponInfo.SetBelong(this.instance);
				}
				return r_RRefreshMyWeaponModle_weaponInfo;
			}
		}

		/// <summary>
		/// Void RefreshWeaponModle(weaponInfo)
		/// </summary>
		protected RMethod r_RRefreshWeaponModle_weaponInfo;
		public virtual RMethod RRefreshWeaponModle_weaponInfo
		{
			get
			{
				if(r_RRefreshWeaponModle_weaponInfo == null)
				{
					r_RRefreshWeaponModle_weaponInfo = new(this, "RefreshWeaponModle", 0,  ReleactionUtils.GetType("AvatarController+weaponInfo"));
					r_RRefreshWeaponModle_weaponInfo.SetBelong(this.instance);
				}
				return r_RRefreshWeaponModle_weaponInfo;
			}
		}

		/// <summary>
		/// Void UpdateWeapon()
		/// </summary>
		protected RMethod r_RUpdateWeapon;
		public virtual RMethod RUpdateWeapon
		{
			get
			{
				if(r_RUpdateWeapon == null)
				{
					r_RUpdateWeapon = new(this, "UpdateWeapon", 0);
					r_RUpdateWeapon.SetBelong(this.instance);
				}
				return r_RUpdateWeapon;
			}
		}

		/// <summary>
		/// Void SetIDbodyItem(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSetIDbodyItem_ID;
		public virtual RMethod RSetIDbodyItem_ID
		{
			get
			{
				if(r_RSetIDbodyItem_ID == null)
				{
					r_RSetIDbodyItem_ID = new(this, "SetIDbodyItem", 0, typeof(GameDefineType.ID));
					r_RSetIDbodyItem_ID.SetBelong(this.instance);
				}
				return r_RSetIDbodyItem_ID;
			}
		}

		/// <summary>
		/// Void UpdateAvatar()
		/// </summary>
		protected RMethod r_RUpdateAvatar;
		public virtual RMethod RUpdateAvatar
		{
			get
			{
				if(r_RUpdateAvatar == null)
				{
					r_RUpdateAvatar = new(this, "UpdateAvatar", 0);
					r_RUpdateAvatar.SetBelong(this.instance);
				}
				return r_RUpdateAvatar;
			}
		}

		/// <summary>
		/// Void UpdateAvatar(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RUpdateAvatar_ID;
		public virtual RMethod RUpdateAvatar_ID
		{
			get
			{
				if(r_RUpdateAvatar_ID == null)
				{
					r_RUpdateAvatar_ID = new(this, "UpdateAvatar", 0, typeof(GameDefineType.ID));
					r_RUpdateAvatar_ID.SetBelong(this.instance);
				}
				return r_RUpdateAvatar_ID;
			}
		}

		/// <summary>
		/// Void OnLoadPlayer(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadPlayer_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadPlayer_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadPlayer_Object_CGLoadedArgs == null)
				{
					r_ROnLoadPlayer_Object_CGLoadedArgs = new(this, "OnLoadPlayer", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadPlayer_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadPlayer_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void RemoveAllWeapon()
		/// </summary>
		protected RMethod r_RRemoveAllWeapon;
		public virtual RMethod RRemoveAllWeapon
		{
			get
			{
				if(r_RRemoveAllWeapon == null)
				{
					r_RRemoveAllWeapon = new(this, "RemoveAllWeapon", 0);
					r_RRemoveAllWeapon.SetBelong(this.instance);
				}
				return r_RRemoveAllWeapon;
			}
		}

		/// <summary>
		/// Void WeaponsOnInCombat(GameDefineType.ID, Int32, Int32)
		/// </summary>
		protected RMethod r_RWeaponsOnInCombat_ID_Int32_Int32;
		public virtual RMethod RWeaponsOnInCombat_ID_Int32_Int32
		{
			get
			{
				if(r_RWeaponsOnInCombat_ID_Int32_Int32 == null)
				{
					r_RWeaponsOnInCombat_ID_Int32_Int32 = new(this, "WeaponsOnInCombat", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32));
					r_RWeaponsOnInCombat_ID_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWeaponsOnInCombat_ID_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ChangWeaponOutOfCombat(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RChangWeaponOutOfCombat_ID_ID;
		public virtual RMethod RChangWeaponOutOfCombat_ID_ID
		{
			get
			{
				if(r_RChangWeaponOutOfCombat_ID_ID == null)
				{
					r_RChangWeaponOutOfCombat_ID_ID = new(this, "ChangWeaponOutOfCombat", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RChangWeaponOutOfCombat_ID_ID.SetBelong(this.instance);
				}
				return r_RChangWeaponOutOfCombat_ID_ID;
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
		/// Void WeaponsOn()
		/// </summary>
		protected RMethod r_RWeaponsOn;
		public virtual RMethod RWeaponsOn
		{
			get
			{
				if(r_RWeaponsOn == null)
				{
					r_RWeaponsOn = new(this, "WeaponsOn", 0);
					r_RWeaponsOn.SetBelong(this.instance);
				}
				return r_RWeaponsOn;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator OnModleLoadedReset()
		/// </summary>
		protected RMethod r_ROnModleLoadedReset;
		public virtual RMethod ROnModleLoadedReset
		{
			get
			{
				if(r_ROnModleLoadedReset == null)
				{
					r_ROnModleLoadedReset = new(this, "OnModleLoadedReset", 0);
					r_ROnModleLoadedReset.SetBelong(this.instance);
				}
				return r_ROnModleLoadedReset;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator InitFlowllEffect()
		/// </summary>
		protected RMethod r_RInitFlowllEffect;
		public virtual RMethod RInitFlowllEffect
		{
			get
			{
				if(r_RInitFlowllEffect == null)
				{
					r_RInitFlowllEffect = new(this, "InitFlowllEffect", 0);
					r_RInitFlowllEffect.SetBelong(this.instance);
				}
				return r_RInitFlowllEffect;
			}
		}

		/// <summary>
		/// Void OnBecameVisible()
		/// </summary>
		protected RMethod r_ROnBecameVisible;
		public virtual RMethod ROnBecameVisible
		{
			get
			{
				if(r_ROnBecameVisible == null)
				{
					r_ROnBecameVisible = new(this, "OnBecameVisible", 0);
					r_ROnBecameVisible.SetBelong(this.instance);
				}
				return r_ROnBecameVisible;
			}
		}

		/// <summary>
		/// Void OnBecameInvisible()
		/// </summary>
		protected RMethod r_ROnBecameInvisible;
		public virtual RMethod ROnBecameInvisible
		{
			get
			{
				if(r_ROnBecameInvisible == null)
				{
					r_ROnBecameInvisible = new(this, "OnBecameInvisible", 0);
					r_ROnBecameInvisible.SetBelong(this.instance);
				}
				return r_ROnBecameInvisible;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Void RemoveTaskTitleEffect()
		/// </summary>
		protected RMethod r_RRemoveTaskTitleEffect;
		public virtual RMethod RRemoveTaskTitleEffect
		{
			get
			{
				if(r_RRemoveTaskTitleEffect == null)
				{
					r_RRemoveTaskTitleEffect = new(this, "RemoveTaskTitleEffect", 0);
					r_RRemoveTaskTitleEffect.SetBelong(this.instance);
				}
				return r_RRemoveTaskTitleEffect;
			}
		}

		/// <summary>
		/// Void RecoverTaskTitleEffect()
		/// </summary>
		protected RMethod r_RRecoverTaskTitleEffect;
		public virtual RMethod RRecoverTaskTitleEffect
		{
			get
			{
				if(r_RRecoverTaskTitleEffect == null)
				{
					r_RRecoverTaskTitleEffect = new(this, "RecoverTaskTitleEffect", 0);
					r_RRecoverTaskTitleEffect.SetBelong(this.instance);
				}
				return r_RRecoverTaskTitleEffect;
			}
		}

		/// <summary>
		/// System.String GetBeadFightEffectName(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetBeadFightEffectName_Int32_Ref_Single;
		public virtual RMethod RGetBeadFightEffectName_Int32_Ref_Single
		{
			get
			{
				if(r_RGetBeadFightEffectName_Int32_Ref_Single == null)
				{
					r_RGetBeadFightEffectName_Int32_Ref_Single = new(this, "GetBeadFightEffectName", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetBeadFightEffectName_Int32_Ref_Single.SetBelong(this.instance);
				}
				return r_RGetBeadFightEffectName_Int32_Ref_Single;
			}
		}

		/// <summary>
		/// System.String GetSelectInfoEffectName(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetSelectInfoEffectName_Int32_Ref_Single;
		public virtual RMethod RGetSelectInfoEffectName_Int32_Ref_Single
		{
			get
			{
				if(r_RGetSelectInfoEffectName_Int32_Ref_Single == null)
				{
					r_RGetSelectInfoEffectName_Int32_Ref_Single = new(this, "GetSelectInfoEffectName", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetSelectInfoEffectName_Int32_Ref_Single.SetBelong(this.instance);
				}
				return r_RGetSelectInfoEffectName_Int32_Ref_Single;
			}
		}

		/// <summary>
		/// Void SetTaskEffect(TaskEffectInfo, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RSetTaskEffect_TaskEffectInfo_GameObject;
		public virtual RMethod RSetTaskEffect_TaskEffectInfo_GameObject
		{
			get
			{
				if(r_RSetTaskEffect_TaskEffectInfo_GameObject == null)
				{
					r_RSetTaskEffect_TaskEffectInfo_GameObject = new(this, "SetTaskEffect", 0,  ReleactionUtils.GetType("AvatarController+TaskEffectInfo"), typeof(UnityEngine.GameObject));
					r_RSetTaskEffect_TaskEffectInfo_GameObject.SetBelong(this.instance);
				}
				return r_RSetTaskEffect_TaskEffectInfo_GameObject;
			}
		}

		/// <summary>
		/// Void UpdateTaskEffect(TASK_EFFECT, System.String, Single)
		/// </summary>
		protected RMethod r_RUpdateTaskEffect_TASK_EFFECT_String_Single;
		public virtual RMethod RUpdateTaskEffect_TASK_EFFECT_String_Single
		{
			get
			{
				if(r_RUpdateTaskEffect_TASK_EFFECT_String_Single == null)
				{
					r_RUpdateTaskEffect_TASK_EFFECT_String_Single = new(this, "UpdateTaskEffect", 0,  ReleactionUtils.GetType("AvatarController+TASK_EFFECT"), typeof(System.String), typeof(System.Single));
					r_RUpdateTaskEffect_TASK_EFFECT_String_Single.SetBelong(this.instance);
				}
				return r_RUpdateTaskEffect_TASK_EFFECT_String_Single;
			}
		}

		/// <summary>
		/// Void OnTaskEffectLoaded(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnTaskEffectLoaded_Object_ABLoadedArgs;
		public virtual RMethod ROnTaskEffectLoaded_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnTaskEffectLoaded_Object_ABLoadedArgs == null)
				{
					r_ROnTaskEffectLoaded_Object_ABLoadedArgs = new(this, "OnTaskEffectLoaded", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnTaskEffectLoaded_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnTaskEffectLoaded_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void ShowTaskEffect(System.Object)
		/// </summary>
		protected RMethod r_RShowTaskEffect_Object;
		public virtual RMethod RShowTaskEffect_Object
		{
			get
			{
				if(r_RShowTaskEffect_Object == null)
				{
					r_RShowTaskEffect_Object = new(this, "ShowTaskEffect", 0, typeof(System.Object));
					r_RShowTaskEffect_Object.SetBelong(this.instance);
				}
				return r_RShowTaskEffect_Object;
			}
		}

		/// <summary>
		/// Void UpdateSpecialTitle(TITLE_INFO)
		/// </summary>
		protected RMethod r_RUpdateSpecialTitle_TITLE_INFO;
		public virtual RMethod RUpdateSpecialTitle_TITLE_INFO
		{
			get
			{
				if(r_RUpdateSpecialTitle_TITLE_INFO == null)
				{
					r_RUpdateSpecialTitle_TITLE_INFO = new(this, "UpdateSpecialTitle", 0, typeof(TITLE_INFO));
					r_RUpdateSpecialTitle_TITLE_INFO.SetBelong(this.instance);
				}
				return r_RUpdateSpecialTitle_TITLE_INFO;
			}
		}

		/// <summary>
		/// Void ShowFlowerBodyEffect(System.Object)
		/// </summary>
		protected RMethod r_RShowFlowerBodyEffect_Object;
		public virtual RMethod RShowFlowerBodyEffect_Object
		{
			get
			{
				if(r_RShowFlowerBodyEffect_Object == null)
				{
					r_RShowFlowerBodyEffect_Object = new(this, "ShowFlowerBodyEffect", 0, typeof(System.Object));
					r_RShowFlowerBodyEffect_Object.SetBelong(this.instance);
				}
				return r_RShowFlowerBodyEffect_Object;
			}
		}

		/// <summary>
		/// Void RegisterEffectFollowingReset(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RRegisterEffectFollowingReset_Transform;
		public virtual RMethod RRegisterEffectFollowingReset_Transform
		{
			get
			{
				if(r_RRegisterEffectFollowingReset_Transform == null)
				{
					r_RRegisterEffectFollowingReset_Transform = new(this, "RegisterEffectFollowingReset", 0, typeof(UnityEngine.Transform));
					r_RRegisterEffectFollowingReset_Transform.SetBelong(this.instance);
				}
				return r_RRegisterEffectFollowingReset_Transform;
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


        public RAvatarController() : base("AvatarController")
        {
        }

        public RAvatarController(System.Object instance) : base("AvatarController")
		{
            SetInstance(instance);
		}

        public RAvatarController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAvatarController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 GetDefaultWeaponType(System.UInt32  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = RGetDefaultWeaponType_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetAnimationWeaponTypeName(System.UInt32  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = RGetAnimationWeaponTypeName_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.GameObject InstantiateEffect(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RInstantiateEffect_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public static System.Boolean IsSuitEffectLibExist(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsSuitEffectLibExist_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public static void AddToSuitEffectLib(System.String  @suitEffectname, UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suitEffectname, @obj};
            var ___result = RAddToSuitEffectLib_String_GameObject.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void EmbedSuitEffectUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REmbedSuitEffectUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _EmbedSuitEffectUpdate(System.String  @embedSuit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@embedSuit};
            var ___result = R_EmbedSuitEffectUpdate_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StarSuitEffectUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStarSuitEffectUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _StarSuitEffectUpdate(System.String  @starSuit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@starSuit};
            var ___result = R_StarSuitEffectUpdate_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GodSuitEffectUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGodSuitEffectUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _GodSuitEffectUpdate(System.String  @godSuit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@godSuit};
            var ___result = R_GodSuitEffectUpdate_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSuitEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateSuitEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject InstantiateEffect(System.String  @name, UnityEngine.GameObject  @prefab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @prefab};
            var ___result = RInstantiateEffect_String_GameObject.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }



        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWeapon(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = RSetWeapon_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Transform GetWeaponPointTransform(System.String  @WeaponPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@WeaponPoint};
            var ___result = RGetWeaponPointTransform_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public virtual void ShowErrorMsg(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RShowErrorMsg_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChangePositionByName(UnityEngine.GameObject  @obj, System.String  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @to};
            var ___result = RChangePositionByName_GameObject_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetWeaponPointName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWeaponPointName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ClearWeapon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearWeapon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _LeaveCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_LeaveCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddWeapon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddWeapon.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void UpdateWeapon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWeapon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIDbodyItem(GameDefineType.ID  @idBody)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBody};
            var ___result = RSetIDbodyItem_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAvatar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAvatar.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAvatar(GameDefineType.ID  @idBodyTypItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBodyTypItem};
            var ___result = RUpdateAvatar_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void RemoveAllWeapon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAllWeapon.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WeaponsOnInCombat(GameDefineType.ID  @weaponTyp, System.Int32  @nInlayCount, System.Int32  @nStartSuiLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weaponTyp, @nInlayCount, @nStartSuiLevel};
            var ___result = RWeaponsOnInCombat_ID_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChangWeaponOutOfCombat(GameDefineType.ID  @idEquipType, GameDefineType.ID  @itemT)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEquipType, @itemT};
            var ___result = RChangWeaponOutOfCombat_ID_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGetWeaponRes(System.Object  @sender, UnityEngine.GameObject  @weapon0, UnityEngine.GameObject  @weapon1, System.Object  @tmpObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @weapon0, @weapon1, @tmpObj};
            var ___result = ROnGetWeaponRes_Object_GameObject_GameObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WeaponsOn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWeaponsOn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator OnModleLoadedReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnModleLoadedReset.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator InitFlowllEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitFlowllEffect.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void OnBecameVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameVisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBecameInvisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameInvisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveTaskTitleEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveTaskTitleEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecoverTaskTitleEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecoverTaskTitleEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetBeadFightEffectName(System.Int32  @value, ref System.Single  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @h};
            var ___result = RGetBeadFightEffectName_Int32_Ref_Single.Invoke(___genericsType, ___parameters);
			h = (System.Single)___parameters[1];

            return (System.String)___result;
        }


        public virtual System.String GetSelectInfoEffectName(System.Int32  @value, ref System.Single  @h)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @h};
            var ___result = RGetSelectInfoEffectName_Int32_Ref_Single.Invoke(___genericsType, ___parameters);
			h = (System.Single)___parameters[1];

            return (System.String)___result;
        }





        public virtual void ShowTaskEffect(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RShowTaskEffect_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSpecialTitle(TITLE_INFO  @titleInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@titleInfo};
            var ___result = RUpdateSpecialTitle_TITLE_INFO.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowFlowerBodyEffect(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RShowFlowerBodyEffect_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterEffectFollowingReset(UnityEngine.Transform  @transTarget)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transTarget};
            var ___result = RRegisterEffectFollowingReset_Transform.Invoke(___genericsType, ___parameters);

            
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
