using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AchievementRewardConfig
	/// </summary>
    public partial class RAchievementRewardConfig : RMember //
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
		/// System.Int32 itemid1
		/// </summary>
		protected RField r_itemid1;
		public virtual RField Ritemid1
		{
			get
			{
				if(r_itemid1 == null)
				{
					r_itemid1 = new(this, "itemid1");
					r_itemid1.SetBelong(this.instance);
				}
				return r_itemid1;
			}
		}

		/// <summary>
		/// System.Int32 itemid2
		/// </summary>
		protected RField r_itemid2;
		public virtual RField Ritemid2
		{
			get
			{
				if(r_itemid2 == null)
				{
					r_itemid2 = new(this, "itemid2");
					r_itemid2.SetBelong(this.instance);
				}
				return r_itemid2;
			}
		}

		/// <summary>
		/// System.Int32 itemid3
		/// </summary>
		protected RField r_itemid3;
		public virtual RField Ritemid3
		{
			get
			{
				if(r_itemid3 == null)
				{
					r_itemid3 = new(this, "itemid3");
					r_itemid3.SetBelong(this.instance);
				}
				return r_itemid3;
			}
		}

		/// <summary>
		/// System.Int32 itemid4
		/// </summary>
		protected RField r_itemid4;
		public virtual RField Ritemid4
		{
			get
			{
				if(r_itemid4 == null)
				{
					r_itemid4 = new(this, "itemid4");
					r_itemid4.SetBelong(this.instance);
				}
				return r_itemid4;
			}
		}

		/// <summary>
		/// System.Int32 itemcount1
		/// </summary>
		protected RField r_itemcount1;
		public virtual RField Ritemcount1
		{
			get
			{
				if(r_itemcount1 == null)
				{
					r_itemcount1 = new(this, "itemcount1");
					r_itemcount1.SetBelong(this.instance);
				}
				return r_itemcount1;
			}
		}

		/// <summary>
		/// System.Int32 itemcount2
		/// </summary>
		protected RField r_itemcount2;
		public virtual RField Ritemcount2
		{
			get
			{
				if(r_itemcount2 == null)
				{
					r_itemcount2 = new(this, "itemcount2");
					r_itemcount2.SetBelong(this.instance);
				}
				return r_itemcount2;
			}
		}

		/// <summary>
		/// System.Int32 itemcount3
		/// </summary>
		protected RField r_itemcount3;
		public virtual RField Ritemcount3
		{
			get
			{
				if(r_itemcount3 == null)
				{
					r_itemcount3 = new(this, "itemcount3");
					r_itemcount3.SetBelong(this.instance);
				}
				return r_itemcount3;
			}
		}

		/// <summary>
		/// System.Int32 itemcount4
		/// </summary>
		protected RField r_itemcount4;
		public virtual RField Ritemcount4
		{
			get
			{
				if(r_itemcount4 == null)
				{
					r_itemcount4 = new(this, "itemcount4");
					r_itemcount4.SetBelong(this.instance);
				}
				return r_itemcount4;
			}
		}

		/// <summary>
		/// System.Int32 point
		/// </summary>
		protected RField r_point;
		public virtual RField Rpoint
		{
			get
			{
				if(r_point == null)
				{
					r_point = new(this, "point");
					r_point.SetBelong(this.instance);
				}
				return r_point;
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


        public RAchievementRewardConfig() : base("AchievementRewardConfig")
        {
        }

        public RAchievementRewardConfig(System.Object instance) : base("AchievementRewardConfig")
		{
            SetInstance(instance);
		}

        public RAchievementRewardConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAchievementRewardConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
