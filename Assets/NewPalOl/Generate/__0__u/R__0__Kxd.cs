using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Kxd
	/// </summary>
    public partial class R__0__Kxd : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("#u.#Kxd"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// KeyValueContent #b
		/// </summary>
		protected RKeyValueContent r___0__b;
		public virtual RKeyValueContent R__0__b
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
		/// Void OnLoadEquipmentsuffixConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadEquipmentsuffixConfig_Object;
		public virtual RMethod ROnLoadEquipmentsuffixConfig_Object
		{
			get
			{
				if(r_ROnLoadEquipmentsuffixConfig_Object == null)
				{
					r_ROnLoadEquipmentsuffixConfig_Object = new(this, "OnLoadEquipmentsuffixConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadEquipmentsuffixConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadEquipmentsuffixConfig_Object;
			}
		}

		/// <summary>
		/// System.String #GVc(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__GVc_ID_String;
		public virtual RMethod R__0__GVc_ID_String
		{
			get
			{
				if(r_R__0__GVc_ID_String == null)
				{
					r_R__0__GVc_ID_String = new(this, "#GVc", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__GVc_ID_String.SetBelong(this.instance);
				}
				return r_R__0__GVc_ID_String;
			}
		}

		/// <summary>
		/// Int32 #Jxd(#u.#Ckb, System.String)
		/// </summary>
		protected RMethod r_R__0__Jxd___0__Ckb_String;
		public virtual RMethod R__0__Jxd___0__Ckb_String
		{
			get
			{
				if(r_R__0__Jxd___0__Ckb_String == null)
				{
					r_R__0__Jxd___0__Ckb_String = new(this, "#Jxd", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.String));
					r_R__0__Jxd___0__Ckb_String.SetBelong(this.instance);
				}
				return r_R__0__Jxd___0__Ckb_String;
			}
		}

		/// <summary>
		/// Int32 #Cae(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__Cae_Int32_Int32;
		public virtual RMethod R__0__Cae_Int32_Int32
		{
			get
			{
				if(r_R__0__Cae_Int32_Int32 == null)
				{
					r_R__0__Cae_Int32_Int32 = new(this, "#Cae", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__Cae_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__Cae_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 #Dae(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__Dae_Int32_Int32;
		public virtual RMethod R__0__Dae_Int32_Int32
		{
			get
			{
				if(r_R__0__Dae_Int32_Int32 == null)
				{
					r_R__0__Dae_Int32_Int32 = new(this, "#Dae", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__Dae_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__Dae_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 #GVj(#u.#Dkb)
		/// </summary>
		protected RMethod r_R__0__GVj___0__Dkb;
		public virtual RMethod R__0__GVj___0__Dkb
		{
			get
			{
				if(r_R__0__GVj___0__Dkb == null)
				{
					r_R__0__GVj___0__Dkb = new(this, "#GVj", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_R__0__GVj___0__Dkb.SetBelong(this.instance);
				}
				return r_R__0__GVj___0__Dkb;
			}
		}

		/// <summary>
		/// Int32 #HVj(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__HVj_Int32_Int32;
		public virtual RMethod R__0__HVj_Int32_Int32
		{
			get
			{
				if(r_R__0__HVj_Int32_Int32 == null)
				{
					r_R__0__HVj_Int32_Int32 = new(this, "#HVj", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__HVj_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__HVj_Int32_Int32;
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


        public R__0__Kxd() : base("#u.#Kxd")
        {
        }

        public R__0__Kxd(System.Object instance) : base("#u.#Kxd")
		{
            SetInstance(instance);
		}

        public R__0__Kxd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Kxd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadEquipmentsuffixConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadEquipmentsuffixConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__GVc(GameDefineType.ID  @id, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @name};
            var ___result = R__0__GVc_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.Int32 __0__Cae(System.Int32  @now, System.Int32  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@now, @max};
            var ___result = R__0__Cae_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__Dae(System.Int32  @now, System.Int32  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@now, @max};
            var ___result = R__0__Dae_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 __0__HVj(System.Int32  @sumval, System.Int32  @goldnum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sumval, @goldnum};
            var ___result = R__0__HVj_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
