using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IValidationEventHandling
	/// </summary>
    public partial class RIValidationEventHandling : RMember //
    {

		/// <summary>
		/// System.Object EventHandler
		/// </summary>
		protected RSystem.RObject r_EventHandler;
		public virtual RSystem.RObject REventHandler
		{
			get
			{
				if(r_EventHandler == null)
				{
					r_EventHandler = new(this, "EventHandler", -1);
					r_EventHandler.SetBelong(this.instance);
				}
				return r_EventHandler;
			}
		}

		/// <summary>
		/// Void SendEvent(System.Exception, System.Xml.Schema.XmlSeverityType)
		/// </summary>
		protected RMethod r_RSendEvent_Exception_XmlSeverityType;
		public virtual RMethod RSendEvent_Exception_XmlSeverityType
		{
			get
			{
				if(r_RSendEvent_Exception_XmlSeverityType == null)
				{
					r_RSendEvent_Exception_XmlSeverityType = new(this, "SendEvent", 0, typeof(System.Exception), typeof(System.Xml.Schema.XmlSeverityType));
					r_RSendEvent_Exception_XmlSeverityType.SetBelong(this.instance);
				}
				return r_RSendEvent_Exception_XmlSeverityType;
			}
		}


        public RIValidationEventHandling() : base("System.Xml.IValidationEventHandling")
        {
        }

        public RIValidationEventHandling(System.Object instance) : base("System.Xml.IValidationEventHandling")
		{
            SetInstance(instance);
		}

        public RIValidationEventHandling(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIValidationEventHandling(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SendEvent(System.Exception  @exception, System.Xml.Schema.XmlSeverityType  @severity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @severity};
            var ___result = RSendEvent_Exception_XmlSeverityType.Invoke(___genericsType, ___parameters);

            
        }


    }
}
