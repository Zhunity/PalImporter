using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlNamedNodeMap
	/// </summary>
    public partial class RXmlNamedNodeMap : RMember //
    {

		/// <summary>
		/// System.Xml.XmlNode parent
		/// </summary>
		protected RSystem.RXml.RXmlNode r_parent;
		public virtual RSystem.RXml.RXmlNode Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent");
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamedNodeMap+SmallXmlNodeList nodes
		/// </summary>
		protected RSystem.RXml.RXmlNamedNodeMap.RSmallXmlNodeList r_nodes;
		public virtual RSystem.RXml.RXmlNamedNodeMap.RSmallXmlNodeList Rnodes
		{
			get
			{
				if(r_nodes == null)
				{
					r_nodes = new(this, "nodes");
					r_nodes.SetBelong(this.instance);
				}
				return r_nodes;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode GetNamedItem(System.String)
		/// </summary>
		protected RMethod r_RGetNamedItem_String;
		public virtual RMethod RGetNamedItem_String
		{
			get
			{
				if(r_RGetNamedItem_String == null)
				{
					r_RGetNamedItem_String = new(this, "GetNamedItem", 0, typeof(System.String));
					r_RGetNamedItem_String.SetBelong(this.instance);
				}
				return r_RGetNamedItem_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RSetNamedItem_XmlNode;
		public virtual RMethod RSetNamedItem_XmlNode
		{
			get
			{
				if(r_RSetNamedItem_XmlNode == null)
				{
					r_RSetNamedItem_XmlNode = new(this, "SetNamedItem", 0, typeof(System.Xml.XmlNode));
					r_RSetNamedItem_XmlNode.SetBelong(this.instance);
				}
				return r_RSetNamedItem_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode RemoveNamedItem(System.String)
		/// </summary>
		protected RMethod r_RRemoveNamedItem_String;
		public virtual RMethod RRemoveNamedItem_String
		{
			get
			{
				if(r_RRemoveNamedItem_String == null)
				{
					r_RRemoveNamedItem_String = new(this, "RemoveNamedItem", 0, typeof(System.String));
					r_RRemoveNamedItem_String.SetBelong(this.instance);
				}
				return r_RRemoveNamedItem_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode Item(Int32)
		/// </summary>
		protected RMethod r_RItem_Int32;
		public virtual RMethod RItem_Int32
		{
			get
			{
				if(r_RItem_Int32 == null)
				{
					r_RItem_Int32 = new(this, "Item", 0, typeof(System.Int32));
					r_RItem_Int32.SetBelong(this.instance);
				}
				return r_RItem_Int32;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode GetNamedItem(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetNamedItem_String_String;
		public virtual RMethod RGetNamedItem_String_String
		{
			get
			{
				if(r_RGetNamedItem_String_String == null)
				{
					r_RGetNamedItem_String_String = new(this, "GetNamedItem", 0, typeof(System.String), typeof(System.String));
					r_RGetNamedItem_String_String.SetBelong(this.instance);
				}
				return r_RGetNamedItem_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode RemoveNamedItem(System.String, System.String)
		/// </summary>
		protected RMethod r_RRemoveNamedItem_String_String;
		public virtual RMethod RRemoveNamedItem_String_String
		{
			get
			{
				if(r_RRemoveNamedItem_String_String == null)
				{
					r_RRemoveNamedItem_String_String = new(this, "RemoveNamedItem", 0, typeof(System.String), typeof(System.String));
					r_RRemoveNamedItem_String_String.SetBelong(this.instance);
				}
				return r_RRemoveNamedItem_String_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Int32 FindNodeOffset(System.String)
		/// </summary>
		protected RMethod r_RFindNodeOffset_String;
		public virtual RMethod RFindNodeOffset_String
		{
			get
			{
				if(r_RFindNodeOffset_String == null)
				{
					r_RFindNodeOffset_String = new(this, "FindNodeOffset", 0, typeof(System.String));
					r_RFindNodeOffset_String.SetBelong(this.instance);
				}
				return r_RFindNodeOffset_String;
			}
		}

		/// <summary>
		/// Int32 FindNodeOffset(System.String, System.String)
		/// </summary>
		protected RMethod r_RFindNodeOffset_String_String;
		public virtual RMethod RFindNodeOffset_String_String
		{
			get
			{
				if(r_RFindNodeOffset_String_String == null)
				{
					r_RFindNodeOffset_String_String = new(this, "FindNodeOffset", 0, typeof(System.String), typeof(System.String));
					r_RFindNodeOffset_String_String.SetBelong(this.instance);
				}
				return r_RFindNodeOffset_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode AddNode(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RAddNode_XmlNode;
		public virtual RMethod RAddNode_XmlNode
		{
			get
			{
				if(r_RAddNode_XmlNode == null)
				{
					r_RAddNode_XmlNode = new(this, "AddNode", 0, typeof(System.Xml.XmlNode));
					r_RAddNode_XmlNode.SetBelong(this.instance);
				}
				return r_RAddNode_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode, System.Xml.XmlDocument)
		/// </summary>
		protected RMethod r_RAddNodeForLoad_XmlNode_XmlDocument;
		public virtual RMethod RAddNodeForLoad_XmlNode_XmlDocument
		{
			get
			{
				if(r_RAddNodeForLoad_XmlNode_XmlDocument == null)
				{
					r_RAddNodeForLoad_XmlNode_XmlDocument = new(this, "AddNodeForLoad", 0, typeof(System.Xml.XmlNode), typeof(System.Xml.XmlDocument));
					r_RAddNodeForLoad_XmlNode_XmlDocument.SetBelong(this.instance);
				}
				return r_RAddNodeForLoad_XmlNode_XmlDocument;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode RemoveNodeAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveNodeAt_Int32;
		public virtual RMethod RRemoveNodeAt_Int32
		{
			get
			{
				if(r_RRemoveNodeAt_Int32 == null)
				{
					r_RRemoveNodeAt_Int32 = new(this, "RemoveNodeAt", 0, typeof(System.Int32));
					r_RRemoveNodeAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveNodeAt_Int32;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode ReplaceNodeAt(Int32, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RReplaceNodeAt_Int32_XmlNode;
		public virtual RMethod RReplaceNodeAt_Int32_XmlNode
		{
			get
			{
				if(r_RReplaceNodeAt_Int32_XmlNode == null)
				{
					r_RReplaceNodeAt_Int32_XmlNode = new(this, "ReplaceNodeAt", 0, typeof(System.Int32), typeof(System.Xml.XmlNode));
					r_RReplaceNodeAt_Int32_XmlNode.SetBelong(this.instance);
				}
				return r_RReplaceNodeAt_Int32_XmlNode;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode InsertNodeAt(Int32, System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RInsertNodeAt_Int32_XmlNode;
		public virtual RMethod RInsertNodeAt_Int32_XmlNode
		{
			get
			{
				if(r_RInsertNodeAt_Int32_XmlNode == null)
				{
					r_RInsertNodeAt_Int32_XmlNode = new(this, "InsertNodeAt", 0, typeof(System.Int32), typeof(System.Xml.XmlNode));
					r_RInsertNodeAt_Int32_XmlNode.SetBelong(this.instance);
				}
				return r_RInsertNodeAt_Int32_XmlNode;
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


        public RXmlNamedNodeMap() : base("System.Xml.XmlNamedNodeMap")
        {
        }

        public RXmlNamedNodeMap(System.Object instance) : base("System.Xml.XmlNamedNodeMap")
		{
            SetInstance(instance);
		}

        public RXmlNamedNodeMap(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlNamedNodeMap(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.XmlNode GetNamedItem(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedItem_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RSetNamedItem_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode RemoveNamedItem(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRemoveNamedItem_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode Item(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RItem_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode GetNamedItem(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetNamedItem_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode RemoveNamedItem(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RRemoveNamedItem_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Int32 FindNodeOffset(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindNodeOffset_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNodeOffset(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RFindNodeOffset_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Xml.XmlNode AddNode(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAddNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode  @node, System.Xml.XmlDocument  @doc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @doc};
            var ___result = RAddNodeForLoad_XmlNode_XmlDocument.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode RemoveNodeAt(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RRemoveNodeAt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode ReplaceNodeAt(System.Int32  @i, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @node};
            var ___result = RReplaceNodeAt_Int32_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode InsertNodeAt(System.Int32  @i, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @node};
            var ___result = RInsertNodeAt_Int32_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
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
