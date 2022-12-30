using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// EventMgr
	/// </summary>
    public partial class REventMgr : RMember //
    {

		/// <summary>
		/// EventMgr #a
		/// </summary>
		protected static REventMgr r___0__a;
		public static REventMgr R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(EventMgr), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Object,System.Collections.Generic.Dictionary`2[System.Type,System.Collections.Generic.List`1[EventMgr+ICallback]]] listeners
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RObject, RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<REventMgr.RICallback>>> r_listeners;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RObject, RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<REventMgr.RICallback>>> Rlisteners
		{
			get
			{
				if(r_listeners == null)
				{
					r_listeners = new(this, "listeners");
					r_listeners.SetBelong(this.instance);
				}
				return r_listeners;
			}
		}

		/// <summary>
		/// System.Int32 nFire
		/// </summary>
		protected RField r_nFire;
		public virtual RField RnFire
		{
			get
			{
				if(r_nFire == null)
				{
					r_nFire = new(this, "nFire");
					r_nFire.SetBelong(this.instance);
				}
				return r_nFire;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[EventMgr+CallbackData] pendingDeletes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<REventMgr.RCallbackData> r_pendingDeletes;
		public virtual RSystem.RCollections.RGeneric.RList<REventMgr.RCallbackData> RpendingDeletes
		{
			get
			{
				if(r_pendingDeletes == null)
				{
					r_pendingDeletes = new(this, "pendingDeletes");
					r_pendingDeletes.SetBelong(this.instance);
				}
				return r_pendingDeletes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[EventMgr+CallbackData] pendingListens
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<REventMgr.RCallbackData> r_pendingListens;
		public virtual RSystem.RCollections.RGeneric.RList<REventMgr.RCallbackData> RpendingListens
		{
			get
			{
				if(r_pendingListens == null)
				{
					r_pendingListens = new(this, "pendingListens");
					r_pendingListens.SetBelong(this.instance);
				}
				return r_pendingListens;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Object,System.Collections.Generic.Dictionary`2[System.Type,System.Collections.Generic.List`1[EventMgr+ICallback]]] Listeners
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RObject, RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<REventMgr.RICallback>>> r_Listeners;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RObject, RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<REventMgr.RICallback>>> RListeners
		{
			get
			{
				if(r_Listeners == null)
				{
					r_Listeners = new(this, "Listeners", -1);
					r_Listeners.SetBelong(this.instance);
				}
				return r_Listeners;
			}
		}

		/// <summary>
		/// EventMgr Inst()
		/// </summary>
		protected static RMethod r_RInst;
		public static RMethod RInst
		{
			get
			{
				if(r_RInst == null)
				{
					r_RInst = new(typeof(EventMgr), "Inst", 0);
					r_RInst.SetBelong(null);
				}
				return r_RInst;
			}
		}

		/// <summary>
		/// Void AddListener[T](GenericDelegate`1)
		/// </summary>
		protected RMethod r_RAddListener_GT_GenericDelegate_d_T_p_;
		public virtual RMethod RAddListener_GT_GenericDelegate_d_T_p_
		{
			get
			{
				if(r_RAddListener_GT_GenericDelegate_d_T_p_ == null)
				{
					r_RAddListener_GT_GenericDelegate_d_T_p_ = new(this, "AddListener", 1,  ReleactionUtils.GetType("EventMgr+GenericDelegate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddListener_GT_GenericDelegate_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddListener_GT_GenericDelegate_d_T_p_;
			}
		}

		/// <summary>
		/// Void AddListener[T](System.Object, GenericDelegate`1)
		/// </summary>
		protected RMethod r_RAddListener_GT_Object_GenericDelegate_d_T_p_;
		public virtual RMethod RAddListener_GT_Object_GenericDelegate_d_T_p_
		{
			get
			{
				if(r_RAddListener_GT_Object_GenericDelegate_d_T_p_ == null)
				{
					r_RAddListener_GT_Object_GenericDelegate_d_T_p_ = new(this, "AddListener", 1, typeof(System.Object),  ReleactionUtils.GetType("EventMgr+GenericDelegate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAddListener_GT_Object_GenericDelegate_d_T_p_.SetBelong(this.instance);
				}
				return r_RAddListener_GT_Object_GenericDelegate_d_T_p_;
			}
		}

		/// <summary>
		/// Void DetectLeakedObjects()
		/// </summary>
		protected RMethod r_RDetectLeakedObjects;
		public virtual RMethod RDetectLeakedObjects
		{
			get
			{
				if(r_RDetectLeakedObjects == null)
				{
					r_RDetectLeakedObjects = new(this, "DetectLeakedObjects", 0);
					r_RDetectLeakedObjects.SetBelong(this.instance);
				}
				return r_RDetectLeakedObjects;
			}
		}

		/// <summary>
		/// Void DumpEventListeners()
		/// </summary>
		protected RMethod r_RDumpEventListeners;
		public virtual RMethod RDumpEventListeners
		{
			get
			{
				if(r_RDumpEventListeners == null)
				{
					r_RDumpEventListeners = new(this, "DumpEventListeners", 0);
					r_RDumpEventListeners.SetBelong(this.instance);
				}
				return r_RDumpEventListeners;
			}
		}

		/// <summary>
		/// Void Fire(System.Object, EventMessage)
		/// </summary>
		protected RMethod r_RFire_Object_EventMessage;
		public virtual RMethod RFire_Object_EventMessage
		{
			get
			{
				if(r_RFire_Object_EventMessage == null)
				{
					r_RFire_Object_EventMessage = new(this, "Fire", 0, typeof(System.Object), typeof(EventMessage));
					r_RFire_Object_EventMessage.SetBelong(this.instance);
				}
				return r_RFire_Object_EventMessage;
			}
		}

		/// <summary>
		/// Void FireEventWithFilter(System.Object, System.Object, EventMessage)
		/// </summary>
		protected RMethod r_RFireEventWithFilter_Object_Object_EventMessage;
		public virtual RMethod RFireEventWithFilter_Object_Object_EventMessage
		{
			get
			{
				if(r_RFireEventWithFilter_Object_Object_EventMessage == null)
				{
					r_RFireEventWithFilter_Object_Object_EventMessage = new(this, "FireEventWithFilter", 0, typeof(System.Object), typeof(System.Object), typeof(EventMessage));
					r_RFireEventWithFilter_Object_Object_EventMessage.SetBelong(this.instance);
				}
				return r_RFireEventWithFilter_Object_Object_EventMessage;
			}
		}

		/// <summary>
		/// Void ProcessPendingDeletes()
		/// </summary>
		protected RMethod r_RProcessPendingDeletes;
		public virtual RMethod RProcessPendingDeletes
		{
			get
			{
				if(r_RProcessPendingDeletes == null)
				{
					r_RProcessPendingDeletes = new(this, "ProcessPendingDeletes", 0);
					r_RProcessPendingDeletes.SetBelong(this.instance);
				}
				return r_RProcessPendingDeletes;
			}
		}

		/// <summary>
		/// Void ProcessPendingListens()
		/// </summary>
		protected RMethod r_RProcessPendingListens;
		public virtual RMethod RProcessPendingListens
		{
			get
			{
				if(r_RProcessPendingListens == null)
				{
					r_RProcessPendingListens = new(this, "ProcessPendingListens", 0);
					r_RProcessPendingListens.SetBelong(this.instance);
				}
				return r_RProcessPendingListens;
			}
		}

		/// <summary>
		/// Void RemoveListener[T](GenericDelegate`1)
		/// </summary>
		protected RMethod r_RRemoveListener_GT_GenericDelegate_d_T_p_;
		public virtual RMethod RRemoveListener_GT_GenericDelegate_d_T_p_
		{
			get
			{
				if(r_RRemoveListener_GT_GenericDelegate_d_T_p_ == null)
				{
					r_RRemoveListener_GT_GenericDelegate_d_T_p_ = new(this, "RemoveListener", 1,  ReleactionUtils.GetType("EventMgr+GenericDelegate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveListener_GT_GenericDelegate_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveListener_GT_GenericDelegate_d_T_p_;
			}
		}

		/// <summary>
		/// Void RemoveListener[T](System.Object, GenericDelegate`1)
		/// </summary>
		protected RMethod r_RRemoveListener_GT_Object_GenericDelegate_d_T_p_;
		public virtual RMethod RRemoveListener_GT_Object_GenericDelegate_d_T_p_
		{
			get
			{
				if(r_RRemoveListener_GT_Object_GenericDelegate_d_T_p_ == null)
				{
					r_RRemoveListener_GT_Object_GenericDelegate_d_T_p_ = new(this, "RemoveListener", 1, typeof(System.Object),  ReleactionUtils.GetType("EventMgr+GenericDelegate`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RRemoveListener_GT_Object_GenericDelegate_d_T_p_.SetBelong(this.instance);
				}
				return r_RRemoveListener_GT_Object_GenericDelegate_d_T_p_;
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


        public REventMgr() : base("EventMgr")
        {
        }

        public REventMgr(System.Object instance) : base("EventMgr")
		{
            SetInstance(instance);
		}

        public REventMgr(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventMgr(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static EventMgr Inst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInst.Invoke(___genericsType, ___parameters);

            return (EventMgr)___result;
        }




        public virtual void DetectLeakedObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetectLeakedObjects.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DumpEventListeners()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDumpEventListeners.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Fire(System.Object  @sender, EventMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @msg};
            var ___result = RFire_Object_EventMessage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FireEventWithFilter(System.Object  @filter, System.Object  @sender, EventMessage  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @sender, @msg};
            var ___result = RFireEventWithFilter_Object_Object_EventMessage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPendingDeletes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessPendingDeletes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPendingListens()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessPendingListens.Invoke(___genericsType, ___parameters);

            
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
