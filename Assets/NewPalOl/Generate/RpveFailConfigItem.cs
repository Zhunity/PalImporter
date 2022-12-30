using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// pveFailConfigItem
	/// </summary>
    public partial class RpveFailConfigItem : RMember //
    {

		/// <summary>
		/// System.Int32 idLv
		/// </summary>
		protected RField r_idLv;
		public virtual RField RidLv
		{
			get
			{
				if(r_idLv == null)
				{
					r_idLv = new(this, "idLv");
					r_idLv.SetBelong(this.instance);
				}
				return r_idLv;
			}
		}

		/// <summary>
		/// System.String help0
		/// </summary>
		protected RField r_help0;
		public virtual RField Rhelp0
		{
			get
			{
				if(r_help0 == null)
				{
					r_help0 = new(this, "help0");
					r_help0.SetBelong(this.instance);
				}
				return r_help0;
			}
		}

		/// <summary>
		/// System.String help1
		/// </summary>
		protected RField r_help1;
		public virtual RField Rhelp1
		{
			get
			{
				if(r_help1 == null)
				{
					r_help1 = new(this, "help1");
					r_help1.SetBelong(this.instance);
				}
				return r_help1;
			}
		}

		/// <summary>
		/// System.String help2
		/// </summary>
		protected RField r_help2;
		public virtual RField Rhelp2
		{
			get
			{
				if(r_help2 == null)
				{
					r_help2 = new(this, "help2");
					r_help2.SetBelong(this.instance);
				}
				return r_help2;
			}
		}

		/// <summary>
		/// System.String help3
		/// </summary>
		protected RField r_help3;
		public virtual RField Rhelp3
		{
			get
			{
				if(r_help3 == null)
				{
					r_help3 = new(this, "help3");
					r_help3.SetBelong(this.instance);
				}
				return r_help3;
			}
		}

		/// <summary>
		/// System.String GetHelp(Int32)
		/// </summary>
		protected RMethod r_RGetHelp_Int32;
		public virtual RMethod RGetHelp_Int32
		{
			get
			{
				if(r_RGetHelp_Int32 == null)
				{
					r_RGetHelp_Int32 = new(this, "GetHelp", 0, typeof(System.Int32));
					r_RGetHelp_Int32.SetBelong(this.instance);
				}
				return r_RGetHelp_Int32;
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


        public RpveFailConfigItem() : base("pveFailConfigItem")
        {
        }

        public RpveFailConfigItem(System.Object instance) : base("pveFailConfigItem")
		{
            SetInstance(instance);
		}

        public RpveFailConfigItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RpveFailConfigItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String GetHelp(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetHelp_Int32.Invoke(___genericsType, ___parameters);

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
