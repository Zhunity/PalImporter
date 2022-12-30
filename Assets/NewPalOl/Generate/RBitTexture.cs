using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BitTexture
	/// </summary>
    public partial class RBitTexture : RMember //
    {

		/// <summary>
		/// System.Collections.BitArray #a
		/// </summary>
		protected RSystem.RCollections.RBitArray r___0__a;
		public virtual RSystem.RCollections.RBitArray R__0__a
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
		/// System.Collections.BitArray Bits
		/// </summary>
		protected RSystem.RCollections.RBitArray r_Bits;
		public virtual RSystem.RCollections.RBitArray RBits
		{
			get
			{
				if(r_Bits == null)
				{
					r_Bits = new(this, "Bits", -1);
					r_Bits.SetBelong(this.instance);
				}
				return r_Bits;
			}
		}

		/// <summary>
		/// Int32 Height
		/// </summary>
		protected RProperty r_Height;
		public virtual RProperty RHeight
		{
			get
			{
				if(r_Height == null)
				{
					r_Height = new(this, "Height", -1);
					r_Height.SetBelong(this.instance);
				}
				return r_Height;
			}
		}

		/// <summary>
		/// Int32 Width
		/// </summary>
		protected RProperty r_Width;
		public virtual RProperty RWidth
		{
			get
			{
				if(r_Width == null)
				{
					r_Width = new(this, "Width", -1);
					r_Width.SetBelong(this.instance);
				}
				return r_Width;
			}
		}

		/// <summary>
		/// Void SetBitData(System.String)
		/// </summary>
		protected RMethod r_RSetBitData_String;
		public virtual RMethod RSetBitData_String
		{
			get
			{
				if(r_RSetBitData_String == null)
				{
					r_RSetBitData_String = new(this, "SetBitData", 0, typeof(System.String));
					r_RSetBitData_String.SetBelong(this.instance);
				}
				return r_RSetBitData_String;
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


        public RBitTexture() : base("BitTexture")
        {
        }

        public RBitTexture(System.Object instance) : base("BitTexture")
		{
            SetInstance(instance);
		}

        public RBitTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBitTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetBitData(System.String  @base64Data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@base64Data};
            var ___result = RSetBitData_String.Invoke(___genericsType, ___parameters);

            
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
