using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#6Gb
	/// </summary>
    public partial class R__0__6Gb : RMember //
    {

		/// <summary>
		/// MyGUIWindow #a
		/// </summary>
		protected RMyGUIWindow r___0__a;
		public virtual RMyGUIWindow R__0__a
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
		/// System.String GameStaetName
		/// </summary>
		protected RProperty r_R__0__mGb;
		public virtual RProperty R__0__mGb
		{
			get
			{
				if(r_R__0__mGb == null)
				{
					r_R__0__mGb = new(this, "GameStaetName", -1);
					r_R__0__mGb.SetBelong(this.instance);
				}
				return r_R__0__mGb;
			}
		}

		/// <summary>
		/// Void SetWindow(MyGUIWindow)
		/// </summary>
		protected RMethod r_RSetWindow_MyGUIWindow;
		public virtual RMethod RSetWindow_MyGUIWindow
		{
			get
			{
				if(r_RSetWindow_MyGUIWindow == null)
				{
					r_RSetWindow_MyGUIWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RSetWindow_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RSetWindow_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #Pr(System.String)
		/// </summary>
		protected RMethod r_R__0__Pr_String;
		public virtual RMethod R__0__Pr_String
		{
			get
			{
				if(r_R__0__Pr_String == null)
				{
					r_R__0__Pr_String = new(this, "#Pr", 0, typeof(System.String));
					r_R__0__Pr_String.SetBelong(this.instance);
				}
				return r_R__0__Pr_String;
			}
		}

		/// <summary>
		/// Void #rGb(System.String)
		/// </summary>
		protected RMethod r_R__0__rGb_String;
		public virtual RMethod R__0__rGb_String
		{
			get
			{
				if(r_R__0__rGb_String == null)
				{
					r_R__0__rGb_String = new(this, "#rGb", 0, typeof(System.String));
					r_R__0__rGb_String.SetBelong(this.instance);
				}
				return r_R__0__rGb_String;
			}
		}

		/// <summary>
		/// Void #sGb(System.String)
		/// </summary>
		protected RMethod r_R__0__sGb_String;
		public virtual RMethod R__0__sGb_String
		{
			get
			{
				if(r_R__0__sGb_String == null)
				{
					r_R__0__sGb_String = new(this, "#sGb", 0, typeof(System.String));
					r_R__0__sGb_String.SetBelong(this.instance);
				}
				return r_R__0__sGb_String;
			}
		}

		/// <summary>
		/// Void #tGb(System.String)
		/// </summary>
		protected RMethod r_R__0__tGb_String;
		public virtual RMethod R__0__tGb_String
		{
			get
			{
				if(r_R__0__tGb_String == null)
				{
					r_R__0__tGb_String = new(this, "#tGb", 0, typeof(System.String));
					r_R__0__tGb_String.SetBelong(this.instance);
				}
				return r_R__0__tGb_String;
			}
		}

		/// <summary>
		/// Void Update(Single)
		/// </summary>
		protected RMethod r_RUpdate_Single;
		public virtual RMethod RUpdate_Single
		{
			get
			{
				if(r_RUpdate_Single == null)
				{
					r_RUpdate_Single = new(this, "Update", 0, typeof(System.Single));
					r_RUpdate_Single.SetBelong(this.instance);
				}
				return r_RUpdate_Single;
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


        public R__0__6Gb() : base("#u.#6Gb")
        {
        }

        public R__0__6Gb(System.Object instance) : base("#u.#6Gb")
		{
            SetInstance(instance);
		}

        public R__0__6Gb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__6Gb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual void __0__Pr(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__Pr_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__rGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__sGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tGb(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__tGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update(System.Single  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RUpdate_Single.Invoke(___genericsType, ___parameters);

            
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
