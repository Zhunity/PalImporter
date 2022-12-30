using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// HyperLinkSceneCfg
	/// </summary>
    public partial class RHyperLinkSceneCfg : RMember //
    {

		/// <summary>
		/// System.Int32 targetMapID
		/// </summary>
		protected RField r_targetMapID;
		public virtual RField RtargetMapID
		{
			get
			{
				if(r_targetMapID == null)
				{
					r_targetMapID = new(this, "targetMapID");
					r_targetMapID.SetBelong(this.instance);
				}
				return r_targetMapID;
			}
		}

		/// <summary>
		/// System.Int32 mapType
		/// </summary>
		protected RField r_mapType;
		public virtual RField RmapType
		{
			get
			{
				if(r_mapType == null)
				{
					r_mapType = new(this, "mapType");
					r_mapType.SetBelong(this.instance);
				}
				return r_mapType;
			}
		}

		/// <summary>
		/// System.String transNPCID
		/// </summary>
		protected RField r_transNPCID;
		public virtual RField RtransNPCID
		{
			get
			{
				if(r_transNPCID == null)
				{
					r_transNPCID = new(this, "transNPCID");
					r_transNPCID.SetBelong(this.instance);
				}
				return r_transNPCID;
			}
		}

		/// <summary>
		/// System.Int32 needLevel
		/// </summary>
		protected RField r_needLevel;
		public virtual RField RneedLevel
		{
			get
			{
				if(r_needLevel == null)
				{
					r_needLevel = new(this, "needLevel");
					r_needLevel.SetBelong(this.instance);
				}
				return r_needLevel;
			}
		}

		/// <summary>
		/// System.Int32 parentMapID
		/// </summary>
		protected RField r_parentMapID;
		public virtual RField RparentMapID
		{
			get
			{
				if(r_parentMapID == null)
				{
					r_parentMapID = new(this, "parentMapID");
					r_parentMapID.SetBelong(this.instance);
				}
				return r_parentMapID;
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


        public RHyperLinkSceneCfg() : base("HyperLinkSceneCfg")
        {
        }

        public RHyperLinkSceneCfg(System.Object instance) : base("HyperLinkSceneCfg")
		{
            SetInstance(instance);
		}

        public RHyperLinkSceneCfg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHyperLinkSceneCfg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
