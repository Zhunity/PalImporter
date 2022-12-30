using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#f8
	/// </summary>
    public partial class R__0__f8 : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
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
		/// WindowSettingMap LoadXml(UnityEngine.TextAsset)
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
		/// WindowSettingMap LoadXml(System.String)
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
		/// #u.#O7 #c8(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_R__0__c8_XmlNode;
		public virtual RMethod R__0__c8_XmlNode
		{
			get
			{
				if(r_R__0__c8_XmlNode == null)
				{
					r_R__0__c8_XmlNode = new(this, "#c8", 0, typeof(System.Xml.XmlNode));
					r_R__0__c8_XmlNode.SetBelong(this.instance);
				}
				return r_R__0__c8_XmlNode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #07(System.String)
		/// </summary>
		protected RMethod r_R__0__07_String;
		public virtual RMethod R__0__07_String
		{
			get
			{
				if(r_R__0__07_String == null)
				{
					r_R__0__07_String = new(this, "#07", 0, typeof(System.String));
					r_R__0__07_String.SetBelong(this.instance);
				}
				return r_R__0__07_String;
			}
		}

		/// <summary>
		/// #u.#QHb #d8(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_R__0__d8_XmlNode;
		public virtual RMethod R__0__d8_XmlNode
		{
			get
			{
				if(r_R__0__d8_XmlNode == null)
				{
					r_R__0__d8_XmlNode = new(this, "#d8", 0, typeof(System.Xml.XmlNode));
					r_R__0__d8_XmlNode.SetBelong(this.instance);
				}
				return r_R__0__d8_XmlNode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #e8(UnityEngine.Vector2, WindowMoveDir, Single)
		/// </summary>
		protected static RMethod r_R__0__e8_Vector2_WindowMoveDir_Single;
		public static RMethod R__0__e8_Vector2_WindowMoveDir_Single
		{
			get
			{
				if(r_R__0__e8_Vector2_WindowMoveDir_Single == null)
				{
					r_R__0__e8_Vector2_WindowMoveDir_Single = new( ReleactionUtils.GetType("#u.#f8"), "#e8", 0, typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("WindowMoveDir"), typeof(System.Single));
					r_R__0__e8_Vector2_WindowMoveDir_Single.SetBelong(null);
				}
				return r_R__0__e8_Vector2_WindowMoveDir_Single;
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


        public R__0__f8() : base("#u.#f8")
        {
        }

        public R__0__f8(System.Object instance) : base("#u.#f8")
		{
            SetInstance(instance);
		}

        public R__0__f8(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__f8(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LoadXml(UnityEngine.TextAsset  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadXml(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadXml_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__c8(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = R__0__c8_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual UnityEngine.Vector2 __0__07(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = R__0__07_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Object __0__d8(System.Xml.XmlNode  @animNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animNode};
            var ___result = R__0__d8_XmlNode.Invoke(___genericsType, ___parameters);

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
