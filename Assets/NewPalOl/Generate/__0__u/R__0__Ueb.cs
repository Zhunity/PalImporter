using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Ueb
	/// </summary>
    public partial class R__0__Ueb : RMember //
    {

		/// <summary>
		/// #u.#Yeb #a
		/// </summary>
		protected R__0__u.R__0__Yeb r___0__a;
		public virtual R__0__u.R__0__Yeb R__0__a
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
		/// System.Int32 #b
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
		/// Int32 ComponentID
		/// </summary>
		protected RProperty r_R__0__Seb;
		public virtual RProperty R__0__Seb
		{
			get
			{
				if(r_R__0__Seb == null)
				{
					r_R__0__Seb = new(this, "ComponentID", -1);
					r_R__0__Seb.SetBelong(this.instance);
				}
				return r_R__0__Seb;
			}
		}

		/// <summary>
		/// Void SetPropertyValue(System.Object, System.Reflection.FieldInfo, System.String)
		/// </summary>
		protected static RMethod r_RSetPropertyValue_Object_FieldInfo_String;
		public static RMethod RSetPropertyValue_Object_FieldInfo_String
		{
			get
			{
				if(r_RSetPropertyValue_Object_FieldInfo_String == null)
				{
					r_RSetPropertyValue_Object_FieldInfo_String = new( ReleactionUtils.GetType("#u.#Ueb"), "SetPropertyValue", 0, typeof(System.Object), typeof(System.Reflection.FieldInfo), typeof(System.String));
					r_RSetPropertyValue_Object_FieldInfo_String.SetBelong(null);
				}
				return r_RSetPropertyValue_Object_FieldInfo_String;
			}
		}

		/// <summary>
		/// Void SetPropertyValue(System.Object, System.Reflection.PropertyInfo, System.String)
		/// </summary>
		protected static RMethod r_RSetPropertyValue_Object_PropertyInfo_String;
		public static RMethod RSetPropertyValue_Object_PropertyInfo_String
		{
			get
			{
				if(r_RSetPropertyValue_Object_PropertyInfo_String == null)
				{
					r_RSetPropertyValue_Object_PropertyInfo_String = new( ReleactionUtils.GetType("#u.#Ueb"), "SetPropertyValue", 0, typeof(System.Object), typeof(System.Reflection.PropertyInfo), typeof(System.String));
					r_RSetPropertyValue_Object_PropertyInfo_String.SetBelong(null);
				}
				return r_RSetPropertyValue_Object_PropertyInfo_String;
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


        public R__0__Ueb() : base("#u.#Ueb")
        {
        }

        public R__0__Ueb(System.Object instance) : base("#u.#Ueb")
		{
            SetInstance(instance);
		}

        public R__0__Ueb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Ueb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetPropertyValue(System.Object  @instance, System.Reflection.FieldInfo  @prop, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instance, @prop, @value};
            var ___result = RSetPropertyValue_Object_FieldInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetPropertyValue(System.Object  @instance, System.Reflection.PropertyInfo  @prop, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instance, @prop, @value};
            var ___result = RSetPropertyValue_Object_PropertyInfo_String.Invoke(___genericsType, ___parameters);

            
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
