using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.CustomAttributeNamedArgument
	/// </summary>
    public partial class RCustomAttributeNamedArgument : RMember //
    {

		/// <summary>
		/// System.Reflection.CustomAttributeTypedArgument <TypedValue>k__BackingField
		/// </summary>
		protected RSystem.RReflection.RCustomAttributeTypedArgument r___2__TypedValue__4__k__BackingField;
		public virtual RSystem.RReflection.RCustomAttributeTypedArgument R__2__TypedValue__4__k__BackingField
		{
			get
			{
				if(r___2__TypedValue__4__k__BackingField == null)
				{
					r___2__TypedValue__4__k__BackingField = new(this, "<TypedValue>k__BackingField");
					r___2__TypedValue__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__TypedValue__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <IsField>k__BackingField
		/// </summary>
		protected RField r___2__IsField__4__k__BackingField;
		public virtual RField R__2__IsField__4__k__BackingField
		{
			get
			{
				if(r___2__IsField__4__k__BackingField == null)
				{
					r___2__IsField__4__k__BackingField = new(this, "<IsField>k__BackingField");
					r___2__IsField__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__IsField__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <MemberName>k__BackingField
		/// </summary>
		protected RField r___2__MemberName__4__k__BackingField;
		public virtual RField R__2__MemberName__4__k__BackingField
		{
			get
			{
				if(r___2__MemberName__4__k__BackingField == null)
				{
					r___2__MemberName__4__k__BackingField = new(this, "<MemberName>k__BackingField");
					r___2__MemberName__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__MemberName__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type _attributeType
		/// </summary>
		protected RSystem.RType r__attributeType;
		public virtual RSystem.RType R_attributeType
		{
			get
			{
				if(r__attributeType == null)
				{
					r__attributeType = new(this, "_attributeType");
					r__attributeType.SetBelong(this.instance);
				}
				return r__attributeType;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo _lazyMemberInfo
		/// </summary>
		protected RSystem.RReflection.RMemberInfo r__lazyMemberInfo;
		public virtual RSystem.RReflection.RMemberInfo R_lazyMemberInfo
		{
			get
			{
				if(r__lazyMemberInfo == null)
				{
					r__lazyMemberInfo = new(this, "_lazyMemberInfo");
					r__lazyMemberInfo.SetBelong(this.instance);
				}
				return r__lazyMemberInfo;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeTypedArgument TypedValue
		/// </summary>
		protected RSystem.RReflection.RCustomAttributeTypedArgument r_TypedValue;
		public virtual RSystem.RReflection.RCustomAttributeTypedArgument RTypedValue
		{
			get
			{
				if(r_TypedValue == null)
				{
					r_TypedValue = new(this, "TypedValue", -1);
					r_TypedValue.SetBelong(this.instance);
				}
				return r_TypedValue;
			}
		}

		/// <summary>
		/// Boolean IsField
		/// </summary>
		protected RProperty r_IsField;
		public virtual RProperty RIsField
		{
			get
			{
				if(r_IsField == null)
				{
					r_IsField = new(this, "IsField", -1);
					r_IsField.SetBelong(this.instance);
				}
				return r_IsField;
			}
		}

		/// <summary>
		/// System.String MemberName
		/// </summary>
		protected RProperty r_MemberName;
		public virtual RProperty RMemberName
		{
			get
			{
				if(r_MemberName == null)
				{
					r_MemberName = new(this, "MemberName", -1);
					r_MemberName.SetBelong(this.instance);
				}
				return r_MemberName;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo MemberInfo
		/// </summary>
		protected RSystem.RReflection.RMemberInfo r_MemberInfo;
		public virtual RSystem.RReflection.RMemberInfo RMemberInfo
		{
			get
			{
				if(r_MemberInfo == null)
				{
					r_MemberInfo = new(this, "MemberInfo", -1);
					r_MemberInfo.SetBelong(this.instance);
				}
				return r_MemberInfo;
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
		/// Boolean op_Equality(System.Reflection.CustomAttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument)
		/// </summary>
		protected static RMethod r_Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
		public static RMethod Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument
		{
			get
			{
				if(r_Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument == null)
				{
					r_Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument = new(typeof(System.Reflection.CustomAttributeNamedArgument), "op_Equality", 0, typeof(System.Reflection.CustomAttributeNamedArgument), typeof(System.Reflection.CustomAttributeNamedArgument));
					r_Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.SetBelong(null);
				}
				return r_Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.CustomAttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument)
		/// </summary>
		protected static RMethod r_Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
		public static RMethod Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument
		{
			get
			{
				if(r_Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument == null)
				{
					r_Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument = new(typeof(System.Reflection.CustomAttributeNamedArgument), "op_Inequality", 0, typeof(System.Reflection.CustomAttributeNamedArgument), typeof(System.Reflection.CustomAttributeNamedArgument));
					r_Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.SetBelong(null);
				}
				return r_Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
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


        public RCustomAttributeNamedArgument() : base("System.Reflection.CustomAttributeNamedArgument")
        {
        }

        public RCustomAttributeNamedArgument(System.Object instance) : base("System.Reflection.CustomAttributeNamedArgument")
		{
            SetInstance(instance);
		}

        public RCustomAttributeNamedArgument(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeNamedArgument(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public static System.Boolean op_Equality(System.Reflection.CustomAttributeNamedArgument  @left, System.Reflection.CustomAttributeNamedArgument  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.CustomAttributeNamedArgument  @left, System.Reflection.CustomAttributeNamedArgument  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
