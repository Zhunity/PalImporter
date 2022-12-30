using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.SortedSet`1
	/// </summary>
    public partial class RSortedSet<T> : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.SortedSet`1+Node[T] root
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode r_root;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode Rroot
		{
			get
			{
				if(r_root == null)
				{
					r_root = new(this, "root");
					r_root.SetBelong(this.instance);
				}
				return r_root;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IComparer`1[T] comparer
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIComparer<RField> r_comparer;
		public virtual RSystem.RCollections.RGeneric.RIComparer<RField> Rcomparer
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
		/// System.Int32 count
		/// </summary>
		protected RField r_count;
		public virtual RField Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
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
		/// System.Runtime.Serialization.SerializationInfo siInfo
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSerializationInfo r_siInfo;
		public virtual RSystem.RRuntime.RSerialization.RSerializationInfo RsiInfo
		{
			get
			{
				if(r_siInfo == null)
				{
					r_siInfo = new(this, "siInfo");
					r_siInfo.SetBelong(this.instance);
				}
				return r_siInfo;
			}
		}

		/// <summary>
		/// System.String ComparerName
		/// </summary>
		protected static RField r_ComparerName;
		public static RField RComparerName
		{
			get
			{
				if(r_ComparerName == null)
				{
					r_ComparerName = new(typeof(System.Collections.Generic.SortedSet<>), "ComparerName");
					r_ComparerName.SetBelong(null);
				}
				return r_ComparerName;
			}
		}

		/// <summary>
		/// System.String CountName
		/// </summary>
		protected static RField r_CountName;
		public static RField RCountName
		{
			get
			{
				if(r_CountName == null)
				{
					r_CountName = new(typeof(System.Collections.Generic.SortedSet<>), "CountName");
					r_CountName.SetBelong(null);
				}
				return r_CountName;
			}
		}

		/// <summary>
		/// System.String ItemsName
		/// </summary>
		protected static RField r_ItemsName;
		public static RField RItemsName
		{
			get
			{
				if(r_ItemsName == null)
				{
					r_ItemsName = new(typeof(System.Collections.Generic.SortedSet<>), "ItemsName");
					r_ItemsName.SetBelong(null);
				}
				return r_ItemsName;
			}
		}

		/// <summary>
		/// System.String VersionName
		/// </summary>
		protected static RField r_VersionName;
		public static RField RVersionName
		{
			get
			{
				if(r_VersionName == null)
				{
					r_VersionName = new(typeof(System.Collections.Generic.SortedSet<>), "VersionName");
					r_VersionName.SetBelong(null);
				}
				return r_VersionName;
			}
		}

		/// <summary>
		/// System.String TreeName
		/// </summary>
		protected static RField r_TreeName;
		public static RField RTreeName
		{
			get
			{
				if(r_TreeName == null)
				{
					r_TreeName = new(typeof(System.Collections.Generic.SortedSet<>), "TreeName");
					r_TreeName.SetBelong(null);
				}
				return r_TreeName;
			}
		}

		/// <summary>
		/// System.String NodeValueName
		/// </summary>
		protected static RField r_NodeValueName;
		public static RField RNodeValueName
		{
			get
			{
				if(r_NodeValueName == null)
				{
					r_NodeValueName = new(typeof(System.Collections.Generic.SortedSet<>), "NodeValueName");
					r_NodeValueName.SetBelong(null);
				}
				return r_NodeValueName;
			}
		}

		/// <summary>
		/// System.String EnumStartName
		/// </summary>
		protected static RField r_EnumStartName;
		public static RField REnumStartName
		{
			get
			{
				if(r_EnumStartName == null)
				{
					r_EnumStartName = new(typeof(System.Collections.Generic.SortedSet<>), "EnumStartName");
					r_EnumStartName.SetBelong(null);
				}
				return r_EnumStartName;
			}
		}

		/// <summary>
		/// System.String ReverseName
		/// </summary>
		protected static RField r_ReverseName;
		public static RField ReverseName
		{
			get
			{
				if(r_ReverseName == null)
				{
					r_ReverseName = new(typeof(System.Collections.Generic.SortedSet<>), "ReverseName");
					r_ReverseName.SetBelong(null);
				}
				return r_ReverseName;
			}
		}

		/// <summary>
		/// System.String EnumVersionName
		/// </summary>
		protected static RField r_EnumVersionName;
		public static RField REnumVersionName
		{
			get
			{
				if(r_EnumVersionName == null)
				{
					r_EnumVersionName = new(typeof(System.Collections.Generic.SortedSet<>), "EnumVersionName");
					r_EnumVersionName.SetBelong(null);
				}
				return r_EnumVersionName;
			}
		}

		/// <summary>
		/// System.String MinName
		/// </summary>
		protected static RField r_MinName;
		public static RField RMinName
		{
			get
			{
				if(r_MinName == null)
				{
					r_MinName = new(typeof(System.Collections.Generic.SortedSet<>), "MinName");
					r_MinName.SetBelong(null);
				}
				return r_MinName;
			}
		}

		/// <summary>
		/// System.String MaxName
		/// </summary>
		protected static RField r_MaxName;
		public static RField RMaxName
		{
			get
			{
				if(r_MaxName == null)
				{
					r_MaxName = new(typeof(System.Collections.Generic.SortedSet<>), "MaxName");
					r_MaxName.SetBelong(null);
				}
				return r_MaxName;
			}
		}

		/// <summary>
		/// System.String LowerBoundActiveName
		/// </summary>
		protected static RField r_LowerBoundActiveName;
		public static RField RLowerBoundActiveName
		{
			get
			{
				if(r_LowerBoundActiveName == null)
				{
					r_LowerBoundActiveName = new(typeof(System.Collections.Generic.SortedSet<>), "LowerBoundActiveName");
					r_LowerBoundActiveName.SetBelong(null);
				}
				return r_LowerBoundActiveName;
			}
		}

		/// <summary>
		/// System.String UpperBoundActiveName
		/// </summary>
		protected static RField r_UpperBoundActiveName;
		public static RField RUpperBoundActiveName
		{
			get
			{
				if(r_UpperBoundActiveName == null)
				{
					r_UpperBoundActiveName = new(typeof(System.Collections.Generic.SortedSet<>), "UpperBoundActiveName");
					r_UpperBoundActiveName.SetBelong(null);
				}
				return r_UpperBoundActiveName;
			}
		}

		/// <summary>
		/// System.Int32 StackAllocThreshold
		/// </summary>
		protected static RField r_StackAllocThreshold;
		public static RField RStackAllocThreshold
		{
			get
			{
				if(r_StackAllocThreshold == null)
				{
					r_StackAllocThreshold = new(typeof(System.Collections.Generic.SortedSet<>), "StackAllocThreshold");
					r_StackAllocThreshold.SetBelong(null);
				}
				return r_StackAllocThreshold;
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
		/// System.Collections.Generic.IComparer`1[T] Comparer
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
		/// Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly;
		public virtual RProperty RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly = new(this, "System.Collections.Generic.ICollection<T>.IsReadOnly", -1);
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__get_IsReadOnly;
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
		/// T Min
		/// </summary>
		protected RProperty r_Min;
		public virtual RProperty RMin
		{
			get
			{
				if(r_Min == null)
				{
					r_Min = new(this, "Min", -1);
					r_Min.SetBelong(this.instance);
				}
				return r_Min;
			}
		}

		/// <summary>
		/// T MinInternal
		/// </summary>
		protected RProperty r_MinInternal;
		public virtual RProperty RMinInternal
		{
			get
			{
				if(r_MinInternal == null)
				{
					r_MinInternal = new(this, "MinInternal", -1);
					r_MinInternal.SetBelong(this.instance);
				}
				return r_MinInternal;
			}
		}

		/// <summary>
		/// T Max
		/// </summary>
		protected RProperty r_Max;
		public virtual RProperty RMax
		{
			get
			{
				if(r_Max == null)
				{
					r_Max = new(this, "Max", -1);
					r_Max.SetBelong(this.instance);
				}
				return r_Max;
			}
		}

		/// <summary>
		/// T MaxInternal
		/// </summary>
		protected RProperty r_MaxInternal;
		public virtual RProperty RMaxInternal
		{
			get
			{
				if(r_MaxInternal == null)
				{
					r_MaxInternal = new(this, "MaxInternal", -1);
					r_MaxInternal.SetBelong(this.instance);
				}
				return r_MaxInternal;
			}
		}

		/// <summary>
		/// Void AddAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RAddAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RAddAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RAddAllElements_IEnumerable_d_T_p_ == null)
				{
					r_RAddAllElements_IEnumerable_d_T_p_ = new(this, "AddAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void RemoveAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RRemoveAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RRemoveAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RRemoveAllElements_IEnumerable_d_T_p_ == null)
				{
					r_RRemoveAllElements_IEnumerable_d_T_p_ = new(this, "RemoveAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean ContainsAllElements(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RContainsAllElements_IEnumerable_d_T_p_;
		public virtual RMethod RContainsAllElements_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RContainsAllElements_IEnumerable_d_T_p_ == null)
				{
					r_RContainsAllElements_IEnumerable_d_T_p_ = new(this, "ContainsAllElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RContainsAllElements_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RContainsAllElements_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate`1[T])
		/// </summary>
		protected RMethod r_RInOrderTreeWalk_TreeWalkPredicate_d_T_p_;
		public virtual RMethod RInOrderTreeWalk_TreeWalkPredicate_d_T_p_
		{
			get
			{
				if(r_RInOrderTreeWalk_TreeWalkPredicate_d_T_p_ == null)
				{
					r_RInOrderTreeWalk_TreeWalkPredicate_d_T_p_ = new(this, "InOrderTreeWalk", 0,  ReleactionUtils.GetType("System.Collections.Generic.TreeWalkPredicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RInOrderTreeWalk_TreeWalkPredicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RInOrderTreeWalk_TreeWalkPredicate_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean BreadthFirstTreeWalk(System.Collections.Generic.TreeWalkPredicate`1[T])
		/// </summary>
		protected RMethod r_RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_;
		public virtual RMethod RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_
		{
			get
			{
				if(r_RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_ == null)
				{
					r_RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_ = new(this, "BreadthFirstTreeWalk", 0,  ReleactionUtils.GetType("System.Collections.Generic.TreeWalkPredicate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RBreadthFirstTreeWalk_TreeWalkPredicate_d_T_p_;
			}
		}

		/// <summary>
		/// Void VersionCheck()
		/// </summary>
		protected RMethod r_RVersionCheck;
		public virtual RMethod RVersionCheck
		{
			get
			{
				if(r_RVersionCheck == null)
				{
					r_RVersionCheck = new(this, "VersionCheck", 0);
					r_RVersionCheck.SetBelong(this.instance);
				}
				return r_RVersionCheck;
			}
		}

		/// <summary>
		/// Boolean IsWithinRange(T)
		/// </summary>
		protected RMethod r_RIsWithinRange_T;
		public virtual RMethod RIsWithinRange_T
		{
			get
			{
				if(r_RIsWithinRange_T == null)
				{
					r_RIsWithinRange_T = new(this, "IsWithinRange", 0, Type.MakeGenericMethodParameter(0));
					r_RIsWithinRange_T.SetBelong(this.instance);
				}
				return r_RIsWithinRange_T;
			}
		}

		/// <summary>
		/// Boolean Add(T)
		/// </summary>
		protected RMethod r_RAdd_T;
		public virtual RMethod RAdd_T
		{
			get
			{
				if(r_RAdd_T == null)
				{
					r_RAdd_T = new(this, "Add", 0, Type.MakeGenericMethodParameter(0));
					r_RAdd_T.SetBelong(this.instance);
				}
				return r_RAdd_T;
			}
		}

		/// <summary>
		/// Void System.Collections.Generic.ICollection<T>.Add(T)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T == null)
				{
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T = new(this, "System.Collections.Generic.ICollection<T>.Add", 0, Type.MakeGenericMethodParameter(0));
					r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T;
			}
		}

		/// <summary>
		/// Boolean AddIfNotPresent(T)
		/// </summary>
		protected RMethod r_RAddIfNotPresent_T;
		public virtual RMethod RAddIfNotPresent_T
		{
			get
			{
				if(r_RAddIfNotPresent_T == null)
				{
					r_RAddIfNotPresent_T = new(this, "AddIfNotPresent", 0, Type.MakeGenericMethodParameter(0));
					r_RAddIfNotPresent_T.SetBelong(this.instance);
				}
				return r_RAddIfNotPresent_T;
			}
		}

		/// <summary>
		/// Boolean Remove(T)
		/// </summary>
		protected RMethod r_RRemove_T;
		public virtual RMethod RRemove_T
		{
			get
			{
				if(r_RRemove_T == null)
				{
					r_RRemove_T = new(this, "Remove", 0, Type.MakeGenericMethodParameter(0));
					r_RRemove_T.SetBelong(this.instance);
				}
				return r_RRemove_T;
			}
		}

		/// <summary>
		/// Boolean DoRemove(T)
		/// </summary>
		protected RMethod r_RDoRemove_T;
		public virtual RMethod RDoRemove_T
		{
			get
			{
				if(r_RDoRemove_T == null)
				{
					r_RDoRemove_T = new(this, "DoRemove", 0, Type.MakeGenericMethodParameter(0));
					r_RDoRemove_T.SetBelong(this.instance);
				}
				return r_RDoRemove_T;
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
		/// Boolean Contains(T)
		/// </summary>
		protected RMethod r_RContains_T;
		public virtual RMethod RContains_T
		{
			get
			{
				if(r_RContains_T == null)
				{
					r_RContains_T = new(this, "Contains", 0, Type.MakeGenericMethodParameter(0));
					r_RContains_T.SetBelong(this.instance);
				}
				return r_RContains_T;
			}
		}

		/// <summary>
		/// Void CopyTo(T[])
		/// </summary>
		protected RMethod r_RCopyTo_TArray;
		public virtual RMethod RCopyTo_TArray
		{
			get
			{
				if(r_RCopyTo_TArray == null)
				{
					r_RCopyTo_TArray = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RCopyTo_TArray.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_TArray_Int32;
		public virtual RMethod RCopyTo_TArray_Int32
		{
			get
			{
				if(r_RCopyTo_TArray_Int32 == null)
				{
					r_RCopyTo_TArray_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_TArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(T[], Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_TArray_Int32_Int32;
		public virtual RMethod RCopyTo_TArray_Int32_Int32
		{
			get
			{
				if(r_RCopyTo_TArray_Int32_Int32 == null)
				{
					r_RCopyTo_TArray_Int32_Int32 = new(this, "CopyTo", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTo_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_TArray_Int32_Int32;
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
		/// System.Collections.Generic.IEnumerator`1[T] System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator;
		public virtual RMethod RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator = new(this, "System.Collections.Generic.IEnumerable<T>.GetEnumerator", 0);
					r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator;
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
		/// Void InsertionBalance(Node, Node ByRef, Node, Node)
		/// </summary>
		protected RMethod r_RInsertionBalance_Node_Ref_Node_Node_Node;
		public virtual RMethod RInsertionBalance_Node_Ref_Node_Node_Node
		{
			get
			{
				if(r_RInsertionBalance_Node_Ref_Node_Node_Node == null)
				{
					r_RInsertionBalance_Node_Ref_Node_Node_Node = new(this, "InsertionBalance", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)).MakeByRefType(),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RInsertionBalance_Node_Ref_Node_Node_Node.SetBelong(this.instance);
				}
				return r_RInsertionBalance_Node_Ref_Node_Node_Node;
			}
		}

		/// <summary>
		/// Void ReplaceChildOrRoot(Node, Node, Node)
		/// </summary>
		protected RMethod r_RReplaceChildOrRoot_Node_Node_Node;
		public virtual RMethod RReplaceChildOrRoot_Node_Node_Node
		{
			get
			{
				if(r_RReplaceChildOrRoot_Node_Node_Node == null)
				{
					r_RReplaceChildOrRoot_Node_Node_Node = new(this, "ReplaceChildOrRoot", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RReplaceChildOrRoot_Node_Node_Node.SetBelong(this.instance);
				}
				return r_RReplaceChildOrRoot_Node_Node_Node;
			}
		}

		/// <summary>
		/// Void ReplaceNode(Node, Node, Node, Node)
		/// </summary>
		protected RMethod r_RReplaceNode_Node_Node_Node_Node;
		public virtual RMethod RReplaceNode_Node_Node_Node_Node
		{
			get
			{
				if(r_RReplaceNode_Node_Node_Node_Node == null)
				{
					r_RReplaceNode_Node_Node_Node_Node = new(this, "ReplaceNode", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RReplaceNode_Node_Node_Node_Node.SetBelong(this.instance);
				}
				return r_RReplaceNode_Node_Node_Node_Node;
			}
		}

		/// <summary>
		/// Node FindNode(T)
		/// </summary>
		protected RMethod r_RFindNode_T;
		public virtual RMethod RFindNode_T
		{
			get
			{
				if(r_RFindNode_T == null)
				{
					r_RFindNode_T = new(this, "FindNode", 0, Type.MakeGenericMethodParameter(0));
					r_RFindNode_T.SetBelong(this.instance);
				}
				return r_RFindNode_T;
			}
		}

		/// <summary>
		/// Int32 InternalIndexOf(T)
		/// </summary>
		protected RMethod r_RInternalIndexOf_T;
		public virtual RMethod RInternalIndexOf_T
		{
			get
			{
				if(r_RInternalIndexOf_T == null)
				{
					r_RInternalIndexOf_T = new(this, "InternalIndexOf", 0, Type.MakeGenericMethodParameter(0));
					r_RInternalIndexOf_T.SetBelong(this.instance);
				}
				return r_RInternalIndexOf_T;
			}
		}

		/// <summary>
		/// Node FindRange(T, T)
		/// </summary>
		protected RMethod r_RFindRange_T_T;
		public virtual RMethod RFindRange_T_T
		{
			get
			{
				if(r_RFindRange_T_T == null)
				{
					r_RFindRange_T_T = new(this, "FindRange", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
					r_RFindRange_T_T.SetBelong(this.instance);
				}
				return r_RFindRange_T_T;
			}
		}

		/// <summary>
		/// Node FindRange(T, T, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RFindRange_T_T_Boolean_Boolean;
		public virtual RMethod RFindRange_T_T_Boolean_Boolean
		{
			get
			{
				if(r_RFindRange_T_T_Boolean_Boolean == null)
				{
					r_RFindRange_T_T_Boolean_Boolean = new(this, "FindRange", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), typeof(System.Boolean), typeof(System.Boolean));
					r_RFindRange_T_T_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RFindRange_T_T_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateVersion()
		/// </summary>
		protected RMethod r_RUpdateVersion;
		public virtual RMethod RUpdateVersion
		{
			get
			{
				if(r_RUpdateVersion == null)
				{
					r_RUpdateVersion = new(this, "UpdateVersion", 0);
					r_RUpdateVersion.SetBelong(this.instance);
				}
				return r_RUpdateVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.SortedSet`1[T]] CreateSetComparer()
		/// </summary>
		protected static RMethod r_RCreateSetComparer;
		public static RMethod RCreateSetComparer
		{
			get
			{
				if(r_RCreateSetComparer == null)
				{
					r_RCreateSetComparer = new(typeof(System.Collections.Generic.SortedSet<>), "CreateSetComparer", 0);
					r_RCreateSetComparer.SetBelong(null);
				}
				return r_RCreateSetComparer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEqualityComparer`1[System.Collections.Generic.SortedSet`1[T]] CreateSetComparer(System.Collections.Generic.IEqualityComparer`1[T])
		/// </summary>
		protected static RMethod r_RCreateSetComparer_IEqualityComparer_d_T_p_;
		public static RMethod RCreateSetComparer_IEqualityComparer_d_T_p_
		{
			get
			{
				if(r_RCreateSetComparer_IEqualityComparer_d_T_p_ == null)
				{
					r_RCreateSetComparer_IEqualityComparer_d_T_p_ = new(typeof(System.Collections.Generic.SortedSet<>), "CreateSetComparer", 0, typeof(System.Collections.Generic.IEqualityComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCreateSetComparer_IEqualityComparer_d_T_p_.SetBelong(null);
				}
				return r_RCreateSetComparer_IEqualityComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SortedSetEquals(System.Collections.Generic.SortedSet`1[T], System.Collections.Generic.SortedSet`1[T], System.Collections.Generic.IComparer`1[T])
		/// </summary>
		protected static RMethod r_RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_;
		public static RMethod RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_
		{
			get
			{
				if(r_RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_ == null)
				{
					r_RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_ = new(typeof(System.Collections.Generic.SortedSet<>), "SortedSetEquals", 0, typeof(System.Collections.Generic.SortedSet<>), typeof(System.Collections.Generic.SortedSet<>), typeof(System.Collections.Generic.IComparer<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_.SetBelong(null);
				}
				return r_RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean HasEqualComparer(System.Collections.Generic.SortedSet`1[T])
		/// </summary>
		protected RMethod r_RHasEqualComparer_SortedSet_d_T_p_;
		public virtual RMethod RHasEqualComparer_SortedSet_d_T_p_
		{
			get
			{
				if(r_RHasEqualComparer_SortedSet_d_T_p_ == null)
				{
					r_RHasEqualComparer_SortedSet_d_T_p_ = new(this, "HasEqualComparer", 0, typeof(System.Collections.Generic.SortedSet<>));
					r_RHasEqualComparer_SortedSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RHasEqualComparer_SortedSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void UnionWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RUnionWith_IEnumerable_d_T_p_;
		public virtual RMethod RUnionWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RUnionWith_IEnumerable_d_T_p_ == null)
				{
					r_RUnionWith_IEnumerable_d_T_p_ = new(this, "UnionWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RUnionWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RUnionWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Node ConstructRootFromSortedArray(T[], Int32, Int32, Node)
		/// </summary>
		protected static RMethod r_RConstructRootFromSortedArray_TArray_Int32_Int32_Node;
		public static RMethod RConstructRootFromSortedArray_TArray_Int32_Int32_Node
		{
			get
			{
				if(r_RConstructRootFromSortedArray_TArray_Int32_Int32_Node == null)
				{
					r_RConstructRootFromSortedArray_TArray_Int32_Int32_Node = new(typeof(System.Collections.Generic.SortedSet<>), "ConstructRootFromSortedArray", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RConstructRootFromSortedArray_TArray_Int32_Int32_Node.SetBelong(null);
				}
				return r_RConstructRootFromSortedArray_TArray_Int32_Int32_Node;
			}
		}

		/// <summary>
		/// Void IntersectWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIntersectWith_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIntersectWith_IEnumerable_d_T_p_ == null)
				{
					r_RIntersectWith_IEnumerable_d_T_p_ = new(this, "IntersectWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIntersectWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIntersectWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIntersectWithEnumerable_IEnumerable_d_T_p_;
		public virtual RMethod RIntersectWithEnumerable_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIntersectWithEnumerable_IEnumerable_d_T_p_ == null)
				{
					r_RIntersectWithEnumerable_IEnumerable_d_T_p_ = new(this, "IntersectWithEnumerable", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIntersectWithEnumerable_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIntersectWithEnumerable_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void ExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_RExceptWith_IEnumerable_d_T_p_ = new(this, "ExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWith(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RSymmetricExceptWith_IEnumerable_d_T_p_;
		public virtual RMethod RSymmetricExceptWith_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RSymmetricExceptWith_IEnumerable_d_T_p_ == null)
				{
					r_RSymmetricExceptWith_IEnumerable_d_T_p_ = new(this, "SymmetricExceptWith", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSymmetricExceptWith_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWith_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithSameComparer(System.Collections.Generic.SortedSet`1[T])
		/// </summary>
		protected RMethod r_RSymmetricExceptWithSameComparer_SortedSet_d_T_p_;
		public virtual RMethod RSymmetricExceptWithSameComparer_SortedSet_d_T_p_
		{
			get
			{
				if(r_RSymmetricExceptWithSameComparer_SortedSet_d_T_p_ == null)
				{
					r_RSymmetricExceptWithSameComparer_SortedSet_d_T_p_ = new(this, "SymmetricExceptWithSameComparer", 0, typeof(System.Collections.Generic.SortedSet<>));
					r_RSymmetricExceptWithSameComparer_SortedSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWithSameComparer_SortedSet_d_T_p_;
			}
		}

		/// <summary>
		/// Void SymmetricExceptWithSameComparer(T[], Int32)
		/// </summary>
		protected RMethod r_RSymmetricExceptWithSameComparer_TArray_Int32;
		public virtual RMethod RSymmetricExceptWithSameComparer_TArray_Int32
		{
			get
			{
				if(r_RSymmetricExceptWithSameComparer_TArray_Int32 == null)
				{
					r_RSymmetricExceptWithSameComparer_TArray_Int32 = new(this, "SymmetricExceptWithSameComparer", 0, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32));
					r_RSymmetricExceptWithSameComparer_TArray_Int32.SetBelong(this.instance);
				}
				return r_RSymmetricExceptWithSameComparer_TArray_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsSubsetOf_IEnumerable_d_T_p_ = new(this, "IsSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOfSortedSetWithSameComparer(System.Collections.Generic.SortedSet`1[T])
		/// </summary>
		protected RMethod r_RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_;
		public virtual RMethod RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_
		{
			get
			{
				if(r_RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_ == null)
				{
					r_RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_ = new(this, "IsSubsetOfSortedSetWithSameComparer", 0, typeof(System.Collections.Generic.SortedSet<>));
					r_RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsProperSubsetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSubsetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsProperSubsetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsProperSubsetOf_IEnumerable_d_T_p_ = new(this, "IsProperSubsetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsProperSubsetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsProperSubsetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsSupersetOf_IEnumerable_d_T_p_ = new(this, "IsSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RIsProperSupersetOf_IEnumerable_d_T_p_;
		public virtual RMethod RIsProperSupersetOf_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RIsProperSupersetOf_IEnumerable_d_T_p_ == null)
				{
					r_RIsProperSupersetOf_IEnumerable_d_T_p_ = new(this, "IsProperSupersetOf", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RIsProperSupersetOf_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RIsProperSupersetOf_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean SetEquals(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RSetEquals_IEnumerable_d_T_p_;
		public virtual RMethod RSetEquals_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RSetEquals_IEnumerable_d_T_p_ == null)
				{
					r_RSetEquals_IEnumerable_d_T_p_ = new(this, "SetEquals", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetEquals_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetEquals_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean Overlaps(System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_ROverlaps_IEnumerable_d_T_p_;
		public virtual RMethod ROverlaps_IEnumerable_d_T_p_
		{
			get
			{
				if(r_ROverlaps_IEnumerable_d_T_p_ == null)
				{
					r_ROverlaps_IEnumerable_d_T_p_ = new(this, "Overlaps", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_ROverlaps_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_ROverlaps_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable`1[T], Boolean)
		/// </summary>
		protected RMethod r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
		public virtual RMethod RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean
		{
			get
			{
				if(r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean == null)
				{
					r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean = new(this, "CheckUniqueAndUnfoundElements", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Boolean));
					r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.SetBelong(this.instance);
				}
				return r_RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 RemoveWhere(System.Predicate`1[T])
		/// </summary>
		protected RMethod r_RRemoveWhere_Predicate_d_T_p_;
		public virtual RMethod RRemoveWhere_Predicate_d_T_p_
		{
			get
			{
				if(r_RRemoveWhere_Predicate_d_T_p_ == null)
				{
					r_RRemoveWhere_Predicate_d_T_p_ = new(this, "RemoveWhere", 0, typeof(System.Predicate<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveWhere_Predicate_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveWhere_Predicate_d_T_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[T] Reverse()
		/// </summary>
		protected RMethod r_RReverse;
		public virtual RMethod RReverse
		{
			get
			{
				if(r_RReverse == null)
				{
					r_RReverse = new(this, "Reverse", 0);
					r_RReverse.SetBelong(this.instance);
				}
				return r_RReverse;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedSet`1[T] GetViewBetween(T, T)
		/// </summary>
		protected RMethod r_RGetViewBetween_T_T;
		public virtual RMethod RGetViewBetween_T_T
		{
			get
			{
				if(r_RGetViewBetween_T_T == null)
				{
					r_RGetViewBetween_T_T = new(this, "GetViewBetween", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0));
					r_RGetViewBetween_T_T.SetBelong(this.instance);
				}
				return r_RGetViewBetween_T_T;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object;
		public virtual RMethod RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object == null)
				{
					r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_ROnDeserialization_Object;
		public virtual RMethod ROnDeserialization_Object
		{
			get
			{
				if(r_ROnDeserialization_Object == null)
				{
					r_ROnDeserialization_Object = new(this, "OnDeserialization", 0, typeof(System.Object));
					r_ROnDeserialization_Object.SetBelong(this.instance);
				}
				return r_ROnDeserialization_Object;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(T, T ByRef)
		/// </summary>
		protected RMethod r_RTryGetValue_T_Out_T;
		public virtual RMethod RTryGetValue_T_Out_T
		{
			get
			{
				if(r_RTryGetValue_T_Out_T == null)
				{
					r_RTryGetValue_T_Out_T = new(this, "TryGetValue", 0, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetValue_T_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetValue_T_Out_T;
			}
		}

		/// <summary>
		/// Int32 Log2(Int32)
		/// </summary>
		protected static RMethod r_RLog2_Int32;
		public static RMethod RLog2_Int32
		{
			get
			{
				if(r_RLog2_Int32 == null)
				{
					r_RLog2_Int32 = new(typeof(System.Collections.Generic.SortedSet<>), "Log2", 0, typeof(System.Int32));
					r_RLog2_Int32.SetBelong(null);
				}
				return r_RLog2_Int32;
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


        public RSortedSet() : base("System.Collections.Generic.SortedSet`1")
        {
        }

        public RSortedSet(System.Object instance) : base("System.Collections.Generic.SortedSet`1")
		{
            SetInstance(instance);
		}

        public RSortedSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortedSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddAllElements(System.Collections.Generic.IEnumerable<T>  @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collection};
            var ___result = RAddAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllElements(System.Collections.Generic.IEnumerable<T>  @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collection};
            var ___result = RRemoveAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T>  @collection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@collection};
            var ___result = RContainsAllElements_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void VersionCheck()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVersionCheck.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsWithinRange(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RIsWithinRange_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Add(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAdd_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RSystem__1__Collections__1__Generic__1__ICollection__2__T__4____1__Add_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddIfNotPresent(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAddIfNotPresent_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Remove(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DoRemove(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RDoRemove_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RContains_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CopyTo(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(T[]  @array, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @count};
            var ___result = RCopyTo_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Collections__1__ICollection__1__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.Generic.IEnumerator<T> System__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__Generic__1__IEnumerable__2__T__4____1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerator<T>)___result;
        }


        public virtual System.Collections.IEnumerator System__1__Collections__1__IEnumerable__1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }





        public virtual System.Object FindNode(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RFindNode_T.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 InternalIndexOf(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RInternalIndexOf_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object FindRange(T  @from, T  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RFindRange_T_T.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object FindRange(T  @from, T  @to, System.Boolean  @lowerBoundActive, System.Boolean  @upperBoundActive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @lowerBoundActive, @upperBoundActive};
            var ___result = RFindRange_T_T_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void UpdateVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateVersion.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateSetComparer.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>)___result;
        }


        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer(System.Collections.Generic.IEqualityComparer<T>  @memberEqualityComparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberEqualityComparer};
            var ___result = RCreateSetComparer_IEqualityComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>)___result;
        }


        public static System.Boolean SortedSetEquals(System.Collections.Generic.SortedSet<T>  @set1, System.Collections.Generic.SortedSet<T>  @set2, System.Collections.Generic.IComparer<T>  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@set1, @set2, @comparer};
            var ___result = RSortedSetEquals_SortedSet_d_T_p__SortedSet_d_T_p__IComparer_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEqualComparer(System.Collections.Generic.SortedSet<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasEqualComparer_SortedSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UnionWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnionWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersectWithEnumerable_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExceptWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWith_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWithSameComparer(System.Collections.Generic.SortedSet<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSymmetricExceptWithSameComparer_SortedSet_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SymmetricExceptWithSameComparer(T[]  @other, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @count};
            var ___result = RSymmetricExceptWithSameComparer_TArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSubsetOfSortedSetWithSameComparer(System.Collections.Generic.SortedSet<T>  @asSorted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asSorted};
            var ___result = RIsSubsetOfSortedSetWithSameComparer_SortedSet_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsProperSupersetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RSetEquals_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = ROverlaps_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T>  @other, System.Boolean  @returnIfUnfound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @returnIfUnfound};
            var ___result = RCheckUniqueAndUnfoundElements_IEnumerable_d_T_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 RemoveWhere(System.Predicate<T>  @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RRemoveWhere_Predicate_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<T> Reverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReverse.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<T>)___result;
        }


        public virtual System.Collections.Generic.SortedSet<T> GetViewBetween(T  @lowerValue, T  @upperValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowerValue, @upperValue};
            var ___result = RGetViewBetween_T_T.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.SortedSet<T>)___result;
        }


        public virtual void System__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = ROnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetValue(T  @equalValue, out T  @actualValue)
        {
			actualValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equalValue, @actualValue};
            var ___result = RTryGetValue_T_Out_T.Invoke(___genericsType, ___parameters);
			actualValue = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Int32 Log2(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLog2_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
