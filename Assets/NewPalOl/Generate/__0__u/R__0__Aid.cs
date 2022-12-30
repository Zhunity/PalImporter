using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Aid
	/// </summary>
    public partial class R__0__Aid : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#aid] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__aid> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__aid> R__0__a
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
		/// UnityEngine.Shader #b
		/// </summary>
		protected RUnityEngine.RShader r___0__b;
		public virtual RUnityEngine.RShader R__0__b
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
		/// System.String #c
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
		/// System.String #d
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
		/// System.Boolean #e
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
		/// NpcResStructHold #f
		/// </summary>
		protected RNpcResStructHold r___0__f;
		public virtual RNpcResStructHold R__0__f
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
		/// System.Func`2[#u.#aid,GameDefineType.ID] #g
		/// </summary>
		protected static RSystem.RFunc<R__0__u.R__0__aid, RGameDefineType.RID> r___0__g;
		public static RSystem.RFunc<R__0__u.R__0__aid, RGameDefineType.RID> R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("#u.#Aid"), "#g");
					r___0__g.SetBelong(null);
				}
				return r___0__g;
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
		/// UnityEngine.Shader NpcShader
		/// </summary>
		protected RUnityEngine.RShader r_R__0__bid;
		public virtual RUnityEngine.RShader R__0__bid
		{
			get
			{
				if(r_R__0__bid == null)
				{
					r_R__0__bid = new(this, "NpcShader", -1);
					r_R__0__bid.SetBelong(this.instance);
				}
				return r_R__0__bid;
			}
		}

		/// <summary>
		/// Void #cid()
		/// </summary>
		protected RMethod r_R__0__cid;
		public virtual RMethod R__0__cid
		{
			get
			{
				if(r_R__0__cid == null)
				{
					r_R__0__cid = new(this, "#cid", 0);
					r_R__0__cid.SetBelong(this.instance);
				}
				return r_R__0__cid;
			}
		}

		/// <summary>
		/// Void UnloadAssets()
		/// </summary>
		protected RMethod r_RUnloadAssets;
		public virtual RMethod RUnloadAssets
		{
			get
			{
				if(r_RUnloadAssets == null)
				{
					r_RUnloadAssets = new(this, "UnloadAssets", 0);
					r_RUnloadAssets.SetBelong(this.instance);
				}
				return r_RUnloadAssets;
			}
		}

		/// <summary>
		/// Void OnLoadNpcResourceConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadNpcResourceConfig_Object;
		public virtual RMethod ROnLoadNpcResourceConfig_Object
		{
			get
			{
				if(r_ROnLoadNpcResourceConfig_Object == null)
				{
					r_ROnLoadNpcResourceConfig_Object = new(this, "OnLoadNpcResourceConfig", 0, typeof(System.Object));
					r_ROnLoadNpcResourceConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadNpcResourceConfig_Object;
			}
		}

		/// <summary>
		/// Void #did()
		/// </summary>
		protected RMethod r_R__0__did;
		public virtual RMethod R__0__did
		{
			get
			{
				if(r_R__0__did == null)
				{
					r_R__0__did = new(this, "#did", 0);
					r_R__0__did.SetBelong(this.instance);
				}
				return r_R__0__did;
			}
		}

		/// <summary>
		/// System.String[] #fid(GameDefineType.ID, System.Object, #u.#tOb, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler = new(this, "#fid", 0, typeof(GameDefineType.ID), typeof(System.Object),  ReleactionUtils.GetType("#u.#tOb"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_R__0__fid_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// System.String[] #fid(GameDefineType.ID, GameDefineType.ID, System.Object, #u.#tOb, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler = new(this, "#fid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Object),  ReleactionUtils.GetType("#u.#tOb"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_R__0__fid_ID_ID_Object___0__tOb_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void #gid(GameDefineType.ID, #u.#tOb)
		/// </summary>
		protected RMethod r_R__0__gid_ID___0__tOb;
		public virtual RMethod R__0__gid_ID___0__tOb
		{
			get
			{
				if(r_R__0__gid_ID___0__tOb == null)
				{
					r_R__0__gid_ID___0__tOb = new(this, "#gid", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#tOb"));
					r_R__0__gid_ID___0__tOb.SetBelong(this.instance);
				}
				return r_R__0__gid_ID___0__tOb;
			}
		}

		/// <summary>
		/// Void #ost(GameDefineType.ID, #u.#tOb)
		/// </summary>
		protected RMethod r_R__0__ost_ID___0__tOb;
		public virtual RMethod R__0__ost_ID___0__tOb
		{
			get
			{
				if(r_R__0__ost_ID___0__tOb == null)
				{
					r_R__0__ost_ID___0__tOb = new(this, "#ost", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#tOb"));
					r_R__0__ost_ID___0__tOb.SetBelong(this.instance);
				}
				return r_R__0__ost_ID___0__tOb;
			}
		}

		/// <summary>
		/// Void #Xei(GameDefineType.ID, #u.#tOb)
		/// </summary>
		protected RMethod r_R__0__Xei_ID___0__tOb;
		public virtual RMethod R__0__Xei_ID___0__tOb
		{
			get
			{
				if(r_R__0__Xei_ID___0__tOb == null)
				{
					r_R__0__Xei_ID___0__tOb = new(this, "#Xei", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#tOb"));
					r_R__0__Xei_ID___0__tOb.SetBelong(this.instance);
				}
				return r_R__0__Xei_ID___0__tOb;
			}
		}

		/// <summary>
		/// Void #Ifo(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__Ifo_Object_ABLoadedArgs;
		public virtual RMethod R__0__Ifo_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__Ifo_Object_ABLoadedArgs == null)
				{
					r_R__0__Ifo_Object_ABLoadedArgs = new(this, "#Ifo", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__Ifo_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__Ifo_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #hid(GameDefineType.ID, Int32, Single)
		/// </summary>
		protected RMethod r_R__0__hid_ID_Int32_Single;
		public virtual RMethod R__0__hid_ID_Int32_Single
		{
			get
			{
				if(r_R__0__hid_ID_Int32_Single == null)
				{
					r_R__0__hid_ID_Int32_Single = new(this, "#hid", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Single));
					r_R__0__hid_ID_Int32_Single.SetBelong(this.instance);
				}
				return r_R__0__hid_ID_Int32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #hid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__hid_ID;
		public virtual RMethod R__0__hid_ID
		{
			get
			{
				if(r_R__0__hid_ID == null)
				{
					r_R__0__hid_ID = new(this, "#hid", 0, typeof(GameDefineType.ID));
					r_R__0__hid_ID.SetBelong(this.instance);
				}
				return r_R__0__hid_ID;
			}
		}

		/// <summary>
		/// Boolean #iid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__iid_ID;
		public virtual RMethod R__0__iid_ID
		{
			get
			{
				if(r_R__0__iid_ID == null)
				{
					r_R__0__iid_ID = new(this, "#iid", 0, typeof(GameDefineType.ID));
					r_R__0__iid_ID.SetBelong(this.instance);
				}
				return r_R__0__iid_ID;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #jid(GameDefineType.ID, #u.#tOb)
		/// </summary>
		protected RMethod r_R__0__jid_ID___0__tOb;
		public virtual RMethod R__0__jid_ID___0__tOb
		{
			get
			{
				if(r_R__0__jid_ID___0__tOb == null)
				{
					r_R__0__jid_ID___0__tOb = new(this, "#jid", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#tOb"));
					r_R__0__jid_ID___0__tOb.SetBelong(this.instance);
				}
				return r_R__0__jid_ID___0__tOb;
			}
		}

		/// <summary>
		/// Void #jid(GameDefineType.ID, #u.#tOb, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__jid_ID___0__tOb_GameObject;
		public virtual RMethod R__0__jid_ID___0__tOb_GameObject
		{
			get
			{
				if(r_R__0__jid_ID___0__tOb_GameObject == null)
				{
					r_R__0__jid_ID___0__tOb_GameObject = new(this, "#jid", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#tOb"), typeof(UnityEngine.GameObject));
					r_R__0__jid_ID___0__tOb_GameObject.SetBelong(this.instance);
				}
				return r_R__0__jid_ID___0__tOb_GameObject;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #kid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__kid_ID;
		public virtual RMethod R__0__kid_ID
		{
			get
			{
				if(r_R__0__kid_ID == null)
				{
					r_R__0__kid_ID = new(this, "#kid", 0, typeof(GameDefineType.ID));
					r_R__0__kid_ID.SetBelong(this.instance);
				}
				return r_R__0__kid_ID;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #kid(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__kid_ID_Int32;
		public virtual RMethod R__0__kid_ID_Int32
		{
			get
			{
				if(r_R__0__kid_ID_Int32 == null)
				{
					r_R__0__kid_ID_Int32 = new(this, "#kid", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__kid_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__kid_ID_Int32;
			}
		}

		/// <summary>
		/// Void #lid(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__lid_ID_Int32;
		public virtual RMethod R__0__lid_ID_Int32
		{
			get
			{
				if(r_R__0__lid_ID_Int32 == null)
				{
					r_R__0__lid_ID_Int32 = new(this, "#lid", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__lid_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__lid_ID_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #mid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__mid_ID;
		public virtual RMethod R__0__mid_ID
		{
			get
			{
				if(r_R__0__mid_ID == null)
				{
					r_R__0__mid_ID = new(this, "#mid", 0, typeof(GameDefineType.ID));
					r_R__0__mid_ID.SetBelong(this.instance);
				}
				return r_R__0__mid_ID;
			}
		}

		/// <summary>
		/// Void #nid(System.Object, #u.#egb)
		/// </summary>
		protected RMethod r_R__0__nid_Object___0__egb;
		public virtual RMethod R__0__nid_Object___0__egb
		{
			get
			{
				if(r_R__0__nid_Object___0__egb == null)
				{
					r_R__0__nid_Object___0__egb = new(this, "#nid", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#egb"));
					r_R__0__nid_Object___0__egb.SetBelong(this.instance);
				}
				return r_R__0__nid_Object___0__egb;
			}
		}

		/// <summary>
		/// #u.#aid #oid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__oid_ID;
		public virtual RMethod R__0__oid_ID
		{
			get
			{
				if(r_R__0__oid_ID == null)
				{
					r_R__0__oid_ID = new(this, "#oid", 0, typeof(GameDefineType.ID));
					r_R__0__oid_ID.SetBelong(this.instance);
				}
				return r_R__0__oid_ID;
			}
		}

		/// <summary>
		/// #u.#aid #pid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__pid_ID;
		public virtual RMethod R__0__pid_ID
		{
			get
			{
				if(r_R__0__pid_ID == null)
				{
					r_R__0__pid_ID = new(this, "#pid", 0, typeof(GameDefineType.ID));
					r_R__0__pid_ID.SetBelong(this.instance);
				}
				return r_R__0__pid_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID #qid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__qid_ID;
		public virtual RMethod R__0__qid_ID
		{
			get
			{
				if(r_R__0__qid_ID == null)
				{
					r_R__0__qid_ID = new(this, "#qid", 0, typeof(GameDefineType.ID));
					r_R__0__qid_ID.SetBelong(this.instance);
				}
				return r_R__0__qid_ID;
			}
		}

		/// <summary>
		/// #u.#aid #rid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__rid_ID;
		public virtual RMethod R__0__rid_ID
		{
			get
			{
				if(r_R__0__rid_ID == null)
				{
					r_R__0__rid_ID = new(this, "#rid", 0, typeof(GameDefineType.ID));
					r_R__0__rid_ID.SetBelong(this.instance);
				}
				return r_R__0__rid_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID #sid(System.String)
		/// </summary>
		protected RMethod r_R__0__sid_String;
		public virtual RMethod R__0__sid_String
		{
			get
			{
				if(r_R__0__sid_String == null)
				{
					r_R__0__sid_String = new(this, "#sid", 0, typeof(System.String));
					r_R__0__sid_String.SetBelong(this.instance);
				}
				return r_R__0__sid_String;
			}
		}

		/// <summary>
		/// Void #tid(System.String, System.Collections.Generic.List`1[System.String] ByRef)
		/// </summary>
		protected RMethod r_R__0__tid_String_Ref_List_d_String_p_;
		public virtual RMethod R__0__tid_String_Ref_List_d_String_p_
		{
			get
			{
				if(r_R__0__tid_String_Ref_List_d_String_p_ == null)
				{
					r_R__0__tid_String_Ref_List_d_String_p_ = new(this, "#tid", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)).MakeByRefType());
					r_R__0__tid_String_Ref_List_d_String_p_.SetBelong(this.instance);
				}
				return r_R__0__tid_String_Ref_List_d_String_p_;
			}
		}

		/// <summary>
		/// Boolean #uid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__uid_ID;
		public virtual RMethod R__0__uid_ID
		{
			get
			{
				if(r_R__0__uid_ID == null)
				{
					r_R__0__uid_ID = new(this, "#uid", 0, typeof(GameDefineType.ID));
					r_R__0__uid_ID.SetBelong(this.instance);
				}
				return r_R__0__uid_ID;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList #vid()
		/// </summary>
		protected RMethod r_R__0__vid;
		public virtual RMethod R__0__vid
		{
			get
			{
				if(r_R__0__vid == null)
				{
					r_R__0__vid = new(this, "#vid", 0);
					r_R__0__vid.SetBelong(this.instance);
				}
				return r_R__0__vid;
			}
		}

		/// <summary>
		/// System.String #wid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__wid_ID;
		public virtual RMethod R__0__wid_ID
		{
			get
			{
				if(r_R__0__wid_ID == null)
				{
					r_R__0__wid_ID = new(this, "#wid", 0, typeof(GameDefineType.ID));
					r_R__0__wid_ID.SetBelong(this.instance);
				}
				return r_R__0__wid_ID;
			}
		}

		/// <summary>
		/// System.String #xid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__xid_ID;
		public virtual RMethod R__0__xid_ID
		{
			get
			{
				if(r_R__0__xid_ID == null)
				{
					r_R__0__xid_ID = new(this, "#xid", 0, typeof(GameDefineType.ID));
					r_R__0__xid_ID.SetBelong(this.instance);
				}
				return r_R__0__xid_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[#u.#aid] #yid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__yid_ID;
		public virtual RMethod R__0__yid_ID
		{
			get
			{
				if(r_R__0__yid_ID == null)
				{
					r_R__0__yid_ID = new(this, "#yid", 0, typeof(GameDefineType.ID));
					r_R__0__yid_ID.SetBelong(this.instance);
				}
				return r_R__0__yid_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID #57r(#u.#aid)
		/// </summary>
		protected static RMethod r_R__0__57r___0__aid;
		public static RMethod R__0__57r___0__aid
		{
			get
			{
				if(r_R__0__57r___0__aid == null)
				{
					r_R__0__57r___0__aid = new( ReleactionUtils.GetType("#u.#Aid"), "#57r", 0,  ReleactionUtils.GetType("#u.#aid"));
					r_R__0__57r___0__aid.SetBelong(null);
				}
				return r_R__0__57r___0__aid;
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


        public R__0__Aid() : base("#u.#Aid")
        {
        }

        public R__0__Aid(System.Object instance) : base("#u.#Aid")
		{
            SetInstance(instance);
		}

        public R__0__Aid(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Aid(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__cid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__cid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnloadAssets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnloadAssets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadNpcResourceConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadNpcResourceConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__did()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__did.Invoke(___genericsType, ___parameters);

            
        }








        public virtual UnityEngine.GameObject __0__hid(GameDefineType.ID  @resId, System.Int32  @tenseiLevel, System.Single  @ratio)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resId, @tenseiLevel, @ratio};
            var ___result = R__0__hid_ID_Int32_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual UnityEngine.GameObject __0__hid(GameDefineType.ID  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resId};
            var ___result = R__0__hid_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual System.Boolean __0__iid(GameDefineType.ID  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resId};
            var ___result = R__0__iid_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual UnityEngine.GameObject __0__kid(GameDefineType.ID  @npcId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@npcId};
            var ___result = R__0__kid_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual UnityEngine.GameObject __0__kid(GameDefineType.ID  @npcId, System.Int32  @tenseiLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@npcId, @tenseiLevel};
            var ___result = R__0__kid_ID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void __0__lid(GameDefineType.ID  @id, System.Int32  @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @flag};
            var ___result = R__0__lid_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject __0__mid(GameDefineType.ID  @npcId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@npcId};
            var ___result = R__0__mid_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }



        public virtual System.Object __0__oid(GameDefineType.ID  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resId};
            var ___result = R__0__oid_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__pid(GameDefineType.ID  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = R__0__pid_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual GameDefineType.ID __0__qid(GameDefineType.ID  @idCarrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCarrer};
            var ___result = R__0__qid_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Object __0__rid(GameDefineType.ID  @npcID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@npcID};
            var ___result = R__0__rid_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual GameDefineType.ID __0__sid(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__sid_String.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void __0__tid(System.String  @part, ref System.Collections.Generic.List<System.String>  @namelist)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@part, @namelist};
            var ___result = R__0__tid_String_Ref_List_d_String_p_.Invoke(___genericsType, ___parameters);
			namelist = (System.Collections.Generic.List<System.String>)___parameters[1];

            
        }


        public virtual System.Boolean __0__uid(GameDefineType.ID  @resid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resid};
            var ___result = R__0__uid_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.ArrayList __0__vid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__vid.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.String __0__wid(GameDefineType.ID  @resid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resid};
            var ___result = R__0__wid_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__xid(GameDefineType.ID  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = R__0__xid_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object __0__yid(GameDefineType.ID  @resID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resID};
            var ___result = R__0__yid_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
