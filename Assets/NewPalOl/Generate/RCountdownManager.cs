using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CountdownManager
	/// </summary>
    public partial class RCountdownManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[CountdownType,CountdownManager+Countdown] CountdownDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RCountdownManager.RCountdown> r_CountdownDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RCountdownManager.RCountdown> RCountdownDict
		{
			get
			{
				if(r_CountdownDict == null)
				{
					r_CountdownDict = new(this, "CountdownDict");
					r_CountdownDict.SetBelong(this.instance);
				}
				return r_CountdownDict;
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
		/// Void SetCountdown(CountdownType, Single)
		/// </summary>
		protected RMethod r_RSetCountdown_CountdownType_Single;
		public virtual RMethod RSetCountdown_CountdownType_Single
		{
			get
			{
				if(r_RSetCountdown_CountdownType_Single == null)
				{
					r_RSetCountdown_CountdownType_Single = new(this, "SetCountdown", 0,  ReleactionUtils.GetType("CountdownType"), typeof(System.Single));
					r_RSetCountdown_CountdownType_Single.SetBelong(this.instance);
				}
				return r_RSetCountdown_CountdownType_Single;
			}
		}

		/// <summary>
		/// Void SetCountdown(CountdownType, Handler, Single)
		/// </summary>
		protected RMethod r_RSetCountdown_CountdownType_Handler_Single;
		public virtual RMethod RSetCountdown_CountdownType_Handler_Single
		{
			get
			{
				if(r_RSetCountdown_CountdownType_Handler_Single == null)
				{
					r_RSetCountdown_CountdownType_Handler_Single = new(this, "SetCountdown", 0,  ReleactionUtils.GetType("CountdownType"),  ReleactionUtils.GetType("CountdownManager+Handler"), typeof(System.Single));
					r_RSetCountdown_CountdownType_Handler_Single.SetBelong(this.instance);
				}
				return r_RSetCountdown_CountdownType_Handler_Single;
			}
		}

		/// <summary>
		/// Void SetCountdown(CountdownType, Handler, System.Object, Single)
		/// </summary>
		protected RMethod r_RSetCountdown_CountdownType_Handler_Object_Single;
		public virtual RMethod RSetCountdown_CountdownType_Handler_Object_Single
		{
			get
			{
				if(r_RSetCountdown_CountdownType_Handler_Object_Single == null)
				{
					r_RSetCountdown_CountdownType_Handler_Object_Single = new(this, "SetCountdown", 0,  ReleactionUtils.GetType("CountdownType"),  ReleactionUtils.GetType("CountdownManager+Handler"), typeof(System.Object), typeof(System.Single));
					r_RSetCountdown_CountdownType_Handler_Object_Single.SetBelong(this.instance);
				}
				return r_RSetCountdown_CountdownType_Handler_Object_Single;
			}
		}

		/// <summary>
		/// Single GetRemainTime(CountdownType)
		/// </summary>
		protected RMethod r_RGetRemainTime_CountdownType;
		public virtual RMethod RGetRemainTime_CountdownType
		{
			get
			{
				if(r_RGetRemainTime_CountdownType == null)
				{
					r_RGetRemainTime_CountdownType = new(this, "GetRemainTime", 0,  ReleactionUtils.GetType("CountdownType"));
					r_RGetRemainTime_CountdownType.SetBelong(this.instance);
				}
				return r_RGetRemainTime_CountdownType;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// System.String GetTimeDescBySecond(Int32)
		/// </summary>
		protected static RMethod r_RGetTimeDescBySecond_Int32;
		public static RMethod RGetTimeDescBySecond_Int32
		{
			get
			{
				if(r_RGetTimeDescBySecond_Int32 == null)
				{
					r_RGetTimeDescBySecond_Int32 = new( ReleactionUtils.GetType("CountdownManager"), "GetTimeDescBySecond", 0, typeof(System.Int32));
					r_RGetTimeDescBySecond_Int32.SetBelong(null);
				}
				return r_RGetTimeDescBySecond_Int32;
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


        public RCountdownManager() : base("CountdownManager")
        {
        }

        public RCountdownManager(System.Object instance) : base("CountdownManager")
		{
            SetInstance(instance);
		}

        public RCountdownManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCountdownManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetTimeDescBySecond(System.Int32  @second)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@second};
            var ___result = RGetTimeDescBySecond_Int32.Invoke(___genericsType, ___parameters);

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
