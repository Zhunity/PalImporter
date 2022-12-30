using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RCollections
{public partial class RNativeArray<T>
{
	
	/// <summary>
	/// Unity.Collections.NativeArray`1+ReadOnly
	/// </summary>
    public partial class RReadOnly : RMember //
    {

		/// <summary>
		/// System.Void* m_Buffer
		/// </summary>
		protected RFieldPointer<RField> r_m_Buffer;
		public virtual RFieldPointer<RField> Rm_Buffer
		{
			get
			{
				if(r_m_Buffer == null)
				{
					r_m_Buffer = new(this, "m_Buffer");
					r_m_Buffer.SetBelong(this.instance);
				}
				return r_m_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RField r_m_Length;
		public virtual RField Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_m_Safety;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle Rm_Safety
		{
			get
			{
				if(r_m_Safety == null)
				{
					r_m_Safety = new(this, "m_Safety");
					r_m_Safety.SetBelong(this.instance);
				}
				return r_m_Safety;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// T Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
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
		/// Boolean IsCreated
		/// </summary>
		protected RProperty r_IsCreated;
		public virtual RProperty RIsCreated
		{
			get
			{
				if(r_IsCreated == null)
				{
					r_IsCreated = new(this, "IsCreated", -1);
					r_IsCreated.SetBelong(this.instance);
				}
				return r_IsCreated;
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
		/// Void CopyTo(Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RCopyTo_NativeArray_d_T_p_;
		public virtual RMethod RCopyTo_NativeArray_d_T_p_
		{
			get
			{
				if(r_RCopyTo_NativeArray_d_T_p_ == null)
				{
					r_RCopyTo_NativeArray_d_T_p_ = new(this, "CopyTo", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RCopyTo_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RCopyTo_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// T[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
			}
		}

		/// <summary>
		/// ReadOnly Reinterpret[U]()
		/// </summary>
		protected RMethod r_RReinterpret_GU;
		public virtual RMethod RReinterpret_GU
		{
			get
			{
				if(r_RReinterpret_GU == null)
				{
					r_RReinterpret_GU = new(this, "Reinterpret", 1);
					r_RReinterpret_GU.SetBelong(this.instance);
				}
				return r_RReinterpret_GU;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_RCheckElementReadAccess_Int32;
		public virtual RMethod RCheckElementReadAccess_Int32
		{
			get
			{
				if(r_RCheckElementReadAccess_Int32 == null)
				{
					r_RCheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
					r_RCheckElementReadAccess_Int32.SetBelong(this.instance);
				}
				return r_RCheckElementReadAccess_Int32;
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
		/// System.ReadOnlySpan`1[T] AsReadOnlySpan()
		/// </summary>
		protected RMethod r_RAsReadOnlySpan;
		public virtual RMethod RAsReadOnlySpan
		{
			get
			{
				if(r_RAsReadOnlySpan == null)
				{
					r_RAsReadOnlySpan = new(this, "AsReadOnlySpan", 0);
					r_RAsReadOnlySpan.SetBelong(this.instance);
				}
				return r_RAsReadOnlySpan;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[T] op_Implicit(ReadOnly ByRef)
		/// </summary>
		protected static RMethod r_Rop_Implicit_In_ReadOnly;
		public static RMethod Rop_Implicit_In_ReadOnly
		{
			get
			{
				if(r_Rop_Implicit_In_ReadOnly == null)
				{
					r_Rop_Implicit_In_ReadOnly = new( ReleactionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly"), "op_Implicit", 0,  ReleactionUtils.GetType("Unity.Collections.NativeArray`1+ReadOnly").MakeByRefType());
					r_Rop_Implicit_In_ReadOnly.SetBelong(null);
				}
				return r_Rop_Implicit_In_ReadOnly;
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


        public RReadOnly() : base("Unity.Collections.NativeArray`1+ReadOnly")
        {
        }

        public RReadOnly(System.Object instance) : base("Unity.Collections.NativeArray`1+ReadOnly")
		{
            SetInstance(instance);
		}

        public RReadOnly(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReadOnly(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CopyTo(T[]  @array)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array};
            var ___result = RCopyTo_TArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual T[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Object Reinterpret<U>() where U : struct
        {

            var ___genericsType = new Type[] {typeof(U)};
            var ___parameters = new object[]{};
            var ___result = RReinterpret_GU.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CheckElementReadAccess(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Object AsReadOnlySpan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsReadOnlySpan.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}