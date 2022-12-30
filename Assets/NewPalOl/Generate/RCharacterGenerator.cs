using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CharacterGenerator
	/// </summary>
    public partial class RCharacterGenerator : RMember //
    {

		/// <summary>
		/// System.Boolean #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("CharacterGenerator"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.String #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("CharacterGenerator"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// UnityEngine.WWW #c
		/// </summary>
		protected static RUnityEngine.RWWW r___0__c;
		public static RUnityEngine.RWWW R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("CharacterGenerator"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest #d
		/// </summary>
		protected static RUnityEngine.RAssetBundleCreateRequest r___0__d;
		public static RUnityEngine.RAssetBundleCreateRequest R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new( ReleactionUtils.GetType("CharacterGenerator"), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle #e
		/// </summary>
		protected static RUnityEngine.RAssetBundle r___0__e;
		public static RUnityEngine.RAssetBundle R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new( ReleactionUtils.GetType("CharacterGenerator"), "#e");
					r___0__e.SetBelong(null);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.String #f
		/// </summary>
		protected static RField r___0__f;
		public static RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new( ReleactionUtils.GetType("CharacterGenerator"), "#f");
					r___0__f.SetBelong(null);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[CharacterElement]]] #g
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RCharacterElement>>> r___0__g;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RCharacterElement>>> R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("CharacterGenerator"), "#g");
					r___0__g.SetBelong(null);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #h
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RField> r___0__h;
		public static RSystem.RCollections.RGeneric.RList<RField> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new( ReleactionUtils.GetType("CharacterGenerator"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.WWW] #i
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RWWW> r___0__i;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RWWW> R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new( ReleactionUtils.GetType("CharacterGenerator"), "#i");
					r___0__i.SetBelong(null);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Object] #j
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RObject> r___0__j;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RObject> R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new( ReleactionUtils.GetType("CharacterGenerator"), "#j");
					r___0__j.SetBelong(null);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// System.String #k
		/// </summary>
		protected RField r___0__k;
		public virtual RField R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new(this, "#k");
					r___0__k.SetBelong(this.instance);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest #l
		/// </summary>
		protected RUnityEngine.RAssetBundleCreateRequest r___0__l;
		public virtual RUnityEngine.RAssetBundleCreateRequest R__0__l
		{
			get
			{
				if(r___0__l == null)
				{
					r___0__l = new(this, "#l");
					r___0__l.SetBelong(this.instance);
				}
				return r___0__l;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle #m
		/// </summary>
		protected RUnityEngine.RAssetBundle r___0__m;
		public virtual RUnityEngine.RAssetBundle R__0__m
		{
			get
			{
				if(r___0__m == null)
				{
					r___0__m = new(this, "#m");
					r___0__m.SetBelong(this.instance);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,CharacterElement] #n
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RCharacterElement> r___0__n;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RCharacterElement> R__0__n
		{
			get
			{
				if(r___0__n == null)
				{
					r___0__n = new(this, "#n");
					r___0__n.SetBelong(this.instance);
				}
				return r___0__n;
			}
		}

		/// <summary>
		/// System.Single #o
		/// </summary>
		protected RField r___0__o;
		public virtual RField R__0__o
		{
			get
			{
				if(r___0__o == null)
				{
					r___0__o = new(this, "#o");
					r___0__o.SetBelong(this.instance);
				}
				return r___0__o;
			}
		}

		/// <summary>
		/// UnityEngine.Color[,] #p
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r___0__p;
		public virtual RFieldArray<RUnityEngine.RColor> R__0__p
		{
			get
			{
				if(r___0__p == null)
				{
					r___0__p = new(this, "#p");
					r___0__p.SetBelong(this.instance);
				}
				return r___0__p;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #q
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__q;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__q
		{
			get
			{
				if(r___0__q == null)
				{
					r___0__q = new(this, "#q");
					r___0__q.SetBelong(this.instance);
				}
				return r___0__q;
			}
		}

		/// <summary>
		/// System.String #r
		/// </summary>
		protected static RField r___0__r;
		public static RField R__0__r
		{
			get
			{
				if(r___0__r == null)
				{
					r___0__r = new( ReleactionUtils.GetType("CharacterGenerator"), "#r");
					r___0__r.SetBelong(null);
				}
				return r___0__r;
			}
		}

		/// <summary>
		/// System.String #s
		/// </summary>
		protected static RField r___0__s;
		public static RField R__0__s
		{
			get
			{
				if(r___0__s == null)
				{
					r___0__s = new( ReleactionUtils.GetType("CharacterGenerator"), "#s");
					r___0__s.SetBelong(null);
				}
				return r___0__s;
			}
		}

		/// <summary>
		/// Boolean ReadyToUse
		/// </summary>
		protected static RProperty r_R__0__h;
		public static RProperty R__0__h
		{
			get
			{
				if(r_R__0__h == null)
				{
					r_R__0__h = new( ReleactionUtils.GetType("CharacterGenerator"), "ReadyToUse", -1);
					r_R__0__h.SetBelong(null);
				}
				return r_R__0__h;
			}
		}

		/// <summary>
		/// Boolean AssetBundleReady
		/// </summary>
		protected static RProperty r_R__0__eod;
		public static RProperty R__0__eod
		{
			get
			{
				if(r_R__0__eod == null)
				{
					r_R__0__eod = new( ReleactionUtils.GetType("CharacterGenerator"), "AssetBundleReady", -1);
					r_R__0__eod.SetBelong(null);
				}
				return r_R__0__eod;
			}
		}

		/// <summary>
		/// Single CurrentConfigProgress
		/// </summary>
		protected RProperty r_R__0__i;
		public virtual RProperty R__0__i
		{
			get
			{
				if(r_R__0__i == null)
				{
					r_R__0__i = new(this, "CurrentConfigProgress", -1);
					r_R__0__i.SetBelong(this.instance);
				}
				return r_R__0__i;
			}
		}

		/// <summary>
		/// Boolean CharacterBaseReady
		/// </summary>
		protected RProperty r_R__0__hod;
		public virtual RProperty R__0__hod
		{
			get
			{
				if(r_R__0__hod == null)
				{
					r_R__0__hod = new(this, "CharacterBaseReady", -1);
					r_R__0__hod.SetBelong(this.instance);
				}
				return r_R__0__hod;
			}
		}

		/// <summary>
		/// Boolean ConfigReady
		/// </summary>
		protected RProperty r_R__0__j;
		public virtual RProperty R__0__j
		{
			get
			{
				if(r_R__0__j == null)
				{
					r_R__0__j = new(this, "ConfigReady", -1);
					r_R__0__j.SetBelong(this.instance);
				}
				return r_R__0__j;
			}
		}

		/// <summary>
		/// System.String AssetbundleBaseURL
		/// </summary>
		protected static RProperty r_R__0__p;
		public static RProperty R__0__p
		{
			get
			{
				if(r_R__0__p == null)
				{
					r_R__0__p = new( ReleactionUtils.GetType("CharacterGenerator"), "AssetbundleBaseURL", -1);
					r_R__0__p.SetBelong(null);
				}
				return r_R__0__p;
			}
		}

		/// <summary>
		/// UnityEngine.WWW CurrentCharacterBase
		/// </summary>
		protected RUnityEngine.RWWW r_R__0__r;
		public virtual RUnityEngine.RWWW R__0__r
		{
			get
			{
				if(r_R__0__r == null)
				{
					r_R__0__r = new(this, "CurrentCharacterBase", -1);
					r_R__0__r.SetBelong(this.instance);
				}
				return r_R__0__r;
			}
		}

		/// <summary>
		/// Void #b()
		/// </summary>
		protected static RMethod r_R__0__b;
		public static RMethod R__0__b
		{
			get
			{
				if(r_R__0__b == null)
				{
					r_R__0__b = new( ReleactionUtils.GetType("CharacterGenerator"), "#b", 0);
					r_R__0__b.SetBelong(null);
				}
				return r_R__0__b;
			}
		}

		/// <summary>
		/// Void #E7()
		/// </summary>
		protected RMethod r_R__0__E7;
		public virtual RMethod R__0__E7
		{
			get
			{
				if(r_R__0__E7 == null)
				{
					r_R__0__E7 = new(this, "#E7", 0);
					r_R__0__E7.SetBelong(this.instance);
				}
				return r_R__0__E7;
			}
		}

		/// <summary>
		/// Void OnApplicationQuit()
		/// </summary>
		protected static RMethod r_ROnApplicationQuit;
		public static RMethod ROnApplicationQuit
		{
			get
			{
				if(r_ROnApplicationQuit == null)
				{
					r_ROnApplicationQuit = new( ReleactionUtils.GetType("CharacterGenerator"), "OnApplicationQuit", 0);
					r_ROnApplicationQuit.SetBelong(null);
				}
				return r_ROnApplicationQuit;
			}
		}

		/// <summary>
		/// CharacterGenerator #c(System.String)
		/// </summary>
		protected static RMethod r_R__0__c_String;
		public static RMethod R__0__c_String
		{
			get
			{
				if(r_R__0__c_String == null)
				{
					r_R__0__c_String = new( ReleactionUtils.GetType("CharacterGenerator"), "#c", 0, typeof(System.String));
					r_R__0__c_String.SetBelong(null);
				}
				return r_R__0__c_String;
			}
		}

		/// <summary>
		/// Void #d(System.String)
		/// </summary>
		protected RMethod r_R__0__d_String;
		public virtual RMethod R__0__d_String
		{
			get
			{
				if(r_R__0__d_String == null)
				{
					r_R__0__d_String = new(this, "#d", 0, typeof(System.String));
					r_R__0__d_String.SetBelong(this.instance);
				}
				return r_R__0__d_String;
			}
		}

		/// <summary>
		/// System.String #e()
		/// </summary>
		protected RMethod r_R__0__e;
		public virtual RMethod R__0__e
		{
			get
			{
				if(r_R__0__e == null)
				{
					r_R__0__e = new(this, "#e", 0);
					r_R__0__e.SetBelong(this.instance);
				}
				return r_R__0__e;
			}
		}

		/// <summary>
		/// Void #f(System.String, Boolean)
		/// </summary>
		protected RMethod r_R__0__f_String_Boolean;
		public virtual RMethod R__0__f_String_Boolean
		{
			get
			{
				if(r_R__0__f_String_Boolean == null)
				{
					r_R__0__f_String_Boolean = new(this, "#f", 0, typeof(System.String), typeof(System.Boolean));
					r_R__0__f_String_Boolean.SetBelong(this.instance);
				}
				return r_R__0__f_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean #g(UnityEngine.WWW)
		/// </summary>
		protected static RMethod r_R__0__g_WWW;
		public static RMethod R__0__g_WWW
		{
			get
			{
				if(r_R__0__g_WWW == null)
				{
					r_R__0__g_WWW = new( ReleactionUtils.GetType("CharacterGenerator"), "#g", 0, typeof(UnityEngine.WWW));
					r_R__0__g_WWW.SetBelong(null);
				}
				return r_R__0__g_WWW;
			}
		}

		/// <summary>
		/// Void #fod()
		/// </summary>
		protected static RMethod r_R__0__fod;
		public static RMethod R__0__fod
		{
			get
			{
				if(r_R__0__fod == null)
				{
					r_R__0__fod = new( ReleactionUtils.GetType("CharacterGenerator"), "#fod", 0);
					r_R__0__fod.SetBelong(null);
				}
				return r_R__0__fod;
			}
		}

		/// <summary>
		/// Void #god()
		/// </summary>
		protected RMethod r_R__0__god;
		public virtual RMethod R__0__god
		{
			get
			{
				if(r_R__0__god == null)
				{
					r_R__0__god = new(this, "#god", 0);
					r_R__0__god.SetBelong(this.instance);
				}
				return r_R__0__god;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #k()
		/// </summary>
		protected RMethod r_R__0__k;
		public virtual RMethod R__0__k
		{
			get
			{
				if(r_R__0__k == null)
				{
					r_R__0__k = new(this, "#k", 0);
					r_R__0__k.SetBelong(this.instance);
				}
				return r_R__0__k;
			}
		}

		/// <summary>
		/// Void #l()
		/// </summary>
		protected RMethod r_R__0__l;
		public virtual RMethod R__0__l
		{
			get
			{
				if(r_R__0__l == null)
				{
					r_R__0__l = new(this, "#l", 0);
					r_R__0__l.SetBelong(this.instance);
				}
				return r_R__0__l;
			}
		}

		/// <summary>
		/// Void #m(UnityEngine.GameObject, UnityEngine.Color, UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_R__0__m_GameObject_Color_Color_Color;
		public static RMethod R__0__m_GameObject_Color_Color_Color
		{
			get
			{
				if(r_R__0__m_GameObject_Color_Color_Color == null)
				{
					r_R__0__m_GameObject_Color_Color_Color = new( ReleactionUtils.GetType("CharacterGenerator"), "#m", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_R__0__m_GameObject_Color_Color_Color.SetBelong(null);
				}
				return r_R__0__m_GameObject_Color_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #k(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__k_GameObject;
		public virtual RMethod R__0__k_GameObject
		{
			get
			{
				if(r_R__0__k_GameObject == null)
				{
					r_R__0__k_GameObject = new(this, "#k", 0, typeof(UnityEngine.GameObject));
					r_R__0__k_GameObject.SetBelong(this.instance);
				}
				return r_R__0__k_GameObject;
			}
		}

		/// <summary>
		/// Void #n(UnityEngine.Mesh)
		/// </summary>
		protected RMethod r_R__0__n_Mesh;
		public virtual RMethod R__0__n_Mesh
		{
			get
			{
				if(r_R__0__n_Mesh == null)
				{
					r_R__0__n_Mesh = new(this, "#n", 0, typeof(UnityEngine.Mesh));
					r_R__0__n_Mesh.SetBelong(this.instance);
				}
				return r_R__0__n_Mesh;
			}
		}

		/// <summary>
		/// Void #o()
		/// </summary>
		protected RMethod r_R__0__o;
		public virtual RMethod R__0__o
		{
			get
			{
				if(r_R__0__o == null)
				{
					r_R__0__o = new(this, "#o", 0);
					r_R__0__o.SetBelong(this.instance);
				}
				return r_R__0__o;
			}
		}

		/// <summary>
		/// Void #s(UnityEngine.GameObject, Single)
		/// </summary>
		protected static RMethod r_R__0__s_GameObject_Single;
		public static RMethod R__0__s_GameObject_Single
		{
			get
			{
				if(r_R__0__s_GameObject_Single == null)
				{
					r_R__0__s_GameObject_Single = new( ReleactionUtils.GetType("CharacterGenerator"), "#s", 0, typeof(UnityEngine.GameObject), typeof(System.Single));
					r_R__0__s_GameObject_Single.SetBelong(null);
				}
				return r_R__0__s_GameObject_Single;
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


        public RCharacterGenerator() : base("CharacterGenerator")
        {
        }

        public RCharacterGenerator(System.Object instance) : base("CharacterGenerator")
		{
            SetInstance(instance);
		}

        public RCharacterGenerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterGenerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void __0__b()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__b.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__E7()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__E7.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnApplicationQuit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnApplicationQuit.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object __0__c(System.String  @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config};
            var ___result = R__0__c_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__d(System.String  @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config};
            var ___result = R__0__d_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__e()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__e.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__f(System.String  @catagory, System.Boolean  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@catagory, @next};
            var ___result = R__0__f_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean __0__g(UnityEngine.WWW  @mWWW)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mWWW};
            var ___result = R__0__g_WWW.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void __0__fod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__fod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__god()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__god.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject __0__k()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__k.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void __0__l()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__l.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__m(UnityEngine.GameObject  @root, UnityEngine.Color  @mainColor, UnityEngine.Color  @SpecColor, UnityEngine.Color  @_Emission)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root, @mainColor, @SpecColor, @_Emission};
            var ___result = R__0__m_GameObject_Color_Color_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject __0__k(UnityEngine.GameObject  @root)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root};
            var ___result = R__0__k_GameObject.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void __0__n(UnityEngine.Mesh  @mMesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mMesh};
            var ___result = R__0__n_Mesh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__o()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__o.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__s(UnityEngine.GameObject  @root, System.Single  @alpha)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root, @alpha};
            var ___result = R__0__s_GameObject_Single.Invoke(___genericsType, ___parameters);

            
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
