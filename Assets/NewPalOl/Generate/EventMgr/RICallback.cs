using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class REventMgr
{
	
	/// <summary>
	/// EventMgr+ICallback
	/// </summary>
    public partial class RICallback : RMember //
    {

		/// <summary>
		/// System.Object ReferencedFunction
		/// </summary>
		protected RSystem.RObject r_ReferencedFunction;
		public virtual RSystem.RObject ReferencedFunction
		{
			get
			{
				if(r_ReferencedFunction == null)
				{
					r_ReferencedFunction = new(this, "ReferencedFunction", -1);
					r_ReferencedFunction.SetBelong(this.instance);
				}
				return r_ReferencedFunction;
			}
		}

		/// <summary>
		/// Void Fire(EventMessage)
		/// </summary>
		protected RMethod r_RFire_EventMessage;
		public virtual RMethod RFire_EventMessage
		{
			get
			{
				if(r_RFire_EventMessage == null)
				{
					r_RFire_EventMessage = new(this, "Fire", 0, typeof(EventMessage));
					r_RFire_EventMessage.SetBelong(this.instance);
				}
				return r_RFire_EventMessage;
			}
		}


        public RICallback() : base("EventMgr+ICallback")
        {
        }

        public RICallback(System.Object instance) : base("EventMgr+ICallback")
		{
            SetInstance(instance);
		}

        public RICallback(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICallback(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Fire(EventMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg};
            var ___result = RFire_EventMessage.Invoke(___genericsType, ___parameters);

            
        }


    }
}
}