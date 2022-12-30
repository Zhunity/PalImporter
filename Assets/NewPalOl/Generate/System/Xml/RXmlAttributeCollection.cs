using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlAttributeCollection
	/// </summary>
    public partial class RXmlAttributeCollection : RMember //
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
		/// System.Xml.XmlAttribute ItemOf [Int32]
		/// </summary>
		protected RSystem.RXml.RXmlAttribute r_ItemOf_Int32;
		public virtual RSystem.RXml.RXmlAttribute RItemOf_Int32
		{
			get
			{
				if(r_ItemOf_Int32 == null)
				{
					r_ItemOf_Int32 = new(this, "ItemOf", -1, typeof(System.Int32));
					r_ItemOf_Int32.SetBelong(this.instance);
				}
				return r_ItemOf_Int32;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute ItemOf [System.String]
		/// </summary>
		protected RSystem.RXml.RXmlAttribute r_ItemOf_String;
		public virtual RSystem.RXml.RXmlAttribute RItemOf_String
		{
			get
			{
				if(r_ItemOf_String == null)
				{
					r_ItemOf_String = new(this, "ItemOf", -1, typeof(System.String));
					r_ItemOf_String.SetBelong(this.instance);
				}
				return r_ItemOf_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute ItemOf [System.String, System.String]
		/// </summary>
		protected RSystem.RXml.RXmlAttribute r_ItemOf_String_String;
		public virtual RSystem.RXml.RXmlAttribute RItemOf_String_String
		{
			get
			{
				if(r_ItemOf_String_String == null)
				{
					r_ItemOf_String_String = new(this, "ItemOf", -1, typeof(System.String), typeof(System.String));
					r_ItemOf_String_String.SetBelong(this.instance);
				}
				return r_ItemOf_String_String;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized;
		public virtual RProperty RSystem__1__Collections__1__ICollection__1__get_IsSynchronized
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot;
		public virtual RSystem.RObject RSystem__1__Collections__1__ICollection__1__get_SyncRoot
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot;
			}
		}

		/// <summary>
		/// Int32 System.Collections.ICollection.Count
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__ICollection__1__get_Count;
		public virtual RProperty RSystem__1__Collections__1__ICollection__1__get_Count
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_Count == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_Count = new(this, "System.Collections.ICollection.Count", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_Count.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_Count;
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
		/// Int32 FindNodeOffset(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RFindNodeOffset_XmlAttribute;
		public virtual RMethod RFindNodeOffset_XmlAttribute
		{
			get
			{
				if(r_RFindNodeOffset_XmlAttribute == null)
				{
					r_RFindNodeOffset_XmlAttribute = new(this, "FindNodeOffset", 0, typeof(System.Xml.XmlAttribute));
					r_RFindNodeOffset_XmlAttribute.SetBelong(this.instance);
				}
				return r_RFindNodeOffset_XmlAttribute;
			}
		}

		/// <summary>
		/// Int32 FindNodeOffsetNS(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RFindNodeOffsetNS_XmlAttribute;
		public virtual RMethod RFindNodeOffsetNS_XmlAttribute
		{
			get
			{
				if(r_RFindNodeOffsetNS_XmlAttribute == null)
				{
					r_RFindNodeOffsetNS_XmlAttribute = new(this, "FindNodeOffsetNS", 0, typeof(System.Xml.XmlAttribute));
					r_RFindNodeOffsetNS_XmlAttribute.SetBelong(this.instance);
				}
				return r_RFindNodeOffsetNS_XmlAttribute;
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
		/// System.Xml.XmlAttribute Prepend(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RPrepend_XmlAttribute;
		public virtual RMethod RPrepend_XmlAttribute
		{
			get
			{
				if(r_RPrepend_XmlAttribute == null)
				{
					r_RPrepend_XmlAttribute = new(this, "Prepend", 0, typeof(System.Xml.XmlAttribute));
					r_RPrepend_XmlAttribute.SetBelong(this.instance);
				}
				return r_RPrepend_XmlAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute Append(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RAppend_XmlAttribute;
		public virtual RMethod RAppend_XmlAttribute
		{
			get
			{
				if(r_RAppend_XmlAttribute == null)
				{
					r_RAppend_XmlAttribute = new(this, "Append", 0, typeof(System.Xml.XmlAttribute));
					r_RAppend_XmlAttribute.SetBelong(this.instance);
				}
				return r_RAppend_XmlAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute InsertBefore(System.Xml.XmlAttribute, System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RInsertBefore_XmlAttribute_XmlAttribute;
		public virtual RMethod RInsertBefore_XmlAttribute_XmlAttribute
		{
			get
			{
				if(r_RInsertBefore_XmlAttribute_XmlAttribute == null)
				{
					r_RInsertBefore_XmlAttribute_XmlAttribute = new(this, "InsertBefore", 0, typeof(System.Xml.XmlAttribute), typeof(System.Xml.XmlAttribute));
					r_RInsertBefore_XmlAttribute_XmlAttribute.SetBelong(this.instance);
				}
				return r_RInsertBefore_XmlAttribute_XmlAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute InsertAfter(System.Xml.XmlAttribute, System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RInsertAfter_XmlAttribute_XmlAttribute;
		public virtual RMethod RInsertAfter_XmlAttribute_XmlAttribute
		{
			get
			{
				if(r_RInsertAfter_XmlAttribute_XmlAttribute == null)
				{
					r_RInsertAfter_XmlAttribute_XmlAttribute = new(this, "InsertAfter", 0, typeof(System.Xml.XmlAttribute), typeof(System.Xml.XmlAttribute));
					r_RInsertAfter_XmlAttribute_XmlAttribute.SetBelong(this.instance);
				}
				return r_RInsertAfter_XmlAttribute_XmlAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RRemove_XmlAttribute;
		public virtual RMethod RRemove_XmlAttribute
		{
			get
			{
				if(r_RRemove_XmlAttribute == null)
				{
					r_RRemove_XmlAttribute = new(this, "Remove", 0, typeof(System.Xml.XmlAttribute));
					r_RRemove_XmlAttribute.SetBelong(this.instance);
				}
				return r_RRemove_XmlAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RRemoveAt_Int32 == null)
				{
					r_RRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void RemoveAll()
		/// </summary>
		protected RMethod r_RRemoveAll;
		public virtual RMethod RRemoveAll
		{
			get
			{
				if(r_RRemoveAll == null)
				{
					r_RRemoveAll = new(this, "RemoveAll", 0);
					r_RRemoveAll.SetBelong(this.instance);
				}
				return r_RRemoveAll;
			}
		}

		/// <summary>
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32;
		public virtual RMethod RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32 == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Xml.XmlAttribute[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_XmlAttributeArray_Int32;
		public virtual RMethod RCopyTo_XmlAttributeArray_Int32
		{
			get
			{
				if(r_RCopyTo_XmlAttributeArray_Int32 == null)
				{
					r_RCopyTo_XmlAttributeArray_Int32 = new(this, "CopyTo", 0, typeof(System.Xml.XmlAttribute).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_XmlAttributeArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_XmlAttributeArray_Int32;
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
		/// Void Detach(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RDetach_XmlAttribute;
		public virtual RMethod RDetach_XmlAttribute
		{
			get
			{
				if(r_RDetach_XmlAttribute == null)
				{
					r_RDetach_XmlAttribute = new(this, "Detach", 0, typeof(System.Xml.XmlAttribute));
					r_RDetach_XmlAttribute.SetBelong(this.instance);
				}
				return r_RDetach_XmlAttribute;
			}
		}

		/// <summary>
		/// Void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RInsertParentIntoElementIdAttrMap_XmlAttribute;
		public virtual RMethod RInsertParentIntoElementIdAttrMap_XmlAttribute
		{
			get
			{
				if(r_RInsertParentIntoElementIdAttrMap_XmlAttribute == null)
				{
					r_RInsertParentIntoElementIdAttrMap_XmlAttribute = new(this, "InsertParentIntoElementIdAttrMap", 0, typeof(System.Xml.XmlAttribute));
					r_RInsertParentIntoElementIdAttrMap_XmlAttribute.SetBelong(this.instance);
				}
				return r_RInsertParentIntoElementIdAttrMap_XmlAttribute;
			}
		}

		/// <summary>
		/// Void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RRemoveParentFromElementIdAttrMap_XmlAttribute;
		public virtual RMethod RRemoveParentFromElementIdAttrMap_XmlAttribute
		{
			get
			{
				if(r_RRemoveParentFromElementIdAttrMap_XmlAttribute == null)
				{
					r_RRemoveParentFromElementIdAttrMap_XmlAttribute = new(this, "RemoveParentFromElementIdAttrMap", 0, typeof(System.Xml.XmlAttribute));
					r_RRemoveParentFromElementIdAttrMap_XmlAttribute.SetBelong(this.instance);
				}
				return r_RRemoveParentFromElementIdAttrMap_XmlAttribute;
			}
		}

		/// <summary>
		/// Int32 RemoveDuplicateAttribute(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RRemoveDuplicateAttribute_XmlAttribute;
		public virtual RMethod RRemoveDuplicateAttribute_XmlAttribute
		{
			get
			{
				if(r_RRemoveDuplicateAttribute_XmlAttribute == null)
				{
					r_RRemoveDuplicateAttribute_XmlAttribute = new(this, "RemoveDuplicateAttribute", 0, typeof(System.Xml.XmlAttribute));
					r_RRemoveDuplicateAttribute_XmlAttribute.SetBelong(this.instance);
				}
				return r_RRemoveDuplicateAttribute_XmlAttribute;
			}
		}

		/// <summary>
		/// Boolean PrepareParentInElementIdAttrMap(System.String, System.String)
		/// </summary>
		protected RMethod r_RPrepareParentInElementIdAttrMap_String_String;
		public virtual RMethod RPrepareParentInElementIdAttrMap_String_String
		{
			get
			{
				if(r_RPrepareParentInElementIdAttrMap_String_String == null)
				{
					r_RPrepareParentInElementIdAttrMap_String_String = new(this, "PrepareParentInElementIdAttrMap", 0, typeof(System.String), typeof(System.String));
					r_RPrepareParentInElementIdAttrMap_String_String.SetBelong(this.instance);
				}
				return r_RPrepareParentInElementIdAttrMap_String_String;
			}
		}

		/// <summary>
		/// Void ResetParentInElementIdAttrMap(System.String, System.String)
		/// </summary>
		protected RMethod r_RResetParentInElementIdAttrMap_String_String;
		public virtual RMethod RResetParentInElementIdAttrMap_String_String
		{
			get
			{
				if(r_RResetParentInElementIdAttrMap_String_String == null)
				{
					r_RResetParentInElementIdAttrMap_String_String = new(this, "ResetParentInElementIdAttrMap", 0, typeof(System.String), typeof(System.String));
					r_RResetParentInElementIdAttrMap_String_String.SetBelong(this.instance);
				}
				return r_RResetParentInElementIdAttrMap_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute)
		/// </summary>
		protected RMethod r_RInternalAppendAttribute_XmlAttribute;
		public virtual RMethod RInternalAppendAttribute_XmlAttribute
		{
			get
			{
				if(r_RInternalAppendAttribute_XmlAttribute == null)
				{
					r_RInternalAppendAttribute_XmlAttribute = new(this, "InternalAppendAttribute", 0, typeof(System.Xml.XmlAttribute));
					r_RInternalAppendAttribute_XmlAttribute.SetBelong(this.instance);
				}
				return r_RInternalAppendAttribute_XmlAttribute;
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


        public RXmlAttributeCollection() : base("System.Xml.XmlAttributeCollection")
        {
        }

        public RXmlAttributeCollection(System.Object instance) : base("System.Xml.XmlAttributeCollection")
		{
            SetInstance(instance);
		}

        public RXmlAttributeCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlAttributeCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 FindNodeOffset(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RFindNodeOffset_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNodeOffsetNS(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RFindNodeOffsetNS_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RSetNamedItem_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlAttribute Prepend(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RPrepend_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute Append(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAppend_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute InsertBefore(System.Xml.XmlAttribute  @newNode, System.Xml.XmlAttribute  @refNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode, @refNode};
            var ___result = RInsertBefore_XmlAttribute_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute InsertAfter(System.Xml.XmlAttribute  @newNode, System.Xml.XmlAttribute  @refNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNode, @refNode};
            var ___result = RInsertAfter_XmlAttribute_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RRemove_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlAttribute RemoveAt(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual void RemoveAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Collections__1__ICollection__1__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Xml.XmlAttribute[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_XmlAttributeArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNode AddNode(System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAddNode_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode InsertNodeAt(System.Int32  @i, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @node};
            var ___result = RInsertNodeAt_Int32_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode RemoveNodeAt(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RRemoveNodeAt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual void Detach(System.Xml.XmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RDetach_XmlAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RInsertParentIntoElementIdAttrMap_XmlAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RRemoveParentFromElementIdAttrMap_XmlAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RemoveDuplicateAttribute(System.Xml.XmlAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RRemoveDuplicateAttribute_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean PrepareParentInElementIdAttrMap(System.String  @attrPrefix, System.String  @attrLocalName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attrPrefix, @attrLocalName};
            var ___result = RPrepareParentInElementIdAttrMap_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResetParentInElementIdAttrMap(System.String  @oldVal, System.String  @newVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldVal, @newVal};
            var ___result = RResetParentInElementIdAttrMap_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RInternalAppendAttribute_XmlAttribute.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlAttribute)___result;
        }


        public virtual System.Xml.XmlNode GetNamedItem(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedItem_String.Invoke(___genericsType, ___parameters);

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


        public virtual System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode  @node, System.Xml.XmlDocument  @doc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @doc};
            var ___result = RAddNodeForLoad_XmlNode_XmlDocument.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNode)___result;
        }


        public virtual System.Xml.XmlNode ReplaceNodeAt(System.Int32  @i, System.Xml.XmlNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @node};
            var ___result = RReplaceNodeAt_Int32_XmlNode.Invoke(___genericsType, ___parameters);

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
