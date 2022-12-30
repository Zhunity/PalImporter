using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RXPath
{
	/// <summary>
	/// System.Xml.XPath.XPathExpression
	/// </summary>
    public partial class RXPathExpression : RMember //
    {

		/// <summary>
		/// System.String Expression
		/// </summary>
		protected RProperty r_Expression;
		public virtual RProperty RExpression
		{
			get
			{
				if(r_Expression == null)
				{
					r_Expression = new(this, "Expression", -1);
					r_Expression.SetBelong(this.instance);
				}
				return r_Expression;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathResultType ReturnType
		/// </summary>
		protected RProperty r_ReturnType;
		public virtual RProperty ReturnType
		{
			get
			{
				if(r_ReturnType == null)
				{
					r_ReturnType = new(this, "ReturnType", -1);
					r_ReturnType.SetBelong(this.instance);
				}
				return r_ReturnType;
			}
		}

		/// <summary>
		/// Void AddSort(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_RAddSort_Object_IComparer;
		public virtual RMethod RAddSort_Object_IComparer
		{
			get
			{
				if(r_RAddSort_Object_IComparer == null)
				{
					r_RAddSort_Object_IComparer = new(this, "AddSort", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_RAddSort_Object_IComparer.SetBelong(this.instance);
				}
				return r_RAddSort_Object_IComparer;
			}
		}

		/// <summary>
		/// Void AddSort(System.Object, System.Xml.XPath.XmlSortOrder, System.Xml.XPath.XmlCaseOrder, System.String, System.Xml.XPath.XmlDataType)
		/// </summary>
		protected RMethod r_RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType;
		public virtual RMethod RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType
		{
			get
			{
				if(r_RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType == null)
				{
					r_RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType = new(this, "AddSort", 0, typeof(System.Object), typeof(System.Xml.XPath.XmlSortOrder), typeof(System.Xml.XPath.XmlCaseOrder), typeof(System.String), typeof(System.Xml.XPath.XmlDataType));
					r_RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType.SetBelong(this.instance);
				}
				return r_RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathExpression Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void SetContext(System.Xml.XmlNamespaceManager)
		/// </summary>
		protected RMethod r_RSetContext_XmlNamespaceManager;
		public virtual RMethod RSetContext_XmlNamespaceManager
		{
			get
			{
				if(r_RSetContext_XmlNamespaceManager == null)
				{
					r_RSetContext_XmlNamespaceManager = new(this, "SetContext", 0, typeof(System.Xml.XmlNamespaceManager));
					r_RSetContext_XmlNamespaceManager.SetBelong(this.instance);
				}
				return r_RSetContext_XmlNamespaceManager;
			}
		}

		/// <summary>
		/// Void SetContext(System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RSetContext_IXmlNamespaceResolver;
		public virtual RMethod RSetContext_IXmlNamespaceResolver
		{
			get
			{
				if(r_RSetContext_IXmlNamespaceResolver == null)
				{
					r_RSetContext_IXmlNamespaceResolver = new(this, "SetContext", 0, typeof(System.Xml.IXmlNamespaceResolver));
					r_RSetContext_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RSetContext_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathExpression Compile(System.String)
		/// </summary>
		protected static RMethod r_RCompile_String;
		public static RMethod RCompile_String
		{
			get
			{
				if(r_RCompile_String == null)
				{
					r_RCompile_String = new(typeof(System.Xml.XPath.XPathExpression), "Compile", 0, typeof(System.String));
					r_RCompile_String.SetBelong(null);
				}
				return r_RCompile_String;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathExpression Compile(System.String, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected static RMethod r_RCompile_String_IXmlNamespaceResolver;
		public static RMethod RCompile_String_IXmlNamespaceResolver
		{
			get
			{
				if(r_RCompile_String_IXmlNamespaceResolver == null)
				{
					r_RCompile_String_IXmlNamespaceResolver = new(typeof(System.Xml.XPath.XPathExpression), "Compile", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver));
					r_RCompile_String_IXmlNamespaceResolver.SetBelong(null);
				}
				return r_RCompile_String_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// Void PrintQuery(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RPrintQuery_XmlWriter;
		public virtual RMethod RPrintQuery_XmlWriter
		{
			get
			{
				if(r_RPrintQuery_XmlWriter == null)
				{
					r_RPrintQuery_XmlWriter = new(this, "PrintQuery", 0, typeof(System.Xml.XmlWriter));
					r_RPrintQuery_XmlWriter.SetBelong(this.instance);
				}
				return r_RPrintQuery_XmlWriter;
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


        public RXPathExpression() : base("System.Xml.XPath.XPathExpression")
        {
        }

        public RXPathExpression(System.Object instance) : base("System.Xml.XPath.XPathExpression")
		{
            SetInstance(instance);
		}

        public RXPathExpression(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXPathExpression(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddSort(System.Object  @expr, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr, @comparer};
            var ___result = RAddSort_Object_IComparer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSort(System.Object  @expr, System.Xml.XPath.XmlSortOrder  @order, System.Xml.XPath.XmlCaseOrder  @caseOrder, System.String  @lang, System.Xml.XPath.XmlDataType  @dataType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expr, @order, @caseOrder, @lang, @dataType};
            var ___result = RAddSort_Object_XmlSortOrder_XmlCaseOrder_String_XmlDataType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XPath.XPathExpression Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathExpression)___result;
        }


        public virtual void SetContext(System.Xml.XmlNamespaceManager  @nsManager)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nsManager};
            var ___result = RSetContext_XmlNamespaceManager.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetContext(System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nsResolver};
            var ___result = RSetContext_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.XPath.XPathExpression Compile(System.String  @xpath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath};
            var ___result = RCompile_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathExpression)___result;
        }


        public static System.Xml.XPath.XPathExpression Compile(System.String  @xpath, System.Xml.IXmlNamespaceResolver  @nsResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xpath, @nsResolver};
            var ___result = RCompile_String_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XPath.XPathExpression)___result;
        }


        public virtual void PrintQuery(System.Xml.XmlWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RPrintQuery_XmlWriter.Invoke(___genericsType, ___parameters);

            
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
