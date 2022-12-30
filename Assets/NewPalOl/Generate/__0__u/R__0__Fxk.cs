using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Fxk
	/// </summary>
    public partial class R__0__Fxk : RMember //
    {

		/// <summary>
		/// KeyValueContent #a
		/// </summary>
		protected RKeyValueContent r___0__a;
		public virtual RKeyValueContent R__0__a
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
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("#u.#Fxk"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UIeffect]] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect>> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect>> R__0__c
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
		/// Void OnLoadEquipGodConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadEquipGodConfig_Object;
		public virtual RMethod ROnLoadEquipGodConfig_Object
		{
			get
			{
				if(r_ROnLoadEquipGodConfig_Object == null)
				{
					r_ROnLoadEquipGodConfig_Object = new(this, "OnLoadEquipGodConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadEquipGodConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadEquipGodConfig_Object;
			}
		}

		/// <summary>
		/// System.String #Dxk(Int32)
		/// </summary>
		protected RMethod r_R__0__Dxk_Int32;
		public virtual RMethod R__0__Dxk_Int32
		{
			get
			{
				if(r_R__0__Dxk_Int32 == null)
				{
					r_R__0__Dxk_Int32 = new(this, "#Dxk", 0, typeof(System.Int32));
					r_R__0__Dxk_Int32.SetBelong(this.instance);
				}
				return r_R__0__Dxk_Int32;
			}
		}

		/// <summary>
		/// System.String #Exk(Int32, System.String)
		/// </summary>
		protected RMethod r_R__0__Exk_Int32_String;
		public virtual RMethod R__0__Exk_Int32_String
		{
			get
			{
				if(r_R__0__Exk_Int32_String == null)
				{
					r_R__0__Exk_Int32_String = new(this, "#Exk", 0, typeof(System.Int32), typeof(System.String));
					r_R__0__Exk_Int32_String.SetBelong(this.instance);
				}
				return r_R__0__Exk_Int32_String;
			}
		}

		/// <summary>
		/// Void #2Sk(System.String, MyGUI.ElementBase, #u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__2Sk_String_ElementBase___0__Ckb;
		public virtual RMethod R__0__2Sk_String_ElementBase___0__Ckb
		{
			get
			{
				if(r_R__0__2Sk_String_ElementBase___0__Ckb == null)
				{
					r_R__0__2Sk_String_ElementBase___0__Ckb = new(this, "#2Sk", 0, typeof(System.String), typeof(MyGUI.ElementBase),  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__2Sk_String_ElementBase___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__2Sk_String_ElementBase___0__Ckb;
			}
		}

		/// <summary>
		/// Void #3Sk(System.String)
		/// </summary>
		protected RMethod r_R__0__3Sk_String;
		public virtual RMethod R__0__3Sk_String
		{
			get
			{
				if(r_R__0__3Sk_String == null)
				{
					r_R__0__3Sk_String = new(this, "#3Sk", 0, typeof(System.String));
					r_R__0__3Sk_String.SetBelong(this.instance);
				}
				return r_R__0__3Sk_String;
			}
		}

		/// <summary>
		/// Void OnLoadUIeffect(System.String, System.String, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_ROnLoadUIeffect_String_String_ElementBase;
		public virtual RMethod ROnLoadUIeffect_String_String_ElementBase
		{
			get
			{
				if(r_ROnLoadUIeffect_String_String_ElementBase == null)
				{
					r_ROnLoadUIeffect_String_String_ElementBase = new(this, "OnLoadUIeffect", 0, typeof(System.String), typeof(System.String), typeof(MyGUI.ElementBase));
					r_ROnLoadUIeffect_String_String_ElementBase.SetBelong(this.instance);
				}
				return r_ROnLoadUIeffect_String_String_ElementBase;
			}
		}

		/// <summary>
		/// Void OnLoadObj(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadObj_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadObj_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadObj_Object_ABLoadedArgs == null)
				{
					r_ROnLoadObj_Object_ABLoadedArgs = new(this, "OnLoadObj", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadObj_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadObj_Object_ABLoadedArgs;
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


        public R__0__Fxk() : base("#u.#Fxk")
        {
        }

        public R__0__Fxk(System.Object instance) : base("#u.#Fxk")
		{
            SetInstance(instance);
		}

        public R__0__Fxk(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Fxk(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadEquipGodConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadEquipGodConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Dxk(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Dxk_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__Exk(System.Int32  @level, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level, @name};
            var ___result = R__0__Exk_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void __0__3Sk(System.String  @wndname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndname};
            var ___result = R__0__3Sk_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadUIeffect(System.String  @name, System.String  @wndname, MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @wndname, @eb};
            var ___result = ROnLoadUIeffect_String_String_ElementBase.Invoke(___genericsType, ___parameters);

            
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
