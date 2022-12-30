using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMyGUI
{
	/// <summary>
	/// MyGUI.DragDropInfo
	/// </summary>
    public partial class RDragDropInfo : RMember //
    {

		/// <summary>
		/// MyGUI.DragDropInfo+CollectionType CollectionId
		/// </summary>
		protected RField r_CollectionId;
		public virtual RField RCollectionId
		{
			get
			{
				if(r_CollectionId == null)
				{
					r_CollectionId = new(this, "CollectionId");
					r_CollectionId.SetBelong(this.instance);
				}
				return r_CollectionId;
			}
		}

		/// <summary>
		/// System.String GameObjectSource
		/// </summary>
		protected RField r_GameObjectSource;
		public virtual RField RGameObjectSource
		{
			get
			{
				if(r_GameObjectSource == null)
				{
					r_GameObjectSource = new(this, "GameObjectSource");
					r_GameObjectSource.SetBelong(this.instance);
				}
				return r_GameObjectSource;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 IconSize
		/// </summary>
		protected RUnityEngine.RVector2 r_IconSize;
		public virtual RUnityEngine.RVector2 RIconSize
		{
			get
			{
				if(r_IconSize == null)
				{
					r_IconSize = new(this, "IconSize");
					r_IconSize.SetBelong(this.instance);
				}
				return r_IconSize;
			}
		}

		/// <summary>
		/// System.String IconSource
		/// </summary>
		protected RField r_IconSource;
		public virtual RField RIconSource
		{
			get
			{
				if(r_IconSource == null)
				{
					r_IconSource = new(this, "IconSource");
					r_IconSource.SetBelong(this.instance);
				}
				return r_IconSource;
			}
		}

		/// <summary>
		/// System.Int64 ItemId
		/// </summary>
		protected RField r_ItemId;
		public virtual RField RItemId
		{
			get
			{
				if(r_ItemId == null)
				{
					r_ItemId = new(this, "ItemId");
					r_ItemId.SetBelong(this.instance);
				}
				return r_ItemId;
			}
		}

		/// <summary>
		/// MyGUI.DragDropInfo+DragDropResult Result
		/// </summary>
		protected RField r_Result;
		public virtual RField Result
		{
			get
			{
				if(r_Result == null)
				{
					r_Result = new(this, "Result");
					r_Result.SetBelong(this.instance);
				}
				return r_Result;
			}
		}

		/// <summary>
		/// MyGUI.DragDropInfo+DragDropSourceType SourceType
		/// </summary>
		protected RField r_SourceType;
		public virtual RField RSourceType
		{
			get
			{
				if(r_SourceType == null)
				{
					r_SourceType = new(this, "SourceType");
					r_SourceType.SetBelong(this.instance);
				}
				return r_SourceType;
			}
		}

		/// <summary>
		/// MyGUI.DragDropInfo+DragDropSourceType TargetType
		/// </summary>
		protected RField r_TargetType;
		public virtual RField RTargetType
		{
			get
			{
				if(r_TargetType == null)
				{
					r_TargetType = new(this, "TargetType");
					r_TargetType.SetBelong(this.instance);
				}
				return r_TargetType;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase UISource
		/// </summary>
		protected RMyGUI.RElementBase r_UISource;
		public virtual RMyGUI.RElementBase RUISource
		{
			get
			{
				if(r_UISource == null)
				{
					r_UISource = new(this, "UISource");
					r_UISource.SetBelong(this.instance);
				}
				return r_UISource;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase UITarget
		/// </summary>
		protected RMyGUI.RElementBase r_UITarget;
		public virtual RMyGUI.RElementBase RUITarget
		{
			get
			{
				if(r_UITarget == null)
				{
					r_UITarget = new(this, "UITarget");
					r_UITarget.SetBelong(this.instance);
				}
				return r_UITarget;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject WorldSource
		/// </summary>
		protected RUnityEngine.RGameObject r_WorldSource;
		public virtual RUnityEngine.RGameObject RWorldSource
		{
			get
			{
				if(r_WorldSource == null)
				{
					r_WorldSource = new(this, "WorldSource");
					r_WorldSource.SetBelong(this.instance);
				}
				return r_WorldSource;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject WorldTarget
		/// </summary>
		protected RUnityEngine.RGameObject r_WorldTarget;
		public virtual RUnityEngine.RGameObject RWorldTarget
		{
			get
			{
				if(r_WorldTarget == null)
				{
					r_WorldTarget = new(this, "WorldTarget");
					r_WorldTarget.SetBelong(this.instance);
				}
				return r_WorldTarget;
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


        public RDragDropInfo() : base("MyGUI.DragDropInfo")
        {
        }

        public RDragDropInfo(System.Object instance) : base("MyGUI.DragDropInfo")
		{
            SetInstance(instance);
		}

        public RDragDropInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDragDropInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
