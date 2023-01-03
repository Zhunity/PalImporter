using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.InterfaceMapping
	/// </summary>
    public partial class RInterfaceMapping : RMember //
    {

		/// <summary>
		/// System.Type TargetType
		/// </summary>
		protected RSystem.RType r_TargetType;
		public virtual RSystem.RType RTargetType
		{
			get
			{
				if(r_TargetType == null)
				{
					r_TargetType = new(this, "TargetType");
					r_TargetType.SetBelong(this.instance);
				}
				return r_TargetType;
			}
		}

		/// <summary>
		/// System.Type InterfaceType
		/// </summary>
		protected RSystem.RType r_InterfaceType;
		public virtual RSystem.RType RInterfaceType
		{
			get
			{
				if(r_InterfaceType == null)
				{
					r_InterfaceType = new(this, "InterfaceType");
					r_InterfaceType.SetBelong(this.instance);
				}
				return r_InterfaceType;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] TargetMethods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RMethodInfo> r_TargetMethods;
		public virtual RFieldArray<RSystem.RReflection.RMethodInfo> RTargetMethods
		{
			get
			{
				if(r_TargetMethods == null)
				{
					r_TargetMethods = new(this, "TargetMethods");
					r_TargetMethods.SetBelong(this.instance);
				}
				return r_TargetMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] InterfaceMethods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RMethodInfo> r_InterfaceMethods;
		public virtual RFieldArray<RSystem.RReflection.RMethodInfo> RInterfaceMethods
		{
			get
			{
				if(r_InterfaceMethods == null)
				{
					r_InterfaceMethods = new(this, "InterfaceMethods");
					r_InterfaceMethods.SetBelong(this.instance);
				}
				return r_InterfaceMethods;
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


        public RInterfaceMapping() : base("System.Reflection.InterfaceMapping")
        {
        }

        public RInterfaceMapping(System.Object instance) : base("System.Reflection.InterfaceMapping")
		{
            SetInstance(instance);
		}

        public RInterfaceMapping(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInterfaceMapping(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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