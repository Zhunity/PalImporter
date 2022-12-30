using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RefreshRate
	/// </summary>
    public partial class RRefreshRate : RMember //
    {

		/// <summary>
		/// System.UInt32 numerator
		/// </summary>
		protected RField r_numerator;
		public virtual RField Rnumerator
		{
			get
			{
				if(r_numerator == null)
				{
					r_numerator = new(this, "numerator");
					r_numerator.SetBelong(this.instance);
				}
				return r_numerator;
			}
		}

		/// <summary>
		/// System.UInt32 denominator
		/// </summary>
		protected RField r_denominator;
		public virtual RField Rdenominator
		{
			get
			{
				if(r_denominator == null)
				{
					r_denominator = new(this, "denominator");
					r_denominator.SetBelong(this.instance);
				}
				return r_denominator;
			}
		}

		/// <summary>
		/// Double value
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
		/// Boolean Equals(UnityEngine.RefreshRate)
		/// </summary>
		protected RMethod r_REquals_RefreshRate;
		public virtual RMethod REquals_RefreshRate
		{
			get
			{
				if(r_REquals_RefreshRate == null)
				{
					r_REquals_RefreshRate = new(this, "Equals", 0, typeof(UnityEngine.RefreshRate));
					r_REquals_RefreshRate.SetBelong(this.instance);
				}
				return r_REquals_RefreshRate;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEngine.RefreshRate)
		/// </summary>
		protected RMethod r_RCompareTo_RefreshRate;
		public virtual RMethod RCompareTo_RefreshRate
		{
			get
			{
				if(r_RCompareTo_RefreshRate == null)
				{
					r_RCompareTo_RefreshRate = new(this, "CompareTo", 0, typeof(UnityEngine.RefreshRate));
					r_RCompareTo_RefreshRate.SetBelong(this.instance);
				}
				return r_RCompareTo_RefreshRate;
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


        public RRefreshRate() : base("UnityEngine.RefreshRate")
        {
        }

        public RRefreshRate(System.Object instance) : base("UnityEngine.RefreshRate")
		{
            SetInstance(instance);
		}

        public RRefreshRate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRefreshRate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(UnityEngine.RefreshRate  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_RefreshRate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 CompareTo(UnityEngine.RefreshRate  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_RefreshRate.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
