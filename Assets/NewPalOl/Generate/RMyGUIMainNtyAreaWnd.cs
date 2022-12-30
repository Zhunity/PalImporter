using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MyGUIMainNtyAreaWnd
	/// </summary>
    public partial class RMyGUIMainNtyAreaWnd : RMember //
    {

		/// <summary>
		/// System.Single #a
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
		/// System.Collections.Generic.Dictionary`2[MyGUIMainNtyAreaWnd+NotifyButtonType,#oU.#uU] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> R__0__b
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
		/// System.Collections.Generic.List`1[#oU.#uU] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__oU.R__0__uU> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__oU.R__0__uU> R__0__c
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
		/// System.Int32 #d
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Int32] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> R__0__e
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
		/// System.Collections.Generic.List`1[GameDefineType.ID] #f
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__f;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__f
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
		/// System.Collections.Generic.Queue`1[#Pfb.#PCb] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__PCb> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__PCb> R__0__g
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
		/// System.Collections.Generic.Queue`1[System.Single] #h
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RField> r___0__h;
		public virtual RSystem.RCollections.RGeneric.RQueue<RField> R__0__h
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
		/// System.Collections.Generic.List`1[System.Action] #i
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RAction> r___0__i;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RAction> R__0__i
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
		/// System.Collections.Generic.List`1[System.Action] #j
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RAction> r___0__j;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RAction> R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new(this, "#j");
					r___0__j.SetBelong(this.instance);
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
		/// System.Collections.Generic.List`1[#Pfb.#Xde] #l
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__Xde> r___0__l;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__Xde> R__0__l
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
		/// #u.#IOc+#Hcd #m
		/// </summary>
		protected R__0__u.R__0__IOc.R__0__Hcd r___0__m;
		public virtual R__0__u.R__0__IOc.R__0__Hcd R__0__m
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
		/// System.Collections.Generic.List`1[System.String] #n
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__n;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__n
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
		/// System.Collections.Generic.Queue`1[#Pfb.#xBb] #o
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__xBb> r___0__o;
		public virtual RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__xBb> R__0__o
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
		/// System.Collections.Generic.List`1[#Pfb.#9jg] #p
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9jg> r___0__p;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9jg> R__0__p
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
		/// System.Collections.Generic.List`1[#Pfb.#9jg] #q
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9jg> r___0__q;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__9jg> R__0__q
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
		/// System.Collections.Generic.Queue`1[#Pfb.#jre] #r
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__jre> r___0__r;
		public virtual RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__jre> R__0__r
		{
			get
			{
				if(r___0__r == null)
				{
					r___0__r = new(this, "#r");
					r___0__r.SetBelong(this.instance);
				}
				return r___0__r;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[#Pfb.#xeh] #s
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__xeh> r___0__s;
		public virtual RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__xeh> R__0__s
		{
			get
			{
				if(r___0__s == null)
				{
					r___0__s = new(this, "#s");
					r___0__s.SetBelong(this.instance);
				}
				return r___0__s;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#Pfb.#uzw] #t
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__uzw> r___0__t;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__uzw> R__0__t
		{
			get
			{
				if(r___0__t == null)
				{
					r___0__t = new(this, "#t");
					r___0__t.SetBelong(this.instance);
				}
				return r___0__t;
			}
		}

		/// <summary>
		/// System.Comparison`1[#oU.#uU] #u
		/// </summary>
		protected static RSystem.RComparison<R__0__oU.R__0__uU> r___0__u;
		public static RSystem.RComparison<R__0__oU.R__0__uU> R__0__u
		{
			get
			{
				if(r___0__u == null)
				{
					r___0__u = new( ReleactionUtils.GetType("MyGUIMainNtyAreaWnd"), "#u");
					r___0__u.SetBelong(null);
				}
				return r___0__u;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #v
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__v;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__v
		{
			get
			{
				if(r___0__v == null)
				{
					r___0__v = new( ReleactionUtils.GetType("MyGUIMainNtyAreaWnd"), "#v");
					r___0__v.SetBelong(null);
				}
				return r___0__v;
			}
		}

		/// <summary>
		/// System.Single #y
		/// </summary>
		protected RField r___0__y;
		public virtual RField R__0__y
		{
			get
			{
				if(r___0__y == null)
				{
					r___0__y = new(this, "#y");
					r___0__y.SetBelong(this.instance);
				}
				return r___0__y;
			}
		}

		/// <summary>
		/// System.Single #z
		/// </summary>
		protected RField r___0__z;
		public virtual RField R__0__z
		{
			get
			{
				if(r___0__z == null)
				{
					r___0__z = new(this, "#z");
					r___0__z.SetBelong(this.instance);
				}
				return r___0__z;
			}
		}

		/// <summary>
		/// System.Boolean #D
		/// </summary>
		protected RField r___0__D;
		public virtual RField R__0__D
		{
			get
			{
				if(r___0__D == null)
				{
					r___0__D = new(this, "#D");
					r___0__D.SetBelong(this.instance);
				}
				return r___0__D;
			}
		}

		/// <summary>
		/// System.Boolean #F
		/// </summary>
		protected RField r___0__F;
		public virtual RField R__0__F
		{
			get
			{
				if(r___0__F == null)
				{
					r___0__F = new(this, "#F");
					r___0__F.SetBelong(this.instance);
				}
				return r___0__F;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUIWindow] #I
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUIWindow> r___0__I;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUIWindow> R__0__I
		{
			get
			{
				if(r___0__I == null)
				{
					r___0__I = new(this, "#I");
					r___0__I.SetBelong(this.instance);
				}
				return r___0__I;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #P
		/// </summary>
		protected RUnityEngine.RVector2 r___0__P;
		public virtual RUnityEngine.RVector2 R__0__P
		{
			get
			{
				if(r___0__P == null)
				{
					r___0__P = new(this, "#P");
					r___0__P.SetBelong(this.instance);
				}
				return r___0__P;
			}
		}

		/// <summary>
		/// System.Single #Q
		/// </summary>
		protected RField r___0__Q;
		public virtual RField R__0__Q
		{
			get
			{
				if(r___0__Q == null)
				{
					r___0__Q = new(this, "#Q");
					r___0__Q.SetBelong(this.instance);
				}
				return r___0__Q;
			}
		}

		/// <summary>
		/// System.Boolean #R
		/// </summary>
		protected RField r___0__R;
		public virtual RField R__0__R
		{
			get
			{
				if(r___0__R == null)
				{
					r___0__R = new(this, "#R");
					r___0__R.SetBelong(this.instance);
				}
				return r___0__R;
			}
		}

		/// <summary>
		/// System.String WindowTypeName
		/// </summary>
		protected RProperty r_R__0__rb;
		public virtual RProperty R__0__rb
		{
			get
			{
				if(r_R__0__rb == null)
				{
					r_R__0__rb = new(this, "WindowTypeName", -1);
					r_R__0__rb.SetBelong(this.instance);
				}
				return r_R__0__rb;
			}
		}

		/// <summary>
		/// Boolean IgnoreDropItemEvent
		/// </summary>
		protected RProperty r_R__0__Rf;
		public virtual RProperty R__0__Rf
		{
			get
			{
				if(r_R__0__Rf == null)
				{
					r_R__0__Rf = new(this, "IgnoreDropItemEvent", -1);
					r_R__0__Rf.SetBelong(this.instance);
				}
				return r_R__0__Rf;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin TemplateSkin
		/// </summary>
		protected RUnityEngine.RGUISkin r_R__0__1Jb;
		public virtual RUnityEngine.RGUISkin R__0__1Jb
		{
			get
			{
				if(r_R__0__1Jb == null)
				{
					r_R__0__1Jb = new(this, "TemplateSkin", -1);
					r_R__0__1Jb.SetBelong(this.instance);
				}
				return r_R__0__1Jb;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode[] DefaultHold_HotKeys
		/// </summary>
		protected RPropertyArray<RProperty> r_R__0__Q6;
		public virtual RPropertyArray<RProperty> R__0__Q6
		{
			get
			{
				if(r_R__0__Q6 == null)
				{
					r_R__0__Q6 = new(this, "DefaultHold_HotKeys", -1);
					r_R__0__Q6.SetBelong(this.instance);
				}
				return r_R__0__Q6;
			}
		}

		/// <summary>
		/// Boolean IsUpdateWhenInvisible
		/// </summary>
		protected RProperty r_R__0__3Jb;
		public virtual RProperty R__0__3Jb
		{
			get
			{
				if(r_R__0__3Jb == null)
				{
					r_R__0__3Jb = new(this, "IsUpdateWhenInvisible", -1);
					r_R__0__3Jb.SetBelong(this.instance);
				}
				return r_R__0__3Jb;
			}
		}

		/// <summary>
		/// Int32 mShowCallTime
		/// </summary>
		protected RProperty r_R__0__5Jb;
		public virtual RProperty R__0__5Jb
		{
			get
			{
				if(r_R__0__5Jb == null)
				{
					r_R__0__5Jb = new(this, "mShowCallTime", -1);
					r_R__0__5Jb.SetBelong(this.instance);
				}
				return r_R__0__5Jb;
			}
		}

		/// <summary>
		/// Boolean DrawWindowFrame
		/// </summary>
		protected RProperty r_R__0__7Jb;
		public virtual RProperty R__0__7Jb
		{
			get
			{
				if(r_R__0__7Jb == null)
				{
					r_R__0__7Jb = new(this, "DrawWindowFrame", -1);
					r_R__0__7Jb.SetBelong(this.instance);
				}
				return r_R__0__7Jb;
			}
		}

		/// <summary>
		/// Boolean UseTextureAreaHit
		/// </summary>
		protected RProperty r_R__0__9Jb;
		public virtual RProperty R__0__9Jb
		{
			get
			{
				if(r_R__0__9Jb == null)
				{
					r_R__0__9Jb = new(this, "UseTextureAreaHit", -1);
					r_R__0__9Jb.SetBelong(this.instance);
				}
				return r_R__0__9Jb;
			}
		}

		/// <summary>
		/// Boolean UseContentAreaHit
		/// </summary>
		protected RProperty r_R__0__bKb;
		public virtual RProperty R__0__bKb
		{
			get
			{
				if(r_R__0__bKb == null)
				{
					r_R__0__bKb = new(this, "UseContentAreaHit", -1);
					r_R__0__bKb.SetBelong(this.instance);
				}
				return r_R__0__bKb;
			}
		}

		/// <summary>
		/// System.String MainWindowStyleName
		/// </summary>
		protected RProperty r_R__0__ZU;
		public virtual RProperty R__0__ZU
		{
			get
			{
				if(r_R__0__ZU == null)
				{
					r_R__0__ZU = new(this, "MainWindowStyleName", -1);
					r_R__0__ZU.SetBelong(this.instance);
				}
				return r_R__0__ZU;
			}
		}

		/// <summary>
		/// Boolean CanWindowBeShowed
		/// </summary>
		protected RProperty r_R__0__vKb;
		public virtual RProperty R__0__vKb
		{
			get
			{
				if(r_R__0__vKb == null)
				{
					r_R__0__vKb = new(this, "CanWindowBeShowed", -1);
					r_R__0__vKb.SetBelong(this.instance);
				}
				return r_R__0__vKb;
			}
		}

		/// <summary>
		/// Boolean IsDragable
		/// </summary>
		protected RProperty r_R__0__GKb;
		public virtual RProperty R__0__GKb
		{
			get
			{
				if(r_R__0__GKb == null)
				{
					r_R__0__GKb = new(this, "IsDragable", -1);
					r_R__0__GKb.SetBelong(this.instance);
				}
				return r_R__0__GKb;
			}
		}

		/// <summary>
		/// Boolean IsFullScreen
		/// </summary>
		protected RProperty r_R__0__lob;
		public virtual RProperty R__0__lob
		{
			get
			{
				if(r_R__0__lob == null)
				{
					r_R__0__lob = new(this, "IsFullScreen", -1);
					r_R__0__lob.SetBelong(this.instance);
				}
				return r_R__0__lob;
			}
		}

		/// <summary>
		/// Boolean IsModelWnd
		/// </summary>
		protected RProperty r_R__0__JKb;
		public virtual RProperty R__0__JKb
		{
			get
			{
				if(r_R__0__JKb == null)
				{
					r_R__0__JKb = new(this, "IsModelWnd", -1);
					r_R__0__JKb.SetBelong(this.instance);
				}
				return r_R__0__JKb;
			}
		}

		/// <summary>
		/// Boolean IsModelExcept
		/// </summary>
		protected RProperty r_IsModelExcept;
		public virtual RProperty RIsModelExcept
		{
			get
			{
				if(r_IsModelExcept == null)
				{
					r_IsModelExcept = new(this, "IsModelExcept", -1);
					r_IsModelExcept.SetBelong(this.instance);
				}
				return r_IsModelExcept;
			}
		}

		/// <summary>
		/// #oU.#05 mMainWnd
		/// </summary>
		protected R__0__oU.R__0__05 r_R__0__KKb;
		public virtual R__0__oU.R__0__05 R__0__KKb
		{
			get
			{
				if(r_R__0__KKb == null)
				{
					r_R__0__KKb = new(this, "mMainWnd", -1);
					r_R__0__KKb.SetBelong(this.instance);
				}
				return r_R__0__KKb;
			}
		}

		/// <summary>
		/// #hLb StartPosition
		/// </summary>
		protected RProperty r_R__0__LKb;
		public virtual RProperty R__0__LKb
		{
			get
			{
				if(r_R__0__LKb == null)
				{
					r_R__0__LKb = new(this, "StartPosition", -1);
					r_R__0__LKb.SetBelong(this.instance);
				}
				return r_R__0__LKb;
			}
		}

		/// <summary>
		/// #iLb LayoutMode
		/// </summary>
		protected RProperty r_LayoutMode;
		public virtual RProperty RLayoutMode
		{
			get
			{
				if(r_LayoutMode == null)
				{
					r_LayoutMode = new(this, "LayoutMode", -1);
					r_LayoutMode.SetBelong(this.instance);
				}
				return r_LayoutMode;
			}
		}

		/// <summary>
		/// Boolean IsEnable
		/// </summary>
		protected RProperty r_R__0__NKb;
		public virtual RProperty R__0__NKb
		{
			get
			{
				if(r_R__0__NKb == null)
				{
					r_R__0__NKb = new(this, "IsEnable", -1);
					r_R__0__NKb.SetBelong(this.instance);
				}
				return r_R__0__NKb;
			}
		}

		/// <summary>
		/// MyGUI.WINDOW_LEVEL Level
		/// </summary>
		protected RProperty r_R__0__Meb;
		public virtual RProperty R__0__Meb
		{
			get
			{
				if(r_R__0__Meb == null)
				{
					r_R__0__Meb = new(this, "Level", -1);
					r_R__0__Meb.SetBelong(this.instance);
				}
				return r_R__0__Meb;
			}
		}

		/// <summary>
		/// Int32 WindowID
		/// </summary>
		protected RProperty r_R__0__Z5;
		public virtual RProperty R__0__Z5
		{
			get
			{
				if(r_R__0__Z5 == null)
				{
					r_R__0__Z5 = new(this, "WindowID", -1);
					r_R__0__Z5.SetBelong(this.instance);
				}
				return r_R__0__Z5;
			}
		}

		/// <summary>
		/// Boolean m_Animating
		/// </summary>
		protected RProperty r_R__0__SKb;
		public virtual RProperty R__0__SKb
		{
			get
			{
				if(r_R__0__SKb == null)
				{
					r_R__0__SKb = new(this, "m_Animating", -1);
					r_R__0__SKb.SetBelong(this.instance);
				}
				return r_R__0__SKb;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_R__0__WKb;
		public virtual RUnityEngine.RGameObject R__0__WKb
		{
			get
			{
				if(r_R__0__WKb == null)
				{
					r_R__0__WKb = new(this, "gameObject", -1);
					r_R__0__WKb.SetBelong(this.instance);
				}
				return r_R__0__WKb;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_R__0__YKb;
		public virtual RUnityEngine.RTransform R__0__YKb
		{
			get
			{
				if(r_R__0__YKb == null)
				{
					r_R__0__YKb = new(this, "transform", -1);
					r_R__0__YKb.SetBelong(this.instance);
				}
				return r_R__0__YKb;
			}
		}

		/// <summary>
		/// Boolean MoveIng
		/// </summary>
		protected RProperty r_R__0__8Kb;
		public virtual RProperty R__0__8Kb
		{
			get
			{
				if(r_R__0__8Kb == null)
				{
					r_R__0__8Kb = new(this, "MoveIng", -1);
					r_R__0__8Kb.SetBelong(this.instance);
				}
				return r_R__0__8Kb;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 TargetLocation
		/// </summary>
		protected RUnityEngine.RVector2 r_R__0__Hxj;
		public virtual RUnityEngine.RVector2 R__0__Hxj
		{
			get
			{
				if(r_R__0__Hxj == null)
				{
					r_R__0__Hxj = new(this, "TargetLocation", -1);
					r_R__0__Hxj.SetBelong(this.instance);
				}
				return r_R__0__Hxj;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void #Sb()
		/// </summary>
		protected RMethod r_R__0__Sb;
		public virtual RMethod R__0__Sb
		{
			get
			{
				if(r_R__0__Sb == null)
				{
					r_R__0__Sb = new(this, "#Sb", 0);
					r_R__0__Sb.SetBelong(this.instance);
				}
				return r_R__0__Sb;
			}
		}

		/// <summary>
		/// Void #Mw(NotifyButtonType)
		/// </summary>
		protected RMethod r_R__0__Mw_NotifyButtonType;
		public virtual RMethod R__0__Mw_NotifyButtonType
		{
			get
			{
				if(r_R__0__Mw_NotifyButtonType == null)
				{
					r_R__0__Mw_NotifyButtonType = new(this, "#Mw", 0,  ReleactionUtils.GetType("MyGUIMainNtyAreaWnd+NotifyButtonType"));
					r_R__0__Mw_NotifyButtonType.SetBelong(this.instance);
				}
				return r_R__0__Mw_NotifyButtonType;
			}
		}

		/// <summary>
		/// Void #Mw(NotifyButtonType, System.Object)
		/// </summary>
		protected RMethod r_R__0__Mw_NotifyButtonType_Object;
		public virtual RMethod R__0__Mw_NotifyButtonType_Object
		{
			get
			{
				if(r_R__0__Mw_NotifyButtonType_Object == null)
				{
					r_R__0__Mw_NotifyButtonType_Object = new(this, "#Mw", 0,  ReleactionUtils.GetType("MyGUIMainNtyAreaWnd+NotifyButtonType"), typeof(System.Object));
					r_R__0__Mw_NotifyButtonType_Object.SetBelong(this.instance);
				}
				return r_R__0__Mw_NotifyButtonType_Object;
			}
		}

		/// <summary>
		/// Void #Nw(NotifyButtonType)
		/// </summary>
		protected RMethod r_R__0__Nw_NotifyButtonType;
		public virtual RMethod R__0__Nw_NotifyButtonType
		{
			get
			{
				if(r_R__0__Nw_NotifyButtonType == null)
				{
					r_R__0__Nw_NotifyButtonType = new(this, "#Nw", 0,  ReleactionUtils.GetType("MyGUIMainNtyAreaWnd+NotifyButtonType"));
					r_R__0__Nw_NotifyButtonType.SetBelong(this.instance);
				}
				return r_R__0__Nw_NotifyButtonType;
			}
		}

		/// <summary>
		/// Void #Ow(System.Collections.Generic.List`1[#oU.#uU])
		/// </summary>
		protected RMethod r_R__0__Ow_List_d___0__uU_p_;
		public virtual RMethod R__0__Ow_List_d___0__uU_p_
		{
			get
			{
				if(r_R__0__Ow_List_d___0__uU_p_ == null)
				{
					r_R__0__Ow_List_d___0__uU_p_ = new(this, "#Ow", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#oU.#uU")));
					r_R__0__Ow_List_d___0__uU_p_.SetBelong(this.instance);
				}
				return r_R__0__Ow_List_d___0__uU_p_;
			}
		}

		/// <summary>
		/// Void #oq(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__oq_Object_EventArgs;
		public virtual RMethod R__0__oq_Object_EventArgs
		{
			get
			{
				if(r_R__0__oq_Object_EventArgs == null)
				{
					r_R__0__oq_Object_EventArgs = new(this, "#oq", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__oq_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__oq_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #Pw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Pw_Object___0__7X;
		public virtual RMethod R__0__Pw_Object___0__7X
		{
			get
			{
				if(r_R__0__Pw_Object___0__7X == null)
				{
					r_R__0__Pw_Object___0__7X = new(this, "#Pw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Pw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Pw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #H4g(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__H4g_Object___0__7X;
		public virtual RMethod R__0__H4g_Object___0__7X
		{
			get
			{
				if(r_R__0__H4g_Object___0__7X == null)
				{
					r_R__0__H4g_Object___0__7X = new(this, "#H4g", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__H4g_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__H4g_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Rw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Rw_Object___0__7X;
		public virtual RMethod R__0__Rw_Object___0__7X
		{
			get
			{
				if(r_R__0__Rw_Object___0__7X == null)
				{
					r_R__0__Rw_Object___0__7X = new(this, "#Rw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Rw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Rw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Ht(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ht_Object___0__7X;
		public virtual RMethod R__0__Ht_Object___0__7X
		{
			get
			{
				if(r_R__0__Ht_Object___0__7X == null)
				{
					r_R__0__Ht_Object___0__7X = new(this, "#Ht", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ht_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ht_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Sw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Sw_Object___0__7X;
		public virtual RMethod R__0__Sw_Object___0__7X
		{
			get
			{
				if(r_R__0__Sw_Object___0__7X == null)
				{
					r_R__0__Sw_Object___0__7X = new(this, "#Sw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Sw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Sw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #D1e(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__D1e_Object___0__7X;
		public virtual RMethod R__0__D1e_Object___0__7X
		{
			get
			{
				if(r_R__0__D1e_Object___0__7X == null)
				{
					r_R__0__D1e_Object___0__7X = new(this, "#D1e", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__D1e_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__D1e_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Tw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Tw_Object___0__7X;
		public virtual RMethod R__0__Tw_Object___0__7X
		{
			get
			{
				if(r_R__0__Tw_Object___0__7X == null)
				{
					r_R__0__Tw_Object___0__7X = new(this, "#Tw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Tw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Tw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Uw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Uw_Object___0__7X;
		public virtual RMethod R__0__Uw_Object___0__7X
		{
			get
			{
				if(r_R__0__Uw_Object___0__7X == null)
				{
					r_R__0__Uw_Object___0__7X = new(this, "#Uw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Uw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Uw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Ww(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ww_Object___0__7X;
		public virtual RMethod R__0__Ww_Object___0__7X
		{
			get
			{
				if(r_R__0__Ww_Object___0__7X == null)
				{
					r_R__0__Ww_Object___0__7X = new(this, "#Ww", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ww_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ww_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #TVb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__TVb_Object___0__7X;
		public virtual RMethod R__0__TVb_Object___0__7X
		{
			get
			{
				if(r_R__0__TVb_Object___0__7X == null)
				{
					r_R__0__TVb_Object___0__7X = new(this, "#TVb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__TVb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__TVb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #u0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__u0d_Object___0__7X;
		public virtual RMethod R__0__u0d_Object___0__7X
		{
			get
			{
				if(r_R__0__u0d_Object___0__7X == null)
				{
					r_R__0__u0d_Object___0__7X = new(this, "#u0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__u0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__u0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Yw(System.Action)
		/// </summary>
		protected RMethod r_R__0__Yw_Action;
		public virtual RMethod R__0__Yw_Action
		{
			get
			{
				if(r_R__0__Yw_Action == null)
				{
					r_R__0__Yw_Action = new(this, "#Yw", 0, typeof(System.Action));
					r_R__0__Yw_Action.SetBelong(this.instance);
				}
				return r_R__0__Yw_Action;
			}
		}

		/// <summary>
		/// Void #E1e()
		/// </summary>
		protected RMethod r_R__0__E1e;
		public virtual RMethod R__0__E1e
		{
			get
			{
				if(r_R__0__E1e == null)
				{
					r_R__0__E1e = new(this, "#E1e", 0);
					r_R__0__E1e.SetBelong(this.instance);
				}
				return r_R__0__E1e;
			}
		}

		/// <summary>
		/// Void #F1e()
		/// </summary>
		protected RMethod r_R__0__F1e;
		public virtual RMethod R__0__F1e
		{
			get
			{
				if(r_R__0__F1e == null)
				{
					r_R__0__F1e = new(this, "#F1e", 0);
					r_R__0__F1e.SetBelong(this.instance);
				}
				return r_R__0__F1e;
			}
		}

		/// <summary>
		/// Void #Zw(System.Action)
		/// </summary>
		protected RMethod r_R__0__Zw_Action;
		public virtual RMethod R__0__Zw_Action
		{
			get
			{
				if(r_R__0__Zw_Action == null)
				{
					r_R__0__Zw_Action = new(this, "#Zw", 0, typeof(System.Action));
					r_R__0__Zw_Action.SetBelong(this.instance);
				}
				return r_R__0__Zw_Action;
			}
		}

		/// <summary>
		/// Void #I4g()
		/// </summary>
		protected RMethod r_R__0__I4g;
		public virtual RMethod R__0__I4g
		{
			get
			{
				if(r_R__0__I4g == null)
				{
					r_R__0__I4g = new(this, "#I4g", 0);
					r_R__0__I4g.SetBelong(this.instance);
				}
				return r_R__0__I4g;
			}
		}

		/// <summary>
		/// Void #J4g()
		/// </summary>
		protected RMethod r_R__0__J4g;
		public virtual RMethod R__0__J4g
		{
			get
			{
				if(r_R__0__J4g == null)
				{
					r_R__0__J4g = new(this, "#J4g", 0);
					r_R__0__J4g.SetBelong(this.instance);
				}
				return r_R__0__J4g;
			}
		}

		/// <summary>
		/// Void #0w(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__0w_ID;
		public virtual RMethod R__0__0w_ID
		{
			get
			{
				if(r_R__0__0w_ID == null)
				{
					r_R__0__0w_ID = new(this, "#0w", 0, typeof(GameDefineType.ID));
					r_R__0__0w_ID.SetBelong(this.instance);
				}
				return r_R__0__0w_ID;
			}
		}

		/// <summary>
		/// Void #1w()
		/// </summary>
		protected RMethod r_R__0__1w;
		public virtual RMethod R__0__1w
		{
			get
			{
				if(r_R__0__1w == null)
				{
					r_R__0__1w = new(this, "#1w", 0);
					r_R__0__1w.SetBelong(this.instance);
				}
				return r_R__0__1w;
			}
		}

		/// <summary>
		/// Void #2w()
		/// </summary>
		protected RMethod r_R__0__2w;
		public virtual RMethod R__0__2w
		{
			get
			{
				if(r_R__0__2w == null)
				{
					r_R__0__2w = new(this, "#2w", 0);
					r_R__0__2w.SetBelong(this.instance);
				}
				return r_R__0__2w;
			}
		}

		/// <summary>
		/// Void #3w()
		/// </summary>
		protected RMethod r_R__0__3w;
		public virtual RMethod R__0__3w
		{
			get
			{
				if(r_R__0__3w == null)
				{
					r_R__0__3w = new(this, "#3w", 0);
					r_R__0__3w.SetBelong(this.instance);
				}
				return r_R__0__3w;
			}
		}

		/// <summary>
		/// Void #4w()
		/// </summary>
		protected RMethod r_R__0__4w;
		public virtual RMethod R__0__4w
		{
			get
			{
				if(r_R__0__4w == null)
				{
					r_R__0__4w = new(this, "#4w", 0);
					r_R__0__4w.SetBelong(this.instance);
				}
				return r_R__0__4w;
			}
		}

		/// <summary>
		/// Void #6w()
		/// </summary>
		protected RMethod r_R__0__6w;
		public virtual RMethod R__0__6w
		{
			get
			{
				if(r_R__0__6w == null)
				{
					r_R__0__6w = new(this, "#6w", 0);
					r_R__0__6w.SetBelong(this.instance);
				}
				return r_R__0__6w;
			}
		}

		/// <summary>
		/// Void #7w()
		/// </summary>
		protected RMethod r_R__0__7w;
		public virtual RMethod R__0__7w
		{
			get
			{
				if(r_R__0__7w == null)
				{
					r_R__0__7w = new(this, "#7w", 0);
					r_R__0__7w.SetBelong(this.instance);
				}
				return r_R__0__7w;
			}
		}

		/// <summary>
		/// Void #UVb()
		/// </summary>
		protected RMethod r_R__0__UVb;
		public virtual RMethod R__0__UVb
		{
			get
			{
				if(r_R__0__UVb == null)
				{
					r_R__0__UVb = new(this, "#UVb", 0);
					r_R__0__UVb.SetBelong(this.instance);
				}
				return r_R__0__UVb;
			}
		}

		/// <summary>
		/// Void #VVb()
		/// </summary>
		protected RMethod r_R__0__VVb;
		public virtual RMethod R__0__VVb
		{
			get
			{
				if(r_R__0__VVb == null)
				{
					r_R__0__VVb = new(this, "#VVb", 0);
					r_R__0__VVb.SetBelong(this.instance);
				}
				return r_R__0__VVb;
			}
		}

		/// <summary>
		/// Void #v0d()
		/// </summary>
		protected RMethod r_R__0__v0d;
		public virtual RMethod R__0__v0d
		{
			get
			{
				if(r_R__0__v0d == null)
				{
					r_R__0__v0d = new(this, "#v0d", 0);
					r_R__0__v0d.SetBelong(this.instance);
				}
				return r_R__0__v0d;
			}
		}

		/// <summary>
		/// Void #w0d()
		/// </summary>
		protected RMethod r_R__0__w0d;
		public virtual RMethod R__0__w0d
		{
			get
			{
				if(r_R__0__w0d == null)
				{
					r_R__0__w0d = new(this, "#w0d", 0);
					r_R__0__w0d.SetBelong(this.instance);
				}
				return r_R__0__w0d;
			}
		}

		/// <summary>
		/// Void #x0d(#Pfb.#Xde)
		/// </summary>
		protected RMethod r_R__0__x0d___0__Xde;
		public virtual RMethod R__0__x0d___0__Xde
		{
			get
			{
				if(r_R__0__x0d___0__Xde == null)
				{
					r_R__0__x0d___0__Xde = new(this, "#x0d", 0,  ReleactionUtils.GetType("#Pfb.#Xde"));
					r_R__0__x0d___0__Xde.SetBelong(this.instance);
				}
				return r_R__0__x0d___0__Xde;
			}
		}

		/// <summary>
		/// Void #y0d(System.String)
		/// </summary>
		protected RMethod r_R__0__y0d_String;
		public virtual RMethod R__0__y0d_String
		{
			get
			{
				if(r_R__0__y0d_String == null)
				{
					r_R__0__y0d_String = new(this, "#y0d", 0, typeof(System.String));
					r_R__0__y0d_String.SetBelong(this.instance);
				}
				return r_R__0__y0d_String;
			}
		}

		/// <summary>
		/// Void #z0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__z0d_Object___0__7X;
		public virtual RMethod R__0__z0d_Object___0__7X
		{
			get
			{
				if(r_R__0__z0d_Object___0__7X == null)
				{
					r_R__0__z0d_Object___0__7X = new(this, "#z0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__z0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__z0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #sb(Boolean)
		/// </summary>
		protected RMethod r_R__0__sb_Boolean;
		public virtual RMethod R__0__sb_Boolean
		{
			get
			{
				if(r_R__0__sb_Boolean == null)
				{
					r_R__0__sb_Boolean = new(this, "#sb", 0, typeof(System.Boolean));
					r_R__0__sb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__sb_Boolean;
			}
		}

		/// <summary>
		/// Void Resize()
		/// </summary>
		protected RMethod r_RResize;
		public virtual RMethod RResize
		{
			get
			{
				if(r_RResize == null)
				{
					r_RResize = new(this, "Resize", 0);
					r_RResize.SetBelong(this.instance);
				}
				return r_RResize;
			}
		}

		/// <summary>
		/// Void #8w(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__8w_Object___0__7X;
		public virtual RMethod R__0__8w_Object___0__7X
		{
			get
			{
				if(r_R__0__8w_Object___0__7X == null)
				{
					r_R__0__8w_Object___0__7X = new(this, "#8w", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__8w_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__8w_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #9w(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_R__0__9w_List_d_String_p_;
		public virtual RMethod R__0__9w_List_d_String_p_
		{
			get
			{
				if(r_R__0__9w_List_d_String_p_ == null)
				{
					r_R__0__9w_List_d_String_p_ = new(this, "#9w", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_R__0__9w_List_d_String_p_.SetBelong(this.instance);
				}
				return r_R__0__9w_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void #ax(System.Object)
		/// </summary>
		protected RMethod r_R__0__ax_Object;
		public virtual RMethod R__0__ax_Object
		{
			get
			{
				if(r_R__0__ax_Object == null)
				{
					r_R__0__ax_Object = new(this, "#ax", 0, typeof(System.Object));
					r_R__0__ax_Object.SetBelong(this.instance);
				}
				return r_R__0__ax_Object;
			}
		}

		/// <summary>
		/// Void #h9e(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__h9e_Object___0__7X;
		public virtual RMethod R__0__h9e_Object___0__7X
		{
			get
			{
				if(r_R__0__h9e_Object___0__7X == null)
				{
					r_R__0__h9e_Object___0__7X = new(this, "#h9e", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__h9e_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__h9e_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #i9e(#Pfb.#xBb)
		/// </summary>
		protected RMethod r_R__0__i9e___0__xBb;
		public virtual RMethod R__0__i9e___0__xBb
		{
			get
			{
				if(r_R__0__i9e___0__xBb == null)
				{
					r_R__0__i9e___0__xBb = new(this, "#i9e", 0,  ReleactionUtils.GetType("#Pfb.#xBb"));
					r_R__0__i9e___0__xBb.SetBelong(this.instance);
				}
				return r_R__0__i9e___0__xBb;
			}
		}

		/// <summary>
		/// Void #tG(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tG_Object___0__7X;
		public virtual RMethod R__0__tG_Object___0__7X
		{
			get
			{
				if(r_R__0__tG_Object___0__7X == null)
				{
					r_R__0__tG_Object___0__7X = new(this, "#tG", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tG_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tG_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #zuf()
		/// </summary>
		protected RMethod r_R__0__zuf;
		public virtual RMethod R__0__zuf
		{
			get
			{
				if(r_R__0__zuf == null)
				{
					r_R__0__zuf = new(this, "#zuf", 0);
					r_R__0__zuf.SetBelong(this.instance);
				}
				return r_R__0__zuf;
			}
		}

		/// <summary>
		/// Void #Nbg(#Pfb.#9jg)
		/// </summary>
		protected RMethod r_R__0__Nbg___0__9jg;
		public virtual RMethod R__0__Nbg___0__9jg
		{
			get
			{
				if(r_R__0__Nbg___0__9jg == null)
				{
					r_R__0__Nbg___0__9jg = new(this, "#Nbg", 0,  ReleactionUtils.GetType("#Pfb.#9jg"));
					r_R__0__Nbg___0__9jg.SetBelong(this.instance);
				}
				return r_R__0__Nbg___0__9jg;
			}
		}

		/// <summary>
		/// Void #Obg(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Obg_Object___0__7X;
		public virtual RMethod R__0__Obg_Object___0__7X
		{
			get
			{
				if(r_R__0__Obg_Object___0__7X == null)
				{
					r_R__0__Obg_Object___0__7X = new(this, "#Obg", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Obg_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Obg_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #7li()
		/// </summary>
		protected RMethod r_R__0__7li;
		public virtual RMethod R__0__7li
		{
			get
			{
				if(r_R__0__7li == null)
				{
					r_R__0__7li = new(this, "#7li", 0);
					r_R__0__7li.SetBelong(this.instance);
				}
				return r_R__0__7li;
			}
		}

		/// <summary>
		/// Void #8li()
		/// </summary>
		protected RMethod r_R__0__8li;
		public virtual RMethod R__0__8li
		{
			get
			{
				if(r_R__0__8li == null)
				{
					r_R__0__8li = new(this, "#8li", 0);
					r_R__0__8li.SetBelong(this.instance);
				}
				return r_R__0__8li;
			}
		}

		/// <summary>
		/// Void #9li()
		/// </summary>
		protected RMethod r_R__0__9li;
		public virtual RMethod R__0__9li
		{
			get
			{
				if(r_R__0__9li == null)
				{
					r_R__0__9li = new(this, "#9li", 0);
					r_R__0__9li.SetBelong(this.instance);
				}
				return r_R__0__9li;
			}
		}

		/// <summary>
		/// Void #ami()
		/// </summary>
		protected RMethod r_R__0__ami;
		public virtual RMethod R__0__ami
		{
			get
			{
				if(r_R__0__ami == null)
				{
					r_R__0__ami = new(this, "#ami", 0);
					r_R__0__ami.SetBelong(this.instance);
				}
				return r_R__0__ami;
			}
		}

		/// <summary>
		/// Void #pZg(#Pfb.#jre)
		/// </summary>
		protected RMethod r_R__0__pZg___0__jre;
		public virtual RMethod R__0__pZg___0__jre
		{
			get
			{
				if(r_R__0__pZg___0__jre == null)
				{
					r_R__0__pZg___0__jre = new(this, "#pZg", 0,  ReleactionUtils.GetType("#Pfb.#jre"));
					r_R__0__pZg___0__jre.SetBelong(this.instance);
				}
				return r_R__0__pZg___0__jre;
			}
		}

		/// <summary>
		/// Void #x6d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__x6d_Object___0__7X;
		public virtual RMethod R__0__x6d_Object___0__7X
		{
			get
			{
				if(r_R__0__x6d_Object___0__7X == null)
				{
					r_R__0__x6d_Object___0__7X = new(this, "#x6d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__x6d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__x6d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #qZg(System.Object)
		/// </summary>
		protected RMethod r_R__0__qZg_Object;
		public virtual RMethod R__0__qZg_Object
		{
			get
			{
				if(r_R__0__qZg_Object == null)
				{
					r_R__0__qZg_Object = new(this, "#qZg", 0, typeof(System.Object));
					r_R__0__qZg_Object.SetBelong(this.instance);
				}
				return r_R__0__qZg_Object;
			}
		}

		/// <summary>
		/// Void #Kah(#Pfb.#yeh)
		/// </summary>
		protected RMethod r_R__0__Kah___0__yeh;
		public virtual RMethod R__0__Kah___0__yeh
		{
			get
			{
				if(r_R__0__Kah___0__yeh == null)
				{
					r_R__0__Kah___0__yeh = new(this, "#Kah", 0,  ReleactionUtils.GetType("#Pfb.#yeh"));
					r_R__0__Kah___0__yeh.SetBelong(this.instance);
				}
				return r_R__0__Kah___0__yeh;
			}
		}

		/// <summary>
		/// Void #Lah(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Lah_Object___0__7X;
		public virtual RMethod R__0__Lah_Object___0__7X
		{
			get
			{
				if(r_R__0__Lah_Object___0__7X == null)
				{
					r_R__0__Lah_Object___0__7X = new(this, "#Lah", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Lah_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Lah_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #ack()
		/// </summary>
		protected RMethod r_R__0__ack;
		public virtual RMethod R__0__ack
		{
			get
			{
				if(r_R__0__ack == null)
				{
					r_R__0__ack = new(this, "#ack", 0);
					r_R__0__ack.SetBelong(this.instance);
				}
				return r_R__0__ack;
			}
		}

		/// <summary>
		/// Void #bck(System.Object)
		/// </summary>
		protected RMethod r_R__0__bck_Object;
		public virtual RMethod R__0__bck_Object
		{
			get
			{
				if(r_R__0__bck_Object == null)
				{
					r_R__0__bck_Object = new(this, "#bck", 0, typeof(System.Object));
					r_R__0__bck_Object.SetBelong(this.instance);
				}
				return r_R__0__bck_Object;
			}
		}

		/// <summary>
		/// Void #cck(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cck_Object___0__7X;
		public virtual RMethod R__0__cck_Object___0__7X
		{
			get
			{
				if(r_R__0__cck_Object___0__7X == null)
				{
					r_R__0__cck_Object___0__7X = new(this, "#cck", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cck_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cck_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #efk()
		/// </summary>
		protected RMethod r_R__0__efk;
		public virtual RMethod R__0__efk
		{
			get
			{
				if(r_R__0__efk == null)
				{
					r_R__0__efk = new(this, "#efk", 0);
					r_R__0__efk.SetBelong(this.instance);
				}
				return r_R__0__efk;
			}
		}

		/// <summary>
		/// Void #Exw(#Pfb.#uzw)
		/// </summary>
		protected RMethod r_R__0__Exw___0__uzw;
		public virtual RMethod R__0__Exw___0__uzw
		{
			get
			{
				if(r_R__0__Exw___0__uzw == null)
				{
					r_R__0__Exw___0__uzw = new(this, "#Exw", 0,  ReleactionUtils.GetType("#Pfb.#uzw"));
					r_R__0__Exw___0__uzw.SetBelong(this.instance);
				}
				return r_R__0__Exw___0__uzw;
			}
		}

		/// <summary>
		/// Void #Fxw(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Fxw_ID;
		public virtual RMethod R__0__Fxw_ID
		{
			get
			{
				if(r_R__0__Fxw_ID == null)
				{
					r_R__0__Fxw_ID = new(this, "#Fxw", 0, typeof(GameDefineType.ID));
					r_R__0__Fxw_ID.SetBelong(this.instance);
				}
				return r_R__0__Fxw_ID;
			}
		}

		/// <summary>
		/// Void #Gxw(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Gxw_Object___0__7X;
		public virtual RMethod R__0__Gxw_Object___0__7X
		{
			get
			{
				if(r_R__0__Gxw_Object___0__7X == null)
				{
					r_R__0__Gxw_Object___0__7X = new(this, "#Gxw", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Gxw_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Gxw_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Hxw(System.Object)
		/// </summary>
		protected RMethod r_R__0__Hxw_Object;
		public virtual RMethod R__0__Hxw_Object
		{
			get
			{
				if(r_R__0__Hxw_Object == null)
				{
					r_R__0__Hxw_Object = new(this, "#Hxw", 0, typeof(System.Object));
					r_R__0__Hxw_Object.SetBelong(this.instance);
				}
				return r_R__0__Hxw_Object;
			}
		}

		/// <summary>
		/// Void #Ixw(System.Object)
		/// </summary>
		protected RMethod r_R__0__Ixw_Object;
		public virtual RMethod R__0__Ixw_Object
		{
			get
			{
				if(r_R__0__Ixw_Object == null)
				{
					r_R__0__Ixw_Object = new(this, "#Ixw", 0, typeof(System.Object));
					r_R__0__Ixw_Object.SetBelong(this.instance);
				}
				return r_R__0__Ixw_Object;
			}
		}

		/// <summary>
		/// Int32 #bex(#oU.#uU, #oU.#uU)
		/// </summary>
		protected static RMethod r_R__0__bex___0__uU___0__uU;
		public static RMethod R__0__bex___0__uU___0__uU
		{
			get
			{
				if(r_R__0__bex___0__uU___0__uU == null)
				{
					r_R__0__bex___0__uU___0__uU = new( ReleactionUtils.GetType("MyGUIMainNtyAreaWnd"), "#bex", 0,  ReleactionUtils.GetType("#oU.#uU"),  ReleactionUtils.GetType("#oU.#uU"));
					r_R__0__bex___0__uU___0__uU.SetBelong(null);
				}
				return r_R__0__bex___0__uU___0__uU;
			}
		}

		/// <summary>
		/// Void #dKb(Single)
		/// </summary>
		protected RMethod r_R__0__dKb_Single;
		public virtual RMethod R__0__dKb_Single
		{
			get
			{
				if(r_R__0__dKb_Single == null)
				{
					r_R__0__dKb_Single = new(this, "#dKb", 0, typeof(System.Single));
					r_R__0__dKb_Single.SetBelong(this.instance);
				}
				return r_R__0__dKb_Single;
			}
		}

		/// <summary>
		/// Void #eKb(Single)
		/// </summary>
		protected RMethod r_R__0__eKb_Single;
		public virtual RMethod R__0__eKb_Single
		{
			get
			{
				if(r_R__0__eKb_Single == null)
				{
					r_R__0__eKb_Single = new(this, "#eKb", 0, typeof(System.Single));
					r_R__0__eKb_Single.SetBelong(this.instance);
				}
				return r_R__0__eKb_Single;
			}
		}

		/// <summary>
		/// Void #fKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__fKb_Vector2;
		public virtual RMethod R__0__fKb_Vector2
		{
			get
			{
				if(r_R__0__fKb_Vector2 == null)
				{
					r_R__0__fKb_Vector2 = new(this, "#fKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__fKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__fKb_Vector2;
			}
		}

		/// <summary>
		/// Void #gKb()
		/// </summary>
		protected RMethod r_R__0__gKb;
		public virtual RMethod R__0__gKb
		{
			get
			{
				if(r_R__0__gKb == null)
				{
					r_R__0__gKb = new(this, "#gKb", 0);
					r_R__0__gKb.SetBelong(this.instance);
				}
				return r_R__0__gKb;
			}
		}

		/// <summary>
		/// Void #EF()
		/// </summary>
		protected RMethod r_R__0__EF;
		public virtual RMethod R__0__EF
		{
			get
			{
				if(r_R__0__EF == null)
				{
					r_R__0__EF = new(this, "#EF", 0);
					r_R__0__EF.SetBelong(this.instance);
				}
				return r_R__0__EF;
			}
		}

		/// <summary>
		/// Void #hKb(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__hKb_Vector2_Vector2;
		public virtual RMethod R__0__hKb_Vector2_Vector2
		{
			get
			{
				if(r_R__0__hKb_Vector2_Vector2 == null)
				{
					r_R__0__hKb_Vector2_Vector2 = new(this, "#hKb", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_R__0__hKb_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_R__0__hKb_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Boolean #u1b(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__u1b_Vector2;
		public virtual RMethod R__0__u1b_Vector2
		{
			get
			{
				if(r_R__0__u1b_Vector2 == null)
				{
					r_R__0__u1b_Vector2 = new(this, "#u1b", 0, typeof(UnityEngine.Vector2));
					r_R__0__u1b_Vector2.SetBelong(this.instance);
				}
				return r_R__0__u1b_Vector2;
			}
		}

		/// <summary>
		/// Void #iKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__iKb_Vector2;
		public virtual RMethod R__0__iKb_Vector2
		{
			get
			{
				if(r_R__0__iKb_Vector2 == null)
				{
					r_R__0__iKb_Vector2 = new(this, "#iKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__iKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__iKb_Vector2;
			}
		}

		/// <summary>
		/// Void #jKb()
		/// </summary>
		protected RMethod r_R__0__jKb;
		public virtual RMethod R__0__jKb
		{
			get
			{
				if(r_R__0__jKb == null)
				{
					r_R__0__jKb = new(this, "#jKb", 0);
					r_R__0__jKb.SetBelong(this.instance);
				}
				return r_R__0__jKb;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Boolean #pq()
		/// </summary>
		protected RMethod r_R__0__pq;
		public virtual RMethod R__0__pq
		{
			get
			{
				if(r_R__0__pq == null)
				{
					r_R__0__pq = new(this, "#pq", 0);
					r_R__0__pq.SetBelong(this.instance);
				}
				return r_R__0__pq;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #kKb(System.String)
		/// </summary>
		protected RMethod r_R__0__kKb_String;
		public virtual RMethod R__0__kKb_String
		{
			get
			{
				if(r_R__0__kKb_String == null)
				{
					r_R__0__kKb_String = new(this, "#kKb", 0, typeof(System.String));
					r_R__0__kKb_String.SetBelong(this.instance);
				}
				return r_R__0__kKb_String;
			}
		}

		/// <summary>
		/// #bk #kKb[#bk](System.String)
		/// </summary>
		protected RMethod r_R__0__kKb_G__0__bk_String;
		public virtual RMethod R__0__kKb_G__0__bk_String
		{
			get
			{
				if(r_R__0__kKb_G__0__bk_String == null)
				{
					r_R__0__kKb_G__0__bk_String = new(this, "#kKb", 1, typeof(System.String));
					r_R__0__kKb_G__0__bk_String.SetBelong(this.instance);
				}
				return r_R__0__kKb_G__0__bk_String;
			}
		}

		/// <summary>
		/// Void #lKb()
		/// </summary>
		protected RMethod r_R__0__lKb;
		public virtual RMethod R__0__lKb
		{
			get
			{
				if(r_R__0__lKb == null)
				{
					r_R__0__lKb = new(this, "#lKb", 0);
					r_R__0__lKb.SetBelong(this.instance);
				}
				return r_R__0__lKb;
			}
		}

		/// <summary>
		/// Void #Ibb()
		/// </summary>
		protected RMethod r_R__0__Ibb;
		public virtual RMethod R__0__Ibb
		{
			get
			{
				if(r_R__0__Ibb == null)
				{
					r_R__0__Ibb = new(this, "#Ibb", 0);
					r_R__0__Ibb.SetBelong(this.instance);
				}
				return r_R__0__Ibb;
			}
		}

		/// <summary>
		/// Void #mKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__mKb_Boolean;
		public virtual RMethod R__0__mKb_Boolean
		{
			get
			{
				if(r_R__0__mKb_Boolean == null)
				{
					r_R__0__mKb_Boolean = new(this, "#mKb", 0, typeof(System.Boolean));
					r_R__0__mKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__mKb_Boolean;
			}
		}

		/// <summary>
		/// Void #nKb()
		/// </summary>
		protected RMethod r_R__0__nKb;
		public virtual RMethod R__0__nKb
		{
			get
			{
				if(r_R__0__nKb == null)
				{
					r_R__0__nKb = new(this, "#nKb", 0);
					r_R__0__nKb.SetBelong(this.instance);
				}
				return r_R__0__nKb;
			}
		}

		/// <summary>
		/// Void #Mr(Boolean)
		/// </summary>
		protected RMethod r_R__0__Mr_Boolean;
		public virtual RMethod R__0__Mr_Boolean
		{
			get
			{
				if(r_R__0__Mr_Boolean == null)
				{
					r_R__0__Mr_Boolean = new(this, "#Mr", 0, typeof(System.Boolean));
					r_R__0__Mr_Boolean.SetBelong(this.instance);
				}
				return r_R__0__Mr_Boolean;
			}
		}

		/// <summary>
		/// Void #rKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__rKb_Boolean;
		public virtual RMethod R__0__rKb_Boolean
		{
			get
			{
				if(r_R__0__rKb_Boolean == null)
				{
					r_R__0__rKb_Boolean = new(this, "#rKb", 0, typeof(System.Boolean));
					r_R__0__rKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__rKb_Boolean;
			}
		}

		/// <summary>
		/// Void #tKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__tKb_Boolean;
		public virtual RMethod R__0__tKb_Boolean
		{
			get
			{
				if(r_R__0__tKb_Boolean == null)
				{
					r_R__0__tKb_Boolean = new(this, "#tKb", 0, typeof(System.Boolean));
					r_R__0__tKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__tKb_Boolean;
			}
		}

		/// <summary>
		/// Void #uKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__uKb_Boolean;
		public virtual RMethod R__0__uKb_Boolean
		{
			get
			{
				if(r_R__0__uKb_Boolean == null)
				{
					r_R__0__uKb_Boolean = new(this, "#uKb", 0, typeof(System.Boolean));
					r_R__0__uKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__uKb_Boolean;
			}
		}

		/// <summary>
		/// Boolean #bN()
		/// </summary>
		protected RMethod r_R__0__bN;
		public virtual RMethod R__0__bN
		{
			get
			{
				if(r_R__0__bN == null)
				{
					r_R__0__bN = new(this, "#bN", 0);
					r_R__0__bN.SetBelong(this.instance);
				}
				return r_R__0__bN;
			}
		}

		/// <summary>
		/// Boolean #wKb()
		/// </summary>
		protected RMethod r_R__0__wKb;
		public virtual RMethod R__0__wKb
		{
			get
			{
				if(r_R__0__wKb == null)
				{
					r_R__0__wKb = new(this, "#wKb", 0);
					r_R__0__wKb.SetBelong(this.instance);
				}
				return r_R__0__wKb;
			}
		}

		/// <summary>
		/// Boolean #xKb()
		/// </summary>
		protected RMethod r_R__0__xKb;
		public virtual RMethod R__0__xKb
		{
			get
			{
				if(r_R__0__xKb == null)
				{
					r_R__0__xKb = new(this, "#xKb", 0);
					r_R__0__xKb.SetBelong(this.instance);
				}
				return r_R__0__xKb;
			}
		}

		/// <summary>
		/// Boolean #yKb()
		/// </summary>
		protected RMethod r_R__0__yKb;
		public virtual RMethod R__0__yKb
		{
			get
			{
				if(r_R__0__yKb == null)
				{
					r_R__0__yKb = new(this, "#yKb", 0);
					r_R__0__yKb.SetBelong(this.instance);
				}
				return r_R__0__yKb;
			}
		}

		/// <summary>
		/// Boolean #zKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__zKb_Vector2;
		public virtual RMethod R__0__zKb_Vector2
		{
			get
			{
				if(r_R__0__zKb_Vector2 == null)
				{
					r_R__0__zKb_Vector2 = new(this, "#zKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__zKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__zKb_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #uo()
		/// </summary>
		protected RMethod r_R__0__uo;
		public virtual RMethod R__0__uo
		{
			get
			{
				if(r_R__0__uo == null)
				{
					r_R__0__uo = new(this, "#uo", 0);
					r_R__0__uo.SetBelong(this.instance);
				}
				return r_R__0__uo;
			}
		}

		/// <summary>
		/// Void #gw(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__gw_Vector2;
		public virtual RMethod R__0__gw_Vector2
		{
			get
			{
				if(r_R__0__gw_Vector2 == null)
				{
					r_R__0__gw_Vector2 = new(this, "#gw", 0, typeof(UnityEngine.Vector2));
					r_R__0__gw_Vector2.SetBelong(this.instance);
				}
				return r_R__0__gw_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetWindowLocation()
		/// </summary>
		protected RMethod r_RGetWindowLocation;
		public virtual RMethod RGetWindowLocation
		{
			get
			{
				if(r_RGetWindowLocation == null)
				{
					r_RGetWindowLocation = new(this, "GetWindowLocation", 0);
					r_RGetWindowLocation.SetBelong(this.instance);
				}
				return r_RGetWindowLocation;
			}
		}

		/// <summary>
		/// Void #AKb(System.String, UIeffect)
		/// </summary>
		protected RMethod r_R__0__AKb_String_UIeffect;
		public virtual RMethod R__0__AKb_String_UIeffect
		{
			get
			{
				if(r_R__0__AKb_String_UIeffect == null)
				{
					r_R__0__AKb_String_UIeffect = new(this, "#AKb", 0, typeof(System.String), typeof(UIeffect));
					r_R__0__AKb_String_UIeffect.SetBelong(this.instance);
				}
				return r_R__0__AKb_String_UIeffect;
			}
		}

		/// <summary>
		/// #bk #Oh[#bk]()
		/// </summary>
		protected RMethod r_R__0__Oh_G__0__bk;
		public virtual RMethod R__0__Oh_G__0__bk
		{
			get
			{
				if(r_R__0__Oh_G__0__bk == null)
				{
					r_R__0__Oh_G__0__bk = new(this, "#Oh", 1);
					r_R__0__Oh_G__0__bk.SetBelong(this.instance);
				}
				return r_R__0__Oh_G__0__bk;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUIWindow] #BKb()
		/// </summary>
		protected RMethod r_R__0__BKb;
		public virtual RMethod R__0__BKb
		{
			get
			{
				if(r_R__0__BKb == null)
				{
					r_R__0__BKb = new(this, "#BKb", 0);
					r_R__0__BKb.SetBelong(this.instance);
				}
				return r_R__0__BKb;
			}
		}

		/// <summary>
		/// Void #CKb()
		/// </summary>
		protected RMethod r_R__0__CKb;
		public virtual RMethod R__0__CKb
		{
			get
			{
				if(r_R__0__CKb == null)
				{
					r_R__0__CKb = new(this, "#CKb", 0);
					r_R__0__CKb.SetBelong(this.instance);
				}
				return r_R__0__CKb;
			}
		}

		/// <summary>
		/// Void #lYb(Boolean)
		/// </summary>
		protected RMethod r_R__0__lYb_Boolean;
		public virtual RMethod R__0__lYb_Boolean
		{
			get
			{
				if(r_R__0__lYb_Boolean == null)
				{
					r_R__0__lYb_Boolean = new(this, "#lYb", 0, typeof(System.Boolean));
					r_R__0__lYb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__lYb_Boolean;
			}
		}

		/// <summary>
		/// Boolean #rh()
		/// </summary>
		protected RMethod r_R__0__rh;
		public virtual RMethod R__0__rh
		{
			get
			{
				if(r_R__0__rh == null)
				{
					r_R__0__rh = new(this, "#rh", 0);
					r_R__0__rh.SetBelong(this.instance);
				}
				return r_R__0__rh;
			}
		}

		/// <summary>
		/// Void #DKb()
		/// </summary>
		protected RMethod r_R__0__DKb;
		public virtual RMethod R__0__DKb
		{
			get
			{
				if(r_R__0__DKb == null)
				{
					r_R__0__DKb = new(this, "#DKb", 0);
					r_R__0__DKb.SetBelong(this.instance);
				}
				return r_R__0__DKb;
			}
		}

		/// <summary>
		/// Void #kld()
		/// </summary>
		protected RMethod r_R__0__kld;
		public virtual RMethod R__0__kld
		{
			get
			{
				if(r_R__0__kld == null)
				{
					r_R__0__kld = new(this, "#kld", 0);
					r_R__0__kld.SetBelong(this.instance);
				}
				return r_R__0__kld;
			}
		}

		/// <summary>
		/// #oU.#05 GetWindow()
		/// </summary>
		protected RMethod r_RGetWindow;
		public virtual RMethod RGetWindow
		{
			get
			{
				if(r_RGetWindow == null)
				{
					r_RGetWindow = new(this, "GetWindow", 0);
					r_RGetWindow.SetBelong(this.instance);
				}
				return r_RGetWindow;
			}
		}

		/// <summary>
		/// Void #EKb(WINDOW_HOTKEY)
		/// </summary>
		protected RMethod r_R__0__EKb_WINDOW_HOTKEY;
		public virtual RMethod R__0__EKb_WINDOW_HOTKEY
		{
			get
			{
				if(r_R__0__EKb_WINDOW_HOTKEY == null)
				{
					r_R__0__EKb_WINDOW_HOTKEY = new(this, "#EKb", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY"));
					r_R__0__EKb_WINDOW_HOTKEY.SetBelong(this.instance);
				}
				return r_R__0__EKb_WINDOW_HOTKEY;
			}
		}

		/// <summary>
		/// Void #FKb()
		/// </summary>
		protected RMethod r_R__0__FKb;
		public virtual RMethod R__0__FKb
		{
			get
			{
				if(r_R__0__FKb == null)
				{
					r_R__0__FKb = new(this, "#FKb", 0);
					r_R__0__FKb.SetBelong(this.instance);
				}
				return r_R__0__FKb;
			}
		}

		/// <summary>
		/// Void InitStyle()
		/// </summary>
		protected RMethod r_RInitStyle;
		public virtual RMethod RInitStyle
		{
			get
			{
				if(r_RInitStyle == null)
				{
					r_RInitStyle = new(this, "InitStyle", 0);
					r_RInitStyle.SetBelong(this.instance);
				}
				return r_RInitStyle;
			}
		}

		/// <summary>
		/// Void #mg(Int32)
		/// </summary>
		protected RMethod r_R__0__mg_Int32;
		public virtual RMethod R__0__mg_Int32
		{
			get
			{
				if(r_R__0__mg_Int32 == null)
				{
					r_R__0__mg_Int32 = new(this, "#mg", 0, typeof(System.Int32));
					r_R__0__mg_Int32.SetBelong(this.instance);
				}
				return r_R__0__mg_Int32;
			}
		}

		/// <summary>
		/// Void #PKb(#O2, Boolean)
		/// </summary>
		protected RMethod r_R__0__PKb___0__O2_Boolean;
		public virtual RMethod R__0__PKb___0__O2_Boolean
		{
			get
			{
				if(r_R__0__PKb___0__O2_Boolean == null)
				{
					r_R__0__PKb___0__O2_Boolean = new(this, "#PKb", 0,  ReleactionUtils.GetType("#oU.#K2+#O2"), typeof(System.Boolean));
					r_R__0__PKb___0__O2_Boolean.SetBelong(this.instance);
				}
				return r_R__0__PKb___0__O2_Boolean;
			}
		}

		/// <summary>
		/// Void #Nad(Boolean)
		/// </summary>
		protected RMethod r_R__0__Nad_Boolean;
		public virtual RMethod R__0__Nad_Boolean
		{
			get
			{
				if(r_R__0__Nad_Boolean == null)
				{
					r_R__0__Nad_Boolean = new(this, "#Nad", 0, typeof(System.Boolean));
					r_R__0__Nad_Boolean.SetBelong(this.instance);
				}
				return r_R__0__Nad_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #QKb()
		/// </summary>
		protected RMethod r_R__0__QKb;
		public virtual RMethod R__0__QKb
		{
			get
			{
				if(r_R__0__QKb == null)
				{
					r_R__0__QKb = new(this, "#QKb", 0);
					r_R__0__QKb.SetBelong(this.instance);
				}
				return r_R__0__QKb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #RKb(System.String)
		/// </summary>
		protected RMethod r_R__0__RKb_String;
		public virtual RMethod R__0__RKb_String
		{
			get
			{
				if(r_R__0__RKb_String == null)
				{
					r_R__0__RKb_String = new(this, "#RKb", 0, typeof(System.String));
					r_R__0__RKb_String.SetBelong(this.instance);
				}
				return r_R__0__RKb_String;
			}
		}

		/// <summary>
		/// Void OnAnimationStart(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationStart_Object;
		public virtual RMethod ROnAnimationStart_Object
		{
			get
			{
				if(r_ROnAnimationStart_Object == null)
				{
					r_ROnAnimationStart_Object = new(this, "OnAnimationStart", 0, typeof(System.Object));
					r_ROnAnimationStart_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationStart_Object;
			}
		}

		/// <summary>
		/// Void OnAnimationUpdate(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationUpdate_Object;
		public virtual RMethod ROnAnimationUpdate_Object
		{
			get
			{
				if(r_ROnAnimationUpdate_Object == null)
				{
					r_ROnAnimationUpdate_Object = new(this, "OnAnimationUpdate", 0, typeof(System.Object));
					r_ROnAnimationUpdate_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationUpdate_Object;
			}
		}

		/// <summary>
		/// Void OnAnimationComplete(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationComplete_Object;
		public virtual RMethod ROnAnimationComplete_Object
		{
			get
			{
				if(r_ROnAnimationComplete_Object == null)
				{
					r_ROnAnimationComplete_Object = new(this, "OnAnimationComplete", 0, typeof(System.Object));
					r_ROnAnimationComplete_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationComplete_Object;
			}
		}

		/// <summary>
		/// Void _Update()
		/// </summary>
		protected RMethod r_R_Update;
		public virtual RMethod R_Update
		{
			get
			{
				if(r_R_Update == null)
				{
					r_R_Update = new(this, "_Update", 0);
					r_R_Update.SetBelong(this.instance);
				}
				return r_R_Update;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine #TKb(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_R__0__TKb_IEnumerator;
		public virtual RMethod R__0__TKb_IEnumerator
		{
			get
			{
				if(r_R__0__TKb_IEnumerator == null)
				{
					r_R__0__TKb_IEnumerator = new(this, "#TKb", 0, typeof(System.Collections.IEnumerator));
					r_R__0__TKb_IEnumerator.SetBelong(this.instance);
				}
				return r_R__0__TKb_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine #TKb(System.String, System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_R__0__TKb_String_IEnumerator;
		public virtual RMethod R__0__TKb_String_IEnumerator
		{
			get
			{
				if(r_R__0__TKb_String_IEnumerator == null)
				{
					r_R__0__TKb_String_IEnumerator = new(this, "#TKb", 0, typeof(System.String), typeof(System.Collections.IEnumerator));
					r_R__0__TKb_String_IEnumerator.SetBelong(this.instance);
				}
				return r_R__0__TKb_String_IEnumerator;
			}
		}

		/// <summary>
		/// Void #UKb(System.String)
		/// </summary>
		protected RMethod r_R__0__UKb_String;
		public virtual RMethod R__0__UKb_String
		{
			get
			{
				if(r_R__0__UKb_String == null)
				{
					r_R__0__UKb_String = new(this, "#UKb", 0, typeof(System.String));
					r_R__0__UKb_String.SetBelong(this.instance);
				}
				return r_R__0__UKb_String;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RDestroy_Object;
		public virtual RMethod RDestroy_Object
		{
			get
			{
				if(r_RDestroy_Object == null)
				{
					r_RDestroy_Object = new(this, "Destroy", 0, typeof(UnityEngine.Object));
					r_RDestroy_Object.SetBelong(this.instance);
				}
				return r_RDestroy_Object;
			}
		}

		/// <summary>
		/// Void #VKb(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__VKb_GameObject;
		public virtual RMethod R__0__VKb_GameObject
		{
			get
			{
				if(r_R__0__VKb_GameObject == null)
				{
					r_R__0__VKb_GameObject = new(this, "#VKb", 0, typeof(UnityEngine.GameObject));
					r_R__0__VKb_GameObject.SetBelong(this.instance);
				}
				return r_R__0__VKb_GameObject;
			}
		}

		/// <summary>
		/// Void #XKb()
		/// </summary>
		protected RMethod r_R__0__XKb;
		public virtual RMethod R__0__XKb
		{
			get
			{
				if(r_R__0__XKb == null)
				{
					r_R__0__XKb = new(this, "#XKb", 0);
					r_R__0__XKb.SetBelong(this.instance);
				}
				return r_R__0__XKb;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_RDestroy;
		public virtual RMethod RDestroy
		{
			get
			{
				if(r_RDestroy == null)
				{
					r_RDestroy = new(this, "Destroy", 0);
					r_RDestroy.SetBelong(this.instance);
				}
				return r_RDestroy;
			}
		}

		/// <summary>
		/// Void #ZKb(Boolean, Boolean)
		/// </summary>
		protected RMethod r_R__0__ZKb_Boolean_Boolean;
		public virtual RMethod R__0__ZKb_Boolean_Boolean
		{
			get
			{
				if(r_R__0__ZKb_Boolean_Boolean == null)
				{
					r_R__0__ZKb_Boolean_Boolean = new(this, "#ZKb", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_R__0__ZKb_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_R__0__ZKb_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void #1Kb()
		/// </summary>
		protected RMethod r_R__0__1Kb;
		public virtual RMethod R__0__1Kb
		{
			get
			{
				if(r_R__0__1Kb == null)
				{
					r_R__0__1Kb = new(this, "#1Kb", 0);
					r_R__0__1Kb.SetBelong(this.instance);
				}
				return r_R__0__1Kb;
			}
		}

		/// <summary>
		/// Void #Abb(System.String)
		/// </summary>
		protected RMethod r_R__0__Abb_String;
		public virtual RMethod R__0__Abb_String
		{
			get
			{
				if(r_R__0__Abb_String == null)
				{
					r_R__0__Abb_String = new(this, "#Abb", 0, typeof(System.String));
					r_R__0__Abb_String.SetBelong(this.instance);
				}
				return r_R__0__Abb_String;
			}
		}

		/// <summary>
		/// Void #lBn(System.String)
		/// </summary>
		protected RMethod r_R__0__lBn_String;
		public virtual RMethod R__0__lBn_String
		{
			get
			{
				if(r_R__0__lBn_String == null)
				{
					r_R__0__lBn_String = new(this, "#lBn", 0, typeof(System.String));
					r_R__0__lBn_String.SetBelong(this.instance);
				}
				return r_R__0__lBn_String;
			}
		}

		/// <summary>
		/// Void #lVe(System.Object)
		/// </summary>
		protected RMethod r_R__0__lVe_Object;
		public virtual RMethod R__0__lVe_Object
		{
			get
			{
				if(r_R__0__lVe_Object == null)
				{
					r_R__0__lVe_Object = new(this, "#lVe", 0, typeof(System.Object));
					r_R__0__lVe_Object.SetBelong(this.instance);
				}
				return r_R__0__lVe_Object;
			}
		}

		/// <summary>
		/// Void #2Kb()
		/// </summary>
		protected RMethod r_R__0__2Kb;
		public virtual RMethod R__0__2Kb
		{
			get
			{
				if(r_R__0__2Kb == null)
				{
					r_R__0__2Kb = new(this, "#2Kb", 0);
					r_R__0__2Kb.SetBelong(this.instance);
				}
				return r_R__0__2Kb;
			}
		}

		/// <summary>
		/// Void #3Kb()
		/// </summary>
		protected RMethod r_R__0__3Kb;
		public virtual RMethod R__0__3Kb
		{
			get
			{
				if(r_R__0__3Kb == null)
				{
					r_R__0__3Kb = new(this, "#3Kb", 0);
					r_R__0__3Kb.SetBelong(this.instance);
				}
				return r_R__0__3Kb;
			}
		}

		/// <summary>
		/// Void #5Kb()
		/// </summary>
		protected RMethod r_R__0__5Kb;
		public virtual RMethod R__0__5Kb
		{
			get
			{
				if(r_R__0__5Kb == null)
				{
					r_R__0__5Kb = new(this, "#5Kb", 0);
					r_R__0__5Kb.SetBelong(this.instance);
				}
				return r_R__0__5Kb;
			}
		}

		/// <summary>
		/// Boolean #qh()
		/// </summary>
		protected RMethod r_R__0__qh;
		public virtual RMethod R__0__qh
		{
			get
			{
				if(r_R__0__qh == null)
				{
					r_R__0__qh = new(this, "#qh", 0);
					r_R__0__qh.SetBelong(this.instance);
				}
				return r_R__0__qh;
			}
		}

		/// <summary>
		/// Void PreLoadDefineString()
		/// </summary>
		protected RMethod r_RPreLoadDefineString;
		public virtual RMethod RPreLoadDefineString
		{
			get
			{
				if(r_RPreLoadDefineString == null)
				{
					r_RPreLoadDefineString = new(this, "PreLoadDefineString", 0);
					r_RPreLoadDefineString.SetBelong(this.instance);
				}
				return r_RPreLoadDefineString;
			}
		}

		/// <summary>
		/// Void #6Kb()
		/// </summary>
		protected RMethod r_R__0__6Kb;
		public virtual RMethod R__0__6Kb
		{
			get
			{
				if(r_R__0__6Kb == null)
				{
					r_R__0__6Kb = new(this, "#6Kb", 0);
					r_R__0__6Kb.SetBelong(this.instance);
				}
				return r_R__0__6Kb;
			}
		}

		/// <summary>
		/// Void #7Kb()
		/// </summary>
		protected RMethod r_R__0__7Kb;
		public virtual RMethod R__0__7Kb
		{
			get
			{
				if(r_R__0__7Kb == null)
				{
					r_R__0__7Kb = new(this, "#7Kb", 0);
					r_R__0__7Kb.SetBelong(this.instance);
				}
				return r_R__0__7Kb;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #bLb(MyGUI.ElementBase, Single)
		/// </summary>
		protected RMethod r_R__0__bLb_ElementBase_Single;
		public virtual RMethod R__0__bLb_ElementBase_Single
		{
			get
			{
				if(r_R__0__bLb_ElementBase_Single == null)
				{
					r_R__0__bLb_ElementBase_Single = new(this, "#bLb", 0, typeof(MyGUI.ElementBase), typeof(System.Single));
					r_R__0__bLb_ElementBase_Single.SetBelong(this.instance);
				}
				return r_R__0__bLb_ElementBase_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #cLb(MyGUI.ElementBase, Single)
		/// </summary>
		protected RMethod r_R__0__cLb_ElementBase_Single;
		public virtual RMethod R__0__cLb_ElementBase_Single
		{
			get
			{
				if(r_R__0__cLb_ElementBase_Single == null)
				{
					r_R__0__cLb_ElementBase_Single = new(this, "#cLb", 0, typeof(MyGUI.ElementBase), typeof(System.Single));
					r_R__0__cLb_ElementBase_Single.SetBelong(this.instance);
				}
				return r_R__0__cLb_ElementBase_Single;
			}
		}

		/// <summary>
		/// Void #dLb(#oU.#uU, Int32, Int32, Int32, #JNb)
		/// </summary>
		protected RMethod r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb;
		public virtual RMethod R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb
		{
			get
			{
				if(r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb == null)
				{
					r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb = new(this, "#dLb", 0,  ReleactionUtils.GetType("#oU.#uU"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReleactionUtils.GetType("MyGUIWindow+#JNb"));
					r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb.SetBelong(this.instance);
				}
				return r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb;
			}
		}

		/// <summary>
		/// Void #eLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__eLb_Object___0__7X;
		public virtual RMethod R__0__eLb_Object___0__7X
		{
			get
			{
				if(r_R__0__eLb_Object___0__7X == null)
				{
					r_R__0__eLb_Object___0__7X = new(this, "#eLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__eLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__eLb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #fLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__fLb_Object___0__7X;
		public virtual RMethod R__0__fLb_Object___0__7X
		{
			get
			{
				if(r_R__0__fLb_Object___0__7X == null)
				{
					r_R__0__fLb_Object___0__7X = new(this, "#fLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__fLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__fLb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #gLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__gLb_Object___0__7X;
		public virtual RMethod R__0__gLb_Object___0__7X
		{
			get
			{
				if(r_R__0__gLb_Object___0__7X == null)
				{
					r_R__0__gLb_Object___0__7X = new(this, "#gLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__gLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__gLb_Object___0__7X;
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


        public RMyGUIMainNtyAreaWnd() : base("MyGUIMainNtyAreaWnd")
        {
        }

        public RMyGUIMainNtyAreaWnd(System.Object instance) : base("MyGUIMainNtyAreaWnd")
		{
            SetInstance(instance);
		}

        public RMyGUIMainNtyAreaWnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMyGUIMainNtyAreaWnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Sb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Sb.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__oq(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__oq_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }













        public virtual void __0__Yw(System.Action  @teamAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@teamAction};
            var ___result = R__0__Yw_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__E1e()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__E1e.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__F1e()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__F1e.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Zw(System.Action  @friendAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendAction};
            var ___result = R__0__Zw_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I4g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__I4g.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__J4g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__J4g.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__0w(GameDefineType.ID  @npcID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@npcID};
            var ___result = R__0__0w_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__4w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__4w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__7w()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7w.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__UVb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__UVb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VVb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__VVb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__v0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__v0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__w0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__w0d.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__y0d(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__y0d_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResize.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__9w(System.Collections.Generic.List<System.String>  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = R__0__9w_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ax(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__ax_Object.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__zuf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__zuf.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__7li()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7li.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__8li()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__8li.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__9li()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__9li.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ami()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ami.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__qZg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__qZg_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__ack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__bck(System.Object  @ojt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ojt};
            var ___result = R__0__bck_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__efk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__efk.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Fxw(GameDefineType.ID  @familyID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@familyID};
            var ___result = R__0__Fxw_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Hxw(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Hxw_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ixw(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Ixw_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__dKb(System.Single  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = R__0__dKb_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eKb(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = R__0__eKb_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fKb(UnityEngine.Vector2  @Pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Pos};
            var ___result = R__0__fKb_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__gKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__EF()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__EF.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__hKb(UnityEngine.Vector2  @oldSize, UnityEngine.Vector2  @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldSize, @newSize};
            var ___result = R__0__hKb_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__u1b(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = R__0__u1b_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__iKb(UnityEngine.Vector2  @resolution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resolution};
            var ___result = R__0__iKb_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__jKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__jKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__pq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__pq.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual MyGUI.ElementBase __0__kKb(System.String  @elemName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemName};
            var ___result = R__0__kKb_String.Invoke(___genericsType, ___parameters);

            return (MyGUI.ElementBase)___result;
        }


        public virtual __0__bk __0__kKb<__0__bk>(System.String  @name) where __0__bk : MyGUI.ElementBase
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{@name};
            var ___result = R__0__kKb_G__0__bk_String.Invoke(___genericsType, ___parameters);

            return (__0__bk)___result;
        }


        public virtual void __0__lKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__lKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ibb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Ibb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__mKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Mr(System.Boolean  @isVisible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isVisible};
            var ___result = R__0__Mr_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rKb(System.Boolean  @isOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isOpen};
            var ___result = R__0__rKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__tKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__uKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__uKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__bN()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__bN.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__wKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__xKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__yKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__zKb(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = R__0__zKb_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 __0__uo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__uo.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void __0__gw(UnityEngine.Vector2  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__gw_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetWindowLocation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWindowLocation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void __0__AKb(System.String  @elementName, UIeffect  @effect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementName, @effect};
            var ___result = R__0__AKb_String_UIeffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual __0__bk __0__Oh<__0__bk>() where __0__bk : MyGUIWindow
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{};
            var ___result = R__0__Oh_G__0__bk.Invoke(___genericsType, ___parameters);

            return (__0__bk)___result;
        }


        public virtual System.Object __0__BKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__BKb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__CKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__CKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lYb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__lYb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__rh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__rh.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__DKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__DKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kld()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kld.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWindow.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__FKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__FKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mg(System.Int32  @windowID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowID};
            var ___result = R__0__mg_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Nad(System.Boolean  @bExcept)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bExcept};
            var ___result = R__0__Nad_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIStyle __0__QKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__QKb.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual UnityEngine.GUIStyle __0__RKb(System.String  @styleName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleName};
            var ___result = R__0__RKb_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual void OnAnimationStart(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationStart_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAnimationUpdate(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationUpdate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAnimationComplete(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationComplete_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_Update.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Coroutine __0__TKb(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = R__0__TKb_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine __0__TKb(System.String  @methodName, System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @routine};
            var ___result = R__0__TKb_String_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void __0__UKb(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = R__0__UKb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDestroy_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VKb(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__VKb_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__XKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ZKb(System.Boolean  @bOpen, System.Boolean  @bRelation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bOpen, @bRelation};
            var ___result = R__0__ZKb_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Abb(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__Abb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lBn(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__lBn_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lVe(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__lVe_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__5Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__qh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qh.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PreLoadDefineString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreLoadDefineString.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__7Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__bLb(MyGUI.ElementBase  @elem, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @time};
            var ___result = R__0__bLb_ElementBase_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator __0__cLb(MyGUI.ElementBase  @elem, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @time};
            var ___result = R__0__cLb_ElementBase_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
