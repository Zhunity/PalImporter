using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.ContentValidator
	/// </summary>
    public partial class RContentValidator : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentType contentType
		/// </summary>
		protected RField r_contentType;
		public virtual RField RcontentType
		{
			get
			{
				if(r_contentType == null)
				{
					r_contentType = new(this, "contentType");
					r_contentType.SetBelong(this.instance);
				}
				return r_contentType;
			}
		}

		/// <summary>
		/// System.Boolean isOpen
		/// </summary>
		protected RField r_isOpen;
		public virtual RField RisOpen
		{
			get
			{
				if(r_isOpen == null)
				{
					r_isOpen = new(this, "isOpen");
					r_isOpen.SetBelong(this.instance);
				}
				return r_isOpen;
			}
		}

		/// <summary>
		/// System.Boolean isEmptiable
		/// </summary>
		protected RField r_isEmptiable;
		public virtual RField RisEmptiable
		{
			get
			{
				if(r_isEmptiable == null)
				{
					r_isEmptiable = new(this, "isEmptiable");
					r_isEmptiable.SetBelong(this.instance);
				}
				return r_isEmptiable;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator Empty
		/// </summary>
		protected static RSystem.RXml.RSchema.RContentValidator r_Empty;
		public static RSystem.RXml.RSchema.RContentValidator REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator TextOnly
		/// </summary>
		protected static RSystem.RXml.RSchema.RContentValidator r_TextOnly;
		public static RSystem.RXml.RSchema.RContentValidator RTextOnly
		{
			get
			{
				if(r_TextOnly == null)
				{
					r_TextOnly = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "TextOnly");
					r_TextOnly.SetBelong(null);
				}
				return r_TextOnly;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator Mixed
		/// </summary>
		protected static RSystem.RXml.RSchema.RContentValidator r_Mixed;
		public static RSystem.RXml.RSchema.RContentValidator RMixed
		{
			get
			{
				if(r_Mixed == null)
				{
					r_Mixed = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "Mixed");
					r_Mixed.SetBelong(null);
				}
				return r_Mixed;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ContentValidator Any
		/// </summary>
		protected static RSystem.RXml.RSchema.RContentValidator r_Any;
		public static RSystem.RXml.RSchema.RContentValidator RAny
		{
			get
			{
				if(r_Any == null)
				{
					r_Any = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "Any");
					r_Any.SetBelong(null);
				}
				return r_Any;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentType ContentType
		/// </summary>
		protected RProperty r_ContentType;
		public virtual RProperty RContentType
		{
			get
			{
				if(r_ContentType == null)
				{
					r_ContentType = new(this, "ContentType", -1);
					r_ContentType.SetBelong(this.instance);
				}
				return r_ContentType;
			}
		}

		/// <summary>
		/// Boolean PreserveWhitespace
		/// </summary>
		protected RProperty r_PreserveWhitespace;
		public virtual RProperty RPreserveWhitespace
		{
			get
			{
				if(r_PreserveWhitespace == null)
				{
					r_PreserveWhitespace = new(this, "PreserveWhitespace", -1);
					r_PreserveWhitespace.SetBelong(this.instance);
				}
				return r_PreserveWhitespace;
			}
		}

		/// <summary>
		/// Boolean IsEmptiable
		/// </summary>
		protected RProperty r_IsEmptiable;
		public virtual RProperty RIsEmptiable
		{
			get
			{
				if(r_IsEmptiable == null)
				{
					r_IsEmptiable = new(this, "IsEmptiable", -1);
					r_IsEmptiable.SetBelong(this.instance);
				}
				return r_IsEmptiable;
			}
		}

		/// <summary>
		/// Boolean IsOpen
		/// </summary>
		protected RProperty r_IsOpen;
		public virtual RProperty RIsOpen
		{
			get
			{
				if(r_IsOpen == null)
				{
					r_IsOpen = new(this, "IsOpen", -1);
					r_IsOpen.SetBelong(this.instance);
				}
				return r_IsOpen;
			}
		}

		/// <summary>
		/// Void InitValidation(System.Xml.Schema.ValidationState)
		/// </summary>
		protected RMethod r_RInitValidation_ValidationState;
		public virtual RMethod RInitValidation_ValidationState
		{
			get
			{
				if(r_RInitValidation_ValidationState == null)
				{
					r_RInitValidation_ValidationState = new(this, "InitValidation", 0,  ReleactionUtils.GetType("System.Xml.Schema.ValidationState"));
					r_RInitValidation_ValidationState.SetBelong(this.instance);
				}
				return r_RInitValidation_ValidationState;
			}
		}

		/// <summary>
		/// System.Object ValidateElement(System.Xml.XmlQualifiedName, System.Xml.Schema.ValidationState, Int32 ByRef)
		/// </summary>
		protected RMethod r_RValidateElement_XmlQualifiedName_ValidationState_Out_Int32;
		public virtual RMethod RValidateElement_XmlQualifiedName_ValidationState_Out_Int32
		{
			get
			{
				if(r_RValidateElement_XmlQualifiedName_ValidationState_Out_Int32 == null)
				{
					r_RValidateElement_XmlQualifiedName_ValidationState_Out_Int32 = new(this, "ValidateElement", 0, typeof(System.Xml.XmlQualifiedName),  ReleactionUtils.GetType("System.Xml.Schema.ValidationState"), typeof(System.Int32).MakeByRefType());
					r_RValidateElement_XmlQualifiedName_ValidationState_Out_Int32.SetBelong(this.instance);
				}
				return r_RValidateElement_XmlQualifiedName_ValidationState_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean CompleteValidation(System.Xml.Schema.ValidationState)
		/// </summary>
		protected RMethod r_RCompleteValidation_ValidationState;
		public virtual RMethod RCompleteValidation_ValidationState
		{
			get
			{
				if(r_RCompleteValidation_ValidationState == null)
				{
					r_RCompleteValidation_ValidationState = new(this, "CompleteValidation", 0,  ReleactionUtils.GetType("System.Xml.Schema.ValidationState"));
					r_RCompleteValidation_ValidationState.SetBelong(this.instance);
				}
				return r_RCompleteValidation_ValidationState;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState, Boolean)
		/// </summary>
		protected RMethod r_RExpectedElements_ValidationState_Boolean;
		public virtual RMethod RExpectedElements_ValidationState_Boolean
		{
			get
			{
				if(r_RExpectedElements_ValidationState_Boolean == null)
				{
					r_RExpectedElements_ValidationState_Boolean = new(this, "ExpectedElements", 0,  ReleactionUtils.GetType("System.Xml.Schema.ValidationState"), typeof(System.Boolean));
					r_RExpectedElements_ValidationState_Boolean.SetBelong(this.instance);
				}
				return r_RExpectedElements_ValidationState_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState, Boolean, System.Xml.Schema.XmlSchemaSet)
		/// </summary>
		protected RMethod r_RExpectedParticles_ValidationState_Boolean_XmlSchemaSet;
		public virtual RMethod RExpectedParticles_ValidationState_Boolean_XmlSchemaSet
		{
			get
			{
				if(r_RExpectedParticles_ValidationState_Boolean_XmlSchemaSet == null)
				{
					r_RExpectedParticles_ValidationState_Boolean_XmlSchemaSet = new(this, "ExpectedParticles", 0,  ReleactionUtils.GetType("System.Xml.Schema.ValidationState"), typeof(System.Boolean), typeof(System.Xml.Schema.XmlSchemaSet));
					r_RExpectedParticles_ValidationState_Boolean_XmlSchemaSet.SetBelong(this.instance);
				}
				return r_RExpectedParticles_ValidationState_Boolean_XmlSchemaSet;
			}
		}

		/// <summary>
		/// Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle, System.Xml.Schema.XmlSchemaSet, System.Collections.ArrayList)
		/// </summary>
		protected static RMethod r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList;
		public static RMethod RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList
		{
			get
			{
				if(r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList == null)
				{
					r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "AddParticleToExpected", 0, typeof(System.Xml.Schema.XmlSchemaParticle), typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Collections.ArrayList));
					r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList.SetBelong(null);
				}
				return r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList;
			}
		}

		/// <summary>
		/// Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle, System.Xml.Schema.XmlSchemaSet, System.Collections.ArrayList, Boolean)
		/// </summary>
		protected static RMethod r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean;
		public static RMethod RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean
		{
			get
			{
				if(r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean == null)
				{
					r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean = new( ReleactionUtils.GetType("System.Xml.Schema.ContentValidator"), "AddParticleToExpected", 0, typeof(System.Xml.Schema.XmlSchemaParticle), typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Collections.ArrayList), typeof(System.Boolean));
					r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean.SetBelong(null);
				}
				return r_RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean;
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


        public RContentValidator() : base("System.Xml.Schema.ContentValidator")
        {
        }

        public RContentValidator(System.Object instance) : base("System.Xml.Schema.ContentValidator")
		{
            SetInstance(instance);
		}

        public RContentValidator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RContentValidator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }






        public static void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle  @p, System.Xml.Schema.XmlSchemaSet  @schemaSet, System.Collections.ArrayList  @particles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p, @schemaSet, @particles};
            var ___result = RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle  @p, System.Xml.Schema.XmlSchemaSet  @schemaSet, System.Collections.ArrayList  @particles, System.Boolean  @global)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p, @schemaSet, @particles, @global};
            var ___result = RAddParticleToExpected_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean.Invoke(___genericsType, ___parameters);

            
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
