using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#w4p
	/// </summary>
    public partial class R__0__w4p : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("#u.#w4p"), "#a");
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
					r___0__b = new( ReleactionUtils.GetType("#u.#w4p"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GoddessInfo] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGoddessInfo> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<RGoddessInfo> R__0__c
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
		/// GoddessInfo #d
		/// </summary>
		protected RGoddessInfo r___0__d;
		public virtual RGoddessInfo R__0__d
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
		/// System.Int32 #e
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
		/// GoddessInfo LastLevelGoddessInfo
		/// </summary>
		protected RGoddessInfo r_R__0__j4p;
		public virtual RGoddessInfo R__0__j4p
		{
			get
			{
				if(r_R__0__j4p == null)
				{
					r_R__0__j4p = new(this, "LastLevelGoddessInfo", -1);
					r_R__0__j4p.SetBelong(this.instance);
				}
				return r_R__0__j4p;
			}
		}

		/// <summary>
		/// Int32 MOUNTED_SUPER_SKILL
		/// </summary>
		protected RProperty r_R__0__k4p;
		public virtual RProperty R__0__k4p
		{
			get
			{
				if(r_R__0__k4p == null)
				{
					r_R__0__k4p = new(this, "MOUNTED_SUPER_SKILL", -1);
					r_R__0__k4p.SetBelong(this.instance);
				}
				return r_R__0__k4p;
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
		/// Void #m4p(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__m4p_Object___0__Isb;
		public virtual RMethod R__0__m4p_Object___0__Isb
		{
			get
			{
				if(r_R__0__m4p_Object___0__Isb == null)
				{
					r_R__0__m4p_Object___0__Isb = new(this, "#m4p", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__m4p_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__m4p_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #n4p(System.String, Boolean ByRef)
		/// </summary>
		protected RMethod r_R__0__n4p_String_Out_Boolean;
		public virtual RMethod R__0__n4p_String_Out_Boolean
		{
			get
			{
				if(r_R__0__n4p_String_Out_Boolean == null)
				{
					r_R__0__n4p_String_Out_Boolean = new(this, "#n4p", 0, typeof(System.String), typeof(System.Boolean).MakeByRefType());
					r_R__0__n4p_String_Out_Boolean.SetBelong(this.instance);
				}
				return r_R__0__n4p_String_Out_Boolean;
			}
		}

		/// <summary>
		/// Void OnLoadGoddessUpgradeConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadGoddessUpgradeConfig_Object;
		public virtual RMethod ROnLoadGoddessUpgradeConfig_Object
		{
			get
			{
				if(r_ROnLoadGoddessUpgradeConfig_Object == null)
				{
					r_ROnLoadGoddessUpgradeConfig_Object = new(this, "OnLoadGoddessUpgradeConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadGoddessUpgradeConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadGoddessUpgradeConfig_Object;
			}
		}

		/// <summary>
		/// Int32 #o4p()
		/// </summary>
		protected RMethod r_R__0__o4p;
		public virtual RMethod R__0__o4p
		{
			get
			{
				if(r_R__0__o4p == null)
				{
					r_R__0__o4p = new(this, "#o4p", 0);
					r_R__0__o4p.SetBelong(this.instance);
				}
				return r_R__0__o4p;
			}
		}

		/// <summary>
		/// GoddessInfo #p4p(Int32)
		/// </summary>
		protected RMethod r_R__0__p4p_Int32;
		public virtual RMethod R__0__p4p_Int32
		{
			get
			{
				if(r_R__0__p4p_Int32 == null)
				{
					r_R__0__p4p_Int32 = new(this, "#p4p", 0, typeof(System.Int32));
					r_R__0__p4p_Int32.SetBelong(this.instance);
				}
				return r_R__0__p4p_Int32;
			}
		}

		/// <summary>
		/// GoddessInfo #q4p(Int32)
		/// </summary>
		protected RMethod r_R__0__q4p_Int32;
		public virtual RMethod R__0__q4p_Int32
		{
			get
			{
				if(r_R__0__q4p_Int32 == null)
				{
					r_R__0__q4p_Int32 = new(this, "#q4p", 0, typeof(System.Int32));
					r_R__0__q4p_Int32.SetBelong(this.instance);
				}
				return r_R__0__q4p_Int32;
			}
		}

		/// <summary>
		/// GoddessByLevel #r4p(GoddessInfo, Int32)
		/// </summary>
		protected RMethod r_R__0__r4p_GoddessInfo_Int32;
		public virtual RMethod R__0__r4p_GoddessInfo_Int32
		{
			get
			{
				if(r_R__0__r4p_GoddessInfo_Int32 == null)
				{
					r_R__0__r4p_GoddessInfo_Int32 = new(this, "#r4p", 0, typeof(GoddessInfo), typeof(System.Int32));
					r_R__0__r4p_GoddessInfo_Int32.SetBelong(this.instance);
				}
				return r_R__0__r4p_GoddessInfo_Int32;
			}
		}

		/// <summary>
		/// Boolean #s4p()
		/// </summary>
		protected RMethod r_R__0__s4p;
		public virtual RMethod R__0__s4p
		{
			get
			{
				if(r_R__0__s4p == null)
				{
					r_R__0__s4p = new(this, "#s4p", 0);
					r_R__0__s4p.SetBelong(this.instance);
				}
				return r_R__0__s4p;
			}
		}

		/// <summary>
		/// Boolean #t4p(GoddessInfo)
		/// </summary>
		protected RMethod r_R__0__t4p_GoddessInfo;
		public virtual RMethod R__0__t4p_GoddessInfo
		{
			get
			{
				if(r_R__0__t4p_GoddessInfo == null)
				{
					r_R__0__t4p_GoddessInfo = new(this, "#t4p", 0, typeof(GoddessInfo));
					r_R__0__t4p_GoddessInfo.SetBelong(this.instance);
				}
				return r_R__0__t4p_GoddessInfo;
			}
		}

		/// <summary>
		/// Void #u4p(GoddessInfo)
		/// </summary>
		protected RMethod r_R__0__u4p_GoddessInfo;
		public virtual RMethod R__0__u4p_GoddessInfo
		{
			get
			{
				if(r_R__0__u4p_GoddessInfo == null)
				{
					r_R__0__u4p_GoddessInfo = new(this, "#u4p", 0, typeof(GoddessInfo));
					r_R__0__u4p_GoddessInfo.SetBelong(this.instance);
				}
				return r_R__0__u4p_GoddessInfo;
			}
		}

		/// <summary>
		/// Int32 #v4p(GoddessInfo, GoddessByLevel, eGoddessAttr)
		/// </summary>
		protected RMethod r_R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr;
		public virtual RMethod R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr
		{
			get
			{
				if(r_R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr == null)
				{
					r_R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr = new(this, "#v4p", 0, typeof(GoddessInfo), typeof(GoddessByLevel), typeof(eGoddessAttr));
					r_R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr.SetBelong(this.instance);
				}
				return r_R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr;
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


        public R__0__w4p() : base("#u.#w4p")
        {
        }

        public R__0__w4p(System.Object instance) : base("#u.#w4p")
		{
            SetInstance(instance);
		}

        public R__0__w4p(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__w4p(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__n4p(System.String  @info, out System.Boolean  @isLevelUp)
        {
			isLevelUp = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @isLevelUp};
            var ___result = R__0__n4p_String_Out_Boolean.Invoke(___genericsType, ___parameters);
			isLevelUp = (System.Boolean)___parameters[1];

            
        }


        public virtual void OnLoadGoddessUpgradeConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadGoddessUpgradeConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__o4p()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__o4p.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual GoddessInfo __0__p4p(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = R__0__p4p_Int32.Invoke(___genericsType, ___parameters);

            return (GoddessInfo)___result;
        }


        public virtual GoddessInfo __0__q4p(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__q4p_Int32.Invoke(___genericsType, ___parameters);

            return (GoddessInfo)___result;
        }


        public virtual GoddessByLevel __0__r4p(GoddessInfo  @info, System.Int32  @expAcc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @expAcc};
            var ___result = R__0__r4p_GoddessInfo_Int32.Invoke(___genericsType, ___parameters);

            return (GoddessByLevel)___result;
        }


        public virtual System.Boolean __0__s4p()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__s4p.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__t4p(GoddessInfo  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = R__0__t4p_GoddessInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__u4p(GoddessInfo  @oldInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldInfo};
            var ___result = R__0__u4p_GoddessInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__v4p(GoddessInfo  @info, GoddessByLevel  @levelInfo, eGoddessAttr  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @levelInfo, @type};
            var ___result = R__0__v4p_GoddessInfo_GoddessByLevel_eGoddessAttr.Invoke(___genericsType, ___parameters);

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
