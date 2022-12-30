using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#A7
	/// </summary>
    public partial class R__0__A7 : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[System.String][] #a
		/// </summary>
		protected RFieldArray<RSystem.RCollections.RGeneric.RList<RField>> r___0__a;
		public virtual RFieldArray<RSystem.RCollections.RGeneric.RList<RField>> R__0__a
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
		/// Void #w7(MaskWordHold)
		/// </summary>
		protected RMethod r_R__0__w7_MaskWordHold;
		public virtual RMethod R__0__w7_MaskWordHold
		{
			get
			{
				if(r_R__0__w7_MaskWordHold == null)
				{
					r_R__0__w7_MaskWordHold = new(this, "#w7", 0, typeof(MaskWordHold));
					r_R__0__w7_MaskWordHold.SetBelong(this.instance);
				}
				return r_R__0__w7_MaskWordHold;
			}
		}

		/// <summary>
		/// Boolean #x7(System.String)
		/// </summary>
		protected RMethod r_R__0__x7_String;
		public virtual RMethod R__0__x7_String
		{
			get
			{
				if(r_R__0__x7_String == null)
				{
					r_R__0__x7_String = new(this, "#x7", 0, typeof(System.String));
					r_R__0__x7_String.SetBelong(this.instance);
				}
				return r_R__0__x7_String;
			}
		}

		/// <summary>
		/// System.String #y7(System.String)
		/// </summary>
		protected RMethod r_R__0__y7_String;
		public virtual RMethod R__0__y7_String
		{
			get
			{
				if(r_R__0__y7_String == null)
				{
					r_R__0__y7_String = new(this, "#y7", 0, typeof(System.String));
					r_R__0__y7_String.SetBelong(this.instance);
				}
				return r_R__0__y7_String;
			}
		}

		/// <summary>
		/// System.String #z7(System.String)
		/// </summary>
		protected RMethod r_R__0__z7_String;
		public virtual RMethod R__0__z7_String
		{
			get
			{
				if(r_R__0__z7_String == null)
				{
					r_R__0__z7_String = new(this, "#z7", 0, typeof(System.String));
					r_R__0__z7_String.SetBelong(this.instance);
				}
				return r_R__0__z7_String;
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


        public R__0__A7() : base("#u.#A7")
        {
        }

        public R__0__A7(System.Object instance) : base("#u.#A7")
		{
            SetInstance(instance);
		}

        public R__0__A7(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__A7(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__w7(MaskWordHold  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = R__0__w7_MaskWordHold.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__x7(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__x7_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String __0__y7(System.String  @strInput)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strInput};
            var ___result = R__0__y7_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__z7(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__z7_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
