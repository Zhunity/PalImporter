using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.BitSet
	/// </summary>
    public partial class RBitSet : RMember //
    {

		/// <summary>
		/// System.Int32 bitSlotShift
		/// </summary>
		protected static RField r_bitSlotShift;
		public static RField RbitSlotShift
		{
			get
			{
				if(r_bitSlotShift == null)
				{
					r_bitSlotShift = new( ReleactionUtils.GetType("System.Xml.Schema.BitSet"), "bitSlotShift");
					r_bitSlotShift.SetBelong(null);
				}
				return r_bitSlotShift;
			}
		}

		/// <summary>
		/// System.Int32 bitSlotMask
		/// </summary>
		protected static RField r_bitSlotMask;
		public static RField RbitSlotMask
		{
			get
			{
				if(r_bitSlotMask == null)
				{
					r_bitSlotMask = new( ReleactionUtils.GetType("System.Xml.Schema.BitSet"), "bitSlotMask");
					r_bitSlotMask.SetBelong(null);
				}
				return r_bitSlotMask;
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
		/// System.UInt32[] bits
		/// </summary>
		protected RFieldArray<RField> r_bits;
		public virtual RFieldArray<RField> Rbits
		{
			get
			{
				if(r_bits == null)
				{
					r_bits = new(this, "bits");
					r_bits.SetBelong(this.instance);
				}
				return r_bits;
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
		/// Boolean IsEmpty
		/// </summary>
		protected RProperty r_IsEmpty;
		public virtual RProperty RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", -1);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
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
		/// Void Clear(Int32)
		/// </summary>
		protected RMethod r_RClear_Int32;
		public virtual RMethod RClear_Int32
		{
			get
			{
				if(r_RClear_Int32 == null)
				{
					r_RClear_Int32 = new(this, "Clear", 0, typeof(System.Int32));
					r_RClear_Int32.SetBelong(this.instance);
				}
				return r_RClear_Int32;
			}
		}

		/// <summary>
		/// Void Set(Int32)
		/// </summary>
		protected RMethod r_RSet_Int32;
		public virtual RMethod RSet_Int32
		{
			get
			{
				if(r_RSet_Int32 == null)
				{
					r_RSet_Int32 = new(this, "Set", 0, typeof(System.Int32));
					r_RSet_Int32.SetBelong(this.instance);
				}
				return r_RSet_Int32;
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
		/// Int32 NextSet(Int32)
		/// </summary>
		protected RMethod r_RNextSet_Int32;
		public virtual RMethod RNextSet_Int32
		{
			get
			{
				if(r_RNextSet_Int32 == null)
				{
					r_RNextSet_Int32 = new(this, "NextSet", 0, typeof(System.Int32));
					r_RNextSet_Int32.SetBelong(this.instance);
				}
				return r_RNextSet_Int32;
			}
		}

		/// <summary>
		/// Void And(System.Xml.Schema.BitSet)
		/// </summary>
		protected RMethod r_RAnd_BitSet;
		public virtual RMethod RAnd_BitSet
		{
			get
			{
				if(r_RAnd_BitSet == null)
				{
					r_RAnd_BitSet = new(this, "And", 0,  ReleactionUtils.GetType("System.Xml.Schema.BitSet"));
					r_RAnd_BitSet.SetBelong(this.instance);
				}
				return r_RAnd_BitSet;
			}
		}

		/// <summary>
		/// Void Or(System.Xml.Schema.BitSet)
		/// </summary>
		protected RMethod r_ROr_BitSet;
		public virtual RMethod ROr_BitSet
		{
			get
			{
				if(r_ROr_BitSet == null)
				{
					r_ROr_BitSet = new(this, "Or", 0,  ReleactionUtils.GetType("System.Xml.Schema.BitSet"));
					r_ROr_BitSet.SetBelong(this.instance);
				}
				return r_ROr_BitSet;
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
		/// System.Xml.Schema.BitSet Clone()
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
		/// Boolean Intersects(System.Xml.Schema.BitSet)
		/// </summary>
		protected RMethod r_RIntersects_BitSet;
		public virtual RMethod RIntersects_BitSet
		{
			get
			{
				if(r_RIntersects_BitSet == null)
				{
					r_RIntersects_BitSet = new(this, "Intersects", 0,  ReleactionUtils.GetType("System.Xml.Schema.BitSet"));
					r_RIntersects_BitSet.SetBelong(this.instance);
				}
				return r_RIntersects_BitSet;
			}
		}

		/// <summary>
		/// Int32 Subscript(Int32)
		/// </summary>
		protected RMethod r_RSubscript_Int32;
		public virtual RMethod RSubscript_Int32
		{
			get
			{
				if(r_RSubscript_Int32 == null)
				{
					r_RSubscript_Int32 = new(this, "Subscript", 0, typeof(System.Int32));
					r_RSubscript_Int32.SetBelong(this.instance);
				}
				return r_RSubscript_Int32;
			}
		}

		/// <summary>
		/// Void EnsureLength(Int32)
		/// </summary>
		protected RMethod r_REnsureLength_Int32;
		public virtual RMethod REnsureLength_Int32
		{
			get
			{
				if(r_REnsureLength_Int32 == null)
				{
					r_REnsureLength_Int32 = new(this, "EnsureLength", 0, typeof(System.Int32));
					r_REnsureLength_Int32.SetBelong(this.instance);
				}
				return r_REnsureLength_Int32;
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


        public RBitSet() : base("System.Xml.Schema.BitSet")
        {
        }

        public RBitSet(System.Object instance) : base("System.Xml.Schema.BitSet")
		{
            SetInstance(instance);
		}

        public RBitSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBitSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RClear_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSet_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Get(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGet_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 NextSet(System.Int32  @startFrom)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startFrom};
            var ___result = RNextSet_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Int32 Subscript(System.Int32  @bitIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bitIndex};
            var ___result = RSubscript_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void EnsureLength(System.Int32  @nRequiredLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nRequiredLength};
            var ___result = REnsureLength_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
