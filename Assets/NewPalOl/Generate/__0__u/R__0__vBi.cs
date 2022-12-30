using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#vBi
	/// </summary>
    public partial class R__0__vBi : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("#u.#vBi"), "#a");
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
					r___0__b = new( ReleactionUtils.GetType("#u.#vBi"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.String #c
		/// </summary>
		protected static RField r___0__c;
		public static RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("#u.#vBi"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.String #d
		/// </summary>
		protected static RField r___0__d;
		public static RField R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new( ReleactionUtils.GetType("#u.#vBi"), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.Boolean] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIDictionary<RField, RField> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RIDictionary<RField, RField> R__0__e
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
		/// Void #iBi(CHAT_CHANNEL, GameDefineType.ID, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__iBi_CHAT_CHANNEL_ID_String_String;
		public virtual RMethod R__0__iBi_CHAT_CHANNEL_ID_String_String
		{
			get
			{
				if(r_R__0__iBi_CHAT_CHANNEL_ID_String_String == null)
				{
					r_R__0__iBi_CHAT_CHANNEL_ID_String_String = new(this, "#iBi", 0,  ReleactionUtils.GetType("CHAT_CHANNEL"), typeof(GameDefineType.ID), typeof(System.String), typeof(System.String));
					r_R__0__iBi_CHAT_CHANNEL_ID_String_String.SetBelong(this.instance);
				}
				return r_R__0__iBi_CHAT_CHANNEL_ID_String_String;
			}
		}

		/// <summary>
		/// Void OnSceneChange()
		/// </summary>
		protected RMethod r_ROnSceneChange;
		public virtual RMethod ROnSceneChange
		{
			get
			{
				if(r_ROnSceneChange == null)
				{
					r_ROnSceneChange = new(this, "OnSceneChange", 0);
					r_ROnSceneChange.SetBelong(this.instance);
				}
				return r_ROnSceneChange;
			}
		}

		/// <summary>
		/// Void #Cjb(Int32)
		/// </summary>
		protected RMethod r_R__0__Cjb_Int32;
		public virtual RMethod R__0__Cjb_Int32
		{
			get
			{
				if(r_R__0__Cjb_Int32 == null)
				{
					r_R__0__Cjb_Int32 = new(this, "#Cjb", 0, typeof(System.Int32));
					r_R__0__Cjb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Cjb_Int32;
			}
		}

		/// <summary>
		/// System.String #cei(System.String)
		/// </summary>
		protected static RMethod r_R__0__cei_String;
		public static RMethod R__0__cei_String
		{
			get
			{
				if(r_R__0__cei_String == null)
				{
					r_R__0__cei_String = new( ReleactionUtils.GetType("#u.#vBi"), "#cei", 0, typeof(System.String));
					r_R__0__cei_String.SetBelong(null);
				}
				return r_R__0__cei_String;
			}
		}

		/// <summary>
		/// Void #jBi(CHAT_CHANNEL, GameDefineType.ID, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__jBi_CHAT_CHANNEL_ID_String_String;
		public virtual RMethod R__0__jBi_CHAT_CHANNEL_ID_String_String
		{
			get
			{
				if(r_R__0__jBi_CHAT_CHANNEL_ID_String_String == null)
				{
					r_R__0__jBi_CHAT_CHANNEL_ID_String_String = new(this, "#jBi", 0,  ReleactionUtils.GetType("CHAT_CHANNEL"), typeof(GameDefineType.ID), typeof(System.String), typeof(System.String));
					r_R__0__jBi_CHAT_CHANNEL_ID_String_String.SetBelong(this.instance);
				}
				return r_R__0__jBi_CHAT_CHANNEL_ID_String_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #bei(CHAT_CHANNEL, GameDefineType.ID, System.String, System.String, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject;
		public virtual RMethod R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject
		{
			get
			{
				if(r_R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject == null)
				{
					r_R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject = new(this, "#bei", 0,  ReleactionUtils.GetType("CHAT_CHANNEL"), typeof(GameDefineType.ID), typeof(System.String), typeof(System.String), typeof(UnityEngine.GameObject));
					r_R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject.SetBelong(this.instance);
				}
				return r_R__0__bei_CHAT_CHANNEL_ID_String_String_GameObject;
			}
		}

		/// <summary>
		/// Void #kBi(CHAT_CHANNEL, GameDefineType.ID, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__kBi_CHAT_CHANNEL_ID_String_String;
		public virtual RMethod R__0__kBi_CHAT_CHANNEL_ID_String_String
		{
			get
			{
				if(r_R__0__kBi_CHAT_CHANNEL_ID_String_String == null)
				{
					r_R__0__kBi_CHAT_CHANNEL_ID_String_String = new(this, "#kBi", 0,  ReleactionUtils.GetType("CHAT_CHANNEL"), typeof(GameDefineType.ID), typeof(System.String), typeof(System.String));
					r_R__0__kBi_CHAT_CHANNEL_ID_String_String.SetBelong(this.instance);
				}
				return r_R__0__kBi_CHAT_CHANNEL_ID_String_String;
			}
		}

		/// <summary>
		/// Void #lBi()
		/// </summary>
		protected RMethod r_R__0__lBi;
		public virtual RMethod R__0__lBi
		{
			get
			{
				if(r_R__0__lBi == null)
				{
					r_R__0__lBi = new(this, "#lBi", 0);
					r_R__0__lBi.SetBelong(this.instance);
				}
				return r_R__0__lBi;
			}
		}

		/// <summary>
		/// Void #mBi(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__mBi_String_String_String_String;
		public virtual RMethod R__0__mBi_String_String_String_String
		{
			get
			{
				if(r_R__0__mBi_String_String_String_String == null)
				{
					r_R__0__mBi_String_String_String_String = new(this, "#mBi", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_R__0__mBi_String_String_String_String.SetBelong(this.instance);
				}
				return r_R__0__mBi_String_String_String_String;
			}
		}

		/// <summary>
		/// Void #nBi(System.String, System.String, System.String, System.String, System.Action`1[System.Boolean])
		/// </summary>
		protected RMethod r_R__0__nBi_String_String_String_String_Action_d_Boolean_p_;
		public virtual RMethod R__0__nBi_String_String_String_String_Action_d_Boolean_p_
		{
			get
			{
				if(r_R__0__nBi_String_String_String_String_Action_d_Boolean_p_ == null)
				{
					r_R__0__nBi_String_String_String_String_Action_d_Boolean_p_ = new(this, "#nBi", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)));
					r_R__0__nBi_String_String_String_String_Action_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R__0__nBi_String_String_String_String_Action_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #0Ni(System.String, System.String, System.String, System.String, System.Action`1[System.Boolean], UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject;
		public virtual RMethod R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject
		{
			get
			{
				if(r_R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject == null)
				{
					r_R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject = new(this, "#0Ni", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)), typeof(UnityEngine.GameObject));
					r_R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject.SetBelong(this.instance);
				}
				return r_R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject;
			}
		}

		/// <summary>
		/// Void #oBi(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_R__0__oBi_IDictionary_d_String_Object_p_;
		public virtual RMethod R__0__oBi_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_R__0__oBi_IDictionary_d_String_Object_p_ == null)
				{
					r_R__0__oBi_IDictionary_d_String_Object_p_ = new(this, "#oBi", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_R__0__oBi_IDictionary_d_String_Object_p_.SetBelong(this.instance);
				}
				return r_R__0__oBi_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// System.String #pBi(System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__pBi_String_String_String_String;
		public virtual RMethod R__0__pBi_String_String_String_String
		{
			get
			{
				if(r_R__0__pBi_String_String_String_String == null)
				{
					r_R__0__pBi_String_String_String_String = new(this, "#pBi", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_R__0__pBi_String_String_String_String.SetBelong(this.instance);
				}
				return r_R__0__pBi_String_String_String_String;
			}
		}

		/// <summary>
		/// Void #qBi(System.String, System.String, System.String, #wBi, System.String, System.String, System.String, System.Action`1[System.Boolean])
		/// </summary>
		protected RMethod r_R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_;
		public virtual RMethod R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_
		{
			get
			{
				if(r_R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_ == null)
				{
					r_R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_ = new(this, "#qBi", 0, typeof(System.String), typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("#u.#vBi+#wBi"), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)));
					r_R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R__0__qBi_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void #od(System.String, System.String, System.String, #wBi, System.String, System.String, System.String, System.Action`1[System.Boolean])
		/// </summary>
		protected RMethod r_R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_;
		public virtual RMethod R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_
		{
			get
			{
				if(r_R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_ == null)
				{
					r_R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_ = new(this, "#od", 0, typeof(System.String), typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("#u.#vBi+#wBi"), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)));
					r_R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R__0__od_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #1Ni(System.String, System.String, System.String, #wBi, System.String, System.String, System.String, System.Action`1[System.Boolean], UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject;
		public virtual RMethod R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject
		{
			get
			{
				if(r_R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject == null)
				{
					r_R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject = new(this, "#1Ni", 0, typeof(System.String), typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("#u.#vBi+#wBi"), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)), typeof(UnityEngine.GameObject));
					r_R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject.SetBelong(this.instance);
				}
				return r_R__0__1Ni_String_String_String___0__wBi_String_String_String_Action_d_Boolean_p__GameObject;
			}
		}

		/// <summary>
		/// Void #rBi(System.String, System.String, System.String, System.String, System.Action`1[System.Boolean])
		/// </summary>
		protected RMethod r_R__0__rBi_String_String_String_String_Action_d_Boolean_p_;
		public virtual RMethod R__0__rBi_String_String_String_String_Action_d_Boolean_p_
		{
			get
			{
				if(r_R__0__rBi_String_String_String_String_Action_d_Boolean_p_ == null)
				{
					r_R__0__rBi_String_String_String_String_Action_d_Boolean_p_ = new(this, "#rBi", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.Boolean)));
					r_R__0__rBi_String_String_String_String_Action_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R__0__rBi_String_String_String_String_Action_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void #sBi(System.String, Int32, System.String, System.String, System.String, Int32, System.String, #MBi)
		/// </summary>
		protected RMethod r_R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi;
		public virtual RMethod R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi
		{
			get
			{
				if(r_R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi == null)
				{
					r_R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi = new(this, "#sBi", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.String),  ReleactionUtils.GetType("#u.#vBi+#MBi"));
					r_R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi.SetBelong(this.instance);
				}
				return r_R__0__sBi_String_Int32_String_String_String_Int32_String___0__MBi;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #2Ni(System.String, System.Collections.Generic.IDictionary`2[System.String,System.Object], UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject;
		public virtual RMethod R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject
		{
			get
			{
				if(r_R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject == null)
				{
					r_R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject = new(this, "#2Ni", 0, typeof(System.String), typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)), typeof(UnityEngine.GameObject));
					r_R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject.SetBelong(this.instance);
				}
				return r_R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject;
			}
		}

		/// <summary>
		/// System.String #tBi(System.Collections.Generic.IDictionary`2[System.String,System.Object], #MBi)
		/// </summary>
		protected RMethod r_R__0__tBi_IDictionary_d_String_Object_p____0__MBi;
		public virtual RMethod R__0__tBi_IDictionary_d_String_Object_p____0__MBi
		{
			get
			{
				if(r_R__0__tBi_IDictionary_d_String_Object_p____0__MBi == null)
				{
					r_R__0__tBi_IDictionary_d_String_Object_p____0__MBi = new(this, "#tBi", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)),  ReleactionUtils.GetType("#u.#vBi+#MBi"));
					r_R__0__tBi_IDictionary_d_String_Object_p____0__MBi.SetBelong(this.instance);
				}
				return r_R__0__tBi_IDictionary_d_String_Object_p____0__MBi;
			}
		}

		/// <summary>
		/// System.String #Feb(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_R__0__Feb_IDictionary_d_String_Object_p_;
		public virtual RMethod R__0__Feb_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_R__0__Feb_IDictionary_d_String_Object_p_ == null)
				{
					r_R__0__Feb_IDictionary_d_String_Object_p_ = new(this, "#Feb", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_R__0__Feb_IDictionary_d_String_Object_p_.SetBelong(this.instance);
				}
				return r_R__0__Feb_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// System.String #uBi(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_R__0__uBi_IDictionary_d_String_Object_p_;
		public virtual RMethod R__0__uBi_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_R__0__uBi_IDictionary_d_String_Object_p_ == null)
				{
					r_R__0__uBi_IDictionary_d_String_Object_p_ = new(this, "#uBi", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_R__0__uBi_IDictionary_d_String_Object_p_.SetBelong(this.instance);
				}
				return r_R__0__uBi_IDictionary_d_String_Object_p_;
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


        public R__0__vBi() : base("#u.#vBi")
        {
        }

        public R__0__vBi(System.Object instance) : base("#u.#vBi")
		{
            SetInstance(instance);
		}

        public R__0__vBi(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__vBi(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual void OnSceneChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSceneChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cjb(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Cjb_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String __0__cei(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = R__0__cei_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual void __0__lBi()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__lBi.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mBi(System.String  @toUserRoleName, System.String  @gameSceneId, System.String  @serverId, System.String  @gameId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUserRoleName, @gameSceneId, @serverId, @gameId};
            var ___result = R__0__mBi_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nBi(System.String  @toUserRoleName, System.String  @gameSceneId, System.String  @serverId, System.String  @gameId, System.Action<System.Boolean>  @onGet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUserRoleName, @gameSceneId, @serverId, @gameId, @onGet};
            var ___result = R__0__nBi_String_String_String_String_Action_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__0Ni(System.String  @toUserRoleName, System.String  @gameSceneId, System.String  @serverId, System.String  @gameId, System.Action<System.Boolean>  @onGet, UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUserRoleName, @gameSceneId, @serverId, @gameId, @onGet, @obj};
            var ___result = R__0__0Ni_String_String_String_String_Action_d_Boolean_p__GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__oBi(System.Collections.Generic.IDictionary<System.String, System.Object>  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__oBi_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__pBi(System.String  @toUserRoleName, System.String  @gameSceneId, System.String  @serverId, System.String  @gameId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUserRoleName, @gameSceneId, @serverId, @gameId};
            var ___result = R__0__pBi_String_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual void __0__rBi(System.String  @toUserRoleName, System.String  @gameSceneId, System.String  @serverId, System.String  @gameId, System.Action<System.Boolean>  @onGet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUserRoleName, @gameSceneId, @serverId, @gameId, @onGet};
            var ___result = R__0__rBi_String_String_String_String_Action_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator __0__2Ni(System.String  @Url, System.Collections.Generic.IDictionary<System.String, System.Object>  @data, UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Url, @data, @obj};
            var ___result = R__0__2Ni_String_IDictionary_d_String_Object_p__GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual System.String __0__Feb(System.Collections.Generic.IDictionary<System.String, System.Object>  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Feb_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__uBi(System.Collections.Generic.IDictionary<System.String, System.Object>  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__uBi_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

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
