using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAstarPath
{
	
	/// <summary>
	/// AstarPath+BinaryHeap
	/// </summary>
    public partial class RBinaryHeap : RMember //
    {

		/// <summary>
		/// AstarClasses.Node[] binaryHeap
		/// </summary>
		protected RFieldArray<RAstarClasses.RNode> r_binaryHeap;
		public virtual RFieldArray<RAstarClasses.RNode> RbinaryHeap
		{
			get
			{
				if(r_binaryHeap == null)
				{
					r_binaryHeap = new(this, "binaryHeap");
					r_binaryHeap.SetBelong(this.instance);
				}
				return r_binaryHeap;
			}
		}

		/// <summary>
		/// System.Int32 numberOfItems
		/// </summary>
		protected RField r_numberOfItems;
		public virtual RField RnumberOfItems
		{
			get
			{
				if(r_numberOfItems == null)
				{
					r_numberOfItems = new(this, "numberOfItems");
					r_numberOfItems.SetBelong(this.instance);
				}
				return r_numberOfItems;
			}
		}

		/// <summary>
		/// Void Add(AstarClasses.Node)
		/// </summary>
		protected RMethod r_RAdd_Node;
		public virtual RMethod RAdd_Node
		{
			get
			{
				if(r_RAdd_Node == null)
				{
					r_RAdd_Node = new(this, "Add", 0, typeof(AstarClasses.Node));
					r_RAdd_Node.SetBelong(this.instance);
				}
				return r_RAdd_Node;
			}
		}

		/// <summary>
		/// AstarClasses.Node Remove()
		/// </summary>
		protected RMethod r_RRemove;
		public virtual RMethod RRemove
		{
			get
			{
				if(r_RRemove == null)
				{
					r_RRemove = new(this, "Remove", 0);
					r_RRemove.SetBelong(this.instance);
				}
				return r_RRemove;
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


        public RBinaryHeap() : base("AstarPath+BinaryHeap")
        {
        }

        public RBinaryHeap(System.Object instance) : base("AstarPath+BinaryHeap")
		{
            SetInstance(instance);
		}

        public RBinaryHeap(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBinaryHeap(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(AstarClasses.Node  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RAdd_Node.Invoke(___genericsType, ___parameters);

            
        }


        public virtual AstarClasses.Node Remove()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemove.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
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
}