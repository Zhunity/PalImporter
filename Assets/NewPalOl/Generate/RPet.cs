using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Pet
	/// </summary>
    public partial class RPet : RMember //
    {

		/// <summary>
		/// PetBehav #a
		/// </summary>
		protected RPetBehav r___0__a;
		public virtual RPetBehav R__0__a
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
		/// System.Boolean #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Boolean #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Boolean #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Boolean #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Int32] #f
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> r___0__f;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// PetBehav m_PetBehav
		/// </summary>
		protected RPetBehav r_R__0__eeb;
		public virtual RPetBehav R__0__eeb
		{
			get
			{
				if(r_R__0__eeb == null)
				{
					r_R__0__eeb = new(this, "m_PetBehav", -1);
					r_R__0__eeb.SetBelong(this.instance);
				}
				return r_R__0__eeb;
			}
		}

		/// <summary>
		/// Boolean HasLoadedProperties
		/// </summary>
		protected RProperty r_R__0__feb;
		public virtual RProperty R__0__feb
		{
			get
			{
				if(r_R__0__feb == null)
				{
					r_R__0__feb = new(this, "HasLoadedProperties", -1);
					r_R__0__feb.SetBelong(this.instance);
				}
				return r_R__0__feb;
			}
		}

		/// <summary>
		/// UnityEngine.Transform m_ctrlTransform
		/// </summary>
		protected RUnityEngine.RTransform r_R__0__Hdb;
		public virtual RUnityEngine.RTransform R__0__Hdb
		{
			get
			{
				if(r_R__0__Hdb == null)
				{
					r_R__0__Hdb = new(this, "m_ctrlTransform", -1);
					r_R__0__Hdb.SetBelong(this.instance);
				}
				return r_R__0__Hdb;
			}
		}

		/// <summary>
		/// CreatureBehav m_behav
		/// </summary>
		protected RCreatureBehav r_R__0__Idb;
		public virtual RCreatureBehav R__0__Idb
		{
			get
			{
				if(r_R__0__Idb == null)
				{
					r_R__0__Idb = new(this, "m_behav", -1);
					r_R__0__Idb.SetBelong(this.instance);
				}
				return r_R__0__Idb;
			}
		}

		/// <summary>
		/// GameDefineType.ID ID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Mdb;
		public virtual RGameDefineType.RID R__0__Mdb
		{
			get
			{
				if(r_R__0__Mdb == null)
				{
					r_R__0__Mdb = new(this, "ID", -1);
					r_R__0__Mdb.SetBelong(this.instance);
				}
				return r_R__0__Mdb;
			}
		}

		/// <summary>
		/// GameDefineType.ID CareerID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Odb;
		public virtual RGameDefineType.RID R__0__Odb
		{
			get
			{
				if(r_R__0__Odb == null)
				{
					r_R__0__Odb = new(this, "CareerID", -1);
					r_R__0__Odb.SetBelong(this.instance);
				}
				return r_R__0__Odb;
			}
		}

		/// <summary>
		/// Void #7db(#Pfb.#2yb)
		/// </summary>
		protected RMethod r_R__0__7db___0__2yb;
		public virtual RMethod R__0__7db___0__2yb
		{
			get
			{
				if(r_R__0__7db___0__2yb == null)
				{
					r_R__0__7db___0__2yb = new(this, "#7db", 0,  ReleactionUtils.GetType("#Pfb.#2yb"));
					r_R__0__7db___0__2yb.SetBelong(this.instance);
				}
				return r_R__0__7db___0__2yb;
			}
		}

		/// <summary>
		/// Void #7db(#Pfb.#4yb)
		/// </summary>
		protected RMethod r_R__0__7db___0__4yb;
		public virtual RMethod R__0__7db___0__4yb
		{
			get
			{
				if(r_R__0__7db___0__4yb == null)
				{
					r_R__0__7db___0__4yb = new(this, "#7db", 0,  ReleactionUtils.GetType("#Pfb.#4yb"));
					r_R__0__7db___0__4yb.SetBelong(this.instance);
				}
				return r_R__0__7db___0__4yb;
			}
		}

		/// <summary>
		/// Void #7db(#Pfb.#3yb)
		/// </summary>
		protected RMethod r_R__0__7db___0__3yb;
		public virtual RMethod R__0__7db___0__3yb
		{
			get
			{
				if(r_R__0__7db___0__3yb == null)
				{
					r_R__0__7db___0__3yb = new(this, "#7db", 0,  ReleactionUtils.GetType("#Pfb.#3yb"));
					r_R__0__7db___0__3yb.SetBelong(this.instance);
				}
				return r_R__0__7db___0__3yb;
			}
		}

		/// <summary>
		/// Int32 CompareTo(Pet)
		/// </summary>
		protected RMethod r_RCompareTo_Pet;
		public virtual RMethod RCompareTo_Pet
		{
			get
			{
				if(r_RCompareTo_Pet == null)
				{
					r_RCompareTo_Pet = new(this, "CompareTo", 0,  ReleactionUtils.GetType("Pet"));
					r_RCompareTo_Pet.SetBelong(this.instance);
				}
				return r_RCompareTo_Pet;
			}
		}

		/// <summary>
		/// Boolean #Gkq()
		/// </summary>
		protected RMethod r_R__0__Gkq;
		public virtual RMethod R__0__Gkq
		{
			get
			{
				if(r_R__0__Gkq == null)
				{
					r_R__0__Gkq = new(this, "#Gkq", 0);
					r_R__0__Gkq.SetBelong(this.instance);
				}
				return r_R__0__Gkq;
			}
		}

		/// <summary>
		/// eCombineSkillStatus #Hkq()
		/// </summary>
		protected RMethod r_R__0__Hkq;
		public virtual RMethod R__0__Hkq
		{
			get
			{
				if(r_R__0__Hkq == null)
				{
					r_R__0__Hkq = new(this, "#Hkq", 0);
					r_R__0__Hkq.SetBelong(this.instance);
				}
				return r_R__0__Hkq;
			}
		}

		/// <summary>
		/// Void #beb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__beb_Object_Object;
		public virtual RMethod R__0__beb_Object_Object
		{
			get
			{
				if(r_R__0__beb_Object_Object == null)
				{
					r_R__0__beb_Object_Object = new(this, "#beb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__beb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__beb_Object_Object;
			}
		}

		/// <summary>
		/// Void #ceb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ceb_Object_Object;
		public virtual RMethod R__0__ceb_Object_Object
		{
			get
			{
				if(r_R__0__ceb_Object_Object == null)
				{
					r_R__0__ceb_Object_Object = new(this, "#ceb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ceb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ceb_Object_Object;
			}
		}

		/// <summary>
		/// Void #rxk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__rxk_Object_Object;
		public virtual RMethod R__0__rxk_Object_Object
		{
			get
			{
				if(r_R__0__rxk_Object_Object == null)
				{
					r_R__0__rxk_Object_Object = new(this, "#rxk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__rxk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__rxk_Object_Object;
			}
		}

		/// <summary>
		/// Void #2N(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__2N_Object_Object;
		public virtual RMethod R__0__2N_Object_Object
		{
			get
			{
				if(r_R__0__2N_Object_Object == null)
				{
					r_R__0__2N_Object_Object = new(this, "#2N", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__2N_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__2N_Object_Object;
			}
		}

		/// <summary>
		/// Void #geb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__geb_Object_Object;
		public virtual RMethod R__0__geb_Object_Object
		{
			get
			{
				if(r_R__0__geb_Object_Object == null)
				{
					r_R__0__geb_Object_Object = new(this, "#geb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__geb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__geb_Object_Object;
			}
		}

		/// <summary>
		/// Void #heb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__heb_Object_Object;
		public virtual RMethod R__0__heb_Object_Object
		{
			get
			{
				if(r_R__0__heb_Object_Object == null)
				{
					r_R__0__heb_Object_Object = new(this, "#heb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__heb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__heb_Object_Object;
			}
		}

		/// <summary>
		/// Void #ieb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ieb_Object_Object;
		public virtual RMethod R__0__ieb_Object_Object
		{
			get
			{
				if(r_R__0__ieb_Object_Object == null)
				{
					r_R__0__ieb_Object_Object = new(this, "#ieb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ieb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ieb_Object_Object;
			}
		}

		/// <summary>
		/// Void #JIc(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__JIc_Object_Object;
		public virtual RMethod R__0__JIc_Object_Object
		{
			get
			{
				if(r_R__0__JIc_Object_Object == null)
				{
					r_R__0__JIc_Object_Object = new(this, "#JIc", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__JIc_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__JIc_Object_Object;
			}
		}

		/// <summary>
		/// Void #S8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__S8d_Object_Object;
		public virtual RMethod R__0__S8d_Object_Object
		{
			get
			{
				if(r_R__0__S8d_Object_Object == null)
				{
					r_R__0__S8d_Object_Object = new(this, "#S8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__S8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__S8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #Ikq(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Ikq_Object_Object;
		public virtual RMethod R__0__Ikq_Object_Object
		{
			get
			{
				if(r_R__0__Ikq_Object_Object == null)
				{
					r_R__0__Ikq_Object_Object = new(this, "#Ikq", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Ikq_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Ikq_Object_Object;
			}
		}

		/// <summary>
		/// Void #Jkq(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Jkq_Object_Object;
		public virtual RMethod R__0__Jkq_Object_Object
		{
			get
			{
				if(r_R__0__Jkq_Object_Object == null)
				{
					r_R__0__Jkq_Object_Object = new(this, "#Jkq", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Jkq_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Jkq_Object_Object;
			}
		}

		/// <summary>
		/// Void #T8d(System.String)
		/// </summary>
		protected RMethod r_R__0__T8d_String;
		public virtual RMethod R__0__T8d_String
		{
			get
			{
				if(r_R__0__T8d_String == null)
				{
					r_R__0__T8d_String = new(this, "#T8d", 0, typeof(System.String));
					r_R__0__T8d_String.SetBelong(this.instance);
				}
				return r_R__0__T8d_String;
			}
		}

		/// <summary>
		/// Int32 #oFd(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__oFd_ID;
		public virtual RMethod R__0__oFd_ID
		{
			get
			{
				if(r_R__0__oFd_ID == null)
				{
					r_R__0__oFd_ID = new(this, "#oFd", 0, typeof(GameDefineType.ID));
					r_R__0__oFd_ID.SetBelong(this.instance);
				}
				return r_R__0__oFd_ID;
			}
		}

		/// <summary>
		/// #u.#Ueb #Jdb(#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb___0__Reb;
		public virtual RMethod R__0__Jdb___0__Reb
		{
			get
			{
				if(r_R__0__Jdb___0__Reb == null)
				{
					r_R__0__Jdb___0__Reb = new(this, "#Jdb", 0,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb___0__Reb;
			}
		}

		/// <summary>
		/// #bk #Jdb[#bk](#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb_G__0__bk___0__Reb;
		public virtual RMethod R__0__Jdb_G__0__bk___0__Reb
		{
			get
			{
				if(r_R__0__Jdb_G__0__bk___0__Reb == null)
				{
					r_R__0__Jdb_G__0__bk___0__Reb = new(this, "#Jdb", 1,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb_G__0__bk___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb_G__0__bk___0__Reb;
			}
		}

		/// <summary>
		/// Void #Kdb(#u.#Reb, #u.#Ueb)
		/// </summary>
		protected RMethod r_R__0__Kdb___0__Reb___0__Ueb;
		public virtual RMethod R__0__Kdb___0__Reb___0__Ueb
		{
			get
			{
				if(r_R__0__Kdb___0__Reb___0__Ueb == null)
				{
					r_R__0__Kdb___0__Reb___0__Ueb = new(this, "#Kdb", 0,  ReleactionUtils.GetType("#u.#Reb"),  ReleactionUtils.GetType("#u.#Ueb"));
					r_R__0__Kdb___0__Reb___0__Ueb.SetBelong(this.instance);
				}
				return r_R__0__Kdb___0__Reb___0__Ueb;
			}
		}

		/// <summary>
		/// System.Object GetProperty(System.String)
		/// </summary>
		protected RMethod r_RGetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_RGetProperty_String == null)
				{
					r_RGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_RGetProperty_String.SetBelong(this.instance);
				}
				return r_RGetProperty_String;
			}
		}

		/// <summary>
		/// Void #yhd()
		/// </summary>
		protected RMethod r_R__0__yhd;
		public virtual RMethod R__0__yhd
		{
			get
			{
				if(r_R__0__yhd == null)
				{
					r_R__0__yhd = new(this, "#yhd", 0);
					r_R__0__yhd.SetBelong(this.instance);
				}
				return r_R__0__yhd;
			}
		}

		/// <summary>
		/// Void #Pdb(System.String, #u.#sOb)
		/// </summary>
		protected RMethod r_R__0__Pdb_String___0__sOb;
		public virtual RMethod R__0__Pdb_String___0__sOb
		{
			get
			{
				if(r_R__0__Pdb_String___0__sOb == null)
				{
					r_R__0__Pdb_String___0__sOb = new(this, "#Pdb", 0, typeof(System.String),  ReleactionUtils.GetType("#u.#sOb"));
					r_R__0__Pdb_String___0__sOb.SetBelong(this.instance);
				}
				return r_R__0__Pdb_String___0__sOb;
			}
		}

		/// <summary>
		/// Void #i4c(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__i4c_String_Object_Object;
		public virtual RMethod R__0__i4c_String_Object_Object
		{
			get
			{
				if(r_R__0__i4c_String_Object_Object == null)
				{
					r_R__0__i4c_String_Object_Object = new(this, "#i4c", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_R__0__i4c_String_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__i4c_String_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarOverHead_Object_Object;
		public virtual RMethod RSetProgressBarOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarOverHead_Object_Object == null)
				{
					r_RSetProgressBarOverHead_Object_Object = new(this, "SetProgressBarOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarOverHead_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarTipOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarTipOverHead_Object_Object;
		public virtual RMethod RSetProgressBarTipOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarTipOverHead_Object_Object == null)
				{
					r_RSetProgressBarTipOverHead_Object_Object = new(this, "SetProgressBarTipOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarTipOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarTipOverHead_Object_Object;
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


        public RPet() : base("Pet")
        {
        }

        public RPet(System.Object instance) : base("Pet")
		{
            SetInstance(instance);
		}

        public RPet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }





        public virtual System.Boolean __0__Gkq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Gkq.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual eCombineSkillStatus __0__Hkq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hkq.Invoke(___genericsType, ___parameters);

            return (eCombineSkillStatus)___result;
        }


        public virtual void __0__beb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__beb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ceb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ceb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rxk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__rxk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2N(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__2N_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__geb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__geb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__heb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__heb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ieb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ieb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__JIc(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__JIc_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__S8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__S8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ikq(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Ikq_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Jkq(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Jkq_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__T8d(System.String  @strinfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strinfo};
            var ___result = R__0__T8d_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__oFd(GameDefineType.ID  @itemid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemid};
            var ___result = R__0__oFd_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual System.Object GetProperty(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__yhd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yhd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__i4c(System.String  @proptertyName, System.Object  @propertyOldValue, System.Object  @propertyNewValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proptertyName, @propertyOldValue, @propertyNewValue};
            var ___result = R__0__i4c_String_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarTipOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarTipOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
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
