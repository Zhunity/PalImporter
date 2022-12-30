using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PrestigeInfoXMLReader
	/// </summary>
    public partial class RPrestigeInfoXMLReader : RMember //
    {

		/// <summary>
		/// System.String GetKeyName()
		/// </summary>
		protected RMethod r_RGetKeyName;
		public virtual RMethod RGetKeyName
		{
			get
			{
				if(r_RGetKeyName == null)
				{
					r_RGetKeyName = new(this, "GetKeyName", 0);
					r_RGetKeyName.SetBelong(this.instance);
				}
				return r_RGetKeyName;
			}
		}

		/// <summary>
		/// Void OnGetKeyValue(#u.#N7)
		/// </summary>
		protected RMethod r_ROnGetKeyValue___0__N7;
		public virtual RMethod ROnGetKeyValue___0__N7
		{
			get
			{
				if(r_ROnGetKeyValue___0__N7 == null)
				{
					r_ROnGetKeyValue___0__N7 = new(this, "OnGetKeyValue", 0,  ReleactionUtils.GetType("#u.#N7"));
					r_ROnGetKeyValue___0__N7.SetBelong(this.instance);
				}
				return r_ROnGetKeyValue___0__N7;
			}
		}

		/// <summary>
		/// Void OnGetRootNodeAttrbutes(System.Xml.XmlAttributeCollection)
		/// </summary>
		protected RMethod r_ROnGetRootNodeAttrbutes_XmlAttributeCollection;
		public virtual RMethod ROnGetRootNodeAttrbutes_XmlAttributeCollection
		{
			get
			{
				if(r_ROnGetRootNodeAttrbutes_XmlAttributeCollection == null)
				{
					r_ROnGetRootNodeAttrbutes_XmlAttributeCollection = new(this, "OnGetRootNodeAttrbutes", 0, typeof(System.Xml.XmlAttributeCollection));
					r_ROnGetRootNodeAttrbutes_XmlAttributeCollection.SetBelong(this.instance);
				}
				return r_ROnGetRootNodeAttrbutes_XmlAttributeCollection;
			}
		}

		/// <summary>
		/// KeyValueContent LoadXml(System.String)
		/// </summary>
		protected RMethod r_RLoadXml_String;
		public virtual RMethod RLoadXml_String
		{
			get
			{
				if(r_RLoadXml_String == null)
				{
					r_RLoadXml_String = new(this, "LoadXml", 0, typeof(System.String));
					r_RLoadXml_String.SetBelong(this.instance);
				}
				return r_RLoadXml_String;
			}
		}

		/// <summary>
		/// KeyValueContent LoadXml(UnityEngine.TextAsset)
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
		/// KeyValueContent LoadXml(System.Xml.XmlDocument, System.Xml.XmlNode ByRef)
		/// </summary>
		protected RMethod r_RLoadXml_XmlDocument_Ref_XmlNode;
		public virtual RMethod RLoadXml_XmlDocument_Ref_XmlNode
		{
			get
			{
				if(r_RLoadXml_XmlDocument_Ref_XmlNode == null)
				{
					r_RLoadXml_XmlDocument_Ref_XmlNode = new(this, "LoadXml", 0, typeof(System.Xml.XmlDocument), typeof(System.Xml.XmlNode).MakeByRefType());
					r_RLoadXml_XmlDocument_Ref_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadXml_XmlDocument_Ref_XmlNode;
			}
		}

		/// <summary>
		/// KeyValueContent LoadContentFromConfigHold(KeyValueConfigHold)
		/// </summary>
		protected RMethod r_RLoadContentFromConfigHold_KeyValueConfigHold;
		public virtual RMethod RLoadContentFromConfigHold_KeyValueConfigHold
		{
			get
			{
				if(r_RLoadContentFromConfigHold_KeyValueConfigHold == null)
				{
					r_RLoadContentFromConfigHold_KeyValueConfigHold = new(this, "LoadContentFromConfigHold", 0, typeof(KeyValueConfigHold));
					r_RLoadContentFromConfigHold_KeyValueConfigHold.SetBelong(this.instance);
				}
				return r_RLoadContentFromConfigHold_KeyValueConfigHold;
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


        public RPrestigeInfoXMLReader() : base("PrestigeInfoXMLReader")
        {
        }

        public RPrestigeInfoXMLReader(System.Object instance) : base("PrestigeInfoXMLReader")
		{
            SetInstance(instance);
		}

        public RPrestigeInfoXMLReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPrestigeInfoXMLReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String GetKeyName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void OnGetRootNodeAttrbutes(System.Xml.XmlAttributeCollection  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = ROnGetRootNodeAttrbutes_XmlAttributeCollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object LoadXml(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadXml(UnityEngine.TextAsset  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadXml(System.Xml.XmlDocument  @xml, ref System.Xml.XmlNode  @root)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml, @root};
            var ___result = RLoadXml_XmlDocument_Ref_XmlNode.Invoke(___genericsType, ___parameters);
			root = (System.Xml.XmlNode)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Object LoadContentFromConfigHold(KeyValueConfigHold  @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config};
            var ___result = RLoadContentFromConfigHold_KeyValueConfigHold.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
