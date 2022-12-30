using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#RP
	/// </summary>
    public partial class R__0__RP : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
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
		/// GameDefineType.ID #b
		/// </summary>
		protected RGameDefineType.RID r___0__b;
		public virtual RGameDefineType.RID R__0__b
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
		/// #u.#IOc #d
		/// </summary>
		protected R__0__u.R__0__IOc r___0__d;
		public virtual R__0__u.R__0__IOc R__0__d
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
		/// #u.#IOc+#Hcd #e
		/// </summary>
		protected R__0__u.R__0__IOc.R__0__Hcd r___0__e;
		public virtual R__0__u.R__0__IOc.R__0__Hcd R__0__e
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
		/// System.Boolean #f
		/// </summary>
		protected static RField r___0__f;
		public static RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new( ReleactionUtils.GetType("#u.#RP"), "#f");
					r___0__f.SetBelong(null);
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
					r___0__h = new( ReleactionUtils.GetType("#u.#RP"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.String GameStaetName
		/// </summary>
		protected RProperty r_R__0__mGb;
		public virtual RProperty R__0__mGb
		{
			get
			{
				if(r_R__0__mGb == null)
				{
					r_R__0__mGb = new(this, "GameStaetName", -1);
					r_R__0__mGb.SetBelong(this.instance);
				}
				return r_R__0__mGb;
			}
		}

		/// <summary>
		/// Boolean LoginQueueing
		/// </summary>
		protected RProperty r_R__0__Ouf;
		public virtual RProperty R__0__Ouf
		{
			get
			{
				if(r_R__0__Ouf == null)
				{
					r_R__0__Ouf = new(this, "LoginQueueing", -1);
					r_R__0__Ouf.SetBelong(this.instance);
				}
				return r_R__0__Ouf;
			}
		}

		/// <summary>
		/// Void #nGb()
		/// </summary>
		protected RMethod r_R__0__nGb;
		public virtual RMethod R__0__nGb
		{
			get
			{
				if(r_R__0__nGb == null)
				{
					r_R__0__nGb = new(this, "#nGb", 0);
					r_R__0__nGb.SetBelong(this.instance);
				}
				return r_R__0__nGb;
			}
		}

		/// <summary>
		/// Void #oGb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__oGb_Object___0__Isb;
		public virtual RMethod R__0__oGb_Object___0__Isb
		{
			get
			{
				if(r_R__0__oGb_Object___0__Isb == null)
				{
					r_R__0__oGb_Object___0__Isb = new(this, "#oGb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__oGb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__oGb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #7Ec(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__7Ec_Object___0__Isb;
		public virtual RMethod R__0__7Ec_Object___0__Isb
		{
			get
			{
				if(r_R__0__7Ec_Object___0__Isb == null)
				{
					r_R__0__7Ec_Object___0__Isb = new(this, "#7Ec", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__7Ec_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__7Ec_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #gHb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__gHb_Object___0__Isb;
		public virtual RMethod R__0__gHb_Object___0__Isb
		{
			get
			{
				if(r_R__0__gHb_Object___0__Isb == null)
				{
					r_R__0__gHb_Object___0__Isb = new(this, "#gHb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__gHb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__gHb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #hHb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__hHb_Object___0__Isb;
		public virtual RMethod R__0__hHb_Object___0__Isb
		{
			get
			{
				if(r_R__0__hHb_Object___0__Isb == null)
				{
					r_R__0__hHb_Object___0__Isb = new(this, "#hHb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__hHb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__hHb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #iHb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__iHb_Object___0__Isb;
		public virtual RMethod R__0__iHb_Object___0__Isb
		{
			get
			{
				if(r_R__0__iHb_Object___0__Isb == null)
				{
					r_R__0__iHb_Object___0__Isb = new(this, "#iHb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__iHb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__iHb_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.String #IGg()
		/// </summary>
		protected RMethod r_R__0__IGg;
		public virtual RMethod R__0__IGg
		{
			get
			{
				if(r_R__0__IGg == null)
				{
					r_R__0__IGg = new(this, "#IGg", 0);
					r_R__0__IGg.SetBelong(this.instance);
				}
				return r_R__0__IGg;
			}
		}

		/// <summary>
		/// Void #mAc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__mAc_Object___0__Isb;
		public virtual RMethod R__0__mAc_Object___0__Isb
		{
			get
			{
				if(r_R__0__mAc_Object___0__Isb == null)
				{
					r_R__0__mAc_Object___0__Isb = new(this, "#mAc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__mAc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__mAc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #c1g(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__c1g_Object___0__Isb;
		public virtual RMethod R__0__c1g_Object___0__Isb
		{
			get
			{
				if(r_R__0__c1g_Object___0__Isb == null)
				{
					r_R__0__c1g_Object___0__Isb = new(this, "#c1g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__c1g_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__c1g_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #kMg(MyGUIWindow)
		/// </summary>
		protected RMethod r_R__0__kMg_MyGUIWindow;
		public virtual RMethod R__0__kMg_MyGUIWindow
		{
			get
			{
				if(r_R__0__kMg_MyGUIWindow == null)
				{
					r_R__0__kMg_MyGUIWindow = new(this, "#kMg", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_R__0__kMg_MyGUIWindow.SetBelong(this.instance);
				}
				return r_R__0__kMg_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #lMg(MyGUIWindow)
		/// </summary>
		protected RMethod r_R__0__lMg_MyGUIWindow;
		public virtual RMethod R__0__lMg_MyGUIWindow
		{
			get
			{
				if(r_R__0__lMg_MyGUIWindow == null)
				{
					r_R__0__lMg_MyGUIWindow = new(this, "#lMg", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_R__0__lMg_MyGUIWindow.SetBelong(this.instance);
				}
				return r_R__0__lMg_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #mMg(MyGUIWindow)
		/// </summary>
		protected RMethod r_R__0__mMg_MyGUIWindow;
		public virtual RMethod R__0__mMg_MyGUIWindow
		{
			get
			{
				if(r_R__0__mMg_MyGUIWindow == null)
				{
					r_R__0__mMg_MyGUIWindow = new(this, "#mMg", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_R__0__mMg_MyGUIWindow.SetBelong(this.instance);
				}
				return r_R__0__mMg_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #jHb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__jHb_Object___0__Isb;
		public virtual RMethod R__0__jHb_Object___0__Isb
		{
			get
			{
				if(r_R__0__jHb_Object___0__Isb == null)
				{
					r_R__0__jHb_Object___0__Isb = new(this, "#jHb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__jHb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__jHb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Puf()
		/// </summary>
		protected RMethod r_R__0__Puf;
		public virtual RMethod R__0__Puf
		{
			get
			{
				if(r_R__0__Puf == null)
				{
					r_R__0__Puf = new(this, "#Puf", 0);
					r_R__0__Puf.SetBelong(this.instance);
				}
				return r_R__0__Puf;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #brf()
		/// </summary>
		protected RMethod r_R__0__brf;
		public virtual RMethod R__0__brf
		{
			get
			{
				if(r_R__0__brf == null)
				{
					r_R__0__brf = new(this, "#brf", 0);
					r_R__0__brf.SetBelong(this.instance);
				}
				return r_R__0__brf;
			}
		}

		/// <summary>
		/// Void #Quf(System.Object)
		/// </summary>
		protected RMethod r_R__0__Quf_Object;
		public virtual RMethod R__0__Quf_Object
		{
			get
			{
				if(r_R__0__Quf_Object == null)
				{
					r_R__0__Quf_Object = new(this, "#Quf", 0, typeof(System.Object));
					r_R__0__Quf_Object.SetBelong(this.instance);
				}
				return r_R__0__Quf_Object;
			}
		}

		/// <summary>
		/// Void #crf(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__crf_Object___0__Isb;
		public virtual RMethod R__0__crf_Object___0__Isb
		{
			get
			{
				if(r_R__0__crf_Object___0__Isb == null)
				{
					r_R__0__crf_Object___0__Isb = new(this, "#crf", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__crf_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__crf_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #9Lc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__9Lc_Object___0__Isb;
		public virtual RMethod R__0__9Lc_Object___0__Isb
		{
			get
			{
				if(r_R__0__9Lc_Object___0__Isb == null)
				{
					r_R__0__9Lc_Object___0__Isb = new(this, "#9Lc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__9Lc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__9Lc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #pGb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__pGb_Object___0__Isb;
		public virtual RMethod R__0__pGb_Object___0__Isb
		{
			get
			{
				if(r_R__0__pGb_Object___0__Isb == null)
				{
					r_R__0__pGb_Object___0__Isb = new(this, "#pGb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__pGb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__pGb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLoadPlayer(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadPlayer_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadPlayer_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadPlayer_Object_CGLoadedArgs == null)
				{
					r_ROnLoadPlayer_Object_CGLoadedArgs = new(this, "OnLoadPlayer", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadPlayer_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadPlayer_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadPlayer(System.Object, #u.#egb)
		/// </summary>
		protected RMethod r_ROnLoadPlayer_Object___0__egb;
		public virtual RMethod ROnLoadPlayer_Object___0__egb
		{
			get
			{
				if(r_ROnLoadPlayer_Object___0__egb == null)
				{
					r_ROnLoadPlayer_Object___0__egb = new(this, "OnLoadPlayer", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#egb"));
					r_ROnLoadPlayer_Object___0__egb.SetBelong(this.instance);
				}
				return r_ROnLoadPlayer_Object___0__egb;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Ruf()
		/// </summary>
		protected RMethod r_R__0__Ruf;
		public virtual RMethod R__0__Ruf
		{
			get
			{
				if(r_R__0__Ruf == null)
				{
					r_R__0__Ruf = new(this, "#Ruf", 0);
					r_R__0__Ruf.SetBelong(this.instance);
				}
				return r_R__0__Ruf;
			}
		}

		/// <summary>
		/// Void #Suf()
		/// </summary>
		protected RMethod r_R__0__Suf;
		public virtual RMethod R__0__Suf
		{
			get
			{
				if(r_R__0__Suf == null)
				{
					r_R__0__Suf = new(this, "#Suf", 0);
					r_R__0__Suf.SetBelong(this.instance);
				}
				return r_R__0__Suf;
			}
		}

		/// <summary>
		/// Void #Tuf(System.String)
		/// </summary>
		protected RMethod r_R__0__Tuf_String;
		public virtual RMethod R__0__Tuf_String
		{
			get
			{
				if(r_R__0__Tuf_String == null)
				{
					r_R__0__Tuf_String = new(this, "#Tuf", 0, typeof(System.String));
					r_R__0__Tuf_String.SetBelong(this.instance);
				}
				return r_R__0__Tuf_String;
			}
		}

		/// <summary>
		/// Void #rGb(System.String)
		/// </summary>
		protected RMethod r_R__0__rGb_String;
		public virtual RMethod R__0__rGb_String
		{
			get
			{
				if(r_R__0__rGb_String == null)
				{
					r_R__0__rGb_String = new(this, "#rGb", 0, typeof(System.String));
					r_R__0__rGb_String.SetBelong(this.instance);
				}
				return r_R__0__rGb_String;
			}
		}

		/// <summary>
		/// Void #tGb(System.String)
		/// </summary>
		protected RMethod r_R__0__tGb_String;
		public virtual RMethod R__0__tGb_String
		{
			get
			{
				if(r_R__0__tGb_String == null)
				{
					r_R__0__tGb_String = new(this, "#tGb", 0, typeof(System.String));
					r_R__0__tGb_String.SetBelong(this.instance);
				}
				return r_R__0__tGb_String;
			}
		}

		/// <summary>
		/// Void SetWindow(MyGUIWindow)
		/// </summary>
		protected RMethod r_RSetWindow_MyGUIWindow;
		public virtual RMethod RSetWindow_MyGUIWindow
		{
			get
			{
				if(r_RSetWindow_MyGUIWindow == null)
				{
					r_RSetWindow_MyGUIWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RSetWindow_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RSetWindow_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #Pr(System.String)
		/// </summary>
		protected RMethod r_R__0__Pr_String;
		public virtual RMethod R__0__Pr_String
		{
			get
			{
				if(r_R__0__Pr_String == null)
				{
					r_R__0__Pr_String = new(this, "#Pr", 0, typeof(System.String));
					r_R__0__Pr_String.SetBelong(this.instance);
				}
				return r_R__0__Pr_String;
			}
		}

		/// <summary>
		/// Void #sGb(System.String)
		/// </summary>
		protected RMethod r_R__0__sGb_String;
		public virtual RMethod R__0__sGb_String
		{
			get
			{
				if(r_R__0__sGb_String == null)
				{
					r_R__0__sGb_String = new(this, "#sGb", 0, typeof(System.String));
					r_R__0__sGb_String.SetBelong(this.instance);
				}
				return r_R__0__sGb_String;
			}
		}

		/// <summary>
		/// Void Update(Single)
		/// </summary>
		protected RMethod r_RUpdate_Single;
		public virtual RMethod RUpdate_Single
		{
			get
			{
				if(r_RUpdate_Single == null)
				{
					r_RUpdate_Single = new(this, "Update", 0, typeof(System.Single));
					r_RUpdate_Single.SetBelong(this.instance);
				}
				return r_RUpdate_Single;
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


        public R__0__RP() : base("#u.#RP")
        {
        }

        public R__0__RP(System.Object instance) : base("#u.#RP")
		{
            SetInstance(instance);
		}

        public R__0__RP(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__RP(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__nGb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nGb.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.String __0__IGg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__IGg.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }








        public virtual void __0__Puf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Puf.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__brf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__brf.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__Quf(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Quf_Object.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.Collections.IEnumerator __0__Ruf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Ruf.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__Suf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Suf.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tuf(System.String  @browser)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@browser};
            var ___result = R__0__Tuf_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__rGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tGb(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__tGb_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Pr(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__Pr_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__sGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update(System.Single  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RUpdate_Single.Invoke(___genericsType, ___parameters);

            
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
