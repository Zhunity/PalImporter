using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RTribeManager
{
	
	/// <summary>
	/// TribeManager+<OnTribeWarNtf>c__AnonStorey361
	/// </summary>
    public partial class R__2__OnTribeWarNtf__4__c__AnonStorey361 : RMember //
    {

		/// <summary>
		/// Message.SCNetMsgTribeWarNtf msg
		/// </summary>
		protected RMessage.RSCNetMsgTribeWarNtf r_msg;
		public virtual RMessage.RSCNetMsgTribeWarNtf Rmsg
		{
			get
			{
				if(r_msg == null)
				{
					r_msg = new(this, "msg");
					r_msg.SetBelong(this.instance);
				}
				return r_msg;
			}
		}

		/// <summary>
		/// TribeManager <>f__this
		/// </summary>
		protected RTribeManager r___2____4__f__this;
		public virtual RTribeManager R__2____4__f__this
		{
			get
			{
				if(r___2____4__f__this == null)
				{
					r___2____4__f__this = new(this, "<>f__this");
					r___2____4__f__this.SetBelong(this.instance);
				}
				return r___2____4__f__this;
			}
		}

		/// <summary>
		/// Void <>m__25C()
		/// </summary>
		protected RMethod r_R__2____4__m__25C;
		public virtual RMethod R__2____4__m__25C
		{
			get
			{
				if(r_R__2____4__m__25C == null)
				{
					r_R__2____4__m__25C = new(this, "<>m__25C", 0);
					r_R__2____4__m__25C.SetBelong(this.instance);
				}
				return r_R__2____4__m__25C;
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


        public R__2__OnTribeWarNtf__4__c__AnonStorey361() : base("TribeManager+<OnTribeWarNtf>c__AnonStorey361")
        {
        }

        public R__2__OnTribeWarNtf__4__c__AnonStorey361(System.Object instance) : base("TribeManager+<OnTribeWarNtf>c__AnonStorey361")
		{
            SetInstance(instance);
		}

        public R__2__OnTribeWarNtf__4__c__AnonStorey361(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__OnTribeWarNtf__4__c__AnonStorey361(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __2____4__m__25C()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__2____4__m__25C.Invoke(___genericsType, ___parameters);

            
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
}