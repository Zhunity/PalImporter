using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.UriParser
	/// </summary>
    public partial class RUriParser : RMember //
    {

		/// <summary>
		/// System.UriSyntaxFlags SchemeOnlyFlags
		/// </summary>
		protected static RField r_SchemeOnlyFlags;
		public static RField RSchemeOnlyFlags
		{
			get
			{
				if(r_SchemeOnlyFlags == null)
				{
					r_SchemeOnlyFlags = new(typeof(System.UriParser), "SchemeOnlyFlags");
					r_SchemeOnlyFlags.SetBelong(null);
				}
				return r_SchemeOnlyFlags;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.UriParser] m_Table
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RUriParser> r_m_Table;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RUriParser> Rm_Table
		{
			get
			{
				if(r_m_Table == null)
				{
					r_m_Table = new(typeof(System.UriParser), "m_Table");
					r_m_Table.SetBelong(null);
				}
				return r_m_Table;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.UriParser] m_TempTable
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RUriParser> r_m_TempTable;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RUriParser> Rm_TempTable
		{
			get
			{
				if(r_m_TempTable == null)
				{
					r_m_TempTable = new(typeof(System.UriParser), "m_TempTable");
					r_m_TempTable.SetBelong(null);
				}
				return r_m_TempTable;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags m_Flags
		/// </summary>
		protected RField r_m_Flags;
		public virtual RField Rm_Flags
		{
			get
			{
				if(r_m_Flags == null)
				{
					r_m_Flags = new(this, "m_Flags");
					r_m_Flags.SetBelong(this.instance);
				}
				return r_m_Flags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags m_UpdatableFlags
		/// </summary>
		protected RField r_m_UpdatableFlags;
		public virtual RField Rm_UpdatableFlags
		{
			get
			{
				if(r_m_UpdatableFlags == null)
				{
					r_m_UpdatableFlags = new(this, "m_UpdatableFlags");
					r_m_UpdatableFlags.SetBelong(this.instance);
				}
				return r_m_UpdatableFlags;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdatableFlagsUsed
		/// </summary>
		protected RField r_m_UpdatableFlagsUsed;
		public virtual RField Rm_UpdatableFlagsUsed
		{
			get
			{
				if(r_m_UpdatableFlagsUsed == null)
				{
					r_m_UpdatableFlagsUsed = new(this, "m_UpdatableFlagsUsed");
					r_m_UpdatableFlagsUsed.SetBelong(this.instance);
				}
				return r_m_UpdatableFlagsUsed;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags c_UpdatableFlags
		/// </summary>
		protected static RField r_c_UpdatableFlags;
		public static RField Rc_UpdatableFlags
		{
			get
			{
				if(r_c_UpdatableFlags == null)
				{
					r_c_UpdatableFlags = new(typeof(System.UriParser), "c_UpdatableFlags");
					r_c_UpdatableFlags.SetBelong(null);
				}
				return r_c_UpdatableFlags;
			}
		}

		/// <summary>
		/// System.Int32 m_Port
		/// </summary>
		protected RField r_m_Port;
		public virtual RField Rm_Port
		{
			get
			{
				if(r_m_Port == null)
				{
					r_m_Port = new(this, "m_Port");
					r_m_Port.SetBelong(this.instance);
				}
				return r_m_Port;
			}
		}

		/// <summary>
		/// System.String m_Scheme
		/// </summary>
		protected RField r_m_Scheme;
		public virtual RField Rm_Scheme
		{
			get
			{
				if(r_m_Scheme == null)
				{
					r_m_Scheme = new(this, "m_Scheme");
					r_m_Scheme.SetBelong(this.instance);
				}
				return r_m_Scheme;
			}
		}

		/// <summary>
		/// System.Int32 NoDefaultPort
		/// </summary>
		protected static RField r_NoDefaultPort;
		public static RField RNoDefaultPort
		{
			get
			{
				if(r_NoDefaultPort == null)
				{
					r_NoDefaultPort = new(typeof(System.UriParser), "NoDefaultPort");
					r_NoDefaultPort.SetBelong(null);
				}
				return r_NoDefaultPort;
			}
		}

		/// <summary>
		/// System.Int32 c_InitialTableSize
		/// </summary>
		protected static RField r_c_InitialTableSize;
		public static RField Rc_InitialTableSize
		{
			get
			{
				if(r_c_InitialTableSize == null)
				{
					r_c_InitialTableSize = new(typeof(System.UriParser), "c_InitialTableSize");
					r_c_InitialTableSize.SetBelong(null);
				}
				return r_c_InitialTableSize;
			}
		}

		/// <summary>
		/// System.UriParser HttpUri
		/// </summary>
		protected static RSystem.RUriParser r_HttpUri;
		public static RSystem.RUriParser RHttpUri
		{
			get
			{
				if(r_HttpUri == null)
				{
					r_HttpUri = new(typeof(System.UriParser), "HttpUri");
					r_HttpUri.SetBelong(null);
				}
				return r_HttpUri;
			}
		}

		/// <summary>
		/// System.UriParser HttpsUri
		/// </summary>
		protected static RSystem.RUriParser r_HttpsUri;
		public static RSystem.RUriParser RHttpsUri
		{
			get
			{
				if(r_HttpsUri == null)
				{
					r_HttpsUri = new(typeof(System.UriParser), "HttpsUri");
					r_HttpsUri.SetBelong(null);
				}
				return r_HttpsUri;
			}
		}

		/// <summary>
		/// System.UriParser WsUri
		/// </summary>
		protected static RSystem.RUriParser r_WsUri;
		public static RSystem.RUriParser RWsUri
		{
			get
			{
				if(r_WsUri == null)
				{
					r_WsUri = new(typeof(System.UriParser), "WsUri");
					r_WsUri.SetBelong(null);
				}
				return r_WsUri;
			}
		}

		/// <summary>
		/// System.UriParser WssUri
		/// </summary>
		protected static RSystem.RUriParser r_WssUri;
		public static RSystem.RUriParser RWssUri
		{
			get
			{
				if(r_WssUri == null)
				{
					r_WssUri = new(typeof(System.UriParser), "WssUri");
					r_WssUri.SetBelong(null);
				}
				return r_WssUri;
			}
		}

		/// <summary>
		/// System.UriParser FtpUri
		/// </summary>
		protected static RSystem.RUriParser r_FtpUri;
		public static RSystem.RUriParser RFtpUri
		{
			get
			{
				if(r_FtpUri == null)
				{
					r_FtpUri = new(typeof(System.UriParser), "FtpUri");
					r_FtpUri.SetBelong(null);
				}
				return r_FtpUri;
			}
		}

		/// <summary>
		/// System.UriParser FileUri
		/// </summary>
		protected static RSystem.RUriParser r_FileUri;
		public static RSystem.RUriParser RFileUri
		{
			get
			{
				if(r_FileUri == null)
				{
					r_FileUri = new(typeof(System.UriParser), "FileUri");
					r_FileUri.SetBelong(null);
				}
				return r_FileUri;
			}
		}

		/// <summary>
		/// System.UriParser GopherUri
		/// </summary>
		protected static RSystem.RUriParser r_GopherUri;
		public static RSystem.RUriParser RGopherUri
		{
			get
			{
				if(r_GopherUri == null)
				{
					r_GopherUri = new(typeof(System.UriParser), "GopherUri");
					r_GopherUri.SetBelong(null);
				}
				return r_GopherUri;
			}
		}

		/// <summary>
		/// System.UriParser NntpUri
		/// </summary>
		protected static RSystem.RUriParser r_NntpUri;
		public static RSystem.RUriParser RNntpUri
		{
			get
			{
				if(r_NntpUri == null)
				{
					r_NntpUri = new(typeof(System.UriParser), "NntpUri");
					r_NntpUri.SetBelong(null);
				}
				return r_NntpUri;
			}
		}

		/// <summary>
		/// System.UriParser NewsUri
		/// </summary>
		protected static RSystem.RUriParser r_NewsUri;
		public static RSystem.RUriParser RNewsUri
		{
			get
			{
				if(r_NewsUri == null)
				{
					r_NewsUri = new(typeof(System.UriParser), "NewsUri");
					r_NewsUri.SetBelong(null);
				}
				return r_NewsUri;
			}
		}

		/// <summary>
		/// System.UriParser MailToUri
		/// </summary>
		protected static RSystem.RUriParser r_MailToUri;
		public static RSystem.RUriParser RMailToUri
		{
			get
			{
				if(r_MailToUri == null)
				{
					r_MailToUri = new(typeof(System.UriParser), "MailToUri");
					r_MailToUri.SetBelong(null);
				}
				return r_MailToUri;
			}
		}

		/// <summary>
		/// System.UriParser UuidUri
		/// </summary>
		protected static RSystem.RUriParser r_UuidUri;
		public static RSystem.RUriParser RUuidUri
		{
			get
			{
				if(r_UuidUri == null)
				{
					r_UuidUri = new(typeof(System.UriParser), "UuidUri");
					r_UuidUri.SetBelong(null);
				}
				return r_UuidUri;
			}
		}

		/// <summary>
		/// System.UriParser TelnetUri
		/// </summary>
		protected static RSystem.RUriParser r_TelnetUri;
		public static RSystem.RUriParser RTelnetUri
		{
			get
			{
				if(r_TelnetUri == null)
				{
					r_TelnetUri = new(typeof(System.UriParser), "TelnetUri");
					r_TelnetUri.SetBelong(null);
				}
				return r_TelnetUri;
			}
		}

		/// <summary>
		/// System.UriParser LdapUri
		/// </summary>
		protected static RSystem.RUriParser r_LdapUri;
		public static RSystem.RUriParser RLdapUri
		{
			get
			{
				if(r_LdapUri == null)
				{
					r_LdapUri = new(typeof(System.UriParser), "LdapUri");
					r_LdapUri.SetBelong(null);
				}
				return r_LdapUri;
			}
		}

		/// <summary>
		/// System.UriParser NetTcpUri
		/// </summary>
		protected static RSystem.RUriParser r_NetTcpUri;
		public static RSystem.RUriParser RNetTcpUri
		{
			get
			{
				if(r_NetTcpUri == null)
				{
					r_NetTcpUri = new(typeof(System.UriParser), "NetTcpUri");
					r_NetTcpUri.SetBelong(null);
				}
				return r_NetTcpUri;
			}
		}

		/// <summary>
		/// System.UriParser NetPipeUri
		/// </summary>
		protected static RSystem.RUriParser r_NetPipeUri;
		public static RSystem.RUriParser RNetPipeUri
		{
			get
			{
				if(r_NetPipeUri == null)
				{
					r_NetPipeUri = new(typeof(System.UriParser), "NetPipeUri");
					r_NetPipeUri.SetBelong(null);
				}
				return r_NetPipeUri;
			}
		}

		/// <summary>
		/// System.UriParser VsMacrosUri
		/// </summary>
		protected static RSystem.RUriParser r_VsMacrosUri;
		public static RSystem.RUriParser RVsMacrosUri
		{
			get
			{
				if(r_VsMacrosUri == null)
				{
					r_VsMacrosUri = new(typeof(System.UriParser), "VsMacrosUri");
					r_VsMacrosUri.SetBelong(null);
				}
				return r_VsMacrosUri;
			}
		}

		/// <summary>
		/// System.UriParser+UriQuirksVersion s_QuirksVersion
		/// </summary>
		protected static RField r_s_QuirksVersion;
		public static RField Rs_QuirksVersion
		{
			get
			{
				if(r_s_QuirksVersion == null)
				{
					r_s_QuirksVersion = new(typeof(System.UriParser), "s_QuirksVersion");
					r_s_QuirksVersion.SetBelong(null);
				}
				return r_s_QuirksVersion;
			}
		}

		/// <summary>
		/// System.Int32 c_MaxCapacity
		/// </summary>
		protected static RField r_c_MaxCapacity;
		public static RField Rc_MaxCapacity
		{
			get
			{
				if(r_c_MaxCapacity == null)
				{
					r_c_MaxCapacity = new(typeof(System.UriParser), "c_MaxCapacity");
					r_c_MaxCapacity.SetBelong(null);
				}
				return r_c_MaxCapacity;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags UnknownV1SyntaxFlags
		/// </summary>
		protected static RField r_UnknownV1SyntaxFlags;
		public static RField RUnknownV1SyntaxFlags
		{
			get
			{
				if(r_UnknownV1SyntaxFlags == null)
				{
					r_UnknownV1SyntaxFlags = new(typeof(System.UriParser), "UnknownV1SyntaxFlags");
					r_UnknownV1SyntaxFlags.SetBelong(null);
				}
				return r_UnknownV1SyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags HttpSyntaxFlags
		/// </summary>
		protected static RField r_HttpSyntaxFlags;
		public static RField RHttpSyntaxFlags
		{
			get
			{
				if(r_HttpSyntaxFlags == null)
				{
					r_HttpSyntaxFlags = new(typeof(System.UriParser), "HttpSyntaxFlags");
					r_HttpSyntaxFlags.SetBelong(null);
				}
				return r_HttpSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags FtpSyntaxFlags
		/// </summary>
		protected static RField r_FtpSyntaxFlags;
		public static RField RFtpSyntaxFlags
		{
			get
			{
				if(r_FtpSyntaxFlags == null)
				{
					r_FtpSyntaxFlags = new(typeof(System.UriParser), "FtpSyntaxFlags");
					r_FtpSyntaxFlags.SetBelong(null);
				}
				return r_FtpSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags FileSyntaxFlags
		/// </summary>
		protected static RField r_FileSyntaxFlags;
		public static RField RFileSyntaxFlags
		{
			get
			{
				if(r_FileSyntaxFlags == null)
				{
					r_FileSyntaxFlags = new(typeof(System.UriParser), "FileSyntaxFlags");
					r_FileSyntaxFlags.SetBelong(null);
				}
				return r_FileSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags VsmacrosSyntaxFlags
		/// </summary>
		protected static RField r_VsmacrosSyntaxFlags;
		public static RField RVsmacrosSyntaxFlags
		{
			get
			{
				if(r_VsmacrosSyntaxFlags == null)
				{
					r_VsmacrosSyntaxFlags = new(typeof(System.UriParser), "VsmacrosSyntaxFlags");
					r_VsmacrosSyntaxFlags.SetBelong(null);
				}
				return r_VsmacrosSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags GopherSyntaxFlags
		/// </summary>
		protected static RField r_GopherSyntaxFlags;
		public static RField RGopherSyntaxFlags
		{
			get
			{
				if(r_GopherSyntaxFlags == null)
				{
					r_GopherSyntaxFlags = new(typeof(System.UriParser), "GopherSyntaxFlags");
					r_GopherSyntaxFlags.SetBelong(null);
				}
				return r_GopherSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags NewsSyntaxFlags
		/// </summary>
		protected static RField r_NewsSyntaxFlags;
		public static RField RNewsSyntaxFlags
		{
			get
			{
				if(r_NewsSyntaxFlags == null)
				{
					r_NewsSyntaxFlags = new(typeof(System.UriParser), "NewsSyntaxFlags");
					r_NewsSyntaxFlags.SetBelong(null);
				}
				return r_NewsSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags NntpSyntaxFlags
		/// </summary>
		protected static RField r_NntpSyntaxFlags;
		public static RField RNntpSyntaxFlags
		{
			get
			{
				if(r_NntpSyntaxFlags == null)
				{
					r_NntpSyntaxFlags = new(typeof(System.UriParser), "NntpSyntaxFlags");
					r_NntpSyntaxFlags.SetBelong(null);
				}
				return r_NntpSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags TelnetSyntaxFlags
		/// </summary>
		protected static RField r_TelnetSyntaxFlags;
		public static RField RTelnetSyntaxFlags
		{
			get
			{
				if(r_TelnetSyntaxFlags == null)
				{
					r_TelnetSyntaxFlags = new(typeof(System.UriParser), "TelnetSyntaxFlags");
					r_TelnetSyntaxFlags.SetBelong(null);
				}
				return r_TelnetSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags LdapSyntaxFlags
		/// </summary>
		protected static RField r_LdapSyntaxFlags;
		public static RField RLdapSyntaxFlags
		{
			get
			{
				if(r_LdapSyntaxFlags == null)
				{
					r_LdapSyntaxFlags = new(typeof(System.UriParser), "LdapSyntaxFlags");
					r_LdapSyntaxFlags.SetBelong(null);
				}
				return r_LdapSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags MailtoSyntaxFlags
		/// </summary>
		protected static RField r_MailtoSyntaxFlags;
		public static RField RMailtoSyntaxFlags
		{
			get
			{
				if(r_MailtoSyntaxFlags == null)
				{
					r_MailtoSyntaxFlags = new(typeof(System.UriParser), "MailtoSyntaxFlags");
					r_MailtoSyntaxFlags.SetBelong(null);
				}
				return r_MailtoSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags NetPipeSyntaxFlags
		/// </summary>
		protected static RField r_NetPipeSyntaxFlags;
		public static RField RNetPipeSyntaxFlags
		{
			get
			{
				if(r_NetPipeSyntaxFlags == null)
				{
					r_NetPipeSyntaxFlags = new(typeof(System.UriParser), "NetPipeSyntaxFlags");
					r_NetPipeSyntaxFlags.SetBelong(null);
				}
				return r_NetPipeSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags NetTcpSyntaxFlags
		/// </summary>
		protected static RField r_NetTcpSyntaxFlags;
		public static RField RNetTcpSyntaxFlags
		{
			get
			{
				if(r_NetTcpSyntaxFlags == null)
				{
					r_NetTcpSyntaxFlags = new(typeof(System.UriParser), "NetTcpSyntaxFlags");
					r_NetTcpSyntaxFlags.SetBelong(null);
				}
				return r_NetTcpSyntaxFlags;
			}
		}

		/// <summary>
		/// System.String SchemeName
		/// </summary>
		protected RProperty r_SchemeName;
		public virtual RProperty RSchemeName
		{
			get
			{
				if(r_SchemeName == null)
				{
					r_SchemeName = new(this, "SchemeName", -1);
					r_SchemeName.SetBelong(this.instance);
				}
				return r_SchemeName;
			}
		}

		/// <summary>
		/// Int32 DefaultPort
		/// </summary>
		protected RProperty r_DefaultPort;
		public virtual RProperty RDefaultPort
		{
			get
			{
				if(r_DefaultPort == null)
				{
					r_DefaultPort = new(this, "DefaultPort", -1);
					r_DefaultPort.SetBelong(this.instance);
				}
				return r_DefaultPort;
			}
		}

		/// <summary>
		/// Boolean ShouldUseLegacyV2Quirks
		/// </summary>
		protected static RProperty r_ShouldUseLegacyV2Quirks;
		public static RProperty RShouldUseLegacyV2Quirks
		{
			get
			{
				if(r_ShouldUseLegacyV2Quirks == null)
				{
					r_ShouldUseLegacyV2Quirks = new(typeof(System.UriParser), "ShouldUseLegacyV2Quirks", -1);
					r_ShouldUseLegacyV2Quirks.SetBelong(null);
				}
				return r_ShouldUseLegacyV2Quirks;
			}
		}

		/// <summary>
		/// System.UriSyntaxFlags Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
			}
		}

		/// <summary>
		/// Boolean IsSimple
		/// </summary>
		protected RProperty r_IsSimple;
		public virtual RProperty RIsSimple
		{
			get
			{
				if(r_IsSimple == null)
				{
					r_IsSimple = new(this, "IsSimple", -1);
					r_IsSimple.SetBelong(this.instance);
				}
				return r_IsSimple;
			}
		}

		/// <summary>
		/// System.UriParser OnNewUri()
		/// </summary>
		protected RMethod r_ROnNewUri;
		public virtual RMethod ROnNewUri
		{
			get
			{
				if(r_ROnNewUri == null)
				{
					r_ROnNewUri = new(this, "OnNewUri", 0);
					r_ROnNewUri.SetBelong(this.instance);
				}
				return r_ROnNewUri;
			}
		}

		/// <summary>
		/// Void OnRegister(System.String, Int32)
		/// </summary>
		protected RMethod r_ROnRegister_String_Int32;
		public virtual RMethod ROnRegister_String_Int32
		{
			get
			{
				if(r_ROnRegister_String_Int32 == null)
				{
					r_ROnRegister_String_Int32 = new(this, "OnRegister", 0, typeof(System.String), typeof(System.Int32));
					r_ROnRegister_String_Int32.SetBelong(this.instance);
				}
				return r_ROnRegister_String_Int32;
			}
		}

		/// <summary>
		/// Void InitializeAndValidate(System.Uri, System.UriFormatException ByRef)
		/// </summary>
		protected RMethod r_RInitializeAndValidate_Uri_Out_UriFormatException;
		public virtual RMethod RInitializeAndValidate_Uri_Out_UriFormatException
		{
			get
			{
				if(r_RInitializeAndValidate_Uri_Out_UriFormatException == null)
				{
					r_RInitializeAndValidate_Uri_Out_UriFormatException = new(this, "InitializeAndValidate", 0, typeof(System.Uri), typeof(System.UriFormatException).MakeByRefType());
					r_RInitializeAndValidate_Uri_Out_UriFormatException.SetBelong(this.instance);
				}
				return r_RInitializeAndValidate_Uri_Out_UriFormatException;
			}
		}

		/// <summary>
		/// System.String Resolve(System.Uri, System.Uri, System.UriFormatException ByRef)
		/// </summary>
		protected RMethod r_RResolve_Uri_Uri_Out_UriFormatException;
		public virtual RMethod RResolve_Uri_Uri_Out_UriFormatException
		{
			get
			{
				if(r_RResolve_Uri_Uri_Out_UriFormatException == null)
				{
					r_RResolve_Uri_Uri_Out_UriFormatException = new(this, "Resolve", 0, typeof(System.Uri), typeof(System.Uri), typeof(System.UriFormatException).MakeByRefType());
					r_RResolve_Uri_Uri_Out_UriFormatException.SetBelong(this.instance);
				}
				return r_RResolve_Uri_Uri_Out_UriFormatException;
			}
		}

		/// <summary>
		/// Boolean IsBaseOf(System.Uri, System.Uri)
		/// </summary>
		protected RMethod r_RIsBaseOf_Uri_Uri;
		public virtual RMethod RIsBaseOf_Uri_Uri
		{
			get
			{
				if(r_RIsBaseOf_Uri_Uri == null)
				{
					r_RIsBaseOf_Uri_Uri = new(this, "IsBaseOf", 0, typeof(System.Uri), typeof(System.Uri));
					r_RIsBaseOf_Uri_Uri.SetBelong(this.instance);
				}
				return r_RIsBaseOf_Uri_Uri;
			}
		}

		/// <summary>
		/// System.String GetComponents(System.Uri, System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetComponents_Uri_UriComponents_UriFormat;
		public virtual RMethod RGetComponents_Uri_UriComponents_UriFormat
		{
			get
			{
				if(r_RGetComponents_Uri_UriComponents_UriFormat == null)
				{
					r_RGetComponents_Uri_UriComponents_UriFormat = new(this, "GetComponents", 0, typeof(System.Uri), typeof(System.UriComponents), typeof(System.UriFormat));
					r_RGetComponents_Uri_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RGetComponents_Uri_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// Boolean IsWellFormedOriginalString(System.Uri)
		/// </summary>
		protected RMethod r_RIsWellFormedOriginalString_Uri;
		public virtual RMethod RIsWellFormedOriginalString_Uri
		{
			get
			{
				if(r_RIsWellFormedOriginalString_Uri == null)
				{
					r_RIsWellFormedOriginalString_Uri = new(this, "IsWellFormedOriginalString", 0, typeof(System.Uri));
					r_RIsWellFormedOriginalString_Uri.SetBelong(this.instance);
				}
				return r_RIsWellFormedOriginalString_Uri;
			}
		}

		/// <summary>
		/// Void Register(System.UriParser, System.String, Int32)
		/// </summary>
		protected static RMethod r_RRegister_UriParser_String_Int32;
		public static RMethod RRegister_UriParser_String_Int32
		{
			get
			{
				if(r_RRegister_UriParser_String_Int32 == null)
				{
					r_RRegister_UriParser_String_Int32 = new(typeof(System.UriParser), "Register", 0, typeof(System.UriParser), typeof(System.String), typeof(System.Int32));
					r_RRegister_UriParser_String_Int32.SetBelong(null);
				}
				return r_RRegister_UriParser_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsKnownScheme(System.String)
		/// </summary>
		protected static RMethod r_RIsKnownScheme_String;
		public static RMethod RIsKnownScheme_String
		{
			get
			{
				if(r_RIsKnownScheme_String == null)
				{
					r_RIsKnownScheme_String = new(typeof(System.UriParser), "IsKnownScheme", 0, typeof(System.String));
					r_RIsKnownScheme_String.SetBelong(null);
				}
				return r_RIsKnownScheme_String;
			}
		}

		/// <summary>
		/// Boolean NotAny(System.UriSyntaxFlags)
		/// </summary>
		protected RMethod r_RNotAny_UriSyntaxFlags;
		public virtual RMethod RNotAny_UriSyntaxFlags
		{
			get
			{
				if(r_RNotAny_UriSyntaxFlags == null)
				{
					r_RNotAny_UriSyntaxFlags = new(this, "NotAny", 0,  ReleactionUtils.GetType("System.UriSyntaxFlags"));
					r_RNotAny_UriSyntaxFlags.SetBelong(this.instance);
				}
				return r_RNotAny_UriSyntaxFlags;
			}
		}

		/// <summary>
		/// Boolean InFact(System.UriSyntaxFlags)
		/// </summary>
		protected RMethod r_RInFact_UriSyntaxFlags;
		public virtual RMethod RInFact_UriSyntaxFlags
		{
			get
			{
				if(r_RInFact_UriSyntaxFlags == null)
				{
					r_RInFact_UriSyntaxFlags = new(this, "InFact", 0,  ReleactionUtils.GetType("System.UriSyntaxFlags"));
					r_RInFact_UriSyntaxFlags.SetBelong(this.instance);
				}
				return r_RInFact_UriSyntaxFlags;
			}
		}

		/// <summary>
		/// Boolean IsAllSet(System.UriSyntaxFlags)
		/// </summary>
		protected RMethod r_RIsAllSet_UriSyntaxFlags;
		public virtual RMethod RIsAllSet_UriSyntaxFlags
		{
			get
			{
				if(r_RIsAllSet_UriSyntaxFlags == null)
				{
					r_RIsAllSet_UriSyntaxFlags = new(this, "IsAllSet", 0,  ReleactionUtils.GetType("System.UriSyntaxFlags"));
					r_RIsAllSet_UriSyntaxFlags.SetBelong(this.instance);
				}
				return r_RIsAllSet_UriSyntaxFlags;
			}
		}

		/// <summary>
		/// Boolean IsFullMatch(System.UriSyntaxFlags, System.UriSyntaxFlags)
		/// </summary>
		protected RMethod r_RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags;
		public virtual RMethod RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags
		{
			get
			{
				if(r_RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags == null)
				{
					r_RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags = new(this, "IsFullMatch", 0,  ReleactionUtils.GetType("System.UriSyntaxFlags"),  ReleactionUtils.GetType("System.UriSyntaxFlags"));
					r_RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags.SetBelong(this.instance);
				}
				return r_RIsFullMatch_UriSyntaxFlags_UriSyntaxFlags;
			}
		}

		/// <summary>
		/// Void FetchSyntax(System.UriParser, System.String, Int32)
		/// </summary>
		protected static RMethod r_RFetchSyntax_UriParser_String_Int32;
		public static RMethod RFetchSyntax_UriParser_String_Int32
		{
			get
			{
				if(r_RFetchSyntax_UriParser_String_Int32 == null)
				{
					r_RFetchSyntax_UriParser_String_Int32 = new(typeof(System.UriParser), "FetchSyntax", 0, typeof(System.UriParser), typeof(System.String), typeof(System.Int32));
					r_RFetchSyntax_UriParser_String_Int32.SetBelong(null);
				}
				return r_RFetchSyntax_UriParser_String_Int32;
			}
		}

		/// <summary>
		/// System.UriParser FindOrFetchAsUnknownV1Syntax(System.String)
		/// </summary>
		protected static RMethod r_RFindOrFetchAsUnknownV1Syntax_String;
		public static RMethod RFindOrFetchAsUnknownV1Syntax_String
		{
			get
			{
				if(r_RFindOrFetchAsUnknownV1Syntax_String == null)
				{
					r_RFindOrFetchAsUnknownV1Syntax_String = new(typeof(System.UriParser), "FindOrFetchAsUnknownV1Syntax", 0, typeof(System.String));
					r_RFindOrFetchAsUnknownV1Syntax_String.SetBelong(null);
				}
				return r_RFindOrFetchAsUnknownV1Syntax_String;
			}
		}

		/// <summary>
		/// System.UriParser GetSyntax(System.String)
		/// </summary>
		protected static RMethod r_RGetSyntax_String;
		public static RMethod RGetSyntax_String
		{
			get
			{
				if(r_RGetSyntax_String == null)
				{
					r_RGetSyntax_String = new(typeof(System.UriParser), "GetSyntax", 0, typeof(System.String));
					r_RGetSyntax_String.SetBelong(null);
				}
				return r_RGetSyntax_String;
			}
		}

		/// <summary>
		/// Void CheckSetIsSimpleFlag()
		/// </summary>
		protected RMethod r_RCheckSetIsSimpleFlag;
		public virtual RMethod RCheckSetIsSimpleFlag
		{
			get
			{
				if(r_RCheckSetIsSimpleFlag == null)
				{
					r_RCheckSetIsSimpleFlag = new(this, "CheckSetIsSimpleFlag", 0);
					r_RCheckSetIsSimpleFlag.SetBelong(this.instance);
				}
				return r_RCheckSetIsSimpleFlag;
			}
		}

		/// <summary>
		/// Void SetUpdatableFlags(System.UriSyntaxFlags)
		/// </summary>
		protected RMethod r_RSetUpdatableFlags_UriSyntaxFlags;
		public virtual RMethod RSetUpdatableFlags_UriSyntaxFlags
		{
			get
			{
				if(r_RSetUpdatableFlags_UriSyntaxFlags == null)
				{
					r_RSetUpdatableFlags_UriSyntaxFlags = new(this, "SetUpdatableFlags", 0,  ReleactionUtils.GetType("System.UriSyntaxFlags"));
					r_RSetUpdatableFlags_UriSyntaxFlags.SetBelong(this.instance);
				}
				return r_RSetUpdatableFlags_UriSyntaxFlags;
			}
		}

		/// <summary>
		/// System.UriParser InternalOnNewUri()
		/// </summary>
		protected RMethod r_RInternalOnNewUri;
		public virtual RMethod RInternalOnNewUri
		{
			get
			{
				if(r_RInternalOnNewUri == null)
				{
					r_RInternalOnNewUri = new(this, "InternalOnNewUri", 0);
					r_RInternalOnNewUri.SetBelong(this.instance);
				}
				return r_RInternalOnNewUri;
			}
		}

		/// <summary>
		/// Void InternalValidate(System.Uri, System.UriFormatException ByRef)
		/// </summary>
		protected RMethod r_RInternalValidate_Uri_Out_UriFormatException;
		public virtual RMethod RInternalValidate_Uri_Out_UriFormatException
		{
			get
			{
				if(r_RInternalValidate_Uri_Out_UriFormatException == null)
				{
					r_RInternalValidate_Uri_Out_UriFormatException = new(this, "InternalValidate", 0, typeof(System.Uri), typeof(System.UriFormatException).MakeByRefType());
					r_RInternalValidate_Uri_Out_UriFormatException.SetBelong(this.instance);
				}
				return r_RInternalValidate_Uri_Out_UriFormatException;
			}
		}

		/// <summary>
		/// System.String InternalResolve(System.Uri, System.Uri, System.UriFormatException ByRef)
		/// </summary>
		protected RMethod r_RInternalResolve_Uri_Uri_Out_UriFormatException;
		public virtual RMethod RInternalResolve_Uri_Uri_Out_UriFormatException
		{
			get
			{
				if(r_RInternalResolve_Uri_Uri_Out_UriFormatException == null)
				{
					r_RInternalResolve_Uri_Uri_Out_UriFormatException = new(this, "InternalResolve", 0, typeof(System.Uri), typeof(System.Uri), typeof(System.UriFormatException).MakeByRefType());
					r_RInternalResolve_Uri_Uri_Out_UriFormatException.SetBelong(this.instance);
				}
				return r_RInternalResolve_Uri_Uri_Out_UriFormatException;
			}
		}

		/// <summary>
		/// Boolean InternalIsBaseOf(System.Uri, System.Uri)
		/// </summary>
		protected RMethod r_RInternalIsBaseOf_Uri_Uri;
		public virtual RMethod RInternalIsBaseOf_Uri_Uri
		{
			get
			{
				if(r_RInternalIsBaseOf_Uri_Uri == null)
				{
					r_RInternalIsBaseOf_Uri_Uri = new(this, "InternalIsBaseOf", 0, typeof(System.Uri), typeof(System.Uri));
					r_RInternalIsBaseOf_Uri_Uri.SetBelong(this.instance);
				}
				return r_RInternalIsBaseOf_Uri_Uri;
			}
		}

		/// <summary>
		/// System.String InternalGetComponents(System.Uri, System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RInternalGetComponents_Uri_UriComponents_UriFormat;
		public virtual RMethod RInternalGetComponents_Uri_UriComponents_UriFormat
		{
			get
			{
				if(r_RInternalGetComponents_Uri_UriComponents_UriFormat == null)
				{
					r_RInternalGetComponents_Uri_UriComponents_UriFormat = new(this, "InternalGetComponents", 0, typeof(System.Uri), typeof(System.UriComponents), typeof(System.UriFormat));
					r_RInternalGetComponents_Uri_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RInternalGetComponents_Uri_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// Boolean InternalIsWellFormedOriginalString(System.Uri)
		/// </summary>
		protected RMethod r_RInternalIsWellFormedOriginalString_Uri;
		public virtual RMethod RInternalIsWellFormedOriginalString_Uri
		{
			get
			{
				if(r_RInternalIsWellFormedOriginalString_Uri == null)
				{
					r_RInternalIsWellFormedOriginalString_Uri = new(this, "InternalIsWellFormedOriginalString", 0, typeof(System.Uri));
					r_RInternalIsWellFormedOriginalString_Uri.SetBelong(this.instance);
				}
				return r_RInternalIsWellFormedOriginalString_Uri;
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


        public RUriParser() : base("System.UriParser")
        {
        }

        public RUriParser(System.Object instance) : base("System.UriParser")
		{
            SetInstance(instance);
		}

        public RUriParser(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUriParser(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.UriParser OnNewUri()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnNewUri.Invoke(___genericsType, ___parameters);

            return (System.UriParser)___result;
        }


        public virtual void OnRegister(System.String  @schemeName, System.Int32  @defaultPort)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemeName, @defaultPort};
            var ___result = ROnRegister_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitializeAndValidate(System.Uri  @uri, out System.UriFormatException  @parsingError)
        {
			parsingError = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @parsingError};
            var ___result = RInitializeAndValidate_Uri_Out_UriFormatException.Invoke(___genericsType, ___parameters);
			parsingError = (System.UriFormatException)___parameters[1];

            
        }


        public virtual System.String Resolve(System.Uri  @baseUri, System.Uri  @relativeUri, out System.UriFormatException  @parsingError)
        {
			parsingError = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri, @parsingError};
            var ___result = RResolve_Uri_Uri_Out_UriFormatException.Invoke(___genericsType, ___parameters);
			parsingError = (System.UriFormatException)___parameters[2];

            return (System.String)___result;
        }


        public virtual System.Boolean IsBaseOf(System.Uri  @baseUri, System.Uri  @relativeUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri};
            var ___result = RIsBaseOf_Uri_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetComponents(System.Uri  @uri, System.UriComponents  @components, System.UriFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @components, @format};
            var ___result = RGetComponents_Uri_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsWellFormedOriginalString(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RIsWellFormedOriginalString_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Register(System.UriParser  @uriParser, System.String  @schemeName, System.Int32  @defaultPort)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriParser, @schemeName, @defaultPort};
            var ___result = RRegister_UriParser_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsKnownScheme(System.String  @schemeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemeName};
            var ___result = RIsKnownScheme_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }






        public static void FetchSyntax(System.UriParser  @syntax, System.String  @lwrCaseSchemeName, System.Int32  @defaultPort)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax, @lwrCaseSchemeName, @defaultPort};
            var ___result = RFetchSyntax_UriParser_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.UriParser FindOrFetchAsUnknownV1Syntax(System.String  @lwrCaseScheme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lwrCaseScheme};
            var ___result = RFindOrFetchAsUnknownV1Syntax_String.Invoke(___genericsType, ___parameters);

            return (System.UriParser)___result;
        }


        public static System.UriParser GetSyntax(System.String  @lwrCaseScheme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lwrCaseScheme};
            var ___result = RGetSyntax_String.Invoke(___genericsType, ___parameters);

            return (System.UriParser)___result;
        }


        public virtual void CheckSetIsSimpleFlag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckSetIsSimpleFlag.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.UriParser InternalOnNewUri()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalOnNewUri.Invoke(___genericsType, ___parameters);

            return (System.UriParser)___result;
        }


        public virtual void InternalValidate(System.Uri  @thisUri, out System.UriFormatException  @parsingError)
        {
			parsingError = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thisUri, @parsingError};
            var ___result = RInternalValidate_Uri_Out_UriFormatException.Invoke(___genericsType, ___parameters);
			parsingError = (System.UriFormatException)___parameters[1];

            
        }


        public virtual System.String InternalResolve(System.Uri  @thisBaseUri, System.Uri  @uriLink, out System.UriFormatException  @parsingError)
        {
			parsingError = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thisBaseUri, @uriLink, @parsingError};
            var ___result = RInternalResolve_Uri_Uri_Out_UriFormatException.Invoke(___genericsType, ___parameters);
			parsingError = (System.UriFormatException)___parameters[2];

            return (System.String)___result;
        }


        public virtual System.Boolean InternalIsBaseOf(System.Uri  @thisBaseUri, System.Uri  @uriLink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thisBaseUri, @uriLink};
            var ___result = RInternalIsBaseOf_Uri_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalGetComponents(System.Uri  @thisUri, System.UriComponents  @uriComponents, System.UriFormat  @uriFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thisUri, @uriComponents, @uriFormat};
            var ___result = RInternalGetComponents_Uri_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean InternalIsWellFormedOriginalString(System.Uri  @thisUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thisUri};
            var ___result = RInternalIsWellFormedOriginalString_Uri.Invoke(___genericsType, ___parameters);

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
