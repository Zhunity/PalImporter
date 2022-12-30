using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__PT
{
	/// <summary>
	/// #PT.#RT
	/// </summary>
    public partial class R__0__RT : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 CatmullRom(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single;
		public static RMethod RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single
		{
			get
			{
				if(r_RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single == null)
				{
					r_RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single = new( ReleactionUtils.GetType("#PT.#RT"), "CatmullRom", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 #QT(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_R__0__QT_Vector3_Vector3_Vector3_Vector3_Single;
		public static RMethod R__0__QT_Vector3_Vector3_Vector3_Vector3_Single
		{
			get
			{
				if(r_R__0__QT_Vector3_Vector3_Vector3_Vector3_Single == null)
				{
					r_R__0__QT_Vector3_Vector3_Vector3_Vector3_Single = new( ReleactionUtils.GetType("#PT.#RT"), "#QT", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_R__0__QT_Vector3_Vector3_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_R__0__QT_Vector3_Vector3_Vector3_Vector3_Single;
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


        public R__0__RT() : base("#PT.#RT")
        {
        }

        public R__0__RT(System.Object instance) : base("#PT.#RT")
		{
            SetInstance(instance);
		}

        public R__0__RT(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__RT(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Vector3 CatmullRom(UnityEngine.Vector3  @previous, UnityEngine.Vector3  @start, UnityEngine.Vector3  @end, UnityEngine.Vector3  @next, System.Single  @elapsedTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous, @start, @end, @next, @elapsedTime};
            var ___result = RCatmullRom_Vector3_Vector3_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3 __0__QT(UnityEngine.Vector3  @previous, UnityEngine.Vector3  @start, UnityEngine.Vector3  @end, UnityEngine.Vector3  @next, System.Single  @elapsedTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous, @start, @end, @next, @elapsedTime};
            var ___result = R__0__QT_Vector3_Vector3_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
