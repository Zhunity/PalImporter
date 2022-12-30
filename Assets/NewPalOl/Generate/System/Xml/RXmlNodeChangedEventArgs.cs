using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlNodeChangedEventArgs
	/// </summary>
    public partial class RXmlNodeChangedEventArgs : RMember //
    {

		/// <summary>
		/// System.Xml.XmlNodeChangedAction action
		/// </summary>
		protected RField r_action;
		public virtual RField Raction
		{
			get
			{
				if(r_action == null)
				{
					r_action = new(this, "action");
					r_action.SetBelong(this.instance);
				}
				return r_action;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode node
		/// </summary>
		protected RSystem.RXml.RXmlNode r_node;
		public virtual RSystem.RXml.RXmlNode Rnode
		{
			get
			{
				if(r_node == null)
				{
					r_node = new(this, "node");
					r_node.SetBelong(this.instance);
				}
				return r_node;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode oldParent
		/// </summary>
		protected RSystem.RXml.RXmlNode r_oldParent;
		public virtual RSystem.RXml.RXmlNode RoldParent
		{
			get
			{
				if(r_oldParent == null)
				{
					r_oldParent = new(this, "oldParent");
					r_oldParent.SetBelong(this.instance);
				}
				return r_oldParent;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode newParent
		/// </summary>
		protected RSystem.RXml.RXmlNode r_newParent;
		public virtual RSystem.RXml.RXmlNode RnewParent
		{
			get
			{
				if(r_newParent == null)
				{
					r_newParent = new(this, "newParent");
					r_newParent.SetBelong(this.instance);
				}
				return r_newParent;
			}
		}

		/// <summary>
		/// System.String oldValue
		/// </summary>
		protected RField r_oldValue;
		public virtual RField RoldValue
		{
			get
			{
				if(r_oldValue == null)
				{
					r_oldValue = new(this, "oldValue");
					r_oldValue.SetBelong(this.instance);
				}
				return r_oldValue;
			}
		}

		/// <summary>
		/// System.String newValue
		/// </summary>
		protected RField r_newValue;
		public virtual RField RnewValue
		{
			get
			{
				if(r_newValue == null)
				{
					r_newValue = new(this, "newValue");
					r_newValue.SetBelong(this.instance);
				}
				return r_newValue;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeChangedAction Action
		/// </summary>
		protected RProperty r_Action;
		public virtual RProperty RAction
		{
			get
			{
				if(r_Action == null)
				{
					r_Action = new(this, "Action", -1);
					r_Action.SetBelong(this.instance);
				}
				return r_Action;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode Node
		/// </summary>
		protected RSystem.RXml.RXmlNode r_Node;
		public virtual RSystem.RXml.RXmlNode RNode
		{
			get
			{
				if(r_Node == null)
				{
					r_Node = new(this, "Node", -1);
					r_Node.SetBelong(this.instance);
				}
				return r_Node;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode OldParent
		/// </summary>
		protected RSystem.RXml.RXmlNode r_OldParent;
		public virtual RSystem.RXml.RXmlNode ROldParent
		{
			get
			{
				if(r_OldParent == null)
				{
					r_OldParent = new(this, "OldParent", -1);
					r_OldParent.SetBelong(this.instance);
				}
				return r_OldParent;
			}
		}

		/// <summary>
		/// System.Xml.XmlNode NewParent
		/// </summary>
		protected RSystem.RXml.RXmlNode r_NewParent;
		public virtual RSystem.RXml.RXmlNode RNewParent
		{
			get
			{
				if(r_NewParent == null)
				{
					r_NewParent = new(this, "NewParent", -1);
					r_NewParent.SetBelong(this.instance);
				}
				return r_NewParent;
			}
		}

		/// <summary>
		/// System.String OldValue
		/// </summary>
		protected RProperty r_OldValue;
		public virtual RProperty ROldValue
		{
			get
			{
				if(r_OldValue == null)
				{
					r_OldValue = new(this, "OldValue", -1);
					r_OldValue.SetBelong(this.instance);
				}
				return r_OldValue;
			}
		}

		/// <summary>
		/// System.String NewValue
		/// </summary>
		protected RProperty r_NewValue;
		public virtual RProperty RNewValue
		{
			get
			{
				if(r_NewValue == null)
				{
					r_NewValue = new(this, "NewValue", -1);
					r_NewValue.SetBelong(this.instance);
				}
				return r_NewValue;
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


        public RXmlNodeChangedEventArgs() : base("System.Xml.XmlNodeChangedEventArgs")
        {
        }

        public RXmlNodeChangedEventArgs(System.Object instance) : base("System.Xml.XmlNodeChangedEventArgs")
		{
            SetInstance(instance);
		}

        public RXmlNodeChangedEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlNodeChangedEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
