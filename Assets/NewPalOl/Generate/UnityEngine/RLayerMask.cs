using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.LayerMask
	/// </summary>
    public partial class RLayerMask : RMember //
    {

		/// <summary>
		/// System.Int32 m_Mask
		/// </summary>
		protected RField r_m_Mask;
		public virtual RField Rm_Mask
		{
			get
			{
				if(r_m_Mask == null)
				{
					r_m_Mask = new(this, "m_Mask");
					r_m_Mask.SetBelong(this.instance);
				}
				return r_m_Mask;
			}
		}

		/// <summary>
		/// Int32 value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// Int32 op_Implicit(UnityEngine.LayerMask)
		/// </summary>
		protected static RMethod r_Rop_Implicit_LayerMask;
		public static RMethod Rop_Implicit_LayerMask
		{
			get
			{
				if(r_Rop_Implicit_LayerMask == null)
				{
					r_Rop_Implicit_LayerMask = new(typeof(UnityEngine.LayerMask), "op_Implicit", 0, typeof(UnityEngine.LayerMask));
					r_Rop_Implicit_LayerMask.SetBelong(null);
				}
				return r_Rop_Implicit_LayerMask;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Int32;
		public static RMethod Rop_Implicit_Int32
		{
			get
			{
				if(r_Rop_Implicit_Int32 == null)
				{
					r_Rop_Implicit_Int32 = new(typeof(UnityEngine.LayerMask), "op_Implicit", 0, typeof(System.Int32));
					r_Rop_Implicit_Int32.SetBelong(null);
				}
				return r_Rop_Implicit_Int32;
			}
		}

		/// <summary>
		/// System.String LayerToName(Int32)
		/// </summary>
		protected static RMethod r_RLayerToName_Int32;
		public static RMethod RLayerToName_Int32
		{
			get
			{
				if(r_RLayerToName_Int32 == null)
				{
					r_RLayerToName_Int32 = new(typeof(UnityEngine.LayerMask), "LayerToName", 0, typeof(System.Int32));
					r_RLayerToName_Int32.SetBelong(null);
				}
				return r_RLayerToName_Int32;
			}
		}

		/// <summary>
		/// Int32 NameToLayer(System.String)
		/// </summary>
		protected static RMethod r_RNameToLayer_String;
		public static RMethod RNameToLayer_String
		{
			get
			{
				if(r_RNameToLayer_String == null)
				{
					r_RNameToLayer_String = new(typeof(UnityEngine.LayerMask), "NameToLayer", 0, typeof(System.String));
					r_RNameToLayer_String.SetBelong(null);
				}
				return r_RNameToLayer_String;
			}
		}

		/// <summary>
		/// Int32 GetMask(System.String[])
		/// </summary>
		protected static RMethod r_RGetMask_StringArray;
		public static RMethod RGetMask_StringArray
		{
			get
			{
				if(r_RGetMask_StringArray == null)
				{
					r_RGetMask_StringArray = new(typeof(UnityEngine.LayerMask), "GetMask", 0, typeof(System.String).MakeArrayType());
					r_RGetMask_StringArray.SetBelong(null);
				}
				return r_RGetMask_StringArray;
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


        public RLayerMask() : base("UnityEngine.LayerMask")
        {
        }

        public RLayerMask(System.Object instance) : base("UnityEngine.LayerMask")
		{
            SetInstance(instance);
		}

        public RLayerMask(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLayerMask(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 op_Implicit(UnityEngine.LayerMask  @mask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mask};
            var ___result = Rop_Implicit_LayerMask.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.LayerMask op_Implicit(System.Int32  @intVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intVal};
            var ___result = Rop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.LayerMask)___result;
        }


        public static System.String LayerToName(System.Int32  @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layer};
            var ___result = RLayerToName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 NameToLayer(System.String  @layerName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerName};
            var ___result = RNameToLayer_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetMask(System.String[]  @layerNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layerNames};
            var ___result = RGetMask_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
