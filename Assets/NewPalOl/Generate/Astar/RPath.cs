using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAstarPath
{
	
	/// <summary>
	/// AstarPath+Path
	/// </summary>
    public partial class RPath : RMember //
    {

		/// <summary>
		/// Seeker seeker
		/// </summary>
		protected RSeeker r_seeker;
		public virtual RSeeker Rseeker
		{
			get
			{
				if(r_seeker == null)
				{
					r_seeker = new(this, "seeker");
					r_seeker.SetBelong(this.instance);
				}
				return r_seeker;
			}
		}

		/// <summary>
		/// System.Single pathStartTime
		/// </summary>
		protected RField r_pathStartTime;
		public virtual RField RpathStartTime
		{
			get
			{
				if(r_pathStartTime == null)
				{
					r_pathStartTime = new(this, "pathStartTime");
					r_pathStartTime.SetBelong(this.instance);
				}
				return r_pathStartTime;
			}
		}

		/// <summary>
		/// AstarClasses.Node start
		/// </summary>
		protected RAstarClasses.RNode r_start;
		public virtual RAstarClasses.RNode Rstart
		{
			get
			{
				if(r_start == null)
				{
					r_start = new(this, "start");
					r_start.SetBelong(this.instance);
				}
				return r_start;
			}
		}

		/// <summary>
		/// AstarClasses.Node end
		/// </summary>
		protected RAstarClasses.RNode r_end;
		public virtual RAstarClasses.RNode Rend
		{
			get
			{
				if(r_end == null)
				{
					r_end = new(this, "end");
					r_end.SetBelong(this.instance);
				}
				return r_end;
			}
		}

		/// <summary>
		/// AstarPath+BinaryHeap open
		/// </summary>
		protected RAstarPath.RBinaryHeap r_open;
		public virtual RAstarPath.RBinaryHeap Ropen
		{
			get
			{
				if(r_open == null)
				{
					r_open = new(this, "open");
					r_open.SetBelong(this.instance);
				}
				return r_open;
			}
		}

		/// <summary>
		/// AstarClasses.Node current
		/// </summary>
		protected RAstarClasses.RNode r_current;
		public virtual RAstarClasses.RNode Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(this, "current");
					r_current.SetBelong(this.instance);
				}
				return r_current;
			}
		}

		/// <summary>
		/// System.Boolean foundEnd
		/// </summary>
		protected RField r_foundEnd;
		public virtual RField RfoundEnd
		{
			get
			{
				if(r_foundEnd == null)
				{
					r_foundEnd = new(this, "foundEnd");
					r_foundEnd.SetBelong(this.instance);
				}
				return r_foundEnd;
			}
		}

		/// <summary>
		/// System.Single maxFrameTime
		/// </summary>
		protected RField r_maxFrameTime;
		public virtual RField RmaxFrameTime
		{
			get
			{
				if(r_maxFrameTime == null)
				{
					r_maxFrameTime = new(this, "maxFrameTime");
					r_maxFrameTime.SetBelong(this.instance);
				}
				return r_maxFrameTime;
			}
		}

		/// <summary>
		/// System.Single maxAngle
		/// </summary>
		protected RField r_maxAngle;
		public virtual RField RmaxAngle
		{
			get
			{
				if(r_maxAngle == null)
				{
					r_maxAngle = new(this, "maxAngle");
					r_maxAngle.SetBelong(this.instance);
				}
				return r_maxAngle;
			}
		}

		/// <summary>
		/// System.Single angleCost
		/// </summary>
		protected RField r_angleCost;
		public virtual RField RangleCost
		{
			get
			{
				if(r_angleCost == null)
				{
					r_angleCost = new(this, "angleCost");
					r_angleCost.SetBelong(this.instance);
				}
				return r_angleCost;
			}
		}

		/// <summary>
		/// System.Boolean stepByStep
		/// </summary>
		protected RField r_stepByStep;
		public virtual RField RstepByStep
		{
			get
			{
				if(r_stepByStep == null)
				{
					r_stepByStep = new(this, "stepByStep");
					r_stepByStep.SetBelong(this.instance);
				}
				return r_stepByStep;
			}
		}

		/// <summary>
		/// System.Single realStartTime
		/// </summary>
		protected RField r_realStartTime;
		public virtual RField RrealStartTime
		{
			get
			{
				if(r_realStartTime == null)
				{
					r_realStartTime = new(this, "realStartTime");
					r_realStartTime.SetBelong(this.instance);
				}
				return r_realStartTime;
			}
		}

		/// <summary>
		/// AstarClasses.Node[] path
		/// </summary>
		protected RFieldArray<RAstarClasses.RNode> r_path;
		public virtual RFieldArray<RAstarClasses.RNode> Rpath
		{
			get
			{
				if(r_path == null)
				{
					r_path = new(this, "path");
					r_path.SetBelong(this.instance);
				}
				return r_path;
			}
		}

		/// <summary>
		/// System.Boolean error
		/// </summary>
		protected RField r_error;
		public virtual RField Rerror
		{
			get
			{
				if(r_error == null)
				{
					r_error = new(this, "error");
					r_error.SetBelong(this.instance);
				}
				return r_error;
			}
		}

		/// <summary>
		/// System.Single t
		/// </summary>
		protected RField r_t;
		public virtual RField Rt
		{
			get
			{
				if(r_t == null)
				{
					r_t = new(this, "t");
					r_t.SetBelong(this.instance);
				}
				return r_t;
			}
		}

		/// <summary>
		/// System.Int32 frames
		/// </summary>
		protected RField r_frames;
		public virtual RField Rframes
		{
			get
			{
				if(r_frames == null)
				{
					r_frames = new(this, "frames");
					r_frames.SetBelong(this.instance);
				}
				return r_frames;
			}
		}

		/// <summary>
		/// System.Int32 closedNodes
		/// </summary>
		protected RField r_closedNodes;
		public virtual RField RclosedNodes
		{
			get
			{
				if(r_closedNodes == null)
				{
					r_closedNodes = new(this, "closedNodes");
					r_closedNodes.SetBelong(this.instance);
				}
				return r_closedNodes;
			}
		}

		/// <summary>
		/// System.Boolean forceStartSnap
		/// </summary>
		protected RField r_forceStartSnap;
		public virtual RField RforceStartSnap
		{
			get
			{
				if(r_forceStartSnap == null)
				{
					r_forceStartSnap = new(this, "forceStartSnap");
					r_forceStartSnap.SetBelong(this.instance);
				}
				return r_forceStartSnap;
			}
		}

		/// <summary>
		/// System.Boolean forceEndSnap
		/// </summary>
		protected RField r_forceEndSnap;
		public virtual RField RforceEndSnap
		{
			get
			{
				if(r_forceEndSnap == null)
				{
					r_forceEndSnap = new(this, "forceEndSnap");
					r_forceEndSnap.SetBelong(this.instance);
				}
				return r_forceEndSnap;
			}
		}

		/// <summary>
		/// Void PostNew(AstarClasses.Int3, AstarClasses.Int3)
		/// </summary>
		protected RMethod r_RPostNew_Int3_Int3;
		public virtual RMethod RPostNew_Int3_Int3
		{
			get
			{
				if(r_RPostNew_Int3_Int3 == null)
				{
					r_RPostNew_Int3_Int3 = new(this, "PostNew", 0, typeof(AstarClasses.Int3), typeof(AstarClasses.Int3));
					r_RPostNew_Int3_Int3.SetBelong(this.instance);
				}
				return r_RPostNew_Int3_Int3;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void Calc(Boolean)
		/// </summary>
		protected RMethod r_RCalc_Boolean;
		public virtual RMethod RCalc_Boolean
		{
			get
			{
				if(r_RCalc_Boolean == null)
				{
					r_RCalc_Boolean = new(this, "Calc", 0, typeof(System.Boolean));
					r_RCalc_Boolean.SetBelong(this.instance);
				}
				return r_RCalc_Boolean;
			}
		}

		/// <summary>
		/// Void Open(Int32)
		/// </summary>
		protected RMethod r_ROpen_Int32;
		public virtual RMethod ROpen_Int32
		{
			get
			{
				if(r_ROpen_Int32 == null)
				{
					r_ROpen_Int32 = new(this, "Open", 0, typeof(System.Int32));
					r_ROpen_Int32.SetBelong(this.instance);
				}
				return r_ROpen_Int32;
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


        public RPath() : base("AstarPath+Path")
        {
        }

        public RPath(System.Object instance) : base("AstarPath+Path")
		{
            SetInstance(instance);
		}

        public RPath(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPath(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void PostNew(AstarClasses.Int3  @startPos, AstarClasses.Int3  @endPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos, @endPos};
            var ___result = RPostNew_Int3_Int3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Calc(System.Boolean  @multithreaded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multithreaded};
            var ___result = RCalc_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Open(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = ROpen_Int32.Invoke(___genericsType, ___parameters);

            
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