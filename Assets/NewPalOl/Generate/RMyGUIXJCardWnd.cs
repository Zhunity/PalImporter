using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MyGUIXJCardWnd
	/// </summary>
    public partial class RMyGUIXJCardWnd : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#a");
					r___0__a.SetBelong(null);
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
					r___0__b = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Int32 #c
		/// </summary>
		protected static RField r___0__c;
		public static RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Int32 #d
		/// </summary>
		protected static RField r___0__d;
		public static RField R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Int32 #e
		/// </summary>
		protected static RField r___0__e;
		public static RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#e");
					r___0__e.SetBelong(null);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// XJCard[] #f
		/// </summary>
		protected RFieldArray<RXJCard> r___0__f;
		public virtual RFieldArray<RXJCard> R__0__f
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
		/// XJCard[] #g
		/// </summary>
		protected RFieldArray<RXJCard> r___0__g;
		public virtual RFieldArray<RXJCard> R__0__g
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
		/// #oU.#5bb #h
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__h;
		public virtual R__0__oU.R__0__5bb R__0__h
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
		/// System.Single #i
		/// </summary>
		protected RField r___0__i;
		public virtual RField R__0__i
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
		/// System.Single #j
		/// </summary>
		protected static RField r___0__j;
		public static RField R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#j");
					r___0__j.SetBelong(null);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// GameDefineType.ID #k
		/// </summary>
		protected static RGameDefineType.RID r___0__k;
		public static RGameDefineType.RID R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#k");
					r___0__k.SetBelong(null);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UIeffect] #l
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect> r___0__l;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect> R__0__l
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
		/// MyGUIXJCardWnd+CardsStage #m
		/// </summary>
		protected RField r___0__m;
		public virtual RField R__0__m
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
		/// System.Int32 #n
		/// </summary>
		protected RField r___0__n;
		public virtual RField R__0__n
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
		/// System.Int32 #o
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
		/// System.Int32 #p
		/// </summary>
		protected RField r___0__p;
		public virtual RField R__0__p
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
		/// System.Int32 #q
		/// </summary>
		protected RField r___0__q;
		public virtual RField R__0__q
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
		/// System.Int32 #r
		/// </summary>
		protected RField r___0__r;
		public virtual RField R__0__r
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
		/// System.Int32 #s
		/// </summary>
		protected RField r___0__s;
		public virtual RField R__0__s
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
		/// System.Boolean #t
		/// </summary>
		protected RField r___0__t;
		public virtual RField R__0__t
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
		/// System.Collections.Generic.List`1[System.Int32] #u
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__u;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__u
		{
			get
			{
				if(r___0__u == null)
				{
					r___0__u = new(this, "#u");
					r___0__u.SetBelong(this.instance);
				}
				return r___0__u;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #v
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__v;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__v
		{
			get
			{
				if(r___0__v == null)
				{
					r___0__v = new(this, "#v");
					r___0__v.SetBelong(this.instance);
				}
				return r___0__v;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[XJCard] #w
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RXJCard> r___0__w;
		public virtual RSystem.RCollections.RGeneric.RList<RXJCard> R__0__w
		{
			get
			{
				if(r___0__w == null)
				{
					r___0__w = new(this, "#w");
					r___0__w.SetBelong(this.instance);
				}
				return r___0__w;
			}
		}

		/// <summary>
		/// System.Int32 #x
		/// </summary>
		protected static RField r___0__x;
		public static RField R__0__x
		{
			get
			{
				if(r___0__x == null)
				{
					r___0__x = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#x");
					r___0__x.SetBelong(null);
				}
				return r___0__x;
			}
		}

		/// <summary>
		/// System.Int32 #y
		/// </summary>
		protected static RField r___0__y;
		public static RField R__0__y
		{
			get
			{
				if(r___0__y == null)
				{
					r___0__y = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#y");
					r___0__y.SetBelong(null);
				}
				return r___0__y;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[System.Collections.Generic.KeyValuePair`2[System.Int32,GameDefineType.ID]] #z
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RGameDefineType.RID>> r___0__z;
		public virtual RSystem.RCollections.RGeneric.RQueue<RSystem.RCollections.RGeneric.RKeyValuePair<RField, RGameDefineType.RID>> R__0__z
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
		/// System.Single #A
		/// </summary>
		protected static RField r___0__A;
		public static RField R__0__A
		{
			get
			{
				if(r___0__A == null)
				{
					r___0__A = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#A");
					r___0__A.SetBelong(null);
				}
				return r___0__A;
			}
		}

		/// <summary>
		/// System.Single #B
		/// </summary>
		protected RField r___0__B;
		public virtual RField R__0__B
		{
			get
			{
				if(r___0__B == null)
				{
					r___0__B = new(this, "#B");
					r___0__B.SetBelong(this.instance);
				}
				return r___0__B;
			}
		}

		/// <summary>
		/// System.Boolean #C
		/// </summary>
		protected RField r___0__C;
		public virtual RField R__0__C
		{
			get
			{
				if(r___0__C == null)
				{
					r___0__C = new(this, "#C");
					r___0__C.SetBelong(this.instance);
				}
				return r___0__C;
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
		/// System.Collections.Generic.List`1[System.Int32] #E
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__E;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__E
		{
			get
			{
				if(r___0__E == null)
				{
					r___0__E = new(this, "#E");
					r___0__E.SetBelong(this.instance);
				}
				return r___0__E;
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
		/// System.Single #G
		/// </summary>
		protected static RField r___0__G;
		public static RField R__0__G
		{
			get
			{
				if(r___0__G == null)
				{
					r___0__G = new( ReleactionUtils.GetType("MyGUIXJCardWnd"), "#G");
					r___0__G.SetBelong(null);
				}
				return r___0__G;
			}
		}

		/// <summary>
		/// System.Boolean #H
		/// </summary>
		protected RField r___0__H;
		public virtual RField R__0__H
		{
			get
			{
				if(r___0__H == null)
				{
					r___0__H = new(this, "#H");
					r___0__H.SetBelong(this.instance);
				}
				return r___0__H;
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
		/// CardsStage NowCardStage
		/// </summary>
		protected RProperty r_R__0__k5d;
		public virtual RProperty R__0__k5d
		{
			get
			{
				if(r_R__0__k5d == null)
				{
					r_R__0__k5d = new(this, "NowCardStage", -1);
					r_R__0__k5d.SetBelong(this.instance);
				}
				return r_R__0__k5d;
			}
		}

		/// <summary>
		/// Boolean IsRewardTurn
		/// </summary>
		protected RProperty r_R__0__ufg;
		public virtual RProperty R__0__ufg
		{
			get
			{
				if(r_R__0__ufg == null)
				{
					r_R__0__ufg = new(this, "IsRewardTurn", -1);
					r_R__0__ufg.SetBelong(this.instance);
				}
				return r_R__0__ufg;
			}
		}

		/// <summary>
		/// Boolean IsAotoXJCard
		/// </summary>
		protected RProperty r_R__0__U5d;
		public virtual RProperty R__0__U5d
		{
			get
			{
				if(r_R__0__U5d == null)
				{
					r_R__0__U5d = new(this, "IsAotoXJCard", -1);
					r_R__0__U5d.SetBelong(this.instance);
				}
				return r_R__0__U5d;
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
		/// Void #6c()
		/// </summary>
		protected RMethod r_R__0__6c;
		public virtual RMethod R__0__6c
		{
			get
			{
				if(r_R__0__6c == null)
				{
					r_R__0__6c = new(this, "#6c", 0);
					r_R__0__6c.SetBelong(this.instance);
				}
				return r_R__0__6c;
			}
		}

		/// <summary>
		/// Void #kWe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__kWe_Object___0__7X;
		public virtual RMethod R__0__kWe_Object___0__7X
		{
			get
			{
				if(r_R__0__kWe_Object___0__7X == null)
				{
					r_R__0__kWe_Object___0__7X = new(this, "#kWe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__kWe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__kWe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #j5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__j5d_Object___0__7X;
		public virtual RMethod R__0__j5d_Object___0__7X
		{
			get
			{
				if(r_R__0__j5d_Object___0__7X == null)
				{
					r_R__0__j5d_Object___0__7X = new(this, "#j5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__j5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__j5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Xgc(MyGUI.ElementBase, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__Xgc_ElementBase_GameObject;
		public virtual RMethod R__0__Xgc_ElementBase_GameObject
		{
			get
			{
				if(r_R__0__Xgc_ElementBase_GameObject == null)
				{
					r_R__0__Xgc_ElementBase_GameObject = new(this, "#Xgc", 0, typeof(MyGUI.ElementBase), typeof(UnityEngine.GameObject));
					r_R__0__Xgc_ElementBase_GameObject.SetBelong(this.instance);
				}
				return r_R__0__Xgc_ElementBase_GameObject;
			}
		}

		/// <summary>
		/// Void #xAd(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__xAd_ElementBase;
		public virtual RMethod R__0__xAd_ElementBase
		{
			get
			{
				if(r_R__0__xAd_ElementBase == null)
				{
					r_R__0__xAd_ElementBase = new(this, "#xAd", 0, typeof(MyGUI.ElementBase));
					r_R__0__xAd_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__xAd_ElementBase;
			}
		}

		/// <summary>
		/// Void #yAd()
		/// </summary>
		protected RMethod r_R__0__yAd;
		public virtual RMethod R__0__yAd
		{
			get
			{
				if(r_R__0__yAd == null)
				{
					r_R__0__yAd = new(this, "#yAd", 0);
					r_R__0__yAd.SetBelong(this.instance);
				}
				return r_R__0__yAd;
			}
		}

		/// <summary>
		/// Void OnLoadUIeffect(System.String, #eee)
		/// </summary>
		protected RMethod r_ROnLoadUIeffect_String___0__eee;
		public virtual RMethod ROnLoadUIeffect_String___0__eee
		{
			get
			{
				if(r_ROnLoadUIeffect_String___0__eee == null)
				{
					r_ROnLoadUIeffect_String___0__eee = new(this, "OnLoadUIeffect", 0, typeof(System.String),  ReleactionUtils.GetType("MyGUIXJCardWnd+#eee"));
					r_ROnLoadUIeffect_String___0__eee.SetBelong(this.instance);
				}
				return r_ROnLoadUIeffect_String___0__eee;
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
		/// Void #qfg(#Jfg)
		/// </summary>
		protected RMethod r_R__0__qfg___0__Jfg;
		public virtual RMethod R__0__qfg___0__Jfg
		{
			get
			{
				if(r_R__0__qfg___0__Jfg == null)
				{
					r_R__0__qfg___0__Jfg = new(this, "#qfg", 0,  ReleactionUtils.GetType("MyGUIXJCardWnd+#Jfg"));
					r_R__0__qfg___0__Jfg.SetBelong(this.instance);
				}
				return r_R__0__qfg___0__Jfg;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #rfg(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__rfg_ElementBase;
		public virtual RMethod R__0__rfg_ElementBase
		{
			get
			{
				if(r_R__0__rfg_ElementBase == null)
				{
					r_R__0__rfg_ElementBase = new(this, "#rfg", 0, typeof(MyGUI.ElementBase));
					r_R__0__rfg_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__rfg_ElementBase;
			}
		}

		/// <summary>
		/// Boolean #m5d(Int32)
		/// </summary>
		protected RMethod r_R__0__m5d_Int32;
		public virtual RMethod R__0__m5d_Int32
		{
			get
			{
				if(r_R__0__m5d_Int32 == null)
				{
					r_R__0__m5d_Int32 = new(this, "#m5d", 0, typeof(System.Int32));
					r_R__0__m5d_Int32.SetBelong(this.instance);
				}
				return r_R__0__m5d_Int32;
			}
		}

		/// <summary>
		/// Int32 #n5d(Int32)
		/// </summary>
		protected RMethod r_R__0__n5d_Int32;
		public virtual RMethod R__0__n5d_Int32
		{
			get
			{
				if(r_R__0__n5d_Int32 == null)
				{
					r_R__0__n5d_Int32 = new(this, "#n5d", 0, typeof(System.Int32));
					r_R__0__n5d_Int32.SetBelong(this.instance);
				}
				return r_R__0__n5d_Int32;
			}
		}

		/// <summary>
		/// Int32 #o5d()
		/// </summary>
		protected RMethod r_R__0__o5d;
		public virtual RMethod R__0__o5d
		{
			get
			{
				if(r_R__0__o5d == null)
				{
					r_R__0__o5d = new(this, "#o5d", 0);
					r_R__0__o5d.SetBelong(this.instance);
				}
				return r_R__0__o5d;
			}
		}

		/// <summary>
		/// Void #p5d()
		/// </summary>
		protected RMethod r_R__0__p5d;
		public virtual RMethod R__0__p5d
		{
			get
			{
				if(r_R__0__p5d == null)
				{
					r_R__0__p5d = new(this, "#p5d", 0);
					r_R__0__p5d.SetBelong(this.instance);
				}
				return r_R__0__p5d;
			}
		}

		/// <summary>
		/// Void #q5d()
		/// </summary>
		protected RMethod r_R__0__q5d;
		public virtual RMethod R__0__q5d
		{
			get
			{
				if(r_R__0__q5d == null)
				{
					r_R__0__q5d = new(this, "#q5d", 0);
					r_R__0__q5d.SetBelong(this.instance);
				}
				return r_R__0__q5d;
			}
		}

		/// <summary>
		/// Void #r5d()
		/// </summary>
		protected RMethod r_R__0__r5d;
		public virtual RMethod R__0__r5d
		{
			get
			{
				if(r_R__0__r5d == null)
				{
					r_R__0__r5d = new(this, "#r5d", 0);
					r_R__0__r5d.SetBelong(this.instance);
				}
				return r_R__0__r5d;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #s5d()
		/// </summary>
		protected RMethod r_R__0__s5d;
		public virtual RMethod R__0__s5d
		{
			get
			{
				if(r_R__0__s5d == null)
				{
					r_R__0__s5d = new(this, "#s5d", 0);
					r_R__0__s5d.SetBelong(this.instance);
				}
				return r_R__0__s5d;
			}
		}

		/// <summary>
		/// Void #t5d()
		/// </summary>
		protected RMethod r_R__0__t5d;
		public virtual RMethod R__0__t5d
		{
			get
			{
				if(r_R__0__t5d == null)
				{
					r_R__0__t5d = new(this, "#t5d", 0);
					r_R__0__t5d.SetBelong(this.instance);
				}
				return r_R__0__t5d;
			}
		}

		/// <summary>
		/// Void #u5d(Int32)
		/// </summary>
		protected RMethod r_R__0__u5d_Int32;
		public virtual RMethod R__0__u5d_Int32
		{
			get
			{
				if(r_R__0__u5d_Int32 == null)
				{
					r_R__0__u5d_Int32 = new(this, "#u5d", 0, typeof(System.Int32));
					r_R__0__u5d_Int32.SetBelong(this.instance);
				}
				return r_R__0__u5d_Int32;
			}
		}

		/// <summary>
		/// Void #v5d(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_R__0__v5d_List_d_Int32_p__Int32;
		public virtual RMethod R__0__v5d_List_d_Int32_p__Int32
		{
			get
			{
				if(r_R__0__v5d_List_d_Int32_p__Int32 == null)
				{
					r_R__0__v5d_List_d_Int32_p__Int32 = new(this, "#v5d", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_R__0__v5d_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_R__0__v5d_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void #sfg(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_R__0__sfg_List_d_Int32_p_;
		public virtual RMethod R__0__sfg_List_d_Int32_p_
		{
			get
			{
				if(r_R__0__sfg_List_d_Int32_p_ == null)
				{
					r_R__0__sfg_List_d_Int32_p_ = new(this, "#sfg", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_R__0__sfg_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_R__0__sfg_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #5d()
		/// </summary>
		protected RMethod r_R__0__5d;
		public virtual RMethod R__0__5d
		{
			get
			{
				if(r_R__0__5d == null)
				{
					r_R__0__5d = new(this, "#5d", 0);
					r_R__0__5d.SetBelong(this.instance);
				}
				return r_R__0__5d;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #w5d(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_R__0__w5d_List_d_Int32_p_;
		public virtual RMethod R__0__w5d_List_d_Int32_p_
		{
			get
			{
				if(r_R__0__w5d_List_d_Int32_p_ == null)
				{
					r_R__0__w5d_List_d_Int32_p_ = new(this, "#w5d", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_R__0__w5d_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_R__0__w5d_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void #x5d(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_R__0__x5d_List_d_Int32_p_;
		public virtual RMethod R__0__x5d_List_d_Int32_p_
		{
			get
			{
				if(r_R__0__x5d_List_d_Int32_p_ == null)
				{
					r_R__0__x5d_List_d_Int32_p_ = new(this, "#x5d", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_R__0__x5d_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_R__0__x5d_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void #y5d()
		/// </summary>
		protected RMethod r_R__0__y5d;
		public virtual RMethod R__0__y5d
		{
			get
			{
				if(r_R__0__y5d == null)
				{
					r_R__0__y5d = new(this, "#y5d", 0);
					r_R__0__y5d.SetBelong(this.instance);
				}
				return r_R__0__y5d;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #7d()
		/// </summary>
		protected RMethod r_R__0__7d;
		public virtual RMethod R__0__7d
		{
			get
			{
				if(r_R__0__7d == null)
				{
					r_R__0__7d = new(this, "#7d", 0);
					r_R__0__7d.SetBelong(this.instance);
				}
				return r_R__0__7d;
			}
		}

		/// <summary>
		/// Void #z5d()
		/// </summary>
		protected RMethod r_R__0__z5d;
		public virtual RMethod R__0__z5d
		{
			get
			{
				if(r_R__0__z5d == null)
				{
					r_R__0__z5d = new(this, "#z5d", 0);
					r_R__0__z5d.SetBelong(this.instance);
				}
				return r_R__0__z5d;
			}
		}

		/// <summary>
		/// Void #tfg()
		/// </summary>
		protected RMethod r_R__0__tfg;
		public virtual RMethod R__0__tfg
		{
			get
			{
				if(r_R__0__tfg == null)
				{
					r_R__0__tfg = new(this, "#tfg", 0);
					r_R__0__tfg.SetBelong(this.instance);
				}
				return r_R__0__tfg;
			}
		}

		/// <summary>
		/// Void #se(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__se_Int32_ID;
		public virtual RMethod R__0__se_Int32_ID
		{
			get
			{
				if(r_R__0__se_Int32_ID == null)
				{
					r_R__0__se_Int32_ID = new(this, "#se", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__se_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__se_Int32_ID;
			}
		}

		/// <summary>
		/// Void #B5d(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__B5d_Int32_ID;
		public virtual RMethod R__0__B5d_Int32_ID
		{
			get
			{
				if(r_R__0__B5d_Int32_ID == null)
				{
					r_R__0__B5d_Int32_ID = new(this, "#B5d", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__B5d_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__B5d_Int32_ID;
			}
		}

		/// <summary>
		/// Void #C5d(XJCard)
		/// </summary>
		protected RMethod r_R__0__C5d_XJCard;
		public virtual RMethod R__0__C5d_XJCard
		{
			get
			{
				if(r_R__0__C5d_XJCard == null)
				{
					r_R__0__C5d_XJCard = new(this, "#C5d", 0,  ReleactionUtils.GetType("XJCard"));
					r_R__0__C5d_XJCard.SetBelong(this.instance);
				}
				return r_R__0__C5d_XJCard;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #D5d(XJCard)
		/// </summary>
		protected RMethod r_R__0__D5d_XJCard;
		public virtual RMethod R__0__D5d_XJCard
		{
			get
			{
				if(r_R__0__D5d_XJCard == null)
				{
					r_R__0__D5d_XJCard = new(this, "#D5d", 0,  ReleactionUtils.GetType("XJCard"));
					r_R__0__D5d_XJCard.SetBelong(this.instance);
				}
				return r_R__0__D5d_XJCard;
			}
		}

		/// <summary>
		/// Void #E5d()
		/// </summary>
		protected RMethod r_R__0__E5d;
		public virtual RMethod R__0__E5d
		{
			get
			{
				if(r_R__0__E5d == null)
				{
					r_R__0__E5d = new(this, "#E5d", 0);
					r_R__0__E5d.SetBelong(this.instance);
				}
				return r_R__0__E5d;
			}
		}

		/// <summary>
		/// Void #F5d()
		/// </summary>
		protected RMethod r_R__0__F5d;
		public virtual RMethod R__0__F5d
		{
			get
			{
				if(r_R__0__F5d == null)
				{
					r_R__0__F5d = new(this, "#F5d", 0);
					r_R__0__F5d.SetBelong(this.instance);
				}
				return r_R__0__F5d;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #G5d()
		/// </summary>
		protected RMethod r_R__0__G5d;
		public virtual RMethod R__0__G5d
		{
			get
			{
				if(r_R__0__G5d == null)
				{
					r_R__0__G5d = new(this, "#G5d", 0);
					r_R__0__G5d.SetBelong(this.instance);
				}
				return r_R__0__G5d;
			}
		}

		/// <summary>
		/// Void #H5d(XJCard)
		/// </summary>
		protected RMethod r_R__0__H5d_XJCard;
		public virtual RMethod R__0__H5d_XJCard
		{
			get
			{
				if(r_R__0__H5d_XJCard == null)
				{
					r_R__0__H5d_XJCard = new(this, "#H5d", 0,  ReleactionUtils.GetType("XJCard"));
					r_R__0__H5d_XJCard.SetBelong(this.instance);
				}
				return r_R__0__H5d_XJCard;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #ce(XJCard)
		/// </summary>
		protected RMethod r_R__0__ce_XJCard;
		public virtual RMethod R__0__ce_XJCard
		{
			get
			{
				if(r_R__0__ce_XJCard == null)
				{
					r_R__0__ce_XJCard = new(this, "#ce", 0,  ReleactionUtils.GetType("XJCard"));
					r_R__0__ce_XJCard.SetBelong(this.instance);
				}
				return r_R__0__ce_XJCard;
			}
		}

		/// <summary>
		/// XJCard #vfg(Int32)
		/// </summary>
		protected RMethod r_R__0__vfg_Int32;
		public virtual RMethod R__0__vfg_Int32
		{
			get
			{
				if(r_R__0__vfg_Int32 == null)
				{
					r_R__0__vfg_Int32 = new(this, "#vfg", 0, typeof(System.Int32));
					r_R__0__vfg_Int32.SetBelong(this.instance);
				}
				return r_R__0__vfg_Int32;
			}
		}

		/// <summary>
		/// Void #wfg(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_R__0__wfg_List_d_Int32_p_;
		public virtual RMethod R__0__wfg_List_d_Int32_p_
		{
			get
			{
				if(r_R__0__wfg_List_d_Int32_p_ == null)
				{
					r_R__0__wfg_List_d_Int32_p_ = new(this, "#wfg", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_R__0__wfg_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_R__0__wfg_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void #xfg()
		/// </summary>
		protected RMethod r_R__0__xfg;
		public virtual RMethod R__0__xfg
		{
			get
			{
				if(r_R__0__xfg == null)
				{
					r_R__0__xfg = new(this, "#xfg", 0);
					r_R__0__xfg.SetBelong(this.instance);
				}
				return r_R__0__xfg;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #yfg()
		/// </summary>
		protected RMethod r_R__0__yfg;
		public virtual RMethod R__0__yfg
		{
			get
			{
				if(r_R__0__yfg == null)
				{
					r_R__0__yfg = new(this, "#yfg", 0);
					r_R__0__yfg.SetBelong(this.instance);
				}
				return r_R__0__yfg;
			}
		}

		/// <summary>
		/// Void #zfg()
		/// </summary>
		protected RMethod r_R__0__zfg;
		public virtual RMethod R__0__zfg
		{
			get
			{
				if(r_R__0__zfg == null)
				{
					r_R__0__zfg = new(this, "#zfg", 0);
					r_R__0__zfg.SetBelong(this.instance);
				}
				return r_R__0__zfg;
			}
		}

		/// <summary>
		/// Void #Afg(Int32)
		/// </summary>
		protected RMethod r_R__0__Afg_Int32;
		public virtual RMethod R__0__Afg_Int32
		{
			get
			{
				if(r_R__0__Afg_Int32 == null)
				{
					r_R__0__Afg_Int32 = new(this, "#Afg", 0, typeof(System.Int32));
					r_R__0__Afg_Int32.SetBelong(this.instance);
				}
				return r_R__0__Afg_Int32;
			}
		}

		/// <summary>
		/// Void #I5d()
		/// </summary>
		protected RMethod r_R__0__I5d;
		public virtual RMethod R__0__I5d
		{
			get
			{
				if(r_R__0__I5d == null)
				{
					r_R__0__I5d = new(this, "#I5d", 0);
					r_R__0__I5d.SetBelong(this.instance);
				}
				return r_R__0__I5d;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #0bc(XJCard, Boolean, #fee)
		/// </summary>
		protected RMethod r_R__0__0bc_XJCard_Boolean___0__fee;
		public virtual RMethod R__0__0bc_XJCard_Boolean___0__fee
		{
			get
			{
				if(r_R__0__0bc_XJCard_Boolean___0__fee == null)
				{
					r_R__0__0bc_XJCard_Boolean___0__fee = new(this, "#0bc", 0,  ReleactionUtils.GetType("XJCard"), typeof(System.Boolean),  ReleactionUtils.GetType("MyGUIXJCardWnd+#fee"));
					r_R__0__0bc_XJCard_Boolean___0__fee.SetBelong(this.instance);
				}
				return r_R__0__0bc_XJCard_Boolean___0__fee;
			}
		}

		/// <summary>
		/// Void #1bc(XJCard, Boolean, #fee)
		/// </summary>
		protected RMethod r_R__0__1bc_XJCard_Boolean___0__fee;
		public virtual RMethod R__0__1bc_XJCard_Boolean___0__fee
		{
			get
			{
				if(r_R__0__1bc_XJCard_Boolean___0__fee == null)
				{
					r_R__0__1bc_XJCard_Boolean___0__fee = new(this, "#1bc", 0,  ReleactionUtils.GetType("XJCard"), typeof(System.Boolean),  ReleactionUtils.GetType("MyGUIXJCardWnd+#fee"));
					r_R__0__1bc_XJCard_Boolean___0__fee.SetBelong(this.instance);
				}
				return r_R__0__1bc_XJCard_Boolean___0__fee;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #J5d(XJCard, UnityEngine.Vector2, Single)
		/// </summary>
		protected RMethod r_R__0__J5d_XJCard_Vector2_Single;
		public virtual RMethod R__0__J5d_XJCard_Vector2_Single
		{
			get
			{
				if(r_R__0__J5d_XJCard_Vector2_Single == null)
				{
					r_R__0__J5d_XJCard_Vector2_Single = new(this, "#J5d", 0,  ReleactionUtils.GetType("XJCard"), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_R__0__J5d_XJCard_Vector2_Single.SetBelong(this.instance);
				}
				return r_R__0__J5d_XJCard_Vector2_Single;
			}
		}

		/// <summary>
		/// Void #K5d(XJCard, UnityEngine.Vector2, Single)
		/// </summary>
		protected RMethod r_R__0__K5d_XJCard_Vector2_Single;
		public virtual RMethod R__0__K5d_XJCard_Vector2_Single
		{
			get
			{
				if(r_R__0__K5d_XJCard_Vector2_Single == null)
				{
					r_R__0__K5d_XJCard_Vector2_Single = new(this, "#K5d", 0,  ReleactionUtils.GetType("XJCard"), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_R__0__K5d_XJCard_Vector2_Single.SetBelong(this.instance);
				}
				return r_R__0__K5d_XJCard_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #Ud(MyGUI.ElementBase, Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__Ud_ElementBase_Int32_Int32;
		public virtual RMethod R__0__Ud_ElementBase_Int32_Int32
		{
			get
			{
				if(r_R__0__Ud_ElementBase_Int32_Int32 == null)
				{
					r_R__0__Ud_ElementBase_Int32_Int32 = new(this, "#Ud", 0, typeof(MyGUI.ElementBase), typeof(System.Int32), typeof(System.Int32));
					r_R__0__Ud_ElementBase_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__Ud_ElementBase_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean #eqf()
		/// </summary>
		protected RMethod r_R__0__eqf;
		public virtual RMethod R__0__eqf
		{
			get
			{
				if(r_R__0__eqf == null)
				{
					r_R__0__eqf = new(this, "#eqf", 0);
					r_R__0__eqf.SetBelong(this.instance);
				}
				return r_R__0__eqf;
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
		/// Void #L5d()
		/// </summary>
		protected RMethod r_R__0__L5d;
		public virtual RMethod R__0__L5d
		{
			get
			{
				if(r_R__0__L5d == null)
				{
					r_R__0__L5d = new(this, "#L5d", 0);
					r_R__0__L5d.SetBelong(this.instance);
				}
				return r_R__0__L5d;
			}
		}

		/// <summary>
		/// Void #M5d(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__M5d_Int32_Int32_Int32;
		public virtual RMethod R__0__M5d_Int32_Int32_Int32
		{
			get
			{
				if(r_R__0__M5d_Int32_Int32_Int32 == null)
				{
					r_R__0__M5d_Int32_Int32_Int32 = new(this, "#M5d", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_R__0__M5d_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__M5d_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #sfg()
		/// </summary>
		protected RMethod r_R__0__sfg;
		public virtual RMethod R__0__sfg
		{
			get
			{
				if(r_R__0__sfg == null)
				{
					r_R__0__sfg = new(this, "#sfg", 0);
					r_R__0__sfg.SetBelong(this.instance);
				}
				return r_R__0__sfg;
			}
		}

		/// <summary>
		/// Void #Bfg()
		/// </summary>
		protected RMethod r_R__0__Bfg;
		public virtual RMethod R__0__Bfg
		{
			get
			{
				if(r_R__0__Bfg == null)
				{
					r_R__0__Bfg = new(this, "#Bfg", 0);
					r_R__0__Bfg.SetBelong(this.instance);
				}
				return r_R__0__Bfg;
			}
		}

		/// <summary>
		/// Void #3d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__3d_Object___0__7X;
		public virtual RMethod R__0__3d_Object___0__7X
		{
			get
			{
				if(r_R__0__3d_Object___0__7X == null)
				{
					r_R__0__3d_Object___0__7X = new(this, "#3d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__3d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__3d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #N5d(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__N5d_Int32_ID;
		public virtual RMethod R__0__N5d_Int32_ID
		{
			get
			{
				if(r_R__0__N5d_Int32_ID == null)
				{
					r_R__0__N5d_Int32_ID = new(this, "#N5d", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__N5d_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__N5d_Int32_ID;
			}
		}

		/// <summary>
		/// Void #O5d()
		/// </summary>
		protected RMethod r_R__0__O5d;
		public virtual RMethod R__0__O5d
		{
			get
			{
				if(r_R__0__O5d == null)
				{
					r_R__0__O5d = new(this, "#O5d", 0);
					r_R__0__O5d.SetBelong(this.instance);
				}
				return r_R__0__O5d;
			}
		}

		/// <summary>
		/// Void #Cfg()
		/// </summary>
		protected RMethod r_R__0__Cfg;
		public virtual RMethod R__0__Cfg
		{
			get
			{
				if(r_R__0__Cfg == null)
				{
					r_R__0__Cfg = new(this, "#Cfg", 0);
					r_R__0__Cfg.SetBelong(this.instance);
				}
				return r_R__0__Cfg;
			}
		}

		/// <summary>
		/// Void #P5d(Int32)
		/// </summary>
		protected RMethod r_R__0__P5d_Int32;
		public virtual RMethod R__0__P5d_Int32
		{
			get
			{
				if(r_R__0__P5d_Int32 == null)
				{
					r_R__0__P5d_Int32 = new(this, "#P5d", 0, typeof(System.Int32));
					r_R__0__P5d_Int32.SetBelong(this.instance);
				}
				return r_R__0__P5d_Int32;
			}
		}

		/// <summary>
		/// Void #Q5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Q5d_Object___0__7X;
		public virtual RMethod R__0__Q5d_Object___0__7X
		{
			get
			{
				if(r_R__0__Q5d_Object___0__7X == null)
				{
					r_R__0__Q5d_Object___0__7X = new(this, "#Q5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Q5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Q5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Dfg()
		/// </summary>
		protected RMethod r_R__0__Dfg;
		public virtual RMethod R__0__Dfg
		{
			get
			{
				if(r_R__0__Dfg == null)
				{
					r_R__0__Dfg = new(this, "#Dfg", 0);
					r_R__0__Dfg.SetBelong(this.instance);
				}
				return r_R__0__Dfg;
			}
		}

		/// <summary>
		/// Void #Efg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Efg_Object_Object;
		public virtual RMethod R__0__Efg_Object_Object
		{
			get
			{
				if(r_R__0__Efg_Object_Object == null)
				{
					r_R__0__Efg_Object_Object = new(this, "#Efg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Efg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Efg_Object_Object;
			}
		}

		/// <summary>
		/// Void #Ffg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Ffg_Object_Object;
		public virtual RMethod R__0__Ffg_Object_Object
		{
			get
			{
				if(r_R__0__Ffg_Object_Object == null)
				{
					r_R__0__Ffg_Object_Object = new(this, "#Ffg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Ffg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Ffg_Object_Object;
			}
		}

		/// <summary>
		/// Void #R5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__R5d_Object___0__7X;
		public virtual RMethod R__0__R5d_Object___0__7X
		{
			get
			{
				if(r_R__0__R5d_Object___0__7X == null)
				{
					r_R__0__R5d_Object___0__7X = new(this, "#R5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__R5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__R5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #S5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__S5d_Object___0__7X;
		public virtual RMethod R__0__S5d_Object___0__7X
		{
			get
			{
				if(r_R__0__S5d_Object___0__7X == null)
				{
					r_R__0__S5d_Object___0__7X = new(this, "#S5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__S5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__S5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #V5d(Boolean, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_R__0__V5d_Boolean_Int32_Boolean_Int32;
		public virtual RMethod R__0__V5d_Boolean_Int32_Boolean_Int32
		{
			get
			{
				if(r_R__0__V5d_Boolean_Int32_Boolean_Int32 == null)
				{
					r_R__0__V5d_Boolean_Int32_Boolean_Int32 = new(this, "#V5d", 0, typeof(System.Boolean), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_R__0__V5d_Boolean_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_R__0__V5d_Boolean_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #W5d(Boolean, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_R__0__W5d_Boolean_Int32_Boolean_Int32;
		public virtual RMethod R__0__W5d_Boolean_Int32_Boolean_Int32
		{
			get
			{
				if(r_R__0__W5d_Boolean_Int32_Boolean_Int32 == null)
				{
					r_R__0__W5d_Boolean_Int32_Boolean_Int32 = new(this, "#W5d", 0, typeof(System.Boolean), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_R__0__W5d_Boolean_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_R__0__W5d_Boolean_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void #gx(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__gx_Object___0__7X;
		public virtual RMethod R__0__gx_Object___0__7X
		{
			get
			{
				if(r_R__0__gx_Object___0__7X == null)
				{
					r_R__0__gx_Object___0__7X = new(this, "#gx", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__gx_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__gx_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Gfg(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Gfg_Object___0__7X;
		public virtual RMethod R__0__Gfg_Object___0__7X
		{
			get
			{
				if(r_R__0__Gfg_Object___0__7X == null)
				{
					r_R__0__Gfg_Object___0__7X = new(this, "#Gfg", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Gfg_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Gfg_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #m9b(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__m9b_Object___0__7X;
		public virtual RMethod R__0__m9b_Object___0__7X
		{
			get
			{
				if(r_R__0__m9b_Object___0__7X == null)
				{
					r_R__0__m9b_Object___0__7X = new(this, "#m9b", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__m9b_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__m9b_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #X5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__X5d_Object___0__7X;
		public virtual RMethod R__0__X5d_Object___0__7X
		{
			get
			{
				if(r_R__0__X5d_Object___0__7X == null)
				{
					r_R__0__X5d_Object___0__7X = new(this, "#X5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__X5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__X5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Y5d()
		/// </summary>
		protected RMethod r_R__0__Y5d;
		public virtual RMethod R__0__Y5d
		{
			get
			{
				if(r_R__0__Y5d == null)
				{
					r_R__0__Y5d = new(this, "#Y5d", 0);
					r_R__0__Y5d.SetBelong(this.instance);
				}
				return r_R__0__Y5d;
			}
		}

		/// <summary>
		/// Void #Z5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Z5d_Object___0__7X;
		public virtual RMethod R__0__Z5d_Object___0__7X
		{
			get
			{
				if(r_R__0__Z5d_Object___0__7X == null)
				{
					r_R__0__Z5d_Object___0__7X = new(this, "#Z5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Z5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Z5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Db(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Db_Object___0__7X;
		public virtual RMethod R__0__Db_Object___0__7X
		{
			get
			{
				if(r_R__0__Db_Object___0__7X == null)
				{
					r_R__0__Db_Object___0__7X = new(this, "#Db", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Db_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Db_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Hfg(System.Object)
		/// </summary>
		protected RMethod r_R__0__Hfg_Object;
		public virtual RMethod R__0__Hfg_Object
		{
			get
			{
				if(r_R__0__Hfg_Object == null)
				{
					r_R__0__Hfg_Object = new(this, "#Hfg", 0, typeof(System.Object));
					r_R__0__Hfg_Object.SetBelong(this.instance);
				}
				return r_R__0__Hfg_Object;
			}
		}

		/// <summary>
		/// Void #Ifg(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ifg_Object___0__7X;
		public virtual RMethod R__0__Ifg_Object___0__7X
		{
			get
			{
				if(r_R__0__Ifg_Object___0__7X == null)
				{
					r_R__0__Ifg_Object___0__7X = new(this, "#Ifg", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ifg_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ifg_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #0Kg(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__0Kg_Object___0__7X;
		public virtual RMethod R__0__0Kg_Object___0__7X
		{
			get
			{
				if(r_R__0__0Kg_Object___0__7X == null)
				{
					r_R__0__0Kg_Object___0__7X = new(this, "#0Kg", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__0Kg_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__0Kg_Object___0__7X;
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


        public RMyGUIXJCardWnd() : base("MyGUIXJCardWnd")
        {
        }

        public RMyGUIXJCardWnd(System.Object instance) : base("MyGUIXJCardWnd")
		{
            SetInstance(instance);
		}

        public RMyGUIXJCardWnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMyGUIXJCardWnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6c.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Xgc(MyGUI.ElementBase  @eb, UnityEngine.GameObject  @ojt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb, @ojt};
            var ___result = R__0__Xgc_ElementBase_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__xAd(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__xAd_ElementBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__yAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yAd.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Collections.IEnumerator __0__rfg(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__rfg_ElementBase.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean __0__m5d(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = R__0__m5d_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 __0__n5d(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = R__0__n5d_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__o5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__o5d.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__p5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__p5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__q5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__q5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__r5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__r5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__s5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__s5d.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__t5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__t5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__u5d(System.Int32  @weekcount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weekcount};
            var ___result = R__0__u5d_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__v5d(System.Collections.Generic.List<System.Int32>  @cardlist, System.Int32  @weekcount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cardlist, @weekcount};
            var ___result = R__0__v5d_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sfg(System.Collections.Generic.List<System.Int32>  @cardlist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cardlist};
            var ___result = R__0__sfg_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5d.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator __0__w5d(System.Collections.Generic.List<System.Int32>  @cardlist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cardlist};
            var ___result = R__0__w5d_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__x5d(System.Collections.Generic.List<System.Int32>  @cardlist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cardlist};
            var ___result = R__0__x5d_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__y5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__y5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__7d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7d.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__z5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__z5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__tfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__se(System.Int32  @idx, GameDefineType.ID  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @val};
            var ___result = R__0__se_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__B5d(System.Int32  @idx, GameDefineType.ID  @conifgid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @conifgid};
            var ___result = R__0__B5d_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__E5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__E5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__F5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__F5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__G5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__G5d.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }




        public virtual System.Object __0__vfg(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__vfg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__wfg(System.Collections.Generic.List<System.Int32>  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = R__0__wfg_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__xfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__yfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yfg.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__zfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__zfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Afg(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__Afg_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__I5d.Invoke(___genericsType, ___parameters);

            
        }






        public virtual UnityEngine.Vector2 __0__Ud(MyGUI.ElementBase  @eb, System.Int32  @pos, System.Int32  @sum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb, @pos, @sum};
            var ___result = R__0__Ud_ElementBase_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Boolean __0__eqf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__eqf.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__L5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__L5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__M5d(System.Int32  @dayScore, System.Int32  @weekScore, System.Int32  @weekRank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dayScore, @weekScore, @weekRank};
            var ___result = R__0__M5d_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__sfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Bfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Bfg.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__N5d(System.Int32  @type, GameDefineType.ID  @iditem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @iditem};
            var ___result = R__0__N5d_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__O5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__O5d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Cfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__P5d(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__P5d_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Dfg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Dfg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Efg(System.Object  @oldvalue, System.Object  @newvalue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldvalue, @newvalue};
            var ___result = R__0__Efg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ffg(System.Object  @oldvalue, System.Object  @newvalue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldvalue, @newvalue};
            var ___result = R__0__Ffg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__V5d(System.Boolean  @_bUseCards, System.Int32  @playcount, System.Boolean  @_bUseMoney, System.Int32  @_limitrare)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_bUseCards, @playcount, @_bUseMoney, @_limitrare};
            var ___result = R__0__V5d_Boolean_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__W5d(System.Boolean  @_bUseCards, System.Int32  @playcount, System.Boolean  @_bUseMoney, System.Int32  @_limitrare)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_bUseCards, @playcount, @_bUseMoney, @_limitrare};
            var ___result = R__0__W5d_Boolean_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }






        public virtual void __0__Y5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Y5d.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Hfg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Hfg_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Abb(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__Abb_String.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Resize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResize.Invoke(___genericsType, ___parameters);

            
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
