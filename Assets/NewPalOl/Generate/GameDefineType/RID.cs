using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RGameDefineType
{
	/// <summary>
	/// GameDefineType.ID
	/// </summary>
    public partial class RID : RMember //
    {

		/// <summary>
		/// System.Int64 value
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
		/// GameDefineType.ID Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(GameDefineType.ID), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// Int32 CompareTo(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RCompareTo_ID;
		public virtual RMethod RCompareTo_ID
		{
			get
			{
				if(r_RCompareTo_ID == null)
				{
					r_RCompareTo_ID = new(this, "CompareTo", 0, typeof(GameDefineType.ID));
					r_RCompareTo_ID.SetBelong(this.instance);
				}
				return r_RCompareTo_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID op_Implicit(Int64)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Int64;
		public static RMethod Rop_Implicit_Int64
		{
			get
			{
				if(r_Rop_Implicit_Int64 == null)
				{
					r_Rop_Implicit_Int64 = new(typeof(GameDefineType.ID), "op_Implicit", 0, typeof(System.Int64));
					r_Rop_Implicit_Int64.SetBelong(null);
				}
				return r_Rop_Implicit_Int64;
			}
		}

		/// <summary>
		/// Int64 op_Implicit(GameDefineType.ID)
		/// </summary>
		protected static RMethod r_Rop_Implicit_ID;
		public static RMethod Rop_Implicit_ID
		{
			get
			{
				if(r_Rop_Implicit_ID == null)
				{
					r_Rop_Implicit_ID = new(typeof(GameDefineType.ID), "op_Implicit", 0, typeof(GameDefineType.ID));
					r_Rop_Implicit_ID.SetBelong(null);
				}
				return r_Rop_Implicit_ID;
			}
		}

		/// <summary>
		/// Boolean op_Equality(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected static RMethod r_Rop_Equality_ID_ID;
		public static RMethod Rop_Equality_ID_ID
		{
			get
			{
				if(r_Rop_Equality_ID_ID == null)
				{
					r_Rop_Equality_ID_ID = new(typeof(GameDefineType.ID), "op_Equality", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_Rop_Equality_ID_ID.SetBelong(null);
				}
				return r_Rop_Equality_ID_ID;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected static RMethod r_Rop_Inequality_ID_ID;
		public static RMethod Rop_Inequality_ID_ID
		{
			get
			{
				if(r_Rop_Inequality_ID_ID == null)
				{
					r_Rop_Inequality_ID_ID = new(typeof(GameDefineType.ID), "op_Inequality", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_Rop_Inequality_ID_ID.SetBelong(null);
				}
				return r_Rop_Inequality_ID_ID;
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


        public RID() : base("GameDefineType.ID")
        {
        }

        public RID(System.Object instance) : base("GameDefineType.ID")
		{
            SetInstance(instance);
		}

        public RID(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RID(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static GameDefineType.ID Parse(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Int32 CompareTo(GameDefineType.ID  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static GameDefineType.ID op_Implicit(System.Int64  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = Rop_Implicit_Int64.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public static System.Int64 op_Implicit(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = Rop_Implicit_ID.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Boolean op_Equality(GameDefineType.ID  @x, GameDefineType.ID  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_Equality_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(GameDefineType.ID  @x, GameDefineType.ID  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = Rop_Inequality_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
