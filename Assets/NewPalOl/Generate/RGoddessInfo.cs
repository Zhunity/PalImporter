using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// GoddessInfo
	/// </summary>
    public partial class RGoddessInfo : RMember //
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
		/// eGoddessStatus status
		/// </summary>
		protected RField r_status;
		public virtual RField Rstatus
		{
			get
			{
				if(r_status == null)
				{
					r_status = new(this, "status");
					r_status.SetBelong(this.instance);
				}
				return r_status;
			}
		}

		/// <summary>
		/// System.Boolean server_isActive
		/// </summary>
		protected RField r_server_isActive;
		public virtual RField Rserver_isActive
		{
			get
			{
				if(r_server_isActive == null)
				{
					r_server_isActive = new(this, "server_isActive");
					r_server_isActive.SetBelong(this.instance);
				}
				return r_server_isActive;
			}
		}

		/// <summary>
		/// System.Boolean server_isEquiped
		/// </summary>
		protected RField r_server_isEquiped;
		public virtual RField Rserver_isEquiped
		{
			get
			{
				if(r_server_isEquiped == null)
				{
					r_server_isEquiped = new(this, "server_isEquiped");
					r_server_isEquiped.SetBelong(this.instance);
				}
				return r_server_isEquiped;
			}
		}

		/// <summary>
		/// System.Int32 server_exp
		/// </summary>
		protected RField r_server_exp;
		public virtual RField Rserver_exp
		{
			get
			{
				if(r_server_exp == null)
				{
					r_server_exp = new(this, "server_exp");
					r_server_exp.SetBelong(this.instance);
				}
				return r_server_exp;
			}
		}

		/// <summary>
		/// System.Int32 server_level
		/// </summary>
		protected RField r_server_level;
		public virtual RField Rserver_level
		{
			get
			{
				if(r_server_level == null)
				{
					r_server_level = new(this, "server_level");
					r_server_level.SetBelong(this.instance);
				}
				return r_server_level;
			}
		}

		/// <summary>
		/// System.Int32 active_level
		/// </summary>
		protected RField r_active_level;
		public virtual RField Ractive_level
		{
			get
			{
				if(r_active_level == null)
				{
					r_active_level = new(this, "active_level");
					r_active_level.SetBelong(this.instance);
				}
				return r_active_level;
			}
		}

		/// <summary>
		/// System.Int32 active_item
		/// </summary>
		protected RField r_active_item;
		public virtual RField Ractive_item
		{
			get
			{
				if(r_active_item == null)
				{
					r_active_item = new(this, "active_item");
					r_active_item.SetBelong(this.instance);
				}
				return r_active_item;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GoddessByLevel] listByLevel
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGoddessByLevel> r_listByLevel;
		public virtual RSystem.RCollections.RGeneric.RList<RGoddessByLevel> RlistByLevel
		{
			get
			{
				if(r_listByLevel == null)
				{
					r_listByLevel = new(this, "listByLevel");
					r_listByLevel.SetBelong(this.instance);
				}
				return r_listByLevel;
			}
		}

		/// <summary>
		/// GoddessByLevel GetCurrGoddessByLevel()
		/// </summary>
		protected RMethod r_RGetCurrGoddessByLevel;
		public virtual RMethod RGetCurrGoddessByLevel
		{
			get
			{
				if(r_RGetCurrGoddessByLevel == null)
				{
					r_RGetCurrGoddessByLevel = new(this, "GetCurrGoddessByLevel", 0);
					r_RGetCurrGoddessByLevel.SetBelong(this.instance);
				}
				return r_RGetCurrGoddessByLevel;
			}
		}

		/// <summary>
		/// GoddessByLevel GetGoddessByLevel(Int32)
		/// </summary>
		protected RMethod r_RGetGoddessByLevel_Int32;
		public virtual RMethod RGetGoddessByLevel_Int32
		{
			get
			{
				if(r_RGetGoddessByLevel_Int32 == null)
				{
					r_RGetGoddessByLevel_Int32 = new(this, "GetGoddessByLevel", 0, typeof(System.Int32));
					r_RGetGoddessByLevel_Int32.SetBelong(this.instance);
				}
				return r_RGetGoddessByLevel_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMaxLevel()
		/// </summary>
		protected RMethod r_RGetMaxLevel;
		public virtual RMethod RGetMaxLevel
		{
			get
			{
				if(r_RGetMaxLevel == null)
				{
					r_RGetMaxLevel = new(this, "GetMaxLevel", 0);
					r_RGetMaxLevel.SetBelong(this.instance);
				}
				return r_RGetMaxLevel;
			}
		}

		/// <summary>
		/// Int32 GetMaxExpAcc()
		/// </summary>
		protected RMethod r_RGetMaxExpAcc;
		public virtual RMethod RGetMaxExpAcc
		{
			get
			{
				if(r_RGetMaxExpAcc == null)
				{
					r_RGetMaxExpAcc = new(this, "GetMaxExpAcc", 0);
					r_RGetMaxExpAcc.SetBelong(this.instance);
				}
				return r_RGetMaxExpAcc;
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


        public RGoddessInfo() : base("GoddessInfo")
        {
        }

        public RGoddessInfo(System.Object instance) : base("GoddessInfo")
		{
            SetInstance(instance);
		}

        public RGoddessInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGoddessInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual GoddessByLevel GetCurrGoddessByLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrGoddessByLevel.Invoke(___genericsType, ___parameters);

            return (GoddessByLevel)___result;
        }


        public virtual GoddessByLevel GetGoddessByLevel(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetGoddessByLevel_Int32.Invoke(___genericsType, ___parameters);

            return (GoddessByLevel)___result;
        }


        public virtual System.Int32 GetMaxLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMaxLevel.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMaxExpAcc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMaxExpAcc.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
