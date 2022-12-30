using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections
{
	/// <summary>
	/// System.Collections.BitArray
	/// </summary>
    public partial class RBitArray : RMember //
    {

		/// <summary>
		/// System.Int32[] m_array
		/// </summary>
		protected RFieldArray<RField> r_m_array;
		public virtual RFieldArray<RField> Rm_array
		{
			get
			{
				if(r_m_array == null)
				{
					r_m_array = new(this, "m_array");
					r_m_array.SetBelong(this.instance);
				}
				return r_m_array;
			}
		}

		/// <summary>
		/// System.Int32 m_length
		/// </summary>
		protected RField r_m_length;
		public virtual RField Rm_length
		{
			get
			{
				if(r_m_length == null)
				{
					r_m_length = new(this, "m_length");
					r_m_length.SetBelong(this.instance);
				}
				return r_m_length;
			}
		}

		/// <summary>
		/// System.Int32 _version
		/// </summary>
		protected RField r__version;
		public virtual RField R_version
		{
			get
			{
				if(r__version == null)
				{
					r__version = new(this, "_version");
					r__version.SetBelong(this.instance);
				}
				return r__version;
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
		/// System.Int32 _ShrinkThreshold
		/// </summary>
		protected static RField r__ShrinkThreshold;
		public static RField R_ShrinkThreshold
		{
			get
			{
				if(r__ShrinkThreshold == null)
				{
					r__ShrinkThreshold = new(typeof(System.Collections.BitArray), "_ShrinkThreshold");
					r__ShrinkThreshold.SetBelong(null);
				}
				return r__ShrinkThreshold;
			}
		}

		/// <summary>
		/// System.Int32 BitsPerInt32
		/// </summary>
		protected static RField r_BitsPerInt32;
		public static RField RBitsPerInt32
		{
			get
			{
				if(r_BitsPerInt32 == null)
				{
					r_BitsPerInt32 = new(typeof(System.Collections.BitArray), "BitsPerInt32");
					r_BitsPerInt32.SetBelong(null);
				}
				return r_BitsPerInt32;
			}
		}

		/// <summary>
		/// System.Int32 BytesPerInt32
		/// </summary>
		protected static RField r_BytesPerInt32;
		public static RField RBytesPerInt32
		{
			get
			{
				if(r_BytesPerInt32 == null)
				{
					r_BytesPerInt32 = new(typeof(System.Collections.BitArray), "BytesPerInt32");
					r_BytesPerInt32.SetBelong(null);
				}
				return r_BytesPerInt32;
			}
		}

		/// <summary>
		/// System.Int32 BitsPerByte
		/// </summary>
		protected static RField r_BitsPerByte;
		public static RField RBitsPerByte
		{
			get
			{
				if(r_BitsPerByte == null)
				{
					r_BitsPerByte = new(typeof(System.Collections.BitArray), "BitsPerByte");
					r_BitsPerByte.SetBelong(null);
				}
				return r_BitsPerByte;
			}
		}

		/// <summary>
		/// Boolean Item [Int32]
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
		/// Boolean Get(Int32)
		/// </summary>
		protected RMethod r_RGet_Int32;
		public virtual RMethod RGet_Int32
		{
			get
			{
				if(r_RGet_Int32 == null)
				{
					r_RGet_Int32 = new(this, "Get", 0, typeof(System.Int32));
					r_RGet_Int32.SetBelong(this.instance);
				}
				return r_RGet_Int32;
			}
		}

		/// <summary>
		/// Void Set(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSet_Int32_Boolean;
		public virtual RMethod RSet_Int32_Boolean
		{
			get
			{
				if(r_RSet_Int32_Boolean == null)
				{
					r_RSet_Int32_Boolean = new(this, "Set", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSet_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSet_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetAll(Boolean)
		/// </summary>
		protected RMethod r_RSetAll_Boolean;
		public virtual RMethod RSetAll_Boolean
		{
			get
			{
				if(r_RSetAll_Boolean == null)
				{
					r_RSetAll_Boolean = new(this, "SetAll", 0, typeof(System.Boolean));
					r_RSetAll_Boolean.SetBelong(this.instance);
				}
				return r_RSetAll_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.BitArray And(System.Collections.BitArray)
		/// </summary>
		protected RMethod r_RAnd_BitArray;
		public virtual RMethod RAnd_BitArray
		{
			get
			{
				if(r_RAnd_BitArray == null)
				{
					r_RAnd_BitArray = new(this, "And", 0, typeof(System.Collections.BitArray));
					r_RAnd_BitArray.SetBelong(this.instance);
				}
				return r_RAnd_BitArray;
			}
		}

		/// <summary>
		/// System.Collections.BitArray Or(System.Collections.BitArray)
		/// </summary>
		protected RMethod r_ROr_BitArray;
		public virtual RMethod ROr_BitArray
		{
			get
			{
				if(r_ROr_BitArray == null)
				{
					r_ROr_BitArray = new(this, "Or", 0, typeof(System.Collections.BitArray));
					r_ROr_BitArray.SetBelong(this.instance);
				}
				return r_ROr_BitArray;
			}
		}

		/// <summary>
		/// System.Collections.BitArray Xor(System.Collections.BitArray)
		/// </summary>
		protected RMethod r_RXor_BitArray;
		public virtual RMethod RXor_BitArray
		{
			get
			{
				if(r_RXor_BitArray == null)
				{
					r_RXor_BitArray = new(this, "Xor", 0, typeof(System.Collections.BitArray));
					r_RXor_BitArray.SetBelong(this.instance);
				}
				return r_RXor_BitArray;
			}
		}

		/// <summary>
		/// System.Collections.BitArray Not()
		/// </summary>
		protected RMethod r_RNot;
		public virtual RMethod RNot
		{
			get
			{
				if(r_RNot == null)
				{
					r_RNot = new(this, "Not", 0);
					r_RNot.SetBelong(this.instance);
				}
				return r_RNot;
			}
		}

		/// <summary>
		/// System.Collections.BitArray RightShift(Int32)
		/// </summary>
		protected RMethod r_RRightShift_Int32;
		public virtual RMethod RRightShift_Int32
		{
			get
			{
				if(r_RRightShift_Int32 == null)
				{
					r_RRightShift_Int32 = new(this, "RightShift", 0, typeof(System.Int32));
					r_RRightShift_Int32.SetBelong(this.instance);
				}
				return r_RRightShift_Int32;
			}
		}

		/// <summary>
		/// System.Collections.BitArray LeftShift(Int32)
		/// </summary>
		protected RMethod r_RLeftShift_Int32;
		public virtual RMethod RLeftShift_Int32
		{
			get
			{
				if(r_RLeftShift_Int32 == null)
				{
					r_RLeftShift_Int32 = new(this, "LeftShift", 0, typeof(System.Int32));
					r_RLeftShift_Int32.SetBelong(this.instance);
				}
				return r_RLeftShift_Int32;
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
		/// Int32 GetArrayLength(Int32, Int32)
		/// </summary>
		protected static RMethod r_RGetArrayLength_Int32_Int32;
		public static RMethod RGetArrayLength_Int32_Int32
		{
			get
			{
				if(r_RGetArrayLength_Int32_Int32 == null)
				{
					r_RGetArrayLength_Int32_Int32 = new(typeof(System.Collections.BitArray), "GetArrayLength", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetArrayLength_Int32_Int32.SetBelong(null);
				}
				return r_RGetArrayLength_Int32_Int32;
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


        public RBitArray() : base("System.Collections.BitArray")
        {
        }

        public RBitArray(System.Object instance) : base("System.Collections.BitArray")
		{
            SetInstance(instance);
		}

        public RBitArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBitArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Get(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGet_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Set(System.Int32  @index, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSet_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAll(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAll_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.BitArray And(System.Collections.BitArray  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAnd_BitArray.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual System.Collections.BitArray Or(System.Collections.BitArray  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = ROr_BitArray.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual System.Collections.BitArray Xor(System.Collections.BitArray  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RXor_BitArray.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual System.Collections.BitArray Not()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNot.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual System.Collections.BitArray RightShift(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RRightShift_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual System.Collections.BitArray LeftShift(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RLeftShift_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.BitArray)___result;
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public static System.Int32 GetArrayLength(System.Int32  @n, System.Int32  @div)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n, @div};
            var ___result = RGetArrayLength_Int32_Int32.Invoke(___genericsType, ___parameters);

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
