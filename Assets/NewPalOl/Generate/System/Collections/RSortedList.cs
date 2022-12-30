using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.SortedList
	/// </summary>
    public partial class RSortedList : RMember //
    {

		/// <summary>
		/// System.Object[] keys
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_keys;
		public virtual RFieldArray<RSystem.RObject> Rkeys
		{
			get
			{
				if(r_keys == null)
				{
					r_keys = new(this, "keys");
					r_keys.SetBelong(this.instance);
				}
				return r_keys;
			}
		}

		/// <summary>
		/// System.Object[] values
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_values;
		public virtual RFieldArray<RSystem.RObject> Rvalues
		{
			get
			{
				if(r_values == null)
				{
					r_values = new(this, "values");
					r_values.SetBelong(this.instance);
				}
				return r_values;
			}
		}

		/// <summary>
		/// System.Int32 _size
		/// </summary>
		protected RField r__size;
		public virtual RField R_size
		{
			get
			{
				if(r__size == null)
				{
					r__size = new(this, "_size");
					r__size.SetBelong(this.instance);
				}
				return r__size;
			}
		}

		/// <summary>
		/// System.Int32 version
		/// </summary>
		protected RField r_version;
		public virtual RField Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.Collections.IComparer comparer
		/// </summary>
		protected RSystem.RCollections.RIComparer r_comparer;
		public virtual RSystem.RCollections.RIComparer Rcomparer
		{
			get
			{
				if(r_comparer == null)
				{
					r_comparer = new(this, "comparer");
					r_comparer.SetBelong(this.instance);
				}
				return r_comparer;
			}
		}

		/// <summary>
		/// System.Collections.SortedList+KeyList keyList
		/// </summary>
		protected RSystem.RCollections.RSortedList.RKeyList r_keyList;
		public virtual RSystem.RCollections.RSortedList.RKeyList RkeyList
		{
			get
			{
				if(r_keyList == null)
				{
					r_keyList = new(this, "keyList");
					r_keyList.SetBelong(this.instance);
				}
				return r_keyList;
			}
		}

		/// <summary>
		/// System.Collections.SortedList+ValueList valueList
		/// </summary>
		protected RSystem.RCollections.RSortedList.RValueList r_valueList;
		public virtual RSystem.RCollections.RSortedList.RValueList RvalueList
		{
			get
			{
				if(r_valueList == null)
				{
					r_valueList = new(this, "valueList");
					r_valueList.SetBelong(this.instance);
				}
				return r_valueList;
			}
		}

		/// <summary>
		/// System.Object _syncRoot
		/// </summary>
		protected RSystem.RObject r__syncRoot;
		public virtual RSystem.RObject R_syncRoot
		{
			get
			{
				if(r__syncRoot == null)
				{
					r__syncRoot = new(this, "_syncRoot");
					r__syncRoot.SetBelong(this.instance);
				}
				return r__syncRoot;
			}
		}

		/// <summary>
		/// System.Int32 _defaultCapacity
		/// </summary>
		protected static RField r__defaultCapacity;
		public static RField R_defaultCapacity
		{
			get
			{
				if(r__defaultCapacity == null)
				{
					r__defaultCapacity = new(typeof(System.Collections.SortedList), "_defaultCapacity");
					r__defaultCapacity.SetBelong(null);
				}
				return r__defaultCapacity;
			}
		}

		/// <summary>
		/// System.Int32 MaxArrayLength
		/// </summary>
		protected static RField r_MaxArrayLength;
		public static RField RMaxArrayLength
		{
			get
			{
				if(r_MaxArrayLength == null)
				{
					r_MaxArrayLength = new(typeof(System.Collections.SortedList), "MaxArrayLength");
					r_MaxArrayLength.SetBelong(null);
				}
				return r_MaxArrayLength;
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
		/// System.Collections.ICollection Keys
		/// </summary>
		protected RSystem.RCollections.RICollection r_Keys;
		public virtual RSystem.RCollections.RICollection RKeys
		{
			get
			{
				if(r_Keys == null)
				{
					r_Keys = new(this, "Keys", -1);
					r_Keys.SetBelong(this.instance);
				}
				return r_Keys;
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
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsFixedSize
		/// </summary>
		protected RProperty r_IsFixedSize;
		public virtual RProperty RIsFixedSize
		{
			get
			{
				if(r_IsFixedSize == null)
				{
					r_IsFixedSize = new(this, "IsFixedSize", -1);
					r_IsFixedSize.SetBelong(this.instance);
				}
				return r_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// System.Object Item [System.Object]
		/// </summary>
		protected RSystem.RObject r_Item_Object;
		public virtual RSystem.RObject RItem_Object
		{
			get
			{
				if(r_Item_Object == null)
				{
					r_Item_Object = new(this, "Item", -1, typeof(System.Object));
					r_Item_Object.SetBelong(this.instance);
				}
				return r_Item_Object;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RAdd_Object_Object;
		public virtual RMethod RAdd_Object_Object
		{
			get
			{
				if(r_RAdd_Object_Object == null)
				{
					r_RAdd_Object_Object = new(this, "Add", 0, typeof(System.Object), typeof(System.Object));
					r_RAdd_Object_Object.SetBelong(this.instance);
				}
				return r_RAdd_Object_Object;
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
		/// System.Object Clone()
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
		/// Boolean Contains(System.Object)
		/// </summary>
		protected RMethod r_RContains_Object;
		public virtual RMethod RContains_Object
		{
			get
			{
				if(r_RContains_Object == null)
				{
					r_RContains_Object = new(this, "Contains", 0, typeof(System.Object));
					r_RContains_Object.SetBelong(this.instance);
				}
				return r_RContains_Object;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.Object)
		/// </summary>
		protected RMethod r_RContainsKey_Object;
		public virtual RMethod RContainsKey_Object
		{
			get
			{
				if(r_RContainsKey_Object == null)
				{
					r_RContainsKey_Object = new(this, "ContainsKey", 0, typeof(System.Object));
					r_RContainsKey_Object.SetBelong(this.instance);
				}
				return r_RContainsKey_Object;
			}
		}

		/// <summary>
		/// Boolean ContainsValue(System.Object)
		/// </summary>
		protected RMethod r_RContainsValue_Object;
		public virtual RMethod RContainsValue_Object
		{
			get
			{
				if(r_RContainsValue_Object == null)
				{
					r_RContainsValue_Object = new(this, "ContainsValue", 0, typeof(System.Object));
					r_RContainsValue_Object.SetBelong(this.instance);
				}
				return r_RContainsValue_Object;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_RCopyTo_Array_Int32 == null)
				{
					r_RCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Collections.KeyValuePairs[] ToKeyValuePairsArray()
		/// </summary>
		protected RMethod r_RToKeyValuePairsArray;
		public virtual RMethod RToKeyValuePairsArray
		{
			get
			{
				if(r_RToKeyValuePairsArray == null)
				{
					r_RToKeyValuePairsArray = new(this, "ToKeyValuePairsArray", 0);
					r_RToKeyValuePairsArray.SetBelong(this.instance);
				}
				return r_RToKeyValuePairsArray;
			}
		}

		/// <summary>
		/// Void EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_REnsureCapacity_Int32;
		public virtual RMethod REnsureCapacity_Int32
		{
			get
			{
				if(r_REnsureCapacity_Int32 == null)
				{
					r_REnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_REnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_REnsureCapacity_Int32;
			}
		}

		/// <summary>
		/// System.Object GetByIndex(Int32)
		/// </summary>
		protected RMethod r_RGetByIndex_Int32;
		public virtual RMethod RGetByIndex_Int32
		{
			get
			{
				if(r_RGetByIndex_Int32 == null)
				{
					r_RGetByIndex_Int32 = new(this, "GetByIndex", 0, typeof(System.Int32));
					r_RGetByIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetByIndex_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator;
		public virtual RMethod RSystem__1__Collections__1__IEnumerable__1__GetEnumerator
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator == null)
				{
					r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator;
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
		/// System.Object GetKey(Int32)
		/// </summary>
		protected RMethod r_RGetKey_Int32;
		public virtual RMethod RGetKey_Int32
		{
			get
			{
				if(r_RGetKey_Int32 == null)
				{
					r_RGetKey_Int32 = new(this, "GetKey", 0, typeof(System.Int32));
					r_RGetKey_Int32.SetBelong(this.instance);
				}
				return r_RGetKey_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IList GetKeyList()
		/// </summary>
		protected RMethod r_RGetKeyList;
		public virtual RMethod RGetKeyList
		{
			get
			{
				if(r_RGetKeyList == null)
				{
					r_RGetKeyList = new(this, "GetKeyList", 0);
					r_RGetKeyList.SetBelong(this.instance);
				}
				return r_RGetKeyList;
			}
		}

		/// <summary>
		/// System.Collections.IList GetValueList()
		/// </summary>
		protected RMethod r_RGetValueList;
		public virtual RMethod RGetValueList
		{
			get
			{
				if(r_RGetValueList == null)
				{
					r_RGetValueList = new(this, "GetValueList", 0);
					r_RGetValueList.SetBelong(this.instance);
				}
				return r_RGetValueList;
			}
		}

		/// <summary>
		/// Int32 IndexOfKey(System.Object)
		/// </summary>
		protected RMethod r_RIndexOfKey_Object;
		public virtual RMethod RIndexOfKey_Object
		{
			get
			{
				if(r_RIndexOfKey_Object == null)
				{
					r_RIndexOfKey_Object = new(this, "IndexOfKey", 0, typeof(System.Object));
					r_RIndexOfKey_Object.SetBelong(this.instance);
				}
				return r_RIndexOfKey_Object;
			}
		}

		/// <summary>
		/// Int32 IndexOfValue(System.Object)
		/// </summary>
		protected RMethod r_RIndexOfValue_Object;
		public virtual RMethod RIndexOfValue_Object
		{
			get
			{
				if(r_RIndexOfValue_Object == null)
				{
					r_RIndexOfValue_Object = new(this, "IndexOfValue", 0, typeof(System.Object));
					r_RIndexOfValue_Object.SetBelong(this.instance);
				}
				return r_RIndexOfValue_Object;
			}
		}

		/// <summary>
		/// Void Insert(Int32, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RInsert_Int32_Object_Object;
		public virtual RMethod RInsert_Int32_Object_Object
		{
			get
			{
				if(r_RInsert_Int32_Object_Object == null)
				{
					r_RInsert_Int32_Object_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Object));
					r_RInsert_Int32_Object_Object.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Object_Object;
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
		/// Void Remove(System.Object)
		/// </summary>
		protected RMethod r_RRemove_Object;
		public virtual RMethod RRemove_Object
		{
			get
			{
				if(r_RRemove_Object == null)
				{
					r_RRemove_Object = new(this, "Remove", 0, typeof(System.Object));
					r_RRemove_Object.SetBelong(this.instance);
				}
				return r_RRemove_Object;
			}
		}

		/// <summary>
		/// Void SetByIndex(Int32, System.Object)
		/// </summary>
		protected RMethod r_RSetByIndex_Int32_Object;
		public virtual RMethod RSetByIndex_Int32_Object
		{
			get
			{
				if(r_RSetByIndex_Int32_Object == null)
				{
					r_RSetByIndex_Int32_Object = new(this, "SetByIndex", 0, typeof(System.Int32), typeof(System.Object));
					r_RSetByIndex_Int32_Object.SetBelong(this.instance);
				}
				return r_RSetByIndex_Int32_Object;
			}
		}

		/// <summary>
		/// System.Collections.SortedList Synchronized(System.Collections.SortedList)
		/// </summary>
		protected static RMethod r_RSynchronized_SortedList;
		public static RMethod RSynchronized_SortedList
		{
			get
			{
				if(r_RSynchronized_SortedList == null)
				{
					r_RSynchronized_SortedList = new(typeof(System.Collections.SortedList), "Synchronized", 0, typeof(System.Collections.SortedList));
					r_RSynchronized_SortedList.SetBelong(null);
				}
				return r_RSynchronized_SortedList;
			}
		}

		/// <summary>
		/// Void TrimToSize()
		/// </summary>
		protected RMethod r_RTrimToSize;
		public virtual RMethod RTrimToSize
		{
			get
			{
				if(r_RTrimToSize == null)
				{
					r_RTrimToSize = new(this, "TrimToSize", 0);
					r_RTrimToSize.SetBelong(this.instance);
				}
				return r_RTrimToSize;
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


        public RSortedList() : base("System.Collections.SortedList")
        {
        }

        public RSortedList(System.Object instance) : base("System.Collections.SortedList")
		{
            SetInstance(instance);
		}

        public RSortedList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortedList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(System.Object  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Contains(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsKey(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContainsKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsValue(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContainsValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @arrayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @arrayIndex};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ToKeyValuePairsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToKeyValuePairsArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void EnsureCapacity(System.Int32  @min)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min};
            var ___result = REnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetByIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetByIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.IEnumerator System__1__Collections__1__IEnumerable__1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual System.Object GetKey(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetKey_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.IList GetKeyList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetKeyList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public virtual System.Collections.IList GetValueList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueList.Invoke(___genericsType, ___parameters);

            return (System.Collections.IList)___result;
        }


        public virtual System.Int32 IndexOfKey(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RIndexOfKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfValue(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIndexOfValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Insert(System.Int32  @index, System.Object  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @key, @value};
            var ___result = RInsert_Int32_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetByIndex(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSetByIndex_Int32_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.SortedList Synchronized(System.Collections.SortedList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RSynchronized_SortedList.Invoke(___genericsType, ___parameters);

            return (System.Collections.SortedList)___result;
        }


        public virtual void TrimToSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimToSize.Invoke(___genericsType, ___parameters);

            
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
