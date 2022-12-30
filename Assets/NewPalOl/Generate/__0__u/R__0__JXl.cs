using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#JXl
	/// </summary>
    public partial class R__0__JXl : RMember //
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
		/// Void OnLoadEquipNecklaceUpConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadEquipNecklaceUpConfig_Object;
		public virtual RMethod ROnLoadEquipNecklaceUpConfig_Object
		{
			get
			{
				if(r_ROnLoadEquipNecklaceUpConfig_Object == null)
				{
					r_ROnLoadEquipNecklaceUpConfig_Object = new(this, "OnLoadEquipNecklaceUpConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadEquipNecklaceUpConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadEquipNecklaceUpConfig_Object;
			}
		}

		/// <summary>
		/// System.String #GVc(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__GVc_ID_String;
		public virtual RMethod R__0__GVc_ID_String
		{
			get
			{
				if(r_R__0__GVc_ID_String == null)
				{
					r_R__0__GVc_ID_String = new(this, "#GVc", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__GVc_ID_String.SetBelong(this.instance);
				}
				return r_R__0__GVc_ID_String;
			}
		}

		/// <summary>
		/// GameDefineType.ID #dam(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__dam_ID;
		public virtual RMethod R__0__dam_ID
		{
			get
			{
				if(r_R__0__dam_ID == null)
				{
					r_R__0__dam_ID = new(this, "#dam", 0, typeof(GameDefineType.ID));
					r_R__0__dam_ID.SetBelong(this.instance);
				}
				return r_R__0__dam_ID;
			}
		}

		/// <summary>
		/// Boolean #eam(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__eam_ID;
		public virtual RMethod R__0__eam_ID
		{
			get
			{
				if(r_R__0__eam_ID == null)
				{
					r_R__0__eam_ID = new(this, "#eam", 0, typeof(GameDefineType.ID));
					r_R__0__eam_ID.SetBelong(this.instance);
				}
				return r_R__0__eam_ID;
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


        public R__0__JXl() : base("#u.#JXl")
        {
        }

        public R__0__JXl(System.Object instance) : base("#u.#JXl")
		{
            SetInstance(instance);
		}

        public R__0__JXl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__JXl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadEquipNecklaceUpConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadEquipNecklaceUpConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__GVc(GameDefineType.ID  @id, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @name};
            var ___result = R__0__GVc_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual GameDefineType.ID __0__dam(GameDefineType.ID  @necklaceid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@necklaceid};
            var ___result = R__0__dam_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Boolean __0__eam(GameDefineType.ID  @necklaceid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@necklaceid};
            var ___result = R__0__eam_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
