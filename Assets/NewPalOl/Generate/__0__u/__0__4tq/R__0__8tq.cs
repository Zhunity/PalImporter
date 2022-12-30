using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{public partial class R__0__4tq
{
	
	/// <summary>
	/// #u.#4tq+#8tq
	/// </summary>
    public partial class R__0__8tq : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
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
		/// #oU.#5bb #b
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__b;
		public virtual R__0__oU.R__0__5bb R__0__b
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
		/// Int32 Index
		/// </summary>
		protected RProperty r_R__0__xIp;
		public virtual RProperty R__0__xIp
		{
			get
			{
				if(r_R__0__xIp == null)
				{
					r_R__0__xIp = new(this, "Index", -1);
					r_R__0__xIp.SetBelong(this.instance);
				}
				return r_R__0__xIp;
			}
		}

		/// <summary>
		/// #oU.#5bb Group
		/// </summary>
		protected R__0__oU.R__0__5bb r_R__0__rIp;
		public virtual R__0__oU.R__0__5bb R__0__rIp
		{
			get
			{
				if(r_R__0__rIp == null)
				{
					r_R__0__rIp = new(this, "Group", -1);
					r_R__0__rIp.SetBelong(this.instance);
				}
				return r_R__0__rIp;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase Desc
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__5tq;
		public virtual RMyGUI.RElementBase R__0__5tq
		{
			get
			{
				if(r_R__0__5tq == null)
				{
					r_R__0__5tq = new(this, "Desc", -1);
					r_R__0__5tq.SetBelong(this.instance);
				}
				return r_R__0__5tq;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase Result
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__6tq;
		public virtual RMyGUI.RElementBase R__0__6tq
		{
			get
			{
				if(r_R__0__6tq == null)
				{
					r_R__0__6tq = new(this, "Result", -1);
					r_R__0__6tq.SetBelong(this.instance);
				}
				return r_R__0__6tq;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase BtnAawrd
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__7tq;
		public virtual RMyGUI.RElementBase R__0__7tq
		{
			get
			{
				if(r_R__0__7tq == null)
				{
					r_R__0__7tq = new(this, "BtnAawrd", -1);
					r_R__0__7tq.SetBelong(this.instance);
				}
				return r_R__0__7tq;
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


        public R__0__8tq() : base("#u.#4tq+#8tq")
        {
        }

        public R__0__8tq(System.Object instance) : base("#u.#4tq+#8tq")
		{
            SetInstance(instance);
		}

        public R__0__8tq(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__8tq(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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