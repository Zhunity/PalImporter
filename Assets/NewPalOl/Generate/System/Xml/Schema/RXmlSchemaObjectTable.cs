using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaObjectTable
	/// </summary>
    public partial class RXmlSchemaObjectTable : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject] table
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RXmlSchemaObject> r_table;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RXmlQualifiedName, RSystem.RXml.RSchema.RXmlSchemaObject> Rtable
		{
			get
			{
				if(r_table == null)
				{
					r_table = new(this, "table");
					r_table.SetBelong(this.instance);
				}
				return r_table;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Xml.Schema.XmlSchemaObjectTable+XmlSchemaObjectEntry] entries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RXml.RSchema.RXmlSchemaObjectTable.RXmlSchemaObjectEntry> r_entries;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RXml.RSchema.RXmlSchemaObjectTable.RXmlSchemaObjectEntry> Rentries
		{
			get
			{
				if(r_entries == null)
				{
					r_entries = new(this, "entries");
					r_entries.SetBelong(this.instance);
				}
				return r_entries;
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
		/// System.Xml.Schema.XmlSchemaObject Item [System.Xml.XmlQualifiedName]
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObject r_Item_XmlQualifiedName;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObject RItem_XmlQualifiedName
		{
			get
			{
				if(r_Item_XmlQualifiedName == null)
				{
					r_Item_XmlQualifiedName = new(this, "Item", -1, typeof(System.Xml.XmlQualifiedName));
					r_Item_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_Item_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Names
		/// </summary>
		protected RSystem.RCollections.RICollection r_Names;
		public virtual RSystem.RCollections.RICollection RNames
		{
			get
			{
				if(r_Names == null)
				{
					r_Names = new(this, "Names", -1);
					r_Names.SetBelong(this.instance);
				}
				return r_Names;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Values
		/// </summary>
		protected RSystem.RCollections.RICollection r_Values;
		public virtual RSystem.RCollections.RICollection RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
			}
		}

		/// <summary>
		/// Void Add(System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RAdd_XmlQualifiedName_XmlSchemaObject;
		public virtual RMethod RAdd_XmlQualifiedName_XmlSchemaObject
		{
			get
			{
				if(r_RAdd_XmlQualifiedName_XmlSchemaObject == null)
				{
					r_RAdd_XmlQualifiedName_XmlSchemaObject = new(this, "Add", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RAdd_XmlQualifiedName_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RAdd_XmlQualifiedName_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void Insert(System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RInsert_XmlQualifiedName_XmlSchemaObject;
		public virtual RMethod RInsert_XmlQualifiedName_XmlSchemaObject
		{
			get
			{
				if(r_RInsert_XmlQualifiedName_XmlSchemaObject == null)
				{
					r_RInsert_XmlQualifiedName_XmlSchemaObject = new(this, "Insert", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RInsert_XmlQualifiedName_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RInsert_XmlQualifiedName_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void Replace(System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RReplace_XmlQualifiedName_XmlSchemaObject;
		public virtual RMethod RReplace_XmlQualifiedName_XmlSchemaObject
		{
			get
			{
				if(r_RReplace_XmlQualifiedName_XmlSchemaObject == null)
				{
					r_RReplace_XmlQualifiedName_XmlSchemaObject = new(this, "Replace", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RReplace_XmlQualifiedName_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RReplace_XmlQualifiedName_XmlSchemaObject;
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
		/// Void Remove(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RRemove_XmlQualifiedName;
		public virtual RMethod RRemove_XmlQualifiedName
		{
			get
			{
				if(r_RRemove_XmlQualifiedName == null)
				{
					r_RRemove_XmlQualifiedName = new(this, "Remove", 0, typeof(System.Xml.XmlQualifiedName));
					r_RRemove_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RRemove_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Int32 FindIndexByValue(System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RFindIndexByValue_XmlSchemaObject;
		public virtual RMethod RFindIndexByValue_XmlSchemaObject
		{
			get
			{
				if(r_RFindIndexByValue_XmlSchemaObject == null)
				{
					r_RFindIndexByValue_XmlSchemaObject = new(this, "FindIndexByValue", 0, typeof(System.Xml.Schema.XmlSchemaObject));
					r_RFindIndexByValue_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RFindIndexByValue_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RContains_XmlQualifiedName;
		public virtual RMethod RContains_XmlQualifiedName
		{
			get
			{
				if(r_RContains_XmlQualifiedName == null)
				{
					r_RContains_XmlQualifiedName = new(this, "Contains", 0, typeof(System.Xml.XmlQualifiedName));
					r_RContains_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RContains_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Collections.IDictionaryEnumerator GetEnumerator()
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


        public RXmlSchemaObjectTable() : base("System.Xml.Schema.XmlSchemaObjectTable")
        {
        }

        public RXmlSchemaObjectTable(System.Object instance) : base("System.Xml.Schema.XmlSchemaObjectTable")
		{
            SetInstance(instance);
		}

        public RXmlSchemaObjectTable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaObjectTable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(System.Xml.XmlQualifiedName  @name, System.Xml.Schema.XmlSchemaObject  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAdd_XmlQualifiedName_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Xml.XmlQualifiedName  @name, System.Xml.Schema.XmlSchemaObject  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RInsert_XmlQualifiedName_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Replace(System.Xml.XmlQualifiedName  @name, System.Xml.Schema.XmlSchemaObject  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RReplace_XmlQualifiedName_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Xml.XmlQualifiedName  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRemove_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindIndexByValue(System.Xml.Schema.XmlSchemaObject  @xso)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xso};
            var ___result = RFindIndexByValue_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Contains(System.Xml.XmlQualifiedName  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RContains_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
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
