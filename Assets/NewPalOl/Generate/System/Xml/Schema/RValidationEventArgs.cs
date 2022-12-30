using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.ValidationEventArgs
	/// </summary>
    public partial class RValidationEventArgs : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaException ex
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaException r_ex;
		public virtual RSystem.RXml.RSchema.RXmlSchemaException Rex
		{
			get
			{
				if(r_ex == null)
				{
					r_ex = new(this, "ex");
					r_ex.SetBelong(this.instance);
				}
				return r_ex;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSeverityType severity
		/// </summary>
		protected RField r_severity;
		public virtual RField Rseverity
		{
			get
			{
				if(r_severity == null)
				{
					r_severity = new(this, "severity");
					r_severity.SetBelong(this.instance);
				}
				return r_severity;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSeverityType Severity
		/// </summary>
		protected RProperty r_Severity;
		public virtual RProperty RSeverity
		{
			get
			{
				if(r_Severity == null)
				{
					r_Severity = new(this, "Severity", -1);
					r_Severity.SetBelong(this.instance);
				}
				return r_Severity;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaException Exception
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaException r_Exception;
		public virtual RSystem.RXml.RSchema.RXmlSchemaException RException
		{
			get
			{
				if(r_Exception == null)
				{
					r_Exception = new(this, "Exception", -1);
					r_Exception.SetBelong(this.instance);
				}
				return r_Exception;
			}
		}

		/// <summary>
		/// System.String Message
		/// </summary>
		protected RProperty r_Message;
		public virtual RProperty RMessage
		{
			get
			{
				if(r_Message == null)
				{
					r_Message = new(this, "Message", -1);
					r_Message.SetBelong(this.instance);
				}
				return r_Message;
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


        public RValidationEventArgs() : base("System.Xml.Schema.ValidationEventArgs")
        {
        }

        public RValidationEventArgs(System.Object instance) : base("System.Xml.Schema.ValidationEventArgs")
		{
            SetInstance(instance);
		}

        public RValidationEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValidationEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
