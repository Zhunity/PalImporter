using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#tVf
	/// </summary>
    public partial class R__0__tVf : RMember //
    {

		/// <summary>
		/// System.String[] #a
		/// </summary>
		protected RFieldArray<RField> r___0__a;
		public virtual RFieldArray<RField> R__0__a
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
		/// #u.#8Rc #b
		/// </summary>
		protected R__0__u.R__0__8Rc r___0__b;
		public virtual R__0__u.R__0__8Rc R__0__b
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
		/// #u.#Ckb #c
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__c;
		public virtual R__0__u.R__0__Ckb R__0__c
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,HyperLinkSceneCfg] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RHyperLinkSceneCfg> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RHyperLinkSceneCfg> R__0__d
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,MyGUI.ElementBase] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RMyGUI.RElementBase> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RMyGUI.RElementBase> R__0__e
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #f
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__f;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new( ReleactionUtils.GetType("#u.#tVf"), "#f");
					r___0__f.SetBelong(null);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #g
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__g;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("#u.#tVf"), "#g");
					r___0__g.SetBelong(null);
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
					r___0__h = new( ReleactionUtils.GetType("#u.#tVf"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// Void OnLoadHyperLinkSceneConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadHyperLinkSceneConfig_Object;
		public virtual RMethod ROnLoadHyperLinkSceneConfig_Object
		{
			get
			{
				if(r_ROnLoadHyperLinkSceneConfig_Object == null)
				{
					r_ROnLoadHyperLinkSceneConfig_Object = new(this, "OnLoadHyperLinkSceneConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadHyperLinkSceneConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadHyperLinkSceneConfig_Object;
			}
		}

		/// <summary>
		/// HyperLinkSceneCfg #10f(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__10f_ID;
		public virtual RMethod R__0__10f_ID
		{
			get
			{
				if(r_R__0__10f_ID == null)
				{
					r_R__0__10f_ID = new(this, "#10f", 0, typeof(GameDefineType.ID));
					r_R__0__10f_ID.SetBelong(this.instance);
				}
				return r_R__0__10f_ID;
			}
		}

		/// <summary>
		/// Void #jVf(System.String[])
		/// </summary>
		protected RMethod r_R__0__jVf_StringArray;
		public virtual RMethod R__0__jVf_StringArray
		{
			get
			{
				if(r_R__0__jVf_StringArray == null)
				{
					r_R__0__jVf_StringArray = new(this, "#jVf", 0, typeof(System.String).MakeArrayType());
					r_R__0__jVf_StringArray.SetBelong(this.instance);
				}
				return r_R__0__jVf_StringArray;
			}
		}

		/// <summary>
		/// Void #YYi(GameDefineType.ID, System.String[])
		/// </summary>
		protected RMethod r_R__0__YYi_ID_StringArray;
		public virtual RMethod R__0__YYi_ID_StringArray
		{
			get
			{
				if(r_R__0__YYi_ID_StringArray == null)
				{
					r_R__0__YYi_ID_StringArray = new(this, "#YYi", 0, typeof(GameDefineType.ID), typeof(System.String).MakeArrayType());
					r_R__0__YYi_ID_StringArray.SetBelong(this.instance);
				}
				return r_R__0__YYi_ID_StringArray;
			}
		}

		/// <summary>
		/// Void #kVf(System.String, System.String ByRef, System.String[])
		/// </summary>
		protected RMethod r_R__0__kVf_String_Out_String_StringArray;
		public virtual RMethod R__0__kVf_String_Out_String_StringArray
		{
			get
			{
				if(r_R__0__kVf_String_Out_String_StringArray == null)
				{
					r_R__0__kVf_String_Out_String_StringArray = new(this, "#kVf", 0, typeof(System.String), typeof(System.String).MakeByRefType(), typeof(System.String).MakeArrayType());
					r_R__0__kVf_String_Out_String_StringArray.SetBelong(this.instance);
				}
				return r_R__0__kVf_String_Out_String_StringArray;
			}
		}

		/// <summary>
		/// Void #lVf(System.String)
		/// </summary>
		protected RMethod r_R__0__lVf_String;
		public virtual RMethod R__0__lVf_String
		{
			get
			{
				if(r_R__0__lVf_String == null)
				{
					r_R__0__lVf_String = new(this, "#lVf", 0, typeof(System.String));
					r_R__0__lVf_String.SetBelong(this.instance);
				}
				return r_R__0__lVf_String;
			}
		}

		/// <summary>
		/// System.String[] #mVf(System.String)
		/// </summary>
		protected RMethod r_R__0__mVf_String;
		public virtual RMethod R__0__mVf_String
		{
			get
			{
				if(r_R__0__mVf_String == null)
				{
					r_R__0__mVf_String = new(this, "#mVf", 0, typeof(System.String));
					r_R__0__mVf_String.SetBelong(this.instance);
				}
				return r_R__0__mVf_String;
			}
		}

		/// <summary>
		/// System.String #nVf(System.String)
		/// </summary>
		protected RMethod r_R__0__nVf_String;
		public virtual RMethod R__0__nVf_String
		{
			get
			{
				if(r_R__0__nVf_String == null)
				{
					r_R__0__nVf_String = new(this, "#nVf", 0, typeof(System.String));
					r_R__0__nVf_String.SetBelong(this.instance);
				}
				return r_R__0__nVf_String;
			}
		}

		/// <summary>
		/// System.String #oVf(System.String)
		/// </summary>
		protected RMethod r_R__0__oVf_String;
		public virtual RMethod R__0__oVf_String
		{
			get
			{
				if(r_R__0__oVf_String == null)
				{
					r_R__0__oVf_String = new(this, "#oVf", 0, typeof(System.String));
					r_R__0__oVf_String.SetBelong(this.instance);
				}
				return r_R__0__oVf_String;
			}
		}

		/// <summary>
		/// Void #pVf(MyGUI.CustomLabel)
		/// </summary>
		protected RMethod r_R__0__pVf_CustomLabel;
		public virtual RMethod R__0__pVf_CustomLabel
		{
			get
			{
				if(r_R__0__pVf_CustomLabel == null)
				{
					r_R__0__pVf_CustomLabel = new(this, "#pVf", 0,  ReleactionUtils.GetType("MyGUI.CustomLabel"));
					r_R__0__pVf_CustomLabel.SetBelong(this.instance);
				}
				return r_R__0__pVf_CustomLabel;
			}
		}

		/// <summary>
		/// Void #pVf(MyGUI.CustomLabel, System.String[])
		/// </summary>
		protected RMethod r_R__0__pVf_CustomLabel_StringArray;
		public virtual RMethod R__0__pVf_CustomLabel_StringArray
		{
			get
			{
				if(r_R__0__pVf_CustomLabel_StringArray == null)
				{
					r_R__0__pVf_CustomLabel_StringArray = new(this, "#pVf", 0,  ReleactionUtils.GetType("MyGUI.CustomLabel"), typeof(System.String).MakeArrayType());
					r_R__0__pVf_CustomLabel_StringArray.SetBelong(this.instance);
				}
				return r_R__0__pVf_CustomLabel_StringArray;
			}
		}

		/// <summary>
		/// Void #pVf(MyGUI.CustomLabel, System.String[], #ZNb)
		/// </summary>
		protected RMethod r_R__0__pVf_CustomLabel_StringArray___0__ZNb;
		public virtual RMethod R__0__pVf_CustomLabel_StringArray___0__ZNb
		{
			get
			{
				if(r_R__0__pVf_CustomLabel_StringArray___0__ZNb == null)
				{
					r_R__0__pVf_CustomLabel_StringArray___0__ZNb = new(this, "#pVf", 0,  ReleactionUtils.GetType("MyGUI.CustomLabel"), typeof(System.String).MakeArrayType(),  ReleactionUtils.GetType("MyGUI.ElementBase+#ZNb"));
					r_R__0__pVf_CustomLabel_StringArray___0__ZNb.SetBelong(this.instance);
				}
				return r_R__0__pVf_CustomLabel_StringArray___0__ZNb;
			}
		}

		/// <summary>
		/// Void #E4f(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__E4f_Object___0__7X;
		public virtual RMethod R__0__E4f_Object___0__7X
		{
			get
			{
				if(r_R__0__E4f_Object___0__7X == null)
				{
					r_R__0__E4f_Object___0__7X = new(this, "#E4f", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__E4f_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__E4f_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #F4f(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__F4f_Object___0__7X;
		public virtual RMethod R__0__F4f_Object___0__7X
		{
			get
			{
				if(r_R__0__F4f_Object___0__7X == null)
				{
					r_R__0__F4f_Object___0__7X = new(this, "#F4f", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__F4f_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__F4f_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #GBd(Int32, System.String[], MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__GBd_Int32_StringArray_ElementBase;
		public virtual RMethod R__0__GBd_Int32_StringArray_ElementBase
		{
			get
			{
				if(r_R__0__GBd_Int32_StringArray_ElementBase == null)
				{
					r_R__0__GBd_Int32_StringArray_ElementBase = new(this, "#GBd", 0, typeof(System.Int32), typeof(System.String).MakeArrayType(), typeof(MyGUI.ElementBase));
					r_R__0__GBd_Int32_StringArray_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__GBd_Int32_StringArray_ElementBase;
			}
		}

		/// <summary>
		/// Void #qVf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__qVf_Object___0__7X;
		public virtual RMethod R__0__qVf_Object___0__7X
		{
			get
			{
				if(r_R__0__qVf_Object___0__7X == null)
				{
					r_R__0__qVf_Object___0__7X = new(this, "#qVf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__qVf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__qVf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #H4f(System.String, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__H4f_String_ElementBase;
		public virtual RMethod R__0__H4f_String_ElementBase
		{
			get
			{
				if(r_R__0__H4f_String_ElementBase == null)
				{
					r_R__0__H4f_String_ElementBase = new(this, "#H4f", 0, typeof(System.String), typeof(MyGUI.ElementBase));
					r_R__0__H4f_String_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__H4f_String_ElementBase;
			}
		}

		/// <summary>
		/// Void ShowTargetMenu(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RShowTargetMenu_ID_String;
		public virtual RMethod RShowTargetMenu_ID_String
		{
			get
			{
				if(r_RShowTargetMenu_ID_String == null)
				{
					r_RShowTargetMenu_ID_String = new(this, "ShowTargetMenu", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RShowTargetMenu_ID_String.SetBelong(this.instance);
				}
				return r_RShowTargetMenu_ID_String;
			}
		}

		/// <summary>
		/// Void #sVf(System.String[])
		/// </summary>
		protected RMethod r_R__0__sVf_StringArray;
		public virtual RMethod R__0__sVf_StringArray
		{
			get
			{
				if(r_R__0__sVf_StringArray == null)
				{
					r_R__0__sVf_StringArray = new(this, "#sVf", 0, typeof(System.String).MakeArrayType());
					r_R__0__sVf_StringArray.SetBelong(this.instance);
				}
				return r_R__0__sVf_StringArray;
			}
		}

		/// <summary>
		/// Void #I4f(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__I4f_ID_String;
		public virtual RMethod R__0__I4f_ID_String
		{
			get
			{
				if(r_R__0__I4f_ID_String == null)
				{
					r_R__0__I4f_ID_String = new(this, "#I4f", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__I4f_ID_String.SetBelong(this.instance);
				}
				return r_R__0__I4f_ID_String;
			}
		}

		/// <summary>
		/// Void #J4f(GameDefineType.ID, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__J4f_ID_ID_String;
		public virtual RMethod R__0__J4f_ID_ID_String
		{
			get
			{
				if(r_R__0__J4f_ID_ID_String == null)
				{
					r_R__0__J4f_ID_ID_String = new(this, "#J4f", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__J4f_ID_ID_String.SetBelong(this.instance);
				}
				return r_R__0__J4f_ID_ID_String;
			}
		}

		/// <summary>
		/// Void #HTc(System.String)
		/// </summary>
		protected RMethod r_R__0__HTc_String;
		public virtual RMethod R__0__HTc_String
		{
			get
			{
				if(r_R__0__HTc_String == null)
				{
					r_R__0__HTc_String = new(this, "#HTc", 0, typeof(System.String));
					r_R__0__HTc_String.SetBelong(this.instance);
				}
				return r_R__0__HTc_String;
			}
		}

		/// <summary>
		/// Void #Ee(System.String)
		/// </summary>
		protected RMethod r_R__0__Ee_String;
		public virtual RMethod R__0__Ee_String
		{
			get
			{
				if(r_R__0__Ee_String == null)
				{
					r_R__0__Ee_String = new(this, "#Ee", 0, typeof(System.String));
					r_R__0__Ee_String.SetBelong(this.instance);
				}
				return r_R__0__Ee_String;
			}
		}

		/// <summary>
		/// Void #X1(System.String[])
		/// </summary>
		protected RMethod r_R__0__X1_StringArray;
		public virtual RMethod R__0__X1_StringArray
		{
			get
			{
				if(r_R__0__X1_StringArray == null)
				{
					r_R__0__X1_StringArray = new(this, "#X1", 0, typeof(System.String).MakeArrayType());
					r_R__0__X1_StringArray.SetBelong(this.instance);
				}
				return r_R__0__X1_StringArray;
			}
		}

		/// <summary>
		/// Void #6Vc(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__6Vc___0__Ckb;
		public virtual RMethod R__0__6Vc___0__Ckb
		{
			get
			{
				if(r_R__0__6Vc___0__Ckb == null)
				{
					r_R__0__6Vc___0__Ckb = new(this, "#6Vc", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__6Vc___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__6Vc___0__Ckb;
			}
		}

		/// <summary>
		/// Void #Xwg(GameDefineType.ID, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__Xwg_ID_ElementBase;
		public virtual RMethod R__0__Xwg_ID_ElementBase
		{
			get
			{
				if(r_R__0__Xwg_ID_ElementBase == null)
				{
					r_R__0__Xwg_ID_ElementBase = new(this, "#Xwg", 0, typeof(GameDefineType.ID), typeof(MyGUI.ElementBase));
					r_R__0__Xwg_ID_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__Xwg_ID_ElementBase;
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


        public R__0__tVf() : base("#u.#tVf")
        {
        }

        public R__0__tVf(System.Object instance) : base("#u.#tVf")
		{
            SetInstance(instance);
		}

        public R__0__tVf(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__tVf(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadHyperLinkSceneConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadHyperLinkSceneConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual HyperLinkSceneCfg __0__10f(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__10f_ID.Invoke(___genericsType, ___parameters);

            return (HyperLinkSceneCfg)___result;
        }


        public virtual void __0__jVf(System.String[]  @paramArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramArray};
            var ___result = R__0__jVf_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__YYi(GameDefineType.ID  @textID, System.String[]  @paramArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textID, @paramArray};
            var ___result = R__0__YYi_ID_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kVf(System.String  @content, out System.String  @newContent, System.String[]  @paramArray)
        {
			newContent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @newContent, @paramArray};
            var ___result = R__0__kVf_String_Out_String_StringArray.Invoke(___genericsType, ___parameters);
			newContent = (System.String)___parameters[1];

            
        }


        public virtual void __0__lVf(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__lVf_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String[] __0__mVf(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__mVf_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String __0__nVf(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__nVf_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__oVf(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__oVf_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }







        public virtual void __0__GBd(System.Int32  @type, System.String[]  @paramArray, MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @paramArray, @elem};
            var ___result = R__0__GBd_Int32_StringArray_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__H4f(System.String  @str, MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @elem};
            var ___result = R__0__H4f_String_ElementBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTargetMenu(GameDefineType.ID  @id, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @name};
            var ___result = RShowTargetMenu_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sVf(System.String[]  @parm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parm};
            var ___result = R__0__sVf_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I4f(GameDefineType.ID  @idBoss, System.String  @sceneName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBoss, @sceneName};
            var ___result = R__0__I4f_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__J4f(GameDefineType.ID  @parentMapID, GameDefineType.ID  @targetNpcID, System.String  @sceneName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentMapID, @targetNpcID, @sceneName};
            var ___result = R__0__J4f_ID_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__HTc(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = R__0__HTc_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ee(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__Ee_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__X1(System.String[]  @parms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parms};
            var ___result = R__0__X1_StringArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Xwg(GameDefineType.ID  @id, MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @elem};
            var ___result = R__0__Xwg_ID_ElementBase.Invoke(___genericsType, ___parameters);

            
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
