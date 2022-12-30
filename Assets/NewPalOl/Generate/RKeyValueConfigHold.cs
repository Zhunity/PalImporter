using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// KeyValueConfigHold
	/// </summary>
    public partial class RKeyValueConfigHold : RMember //
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
					r_ROOT_NAME = new(typeof(KeyValueConfigHold), "ROOT_NAME");
					r_ROOT_NAME.SetBelong(null);
				}
				return r_ROOT_NAME;
			}
		}

		/// <summary>
		/// System.String ID_NAME
		/// </summary>
		protected static RField r_ID_NAME;
		public static RField RID_NAME
		{
			get
			{
				if(r_ID_NAME == null)
				{
					r_ID_NAME = new(typeof(KeyValueConfigHold), "ID_NAME");
					r_ID_NAME.SetBelong(null);
				}
				return r_ID_NAME;
			}
		}

		/// <summary>
		/// System.String TYPE_NAME
		/// </summary>
		protected static RField r_TYPE_NAME;
		public static RField RTYPE_NAME
		{
			get
			{
				if(r_TYPE_NAME == null)
				{
					r_TYPE_NAME = new(typeof(KeyValueConfigHold), "TYPE_NAME");
					r_TYPE_NAME.SetBelong(null);
				}
				return r_TYPE_NAME;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[KeyValueListElem] m_KeyValueList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RKeyValueListElem> r_m_KeyValueList;
		public virtual RSystem.RCollections.RGeneric.RList<RKeyValueListElem> Rm_KeyValueList
		{
			get
			{
				if(r_m_KeyValueList == null)
				{
					r_m_KeyValueList = new(this, "m_KeyValueList");
					r_m_KeyValueList.SetBelong(this.instance);
				}
				return r_m_KeyValueList;
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
					r_RLoadXml_Object = new(typeof(KeyValueConfigHold), "LoadXml", 0, typeof(System.Object));
					r_RLoadXml_Object.SetBelong(null);
				}
				return r_RLoadXml_Object;
			}
		}

		/// <summary>
		/// KeyValueListElem ParseKeyValue(System.Xml.XmlNode)
		/// </summary>
		protected static RMethod r_RParseKeyValue_XmlNode;
		public static RMethod RParseKeyValue_XmlNode
		{
			get
			{
				if(r_RParseKeyValue_XmlNode == null)
				{
					r_RParseKeyValue_XmlNode = new(typeof(KeyValueConfigHold), "ParseKeyValue", 0, typeof(System.Xml.XmlNode));
					r_RParseKeyValue_XmlNode.SetBelong(null);
				}
				return r_RParseKeyValue_XmlNode;
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


        public RKeyValueConfigHold() : base("KeyValueConfigHold")
        {
        }

        public RKeyValueConfigHold(System.Object instance) : base("KeyValueConfigHold")
		{
            SetInstance(instance);
		}

        public RKeyValueConfigHold(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyValueConfigHold(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.ScriptableObject LoadXml(System.Object  @textObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textObj};
            var ___result = RLoadXml_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static KeyValueListElem ParseKeyValue(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RParseKeyValue_XmlNode.Invoke(___genericsType, ___parameters);

            return (KeyValueListElem)___result;
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
