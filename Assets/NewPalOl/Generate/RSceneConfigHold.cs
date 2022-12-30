using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneConfigHold
	/// </summary>
    public partial class RSceneConfigHold : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[SceneLogicConfig] mConfig_Store
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneLogicConfig> r_mConfig_Store;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneLogicConfig> RmConfig_Store
		{
			get
			{
				if(r_mConfig_Store == null)
				{
					r_mConfig_Store = new(this, "mConfig_Store");
					r_mConfig_Store.SetBelong(this.instance);
				}
				return r_mConfig_Store;
			}
		}

		/// <summary>
		/// System.String mErrorLog
		/// </summary>
		protected static RField r_mErrorLog;
		public static RField RmErrorLog
		{
			get
			{
				if(r_mErrorLog == null)
				{
					r_mErrorLog = new(typeof(SceneConfigHold), "mErrorLog");
					r_mErrorLog.SetBelong(null);
				}
				return r_mErrorLog;
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
		/// UnityEngine.ScriptableObject LoadXml(System.Object)
		/// </summary>
		protected static RMethod r_RLoadXml_Object;
		public static RMethod RLoadXml_Object
		{
			get
			{
				if(r_RLoadXml_Object == null)
				{
					r_RLoadXml_Object = new(typeof(SceneConfigHold), "LoadXml", 0, typeof(System.Object));
					r_RLoadXml_Object.SetBelong(null);
				}
				return r_RLoadXml_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Color ParseRGBA(System.String)
		/// </summary>
		protected static RMethod r_RParseRGBA_String;
		public static RMethod RParseRGBA_String
		{
			get
			{
				if(r_RParseRGBA_String == null)
				{
					r_RParseRGBA_String = new(typeof(SceneConfigHold), "ParseRGBA", 0, typeof(System.String));
					r_RParseRGBA_String.SetBelong(null);
				}
				return r_RParseRGBA_String;
			}
		}

		/// <summary>
		/// SceneLogicConfig ParseSceneConfigNode(System.Xml.XmlNode)
		/// </summary>
		protected static RMethod r_RParseSceneConfigNode_XmlNode;
		public static RMethod RParseSceneConfigNode_XmlNode
		{
			get
			{
				if(r_RParseSceneConfigNode_XmlNode == null)
				{
					r_RParseSceneConfigNode_XmlNode = new(typeof(SceneConfigHold), "ParseSceneConfigNode", 0, typeof(System.Xml.XmlNode));
					r_RParseSceneConfigNode_XmlNode.SetBelong(null);
				}
				return r_RParseSceneConfigNode_XmlNode;
			}
		}

		/// <summary>
		/// SceneSoundConfig ParseSceneSoundConfigNode(System.Xml.XmlNode, Boolean)
		/// </summary>
		protected static RMethod r_RParseSceneSoundConfigNode_XmlNode_Boolean;
		public static RMethod RParseSceneSoundConfigNode_XmlNode_Boolean
		{
			get
			{
				if(r_RParseSceneSoundConfigNode_XmlNode_Boolean == null)
				{
					r_RParseSceneSoundConfigNode_XmlNode_Boolean = new(typeof(SceneConfigHold), "ParseSceneSoundConfigNode", 0, typeof(System.Xml.XmlNode), typeof(System.Boolean));
					r_RParseSceneSoundConfigNode_XmlNode_Boolean.SetBelong(null);
				}
				return r_RParseSceneSoundConfigNode_XmlNode_Boolean;
			}
		}

		/// <summary>
		/// BattleSpot ParseBattleSpotConfigNode(System.Xml.XmlNode)
		/// </summary>
		protected static RMethod r_RParseBattleSpotConfigNode_XmlNode;
		public static RMethod RParseBattleSpotConfigNode_XmlNode
		{
			get
			{
				if(r_RParseBattleSpotConfigNode_XmlNode == null)
				{
					r_RParseBattleSpotConfigNode_XmlNode = new(typeof(SceneConfigHold), "ParseBattleSpotConfigNode", 0, typeof(System.Xml.XmlNode));
					r_RParseBattleSpotConfigNode_XmlNode.SetBelong(null);
				}
				return r_RParseBattleSpotConfigNode_XmlNode;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
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


        public RSceneConfigHold() : base("SceneConfigHold")
        {
        }

        public RSceneConfigHold(System.Object instance) : base("SceneConfigHold")
		{
            SetInstance(instance);
		}

        public RSceneConfigHold(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneConfigHold(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.ScriptableObject LoadXml(System.Object  @textObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textObj};
            var ___result = RLoadXml_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static UnityEngine.Color ParseRGBA(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RParseRGBA_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static SceneLogicConfig ParseSceneConfigNode(System.Xml.XmlNode  @aScene)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aScene};
            var ___result = RParseSceneConfigNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (SceneLogicConfig)___result;
        }


        public static SceneSoundConfig ParseSceneSoundConfigNode(System.Xml.XmlNode  @soundNode, System.Boolean  @isCameraSound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@soundNode, @isCameraSound};
            var ___result = RParseSceneSoundConfigNode_XmlNode_Boolean.Invoke(___genericsType, ___parameters);

            return (SceneSoundConfig)___result;
        }


        public static BattleSpot ParseBattleSpotConfigNode(System.Xml.XmlNode  @battleNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@battleNode};
            var ___result = RParseBattleSpotConfigNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (BattleSpot)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
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
