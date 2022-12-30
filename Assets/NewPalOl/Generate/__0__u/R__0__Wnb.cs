using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Wnb
	/// </summary>
    public partial class R__0__Wnb : RMember //
    {

		/// <summary>
		/// #u.#Wnb #a
		/// </summary>
		protected static R__0__u.R__0__Wnb r___0__a;
		public static R__0__u.R__0__Wnb R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Wnb"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 mouseUIPosition
		/// </summary>
		protected static RUnityEngine.RVector3 r_R__0__Unb;
		public static RUnityEngine.RVector3 R__0__Unb
		{
			get
			{
				if(r_R__0__Unb == null)
				{
					r_R__0__Unb = new( ReleactionUtils.GetType("#u.#Wnb"), "mouseUIPosition", -1);
					r_R__0__Unb.SetBelong(null);
				}
				return r_R__0__Unb;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 mouseUIPositionReverseY
		/// </summary>
		protected static RUnityEngine.RVector3 r_R__0__Vnb;
		public static RUnityEngine.RVector3 R__0__Vnb
		{
			get
			{
				if(r_R__0__Vnb == null)
				{
					r_R__0__Vnb = new( ReleactionUtils.GetType("#u.#Wnb"), "mouseUIPositionReverseY", -1);
					r_R__0__Vnb.SetBelong(null);
				}
				return r_R__0__Vnb;
			}
		}

		/// <summary>
		/// #u.#Wnb GetInst()
		/// </summary>
		protected static RMethod r_RGetInst;
		public static RMethod RGetInst
		{
			get
			{
				if(r_RGetInst == null)
				{
					r_RGetInst = new( ReleactionUtils.GetType("#u.#Wnb"), "GetInst", 0);
					r_RGetInst.SetBelong(null);
				}
				return r_RGetInst;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void #Rnb()
		/// </summary>
		protected RMethod r_R__0__Rnb;
		public virtual RMethod R__0__Rnb
		{
			get
			{
				if(r_R__0__Rnb == null)
				{
					r_R__0__Rnb = new(this, "#Rnb", 0);
					r_R__0__Rnb.SetBelong(this.instance);
				}
				return r_R__0__Rnb;
			}
		}

		/// <summary>
		/// Boolean #Snb()
		/// </summary>
		protected RMethod r_R__0__Snb;
		public virtual RMethod R__0__Snb
		{
			get
			{
				if(r_R__0__Snb == null)
				{
					r_R__0__Snb = new(this, "#Snb", 0);
					r_R__0__Snb.SetBelong(this.instance);
				}
				return r_R__0__Snb;
			}
		}

		/// <summary>
		/// Void #l2()
		/// </summary>
		protected RMethod r_R__0__l2;
		public virtual RMethod R__0__l2
		{
			get
			{
				if(r_R__0__l2 == null)
				{
					r_R__0__l2 = new(this, "#l2", 0);
					r_R__0__l2.SetBelong(this.instance);
				}
				return r_R__0__l2;
			}
		}

		/// <summary>
		/// Void #Tnb(UnityEngine.EventType, Int32)
		/// </summary>
		protected RMethod r_R__0__Tnb_EventType_Int32;
		public virtual RMethod R__0__Tnb_EventType_Int32
		{
			get
			{
				if(r_R__0__Tnb_EventType_Int32 == null)
				{
					r_R__0__Tnb_EventType_Int32 = new(this, "#Tnb", 0, typeof(UnityEngine.EventType), typeof(System.Int32));
					r_R__0__Tnb_EventType_Int32.SetBelong(this.instance);
				}
				return r_R__0__Tnb_EventType_Int32;
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


        public R__0__Wnb() : base("#u.#Wnb")
        {
        }

        public R__0__Wnb(System.Object instance) : base("#u.#Wnb")
		{
            SetInstance(instance);
		}

        public R__0__Wnb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Wnb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object GetInst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInst.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Rnb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Rnb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Snb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Snb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__l2()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__l2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tnb(UnityEngine.EventType  @type, System.Int32  @mouseButton)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @mouseButton};
            var ___result = R__0__Tnb_EventType_Int32.Invoke(___genericsType, ___parameters);

            
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
