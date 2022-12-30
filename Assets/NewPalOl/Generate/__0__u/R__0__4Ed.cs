using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#4Ed
	/// </summary>
    public partial class R__0__4Ed : RMember //
    {

		/// <summary>
		/// KeyValueContent #a
		/// </summary>
		protected RKeyValueContent r___0__a;
		public virtual RKeyValueContent R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// Void OnLoadDefineEquipConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadDefineEquipConfig_Object;
		public virtual RMethod ROnLoadDefineEquipConfig_Object
		{
			get
			{
				if(r_ROnLoadDefineEquipConfig_Object == null)
				{
					r_ROnLoadDefineEquipConfig_Object = new(this, "OnLoadDefineEquipConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadDefineEquipConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadDefineEquipConfig_Object;
			}
		}

		/// <summary>
		/// GameDefineType.ID #1Ed(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__1Ed_ID_Int32;
		public virtual RMethod R__0__1Ed_ID_Int32
		{
			get
			{
				if(r_R__0__1Ed_ID_Int32 == null)
				{
					r_R__0__1Ed_ID_Int32 = new(this, "#1Ed", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__1Ed_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__1Ed_ID_Int32;
			}
		}

		/// <summary>
		/// GameDefineType.ID #2Ed(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__2Ed_ID_Int32;
		public virtual RMethod R__0__2Ed_ID_Int32
		{
			get
			{
				if(r_R__0__2Ed_ID_Int32 == null)
				{
					r_R__0__2Ed_ID_Int32 = new(this, "#2Ed", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__2Ed_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__2Ed_ID_Int32;
			}
		}

		/// <summary>
		/// Int32 #3Ed(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__3Ed_ID_Int32;
		public virtual RMethod R__0__3Ed_ID_Int32
		{
			get
			{
				if(r_R__0__3Ed_ID_Int32 == null)
				{
					r_R__0__3Ed_ID_Int32 = new(this, "#3Ed", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__3Ed_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__3Ed_ID_Int32;
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


        public R__0__4Ed() : base("#u.#4Ed")
        {
        }

        public R__0__4Ed(System.Object instance) : base("#u.#4Ed")
		{
            SetInstance(instance);
		}

        public R__0__4Ed(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__4Ed(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadDefineEquipConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadDefineEquipConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual GameDefineType.ID __0__1Ed(GameDefineType.ID  @careerid, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerid, @type};
            var ___result = R__0__1Ed_ID_Int32.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual GameDefineType.ID __0__2Ed(GameDefineType.ID  @careerid, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerid, @type};
            var ___result = R__0__2Ed_ID_Int32.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Int32 __0__3Ed(GameDefineType.ID  @careerid, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerid, @type};
            var ___result = R__0__3Ed_ID_Int32.Invoke(___genericsType, ___parameters);

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
