using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TargetMenu
	/// </summary>
    public partial class RTargetMenu : RMember //
    {

		/// <summary>
		/// System.Single VISIBLE_DISTANCE
		/// </summary>
		protected static RField r_VISIBLE_DISTANCE;
		public static RField RVISIBLE_DISTANCE
		{
			get
			{
				if(r_VISIBLE_DISTANCE == null)
				{
					r_VISIBLE_DISTANCE = new( ReleactionUtils.GetType("TargetMenu"), "VISIBLE_DISTANCE");
					r_VISIBLE_DISTANCE.SetBelong(null);
				}
				return r_VISIBLE_DISTANCE;
			}
		}

		/// <summary>
		/// System.String[] MENU_ITEMS
		/// </summary>
		protected RFieldArray<RField> r_MENU_ITEMS;
		public virtual RFieldArray<RField> RMENU_ITEMS
		{
			get
			{
				if(r_MENU_ITEMS == null)
				{
					r_MENU_ITEMS = new(this, "MENU_ITEMS");
					r_MENU_ITEMS.SetBelong(this.instance);
				}
				return r_MENU_ITEMS;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_MenuTargetID
		/// </summary>
		protected RGameDefineType.RID r_m_MenuTargetID;
		public virtual RGameDefineType.RID Rm_MenuTargetID
		{
			get
			{
				if(r_m_MenuTargetID == null)
				{
					r_m_MenuTargetID = new(this, "m_MenuTargetID");
					r_m_MenuTargetID.SetBelong(this.instance);
				}
				return r_m_MenuTargetID;
			}
		}

		/// <summary>
		/// System.String m_TargetName
		/// </summary>
		protected RField r_m_TargetName;
		public virtual RField Rm_TargetName
		{
			get
			{
				if(r_m_TargetName == null)
				{
					r_m_TargetName = new(this, "m_TargetName");
					r_m_TargetName.SetBelong(this.instance);
				}
				return r_m_TargetName;
			}
		}

		/// <summary>
		/// Character m_Target
		/// </summary>
		protected RCharacter r_m_Target;
		public virtual RCharacter Rm_Target
		{
			get
			{
				if(r_m_Target == null)
				{
					r_m_Target = new(this, "m_Target");
					r_m_Target.SetBelong(this.instance);
				}
				return r_m_Target;
			}
		}

		/// <summary>
		/// MyGUIGenericMenuWnd m_MenuWnd
		/// </summary>
		protected RMyGUIGenericMenuWnd r_m_MenuWnd;
		public virtual RMyGUIGenericMenuWnd Rm_MenuWnd
		{
			get
			{
				if(r_m_MenuWnd == null)
				{
					r_m_MenuWnd = new(this, "m_MenuWnd");
					r_m_MenuWnd.SetBelong(this.instance);
				}
				return r_m_MenuWnd;
			}
		}

		/// <summary>
		/// System.Boolean m_bShowFromChat
		/// </summary>
		protected RField r_m_bShowFromChat;
		public virtual RField Rm_bShowFromChat
		{
			get
			{
				if(r_m_bShowFromChat == null)
				{
					r_m_bShowFromChat = new(this, "m_bShowFromChat");
					r_m_bShowFromChat.SetBelong(this.instance);
				}
				return r_m_bShowFromChat;
			}
		}

		/// <summary>
		/// Void ShowTargetMenu(GameDefineType.ID, Boolean, System.String)
		/// </summary>
		protected RMethod r_RShowTargetMenu_ID_Boolean_String;
		public virtual RMethod RShowTargetMenu_ID_Boolean_String
		{
			get
			{
				if(r_RShowTargetMenu_ID_Boolean_String == null)
				{
					r_RShowTargetMenu_ID_Boolean_String = new(this, "ShowTargetMenu", 0, typeof(GameDefineType.ID), typeof(System.Boolean), typeof(System.String));
					r_RShowTargetMenu_ID_Boolean_String.SetBelong(this.instance);
				}
				return r_RShowTargetMenu_ID_Boolean_String;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void OnClickGuildInvite(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickGuildInvite_Object___0__7X;
		public virtual RMethod ROnClickGuildInvite_Object___0__7X
		{
			get
			{
				if(r_ROnClickGuildInvite_Object___0__7X == null)
				{
					r_ROnClickGuildInvite_Object___0__7X = new(this, "OnClickGuildInvite", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickGuildInvite_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickGuildInvite_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickJoinTeam(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickJoinTeam_Object___0__7X;
		public virtual RMethod ROnClickJoinTeam_Object___0__7X
		{
			get
			{
				if(r_ROnClickJoinTeam_Object___0__7X == null)
				{
					r_ROnClickJoinTeam_Object___0__7X = new(this, "OnClickJoinTeam", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickJoinTeam_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickJoinTeam_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickKickOut(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickKickOut_Object___0__7X;
		public virtual RMethod ROnClickKickOut_Object___0__7X
		{
			get
			{
				if(r_ROnClickKickOut_Object___0__7X == null)
				{
					r_ROnClickKickOut_Object___0__7X = new(this, "OnClickKickOut", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickKickOut_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickKickOut_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickFollowTeam(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickFollowTeam_Object___0__7X;
		public virtual RMethod ROnClickFollowTeam_Object___0__7X
		{
			get
			{
				if(r_ROnClickFollowTeam_Object___0__7X == null)
				{
					r_ROnClickFollowTeam_Object___0__7X = new(this, "OnClickFollowTeam", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickFollowTeam_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickFollowTeam_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickLeaveTeamTempy(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickLeaveTeamTempy_Object___0__7X;
		public virtual RMethod ROnClickLeaveTeamTempy_Object___0__7X
		{
			get
			{
				if(r_ROnClickLeaveTeamTempy_Object___0__7X == null)
				{
					r_ROnClickLeaveTeamTempy_Object___0__7X = new(this, "OnClickLeaveTeamTempy", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickLeaveTeamTempy_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickLeaveTeamTempy_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickLeaveTeam(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickLeaveTeam_Object___0__7X;
		public virtual RMethod ROnClickLeaveTeam_Object___0__7X
		{
			get
			{
				if(r_ROnClickLeaveTeam_Object___0__7X == null)
				{
					r_ROnClickLeaveTeam_Object___0__7X = new(this, "OnClickLeaveTeam", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickLeaveTeam_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickLeaveTeam_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickInviteJoinTeam(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickInviteJoinTeam_Object___0__7X;
		public virtual RMethod ROnClickInviteJoinTeam_Object___0__7X
		{
			get
			{
				if(r_ROnClickInviteJoinTeam_Object___0__7X == null)
				{
					r_ROnClickInviteJoinTeam_Object___0__7X = new(this, "OnClickInviteJoinTeam", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickInviteJoinTeam_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickInviteJoinTeam_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickAddBlack(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickAddBlack_Object___0__7X;
		public virtual RMethod ROnClickAddBlack_Object___0__7X
		{
			get
			{
				if(r_ROnClickAddBlack_Object___0__7X == null)
				{
					r_ROnClickAddBlack_Object___0__7X = new(this, "OnClickAddBlack", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickAddBlack_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickAddBlack_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickAddFriend(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickAddFriend_Object___0__7X;
		public virtual RMethod ROnClickAddFriend_Object___0__7X
		{
			get
			{
				if(r_ROnClickAddFriend_Object___0__7X == null)
				{
					r_ROnClickAddFriend_Object___0__7X = new(this, "OnClickAddFriend", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickAddFriend_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickAddFriend_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickAddEnemy(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickAddEnemy_Object___0__7X;
		public virtual RMethod ROnClickAddEnemy_Object___0__7X
		{
			get
			{
				if(r_ROnClickAddEnemy_Object___0__7X == null)
				{
					r_ROnClickAddEnemy_Object___0__7X = new(this, "OnClickAddEnemy", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickAddEnemy_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickAddEnemy_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickTrade(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickTrade_Object___0__7X;
		public virtual RMethod ROnClickTrade_Object___0__7X
		{
			get
			{
				if(r_ROnClickTrade_Object___0__7X == null)
				{
					r_ROnClickTrade_Object___0__7X = new(this, "OnClickTrade", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickTrade_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickTrade_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickCopyName(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickCopyName_Object___0__7X;
		public virtual RMethod ROnClickCopyName_Object___0__7X
		{
			get
			{
				if(r_ROnClickCopyName_Object___0__7X == null)
				{
					r_ROnClickCopyName_Object___0__7X = new(this, "OnClickCopyName", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickCopyName_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickCopyName_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickDuetHorse(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickDuetHorse_Object___0__7X;
		public virtual RMethod ROnClickDuetHorse_Object___0__7X
		{
			get
			{
				if(r_ROnClickDuetHorse_Object___0__7X == null)
				{
					r_ROnClickDuetHorse_Object___0__7X = new(this, "OnClickDuetHorse", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickDuetHorse_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickDuetHorse_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickCheckAttri(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickCheckAttri_Object___0__7X;
		public virtual RMethod ROnClickCheckAttri_Object___0__7X
		{
			get
			{
				if(r_ROnClickCheckAttri_Object___0__7X == null)
				{
					r_ROnClickCheckAttri_Object___0__7X = new(this, "OnClickCheckAttri", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickCheckAttri_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickCheckAttri_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickWndChat(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickWndChat_Object___0__7X;
		public virtual RMethod ROnClickWndChat_Object___0__7X
		{
			get
			{
				if(r_ROnClickWndChat_Object___0__7X == null)
				{
					r_ROnClickWndChat_Object___0__7X = new(this, "OnClickWndChat", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickWndChat_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickWndChat_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickPrivateChat(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickPrivateChat_Object___0__7X;
		public virtual RMethod ROnClickPrivateChat_Object___0__7X
		{
			get
			{
				if(r_ROnClickPrivateChat_Object___0__7X == null)
				{
					r_ROnClickPrivateChat_Object___0__7X = new(this, "OnClickPrivateChat", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickPrivateChat_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickPrivateChat_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickAutoFind(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickAutoFind_Object___0__7X;
		public virtual RMethod ROnClickAutoFind_Object___0__7X
		{
			get
			{
				if(r_ROnClickAutoFind_Object___0__7X == null)
				{
					r_ROnClickAutoFind_Object___0__7X = new(this, "OnClickAutoFind", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickAutoFind_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickAutoFind_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickInviteProtection(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickInviteProtection_Object___0__7X;
		public virtual RMethod ROnClickInviteProtection_Object___0__7X
		{
			get
			{
				if(r_ROnClickInviteProtection_Object___0__7X == null)
				{
					r_ROnClickInviteProtection_Object___0__7X = new(this, "OnClickInviteProtection", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickInviteProtection_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickInviteProtection_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickStopProtection(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickStopProtection_Object___0__7X;
		public virtual RMethod ROnClickStopProtection_Object___0__7X
		{
			get
			{
				if(r_ROnClickStopProtection_Object___0__7X == null)
				{
					r_ROnClickStopProtection_Object___0__7X = new(this, "OnClickStopProtection", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickStopProtection_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickStopProtection_Object___0__7X;
			}
		}

		/// <summary>
		/// Void OnClickInvitePK(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnClickInvitePK_Object___0__7X;
		public virtual RMethod ROnClickInvitePK_Object___0__7X
		{
			get
			{
				if(r_ROnClickInvitePK_Object___0__7X == null)
				{
					r_ROnClickInvitePK_Object___0__7X = new(this, "OnClickInvitePK", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnClickInvitePK_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnClickInvitePK_Object___0__7X;
			}
		}

		/// <summary>
		/// Void ShowTargetMenuArena3D(GameDefineType.ID, Boolean, System.String)
		/// </summary>
		protected RMethod r_RShowTargetMenuArena3D_ID_Boolean_String;
		public virtual RMethod RShowTargetMenuArena3D_ID_Boolean_String
		{
			get
			{
				if(r_RShowTargetMenuArena3D_ID_Boolean_String == null)
				{
					r_RShowTargetMenuArena3D_ID_Boolean_String = new(this, "ShowTargetMenuArena3D", 0, typeof(GameDefineType.ID), typeof(System.Boolean), typeof(System.String));
					r_RShowTargetMenuArena3D_ID_Boolean_String.SetBelong(this.instance);
				}
				return r_RShowTargetMenuArena3D_ID_Boolean_String;
			}
		}

		/// <summary>
		/// Void ShowTargetMenuPKOfflinePlayer(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RShowTargetMenuPKOfflinePlayer_ID;
		public virtual RMethod RShowTargetMenuPKOfflinePlayer_ID
		{
			get
			{
				if(r_RShowTargetMenuPKOfflinePlayer_ID == null)
				{
					r_RShowTargetMenuPKOfflinePlayer_ID = new(this, "ShowTargetMenuPKOfflinePlayer", 0, typeof(GameDefineType.ID));
					r_RShowTargetMenuPKOfflinePlayer_ID.SetBelong(this.instance);
				}
				return r_RShowTargetMenuPKOfflinePlayer_ID;
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


        public RTargetMenu() : base("TargetMenu")
        {
        }

        public RTargetMenu(System.Object instance) : base("TargetMenu")
		{
            SetInstance(instance);
		}

        public RTargetMenu(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTargetMenu(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ShowTargetMenu(GameDefineType.ID  @targetID, System.Boolean  @bFromChat, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetID, @bFromChat, @name};
            var ___result = RShowTargetMenu_ID_Boolean_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }






















        public virtual void ShowTargetMenuArena3D(GameDefineType.ID  @targetID, System.Boolean  @bFromChat, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetID, @bFromChat, @name};
            var ___result = RShowTargetMenuArena3D_ID_Boolean_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTargetMenuPKOfflinePlayer(GameDefineType.ID  @targetID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetID};
            var ___result = RShowTargetMenuPKOfflinePlayer_ID.Invoke(___genericsType, ___parameters);

            
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
