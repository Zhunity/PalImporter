using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#ogd
	/// </summary>
    public partial class R__0__ogd : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,#u.#hgd] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__hgd> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__hgd> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[System.String,#u.#hgd] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__hgd> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__hgd> R__0__b
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
		/// System.Boolean #c
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
		/// System.Boolean #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
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
		/// System.Collections.Generic.List`1[System.String] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__e
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
		/// System.String[] #f
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
		/// Boolean IsReadyToUse
		/// </summary>
		protected RProperty r_IsReadyToUse;
		public virtual RProperty RIsReadyToUse
		{
			get
			{
				if(r_IsReadyToUse == null)
				{
					r_IsReadyToUse = new(this, "IsReadyToUse", -1);
					r_IsReadyToUse.SetBelong(this.instance);
				}
				return r_IsReadyToUse;
			}
		}

		/// <summary>
		/// Void OnLoadPlayerPropExpressionConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPlayerPropExpressionConfig_Object;
		public virtual RMethod ROnLoadPlayerPropExpressionConfig_Object
		{
			get
			{
				if(r_ROnLoadPlayerPropExpressionConfig_Object == null)
				{
					r_ROnLoadPlayerPropExpressionConfig_Object = new(this, "OnLoadPlayerPropExpressionConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPlayerPropExpressionConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPlayerPropExpressionConfig_Object;
			}
		}

		/// <summary>
		/// Void #igd(UnityEngine.Object, System.Collections.Generic.Dictionary`2[System.String,#u.#hgd] ByRef)
		/// </summary>
		protected RMethod r_R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_;
		public virtual RMethod R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_
		{
			get
			{
				if(r_R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_ == null)
				{
					r_R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_ = new(this, "#igd", 0, typeof(UnityEngine.Object), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#hgd")).MakeByRefType());
					r_R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_.SetBelong(this.instance);
				}
				return r_R__0__igd_Object_Ref_Dictionary_d_String___0__hgd_p_;
			}
		}

		/// <summary>
		/// System.String #jgd(#u.#Ieb, System.String)
		/// </summary>
		protected RMethod r_R__0__jgd___0__Ieb_String;
		public virtual RMethod R__0__jgd___0__Ieb_String
		{
			get
			{
				if(r_R__0__jgd___0__Ieb_String == null)
				{
					r_R__0__jgd___0__Ieb_String = new(this, "#jgd", 0,  ReleactionUtils.GetType("#u.#Ieb"), typeof(System.String));
					r_R__0__jgd___0__Ieb_String.SetBelong(this.instance);
				}
				return r_R__0__jgd___0__Ieb_String;
			}
		}

		/// <summary>
		/// System.String #Ohg(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__Ohg_ID_String;
		public virtual RMethod R__0__Ohg_ID_String
		{
			get
			{
				if(r_R__0__Ohg_ID_String == null)
				{
					r_R__0__Ohg_ID_String = new(this, "#Ohg", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__Ohg_ID_String.SetBelong(this.instance);
				}
				return r_R__0__Ohg_ID_String;
			}
		}

		/// <summary>
		/// System.String #08d(Fighter, System.String)
		/// </summary>
		protected RMethod r_R__0__08d_Fighter_String;
		public virtual RMethod R__0__08d_Fighter_String
		{
			get
			{
				if(r_R__0__08d_Fighter_String == null)
				{
					r_R__0__08d_Fighter_String = new(this, "#08d", 0,  ReleactionUtils.GetType("Fighter"), typeof(System.String));
					r_R__0__08d_Fighter_String.SetBelong(this.instance);
				}
				return r_R__0__08d_Fighter_String;
			}
		}

		/// <summary>
		/// System.String #jgd(#u.#Ckb, System.String)
		/// </summary>
		protected RMethod r_R__0__jgd___0__Ckb_String;
		public virtual RMethod R__0__jgd___0__Ckb_String
		{
			get
			{
				if(r_R__0__jgd___0__Ckb_String == null)
				{
					r_R__0__jgd___0__Ckb_String = new(this, "#jgd", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.String));
					r_R__0__jgd___0__Ckb_String.SetBelong(this.instance);
				}
				return r_R__0__jgd___0__Ckb_String;
			}
		}

		/// <summary>
		/// System.String #kgd(#u.#Ckb, System.String, System.Collections.Generic.Dictionary`2[System.String,#u.#hgd])
		/// </summary>
		protected RMethod r_R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_;
		public virtual RMethod R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_
		{
			get
			{
				if(r_R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_ == null)
				{
					r_R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_ = new(this, "#kgd", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.String), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#hgd")));
					r_R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_.SetBelong(this.instance);
				}
				return r_R__0__kgd___0__Ckb_String_Dictionary_d_String___0__hgd_p_;
			}
		}

		/// <summary>
		/// System.String #cVf(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__cVf_Int32_Int32;
		public virtual RMethod R__0__cVf_Int32_Int32
		{
			get
			{
				if(r_R__0__cVf_Int32_Int32 == null)
				{
					r_R__0__cVf_Int32_Int32 = new(this, "#cVf", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__cVf_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__cVf_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String #kgd(#u.#Ieb, System.String, System.Collections.Generic.Dictionary`2[System.String,#u.#hgd])
		/// </summary>
		protected RMethod r_R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_;
		public virtual RMethod R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_
		{
			get
			{
				if(r_R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_ == null)
				{
					r_R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_ = new(this, "#kgd", 0,  ReleactionUtils.GetType("#u.#Ieb"), typeof(System.String), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#hgd")));
					r_R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_.SetBelong(this.instance);
				}
				return r_R__0__kgd___0__Ieb_String_Dictionary_d_String___0__hgd_p_;
			}
		}

		/// <summary>
		/// Boolean #lgd(Creature, System.String)
		/// </summary>
		protected RMethod r_R__0__lgd_Creature_String;
		public virtual RMethod R__0__lgd_Creature_String
		{
			get
			{
				if(r_R__0__lgd_Creature_String == null)
				{
					r_R__0__lgd_Creature_String = new(this, "#lgd", 0,  ReleactionUtils.GetType("Creature"), typeof(System.String));
					r_R__0__lgd_Creature_String.SetBelong(this.instance);
				}
				return r_R__0__lgd_Creature_String;
			}
		}

		/// <summary>
		/// Boolean #mgd(System.String)
		/// </summary>
		protected RMethod r_R__0__mgd_String;
		public virtual RMethod R__0__mgd_String
		{
			get
			{
				if(r_R__0__mgd_String == null)
				{
					r_R__0__mgd_String = new(this, "#mgd", 0, typeof(System.String));
					r_R__0__mgd_String.SetBelong(this.instance);
				}
				return r_R__0__mgd_String;
			}
		}

		/// <summary>
		/// Void #ngd(System.String, #u.#hgd ByRef)
		/// </summary>
		protected RMethod r_R__0__ngd_String_Ref___0__hgd;
		public virtual RMethod R__0__ngd_String_Ref___0__hgd
		{
			get
			{
				if(r_R__0__ngd_String_Ref___0__hgd == null)
				{
					r_R__0__ngd_String_Ref___0__hgd = new(this, "#ngd", 0, typeof(System.String),  ReleactionUtils.GetType("#u.#hgd").MakeByRefType());
					r_R__0__ngd_String_Ref___0__hgd.SetBelong(this.instance);
				}
				return r_R__0__ngd_String_Ref___0__hgd;
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


        public R__0__ogd() : base("#u.#ogd")
        {
        }

        public R__0__ogd(System.Object instance) : base("#u.#ogd")
		{
            SetInstance(instance);
		}

        public R__0__ogd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__ogd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadPlayerPropExpressionConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadPlayerPropExpressionConfig_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.String __0__Ohg(GameDefineType.ID  @carrer, System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer, @propertyName};
            var ___result = R__0__Ohg_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual System.String __0__cVf(System.Int32  @matrixtype, System.Int32  @valtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixtype, @valtype};
            var ___result = R__0__cVf_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }




        public virtual System.Boolean __0__mgd(System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = R__0__mgd_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
