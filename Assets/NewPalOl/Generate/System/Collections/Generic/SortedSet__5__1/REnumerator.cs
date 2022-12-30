using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RSortedSet<T>
{
	
	/// <summary>
	/// System.Collections.Generic.SortedSet`1+Enumerator
	/// </summary>
    public partial class REnumerator : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.SortedSet`1+Node[T] s_dummyNode
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode r_s_dummyNode;
		public static RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode Rs_dummyNode
		{
			get
			{
				if(r_s_dummyNode == null)
				{
					r_s_dummyNode = new( ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Enumerator"), "s_dummyNode");
					r_s_dummyNode.SetBelong(null);
				}
				return r_s_dummyNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedSet`1[T] _tree
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RField> r__tree;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RField> R_tree
		{
			get
			{
				if(r__tree == null)
				{
					r__tree = new(this, "_tree");
					r__tree.SetBelong(this.instance);
				}
				return r__tree;
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
		/// System.Collections.Generic.Stack`1[System.Collections.Generic.SortedSet`1+Node[T]] _stack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode> r__stack;
		public virtual RSystem.RCollections.RGeneric.RStack<RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode> R_stack
		{
			get
			{
				if(r__stack == null)
				{
					r__stack = new(this, "_stack");
					r__stack.SetBelong(this.instance);
				}
				return r__stack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedSet`1+Node[T] _current
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode r__current;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode R_current
		{
			get
			{
				if(r__current == null)
				{
					r__current = new(this, "_current");
					r__current.SetBelong(this.instance);
				}
				return r__current;
			}
		}

		/// <summary>
		/// System.Boolean _reverse
		/// </summary>
		protected RField r__reverse;
		public virtual RField R_reverse
		{
			get
			{
				if(r__reverse == null)
				{
					r__reverse = new(this, "_reverse");
					r__reverse.SetBelong(this.instance);
				}
				return r__reverse;
			}
		}

		/// <summary>
		/// T Current
		/// </summary>
		protected RProperty r_Current;
		public virtual RProperty RCurrent
		{
			get
			{
				if(r_Current == null)
				{
					r_Current = new(this, "Current", -1);
					r_Current.SetBelong(this.instance);
				}
				return r_Current;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
		public virtual RSystem.RObject RSystem__1__Collections__1__IEnumerator__1__get_Current
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__get_Current == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
			}
		}

		/// <summary>
		/// Boolean NotStartedOrEnded
		/// </summary>
		protected RProperty r_NotStartedOrEnded;
		public virtual RProperty RNotStartedOrEnded
		{
			get
			{
				if(r_NotStartedOrEnded == null)
				{
					r_NotStartedOrEnded = new(this, "NotStartedOrEnded", -1);
					r_NotStartedOrEnded.SetBelong(this.instance);
				}
				return r_NotStartedOrEnded;
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
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void System.Collections.IEnumerator.Reset()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IEnumerator__1__Reset;
		public virtual RMethod RSystem__1__Collections__1__IEnumerator__1__Reset
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__Reset == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__Reset = new(this, "System.Collections.IEnumerator.Reset", 0);
					r_RSystem__1__Collections__1__IEnumerator__1__Reset.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__Reset;
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


        public REnumerator() : base("System.Collections.Generic.SortedSet`1+Enumerator")
        {
        }

        public REnumerator(System.Object instance) : base("System.Collections.Generic.SortedSet`1+Enumerator")
		{
            SetInstance(instance);
		}

        public REnumerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REnumerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__1__Runtime__1__Serialization__1__IDeserializationCallback__1__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Collections__1__IEnumerator__1__Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerator__1__Reset.Invoke(___genericsType, ___parameters);

            
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