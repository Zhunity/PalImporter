using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Lob
	/// </summary>
    public partial class R__0__Lob : RMember //
    {

		/// <summary>
		/// #u.#Lob #a
		/// </summary>
		protected static R__0__u.R__0__Lob r___0__a;
		public static R__0__u.R__0__Lob R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Lob"), "#a");
					r___0__a.SetBelong(null);
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
		/// System.Boolean #d
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
		/// System.String #e
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
		/// #u.#Lob Inst
		/// </summary>
		protected static R__0__u.R__0__Lob r_Inst;
		public static R__0__u.R__0__Lob RInst
		{
			get
			{
				if(r_Inst == null)
				{
					r_Inst = new( ReleactionUtils.GetType("#u.#Lob"), "Inst", -1);
					r_Inst.SetBelong(null);
				}
				return r_Inst;
			}
		}

		/// <summary>
		/// Single MusicVolume
		/// </summary>
		protected RProperty r_R__0__Dob;
		public virtual RProperty R__0__Dob
		{
			get
			{
				if(r_R__0__Dob == null)
				{
					r_R__0__Dob = new(this, "MusicVolume", -1);
					r_R__0__Dob.SetBelong(this.instance);
				}
				return r_R__0__Dob;
			}
		}

		/// <summary>
		/// Single SoundVolume
		/// </summary>
		protected RProperty r_R__0__Fob;
		public virtual RProperty R__0__Fob
		{
			get
			{
				if(r_R__0__Fob == null)
				{
					r_R__0__Fob = new(this, "SoundVolume", -1);
					r_R__0__Fob.SetBelong(this.instance);
				}
				return r_R__0__Fob;
			}
		}

		/// <summary>
		/// Boolean CanMusic
		/// </summary>
		protected RProperty r_R__0__Hob;
		public virtual RProperty R__0__Hob
		{
			get
			{
				if(r_R__0__Hob == null)
				{
					r_R__0__Hob = new(this, "CanMusic", -1);
					r_R__0__Hob.SetBelong(this.instance);
				}
				return r_R__0__Hob;
			}
		}

		/// <summary>
		/// Boolean CanSound
		/// </summary>
		protected RProperty r_R__0__Job;
		public virtual RProperty R__0__Job
		{
			get
			{
				if(r_R__0__Job == null)
				{
					r_R__0__Job = new(this, "CanSound", -1);
					r_R__0__Job.SetBelong(this.instance);
				}
				return r_R__0__Job;
			}
		}

		/// <summary>
		/// Void #TYb()
		/// </summary>
		protected RMethod r_R__0__TYb;
		public virtual RMethod R__0__TYb
		{
			get
			{
				if(r_R__0__TYb == null)
				{
					r_R__0__TYb = new(this, "#TYb", 0);
					r_R__0__TYb.SetBelong(this.instance);
				}
				return r_R__0__TYb;
			}
		}

		/// <summary>
		/// Void #gob()
		/// </summary>
		protected RMethod r_R__0__gob;
		public virtual RMethod R__0__gob
		{
			get
			{
				if(r_R__0__gob == null)
				{
					r_R__0__gob = new(this, "#gob", 0);
					r_R__0__gob.SetBelong(this.instance);
				}
				return r_R__0__gob;
			}
		}

		/// <summary>
		/// Void #TYb(System.String)
		/// </summary>
		protected RMethod r_R__0__TYb_String;
		public virtual RMethod R__0__TYb_String
		{
			get
			{
				if(r_R__0__TYb_String == null)
				{
					r_R__0__TYb_String = new(this, "#TYb", 0, typeof(System.String));
					r_R__0__TYb_String.SetBelong(this.instance);
				}
				return r_R__0__TYb_String;
			}
		}

		/// <summary>
		/// Void #gob(System.String)
		/// </summary>
		protected RMethod r_R__0__gob_String;
		public virtual RMethod R__0__gob_String
		{
			get
			{
				if(r_R__0__gob_String == null)
				{
					r_R__0__gob_String = new(this, "#gob", 0, typeof(System.String));
					r_R__0__gob_String.SetBelong(this.instance);
				}
				return r_R__0__gob_String;
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


        public R__0__Lob() : base("#u.#Lob")
        {
        }

        public R__0__Lob(System.Object instance) : base("#u.#Lob")
		{
            SetInstance(instance);
		}

        public R__0__Lob(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Lob(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__TYb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__TYb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gob()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__gob.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__TYb(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = R__0__TYb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gob(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = R__0__gob_String.Invoke(___genericsType, ___parameters);

            
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
