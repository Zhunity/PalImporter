using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ShortcutManager
	/// </summary>
    public partial class RShortcutManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[ShortcutConfig] cfgList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RShortcutConfig> r_cfgList;
		public virtual RSystem.RCollections.RGeneric.RList<RShortcutConfig> RcfgList
		{
			get
			{
				if(r_cfgList == null)
				{
					r_cfgList = new(this, "cfgList");
					r_cfgList.SetBelong(this.instance);
				}
				return r_cfgList;
			}
		}

		/// <summary>
		/// System.Single ICON_SHADOW_OVERFLOW
		/// </summary>
		protected static RField r_ICON_SHADOW_OVERFLOW;
		public static RField RICON_SHADOW_OVERFLOW
		{
			get
			{
				if(r_ICON_SHADOW_OVERFLOW == null)
				{
					r_ICON_SHADOW_OVERFLOW = new( ReleactionUtils.GetType("ShortcutManager"), "ICON_SHADOW_OVERFLOW");
					r_ICON_SHADOW_OVERFLOW.SetBelong(null);
				}
				return r_ICON_SHADOW_OVERFLOW;
			}
		}

		/// <summary>
		/// System.Single textOffsetY
		/// </summary>
		protected static RField r_textOffsetY;
		public static RField RtextOffsetY
		{
			get
			{
				if(r_textOffsetY == null)
				{
					r_textOffsetY = new( ReleactionUtils.GetType("ShortcutManager"), "textOffsetY");
					r_textOffsetY.SetBelong(null);
				}
				return r_textOffsetY;
			}
		}

		/// <summary>
		/// System.Int32 OUT_INTERVAL_WIDTH
		/// </summary>
		protected RField r_OUT_INTERVAL_WIDTH;
		public virtual RField ROUT_INTERVAL_WIDTH
		{
			get
			{
				if(r_OUT_INTERVAL_WIDTH == null)
				{
					r_OUT_INTERVAL_WIDTH = new(this, "OUT_INTERVAL_WIDTH");
					r_OUT_INTERVAL_WIDTH.SetBelong(this.instance);
				}
				return r_OUT_INTERVAL_WIDTH;
			}
		}

		/// <summary>
		/// System.Int32 IN_INTERVAL_WIDTH
		/// </summary>
		protected RField r_IN_INTERVAL_WIDTH;
		public virtual RField RIN_INTERVAL_WIDTH
		{
			get
			{
				if(r_IN_INTERVAL_WIDTH == null)
				{
					r_IN_INTERVAL_WIDTH = new(this, "IN_INTERVAL_WIDTH");
					r_IN_INTERVAL_WIDTH.SetBelong(this.instance);
				}
				return r_IN_INTERVAL_WIDTH;
			}
		}

		/// <summary>
		/// System.Int32 outMaxX
		/// </summary>
		protected RField r_outMaxX;
		public virtual RField RoutMaxX
		{
			get
			{
				if(r_outMaxX == null)
				{
					r_outMaxX = new(this, "outMaxX");
					r_outMaxX.SetBelong(this.instance);
				}
				return r_outMaxX;
			}
		}

		/// <summary>
		/// System.Int32 inMaxX
		/// </summary>
		protected RField r_inMaxX;
		public virtual RField RinMaxX
		{
			get
			{
				if(r_inMaxX == null)
				{
					r_inMaxX = new(this, "inMaxX");
					r_inMaxX.SetBelong(this.instance);
				}
				return r_inMaxX;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UnityEngine.Rect] outShortcutRawRect
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RRect> r_outShortcutRawRect;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RRect> RoutShortcutRawRect
		{
			get
			{
				if(r_outShortcutRawRect == null)
				{
					r_outShortcutRawRect = new(this, "outShortcutRawRect");
					r_outShortcutRawRect.SetBelong(this.instance);
				}
				return r_outShortcutRawRect;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[ShortcutConfig,ShortcutManager+UpArrowInfo] iconArrows
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RShortcutConfig, RShortcutManager.RUpArrowInfo> r_iconArrows;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RShortcutConfig, RShortcutManager.RUpArrowInfo> RiconArrows
		{
			get
			{
				if(r_iconArrows == null)
				{
					r_iconArrows = new(this, "iconArrows");
					r_iconArrows.SetBelong(this.instance);
				}
				return r_iconArrows;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,MyGUI.ElementBase] iconUpElems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RMyGUI.RElementBase> r_iconUpElems;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RMyGUI.RElementBase> RiconUpElems
		{
			get
			{
				if(r_iconUpElems == null)
				{
					r_iconUpElems = new(this, "iconUpElems");
					r_iconUpElems.SetBelong(this.instance);
				}
				return r_iconUpElems;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UnityEngine.Vector2] iconUpOffset
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RVector2> r_iconUpOffset;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RVector2> RiconUpOffset
		{
			get
			{
				if(r_iconUpOffset == null)
				{
					r_iconUpOffset = new(this, "iconUpOffset");
					r_iconUpOffset.SetBelong(this.instance);
				}
				return r_iconUpOffset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUI.ElementBase] outShortcutIcons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> r_outShortcutIcons;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> RoutShortcutIcons
		{
			get
			{
				if(r_outShortcutIcons == null)
				{
					r_outShortcutIcons = new(this, "outShortcutIcons");
					r_outShortcutIcons.SetBelong(this.instance);
				}
				return r_outShortcutIcons;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUI.ElementBase] inShortcutIcons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> r_inShortcutIcons;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> RinShortcutIcons
		{
			get
			{
				if(r_inShortcutIcons == null)
				{
					r_inShortcutIcons = new(this, "inShortcutIcons");
					r_inShortcutIcons.SetBelong(this.instance);
				}
				return r_inShortcutIcons;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUI.ElementBase] outShowIcons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> r_outShowIcons;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> RoutShowIcons
		{
			get
			{
				if(r_outShowIcons == null)
				{
					r_outShowIcons = new(this, "outShowIcons");
					r_outShowIcons.SetBelong(this.instance);
				}
				return r_outShowIcons;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUI.ElementBase] inShowIcons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> r_inShowIcons;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> RinShowIcons
		{
			get
			{
				if(r_inShowIcons == null)
				{
					r_inShowIcons = new(this, "inShowIcons");
					r_inShowIcons.SetBelong(this.instance);
				}
				return r_inShowIcons;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[WINDOW_HOTKEY,System.Int32] hotkeyDic
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RWINDOW_HOTKEY, RField> r_hotkeyDic;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RWINDOW_HOTKEY, RField> RhotkeyDic
		{
			get
			{
				if(r_hotkeyDic == null)
				{
					r_hotkeyDic = new(this, "hotkeyDic");
					r_hotkeyDic.SetBelong(this.instance);
				}
				return r_hotkeyDic;
			}
		}

		/// <summary>
		/// System.Boolean bLockIcon
		/// </summary>
		protected RField r_bLockIcon;
		public virtual RField RbLockIcon
		{
			get
			{
				if(r_bLockIcon == null)
				{
					r_bLockIcon = new(this, "bLockIcon");
					r_bLockIcon.SetBelong(this.instance);
				}
				return r_bLockIcon;
			}
		}

		/// <summary>
		/// System.Boolean bWaitNewIconClick
		/// </summary>
		protected RField r_bWaitNewIconClick;
		public virtual RField RbWaitNewIconClick
		{
			get
			{
				if(r_bWaitNewIconClick == null)
				{
					r_bWaitNewIconClick = new(this, "bWaitNewIconClick");
					r_bWaitNewIconClick.SetBelong(this.instance);
				}
				return r_bWaitNewIconClick;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject effectPrefab
		/// </summary>
		protected RUnityEngine.RGameObject r_effectPrefab;
		public virtual RUnityEngine.RGameObject ReffectPrefab
		{
			get
			{
				if(r_effectPrefab == null)
				{
					r_effectPrefab = new(this, "effectPrefab");
					r_effectPrefab.SetBelong(this.instance);
				}
				return r_effectPrefab;
			}
		}

		/// <summary>
		/// Void OnLoadShortcutConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadShortcutConfig_Object;
		public virtual RMethod ROnLoadShortcutConfig_Object
		{
			get
			{
				if(r_ROnLoadShortcutConfig_Object == null)
				{
					r_ROnLoadShortcutConfig_Object = new(this, "OnLoadShortcutConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadShortcutConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadShortcutConfig_Object;
			}
		}

		/// <summary>
		/// Boolean CheckIconOpen(System.String)
		/// </summary>
		protected RMethod r_RCheckIconOpen_String;
		public virtual RMethod RCheckIconOpen_String
		{
			get
			{
				if(r_RCheckIconOpen_String == null)
				{
					r_RCheckIconOpen_String = new(this, "CheckIconOpen", 0, typeof(System.String));
					r_RCheckIconOpen_String.SetBelong(this.instance);
				}
				return r_RCheckIconOpen_String;
			}
		}

		/// <summary>
		/// Boolean CheckSpecialShortcut(System.String)
		/// </summary>
		protected RMethod r_RCheckSpecialShortcut_String;
		public virtual RMethod RCheckSpecialShortcut_String
		{
			get
			{
				if(r_RCheckSpecialShortcut_String == null)
				{
					r_RCheckSpecialShortcut_String = new(this, "CheckSpecialShortcut", 0, typeof(System.String));
					r_RCheckSpecialShortcut_String.SetBelong(this.instance);
				}
				return r_RCheckSpecialShortcut_String;
			}
		}

		/// <summary>
		/// Boolean CanUseShortcut(Int32)
		/// </summary>
		protected RMethod r_RCanUseShortcut_Int32;
		public virtual RMethod RCanUseShortcut_Int32
		{
			get
			{
				if(r_RCanUseShortcut_Int32 == null)
				{
					r_RCanUseShortcut_Int32 = new(this, "CanUseShortcut", 0, typeof(System.Int32));
					r_RCanUseShortcut_Int32.SetBelong(this.instance);
				}
				return r_RCanUseShortcut_Int32;
			}
		}

		/// <summary>
		/// Boolean CanUseHotKey(WINDOW_HOTKEY)
		/// </summary>
		protected RMethod r_RCanUseHotKey_WINDOW_HOTKEY;
		public virtual RMethod RCanUseHotKey_WINDOW_HOTKEY
		{
			get
			{
				if(r_RCanUseHotKey_WINDOW_HOTKEY == null)
				{
					r_RCanUseHotKey_WINDOW_HOTKEY = new(this, "CanUseHotKey", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY"));
					r_RCanUseHotKey_WINDOW_HOTKEY.SetBelong(this.instance);
				}
				return r_RCanUseHotKey_WINDOW_HOTKEY;
			}
		}

		/// <summary>
		/// Void LayoutOutIcons()
		/// </summary>
		protected RMethod r_RLayoutOutIcons;
		public virtual RMethod RLayoutOutIcons
		{
			get
			{
				if(r_RLayoutOutIcons == null)
				{
					r_RLayoutOutIcons = new(this, "LayoutOutIcons", 0);
					r_RLayoutOutIcons.SetBelong(this.instance);
				}
				return r_RLayoutOutIcons;
			}
		}

		/// <summary>
		/// Int32 GetIdByTutorialId(Int32)
		/// </summary>
		protected RMethod r_RGetIdByTutorialId_Int32;
		public virtual RMethod RGetIdByTutorialId_Int32
		{
			get
			{
				if(r_RGetIdByTutorialId_Int32 == null)
				{
					r_RGetIdByTutorialId_Int32 = new(this, "GetIdByTutorialId", 0, typeof(System.Int32));
					r_RGetIdByTutorialId_Int32.SetBelong(this.instance);
				}
				return r_RGetIdByTutorialId_Int32;
			}
		}

		/// <summary>
		/// ShortcutConfig GetConfigByID(Int32)
		/// </summary>
		protected RMethod r_RGetConfigByID_Int32;
		public virtual RMethod RGetConfigByID_Int32
		{
			get
			{
				if(r_RGetConfigByID_Int32 == null)
				{
					r_RGetConfigByID_Int32 = new(this, "GetConfigByID", 0, typeof(System.Int32));
					r_RGetConfigByID_Int32.SetBelong(this.instance);
				}
				return r_RGetConfigByID_Int32;
			}
		}

		/// <summary>
		/// Void ShowIconByTutorialFlag()
		/// </summary>
		protected RMethod r_RShowIconByTutorialFlag;
		public virtual RMethod RShowIconByTutorialFlag
		{
			get
			{
				if(r_RShowIconByTutorialFlag == null)
				{
					r_RShowIconByTutorialFlag = new(this, "ShowIconByTutorialFlag", 0);
					r_RShowIconByTutorialFlag.SetBelong(this.instance);
				}
				return r_RShowIconByTutorialFlag;
			}
		}

		/// <summary>
		/// Void BeginAddShortcutByTutorialId(Int32, System.Action)
		/// </summary>
		protected RMethod r_RBeginAddShortcutByTutorialId_Int32_Action;
		public virtual RMethod RBeginAddShortcutByTutorialId_Int32_Action
		{
			get
			{
				if(r_RBeginAddShortcutByTutorialId_Int32_Action == null)
				{
					r_RBeginAddShortcutByTutorialId_Int32_Action = new(this, "BeginAddShortcutByTutorialId", 0, typeof(System.Int32), typeof(System.Action));
					r_RBeginAddShortcutByTutorialId_Int32_Action.SetBelong(this.instance);
				}
				return r_RBeginAddShortcutByTutorialId_Int32_Action;
			}
		}

		/// <summary>
		/// Void BeginAddEventPanelIcon(Int32, System.Action)
		/// </summary>
		protected RMethod r_RBeginAddEventPanelIcon_Int32_Action;
		public virtual RMethod RBeginAddEventPanelIcon_Int32_Action
		{
			get
			{
				if(r_RBeginAddEventPanelIcon_Int32_Action == null)
				{
					r_RBeginAddEventPanelIcon_Int32_Action = new(this, "BeginAddEventPanelIcon", 0, typeof(System.Int32), typeof(System.Action));
					r_RBeginAddEventPanelIcon_Int32_Action.SetBelong(this.instance);
				}
				return r_RBeginAddEventPanelIcon_Int32_Action;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EventPanelIconOpen(Int32, System.Action)
		/// </summary>
		protected RMethod r_REventPanelIconOpen_Int32_Action;
		public virtual RMethod REventPanelIconOpen_Int32_Action
		{
			get
			{
				if(r_REventPanelIconOpen_Int32_Action == null)
				{
					r_REventPanelIconOpen_Int32_Action = new(this, "EventPanelIconOpen", 0, typeof(System.Int32), typeof(System.Action));
					r_REventPanelIconOpen_Int32_Action.SetBelong(this.instance);
				}
				return r_REventPanelIconOpen_Int32_Action;
			}
		}

		/// <summary>
		/// Void BeginAddShortcut(Int32, System.Action)
		/// </summary>
		protected RMethod r_RBeginAddShortcut_Int32_Action;
		public virtual RMethod RBeginAddShortcut_Int32_Action
		{
			get
			{
				if(r_RBeginAddShortcut_Int32_Action == null)
				{
					r_RBeginAddShortcut_Int32_Action = new(this, "BeginAddShortcut", 0, typeof(System.Int32), typeof(System.Action));
					r_RBeginAddShortcut_Int32_Action.SetBelong(this.instance);
				}
				return r_RBeginAddShortcut_Int32_Action;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ShortcutOpen(Int32, System.Action)
		/// </summary>
		protected RMethod r_RShortcutOpen_Int32_Action;
		public virtual RMethod RShortcutOpen_Int32_Action
		{
			get
			{
				if(r_RShortcutOpen_Int32_Action == null)
				{
					r_RShortcutOpen_Int32_Action = new(this, "ShortcutOpen", 0, typeof(System.Int32), typeof(System.Action));
					r_RShortcutOpen_Int32_Action.SetBelong(this.instance);
				}
				return r_RShortcutOpen_Int32_Action;
			}
		}

		/// <summary>
		/// Void LoadEffect()
		/// </summary>
		protected RMethod r_RLoadEffect;
		public virtual RMethod RLoadEffect
		{
			get
			{
				if(r_RLoadEffect == null)
				{
					r_RLoadEffect = new(this, "LoadEffect", 0);
					r_RLoadEffect.SetBelong(this.instance);
				}
				return r_RLoadEffect;
			}
		}

		/// <summary>
		/// Void OnLoadEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadEffect_Object_ABLoadedArgs = new(this, "OnLoadEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase GetEffectElement()
		/// </summary>
		protected RMethod r_RGetEffectElement;
		public virtual RMethod RGetEffectElement
		{
			get
			{
				if(r_RGetEffectElement == null)
				{
					r_RGetEffectElement = new(this, "GetEffectElement", 0);
					r_RGetEffectElement.SetBelong(this.instance);
				}
				return r_RGetEffectElement;
			}
		}

		/// <summary>
		/// Void BindHotkey(WINDOW_HOTKEY, System.String)
		/// </summary>
		protected RMethod r_RBindHotkey_WINDOW_HOTKEY_String;
		public virtual RMethod RBindHotkey_WINDOW_HOTKEY_String
		{
			get
			{
				if(r_RBindHotkey_WINDOW_HOTKEY_String == null)
				{
					r_RBindHotkey_WINDOW_HOTKEY_String = new(this, "BindHotkey", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY"), typeof(System.String));
					r_RBindHotkey_WINDOW_HOTKEY_String.SetBelong(this.instance);
				}
				return r_RBindHotkey_WINDOW_HOTKEY_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator WaitForShortcutCfgDownload(WINDOW_HOTKEY, System.String)
		/// </summary>
		protected RMethod r_RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String;
		public virtual RMethod RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String
		{
			get
			{
				if(r_RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String == null)
				{
					r_RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String = new(this, "WaitForShortcutCfgDownload", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY"), typeof(System.String));
					r_RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String.SetBelong(this.instance);
				}
				return r_RWaitForShortcutCfgDownload_WINDOW_HOTKEY_String;
			}
		}

		/// <summary>
		/// Void NotifyIconUp(GameDefineType.ID, Boolean)
		/// </summary>
		protected RMethod r_RNotifyIconUp_ID_Boolean;
		public virtual RMethod RNotifyIconUp_ID_Boolean
		{
			get
			{
				if(r_RNotifyIconUp_ID_Boolean == null)
				{
					r_RNotifyIconUp_ID_Boolean = new(this, "NotifyIconUp", 0, typeof(GameDefineType.ID), typeof(System.Boolean));
					r_RNotifyIconUp_ID_Boolean.SetBelong(this.instance);
				}
				return r_RNotifyIconUp_ID_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyIconUp(System.String, Boolean)
		/// </summary>
		protected RMethod r_RNotifyIconUp_String_Boolean;
		public virtual RMethod RNotifyIconUp_String_Boolean
		{
			get
			{
				if(r_RNotifyIconUp_String_Boolean == null)
				{
					r_RNotifyIconUp_String_Boolean = new(this, "NotifyIconUp", 0, typeof(System.String), typeof(System.Boolean));
					r_RNotifyIconUp_String_Boolean.SetBelong(this.instance);
				}
				return r_RNotifyIconUp_String_Boolean;
			}
		}

		/// <summary>
		/// Void NotifyIconNum(System.String, Int32)
		/// </summary>
		protected RMethod r_RNotifyIconNum_String_Int32;
		public virtual RMethod RNotifyIconNum_String_Int32
		{
			get
			{
				if(r_RNotifyIconNum_String_Int32 == null)
				{
					r_RNotifyIconNum_String_Int32 = new(this, "NotifyIconNum", 0, typeof(System.String), typeof(System.Int32));
					r_RNotifyIconNum_String_Int32.SetBelong(this.instance);
				}
				return r_RNotifyIconNum_String_Int32;
			}
		}

		/// <summary>
		/// Void NotifyIconUp(ShortcutConfig, Boolean, Int32)
		/// </summary>
		protected RMethod r_RNotifyIconUp_ShortcutConfig_Boolean_Int32;
		public virtual RMethod RNotifyIconUp_ShortcutConfig_Boolean_Int32
		{
			get
			{
				if(r_RNotifyIconUp_ShortcutConfig_Boolean_Int32 == null)
				{
					r_RNotifyIconUp_ShortcutConfig_Boolean_Int32 = new(this, "NotifyIconUp", 0, typeof(ShortcutConfig), typeof(System.Boolean), typeof(System.Int32));
					r_RNotifyIconUp_ShortcutConfig_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RNotifyIconUp_ShortcutConfig_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void NotifyIconUp(ShortcutConfig, Boolean)
		/// </summary>
		protected RMethod r_RNotifyIconUp_ShortcutConfig_Boolean;
		public virtual RMethod RNotifyIconUp_ShortcutConfig_Boolean
		{
			get
			{
				if(r_RNotifyIconUp_ShortcutConfig_Boolean == null)
				{
					r_RNotifyIconUp_ShortcutConfig_Boolean = new(this, "NotifyIconUp", 0, typeof(ShortcutConfig), typeof(System.Boolean));
					r_RNotifyIconUp_ShortcutConfig_Boolean.SetBelong(this.instance);
				}
				return r_RNotifyIconUp_ShortcutConfig_Boolean;
			}
		}

		/// <summary>
		/// Void RegistUpOffset(MyGUI.ElementBase, MyGUI.ElementBase, #oU.#bV)
		/// </summary>
		protected RMethod r_RRegistUpOffset_ElementBase_ElementBase___0__bV;
		public virtual RMethod RRegistUpOffset_ElementBase_ElementBase___0__bV
		{
			get
			{
				if(r_RRegistUpOffset_ElementBase_ElementBase___0__bV == null)
				{
					r_RRegistUpOffset_ElementBase_ElementBase___0__bV = new(this, "RegistUpOffset", 0, typeof(MyGUI.ElementBase), typeof(MyGUI.ElementBase),  ReleactionUtils.GetType("#oU.#bV"));
					r_RRegistUpOffset_ElementBase_ElementBase___0__bV.SetBelong(this.instance);
				}
				return r_RRegistUpOffset_ElementBase_ElementBase___0__bV;
			}
		}

		/// <summary>
		/// Void UpdateArrowPostion()
		/// </summary>
		protected RMethod r_RUpdateArrowPostion;
		public virtual RMethod RUpdateArrowPostion
		{
			get
			{
				if(r_RUpdateArrowPostion == null)
				{
					r_RUpdateArrowPostion = new(this, "UpdateArrowPostion", 0);
					r_RUpdateArrowPostion.SetBelong(this.instance);
				}
				return r_RUpdateArrowPostion;
			}
		}

		/// <summary>
		/// Void OnDebugOpenAll(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDebugOpenAll_Object___0__Isb;
		public virtual RMethod ROnDebugOpenAll_Object___0__Isb
		{
			get
			{
				if(r_ROnDebugOpenAll_Object___0__Isb == null)
				{
					r_ROnDebugOpenAll_Object___0__Isb = new(this, "OnDebugOpenAll", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDebugOpenAll_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDebugOpenAll_Object___0__Isb;
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


        public RShortcutManager() : base("ShortcutManager")
        {
        }

        public RShortcutManager(System.Object instance) : base("ShortcutManager")
		{
            SetInstance(instance);
		}

        public RShortcutManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RShortcutManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadShortcutConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadShortcutConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckIconOpen(System.String  @iconname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconname};
            var ___result = RCheckIconOpen_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckSpecialShortcut(System.String  @iconname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconname};
            var ___result = RCheckSpecialShortcut_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanUseShortcut(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCanUseShortcut_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void LayoutOutIcons()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLayoutOutIcons.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetIdByTutorialId(System.Int32  @tutorialID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tutorialID};
            var ___result = RGetIdByTutorialId_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual ShortcutConfig GetConfigByID(System.Int32  @idConfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idConfig};
            var ___result = RGetConfigByID_Int32.Invoke(___genericsType, ___parameters);

            return (ShortcutConfig)___result;
        }


        public virtual void ShowIconByTutorialFlag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowIconByTutorialFlag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginAddShortcutByTutorialId(System.Int32  @tutorialID, System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tutorialID, @callback};
            var ___result = RBeginAddShortcutByTutorialId_Int32_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginAddEventPanelIcon(System.Int32  @configID, System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configID, @callback};
            var ___result = RBeginAddEventPanelIcon_Int32_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator EventPanelIconOpen(System.Int32  @configID, System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configID, @callback};
            var ___result = REventPanelIconOpen_Int32_Action.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void BeginAddShortcut(System.Int32  @configID, System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configID, @callback};
            var ___result = RBeginAddShortcut_Int32_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator ShortcutOpen(System.Int32  @configID, System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configID, @callback};
            var ___result = RShortcutOpen_Int32_Action.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void LoadEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadEffect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual MyGUI.ElementBase GetEffectElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEffectElement.Invoke(___genericsType, ___parameters);

            return (MyGUI.ElementBase)___result;
        }




        public virtual void NotifyIconUp(GameDefineType.ID  @shortCutID, System.Boolean  @bOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shortCutID, @bOpen};
            var ___result = RNotifyIconUp_ID_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyIconUp(System.String  @iconName, System.Boolean  @bOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconName, @bOpen};
            var ___result = RNotifyIconUp_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyIconNum(System.String  @iconName, System.Int32  @num)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconName, @num};
            var ___result = RNotifyIconNum_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyIconUp(ShortcutConfig  @shortCut, System.Boolean  @bOpen, System.Int32  @num)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shortCut, @bOpen, @num};
            var ___result = RNotifyIconUp_ShortcutConfig_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NotifyIconUp(ShortcutConfig  @shortCut, System.Boolean  @bOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shortCut, @bOpen};
            var ___result = RNotifyIconUp_ShortcutConfig_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UpdateArrowPostion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateArrowPostion.Invoke(___genericsType, ___parameters);

            
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
