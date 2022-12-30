using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Tbb
	/// </summary>
    public partial class R__0__Tbb : RMember //
    {

		/// <summary>
		/// GameDefineType.ID #a
		/// </summary>
		protected RGameDefineType.RID r___0__a;
		public virtual RGameDefineType.RID R__0__a
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
		/// System.Collections.Generic.List`1[#u.#Vbb] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Vbb> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Vbb> R__0__b
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
		/// #u.#rOb #c
		/// </summary>
		protected R__0__u.R__0__rOb r___0__c;
		public virtual R__0__u.R__0__rOb R__0__c
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
		/// System.Collections.Generic.List`1[#u.#Vbb] MsgList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Vbb> r_R__0__Pbb;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Vbb> R__0__Pbb
		{
			get
			{
				if(r_R__0__Pbb == null)
				{
					r_R__0__Pbb = new(this, "MsgList", -1);
					r_R__0__Pbb.SetBelong(this.instance);
				}
				return r_R__0__Pbb;
			}
		}

		/// <summary>
		/// #u.#Vbb Item [Int32]
		/// </summary>
		protected R__0__u.R__0__Vbb r_R__0__Rbb_Int32;
		public virtual R__0__u.R__0__Vbb R__0__Rbb_Int32
		{
			get
			{
				if(r_R__0__Rbb_Int32 == null)
				{
					r_R__0__Rbb_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_R__0__Rbb_Int32.SetBelong(this.instance);
				}
				return r_R__0__Rbb_Int32;
			}
		}

		/// <summary>
		/// #u.#Tbb GetInst(GameDefineType.ID)
		/// </summary>
		protected static RMethod r_RGetInst_ID;
		public static RMethod RGetInst_ID
		{
			get
			{
				if(r_RGetInst_ID == null)
				{
					r_RGetInst_ID = new( ReleactionUtils.GetType("#u.#Tbb"), "GetInst", 0, typeof(GameDefineType.ID));
					r_RGetInst_ID.SetBelong(null);
				}
				return r_RGetInst_ID;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Qbb()
		/// </summary>
		protected RMethod r_R__0__Qbb;
		public virtual RMethod R__0__Qbb
		{
			get
			{
				if(r_R__0__Qbb == null)
				{
					r_R__0__Qbb = new(this, "#Qbb", 0);
					r_R__0__Qbb.SetBelong(this.instance);
				}
				return r_R__0__Qbb;
			}
		}

		/// <summary>
		/// Void #Sbb(#u.#Vbb)
		/// </summary>
		protected RMethod r_R__0__Sbb___0__Vbb;
		public virtual RMethod R__0__Sbb___0__Vbb
		{
			get
			{
				if(r_R__0__Sbb___0__Vbb == null)
				{
					r_R__0__Sbb___0__Vbb = new(this, "#Sbb", 0,  ReleactionUtils.GetType("#u.#Vbb"));
					r_R__0__Sbb___0__Vbb.SetBelong(this.instance);
				}
				return r_R__0__Sbb___0__Vbb;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
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


        public R__0__Tbb() : base("#u.#Tbb")
        {
        }

        public R__0__Tbb(System.Object instance) : base("#u.#Tbb")
		{
            SetInstance(instance);
		}

        public R__0__Tbb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Tbb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object GetInst(GameDefineType.ID  @channelId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channelId};
            var ___result = RGetInst_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.IEnumerator __0__Qbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Qbb.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
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
