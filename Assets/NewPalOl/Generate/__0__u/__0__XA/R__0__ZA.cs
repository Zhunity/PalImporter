using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{public partial class R__0__XA
{
	
	/// <summary>
	/// #u.#XA+#ZA
	/// </summary>
    public partial class R__0__ZA : RMember //
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
		/// System.String #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
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
		/// System.Int32 #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
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
		/// System.Int32 #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.String #f
		/// </summary>
		protected static RField r___0__f;
		public static RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new( ReleactionUtils.GetType("#u.#XA+#ZA"), "#f");
					r___0__f.SetBelong(null);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.Boolean #g
		/// </summary>
		protected static RField r___0__g;
		public static RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("#u.#XA+#ZA"), "#g");
					r___0__g.SetBelong(null);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #h
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__h;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new( ReleactionUtils.GetType("#u.#XA+#ZA"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// Int32 CompareTo(#ZA)
		/// </summary>
		protected RMethod r_RCompareTo___0__ZA;
		public virtual RMethod RCompareTo___0__ZA
		{
			get
			{
				if(r_RCompareTo___0__ZA == null)
				{
					r_RCompareTo___0__ZA = new(this, "CompareTo", 0,  ReleactionUtils.GetType("#u.#XA+#ZA"));
					r_RCompareTo___0__ZA.SetBelong(this.instance);
				}
				return r_RCompareTo___0__ZA;
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


        public R__0__ZA() : base("#u.#XA+#ZA")
        {
        }

        public R__0__ZA(System.Object instance) : base("#u.#XA+#ZA")
		{
            SetInstance(instance);
		}

        public R__0__ZA(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__ZA(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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