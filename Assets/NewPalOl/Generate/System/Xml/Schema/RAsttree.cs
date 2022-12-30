using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.Asttree
	/// </summary>
    public partial class RAsttree : RMember //
    {

		/// <summary>
		/// System.Collections.ArrayList _fAxisArray
		/// </summary>
		protected RSystem.RCollections.RArrayList r__fAxisArray;
		public virtual RSystem.RCollections.RArrayList R_fAxisArray
		{
			get
			{
				if(r__fAxisArray == null)
				{
					r__fAxisArray = new(this, "_fAxisArray");
					r__fAxisArray.SetBelong(this.instance);
				}
				return r__fAxisArray;
			}
		}

		/// <summary>
		/// System.String _xpathexpr
		/// </summary>
		protected RField r__xpathexpr;
		public virtual RField R_xpathexpr
		{
			get
			{
				if(r__xpathexpr == null)
				{
					r__xpathexpr = new(this, "_xpathexpr");
					r__xpathexpr.SetBelong(this.instance);
				}
				return r__xpathexpr;
			}
		}

		/// <summary>
		/// System.Boolean _isField
		/// </summary>
		protected RField r__isField;
		public virtual RField R_isField
		{
			get
			{
				if(r__isField == null)
				{
					r__isField = new(this, "_isField");
					r__isField.SetBelong(this.instance);
				}
				return r__isField;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager _nsmgr
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r__nsmgr;
		public virtual RSystem.RXml.RXmlNamespaceManager R_nsmgr
		{
			get
			{
				if(r__nsmgr == null)
				{
					r__nsmgr = new(this, "_nsmgr");
					r__nsmgr.SetBelong(this.instance);
				}
				return r__nsmgr;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList SubtreeArray
		/// </summary>
		protected RSystem.RCollections.RArrayList r_SubtreeArray;
		public virtual RSystem.RCollections.RArrayList RSubtreeArray
		{
			get
			{
				if(r_SubtreeArray == null)
				{
					r_SubtreeArray = new(this, "SubtreeArray", -1);
					r_SubtreeArray.SetBelong(this.instance);
				}
				return r_SubtreeArray;
			}
		}

		/// <summary>
		/// Boolean IsNameTest(MS.Internal.Xml.XPath.Axis)
		/// </summary>
		protected static RMethod r_RIsNameTest_Axis;
		public static RMethod RIsNameTest_Axis
		{
			get
			{
				if(r_RIsNameTest_Axis == null)
				{
					r_RIsNameTest_Axis = new( ReleactionUtils.GetType("System.Xml.Schema.Asttree"), "IsNameTest", 0,  ReleactionUtils.GetType("MS.Internal.Xml.XPath.Axis"));
					r_RIsNameTest_Axis.SetBelong(null);
				}
				return r_RIsNameTest_Axis;
			}
		}

		/// <summary>
		/// Boolean IsAttribute(MS.Internal.Xml.XPath.Axis)
		/// </summary>
		protected static RMethod r_RIsAttribute_Axis;
		public static RMethod RIsAttribute_Axis
		{
			get
			{
				if(r_RIsAttribute_Axis == null)
				{
					r_RIsAttribute_Axis = new( ReleactionUtils.GetType("System.Xml.Schema.Asttree"), "IsAttribute", 0,  ReleactionUtils.GetType("MS.Internal.Xml.XPath.Axis"));
					r_RIsAttribute_Axis.SetBelong(null);
				}
				return r_RIsAttribute_Axis;
			}
		}

		/// <summary>
		/// Boolean IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis)
		/// </summary>
		protected static RMethod r_RIsDescendantOrSelf_Axis;
		public static RMethod RIsDescendantOrSelf_Axis
		{
			get
			{
				if(r_RIsDescendantOrSelf_Axis == null)
				{
					r_RIsDescendantOrSelf_Axis = new( ReleactionUtils.GetType("System.Xml.Schema.Asttree"), "IsDescendantOrSelf", 0,  ReleactionUtils.GetType("MS.Internal.Xml.XPath.Axis"));
					r_RIsDescendantOrSelf_Axis.SetBelong(null);
				}
				return r_RIsDescendantOrSelf_Axis;
			}
		}

		/// <summary>
		/// Boolean IsSelf(MS.Internal.Xml.XPath.Axis)
		/// </summary>
		protected static RMethod r_RIsSelf_Axis;
		public static RMethod RIsSelf_Axis
		{
			get
			{
				if(r_RIsSelf_Axis == null)
				{
					r_RIsSelf_Axis = new( ReleactionUtils.GetType("System.Xml.Schema.Asttree"), "IsSelf", 0,  ReleactionUtils.GetType("MS.Internal.Xml.XPath.Axis"));
					r_RIsSelf_Axis.SetBelong(null);
				}
				return r_RIsSelf_Axis;
			}
		}

		/// <summary>
		/// Void CompileXPath(System.String, Boolean, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RCompileXPath_String_Boolean_XmlNamespaceManager;
		public virtual RMethod RCompileXPath_String_Boolean_XmlNamespaceManager
		{
			get
			{
				if(r_RCompileXPath_String_Boolean_XmlNamespaceManager == null)
				{
					r_RCompileXPath_String_Boolean_XmlNamespaceManager = new(this, "CompileXPath", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Xml.XmlNamespaceManager));
					r_RCompileXPath_String_Boolean_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RCompileXPath_String_Boolean_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Void SetURN(MS.Internal.Xml.XPath.Axis, System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RSetURN_Axis_XmlNamespaceManager;
		public virtual RMethod RSetURN_Axis_XmlNamespaceManager
		{
			get
			{
				if(r_RSetURN_Axis_XmlNamespaceManager == null)
				{
					r_RSetURN_Axis_XmlNamespaceManager = new(this, "SetURN", 0,  ReleactionUtils.GetType("MS.Internal.Xml.XPath.Axis"), typeof(System.Xml.XmlNamespaceManager));
					r_RSetURN_Axis_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RSetURN_Axis_XmlNamespaceManager;
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


        public RAsttree() : base("System.Xml.Schema.Asttree")
        {
        }

        public RAsttree(System.Object instance) : base("System.Xml.Schema.Asttree")
		{
            SetInstance(instance);
		}

        public RAsttree(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsttree(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }





        public virtual void CompileXPath(System.String  @xPath, System.Boolean  @isField, System.Xml.XmlNamespaceManager  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xPath, @isField, @nsmgr};
            var ___result = RCompileXPath_String_Boolean_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            
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
