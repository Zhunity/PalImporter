using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlValidatingReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlValidatingReaderImpl+ValidationEventHandling
	/// </summary>
    public partial class RValidationEventHandling : RMember //
    {

		/// <summary>
		/// System.Xml.XmlValidatingReaderImpl reader
		/// </summary>
		protected RSystem.RXml.RXmlValidatingReaderImpl r_reader;
		public virtual RSystem.RXml.RXmlValidatingReaderImpl Rreader
		{
			get
			{
				if(r_reader == null)
				{
					r_reader = new(this, "reader");
					r_reader.SetBelong(this.instance);
				}
				return r_reader;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler eventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_eventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler ReventHandler
		{
			get
			{
				if(r_eventHandler == null)
				{
					r_eventHandler = new(this, "eventHandler");
					r_eventHandler.SetBelong(this.instance);
				}
				return r_eventHandler;
			}
		}

		/// <summary>
		/// System.Object System.Xml.IValidationEventHandling.EventHandler
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler;
		public virtual RSystem.RObject RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler
		{
			get
			{
				if(r_RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler == null)
				{
					r_RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler = new(this, "System.Xml.IValidationEventHandling.EventHandler", -1);
					r_RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IValidationEventHandling__1__get_EventHandler;
			}
		}

		/// <summary>
		/// Void System.Xml.IValidationEventHandling.SendEvent(System.Exception, System.Xml.Schema.XmlSeverityType)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType;
		public virtual RMethod RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType
		{
			get
			{
				if(r_RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType == null)
				{
					r_RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType = new(this, "System.Xml.IValidationEventHandling.SendEvent", 0, typeof(System.Exception), typeof(System.Xml.Schema.XmlSeverityType));
					r_RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType;
			}
		}

		/// <summary>
		/// Void AddHandler(System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RAddHandler_ValidationEventHandler;
		public virtual RMethod RAddHandler_ValidationEventHandler
		{
			get
			{
				if(r_RAddHandler_ValidationEventHandler == null)
				{
					r_RAddHandler_ValidationEventHandler = new(this, "AddHandler", 0, typeof(System.Xml.Schema.ValidationEventHandler));
					r_RAddHandler_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RAddHandler_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void RemoveHandler(System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RRemoveHandler_ValidationEventHandler;
		public virtual RMethod RRemoveHandler_ValidationEventHandler
		{
			get
			{
				if(r_RRemoveHandler_ValidationEventHandler == null)
				{
					r_RRemoveHandler_ValidationEventHandler = new(this, "RemoveHandler", 0, typeof(System.Xml.Schema.ValidationEventHandler));
					r_RRemoveHandler_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RRemoveHandler_ValidationEventHandler;
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


        public RValidationEventHandling() : base("System.Xml.XmlValidatingReaderImpl+ValidationEventHandling")
        {
        }

        public RValidationEventHandling(System.Object instance) : base("System.Xml.XmlValidatingReaderImpl+ValidationEventHandling")
		{
            SetInstance(instance);
		}

        public RValidationEventHandling(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValidationEventHandling(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Xml__1__IValidationEventHandling__1__SendEvent(System.Exception  @exception, System.Xml.Schema.XmlSeverityType  @severity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @severity};
            var ___result = RSystem__1__Xml__1__IValidationEventHandling__1__SendEvent_Exception_XmlSeverityType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddHandler(System.Xml.Schema.ValidationEventHandler  @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler};
            var ___result = RAddHandler_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveHandler(System.Xml.Schema.ValidationEventHandler  @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler};
            var ___result = RRemoveHandler_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            
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