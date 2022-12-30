using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.SortedDictionary`2
	/// </summary>
    public partial class RSortedDictionary<TKey, TValue> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.SortedDictionary`2+KeyCollection[TKey,TValue] _keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedDictionary<RField, RField>.RKeyCollection r__keys;
		public virtual RSystem.RCollections.RGeneric.RSortedDictionary<RField, RField>.RKeyCollection R_keys
		{
			get
			{
				if(r__keys == null)
				{
					r__keys = new(this, "_keys");
					r__keys.SetBelong(this.instance);
				}
				return r__keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedDictionary`2+ValueCollection[TKey,TValue] _values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedDictionary<RField, RField>.RValueCollection r__values;
		public virtual RSystem.RCollections.RGeneric.RSortedDictionary<RField, RField>.RValueCollection R_values
		{
			get
			{
				if(r__values == null)
				{
					r__values = new(this, "_values");
					r__values.SetBelong(this.instance);
				}
				return r__values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.TreeSet`1[System.Collections.Generic.KeyValuePair`2[TKey,TValue]] _set
		/// </summary>
		protected RSystem.RCollections.RGeneric.RTreeSet<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> r__set;
		public virtual RSystem.RCollections.RGeneric.RTreeSet<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> R_set
		{
			get
			{
				if(r__set == null)
				{
					r__set = new(this, "_set");
					r__set.SetBelong(this.instance);
				}
				return r__set;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly;
		public virtual RProperty RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly", -1);
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__get_IsReadOnly;
			}
		}

		/// <summary>
		/// TValue Item [TKey]
		/// </summary>
		protected RProperty r_Item_TKey;
		public virtual RProperty RItem_TKey
		{
			get
			{
				if(r_Item_TKey == null)
				{
					r_Item_TKey = new(this, "Item", -1, Type.MakeGenericMethodParameter(0));
					r_Item_TKey.SetBelong(this.instance);
				}
				return r_Item_TKey;
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
		/// System.Collections.Generic.IComparer`1[TKey] Comparer
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIComparer<RProperty> r_Comparer;
		public virtual RSystem.RCollections.RGeneric.RIComparer<RProperty> RComparer
		{
			get
			{
				if(r_Comparer == null)
				{
					r_Comparer = new(this, "Comparer", -1);
					r_Comparer.SetBelong(this.instance);
				}
				return r_Comparer;
			}
		}

		/// <summary>
		/// KeyCollection Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedDictionary<RProperty, RProperty>.RKeyCollection r_Keys;
		public virtual RSystem.RCollections.RGeneric.RSortedDictionary<RProperty, RProperty>.RKeyCollection RKeys
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
		/// System.Collections.Generic.ICollection`1[TKey] System.Collections.Generic.IDictionary<TKey,TValue>.Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys = new(this, "System.Collections.Generic.IDictionary<TKey,TValue>.Keys", -1);
					r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[TKey] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RProperty> r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RProperty> RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys = new(this, "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys", -1);
					r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Keys;
			}
		}

		/// <summary>
		/// ValueCollection Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedDictionary<RProperty, RProperty>.RValueCollection r_Values;
		public virtual RSystem.RCollections.RGeneric.RSortedDictionary<RProperty, RProperty>.RValueCollection RValues
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
		/// System.Collections.Generic.ICollection`1[TValue] System.Collections.Generic.IDictionary<TKey,TValue>.Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RICollection<RProperty> r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values;
		public virtual RSystem.RCollections.RGeneric.RICollection<RProperty> RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values = new(this, "System.Collections.Generic.IDictionary<TKey,TValue>.Values", -1);
					r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IDictionary__2__TKey__3__TValue__4____1__get_Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[TValue] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RProperty> r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RProperty> RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values = new(this, "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values", -1);
					r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IReadOnlyDictionary__2__TKey__3__TValue__4____1__get_Values;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.IsFixedSize
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize;
		public virtual RProperty RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize = new(this, "System.Collections.IDictionary.IsFixedSize", -1);
					r_RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__get_IsFixedSize;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly;
		public virtual RProperty RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly = new(this, "System.Collections.IDictionary.IsReadOnly", -1);
					r_RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__get_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Collections.ICollection System.Collections.IDictionary.Keys
		/// </summary>
		protected RSystem.RCollections.RICollection r_RSystem__1__Collections__1__IDictionary__1__get_Keys;
		public virtual RSystem.RCollections.RICollection RSystem__1__Collections__1__IDictionary__1__get_Keys
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__get_Keys == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__get_Keys = new(this, "System.Collections.IDictionary.Keys", -1);
					r_RSystem__1__Collections__1__IDictionary__1__get_Keys.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__get_Keys;
			}
		}

		/// <summary>
		/// System.Collections.ICollection System.Collections.IDictionary.Values
		/// </summary>
		protected RSystem.RCollections.RICollection r_RSystem__1__Collections__1__IDictionary__1__get_Values;
		public virtual RSystem.RCollections.RICollection RSystem__1__Collections__1__IDictionary__1__get_Values
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__get_Values == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__get_Values = new(this, "System.Collections.IDictionary.Values", -1);
					r_RSystem__1__Collections__1__IDictionary__1__get_Values.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__get_Values;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IDictionary.Item [System.Object]
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__IDictionary__1__get_Item_Object;
		public virtual RSystem.RObject RSystem__1__Collections__1__IDictionary__1__get_Item_Object
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__get_Item_Object == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__get_Item_Object = new(this, "System.Collections.IDictionary.Item", -1, typeof(System.Object));
					r_RSystem__1__Collections__1__IDictionary__1__get_Item_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__get_Item_Object;
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
		/// Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_;
			}
		}

		/// <summary>
		/// Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair`2[TKey,TValue])
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_ == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_ = new(this, "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)));
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_;
			}
		}

		/// <summary>
		/// Void Add(TKey, TValue)
		/// </summary>
		protected RMethod r_RAdd_TKey_TValue;
		public virtual RMethod RAdd_TKey_TValue
		{
			get
			{
				if(r_RAdd_TKey_TValue == null)
				{
					r_RAdd_TKey_TValue = new(this, "Add", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
					r_RAdd_TKey_TValue.SetBelong(this.instance);
				}
				return r_RAdd_TKey_TValue;
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
		/// Boolean ContainsKey(TKey)
		/// </summary>
		protected RMethod r_RContainsKey_TKey;
		public virtual RMethod RContainsKey_TKey
		{
			get
			{
				if(r_RContainsKey_TKey == null)
				{
					r_RContainsKey_TKey = new(this, "ContainsKey", 0, Type.MakeGenericMethodParameter(0));
					r_RContainsKey_TKey.SetBelong(this.instance);
				}
				return r_RContainsKey_TKey;
			}
		}

		/// <summary>
		/// Boolean ContainsValue(TValue)
		/// </summary>
		protected RMethod r_RContainsValue_TValue;
		public virtual RMethod RContainsValue_TValue
		{
			get
			{
				if(r_RContainsValue_TValue == null)
				{
					r_RContainsValue_TValue = new(this, "ContainsValue", 0, Type.MakeGenericMethodParameter(1));
					r_RContainsValue_TValue.SetBelong(this.instance);
				}
				return r_RContainsValue_TValue;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Collections.Generic.KeyValuePair`2[TKey,TValue][], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
		public virtual RMethod RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32
		{
			get
			{
				if(r_RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 == null)
				{
					r_RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Collections.Generic.KeyValuePair<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32;
			}
		}

		/// <summary>
		/// Enumerator GetEnumerator()
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
		/// System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[TKey,TValue]] System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", 0);
					r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean Remove(TKey)
		/// </summary>
		protected RMethod r_RRemove_TKey;
		public virtual RMethod RRemove_TKey
		{
			get
			{
				if(r_RRemove_TKey == null)
				{
					r_RRemove_TKey = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_TKey.SetBelong(this.instance);
				}
				return r_RRemove_TKey;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(TKey, TValue ByRef)
		/// </summary>
		protected RMethod r_RTryGetValue_TKey_Out_TValue;
		public virtual RMethod RTryGetValue_TKey_Out_TValue
		{
			get
			{
				if(r_RTryGetValue_TKey_Out_TValue == null)
				{
					r_RTryGetValue_TKey_Out_TValue = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RTryGetValue_TKey_Out_TValue.SetBelong(this.instance);
				}
				return r_RTryGetValue_TKey_Out_TValue;
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
		/// Void System.Collections.IDictionary.Add(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IDictionary__1__Add_Object_Object;
		public virtual RMethod RSystem__1__Collections__1__IDictionary__1__Add_Object_Object
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__Add_Object_Object == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__Add_Object_Object = new(this, "System.Collections.IDictionary.Add", 0, typeof(System.Object), typeof(System.Object));
					r_RSystem__1__Collections__1__IDictionary__1__Add_Object_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__Add_Object_Object;
			}
		}

		/// <summary>
		/// Boolean System.Collections.IDictionary.Contains(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IDictionary__1__Contains_Object;
		public virtual RMethod RSystem__1__Collections__1__IDictionary__1__Contains_Object
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__Contains_Object == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__Contains_Object = new(this, "System.Collections.IDictionary.Contains", 0, typeof(System.Object));
					r_RSystem__1__Collections__1__IDictionary__1__Contains_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__Contains_Object;
			}
		}

		/// <summary>
		/// Boolean IsCompatibleKey(System.Object)
		/// </summary>
		protected static RMethod r_RIsCompatibleKey_Object;
		public static RMethod RIsCompatibleKey_Object
		{
			get
			{
				if(r_RIsCompatibleKey_Object == null)
				{
					r_RIsCompatibleKey_Object = new(typeof(System.Collections.Generic.SortedDictionary<, >), "IsCompatibleKey", 0, typeof(System.Object));
					r_RIsCompatibleKey_Object.SetBelong(null);
				}
				return r_RIsCompatibleKey_Object;
			}
		}

		/// <summary>
		/// System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IDictionary__1__GetEnumerator;
		public virtual RMethod RSystem__1__Collections__1__IDictionary__1__GetEnumerator
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__GetEnumerator == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__GetEnumerator = new(this, "System.Collections.IDictionary.GetEnumerator", 0);
					r_RSystem__1__Collections__1__IDictionary__1__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__GetEnumerator;
			}
		}

		/// <summary>
		/// Void System.Collections.IDictionary.Remove(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IDictionary__1__Remove_Object;
		public virtual RMethod RSystem__1__Collections__1__IDictionary__1__Remove_Object
		{
			get
			{
				if(r_RSystem__1__Collections__1__IDictionary__1__Remove_Object == null)
				{
					r_RSystem__1__Collections__1__IDictionary__1__Remove_Object = new(this, "System.Collections.IDictionary.Remove", 0, typeof(System.Object));
					r_RSystem__1__Collections__1__IDictionary__1__Remove_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IDictionary__1__Remove_Object;
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


        public RSortedDictionary() : base("System.Collections.Generic.SortedDictionary`2")
        {
        }

        public RSortedDictionary(System.Object instance) : base("System.Collections.Generic.SortedDictionary`2")
		{
            SetInstance(instance);
		}

        public RSortedDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortedDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add(System.Collections.Generic.KeyValuePair<TKey, TValue>  @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Add_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains(System.Collections.Generic.KeyValuePair<TKey, TValue>  @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Contains_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove(System.Collections.Generic.KeyValuePair<TKey, TValue>  @keyValuePair)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyValuePair};
            var ___result = RSystem__1__Collections__1__Generic__1__ICollection__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__Remove_KeyValuePair_d_TKey_TValue_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(TKey  @key, TValue  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RAdd_TKey_TValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsKey(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContainsKey_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ContainsValue(TValue  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RContainsValue_TValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_KeyValuePair_d_TKey_TValue_p_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__Generic__1__IEnumerable__2__System__1__Collections__1__Generic__1__KeyValuePair__2__TKey__3__TValue__4____4____1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>)___result;
        }


        public virtual System.Boolean Remove(TKey  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RRemove_TKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(TKey  @key, out TValue  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RTryGetValue_TKey_Out_TValue.Invoke(___genericsType, ___parameters);
			value = (TValue)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void System__1__Collections__1__ICollection__1__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Collections__1__IDictionary__1__Add(System.Object  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RSystem__1__Collections__1__IDictionary__1__Add_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean System__1__Collections__1__IDictionary__1__Contains(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RSystem__1__Collections__1__IDictionary__1__Contains_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsCompatibleKey(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RIsCompatibleKey_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IDictionaryEnumerator System__1__Collections__1__IDictionary__1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IDictionary__1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IDictionaryEnumerator)___result;
        }


        public virtual void System__1__Collections__1__IDictionary__1__Remove(System.Object  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RSystem__1__Collections__1__IDictionary__1__Remove_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator System__1__Collections__1__IEnumerable__1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
