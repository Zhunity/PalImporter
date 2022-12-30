using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#X6
	/// </summary>
    public partial class R__0__X6 : RMember //
    {

		/// <summary>
		/// UnityEngine.KeyCode #c
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
		/// UnityEngine.KeyCode[] #d
		/// </summary>
		protected RFieldArray<RField> r___0__d;
		public virtual RFieldArray<RField> R__0__d
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
		/// UnityEngine.KeyCode[] #e
		/// </summary>
		protected RFieldArray<RField> r___0__e;
		public virtual RFieldArray<RField> R__0__e
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
		/// UnityEngine.KeyCode[] DefaultHold_HotKeys
		/// </summary>
		protected RPropertyArray<RProperty> r_R__0__Q6;
		public virtual RPropertyArray<RProperty> R__0__Q6
		{
			get
			{
				if(r_R__0__Q6 == null)
				{
					r_R__0__Q6 = new(this, "DefaultHold_HotKeys", -1);
					r_R__0__Q6.SetBelong(this.instance);
				}
				return r_R__0__Q6;
			}
		}

		/// <summary>
		/// Int32 CheckFlag
		/// </summary>
		protected RProperty r_R__0__R6;
		public virtual RProperty R__0__R6
		{
			get
			{
				if(r_R__0__R6 == null)
				{
					r_R__0__R6 = new(this, "CheckFlag", -1);
					r_R__0__R6.SetBelong(this.instance);
				}
				return r_R__0__R6;
			}
		}

		/// <summary>
		/// Void #S6(#U6, Boolean)
		/// </summary>
		protected RMethod r_R__0__S6___0__U6_Boolean;
		public virtual RMethod R__0__S6___0__U6_Boolean
		{
			get
			{
				if(r_R__0__S6___0__U6_Boolean == null)
				{
					r_R__0__S6___0__U6_Boolean = new(this, "#S6", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY+#U6"), typeof(System.Boolean));
					r_R__0__S6___0__U6_Boolean.SetBelong(this.instance);
				}
				return r_R__0__S6___0__U6_Boolean;
			}
		}

		/// <summary>
		/// Boolean #T6(#U6)
		/// </summary>
		protected RMethod r_R__0__T6___0__U6;
		public virtual RMethod R__0__T6___0__U6
		{
			get
			{
				if(r_R__0__T6___0__U6 == null)
				{
					r_R__0__T6___0__U6 = new(this, "#T6", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY+#U6"));
					r_R__0__T6___0__U6.SetBelong(this.instance);
				}
				return r_R__0__T6___0__U6;
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


        public R__0__X6() : base("#u.#X6")
        {
        }

        public R__0__X6(System.Object instance) : base("#u.#X6")
		{
            SetInstance(instance);
		}

        public R__0__X6(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__X6(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
