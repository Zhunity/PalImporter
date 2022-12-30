using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NotifyMessageTemplate
	/// </summary>
    public partial class RNotifyMessageTemplate : RMember //
    {

		/// <summary>
		/// KeyValueContent notifyMessageTemplate
		/// </summary>
		protected RKeyValueContent r_notifyMessageTemplate;
		public virtual RKeyValueContent RnotifyMessageTemplate
		{
			get
			{
				if(r_notifyMessageTemplate == null)
				{
					r_notifyMessageTemplate = new(this, "notifyMessageTemplate");
					r_notifyMessageTemplate.SetBelong(this.instance);
				}
				return r_notifyMessageTemplate;
			}
		}

		/// <summary>
		/// System.String FlagName
		/// </summary>
		protected RField r_FlagName;
		public virtual RField RFlagName
		{
			get
			{
				if(r_FlagName == null)
				{
					r_FlagName = new(this, "FlagName");
					r_FlagName.SetBelong(this.instance);
				}
				return r_FlagName;
			}
		}

		/// <summary>
		/// System.String FormatName
		/// </summary>
		protected RField r_FormatName;
		public virtual RField RFormatName
		{
			get
			{
				if(r_FormatName == null)
				{
					r_FormatName = new(this, "FormatName");
					r_FormatName.SetBelong(this.instance);
				}
				return r_FormatName;
			}
		}

		/// <summary>
		/// System.String TVFormatName
		/// </summary>
		protected RField r_TVFormatName;
		public virtual RField RTVFormatName
		{
			get
			{
				if(r_TVFormatName == null)
				{
					r_TVFormatName = new(this, "TVFormatName");
					r_TVFormatName.SetBelong(this.instance);
				}
				return r_TVFormatName;
			}
		}

		/// <summary>
		/// System.String KingSecretary
		/// </summary>
		protected RField r_KingSecretary;
		public virtual RField RKingSecretary
		{
			get
			{
				if(r_KingSecretary == null)
				{
					r_KingSecretary = new(this, "KingSecretary");
					r_KingSecretary.SetBelong(this.instance);
				}
				return r_KingSecretary;
			}
		}

		/// <summary>
		/// System.String[] ChannelName
		/// </summary>
		protected RFieldArray<RField> r_ChannelName;
		public virtual RFieldArray<RField> RChannelName
		{
			get
			{
				if(r_ChannelName == null)
				{
					r_ChannelName = new(this, "ChannelName");
					r_ChannelName.SetBelong(this.instance);
				}
				return r_ChannelName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.List`1[CHAT_CHANNEL]] _messageIDChannel
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RField>> r__messageIDChannel;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RField>> R_messageIDChannel
		{
			get
			{
				if(r__messageIDChannel == null)
				{
					r__messageIDChannel = new(this, "_messageIDChannel");
					r__messageIDChannel.SetBelong(this.instance);
				}
				return r__messageIDChannel;
			}
		}

		/// <summary>
		/// System.String notifyConfig
		/// </summary>
		protected RField r_notifyConfig;
		public virtual RField RnotifyConfig
		{
			get
			{
				if(r_notifyConfig == null)
				{
					r_notifyConfig = new(this, "notifyConfig");
					r_notifyConfig.SetBelong(this.instance);
				}
				return r_notifyConfig;
			}
		}

		/// <summary>
		/// Void OnLoadNitifyMessageTemplateConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadNitifyMessageTemplateConfig_Object;
		public virtual RMethod ROnLoadNitifyMessageTemplateConfig_Object
		{
			get
			{
				if(r_ROnLoadNitifyMessageTemplateConfig_Object == null)
				{
					r_ROnLoadNitifyMessageTemplateConfig_Object = new(this, "OnLoadNitifyMessageTemplateConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadNitifyMessageTemplateConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadNitifyMessageTemplateConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadNitifyMessageTemplateConfigNewThread()
		/// </summary>
		protected RMethod r_ROnLoadNitifyMessageTemplateConfigNewThread;
		public virtual RMethod ROnLoadNitifyMessageTemplateConfigNewThread
		{
			get
			{
				if(r_ROnLoadNitifyMessageTemplateConfigNewThread == null)
				{
					r_ROnLoadNitifyMessageTemplateConfigNewThread = new(this, "OnLoadNitifyMessageTemplateConfigNewThread", 0);
					r_ROnLoadNitifyMessageTemplateConfigNewThread.SetBelong(this.instance);
				}
				return r_ROnLoadNitifyMessageTemplateConfigNewThread;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[CHAT_CHANNEL] GetMessageChannel(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetMessageChannel_ID;
		public virtual RMethod RGetMessageChannel_ID
		{
			get
			{
				if(r_RGetMessageChannel_ID == null)
				{
					r_RGetMessageChannel_ID = new(this, "GetMessageChannel", 0, typeof(GameDefineType.ID));
					r_RGetMessageChannel_ID.SetBelong(this.instance);
				}
				return r_RGetMessageChannel_ID;
			}
		}

		/// <summary>
		/// System.String GetMessageFormat(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetMessageFormat_ID;
		public virtual RMethod RGetMessageFormat_ID
		{
			get
			{
				if(r_RGetMessageFormat_ID == null)
				{
					r_RGetMessageFormat_ID = new(this, "GetMessageFormat", 0, typeof(GameDefineType.ID));
					r_RGetMessageFormat_ID.SetBelong(this.instance);
				}
				return r_RGetMessageFormat_ID;
			}
		}

		/// <summary>
		/// System.String GetMessageFormat(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetMessageFormat_ID_String;
		public virtual RMethod RGetMessageFormat_ID_String
		{
			get
			{
				if(r_RGetMessageFormat_ID_String == null)
				{
					r_RGetMessageFormat_ID_String = new(this, "GetMessageFormat", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetMessageFormat_ID_String.SetBelong(this.instance);
				}
				return r_RGetMessageFormat_ID_String;
			}
		}

		/// <summary>
		/// System.String GetChannelName(CHAT_CHANNEL)
		/// </summary>
		protected RMethod r_RGetChannelName_CHAT_CHANNEL;
		public virtual RMethod RGetChannelName_CHAT_CHANNEL
		{
			get
			{
				if(r_RGetChannelName_CHAT_CHANNEL == null)
				{
					r_RGetChannelName_CHAT_CHANNEL = new(this, "GetChannelName", 0,  ReleactionUtils.GetType("CHAT_CHANNEL"));
					r_RGetChannelName_CHAT_CHANNEL.SetBelong(this.instance);
				}
				return r_RGetChannelName_CHAT_CHANNEL;
			}
		}

		/// <summary>
		/// Void OnGetKeyValueNotify(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnGetKeyValueNotify_Object___0__i8;
		public virtual RMethod ROnGetKeyValueNotify_Object___0__i8
		{
			get
			{
				if(r_ROnGetKeyValueNotify_Object___0__i8 == null)
				{
					r_ROnGetKeyValueNotify_Object___0__i8 = new(this, "OnGetKeyValueNotify", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnGetKeyValueNotify_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnGetKeyValueNotify_Object___0__i8;
			}
		}

		/// <summary>
		/// Void OnGetRootAttributes(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnGetRootAttributes_Object___0__i8;
		public virtual RMethod ROnGetRootAttributes_Object___0__i8
		{
			get
			{
				if(r_ROnGetRootAttributes_Object___0__i8 == null)
				{
					r_ROnGetRootAttributes_Object___0__i8 = new(this, "OnGetRootAttributes", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnGetRootAttributes_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnGetRootAttributes_Object___0__i8;
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


        public RNotifyMessageTemplate() : base("NotifyMessageTemplate")
        {
        }

        public RNotifyMessageTemplate(System.Object instance) : base("NotifyMessageTemplate")
		{
            SetInstance(instance);
		}

        public RNotifyMessageTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNotifyMessageTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadNitifyMessageTemplateConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadNitifyMessageTemplateConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadNitifyMessageTemplateConfigNewThread()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnLoadNitifyMessageTemplateConfigNewThread.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetMessageChannel(GameDefineType.ID  @messageID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@messageID};
            var ___result = RGetMessageChannel_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetMessageFormat(GameDefineType.ID  @messageID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@messageID};
            var ___result = RGetMessageFormat_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetMessageFormat(GameDefineType.ID  @messageID, System.String  @m_formationName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@messageID, @m_formationName};
            var ___result = RGetMessageFormat_ID_String.Invoke(___genericsType, ___parameters);

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
