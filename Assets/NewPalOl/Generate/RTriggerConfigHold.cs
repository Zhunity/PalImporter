using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TriggerConfigHold
	/// </summary>
    public partial class RTriggerConfigHold : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[TriggerObjectInfo] m_TriggerList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTriggerObjectInfo> r_m_TriggerList;
		public virtual RSystem.RCollections.RGeneric.RList<RTriggerObjectInfo> Rm_TriggerList
		{
			get
			{
				if(r_m_TriggerList == null)
				{
					r_m_TriggerList = new(this, "m_TriggerList");
					r_m_TriggerList.SetBelong(this.instance);
				}
				return r_m_TriggerList;
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
					r_RLoadXml_Object = new(typeof(TriggerConfigHold), "LoadXml", 0, typeof(System.Object));
					r_RLoadXml_Object.SetBelong(null);
				}
				return r_RLoadXml_Object;
			}
		}

		/// <summary>
		/// TriggerObjectInfo ParseTriggerObject(System.Xml.XmlNode)
		/// </summary>
		protected static RMethod r_RParseTriggerObject_XmlNode;
		public static RMethod RParseTriggerObject_XmlNode
		{
			get
			{
				if(r_RParseTriggerObject_XmlNode == null)
				{
					r_RParseTriggerObject_XmlNode = new(typeof(TriggerConfigHold), "ParseTriggerObject", 0, typeof(System.Xml.XmlNode));
					r_RParseTriggerObject_XmlNode.SetBelong(null);
				}
				return r_RParseTriggerObject_XmlNode;
			}
		}

		/// <summary>
		/// Void SetPropertyValue(System.Object, System.Reflection.FieldInfo, System.String)
		/// </summary>
		protected static RMethod r_RSetPropertyValue_Object_FieldInfo_String;
		public static RMethod RSetPropertyValue_Object_FieldInfo_String
		{
			get
			{
				if(r_RSetPropertyValue_Object_FieldInfo_String == null)
				{
					r_RSetPropertyValue_Object_FieldInfo_String = new(typeof(TriggerConfigHold), "SetPropertyValue", 0, typeof(System.Object), typeof(System.Reflection.FieldInfo), typeof(System.String));
					r_RSetPropertyValue_Object_FieldInfo_String.SetBelong(null);
				}
				return r_RSetPropertyValue_Object_FieldInfo_String;
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


        public RTriggerConfigHold() : base("TriggerConfigHold")
        {
        }

        public RTriggerConfigHold(System.Object instance) : base("TriggerConfigHold")
		{
            SetInstance(instance);
		}

        public RTriggerConfigHold(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTriggerConfigHold(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.ScriptableObject LoadXml(System.Object  @textObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textObj};
            var ___result = RLoadXml_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static TriggerObjectInfo ParseTriggerObject(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RParseTriggerObject_XmlNode.Invoke(___genericsType, ___parameters);

            return (TriggerObjectInfo)___result;
        }


        public static void SetPropertyValue(System.Object  @instance, System.Reflection.FieldInfo  @prop, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instance, @prop, @value};
            var ___result = RSetPropertyValue_Object_FieldInfo_String.Invoke(___genericsType, ___parameters);

            
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
