using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// UIManager
	/// </summary>
    public partial class RUIManager : RMember //
    {

		/// <summary>
		/// System.Int32 countInitEveryFrame
		/// </summary>
		protected static RField r_countInitEveryFrame;
		public static RField RcountInitEveryFrame
		{
			get
			{
				if(r_countInitEveryFrame == null)
				{
					r_countInitEveryFrame = new( ReleactionUtils.GetType("UIManager"), "countInitEveryFrame");
					r_countInitEveryFrame.SetBelong(null);
				}
				return r_countInitEveryFrame;
			}
		}

		/// <summary>
		/// UnityEngine.Font mFont
		/// </summary>
		protected RUnityEngine.RFont r_mFont;
		public virtual RUnityEngine.RFont RmFont
		{
			get
			{
				if(r_mFont == null)
				{
					r_mFont = new(this, "mFont");
					r_mFont.SetBelong(this.instance);
				}
				return r_mFont;
			}
		}

		/// <summary>
		/// UnityEngine.Font mPlayerNameFont
		/// </summary>
		protected static RUnityEngine.RFont r_mPlayerNameFont;
		public static RUnityEngine.RFont RmPlayerNameFont
		{
			get
			{
				if(r_mPlayerNameFont == null)
				{
					r_mPlayerNameFont = new( ReleactionUtils.GetType("UIManager"), "mPlayerNameFont");
					r_mPlayerNameFont.SetBelong(null);
				}
				return r_mPlayerNameFont;
			}
		}

		/// <summary>
		/// UnityEngine.Font mPlayerFunFont
		/// </summary>
		protected static RUnityEngine.RFont r_mPlayerFunFont;
		public static RUnityEngine.RFont RmPlayerFunFont
		{
			get
			{
				if(r_mPlayerFunFont == null)
				{
					r_mPlayerFunFont = new( ReleactionUtils.GetType("UIManager"), "mPlayerFunFont");
					r_mPlayerFunFont.SetBelong(null);
				}
				return r_mPlayerFunFont;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] m_allTex
		/// </summary>
		protected static RFieldArray<RUnityEngine.RTexture2D> r_m_allTex;
		public static RFieldArray<RUnityEngine.RTexture2D> Rm_allTex
		{
			get
			{
				if(r_m_allTex == null)
				{
					r_m_allTex = new( ReleactionUtils.GetType("UIManager"), "m_allTex");
					r_m_allTex.SetBelong(null);
				}
				return r_m_allTex;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D transparentTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_transparentTex;
		public virtual RUnityEngine.RTexture2D RtransparentTex
		{
			get
			{
				if(r_transparentTex == null)
				{
					r_transparentTex = new(this, "transparentTex");
					r_transparentTex.SetBelong(this.instance);
				}
				return r_transparentTex;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mBeginWindow
		/// </summary>
		protected RUnityEngine.RGameObject r_mBeginWindow;
		public virtual RUnityEngine.RGameObject RmBeginWindow
		{
			get
			{
				if(r_mBeginWindow == null)
				{
					r_mBeginWindow = new(this, "mBeginWindow");
					r_mBeginWindow.SetBelong(this.instance);
				}
				return r_mBeginWindow;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mUIobjRoot
		/// </summary>
		protected RUnityEngine.RGameObject r_mUIobjRoot;
		public virtual RUnityEngine.RGameObject RmUIobjRoot
		{
			get
			{
				if(r_mUIobjRoot == null)
				{
					r_mUIobjRoot = new(this, "mUIobjRoot");
					r_mUIobjRoot.SetBelong(this.instance);
				}
				return r_mUIobjRoot;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,MyGUIWindow] mUIGroup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIWindow> r_mUIGroup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIWindow> RmUIGroup
		{
			get
			{
				if(r_mUIGroup == null)
				{
					r_mUIGroup = new(this, "mUIGroup");
					r_mUIGroup.SetBelong(this.instance);
				}
				return r_mUIGroup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] mElemLanguageGroup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_mElemLanguageGroup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RmElemLanguageGroup
		{
			get
			{
				if(r_mElemLanguageGroup == null)
				{
					r_mElemLanguageGroup = new(this, "mElemLanguageGroup");
					r_mElemLanguageGroup.SetBelong(this.instance);
				}
				return r_mElemLanguageGroup;
			}
		}

		/// <summary>
		/// UI_CONTENT_GROUP mUIContentGroup
		/// </summary>
		protected RUI_CONTENT_GROUP r_mUIContentGroup;
		public virtual RUI_CONTENT_GROUP RmUIContentGroup
		{
			get
			{
				if(r_mUIContentGroup == null)
				{
					r_mUIContentGroup = new(this, "mUIContentGroup");
					r_mUIContentGroup.SetBelong(this.instance);
				}
				return r_mUIContentGroup;
			}
		}

		/// <summary>
		/// System.String _defaultTemplateSkinName
		/// </summary>
		protected RField r__defaultTemplateSkinName;
		public virtual RField R_defaultTemplateSkinName
		{
			get
			{
				if(r__defaultTemplateSkinName == null)
				{
					r__defaultTemplateSkinName = new(this, "_defaultTemplateSkinName");
					r__defaultTemplateSkinName.SetBelong(this.instance);
				}
				return r__defaultTemplateSkinName;
			}
		}

		/// <summary>
		/// System.String Empty_Skin_Name
		/// </summary>
		protected RField r_Empty_Skin_Name;
		public virtual RField REmpty_Skin_Name
		{
			get
			{
				if(r_Empty_Skin_Name == null)
				{
					r_Empty_Skin_Name = new(this, "Empty_Skin_Name");
					r_Empty_Skin_Name.SetBelong(this.instance);
				}
				return r_Empty_Skin_Name;
			}
		}

		/// <summary>
		/// System.Int32 mWndTotal
		/// </summary>
		protected RField r_mWndTotal;
		public virtual RField RmWndTotal
		{
			get
			{
				if(r_mWndTotal == null)
				{
					r_mWndTotal = new(this, "mWndTotal");
					r_mWndTotal.SetBelong(this.instance);
				}
				return r_mWndTotal;
			}
		}

		/// <summary>
		/// System.Int32 mWndLoaded
		/// </summary>
		protected RField r_mWndLoaded;
		public virtual RField RmWndLoaded
		{
			get
			{
				if(r_mWndLoaded == null)
				{
					r_mWndLoaded = new(this, "mWndLoaded");
					r_mWndLoaded.SetBelong(this.instance);
				}
				return r_mWndLoaded;
			}
		}

		/// <summary>
		/// System.Int32 _assertTotal
		/// </summary>
		protected RField r__assertTotal;
		public virtual RField R_assertTotal
		{
			get
			{
				if(r__assertTotal == null)
				{
					r__assertTotal = new(this, "_assertTotal");
					r__assertTotal.SetBelong(this.instance);
				}
				return r__assertTotal;
			}
		}

		/// <summary>
		/// System.Int32 _assertLoaded
		/// </summary>
		protected RField r__assertLoaded;
		public virtual RField R_assertLoaded
		{
			get
			{
				if(r__assertLoaded == null)
				{
					r__assertLoaded = new(this, "_assertLoaded");
					r__assertLoaded.SetBelong(this.instance);
				}
				return r__assertLoaded;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUIWindow] waitInitList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUIWindow> r_waitInitList;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUIWindow> RwaitInitList
		{
			get
			{
				if(r_waitInitList == null)
				{
					r_waitInitList = new(this, "waitInitList");
					r_waitInitList.SetBelong(this.instance);
				}
				return r_waitInitList;
			}
		}

		/// <summary>
		/// System.Boolean bLayoutDownloaded
		/// </summary>
		protected RField r_bLayoutDownloaded;
		public virtual RField RbLayoutDownloaded
		{
			get
			{
				if(r_bLayoutDownloaded == null)
				{
					r_bLayoutDownloaded = new(this, "bLayoutDownloaded");
					r_bLayoutDownloaded.SetBelong(this.instance);
				}
				return r_bLayoutDownloaded;
			}
		}

		/// <summary>
		/// System.String copyBuffer
		/// </summary>
		protected RField r_copyBuffer;
		public virtual RField RcopyBuffer
		{
			get
			{
				if(r_copyBuffer == null)
				{
					r_copyBuffer = new(this, "copyBuffer");
					r_copyBuffer.SetBelong(this.instance);
				}
				return r_copyBuffer;
			}
		}

		/// <summary>
		/// System.Boolean bSetCopyBuffer
		/// </summary>
		protected RField r_bSetCopyBuffer;
		public virtual RField RbSetCopyBuffer
		{
			get
			{
				if(r_bSetCopyBuffer == null)
				{
					r_bSetCopyBuffer = new(this, "bSetCopyBuffer");
					r_bSetCopyBuffer.SetBelong(this.instance);
				}
				return r_bSetCopyBuffer;
			}
		}

		/// <summary>
		/// System.Int32 hotControl
		/// </summary>
		protected static RField r_hotControl;
		public static RField RhotControl
		{
			get
			{
				if(r_hotControl == null)
				{
					r_hotControl = new( ReleactionUtils.GetType("UIManager"), "hotControl");
					r_hotControl.SetBelong(null);
				}
				return r_hotControl;
			}
		}

		/// <summary>
		/// TransactionMonitor uiTransaction
		/// </summary>
		protected RTransactionMonitor r_uiTransaction;
		public virtual RTransactionMonitor RuiTransaction
		{
			get
			{
				if(r_uiTransaction == null)
				{
					r_uiTransaction = new(this, "uiTransaction");
					r_uiTransaction.SetBelong(this.instance);
				}
				return r_uiTransaction;
			}
		}

		/// <summary>
		/// TransactionMonitor wndsLoadTransaction
		/// </summary>
		protected RTransactionMonitor r_wndsLoadTransaction;
		public virtual RTransactionMonitor RwndsLoadTransaction
		{
			get
			{
				if(r_wndsLoadTransaction == null)
				{
					r_wndsLoadTransaction = new(this, "wndsLoadTransaction");
					r_wndsLoadTransaction.SetBelong(this.instance);
				}
				return r_wndsLoadTransaction;
			}
		}

		/// <summary>
		/// MyGUIWndTipTextWnd+WindowAndElementTip elemInfo
		/// </summary>
		protected RMyGUIWndTipTextWnd.RWindowAndElementTip r_elemInfo;
		public virtual RMyGUIWndTipTextWnd.RWindowAndElementTip RelemInfo
		{
			get
			{
				if(r_elemInfo == null)
				{
					r_elemInfo = new(this, "elemInfo");
					r_elemInfo.SetBelong(this.instance);
				}
				return r_elemInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Font] m_FontLib
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RFont> r_m_FontLib;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RFont> Rm_FontLib
		{
			get
			{
				if(r_m_FontLib == null)
				{
					r_m_FontLib = new( ReleactionUtils.GetType("UIManager"), "m_FontLib");
					r_m_FontLib.SetBelong(null);
				}
				return r_m_FontLib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[MyGUIWindow]] _delayInitialWindows
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RMyGUIWindow>> r__delayInitialWindows;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RMyGUIWindow>> R_delayInitialWindows
		{
			get
			{
				if(r__delayInitialWindows == null)
				{
					r__delayInitialWindows = new(this, "_delayInitialWindows");
					r__delayInitialWindows.SetBelong(this.instance);
				}
				return r__delayInitialWindows;
			}
		}

		/// <summary>
		/// System.Boolean isUIDummy
		/// </summary>
		protected RField r_isUIDummy;
		public virtual RField RisUIDummy
		{
			get
			{
				if(r_isUIDummy == null)
				{
					r_isUIDummy = new(this, "isUIDummy");
					r_isUIDummy.SetBelong(this.instance);
				}
				return r_isUIDummy;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _pauseBG
		/// </summary>
		protected RUnityEngine.RGUIStyle r__pauseBG;
		public virtual RUnityEngine.RGUIStyle R_pauseBG
		{
			get
			{
				if(r__pauseBG == null)
				{
					r__pauseBG = new(this, "_pauseBG");
					r__pauseBG.SetBelong(this.instance);
				}
				return r__pauseBG;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D tmpTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_tmpTex;
		public virtual RUnityEngine.RTexture2D RtmpTex
		{
			get
			{
				if(r_tmpTex == null)
				{
					r_tmpTex = new(this, "tmpTex");
					r_tmpTex.SetBelong(this.instance);
				}
				return r_tmpTex;
			}
		}

		/// <summary>
		/// UnityEngine.Texture tex
		/// </summary>
		protected RUnityEngine.RTexture r_tex;
		public virtual RUnityEngine.RTexture Rtex
		{
			get
			{
				if(r_tex == null)
				{
					r_tex = new(this, "tex");
					r_tex.SetBelong(this.instance);
				}
				return r_tex;
			}
		}

		/// <summary>
		/// System.Int32 m_nMaxWaitInitCount
		/// </summary>
		protected RField r_m_nMaxWaitInitCount;
		public virtual RField Rm_nMaxWaitInitCount
		{
			get
			{
				if(r_m_nMaxWaitInitCount == null)
				{
					r_m_nMaxWaitInitCount = new(this, "m_nMaxWaitInitCount");
					r_m_nMaxWaitInitCount.SetBelong(this.instance);
				}
				return r_m_nMaxWaitInitCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,MyGUIWindow] m_UpdateList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIWindow> r_m_UpdateList;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIWindow> Rm_UpdateList
		{
			get
			{
				if(r_m_UpdateList == null)
				{
					r_m_UpdateList = new(this, "m_UpdateList");
					r_m_UpdateList.SetBelong(this.instance);
				}
				return r_m_UpdateList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUIEvent,MyGUIRegistEventHandler] _handlerMap
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIRegistEventHandler> r__handlerMap;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUIRegistEventHandler> R_handlerMap
		{
			get
			{
				if(r__handlerMap == null)
				{
					r__handlerMap = new( ReleactionUtils.GetType("UIManager"), "_handlerMap");
					r__handlerMap.SetBelong(null);
				}
				return r__handlerMap;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.GameObject] m_UIeffect
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> r_m_UIeffect;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> Rm_UIeffect
		{
			get
			{
				if(r_m_UIeffect == null)
				{
					r_m_UIeffect = new(this, "m_UIeffect");
					r_m_UIeffect.SetBelong(this.instance);
				}
				return r_m_UIeffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_UIEffectRoot
		/// </summary>
		protected RUnityEngine.RGameObject r_m_UIEffectRoot;
		public virtual RUnityEngine.RGameObject Rm_UIEffectRoot
		{
			get
			{
				if(r_m_UIEffectRoot == null)
				{
					r_m_UIEffectRoot = new(this, "m_UIEffectRoot");
					r_m_UIEffectRoot.SetBelong(this.instance);
				}
				return r_m_UIEffectRoot;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D TransparentTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_TransparentTex;
		public virtual RUnityEngine.RTexture2D RTransparentTex
		{
			get
			{
				if(r_TransparentTex == null)
				{
					r_TransparentTex = new(this, "TransparentTex", -1);
					r_TransparentTex.SetBelong(this.instance);
				}
				return r_TransparentTex;
			}
		}

		/// <summary>
		/// Int32 FocusWindowID
		/// </summary>
		protected RProperty r_FocusWindowID;
		public virtual RProperty RFocusWindowID
		{
			get
			{
				if(r_FocusWindowID == null)
				{
					r_FocusWindowID = new(this, "FocusWindowID", -1);
					r_FocusWindowID.SetBelong(this.instance);
				}
				return r_FocusWindowID;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_pauseBGStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_pauseBGStyle;
		public virtual RUnityEngine.RGUIStyle Rm_pauseBGStyle
		{
			get
			{
				if(r_m_pauseBGStyle == null)
				{
					r_m_pauseBGStyle = new(this, "m_pauseBGStyle", -1);
					r_m_pauseBGStyle.SetBelong(this.instance);
				}
				return r_m_pauseBGStyle;
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
		/// Boolean HasLoadAllUI
		/// </summary>
		protected RProperty r_HasLoadAllUI;
		public virtual RProperty RHasLoadAllUI
		{
			get
			{
				if(r_HasLoadAllUI == null)
				{
					r_HasLoadAllUI = new(this, "HasLoadAllUI", -1);
					r_HasLoadAllUI.SetBelong(this.instance);
				}
				return r_HasLoadAllUI;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mGameWindSize
		/// </summary>
		protected RUnityEngine.RVector2 r_mGameWindSize;
		public virtual RUnityEngine.RVector2 RmGameWindSize
		{
			get
			{
				if(r_mGameWindSize == null)
				{
					r_mGameWindSize = new(this, "mGameWindSize", -1);
					r_mGameWindSize.SetBelong(this.instance);
				}
				return r_mGameWindSize;
			}
		}

		/// <summary>
		/// UnityEngine.Transform UIEffectRoot
		/// </summary>
		protected RUnityEngine.RTransform r_UIEffectRoot;
		public virtual RUnityEngine.RTransform RUIEffectRoot
		{
			get
			{
				if(r_UIEffectRoot == null)
				{
					r_UIEffectRoot = new(this, "UIEffectRoot", -1);
					r_UIEffectRoot.SetBelong(this.instance);
				}
				return r_UIEffectRoot;
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
		/// Void CompleteStep(System.String)
		/// </summary>
		protected RMethod r_RCompleteStep_String;
		public virtual RMethod RCompleteStep_String
		{
			get
			{
				if(r_RCompleteStep_String == null)
				{
					r_RCompleteStep_String = new(this, "CompleteStep", 0, typeof(System.String));
					r_RCompleteStep_String.SetBelong(this.instance);
				}
				return r_RCompleteStep_String;
			}
		}

		/// <summary>
		/// Void OnUILaunchComplete(ExitCondition, System.String, System.Object)
		/// </summary>
		protected RMethod r_ROnUILaunchComplete_ExitCondition_String_Object;
		public virtual RMethod ROnUILaunchComplete_ExitCondition_String_Object
		{
			get
			{
				if(r_ROnUILaunchComplete_ExitCondition_String_Object == null)
				{
					r_ROnUILaunchComplete_ExitCondition_String_Object = new(this, "OnUILaunchComplete", 0,  ReleactionUtils.GetType("TransactionMonitor+ExitCondition"), typeof(System.String), typeof(System.Object));
					r_ROnUILaunchComplete_ExitCondition_String_Object.SetBelong(this.instance);
				}
				return r_ROnUILaunchComplete_ExitCondition_String_Object;
			}
		}

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void ReturnRegistCallBack(MyGUIWindow)
		/// </summary>
		protected RMethod r_RReturnRegistCallBack_MyGUIWindow;
		public virtual RMethod RReturnRegistCallBack_MyGUIWindow
		{
			get
			{
				if(r_RReturnRegistCallBack_MyGUIWindow == null)
				{
					r_RReturnRegistCallBack_MyGUIWindow = new(this, "ReturnRegistCallBack", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RReturnRegistCallBack_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RReturnRegistCallBack_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void SetUIScreenResizable()
		/// </summary>
		protected RMethod r_RSetUIScreenResizable;
		public virtual RMethod RSetUIScreenResizable
		{
			get
			{
				if(r_RSetUIScreenResizable == null)
				{
					r_RSetUIScreenResizable = new(this, "SetUIScreenResizable", 0);
					r_RSetUIScreenResizable.SetBelong(this.instance);
				}
				return r_RSetUIScreenResizable;
			}
		}

		/// <summary>
		/// Void HandlerWindowElementClick(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_RHandlerWindowElementClick_ElementBase;
		public virtual RMethod RHandlerWindowElementClick_ElementBase
		{
			get
			{
				if(r_RHandlerWindowElementClick_ElementBase == null)
				{
					r_RHandlerWindowElementClick_ElementBase = new(this, "HandlerWindowElementClick", 0, typeof(MyGUI.ElementBase));
					r_RHandlerWindowElementClick_ElementBase.SetBelong(this.instance);
				}
				return r_RHandlerWindowElementClick_ElementBase;
			}
		}

		/// <summary>
		/// Void HandleWindowOpen(MyGUIWindow)
		/// </summary>
		protected RMethod r_RHandleWindowOpen_MyGUIWindow;
		public virtual RMethod RHandleWindowOpen_MyGUIWindow
		{
			get
			{
				if(r_RHandleWindowOpen_MyGUIWindow == null)
				{
					r_RHandleWindowOpen_MyGUIWindow = new(this, "HandleWindowOpen", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RHandleWindowOpen_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RHandleWindowOpen_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void HandleWindiwClose(System.String)
		/// </summary>
		protected RMethod r_RHandleWindiwClose_String;
		public virtual RMethod RHandleWindiwClose_String
		{
			get
			{
				if(r_RHandleWindiwClose_String == null)
				{
					r_RHandleWindiwClose_String = new(this, "HandleWindiwClose", 0, typeof(System.String));
					r_RHandleWindiwClose_String.SetBelong(this.instance);
				}
				return r_RHandleWindiwClose_String;
			}
		}

		/// <summary>
		/// Void RegisterWindows()
		/// </summary>
		protected RMethod r_RRegisterWindows;
		public virtual RMethod RRegisterWindows
		{
			get
			{
				if(r_RRegisterWindows == null)
				{
					r_RRegisterWindows = new(this, "RegisterWindows", 0);
					r_RRegisterWindows.SetBelong(this.instance);
				}
				return r_RRegisterWindows;
			}
		}

		/// <summary>
		/// Void OnAfterMainCallStart()
		/// </summary>
		protected RMethod r_ROnAfterMainCallStart;
		public virtual RMethod ROnAfterMainCallStart
		{
			get
			{
				if(r_ROnAfterMainCallStart == null)
				{
					r_ROnAfterMainCallStart = new(this, "OnAfterMainCallStart", 0);
					r_ROnAfterMainCallStart.SetBelong(this.instance);
				}
				return r_ROnAfterMainCallStart;
			}
		}

		/// <summary>
		/// Void OnHoverTipTextElement(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnHoverTipTextElement_Object___0__7X;
		public virtual RMethod ROnHoverTipTextElement_Object___0__7X
		{
			get
			{
				if(r_ROnHoverTipTextElement_Object___0__7X == null)
				{
					r_ROnHoverTipTextElement_Object___0__7X = new(this, "OnHoverTipTextElement", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnHoverTipTextElement_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnHoverTipTextElement_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnOutTipTextElement(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnOutTipTextElement_Object___0__7X;
		public virtual RMethod ROnOutTipTextElement_Object___0__7X
		{
			get
			{
				if(r_ROnOutTipTextElement_Object___0__7X == null)
				{
					r_ROnOutTipTextElement_Object___0__7X = new(this, "OnOutTipTextElement", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnOutTipTextElement_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnOutTipTextElement_Object___0__7X;
			}
		}

		/// <summary>
		/// UnityEngine.Font GetFont(System.String)
		/// </summary>
		protected static RMethod r_RGetFont_String;
		public static RMethod RGetFont_String
		{
			get
			{
				if(r_RGetFont_String == null)
				{
					r_RGetFont_String = new( ReleactionUtils.GetType("UIManager"), "GetFont", 0, typeof(System.String));
					r_RGetFont_String.SetBelong(null);
				}
				return r_RGetFont_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ScreenToUIpos(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RScreenToUIpos_Vector3;
		public static RMethod RScreenToUIpos_Vector3
		{
			get
			{
				if(r_RScreenToUIpos_Vector3 == null)
				{
					r_RScreenToUIpos_Vector3 = new( ReleactionUtils.GetType("UIManager"), "ScreenToUIpos", 0, typeof(UnityEngine.Vector3));
					r_RScreenToUIpos_Vector3.SetBelong(null);
				}
				return r_RScreenToUIpos_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UIToScreenPos(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RUIToScreenPos_Vector3;
		public static RMethod RUIToScreenPos_Vector3
		{
			get
			{
				if(r_RUIToScreenPos_Vector3 == null)
				{
					r_RUIToScreenPos_Vector3 = new( ReleactionUtils.GetType("UIManager"), "UIToScreenPos", 0, typeof(UnityEngine.Vector3));
					r_RUIToScreenPos_Vector3.SetBelong(null);
				}
				return r_RUIToScreenPos_Vector3;
			}
		}

		/// <summary>
		/// Void RegisteWndInstance(MyGUIWindow)
		/// </summary>
		protected RMethod r_RRegisteWndInstance_MyGUIWindow;
		public virtual RMethod RRegisteWndInstance_MyGUIWindow
		{
			get
			{
				if(r_RRegisteWndInstance_MyGUIWindow == null)
				{
					r_RRegisteWndInstance_MyGUIWindow = new(this, "RegisteWndInstance", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RRegisteWndInstance_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RRegisteWndInstance_MyGUIWindow;
			}
		}

		/// <summary>
		/// T GetWindow[T](System.String)
		/// </summary>
		protected RMethod r_RGetWindow_GT_String;
		public virtual RMethod RGetWindow_GT_String
		{
			get
			{
				if(r_RGetWindow_GT_String == null)
				{
					r_RGetWindow_GT_String = new(this, "GetWindow", 1, typeof(System.String));
					r_RGetWindow_GT_String.SetBelong(this.instance);
				}
				return r_RGetWindow_GT_String;
			}
		}

		/// <summary>
		/// Void DestroyWindow[T](System.String)
		/// </summary>
		protected RMethod r_RDestroyWindow_GT_String;
		public virtual RMethod RDestroyWindow_GT_String
		{
			get
			{
				if(r_RDestroyWindow_GT_String == null)
				{
					r_RDestroyWindow_GT_String = new(this, "DestroyWindow", 1, typeof(System.String));
					r_RDestroyWindow_GT_String.SetBelong(this.instance);
				}
				return r_RDestroyWindow_GT_String;
			}
		}

		/// <summary>
		/// MyGUIWindow GetWindow(System.String)
		/// </summary>
		protected RMethod r_RGetWindow_String;
		public virtual RMethod RGetWindow_String
		{
			get
			{
				if(r_RGetWindow_String == null)
				{
					r_RGetWindow_String = new(this, "GetWindow", 0, typeof(System.String));
					r_RGetWindow_String.SetBelong(this.instance);
				}
				return r_RGetWindow_String;
			}
		}

		/// <summary>
		/// MyGUIWindow GetWindow(Int32)
		/// </summary>
		protected RMethod r_RGetWindow_Int32;
		public virtual RMethod RGetWindow_Int32
		{
			get
			{
				if(r_RGetWindow_Int32 == null)
				{
					r_RGetWindow_Int32 = new(this, "GetWindow", 0, typeof(System.Int32));
					r_RGetWindow_Int32.SetBelong(this.instance);
				}
				return r_RGetWindow_Int32;
			}
		}

		/// <summary>
		/// Void DestroyWindow(System.String)
		/// </summary>
		protected RMethod r_RDestroyWindow_String;
		public virtual RMethod RDestroyWindow_String
		{
			get
			{
				if(r_RDestroyWindow_String == null)
				{
					r_RDestroyWindow_String = new(this, "DestroyWindow", 0, typeof(System.String));
					r_RDestroyWindow_String.SetBelong(this.instance);
				}
				return r_RDestroyWindow_String;
			}
		}

		/// <summary>
		/// Void DestroyWindowGroup(System.String)
		/// </summary>
		protected RMethod r_RDestroyWindowGroup_String;
		public virtual RMethod RDestroyWindowGroup_String
		{
			get
			{
				if(r_RDestroyWindowGroup_String == null)
				{
					r_RDestroyWindowGroup_String = new(this, "DestroyWindowGroup", 0, typeof(System.String));
					r_RDestroyWindowGroup_String.SetBelong(this.instance);
				}
				return r_RDestroyWindowGroup_String;
			}
		}

		/// <summary>
		/// Void OnLoadUIConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadUIConfig_Object;
		public virtual RMethod ROnLoadUIConfig_Object
		{
			get
			{
				if(r_ROnLoadUIConfig_Object == null)
				{
					r_ROnLoadUIConfig_Object = new(this, "OnLoadUIConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadUIConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadUIConfig_Object;
			}
		}

		/// <summary>
		/// Void LoadCommonGroup(#u.#G7)
		/// </summary>
		protected RMethod r_RLoadCommonGroup___0__G7;
		public virtual RMethod RLoadCommonGroup___0__G7
		{
			get
			{
				if(r_RLoadCommonGroup___0__G7 == null)
				{
					r_RLoadCommonGroup___0__G7 = new(this, "LoadCommonGroup", 0,  ReleactionUtils.GetType("#u.#G7"));
					r_RLoadCommonGroup___0__G7.SetBelong(this.instance);
				}
				return r_RLoadCommonGroup___0__G7;
			}
		}

		/// <summary>
		/// Void LoadWindowsGroup(System.Collections.Generic.Dictionary`2[System.String,#u.#F7])
		/// </summary>
		protected RMethod r_RLoadWindowsGroup_Dictionary_d_String___0__F7_p_;
		public virtual RMethod RLoadWindowsGroup_Dictionary_d_String___0__F7_p_
		{
			get
			{
				if(r_RLoadWindowsGroup_Dictionary_d_String___0__F7_p_ == null)
				{
					r_RLoadWindowsGroup_Dictionary_d_String___0__F7_p_ = new(this, "LoadWindowsGroup", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#F7")));
					r_RLoadWindowsGroup_Dictionary_d_String___0__F7_p_.SetBelong(this.instance);
				}
				return r_RLoadWindowsGroup_Dictionary_d_String___0__F7_p_;
			}
		}

		/// <summary>
		/// Void PreLoadDefineString()
		/// </summary>
		protected RMethod r_RPreLoadDefineString;
		public virtual RMethod RPreLoadDefineString
		{
			get
			{
				if(r_RPreLoadDefineString == null)
				{
					r_RPreLoadDefineString = new(this, "PreLoadDefineString", 0);
					r_RPreLoadDefineString.SetBelong(this.instance);
				}
				return r_RPreLoadDefineString;
			}
		}

		/// <summary>
		/// Void LoadWindowsGroupAsset(System.String, MyGUIWindow, WindowParam)
		/// </summary>
		protected RMethod r_RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam;
		public virtual RMethod RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam
		{
			get
			{
				if(r_RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam == null)
				{
					r_RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam = new(this, "LoadWindowsGroupAsset", 0, typeof(System.String),  ReleactionUtils.GetType("MyGUIWindow"),  ReleactionUtils.GetType("UIManager+WindowParam"));
					r_RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam.SetBelong(this.instance);
				}
				return r_RLoadWindowsGroupAsset_String_MyGUIWindow_WindowParam;
			}
		}

		/// <summary>
		/// Void OnLoadUI(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadUI_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadUI_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadUI_Object_ABLoadedArgs == null)
				{
					r_ROnLoadUI_Object_ABLoadedArgs = new(this, "OnLoadUI", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadUI_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadUI_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void AddTexturesOfStyleToList(System.Collections.Generic.List`1[UnityEngine.Texture2D], UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle;
		public virtual RMethod RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle
		{
			get
			{
				if(r_RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle == null)
				{
					r_RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle = new(this, "AddTexturesOfStyleToList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Texture2D)), typeof(UnityEngine.GUIStyle));
					r_RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle.SetBelong(this.instance);
				}
				return r_RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle;
			}
		}

		/// <summary>
		/// Void SaveReferenceOfAllTex(UnityEngine.GUISkin)
		/// </summary>
		protected RMethod r_RSaveReferenceOfAllTex_GUISkin;
		public virtual RMethod RSaveReferenceOfAllTex_GUISkin
		{
			get
			{
				if(r_RSaveReferenceOfAllTex_GUISkin == null)
				{
					r_RSaveReferenceOfAllTex_GUISkin = new(this, "SaveReferenceOfAllTex", 0, typeof(UnityEngine.GUISkin));
					r_RSaveReferenceOfAllTex_GUISkin.SetBelong(this.instance);
				}
				return r_RSaveReferenceOfAllTex_GUISkin;
			}
		}

		/// <summary>
		/// Void SetAllLanguageText(UnityEngine.TextAsset)
		/// </summary>
		protected RMethod r_RSetAllLanguageText_TextAsset;
		public virtual RMethod RSetAllLanguageText_TextAsset
		{
			get
			{
				if(r_RSetAllLanguageText_TextAsset == null)
				{
					r_RSetAllLanguageText_TextAsset = new(this, "SetAllLanguageText", 0, typeof(UnityEngine.TextAsset));
					r_RSetAllLanguageText_TextAsset.SetBelong(this.instance);
				}
				return r_RSetAllLanguageText_TextAsset;
			}
		}

		/// <summary>
		/// System.String GetElemLanguage(System.String)
		/// </summary>
		protected RMethod r_RGetElemLanguage_String;
		public virtual RMethod RGetElemLanguage_String
		{
			get
			{
				if(r_RGetElemLanguage_String == null)
				{
					r_RGetElemLanguage_String = new(this, "GetElemLanguage", 0, typeof(System.String));
					r_RGetElemLanguage_String.SetBelong(this.instance);
				}
				return r_RGetElemLanguage_String;
			}
		}

		/// <summary>
		/// Void UpdateAllLayout(LayoutContents)
		/// </summary>
		protected RMethod r_RUpdateAllLayout_LayoutContents;
		public virtual RMethod RUpdateAllLayout_LayoutContents
		{
			get
			{
				if(r_RUpdateAllLayout_LayoutContents == null)
				{
					r_RUpdateAllLayout_LayoutContents = new(this, "UpdateAllLayout", 0, typeof(LayoutContents));
					r_RUpdateAllLayout_LayoutContents.SetBelong(this.instance);
				}
				return r_RUpdateAllLayout_LayoutContents;
			}
		}

		/// <summary>
		/// Void UpdateWindowAsset(MyGUIWindow, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RUpdateWindowAsset_MyGUIWindow_Object;
		public virtual RMethod RUpdateWindowAsset_MyGUIWindow_Object
		{
			get
			{
				if(r_RUpdateWindowAsset_MyGUIWindow_Object == null)
				{
					r_RUpdateWindowAsset_MyGUIWindow_Object = new(this, "UpdateWindowAsset", 0,  ReleactionUtils.GetType("MyGUIWindow"), typeof(UnityEngine.Object));
					r_RUpdateWindowAsset_MyGUIWindow_Object.SetBelong(this.instance);
				}
				return r_RUpdateWindowAsset_MyGUIWindow_Object;
			}
		}

		/// <summary>
		/// Void DownLoadTex()
		/// </summary>
		protected RMethod r_RDownLoadTex;
		public virtual RMethod RDownLoadTex
		{
			get
			{
				if(r_RDownLoadTex == null)
				{
					r_RDownLoadTex = new(this, "DownLoadTex", 0);
					r_RDownLoadTex.SetBelong(this.instance);
				}
				return r_RDownLoadTex;
			}
		}

		/// <summary>
		/// Void OnLoadTex(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadTex_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadTex_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadTex_Object_ABLoadedArgs == null)
				{
					r_ROnLoadTex_Object_ABLoadedArgs = new(this, "OnLoadTex", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadTex_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadTex_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void _OnGUI()
		/// </summary>
		protected RMethod r_R_OnGUI;
		public virtual RMethod R_OnGUI
		{
			get
			{
				if(r_R_OnGUI == null)
				{
					r_R_OnGUI = new(this, "_OnGUI", 0);
					r_R_OnGUI.SetBelong(this.instance);
				}
				return r_R_OnGUI;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator InitWaitAsset()
		/// </summary>
		protected RMethod r_RInitWaitAsset;
		public virtual RMethod RInitWaitAsset
		{
			get
			{
				if(r_RInitWaitAsset == null)
				{
					r_RInitWaitAsset = new(this, "InitWaitAsset", 0);
					r_RInitWaitAsset.SetBelong(this.instance);
				}
				return r_RInitWaitAsset;
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
		/// Void UpdateWaitInitWnd()
		/// </summary>
		protected RMethod r_RUpdateWaitInitWnd;
		public virtual RMethod RUpdateWaitInitWnd
		{
			get
			{
				if(r_RUpdateWaitInitWnd == null)
				{
					r_RUpdateWaitInitWnd = new(this, "UpdateWaitInitWnd", 0);
					r_RUpdateWaitInitWnd.SetBelong(this.instance);
				}
				return r_RUpdateWaitInitWnd;
			}
		}

		/// <summary>
		/// Void SetUIupdate(System.String, Boolean)
		/// </summary>
		protected RMethod r_RSetUIupdate_String_Boolean;
		public virtual RMethod RSetUIupdate_String_Boolean
		{
			get
			{
				if(r_RSetUIupdate_String_Boolean == null)
				{
					r_RSetUIupdate_String_Boolean = new(this, "SetUIupdate", 0, typeof(System.String), typeof(System.Boolean));
					r_RSetUIupdate_String_Boolean.SetBelong(this.instance);
				}
				return r_RSetUIupdate_String_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateAllWindowMonoBehaviour()
		/// </summary>
		protected RMethod r_RUpdateAllWindowMonoBehaviour;
		public virtual RMethod RUpdateAllWindowMonoBehaviour
		{
			get
			{
				if(r_RUpdateAllWindowMonoBehaviour == null)
				{
					r_RUpdateAllWindowMonoBehaviour = new(this, "UpdateAllWindowMonoBehaviour", 0);
					r_RUpdateAllWindowMonoBehaviour.SetBelong(this.instance);
				}
				return r_RUpdateAllWindowMonoBehaviour;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetShowWindows()
		/// </summary>
		protected RMethod r_RGetShowWindows;
		public virtual RMethod RGetShowWindows
		{
			get
			{
				if(r_RGetShowWindows == null)
				{
					r_RGetShowWindows = new(this, "GetShowWindows", 0);
					r_RGetShowWindows.SetBelong(this.instance);
				}
				return r_RGetShowWindows;
			}
		}

		/// <summary>
		/// Void ShowWindows(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_RShowWindows_List_d_String_p_;
		public virtual RMethod RShowWindows_List_d_String_p_
		{
			get
			{
				if(r_RShowWindows_List_d_String_p_ == null)
				{
					r_RShowWindows_List_d_String_p_ = new(this, "ShowWindows", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_RShowWindows_List_d_String_p_.SetBelong(this.instance);
				}
				return r_RShowWindows_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void CloseWindows(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_RCloseWindows_List_d_String_p_;
		public virtual RMethod RCloseWindows_List_d_String_p_
		{
			get
			{
				if(r_RCloseWindows_List_d_String_p_ == null)
				{
					r_RCloseWindows_List_d_String_p_ = new(this, "CloseWindows", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_RCloseWindows_List_d_String_p_.SetBelong(this.instance);
				}
				return r_RCloseWindows_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void CloseAllMyGUI()
		/// </summary>
		protected RMethod r_RCloseAllMyGUI;
		public virtual RMethod RCloseAllMyGUI
		{
			get
			{
				if(r_RCloseAllMyGUI == null)
				{
					r_RCloseAllMyGUI = new(this, "CloseAllMyGUI", 0);
					r_RCloseAllMyGUI.SetBelong(this.instance);
				}
				return r_RCloseAllMyGUI;
			}
		}

		/// <summary>
		/// MyGUIWindow GetHoverWindow(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetHoverWindow_Boolean_Boolean;
		public virtual RMethod RGetHoverWindow_Boolean_Boolean
		{
			get
			{
				if(r_RGetHoverWindow_Boolean_Boolean == null)
				{
					r_RGetHoverWindow_Boolean_Boolean = new(this, "GetHoverWindow", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RGetHoverWindow_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetHoverWindow_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsWindowVisible(MyGUIWindow)
		/// </summary>
		protected RMethod r_RIsWindowVisible_MyGUIWindow;
		public virtual RMethod RIsWindowVisible_MyGUIWindow
		{
			get
			{
				if(r_RIsWindowVisible_MyGUIWindow == null)
				{
					r_RIsWindowVisible_MyGUIWindow = new(this, "IsWindowVisible", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RIsWindowVisible_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RIsWindowVisible_MyGUIWindow;
			}
		}

		/// <summary>
		/// Boolean IsNomalWindowOpened()
		/// </summary>
		protected RMethod r_RIsNomalWindowOpened;
		public virtual RMethod RIsNomalWindowOpened
		{
			get
			{
				if(r_RIsNomalWindowOpened == null)
				{
					r_RIsNomalWindowOpened = new(this, "IsNomalWindowOpened", 0);
					r_RIsNomalWindowOpened.SetBelong(this.instance);
				}
				return r_RIsNomalWindowOpened;
			}
		}

		/// <summary>
		/// Void RefreshWindow()
		/// </summary>
		protected RMethod r_RRefreshWindow;
		public virtual RMethod RRefreshWindow
		{
			get
			{
				if(r_RRefreshWindow == null)
				{
					r_RRefreshWindow = new(this, "RefreshWindow", 0);
					r_RRefreshWindow.SetBelong(this.instance);
				}
				return r_RRefreshWindow;
			}
		}

		/// <summary>
		/// Void ResetVisibleWindow()
		/// </summary>
		protected RMethod r_RResetVisibleWindow;
		public virtual RMethod RResetVisibleWindow
		{
			get
			{
				if(r_RResetVisibleWindow == null)
				{
					r_RResetVisibleWindow = new(this, "ResetVisibleWindow", 0);
					r_RResetVisibleWindow.SetBelong(this.instance);
				}
				return r_RResetVisibleWindow;
			}
		}

		/// <summary>
		/// Void OnChangeResolution(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ROnChangeResolution_Vector2;
		public virtual RMethod ROnChangeResolution_Vector2
		{
			get
			{
				if(r_ROnChangeResolution_Vector2 == null)
				{
					r_ROnChangeResolution_Vector2 = new(this, "OnChangeResolution", 0, typeof(UnityEngine.Vector2));
					r_ROnChangeResolution_Vector2.SetBelong(this.instance);
				}
				return r_ROnChangeResolution_Vector2;
			}
		}

		/// <summary>
		/// Void ResetPos()
		/// </summary>
		protected RMethod r_RResetPos;
		public virtual RMethod RResetPos
		{
			get
			{
				if(r_RResetPos == null)
				{
					r_RResetPos = new(this, "ResetPos", 0);
					r_RResetPos.SetBelong(this.instance);
				}
				return r_RResetPos;
			}
		}

		/// <summary>
		/// Void RegisterEventHandler(MyGUIEvent, #u.#vOb)
		/// </summary>
		protected static RMethod r_RRegisterEventHandler_MyGUIEvent___0__vOb;
		public static RMethod RRegisterEventHandler_MyGUIEvent___0__vOb
		{
			get
			{
				if(r_RRegisterEventHandler_MyGUIEvent___0__vOb == null)
				{
					r_RRegisterEventHandler_MyGUIEvent___0__vOb = new( ReleactionUtils.GetType("UIManager"), "RegisterEventHandler", 0,  ReleactionUtils.GetType("MyGUIEvent"),  ReleactionUtils.GetType("#u.#vOb"));
					r_RRegisterEventHandler_MyGUIEvent___0__vOb.SetBelong(null);
				}
				return r_RRegisterEventHandler_MyGUIEvent___0__vOb;
			}
		}

		/// <summary>
		/// Void SendEvent(MyGUIEvent, System.Object, System.EventArgs)
		/// </summary>
		protected static RMethod r_RSendEvent_MyGUIEvent_Object_EventArgs;
		public static RMethod RSendEvent_MyGUIEvent_Object_EventArgs
		{
			get
			{
				if(r_RSendEvent_MyGUIEvent_Object_EventArgs == null)
				{
					r_RSendEvent_MyGUIEvent_Object_EventArgs = new( ReleactionUtils.GetType("UIManager"), "SendEvent", 0,  ReleactionUtils.GetType("MyGUIEvent"), typeof(System.Object), typeof(System.EventArgs));
					r_RSendEvent_MyGUIEvent_Object_EventArgs.SetBelong(null);
				}
				return r_RSendEvent_MyGUIEvent_Object_EventArgs;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin GetDefaultTemplateSkin()
		/// </summary>
		protected RMethod r_RGetDefaultTemplateSkin;
		public virtual RMethod RGetDefaultTemplateSkin
		{
			get
			{
				if(r_RGetDefaultTemplateSkin == null)
				{
					r_RGetDefaultTemplateSkin = new(this, "GetDefaultTemplateSkin", 0);
					r_RGetDefaultTemplateSkin.SetBelong(this.instance);
				}
				return r_RGetDefaultTemplateSkin;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin GetTemplateSkin(System.String)
		/// </summary>
		protected RMethod r_RGetTemplateSkin_String;
		public virtual RMethod RGetTemplateSkin_String
		{
			get
			{
				if(r_RGetTemplateSkin_String == null)
				{
					r_RGetTemplateSkin_String = new(this, "GetTemplateSkin", 0, typeof(System.String));
					r_RGetTemplateSkin_String.SetBelong(this.instance);
				}
				return r_RGetTemplateSkin_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle GetNumStyle(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetNumStyle_Int32_Int32;
		public virtual RMethod RGetNumStyle_Int32_Int32
		{
			get
			{
				if(r_RGetNumStyle_Int32_Int32 == null)
				{
					r_RGetNumStyle_Int32_Int32 = new(this, "GetNumStyle", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetNumStyle_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetNumStyle_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUIeffectVisible(Boolean)
		/// </summary>
		protected RMethod r_RSetUIeffectVisible_Boolean;
		public virtual RMethod RSetUIeffectVisible_Boolean
		{
			get
			{
				if(r_RSetUIeffectVisible_Boolean == null)
				{
					r_RSetUIeffectVisible_Boolean = new(this, "SetUIeffectVisible", 0, typeof(System.Boolean));
					r_RSetUIeffectVisible_Boolean.SetBelong(this.instance);
				}
				return r_RSetUIeffectVisible_Boolean;
			}
		}

		/// <summary>
		/// Void RegisterUIeffect(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RRegisterUIeffect_GameObject;
		public virtual RMethod RRegisterUIeffect_GameObject
		{
			get
			{
				if(r_RRegisterUIeffect_GameObject == null)
				{
					r_RRegisterUIeffect_GameObject = new(this, "RegisterUIeffect", 0, typeof(UnityEngine.GameObject));
					r_RRegisterUIeffect_GameObject.SetBelong(this.instance);
				}
				return r_RRegisterUIeffect_GameObject;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject InitUIeffect(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RInitUIeffect_GameObject;
		public virtual RMethod RInitUIeffect_GameObject
		{
			get
			{
				if(r_RInitUIeffect_GameObject == null)
				{
					r_RInitUIeffect_GameObject = new(this, "InitUIeffect", 0, typeof(UnityEngine.GameObject));
					r_RInitUIeffect_GameObject.SetBelong(this.instance);
				}
				return r_RInitUIeffect_GameObject;
			}
		}

		/// <summary>
		/// UIeffect RegisterUIeffectEx(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RRegisterUIeffectEx_GameObject;
		public virtual RMethod RRegisterUIeffectEx_GameObject
		{
			get
			{
				if(r_RRegisterUIeffectEx_GameObject == null)
				{
					r_RRegisterUIeffectEx_GameObject = new(this, "RegisterUIeffectEx", 0, typeof(UnityEngine.GameObject));
					r_RRegisterUIeffectEx_GameObject.SetBelong(this.instance);
				}
				return r_RRegisterUIeffectEx_GameObject;
			}
		}

		/// <summary>
		/// UIeffect RegisterUIeffect(UnityEngine.GameObject, System.String, System.String)
		/// </summary>
		protected RMethod r_RRegisterUIeffect_GameObject_String_String;
		public virtual RMethod RRegisterUIeffect_GameObject_String_String
		{
			get
			{
				if(r_RRegisterUIeffect_GameObject_String_String == null)
				{
					r_RRegisterUIeffect_GameObject_String_String = new(this, "RegisterUIeffect", 0, typeof(UnityEngine.GameObject), typeof(System.String), typeof(System.String));
					r_RRegisterUIeffect_GameObject_String_String.SetBelong(this.instance);
				}
				return r_RRegisterUIeffect_GameObject_String_String;
			}
		}

		/// <summary>
		/// UIeffect RegisterUIeffect(UnityEngine.GameObject, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_RRegisterUIeffect_GameObject_ElementBase;
		public virtual RMethod RRegisterUIeffect_GameObject_ElementBase
		{
			get
			{
				if(r_RRegisterUIeffect_GameObject_ElementBase == null)
				{
					r_RRegisterUIeffect_GameObject_ElementBase = new(this, "RegisterUIeffect", 0, typeof(UnityEngine.GameObject), typeof(MyGUI.ElementBase));
					r_RRegisterUIeffect_GameObject_ElementBase.SetBelong(this.instance);
				}
				return r_RRegisterUIeffect_GameObject_ElementBase;
			}
		}

		/// <summary>
		/// UIeffect RegisterUIeffect(UnityEngine.GameObject, MyGUI.ElementBase, MyGUI.ElementBase, Single, Int32)
		/// </summary>
		protected RMethod r_RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32;
		public virtual RMethod RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32
		{
			get
			{
				if(r_RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32 == null)
				{
					r_RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32 = new(this, "RegisterUIeffect", 0, typeof(UnityEngine.GameObject), typeof(MyGUI.ElementBase), typeof(MyGUI.ElementBase), typeof(System.Single), typeof(System.Int32));
					r_RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32.SetBelong(this.instance);
				}
				return r_RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32;
			}
		}

		/// <summary>
		/// UIeffect RegisterUIeffect(UnityEngine.GameObject, UnityEngine.Rect, UnityEngine.Rect, Single, Int32)
		/// </summary>
		protected RMethod r_RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32;
		public virtual RMethod RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32
		{
			get
			{
				if(r_RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32 == null)
				{
					r_RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32 = new(this, "RegisterUIeffect", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Int32));
					r_RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32.SetBelong(this.instance);
				}
				return r_RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32;
			}
		}

		/// <summary>
		/// System.String GetCopyString()
		/// </summary>
		protected RMethod r_RGetCopyString;
		public virtual RMethod RGetCopyString
		{
			get
			{
				if(r_RGetCopyString == null)
				{
					r_RGetCopyString = new(this, "GetCopyString", 0);
					r_RGetCopyString.SetBelong(this.instance);
				}
				return r_RGetCopyString;
			}
		}

		/// <summary>
		/// Void SetCopyString(System.String)
		/// </summary>
		protected RMethod r_RSetCopyString_String;
		public virtual RMethod RSetCopyString_String
		{
			get
			{
				if(r_RSetCopyString_String == null)
				{
					r_RSetCopyString_String = new(this, "SetCopyString", 0, typeof(System.String));
					r_RSetCopyString_String.SetBelong(this.instance);
				}
				return r_RSetCopyString_String;
			}
		}

		/// <summary>
		/// Void SetCopyToUI()
		/// </summary>
		protected RMethod r_RSetCopyToUI;
		public virtual RMethod RSetCopyToUI
		{
			get
			{
				if(r_RSetCopyToUI == null)
				{
					r_RSetCopyToUI = new(this, "SetCopyToUI", 0);
					r_RSetCopyToUI.SetBelong(this.instance);
				}
				return r_RSetCopyToUI;
			}
		}

		/// <summary>
		/// Void SetNullHorizontalScrollbar(System.Object)
		/// </summary>
		protected RMethod r_RSetNullHorizontalScrollbar_Object;
		public virtual RMethod RSetNullHorizontalScrollbar_Object
		{
			get
			{
				if(r_RSetNullHorizontalScrollbar_Object == null)
				{
					r_RSetNullHorizontalScrollbar_Object = new(this, "SetNullHorizontalScrollbar", 0, typeof(System.Object));
					r_RSetNullHorizontalScrollbar_Object.SetBelong(this.instance);
				}
				return r_RSetNullHorizontalScrollbar_Object;
			}
		}

		/// <summary>
		/// Void OnApplicationFocus(Boolean)
		/// </summary>
		protected RMethod r_ROnApplicationFocus_Boolean;
		public virtual RMethod ROnApplicationFocus_Boolean
		{
			get
			{
				if(r_ROnApplicationFocus_Boolean == null)
				{
					r_ROnApplicationFocus_Boolean = new(this, "OnApplicationFocus", 0, typeof(System.Boolean));
					r_ROnApplicationFocus_Boolean.SetBelong(this.instance);
				}
				return r_ROnApplicationFocus_Boolean;
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


        public RUIManager() : base("UIManager")
        {
        }

        public RUIManager(System.Object instance) : base("UIManager")
		{
            SetInstance(instance);
		}

        public RUIManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteStep(System.String  @stepName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stepName};
            var ___result = RCompleteStep_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetUIScreenResizable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetUIScreenResizable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandlerWindowElementClick(MyGUI.ElementBase  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RHandlerWindowElementClick_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void HandleWindiwClose(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RHandleWindiwClose_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterMainCallStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterMainCallStart.Invoke(___genericsType, ___parameters);

            
        }




        public static UnityEngine.Font GetFont(System.String  @fontName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontName};
            var ___result = RGetFont_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public static UnityEngine.Vector3 ScreenToUIpos(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RScreenToUIpos_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 UIToScreenPos(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RUIToScreenPos_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }



        public virtual T GetWindow<T>(System.String  @windowName) where T : MyGUIWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@windowName};
            var ___result = RGetWindow_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void DestroyWindow<T>(System.String  @windowName) where T : MyGUIWindow
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@windowName};
            var ___result = RDestroyWindow_GT_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetWindow(System.String  @wndName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndName};
            var ___result = RGetWindow_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetWindow(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetWindow_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void DestroyWindow(System.String  @wndName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndName};
            var ___result = RDestroyWindow_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DestroyWindowGroup(System.String  @groupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupName};
            var ___result = RDestroyWindowGroup_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadUIConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadUIConfig_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void PreLoadDefineString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreLoadDefineString.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void AddTexturesOfStyleToList(System.Collections.Generic.List<UnityEngine.Texture2D>  @tmpList, UnityEngine.GUIStyle  @tmpStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tmpList, @tmpStyle};
            var ___result = RAddTexturesOfStyleToList_List_d_Texture2D_p__GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveReferenceOfAllTex(UnityEngine.GUISkin  @m_skin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m_skin};
            var ___result = RSaveReferenceOfAllTex_GUISkin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllLanguageText(UnityEngine.TextAsset  @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RSetAllLanguageText_TextAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetElemLanguage(System.String  @elemName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemName};
            var ___result = RGetElemLanguage_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void UpdateAllLayout(LayoutContents  @layouts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layouts};
            var ___result = RUpdateAllLayout_LayoutContents.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void DownLoadTex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDownLoadTex.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void _OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator InitWaitAsset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitWaitAsset.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWaitInitWnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWaitInitWnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUIupdate(System.String  @wndName, System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndName, @bl};
            var ___result = RSetUIupdate_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAllWindowMonoBehaviour()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAllWindowMonoBehaviour.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetShowWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetShowWindows.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ShowWindows(System.Collections.Generic.List<System.String>  @winlist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@winlist};
            var ___result = RShowWindows_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseWindows(System.Collections.Generic.List<System.String>  @winlist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@winlist};
            var ___result = RCloseWindows_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseAllMyGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseAllMyGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetHoverWindow(System.Boolean  @ignoreUnhandleMouseEventWindow, System.Boolean  @alphaTest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignoreUnhandleMouseEventWindow, @alphaTest};
            var ___result = RGetHoverWindow_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Boolean IsNomalWindowOpened()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNomalWindowOpened.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RefreshWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefreshWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetVisibleWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetVisibleWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnChangeResolution(UnityEngine.Vector2  @resolution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resolution};
            var ___result = ROnChangeResolution_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetPos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetPos.Invoke(___genericsType, ___parameters);

            
        }




        public virtual UnityEngine.GUISkin GetDefaultTemplateSkin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultTemplateSkin.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUISkin)___result;
        }


        public virtual UnityEngine.GUISkin GetTemplateSkin(System.String  @skinName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skinName};
            var ___result = RGetTemplateSkin_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUISkin)___result;
        }


        public virtual UnityEngine.GUIStyle GetNumStyle(System.Int32  @index, System.Int32  @num)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @num};
            var ___result = RGetNumStyle_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual void SetUIeffectVisible(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = RSetUIeffectVisible_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterUIeffect(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRegisterUIeffect_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject InitUIeffect(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RInitUIeffect_GameObject.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual UIeffect RegisterUIeffectEx(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRegisterUIeffectEx_GameObject.Invoke(___genericsType, ___parameters);

            return (UIeffect)___result;
        }


        public virtual UIeffect RegisterUIeffect(UnityEngine.GameObject  @obj, System.String  @windowName, System.String  @elementName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @windowName, @elementName};
            var ___result = RRegisterUIeffect_GameObject_String_String.Invoke(___genericsType, ___parameters);

            return (UIeffect)___result;
        }


        public virtual UIeffect RegisterUIeffect(UnityEngine.GameObject  @obj, MyGUI.ElementBase  @elementBase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @elementBase};
            var ___result = RRegisterUIeffect_GameObject_ElementBase.Invoke(___genericsType, ___parameters);

            return (UIeffect)___result;
        }


        public virtual UIeffect RegisterUIeffect(UnityEngine.GameObject  @obj, MyGUI.ElementBase  @elementBaseStart, MyGUI.ElementBase  @elementBaseEnd, System.Single  @time, System.Int32  @typ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @elementBaseStart, @elementBaseEnd, @time, @typ};
            var ___result = RRegisterUIeffect_GameObject_ElementBase_ElementBase_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UIeffect)___result;
        }


        public virtual UIeffect RegisterUIeffect(UnityEngine.GameObject  @obj, UnityEngine.Rect  @rtStart, UnityEngine.Rect  @rtEnd, System.Single  @time, System.Int32  @typ)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @rtStart, @rtEnd, @time, @typ};
            var ___result = RRegisterUIeffect_GameObject_Rect_Rect_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UIeffect)___result;
        }


        public virtual System.String GetCopyString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCopyString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetCopyString(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RSetCopyString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCopyToUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetCopyToUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNullHorizontalScrollbar(System.Object  @skinObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skinObj};
            var ___result = RSetNullHorizontalScrollbar_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnApplicationFocus(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = ROnApplicationFocus_Boolean.Invoke(___genericsType, ___parameters);

            
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
