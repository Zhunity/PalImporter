using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{
	/// <summary>
	/// System.Collections.Generic.TreeSet`1
	/// </summary>
    public partial class RTreeSet<T> : RMember //
    {

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


        public RTreeSet() : base("System.Collections.Generic.TreeSet`1")
        {
        }

        public RTreeSet(System.Object instance) : base("System.Collections.Generic.TreeSet`1")
		{
            SetInstance(instance);
		}

        public RTreeSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTreeSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean AddIfNotPresent(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RAddIfNotPresent_T.Invoke(___genericsType, ___parameters);

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


        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsSubsetOf_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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
