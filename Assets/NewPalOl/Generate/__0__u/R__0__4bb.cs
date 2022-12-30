using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#4bb
	/// </summary>
    public partial class R__0__4bb : RMember //
    {

		/// <summary>
		/// GameDefineType.ID #a
		/// </summary>
		protected RGameDefineType.RID r___0__a;
		public virtual RGameDefineType.RID R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#7bb] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__7bb> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__7bb> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// #u.#qOb #d
		/// </summary>
		protected R__0__u.R__0__qOb r___0__d;
		public virtual R__0__u.R__0__qOb R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Func`2[#u.#7bb,System.Boolean] #e
		/// </summary>
		protected static RSystem.RFunc<R__0__u.R__0__7bb, RField> r___0__e;
		public static RSystem.RFunc<R__0__u.R__0__7bb, RField> R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new( ReleactionUtils.GetType("#u.#4bb"), "#e");
					r___0__e.SetBelong(null);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// Int32 FriendsCount
		/// </summary>
		protected RProperty r_R__0__Zbb;
		public virtual RProperty R__0__Zbb
		{
			get
			{
				if(r_R__0__Zbb == null)
				{
					r_R__0__Zbb = new(this, "FriendsCount", -1);
					r_R__0__Zbb.SetBelong(this.instance);
				}
				return r_R__0__Zbb;
			}
		}

		/// <summary>
		/// #u.#7bb Item [Int32]
		/// </summary>
		protected R__0__u.R__0__7bb r_R__0__Rbb_Int32;
		public virtual R__0__u.R__0__7bb R__0__Rbb_Int32
		{
			get
			{
				if(r_R__0__Rbb_Int32 == null)
				{
					r_R__0__Rbb_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_R__0__Rbb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Rbb_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Xbb()
		/// </summary>
		protected RMethod r_R__0__Xbb;
		public virtual RMethod R__0__Xbb
		{
			get
			{
				if(r_R__0__Xbb == null)
				{
					r_R__0__Xbb = new(this, "#Xbb", 0);
					r_R__0__Xbb.SetBelong(this.instance);
				}
				return r_R__0__Xbb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[#u.#7bb] #Ybb()
		/// </summary>
		protected RMethod r_R__0__Ybb;
		public virtual RMethod R__0__Ybb
		{
			get
			{
				if(r_R__0__Ybb == null)
				{
					r_R__0__Ybb = new(this, "#Ybb", 0);
					r_R__0__Ybb.SetBelong(this.instance);
				}
				return r_R__0__Ybb;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
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
		/// Void #0bb(#Pfb.#3vb)
		/// </summary>
		protected RMethod r_R__0__0bb___0__3vb;
		public virtual RMethod R__0__0bb___0__3vb
		{
			get
			{
				if(r_R__0__0bb___0__3vb == null)
				{
					r_R__0__0bb___0__3vb = new(this, "#0bb", 0,  ReleactionUtils.GetType("#Pfb.#3vb"));
					r_R__0__0bb___0__3vb.SetBelong(this.instance);
				}
				return r_R__0__0bb___0__3vb;
			}
		}

		/// <summary>
		/// Void #iQ(#Pfb.#6vb)
		/// </summary>
		protected RMethod r_R__0__iQ___0__6vb;
		public virtual RMethod R__0__iQ___0__6vb
		{
			get
			{
				if(r_R__0__iQ___0__6vb == null)
				{
					r_R__0__iQ___0__6vb = new(this, "#iQ", 0,  ReleactionUtils.GetType("#Pfb.#6vb"));
					r_R__0__iQ___0__6vb.SetBelong(this.instance);
				}
				return r_R__0__iQ___0__6vb;
			}
		}

		/// <summary>
		/// Int32 #1bb()
		/// </summary>
		protected RMethod r_R__0__1bb;
		public virtual RMethod R__0__1bb
		{
			get
			{
				if(r_R__0__1bb == null)
				{
					r_R__0__1bb = new(this, "#1bb", 0);
					r_R__0__1bb.SetBelong(this.instance);
				}
				return r_R__0__1bb;
			}
		}

		/// <summary>
		/// Void Add(#u.#7bb)
		/// </summary>
		protected RMethod r_RAdd___0__7bb;
		public virtual RMethod RAdd___0__7bb
		{
			get
			{
				if(r_RAdd___0__7bb == null)
				{
					r_RAdd___0__7bb = new(this, "Add", 0,  ReleactionUtils.GetType("#u.#7bb"));
					r_RAdd___0__7bb.SetBelong(this.instance);
				}
				return r_RAdd___0__7bb;
			}
		}

		/// <summary>
		/// Void Remove(#u.#7bb)
		/// </summary>
		protected RMethod r_RRemove___0__7bb;
		public virtual RMethod RRemove___0__7bb
		{
			get
			{
				if(r_RRemove___0__7bb == null)
				{
					r_RRemove___0__7bb = new(this, "Remove", 0,  ReleactionUtils.GetType("#u.#7bb"));
					r_RRemove___0__7bb.SetBelong(this.instance);
				}
				return r_RRemove___0__7bb;
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
		/// Void #2bb()
		/// </summary>
		protected RMethod r_R__0__2bb;
		public virtual RMethod R__0__2bb
		{
			get
			{
				if(r_R__0__2bb == null)
				{
					r_R__0__2bb = new(this, "#2bb", 0);
					r_R__0__2bb.SetBelong(this.instance);
				}
				return r_R__0__2bb;
			}
		}

		/// <summary>
		/// Enumerator #Qbb()
		/// </summary>
		protected RMethod r_R__0__Qbb;
		public virtual RMethod R__0__Qbb
		{
			get
			{
				if(r_R__0__Qbb == null)
				{
					r_R__0__Qbb = new(this, "#Qbb", 0);
					r_R__0__Qbb.SetBelong(this.instance);
				}
				return r_R__0__Qbb;
			}
		}

		/// <summary>
		/// Boolean #Isx(#u.#7bb)
		/// </summary>
		protected static RMethod r_R__0__Isx___0__7bb;
		public static RMethod R__0__Isx___0__7bb
		{
			get
			{
				if(r_R__0__Isx___0__7bb == null)
				{
					r_R__0__Isx___0__7bb = new( ReleactionUtils.GetType("#u.#4bb"), "#Isx", 0,  ReleactionUtils.GetType("#u.#7bb"));
					r_R__0__Isx___0__7bb.SetBelong(null);
				}
				return r_R__0__Isx___0__7bb;
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


        public R__0__4bb() : base("#u.#4bb")
        {
        }

        public R__0__4bb(System.Object instance) : base("#u.#4bb")
		{
            SetInstance(instance);
		}

        public R__0__4bb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__4bb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Collections.IEnumerator __0__Xbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xbb.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Object __0__Ybb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Ybb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }




        public virtual System.Int32 __0__1bb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1bb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2bb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2bb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__Qbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Qbb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


    }
}
