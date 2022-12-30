using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BubbleContent
	/// </summary>
    public partial class RBubbleContent : RMember //
    {

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Single fireTime
		/// </summary>
		protected RField r_fireTime;
		public virtual RField RfireTime
		{
			get
			{
				if(r_fireTime == null)
				{
					r_fireTime = new(this, "fireTime");
					r_fireTime.SetBelong(this.instance);
				}
				return r_fireTime;
			}
		}

		/// <summary>
		/// System.Single duration
		/// </summary>
		protected RField r_duration;
		public virtual RField Rduration
		{
			get
			{
				if(r_duration == null)
				{
					r_duration = new(this, "duration");
					r_duration.SetBelong(this.instance);
				}
				return r_duration;
			}
		}

		/// <summary>
		/// System.String content
		/// </summary>
		protected RField r_content;
		public virtual RField Rcontent
		{
			get
			{
				if(r_content == null)
				{
					r_content = new(this, "content");
					r_content.SetBelong(this.instance);
				}
				return r_content;
			}
		}

		/// <summary>
		/// System.String idNpcTarget
		/// </summary>
		protected RField r_idNpcTarget;
		public virtual RField RidNpcTarget
		{
			get
			{
				if(r_idNpcTarget == null)
				{
					r_idNpcTarget = new(this, "idNpcTarget");
					r_idNpcTarget.SetBelong(this.instance);
				}
				return r_idNpcTarget;
			}
		}

		/// <summary>
		/// System.Int32 targetIndex
		/// </summary>
		protected RField r_targetIndex;
		public virtual RField RtargetIndex
		{
			get
			{
				if(r_targetIndex == null)
				{
					r_targetIndex = new(this, "targetIndex");
					r_targetIndex.SetBelong(this.instance);
				}
				return r_targetIndex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleContent] mBubbleList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleContent> r_mBubbleList;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleContent> RmBubbleList
		{
			get
			{
				if(r_mBubbleList == null)
				{
					r_mBubbleList = new(this, "mBubbleList");
					r_mBubbleList.SetBelong(this.instance);
				}
				return r_mBubbleList;
			}
		}

		/// <summary>
		/// Void SetBubbleContent(Int32, System.String)
		/// </summary>
		protected RMethod r_RSetBubbleContent_Int32_String;
		public virtual RMethod RSetBubbleContent_Int32_String
		{
			get
			{
				if(r_RSetBubbleContent_Int32_String == null)
				{
					r_RSetBubbleContent_Int32_String = new(this, "SetBubbleContent", 0, typeof(System.Int32), typeof(System.String));
					r_RSetBubbleContent_Int32_String.SetBelong(this.instance);
				}
				return r_RSetBubbleContent_Int32_String;
			}
		}

		/// <summary>
		/// Void SetSeriBubbleContent(Int32, System.String)
		/// </summary>
		protected RMethod r_RSetSeriBubbleContent_Int32_String;
		public virtual RMethod RSetSeriBubbleContent_Int32_String
		{
			get
			{
				if(r_RSetSeriBubbleContent_Int32_String == null)
				{
					r_RSetSeriBubbleContent_Int32_String = new(this, "SetSeriBubbleContent", 0, typeof(System.Int32), typeof(System.String));
					r_RSetSeriBubbleContent_Int32_String.SetBelong(this.instance);
				}
				return r_RSetSeriBubbleContent_Int32_String;
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


        public RBubbleContent() : base("BubbleContent")
        {
        }

        public RBubbleContent(System.Object instance) : base("BubbleContent")
		{
            SetInstance(instance);
		}

        public RBubbleContent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBubbleContent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetBubbleContent(System.Int32  @index, System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @str};
            var ___result = RSetBubbleContent_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSeriBubbleContent(System.Int32  @index, System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @str};
            var ___result = RSetSeriBubbleContent_Int32_String.Invoke(___genericsType, ___parameters);

            
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
