using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__0Ib
{
	/// <summary>
	/// #0Ib.#ZIb
	/// </summary>
    public partial class R__0__ZIb : RMember //
    {

		/// <summary>
		/// System.UInt32 #a
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
		/// Void #XIb(#0Ib.#7Ib)
		/// </summary>
		protected RMethod r_R__0__XIb___0__7Ib;
		public virtual RMethod R__0__XIb___0__7Ib
		{
			get
			{
				if(r_R__0__XIb___0__7Ib == null)
				{
					r_R__0__XIb___0__7Ib = new(this, "#XIb", 0,  ReleactionUtils.GetType("#0Ib.#7Ib"));
					r_R__0__XIb___0__7Ib.SetBelong(this.instance);
				}
				return r_R__0__XIb___0__7Ib;
			}
		}

		/// <summary>
		/// Boolean #Ubc(#0Ib.#7Ib)
		/// </summary>
		protected RMethod r_R__0__Ubc___0__7Ib;
		public virtual RMethod R__0__Ubc___0__7Ib
		{
			get
			{
				if(r_R__0__Ubc___0__7Ib == null)
				{
					r_R__0__Ubc___0__7Ib = new(this, "#Ubc", 0,  ReleactionUtils.GetType("#0Ib.#7Ib"));
					r_R__0__Ubc___0__7Ib.SetBelong(this.instance);
				}
				return r_R__0__Ubc___0__7Ib;
			}
		}

		/// <summary>
		/// System.String #YIb(System.String)
		/// </summary>
		protected RMethod r_R__0__YIb_String;
		public virtual RMethod R__0__YIb_String
		{
			get
			{
				if(r_R__0__YIb_String == null)
				{
					r_R__0__YIb_String = new(this, "#YIb", 0, typeof(System.String));
					r_R__0__YIb_String.SetBelong(this.instance);
				}
				return r_R__0__YIb_String;
			}
		}

		/// <summary>
		/// Void PlayMusic(System.String)
		/// </summary>
		protected RMethod r_RPlayMusic_String;
		public virtual RMethod RPlayMusic_String
		{
			get
			{
				if(r_RPlayMusic_String == null)
				{
					r_RPlayMusic_String = new(this, "PlayMusic", 0, typeof(System.String));
					r_RPlayMusic_String.SetBelong(this.instance);
				}
				return r_RPlayMusic_String;
			}
		}

		/// <summary>
		/// Void PlayMusic(System.String, System.String)
		/// </summary>
		protected RMethod r_RPlayMusic_String_String;
		public virtual RMethod RPlayMusic_String_String
		{
			get
			{
				if(r_RPlayMusic_String_String == null)
				{
					r_RPlayMusic_String_String = new(this, "PlayMusic", 0, typeof(System.String), typeof(System.String));
					r_RPlayMusic_String_String.SetBelong(this.instance);
				}
				return r_RPlayMusic_String_String;
			}
		}

		/// <summary>
		/// Boolean #Vbc(System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__Vbc_String_String;
		public virtual RMethod R__0__Vbc_String_String
		{
			get
			{
				if(r_R__0__Vbc_String_String == null)
				{
					r_R__0__Vbc_String_String = new(this, "#Vbc", 0, typeof(System.String), typeof(System.String));
					r_R__0__Vbc_String_String.SetBelong(this.instance);
				}
				return r_R__0__Vbc_String_String;
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


        public R__0__ZIb() : base("#0Ib.#ZIb")
        {
        }

        public R__0__ZIb(System.Object instance) : base("#0Ib.#ZIb")
		{
            SetInstance(instance);
		}

        public R__0__ZIb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__ZIb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual System.String __0__YIb(System.String  @eventName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventName};
            var ___result = R__0__YIb_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void PlayMusic(System.String  @musicID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@musicID};
            var ___result = RPlayMusic_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayMusic(System.String  @musicUnitName, System.String  @musicID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@musicUnitName, @musicID};
            var ___result = RPlayMusic_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Vbc(System.String  @musicUnitName, System.String  @musicID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@musicUnitName, @musicID};
            var ___result = R__0__Vbc_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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