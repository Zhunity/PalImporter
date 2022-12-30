using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#EGd
	/// </summary>
    public partial class R__0__EGd : RMember //
    {

		/// <summary>
		/// System.Single #a
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
		/// #u.#EGd+#FGd #b
		/// </summary>
		protected R__0__u.R__0__EGd.R__0__FGd r___0__b;
		public virtual R__0__u.R__0__EGd.R__0__FGd R__0__b
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
		/// System.Collections.Generic.List`1[#u.#EGd+#FGd] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__EGd.R__0__FGd> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__EGd.R__0__FGd> R__0__c
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
		/// Void Open(#u.#BGd, System.Object, MyGUI.ElementBase, #JGd, System.Object)
		/// </summary>
		protected RMethod r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object;
		public virtual RMethod ROpen___0__BGd_Object_ElementBase___0__JGd_Object
		{
			get
			{
				if(r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object == null)
				{
					r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object = new(this, "Open", 0,  ReleactionUtils.GetType("#u.#BGd"), typeof(System.Object), typeof(MyGUI.ElementBase),  ReleactionUtils.GetType("#u.#EGd+#JGd"), typeof(System.Object));
					r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object.SetBelong(this.instance);
				}
				return r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object;
			}
		}

		/// <summary>
		/// Void Open(#u.#BGd, System.Object, MyGUI.ElementBase, #JGd, System.Object, Single)
		/// </summary>
		protected RMethod r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single;
		public virtual RMethod ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single
		{
			get
			{
				if(r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single == null)
				{
					r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single = new(this, "Open", 0,  ReleactionUtils.GetType("#u.#BGd"), typeof(System.Object), typeof(MyGUI.ElementBase),  ReleactionUtils.GetType("#u.#EGd+#JGd"), typeof(System.Object), typeof(System.Single));
					r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single.SetBelong(this.instance);
				}
				return r_ROpen___0__BGd_Object_ElementBase___0__JGd_Object_Single;
			}
		}

		/// <summary>
		/// Void #CA(#u.#BGd, System.Object)
		/// </summary>
		protected RMethod r_R__0__CA___0__BGd_Object;
		public virtual RMethod R__0__CA___0__BGd_Object
		{
			get
			{
				if(r_R__0__CA___0__BGd_Object == null)
				{
					r_R__0__CA___0__BGd_Object = new(this, "#CA", 0,  ReleactionUtils.GetType("#u.#BGd"), typeof(System.Object));
					r_R__0__CA___0__BGd_Object.SetBelong(this.instance);
				}
				return r_R__0__CA___0__BGd_Object;
			}
		}

		/// <summary>
		/// Void #CGd(#u.#BGd)
		/// </summary>
		protected RMethod r_R__0__CGd___0__BGd;
		public virtual RMethod R__0__CGd___0__BGd
		{
			get
			{
				if(r_R__0__CGd___0__BGd == null)
				{
					r_R__0__CGd___0__BGd = new(this, "#CGd", 0,  ReleactionUtils.GetType("#u.#BGd"));
					r_R__0__CGd___0__BGd.SetBelong(this.instance);
				}
				return r_R__0__CGd___0__BGd;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void #0k(#FGd)
		/// </summary>
		protected RMethod r_R__0__0k___0__FGd;
		public virtual RMethod R__0__0k___0__FGd
		{
			get
			{
				if(r_R__0__0k___0__FGd == null)
				{
					r_R__0__0k___0__FGd = new(this, "#0k", 0,  ReleactionUtils.GetType("#u.#EGd+#FGd"));
					r_R__0__0k___0__FGd.SetBelong(this.instance);
				}
				return r_R__0__0k___0__FGd;
			}
		}

		/// <summary>
		/// Void #DGd()
		/// </summary>
		protected RMethod r_R__0__DGd;
		public virtual RMethod R__0__DGd
		{
			get
			{
				if(r_R__0__DGd == null)
				{
					r_R__0__DGd = new(this, "#DGd", 0);
					r_R__0__DGd.SetBelong(this.instance);
				}
				return r_R__0__DGd;
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


        public R__0__EGd() : base("#u.#EGd")
        {
        }

        public R__0__EGd(System.Object instance) : base("#u.#EGd")
		{
            SetInstance(instance);
		}

        public R__0__EGd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__EGd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }





        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__DGd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__DGd.Invoke(___genericsType, ___parameters);

            
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
