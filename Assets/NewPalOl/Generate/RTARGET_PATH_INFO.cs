using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TARGET_PATH_INFO
	/// </summary>
    public partial class RTARGET_PATH_INFO : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.String mapid
		/// </summary>
		protected RField r_mapid;
		public virtual RField Rmapid
		{
			get
			{
				if(r_mapid == null)
				{
					r_mapid = new(this, "mapid");
					r_mapid.SetBelong(this.instance);
				}
				return r_mapid;
			}
		}

		/// <summary>
		/// System.String npcid
		/// </summary>
		protected RField r_npcid;
		public virtual RField Rnpcid
		{
			get
			{
				if(r_npcid == null)
				{
					r_npcid = new(this, "npcid");
					r_npcid.SetBelong(this.instance);
				}
				return r_npcid;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 targetpos
		/// </summary>
		protected RUnityEngine.RVector3 r_targetpos;
		public virtual RUnityEngine.RVector3 Rtargetpos
		{
			get
			{
				if(r_targetpos == null)
				{
					r_targetpos = new(this, "targetpos");
					r_targetpos.SetBelong(this.instance);
				}
				return r_targetpos;
			}
		}

		/// <summary>
		/// System.String raid_id
		/// </summary>
		protected RField r_raid_id;
		public virtual RField Rraid_id
		{
			get
			{
				if(r_raid_id == null)
				{
					r_raid_id = new(this, "raid_id");
					r_raid_id.SetBelong(this.instance);
				}
				return r_raid_id;
			}
		}

		/// <summary>
		/// System.String raid_npcid
		/// </summary>
		protected RField r_raid_npcid;
		public virtual RField Rraid_npcid
		{
			get
			{
				if(r_raid_npcid == null)
				{
					r_raid_npcid = new(this, "raid_npcid");
					r_raid_npcid.SetBelong(this.instance);
				}
				return r_raid_npcid;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 raid_targetpos
		/// </summary>
		protected RUnityEngine.RVector3 r_raid_targetpos;
		public virtual RUnityEngine.RVector3 Rraid_targetpos
		{
			get
			{
				if(r_raid_targetpos == null)
				{
					r_raid_targetpos = new(this, "raid_targetpos");
					r_raid_targetpos.SetBelong(this.instance);
				}
				return r_raid_targetpos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] tribe_mapid
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_tribe_mapid;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rtribe_mapid
		{
			get
			{
				if(r_tribe_mapid == null)
				{
					r_tribe_mapid = new(this, "tribe_mapid");
					r_tribe_mapid.SetBelong(this.instance);
				}
				return r_tribe_mapid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] tribe_npcid
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_tribe_npcid;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rtribe_npcid
		{
			get
			{
				if(r_tribe_npcid == null)
				{
					r_tribe_npcid = new(this, "tribe_npcid");
					r_tribe_npcid.SetBelong(this.instance);
				}
				return r_tribe_npcid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Vector3] tribe_targetpos
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> r_tribe_targetpos;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> Rtribe_targetpos
		{
			get
			{
				if(r_tribe_targetpos == null)
				{
					r_tribe_targetpos = new(this, "tribe_targetpos");
					r_tribe_targetpos.SetBelong(this.instance);
				}
				return r_tribe_targetpos;
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


        public RTARGET_PATH_INFO() : base("TARGET_PATH_INFO")
        {
        }

        public RTARGET_PATH_INFO(System.Object instance) : base("TARGET_PATH_INFO")
		{
            SetInstance(instance);
		}

        public RTARGET_PATH_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTARGET_PATH_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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