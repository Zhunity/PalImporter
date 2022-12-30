using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RTransactionMonitor
{
	
	/// <summary>
	/// TransactionMonitor+Step
	/// </summary>
    public partial class RStep : RMember //
    {

		/// <summary>
		/// System.String bundlePath
		/// </summary>
		protected RField r_bundlePath;
		public virtual RField RbundlePath
		{
			get
			{
				if(r_bundlePath == null)
				{
					r_bundlePath = new(this, "bundlePath");
					r_bundlePath.SetBelong(this.instance);
				}
				return r_bundlePath;
			}
		}

		/// <summary>
		/// System.Boolean complete
		/// </summary>
		protected RField r_complete;
		public virtual RField Rcomplete
		{
			get
			{
				if(r_complete == null)
				{
					r_complete = new(this, "complete");
					r_complete.SetBelong(this.instance);
				}
				return r_complete;
			}
		}

		/// <summary>
		/// System.Single endTime
		/// </summary>
		protected RField r_endTime;
		public virtual RField RendTime
		{
			get
			{
				if(r_endTime == null)
				{
					r_endTime = new(this, "endTime");
					r_endTime.SetBelong(this.instance);
				}
				return r_endTime;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// TransactionMonitor+OnStepDelegate onComplete
		/// </summary>
		protected RTransactionMonitor.ROnStepDelegate r_onComplete;
		public virtual RTransactionMonitor.ROnStepDelegate RonComplete
		{
			get
			{
				if(r_onComplete == null)
				{
					r_onComplete = new(this, "onComplete");
					r_onComplete.SetBelong(this.instance);
				}
				return r_onComplete;
			}
		}

		/// <summary>
		/// System.Single percentComplete
		/// </summary>
		protected RField r_percentComplete;
		public virtual RField RpercentComplete
		{
			get
			{
				if(r_percentComplete == null)
				{
					r_percentComplete = new(this, "percentComplete");
					r_percentComplete.SetBelong(this.instance);
				}
				return r_percentComplete;
			}
		}

		/// <summary>
		/// TransactionMonitor+ExitCondition result
		/// </summary>
		protected RField r_result;
		public virtual RField Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result");
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// System.Single startTime
		/// </summary>
		protected RField r_startTime;
		public virtual RField RstartTime
		{
			get
			{
				if(r_startTime == null)
				{
					r_startTime = new(this, "startTime");
					r_startTime.SetBelong(this.instance);
				}
				return r_startTime;
			}
		}

		/// <summary>
		/// System.String updateNotice
		/// </summary>
		protected RField r_updateNotice;
		public virtual RField RupdateNotice
		{
			get
			{
				if(r_updateNotice == null)
				{
					r_updateNotice = new(this, "updateNotice");
					r_updateNotice.SetBelong(this.instance);
				}
				return r_updateNotice;
			}
		}

		/// <summary>
		/// System.Single weight
		/// </summary>
		protected RField r_weight;
		public virtual RField Rweight
		{
			get
			{
				if(r_weight == null)
				{
					r_weight = new(this, "weight");
					r_weight.SetBelong(this.instance);
				}
				return r_weight;
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


        public RStep() : base("TransactionMonitor+Step")
        {
        }

        public RStep(System.Object instance) : base("TransactionMonitor+Step")
		{
            SetInstance(instance);
		}

        public RStep(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStep(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}