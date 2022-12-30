using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AssetBundleRecompressOperation
	/// </summary>
    public partial class RAssetBundleRecompressOperation : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// System.String humanReadableResult
		/// </summary>
		protected RProperty r_humanReadableResult;
		public virtual RProperty RhumanReadableResult
		{
			get
			{
				if(r_humanReadableResult == null)
				{
					r_humanReadableResult = new(this, "humanReadableResult", -1);
					r_humanReadableResult.SetBelong(this.instance);
				}
				return r_humanReadableResult;
			}
		}

		/// <summary>
		/// System.String inputPath
		/// </summary>
		protected RProperty r_inputPath;
		public virtual RProperty RinputPath
		{
			get
			{
				if(r_inputPath == null)
				{
					r_inputPath = new(this, "inputPath", -1);
					r_inputPath.SetBelong(this.instance);
				}
				return r_inputPath;
			}
		}

		/// <summary>
		/// System.String outputPath
		/// </summary>
		protected RProperty r_outputPath;
		public virtual RProperty RoutputPath
		{
			get
			{
				if(r_outputPath == null)
				{
					r_outputPath = new(this, "outputPath", -1);
					r_outputPath.SetBelong(this.instance);
				}
				return r_outputPath;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleLoadResult result
		/// </summary>
		protected RProperty r_result;
		public virtual RProperty Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result", -1);
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// Boolean success
		/// </summary>
		protected RProperty r_success;
		public virtual RProperty Rsuccess
		{
			get
			{
				if(r_success == null)
				{
					r_success = new(this, "success", -1);
					r_success.SetBelong(this.instance);
				}
				return r_success;
			}
		}

		/// <summary>
		/// Boolean isDone
		/// </summary>
		protected RProperty r_isDone;
		public virtual RProperty RisDone
		{
			get
			{
				if(r_isDone == null)
				{
					r_isDone = new(this, "isDone", -1);
					r_isDone.SetBelong(this.instance);
				}
				return r_isDone;
			}
		}

		/// <summary>
		/// Single progress
		/// </summary>
		protected RProperty r_progress;
		public virtual RProperty Rprogress
		{
			get
			{
				if(r_progress == null)
				{
					r_progress = new(this, "progress", -1);
					r_progress.SetBelong(this.instance);
				}
				return r_progress;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected RProperty r_priority;
		public virtual RProperty Rpriority
		{
			get
			{
				if(r_priority == null)
				{
					r_priority = new(this, "priority", -1);
					r_priority.SetBelong(this.instance);
				}
				return r_priority;
			}
		}

		/// <summary>
		/// Boolean allowSceneActivation
		/// </summary>
		protected RProperty r_allowSceneActivation;
		public virtual RProperty RallowSceneActivation
		{
			get
			{
				if(r_allowSceneActivation == null)
				{
					r_allowSceneActivation = new(this, "allowSceneActivation", -1);
					r_allowSceneActivation.SetBelong(this.instance);
				}
				return r_allowSceneActivation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.AsyncOperation] completed
		/// </summary>
		protected REvent r_completed;
		public virtual REvent Rcompleted
		{
			get
			{
				if(r_completed == null)
				{
					r_completed = new(this, "completed");
					r_completed.SetBelong(this.instance);
				}
				return r_completed;
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
		/// Void InvokeCompletionEvent()
		/// </summary>
		protected RMethod r_RInvokeCompletionEvent;
		public virtual RMethod RInvokeCompletionEvent
		{
			get
			{
				if(r_RInvokeCompletionEvent == null)
				{
					r_RInvokeCompletionEvent = new(this, "InvokeCompletionEvent", 0);
					r_RInvokeCompletionEvent.SetBelong(this.instance);
				}
				return r_RInvokeCompletionEvent;
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


        public RAssetBundleRecompressOperation() : base("UnityEngine.AssetBundleRecompressOperation")
        {
        }

        public RAssetBundleRecompressOperation(System.Object instance) : base("UnityEngine.AssetBundleRecompressOperation")
		{
            SetInstance(instance);
		}

        public RAssetBundleRecompressOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetBundleRecompressOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeCompletionEvent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvokeCompletionEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
