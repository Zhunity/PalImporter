using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.Grid
	/// </summary>
    public partial class RGrid : RMember //
    {

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
		/// System.Boolean showInEditor
		/// </summary>
		protected RField r_showInEditor;
		public virtual RField RshowInEditor
		{
			get
			{
				if(r_showInEditor == null)
				{
					r_showInEditor = new(this, "showInEditor");
					r_showInEditor.SetBelong(this.instance);
				}
				return r_showInEditor;
			}
		}

		/// <summary>
		/// System.Boolean debug
		/// </summary>
		protected RField r_debug;
		public virtual RField Rdebug
		{
			get
			{
				if(r_debug == null)
				{
					r_debug = new(this, "debug");
					r_debug.SetBelong(this.instance);
				}
				return r_debug;
			}
		}

		/// <summary>
		/// System.Boolean changed
		/// </summary>
		protected RField r_changed;
		public virtual RField Rchanged
		{
			get
			{
				if(r_changed == null)
				{
					r_changed = new(this, "changed");
					r_changed.SetBelong(this.instance);
				}
				return r_changed;
			}
		}

		/// <summary>
		/// System.Single _height
		/// </summary>
		protected RField r__height;
		public virtual RField R_height
		{
			get
			{
				if(r__height == null)
				{
					r__height = new(this, "_height");
					r__height.SetBelong(this.instance);
				}
				return r__height;
			}
		}

		/// <summary>
		/// System.Int32 _width
		/// </summary>
		protected RField r__width;
		public virtual RField R_width
		{
			get
			{
				if(r__width == null)
				{
					r__width = new(this, "_width");
					r__width.SetBelong(this.instance);
				}
				return r__width;
			}
		}

		/// <summary>
		/// System.Int32 _depth
		/// </summary>
		protected RField r__depth;
		public virtual RField R_depth
		{
			get
			{
				if(r__depth == null)
				{
					r__depth = new(this, "_depth");
					r__depth.SetBelong(this.instance);
				}
				return r__depth;
			}
		}

		/// <summary>
		/// System.Single scale
		/// </summary>
		protected RField r_scale;
		public virtual RField Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale");
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 offset
		/// </summary>
		protected RUnityEngine.RVector3 r_offset;
		public virtual RUnityEngine.RVector3 Roffset
		{
			get
			{
				if(r_offset == null)
				{
					r_offset = new(this, "offset");
					r_offset.SetBelong(this.instance);
				}
				return r_offset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 globalOffset
		/// </summary>
		protected RUnityEngine.RVector3 r_globalOffset;
		public virtual RUnityEngine.RVector3 RglobalOffset
		{
			get
			{
				if(r_globalOffset == null)
				{
					r_globalOffset = new(this, "globalOffset");
					r_globalOffset.SetBelong(this.instance);
				}
				return r_globalOffset;
			}
		}

		/// <summary>
		/// System.Single nodeSize
		/// </summary>
		protected RField r_nodeSize;
		public virtual RField RnodeSize
		{
			get
			{
				if(r_nodeSize == null)
				{
					r_nodeSize = new(this, "nodeSize");
					r_nodeSize.SetBelong(this.instance);
				}
				return r_nodeSize;
			}
		}

		/// <summary>
		/// System.Single globalWidth
		/// </summary>
		protected RField r_globalWidth;
		public virtual RField RglobalWidth
		{
			get
			{
				if(r_globalWidth == null)
				{
					r_globalWidth = new(this, "globalWidth");
					r_globalWidth.SetBelong(this.instance);
				}
				return r_globalWidth;
			}
		}

		/// <summary>
		/// System.Single globalDepth
		/// </summary>
		protected RField r_globalDepth;
		public virtual RField RglobalDepth
		{
			get
			{
				if(r_globalDepth == null)
				{
					r_globalDepth = new(this, "globalDepth");
					r_globalDepth.SetBelong(this.instance);
				}
				return r_globalDepth;
			}
		}

		/// <summary>
		/// System.Single globalHeight
		/// </summary>
		protected RField r_globalHeight;
		public virtual RField RglobalHeight
		{
			get
			{
				if(r_globalHeight == null)
				{
					r_globalHeight = new(this, "globalHeight");
					r_globalHeight.SetBelong(this.instance);
				}
				return r_globalHeight;
			}
		}

		/// <summary>
		/// System.Boolean showPhysics
		/// </summary>
		protected RField r_showPhysics;
		public virtual RField RshowPhysics
		{
			get
			{
				if(r_showPhysics == null)
				{
					r_showPhysics = new(this, "showPhysics");
					r_showPhysics.SetBelong(this.instance);
				}
				return r_showPhysics;
			}
		}

		/// <summary>
		/// System.Int32 ignoreLayer
		/// </summary>
		protected RField r_ignoreLayer;
		public virtual RField RignoreLayer
		{
			get
			{
				if(r_ignoreLayer == null)
				{
					r_ignoreLayer = new(this, "ignoreLayer");
					r_ignoreLayer.SetBelong(this.instance);
				}
				return r_ignoreLayer;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask physicsMask
		/// </summary>
		protected RUnityEngine.RLayerMask r_physicsMask;
		public virtual RUnityEngine.RLayerMask RphysicsMask
		{
			get
			{
				if(r_physicsMask == null)
				{
					r_physicsMask = new(this, "physicsMask");
					r_physicsMask.SetBelong(this.instance);
				}
				return r_physicsMask;
			}
		}

		/// <summary>
		/// AstarClasses.PhysicsType physicsType
		/// </summary>
		protected RField r_physicsType;
		public virtual RField RphysicsType
		{
			get
			{
				if(r_physicsType == null)
				{
					r_physicsType = new(this, "physicsType");
					r_physicsType.SetBelong(this.instance);
				}
				return r_physicsType;
			}
		}

		/// <summary>
		/// AstarClasses.UpDown raycastUpDown
		/// </summary>
		protected RField r_raycastUpDown;
		public virtual RField RraycastUpDown
		{
			get
			{
				if(r_raycastUpDown == null)
				{
					r_raycastUpDown = new(this, "raycastUpDown");
					r_raycastUpDown.SetBelong(this.instance);
				}
				return r_raycastUpDown;
			}
		}

		/// <summary>
		/// System.Single raycastLength
		/// </summary>
		protected RField r_raycastLength;
		public virtual RField RraycastLength
		{
			get
			{
				if(r_raycastLength == null)
				{
					r_raycastLength = new(this, "raycastLength");
					r_raycastLength.SetBelong(this.instance);
				}
				return r_raycastLength;
			}
		}

		/// <summary>
		/// System.Single capsuleHeight
		/// </summary>
		protected RField r_capsuleHeight;
		public virtual RField RcapsuleHeight
		{
			get
			{
				if(r_capsuleHeight == null)
				{
					r_capsuleHeight = new(this, "capsuleHeight");
					r_capsuleHeight.SetBelong(this.instance);
				}
				return r_capsuleHeight;
			}
		}

		/// <summary>
		/// System.Single physicsRadius
		/// </summary>
		protected RField r_physicsRadius;
		public virtual RField RphysicsRadius
		{
			get
			{
				if(r_physicsRadius == null)
				{
					r_physicsRadius = new(this, "physicsRadius");
					r_physicsRadius.SetBelong(this.instance);
				}
				return r_physicsRadius;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected RProperty r_depth;
		public virtual RProperty Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth", -1);
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 realOffset
		/// </summary>
		protected RUnityEngine.RVector3 r_realOffset;
		public virtual RUnityEngine.RVector3 RrealOffset
		{
			get
			{
				if(r_realOffset == null)
				{
					r_realOffset = new(this, "realOffset", -1);
					r_realOffset.SetBelong(this.instance);
				}
				return r_realOffset;
			}
		}

		/// <summary>
		/// Boolean Contains(AstarClasses.Int3)
		/// </summary>
		protected RMethod r_RContains_Int3;
		public virtual RMethod RContains_Int3
		{
			get
			{
				if(r_RContains_Int3 == null)
				{
					r_RContains_Int3 = new(this, "Contains", 0, typeof(AstarClasses.Int3));
					r_RContains_Int3.SetBelong(this.instance);
				}
				return r_RContains_Int3;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RContains_Vector3;
		public virtual RMethod RContains_Vector3
		{
			get
			{
				if(r_RContains_Vector3 == null)
				{
					r_RContains_Vector3 = new(this, "Contains", 0, typeof(UnityEngine.Vector3));
					r_RContains_Vector3.SetBelong(this.instance);
				}
				return r_RContains_Vector3;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
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


        public RGrid() : base("AstarClasses.Grid")
        {
        }

        public RGrid(System.Object instance) : base("AstarClasses.Grid")
		{
            SetInstance(instance);
		}

        public RGrid(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGrid(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Contains(AstarClasses.Int3  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RContains_Int3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RContains_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
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
