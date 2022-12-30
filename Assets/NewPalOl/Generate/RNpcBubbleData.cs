using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NpcBubbleData
	/// </summary>
    public partial class RNpcBubbleData : RMember //
    {

		/// <summary>
		/// System.String idNpc
		/// </summary>
		protected RField r_idNpc;
		public virtual RField RidNpc
		{
			get
			{
				if(r_idNpc == null)
				{
					r_idNpc = new(this, "idNpc");
					r_idNpc.SetBelong(this.instance);
				}
				return r_idNpc;
			}
		}

		/// <summary>
		/// System.Single interval
		/// </summary>
		protected RField r_interval;
		public virtual RField Rinterval
		{
			get
			{
				if(r_interval == null)
				{
					r_interval = new(this, "interval");
					r_interval.SetBelong(this.instance);
				}
				return r_interval;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleContent] bubbleList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleContent> r_bubbleList;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleContent> RbubbleList
		{
			get
			{
				if(r_bubbleList == null)
				{
					r_bubbleList = new(this, "bubbleList");
					r_bubbleList.SetBelong(this.instance);
				}
				return r_bubbleList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleContent] randomList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleContent> r_randomList;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleContent> RrandomList
		{
			get
			{
				if(r_randomList == null)
				{
					r_randomList = new(this, "randomList");
					r_randomList.SetBelong(this.instance);
				}
				return r_randomList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleContent] serialList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleContent> r_serialList;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleContent> RserialList
		{
			get
			{
				if(r_serialList == null)
				{
					r_serialList = new(this, "serialList");
					r_serialList.SetBelong(this.instance);
				}
				return r_serialList;
			}
		}

		/// <summary>
		/// BubbleContent GetBubble(Int32)
		/// </summary>
		protected RMethod r_RGetBubble_Int32;
		public virtual RMethod RGetBubble_Int32
		{
			get
			{
				if(r_RGetBubble_Int32 == null)
				{
					r_RGetBubble_Int32 = new(this, "GetBubble", 0, typeof(System.Int32));
					r_RGetBubble_Int32.SetBelong(this.instance);
				}
				return r_RGetBubble_Int32;
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


        public RNpcBubbleData() : base("NpcBubbleData")
        {
        }

        public RNpcBubbleData(System.Object instance) : base("NpcBubbleData")
		{
            SetInstance(instance);
		}

        public RNpcBubbleData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNpcBubbleData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual BubbleContent GetBubble(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetBubble_Int32.Invoke(___genericsType, ___parameters);

            return (BubbleContent)___result;
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
