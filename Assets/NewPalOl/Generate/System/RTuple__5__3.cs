using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Tuple`3
	/// </summary>
    public partial class RTuple<T1, T2, T3> : RMember //
    {

		/// <summary>
		/// T1 m_Item1
		/// </summary>
		protected RField r_m_Item1;
		public virtual RField Rm_Item1
		{
			get
			{
				if(r_m_Item1 == null)
				{
					r_m_Item1 = new(this, "m_Item1");
					r_m_Item1.SetBelong(this.instance);
				}
				return r_m_Item1;
			}
		}

		/// <summary>
		/// T2 m_Item2
		/// </summary>
		protected RField r_m_Item2;
		public virtual RField Rm_Item2
		{
			get
			{
				if(r_m_Item2 == null)
				{
					r_m_Item2 = new(this, "m_Item2");
					r_m_Item2.SetBelong(this.instance);
				}
				return r_m_Item2;
			}
		}

		/// <summary>
		/// T3 m_Item3
		/// </summary>
		protected RField r_m_Item3;
		public virtual RField Rm_Item3
		{
			get
			{
				if(r_m_Item3 == null)
				{
					r_m_Item3 = new(this, "m_Item3");
					r_m_Item3.SetBelong(this.instance);
				}
				return r_m_Item3;
			}
		}

		/// <summary>
		/// T1 Item1
		/// </summary>
		protected RProperty r_Item1;
		public virtual RProperty RItem1
		{
			get
			{
				if(r_Item1 == null)
				{
					r_Item1 = new(this, "Item1", -1);
					r_Item1.SetBelong(this.instance);
				}
				return r_Item1;
			}
		}

		/// <summary>
		/// T2 Item2
		/// </summary>
		protected RProperty r_Item2;
		public virtual RProperty RItem2
		{
			get
			{
				if(r_Item2 == null)
				{
					r_Item2 = new(this, "Item2", -1);
					r_Item2.SetBelong(this.instance);
				}
				return r_Item2;
			}
		}

		/// <summary>
		/// T3 Item3
		/// </summary>
		protected RProperty r_Item3;
		public virtual RProperty RItem3
		{
			get
			{
				if(r_Item3 == null)
				{
					r_Item3 = new(this, "Item3", -1);
					r_Item3.SetBelong(this.instance);
				}
				return r_Item3;
			}
		}

		/// <summary>
		/// Int32 System.Runtime.CompilerServices.ITuple.Length
		/// </summary>
		protected RProperty r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length;
		public virtual RProperty RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length
		{
			get
			{
				if(r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length == null)
				{
					r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length = new(this, "System.Runtime.CompilerServices.ITuple.Length", -1);
					r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Length;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.CompilerServices.ITuple.Item [Int32]
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32;
		public virtual RSystem.RObject RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32
		{
			get
			{
				if(r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32 == null)
				{
					r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32 = new(this, "System.Runtime.CompilerServices.ITuple.Item", -1, typeof(System.Int32));
					r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__CompilerServices__1__ITuple__1__get_Item_Int32;
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
		/// Boolean System.Collections.IStructuralEquatable.Equals(System.Object, System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer;
		public virtual RMethod RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer
		{
			get
			{
				if(r_RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer == null)
				{
					r_RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.Equals", 0, typeof(System.Object), typeof(System.Collections.IEqualityComparer));
					r_RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 System.IComparable.CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RSystem__1__IComparable__1__CompareTo_Object;
		public virtual RMethod RSystem__1__IComparable__1__CompareTo_Object
		{
			get
			{
				if(r_RSystem__1__IComparable__1__CompareTo_Object == null)
				{
					r_RSystem__1__IComparable__1__CompareTo_Object = new(this, "System.IComparable.CompareTo", 0, typeof(System.Object));
					r_RSystem__1__IComparable__1__CompareTo_Object.SetBelong(this.instance);
				}
				return r_RSystem__1__IComparable__1__CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 System.Collections.IStructuralComparable.CompareTo(System.Object, System.Collections.IComparer)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer;
		public virtual RMethod RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer
		{
			get
			{
				if(r_RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer == null)
				{
					r_RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer = new(this, "System.Collections.IStructuralComparable.CompareTo", 0, typeof(System.Object), typeof(System.Collections.IComparer));
					r_RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer;
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
		/// Int32 System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer;
		public virtual RMethod RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer == null)
				{
					r_RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer = new(this, "System.Collections.IStructuralEquatable.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
					r_RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer;
			}
		}

		/// <summary>
		/// Int32 System.ITupleInternal.GetHashCode(System.Collections.IEqualityComparer)
		/// </summary>
		protected RMethod r_RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer;
		public virtual RMethod RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer
		{
			get
			{
				if(r_RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer == null)
				{
					r_RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer = new(this, "System.ITupleInternal.GetHashCode", 0, typeof(System.Collections.IEqualityComparer));
					r_RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer.SetBelong(this.instance);
				}
				return r_RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer;
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
		/// System.String System.ITupleInternal.ToString(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RSystem__1__ITupleInternal__1__ToString_StringBuilder;
		public virtual RMethod RSystem__1__ITupleInternal__1__ToString_StringBuilder
		{
			get
			{
				if(r_RSystem__1__ITupleInternal__1__ToString_StringBuilder == null)
				{
					r_RSystem__1__ITupleInternal__1__ToString_StringBuilder = new(this, "System.ITupleInternal.ToString", 0, typeof(System.Text.StringBuilder));
					r_RSystem__1__ITupleInternal__1__ToString_StringBuilder.SetBelong(this.instance);
				}
				return r_RSystem__1__ITupleInternal__1__ToString_StringBuilder;
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


        public RTuple() : base("System.Tuple`3")
        {
        }

        public RTuple(System.Object instance) : base("System.Tuple`3")
		{
            SetInstance(instance);
		}

        public RTuple(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTuple(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean System__1__Collections__1__IStructuralEquatable__1__Equals(System.Object  @other, System.Collections.IEqualityComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RSystem__1__Collections__1__IStructuralEquatable__1__Equals_Object_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 System__1__IComparable__1__CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RSystem__1__IComparable__1__CompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__1__Collections__1__IStructuralComparable__1__CompareTo(System.Object  @other, System.Collections.IComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @comparer};
            var ___result = RSystem__1__Collections__1__IStructuralComparable__1__CompareTo_Object_IComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__1__Collections__1__IStructuralEquatable__1__GetHashCode(System.Collections.IEqualityComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RSystem__1__Collections__1__IStructuralEquatable__1__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 System__1__ITupleInternal__1__GetHashCode(System.Collections.IEqualityComparer  @comparer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer};
            var ___result = RSystem__1__ITupleInternal__1__GetHashCode_IEqualityComparer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String System__1__ITupleInternal__1__ToString(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RSystem__1__ITupleInternal__1__ToString_StringBuilder.Invoke(___genericsType, ___parameters);

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
