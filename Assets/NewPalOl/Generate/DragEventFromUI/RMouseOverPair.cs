using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RDragEventFromUI
{
	
	/// <summary>
	/// DragEventFromUI+MouseOverPair
	/// </summary>
    public partial class RMouseOverPair : RMember //
    {

		/// <summary>
		/// UnityEngine.GameObject target
		/// </summary>
		protected RUnityEngine.RGameObject r_target;
		public virtual RUnityEngine.RGameObject Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target");
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// UnityEngine.Camera camera
		/// </summary>
		protected RUnityEngine.RCamera r_camera;
		public virtual RUnityEngine.RCamera Rcamera
		{
			get
			{
				if(r_camera == null)
				{
					r_camera = new(this, "camera");
					r_camera.SetBelong(this.instance);
				}
				return r_camera;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_RSendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_RSendMessage_String == null)
				{
					r_RSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_RSendMessage_String.SetBelong(this.instance);
				}
				return r_RSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_Object_SendMessageOptions == null)
				{
					r_RSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Boolean ComparePair(MouseOverPair, MouseOverPair)
		/// </summary>
		protected static RMethod r_RComparePair_MouseOverPair_MouseOverPair;
		public static RMethod RComparePair_MouseOverPair_MouseOverPair
		{
			get
			{
				if(r_RComparePair_MouseOverPair_MouseOverPair == null)
				{
					r_RComparePair_MouseOverPair_MouseOverPair = new( ReleactionUtils.GetType("DragEventFromUI+MouseOverPair"), "ComparePair", 0,  ReleactionUtils.GetType("DragEventFromUI+MouseOverPair"),  ReleactionUtils.GetType("DragEventFromUI+MouseOverPair"));
					r_RComparePair_MouseOverPair_MouseOverPair.SetBelong(null);
				}
				return r_RComparePair_MouseOverPair_MouseOverPair;
			}
		}

		/// <summary>
		/// Boolean op_Implicit(MouseOverPair)
		/// </summary>
		protected static RMethod r_Rop_Implicit_MouseOverPair;
		public static RMethod Rop_Implicit_MouseOverPair
		{
			get
			{
				if(r_Rop_Implicit_MouseOverPair == null)
				{
					r_Rop_Implicit_MouseOverPair = new( ReleactionUtils.GetType("DragEventFromUI+MouseOverPair"), "op_Implicit", 0,  ReleactionUtils.GetType("DragEventFromUI+MouseOverPair"));
					r_Rop_Implicit_MouseOverPair.SetBelong(null);
				}
				return r_Rop_Implicit_MouseOverPair;
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


        public RMouseOverPair() : base("DragEventFromUI+MouseOverPair")
        {
        }

        public RMouseOverPair(System.Object instance) : base("DragEventFromUI+MouseOverPair")
		{
            SetInstance(instance);
		}

        public RMouseOverPair(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMouseOverPair(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SendMessage(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}