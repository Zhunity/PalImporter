using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#qOi
	/// </summary>
    public partial class R__0__qOi : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,StrengthenConfig] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenConfig> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenConfig> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,StrengthenShowConfig] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenShowConfig> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenShowConfig> R__0__b
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
		/// Void #lOi(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__lOi_Object___0__Isb;
		public virtual RMethod R__0__lOi_Object___0__Isb
		{
			get
			{
				if(r_R__0__lOi_Object___0__Isb == null)
				{
					r_R__0__lOi_Object___0__Isb = new(this, "#lOi", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__lOi_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__lOi_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,StrengthenShowConfig] #mOi()
		/// </summary>
		protected RMethod r_R__0__mOi;
		public virtual RMethod R__0__mOi
		{
			get
			{
				if(r_R__0__mOi == null)
				{
					r_R__0__mOi = new(this, "#mOi", 0);
					r_R__0__mOi.SetBelong(this.instance);
				}
				return r_R__0__mOi;
			}
		}

		/// <summary>
		/// Void OnLoadStrengthenConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadStrengthenConfig_Object;
		public virtual RMethod ROnLoadStrengthenConfig_Object
		{
			get
			{
				if(r_ROnLoadStrengthenConfig_Object == null)
				{
					r_ROnLoadStrengthenConfig_Object = new(this, "OnLoadStrengthenConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadStrengthenConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadStrengthenConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadStrengthenShowConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadStrengthenShowConfig_Object;
		public virtual RMethod ROnLoadStrengthenShowConfig_Object
		{
			get
			{
				if(r_ROnLoadStrengthenShowConfig_Object == null)
				{
					r_ROnLoadStrengthenShowConfig_Object = new(this, "OnLoadStrengthenShowConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadStrengthenShowConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadStrengthenShowConfig_Object;
			}
		}

		/// <summary>
		/// StrengthenConfig #nOi(Int32)
		/// </summary>
		protected RMethod r_R__0__nOi_Int32;
		public virtual RMethod R__0__nOi_Int32
		{
			get
			{
				if(r_R__0__nOi_Int32 == null)
				{
					r_R__0__nOi_Int32 = new(this, "#nOi", 0, typeof(System.Int32));
					r_R__0__nOi_Int32.SetBelong(this.instance);
				}
				return r_R__0__nOi_Int32;
			}
		}

		/// <summary>
		/// Int32 #oOi(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__oOi_Int32_Int32;
		public virtual RMethod R__0__oOi_Int32_Int32
		{
			get
			{
				if(r_R__0__oOi_Int32_Int32 == null)
				{
					r_R__0__oOi_Int32_Int32 = new(this, "#oOi", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__oOi_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__oOi_Int32_Int32;
			}
		}

		/// <summary>
		/// StrengthenShowConfig #pOi(Int32)
		/// </summary>
		protected RMethod r_R__0__pOi_Int32;
		public virtual RMethod R__0__pOi_Int32
		{
			get
			{
				if(r_R__0__pOi_Int32 == null)
				{
					r_R__0__pOi_Int32 = new(this, "#pOi", 0, typeof(System.Int32));
					r_R__0__pOi_Int32.SetBelong(this.instance);
				}
				return r_R__0__pOi_Int32;
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


        public R__0__qOi() : base("#u.#qOi")
        {
        }

        public R__0__qOi(System.Object instance) : base("#u.#qOi")
		{
            SetInstance(instance);
		}

        public R__0__qOi(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__qOi(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, StrengthenShowConfig> __0__mOi()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__mOi.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, StrengthenShowConfig>)___result;
        }


        public virtual void OnLoadStrengthenConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadStrengthenConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadStrengthenShowConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadStrengthenShowConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual StrengthenConfig __0__nOi(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__nOi_Int32.Invoke(___genericsType, ___parameters);

            return (StrengthenConfig)___result;
        }


        public virtual System.Int32 __0__oOi(System.Int32  @id, System.Int32  @indx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @indx};
            var ___result = R__0__oOi_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual StrengthenShowConfig __0__pOi(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__pOi_Int32.Invoke(___genericsType, ___parameters);

            return (StrengthenShowConfig)___result;
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
