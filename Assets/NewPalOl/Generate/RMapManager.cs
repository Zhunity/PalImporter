using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MapManager
	/// </summary>
    public partial class RMapManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] m_MapEnableInfo
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r_m_MapEnableInfo;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> Rm_MapEnableInfo
		{
			get
			{
				if(r_m_MapEnableInfo == null)
				{
					r_m_MapEnableInfo = new(this, "m_MapEnableInfo");
					r_m_MapEnableInfo.SetBelong(this.instance);
				}
				return r_m_MapEnableInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,WORLD_MAP_CFG] m_WorldmapCfgList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RWORLD_MAP_CFG> r_m_WorldmapCfgList;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RWORLD_MAP_CFG> Rm_WorldmapCfgList
		{
			get
			{
				if(r_m_WorldmapCfgList == null)
				{
					r_m_WorldmapCfgList = new(this, "m_WorldmapCfgList");
					r_m_WorldmapCfgList.SetBelong(this.instance);
				}
				return r_m_WorldmapCfgList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,TARGET_PATH_INFO] m_TargetPathDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RTARGET_PATH_INFO> r_m_TargetPathDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RTARGET_PATH_INFO> Rm_TargetPathDict
		{
			get
			{
				if(r_m_TargetPathDict == null)
				{
					r_m_TargetPathDict = new(this, "m_TargetPathDict");
					r_m_TargetPathDict.SetBelong(this.instance);
				}
				return r_m_TargetPathDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,NpcIconConfig] m_NpcIconNameDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RNpcIconConfig> r_m_NpcIconNameDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RNpcIconConfig> Rm_NpcIconNameDict
		{
			get
			{
				if(r_m_NpcIconNameDict == null)
				{
					r_m_NpcIconNameDict = new(this, "m_NpcIconNameDict");
					r_m_NpcIconNameDict.SetBelong(this.instance);
				}
				return r_m_NpcIconNameDict;
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
		/// Void OnLoadTargetPathConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadTargetPathConfig_Object;
		public virtual RMethod ROnLoadTargetPathConfig_Object
		{
			get
			{
				if(r_ROnLoadTargetPathConfig_Object == null)
				{
					r_ROnLoadTargetPathConfig_Object = new(this, "OnLoadTargetPathConfig", 0, typeof(System.Object));
					r_ROnLoadTargetPathConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTargetPathConfig_Object;
			}
		}

		/// <summary>
		/// Boolean CheckISWorldmap(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RCheckISWorldmap_ID;
		public virtual RMethod RCheckISWorldmap_ID
		{
			get
			{
				if(r_RCheckISWorldmap_ID == null)
				{
					r_RCheckISWorldmap_ID = new(this, "CheckISWorldmap", 0, typeof(GameDefineType.ID));
					r_RCheckISWorldmap_ID.SetBelong(this.instance);
				}
				return r_RCheckISWorldmap_ID;
			}
		}

		/// <summary>
		/// TARGET_PATH_INFO GetTargetPathInfo(Int32)
		/// </summary>
		protected RMethod r_RGetTargetPathInfo_Int32;
		public virtual RMethod RGetTargetPathInfo_Int32
		{
			get
			{
				if(r_RGetTargetPathInfo_Int32 == null)
				{
					r_RGetTargetPathInfo_Int32 = new(this, "GetTargetPathInfo", 0, typeof(System.Int32));
					r_RGetTargetPathInfo_Int32.SetBelong(this.instance);
				}
				return r_RGetTargetPathInfo_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadWorldmapConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadWorldmapConfig_Object;
		public virtual RMethod ROnLoadWorldmapConfig_Object
		{
			get
			{
				if(r_ROnLoadWorldmapConfig_Object == null)
				{
					r_ROnLoadWorldmapConfig_Object = new(this, "OnLoadWorldmapConfig", 0, typeof(System.Object));
					r_ROnLoadWorldmapConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadWorldmapConfig_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetMapIconPos(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetMapIconPos_ID;
		public virtual RMethod RGetMapIconPos_ID
		{
			get
			{
				if(r_RGetMapIconPos_ID == null)
				{
					r_RGetMapIconPos_ID = new(this, "GetMapIconPos", 0, typeof(GameDefineType.ID));
					r_RGetMapIconPos_ID.SetBelong(this.instance);
				}
				return r_RGetMapIconPos_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID GetMapTranspointId(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetMapTranspointId_ID;
		public virtual RMethod RGetMapTranspointId_ID
		{
			get
			{
				if(r_RGetMapTranspointId_ID == null)
				{
					r_RGetMapTranspointId_ID = new(this, "GetMapTranspointId", 0, typeof(GameDefineType.ID));
					r_RGetMapTranspointId_ID.SetBelong(this.instance);
				}
				return r_RGetMapTranspointId_ID;
			}
		}

		/// <summary>
		/// Void OnMapIconEnableInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMapIconEnableInfo_Object___0__Isb;
		public virtual RMethod ROnMapIconEnableInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnMapIconEnableInfo_Object___0__Isb == null)
				{
					r_ROnMapIconEnableInfo_Object___0__Isb = new(this, "OnMapIconEnableInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMapIconEnableInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMapIconEnableInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] GetMapEnableInfo()
		/// </summary>
		protected RMethod r_RGetMapEnableInfo;
		public virtual RMethod RGetMapEnableInfo
		{
			get
			{
				if(r_RGetMapEnableInfo == null)
				{
					r_RGetMapEnableInfo = new(this, "GetMapEnableInfo", 0);
					r_RGetMapEnableInfo.SetBelong(this.instance);
				}
				return r_RGetMapEnableInfo;
			}
		}

		/// <summary>
		/// Void OnReqMapTag(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnReqMapTag_Object___0__Isb;
		public virtual RMethod ROnReqMapTag_Object___0__Isb
		{
			get
			{
				if(r_ROnReqMapTag_Object___0__Isb == null)
				{
					r_ROnReqMapTag_Object___0__Isb = new(this, "OnReqMapTag", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnReqMapTag_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnReqMapTag_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendAddMapTag(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RSendAddMapTag_String_String_String;
		public virtual RMethod RSendAddMapTag_String_String_String
		{
			get
			{
				if(r_RSendAddMapTag_String_String_String == null)
				{
					r_RSendAddMapTag_String_String_String = new(this, "SendAddMapTag", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RSendAddMapTag_String_String_String.SetBelong(this.instance);
				}
				return r_RSendAddMapTag_String_String_String;
			}
		}

		/// <summary>
		/// Void SendDelMapTag(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendDelMapTag_ID;
		public virtual RMethod RSendDelMapTag_ID
		{
			get
			{
				if(r_RSendDelMapTag_ID == null)
				{
					r_RSendDelMapTag_ID = new(this, "SendDelMapTag", 0, typeof(GameDefineType.ID));
					r_RSendDelMapTag_ID.SetBelong(this.instance);
				}
				return r_RSendDelMapTag_ID;
			}
		}

		/// <summary>
		/// Void SendMapTagReq()
		/// </summary>
		protected RMethod r_RSendMapTagReq;
		public virtual RMethod RSendMapTagReq
		{
			get
			{
				if(r_RSendMapTagReq == null)
				{
					r_RSendMapTagReq = new(this, "SendMapTagReq", 0);
					r_RSendMapTagReq.SetBelong(this.instance);
				}
				return r_RSendMapTagReq;
			}
		}

		/// <summary>
		/// Void SendMapTagEdit(GameDefineType.ID, System.String, System.String, System.String, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendMapTagEdit_ID_String_String_String_ID;
		public virtual RMethod RSendMapTagEdit_ID_String_String_String_ID
		{
			get
			{
				if(r_RSendMapTagEdit_ID_String_String_String_ID == null)
				{
					r_RSendMapTagEdit_ID_String_String_String_ID = new(this, "SendMapTagEdit", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(System.String), typeof(System.String), typeof(GameDefineType.ID));
					r_RSendMapTagEdit_ID_String_String_String_ID.SetBelong(this.instance);
				}
				return r_RSendMapTagEdit_ID_String_String_String_ID;
			}
		}

		/// <summary>
		/// Void SendBackToRelivePoint()
		/// </summary>
		protected RMethod r_RSendBackToRelivePoint;
		public virtual RMethod RSendBackToRelivePoint
		{
			get
			{
				if(r_RSendBackToRelivePoint == null)
				{
					r_RSendBackToRelivePoint = new(this, "SendBackToRelivePoint", 0);
					r_RSendBackToRelivePoint.SetBelong(this.instance);
				}
				return r_RSendBackToRelivePoint;
			}
		}

		/// <summary>
		/// Void SendTransMap(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendTransMap_ID;
		public virtual RMethod RSendTransMap_ID
		{
			get
			{
				if(r_RSendTransMap_ID == null)
				{
					r_RSendTransMap_ID = new(this, "SendTransMap", 0, typeof(GameDefineType.ID));
					r_RSendTransMap_ID.SetBelong(this.instance);
				}
				return r_RSendTransMap_ID;
			}
		}

		/// <summary>
		/// Void GotoScene(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGotoScene_ID;
		public virtual RMethod RGotoScene_ID
		{
			get
			{
				if(r_RGotoScene_ID == null)
				{
					r_RGotoScene_ID = new(this, "GotoScene", 0, typeof(GameDefineType.ID));
					r_RGotoScene_ID.SetBelong(this.instance);
				}
				return r_RGotoScene_ID;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ConvertMapPosToScenePos(UnityEngine.Vector2, GameDefineType.ID, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RConvertMapPosToScenePos_Vector2_ID_Vector2;
		public virtual RMethod RConvertMapPosToScenePos_Vector2_ID_Vector2
		{
			get
			{
				if(r_RConvertMapPosToScenePos_Vector2_ID_Vector2 == null)
				{
					r_RConvertMapPosToScenePos_Vector2_ID_Vector2 = new(this, "ConvertMapPosToScenePos", 0, typeof(UnityEngine.Vector2), typeof(GameDefineType.ID), typeof(UnityEngine.Vector2));
					r_RConvertMapPosToScenePos_Vector2_ID_Vector2.SetBelong(this.instance);
				}
				return r_RConvertMapPosToScenePos_Vector2_ID_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 ConvertScenePosToMapPos(UnityEngine.Vector2, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RConvertScenePosToMapPos_Vector2_ID;
		public virtual RMethod RConvertScenePosToMapPos_Vector2_ID
		{
			get
			{
				if(r_RConvertScenePosToMapPos_Vector2_ID == null)
				{
					r_RConvertScenePosToMapPos_Vector2_ID = new(this, "ConvertScenePosToMapPos", 0, typeof(UnityEngine.Vector2), typeof(GameDefineType.ID));
					r_RConvertScenePosToMapPos_Vector2_ID.SetBelong(this.instance);
				}
				return r_RConvertScenePosToMapPos_Vector2_ID;
			}
		}

		/// <summary>
		/// System.String GetNpcIconUrl(Int32)
		/// </summary>
		protected RMethod r_RGetNpcIconUrl_Int32;
		public virtual RMethod RGetNpcIconUrl_Int32
		{
			get
			{
				if(r_RGetNpcIconUrl_Int32 == null)
				{
					r_RGetNpcIconUrl_Int32 = new(this, "GetNpcIconUrl", 0, typeof(System.Int32));
					r_RGetNpcIconUrl_Int32.SetBelong(this.instance);
				}
				return r_RGetNpcIconUrl_Int32;
			}
		}

		/// <summary>
		/// System.String GetNpcMapIconUrl(Int32)
		/// </summary>
		protected RMethod r_RGetNpcMapIconUrl_Int32;
		public virtual RMethod RGetNpcMapIconUrl_Int32
		{
			get
			{
				if(r_RGetNpcMapIconUrl_Int32 == null)
				{
					r_RGetNpcMapIconUrl_Int32 = new(this, "GetNpcMapIconUrl", 0, typeof(System.Int32));
					r_RGetNpcMapIconUrl_Int32.SetBelong(this.instance);
				}
				return r_RGetNpcMapIconUrl_Int32;
			}
		}

		/// <summary>
		/// System.String GetNpcMapNotifyIconUrl(Int32)
		/// </summary>
		protected RMethod r_RGetNpcMapNotifyIconUrl_Int32;
		public virtual RMethod RGetNpcMapNotifyIconUrl_Int32
		{
			get
			{
				if(r_RGetNpcMapNotifyIconUrl_Int32 == null)
				{
					r_RGetNpcMapNotifyIconUrl_Int32 = new(this, "GetNpcMapNotifyIconUrl", 0, typeof(System.Int32));
					r_RGetNpcMapNotifyIconUrl_Int32.SetBelong(this.instance);
				}
				return r_RGetNpcMapNotifyIconUrl_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadNPCIconConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadNPCIconConfig_Object;
		public virtual RMethod ROnLoadNPCIconConfig_Object
		{
			get
			{
				if(r_ROnLoadNPCIconConfig_Object == null)
				{
					r_ROnLoadNPCIconConfig_Object = new(this, "OnLoadNPCIconConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadNPCIconConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadNPCIconConfig_Object;
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


        public RMapManager() : base("MapManager")
        {
        }

        public RMapManager(System.Object instance) : base("MapManager")
		{
            SetInstance(instance);
		}

        public RMapManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMapManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadTargetPathConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTargetPathConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckISWorldmap(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RCheckISWorldmap_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual TARGET_PATH_INFO GetTargetPathInfo(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetTargetPathInfo_Int32.Invoke(___genericsType, ___parameters);

            return (TARGET_PATH_INFO)___result;
        }


        public virtual void OnLoadWorldmapConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadWorldmapConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetMapIconPos(GameDefineType.ID  @mapid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapid};
            var ___result = RGetMapIconPos_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual GameDefineType.ID GetMapTranspointId(GameDefineType.ID  @mapid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapid};
            var ___result = RGetMapTranspointId_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }



        public virtual System.Collections.Generic.List<GameDefineType.ID> GetMapEnableInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMapEnableInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }



        public virtual void SendAddMapTag(System.String  @name, System.String  @x, System.String  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @x, @y};
            var ___result = RSendAddMapTag_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDelMapTag(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendDelMapTag_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMapTagReq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendMapTagReq.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMapTagEdit(GameDefineType.ID  @id, System.String  @name, System.String  @x, System.String  @y, GameDefineType.ID  @sceneid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @name, @x, @y, @sceneid};
            var ___result = RSendMapTagEdit_ID_String_String_String_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendBackToRelivePoint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendBackToRelivePoint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendTransMap(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendTransMap_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GotoScene(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGotoScene_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 ConvertMapPosToScenePos(UnityEngine.Vector2  @mapPos, GameDefineType.ID  @sceneID, UnityEngine.Vector2  @iconSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapPos, @sceneID, @iconSize};
            var ___result = RConvertMapPosToScenePos_Vector2_ID_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector2 ConvertScenePosToMapPos(UnityEngine.Vector2  @scenePos, GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scenePos, @sceneID};
            var ___result = RConvertScenePosToMapPos_Vector2_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.String GetNpcIconUrl(System.Int32  @subtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subtype};
            var ___result = RGetNpcIconUrl_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNpcMapIconUrl(System.Int32  @subtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subtype};
            var ___result = RGetNpcMapIconUrl_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNpcMapNotifyIconUrl(System.Int32  @subtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@subtype};
            var ___result = RGetNpcMapNotifyIconUrl_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnLoadNPCIconConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadNPCIconConfig_Object.Invoke(___genericsType, ___parameters);

            
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
