using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Ahg
	/// </summary>
    public partial class R__0__Ahg : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Ahg"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,FamilyWarLadderConfig] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RFamilyWarLadderConfig> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RFamilyWarLadderConfig> R__0__b
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
		/// GameDefineType.ID #c
		/// </summary>
		protected RGameDefineType.RID r___0__c;
		public virtual RGameDefineType.RID R__0__c
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
		/// GameDefineType.ID #d
		/// </summary>
		protected RGameDefineType.RID r___0__d;
		public virtual RGameDefineType.RID R__0__d
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
		/// Void OnLoadFamilyWarLadderConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadFamilyWarLadderConfig_Object;
		public virtual RMethod ROnLoadFamilyWarLadderConfig_Object
		{
			get
			{
				if(r_ROnLoadFamilyWarLadderConfig_Object == null)
				{
					r_ROnLoadFamilyWarLadderConfig_Object = new(this, "OnLoadFamilyWarLadderConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadFamilyWarLadderConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadFamilyWarLadderConfig_Object;
			}
		}

		/// <summary>
		/// FamilyWarLadderConfig #ahg(Int32)
		/// </summary>
		protected RMethod r_R__0__ahg_Int32;
		public virtual RMethod R__0__ahg_Int32
		{
			get
			{
				if(r_R__0__ahg_Int32 == null)
				{
					r_R__0__ahg_Int32 = new(this, "#ahg", 0, typeof(System.Int32));
					r_R__0__ahg_Int32.SetBelong(this.instance);
				}
				return r_R__0__ahg_Int32;
			}
		}

		/// <summary>
		/// Void #bhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__bhg_Object___0__Isb;
		public virtual RMethod R__0__bhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__bhg_Object___0__Isb == null)
				{
					r_R__0__bhg_Object___0__Isb = new(this, "#bhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__bhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__bhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #chg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__chg_Object___0__Isb;
		public virtual RMethod R__0__chg_Object___0__Isb
		{
			get
			{
				if(r_R__0__chg_Object___0__Isb == null)
				{
					r_R__0__chg_Object___0__Isb = new(this, "#chg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__chg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__chg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #dhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__dhg_Object___0__Isb;
		public virtual RMethod R__0__dhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__dhg_Object___0__Isb == null)
				{
					r_R__0__dhg_Object___0__Isb = new(this, "#dhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__dhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__dhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ehg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__ehg_Object___0__Isb;
		public virtual RMethod R__0__ehg_Object___0__Isb
		{
			get
			{
				if(r_R__0__ehg_Object___0__Isb == null)
				{
					r_R__0__ehg_Object___0__Isb = new(this, "#ehg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__ehg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__ehg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #fhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__fhg_Object___0__Isb;
		public virtual RMethod R__0__fhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__fhg_Object___0__Isb == null)
				{
					r_R__0__fhg_Object___0__Isb = new(this, "#fhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__fhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__fhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ghg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__ghg_Object___0__Isb;
		public virtual RMethod R__0__ghg_Object___0__Isb
		{
			get
			{
				if(r_R__0__ghg_Object___0__Isb == null)
				{
					r_R__0__ghg_Object___0__Isb = new(this, "#ghg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__ghg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__ghg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #hhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__hhg_Object___0__Isb;
		public virtual RMethod R__0__hhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__hhg_Object___0__Isb == null)
				{
					r_R__0__hhg_Object___0__Isb = new(this, "#hhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__hhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__hhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ihg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__ihg_Object___0__Isb;
		public virtual RMethod R__0__ihg_Object___0__Isb
		{
			get
			{
				if(r_R__0__ihg_Object___0__Isb == null)
				{
					r_R__0__ihg_Object___0__Isb = new(this, "#ihg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__ihg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__ihg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #jhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__jhg_Object___0__Isb;
		public virtual RMethod R__0__jhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__jhg_Object___0__Isb == null)
				{
					r_R__0__jhg_Object___0__Isb = new(this, "#jhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__jhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__jhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #khg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__khg_Object___0__Isb;
		public virtual RMethod R__0__khg_Object___0__Isb
		{
			get
			{
				if(r_R__0__khg_Object___0__Isb == null)
				{
					r_R__0__khg_Object___0__Isb = new(this, "#khg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__khg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__khg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #lhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__lhg_Object___0__Isb;
		public virtual RMethod R__0__lhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__lhg_Object___0__Isb == null)
				{
					r_R__0__lhg_Object___0__Isb = new(this, "#lhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__lhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__lhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #mhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__mhg_Object___0__Isb;
		public virtual RMethod R__0__mhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__mhg_Object___0__Isb == null)
				{
					r_R__0__mhg_Object___0__Isb = new(this, "#mhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__mhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__mhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #nhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__nhg_Object___0__Isb;
		public virtual RMethod R__0__nhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__nhg_Object___0__Isb == null)
				{
					r_R__0__nhg_Object___0__Isb = new(this, "#nhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__nhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__nhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #hVj(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R__0__hVj_Object___0__n6c;
		public virtual RMethod R__0__hVj_Object___0__n6c
		{
			get
			{
				if(r_R__0__hVj_Object___0__n6c == null)
				{
					r_R__0__hVj_Object___0__n6c = new(this, "#hVj", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R__0__hVj_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R__0__hVj_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void #ohg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__ohg_Object___0__Isb;
		public virtual RMethod R__0__ohg_Object___0__Isb
		{
			get
			{
				if(r_R__0__ohg_Object___0__Isb == null)
				{
					r_R__0__ohg_Object___0__Isb = new(this, "#ohg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__ohg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__ohg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #iVj(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R__0__iVj_Object___0__n6c;
		public virtual RMethod R__0__iVj_Object___0__n6c
		{
			get
			{
				if(r_R__0__iVj_Object___0__n6c == null)
				{
					r_R__0__iVj_Object___0__n6c = new(this, "#iVj", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R__0__iVj_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R__0__iVj_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void #phg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__phg_Object___0__Isb;
		public virtual RMethod R__0__phg_Object___0__Isb
		{
			get
			{
				if(r_R__0__phg_Object___0__Isb == null)
				{
					r_R__0__phg_Object___0__Isb = new(this, "#phg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__phg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__phg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #qhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__qhg_Object___0__Isb;
		public virtual RMethod R__0__qhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__qhg_Object___0__Isb == null)
				{
					r_R__0__qhg_Object___0__Isb = new(this, "#qhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__qhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__qhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #85g(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R__0__85g_Object___0__n6c;
		public virtual RMethod R__0__85g_Object___0__n6c
		{
			get
			{
				if(r_R__0__85g_Object___0__n6c == null)
				{
					r_R__0__85g_Object___0__n6c = new(this, "#85g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R__0__85g_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R__0__85g_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void #NLg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__NLg_Object___0__Isb;
		public virtual RMethod R__0__NLg_Object___0__Isb
		{
			get
			{
				if(r_R__0__NLg_Object___0__Isb == null)
				{
					r_R__0__NLg_Object___0__Isb = new(this, "#NLg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__NLg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__NLg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #rhg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__rhg_Object___0__Isb;
		public virtual RMethod R__0__rhg_Object___0__Isb
		{
			get
			{
				if(r_R__0__rhg_Object___0__Isb == null)
				{
					r_R__0__rhg_Object___0__Isb = new(this, "#rhg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__rhg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__rhg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #shg(#Pfb.#5sb)
		/// </summary>
		protected RMethod r_R__0__shg___0__5sb;
		public virtual RMethod R__0__shg___0__5sb
		{
			get
			{
				if(r_R__0__shg___0__5sb == null)
				{
					r_R__0__shg___0__5sb = new(this, "#shg", 0,  ReleactionUtils.GetType("#Pfb.#5sb"));
					r_R__0__shg___0__5sb.SetBelong(this.instance);
				}
				return r_R__0__shg___0__5sb;
			}
		}

		/// <summary>
		/// Void #thg()
		/// </summary>
		protected RMethod r_R__0__thg;
		public virtual RMethod R__0__thg
		{
			get
			{
				if(r_R__0__thg == null)
				{
					r_R__0__thg = new(this, "#thg", 0);
					r_R__0__thg.SetBelong(this.instance);
				}
				return r_R__0__thg;
			}
		}

		/// <summary>
		/// Void #uhg()
		/// </summary>
		protected RMethod r_R__0__uhg;
		public virtual RMethod R__0__uhg
		{
			get
			{
				if(r_R__0__uhg == null)
				{
					r_R__0__uhg = new(this, "#uhg", 0);
					r_R__0__uhg.SetBelong(this.instance);
				}
				return r_R__0__uhg;
			}
		}

		/// <summary>
		/// Void #vhg()
		/// </summary>
		protected RMethod r_R__0__vhg;
		public virtual RMethod R__0__vhg
		{
			get
			{
				if(r_R__0__vhg == null)
				{
					r_R__0__vhg = new(this, "#vhg", 0);
					r_R__0__vhg.SetBelong(this.instance);
				}
				return r_R__0__vhg;
			}
		}

		/// <summary>
		/// Void #whg(System.String)
		/// </summary>
		protected RMethod r_R__0__whg_String;
		public virtual RMethod R__0__whg_String
		{
			get
			{
				if(r_R__0__whg_String == null)
				{
					r_R__0__whg_String = new(this, "#whg", 0, typeof(System.String));
					r_R__0__whg_String.SetBelong(this.instance);
				}
				return r_R__0__whg_String;
			}
		}

		/// <summary>
		/// Boolean #xhg()
		/// </summary>
		protected RMethod r_R__0__xhg;
		public virtual RMethod R__0__xhg
		{
			get
			{
				if(r_R__0__xhg == null)
				{
					r_R__0__xhg = new(this, "#xhg", 0);
					r_R__0__xhg.SetBelong(this.instance);
				}
				return r_R__0__xhg;
			}
		}

		/// <summary>
		/// Int32 #yhg()
		/// </summary>
		protected RMethod r_R__0__yhg;
		public virtual RMethod R__0__yhg
		{
			get
			{
				if(r_R__0__yhg == null)
				{
					r_R__0__yhg = new(this, "#yhg", 0);
					r_R__0__yhg.SetBelong(this.instance);
				}
				return r_R__0__yhg;
			}
		}

		/// <summary>
		/// Void #VC(#Pfb.#Grb)
		/// </summary>
		protected RMethod r_R__0__VC___0__Grb;
		public virtual RMethod R__0__VC___0__Grb
		{
			get
			{
				if(r_R__0__VC___0__Grb == null)
				{
					r_R__0__VC___0__Grb = new(this, "#VC", 0,  ReleactionUtils.GetType("#Pfb.#Grb"));
					r_R__0__VC___0__Grb.SetBelong(this.instance);
				}
				return r_R__0__VC___0__Grb;
			}
		}

		/// <summary>
		/// Void #WC(#Pfb.#Hrb)
		/// </summary>
		protected RMethod r_R__0__WC___0__Hrb;
		public virtual RMethod R__0__WC___0__Hrb
		{
			get
			{
				if(r_R__0__WC___0__Hrb == null)
				{
					r_R__0__WC___0__Hrb = new(this, "#WC", 0,  ReleactionUtils.GetType("#Pfb.#Hrb"));
					r_R__0__WC___0__Hrb.SetBelong(this.instance);
				}
				return r_R__0__WC___0__Hrb;
			}
		}

		/// <summary>
		/// Void #zhg(GameDefineType.ID, System.String[])
		/// </summary>
		protected RMethod r_R__0__zhg_ID_StringArray;
		public virtual RMethod R__0__zhg_ID_StringArray
		{
			get
			{
				if(r_R__0__zhg_ID_StringArray == null)
				{
					r_R__0__zhg_ID_StringArray = new(this, "#zhg", 0, typeof(GameDefineType.ID), typeof(System.String).MakeArrayType());
					r_R__0__zhg_ID_StringArray.SetBelong(this.instance);
				}
				return r_R__0__zhg_ID_StringArray;
			}
		}

		/// <summary>
		/// Void #I0g()
		/// </summary>
		protected RMethod r_R__0__I0g;
		public virtual RMethod R__0__I0g
		{
			get
			{
				if(r_R__0__I0g == null)
				{
					r_R__0__I0g = new(this, "#I0g", 0);
					r_R__0__I0g.SetBelong(this.instance);
				}
				return r_R__0__I0g;
			}
		}

		/// <summary>
		/// Void #95g(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__95g_ID;
		public virtual RMethod R__0__95g_ID
		{
			get
			{
				if(r_R__0__95g_ID == null)
				{
					r_R__0__95g_ID = new(this, "#95g", 0, typeof(GameDefineType.ID));
					r_R__0__95g_ID.SetBelong(this.instance);
				}
				return r_R__0__95g_ID;
			}
		}

		/// <summary>
		/// Void #PLg()
		/// </summary>
		protected RMethod r_R__0__PLg;
		public virtual RMethod R__0__PLg
		{
			get
			{
				if(r_R__0__PLg == null)
				{
					r_R__0__PLg = new(this, "#PLg", 0);
					r_R__0__PLg.SetBelong(this.instance);
				}
				return r_R__0__PLg;
			}
		}

		/// <summary>
		/// Void #Fsx(System.Object)
		/// </summary>
		protected RMethod r_R__0__Fsx_Object;
		public virtual RMethod R__0__Fsx_Object
		{
			get
			{
				if(r_R__0__Fsx_Object == null)
				{
					r_R__0__Fsx_Object = new(this, "#Fsx", 0, typeof(System.Object));
					r_R__0__Fsx_Object.SetBelong(this.instance);
				}
				return r_R__0__Fsx_Object;
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


        public R__0__Ahg() : base("#u.#Ahg")
        {
        }

        public R__0__Ahg(System.Object instance) : base("#u.#Ahg")
		{
            SetInstance(instance);
		}

        public R__0__Ahg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Ahg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadFamilyWarLadderConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadFamilyWarLadderConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual FamilyWarLadderConfig __0__ahg(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__ahg_Int32.Invoke(___genericsType, ___parameters);

            return (FamilyWarLadderConfig)___result;
        }
























        public virtual void __0__thg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__thg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__uhg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__uhg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__vhg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__vhg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__whg(System.String  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = R__0__whg_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__xhg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xhg.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 __0__yhg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yhg.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void __0__zhg(GameDefineType.ID  @textID, System.String[]  @paramArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textID, @paramArray};
            var ___result = R__0__zhg_ID_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I0g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__I0g.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__95g(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__95g_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__PLg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__PLg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fsx(System.Object  @x)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x};
            var ___result = R__0__Fsx_Object.Invoke(___genericsType, ___parameters);

            
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
