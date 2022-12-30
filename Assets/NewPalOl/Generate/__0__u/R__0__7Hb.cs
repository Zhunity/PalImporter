using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#7Hb
	/// </summary>
    public partial class R__0__7Hb : RMember //
    {

		/// <summary>
		/// System.Boolean #a
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
		/// System.Single #b
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
		/// System.Single #c
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
		/// #u.#7Hb Empty
		/// </summary>
		protected static R__0__u.R__0__7Hb r_R__0__3Hb;
		public static R__0__u.R__0__7Hb R__0__3Hb
		{
			get
			{
				if(r_R__0__3Hb == null)
				{
					r_R__0__3Hb = new( ReleactionUtils.GetType("#u.#7Hb"), "Empty", -1);
					r_R__0__3Hb.SetBelong(null);
				}
				return r_R__0__3Hb;
			}
		}

		/// <summary>
		/// #u.#7Hb Zero
		/// </summary>
		protected static R__0__u.R__0__7Hb r_R__0__4Hb;
		public static R__0__u.R__0__7Hb R__0__4Hb
		{
			get
			{
				if(r_R__0__4Hb == null)
				{
					r_R__0__4Hb = new( ReleactionUtils.GetType("#u.#7Hb"), "Zero", -1);
					r_R__0__4Hb.SetBelong(null);
				}
				return r_R__0__4Hb;
			}
		}

		/// <summary>
		/// Boolean IsNothing
		/// </summary>
		protected RProperty r_R__0__5Hb;
		public virtual RProperty R__0__5Hb
		{
			get
			{
				if(r_R__0__5Hb == null)
				{
					r_R__0__5Hb = new(this, "IsNothing", -1);
					r_R__0__5Hb.SetBelong(this.instance);
				}
				return r_R__0__5Hb;
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
		/// #u.#7Hb #6Hb(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_R__0__6Hb_Rect;
		public static RMethod R__0__6Hb_Rect
		{
			get
			{
				if(r_R__0__6Hb_Rect == null)
				{
					r_R__0__6Hb_Rect = new( ReleactionUtils.GetType("#u.#7Hb"), "#6Hb", 0, typeof(UnityEngine.Rect));
					r_R__0__6Hb_Rect.SetBelong(null);
				}
				return r_R__0__6Hb_Rect;
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


        public R__0__7Hb() : base("#u.#7Hb")
        {
        }

        public R__0__7Hb(System.Object instance) : base("#u.#7Hb")
		{
            SetInstance(instance);
		}

        public R__0__7Hb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__7Hb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object __0__6Hb(UnityEngine.Rect  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = R__0__6Hb_Rect.Invoke(___genericsType, ___parameters);

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
