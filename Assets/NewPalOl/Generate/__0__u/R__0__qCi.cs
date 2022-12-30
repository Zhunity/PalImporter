using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#qCi
	/// </summary>
    public partial class R__0__qCi : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,FundConfig] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RFundConfig> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RFundConfig> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,#Pfb.#2Ci] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__Pfb.R__0__2Ci> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__Pfb.R__0__2Ci> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,FundShopConfig] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RFundShopConfig> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RFundShopConfig> R__0__c
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
		/// System.Collections.Generic.List`1[System.Int32] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__d
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
		/// System.Collections.Generic.List`1[#Pfb.#9Dm] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9Dm> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9Dm> R__0__e
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
		/// System.Int32 #f
		/// </summary>
		protected RField r___0__f;
		public virtual RField R__0__f
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
		/// System.Single #g
		/// </summary>
		protected RField r___0__g;
		public virtual RField R__0__g
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
		/// System.Int32 #h
		/// </summary>
		protected RField r___0__h;
		public virtual RField R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new(this, "#h");
					r___0__h.SetBelong(this.instance);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Boolean #i
		/// </summary>
		protected RField r___0__i;
		public virtual RField R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new(this, "#i");
					r___0__i.SetBelong(this.instance);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// Boolean IsFundOpen
		/// </summary>
		protected RProperty r_R__0__mEo;
		public virtual RProperty R__0__mEo
		{
			get
			{
				if(r_R__0__mEo == null)
				{
					r_R__0__mEo = new(this, "IsFundOpen", -1);
					r_R__0__mEo.SetBelong(this.instance);
				}
				return r_R__0__mEo;
			}
		}

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void OnLoadFundConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadFundConfig_Object;
		public virtual RMethod ROnLoadFundConfig_Object
		{
			get
			{
				if(r_ROnLoadFundConfig_Object == null)
				{
					r_ROnLoadFundConfig_Object = new(this, "OnLoadFundConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadFundConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadFundConfig_Object;
			}
		}

		/// <summary>
		/// FundConfig #iCi(Int32)
		/// </summary>
		protected RMethod r_R__0__iCi_Int32;
		public virtual RMethod R__0__iCi_Int32
		{
			get
			{
				if(r_R__0__iCi_Int32 == null)
				{
					r_R__0__iCi_Int32 = new(this, "#iCi", 0, typeof(System.Int32));
					r_R__0__iCi_Int32.SetBelong(this.instance);
				}
				return r_R__0__iCi_Int32;
			}
		}

		/// <summary>
		/// Int32 #jCi(FundConfig, Int32)
		/// </summary>
		protected RMethod r_R__0__jCi_FundConfig_Int32;
		public virtual RMethod R__0__jCi_FundConfig_Int32
		{
			get
			{
				if(r_R__0__jCi_FundConfig_Int32 == null)
				{
					r_R__0__jCi_FundConfig_Int32 = new(this, "#jCi", 0, typeof(FundConfig), typeof(System.Int32));
					r_R__0__jCi_FundConfig_Int32.SetBelong(this.instance);
				}
				return r_R__0__jCi_FundConfig_Int32;
			}
		}

		/// <summary>
		/// Void #kCi(Int32, #Pfb.#2Ci)
		/// </summary>
		protected RMethod r_R__0__kCi_Int32___0__2Ci;
		public virtual RMethod R__0__kCi_Int32___0__2Ci
		{
			get
			{
				if(r_R__0__kCi_Int32___0__2Ci == null)
				{
					r_R__0__kCi_Int32___0__2Ci = new(this, "#kCi", 0, typeof(System.Int32),  ReleactionUtils.GetType("#Pfb.#2Ci"));
					r_R__0__kCi_Int32___0__2Ci.SetBelong(this.instance);
				}
				return r_R__0__kCi_Int32___0__2Ci;
			}
		}

		/// <summary>
		/// #Pfb.#2Ci #lCi(Int32)
		/// </summary>
		protected RMethod r_R__0__lCi_Int32;
		public virtual RMethod R__0__lCi_Int32
		{
			get
			{
				if(r_R__0__lCi_Int32 == null)
				{
					r_R__0__lCi_Int32 = new(this, "#lCi", 0, typeof(System.Int32));
					r_R__0__lCi_Int32.SetBelong(this.instance);
				}
				return r_R__0__lCi_Int32;
			}
		}

		/// <summary>
		/// Void #mCi(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__mCi_Object___0__Isb;
		public virtual RMethod R__0__mCi_Object___0__Isb
		{
			get
			{
				if(r_R__0__mCi_Object___0__Isb == null)
				{
					r_R__0__mCi_Object___0__Isb = new(this, "#mCi", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__mCi_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__mCi_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #nCi()
		/// </summary>
		protected RMethod r_R__0__nCi;
		public virtual RMethod R__0__nCi
		{
			get
			{
				if(r_R__0__nCi == null)
				{
					r_R__0__nCi = new(this, "#nCi", 0);
					r_R__0__nCi.SetBelong(this.instance);
				}
				return r_R__0__nCi;
			}
		}

		/// <summary>
		/// Void #oCi(Int32)
		/// </summary>
		protected RMethod r_R__0__oCi_Int32;
		public virtual RMethod R__0__oCi_Int32
		{
			get
			{
				if(r_R__0__oCi_Int32 == null)
				{
					r_R__0__oCi_Int32 = new(this, "#oCi", 0, typeof(System.Int32));
					r_R__0__oCi_Int32.SetBelong(this.instance);
				}
				return r_R__0__oCi_Int32;
			}
		}

		/// <summary>
		/// Void #pCi(Int32)
		/// </summary>
		protected RMethod r_R__0__pCi_Int32;
		public virtual RMethod R__0__pCi_Int32
		{
			get
			{
				if(r_R__0__pCi_Int32 == null)
				{
					r_R__0__pCi_Int32 = new(this, "#pCi", 0, typeof(System.Int32));
					r_R__0__pCi_Int32.SetBelong(this.instance);
				}
				return r_R__0__pCi_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadFundShopConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadFundShopConfig_Object;
		public virtual RMethod ROnLoadFundShopConfig_Object
		{
			get
			{
				if(r_ROnLoadFundShopConfig_Object == null)
				{
					r_ROnLoadFundShopConfig_Object = new(this, "OnLoadFundShopConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadFundShopConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadFundShopConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] #mDm()
		/// </summary>
		protected RMethod r_R__0__mDm;
		public virtual RMethod R__0__mDm
		{
			get
			{
				if(r_R__0__mDm == null)
				{
					r_R__0__mDm = new(this, "#mDm", 0);
					r_R__0__mDm.SetBelong(this.instance);
				}
				return r_R__0__mDm;
			}
		}

		/// <summary>
		/// FundShopConfig #nDm(Int32)
		/// </summary>
		protected RMethod r_R__0__nDm_Int32;
		public virtual RMethod R__0__nDm_Int32
		{
			get
			{
				if(r_R__0__nDm_Int32 == null)
				{
					r_R__0__nDm_Int32 = new(this, "#nDm", 0, typeof(System.Int32));
					r_R__0__nDm_Int32.SetBelong(this.instance);
				}
				return r_R__0__nDm_Int32;
			}
		}

		/// <summary>
		/// Void #oDm(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__oDm_Object___0__Isb;
		public virtual RMethod R__0__oDm_Object___0__Isb
		{
			get
			{
				if(r_R__0__oDm_Object___0__Isb == null)
				{
					r_R__0__oDm_Object___0__Isb = new(this, "#oDm", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__oDm_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__oDm_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#Pfb.#9Dm] #pDm()
		/// </summary>
		protected RMethod r_R__0__pDm;
		public virtual RMethod R__0__pDm
		{
			get
			{
				if(r_R__0__pDm == null)
				{
					r_R__0__pDm = new(this, "#pDm", 0);
					r_R__0__pDm.SetBelong(this.instance);
				}
				return r_R__0__pDm;
			}
		}

		/// <summary>
		/// #Pfb.#9Dm #qDm(Int32)
		/// </summary>
		protected RMethod r_R__0__qDm_Int32;
		public virtual RMethod R__0__qDm_Int32
		{
			get
			{
				if(r_R__0__qDm_Int32 == null)
				{
					r_R__0__qDm_Int32 = new(this, "#qDm", 0, typeof(System.Int32));
					r_R__0__qDm_Int32.SetBelong(this.instance);
				}
				return r_R__0__qDm_Int32;
			}
		}

		/// <summary>
		/// Void #rDm(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__rDm_Object___0__Isb;
		public virtual RMethod R__0__rDm_Object___0__Isb
		{
			get
			{
				if(r_R__0__rDm_Object___0__Isb == null)
				{
					r_R__0__rDm_Object___0__Isb = new(this, "#rDm", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__rDm_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__rDm_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #sDm(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__sDm_Object___0__Isb;
		public virtual RMethod R__0__sDm_Object___0__Isb
		{
			get
			{
				if(r_R__0__sDm_Object___0__Isb == null)
				{
					r_R__0__sDm_Object___0__Isb = new(this, "#sDm", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__sDm_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__sDm_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #tDm(Int32)
		/// </summary>
		protected RMethod r_R__0__tDm_Int32;
		public virtual RMethod R__0__tDm_Int32
		{
			get
			{
				if(r_R__0__tDm_Int32 == null)
				{
					r_R__0__tDm_Int32 = new(this, "#tDm", 0, typeof(System.Int32));
					r_R__0__tDm_Int32.SetBelong(this.instance);
				}
				return r_R__0__tDm_Int32;
			}
		}

		/// <summary>
		/// Void #uDm()
		/// </summary>
		protected RMethod r_R__0__uDm;
		public virtual RMethod R__0__uDm
		{
			get
			{
				if(r_R__0__uDm == null)
				{
					r_R__0__uDm = new(this, "#uDm", 0);
					r_R__0__uDm.SetBelong(this.instance);
				}
				return r_R__0__uDm;
			}
		}

		/// <summary>
		/// Int32 #vDm()
		/// </summary>
		protected RMethod r_R__0__vDm;
		public virtual RMethod R__0__vDm
		{
			get
			{
				if(r_R__0__vDm == null)
				{
					r_R__0__vDm = new(this, "#vDm", 0);
					r_R__0__vDm.SetBelong(this.instance);
				}
				return r_R__0__vDm;
			}
		}

		/// <summary>
		/// Int32 #wDm()
		/// </summary>
		protected RMethod r_R__0__wDm;
		public virtual RMethod R__0__wDm
		{
			get
			{
				if(r_R__0__wDm == null)
				{
					r_R__0__wDm = new(this, "#wDm", 0);
					r_R__0__wDm.SetBelong(this.instance);
				}
				return r_R__0__wDm;
			}
		}

		/// <summary>
		/// Void #nEo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__nEo_Object___0__Isb;
		public virtual RMethod R__0__nEo_Object___0__Isb
		{
			get
			{
				if(r_R__0__nEo_Object___0__Isb == null)
				{
					r_R__0__nEo_Object___0__Isb = new(this, "#nEo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__nEo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__nEo_Object___0__Isb;
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


        public R__0__qCi() : base("#u.#qCi")
        {
        }

        public R__0__qCi(System.Object instance) : base("#u.#qCi")
		{
            SetInstance(instance);
		}

        public R__0__qCi(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__qCi(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadFundConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadFundConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual FundConfig __0__iCi(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__iCi_Int32.Invoke(___genericsType, ___parameters);

            return (FundConfig)___result;
        }


        public virtual System.Int32 __0__jCi(FundConfig  @data, System.Int32  @day)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @day};
            var ___result = R__0__jCi_FundConfig_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Object __0__lCi(System.Int32  @fundid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fundid};
            var ___result = R__0__lCi_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__nCi()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nCi.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__oCi(System.Int32  @fundid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fundid};
            var ___result = R__0__oCi_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__pCi(System.Int32  @fundid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fundid};
            var ___result = R__0__pCi_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadFundShopConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadFundShopConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.Int32> __0__mDm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__mDm.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.Int32>)___result;
        }


        public virtual FundShopConfig __0__nDm(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__nDm_Int32.Invoke(___genericsType, ___parameters);

            return (FundShopConfig)___result;
        }



        public virtual System.Object __0__pDm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__pDm.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__qDm(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__qDm_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void __0__tDm(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__tDm_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__uDm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__uDm.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__vDm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__vDm.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__wDm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wDm.Invoke(___genericsType, ___parameters);

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
