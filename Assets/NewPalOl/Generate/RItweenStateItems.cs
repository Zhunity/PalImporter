using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ItweenStateItems
	/// </summary>
    public partial class RItweenStateItems : RMember //
    {

		/// <summary>
		/// System.Int32 m_time
		/// </summary>
		protected RField r_m_time;
		public virtual RField Rm_time
		{
			get
			{
				if(r_m_time == null)
				{
					r_m_time = new(this, "m_time");
					r_m_time.SetBelong(this.instance);
				}
				return r_m_time;
			}
		}

		/// <summary>
		/// System.Int32 valueInt
		/// </summary>
		protected RField r_valueInt;
		public virtual RField RvalueInt
		{
			get
			{
				if(r_valueInt == null)
				{
					r_valueInt = new(this, "valueInt");
					r_valueInt.SetBelong(this.instance);
				}
				return r_valueInt;
			}
		}

		/// <summary>
		/// System.Single valueFloat
		/// </summary>
		protected RField r_valueFloat;
		public virtual RField RvalueFloat
		{
			get
			{
				if(r_valueFloat == null)
				{
					r_valueFloat = new(this, "valueFloat");
					r_valueFloat.SetBelong(this.instance);
				}
				return r_valueFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 valueVector3
		/// </summary>
		protected RUnityEngine.RVector3 r_valueVector3;
		public virtual RUnityEngine.RVector3 RvalueVector3
		{
			get
			{
				if(r_valueVector3 == null)
				{
					r_valueVector3 = new(this, "valueVector3");
					r_valueVector3.SetBelong(this.instance);
				}
				return r_valueVector3;
			}
		}

		/// <summary>
		/// UnityEngine.Color valueColor
		/// </summary>
		protected RUnityEngine.RColor r_valueColor;
		public virtual RUnityEngine.RColor RvalueColor
		{
			get
			{
				if(r_valueColor == null)
				{
					r_valueColor = new(this, "valueColor");
					r_valueColor.SetBelong(this.instance);
				}
				return r_valueColor;
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


        public RItweenStateItems() : base("ItweenStateItems")
        {
        }

        public RItweenStateItems(System.Object instance) : base("ItweenStateItems")
		{
            SetInstance(instance);
		}

        public RItweenStateItems(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RItweenStateItems(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
