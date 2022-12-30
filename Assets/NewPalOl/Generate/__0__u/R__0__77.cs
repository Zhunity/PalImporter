using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#77
	/// </summary>
    public partial class R__0__77 : RMember //
    {

		/// <summary>
		/// #u.#77+#gOb #a
		/// </summary>
		protected R__0__u.R__0__77.R__0__gOb r___0__a;
		public virtual R__0__u.R__0__77.R__0__gOb R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UITextColorContent] LoadXml(UnityEngine.TextAsset)
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
		/// UITextColorContent #57(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_R__0__57_XmlNode;
		public virtual RMethod R__0__57_XmlNode
		{
			get
			{
				if(r_R__0__57_XmlNode == null)
				{
					r_R__0__57_XmlNode = new(this, "#57", 0, typeof(System.Xml.XmlNode));
					r_R__0__57_XmlNode.SetBelong(this.instance);
				}
				return r_R__0__57_XmlNode;
			}
		}

		/// <summary>
		/// Void #67(System.String, UITextColorContent ByRef)
		/// </summary>
		protected RMethod r_R__0__67_String_Ref_UITextColorContent;
		public virtual RMethod R__0__67_String_Ref_UITextColorContent
		{
			get
			{
				if(r_R__0__67_String_Ref_UITextColorContent == null)
				{
					r_R__0__67_String_Ref_UITextColorContent = new(this, "#67", 0, typeof(System.String),  ReleactionUtils.GetType("UITextColorContent").MakeByRefType());
					r_R__0__67_String_Ref_UITextColorContent.SetBelong(this.instance);
				}
				return r_R__0__67_String_Ref_UITextColorContent;
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


        public R__0__77() : base("#u.#77")
        {
        }

        public R__0__77(System.Object instance) : base("#u.#77")
		{
            SetInstance(instance);
		}

        public R__0__77(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__77(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LoadXml(UnityEngine.TextAsset  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__57(System.Xml.XmlNode  @colorNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorNode};
            var ___result = R__0__57_XmlNode.Invoke(___genericsType, ___parameters);

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
