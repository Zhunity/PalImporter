using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono
{
	/// <summary>
	/// Mono.RuntimePropertyHandle
	/// </summary>
    public partial class RRuntimePropertyHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
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
		/// Boolean Equals(Mono.RuntimePropertyHandle)
		/// </summary>
		protected RMethod r_REquals_RuntimePropertyHandle;
		public virtual RMethod REquals_RuntimePropertyHandle
		{
			get
			{
				if(r_REquals_RuntimePropertyHandle == null)
				{
					r_REquals_RuntimePropertyHandle = new(this, "Equals", 0,  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_REquals_RuntimePropertyHandle.SetBelong(this.instance);
				}
				return r_REquals_RuntimePropertyHandle;
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
		/// Boolean op_Equality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReleactionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Equality", 0,  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"),  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle.SetBelong(null);
				}
				return r_Rop_Equality_RuntimePropertyHandle_RuntimePropertyHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(Mono.RuntimePropertyHandle, Mono.RuntimePropertyHandle)
		/// </summary>
		protected static RMethod r_Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
		public static RMethod Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle
		{
			get
			{
				if(r_Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle == null)
				{
					r_Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle = new( ReleactionUtils.GetType("Mono.RuntimePropertyHandle"), "op_Inequality", 0,  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"),  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"));
					r_Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle.SetBelong(null);
				}
				return r_Rop_Inequality_RuntimePropertyHandle_RuntimePropertyHandle;
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


        public RRuntimePropertyHandle() : base("Mono.RuntimePropertyHandle")
        {
        }

        public RRuntimePropertyHandle(System.Object instance) : base("Mono.RuntimePropertyHandle")
		{
            SetInstance(instance);
		}

        public RRuntimePropertyHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimePropertyHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
