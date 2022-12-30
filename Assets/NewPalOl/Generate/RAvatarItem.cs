using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AvatarItem
	/// </summary>
    public partial class RAvatarItem : RMember //
    {

		/// <summary>
		/// System.Int32 avatarId
		/// </summary>
		protected RField r_avatarId;
		public virtual RField RavatarId
		{
			get
			{
				if(r_avatarId == null)
				{
					r_avatarId = new(this, "avatarId");
					r_avatarId.SetBelong(this.instance);
				}
				return r_avatarId;
			}
		}

		/// <summary>
		/// System.String body_11
		/// </summary>
		protected RField r_body_11;
		public virtual RField Rbody_11
		{
			get
			{
				if(r_body_11 == null)
				{
					r_body_11 = new(this, "body_11");
					r_body_11.SetBelong(this.instance);
				}
				return r_body_11;
			}
		}

		/// <summary>
		/// System.String body_12
		/// </summary>
		protected RField r_body_12;
		public virtual RField Rbody_12
		{
			get
			{
				if(r_body_12 == null)
				{
					r_body_12 = new(this, "body_12");
					r_body_12.SetBelong(this.instance);
				}
				return r_body_12;
			}
		}

		/// <summary>
		/// System.String body_21
		/// </summary>
		protected RField r_body_21;
		public virtual RField Rbody_21
		{
			get
			{
				if(r_body_21 == null)
				{
					r_body_21 = new(this, "body_21");
					r_body_21.SetBelong(this.instance);
				}
				return r_body_21;
			}
		}

		/// <summary>
		/// System.String body_22
		/// </summary>
		protected RField r_body_22;
		public virtual RField Rbody_22
		{
			get
			{
				if(r_body_22 == null)
				{
					r_body_22 = new(this, "body_22");
					r_body_22.SetBelong(this.instance);
				}
				return r_body_22;
			}
		}

		/// <summary>
		/// System.String body_31
		/// </summary>
		protected RField r_body_31;
		public virtual RField Rbody_31
		{
			get
			{
				if(r_body_31 == null)
				{
					r_body_31 = new(this, "body_31");
					r_body_31.SetBelong(this.instance);
				}
				return r_body_31;
			}
		}

		/// <summary>
		/// System.String body_32
		/// </summary>
		protected RField r_body_32;
		public virtual RField Rbody_32
		{
			get
			{
				if(r_body_32 == null)
				{
					r_body_32 = new(this, "body_32");
					r_body_32.SetBelong(this.instance);
				}
				return r_body_32;
			}
		}

		/// <summary>
		/// System.String body_41
		/// </summary>
		protected RField r_body_41;
		public virtual RField Rbody_41
		{
			get
			{
				if(r_body_41 == null)
				{
					r_body_41 = new(this, "body_41");
					r_body_41.SetBelong(this.instance);
				}
				return r_body_41;
			}
		}

		/// <summary>
		/// System.String body_42
		/// </summary>
		protected RField r_body_42;
		public virtual RField Rbody_42
		{
			get
			{
				if(r_body_42 == null)
				{
					r_body_42 = new(this, "body_42");
					r_body_42.SetBelong(this.instance);
				}
				return r_body_42;
			}
		}

		/// <summary>
		/// System.String face_11
		/// </summary>
		protected RField r_face_11;
		public virtual RField Rface_11
		{
			get
			{
				if(r_face_11 == null)
				{
					r_face_11 = new(this, "face_11");
					r_face_11.SetBelong(this.instance);
				}
				return r_face_11;
			}
		}

		/// <summary>
		/// System.String face_12
		/// </summary>
		protected RField r_face_12;
		public virtual RField Rface_12
		{
			get
			{
				if(r_face_12 == null)
				{
					r_face_12 = new(this, "face_12");
					r_face_12.SetBelong(this.instance);
				}
				return r_face_12;
			}
		}

		/// <summary>
		/// System.String face_21
		/// </summary>
		protected RField r_face_21;
		public virtual RField Rface_21
		{
			get
			{
				if(r_face_21 == null)
				{
					r_face_21 = new(this, "face_21");
					r_face_21.SetBelong(this.instance);
				}
				return r_face_21;
			}
		}

		/// <summary>
		/// System.String face_22
		/// </summary>
		protected RField r_face_22;
		public virtual RField Rface_22
		{
			get
			{
				if(r_face_22 == null)
				{
					r_face_22 = new(this, "face_22");
					r_face_22.SetBelong(this.instance);
				}
				return r_face_22;
			}
		}

		/// <summary>
		/// System.String face_31
		/// </summary>
		protected RField r_face_31;
		public virtual RField Rface_31
		{
			get
			{
				if(r_face_31 == null)
				{
					r_face_31 = new(this, "face_31");
					r_face_31.SetBelong(this.instance);
				}
				return r_face_31;
			}
		}

		/// <summary>
		/// System.String face_32
		/// </summary>
		protected RField r_face_32;
		public virtual RField Rface_32
		{
			get
			{
				if(r_face_32 == null)
				{
					r_face_32 = new(this, "face_32");
					r_face_32.SetBelong(this.instance);
				}
				return r_face_32;
			}
		}

		/// <summary>
		/// System.String face_41
		/// </summary>
		protected RField r_face_41;
		public virtual RField Rface_41
		{
			get
			{
				if(r_face_41 == null)
				{
					r_face_41 = new(this, "face_41");
					r_face_41.SetBelong(this.instance);
				}
				return r_face_41;
			}
		}

		/// <summary>
		/// System.String face_42
		/// </summary>
		protected RField r_face_42;
		public virtual RField Rface_42
		{
			get
			{
				if(r_face_42 == null)
				{
					r_face_42 = new(this, "face_42");
					r_face_42.SetBelong(this.instance);
				}
				return r_face_42;
			}
		}

		/// <summary>
		/// System.String hair_11
		/// </summary>
		protected RField r_hair_11;
		public virtual RField Rhair_11
		{
			get
			{
				if(r_hair_11 == null)
				{
					r_hair_11 = new(this, "hair_11");
					r_hair_11.SetBelong(this.instance);
				}
				return r_hair_11;
			}
		}

		/// <summary>
		/// System.String hair_12
		/// </summary>
		protected RField r_hair_12;
		public virtual RField Rhair_12
		{
			get
			{
				if(r_hair_12 == null)
				{
					r_hair_12 = new(this, "hair_12");
					r_hair_12.SetBelong(this.instance);
				}
				return r_hair_12;
			}
		}

		/// <summary>
		/// System.String hair_21
		/// </summary>
		protected RField r_hair_21;
		public virtual RField Rhair_21
		{
			get
			{
				if(r_hair_21 == null)
				{
					r_hair_21 = new(this, "hair_21");
					r_hair_21.SetBelong(this.instance);
				}
				return r_hair_21;
			}
		}

		/// <summary>
		/// System.String hair_22
		/// </summary>
		protected RField r_hair_22;
		public virtual RField Rhair_22
		{
			get
			{
				if(r_hair_22 == null)
				{
					r_hair_22 = new(this, "hair_22");
					r_hair_22.SetBelong(this.instance);
				}
				return r_hair_22;
			}
		}

		/// <summary>
		/// System.String hair_31
		/// </summary>
		protected RField r_hair_31;
		public virtual RField Rhair_31
		{
			get
			{
				if(r_hair_31 == null)
				{
					r_hair_31 = new(this, "hair_31");
					r_hair_31.SetBelong(this.instance);
				}
				return r_hair_31;
			}
		}

		/// <summary>
		/// System.String hair_32
		/// </summary>
		protected RField r_hair_32;
		public virtual RField Rhair_32
		{
			get
			{
				if(r_hair_32 == null)
				{
					r_hair_32 = new(this, "hair_32");
					r_hair_32.SetBelong(this.instance);
				}
				return r_hair_32;
			}
		}

		/// <summary>
		/// System.String hair_41
		/// </summary>
		protected RField r_hair_41;
		public virtual RField Rhair_41
		{
			get
			{
				if(r_hair_41 == null)
				{
					r_hair_41 = new(this, "hair_41");
					r_hair_41.SetBelong(this.instance);
				}
				return r_hair_41;
			}
		}

		/// <summary>
		/// System.String hair_42
		/// </summary>
		protected RField r_hair_42;
		public virtual RField Rhair_42
		{
			get
			{
				if(r_hair_42 == null)
				{
					r_hair_42 = new(this, "hair_42");
					r_hair_42.SetBelong(this.instance);
				}
				return r_hair_42;
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


        public RAvatarItem() : base("AvatarItem")
        {
        }

        public RAvatarItem(System.Object instance) : base("AvatarItem")
		{
            SetInstance(instance);
		}

        public RAvatarItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAvatarItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
