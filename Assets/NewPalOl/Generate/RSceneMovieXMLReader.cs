using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieXMLReader
	/// </summary>
    public partial class RSceneMovieXMLReader : RMember //
    {

		/// <summary>
		/// System.String ROOT_NAME
		/// </summary>
		protected static RField r_ROOT_NAME;
		public static RField ROOT_NAME
		{
			get
			{
				if(r_ROOT_NAME == null)
				{
					r_ROOT_NAME = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ROOT_NAME");
					r_ROOT_NAME.SetBelong(null);
				}
				return r_ROOT_NAME;
			}
		}

		/// <summary>
		/// System.String ATTR_CLIP_NAME
		/// </summary>
		protected static RField r_ATTR_CLIP_NAME;
		public static RField RATTR_CLIP_NAME
		{
			get
			{
				if(r_ATTR_CLIP_NAME == null)
				{
					r_ATTR_CLIP_NAME = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_CLIP_NAME");
					r_ATTR_CLIP_NAME.SetBelong(null);
				}
				return r_ATTR_CLIP_NAME;
			}
		}

		/// <summary>
		/// System.String ATTR_SCENE_NAME
		/// </summary>
		protected static RField r_ATTR_SCENE_NAME;
		public static RField RATTR_SCENE_NAME
		{
			get
			{
				if(r_ATTR_SCENE_NAME == null)
				{
					r_ATTR_SCENE_NAME = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SCENE_NAME");
					r_ATTR_SCENE_NAME.SetBelong(null);
				}
				return r_ATTR_SCENE_NAME;
			}
		}

		/// <summary>
		/// System.String ATTR_CAREER_LIMITED
		/// </summary>
		protected static RField r_ATTR_CAREER_LIMITED;
		public static RField RATTR_CAREER_LIMITED
		{
			get
			{
				if(r_ATTR_CAREER_LIMITED == null)
				{
					r_ATTR_CAREER_LIMITED = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_CAREER_LIMITED");
					r_ATTR_CAREER_LIMITED.SetBelong(null);
				}
				return r_ATTR_CAREER_LIMITED;
			}
		}

		/// <summary>
		/// System.String ATTR_TASK_LIMITED
		/// </summary>
		protected static RField r_ATTR_TASK_LIMITED;
		public static RField RATTR_TASK_LIMITED
		{
			get
			{
				if(r_ATTR_TASK_LIMITED == null)
				{
					r_ATTR_TASK_LIMITED = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_TASK_LIMITED");
					r_ATTR_TASK_LIMITED.SetBelong(null);
				}
				return r_ATTR_TASK_LIMITED;
			}
		}

		/// <summary>
		/// System.String ATTR_RESTORE_PLAYER
		/// </summary>
		protected static RField r_ATTR_RESTORE_PLAYER;
		public static RField RATTR_RESTORE_PLAYER
		{
			get
			{
				if(r_ATTR_RESTORE_PLAYER == null)
				{
					r_ATTR_RESTORE_PLAYER = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_RESTORE_PLAYER");
					r_ATTR_RESTORE_PLAYER.SetBelong(null);
				}
				return r_ATTR_RESTORE_PLAYER;
			}
		}

		/// <summary>
		/// System.String ATTR_RESTORE_BGM
		/// </summary>
		protected static RField r_ATTR_RESTORE_BGM;
		public static RField RATTR_RESTORE_BGM
		{
			get
			{
				if(r_ATTR_RESTORE_BGM == null)
				{
					r_ATTR_RESTORE_BGM = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_RESTORE_BGM");
					r_ATTR_RESTORE_BGM.SetBelong(null);
				}
				return r_ATTR_RESTORE_BGM;
			}
		}

		/// <summary>
		/// System.String ATTR_CAMERA_FOA
		/// </summary>
		protected static RField r_ATTR_CAMERA_FOA;
		public static RField RATTR_CAMERA_FOA
		{
			get
			{
				if(r_ATTR_CAMERA_FOA == null)
				{
					r_ATTR_CAMERA_FOA = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_CAMERA_FOA");
					r_ATTR_CAMERA_FOA.SetBelong(null);
				}
				return r_ATTR_CAMERA_FOA;
			}
		}

		/// <summary>
		/// System.String ATTR_CAMERA_FAR_CLIP
		/// </summary>
		protected static RField r_ATTR_CAMERA_FAR_CLIP;
		public static RField RATTR_CAMERA_FAR_CLIP
		{
			get
			{
				if(r_ATTR_CAMERA_FAR_CLIP == null)
				{
					r_ATTR_CAMERA_FAR_CLIP = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_CAMERA_FAR_CLIP");
					r_ATTR_CAMERA_FAR_CLIP.SetBelong(null);
				}
				return r_ATTR_CAMERA_FAR_CLIP;
			}
		}

		/// <summary>
		/// System.String ATTR_DOWNLOAD_BATTLE_RES
		/// </summary>
		protected static RField r_ATTR_DOWNLOAD_BATTLE_RES;
		public static RField RATTR_DOWNLOAD_BATTLE_RES
		{
			get
			{
				if(r_ATTR_DOWNLOAD_BATTLE_RES == null)
				{
					r_ATTR_DOWNLOAD_BATTLE_RES = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_DOWNLOAD_BATTLE_RES");
					r_ATTR_DOWNLOAD_BATTLE_RES.SetBelong(null);
				}
				return r_ATTR_DOWNLOAD_BATTLE_RES;
			}
		}

		/// <summary>
		/// System.String ATTR_NEED_END_FADEIN
		/// </summary>
		protected static RField r_ATTR_NEED_END_FADEIN;
		public static RField RATTR_NEED_END_FADEIN
		{
			get
			{
				if(r_ATTR_NEED_END_FADEIN == null)
				{
					r_ATTR_NEED_END_FADEIN = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_NEED_END_FADEIN");
					r_ATTR_NEED_END_FADEIN.SetBelong(null);
				}
				return r_ATTR_NEED_END_FADEIN;
			}
		}

		/// <summary>
		/// System.String ATTR_NEED_FOG
		/// </summary>
		protected static RField r_ATTR_NEED_FOG;
		public static RField RATTR_NEED_FOG
		{
			get
			{
				if(r_ATTR_NEED_FOG == null)
				{
					r_ATTR_NEED_FOG = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_NEED_FOG");
					r_ATTR_NEED_FOG.SetBelong(null);
				}
				return r_ATTR_NEED_FOG;
			}
		}

		/// <summary>
		/// System.String ATTR_SHOW_OTHER_PLAYERS
		/// </summary>
		protected static RField r_ATTR_SHOW_OTHER_PLAYERS;
		public static RField RATTR_SHOW_OTHER_PLAYERS
		{
			get
			{
				if(r_ATTR_SHOW_OTHER_PLAYERS == null)
				{
					r_ATTR_SHOW_OTHER_PLAYERS = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SHOW_OTHER_PLAYERS");
					r_ATTR_SHOW_OTHER_PLAYERS.SetBelong(null);
				}
				return r_ATTR_SHOW_OTHER_PLAYERS;
			}
		}

		/// <summary>
		/// System.String ATTR_SHOW_HORSE
		/// </summary>
		protected static RField r_ATTR_SHOW_HORSE;
		public static RField RATTR_SHOW_HORSE
		{
			get
			{
				if(r_ATTR_SHOW_HORSE == null)
				{
					r_ATTR_SHOW_HORSE = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SHOW_HORSE");
					r_ATTR_SHOW_HORSE.SetBelong(null);
				}
				return r_ATTR_SHOW_HORSE;
			}
		}

		/// <summary>
		/// System.String ATTR_SHOW_UI
		/// </summary>
		protected static RField r_ATTR_SHOW_UI;
		public static RField RATTR_SHOW_UI
		{
			get
			{
				if(r_ATTR_SHOW_UI == null)
				{
					r_ATTR_SHOW_UI = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SHOW_UI");
					r_ATTR_SHOW_UI.SetBelong(null);
				}
				return r_ATTR_SHOW_UI;
			}
		}

		/// <summary>
		/// System.String ATTR_SHOW_NPC
		/// </summary>
		protected static RField r_ATTR_SHOW_NPC;
		public static RField RATTR_SHOW_NPC
		{
			get
			{
				if(r_ATTR_SHOW_NPC == null)
				{
					r_ATTR_SHOW_NPC = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SHOW_NPC");
					r_ATTR_SHOW_NPC.SetBelong(null);
				}
				return r_ATTR_SHOW_NPC;
			}
		}

		/// <summary>
		/// System.String ATTR_SHOW_MAP
		/// </summary>
		protected static RField r_ATTR_SHOW_MAP;
		public static RField RATTR_SHOW_MAP
		{
			get
			{
				if(r_ATTR_SHOW_MAP == null)
				{
					r_ATTR_SHOW_MAP = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_SHOW_MAP");
					r_ATTR_SHOW_MAP.SetBelong(null);
				}
				return r_ATTR_SHOW_MAP;
			}
		}

		/// <summary>
		/// System.String ATTR_COMMENT
		/// </summary>
		protected static RField r_ATTR_COMMENT;
		public static RField RATTR_COMMENT
		{
			get
			{
				if(r_ATTR_COMMENT == null)
				{
					r_ATTR_COMMENT = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_COMMENT");
					r_ATTR_COMMENT.SetBelong(null);
				}
				return r_ATTR_COMMENT;
			}
		}

		/// <summary>
		/// System.String ATTR_ESCAPE
		/// </summary>
		protected static RField r_ATTR_ESCAPE;
		public static RField RATTR_ESCAPE
		{
			get
			{
				if(r_ATTR_ESCAPE == null)
				{
					r_ATTR_ESCAPE = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_ESCAPE");
					r_ATTR_ESCAPE.SetBelong(null);
				}
				return r_ATTR_ESCAPE;
			}
		}

		/// <summary>
		/// System.String ASSETS_NAME
		/// </summary>
		protected static RField r_ASSETS_NAME;
		public static RField RASSETS_NAME
		{
			get
			{
				if(r_ASSETS_NAME == null)
				{
					r_ASSETS_NAME = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ASSETS_NAME");
					r_ASSETS_NAME.SetBelong(null);
				}
				return r_ASSETS_NAME;
			}
		}

		/// <summary>
		/// System.String ATTR_COMMON_RES
		/// </summary>
		protected static RField r_ATTR_COMMON_RES;
		public static RField RATTR_COMMON_RES
		{
			get
			{
				if(r_ATTR_COMMON_RES == null)
				{
					r_ATTR_COMMON_RES = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ATTR_COMMON_RES");
					r_ATTR_COMMON_RES.SetBelong(null);
				}
				return r_ATTR_COMMON_RES;
			}
		}

		/// <summary>
		/// System.String ASSET_ATTR_FILE
		/// </summary>
		protected static RField r_ASSET_ATTR_FILE;
		public static RField RASSET_ATTR_FILE
		{
			get
			{
				if(r_ASSET_ATTR_FILE == null)
				{
					r_ASSET_ATTR_FILE = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "ASSET_ATTR_FILE");
					r_ASSET_ATTR_FILE.SetBelong(null);
				}
				return r_ASSET_ATTR_FILE;
			}
		}

		/// <summary>
		/// System.String CONTENT_NAME
		/// </summary>
		protected static RField r_CONTENT_NAME;
		public static RField RCONTENT_NAME
		{
			get
			{
				if(r_CONTENT_NAME == null)
				{
					r_CONTENT_NAME = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "CONTENT_NAME");
					r_CONTENT_NAME.SetBelong(null);
				}
				return r_CONTENT_NAME;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_ScendID
		/// </summary>
		protected RGameDefineType.RID r_m_ScendID;
		public virtual RGameDefineType.RID Rm_ScendID
		{
			get
			{
				if(r_m_ScendID == null)
				{
					r_m_ScendID = new(this, "m_ScendID");
					r_m_ScendID.SetBelong(this.instance);
				}
				return r_m_ScendID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map0
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map0;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map0
		{
			get
			{
				if(r___2____4__f__switch__9__map0 == null)
				{
					r___2____4__f__switch__9__map0 = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "<>f__switch$map0");
					r___2____4__f__switch__9__map0.SetBelong(null);
				}
				return r___2____4__f__switch__9__map0;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map1
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map1;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map1
		{
			get
			{
				if(r___2____4__f__switch__9__map1 == null)
				{
					r___2____4__f__switch__9__map1 = new( ReleactionUtils.GetType("SceneMovieXMLReader"), "<>f__switch$map1");
					r___2____4__f__switch__9__map1.SetBelong(null);
				}
				return r___2____4__f__switch__9__map1;
			}
		}

		/// <summary>
		/// SceneMovieNetConfig LoadXmlContent(System.String, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RLoadXmlContent_String_ID;
		public virtual RMethod RLoadXmlContent_String_ID
		{
			get
			{
				if(r_RLoadXmlContent_String_ID == null)
				{
					r_RLoadXmlContent_String_ID = new(this, "LoadXmlContent", 0, typeof(System.String), typeof(GameDefineType.ID));
					r_RLoadXmlContent_String_ID.SetBelong(this.instance);
				}
				return r_RLoadXmlContent_String_ID;
			}
		}

		/// <summary>
		/// SceneMovieNetConfig LoadXml(System.String, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RLoadXml_String_ID;
		public virtual RMethod RLoadXml_String_ID
		{
			get
			{
				if(r_RLoadXml_String_ID == null)
				{
					r_RLoadXml_String_ID = new(this, "LoadXml", 0, typeof(System.String), typeof(GameDefineType.ID));
					r_RLoadXml_String_ID.SetBelong(this.instance);
				}
				return r_RLoadXml_String_ID;
			}
		}

		/// <summary>
		/// SceneMovieNetConfig LoadXml(System.String, GameDefineType.ID, System.Xml.XmlDocument ByRef)
		/// </summary>
		protected RMethod r_RLoadXml_String_ID_Ref_XmlDocument;
		public virtual RMethod RLoadXml_String_ID_Ref_XmlDocument
		{
			get
			{
				if(r_RLoadXml_String_ID_Ref_XmlDocument == null)
				{
					r_RLoadXml_String_ID_Ref_XmlDocument = new(this, "LoadXml", 0, typeof(System.String), typeof(GameDefineType.ID), typeof(System.Xml.XmlDocument).MakeByRefType());
					r_RLoadXml_String_ID_Ref_XmlDocument.SetBelong(this.instance);
				}
				return r_RLoadXml_String_ID_Ref_XmlDocument;
			}
		}

		/// <summary>
		/// SceneMovieNetConfig LoadXml(UnityEngine.TextAsset)
		/// </summary>
		protected RMethod r_RLoadXml_TextAsset;
		public virtual RMethod RLoadXml_TextAsset
		{
			get
			{
				if(r_RLoadXml_TextAsset == null)
				{
					r_RLoadXml_TextAsset = new(this, "LoadXml", 0, typeof(UnityEngine.TextAsset));
					r_RLoadXml_TextAsset.SetBelong(this.instance);
				}
				return r_RLoadXml_TextAsset;
			}
		}

		/// <summary>
		/// SceneMovieNetConfig LoadXmlDocument(System.Xml.XmlDocument)
		/// </summary>
		protected RMethod r_RLoadXmlDocument_XmlDocument;
		public virtual RMethod RLoadXmlDocument_XmlDocument
		{
			get
			{
				if(r_RLoadXmlDocument_XmlDocument == null)
				{
					r_RLoadXmlDocument_XmlDocument = new(this, "LoadXmlDocument", 0, typeof(System.Xml.XmlDocument));
					r_RLoadXmlDocument_XmlDocument.SetBelong(this.instance);
				}
				return r_RLoadXmlDocument_XmlDocument;
			}
		}

		/// <summary>
		/// SceneMovieClip ParseMovieClip(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RParseMovieClip_XmlNode;
		public virtual RMethod RParseMovieClip_XmlNode
		{
			get
			{
				if(r_RParseMovieClip_XmlNode == null)
				{
					r_RParseMovieClip_XmlNode = new(this, "ParseMovieClip", 0, typeof(System.Xml.XmlNode));
					r_RParseMovieClip_XmlNode.SetBelong(this.instance);
				}
				return r_RParseMovieClip_XmlNode;
			}
		}

		/// <summary>
		/// Boolean ParseMovieClipAssets(SceneMovieClip ByRef, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode;
		public virtual RMethod RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode
		{
			get
			{
				if(r_RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode == null)
				{
					r_RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode = new(this, "ParseMovieClipAssets", 0, typeof(SceneMovieClip).MakeByRefType(), typeof(System.Xml.XmlNode));
					r_RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode.SetBelong(this.instance);
				}
				return r_RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode;
			}
		}

		/// <summary>
		/// Boolean ParseMovieClipContent(SceneMovieClip ByRef, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RParseMovieClipContent_Ref_SceneMovieClip_XmlNode;
		public virtual RMethod RParseMovieClipContent_Ref_SceneMovieClip_XmlNode
		{
			get
			{
				if(r_RParseMovieClipContent_Ref_SceneMovieClip_XmlNode == null)
				{
					r_RParseMovieClipContent_Ref_SceneMovieClip_XmlNode = new(this, "ParseMovieClipContent", 0, typeof(SceneMovieClip).MakeByRefType(), typeof(System.Xml.XmlNode));
					r_RParseMovieClipContent_Ref_SceneMovieClip_XmlNode.SetBelong(this.instance);
				}
				return r_RParseMovieClipContent_Ref_SceneMovieClip_XmlNode;
			}
		}

		/// <summary>
		/// Void CreateClipBase(SceneMovieCommand ByRef, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateClipBase_Ref_SceneMovieCommand_XmlNode;
		public virtual RMethod RCreateClipBase_Ref_SceneMovieCommand_XmlNode
		{
			get
			{
				if(r_RCreateClipBase_Ref_SceneMovieCommand_XmlNode == null)
				{
					r_RCreateClipBase_Ref_SceneMovieCommand_XmlNode = new(this, "CreateClipBase", 0, typeof(SceneMovieCommand).MakeByRefType(), typeof(System.Xml.XmlNode));
					r_RCreateClipBase_Ref_SceneMovieCommand_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateClipBase_Ref_SceneMovieCommand_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieWaiting CreateMovieWaitCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieWaitCmd_XmlNode;
		public virtual RMethod RCreateMovieWaitCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieWaitCmd_XmlNode == null)
				{
					r_RCreateMovieWaitCmd_XmlNode = new(this, "CreateMovieWaitCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieWaitCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieWaitCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieDialogCmd CreateMovieDialogCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieDialogCmd_XmlNode;
		public virtual RMethod RCreateMovieDialogCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieDialogCmd_XmlNode == null)
				{
					r_RCreateMovieDialogCmd_XmlNode = new(this, "CreateMovieDialogCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieDialogCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieDialogCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMoviePlayerLock CreatePlayerLockCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreatePlayerLockCmd_XmlNode;
		public virtual RMethod RCreatePlayerLockCmd_XmlNode
		{
			get
			{
				if(r_RCreatePlayerLockCmd_XmlNode == null)
				{
					r_RCreatePlayerLockCmd_XmlNode = new(this, "CreatePlayerLockCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreatePlayerLockCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreatePlayerLockCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieOtherPlayerShow CreateOtherPlayerShowCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateOtherPlayerShowCmd_XmlNode;
		public virtual RMethod RCreateOtherPlayerShowCmd_XmlNode
		{
			get
			{
				if(r_RCreateOtherPlayerShowCmd_XmlNode == null)
				{
					r_RCreateOtherPlayerShowCmd_XmlNode = new(this, "CreateOtherPlayerShowCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateOtherPlayerShowCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateOtherPlayerShowCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieTimeScale CreateTimeScaleCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateTimeScaleCmd_XmlNode;
		public virtual RMethod RCreateTimeScaleCmd_XmlNode
		{
			get
			{
				if(r_RCreateTimeScaleCmd_XmlNode == null)
				{
					r_RCreateTimeScaleCmd_XmlNode = new(this, "CreateTimeScaleCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateTimeScaleCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateTimeScaleCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieReplayCombat CreateMovieReplayCombatCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieReplayCombatCmd_XmlNode;
		public virtual RMethod RCreateMovieReplayCombatCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieReplayCombatCmd_XmlNode == null)
				{
					r_RCreateMovieReplayCombatCmd_XmlNode = new(this, "CreateMovieReplayCombatCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieReplayCombatCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieReplayCombatCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieCameraCmd CreateMovieCameraCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieCameraCmd_XmlNode;
		public virtual RMethod RCreateMovieCameraCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieCameraCmd_XmlNode == null)
				{
					r_RCreateMovieCameraCmd_XmlNode = new(this, "CreateMovieCameraCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieCameraCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieCameraCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieMusicCmd CreateMovieMusicCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieMusicCmd_XmlNode;
		public virtual RMethod RCreateMovieMusicCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieMusicCmd_XmlNode == null)
				{
					r_RCreateMovieMusicCmd_XmlNode = new(this, "CreateMovieMusicCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieMusicCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieMusicCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieUnitCmd CreateMovieUnitCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateMovieUnitCmd_XmlNode;
		public virtual RMethod RCreateMovieUnitCmd_XmlNode
		{
			get
			{
				if(r_RCreateMovieUnitCmd_XmlNode == null)
				{
					r_RCreateMovieUnitCmd_XmlNode = new(this, "CreateMovieUnitCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateMovieUnitCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateMovieUnitCmd_XmlNode;
			}
		}

		/// <summary>
		/// SceneMovieEffectCmd CreateEffectCmd(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RCreateEffectCmd_XmlNode;
		public virtual RMethod RCreateEffectCmd_XmlNode
		{
			get
			{
				if(r_RCreateEffectCmd_XmlNode == null)
				{
					r_RCreateEffectCmd_XmlNode = new(this, "CreateEffectCmd", 0, typeof(System.Xml.XmlNode));
					r_RCreateEffectCmd_XmlNode.SetBelong(this.instance);
				}
				return r_RCreateEffectCmd_XmlNode;
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


        public RSceneMovieXMLReader() : base("SceneMovieXMLReader")
        {
        }

        public RSceneMovieXMLReader(System.Object instance) : base("SceneMovieXMLReader")
		{
            SetInstance(instance);
		}

        public RSceneMovieXMLReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieXMLReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual SceneMovieNetConfig LoadXmlContent(System.String  @text, GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @sceneID};
            var ___result = RLoadXmlContent_String_ID.Invoke(___genericsType, ___parameters);

            return (SceneMovieNetConfig)___result;
        }


        public virtual SceneMovieNetConfig LoadXml(System.String  @path, GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @sceneID};
            var ___result = RLoadXml_String_ID.Invoke(___genericsType, ___parameters);

            return (SceneMovieNetConfig)___result;
        }


        public virtual SceneMovieNetConfig LoadXml(System.String  @path, GameDefineType.ID  @sceneID, ref System.Xml.XmlDocument  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @sceneID, @xml};
            var ___result = RLoadXml_String_ID_Ref_XmlDocument.Invoke(___genericsType, ___parameters);
			xml = (System.Xml.XmlDocument)___parameters[2];

            return (SceneMovieNetConfig)___result;
        }


        public virtual SceneMovieNetConfig LoadXml(UnityEngine.TextAsset  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_TextAsset.Invoke(___genericsType, ___parameters);

            return (SceneMovieNetConfig)___result;
        }


        public virtual SceneMovieNetConfig LoadXmlDocument(System.Xml.XmlDocument  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RLoadXmlDocument_XmlDocument.Invoke(___genericsType, ___parameters);

            return (SceneMovieNetConfig)___result;
        }


        public virtual SceneMovieClip ParseMovieClip(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RParseMovieClip_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieClip)___result;
        }


        public virtual System.Boolean ParseMovieClipAssets(ref SceneMovieClip  @clip, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @node};
            var ___result = RParseMovieClipAssets_Ref_SceneMovieClip_XmlNode.Invoke(___genericsType, ___parameters);
			clip = (SceneMovieClip)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseMovieClipContent(ref SceneMovieClip  @clip, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @node};
            var ___result = RParseMovieClipContent_Ref_SceneMovieClip_XmlNode.Invoke(___genericsType, ___parameters);
			clip = (SceneMovieClip)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual void CreateClipBase(ref SceneMovieCommand  @command, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@command, @node};
            var ___result = RCreateClipBase_Ref_SceneMovieCommand_XmlNode.Invoke(___genericsType, ___parameters);
			command = (SceneMovieCommand)___parameters[0];

            
        }


        public virtual SceneMovieWaiting CreateMovieWaitCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieWaitCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieWaiting)___result;
        }


        public virtual SceneMovieDialogCmd CreateMovieDialogCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieDialogCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieDialogCmd)___result;
        }


        public virtual SceneMoviePlayerLock CreatePlayerLockCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreatePlayerLockCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMoviePlayerLock)___result;
        }


        public virtual SceneMovieOtherPlayerShow CreateOtherPlayerShowCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateOtherPlayerShowCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieOtherPlayerShow)___result;
        }


        public virtual SceneMovieTimeScale CreateTimeScaleCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateTimeScaleCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieTimeScale)___result;
        }


        public virtual SceneMovieReplayCombat CreateMovieReplayCombatCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieReplayCombatCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieReplayCombat)___result;
        }


        public virtual SceneMovieCameraCmd CreateMovieCameraCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieCameraCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieCameraCmd)___result;
        }


        public virtual SceneMovieMusicCmd CreateMovieMusicCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieMusicCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieMusicCmd)___result;
        }


        public virtual SceneMovieUnitCmd CreateMovieUnitCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateMovieUnitCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieUnitCmd)___result;
        }


        public virtual SceneMovieEffectCmd CreateEffectCmd(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RCreateEffectCmd_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneMovieEffectCmd)___result;
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
