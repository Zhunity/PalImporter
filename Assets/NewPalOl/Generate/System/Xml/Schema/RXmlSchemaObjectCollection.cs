using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaObjectCollection
	/// </summary>
    public partial class RXmlSchemaObjectCollection : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObject parent
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObject r_parent;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObject Rparent
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
		/// System.Xml.Schema.XmlSchemaObject Item [Int32]
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObject r_Item_Int32;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObject RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList InnerList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_InnerList;
		public virtual RSystem.RCollections.RArrayList RInnerList
		{
			get
			{
				if(r_InnerList == null)
				{
					r_InnerList = new(this, "InnerList", -1);
					r_InnerList.SetBelong(this.instance);
				}
				return r_InnerList;
			}
		}

		/// <summary>
		/// System.Collections.IList List
		/// </summary>
		protected RSystem.RCollections.RIList r_List;
		public virtual RSystem.RCollections.RIList RList
		{
			get
			{
				if(r_List == null)
				{
					r_List = new(this, "List", -1);
					r_List.SetBelong(this.instance);
				}
				return r_List;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected RProperty r_Capacity;
		public virtual RProperty RCapacity
		{
			get
			{
				if(r_Capacity == null)
				{
					r_Capacity = new(this, "Capacity", -1);
					r_Capacity.SetBelong(this.instance);
				}
				return r_Capacity;
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
		/// System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator()
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
		/// Int32 Add(System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RAdd_XmlSchemaObject;
		public virtual RMethod RAdd_XmlSchemaObject
		{
			get
			{
				if(r_RAdd_XmlSchemaObject == null)
				{
					r_RAdd_XmlSchemaObject = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchemaObject));
					r_RAdd_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RInsert_Int32_XmlSchemaObject;
		public virtual RMethod RInsert_Int32_XmlSchemaObject
		{
			get
			{
				if(r_RInsert_Int32_XmlSchemaObject == null)
				{
					r_RInsert_Int32_XmlSchemaObject = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RInsert_Int32_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RInsert_Int32_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RIndexOf_XmlSchemaObject;
		public virtual RMethod RIndexOf_XmlSchemaObject
		{
			get
			{
				if(r_RIndexOf_XmlSchemaObject == null)
				{
					r_RIndexOf_XmlSchemaObject = new(this, "IndexOf", 0, typeof(System.Xml.Schema.XmlSchemaObject));
					r_RIndexOf_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RIndexOf_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RContains_XmlSchemaObject;
		public virtual RMethod RContains_XmlSchemaObject
		{
			get
			{
				if(r_RContains_XmlSchemaObject == null)
				{
					r_RContains_XmlSchemaObject = new(this, "Contains", 0, typeof(System.Xml.Schema.XmlSchemaObject));
					r_RContains_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RContains_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void Remove(System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RRemove_XmlSchemaObject;
		public virtual RMethod RRemove_XmlSchemaObject
		{
			get
			{
				if(r_RRemove_XmlSchemaObject == null)
				{
					r_RRemove_XmlSchemaObject = new(this, "Remove", 0, typeof(System.Xml.Schema.XmlSchemaObject));
					r_RRemove_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RRemove_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Xml.Schema.XmlSchemaObject[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_XmlSchemaObjectArray_Int32;
		public virtual RMethod RCopyTo_XmlSchemaObjectArray_Int32
		{
			get
			{
				if(r_RCopyTo_XmlSchemaObjectArray_Int32 == null)
				{
					r_RCopyTo_XmlSchemaObjectArray_Int32 = new(this, "CopyTo", 0, typeof(System.Xml.Schema.XmlSchemaObject).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_XmlSchemaObjectArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_XmlSchemaObjectArray_Int32;
			}
		}

		/// <summary>
		/// Void OnInsert(Int32, System.Object)
		/// </summary>
		protected RMethod r_ROnInsert_Int32_Object;
		public virtual RMethod ROnInsert_Int32_Object
		{
			get
			{
				if(r_ROnInsert_Int32_Object == null)
				{
					r_ROnInsert_Int32_Object = new(this, "OnInsert", 0, typeof(System.Int32), typeof(System.Object));
					r_ROnInsert_Int32_Object.SetBelong(this.instance);
				}
				return r_ROnInsert_Int32_Object;
			}
		}

		/// <summary>
		/// Void OnSet(Int32, System.Object, System.Object)
		/// </summary>
		protected RMethod r_ROnSet_Int32_Object_Object;
		public virtual RMethod ROnSet_Int32_Object_Object
		{
			get
			{
				if(r_ROnSet_Int32_Object_Object == null)
				{
					r_ROnSet_Int32_Object_Object = new(this, "OnSet", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Object));
					r_ROnSet_Int32_Object_Object.SetBelong(this.instance);
				}
				return r_ROnSet_Int32_Object_Object;
			}
		}

		/// <summary>
		/// Void OnClear()
		/// </summary>
		protected RMethod r_ROnClear;
		public virtual RMethod ROnClear
		{
			get
			{
				if(r_ROnClear == null)
				{
					r_ROnClear = new(this, "OnClear", 0);
					r_ROnClear.SetBelong(this.instance);
				}
				return r_ROnClear;
			}
		}

		/// <summary>
		/// Void OnRemove(Int32, System.Object)
		/// </summary>
		protected RMethod r_ROnRemove_Int32_Object;
		public virtual RMethod ROnRemove_Int32_Object
		{
			get
			{
				if(r_ROnRemove_Int32_Object == null)
				{
					r_ROnRemove_Int32_Object = new(this, "OnRemove", 0, typeof(System.Int32), typeof(System.Object));
					r_ROnRemove_Int32_Object.SetBelong(this.instance);
				}
				return r_ROnRemove_Int32_Object;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectCollection Clone()
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
		/// Void Add(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected RMethod r_RAdd_XmlSchemaObjectCollection;
		public virtual RMethod RAdd_XmlSchemaObjectCollection
		{
			get
			{
				if(r_RAdd_XmlSchemaObjectCollection == null)
				{
					r_RAdd_XmlSchemaObjectCollection = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_RAdd_XmlSchemaObjectCollection.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchemaObjectCollection;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
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
		/// Void OnValidate(System.Object)
		/// </summary>
		protected RMethod r_ROnValidate_Object;
		public virtual RMethod ROnValidate_Object
		{
			get
			{
				if(r_ROnValidate_Object == null)
				{
					r_ROnValidate_Object = new(this, "OnValidate", 0, typeof(System.Object));
					r_ROnValidate_Object.SetBelong(this.instance);
				}
				return r_ROnValidate_Object;
			}
		}

		/// <summary>
		/// Void OnSetComplete(Int32, System.Object, System.Object)
		/// </summary>
		protected RMethod r_ROnSetComplete_Int32_Object_Object;
		public virtual RMethod ROnSetComplete_Int32_Object_Object
		{
			get
			{
				if(r_ROnSetComplete_Int32_Object_Object == null)
				{
					r_ROnSetComplete_Int32_Object_Object = new(this, "OnSetComplete", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Object));
					r_ROnSetComplete_Int32_Object_Object.SetBelong(this.instance);
				}
				return r_ROnSetComplete_Int32_Object_Object;
			}
		}

		/// <summary>
		/// Void OnInsertComplete(Int32, System.Object)
		/// </summary>
		protected RMethod r_ROnInsertComplete_Int32_Object;
		public virtual RMethod ROnInsertComplete_Int32_Object
		{
			get
			{
				if(r_ROnInsertComplete_Int32_Object == null)
				{
					r_ROnInsertComplete_Int32_Object = new(this, "OnInsertComplete", 0, typeof(System.Int32), typeof(System.Object));
					r_ROnInsertComplete_Int32_Object.SetBelong(this.instance);
				}
				return r_ROnInsertComplete_Int32_Object;
			}
		}

		/// <summary>
		/// Void OnClearComplete()
		/// </summary>
		protected RMethod r_ROnClearComplete;
		public virtual RMethod ROnClearComplete
		{
			get
			{
				if(r_ROnClearComplete == null)
				{
					r_ROnClearComplete = new(this, "OnClearComplete", 0);
					r_ROnClearComplete.SetBelong(this.instance);
				}
				return r_ROnClearComplete;
			}
		}

		/// <summary>
		/// Void OnRemoveComplete(Int32, System.Object)
		/// </summary>
		protected RMethod r_ROnRemoveComplete_Int32_Object;
		public virtual RMethod ROnRemoveComplete_Int32_Object
		{
			get
			{
				if(r_ROnRemoveComplete_Int32_Object == null)
				{
					r_ROnRemoveComplete_Int32_Object = new(this, "OnRemoveComplete", 0, typeof(System.Int32), typeof(System.Object));
					r_ROnRemoveComplete_Int32_Object.SetBelong(this.instance);
				}
				return r_ROnRemoveComplete_Int32_Object;
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


        public RXmlSchemaObjectCollection() : base("System.Xml.Schema.XmlSchemaObjectCollection")
        {
        }

        public RXmlSchemaObjectCollection(System.Object instance) : base("System.Xml.Schema.XmlSchemaObjectCollection")
		{
            SetInstance(instance);
		}

        public RXmlSchemaObjectCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaObjectCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObjectEnumerator)___result;
        }


        public virtual System.Int32 Add(System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAdd_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32  @index, System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = RInsert_Int32_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOf(System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RIndexOf_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Contains(System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Remove(System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RRemove_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Xml.Schema.XmlSchemaObject[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_XmlSchemaObjectArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInsert(System.Int32  @index, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = ROnInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSet(System.Int32  @index, System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @oldValue, @newValue};
            var ___result = ROnSet_Int32_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnClear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemove(System.Int32  @index, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @item};
            var ___result = ROnRemove_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchemaObjectCollection Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObjectCollection)___result;
        }


        public virtual void Add(System.Xml.Schema.XmlSchemaObjectCollection  @collToAdd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collToAdd};
            var ___result = RAdd_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnValidate(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = ROnValidate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSetComplete(System.Int32  @index, System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @oldValue, @newValue};
            var ___result = ROnSetComplete_Int32_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInsertComplete(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = ROnInsertComplete_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnClearComplete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnClearComplete.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemoveComplete(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = ROnRemoveComplete_Int32_Object.Invoke(___genericsType, ___parameters);

            
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
