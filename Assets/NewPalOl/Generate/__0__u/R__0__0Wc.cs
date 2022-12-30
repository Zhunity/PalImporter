using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#0Wc
	/// </summary>
    public partial class R__0__0Wc : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,ILLUSTRATION_INFO] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RILLUSTRATION_INFO> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RILLUSTRATION_INFO> R__0__a
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
		/// System.Collections.Generic.List`1[System.String] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__b
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
		/// System.Collections.Generic.List`1[System.String] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__c
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
		/// KeyValueContent #d
		/// </summary>
		protected RKeyValueContent r___0__d;
		public virtual RKeyValueContent R__0__d
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
		/// KeyValueContent #e
		/// </summary>
		protected RKeyValueContent r___0__e;
		public virtual RKeyValueContent R__0__e
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
		/// System.Boolean #g
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #h
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__h;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new( ReleactionUtils.GetType("#u.#0Wc"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #i
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__i;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new( ReleactionUtils.GetType("#u.#0Wc"), "#i");
					r___0__i.SetBelong(null);
				}
				return r___0__i;
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
		/// Void OnLoadIllustrationsConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadIllustrationsConfig_Object;
		public virtual RMethod ROnLoadIllustrationsConfig_Object
		{
			get
			{
				if(r_ROnLoadIllustrationsConfig_Object == null)
				{
					r_ROnLoadIllustrationsConfig_Object = new(this, "OnLoadIllustrationsConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadIllustrationsConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadIllustrationsConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadHandbookReelConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadHandbookReelConfig_Object;
		public virtual RMethod ROnLoadHandbookReelConfig_Object
		{
			get
			{
				if(r_ROnLoadHandbookReelConfig_Object == null)
				{
					r_ROnLoadHandbookReelConfig_Object = new(this, "OnLoadHandbookReelConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadHandbookReelConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadHandbookReelConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadPetChallengeTimesConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPetChallengeTimesConfig_Object;
		public virtual RMethod ROnLoadPetChallengeTimesConfig_Object
		{
			get
			{
				if(r_ROnLoadPetChallengeTimesConfig_Object == null)
				{
					r_ROnLoadPetChallengeTimesConfig_Object = new(this, "OnLoadPetChallengeTimesConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPetChallengeTimesConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPetChallengeTimesConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,ILLUSTRATION_INFO] #GWc()
		/// </summary>
		protected RMethod r_R__0__GWc;
		public virtual RMethod R__0__GWc
		{
			get
			{
				if(r_R__0__GWc == null)
				{
					r_R__0__GWc = new(this, "#GWc", 0);
					r_R__0__GWc.SetBelong(this.instance);
				}
				return r_R__0__GWc;
			}
		}

		/// <summary>
		/// ILLUSTRATION_INFO #HWc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__HWc_ID;
		public virtual RMethod R__0__HWc_ID
		{
			get
			{
				if(r_R__0__HWc_ID == null)
				{
					r_R__0__HWc_ID = new(this, "#HWc", 0, typeof(GameDefineType.ID));
					r_R__0__HWc_ID.SetBelong(this.instance);
				}
				return r_R__0__HWc_ID;
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
		/// Void #IWc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__IWc_Object___0__Isb;
		public virtual RMethod R__0__IWc_Object___0__Isb
		{
			get
			{
				if(r_R__0__IWc_Object___0__Isb == null)
				{
					r_R__0__IWc_Object___0__Isb = new(this, "#IWc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__IWc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__IWc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #JWc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__JWc_Object___0__Isb;
		public virtual RMethod R__0__JWc_Object___0__Isb
		{
			get
			{
				if(r_R__0__JWc_Object___0__Isb == null)
				{
					r_R__0__JWc_Object___0__Isb = new(this, "#JWc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__JWc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__JWc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #KWc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__KWc_Object___0__Isb;
		public virtual RMethod R__0__KWc_Object___0__Isb
		{
			get
			{
				if(r_R__0__KWc_Object___0__Isb == null)
				{
					r_R__0__KWc_Object___0__Isb = new(this, "#KWc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__KWc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__KWc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #LWc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__LWc_Object___0__Isb;
		public virtual RMethod R__0__LWc_Object___0__Isb
		{
			get
			{
				if(r_R__0__LWc_Object___0__Isb == null)
				{
					r_R__0__LWc_Object___0__Isb = new(this, "#LWc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__LWc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__LWc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Ukf(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Ukf_Object___0__Isb;
		public virtual RMethod R__0__Ukf_Object___0__Isb
		{
			get
			{
				if(r_R__0__Ukf_Object___0__Isb == null)
				{
					r_R__0__Ukf_Object___0__Isb = new(this, "#Ukf", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Ukf_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Ukf_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 #UKf()
		/// </summary>
		protected RMethod r_R__0__UKf;
		public virtual RMethod R__0__UKf
		{
			get
			{
				if(r_R__0__UKf == null)
				{
					r_R__0__UKf = new(this, "#UKf", 0);
					r_R__0__UKf.SetBelong(this.instance);
				}
				return r_R__0__UKf;
			}
		}

		/// <summary>
		/// Void #TKf(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__TKf_Object___0__Isb;
		public virtual RMethod R__0__TKf_Object___0__Isb
		{
			get
			{
				if(r_R__0__TKf_Object___0__Isb == null)
				{
					r_R__0__TKf_Object___0__Isb = new(this, "#TKf", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__TKf_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__TKf_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #OWc()
		/// </summary>
		protected RMethod r_R__0__OWc;
		public virtual RMethod R__0__OWc
		{
			get
			{
				if(r_R__0__OWc == null)
				{
					r_R__0__OWc = new(this, "#OWc", 0);
					r_R__0__OWc.SetBelong(this.instance);
				}
				return r_R__0__OWc;
			}
		}

		/// <summary>
		/// Void #PWc(ILLUSTRATION_INFO)
		/// </summary>
		protected RMethod r_R__0__PWc_ILLUSTRATION_INFO;
		public virtual RMethod R__0__PWc_ILLUSTRATION_INFO
		{
			get
			{
				if(r_R__0__PWc_ILLUSTRATION_INFO == null)
				{
					r_R__0__PWc_ILLUSTRATION_INFO = new(this, "#PWc", 0, typeof(ILLUSTRATION_INFO));
					r_R__0__PWc_ILLUSTRATION_INFO.SetBelong(this.instance);
				}
				return r_R__0__PWc_ILLUSTRATION_INFO;
			}
		}

		/// <summary>
		/// Void #QWc()
		/// </summary>
		protected RMethod r_R__0__QWc;
		public virtual RMethod R__0__QWc
		{
			get
			{
				if(r_R__0__QWc == null)
				{
					r_R__0__QWc = new(this, "#QWc", 0);
					r_R__0__QWc.SetBelong(this.instance);
				}
				return r_R__0__QWc;
			}
		}

		/// <summary>
		/// GameDefineType.ID #28d(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__28d_ID;
		public virtual RMethod R__0__28d_ID
		{
			get
			{
				if(r_R__0__28d_ID == null)
				{
					r_R__0__28d_ID = new(this, "#28d", 0, typeof(GameDefineType.ID));
					r_R__0__28d_ID.SetBelong(this.instance);
				}
				return r_R__0__28d_ID;
			}
		}

		/// <summary>
		/// Boolean #SWc(ILLUSTRATION_INFO)
		/// </summary>
		protected RMethod r_R__0__SWc_ILLUSTRATION_INFO;
		public virtual RMethod R__0__SWc_ILLUSTRATION_INFO
		{
			get
			{
				if(r_R__0__SWc_ILLUSTRATION_INFO == null)
				{
					r_R__0__SWc_ILLUSTRATION_INFO = new(this, "#SWc", 0, typeof(ILLUSTRATION_INFO));
					r_R__0__SWc_ILLUSTRATION_INFO.SetBelong(this.instance);
				}
				return r_R__0__SWc_ILLUSTRATION_INFO;
			}
		}

		/// <summary>
		/// Boolean #TWc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__TWc_ID;
		public virtual RMethod R__0__TWc_ID
		{
			get
			{
				if(r_R__0__TWc_ID == null)
				{
					r_R__0__TWc_ID = new(this, "#TWc", 0, typeof(GameDefineType.ID));
					r_R__0__TWc_ID.SetBelong(this.instance);
				}
				return r_R__0__TWc_ID;
			}
		}

		/// <summary>
		/// Void #UWc()
		/// </summary>
		protected RMethod r_R__0__UWc;
		public virtual RMethod R__0__UWc
		{
			get
			{
				if(r_R__0__UWc == null)
				{
					r_R__0__UWc = new(this, "#UWc", 0);
					r_R__0__UWc.SetBelong(this.instance);
				}
				return r_R__0__UWc;
			}
		}

		/// <summary>
		/// Void #Obu(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Obu_ID;
		public virtual RMethod R__0__Obu_ID
		{
			get
			{
				if(r_R__0__Obu_ID == null)
				{
					r_R__0__Obu_ID = new(this, "#Obu", 0, typeof(GameDefineType.ID));
					r_R__0__Obu_ID.SetBelong(this.instance);
				}
				return r_R__0__Obu_ID;
			}
		}

		/// <summary>
		/// Void #VWc(GameDefineType.ID, GameDefineType.ID, Boolean)
		/// </summary>
		protected RMethod r_R__0__VWc_ID_ID_Boolean;
		public virtual RMethod R__0__VWc_ID_ID_Boolean
		{
			get
			{
				if(r_R__0__VWc_ID_ID_Boolean == null)
				{
					r_R__0__VWc_ID_ID_Boolean = new(this, "#VWc", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Boolean));
					r_R__0__VWc_ID_ID_Boolean.SetBelong(this.instance);
				}
				return r_R__0__VWc_ID_ID_Boolean;
			}
		}

		/// <summary>
		/// Void #WWc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__WWc_ID;
		public virtual RMethod R__0__WWc_ID
		{
			get
			{
				if(r_R__0__WWc_ID == null)
				{
					r_R__0__WWc_ID = new(this, "#WWc", 0, typeof(GameDefineType.ID));
					r_R__0__WWc_ID.SetBelong(this.instance);
				}
				return r_R__0__WWc_ID;
			}
		}

		/// <summary>
		/// Void #XWc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__XWc_ID;
		public virtual RMethod R__0__XWc_ID
		{
			get
			{
				if(r_R__0__XWc_ID == null)
				{
					r_R__0__XWc_ID = new(this, "#XWc", 0, typeof(GameDefineType.ID));
					r_R__0__XWc_ID.SetBelong(this.instance);
				}
				return r_R__0__XWc_ID;
			}
		}

		/// <summary>
		/// Void #YWc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__YWc_ID;
		public virtual RMethod R__0__YWc_ID
		{
			get
			{
				if(r_R__0__YWc_ID == null)
				{
					r_R__0__YWc_ID = new(this, "#YWc", 0, typeof(GameDefineType.ID));
					r_R__0__YWc_ID.SetBelong(this.instance);
				}
				return r_R__0__YWc_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.List`1[System.String]] #ZWc()
		/// </summary>
		protected RMethod r_R__0__ZWc;
		public virtual RMethod R__0__ZWc
		{
			get
			{
				if(r_R__0__ZWc == null)
				{
					r_R__0__ZWc = new(this, "#ZWc", 0);
					r_R__0__ZWc.SetBelong(this.instance);
				}
				return r_R__0__ZWc;
			}
		}

		/// <summary>
		/// Int32 GetPropertyValue(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetPropertyValue_ID_String;
		public virtual RMethod RGetPropertyValue_ID_String
		{
			get
			{
				if(r_RGetPropertyValue_ID_String == null)
				{
					r_RGetPropertyValue_ID_String = new(this, "GetPropertyValue", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetPropertyValue_ID_String.SetBelong(this.instance);
				}
				return r_RGetPropertyValue_ID_String;
			}
		}

		/// <summary>
		/// Int32 GetPropertyValue(Pet, System.String)
		/// </summary>
		protected static RMethod r_RGetPropertyValue_Pet_String;
		public static RMethod RGetPropertyValue_Pet_String
		{
			get
			{
				if(r_RGetPropertyValue_Pet_String == null)
				{
					r_RGetPropertyValue_Pet_String = new( ReleactionUtils.GetType("#u.#0Wc"), "GetPropertyValue", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String));
					r_RGetPropertyValue_Pet_String.SetBelong(null);
				}
				return r_RGetPropertyValue_Pet_String;
			}
		}

		/// <summary>
		/// Int32 #etd(GameDefineType.ID, Int32, System.String, Single)
		/// </summary>
		protected RMethod r_R__0__etd_ID_Int32_String_Single;
		public virtual RMethod R__0__etd_ID_Int32_String_Single
		{
			get
			{
				if(r_R__0__etd_ID_Int32_String_Single == null)
				{
					r_R__0__etd_ID_Int32_String_Single = new(this, "#etd", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.String), typeof(System.Single));
					r_R__0__etd_ID_Int32_String_Single.SetBelong(this.instance);
				}
				return r_R__0__etd_ID_Int32_String_Single;
			}
		}

		/// <summary>
		/// Int32 #bLd(Pet, System.String, Int32)
		/// </summary>
		protected static RMethod r_R__0__bLd_Pet_String_Int32;
		public static RMethod R__0__bLd_Pet_String_Int32
		{
			get
			{
				if(r_R__0__bLd_Pet_String_Int32 == null)
				{
					r_R__0__bLd_Pet_String_Int32 = new( ReleactionUtils.GetType("#u.#0Wc"), "#bLd", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String), typeof(System.Int32));
					r_R__0__bLd_Pet_String_Int32.SetBelong(null);
				}
				return r_R__0__bLd_Pet_String_Int32;
			}
		}

		/// <summary>
		/// Single #38d(System.String)
		/// </summary>
		protected RMethod r_R__0__38d_String;
		public virtual RMethod R__0__38d_String
		{
			get
			{
				if(r_R__0__38d_String == null)
				{
					r_R__0__38d_String = new(this, "#38d", 0, typeof(System.String));
					r_R__0__38d_String.SetBelong(this.instance);
				}
				return r_R__0__38d_String;
			}
		}

		/// <summary>
		/// Void #48d(Int32, GameDefineType.ID, System.String, Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32 = new(this, "#48d", 0, typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.String), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void #58d(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32 = new(this, "#58d", 0, typeof(System.Int32), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 #68d(Int32, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__68d_Int32_ID_String;
		public virtual RMethod R__0__68d_Int32_ID_String
		{
			get
			{
				if(r_R__0__68d_Int32_ID_String == null)
				{
					r_R__0__68d_Int32_ID_String = new(this, "#68d", 0, typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__68d_Int32_ID_String.SetBelong(this.instance);
				}
				return r_R__0__68d_Int32_ID_String;
			}
		}

		/// <summary>
		/// Void #48d(Pet, System.String, Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32 = new(this, "#48d", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_R__0__48d_Pet_String_Out_Int32_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void #48d(GameDefineType.ID, System.String, Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32;
		public virtual RMethod R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32 == null)
				{
					r_R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32 = new(this, "#48d", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Single #78d(Pet, System.String)
		/// </summary>
		protected RMethod r_R__0__78d_Pet_String;
		public virtual RMethod R__0__78d_Pet_String
		{
			get
			{
				if(r_R__0__78d_Pet_String == null)
				{
					r_R__0__78d_Pet_String = new(this, "#78d", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String));
					r_R__0__78d_Pet_String.SetBelong(this.instance);
				}
				return r_R__0__78d_Pet_String;
			}
		}

		/// <summary>
		/// Single #88d(Pet, System.String)
		/// </summary>
		protected RMethod r_R__0__88d_Pet_String;
		public virtual RMethod R__0__88d_Pet_String
		{
			get
			{
				if(r_R__0__88d_Pet_String == null)
				{
					r_R__0__88d_Pet_String = new(this, "#88d", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String));
					r_R__0__88d_Pet_String.SetBelong(this.instance);
				}
				return r_R__0__88d_Pet_String;
			}
		}

		/// <summary>
		/// Single #88d(Single, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__88d_Single_ID_String;
		public virtual RMethod R__0__88d_Single_ID_String
		{
			get
			{
				if(r_R__0__88d_Single_ID_String == null)
				{
					r_R__0__88d_Single_ID_String = new(this, "#88d", 0, typeof(System.Single), typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__88d_Single_ID_String.SetBelong(this.instance);
				}
				return r_R__0__88d_Single_ID_String;
			}
		}

		/// <summary>
		/// Single #78d(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__78d_ID_String;
		public virtual RMethod R__0__78d_ID_String
		{
			get
			{
				if(r_R__0__78d_ID_String == null)
				{
					r_R__0__78d_ID_String = new(this, "#78d", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__78d_ID_String.SetBelong(this.instance);
				}
				return r_R__0__78d_ID_String;
			}
		}

		/// <summary>
		/// Single #88d(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__88d_ID_String;
		public virtual RMethod R__0__88d_ID_String
		{
			get
			{
				if(r_R__0__88d_ID_String == null)
				{
					r_R__0__88d_ID_String = new(this, "#88d", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__88d_ID_String.SetBelong(this.instance);
				}
				return r_R__0__88d_ID_String;
			}
		}

		/// <summary>
		/// System.String #98d(Pet, System.String)
		/// </summary>
		protected RMethod r_R__0__98d_Pet_String;
		public virtual RMethod R__0__98d_Pet_String
		{
			get
			{
				if(r_R__0__98d_Pet_String == null)
				{
					r_R__0__98d_Pet_String = new(this, "#98d", 0,  ReleactionUtils.GetType("Pet"), typeof(System.String));
					r_R__0__98d_Pet_String.SetBelong(this.instance);
				}
				return r_R__0__98d_Pet_String;
			}
		}

		/// <summary>
		/// System.String #98d(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__98d_ID_String;
		public virtual RMethod R__0__98d_ID_String
		{
			get
			{
				if(r_R__0__98d_ID_String == null)
				{
					r_R__0__98d_ID_String = new(this, "#98d", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__98d_ID_String.SetBelong(this.instance);
				}
				return r_R__0__98d_ID_String;
			}
		}

		/// <summary>
		/// Int32 #UKf(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__UKf_ID;
		public virtual RMethod R__0__UKf_ID
		{
			get
			{
				if(r_R__0__UKf_ID == null)
				{
					r_R__0__UKf_ID = new(this, "#UKf", 0, typeof(GameDefineType.ID));
					r_R__0__UKf_ID.SetBelong(this.instance);
				}
				return r_R__0__UKf_ID;
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


        public R__0__0Wc() : base("#u.#0Wc")
        {
        }

        public R__0__0Wc(System.Object instance) : base("#u.#0Wc")
		{
            SetInstance(instance);
		}

        public R__0__0Wc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__0Wc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadIllustrationsConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadIllustrationsConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadHandbookReelConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadHandbookReelConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadPetChallengeTimesConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadPetChallengeTimesConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, ILLUSTRATION_INFO> __0__GWc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__GWc.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, ILLUSTRATION_INFO>)___result;
        }


        public virtual ILLUSTRATION_INFO __0__HWc(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__HWc_ID.Invoke(___genericsType, ___parameters);

            return (ILLUSTRATION_INFO)___result;
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.Int32 __0__UKf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__UKf.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void __0__OWc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__OWc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__PWc(ILLUSTRATION_INFO  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = R__0__PWc_ILLUSTRATION_INFO.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__QWc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__QWc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual GameDefineType.ID __0__28d(GameDefineType.ID  @itemId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemId};
            var ___result = R__0__28d_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Boolean __0__SWc(ILLUSTRATION_INFO  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = R__0__SWc_ILLUSTRATION_INFO.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__TWc(GameDefineType.ID  @careerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerId};
            var ___result = R__0__TWc_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__UWc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__UWc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Obu(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Obu_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VWc(GameDefineType.ID  @career, GameDefineType.ID  @idIllu, System.Boolean  @isPurchase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@career, @idIllu, @isPurchase};
            var ___result = R__0__VWc_ID_ID_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__WWc(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__WWc_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XWc(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__XWc_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__YWc(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__YWc_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.Collections.Generic.List<System.String>> __0__ZWc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ZWc.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.Collections.Generic.List<System.String>>)___result;
        }


        public virtual System.Int32 GetPropertyValue(GameDefineType.ID  @careerId, System.String  @ProName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerId, @ProName};
            var ___result = RGetPropertyValue_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 __0__etd(GameDefineType.ID  @careerId, System.Int32  @level, System.String  @propName, System.Single  @grow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerId, @level, @propName, @grow};
            var ___result = R__0__etd_ID_Int32_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Single __0__38d(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = R__0__38d_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void __0__48d(System.Int32  @grow, GameDefineType.ID  @careerId, System.String  @propName, out System.Int32  @sun, out System.Int32  @moon, out System.Int32  @star)
        {
			sun = default;
			moon = default;
			star = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@grow, @careerId, @propName, @sun, @moon, @star};
            var ___result = R__0__48d_Int32_ID_String_Out_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			sun = (System.Int32)___parameters[3];
			moon = (System.Int32)___parameters[4];
			star = (System.Int32)___parameters[5];

            
        }


        public virtual void __0__58d(System.Int32  @num, out System.Int32  @sun, out System.Int32  @moon, out System.Int32  @star)
        {
			sun = default;
			moon = default;
			star = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@num, @sun, @moon, @star};
            var ___result = R__0__58d_Int32_Out_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			sun = (System.Int32)___parameters[1];
			moon = (System.Int32)___parameters[2];
			star = (System.Int32)___parameters[3];

            
        }


        public virtual System.Int32 __0__68d(System.Int32  @grow, GameDefineType.ID  @careerId, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@grow, @careerId, @propName};
            var ___result = R__0__68d_Int32_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void __0__48d(GameDefineType.ID  @careerId, System.String  @propName, out System.Int32  @sun, out System.Int32  @moon, out System.Int32  @star)
        {
			sun = default;
			moon = default;
			star = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerId, @propName, @sun, @moon, @star};
            var ___result = R__0__48d_ID_String_Out_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			sun = (System.Int32)___parameters[2];
			moon = (System.Int32)___parameters[3];
			star = (System.Int32)___parameters[4];

            
        }




        public virtual System.Single __0__88d(System.Single  @grower, GameDefineType.ID  @careerId, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@grower, @careerId, @propName};
            var ___result = R__0__88d_Single_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single __0__78d(GameDefineType.ID  @carerrId, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carerrId, @propName};
            var ___result = R__0__78d_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single __0__88d(GameDefineType.ID  @carerrId, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carerrId, @propName};
            var ___result = R__0__88d_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }



        public virtual System.String __0__98d(GameDefineType.ID  @carerrId, System.String  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carerrId, @prop};
            var ___result = R__0__98d_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 __0__UKf(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__UKf_ID.Invoke(___genericsType, ___parameters);

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
