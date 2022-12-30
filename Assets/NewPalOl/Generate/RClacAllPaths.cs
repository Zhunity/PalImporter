using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ClacAllPaths
	/// </summary>
    public partial class RClacAllPaths : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,ClacAllPaths+#0] #a
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RClacAllPaths.R__0__0> r___0__a;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RClacAllPaths.R__0__0> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(ClacAllPaths), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// Void #eVl(SceneConfigHold, TransPointsHold)
		/// </summary>
		protected static RMethod r_R__0__eVl_SceneConfigHold_TransPointsHold;
		public static RMethod R__0__eVl_SceneConfigHold_TransPointsHold
		{
			get
			{
				if(r_R__0__eVl_SceneConfigHold_TransPointsHold == null)
				{
					r_R__0__eVl_SceneConfigHold_TransPointsHold = new(typeof(ClacAllPaths), "#eVl", 0, typeof(SceneConfigHold), typeof(TransPointsHold));
					r_R__0__eVl_SceneConfigHold_TransPointsHold.SetBelong(null);
				}
				return r_R__0__eVl_SceneConfigHold_TransPointsHold;
			}
		}

		/// <summary>
		/// Void #Z(System.Collections.Generic.Stack`1[System.String], System.Collections.Generic.Stack`1[System.String], System.String, System.String, System.String, System.Collections.Generic.Dictionary`2[System.String,SceneLogicConfig])
		/// </summary>
		protected static RMethod r_R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_;
		public static RMethod R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_
		{
			get
			{
				if(r_R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_ == null)
				{
					r_R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_ = new(typeof(ClacAllPaths), "#Z", 0, typeof(System.Collections.Generic.Stack<>).MakeGenericType(typeof(System.String)), typeof(System.Collections.Generic.Stack<>).MakeGenericType(typeof(System.String)), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(SceneLogicConfig)));
					r_R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_.SetBelong(null);
				}
				return r_R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_;
			}
		}

		/// <summary>
		/// System.String #E3c(System.Collections.Generic.Dictionary`2[GameDefineType.ID,TransformInfo], System.String)
		/// </summary>
		protected static RMethod r_R__0__E3c_Dictionary_d_ID_TransformInfo_p__String;
		public static RMethod R__0__E3c_Dictionary_d_ID_TransformInfo_p__String
		{
			get
			{
				if(r_R__0__E3c_Dictionary_d_ID_TransformInfo_p__String == null)
				{
					r_R__0__E3c_Dictionary_d_ID_TransformInfo_p__String = new(typeof(ClacAllPaths), "#E3c", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(GameDefineType.ID), typeof(TransformInfo)), typeof(System.String));
					r_R__0__E3c_Dictionary_d_ID_TransformInfo_p__String.SetBelong(null);
				}
				return r_R__0__E3c_Dictionary_d_ID_TransformInfo_p__String;
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


        public RClacAllPaths() : base("ClacAllPaths")
        {
        }

        public RClacAllPaths(System.Object instance) : base("ClacAllPaths")
		{
            SetInstance(instance);
		}

        public RClacAllPaths(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClacAllPaths(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void __0__eVl(SceneConfigHold  @mapconfig, TransPointsHold  @transHold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapconfig, @transHold};
            var ___result = R__0__eVl_SceneConfigHold_TransPointsHold.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__Z(System.Collections.Generic.Stack<System.String>  @tplist, System.Collections.Generic.Stack<System.String>  @maplist, System.String  @startID, System.String  @currentID, System.String  @targetID, System.Collections.Generic.Dictionary<System.String, SceneLogicConfig>  @mapdict)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tplist, @maplist, @startID, @currentID, @targetID, @mapdict};
            var ___result = R__0__Z_Stack_d_String_p__Stack_d_String_p__String_String_String_Dictionary_d_String_SceneLogicConfig_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String __0__E3c(System.Collections.Generic.Dictionary<GameDefineType.ID, TransformInfo>  @transpoints, System.String  @targetID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@transpoints, @targetID};
            var ___result = R__0__E3c_Dictionary_d_ID_TransformInfo_p__String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
