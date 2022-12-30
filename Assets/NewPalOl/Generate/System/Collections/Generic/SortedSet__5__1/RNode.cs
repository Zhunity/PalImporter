using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric
{public partial class RSortedSet<T>
{
	
	/// <summary>
	/// System.Collections.Generic.SortedSet`1+Node
	/// </summary>
    public partial class RNode : RMember //
    {

		/// <summary>
		/// T <Item>k__BackingField
		/// </summary>
		protected RField r___2__Item__4__k__BackingField;
		public virtual RField R__2__Item__4__k__BackingField
		{
			get
			{
				if(r___2__Item__4__k__BackingField == null)
				{
					r___2__Item__4__k__BackingField = new(this, "<Item>k__BackingField");
					r___2__Item__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__Item__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedSet`1+Node[T] <Left>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode r___2__Left__4__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode R__2__Left__4__k__BackingField
		{
			get
			{
				if(r___2__Left__4__k__BackingField == null)
				{
					r___2__Left__4__k__BackingField = new(this, "<Left>k__BackingField");
					r___2__Left__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__Left__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.SortedSet`1+Node[T] <Right>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode r___2__Right__4__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RField>.RNode R__2__Right__4__k__BackingField
		{
			get
			{
				if(r___2__Right__4__k__BackingField == null)
				{
					r___2__Right__4__k__BackingField = new(this, "<Right>k__BackingField");
					r___2__Right__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__Right__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.NodeColor <Color>k__BackingField
		/// </summary>
		protected RField r___2__Color__4__k__BackingField;
		public virtual RField R__2__Color__4__k__BackingField
		{
			get
			{
				if(r___2__Color__4__k__BackingField == null)
				{
					r___2__Color__4__k__BackingField = new(this, "<Color>k__BackingField");
					r___2__Color__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__Color__4__k__BackingField;
			}
		}

		/// <summary>
		/// T Item
		/// </summary>
		protected RProperty r_Item;
		public virtual RProperty RItem
		{
			get
			{
				if(r_Item == null)
				{
					r_Item = new(this, "Item", -1);
					r_Item.SetBelong(this.instance);
				}
				return r_Item;
			}
		}

		/// <summary>
		/// Node Left
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RProperty>.RNode r_Left;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RProperty>.RNode RLeft
		{
			get
			{
				if(r_Left == null)
				{
					r_Left = new(this, "Left", -1);
					r_Left.SetBelong(this.instance);
				}
				return r_Left;
			}
		}

		/// <summary>
		/// Node Right
		/// </summary>
		protected RSystem.RCollections.RGeneric.RSortedSet<RProperty>.RNode r_Right;
		public virtual RSystem.RCollections.RGeneric.RSortedSet<RProperty>.RNode Right
		{
			get
			{
				if(r_Right == null)
				{
					r_Right = new(this, "Right", -1);
					r_Right.SetBelong(this.instance);
				}
				return r_Right;
			}
		}

		/// <summary>
		/// System.Collections.Generic.NodeColor Color
		/// </summary>
		protected RProperty r_Color;
		public virtual RProperty RColor
		{
			get
			{
				if(r_Color == null)
				{
					r_Color = new(this, "Color", -1);
					r_Color.SetBelong(this.instance);
				}
				return r_Color;
			}
		}

		/// <summary>
		/// Boolean IsBlack
		/// </summary>
		protected RProperty r_IsBlack;
		public virtual RProperty RIsBlack
		{
			get
			{
				if(r_IsBlack == null)
				{
					r_IsBlack = new(this, "IsBlack", -1);
					r_IsBlack.SetBelong(this.instance);
				}
				return r_IsBlack;
			}
		}

		/// <summary>
		/// Boolean IsRed
		/// </summary>
		protected RProperty r_IsRed;
		public virtual RProperty RIsRed
		{
			get
			{
				if(r_IsRed == null)
				{
					r_IsRed = new(this, "IsRed", -1);
					r_IsRed.SetBelong(this.instance);
				}
				return r_IsRed;
			}
		}

		/// <summary>
		/// Boolean Is2Node
		/// </summary>
		protected RProperty r_Is2Node;
		public virtual RProperty RIs2Node
		{
			get
			{
				if(r_Is2Node == null)
				{
					r_Is2Node = new(this, "Is2Node", -1);
					r_Is2Node.SetBelong(this.instance);
				}
				return r_Is2Node;
			}
		}

		/// <summary>
		/// Boolean Is4Node
		/// </summary>
		protected RProperty r_Is4Node;
		public virtual RProperty RIs4Node
		{
			get
			{
				if(r_Is4Node == null)
				{
					r_Is4Node = new(this, "Is4Node", -1);
					r_Is4Node.SetBelong(this.instance);
				}
				return r_Is4Node;
			}
		}

		/// <summary>
		/// Boolean IsNonNullBlack(Node)
		/// </summary>
		protected static RMethod r_RIsNonNullBlack_Node;
		public static RMethod RIsNonNullBlack_Node
		{
			get
			{
				if(r_RIsNonNullBlack_Node == null)
				{
					r_RIsNonNullBlack_Node = new( ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"), "IsNonNullBlack", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RIsNonNullBlack_Node.SetBelong(null);
				}
				return r_RIsNonNullBlack_Node;
			}
		}

		/// <summary>
		/// Boolean IsNonNullRed(Node)
		/// </summary>
		protected static RMethod r_RIsNonNullRed_Node;
		public static RMethod RIsNonNullRed_Node
		{
			get
			{
				if(r_RIsNonNullRed_Node == null)
				{
					r_RIsNonNullRed_Node = new( ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"), "IsNonNullRed", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RIsNonNullRed_Node.SetBelong(null);
				}
				return r_RIsNonNullRed_Node;
			}
		}

		/// <summary>
		/// Boolean IsNullOrBlack(Node)
		/// </summary>
		protected static RMethod r_RIsNullOrBlack_Node;
		public static RMethod RIsNullOrBlack_Node
		{
			get
			{
				if(r_RIsNullOrBlack_Node == null)
				{
					r_RIsNullOrBlack_Node = new( ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"), "IsNullOrBlack", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RIsNullOrBlack_Node.SetBelong(null);
				}
				return r_RIsNullOrBlack_Node;
			}
		}

		/// <summary>
		/// Void ColorBlack()
		/// </summary>
		protected RMethod r_RColorBlack;
		public virtual RMethod RColorBlack
		{
			get
			{
				if(r_RColorBlack == null)
				{
					r_RColorBlack = new(this, "ColorBlack", 0);
					r_RColorBlack.SetBelong(this.instance);
				}
				return r_RColorBlack;
			}
		}

		/// <summary>
		/// Void ColorRed()
		/// </summary>
		protected RMethod r_RColorRed;
		public virtual RMethod RColorRed
		{
			get
			{
				if(r_RColorRed == null)
				{
					r_RColorRed = new(this, "ColorRed", 0);
					r_RColorRed.SetBelong(this.instance);
				}
				return r_RColorRed;
			}
		}

		/// <summary>
		/// Node DeepClone(Int32)
		/// </summary>
		protected RMethod r_RDeepClone_Int32;
		public virtual RMethod RDeepClone_Int32
		{
			get
			{
				if(r_RDeepClone_Int32 == null)
				{
					r_RDeepClone_Int32 = new(this, "DeepClone", 0, typeof(System.Int32));
					r_RDeepClone_Int32.SetBelong(this.instance);
				}
				return r_RDeepClone_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.TreeRotation GetRotation(Node, Node)
		/// </summary>
		protected RMethod r_RGetRotation_Node_Node;
		public virtual RMethod RGetRotation_Node_Node
		{
			get
			{
				if(r_RGetRotation_Node_Node == null)
				{
					r_RGetRotation_Node_Node = new(this, "GetRotation", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RGetRotation_Node_Node.SetBelong(this.instance);
				}
				return r_RGetRotation_Node_Node;
			}
		}

		/// <summary>
		/// Node GetSibling(Node)
		/// </summary>
		protected RMethod r_RGetSibling_Node;
		public virtual RMethod RGetSibling_Node
		{
			get
			{
				if(r_RGetSibling_Node == null)
				{
					r_RGetSibling_Node = new(this, "GetSibling", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RGetSibling_Node.SetBelong(this.instance);
				}
				return r_RGetSibling_Node;
			}
		}

		/// <summary>
		/// Node ShallowClone()
		/// </summary>
		protected RMethod r_RShallowClone;
		public virtual RMethod RShallowClone
		{
			get
			{
				if(r_RShallowClone == null)
				{
					r_RShallowClone = new(this, "ShallowClone", 0);
					r_RShallowClone.SetBelong(this.instance);
				}
				return r_RShallowClone;
			}
		}

		/// <summary>
		/// Void Split4Node()
		/// </summary>
		protected RMethod r_RSplit4Node;
		public virtual RMethod RSplit4Node
		{
			get
			{
				if(r_RSplit4Node == null)
				{
					r_RSplit4Node = new(this, "Split4Node", 0);
					r_RSplit4Node.SetBelong(this.instance);
				}
				return r_RSplit4Node;
			}
		}

		/// <summary>
		/// Node Rotate(System.Collections.Generic.TreeRotation)
		/// </summary>
		protected RMethod r_RRotate_TreeRotation;
		public virtual RMethod RRotate_TreeRotation
		{
			get
			{
				if(r_RRotate_TreeRotation == null)
				{
					r_RRotate_TreeRotation = new(this, "Rotate", 0,  ReleactionUtils.GetType("System.Collections.Generic.TreeRotation"));
					r_RRotate_TreeRotation.SetBelong(this.instance);
				}
				return r_RRotate_TreeRotation;
			}
		}

		/// <summary>
		/// Node RotateLeft()
		/// </summary>
		protected RMethod r_RRotateLeft;
		public virtual RMethod RRotateLeft
		{
			get
			{
				if(r_RRotateLeft == null)
				{
					r_RRotateLeft = new(this, "RotateLeft", 0);
					r_RRotateLeft.SetBelong(this.instance);
				}
				return r_RRotateLeft;
			}
		}

		/// <summary>
		/// Node RotateLeftRight()
		/// </summary>
		protected RMethod r_RRotateLeftRight;
		public virtual RMethod RRotateLeftRight
		{
			get
			{
				if(r_RRotateLeftRight == null)
				{
					r_RRotateLeftRight = new(this, "RotateLeftRight", 0);
					r_RRotateLeftRight.SetBelong(this.instance);
				}
				return r_RRotateLeftRight;
			}
		}

		/// <summary>
		/// Node RotateRight()
		/// </summary>
		protected RMethod r_RRotateRight;
		public virtual RMethod RRotateRight
		{
			get
			{
				if(r_RRotateRight == null)
				{
					r_RRotateRight = new(this, "RotateRight", 0);
					r_RRotateRight.SetBelong(this.instance);
				}
				return r_RRotateRight;
			}
		}

		/// <summary>
		/// Node RotateRightLeft()
		/// </summary>
		protected RMethod r_RRotateRightLeft;
		public virtual RMethod RRotateRightLeft
		{
			get
			{
				if(r_RRotateRightLeft == null)
				{
					r_RRotateRightLeft = new(this, "RotateRightLeft", 0);
					r_RRotateRightLeft.SetBelong(this.instance);
				}
				return r_RRotateRightLeft;
			}
		}

		/// <summary>
		/// Void Merge2Nodes()
		/// </summary>
		protected RMethod r_RMerge2Nodes;
		public virtual RMethod RMerge2Nodes
		{
			get
			{
				if(r_RMerge2Nodes == null)
				{
					r_RMerge2Nodes = new(this, "Merge2Nodes", 0);
					r_RMerge2Nodes.SetBelong(this.instance);
				}
				return r_RMerge2Nodes;
			}
		}

		/// <summary>
		/// Void ReplaceChild(Node, Node)
		/// </summary>
		protected RMethod r_RReplaceChild_Node_Node;
		public virtual RMethod RReplaceChild_Node_Node
		{
			get
			{
				if(r_RReplaceChild_Node_Node == null)
				{
					r_RReplaceChild_Node_Node = new(this, "ReplaceChild", 0,  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"),  ReleactionUtils.GetType("System.Collections.Generic.SortedSet`1+Node"));
					r_RReplaceChild_Node_Node.SetBelong(this.instance);
				}
				return r_RReplaceChild_Node_Node;
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


        public RNode() : base("System.Collections.Generic.SortedSet`1+Node")
        {
        }

        public RNode(System.Object instance) : base("System.Collections.Generic.SortedSet`1+Node")
		{
            SetInstance(instance);
		}

        public RNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }




        public virtual void ColorBlack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RColorBlack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ColorRed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RColorRed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DeepClone(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RDeepClone_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.Object ShallowClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShallowClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Split4Node()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSplit4Node.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object RotateLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRotateLeft.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object RotateLeftRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRotateLeftRight.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object RotateRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRotateRight.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object RotateRightLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRotateRightLeft.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Merge2Nodes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMerge2Nodes.Invoke(___genericsType, ___parameters);

            
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