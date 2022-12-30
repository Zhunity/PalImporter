using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#38
	/// </summary>
    public partial class R__0__38 : RMember //
    {

		/// <summary>
		/// #Pfb.#9ob #a
		/// </summary>
		protected R__0__Pfb.R__0__9ob r___0__a;
		public virtual R__0__Pfb.R__0__9ob R__0__a
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
		/// GameDefineType.ID #b
		/// </summary>
		protected RGameDefineType.RID r___0__b;
		public virtual RGameDefineType.RID R__0__b
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
		/// CombatCommand #d
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
		/// Fighter mActive
		/// </summary>
		protected RFighter r_R__0__T8;
		public virtual RFighter R__0__T8
		{
			get
			{
				if(r_R__0__T8 == null)
				{
					r_R__0__T8 = new(this, "mActive", -1);
					r_R__0__T8.SetBelong(this.instance);
				}
				return r_R__0__T8;
			}
		}

		/// <summary>
		/// Fighter mTarget
		/// </summary>
		protected RFighter r_R__0__U8;
		public virtual RFighter R__0__U8
		{
			get
			{
				if(r_R__0__U8 == null)
				{
					r_R__0__U8 = new(this, "mTarget", -1);
					r_R__0__U8.SetBelong(this.instance);
				}
				return r_R__0__U8;
			}
		}

		/// <summary>
		/// Void #V8(CombatEvent)
		/// </summary>
		protected RMethod r_R__0__V8_CombatEvent;
		public virtual RMethod R__0__V8_CombatEvent
		{
			get
			{
				if(r_R__0__V8_CombatEvent == null)
				{
					r_R__0__V8_CombatEvent = new(this, "#V8", 0,  ReleactionUtils.GetType("CombatEvent"));
					r_R__0__V8_CombatEvent.SetBelong(this.instance);
				}
				return r_R__0__V8_CombatEvent;
			}
		}

		/// <summary>
		/// Boolean #W8(CombatEvent, System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_R__0__W8_CombatEvent_String_String_Boolean_Boolean;
		public virtual RMethod R__0__W8_CombatEvent_String_String_Boolean_Boolean
		{
			get
			{
				if(r_R__0__W8_CombatEvent_String_String_Boolean_Boolean == null)
				{
					r_R__0__W8_CombatEvent_String_String_Boolean_Boolean = new(this, "#W8", 0,  ReleactionUtils.GetType("CombatEvent"), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_R__0__W8_CombatEvent_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_R__0__W8_CombatEvent_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void #X8(CombatEvent)
		/// </summary>
		protected RMethod r_R__0__X8_CombatEvent;
		public virtual RMethod R__0__X8_CombatEvent
		{
			get
			{
				if(r_R__0__X8_CombatEvent == null)
				{
					r_R__0__X8_CombatEvent = new(this, "#X8", 0,  ReleactionUtils.GetType("CombatEvent"));
					r_R__0__X8_CombatEvent.SetBelong(this.instance);
				}
				return r_R__0__X8_CombatEvent;
			}
		}

		/// <summary>
		/// Void #Y8(CombatEvent)
		/// </summary>
		protected RMethod r_R__0__Y8_CombatEvent;
		public virtual RMethod R__0__Y8_CombatEvent
		{
			get
			{
				if(r_R__0__Y8_CombatEvent == null)
				{
					r_R__0__Y8_CombatEvent = new(this, "#Y8", 0,  ReleactionUtils.GetType("CombatEvent"));
					r_R__0__Y8_CombatEvent.SetBelong(this.instance);
				}
				return r_R__0__Y8_CombatEvent;
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


        public R__0__38() : base("#u.#38")
        {
        }

        public R__0__38(System.Object instance) : base("#u.#38")
		{
            SetInstance(instance);
		}

        public R__0__38(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__38(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
