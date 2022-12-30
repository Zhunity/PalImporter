using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#d4c
	/// </summary>
    public partial class R__0__d4c : RMember //
    {

		/// <summary>
		/// System.String #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#d4c"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// #u.#d4c+#e4c #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#d4c+#f4c] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__d4c.R__0__f4c> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__d4c.R__0__f4c> R__0__c
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
		/// System.Collections.Generic.Queue`1[#u.#d4c+#g4c] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<R__0__u.R__0__d4c.R__0__g4c> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RQueue<R__0__u.R__0__d4c.R__0__g4c> R__0__d
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
		/// System.String #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
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
		/// System.Collections.Generic.List`1[CombatEvent] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RCombatEvent> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RList<RCombatEvent> R__0__g
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
		/// System.Boolean #h
		/// </summary>
		protected RField r___0__h;
		public virtual RField R__0__h
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
		/// #Pfb.#m6c #i
		/// </summary>
		protected R__0__Pfb.R__0__m6c r___0__i;
		public virtual R__0__Pfb.R__0__m6c R__0__i
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
		/// System.Collections.Generic.List`1[System.String] #j
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__j;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__j
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
		/// System.Collections.Generic.Dictionary`2[System.Type,#u.#d4c+#uOb] #k
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, R__0__u.R__0__d4c.R__0__uOb> r___0__k;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, R__0__u.R__0__d4c.R__0__uOb> R__0__k
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Queue`1[#Pfb.#n6c]] #l
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__n6c>> r___0__l;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RQueue<R__0__Pfb.R__0__n6c>> R__0__l
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
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #m
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__m;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__m
		{
			get
			{
				if(r___0__m == null)
				{
					r___0__m = new( ReleactionUtils.GetType("#u.#d4c"), "#m");
					r___0__m.SetBelong(null);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// Void #H3c()
		/// </summary>
		protected RMethod r_R__0__H3c;
		public virtual RMethod R__0__H3c
		{
			get
			{
				if(r_R__0__H3c == null)
				{
					r_R__0__H3c = new(this, "#H3c", 0);
					r_R__0__H3c.SetBelong(this.instance);
				}
				return r_R__0__H3c;
			}
		}

		/// <summary>
		/// #e4c #I3c()
		/// </summary>
		protected RMethod r_R__0__I3c;
		public virtual RMethod R__0__I3c
		{
			get
			{
				if(r_R__0__I3c == null)
				{
					r_R__0__I3c = new(this, "#I3c", 0);
					r_R__0__I3c.SetBelong(this.instance);
				}
				return r_R__0__I3c;
			}
		}

		/// <summary>
		/// System.String #L6c()
		/// </summary>
		protected RMethod r_R__0__L6c;
		public virtual RMethod R__0__L6c
		{
			get
			{
				if(r_R__0__L6c == null)
				{
					r_R__0__L6c = new(this, "#L6c", 0);
					r_R__0__L6c.SetBelong(this.instance);
				}
				return r_R__0__L6c;
			}
		}

		/// <summary>
		/// Void #J3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__J3c_Object___0__Isb;
		public virtual RMethod R__0__J3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__J3c_Object___0__Isb == null)
				{
					r_R__0__J3c_Object___0__Isb = new(this, "#J3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__J3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__J3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #K3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__K3c_Object___0__Isb;
		public virtual RMethod R__0__K3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__K3c_Object___0__Isb == null)
				{
					r_R__0__K3c_Object___0__Isb = new(this, "#K3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__K3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__K3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #MIq(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__MIq_Object___0__Isb;
		public virtual RMethod R__0__MIq_Object___0__Isb
		{
			get
			{
				if(r_R__0__MIq_Object___0__Isb == null)
				{
					r_R__0__MIq_Object___0__Isb = new(this, "#MIq", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__MIq_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__MIq_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #L3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__L3c_Object___0__Isb;
		public virtual RMethod R__0__L3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__L3c_Object___0__Isb == null)
				{
					r_R__0__L3c_Object___0__Isb = new(this, "#L3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__L3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__L3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #5Zo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__5Zo_Object___0__Isb;
		public virtual RMethod R__0__5Zo_Object___0__Isb
		{
			get
			{
				if(r_R__0__5Zo_Object___0__Isb == null)
				{
					r_R__0__5Zo_Object___0__Isb = new(this, "#5Zo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__5Zo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__5Zo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #27d(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__27d_Object___0__Isb;
		public virtual RMethod R__0__27d_Object___0__Isb
		{
			get
			{
				if(r_R__0__27d_Object___0__Isb == null)
				{
					r_R__0__27d_Object___0__Isb = new(this, "#27d", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__27d_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__27d_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #M3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__M3c_Object___0__Isb;
		public virtual RMethod R__0__M3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__M3c_Object___0__Isb == null)
				{
					r_R__0__M3c_Object___0__Isb = new(this, "#M3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__M3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__M3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #N3c(#g4c)
		/// </summary>
		protected RMethod r_R__0__N3c___0__g4c;
		public virtual RMethod R__0__N3c___0__g4c
		{
			get
			{
				if(r_R__0__N3c___0__g4c == null)
				{
					r_R__0__N3c___0__g4c = new(this, "#N3c", 0,  ReleactionUtils.GetType("#u.#d4c+#g4c"));
					r_R__0__N3c___0__g4c.SetBelong(this.instance);
				}
				return r_R__0__N3c___0__g4c;
			}
		}

		/// <summary>
		/// Void #O3c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__O3c_ID;
		public virtual RMethod R__0__O3c_ID
		{
			get
			{
				if(r_R__0__O3c_ID == null)
				{
					r_R__0__O3c_ID = new(this, "#O3c", 0, typeof(GameDefineType.ID));
					r_R__0__O3c_ID.SetBelong(this.instance);
				}
				return r_R__0__O3c_ID;
			}
		}

		/// <summary>
		/// Void #P3c(#g4c)
		/// </summary>
		protected RMethod r_R__0__P3c___0__g4c;
		public virtual RMethod R__0__P3c___0__g4c
		{
			get
			{
				if(r_R__0__P3c___0__g4c == null)
				{
					r_R__0__P3c___0__g4c = new(this, "#P3c", 0,  ReleactionUtils.GetType("#u.#d4c+#g4c"));
					r_R__0__P3c___0__g4c.SetBelong(this.instance);
				}
				return r_R__0__P3c___0__g4c;
			}
		}

		/// <summary>
		/// Void #P3c(System.String)
		/// </summary>
		protected RMethod r_R__0__P3c_String;
		public virtual RMethod R__0__P3c_String
		{
			get
			{
				if(r_R__0__P3c_String == null)
				{
					r_R__0__P3c_String = new(this, "#P3c", 0, typeof(System.String));
					r_R__0__P3c_String.SetBelong(this.instance);
				}
				return r_R__0__P3c_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#d4c+#f4c] #Q3c()
		/// </summary>
		protected RMethod r_R__0__Q3c;
		public virtual RMethod R__0__Q3c
		{
			get
			{
				if(r_R__0__Q3c == null)
				{
					r_R__0__Q3c = new(this, "#Q3c", 0);
					r_R__0__Q3c.SetBelong(this.instance);
				}
				return r_R__0__Q3c;
			}
		}

		/// <summary>
		/// Void #R3c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__R3c_ID;
		public virtual RMethod R__0__R3c_ID
		{
			get
			{
				if(r_R__0__R3c_ID == null)
				{
					r_R__0__R3c_ID = new(this, "#R3c", 0, typeof(GameDefineType.ID));
					r_R__0__R3c_ID.SetBelong(this.instance);
				}
				return r_R__0__R3c_ID;
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
		/// Void #S3c()
		/// </summary>
		protected RMethod r_R__0__S3c;
		public virtual RMethod R__0__S3c
		{
			get
			{
				if(r_R__0__S3c == null)
				{
					r_R__0__S3c = new(this, "#S3c", 0);
					r_R__0__S3c.SetBelong(this.instance);
				}
				return r_R__0__S3c;
			}
		}

		/// <summary>
		/// Void #T3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__T3c_Object___0__Isb;
		public virtual RMethod R__0__T3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__T3c_Object___0__Isb == null)
				{
					r_R__0__T3c_Object___0__Isb = new(this, "#T3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__T3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__T3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #U3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__U3c_Object___0__Isb;
		public virtual RMethod R__0__U3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__U3c_Object___0__Isb == null)
				{
					r_R__0__U3c_Object___0__Isb = new(this, "#U3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__U3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__U3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #V3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__V3c_Object___0__Isb;
		public virtual RMethod R__0__V3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__V3c_Object___0__Isb == null)
				{
					r_R__0__V3c_Object___0__Isb = new(this, "#V3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__V3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__V3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #1Dd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__1Dd_Object___0__Isb;
		public virtual RMethod R__0__1Dd_Object___0__Isb
		{
			get
			{
				if(r_R__0__1Dd_Object___0__Isb == null)
				{
					r_R__0__1Dd_Object___0__Isb = new(this, "#1Dd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__1Dd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__1Dd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #W3c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__W3c_Object___0__Isb;
		public virtual RMethod R__0__W3c_Object___0__Isb
		{
			get
			{
				if(r_R__0__W3c_Object___0__Isb == null)
				{
					r_R__0__W3c_Object___0__Isb = new(this, "#W3c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__W3c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__W3c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #X3c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__X3c_ID;
		public virtual RMethod R__0__X3c_ID
		{
			get
			{
				if(r_R__0__X3c_ID == null)
				{
					r_R__0__X3c_ID = new(this, "#X3c", 0, typeof(GameDefineType.ID));
					r_R__0__X3c_ID.SetBelong(this.instance);
				}
				return r_R__0__X3c_ID;
			}
		}

		/// <summary>
		/// Void #Y3c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Y3c_ID;
		public virtual RMethod R__0__Y3c_ID
		{
			get
			{
				if(r_R__0__Y3c_ID == null)
				{
					r_R__0__Y3c_ID = new(this, "#Y3c", 0, typeof(GameDefineType.ID));
					r_R__0__Y3c_ID.SetBelong(this.instance);
				}
				return r_R__0__Y3c_ID;
			}
		}

		/// <summary>
		/// Void #Z3c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Z3c_ID;
		public virtual RMethod R__0__Z3c_ID
		{
			get
			{
				if(r_R__0__Z3c_ID == null)
				{
					r_R__0__Z3c_ID = new(this, "#Z3c", 0, typeof(GameDefineType.ID));
					r_R__0__Z3c_ID.SetBelong(this.instance);
				}
				return r_R__0__Z3c_ID;
			}
		}

		/// <summary>
		/// Void #mmj(System.String)
		/// </summary>
		protected RMethod r_R__0__mmj_String;
		public virtual RMethod R__0__mmj_String
		{
			get
			{
				if(r_R__0__mmj_String == null)
				{
					r_R__0__mmj_String = new(this, "#mmj", 0, typeof(System.String));
					r_R__0__mmj_String.SetBelong(this.instance);
				}
				return r_R__0__mmj_String;
			}
		}

		/// <summary>
		/// Void #6cd(System.String)
		/// </summary>
		protected RMethod r_R__0__6cd_String;
		public virtual RMethod R__0__6cd_String
		{
			get
			{
				if(r_R__0__6cd_String == null)
				{
					r_R__0__6cd_String = new(this, "#6cd", 0, typeof(System.String));
					r_R__0__6cd_String.SetBelong(this.instance);
				}
				return r_R__0__6cd_String;
			}
		}

		/// <summary>
		/// Void #03c(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__03c_Object_EventArgs;
		public virtual RMethod R__0__03c_Object_EventArgs
		{
			get
			{
				if(r_R__0__03c_Object_EventArgs == null)
				{
					r_R__0__03c_Object_EventArgs = new(this, "#03c", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__03c_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__03c_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #13c(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__13c_Object_ABLoadedArgs;
		public virtual RMethod R__0__13c_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__13c_Object_ABLoadedArgs == null)
				{
					r_R__0__13c_Object_ABLoadedArgs = new(this, "#13c", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__13c_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__13c_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #23c(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__23c_Object_ABLoadedArgs;
		public virtual RMethod R__0__23c_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__23c_Object_ABLoadedArgs == null)
				{
					r_R__0__23c_Object_ABLoadedArgs = new(this, "#23c", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__23c_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__23c_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #33c(System.String, EventHandler)
		/// </summary>
		protected RMethod r_R__0__33c_String_EventHandler;
		public virtual RMethod R__0__33c_String_EventHandler
		{
			get
			{
				if(r_R__0__33c_String_EventHandler == null)
				{
					r_R__0__33c_String_EventHandler = new(this, "#33c", 0, typeof(System.String), typeof(EventHandler));
					r_R__0__33c_String_EventHandler.SetBelong(this.instance);
				}
				return r_R__0__33c_String_EventHandler;
			}
		}

		/// <summary>
		/// Void #43c(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__43c_Object_EventArgs;
		public virtual RMethod R__0__43c_Object_EventArgs
		{
			get
			{
				if(r_R__0__43c_Object_EventArgs == null)
				{
					r_R__0__43c_Object_EventArgs = new(this, "#43c", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__43c_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__43c_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void EnterCombat(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_REnterCombat_Object_EventArgs;
		public virtual RMethod REnterCombat_Object_EventArgs
		{
			get
			{
				if(r_REnterCombat_Object_EventArgs == null)
				{
					r_REnterCombat_Object_EventArgs = new(this, "EnterCombat", 0, typeof(System.Object), typeof(System.EventArgs));
					r_REnterCombat_Object_EventArgs.SetBelong(this.instance);
				}
				return r_REnterCombat_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #53c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__53c_ID;
		public virtual RMethod R__0__53c_ID
		{
			get
			{
				if(r_R__0__53c_ID == null)
				{
					r_R__0__53c_ID = new(this, "#53c", 0, typeof(GameDefineType.ID));
					r_R__0__53c_ID.SetBelong(this.instance);
				}
				return r_R__0__53c_ID;
			}
		}

		/// <summary>
		/// Void CheckNpcResourceExist()
		/// </summary>
		protected RMethod r_RCheckNpcResourceExist;
		public virtual RMethod RCheckNpcResourceExist
		{
			get
			{
				if(r_RCheckNpcResourceExist == null)
				{
					r_RCheckNpcResourceExist = new(this, "CheckNpcResourceExist", 0);
					r_RCheckNpcResourceExist.SetBelong(this.instance);
				}
				return r_RCheckNpcResourceExist;
			}
		}

		/// <summary>
		/// Void #63c()
		/// </summary>
		protected RMethod r_R__0__63c;
		public virtual RMethod R__0__63c
		{
			get
			{
				if(r_R__0__63c == null)
				{
					r_R__0__63c = new(this, "#63c", 0);
					r_R__0__63c.SetBelong(this.instance);
				}
				return r_R__0__63c;
			}
		}

		/// <summary>
		/// Void #73c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__73c_Object___0__Isb;
		public virtual RMethod R__0__73c_Object___0__Isb
		{
			get
			{
				if(r_R__0__73c_Object___0__Isb == null)
				{
					r_R__0__73c_Object___0__Isb = new(this, "#73c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__73c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__73c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #83c(System.Type, #uOb)
		/// </summary>
		protected RMethod r_R__0__83c_Type___0__uOb;
		public virtual RMethod R__0__83c_Type___0__uOb
		{
			get
			{
				if(r_R__0__83c_Type___0__uOb == null)
				{
					r_R__0__83c_Type___0__uOb = new(this, "#83c", 0, typeof(System.Type),  ReleactionUtils.GetType("#u.#d4c+#uOb"));
					r_R__0__83c_Type___0__uOb.SetBelong(this.instance);
				}
				return r_R__0__83c_Type___0__uOb;
			}
		}

		/// <summary>
		/// Void #93c(System.Type)
		/// </summary>
		protected RMethod r_R__0__93c_Type;
		public virtual RMethod R__0__93c_Type
		{
			get
			{
				if(r_R__0__93c_Type == null)
				{
					r_R__0__93c_Type = new(this, "#93c", 0, typeof(System.Type));
					r_R__0__93c_Type.SetBelong(this.instance);
				}
				return r_R__0__93c_Type;
			}
		}

		/// <summary>
		/// Void #a4c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__a4c_ID;
		public virtual RMethod R__0__a4c_ID
		{
			get
			{
				if(r_R__0__a4c_ID == null)
				{
					r_R__0__a4c_ID = new(this, "#a4c", 0, typeof(GameDefineType.ID));
					r_R__0__a4c_ID.SetBelong(this.instance);
				}
				return r_R__0__a4c_ID;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #b4c(GameDefineType.ID, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__b4c_ID_GameObject;
		public virtual RMethod R__0__b4c_ID_GameObject
		{
			get
			{
				if(r_R__0__b4c_ID_GameObject == null)
				{
					r_R__0__b4c_ID_GameObject = new(this, "#b4c", 0, typeof(GameDefineType.ID), typeof(UnityEngine.GameObject));
					r_R__0__b4c_ID_GameObject.SetBelong(this.instance);
				}
				return r_R__0__b4c_ID_GameObject;
			}
		}

		/// <summary>
		/// Void #c4c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__c4c_ID;
		public virtual RMethod R__0__c4c_ID
		{
			get
			{
				if(r_R__0__c4c_ID == null)
				{
					r_R__0__c4c_ID = new(this, "#c4c", 0, typeof(GameDefineType.ID));
					r_R__0__c4c_ID.SetBelong(this.instance);
				}
				return r_R__0__c4c_ID;
			}
		}

		/// <summary>
		/// Void #Erh()
		/// </summary>
		protected RMethod r_R__0__Erh;
		public virtual RMethod R__0__Erh
		{
			get
			{
				if(r_R__0__Erh == null)
				{
					r_R__0__Erh = new(this, "#Erh", 0);
					r_R__0__Erh.SetBelong(this.instance);
				}
				return r_R__0__Erh;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #b4c(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__b4c_GameObject;
		public virtual RMethod R__0__b4c_GameObject
		{
			get
			{
				if(r_R__0__b4c_GameObject == null)
				{
					r_R__0__b4c_GameObject = new(this, "#b4c", 0, typeof(UnityEngine.GameObject));
					r_R__0__b4c_GameObject.SetBelong(this.instance);
				}
				return r_R__0__b4c_GameObject;
			}
		}

		/// <summary>
		/// Void #c4c()
		/// </summary>
		protected RMethod r_R__0__c4c;
		public virtual RMethod R__0__c4c
		{
			get
			{
				if(r_R__0__c4c == null)
				{
					r_R__0__c4c = new(this, "#c4c", 0);
					r_R__0__c4c.SetBelong(this.instance);
				}
				return r_R__0__c4c;
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


        public R__0__d4c() : base("#u.#d4c")
        {
        }

        public R__0__d4c(System.Object instance) : base("#u.#d4c")
		{
            SetInstance(instance);
		}

        public R__0__d4c(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__d4c(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__H3c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__H3c.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__I3c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__I3c.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String __0__L6c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__L6c.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }










        public virtual void __0__O3c(GameDefineType.ID  @idCombat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCombat};
            var ___result = R__0__O3c_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__P3c(System.String  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = R__0__P3c_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__Q3c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Q3c.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__R3c(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__R3c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__S3c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__S3c.Invoke(___genericsType, ___parameters);

            
        }







        public virtual void __0__X3c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__X3c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Y3c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__Y3c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Z3c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__Z3c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mmj(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = R__0__mmj_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6cd(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = R__0__6cd_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__03c(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__03c_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__33c(System.String  @param, EventHandler  @mHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@param, @mHandler};
            var ___result = R__0__33c_String_EventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__43c(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__43c_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnterCombat(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = REnterCombat_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__53c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__53c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNpcResourceExist()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNpcResourceExist.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__63c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__63c.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__93c(System.Type  @msgType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msgType};
            var ___result = R__0__93c_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__a4c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__a4c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__b4c(GameDefineType.ID  @idBattle, UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle, @obj};
            var ___result = R__0__b4c_ID_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__c4c(GameDefineType.ID  @idBattle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBattle};
            var ___result = R__0__c4c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Erh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Erh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__b4c(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__b4c_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__c4c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__c4c.Invoke(___genericsType, ___parameters);

            
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
