using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{public partial class RSocket
{
	
	/// <summary>
	/// System.Net.Sockets.Socket+CachedEventArgs
	/// </summary>
    public partial class RCachedEventArgs : RMember //
    {

		/// <summary>
		/// System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1[System.Net.Sockets.Socket] TaskAccept
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RTaskSocketAsyncEventArgs<RSystem.RNet.RSockets.RSocket> r_TaskAccept;
		public virtual RSystem.RNet.RSockets.RSocket.RTaskSocketAsyncEventArgs<RSystem.RNet.RSockets.RSocket> RTaskAccept
		{
			get
			{
				if(r_TaskAccept == null)
				{
					r_TaskAccept = new(this, "TaskAccept");
					r_TaskAccept.SetBelong(this.instance);
				}
				return r_TaskAccept;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs TaskReceive
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs r_TaskReceive;
		public virtual RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs RTaskReceive
		{
			get
			{
				if(r_TaskReceive == null)
				{
					r_TaskReceive = new(this, "TaskReceive");
					r_TaskReceive.SetBelong(this.instance);
				}
				return r_TaskReceive;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs TaskSend
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs r_TaskSend;
		public virtual RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs RTaskSend
		{
			get
			{
				if(r_TaskSend == null)
				{
					r_TaskSend = new(this, "TaskSend");
					r_TaskSend.SetBelong(this.instance);
				}
				return r_TaskSend;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs ValueTaskReceive
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs r_ValueTaskReceive;
		public virtual RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs RValueTaskReceive
		{
			get
			{
				if(r_ValueTaskReceive == null)
				{
					r_ValueTaskReceive = new(this, "ValueTaskReceive");
					r_ValueTaskReceive.SetBelong(this.instance);
				}
				return r_ValueTaskReceive;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs ValueTaskSend
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs r_ValueTaskSend;
		public virtual RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs RValueTaskSend
		{
			get
			{
				if(r_ValueTaskSend == null)
				{
					r_ValueTaskSend = new(this, "ValueTaskSend");
					r_ValueTaskSend.SetBelong(this.instance);
				}
				return r_ValueTaskSend;
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


        public RCachedEventArgs() : base("System.Net.Sockets.Socket+CachedEventArgs")
        {
        }

        public RCachedEventArgs(System.Object instance) : base("System.Net.Sockets.Socket+CachedEventArgs")
		{
            SetInstance(instance);
		}

        public RCachedEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCachedEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}