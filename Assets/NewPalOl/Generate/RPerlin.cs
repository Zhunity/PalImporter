using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Perlin
	/// </summary>
    public partial class RPerlin : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(Perlin), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32 #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(typeof(Perlin), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Int32 #c
		/// </summary>
		protected static RField r___0__c;
		public static RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(typeof(Perlin), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Int32[] #d
		/// </summary>
		protected RFieldArray<RField> r___0__d;
		public virtual RFieldArray<RField> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Single[,] #e
		/// </summary>
		protected RFieldArray<RField> r___0__e;
		public virtual RFieldArray<RField> R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Single[,] #f
		/// </summary>
		protected RFieldArray<RField> r___0__f;
		public virtual RFieldArray<RField> R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.Single[] #g
		/// </summary>
		protected RFieldArray<RField> r___0__g;
		public virtual RFieldArray<RField> R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new(this, "#g");
					r___0__g.SetBelong(this.instance);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// Single #ODd(Single)
		/// </summary>
		protected RMethod r_R__0__ODd_Single;
		public virtual RMethod R__0__ODd_Single
		{
			get
			{
				if(r_R__0__ODd_Single == null)
				{
					r_R__0__ODd_Single = new(this, "#ODd", 0, typeof(System.Single));
					r_R__0__ODd_Single.SetBelong(this.instance);
				}
				return r_R__0__ODd_Single;
			}
		}

		/// <summary>
		/// Single #E(Single, Single, Single)
		/// </summary>
		protected RMethod r_R__0__E_Single_Single_Single;
		public virtual RMethod R__0__E_Single_Single_Single
		{
			get
			{
				if(r_R__0__E_Single_Single_Single == null)
				{
					r_R__0__E_Single_Single_Single = new(this, "#E", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__E_Single_Single_Single.SetBelong(this.instance);
				}
				return r_R__0__E_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void #PDd(Single, Int32 ByRef, Int32 ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single;
		public virtual RMethod R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single
		{
			get
			{
				if(r_R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single == null)
				{
					r_R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single = new(this, "#PDd", 0, typeof(System.Single), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single.SetBelong(this.instance);
				}
				return r_R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single;
			}
		}

		/// <summary>
		/// Single #QDd(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_R__0__QDd_Single_Single_Single_Single;
		public virtual RMethod R__0__QDd_Single_Single_Single_Single
		{
			get
			{
				if(r_R__0__QDd_Single_Single_Single_Single == null)
				{
					r_R__0__QDd_Single_Single_Single_Single = new(this, "#QDd", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__QDd_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_R__0__QDd_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single #RDd(Single, Single, Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_R__0__RDd_Single_Single_Single_Single_Single_Single;
		public virtual RMethod R__0__RDd_Single_Single_Single_Single_Single_Single
		{
			get
			{
				if(r_R__0__RDd_Single_Single_Single_Single_Single_Single == null)
				{
					r_R__0__RDd_Single_Single_Single_Single_Single_Single = new(this, "#RDd", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__RDd_Single_Single_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_R__0__RDd_Single_Single_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single Noise(Single)
		/// </summary>
		protected RMethod r_RNoise_Single;
		public virtual RMethod RNoise_Single
		{
			get
			{
				if(r_RNoise_Single == null)
				{
					r_RNoise_Single = new(this, "Noise", 0, typeof(System.Single));
					r_RNoise_Single.SetBelong(this.instance);
				}
				return r_RNoise_Single;
			}
		}

		/// <summary>
		/// Single Noise(Single, Single)
		/// </summary>
		protected RMethod r_RNoise_Single_Single;
		public virtual RMethod RNoise_Single_Single
		{
			get
			{
				if(r_RNoise_Single_Single == null)
				{
					r_RNoise_Single_Single = new(this, "Noise", 0, typeof(System.Single), typeof(System.Single));
					r_RNoise_Single_Single.SetBelong(this.instance);
				}
				return r_RNoise_Single_Single;
			}
		}

		/// <summary>
		/// Single Noise(Single, Single, Single)
		/// </summary>
		protected RMethod r_RNoise_Single_Single_Single;
		public virtual RMethod RNoise_Single_Single_Single
		{
			get
			{
				if(r_RNoise_Single_Single_Single == null)
				{
					r_RNoise_Single_Single_Single = new(this, "Noise", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RNoise_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RNoise_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void #SDd(Single ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_R__0__SDd_Ref_Single_Ref_Single;
		public virtual RMethod R__0__SDd_Ref_Single_Ref_Single
		{
			get
			{
				if(r_R__0__SDd_Ref_Single_Ref_Single == null)
				{
					r_R__0__SDd_Ref_Single_Ref_Single = new(this, "#SDd", 0, typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_R__0__SDd_Ref_Single_Ref_Single.SetBelong(this.instance);
				}
				return r_R__0__SDd_Ref_Single_Ref_Single;
			}
		}

		/// <summary>
		/// Void #TDd(Single ByRef, Single ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_R__0__TDd_Ref_Single_Ref_Single_Ref_Single;
		public virtual RMethod R__0__TDd_Ref_Single_Ref_Single_Ref_Single
		{
			get
			{
				if(r_R__0__TDd_Ref_Single_Ref_Single_Ref_Single == null)
				{
					r_R__0__TDd_Ref_Single_Ref_Single_Ref_Single = new(this, "#TDd", 0, typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_R__0__TDd_Ref_Single_Ref_Single_Ref_Single.SetBelong(this.instance);
				}
				return r_R__0__TDd_Ref_Single_Ref_Single_Ref_Single;
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


        public RPerlin() : base("Perlin")
        {
        }

        public RPerlin(System.Object instance) : base("Perlin")
		{
            SetInstance(instance);
		}

        public RPerlin(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPerlin(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Single __0__ODd(System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = R__0__ODd_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single __0__E(System.Single  @t, System.Single  @a, System.Single  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @a, @b};
            var ___result = R__0__E_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void __0__PDd(System.Single  @value, out System.Int32  @b0, out System.Int32  @b1, out System.Single  @r0, out System.Single  @r1)
        {
			b0 = default;
			b1 = default;
			r0 = default;
			r1 = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @b0, @b1, @r0, @r1};
            var ___result = R__0__PDd_Single_Out_Int32_Out_Int32_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			b0 = (System.Int32)___parameters[1];
			b1 = (System.Int32)___parameters[2];
			r0 = (System.Single)___parameters[3];
			r1 = (System.Single)___parameters[4];

            
        }


        public virtual System.Single __0__QDd(System.Single  @rx, System.Single  @ry, System.Single  @x, System.Single  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rx, @ry, @x, @y};
            var ___result = R__0__QDd_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single __0__RDd(System.Single  @rx, System.Single  @ry, System.Single  @rz, System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rx, @ry, @rz, @x, @y, @z};
            var ___result = R__0__RDd_Single_Single_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single Noise(System.Single  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg};
            var ___result = RNoise_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single Noise(System.Single  @x, System.Single  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RNoise_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single Noise(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RNoise_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void __0__SDd(ref System.Single  @x, ref System.Single  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = R__0__SDd_Ref_Single_Ref_Single.Invoke(___genericsType, ___parameters);
			x = (System.Single)___parameters[0];
			y = (System.Single)___parameters[1];

            
        }


        public virtual void __0__TDd(ref System.Single  @x, ref System.Single  @y, ref System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = R__0__TDd_Ref_Single_Ref_Single_Ref_Single.Invoke(___genericsType, ___parameters);
			x = (System.Single)___parameters[0];
			y = (System.Single)___parameters[1];
			z = (System.Single)___parameters[2];

            
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
