using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.NodeLink
	/// </summary>
    public partial class RNodeLink : RMember //
    {

		/// <summary>
		/// UnityEngine.Transform fromT
		/// </summary>
		protected RUnityEngine.RTransform r_fromT;
		public virtual RUnityEngine.RTransform RfromT
		{
			get
			{
				if(r_fromT == null)
				{
					r_fromT = new(this, "fromT");
					r_fromT.SetBelong(this.instance);
				}
				return r_fromT;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 _fromVector
		/// </summary>
		protected RUnityEngine.RVector3 r__fromVector;
		public virtual RUnityEngine.RVector3 R_fromVector
		{
			get
			{
				if(r__fromVector == null)
				{
					r__fromVector = new(this, "_fromVector");
					r__fromVector.SetBelong(this.instance);
				}
				return r__fromVector;
			}
		}

		/// <summary>
		/// UnityEngine.Transform toT
		/// </summary>
		protected RUnityEngine.RTransform r_toT;
		public virtual RUnityEngine.RTransform RtoT
		{
			get
			{
				if(r_toT == null)
				{
					r_toT = new(this, "toT");
					r_toT.SetBelong(this.instance);
				}
				return r_toT;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 _toVector
		/// </summary>
		protected RUnityEngine.RVector3 r__toVector;
		public virtual RUnityEngine.RVector3 R_toVector
		{
			get
			{
				if(r__toVector == null)
				{
					r__toVector = new(this, "_toVector");
					r__toVector.SetBelong(this.instance);
				}
				return r__toVector;
			}
		}

		/// <summary>
		/// AstarClasses.LinkType linkType
		/// </summary>
		protected RField r_linkType;
		public virtual RField RlinkType
		{
			get
			{
				if(r_linkType == null)
				{
					r_linkType = new(this, "linkType");
					r_linkType.SetBelong(this.instance);
				}
				return r_linkType;
			}
		}

		/// <summary>
		/// System.Boolean oneWay
		/// </summary>
		protected RField r_oneWay;
		public virtual RField RoneWay
		{
			get
			{
				if(r_oneWay == null)
				{
					r_oneWay = new(this, "oneWay");
					r_oneWay.SetBelong(this.instance);
				}
				return r_oneWay;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 fromVector
		/// </summary>
		protected RUnityEngine.RVector3 r_fromVector;
		public virtual RUnityEngine.RVector3 RfromVector
		{
			get
			{
				if(r_fromVector == null)
				{
					r_fromVector = new(this, "fromVector", -1);
					r_fromVector.SetBelong(this.instance);
				}
				return r_fromVector;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 toVector
		/// </summary>
		protected RUnityEngine.RVector3 r_toVector;
		public virtual RUnityEngine.RVector3 RtoVector
		{
			get
			{
				if(r_toVector == null)
				{
					r_toVector = new(this, "toVector", -1);
					r_toVector.SetBelong(this.instance);
				}
				return r_toVector;
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


        public RNodeLink() : base("AstarClasses.NodeLink")
        {
        }

        public RNodeLink(System.Object instance) : base("AstarClasses.NodeLink")
		{
            SetInstance(instance);
		}

        public RNodeLink(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNodeLink(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
