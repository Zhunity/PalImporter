using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// StrengthenQuene
	/// </summary>
    public partial class RStrengthenQuene : RMember //
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
		/// QueueType #b
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
		/// System.Single #c
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
		/// QueueStateType #d
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
		/// System.Single #e
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
		/// System.Boolean #g
		/// </summary>
		protected RField r___0__g;
		public virtual RField R__0__g
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
		/// QueueType GetType()
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
		/// QueueStateType GetQueneState()
		/// </summary>
		protected RMethod r_RGetQueneState;
		public virtual RMethod RGetQueneState
		{
			get
			{
				if(r_RGetQueneState == null)
				{
					r_RGetQueneState = new(this, "GetQueneState", 0);
					r_RGetQueneState.SetBelong(this.instance);
				}
				return r_RGetQueneState;
			}
		}

		/// <summary>
		/// Single GetQueneCD()
		/// </summary>
		protected RMethod r_RGetQueneCD;
		public virtual RMethod RGetQueneCD
		{
			get
			{
				if(r_RGetQueneCD == null)
				{
					r_RGetQueneCD = new(this, "GetQueneCD", 0);
					r_RGetQueneCD.SetBelong(this.instance);
				}
				return r_RGetQueneCD;
			}
		}

		/// <summary>
		/// Boolean IsLock()
		/// </summary>
		protected RMethod r_RIsLock;
		public virtual RMethod RIsLock
		{
			get
			{
				if(r_RIsLock == null)
				{
					r_RIsLock = new(this, "IsLock", 0);
					r_RIsLock.SetBelong(this.instance);
				}
				return r_RIsLock;
			}
		}

		/// <summary>
		/// Boolean NeedChangeStyle()
		/// </summary>
		protected RMethod r_RNeedChangeStyle;
		public virtual RMethod RNeedChangeStyle
		{
			get
			{
				if(r_RNeedChangeStyle == null)
				{
					r_RNeedChangeStyle = new(this, "NeedChangeStyle", 0);
					r_RNeedChangeStyle.SetBelong(this.instance);
				}
				return r_RNeedChangeStyle;
			}
		}

		/// <summary>
		/// Void ChangedStyle()
		/// </summary>
		protected RMethod r_RChangedStyle;
		public virtual RMethod RChangedStyle
		{
			get
			{
				if(r_RChangedStyle == null)
				{
					r_RChangedStyle = new(this, "ChangedStyle", 0);
					r_RChangedStyle.SetBelong(this.instance);
				}
				return r_RChangedStyle;
			}
		}

		/// <summary>
		/// Void SetQueneState(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetQueneState_Int32_Boolean;
		public virtual RMethod RSetQueneState_Int32_Boolean
		{
			get
			{
				if(r_RSetQueneState_Int32_Boolean == null)
				{
					r_RSetQueneState_Int32_Boolean = new(this, "SetQueneState", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetQueneState_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetQueneState_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetQueneState(QueueStateType, Int32)
		/// </summary>
		protected RMethod r_RSetQueneState_QueueStateType_Int32;
		public virtual RMethod RSetQueneState_QueueStateType_Int32
		{
			get
			{
				if(r_RSetQueneState_QueueStateType_Int32 == null)
				{
					r_RSetQueneState_QueueStateType_Int32 = new(this, "SetQueneState", 0, typeof(QueueStateType), typeof(System.Int32));
					r_RSetQueneState_QueueStateType_Int32.SetBelong(this.instance);
				}
				return r_RSetQueneState_QueueStateType_Int32;
			}
		}

		/// <summary>
		/// Void UpdateCD()
		/// </summary>
		protected RMethod r_RUpdateCD;
		public virtual RMethod RUpdateCD
		{
			get
			{
				if(r_RUpdateCD == null)
				{
					r_RUpdateCD = new(this, "UpdateCD", 0);
					r_RUpdateCD.SetBelong(this.instance);
				}
				return r_RUpdateCD;
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


        public RStrengthenQuene() : base("StrengthenQuene")
        {
        }

        public RStrengthenQuene(System.Object instance) : base("StrengthenQuene")
		{
            SetInstance(instance);
		}

        public RStrengthenQuene(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrengthenQuene(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual QueueType GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (QueueType)___result;
        }


        public virtual QueueStateType GetQueneState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetQueneState.Invoke(___genericsType, ___parameters);

            return (QueueStateType)___result;
        }


        public virtual System.Single GetQueneCD()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetQueneCD.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean IsLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsLock.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean NeedChangeStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNeedChangeStyle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ChangedStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChangedStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetQueneState(System.Int32  @cd, System.Boolean  @bLock)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cd, @bLock};
            var ___result = RSetQueneState_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetQueneState(QueueStateType  @state, System.Int32  @cd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state, @cd};
            var ___result = RSetQueneState_QueueStateType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCD()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCD.Invoke(___genericsType, ___parameters);

            
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
