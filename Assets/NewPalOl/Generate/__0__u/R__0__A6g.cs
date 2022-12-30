using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#A6g
	/// </summary>
    public partial class R__0__A6g : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,RingTaskInfo] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RRingTaskInfo> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RRingTaskInfo> R__0__a
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
		/// System.Collections.Generic.List`1[RingTaskReward] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RRingTaskReward> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RList<RRingTaskReward> R__0__b
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
		/// System.Int32 #c
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
		/// Int32 TODAY_RING_COUNT
		/// </summary>
		protected RProperty r_R__0__q6g;
		public virtual RProperty R__0__q6g
		{
			get
			{
				if(r_R__0__q6g == null)
				{
					r_R__0__q6g = new(this, "TODAY_RING_COUNT", -1);
					r_R__0__q6g.SetBelong(this.instance);
				}
				return r_R__0__q6g;
			}
		}

		/// <summary>
		/// Void OnLoadRingTaskConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRingTaskConfig_Object;
		public virtual RMethod ROnLoadRingTaskConfig_Object
		{
			get
			{
				if(r_ROnLoadRingTaskConfig_Object == null)
				{
					r_ROnLoadRingTaskConfig_Object = new(this, "OnLoadRingTaskConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRingTaskConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRingTaskConfig_Object;
			}
		}

		/// <summary>
		/// RingTaskInfo #n6g(Int32)
		/// </summary>
		protected RMethod r_R__0__n6g_Int32;
		public virtual RMethod R__0__n6g_Int32
		{
			get
			{
				if(r_R__0__n6g_Int32 == null)
				{
					r_R__0__n6g_Int32 = new(this, "#n6g", 0, typeof(System.Int32));
					r_R__0__n6g_Int32.SetBelong(this.instance);
				}
				return r_R__0__n6g_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadRingTaskRewardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRingTaskRewardConfig_Object;
		public virtual RMethod ROnLoadRingTaskRewardConfig_Object
		{
			get
			{
				if(r_ROnLoadRingTaskRewardConfig_Object == null)
				{
					r_ROnLoadRingTaskRewardConfig_Object = new(this, "OnLoadRingTaskRewardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRingTaskRewardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRingTaskRewardConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RingTaskReward] #o6g()
		/// </summary>
		protected RMethod r_R__0__o6g;
		public virtual RMethod R__0__o6g
		{
			get
			{
				if(r_R__0__o6g == null)
				{
					r_R__0__o6g = new(this, "#o6g", 0);
					r_R__0__o6g.SetBelong(this.instance);
				}
				return r_R__0__o6g;
			}
		}

		/// <summary>
		/// System.String #p6g(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__p6g_Int32_Int32;
		public virtual RMethod R__0__p6g_Int32_Int32
		{
			get
			{
				if(r_R__0__p6g_Int32_Int32 == null)
				{
					r_R__0__p6g_Int32_Int32 = new(this, "#p6g", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__p6g_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__p6g_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #s6g(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__s6g_Object___0__Isb;
		public virtual RMethod R__0__s6g_Object___0__Isb
		{
			get
			{
				if(r_R__0__s6g_Object___0__Isb == null)
				{
					r_R__0__s6g_Object___0__Isb = new(this, "#s6g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__s6g_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__s6g_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #t6g(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__t6g_Object___0__Isb;
		public virtual RMethod R__0__t6g_Object___0__Isb
		{
			get
			{
				if(r_R__0__t6g_Object___0__Isb == null)
				{
					r_R__0__t6g_Object___0__Isb = new(this, "#t6g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__t6g_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__t6g_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #u6g(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__u6g_Object___0__Isb;
		public virtual RMethod R__0__u6g_Object___0__Isb
		{
			get
			{
				if(r_R__0__u6g_Object___0__Isb == null)
				{
					r_R__0__u6g_Object___0__Isb = new(this, "#u6g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__u6g_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__u6g_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.String #v6g()
		/// </summary>
		protected RMethod r_R__0__v6g;
		public virtual RMethod R__0__v6g
		{
			get
			{
				if(r_R__0__v6g == null)
				{
					r_R__0__v6g = new(this, "#v6g", 0);
					r_R__0__v6g.SetBelong(this.instance);
				}
				return r_R__0__v6g;
			}
		}

		/// <summary>
		/// Void #w6g(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__w6g_Object___0__Isb;
		public virtual RMethod R__0__w6g_Object___0__Isb
		{
			get
			{
				if(r_R__0__w6g_Object___0__Isb == null)
				{
					r_R__0__w6g_Object___0__Isb = new(this, "#w6g", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__w6g_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__w6g_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendPickReward()
		/// </summary>
		protected RMethod r_RSendPickReward;
		public virtual RMethod RSendPickReward
		{
			get
			{
				if(r_RSendPickReward == null)
				{
					r_RSendPickReward = new(this, "SendPickReward", 0);
					r_RSendPickReward.SetBelong(this.instance);
				}
				return r_RSendPickReward;
			}
		}

		/// <summary>
		/// Void #x6g()
		/// </summary>
		protected RMethod r_R__0__x6g;
		public virtual RMethod R__0__x6g
		{
			get
			{
				if(r_R__0__x6g == null)
				{
					r_R__0__x6g = new(this, "#x6g", 0);
					r_R__0__x6g.SetBelong(this.instance);
				}
				return r_R__0__x6g;
			}
		}

		/// <summary>
		/// Void #y6g()
		/// </summary>
		protected RMethod r_R__0__y6g;
		public virtual RMethod R__0__y6g
		{
			get
			{
				if(r_R__0__y6g == null)
				{
					r_R__0__y6g = new(this, "#y6g", 0);
					r_R__0__y6g.SetBelong(this.instance);
				}
				return r_R__0__y6g;
			}
		}

		/// <summary>
		/// Boolean #z6g()
		/// </summary>
		protected RMethod r_R__0__z6g;
		public virtual RMethod R__0__z6g
		{
			get
			{
				if(r_R__0__z6g == null)
				{
					r_R__0__z6g = new(this, "#z6g", 0);
					r_R__0__z6g.SetBelong(this.instance);
				}
				return r_R__0__z6g;
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


        public R__0__A6g() : base("#u.#A6g")
        {
        }

        public R__0__A6g(System.Object instance) : base("#u.#A6g")
		{
            SetInstance(instance);
		}

        public R__0__A6g(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__A6g(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadRingTaskConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRingTaskConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RingTaskInfo __0__n6g(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__n6g_Int32.Invoke(___genericsType, ___parameters);

            return (RingTaskInfo)___result;
        }


        public virtual void OnLoadRingTaskRewardConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRingTaskRewardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<RingTaskReward> __0__o6g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__o6g.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RingTaskReward>)___result;
        }


        public virtual System.String __0__p6g(System.Int32  @id, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @count};
            var ___result = R__0__p6g_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual System.String __0__v6g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__v6g.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void SendPickReward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendPickReward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__x6g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__x6g.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__y6g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__y6g.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__z6g()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__z6g.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
