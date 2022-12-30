using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#FWc
	/// </summary>
    public partial class R__0__FWc : RMember //
    {

		/// <summary>
		/// stClintParam #a
		/// </summary>
		protected RstClintParam r___0__a;
		public virtual RstClintParam R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.List`1[GameDefineType.ID]] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> R__0__d
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Boolean] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__e
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
		/// System.String #f
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[System.String]] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> R__0__g
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
		/// stClintParam ClientParam
		/// </summary>
		protected RstClintParam r_R__0__EWc;
		public virtual RstClintParam R__0__EWc
		{
			get
			{
				if(r_R__0__EWc == null)
				{
					r_R__0__EWc = new(this, "ClientParam", -1);
					r_R__0__EWc.SetBelong(this.instance);
				}
				return r_R__0__EWc;
			}
		}

		/// <summary>
		/// Void OnLoadClientParamConfig(UnityEngine.TextAsset)
		/// </summary>
		protected RMethod r_ROnLoadClientParamConfig_TextAsset;
		public virtual RMethod ROnLoadClientParamConfig_TextAsset
		{
			get
			{
				if(r_ROnLoadClientParamConfig_TextAsset == null)
				{
					r_ROnLoadClientParamConfig_TextAsset = new(this, "OnLoadClientParamConfig", 0, typeof(UnityEngine.TextAsset));
					r_ROnLoadClientParamConfig_TextAsset.SetBelong(this.instance);
				}
				return r_ROnLoadClientParamConfig_TextAsset;
			}
		}

		/// <summary>
		/// Void #A0g(Int32)
		/// </summary>
		protected RMethod r_R__0__A0g_Int32;
		public virtual RMethod R__0__A0g_Int32
		{
			get
			{
				if(r_R__0__A0g_Int32 == null)
				{
					r_R__0__A0g_Int32 = new(this, "#A0g", 0, typeof(System.Int32));
					r_R__0__A0g_Int32.SetBelong(this.instance);
				}
				return r_R__0__A0g_Int32;
			}
		}

		/// <summary>
		/// Int32 #dei()
		/// </summary>
		protected RMethod r_R__0__dei;
		public virtual RMethod R__0__dei
		{
			get
			{
				if(r_R__0__dei == null)
				{
					r_R__0__dei = new(this, "#dei", 0);
					r_R__0__dei.SetBelong(this.instance);
				}
				return r_R__0__dei;
			}
		}

		/// <summary>
		/// Void OnLoadPlatFeatureConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPlatFeatureConfig_Object;
		public virtual RMethod ROnLoadPlatFeatureConfig_Object
		{
			get
			{
				if(r_ROnLoadPlatFeatureConfig_Object == null)
				{
					r_ROnLoadPlatFeatureConfig_Object = new(this, "OnLoadPlatFeatureConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPlatFeatureConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPlatFeatureConfig_Object;
			}
		}

		/// <summary>
		/// Boolean #AJg(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__AJg_ID;
		public virtual RMethod R__0__AJg_ID
		{
			get
			{
				if(r_R__0__AJg_ID == null)
				{
					r_R__0__AJg_ID = new(this, "#AJg", 0, typeof(GameDefineType.ID));
					r_R__0__AJg_ID.SetBelong(this.instance);
				}
				return r_R__0__AJg_ID;
			}
		}

		/// <summary>
		/// Void #yGg(System.String)
		/// </summary>
		protected RMethod r_R__0__yGg_String;
		public virtual RMethod R__0__yGg_String
		{
			get
			{
				if(r_R__0__yGg_String == null)
				{
					r_R__0__yGg_String = new(this, "#yGg", 0, typeof(System.String));
					r_R__0__yGg_String.SetBelong(this.instance);
				}
				return r_R__0__yGg_String;
			}
		}

		/// <summary>
		/// System.String #Ygg(System.String)
		/// </summary>
		protected RMethod r_R__0__Ygg_String;
		public virtual RMethod R__0__Ygg_String
		{
			get
			{
				if(r_R__0__Ygg_String == null)
				{
					r_R__0__Ygg_String = new(this, "#Ygg", 0, typeof(System.String));
					r_R__0__Ygg_String.SetBelong(this.instance);
				}
				return r_R__0__Ygg_String;
			}
		}

		/// <summary>
		/// Void #CJg(System.String)
		/// </summary>
		protected RMethod r_R__0__CJg_String;
		public virtual RMethod R__0__CJg_String
		{
			get
			{
				if(r_R__0__CJg_String == null)
				{
					r_R__0__CJg_String = new(this, "#CJg", 0, typeof(System.String));
					r_R__0__CJg_String.SetBelong(this.instance);
				}
				return r_R__0__CJg_String;
			}
		}

		/// <summary>
		/// System.String #C7q()
		/// </summary>
		protected RMethod r_R__0__C7q;
		public virtual RMethod R__0__C7q
		{
			get
			{
				if(r_R__0__C7q == null)
				{
					r_R__0__C7q = new(this, "#C7q", 0);
					r_R__0__C7q.SetBelong(this.instance);
				}
				return r_R__0__C7q;
			}
		}

		/// <summary>
		/// System.String #zGg()
		/// </summary>
		protected RMethod r_R__0__zGg;
		public virtual RMethod R__0__zGg
		{
			get
			{
				if(r_R__0__zGg == null)
				{
					r_R__0__zGg = new(this, "#zGg", 0);
					r_R__0__zGg.SetBelong(this.instance);
				}
				return r_R__0__zGg;
			}
		}

		/// <summary>
		/// System.String #PKh()
		/// </summary>
		protected RMethod r_R__0__PKh;
		public virtual RMethod R__0__PKh
		{
			get
			{
				if(r_R__0__PKh == null)
				{
					r_R__0__PKh = new(this, "#PKh", 0);
					r_R__0__PKh.SetBelong(this.instance);
				}
				return r_R__0__PKh;
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
		/// Void #Zgg(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__Zgg_Object_ABLoadedArgs;
		public virtual RMethod R__0__Zgg_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__Zgg_Object_ABLoadedArgs == null)
				{
					r_R__0__Zgg_Object_ABLoadedArgs = new(this, "#Zgg", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__Zgg_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__Zgg_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadServerNameConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadServerNameConfig_Object;
		public virtual RMethod ROnLoadServerNameConfig_Object
		{
			get
			{
				if(r_ROnLoadServerNameConfig_Object == null)
				{
					r_ROnLoadServerNameConfig_Object = new(this, "OnLoadServerNameConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadServerNameConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadServerNameConfig_Object;
			}
		}

		/// <summary>
		/// System.String #abi(Int32)
		/// </summary>
		protected RMethod r_R__0__abi_Int32;
		public virtual RMethod R__0__abi_Int32
		{
			get
			{
				if(r_R__0__abi_Int32 == null)
				{
					r_R__0__abi_Int32 = new(this, "#abi", 0, typeof(System.Int32));
					r_R__0__abi_Int32.SetBelong(this.instance);
				}
				return r_R__0__abi_Int32;
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


        public R__0__FWc() : base("#u.#FWc")
        {
        }

        public R__0__FWc(System.Object instance) : base("#u.#FWc")
		{
            SetInstance(instance);
		}

        public R__0__FWc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__FWc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadClientParamConfig(UnityEngine.TextAsset  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadClientParamConfig_TextAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__A0g(System.Int32  @platform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@platform};
            var ___result = R__0__A0g_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__dei()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__dei.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnLoadPlatFeatureConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadPlatFeatureConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__AJg(GameDefineType.ID  @idFeature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFeature};
            var ___result = R__0__AJg_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__yGg(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = R__0__yGg_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Ygg(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__Ygg_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__CJg(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = R__0__CJg_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__C7q()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__C7q.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__zGg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__zGg.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__PKh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__PKh.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnLoadServerNameConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadServerNameConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__abi(System.Int32  @serverid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serverid};
            var ___result = R__0__abi_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
