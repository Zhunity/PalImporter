using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TriggerControler
	/// </summary>
    public partial class RTriggerControler : RMember //
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
					r_ROOT_NAME = new( ReleactionUtils.GetType("TriggerControler"), "ROOT_NAME");
					r_ROOT_NAME.SetBelong(null);
				}
				return r_ROOT_NAME;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,TriggerAction] mTriggerActions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RTriggerAction> r_mTriggerActions;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RTriggerAction> RmTriggerActions
		{
			get
			{
				if(r_mTriggerActions == null)
				{
					r_mTriggerActions = new(this, "mTriggerActions");
					r_mTriggerActions.SetBelong(this.instance);
				}
				return r_mTriggerActions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.List`1[TriggerObjectInfo]] mTriggerObject
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RTriggerObjectInfo>> r_mTriggerObject;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RTriggerObjectInfo>> RmTriggerObject
		{
			get
			{
				if(r_mTriggerObject == null)
				{
					r_mTriggerObject = new(this, "mTriggerObject");
					r_mTriggerObject.SetBelong(this.instance);
				}
				return r_mTriggerObject;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,TriggerObjectInfo] mTriggerList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTriggerObjectInfo> r_mTriggerList;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RTriggerObjectInfo> RmTriggerList
		{
			get
			{
				if(r_mTriggerList == null)
				{
					r_mTriggerList = new(this, "mTriggerList");
					r_mTriggerList.SetBelong(this.instance);
				}
				return r_mTriggerList;
			}
		}

		/// <summary>
		/// System.String TriggerResourceRootURL
		/// </summary>
		protected static RField r_TriggerResourceRootURL;
		public static RField RTriggerResourceRootURL
		{
			get
			{
				if(r_TriggerResourceRootURL == null)
				{
					r_TriggerResourceRootURL = new( ReleactionUtils.GetType("TriggerControler"), "TriggerResourceRootURL");
					r_TriggerResourceRootURL.SetBelong(null);
				}
				return r_TriggerResourceRootURL;
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
		/// Void OnLoadTriggerObjectConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTriggerObjectConfig_Object;
		public virtual RMethod ROnLoadTriggerObjectConfig_Object
		{
			get
			{
				if(r_ROnLoadTriggerObjectConfig_Object == null)
				{
					r_ROnLoadTriggerObjectConfig_Object = new(this, "OnLoadTriggerObjectConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTriggerObjectConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTriggerObjectConfig_Object;
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
		/// Void LoadTriggerObject(GameDefineType.ID, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler = new(this, "LoadTriggerObject", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RLoadTriggerObject_ID_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// System.String[] GetTriggerURLs(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetTriggerURLs_ID;
		public virtual RMethod RGetTriggerURLs_ID
		{
			get
			{
				if(r_RGetTriggerURLs_ID == null)
				{
					r_RGetTriggerURLs_ID = new(this, "GetTriggerURLs", 0, typeof(GameDefineType.ID));
					r_RGetTriggerURLs_ID.SetBelong(this.instance);
				}
				return r_RGetTriggerURLs_ID;
			}
		}

		/// <summary>
		/// System.String GetTriggerUrl(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetTriggerUrl_ID;
		public virtual RMethod RGetTriggerUrl_ID
		{
			get
			{
				if(r_RGetTriggerUrl_ID == null)
				{
					r_RGetTriggerUrl_ID = new(this, "GetTriggerUrl", 0, typeof(GameDefineType.ID));
					r_RGetTriggerUrl_ID.SetBelong(this.instance);
				}
				return r_RGetTriggerUrl_ID;
			}
		}

		/// <summary>
		/// Void CreateTriggerObject(GameDefineType.ID, GameDefineType.ID, UnityEngine.Vector3, UnityEngine.Quaternion, System.String)
		/// </summary>
		protected RMethod r_RCreateTriggerObject_ID_ID_Vector3_Quaternion_String;
		public virtual RMethod RCreateTriggerObject_ID_ID_Vector3_Quaternion_String
		{
			get
			{
				if(r_RCreateTriggerObject_ID_ID_Vector3_Quaternion_String == null)
				{
					r_RCreateTriggerObject_ID_ID_Vector3_Quaternion_String = new(this, "CreateTriggerObject", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(System.String));
					r_RCreateTriggerObject_ID_ID_Vector3_Quaternion_String.SetBelong(this.instance);
				}
				return r_RCreateTriggerObject_ID_ID_Vector3_Quaternion_String;
			}
		}

		/// <summary>
		/// Void OnLoadTriggerObject(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadTriggerObject_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadTriggerObject_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadTriggerObject_Object_ABLoadedArgs == null)
				{
					r_ROnLoadTriggerObject_Object_ABLoadedArgs = new(this, "OnLoadTriggerObject", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadTriggerObject_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadTriggerObject_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void PostTriggerNotify(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RPostTriggerNotify_ID_ID;
		public virtual RMethod RPostTriggerNotify_ID_ID
		{
			get
			{
				if(r_RPostTriggerNotify_ID_ID == null)
				{
					r_RPostTriggerNotify_ID_ID = new(this, "PostTriggerNotify", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RPostTriggerNotify_ID_ID.SetBelong(this.instance);
				}
				return r_RPostTriggerNotify_ID_ID;
			}
		}

		/// <summary>
		/// Void OnEnterArea(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnEnterArea_Object___0__Isb;
		public virtual RMethod ROnEnterArea_Object___0__Isb
		{
			get
			{
				if(r_ROnEnterArea_Object___0__Isb == null)
				{
					r_ROnEnterArea_Object___0__Isb = new(this, "OnEnterArea", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnEnterArea_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnEnterArea_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTriggerAction(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTriggerAction_Object___0__Isb;
		public virtual RMethod ROnTriggerAction_Object___0__Isb
		{
			get
			{
				if(r_ROnTriggerAction_Object___0__Isb == null)
				{
					r_ROnTriggerAction_Object___0__Isb = new(this, "OnTriggerAction", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTriggerAction_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTriggerAction_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTickCount(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTickCount_Object___0__Isb;
		public virtual RMethod ROnTickCount_Object___0__Isb
		{
			get
			{
				if(r_ROnTickCount_Object___0__Isb == null)
				{
					r_ROnTickCount_Object___0__Isb = new(this, "OnTickCount", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTickCount_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTickCount_Object___0__Isb;
			}
		}

		/// <summary>
		/// TriggerAction GetTriggerActionObj(System.String)
		/// </summary>
		protected RMethod r_RGetTriggerActionObj_String;
		public virtual RMethod RGetTriggerActionObj_String
		{
			get
			{
				if(r_RGetTriggerActionObj_String == null)
				{
					r_RGetTriggerActionObj_String = new(this, "GetTriggerActionObj", 0, typeof(System.String));
					r_RGetTriggerActionObj_String.SetBelong(this.instance);
				}
				return r_RGetTriggerActionObj_String;
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


        public RTriggerControler() : base("TriggerControler")
        {
        }

        public RTriggerControler(System.Object instance) : base("TriggerControler")
		{
            SetInstance(instance);
		}

        public RTriggerControler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTriggerControler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadTriggerObjectConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTriggerObjectConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String[] GetTriggerURLs(GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID};
            var ___result = RGetTriggerURLs_ID.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String GetTriggerUrl(GameDefineType.ID  @triggerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triggerId};
            var ___result = RGetTriggerUrl_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CreateTriggerObject(GameDefineType.ID  @sceneID, GameDefineType.ID  @triggerID, UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation, System.String  @animName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID, @triggerID, @position, @rotation, @animName};
            var ___result = RCreateTriggerObject_ID_ID_Vector3_Quaternion_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void PostTriggerNotify(GameDefineType.ID  @idEvent, GameDefineType.ID  @npcID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEvent, @npcID};
            var ___result = RPostTriggerNotify_ID_ID.Invoke(___genericsType, ___parameters);

            
        }





        public virtual TriggerAction GetTriggerActionObj(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTriggerActionObj_String.Invoke(___genericsType, ___parameters);

            return (TriggerAction)___result;
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
