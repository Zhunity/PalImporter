using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RestRoom
	/// </summary>
    public partial class RRestRoom : RMember //
    {

		/// <summary>
		/// GameDefineType.ID idActor
		/// </summary>
		protected RGameDefineType.RID r_idActor;
		public virtual RGameDefineType.RID RidActor
		{
			get
			{
				if(r_idActor == null)
				{
					r_idActor = new(this, "idActor");
					r_idActor.SetBelong(this.instance);
				}
				return r_idActor;
			}
		}

		/// <summary>
		/// System.Int32 nIndex
		/// </summary>
		protected RField r_nIndex;
		public virtual RField RnIndex
		{
			get
			{
				if(r_nIndex == null)
				{
					r_nIndex = new(this, "nIndex");
					r_nIndex.SetBelong(this.instance);
				}
				return r_nIndex;
			}
		}

		/// <summary>
		/// System.String strName
		/// </summary>
		protected RField r_strName;
		public virtual RField RstrName
		{
			get
			{
				if(r_strName == null)
				{
					r_strName = new(this, "strName");
					r_strName.SetBelong(this.instance);
				}
				return r_strName;
			}
		}

		/// <summary>
		/// System.String strFamily
		/// </summary>
		protected RField r_strFamily;
		public virtual RField RstrFamily
		{
			get
			{
				if(r_strFamily == null)
				{
					r_strFamily = new(this, "strFamily");
					r_strFamily.SetBelong(this.instance);
				}
				return r_strFamily;
			}
		}

		/// <summary>
		/// RestRoomTyp typ
		/// </summary>
		protected RField r_typ;
		public virtual RField Rtyp
		{
			get
			{
				if(r_typ == null)
				{
					r_typ = new(this, "typ");
					r_typ.SetBelong(this.instance);
				}
				return r_typ;
			}
		}

		/// <summary>
		/// Int32 CompareTo(RestRoom)
		/// </summary>
		protected RMethod r_RCompareTo_RestRoom;
		public virtual RMethod RCompareTo_RestRoom
		{
			get
			{
				if(r_RCompareTo_RestRoom == null)
				{
					r_RCompareTo_RestRoom = new(this, "CompareTo", 0, typeof(RestRoom));
					r_RCompareTo_RestRoom.SetBelong(this.instance);
				}
				return r_RCompareTo_RestRoom;
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


        public RRestRoom() : base("RestRoom")
        {
        }

        public RRestRoom(System.Object instance) : base("RestRoom")
		{
            SetInstance(instance);
		}

        public RRestRoom(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRestRoom(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 CompareTo(RestRoom  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_RestRoom.Invoke(___genericsType, ___parameters);

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
