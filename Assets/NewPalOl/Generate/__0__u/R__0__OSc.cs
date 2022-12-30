using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#OSc
	/// </summary>
    public partial class R__0__OSc : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[TargetConfig]] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RTargetConfig>> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RTargetConfig>> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[#u.#OSc+#Wjb]] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<R__0__u.R__0__OSc.R__0__Wjb>> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<R__0__u.R__0__OSc.R__0__Wjb>> R__0__b
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
		/// #Pfb.#cFb #c
		/// </summary>
		protected R__0__Pfb.R__0__cFb r___0__c;
		public virtual R__0__Pfb.R__0__cFb R__0__c
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
		/// System.Comparison`1[TargetConfig] #d
		/// </summary>
		protected static RSystem.RComparison<RTargetConfig> r___0__d;
		public static RSystem.RComparison<RTargetConfig> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new( ReleactionUtils.GetType("#u.#OSc"), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void #yjb(PhaseTargetConfigHold)
		/// </summary>
		protected RMethod r_R__0__yjb_PhaseTargetConfigHold;
		public virtual RMethod R__0__yjb_PhaseTargetConfigHold
		{
			get
			{
				if(r_R__0__yjb_PhaseTargetConfigHold == null)
				{
					r_R__0__yjb_PhaseTargetConfigHold = new(this, "#yjb", 0, typeof(PhaseTargetConfigHold));
					r_R__0__yjb_PhaseTargetConfigHold.SetBelong(this.instance);
				}
				return r_R__0__yjb_PhaseTargetConfigHold;
			}
		}

		/// <summary>
		/// Void #Mjb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Mjb_Object___0__Isb;
		public virtual RMethod R__0__Mjb_Object___0__Isb
		{
			get
			{
				if(r_R__0__Mjb_Object___0__Isb == null)
				{
					r_R__0__Mjb_Object___0__Isb = new(this, "#Mjb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Mjb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Mjb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Cjb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Cjb_Object_Object;
		public virtual RMethod R__0__Cjb_Object_Object
		{
			get
			{
				if(r_R__0__Cjb_Object_Object == null)
				{
					r_R__0__Cjb_Object_Object = new(this, "#Cjb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Cjb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Cjb_Object_Object;
			}
		}

		/// <summary>
		/// Int32 #Njb()
		/// </summary>
		protected RMethod r_R__0__Njb;
		public virtual RMethod R__0__Njb
		{
			get
			{
				if(r_R__0__Njb == null)
				{
					r_R__0__Njb = new(this, "#Njb", 0);
					r_R__0__Njb.SetBelong(this.instance);
				}
				return r_R__0__Njb;
			}
		}

		/// <summary>
		/// Boolean #Ojb(Int32)
		/// </summary>
		protected RMethod r_R__0__Ojb_Int32;
		public virtual RMethod R__0__Ojb_Int32
		{
			get
			{
				if(r_R__0__Ojb_Int32 == null)
				{
					r_R__0__Ojb_Int32 = new(this, "#Ojb", 0, typeof(System.Int32));
					r_R__0__Ojb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Ojb_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Byte] #Pjb()
		/// </summary>
		protected RMethod r_R__0__Pjb;
		public virtual RMethod R__0__Pjb
		{
			get
			{
				if(r_R__0__Pjb == null)
				{
					r_R__0__Pjb = new(this, "#Pjb", 0);
					r_R__0__Pjb.SetBelong(this.instance);
				}
				return r_R__0__Pjb;
			}
		}

		/// <summary>
		/// Boolean #ind()
		/// </summary>
		protected RMethod r_R__0__ind;
		public virtual RMethod R__0__ind
		{
			get
			{
				if(r_R__0__ind == null)
				{
					r_R__0__ind = new(this, "#ind", 0);
					r_R__0__ind.SetBelong(this.instance);
				}
				return r_R__0__ind;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TargetConfig] #Qjb(Int32)
		/// </summary>
		protected RMethod r_R__0__Qjb_Int32;
		public virtual RMethod R__0__Qjb_Int32
		{
			get
			{
				if(r_R__0__Qjb_Int32 == null)
				{
					r_R__0__Qjb_Int32 = new(this, "#Qjb", 0, typeof(System.Int32));
					r_R__0__Qjb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Qjb_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#OSc+#Wjb] #Rjb(Int32)
		/// </summary>
		protected RMethod r_R__0__Rjb_Int32;
		public virtual RMethod R__0__Rjb_Int32
		{
			get
			{
				if(r_R__0__Rjb_Int32 == null)
				{
					r_R__0__Rjb_Int32 = new(this, "#Rjb", 0, typeof(System.Int32));
					r_R__0__Rjb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Rjb_Int32;
			}
		}

		/// <summary>
		/// Void #S1c()
		/// </summary>
		protected RMethod r_R__0__S1c;
		public virtual RMethod R__0__S1c
		{
			get
			{
				if(r_R__0__S1c == null)
				{
					r_R__0__S1c = new(this, "#S1c", 0);
					r_R__0__S1c.SetBelong(this.instance);
				}
				return r_R__0__S1c;
			}
		}

		/// <summary>
		/// Void #Sjb()
		/// </summary>
		protected RMethod r_R__0__Sjb;
		public virtual RMethod R__0__Sjb
		{
			get
			{
				if(r_R__0__Sjb == null)
				{
					r_R__0__Sjb = new(this, "#Sjb", 0);
					r_R__0__Sjb.SetBelong(this.instance);
				}
				return r_R__0__Sjb;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Int32 #Kae()
		/// </summary>
		protected RMethod r_R__0__Kae;
		public virtual RMethod R__0__Kae
		{
			get
			{
				if(r_R__0__Kae == null)
				{
					r_R__0__Kae = new(this, "#Kae", 0);
					r_R__0__Kae.SetBelong(this.instance);
				}
				return r_R__0__Kae;
			}
		}

		/// <summary>
		/// Int32 #87r(TargetConfig, TargetConfig)
		/// </summary>
		protected static RMethod r_R__0__87r_TargetConfig_TargetConfig;
		public static RMethod R__0__87r_TargetConfig_TargetConfig
		{
			get
			{
				if(r_R__0__87r_TargetConfig_TargetConfig == null)
				{
					r_R__0__87r_TargetConfig_TargetConfig = new( ReleactionUtils.GetType("#u.#OSc"), "#87r", 0, typeof(TargetConfig), typeof(TargetConfig));
					r_R__0__87r_TargetConfig_TargetConfig.SetBelong(null);
				}
				return r_R__0__87r_TargetConfig_TargetConfig;
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


        public R__0__OSc() : base("#u.#OSc")
        {
        }

        public R__0__OSc(System.Object instance) : base("#u.#OSc")
		{
            SetInstance(instance);
		}

        public R__0__OSc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__OSc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__yjb(PhaseTargetConfigHold  @configs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configs};
            var ___result = R__0__yjb_PhaseTargetConfigHold.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Cjb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Cjb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__Njb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Njb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean __0__Ojb(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Ojb_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.List<System.Byte> __0__Pjb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Pjb.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.Byte>)___result;
        }


        public virtual System.Boolean __0__ind()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ind.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.List<TargetConfig> __0__Qjb(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Qjb_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<TargetConfig>)___result;
        }


        public virtual System.Object __0__Rjb(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Rjb_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__S1c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__S1c.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Sjb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Sjb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__Kae()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Kae.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 __0__87r(TargetConfig  @x, TargetConfig  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = R__0__87r_TargetConfig_TargetConfig.Invoke(___genericsType, ___parameters);

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
