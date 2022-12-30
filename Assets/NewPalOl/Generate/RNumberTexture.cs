using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NumberTexture
	/// </summary>
    public partial class RNumberTexture : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D #a
		/// </summary>
		protected RUnityEngine.RTexture2D r___0__a;
		public virtual RUnityEngine.RTexture2D R__0__a
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
		/// System.Int32 #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// Void #qJb(UnityEngine.Texture2D, Int32)
		/// </summary>
		protected RMethod r_R__0__qJb_Texture2D_Int32;
		public virtual RMethod R__0__qJb_Texture2D_Int32
		{
			get
			{
				if(r_R__0__qJb_Texture2D_Int32 == null)
				{
					r_R__0__qJb_Texture2D_Int32 = new(this, "#qJb", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32));
					r_R__0__qJb_Texture2D_Int32.SetBelong(this.instance);
				}
				return r_R__0__qJb_Texture2D_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D #rJb(Int64)
		/// </summary>
		protected RMethod r_R__0__rJb_Int64;
		public virtual RMethod R__0__rJb_Int64
		{
			get
			{
				if(r_R__0__rJb_Int64 == null)
				{
					r_R__0__rJb_Int64 = new(this, "#rJb", 0, typeof(System.Int64));
					r_R__0__rJb_Int64.SetBelong(this.instance);
				}
				return r_R__0__rJb_Int64;
			}
		}

		/// <summary>
		/// Void #rJb(UnityEngine.Texture2D, Int64)
		/// </summary>
		protected RMethod r_R__0__rJb_Texture2D_Int64;
		public virtual RMethod R__0__rJb_Texture2D_Int64
		{
			get
			{
				if(r_R__0__rJb_Texture2D_Int64 == null)
				{
					r_R__0__rJb_Texture2D_Int64 = new(this, "#rJb", 0, typeof(UnityEngine.Texture2D), typeof(System.Int64));
					r_R__0__rJb_Texture2D_Int64.SetBelong(this.instance);
				}
				return r_R__0__rJb_Texture2D_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D #sJb(System.String)
		/// </summary>
		protected RMethod r_R__0__sJb_String;
		public virtual RMethod R__0__sJb_String
		{
			get
			{
				if(r_R__0__sJb_String == null)
				{
					r_R__0__sJb_String = new(this, "#sJb", 0, typeof(System.String));
					r_R__0__sJb_String.SetBelong(this.instance);
				}
				return r_R__0__sJb_String;
			}
		}

		/// <summary>
		/// Void #tJb(UnityEngine.Texture2D, System.String)
		/// </summary>
		protected RMethod r_R__0__tJb_Texture2D_String;
		public virtual RMethod R__0__tJb_Texture2D_String
		{
			get
			{
				if(r_R__0__tJb_Texture2D_String == null)
				{
					r_R__0__tJb_Texture2D_String = new(this, "#tJb", 0, typeof(UnityEngine.Texture2D), typeof(System.String));
					r_R__0__tJb_Texture2D_String.SetBelong(this.instance);
				}
				return r_R__0__tJb_Texture2D_String;
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


        public RNumberTexture() : base("NumberTexture")
        {
        }

        public RNumberTexture(System.Object instance) : base("NumberTexture")
		{
            SetInstance(instance);
		}

        public RNumberTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNumberTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__qJb(UnityEngine.Texture2D  @numberTex, System.Int32  @columnNum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberTex, @columnNum};
            var ___result = R__0__qJb_Texture2D_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Texture2D __0__rJb(System.Int64  @number)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@number};
            var ___result = R__0__rJb_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void __0__rJb(UnityEngine.Texture2D  @numberTex, System.Int64  @number)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberTex, @number};
            var ___result = R__0__rJb_Texture2D_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Texture2D __0__sJb(System.String  @numString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numString};
            var ___result = R__0__sJb_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void __0__tJb(UnityEngine.Texture2D  @numberTex, System.String  @numString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numberTex, @numString};
            var ___result = R__0__tJb_Texture2D_String.Invoke(___genericsType, ___parameters);

            
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
