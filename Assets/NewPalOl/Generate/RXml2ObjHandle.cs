using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Xml2ObjHandle
	/// </summary>
    public partial class RXml2ObjHandle : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,Xml2ObjHandle+#Y] #a
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RXml2ObjHandle.R__0__Y> r___0__a;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RXml2ObjHandle.R__0__Y> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(Xml2ObjHandle), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected static RMethod r_RClear;
		public static RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(typeof(Xml2ObjHandle), "Clear", 0);
					r_RClear.SetBelong(null);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Reflection.FieldInfo] GetParserField(System.String, System.Type ByRef)
		/// </summary>
		protected static RMethod r_RGetParserField_String_Out_Type;
		public static RMethod RGetParserField_String_Out_Type
		{
			get
			{
				if(r_RGetParserField_String_Out_Type == null)
				{
					r_RGetParserField_String_Out_Type = new(typeof(Xml2ObjHandle), "GetParserField", 0, typeof(System.String), typeof(System.Type).MakeByRefType());
					r_RGetParserField_String_Out_Type.SetBelong(null);
				}
				return r_RGetParserField_String_Out_Type;
			}
		}

		/// <summary>
		/// System.Object GetCurrNodeObject(System.Xml.XmlNode)
		/// </summary>
		protected static RMethod r_RGetCurrNodeObject_XmlNode;
		public static RMethod RGetCurrNodeObject_XmlNode
		{
			get
			{
				if(r_RGetCurrNodeObject_XmlNode == null)
				{
					r_RGetCurrNodeObject_XmlNode = new(typeof(Xml2ObjHandle), "GetCurrNodeObject", 0, typeof(System.Xml.XmlNode));
					r_RGetCurrNodeObject_XmlNode.SetBelong(null);
				}
				return r_RGetCurrNodeObject_XmlNode;
			}
		}

		/// <summary>
		/// Int32 #P(System.Xml.XmlNode, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__P_XmlNode_ParserXmlAttribute;
		public static RMethod R__0__P_XmlNode_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__P_XmlNode_ParserXmlAttribute == null)
				{
					r_R__0__P_XmlNode_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#P", 0, typeof(System.Xml.XmlNode), typeof(ParserXmlAttribute));
					r_R__0__P_XmlNode_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__P_XmlNode_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// Single #Q(System.Xml.XmlNode, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__Q_XmlNode_ParserXmlAttribute;
		public static RMethod R__0__Q_XmlNode_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__Q_XmlNode_ParserXmlAttribute == null)
				{
					r_R__0__Q_XmlNode_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#Q", 0, typeof(System.Xml.XmlNode), typeof(ParserXmlAttribute));
					r_R__0__Q_XmlNode_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__Q_XmlNode_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// Int64 #R(System.Xml.XmlNode, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__R_XmlNode_ParserXmlAttribute;
		public static RMethod R__0__R_XmlNode_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__R_XmlNode_ParserXmlAttribute == null)
				{
					r_R__0__R_XmlNode_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#R", 0, typeof(System.Xml.XmlNode), typeof(ParserXmlAttribute));
					r_R__0__R_XmlNode_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__R_XmlNode_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// Boolean #S(System.Xml.XmlNode, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__S_XmlNode_ParserXmlAttribute;
		public static RMethod R__0__S_XmlNode_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__S_XmlNode_ParserXmlAttribute == null)
				{
					r_R__0__S_XmlNode_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#S", 0, typeof(System.Xml.XmlNode), typeof(ParserXmlAttribute));
					r_R__0__S_XmlNode_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__S_XmlNode_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// System.Object #T(System.Xml.XmlNode, System.Type, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__T_XmlNode_Type_ParserXmlAttribute;
		public static RMethod R__0__T_XmlNode_Type_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__T_XmlNode_Type_ParserXmlAttribute == null)
				{
					r_R__0__T_XmlNode_Type_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#T", 0, typeof(System.Xml.XmlNode), typeof(System.Type), typeof(ParserXmlAttribute));
					r_R__0__T_XmlNode_Type_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__T_XmlNode_Type_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #U(System.Xml.XmlNode, System.Type, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__U_XmlNode_Type_ParserXmlAttribute;
		public static RMethod R__0__U_XmlNode_Type_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__U_XmlNode_Type_ParserXmlAttribute == null)
				{
					r_R__0__U_XmlNode_Type_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#U", 0, typeof(System.Xml.XmlNode), typeof(System.Type), typeof(ParserXmlAttribute));
					r_R__0__U_XmlNode_Type_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__U_XmlNode_Type_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 #V(System.Xml.XmlNode, System.Type, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__V_XmlNode_Type_ParserXmlAttribute;
		public static RMethod R__0__V_XmlNode_Type_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__V_XmlNode_Type_ParserXmlAttribute == null)
				{
					r_R__0__V_XmlNode_Type_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#V", 0, typeof(System.Xml.XmlNode), typeof(System.Type), typeof(ParserXmlAttribute));
					r_R__0__V_XmlNode_Type_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__V_XmlNode_Type_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Color #W(System.Xml.XmlNode, System.Type, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__W_XmlNode_Type_ParserXmlAttribute;
		public static RMethod R__0__W_XmlNode_Type_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__W_XmlNode_Type_ParserXmlAttribute == null)
				{
					r_R__0__W_XmlNode_Type_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#W", 0, typeof(System.Xml.XmlNode), typeof(System.Type), typeof(ParserXmlAttribute));
					r_R__0__W_XmlNode_Type_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__W_XmlNode_Type_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// System.String #X(System.Xml.XmlNode, ParserXmlAttribute)
		/// </summary>
		protected static RMethod r_R__0__X_XmlNode_ParserXmlAttribute;
		public static RMethod R__0__X_XmlNode_ParserXmlAttribute
		{
			get
			{
				if(r_R__0__X_XmlNode_ParserXmlAttribute == null)
				{
					r_R__0__X_XmlNode_ParserXmlAttribute = new(typeof(Xml2ObjHandle), "#X", 0, typeof(System.Xml.XmlNode), typeof(ParserXmlAttribute));
					r_R__0__X_XmlNode_ParserXmlAttribute.SetBelong(null);
				}
				return r_R__0__X_XmlNode_ParserXmlAttribute;
			}
		}

		/// <summary>
		/// Single[] GetFloatArray(System.String)
		/// </summary>
		protected static RMethod r_RGetFloatArray_String;
		public static RMethod RGetFloatArray_String
		{
			get
			{
				if(r_RGetFloatArray_String == null)
				{
					r_RGetFloatArray_String = new(typeof(Xml2ObjHandle), "GetFloatArray", 0, typeof(System.String));
					r_RGetFloatArray_String.SetBelong(null);
				}
				return r_RGetFloatArray_String;
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


        public RXml2ObjHandle() : base("Xml2ObjHandle")
        {
        }

        public RXml2ObjHandle(System.Object instance) : base("Xml2ObjHandle")
		{
            SetInstance(instance);
		}

        public RXml2ObjHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXml2ObjHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.Dictionary<System.String, System.Reflection.FieldInfo> GetParserField(System.String  @classParserName, out System.Type  @objType)
        {
			objType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@classParserName, @objType};
            var ___result = RGetParserField_String_Out_Type.Invoke(___genericsType, ___parameters);
			objType = (System.Type)___parameters[1];

            return (System.Collections.Generic.Dictionary<System.String, System.Reflection.FieldInfo>)___result;
        }


        public static System.Object GetCurrNodeObject(System.Xml.XmlNode  @xmlNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode};
            var ___result = RGetCurrNodeObject_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Int32 __0__P(System.Xml.XmlNode  @xmlNode, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @attr};
            var ___result = R__0__P_XmlNode_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Single __0__Q(System.Xml.XmlNode  @xmlNode, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @attr};
            var ___result = R__0__Q_XmlNode_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Int64 __0__R(System.Xml.XmlNode  @xmlNode, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @attr};
            var ___result = R__0__R_XmlNode_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Boolean __0__S(System.Xml.XmlNode  @xmlNode, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @attr};
            var ___result = R__0__S_XmlNode_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object __0__T(System.Xml.XmlNode  @xmlNode, System.Type  @enumType, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @enumType, @attr};
            var ___result = R__0__T_XmlNode_Type_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static UnityEngine.Vector2 __0__U(System.Xml.XmlNode  @xmlNode, System.Type  @enumType, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @enumType, @attr};
            var ___result = R__0__U_XmlNode_Type_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector3 __0__V(System.Xml.XmlNode  @xmlNode, System.Type  @enumType, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @enumType, @attr};
            var ___result = R__0__V_XmlNode_Type_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Color __0__W(System.Xml.XmlNode  @xmlNode, System.Type  @enumType, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @enumType, @attr};
            var ___result = R__0__W_XmlNode_Type_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static System.String __0__X(System.Xml.XmlNode  @xmlNode, ParserXmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlNode, @attr};
            var ___result = R__0__X_XmlNode_ParserXmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Single[] GetFloatArray(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RGetFloatArray_String.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
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
