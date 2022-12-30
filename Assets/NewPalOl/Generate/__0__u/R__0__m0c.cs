using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#m0c
	/// </summary>
    public partial class R__0__m0c : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,PrestigeConfig] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RPrestigeConfig> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RPrestigeConfig> R__0__a
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
		/// KeyValueContent #b
		/// </summary>
		protected RKeyValueContent r___0__b;
		public virtual RKeyValueContent R__0__b
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
		/// System.Func`2[System.Int32,System.Int32] #d
		/// </summary>
		protected static RSystem.RFunc<RField, RField> r___0__d;
		public static RSystem.RFunc<RField, RField> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new( ReleactionUtils.GetType("#u.#m0c"), "#d");
					r___0__d.SetBelong(null);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// Boolean CanGetAward
		/// </summary>
		protected RProperty r_R__0__QQd;
		public virtual RProperty R__0__QQd
		{
			get
			{
				if(r_R__0__QQd == null)
				{
					r_R__0__QQd = new(this, "CanGetAward", -1);
					r_R__0__QQd.SetBelong(this.instance);
				}
				return r_R__0__QQd;
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
		/// Void OnLoadPrestigeItemConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPrestigeItemConfig_Object;
		public virtual RMethod ROnLoadPrestigeItemConfig_Object
		{
			get
			{
				if(r_ROnLoadPrestigeItemConfig_Object == null)
				{
					r_ROnLoadPrestigeItemConfig_Object = new(this, "OnLoadPrestigeItemConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPrestigeItemConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPrestigeItemConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadPrestigeConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPrestigeConfig_Object;
		public virtual RMethod ROnLoadPrestigeConfig_Object
		{
			get
			{
				if(r_ROnLoadPrestigeConfig_Object == null)
				{
					r_ROnLoadPrestigeConfig_Object = new(this, "OnLoadPrestigeConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPrestigeConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPrestigeConfig_Object;
			}
		}

		/// <summary>
		/// Void #f0c(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__f0c_Object___0__Isb;
		public virtual RMethod R__0__f0c_Object___0__Isb
		{
			get
			{
				if(r_R__0__f0c_Object___0__Isb == null)
				{
					r_R__0__f0c_Object___0__Isb = new(this, "#f0c", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__f0c_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__f0c_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #BFd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__BFd_Object___0__Isb;
		public virtual RMethod R__0__BFd_Object___0__Isb
		{
			get
			{
				if(r_R__0__BFd_Object___0__Isb == null)
				{
					r_R__0__BFd_Object___0__Isb = new(this, "#BFd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__BFd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__BFd_Object___0__Isb;
			}
		}

		/// <summary>
		/// PrestigeConfig #CFd(Int32)
		/// </summary>
		protected RMethod r_R__0__CFd_Int32;
		public virtual RMethod R__0__CFd_Int32
		{
			get
			{
				if(r_R__0__CFd_Int32 == null)
				{
					r_R__0__CFd_Int32 = new(this, "#CFd", 0, typeof(System.Int32));
					r_R__0__CFd_Int32.SetBelong(this.instance);
				}
				return r_R__0__CFd_Int32;
			}
		}

		/// <summary>
		/// PrestigeConfig #DFd(Int32)
		/// </summary>
		protected RMethod r_R__0__DFd_Int32;
		public virtual RMethod R__0__DFd_Int32
		{
			get
			{
				if(r_R__0__DFd_Int32 == null)
				{
					r_R__0__DFd_Int32 = new(this, "#DFd", 0, typeof(System.Int32));
					r_R__0__DFd_Int32.SetBelong(this.instance);
				}
				return r_R__0__DFd_Int32;
			}
		}

		/// <summary>
		/// PrestigeConfig #EFd()
		/// </summary>
		protected RMethod r_R__0__EFd;
		public virtual RMethod R__0__EFd
		{
			get
			{
				if(r_R__0__EFd == null)
				{
					r_R__0__EFd = new(this, "#EFd", 0);
					r_R__0__EFd.SetBelong(this.instance);
				}
				return r_R__0__EFd;
			}
		}

		/// <summary>
		/// Int32 #SQd()
		/// </summary>
		protected RMethod r_R__0__SQd;
		public virtual RMethod R__0__SQd
		{
			get
			{
				if(r_R__0__SQd == null)
				{
					r_R__0__SQd = new(this, "#SQd", 0);
					r_R__0__SQd.SetBelong(this.instance);
				}
				return r_R__0__SQd;
			}
		}

		/// <summary>
		/// Int32 #g0c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__g0c_ID;
		public virtual RMethod R__0__g0c_ID
		{
			get
			{
				if(r_R__0__g0c_ID == null)
				{
					r_R__0__g0c_ID = new(this, "#g0c", 0, typeof(GameDefineType.ID));
					r_R__0__g0c_ID.SetBelong(this.instance);
				}
				return r_R__0__g0c_ID;
			}
		}

		/// <summary>
		/// Int32 #h0c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__h0c_ID;
		public virtual RMethod R__0__h0c_ID
		{
			get
			{
				if(r_R__0__h0c_ID == null)
				{
					r_R__0__h0c_ID = new(this, "#h0c", 0, typeof(GameDefineType.ID));
					r_R__0__h0c_ID.SetBelong(this.instance);
				}
				return r_R__0__h0c_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID #i0c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__i0c_ID;
		public virtual RMethod R__0__i0c_ID
		{
			get
			{
				if(r_R__0__i0c_ID == null)
				{
					r_R__0__i0c_ID = new(this, "#i0c", 0, typeof(GameDefineType.ID));
					r_R__0__i0c_ID.SetBelong(this.instance);
				}
				return r_R__0__i0c_ID;
			}
		}

		/// <summary>
		/// Void #j0c()
		/// </summary>
		protected RMethod r_R__0__j0c;
		public virtual RMethod R__0__j0c
		{
			get
			{
				if(r_R__0__j0c == null)
				{
					r_R__0__j0c = new(this, "#j0c", 0);
					r_R__0__j0c.SetBelong(this.instance);
				}
				return r_R__0__j0c;
			}
		}

		/// <summary>
		/// Void #k0c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__k0c_ID;
		public virtual RMethod R__0__k0c_ID
		{
			get
			{
				if(r_R__0__k0c_ID == null)
				{
					r_R__0__k0c_ID = new(this, "#k0c", 0, typeof(GameDefineType.ID));
					r_R__0__k0c_ID.SetBelong(this.instance);
				}
				return r_R__0__k0c_ID;
			}
		}

		/// <summary>
		/// Void #l0c()
		/// </summary>
		protected RMethod r_R__0__l0c;
		public virtual RMethod R__0__l0c
		{
			get
			{
				if(r_R__0__l0c == null)
				{
					r_R__0__l0c = new(this, "#l0c", 0);
					r_R__0__l0c.SetBelong(this.instance);
				}
				return r_R__0__l0c;
			}
		}

		/// <summary>
		/// Void #FFd()
		/// </summary>
		protected RMethod r_R__0__FFd;
		public virtual RMethod R__0__FFd
		{
			get
			{
				if(r_R__0__FFd == null)
				{
					r_R__0__FFd = new(this, "#FFd", 0);
					r_R__0__FFd.SetBelong(this.instance);
				}
				return r_R__0__FFd;
			}
		}

		/// <summary>
		/// Int32 #Ssx(Int32)
		/// </summary>
		protected static RMethod r_R__0__Ssx_Int32;
		public static RMethod R__0__Ssx_Int32
		{
			get
			{
				if(r_R__0__Ssx_Int32 == null)
				{
					r_R__0__Ssx_Int32 = new( ReleactionUtils.GetType("#u.#m0c"), "#Ssx", 0, typeof(System.Int32));
					r_R__0__Ssx_Int32.SetBelong(null);
				}
				return r_R__0__Ssx_Int32;
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


        public R__0__m0c() : base("#u.#m0c")
        {
        }

        public R__0__m0c(System.Object instance) : base("#u.#m0c")
		{
            SetInstance(instance);
		}

        public R__0__m0c(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__m0c(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadPrestigeItemConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadPrestigeItemConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadPrestigeConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadPrestigeConfig_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual PrestigeConfig __0__CFd(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__CFd_Int32.Invoke(___genericsType, ___parameters);

            return (PrestigeConfig)___result;
        }


        public virtual PrestigeConfig __0__DFd(System.Int32  @prestige)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prestige};
            var ___result = R__0__DFd_Int32.Invoke(___genericsType, ___parameters);

            return (PrestigeConfig)___result;
        }


        public virtual PrestigeConfig __0__EFd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__EFd.Invoke(___genericsType, ___parameters);

            return (PrestigeConfig)___result;
        }


        public virtual System.Int32 __0__SQd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__SQd.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__g0c(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__g0c_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__h0c(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__h0c_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual GameDefineType.ID __0__i0c(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__i0c_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void __0__j0c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__j0c.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__k0c(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__k0c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__l0c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__l0c.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__FFd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__FFd.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 __0__Ssx(System.Int32  @x)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x};
            var ___result = R__0__Ssx_Int32.Invoke(___genericsType, ___parameters);

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
