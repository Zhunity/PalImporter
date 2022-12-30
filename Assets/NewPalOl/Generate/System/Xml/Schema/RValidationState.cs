using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.ValidationState
	/// </summary>
    public partial class RValidationState : RMember //
    {

		/// <summary>
		/// System.Boolean IsNill
		/// </summary>
		protected RField r_IsNill;
		public virtual RField RIsNill
		{
			get
			{
				if(r_IsNill == null)
				{
					r_IsNill = new(this, "IsNill");
					r_IsNill.SetBelong(this.instance);
				}
				return r_IsNill;
			}
		}

		/// <summary>
		/// System.Boolean IsDefault
		/// </summary>
		protected RField r_IsDefault;
		public virtual RField RIsDefault
		{
			get
			{
				if(r_IsDefault == null)
				{
					r_IsDefault = new(this, "IsDefault");
					r_IsDefault.SetBelong(this.instance);
				}
				return r_IsDefault;
			}
		}

		/// <summary>
		/// System.Boolean NeedValidateChildren
		/// </summary>
		protected RField r_NeedValidateChildren;
		public virtual RField RNeedValidateChildren
		{
			get
			{
				if(r_NeedValidateChildren == null)
				{
					r_NeedValidateChildren = new(this, "NeedValidateChildren");
					r_NeedValidateChildren.SetBelong(this.instance);
				}
				return r_NeedValidateChildren;
			}
		}

		/// <summary>
		/// System.Boolean CheckRequiredAttribute
		/// </summary>
		protected RField r_CheckRequiredAttribute;
		public virtual RField RCheckRequiredAttribute
		{
			get
			{
				if(r_CheckRequiredAttribute == null)
				{
					r_CheckRequiredAttribute = new(this, "CheckRequiredAttribute");
					r_CheckRequiredAttribute.SetBelong(this.instance);
				}
				return r_CheckRequiredAttribute;
			}
		}

		/// <summary>
		/// System.Boolean ValidationSkipped
		/// </summary>
		protected RField r_ValidationSkipped;
		public virtual RField RValidationSkipped
		{
			get
			{
				if(r_ValidationSkipped == null)
				{
					r_ValidationSkipped = new(this, "ValidationSkipped");
					r_ValidationSkipped.SetBelong(this.instance);
				}
				return r_ValidationSkipped;
			}
		}

		/// <summary>
		/// System.Int32 Depth
		/// </summary>
		protected RField r_Depth;
		public virtual RField RDepth
		{
			get
			{
				if(r_Depth == null)
				{
					r_Depth = new(this, "Depth");
					r_Depth.SetBelong(this.instance);
				}
				return r_Depth;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentProcessing ProcessContents
		/// </summary>
		protected RField r_ProcessContents;
		public virtual RField RProcessContents
		{
			get
			{
				if(r_ProcessContents == null)
				{
					r_ProcessContents = new(this, "ProcessContents");
					r_ProcessContents.SetBelong(this.instance);
				}
				return r_ProcessContents;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaValidity Validity
		/// </summary>
		protected RField r_Validity;
		public virtual RField RValidity
		{
			get
			{
				if(r_Validity == null)
				{
					r_Validity = new(this, "Validity");
					r_Validity.SetBelong(this.instance);
				}
				return r_Validity;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl ElementDecl
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaElementDecl r_ElementDecl;
		public virtual RSystem.RXml.RSchema.RSchemaElementDecl RElementDecl
		{
			get
			{
				if(r_ElementDecl == null)
				{
					r_ElementDecl = new(this, "ElementDecl");
					r_ElementDecl.SetBelong(this.instance);
				}
				return r_ElementDecl;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaElementDecl ElementDeclBeforeXsi
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaElementDecl r_ElementDeclBeforeXsi;
		public virtual RSystem.RXml.RSchema.RSchemaElementDecl RElementDeclBeforeXsi
		{
			get
			{
				if(r_ElementDeclBeforeXsi == null)
				{
					r_ElementDeclBeforeXsi = new(this, "ElementDeclBeforeXsi");
					r_ElementDeclBeforeXsi.SetBelong(this.instance);
				}
				return r_ElementDeclBeforeXsi;
			}
		}

		/// <summary>
		/// System.String LocalName
		/// </summary>
		protected RField r_LocalName;
		public virtual RField RLocalName
		{
			get
			{
				if(r_LocalName == null)
				{
					r_LocalName = new(this, "LocalName");
					r_LocalName.SetBelong(this.instance);
				}
				return r_LocalName;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected RField r_Namespace;
		public virtual RField RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(this, "Namespace");
					r_Namespace.SetBelong(this.instance);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ConstraintStruct[] Constr
		/// </summary>
		protected RFieldArray<RSystem.RXml.RSchema.RConstraintStruct> r_Constr;
		public virtual RFieldArray<RSystem.RXml.RSchema.RConstraintStruct> RConstr
		{
			get
			{
				if(r_Constr == null)
				{
					r_Constr = new(this, "Constr");
					r_Constr.SetBelong(this.instance);
				}
				return r_Constr;
			}
		}

		/// <summary>
		/// System.Xml.Schema.StateUnion CurrentState
		/// </summary>
		protected RSystem.RXml.RSchema.RStateUnion r_CurrentState;
		public virtual RSystem.RXml.RSchema.RStateUnion RCurrentState
		{
			get
			{
				if(r_CurrentState == null)
				{
					r_CurrentState = new(this, "CurrentState");
					r_CurrentState.SetBelong(this.instance);
				}
				return r_CurrentState;
			}
		}

		/// <summary>
		/// System.Boolean HasMatched
		/// </summary>
		protected RField r_HasMatched;
		public virtual RField RHasMatched
		{
			get
			{
				if(r_HasMatched == null)
				{
					r_HasMatched = new(this, "HasMatched");
					r_HasMatched.SetBelong(this.instance);
				}
				return r_HasMatched;
			}
		}

		/// <summary>
		/// System.Xml.Schema.BitSet[] CurPos
		/// </summary>
		protected RFieldArray<RSystem.RXml.RSchema.RBitSet> r_CurPos;
		public virtual RFieldArray<RSystem.RXml.RSchema.RBitSet> RCurPos
		{
			get
			{
				if(r_CurPos == null)
				{
					r_CurPos = new(this, "CurPos");
					r_CurPos.SetBelong(this.instance);
				}
				return r_CurPos;
			}
		}

		/// <summary>
		/// System.Xml.Schema.BitSet AllElementsSet
		/// </summary>
		protected RSystem.RXml.RSchema.RBitSet r_AllElementsSet;
		public virtual RSystem.RXml.RSchema.RBitSet RAllElementsSet
		{
			get
			{
				if(r_AllElementsSet == null)
				{
					r_AllElementsSet = new(this, "AllElementsSet");
					r_AllElementsSet.SetBelong(this.instance);
				}
				return r_AllElementsSet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Xml.Schema.RangePositionInfo] RunningPositions
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RXml.RSchema.RRangePositionInfo> r_RunningPositions;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RXml.RSchema.RRangePositionInfo> RunningPositions
		{
			get
			{
				if(r_RunningPositions == null)
				{
					r_RunningPositions = new(this, "RunningPositions");
					r_RunningPositions.SetBelong(this.instance);
				}
				return r_RunningPositions;
			}
		}

		/// <summary>
		/// System.Boolean TooComplex
		/// </summary>
		protected RField r_TooComplex;
		public virtual RField RTooComplex
		{
			get
			{
				if(r_TooComplex == null)
				{
					r_TooComplex = new(this, "TooComplex");
					r_TooComplex.SetBelong(this.instance);
				}
				return r_TooComplex;
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


        public RValidationState() : base("System.Xml.Schema.ValidationState")
        {
        }

        public RValidationState(System.Object instance) : base("System.Xml.Schema.ValidationState")
		{
            SetInstance(instance);
		}

        public RValidationState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValidationState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
