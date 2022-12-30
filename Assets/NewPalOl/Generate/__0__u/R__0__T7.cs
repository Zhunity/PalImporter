using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#T7
	/// </summary>
    public partial class R__0__T7 : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#T7"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("#u.#T7"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// #u.#EUc LoadXml(UnityEngine.TextAsset)
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
		/// #u.#EUc[] LoadXml(UnityEngine.TextAsset, System.String[])
		/// </summary>
		protected RMethod r_RLoadXml_TextAsset_StringArray;
		public virtual RMethod RLoadXml_TextAsset_StringArray
		{
			get
			{
				if(r_RLoadXml_TextAsset_StringArray == null)
				{
					r_RLoadXml_TextAsset_StringArray = new(this, "LoadXml", 0, typeof(UnityEngine.TextAsset), typeof(System.String).MakeArrayType());
					r_RLoadXml_TextAsset_StringArray.SetBelong(this.instance);
				}
				return r_RLoadXml_TextAsset_StringArray;
			}
		}

		/// <summary>
		/// Void #R7(#u.#EUc ByRef, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_R__0__R7_Ref___0__EUc_XmlNode;
		public virtual RMethod R__0__R7_Ref___0__EUc_XmlNode
		{
			get
			{
				if(r_R__0__R7_Ref___0__EUc_XmlNode == null)
				{
					r_R__0__R7_Ref___0__EUc_XmlNode = new(this, "#R7", 0,  ReleactionUtils.GetType("#u.#EUc").MakeByRefType(), typeof(System.Xml.XmlNode));
					r_R__0__R7_Ref___0__EUc_XmlNode.SetBelong(this.instance);
				}
				return r_R__0__R7_Ref___0__EUc_XmlNode;
			}
		}

		/// <summary>
		/// #u.#J7 #S7(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_R__0__S7_XmlNode;
		public virtual RMethod R__0__S7_XmlNode
		{
			get
			{
				if(r_R__0__S7_XmlNode == null)
				{
					r_R__0__S7_XmlNode = new(this, "#S7", 0, typeof(System.Xml.XmlNode));
					r_R__0__S7_XmlNode.SetBelong(this.instance);
				}
				return r_R__0__S7_XmlNode;
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


        public R__0__T7() : base("#u.#T7")
        {
        }

        public R__0__T7(System.Object instance) : base("#u.#T7")
		{
            SetInstance(instance);
		}

        public R__0__T7(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__T7(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LoadXml(UnityEngine.TextAsset  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadXml(UnityEngine.TextAsset  @text, System.String[]  @templateTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @templateTypes};
            var ___result = RLoadXml_TextAsset_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Object __0__S7(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = R__0__S7_XmlNode.Invoke(___genericsType, ___parameters);

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
