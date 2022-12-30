using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Uri
	/// </summary>
    public partial class RUri : RMember //
    {

		/// <summary>
		/// System.String UriSchemeFile
		/// </summary>
		protected static RField r_UriSchemeFile;
		public static RField RUriSchemeFile
		{
			get
			{
				if(r_UriSchemeFile == null)
				{
					r_UriSchemeFile = new(typeof(System.Uri), "UriSchemeFile");
					r_UriSchemeFile.SetBelong(null);
				}
				return r_UriSchemeFile;
			}
		}

		/// <summary>
		/// System.String UriSchemeFtp
		/// </summary>
		protected static RField r_UriSchemeFtp;
		public static RField RUriSchemeFtp
		{
			get
			{
				if(r_UriSchemeFtp == null)
				{
					r_UriSchemeFtp = new(typeof(System.Uri), "UriSchemeFtp");
					r_UriSchemeFtp.SetBelong(null);
				}
				return r_UriSchemeFtp;
			}
		}

		/// <summary>
		/// System.String UriSchemeGopher
		/// </summary>
		protected static RField r_UriSchemeGopher;
		public static RField RUriSchemeGopher
		{
			get
			{
				if(r_UriSchemeGopher == null)
				{
					r_UriSchemeGopher = new(typeof(System.Uri), "UriSchemeGopher");
					r_UriSchemeGopher.SetBelong(null);
				}
				return r_UriSchemeGopher;
			}
		}

		/// <summary>
		/// System.String UriSchemeHttp
		/// </summary>
		protected static RField r_UriSchemeHttp;
		public static RField RUriSchemeHttp
		{
			get
			{
				if(r_UriSchemeHttp == null)
				{
					r_UriSchemeHttp = new(typeof(System.Uri), "UriSchemeHttp");
					r_UriSchemeHttp.SetBelong(null);
				}
				return r_UriSchemeHttp;
			}
		}

		/// <summary>
		/// System.String UriSchemeHttps
		/// </summary>
		protected static RField r_UriSchemeHttps;
		public static RField RUriSchemeHttps
		{
			get
			{
				if(r_UriSchemeHttps == null)
				{
					r_UriSchemeHttps = new(typeof(System.Uri), "UriSchemeHttps");
					r_UriSchemeHttps.SetBelong(null);
				}
				return r_UriSchemeHttps;
			}
		}

		/// <summary>
		/// System.String UriSchemeWs
		/// </summary>
		protected static RField r_UriSchemeWs;
		public static RField RUriSchemeWs
		{
			get
			{
				if(r_UriSchemeWs == null)
				{
					r_UriSchemeWs = new(typeof(System.Uri), "UriSchemeWs");
					r_UriSchemeWs.SetBelong(null);
				}
				return r_UriSchemeWs;
			}
		}

		/// <summary>
		/// System.String UriSchemeWss
		/// </summary>
		protected static RField r_UriSchemeWss;
		public static RField RUriSchemeWss
		{
			get
			{
				if(r_UriSchemeWss == null)
				{
					r_UriSchemeWss = new(typeof(System.Uri), "UriSchemeWss");
					r_UriSchemeWss.SetBelong(null);
				}
				return r_UriSchemeWss;
			}
		}

		/// <summary>
		/// System.String UriSchemeMailto
		/// </summary>
		protected static RField r_UriSchemeMailto;
		public static RField RUriSchemeMailto
		{
			get
			{
				if(r_UriSchemeMailto == null)
				{
					r_UriSchemeMailto = new(typeof(System.Uri), "UriSchemeMailto");
					r_UriSchemeMailto.SetBelong(null);
				}
				return r_UriSchemeMailto;
			}
		}

		/// <summary>
		/// System.String UriSchemeNews
		/// </summary>
		protected static RField r_UriSchemeNews;
		public static RField RUriSchemeNews
		{
			get
			{
				if(r_UriSchemeNews == null)
				{
					r_UriSchemeNews = new(typeof(System.Uri), "UriSchemeNews");
					r_UriSchemeNews.SetBelong(null);
				}
				return r_UriSchemeNews;
			}
		}

		/// <summary>
		/// System.String UriSchemeNntp
		/// </summary>
		protected static RField r_UriSchemeNntp;
		public static RField RUriSchemeNntp
		{
			get
			{
				if(r_UriSchemeNntp == null)
				{
					r_UriSchemeNntp = new(typeof(System.Uri), "UriSchemeNntp");
					r_UriSchemeNntp.SetBelong(null);
				}
				return r_UriSchemeNntp;
			}
		}

		/// <summary>
		/// System.String UriSchemeNetTcp
		/// </summary>
		protected static RField r_UriSchemeNetTcp;
		public static RField RUriSchemeNetTcp
		{
			get
			{
				if(r_UriSchemeNetTcp == null)
				{
					r_UriSchemeNetTcp = new(typeof(System.Uri), "UriSchemeNetTcp");
					r_UriSchemeNetTcp.SetBelong(null);
				}
				return r_UriSchemeNetTcp;
			}
		}

		/// <summary>
		/// System.String UriSchemeNetPipe
		/// </summary>
		protected static RField r_UriSchemeNetPipe;
		public static RField RUriSchemeNetPipe
		{
			get
			{
				if(r_UriSchemeNetPipe == null)
				{
					r_UriSchemeNetPipe = new(typeof(System.Uri), "UriSchemeNetPipe");
					r_UriSchemeNetPipe.SetBelong(null);
				}
				return r_UriSchemeNetPipe;
			}
		}

		/// <summary>
		/// System.String SchemeDelimiter
		/// </summary>
		protected static RField r_SchemeDelimiter;
		public static RField RSchemeDelimiter
		{
			get
			{
				if(r_SchemeDelimiter == null)
				{
					r_SchemeDelimiter = new(typeof(System.Uri), "SchemeDelimiter");
					r_SchemeDelimiter.SetBelong(null);
				}
				return r_SchemeDelimiter;
			}
		}

		/// <summary>
		/// System.Int32 c_Max16BitUtf8SequenceLength
		/// </summary>
		protected static RField r_c_Max16BitUtf8SequenceLength;
		public static RField Rc_Max16BitUtf8SequenceLength
		{
			get
			{
				if(r_c_Max16BitUtf8SequenceLength == null)
				{
					r_c_Max16BitUtf8SequenceLength = new(typeof(System.Uri), "c_Max16BitUtf8SequenceLength");
					r_c_Max16BitUtf8SequenceLength.SetBelong(null);
				}
				return r_c_Max16BitUtf8SequenceLength;
			}
		}

		/// <summary>
		/// System.Int32 c_MaxUriBufferSize
		/// </summary>
		protected static RField r_c_MaxUriBufferSize;
		public static RField Rc_MaxUriBufferSize
		{
			get
			{
				if(r_c_MaxUriBufferSize == null)
				{
					r_c_MaxUriBufferSize = new(typeof(System.Uri), "c_MaxUriBufferSize");
					r_c_MaxUriBufferSize.SetBelong(null);
				}
				return r_c_MaxUriBufferSize;
			}
		}

		/// <summary>
		/// System.Int32 c_MaxUriSchemeName
		/// </summary>
		protected static RField r_c_MaxUriSchemeName;
		public static RField Rc_MaxUriSchemeName
		{
			get
			{
				if(r_c_MaxUriSchemeName == null)
				{
					r_c_MaxUriSchemeName = new(typeof(System.Uri), "c_MaxUriSchemeName");
					r_c_MaxUriSchemeName.SetBelong(null);
				}
				return r_c_MaxUriSchemeName;
			}
		}

		/// <summary>
		/// System.String m_String
		/// </summary>
		protected RField r_m_String;
		public virtual RField Rm_String
		{
			get
			{
				if(r_m_String == null)
				{
					r_m_String = new(this, "m_String");
					r_m_String.SetBelong(this.instance);
				}
				return r_m_String;
			}
		}

		/// <summary>
		/// System.String m_originalUnicodeString
		/// </summary>
		protected RField r_m_originalUnicodeString;
		public virtual RField Rm_originalUnicodeString
		{
			get
			{
				if(r_m_originalUnicodeString == null)
				{
					r_m_originalUnicodeString = new(this, "m_originalUnicodeString");
					r_m_originalUnicodeString.SetBelong(this.instance);
				}
				return r_m_originalUnicodeString;
			}
		}

		/// <summary>
		/// System.UriParser m_Syntax
		/// </summary>
		protected RSystem.RUriParser r_m_Syntax;
		public virtual RSystem.RUriParser Rm_Syntax
		{
			get
			{
				if(r_m_Syntax == null)
				{
					r_m_Syntax = new(this, "m_Syntax");
					r_m_Syntax.SetBelong(this.instance);
				}
				return r_m_Syntax;
			}
		}

		/// <summary>
		/// System.String m_DnsSafeHost
		/// </summary>
		protected RField r_m_DnsSafeHost;
		public virtual RField Rm_DnsSafeHost
		{
			get
			{
				if(r_m_DnsSafeHost == null)
				{
					r_m_DnsSafeHost = new(this, "m_DnsSafeHost");
					r_m_DnsSafeHost.SetBelong(this.instance);
				}
				return r_m_DnsSafeHost;
			}
		}

		/// <summary>
		/// System.Uri+Flags m_Flags
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
		/// System.Uri+UriInfo m_Info
		/// </summary>
		protected RSystem.RUri.RUriInfo r_m_Info;
		public virtual RSystem.RUri.RUriInfo Rm_Info
		{
			get
			{
				if(r_m_Info == null)
				{
					r_m_Info = new(this, "m_Info");
					r_m_Info.SetBelong(this.instance);
				}
				return r_m_Info;
			}
		}

		/// <summary>
		/// System.Boolean m_iriParsing
		/// </summary>
		protected RField r_m_iriParsing;
		public virtual RField Rm_iriParsing
		{
			get
			{
				if(r_m_iriParsing == null)
				{
					r_m_iriParsing = new(this, "m_iriParsing");
					r_m_iriParsing.SetBelong(this.instance);
				}
				return r_m_iriParsing;
			}
		}

		/// <summary>
		/// System.Boolean s_ConfigInitialized
		/// </summary>
		protected static RField r_s_ConfigInitialized;
		public static RField Rs_ConfigInitialized
		{
			get
			{
				if(r_s_ConfigInitialized == null)
				{
					r_s_ConfigInitialized = new(typeof(System.Uri), "s_ConfigInitialized");
					r_s_ConfigInitialized.SetBelong(null);
				}
				return r_s_ConfigInitialized;
			}
		}

		/// <summary>
		/// System.Boolean s_ConfigInitializing
		/// </summary>
		protected static RField r_s_ConfigInitializing;
		public static RField Rs_ConfigInitializing
		{
			get
			{
				if(r_s_ConfigInitializing == null)
				{
					r_s_ConfigInitializing = new(typeof(System.Uri), "s_ConfigInitializing");
					r_s_ConfigInitializing.SetBelong(null);
				}
				return r_s_ConfigInitializing;
			}
		}

		/// <summary>
		/// System.UriIdnScope s_IdnScope
		/// </summary>
		protected static RField r_s_IdnScope;
		public static RField Rs_IdnScope
		{
			get
			{
				if(r_s_IdnScope == null)
				{
					r_s_IdnScope = new(typeof(System.Uri), "s_IdnScope");
					r_s_IdnScope.SetBelong(null);
				}
				return r_s_IdnScope;
			}
		}

		/// <summary>
		/// System.Boolean s_IriParsing
		/// </summary>
		protected static RField r_s_IriParsing;
		public static RField Rs_IriParsing
		{
			get
			{
				if(r_s_IriParsing == null)
				{
					r_s_IriParsing = new(typeof(System.Uri), "s_IriParsing");
					r_s_IriParsing.SetBelong(null);
				}
				return r_s_IriParsing;
			}
		}

		/// <summary>
		/// System.Boolean useDotNetRelativeOrAbsolute
		/// </summary>
		protected static RField r_useDotNetRelativeOrAbsolute;
		public static RField RuseDotNetRelativeOrAbsolute
		{
			get
			{
				if(r_useDotNetRelativeOrAbsolute == null)
				{
					r_useDotNetRelativeOrAbsolute = new(typeof(System.Uri), "useDotNetRelativeOrAbsolute");
					r_useDotNetRelativeOrAbsolute.SetBelong(null);
				}
				return r_useDotNetRelativeOrAbsolute;
			}
		}

		/// <summary>
		/// System.UriKind DotNetRelativeOrAbsolute
		/// </summary>
		protected static RField r_DotNetRelativeOrAbsolute;
		public static RField RDotNetRelativeOrAbsolute
		{
			get
			{
				if(r_DotNetRelativeOrAbsolute == null)
				{
					r_DotNetRelativeOrAbsolute = new(typeof(System.Uri), "DotNetRelativeOrAbsolute");
					r_DotNetRelativeOrAbsolute.SetBelong(null);
				}
				return r_DotNetRelativeOrAbsolute;
			}
		}

		/// <summary>
		/// System.Boolean IsWindowsFileSystem
		/// </summary>
		protected static RField r_IsWindowsFileSystem;
		public static RField RIsWindowsFileSystem
		{
			get
			{
				if(r_IsWindowsFileSystem == null)
				{
					r_IsWindowsFileSystem = new(typeof(System.Uri), "IsWindowsFileSystem");
					r_IsWindowsFileSystem.SetBelong(null);
				}
				return r_IsWindowsFileSystem;
			}
		}

		/// <summary>
		/// System.Object s_initLock
		/// </summary>
		protected static RSystem.RObject r_s_initLock;
		public static RSystem.RObject Rs_initLock
		{
			get
			{
				if(r_s_initLock == null)
				{
					r_s_initLock = new(typeof(System.Uri), "s_initLock");
					r_s_initLock.SetBelong(null);
				}
				return r_s_initLock;
			}
		}

		/// <summary>
		/// System.UriFormat V1ToStringUnescape
		/// </summary>
		protected static RField r_V1ToStringUnescape;
		public static RField RV1ToStringUnescape
		{
			get
			{
				if(r_V1ToStringUnescape == null)
				{
					r_V1ToStringUnescape = new(typeof(System.Uri), "V1ToStringUnescape");
					r_V1ToStringUnescape.SetBelong(null);
				}
				return r_V1ToStringUnescape;
			}
		}

		/// <summary>
		/// System.Char c_DummyChar
		/// </summary>
		protected static RField r_c_DummyChar;
		public static RField Rc_DummyChar
		{
			get
			{
				if(r_c_DummyChar == null)
				{
					r_c_DummyChar = new(typeof(System.Uri), "c_DummyChar");
					r_c_DummyChar.SetBelong(null);
				}
				return r_c_DummyChar;
			}
		}

		/// <summary>
		/// System.Char c_EOL
		/// </summary>
		protected static RField r_c_EOL;
		public static RField Rc_EOL
		{
			get
			{
				if(r_c_EOL == null)
				{
					r_c_EOL = new(typeof(System.Uri), "c_EOL");
					r_c_EOL.SetBelong(null);
				}
				return r_c_EOL;
			}
		}

		/// <summary>
		/// System.Char[] HexLowerChars
		/// </summary>
		protected static RFieldArray<RField> r_HexLowerChars;
		public static RFieldArray<RField> RHexLowerChars
		{
			get
			{
				if(r_HexLowerChars == null)
				{
					r_HexLowerChars = new(typeof(System.Uri), "HexLowerChars");
					r_HexLowerChars.SetBelong(null);
				}
				return r_HexLowerChars;
			}
		}

		/// <summary>
		/// System.Char[] _WSchars
		/// </summary>
		protected static RFieldArray<RField> r__WSchars;
		public static RFieldArray<RField> R_WSchars
		{
			get
			{
				if(r__WSchars == null)
				{
					r__WSchars = new(typeof(System.Uri), "_WSchars");
					r__WSchars.SetBelong(null);
				}
				return r__WSchars;
			}
		}

		/// <summary>
		/// Boolean IsImplicitFile
		/// </summary>
		protected RProperty r_IsImplicitFile;
		public virtual RProperty RIsImplicitFile
		{
			get
			{
				if(r_IsImplicitFile == null)
				{
					r_IsImplicitFile = new(this, "IsImplicitFile", -1);
					r_IsImplicitFile.SetBelong(this.instance);
				}
				return r_IsImplicitFile;
			}
		}

		/// <summary>
		/// Boolean IsUncOrDosPath
		/// </summary>
		protected RProperty r_IsUncOrDosPath;
		public virtual RProperty RIsUncOrDosPath
		{
			get
			{
				if(r_IsUncOrDosPath == null)
				{
					r_IsUncOrDosPath = new(this, "IsUncOrDosPath", -1);
					r_IsUncOrDosPath.SetBelong(this.instance);
				}
				return r_IsUncOrDosPath;
			}
		}

		/// <summary>
		/// Boolean IsDosPath
		/// </summary>
		protected RProperty r_IsDosPath;
		public virtual RProperty RIsDosPath
		{
			get
			{
				if(r_IsDosPath == null)
				{
					r_IsDosPath = new(this, "IsDosPath", -1);
					r_IsDosPath.SetBelong(this.instance);
				}
				return r_IsDosPath;
			}
		}

		/// <summary>
		/// Boolean IsUncPath
		/// </summary>
		protected RProperty r_IsUncPath;
		public virtual RProperty RIsUncPath
		{
			get
			{
				if(r_IsUncPath == null)
				{
					r_IsUncPath = new(this, "IsUncPath", -1);
					r_IsUncPath.SetBelong(this.instance);
				}
				return r_IsUncPath;
			}
		}

		/// <summary>
		/// Flags HostType
		/// </summary>
		protected RProperty r_HostType;
		public virtual RProperty RHostType
		{
			get
			{
				if(r_HostType == null)
				{
					r_HostType = new(this, "HostType", -1);
					r_HostType.SetBelong(this.instance);
				}
				return r_HostType;
			}
		}

		/// <summary>
		/// System.UriParser Syntax
		/// </summary>
		protected RSystem.RUriParser r_Syntax;
		public virtual RSystem.RUriParser RSyntax
		{
			get
			{
				if(r_Syntax == null)
				{
					r_Syntax = new(this, "Syntax", -1);
					r_Syntax.SetBelong(this.instance);
				}
				return r_Syntax;
			}
		}

		/// <summary>
		/// Boolean IsNotAbsoluteUri
		/// </summary>
		protected RProperty r_IsNotAbsoluteUri;
		public virtual RProperty RIsNotAbsoluteUri
		{
			get
			{
				if(r_IsNotAbsoluteUri == null)
				{
					r_IsNotAbsoluteUri = new(this, "IsNotAbsoluteUri", -1);
					r_IsNotAbsoluteUri.SetBelong(this.instance);
				}
				return r_IsNotAbsoluteUri;
			}
		}

		/// <summary>
		/// Boolean AllowIdn
		/// </summary>
		protected RProperty r_AllowIdn;
		public virtual RProperty RAllowIdn
		{
			get
			{
				if(r_AllowIdn == null)
				{
					r_AllowIdn = new(this, "AllowIdn", -1);
					r_AllowIdn.SetBelong(this.instance);
				}
				return r_AllowIdn;
			}
		}

		/// <summary>
		/// Boolean UserDrivenParsing
		/// </summary>
		protected RProperty r_UserDrivenParsing;
		public virtual RProperty RUserDrivenParsing
		{
			get
			{
				if(r_UserDrivenParsing == null)
				{
					r_UserDrivenParsing = new(this, "UserDrivenParsing", -1);
					r_UserDrivenParsing.SetBelong(this.instance);
				}
				return r_UserDrivenParsing;
			}
		}

		/// <summary>
		/// UInt16 SecuredPathIndex
		/// </summary>
		protected RProperty r_SecuredPathIndex;
		public virtual RProperty RSecuredPathIndex
		{
			get
			{
				if(r_SecuredPathIndex == null)
				{
					r_SecuredPathIndex = new(this, "SecuredPathIndex", -1);
					r_SecuredPathIndex.SetBelong(this.instance);
				}
				return r_SecuredPathIndex;
			}
		}

		/// <summary>
		/// System.String AbsolutePath
		/// </summary>
		protected RProperty r_AbsolutePath;
		public virtual RProperty RAbsolutePath
		{
			get
			{
				if(r_AbsolutePath == null)
				{
					r_AbsolutePath = new(this, "AbsolutePath", -1);
					r_AbsolutePath.SetBelong(this.instance);
				}
				return r_AbsolutePath;
			}
		}

		/// <summary>
		/// System.String PrivateAbsolutePath
		/// </summary>
		protected RProperty r_PrivateAbsolutePath;
		public virtual RProperty RPrivateAbsolutePath
		{
			get
			{
				if(r_PrivateAbsolutePath == null)
				{
					r_PrivateAbsolutePath = new(this, "PrivateAbsolutePath", -1);
					r_PrivateAbsolutePath.SetBelong(this.instance);
				}
				return r_PrivateAbsolutePath;
			}
		}

		/// <summary>
		/// System.String AbsoluteUri
		/// </summary>
		protected RProperty r_AbsoluteUri;
		public virtual RProperty RAbsoluteUri
		{
			get
			{
				if(r_AbsoluteUri == null)
				{
					r_AbsoluteUri = new(this, "AbsoluteUri", -1);
					r_AbsoluteUri.SetBelong(this.instance);
				}
				return r_AbsoluteUri;
			}
		}

		/// <summary>
		/// System.String LocalPath
		/// </summary>
		protected RProperty r_LocalPath;
		public virtual RProperty RLocalPath
		{
			get
			{
				if(r_LocalPath == null)
				{
					r_LocalPath = new(this, "LocalPath", -1);
					r_LocalPath.SetBelong(this.instance);
				}
				return r_LocalPath;
			}
		}

		/// <summary>
		/// System.String Authority
		/// </summary>
		protected RProperty r_Authority;
		public virtual RProperty RAuthority
		{
			get
			{
				if(r_Authority == null)
				{
					r_Authority = new(this, "Authority", -1);
					r_Authority.SetBelong(this.instance);
				}
				return r_Authority;
			}
		}

		/// <summary>
		/// System.UriHostNameType HostNameType
		/// </summary>
		protected RProperty r_HostNameType;
		public virtual RProperty RHostNameType
		{
			get
			{
				if(r_HostNameType == null)
				{
					r_HostNameType = new(this, "HostNameType", -1);
					r_HostNameType.SetBelong(this.instance);
				}
				return r_HostNameType;
			}
		}

		/// <summary>
		/// Boolean IsDefaultPort
		/// </summary>
		protected RProperty r_IsDefaultPort;
		public virtual RProperty RIsDefaultPort
		{
			get
			{
				if(r_IsDefaultPort == null)
				{
					r_IsDefaultPort = new(this, "IsDefaultPort", -1);
					r_IsDefaultPort.SetBelong(this.instance);
				}
				return r_IsDefaultPort;
			}
		}

		/// <summary>
		/// Boolean IsFile
		/// </summary>
		protected RProperty r_IsFile;
		public virtual RProperty RIsFile
		{
			get
			{
				if(r_IsFile == null)
				{
					r_IsFile = new(this, "IsFile", -1);
					r_IsFile.SetBelong(this.instance);
				}
				return r_IsFile;
			}
		}

		/// <summary>
		/// Boolean IsLoopback
		/// </summary>
		protected RProperty r_IsLoopback;
		public virtual RProperty RIsLoopback
		{
			get
			{
				if(r_IsLoopback == null)
				{
					r_IsLoopback = new(this, "IsLoopback", -1);
					r_IsLoopback.SetBelong(this.instance);
				}
				return r_IsLoopback;
			}
		}

		/// <summary>
		/// System.String PathAndQuery
		/// </summary>
		protected RProperty r_PathAndQuery;
		public virtual RProperty RPathAndQuery
		{
			get
			{
				if(r_PathAndQuery == null)
				{
					r_PathAndQuery = new(this, "PathAndQuery", -1);
					r_PathAndQuery.SetBelong(this.instance);
				}
				return r_PathAndQuery;
			}
		}

		/// <summary>
		/// System.String[] Segments
		/// </summary>
		protected RPropertyArray<RProperty> r_Segments;
		public virtual RPropertyArray<RProperty> RSegments
		{
			get
			{
				if(r_Segments == null)
				{
					r_Segments = new(this, "Segments", -1);
					r_Segments.SetBelong(this.instance);
				}
				return r_Segments;
			}
		}

		/// <summary>
		/// Boolean IsUnc
		/// </summary>
		protected RProperty r_IsUnc;
		public virtual RProperty RIsUnc
		{
			get
			{
				if(r_IsUnc == null)
				{
					r_IsUnc = new(this, "IsUnc", -1);
					r_IsUnc.SetBelong(this.instance);
				}
				return r_IsUnc;
			}
		}

		/// <summary>
		/// System.String Host
		/// </summary>
		protected RProperty r_Host;
		public virtual RProperty RHost
		{
			get
			{
				if(r_Host == null)
				{
					r_Host = new(this, "Host", -1);
					r_Host.SetBelong(this.instance);
				}
				return r_Host;
			}
		}

		/// <summary>
		/// System.Object InitializeLock
		/// </summary>
		protected static RSystem.RObject r_InitializeLock;
		public static RSystem.RObject RInitializeLock
		{
			get
			{
				if(r_InitializeLock == null)
				{
					r_InitializeLock = new(typeof(System.Uri), "InitializeLock", -1);
					r_InitializeLock.SetBelong(null);
				}
				return r_InitializeLock;
			}
		}

		/// <summary>
		/// Int32 Port
		/// </summary>
		protected RProperty r_Port;
		public virtual RProperty RPort
		{
			get
			{
				if(r_Port == null)
				{
					r_Port = new(this, "Port", -1);
					r_Port.SetBelong(this.instance);
				}
				return r_Port;
			}
		}

		/// <summary>
		/// System.String Query
		/// </summary>
		protected RProperty r_Query;
		public virtual RProperty RQuery
		{
			get
			{
				if(r_Query == null)
				{
					r_Query = new(this, "Query", -1);
					r_Query.SetBelong(this.instance);
				}
				return r_Query;
			}
		}

		/// <summary>
		/// System.String Fragment
		/// </summary>
		protected RProperty r_Fragment;
		public virtual RProperty RFragment
		{
			get
			{
				if(r_Fragment == null)
				{
					r_Fragment = new(this, "Fragment", -1);
					r_Fragment.SetBelong(this.instance);
				}
				return r_Fragment;
			}
		}

		/// <summary>
		/// System.String Scheme
		/// </summary>
		protected RProperty r_Scheme;
		public virtual RProperty RScheme
		{
			get
			{
				if(r_Scheme == null)
				{
					r_Scheme = new(this, "Scheme", -1);
					r_Scheme.SetBelong(this.instance);
				}
				return r_Scheme;
			}
		}

		/// <summary>
		/// Boolean OriginalStringSwitched
		/// </summary>
		protected RProperty r_OriginalStringSwitched;
		public virtual RProperty ROriginalStringSwitched
		{
			get
			{
				if(r_OriginalStringSwitched == null)
				{
					r_OriginalStringSwitched = new(this, "OriginalStringSwitched", -1);
					r_OriginalStringSwitched.SetBelong(this.instance);
				}
				return r_OriginalStringSwitched;
			}
		}

		/// <summary>
		/// System.String OriginalString
		/// </summary>
		protected RProperty r_OriginalString;
		public virtual RProperty ROriginalString
		{
			get
			{
				if(r_OriginalString == null)
				{
					r_OriginalString = new(this, "OriginalString", -1);
					r_OriginalString.SetBelong(this.instance);
				}
				return r_OriginalString;
			}
		}

		/// <summary>
		/// System.String DnsSafeHost
		/// </summary>
		protected RProperty r_DnsSafeHost;
		public virtual RProperty RDnsSafeHost
		{
			get
			{
				if(r_DnsSafeHost == null)
				{
					r_DnsSafeHost = new(this, "DnsSafeHost", -1);
					r_DnsSafeHost.SetBelong(this.instance);
				}
				return r_DnsSafeHost;
			}
		}

		/// <summary>
		/// System.String IdnHost
		/// </summary>
		protected RProperty r_IdnHost;
		public virtual RProperty RIdnHost
		{
			get
			{
				if(r_IdnHost == null)
				{
					r_IdnHost = new(this, "IdnHost", -1);
					r_IdnHost.SetBelong(this.instance);
				}
				return r_IdnHost;
			}
		}

		/// <summary>
		/// Boolean IsAbsoluteUri
		/// </summary>
		protected RProperty r_IsAbsoluteUri;
		public virtual RProperty RIsAbsoluteUri
		{
			get
			{
				if(r_IsAbsoluteUri == null)
				{
					r_IsAbsoluteUri = new(this, "IsAbsoluteUri", -1);
					r_IsAbsoluteUri.SetBelong(this.instance);
				}
				return r_IsAbsoluteUri;
			}
		}

		/// <summary>
		/// Boolean UserEscaped
		/// </summary>
		protected RProperty r_UserEscaped;
		public virtual RProperty RUserEscaped
		{
			get
			{
				if(r_UserEscaped == null)
				{
					r_UserEscaped = new(this, "UserEscaped", -1);
					r_UserEscaped.SetBelong(this.instance);
				}
				return r_UserEscaped;
			}
		}

		/// <summary>
		/// System.String UserInfo
		/// </summary>
		protected RProperty r_UserInfo;
		public virtual RProperty RUserInfo
		{
			get
			{
				if(r_UserInfo == null)
				{
					r_UserInfo = new(this, "UserInfo", -1);
					r_UserInfo.SetBelong(this.instance);
				}
				return r_UserInfo;
			}
		}

		/// <summary>
		/// Boolean HasAuthority
		/// </summary>
		protected RProperty r_HasAuthority;
		public virtual RProperty RHasAuthority
		{
			get
			{
				if(r_HasAuthority == null)
				{
					r_HasAuthority = new(this, "HasAuthority", -1);
					r_HasAuthority.SetBelong(this.instance);
				}
				return r_HasAuthority;
			}
		}

		/// <summary>
		/// Boolean IriParsingStatic(System.UriParser)
		/// </summary>
		protected static RMethod r_RIriParsingStatic_UriParser;
		public static RMethod RIriParsingStatic_UriParser
		{
			get
			{
				if(r_RIriParsingStatic_UriParser == null)
				{
					r_RIriParsingStatic_UriParser = new(typeof(System.Uri), "IriParsingStatic", 0, typeof(System.UriParser));
					r_RIriParsingStatic_UriParser.SetBelong(null);
				}
				return r_RIriParsingStatic_UriParser;
			}
		}

		/// <summary>
		/// Boolean AllowIdnStatic(System.UriParser, Flags)
		/// </summary>
		protected RMethod r_RAllowIdnStatic_UriParser_Flags;
		public virtual RMethod RAllowIdnStatic_UriParser_Flags
		{
			get
			{
				if(r_RAllowIdnStatic_UriParser_Flags == null)
				{
					r_RAllowIdnStatic_UriParser_Flags = new(this, "AllowIdnStatic", 0, typeof(System.UriParser),  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RAllowIdnStatic_UriParser_Flags.SetBelong(this.instance);
				}
				return r_RAllowIdnStatic_UriParser_Flags;
			}
		}

		/// <summary>
		/// Boolean IsIntranet(System.String)
		/// </summary>
		protected RMethod r_RIsIntranet_String;
		public virtual RMethod RIsIntranet_String
		{
			get
			{
				if(r_RIsIntranet_String == null)
				{
					r_RIsIntranet_String = new(this, "IsIntranet", 0, typeof(System.String));
					r_RIsIntranet_String.SetBelong(this.instance);
				}
				return r_RIsIntranet_String;
			}
		}

		/// <summary>
		/// Void SetUserDrivenParsing()
		/// </summary>
		protected RMethod r_RSetUserDrivenParsing;
		public virtual RMethod RSetUserDrivenParsing
		{
			get
			{
				if(r_RSetUserDrivenParsing == null)
				{
					r_RSetUserDrivenParsing = new(this, "SetUserDrivenParsing", 0);
					r_RSetUserDrivenParsing.SetBelong(this.instance);
				}
				return r_RSetUserDrivenParsing;
			}
		}

		/// <summary>
		/// Boolean NotAny(Flags)
		/// </summary>
		protected RMethod r_RNotAny_Flags;
		public virtual RMethod RNotAny_Flags
		{
			get
			{
				if(r_RNotAny_Flags == null)
				{
					r_RNotAny_Flags = new(this, "NotAny", 0,  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RNotAny_Flags.SetBelong(this.instance);
				}
				return r_RNotAny_Flags;
			}
		}

		/// <summary>
		/// Boolean InFact(Flags)
		/// </summary>
		protected RMethod r_RInFact_Flags;
		public virtual RMethod RInFact_Flags
		{
			get
			{
				if(r_RInFact_Flags == null)
				{
					r_RInFact_Flags = new(this, "InFact", 0,  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RInFact_Flags.SetBelong(this.instance);
				}
				return r_RInFact_Flags;
			}
		}

		/// <summary>
		/// Boolean StaticNotAny(Flags, Flags)
		/// </summary>
		protected static RMethod r_RStaticNotAny_Flags_Flags;
		public static RMethod RStaticNotAny_Flags_Flags
		{
			get
			{
				if(r_RStaticNotAny_Flags_Flags == null)
				{
					r_RStaticNotAny_Flags_Flags = new(typeof(System.Uri), "StaticNotAny", 0,  ReleactionUtils.GetType("System.Uri+Flags"),  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RStaticNotAny_Flags_Flags.SetBelong(null);
				}
				return r_RStaticNotAny_Flags_Flags;
			}
		}

		/// <summary>
		/// Boolean StaticInFact(Flags, Flags)
		/// </summary>
		protected static RMethod r_RStaticInFact_Flags_Flags;
		public static RMethod RStaticInFact_Flags_Flags
		{
			get
			{
				if(r_RStaticInFact_Flags_Flags == null)
				{
					r_RStaticInFact_Flags_Flags = new(typeof(System.Uri), "StaticInFact", 0,  ReleactionUtils.GetType("System.Uri+Flags"),  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RStaticInFact_Flags_Flags.SetBelong(null);
				}
				return r_RStaticInFact_Flags_Flags;
			}
		}

		/// <summary>
		/// UriInfo EnsureUriInfo()
		/// </summary>
		protected RMethod r_REnsureUriInfo;
		public virtual RMethod REnsureUriInfo
		{
			get
			{
				if(r_REnsureUriInfo == null)
				{
					r_REnsureUriInfo = new(this, "EnsureUriInfo", 0);
					r_REnsureUriInfo.SetBelong(this.instance);
				}
				return r_REnsureUriInfo;
			}
		}

		/// <summary>
		/// Void EnsureParseRemaining()
		/// </summary>
		protected RMethod r_REnsureParseRemaining;
		public virtual RMethod REnsureParseRemaining
		{
			get
			{
				if(r_REnsureParseRemaining == null)
				{
					r_REnsureParseRemaining = new(this, "EnsureParseRemaining", 0);
					r_REnsureParseRemaining.SetBelong(this.instance);
				}
				return r_REnsureParseRemaining;
			}
		}

		/// <summary>
		/// Void EnsureHostString(Boolean)
		/// </summary>
		protected RMethod r_REnsureHostString_Boolean;
		public virtual RMethod REnsureHostString_Boolean
		{
			get
			{
				if(r_REnsureHostString_Boolean == null)
				{
					r_REnsureHostString_Boolean = new(this, "EnsureHostString", 0, typeof(System.Boolean));
					r_REnsureHostString_Boolean.SetBelong(this.instance);
				}
				return r_REnsureHostString_Boolean;
			}
		}

		/// <summary>
		/// Void CreateUri(System.Uri, System.String, Boolean)
		/// </summary>
		protected RMethod r_RCreateUri_Uri_String_Boolean;
		public virtual RMethod RCreateUri_Uri_String_Boolean
		{
			get
			{
				if(r_RCreateUri_Uri_String_Boolean == null)
				{
					r_RCreateUri_Uri_String_Boolean = new(this, "CreateUri", 0, typeof(System.Uri), typeof(System.String), typeof(System.Boolean));
					r_RCreateUri_Uri_String_Boolean.SetBelong(this.instance);
				}
				return r_RCreateUri_Uri_String_Boolean;
			}
		}

		/// <summary>
		/// System.ParsingError GetCombinedString(System.Uri, System.String, Boolean, System.String ByRef)
		/// </summary>
		protected static RMethod r_RGetCombinedString_Uri_String_Boolean_Ref_String;
		public static RMethod RGetCombinedString_Uri_String_Boolean_Ref_String
		{
			get
			{
				if(r_RGetCombinedString_Uri_String_Boolean_Ref_String == null)
				{
					r_RGetCombinedString_Uri_String_Boolean_Ref_String = new(typeof(System.Uri), "GetCombinedString", 0, typeof(System.Uri), typeof(System.String), typeof(System.Boolean), typeof(System.String).MakeByRefType());
					r_RGetCombinedString_Uri_String_Boolean_Ref_String.SetBelong(null);
				}
				return r_RGetCombinedString_Uri_String_Boolean_Ref_String;
			}
		}

		/// <summary>
		/// System.UriFormatException GetException(System.ParsingError)
		/// </summary>
		protected static RMethod r_RGetException_ParsingError;
		public static RMethod RGetException_ParsingError
		{
			get
			{
				if(r_RGetException_ParsingError == null)
				{
					r_RGetException_ParsingError = new(typeof(System.Uri), "GetException", 0,  ReleactionUtils.GetType("System.ParsingError"));
					r_RGetException_ParsingError.SetBelong(null);
				}
				return r_RGetException_ParsingError;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean StaticIsFile(System.UriParser)
		/// </summary>
		protected static RMethod r_RStaticIsFile_UriParser;
		public static RMethod RStaticIsFile_UriParser
		{
			get
			{
				if(r_RStaticIsFile_UriParser == null)
				{
					r_RStaticIsFile_UriParser = new(typeof(System.Uri), "StaticIsFile", 0, typeof(System.UriParser));
					r_RStaticIsFile_UriParser.SetBelong(null);
				}
				return r_RStaticIsFile_UriParser;
			}
		}

		/// <summary>
		/// Void InitializeUriConfig()
		/// </summary>
		protected static RMethod r_RInitializeUriConfig;
		public static RMethod RInitializeUriConfig
		{
			get
			{
				if(r_RInitializeUriConfig == null)
				{
					r_RInitializeUriConfig = new(typeof(System.Uri), "InitializeUriConfig", 0);
					r_RInitializeUriConfig.SetBelong(null);
				}
				return r_RInitializeUriConfig;
			}
		}

		/// <summary>
		/// System.String GetLocalPath()
		/// </summary>
		protected RMethod r_RGetLocalPath;
		public virtual RMethod RGetLocalPath
		{
			get
			{
				if(r_RGetLocalPath == null)
				{
					r_RGetLocalPath = new(this, "GetLocalPath", 0);
					r_RGetLocalPath.SetBelong(this.instance);
				}
				return r_RGetLocalPath;
			}
		}

		/// <summary>
		/// System.UriHostNameType CheckHostName(System.String)
		/// </summary>
		protected static RMethod r_RCheckHostName_String;
		public static RMethod RCheckHostName_String
		{
			get
			{
				if(r_RCheckHostName_String == null)
				{
					r_RCheckHostName_String = new(typeof(System.Uri), "CheckHostName", 0, typeof(System.String));
					r_RCheckHostName_String.SetBelong(null);
				}
				return r_RCheckHostName_String;
			}
		}

		/// <summary>
		/// System.String GetLeftPart(System.UriPartial)
		/// </summary>
		protected RMethod r_RGetLeftPart_UriPartial;
		public virtual RMethod RGetLeftPart_UriPartial
		{
			get
			{
				if(r_RGetLeftPart_UriPartial == null)
				{
					r_RGetLeftPart_UriPartial = new(this, "GetLeftPart", 0, typeof(System.UriPartial));
					r_RGetLeftPart_UriPartial.SetBelong(this.instance);
				}
				return r_RGetLeftPart_UriPartial;
			}
		}

		/// <summary>
		/// System.String HexEscape(Char)
		/// </summary>
		protected static RMethod r_RHexEscape_Char;
		public static RMethod RHexEscape_Char
		{
			get
			{
				if(r_RHexEscape_Char == null)
				{
					r_RHexEscape_Char = new(typeof(System.Uri), "HexEscape", 0, typeof(System.Char));
					r_RHexEscape_Char.SetBelong(null);
				}
				return r_RHexEscape_Char;
			}
		}

		/// <summary>
		/// Char HexUnescape(System.String, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RHexUnescape_String_Ref_Int32;
		public static RMethod RHexUnescape_String_Ref_Int32
		{
			get
			{
				if(r_RHexUnescape_String_Ref_Int32 == null)
				{
					r_RHexUnescape_String_Ref_Int32 = new(typeof(System.Uri), "HexUnescape", 0, typeof(System.String), typeof(System.Int32).MakeByRefType());
					r_RHexUnescape_String_Ref_Int32.SetBelong(null);
				}
				return r_RHexUnescape_String_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean IsHexEncoding(System.String, Int32)
		/// </summary>
		protected static RMethod r_RIsHexEncoding_String_Int32;
		public static RMethod RIsHexEncoding_String_Int32
		{
			get
			{
				if(r_RIsHexEncoding_String_Int32 == null)
				{
					r_RIsHexEncoding_String_Int32 = new(typeof(System.Uri), "IsHexEncoding", 0, typeof(System.String), typeof(System.Int32));
					r_RIsHexEncoding_String_Int32.SetBelong(null);
				}
				return r_RIsHexEncoding_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsGenDelim(Char)
		/// </summary>
		protected static RMethod r_RIsGenDelim_Char;
		public static RMethod RIsGenDelim_Char
		{
			get
			{
				if(r_RIsGenDelim_Char == null)
				{
					r_RIsGenDelim_Char = new(typeof(System.Uri), "IsGenDelim", 0, typeof(System.Char));
					r_RIsGenDelim_Char.SetBelong(null);
				}
				return r_RIsGenDelim_Char;
			}
		}

		/// <summary>
		/// Boolean CheckSchemeName(System.String)
		/// </summary>
		protected static RMethod r_RCheckSchemeName_String;
		public static RMethod RCheckSchemeName_String
		{
			get
			{
				if(r_RCheckSchemeName_String == null)
				{
					r_RCheckSchemeName_String = new(typeof(System.Uri), "CheckSchemeName", 0, typeof(System.String));
					r_RCheckSchemeName_String.SetBelong(null);
				}
				return r_RCheckSchemeName_String;
			}
		}

		/// <summary>
		/// Boolean IsHexDigit(Char)
		/// </summary>
		protected static RMethod r_RIsHexDigit_Char;
		public static RMethod RIsHexDigit_Char
		{
			get
			{
				if(r_RIsHexDigit_Char == null)
				{
					r_RIsHexDigit_Char = new(typeof(System.Uri), "IsHexDigit", 0, typeof(System.Char));
					r_RIsHexDigit_Char.SetBelong(null);
				}
				return r_RIsHexDigit_Char;
			}
		}

		/// <summary>
		/// Int32 FromHex(Char)
		/// </summary>
		protected static RMethod r_RFromHex_Char;
		public static RMethod RFromHex_Char
		{
			get
			{
				if(r_RFromHex_Char == null)
				{
					r_RFromHex_Char = new(typeof(System.Uri), "FromHex", 0, typeof(System.Char));
					r_RFromHex_Char.SetBelong(null);
				}
				return r_RFromHex_Char;
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

		/// <summary>
		/// Boolean op_Equality(System.Uri, System.Uri)
		/// </summary>
		protected static RMethod r_Rop_Equality_Uri_Uri;
		public static RMethod Rop_Equality_Uri_Uri
		{
			get
			{
				if(r_Rop_Equality_Uri_Uri == null)
				{
					r_Rop_Equality_Uri_Uri = new(typeof(System.Uri), "op_Equality", 0, typeof(System.Uri), typeof(System.Uri));
					r_Rop_Equality_Uri_Uri.SetBelong(null);
				}
				return r_Rop_Equality_Uri_Uri;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Uri, System.Uri)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Uri_Uri;
		public static RMethod Rop_Inequality_Uri_Uri
		{
			get
			{
				if(r_Rop_Inequality_Uri_Uri == null)
				{
					r_Rop_Inequality_Uri_Uri = new(typeof(System.Uri), "op_Inequality", 0, typeof(System.Uri), typeof(System.Uri));
					r_Rop_Inequality_Uri_Uri.SetBelong(null);
				}
				return r_Rop_Inequality_Uri_Uri;
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
		/// System.Uri MakeRelativeUri(System.Uri)
		/// </summary>
		protected RMethod r_RMakeRelativeUri_Uri;
		public virtual RMethod RMakeRelativeUri_Uri
		{
			get
			{
				if(r_RMakeRelativeUri_Uri == null)
				{
					r_RMakeRelativeUri_Uri = new(this, "MakeRelativeUri", 0, typeof(System.Uri));
					r_RMakeRelativeUri_Uri.SetBelong(this.instance);
				}
				return r_RMakeRelativeUri_Uri;
			}
		}

		/// <summary>
		/// Boolean CheckForColonInFirstPathSegment(System.String)
		/// </summary>
		protected static RMethod r_RCheckForColonInFirstPathSegment_String;
		public static RMethod RCheckForColonInFirstPathSegment_String
		{
			get
			{
				if(r_RCheckForColonInFirstPathSegment_String == null)
				{
					r_RCheckForColonInFirstPathSegment_String = new(typeof(System.Uri), "CheckForColonInFirstPathSegment", 0, typeof(System.String));
					r_RCheckForColonInFirstPathSegment_String.SetBelong(null);
				}
				return r_RCheckForColonInFirstPathSegment_String;
			}
		}

		/// <summary>
		/// System.String InternalEscapeString(System.String)
		/// </summary>
		protected static RMethod r_RInternalEscapeString_String;
		public static RMethod RInternalEscapeString_String
		{
			get
			{
				if(r_RInternalEscapeString_String == null)
				{
					r_RInternalEscapeString_String = new(typeof(System.Uri), "InternalEscapeString", 0, typeof(System.String));
					r_RInternalEscapeString_String.SetBelong(null);
				}
				return r_RInternalEscapeString_String;
			}
		}

		/// <summary>
		/// System.ParsingError ParseScheme(System.String, Flags ByRef, System.UriParser ByRef)
		/// </summary>
		protected static RMethod r_RParseScheme_String_Ref_Flags_Ref_UriParser;
		public static RMethod RParseScheme_String_Ref_Flags_Ref_UriParser
		{
			get
			{
				if(r_RParseScheme_String_Ref_Flags_Ref_UriParser == null)
				{
					r_RParseScheme_String_Ref_Flags_Ref_UriParser = new(typeof(System.Uri), "ParseScheme", 0, typeof(System.String),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.UriParser).MakeByRefType());
					r_RParseScheme_String_Ref_Flags_Ref_UriParser.SetBelong(null);
				}
				return r_RParseScheme_String_Ref_Flags_Ref_UriParser;
			}
		}

		/// <summary>
		/// System.UriFormatException ParseMinimal()
		/// </summary>
		protected RMethod r_RParseMinimal;
		public virtual RMethod RParseMinimal
		{
			get
			{
				if(r_RParseMinimal == null)
				{
					r_RParseMinimal = new(this, "ParseMinimal", 0);
					r_RParseMinimal.SetBelong(this.instance);
				}
				return r_RParseMinimal;
			}
		}

		/// <summary>
		/// System.ParsingError PrivateParseMinimal()
		/// </summary>
		protected RMethod r_RPrivateParseMinimal;
		public virtual RMethod RPrivateParseMinimal
		{
			get
			{
				if(r_RPrivateParseMinimal == null)
				{
					r_RPrivateParseMinimal = new(this, "PrivateParseMinimal", 0);
					r_RPrivateParseMinimal.SetBelong(this.instance);
				}
				return r_RPrivateParseMinimal;
			}
		}

		/// <summary>
		/// Void PrivateParseMinimalIri(System.String, UInt16)
		/// </summary>
		protected RMethod r_RPrivateParseMinimalIri_String_UInt16;
		public virtual RMethod RPrivateParseMinimalIri_String_UInt16
		{
			get
			{
				if(r_RPrivateParseMinimalIri_String_UInt16 == null)
				{
					r_RPrivateParseMinimalIri_String_UInt16 = new(this, "PrivateParseMinimalIri", 0, typeof(System.String), typeof(System.UInt16));
					r_RPrivateParseMinimalIri_String_UInt16.SetBelong(this.instance);
				}
				return r_RPrivateParseMinimalIri_String_UInt16;
			}
		}

		/// <summary>
		/// Void CreateUriInfo(Flags)
		/// </summary>
		protected RMethod r_RCreateUriInfo_Flags;
		public virtual RMethod RCreateUriInfo_Flags
		{
			get
			{
				if(r_RCreateUriInfo_Flags == null)
				{
					r_RCreateUriInfo_Flags = new(this, "CreateUriInfo", 0,  ReleactionUtils.GetType("System.Uri+Flags"));
					r_RCreateUriInfo_Flags.SetBelong(this.instance);
				}
				return r_RCreateUriInfo_Flags;
			}
		}

		/// <summary>
		/// Void CreateHostString()
		/// </summary>
		protected RMethod r_RCreateHostString;
		public virtual RMethod RCreateHostString
		{
			get
			{
				if(r_RCreateHostString == null)
				{
					r_RCreateHostString = new(this, "CreateHostString", 0);
					r_RCreateHostString.SetBelong(this.instance);
				}
				return r_RCreateHostString;
			}
		}

		/// <summary>
		/// System.String CreateHostStringHelper(System.String, UInt16, UInt16, Flags ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String;
		public static RMethod RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String
		{
			get
			{
				if(r_RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String == null)
				{
					r_RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String = new(typeof(System.Uri), "CreateHostStringHelper", 0, typeof(System.String), typeof(System.UInt16), typeof(System.UInt16),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.String).MakeByRefType());
					r_RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String.SetBelong(null);
				}
				return r_RCreateHostStringHelper_String_UInt16_UInt16_Ref_Flags_Ref_String;
			}
		}

		/// <summary>
		/// Void GetHostViaCustomSyntax()
		/// </summary>
		protected RMethod r_RGetHostViaCustomSyntax;
		public virtual RMethod RGetHostViaCustomSyntax
		{
			get
			{
				if(r_RGetHostViaCustomSyntax == null)
				{
					r_RGetHostViaCustomSyntax = new(this, "GetHostViaCustomSyntax", 0);
					r_RGetHostViaCustomSyntax.SetBelong(this.instance);
				}
				return r_RGetHostViaCustomSyntax;
			}
		}

		/// <summary>
		/// System.String GetParts(System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetParts_UriComponents_UriFormat;
		public virtual RMethod RGetParts_UriComponents_UriFormat
		{
			get
			{
				if(r_RGetParts_UriComponents_UriFormat == null)
				{
					r_RGetParts_UriComponents_UriFormat = new(this, "GetParts", 0, typeof(System.UriComponents), typeof(System.UriFormat));
					r_RGetParts_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RGetParts_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// System.String GetEscapedParts(System.UriComponents)
		/// </summary>
		protected RMethod r_RGetEscapedParts_UriComponents;
		public virtual RMethod RGetEscapedParts_UriComponents
		{
			get
			{
				if(r_RGetEscapedParts_UriComponents == null)
				{
					r_RGetEscapedParts_UriComponents = new(this, "GetEscapedParts", 0, typeof(System.UriComponents));
					r_RGetEscapedParts_UriComponents.SetBelong(this.instance);
				}
				return r_RGetEscapedParts_UriComponents;
			}
		}

		/// <summary>
		/// System.String GetUnescapedParts(System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetUnescapedParts_UriComponents_UriFormat;
		public virtual RMethod RGetUnescapedParts_UriComponents_UriFormat
		{
			get
			{
				if(r_RGetUnescapedParts_UriComponents_UriFormat == null)
				{
					r_RGetUnescapedParts_UriComponents_UriFormat = new(this, "GetUnescapedParts", 0, typeof(System.UriComponents), typeof(System.UriFormat));
					r_RGetUnescapedParts_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RGetUnescapedParts_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// System.String ReCreateParts(System.UriComponents, UInt16, System.UriFormat)
		/// </summary>
		protected RMethod r_RReCreateParts_UriComponents_UInt16_UriFormat;
		public virtual RMethod RReCreateParts_UriComponents_UInt16_UriFormat
		{
			get
			{
				if(r_RReCreateParts_UriComponents_UInt16_UriFormat == null)
				{
					r_RReCreateParts_UriComponents_UInt16_UriFormat = new(this, "ReCreateParts", 0, typeof(System.UriComponents), typeof(System.UInt16), typeof(System.UriFormat));
					r_RReCreateParts_UriComponents_UInt16_UriFormat.SetBelong(this.instance);
				}
				return r_RReCreateParts_UriComponents_UInt16_UriFormat;
			}
		}

		/// <summary>
		/// System.String GetUriPartsFromUserString(System.UriComponents)
		/// </summary>
		protected RMethod r_RGetUriPartsFromUserString_UriComponents;
		public virtual RMethod RGetUriPartsFromUserString_UriComponents
		{
			get
			{
				if(r_RGetUriPartsFromUserString_UriComponents == null)
				{
					r_RGetUriPartsFromUserString_UriComponents = new(this, "GetUriPartsFromUserString", 0, typeof(System.UriComponents));
					r_RGetUriPartsFromUserString_UriComponents.SetBelong(this.instance);
				}
				return r_RGetUriPartsFromUserString_UriComponents;
			}
		}

		/// <summary>
		/// Void ParseRemaining()
		/// </summary>
		protected RMethod r_RParseRemaining;
		public virtual RMethod RParseRemaining
		{
			get
			{
				if(r_RParseRemaining == null)
				{
					r_RParseRemaining = new(this, "ParseRemaining", 0);
					r_RParseRemaining.SetBelong(this.instance);
				}
				return r_RParseRemaining;
			}
		}

		/// <summary>
		/// UInt16 ParseSchemeCheckImplicitFile(Char*, UInt16, System.ParsingError ByRef, Flags ByRef, System.UriParser ByRef)
		/// </summary>
		protected static RMethod r_RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser;
		public static RMethod RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser
		{
			get
			{
				if(r_RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser == null)
				{
					r_RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser = new(typeof(System.Uri), "ParseSchemeCheckImplicitFile", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16),  ReleactionUtils.GetType("System.ParsingError").MakeByRefType(),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.UriParser).MakeByRefType());
					r_RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser.SetBelong(null);
				}
				return r_RParseSchemeCheckImplicitFile_CharPointer_UInt16_Ref_ParsingError_Ref_Flags_Ref_UriParser;
			}
		}

		/// <summary>
		/// Boolean CheckKnownSchemes(Int64*, UInt16, System.UriParser ByRef)
		/// </summary>
		protected static RMethod r_RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser;
		public static RMethod RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser
		{
			get
			{
				if(r_RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser == null)
				{
					r_RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser = new(typeof(System.Uri), "CheckKnownSchemes", 0, typeof(System.Int64).MakePointerType(), typeof(System.UInt16), typeof(System.UriParser).MakeByRefType());
					r_RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser.SetBelong(null);
				}
				return r_RCheckKnownSchemes_Int64Pointer_UInt16_Ref_UriParser;
			}
		}

		/// <summary>
		/// System.ParsingError CheckSchemeSyntax(Char*, UInt16, System.UriParser ByRef)
		/// </summary>
		protected static RMethod r_RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser;
		public static RMethod RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser
		{
			get
			{
				if(r_RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser == null)
				{
					r_RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser = new(typeof(System.Uri), "CheckSchemeSyntax", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16), typeof(System.UriParser).MakeByRefType());
					r_RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser.SetBelong(null);
				}
				return r_RCheckSchemeSyntax_CharPointer_UInt16_Ref_UriParser;
			}
		}

		/// <summary>
		/// UInt16 CheckAuthorityHelper(Char*, UInt16, UInt16, System.ParsingError ByRef, Flags ByRef, System.UriParser, System.String ByRef)
		/// </summary>
		protected RMethod r_RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String;
		public virtual RMethod RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String
		{
			get
			{
				if(r_RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String == null)
				{
					r_RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String = new(this, "CheckAuthorityHelper", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16), typeof(System.UInt16),  ReleactionUtils.GetType("System.ParsingError").MakeByRefType(),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.UriParser), typeof(System.String).MakeByRefType());
					r_RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String.SetBelong(this.instance);
				}
				return r_RCheckAuthorityHelper_CharPointer_UInt16_UInt16_Ref_ParsingError_Ref_Flags_UriParser_Ref_String;
			}
		}

		/// <summary>
		/// Void CheckAuthorityHelperHandleDnsIri(Char*, UInt16, Int32, Int32, Boolean, Boolean, System.UriParser, System.String, Flags ByRef, Boolean ByRef, System.String ByRef, System.ParsingError ByRef)
		/// </summary>
		protected RMethod r_RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError;
		public virtual RMethod RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError
		{
			get
			{
				if(r_RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError == null)
				{
					r_RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError = new(this, "CheckAuthorityHelperHandleDnsIri", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UriParser), typeof(System.String),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.String).MakeByRefType(),  ReleactionUtils.GetType("System.ParsingError").MakeByRefType());
					r_RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError.SetBelong(this.instance);
				}
				return r_RCheckAuthorityHelperHandleDnsIri_CharPointer_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_Ref_Flags_Ref_Boolean_Ref_String_Ref_ParsingError;
			}
		}

		/// <summary>
		/// Void CheckAuthorityHelperHandleAnyHostIri(Char*, Int32, Int32, Boolean, Boolean, System.UriParser, Flags ByRef, System.String ByRef, System.ParsingError ByRef)
		/// </summary>
		protected RMethod r_RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError;
		public virtual RMethod RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError
		{
			get
			{
				if(r_RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError == null)
				{
					r_RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError = new(this, "CheckAuthorityHelperHandleAnyHostIri", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.UriParser),  ReleactionUtils.GetType("System.Uri+Flags").MakeByRefType(), typeof(System.String).MakeByRefType(),  ReleactionUtils.GetType("System.ParsingError").MakeByRefType());
					r_RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError.SetBelong(this.instance);
				}
				return r_RCheckAuthorityHelperHandleAnyHostIri_CharPointer_Int32_Int32_Boolean_Boolean_UriParser_Ref_Flags_Ref_String_Ref_ParsingError;
			}
		}

		/// <summary>
		/// Void FindEndOfComponent(System.String, UInt16 ByRef, UInt16, Char)
		/// </summary>
		protected RMethod r_RFindEndOfComponent_String_Ref_UInt16_UInt16_Char;
		public virtual RMethod RFindEndOfComponent_String_Ref_UInt16_UInt16_Char
		{
			get
			{
				if(r_RFindEndOfComponent_String_Ref_UInt16_UInt16_Char == null)
				{
					r_RFindEndOfComponent_String_Ref_UInt16_UInt16_Char = new(this, "FindEndOfComponent", 0, typeof(System.String), typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16), typeof(System.Char));
					r_RFindEndOfComponent_String_Ref_UInt16_UInt16_Char.SetBelong(this.instance);
				}
				return r_RFindEndOfComponent_String_Ref_UInt16_UInt16_Char;
			}
		}

		/// <summary>
		/// Void FindEndOfComponent(Char*, UInt16 ByRef, UInt16, Char)
		/// </summary>
		protected RMethod r_RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char;
		public virtual RMethod RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char
		{
			get
			{
				if(r_RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char == null)
				{
					r_RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char = new(this, "FindEndOfComponent", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16), typeof(System.Char));
					r_RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char.SetBelong(this.instance);
				}
				return r_RFindEndOfComponent_CharPointer_Ref_UInt16_UInt16_Char;
			}
		}

		/// <summary>
		/// Check CheckCanonical(Char*, UInt16 ByRef, UInt16, Char)
		/// </summary>
		protected RMethod r_RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char;
		public virtual RMethod RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char
		{
			get
			{
				if(r_RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char == null)
				{
					r_RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char = new(this, "CheckCanonical", 0, typeof(System.Char).MakePointerType(), typeof(System.UInt16).MakeByRefType(), typeof(System.UInt16), typeof(System.Char));
					r_RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char.SetBelong(this.instance);
				}
				return r_RCheckCanonical_CharPointer_Ref_UInt16_UInt16_Char;
			}
		}

		/// <summary>
		/// Char[] GetCanonicalPath(Char[], Int32 ByRef, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetCanonicalPath_CharArray_Ref_Int32_UriFormat;
		public virtual RMethod RGetCanonicalPath_CharArray_Ref_Int32_UriFormat
		{
			get
			{
				if(r_RGetCanonicalPath_CharArray_Ref_Int32_UriFormat == null)
				{
					r_RGetCanonicalPath_CharArray_Ref_Int32_UriFormat = new(this, "GetCanonicalPath", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(System.UriFormat));
					r_RGetCanonicalPath_CharArray_Ref_Int32_UriFormat.SetBelong(this.instance);
				}
				return r_RGetCanonicalPath_CharArray_Ref_Int32_UriFormat;
			}
		}

		/// <summary>
		/// Void UnescapeOnly(Char*, Int32, Int32 ByRef, Char, Char, Char)
		/// </summary>
		protected static RMethod r_RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char;
		public static RMethod RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char
		{
			get
			{
				if(r_RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char == null)
				{
					r_RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char = new(typeof(System.Uri), "UnescapeOnly", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType(), typeof(System.Char), typeof(System.Char), typeof(System.Char));
					r_RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char.SetBelong(null);
				}
				return r_RUnescapeOnly_CharPointer_Int32_Ref_Int32_Char_Char_Char;
			}
		}

		/// <summary>
		/// Char[] Compress(Char[], UInt16, Int32 ByRef, System.UriParser)
		/// </summary>
		protected static RMethod r_RCompress_CharArray_UInt16_Ref_Int32_UriParser;
		public static RMethod RCompress_CharArray_UInt16_Ref_Int32_UriParser
		{
			get
			{
				if(r_RCompress_CharArray_UInt16_Ref_Int32_UriParser == null)
				{
					r_RCompress_CharArray_UInt16_Ref_Int32_UriParser = new(typeof(System.Uri), "Compress", 0, typeof(System.Char).MakeArrayType(), typeof(System.UInt16), typeof(System.Int32).MakeByRefType(), typeof(System.UriParser));
					r_RCompress_CharArray_UInt16_Ref_Int32_UriParser.SetBelong(null);
				}
				return r_RCompress_CharArray_UInt16_Ref_Int32_UriParser;
			}
		}

		/// <summary>
		/// Int32 CalculateCaseInsensitiveHashCode(System.String)
		/// </summary>
		protected static RMethod r_RCalculateCaseInsensitiveHashCode_String;
		public static RMethod RCalculateCaseInsensitiveHashCode_String
		{
			get
			{
				if(r_RCalculateCaseInsensitiveHashCode_String == null)
				{
					r_RCalculateCaseInsensitiveHashCode_String = new(typeof(System.Uri), "CalculateCaseInsensitiveHashCode", 0, typeof(System.String));
					r_RCalculateCaseInsensitiveHashCode_String.SetBelong(null);
				}
				return r_RCalculateCaseInsensitiveHashCode_String;
			}
		}

		/// <summary>
		/// System.String CombineUri(System.Uri, System.String, System.UriFormat)
		/// </summary>
		protected static RMethod r_RCombineUri_Uri_String_UriFormat;
		public static RMethod RCombineUri_Uri_String_UriFormat
		{
			get
			{
				if(r_RCombineUri_Uri_String_UriFormat == null)
				{
					r_RCombineUri_Uri_String_UriFormat = new(typeof(System.Uri), "CombineUri", 0, typeof(System.Uri), typeof(System.String), typeof(System.UriFormat));
					r_RCombineUri_Uri_String_UriFormat.SetBelong(null);
				}
				return r_RCombineUri_Uri_String_UriFormat;
			}
		}

		/// <summary>
		/// System.String PathDifference(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RPathDifference_String_String_Boolean;
		public static RMethod RPathDifference_String_String_Boolean
		{
			get
			{
				if(r_RPathDifference_String_String_Boolean == null)
				{
					r_RPathDifference_String_String_Boolean = new(typeof(System.Uri), "PathDifference", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RPathDifference_String_String_Boolean.SetBelong(null);
				}
				return r_RPathDifference_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsLWS(Char)
		/// </summary>
		protected static RMethod r_RIsLWS_Char;
		public static RMethod RIsLWS_Char
		{
			get
			{
				if(r_RIsLWS_Char == null)
				{
					r_RIsLWS_Char = new(typeof(System.Uri), "IsLWS", 0, typeof(System.Char));
					r_RIsLWS_Char.SetBelong(null);
				}
				return r_RIsLWS_Char;
			}
		}

		/// <summary>
		/// Boolean IsAsciiLetter(Char)
		/// </summary>
		protected static RMethod r_RIsAsciiLetter_Char;
		public static RMethod RIsAsciiLetter_Char
		{
			get
			{
				if(r_RIsAsciiLetter_Char == null)
				{
					r_RIsAsciiLetter_Char = new(typeof(System.Uri), "IsAsciiLetter", 0, typeof(System.Char));
					r_RIsAsciiLetter_Char.SetBelong(null);
				}
				return r_RIsAsciiLetter_Char;
			}
		}

		/// <summary>
		/// Boolean IsAsciiLetterOrDigit(Char)
		/// </summary>
		protected static RMethod r_RIsAsciiLetterOrDigit_Char;
		public static RMethod RIsAsciiLetterOrDigit_Char
		{
			get
			{
				if(r_RIsAsciiLetterOrDigit_Char == null)
				{
					r_RIsAsciiLetterOrDigit_Char = new(typeof(System.Uri), "IsAsciiLetterOrDigit", 0, typeof(System.Char));
					r_RIsAsciiLetterOrDigit_Char.SetBelong(null);
				}
				return r_RIsAsciiLetterOrDigit_Char;
			}
		}

		/// <summary>
		/// Boolean IsBidiControlCharacter(Char)
		/// </summary>
		protected static RMethod r_RIsBidiControlCharacter_Char;
		public static RMethod RIsBidiControlCharacter_Char
		{
			get
			{
				if(r_RIsBidiControlCharacter_Char == null)
				{
					r_RIsBidiControlCharacter_Char = new(typeof(System.Uri), "IsBidiControlCharacter", 0, typeof(System.Char));
					r_RIsBidiControlCharacter_Char.SetBelong(null);
				}
				return r_RIsBidiControlCharacter_Char;
			}
		}

		/// <summary>
		/// System.String StripBidiControlCharacter(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_RStripBidiControlCharacter_CharPointer_Int32_Int32;
		public static RMethod RStripBidiControlCharacter_CharPointer_Int32_Int32
		{
			get
			{
				if(r_RStripBidiControlCharacter_CharPointer_Int32_Int32 == null)
				{
					r_RStripBidiControlCharacter_CharPointer_Int32_Int32 = new(typeof(System.Uri), "StripBidiControlCharacter", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_RStripBidiControlCharacter_CharPointer_Int32_Int32.SetBelong(null);
				}
				return r_RStripBidiControlCharacter_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String MakeRelative(System.Uri)
		/// </summary>
		protected RMethod r_RMakeRelative_Uri;
		public virtual RMethod RMakeRelative_Uri
		{
			get
			{
				if(r_RMakeRelative_Uri == null)
				{
					r_RMakeRelative_Uri = new(this, "MakeRelative", 0, typeof(System.Uri));
					r_RMakeRelative_Uri.SetBelong(this.instance);
				}
				return r_RMakeRelative_Uri;
			}
		}

		/// <summary>
		/// Void Parse()
		/// </summary>
		protected RMethod r_RParse;
		public virtual RMethod RParse
		{
			get
			{
				if(r_RParse == null)
				{
					r_RParse = new(this, "Parse", 0);
					r_RParse.SetBelong(this.instance);
				}
				return r_RParse;
			}
		}

		/// <summary>
		/// Void Canonicalize()
		/// </summary>
		protected RMethod r_RCanonicalize;
		public virtual RMethod RCanonicalize
		{
			get
			{
				if(r_RCanonicalize == null)
				{
					r_RCanonicalize = new(this, "Canonicalize", 0);
					r_RCanonicalize.SetBelong(this.instance);
				}
				return r_RCanonicalize;
			}
		}

		/// <summary>
		/// Void Escape()
		/// </summary>
		protected RMethod r_REscape;
		public virtual RMethod REscape
		{
			get
			{
				if(r_REscape == null)
				{
					r_REscape = new(this, "Escape", 0);
					r_REscape.SetBelong(this.instance);
				}
				return r_REscape;
			}
		}

		/// <summary>
		/// System.String Unescape(System.String)
		/// </summary>
		protected RMethod r_RUnescape_String;
		public virtual RMethod RUnescape_String
		{
			get
			{
				if(r_RUnescape_String == null)
				{
					r_RUnescape_String = new(this, "Unescape", 0, typeof(System.String));
					r_RUnescape_String.SetBelong(this.instance);
				}
				return r_RUnescape_String;
			}
		}

		/// <summary>
		/// System.String EscapeString(System.String)
		/// </summary>
		protected static RMethod r_REscapeString_String;
		public static RMethod REscapeString_String
		{
			get
			{
				if(r_REscapeString_String == null)
				{
					r_REscapeString_String = new(typeof(System.Uri), "EscapeString", 0, typeof(System.String));
					r_REscapeString_String.SetBelong(null);
				}
				return r_REscapeString_String;
			}
		}

		/// <summary>
		/// Void CheckSecurity()
		/// </summary>
		protected RMethod r_RCheckSecurity;
		public virtual RMethod RCheckSecurity
		{
			get
			{
				if(r_RCheckSecurity == null)
				{
					r_RCheckSecurity = new(this, "CheckSecurity", 0);
					r_RCheckSecurity.SetBelong(this.instance);
				}
				return r_RCheckSecurity;
			}
		}

		/// <summary>
		/// Boolean IsReservedCharacter(Char)
		/// </summary>
		protected RMethod r_RIsReservedCharacter_Char;
		public virtual RMethod RIsReservedCharacter_Char
		{
			get
			{
				if(r_RIsReservedCharacter_Char == null)
				{
					r_RIsReservedCharacter_Char = new(this, "IsReservedCharacter", 0, typeof(System.Char));
					r_RIsReservedCharacter_Char.SetBelong(this.instance);
				}
				return r_RIsReservedCharacter_Char;
			}
		}

		/// <summary>
		/// Boolean IsExcludedCharacter(Char)
		/// </summary>
		protected static RMethod r_RIsExcludedCharacter_Char;
		public static RMethod RIsExcludedCharacter_Char
		{
			get
			{
				if(r_RIsExcludedCharacter_Char == null)
				{
					r_RIsExcludedCharacter_Char = new(typeof(System.Uri), "IsExcludedCharacter", 0, typeof(System.Char));
					r_RIsExcludedCharacter_Char.SetBelong(null);
				}
				return r_RIsExcludedCharacter_Char;
			}
		}

		/// <summary>
		/// Boolean IsBadFileSystemCharacter(Char)
		/// </summary>
		protected RMethod r_RIsBadFileSystemCharacter_Char;
		public virtual RMethod RIsBadFileSystemCharacter_Char
		{
			get
			{
				if(r_RIsBadFileSystemCharacter_Char == null)
				{
					r_RIsBadFileSystemCharacter_Char = new(this, "IsBadFileSystemCharacter", 0, typeof(System.Char));
					r_RIsBadFileSystemCharacter_Char.SetBelong(this.instance);
				}
				return r_RIsBadFileSystemCharacter_Char;
			}
		}

		/// <summary>
		/// Void CreateThis(System.String, Boolean, System.UriKind)
		/// </summary>
		protected RMethod r_RCreateThis_String_Boolean_UriKind;
		public virtual RMethod RCreateThis_String_Boolean_UriKind
		{
			get
			{
				if(r_RCreateThis_String_Boolean_UriKind == null)
				{
					r_RCreateThis_String_Boolean_UriKind = new(this, "CreateThis", 0, typeof(System.String), typeof(System.Boolean), typeof(System.UriKind));
					r_RCreateThis_String_Boolean_UriKind.SetBelong(this.instance);
				}
				return r_RCreateThis_String_Boolean_UriKind;
			}
		}

		/// <summary>
		/// Void InitializeUri(System.ParsingError, System.UriKind, System.UriFormatException ByRef)
		/// </summary>
		protected RMethod r_RInitializeUri_ParsingError_UriKind_Out_UriFormatException;
		public virtual RMethod RInitializeUri_ParsingError_UriKind_Out_UriFormatException
		{
			get
			{
				if(r_RInitializeUri_ParsingError_UriKind_Out_UriFormatException == null)
				{
					r_RInitializeUri_ParsingError_UriKind_Out_UriFormatException = new(this, "InitializeUri", 0,  ReleactionUtils.GetType("System.ParsingError"), typeof(System.UriKind), typeof(System.UriFormatException).MakeByRefType());
					r_RInitializeUri_ParsingError_UriKind_Out_UriFormatException.SetBelong(this.instance);
				}
				return r_RInitializeUri_ParsingError_UriKind_Out_UriFormatException;
			}
		}

		/// <summary>
		/// Boolean CheckForConfigLoad(System.String)
		/// </summary>
		protected RMethod r_RCheckForConfigLoad_String;
		public virtual RMethod RCheckForConfigLoad_String
		{
			get
			{
				if(r_RCheckForConfigLoad_String == null)
				{
					r_RCheckForConfigLoad_String = new(this, "CheckForConfigLoad", 0, typeof(System.String));
					r_RCheckForConfigLoad_String.SetBelong(this.instance);
				}
				return r_RCheckForConfigLoad_String;
			}
		}

		/// <summary>
		/// Boolean CheckForUnicode(System.String)
		/// </summary>
		protected RMethod r_RCheckForUnicode_String;
		public virtual RMethod RCheckForUnicode_String
		{
			get
			{
				if(r_RCheckForUnicode_String == null)
				{
					r_RCheckForUnicode_String = new(this, "CheckForUnicode", 0, typeof(System.String));
					r_RCheckForUnicode_String.SetBelong(this.instance);
				}
				return r_RCheckForUnicode_String;
			}
		}

		/// <summary>
		/// Boolean CheckForEscapedUnreserved(System.String)
		/// </summary>
		protected RMethod r_RCheckForEscapedUnreserved_String;
		public virtual RMethod RCheckForEscapedUnreserved_String
		{
			get
			{
				if(r_RCheckForEscapedUnreserved_String == null)
				{
					r_RCheckForEscapedUnreserved_String = new(this, "CheckForEscapedUnreserved", 0, typeof(System.String));
					r_RCheckForEscapedUnreserved_String.SetBelong(this.instance);
				}
				return r_RCheckForEscapedUnreserved_String;
			}
		}

		/// <summary>
		/// Boolean TryCreate(System.String, System.UriKind, System.Uri ByRef)
		/// </summary>
		protected static RMethod r_RTryCreate_String_UriKind_Out_Uri;
		public static RMethod RTryCreate_String_UriKind_Out_Uri
		{
			get
			{
				if(r_RTryCreate_String_UriKind_Out_Uri == null)
				{
					r_RTryCreate_String_UriKind_Out_Uri = new(typeof(System.Uri), "TryCreate", 0, typeof(System.String), typeof(System.UriKind), typeof(System.Uri).MakeByRefType());
					r_RTryCreate_String_UriKind_Out_Uri.SetBelong(null);
				}
				return r_RTryCreate_String_UriKind_Out_Uri;
			}
		}

		/// <summary>
		/// Boolean TryCreate(System.Uri, System.String, System.Uri ByRef)
		/// </summary>
		protected static RMethod r_RTryCreate_Uri_String_Out_Uri;
		public static RMethod RTryCreate_Uri_String_Out_Uri
		{
			get
			{
				if(r_RTryCreate_Uri_String_Out_Uri == null)
				{
					r_RTryCreate_Uri_String_Out_Uri = new(typeof(System.Uri), "TryCreate", 0, typeof(System.Uri), typeof(System.String), typeof(System.Uri).MakeByRefType());
					r_RTryCreate_Uri_String_Out_Uri.SetBelong(null);
				}
				return r_RTryCreate_Uri_String_Out_Uri;
			}
		}

		/// <summary>
		/// Boolean TryCreate(System.Uri, System.Uri, System.Uri ByRef)
		/// </summary>
		protected static RMethod r_RTryCreate_Uri_Uri_Out_Uri;
		public static RMethod RTryCreate_Uri_Uri_Out_Uri
		{
			get
			{
				if(r_RTryCreate_Uri_Uri_Out_Uri == null)
				{
					r_RTryCreate_Uri_Uri_Out_Uri = new(typeof(System.Uri), "TryCreate", 0, typeof(System.Uri), typeof(System.Uri), typeof(System.Uri).MakeByRefType());
					r_RTryCreate_Uri_Uri_Out_Uri.SetBelong(null);
				}
				return r_RTryCreate_Uri_Uri_Out_Uri;
			}
		}

		/// <summary>
		/// System.String GetComponents(System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetComponents_UriComponents_UriFormat;
		public virtual RMethod RGetComponents_UriComponents_UriFormat
		{
			get
			{
				if(r_RGetComponents_UriComponents_UriFormat == null)
				{
					r_RGetComponents_UriComponents_UriFormat = new(this, "GetComponents", 0, typeof(System.UriComponents), typeof(System.UriFormat));
					r_RGetComponents_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RGetComponents_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Uri, System.Uri, System.UriComponents, System.UriFormat, System.StringComparison)
		/// </summary>
		protected static RMethod r_RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison;
		public static RMethod RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison
		{
			get
			{
				if(r_RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison == null)
				{
					r_RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison = new(typeof(System.Uri), "Compare", 0, typeof(System.Uri), typeof(System.Uri), typeof(System.UriComponents), typeof(System.UriFormat), typeof(System.StringComparison));
					r_RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison.SetBelong(null);
				}
				return r_RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison;
			}
		}

		/// <summary>
		/// Boolean IsWellFormedOriginalString()
		/// </summary>
		protected RMethod r_RIsWellFormedOriginalString;
		public virtual RMethod RIsWellFormedOriginalString
		{
			get
			{
				if(r_RIsWellFormedOriginalString == null)
				{
					r_RIsWellFormedOriginalString = new(this, "IsWellFormedOriginalString", 0);
					r_RIsWellFormedOriginalString.SetBelong(this.instance);
				}
				return r_RIsWellFormedOriginalString;
			}
		}

		/// <summary>
		/// Boolean IsWellFormedUriString(System.String, System.UriKind)
		/// </summary>
		protected static RMethod r_RIsWellFormedUriString_String_UriKind;
		public static RMethod RIsWellFormedUriString_String_UriKind
		{
			get
			{
				if(r_RIsWellFormedUriString_String_UriKind == null)
				{
					r_RIsWellFormedUriString_String_UriKind = new(typeof(System.Uri), "IsWellFormedUriString", 0, typeof(System.String), typeof(System.UriKind));
					r_RIsWellFormedUriString_String_UriKind.SetBelong(null);
				}
				return r_RIsWellFormedUriString_String_UriKind;
			}
		}

		/// <summary>
		/// Boolean InternalIsWellFormedOriginalString()
		/// </summary>
		protected RMethod r_RInternalIsWellFormedOriginalString;
		public virtual RMethod RInternalIsWellFormedOriginalString
		{
			get
			{
				if(r_RInternalIsWellFormedOriginalString == null)
				{
					r_RInternalIsWellFormedOriginalString = new(this, "InternalIsWellFormedOriginalString", 0);
					r_RInternalIsWellFormedOriginalString.SetBelong(this.instance);
				}
				return r_RInternalIsWellFormedOriginalString;
			}
		}

		/// <summary>
		/// System.String UnescapeDataString(System.String)
		/// </summary>
		protected static RMethod r_RUnescapeDataString_String;
		public static RMethod RUnescapeDataString_String
		{
			get
			{
				if(r_RUnescapeDataString_String == null)
				{
					r_RUnescapeDataString_String = new(typeof(System.Uri), "UnescapeDataString", 0, typeof(System.String));
					r_RUnescapeDataString_String.SetBelong(null);
				}
				return r_RUnescapeDataString_String;
			}
		}

		/// <summary>
		/// System.String EscapeUriString(System.String)
		/// </summary>
		protected static RMethod r_REscapeUriString_String;
		public static RMethod REscapeUriString_String
		{
			get
			{
				if(r_REscapeUriString_String == null)
				{
					r_REscapeUriString_String = new(typeof(System.Uri), "EscapeUriString", 0, typeof(System.String));
					r_REscapeUriString_String.SetBelong(null);
				}
				return r_REscapeUriString_String;
			}
		}

		/// <summary>
		/// System.String EscapeDataString(System.String)
		/// </summary>
		protected static RMethod r_REscapeDataString_String;
		public static RMethod REscapeDataString_String
		{
			get
			{
				if(r_REscapeDataString_String == null)
				{
					r_REscapeDataString_String = new(typeof(System.Uri), "EscapeDataString", 0, typeof(System.String));
					r_REscapeDataString_String.SetBelong(null);
				}
				return r_REscapeDataString_String;
			}
		}

		/// <summary>
		/// System.String EscapeUnescapeIri(System.String, Int32, Int32, System.UriComponents)
		/// </summary>
		protected RMethod r_REscapeUnescapeIri_String_Int32_Int32_UriComponents;
		public virtual RMethod REscapeUnescapeIri_String_Int32_Int32_UriComponents
		{
			get
			{
				if(r_REscapeUnescapeIri_String_Int32_Int32_UriComponents == null)
				{
					r_REscapeUnescapeIri_String_Int32_Int32_UriComponents = new(this, "EscapeUnescapeIri", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.UriComponents));
					r_REscapeUnescapeIri_String_Int32_Int32_UriComponents.SetBelong(this.instance);
				}
				return r_REscapeUnescapeIri_String_Int32_Int32_UriComponents;
			}
		}

		/// <summary>
		/// System.Uri CreateHelper(System.String, Boolean, System.UriKind, System.UriFormatException ByRef)
		/// </summary>
		protected static RMethod r_RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException;
		public static RMethod RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException
		{
			get
			{
				if(r_RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException == null)
				{
					r_RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException = new(typeof(System.Uri), "CreateHelper", 0, typeof(System.String), typeof(System.Boolean), typeof(System.UriKind), typeof(System.UriFormatException).MakeByRefType());
					r_RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException.SetBelong(null);
				}
				return r_RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException;
			}
		}

		/// <summary>
		/// System.Uri ResolveHelper(System.Uri, System.Uri, System.String ByRef, Boolean ByRef, System.UriFormatException ByRef)
		/// </summary>
		protected static RMethod r_RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException;
		public static RMethod RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException
		{
			get
			{
				if(r_RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException == null)
				{
					r_RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException = new(typeof(System.Uri), "ResolveHelper", 0, typeof(System.Uri), typeof(System.Uri), typeof(System.String).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.UriFormatException).MakeByRefType());
					r_RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException.SetBelong(null);
				}
				return r_RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException;
			}
		}

		/// <summary>
		/// System.String GetRelativeSerializationString(System.UriFormat)
		/// </summary>
		protected RMethod r_RGetRelativeSerializationString_UriFormat;
		public virtual RMethod RGetRelativeSerializationString_UriFormat
		{
			get
			{
				if(r_RGetRelativeSerializationString_UriFormat == null)
				{
					r_RGetRelativeSerializationString_UriFormat = new(this, "GetRelativeSerializationString", 0, typeof(System.UriFormat));
					r_RGetRelativeSerializationString_UriFormat.SetBelong(this.instance);
				}
				return r_RGetRelativeSerializationString_UriFormat;
			}
		}

		/// <summary>
		/// System.String GetComponentsHelper(System.UriComponents, System.UriFormat)
		/// </summary>
		protected RMethod r_RGetComponentsHelper_UriComponents_UriFormat;
		public virtual RMethod RGetComponentsHelper_UriComponents_UriFormat
		{
			get
			{
				if(r_RGetComponentsHelper_UriComponents_UriFormat == null)
				{
					r_RGetComponentsHelper_UriComponents_UriFormat = new(this, "GetComponentsHelper", 0, typeof(System.UriComponents), typeof(System.UriFormat));
					r_RGetComponentsHelper_UriComponents_UriFormat.SetBelong(this.instance);
				}
				return r_RGetComponentsHelper_UriComponents_UriFormat;
			}
		}

		/// <summary>
		/// Boolean IsBaseOf(System.Uri)
		/// </summary>
		protected RMethod r_RIsBaseOf_Uri;
		public virtual RMethod RIsBaseOf_Uri
		{
			get
			{
				if(r_RIsBaseOf_Uri == null)
				{
					r_RIsBaseOf_Uri = new(this, "IsBaseOf", 0, typeof(System.Uri));
					r_RIsBaseOf_Uri.SetBelong(this.instance);
				}
				return r_RIsBaseOf_Uri;
			}
		}

		/// <summary>
		/// Boolean IsBaseOfHelper(System.Uri)
		/// </summary>
		protected RMethod r_RIsBaseOfHelper_Uri;
		public virtual RMethod RIsBaseOfHelper_Uri
		{
			get
			{
				if(r_RIsBaseOfHelper_Uri == null)
				{
					r_RIsBaseOfHelper_Uri = new(this, "IsBaseOfHelper", 0, typeof(System.Uri));
					r_RIsBaseOfHelper_Uri.SetBelong(this.instance);
				}
				return r_RIsBaseOfHelper_Uri;
			}
		}

		/// <summary>
		/// Void CreateThisFromUri(System.Uri)
		/// </summary>
		protected RMethod r_RCreateThisFromUri_Uri;
		public virtual RMethod RCreateThisFromUri_Uri
		{
			get
			{
				if(r_RCreateThisFromUri_Uri == null)
				{
					r_RCreateThisFromUri_Uri = new(this, "CreateThisFromUri", 0, typeof(System.Uri));
					r_RCreateThisFromUri_Uri.SetBelong(this.instance);
				}
				return r_RCreateThisFromUri_Uri;
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


        public RUri() : base("System.Uri")
        {
        }

        public RUri(System.Object instance) : base("System.Uri")
		{
            SetInstance(instance);
		}

        public RUri(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUri(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IriParsingStatic(System.UriParser  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RIriParsingStatic_UriParser.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean IsIntranet(System.String  @schemeHost)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemeHost};
            var ___result = RIsIntranet_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetUserDrivenParsing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetUserDrivenParsing.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Object EnsureUriInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureUriInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void EnsureParseRemaining()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureParseRemaining.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureHostString(System.Boolean  @allowDnsOptimization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allowDnsOptimization};
            var ___result = REnsureHostString_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateUri(System.Uri  @baseUri, System.String  @relativeUri, System.Boolean  @dontEscape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri, @dontEscape};
            var ___result = RCreateUri_Uri_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetCombinedString(System.Uri  @baseUri, System.String  @relativeStr, System.Boolean  @dontEscape, ref System.String  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeStr, @dontEscape, @result};
            var ___result = RGetCombinedString_Uri_String_Boolean_Ref_String.Invoke(___genericsType, ___parameters);
			result = (System.String)___parameters[3];

            return (System.Object)___result;
        }



        public virtual void System__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData(System.Runtime.Serialization.SerializationInfo  @serializationInfo, System.Runtime.Serialization.StreamingContext  @streamingContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializationInfo, @streamingContext};
            var ___result = RSystem__1__Runtime__1__Serialization__1__ISerializable__1__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @serializationInfo, System.Runtime.Serialization.StreamingContext  @streamingContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializationInfo, @streamingContext};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StaticIsFile(System.UriParser  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RStaticIsFile_UriParser.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void InitializeUriConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeUriConfig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetLocalPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocalPath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.UriHostNameType CheckHostName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCheckHostName_String.Invoke(___genericsType, ___parameters);

            return (System.UriHostNameType)___result;
        }


        public virtual System.String GetLeftPart(System.UriPartial  @part)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@part};
            var ___result = RGetLeftPart_UriPartial.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String HexEscape(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RHexEscape_Char.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char HexUnescape(System.String  @pattern, ref System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pattern, @index};
            var ___result = RHexUnescape_String_Ref_Int32.Invoke(___genericsType, ___parameters);
			index = (System.Int32)___parameters[1];

            return (System.Char)___result;
        }


        public static System.Boolean IsHexEncoding(System.String  @pattern, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pattern, @index};
            var ___result = RIsHexEncoding_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsGenDelim(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsGenDelim_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckSchemeName(System.String  @schemeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemeName};
            var ___result = RCheckSchemeName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsHexDigit(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsHexDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 FromHex(System.Char  @digit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@digit};
            var ___result = RFromHex_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(System.Uri  @uri1, System.Uri  @uri2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri1, @uri2};
            var ___result = Rop_Equality_Uri_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Uri  @uri1, System.Uri  @uri2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri1, @uri2};
            var ___result = Rop_Inequality_Uri_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @comparand)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparand};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Uri MakeRelativeUri(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RMakeRelativeUri_Uri.Invoke(___genericsType, ___parameters);

            return (System.Uri)___result;
        }


        public static System.Boolean CheckForColonInFirstPathSegment(System.String  @uriString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriString};
            var ___result = RCheckForColonInFirstPathSegment_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String InternalEscapeString(System.String  @rawString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawString};
            var ___result = RInternalEscapeString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.UriFormatException ParseMinimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseMinimal.Invoke(___genericsType, ___parameters);

            return (System.UriFormatException)___result;
        }


        public virtual System.Object PrivateParseMinimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrivateParseMinimal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void PrivateParseMinimalIri(System.String  @newHost, System.UInt16  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newHost, @idx};
            var ___result = RPrivateParseMinimalIri_String_UInt16.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void CreateHostString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateHostString.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void GetHostViaCustomSyntax()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHostViaCustomSyntax.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetParts(System.UriComponents  @uriParts, System.UriFormat  @formatAs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriParts, @formatAs};
            var ___result = RGetParts_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetEscapedParts(System.UriComponents  @uriParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriParts};
            var ___result = RGetEscapedParts_UriComponents.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetUnescapedParts(System.UriComponents  @uriParts, System.UriFormat  @formatAs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriParts, @formatAs};
            var ___result = RGetUnescapedParts_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReCreateParts(System.UriComponents  @parts, System.UInt16  @nonCanonical, System.UriFormat  @formatAs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parts, @nonCanonical, @formatAs};
            var ___result = RReCreateParts_UriComponents_UInt16_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetUriPartsFromUserString(System.UriComponents  @uriParts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriParts};
            var ___result = RGetUriPartsFromUserString_UriComponents.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ParseRemaining()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseRemaining.Invoke(___genericsType, ___parameters);

            
        }








        public virtual void FindEndOfComponent(System.String  @input, ref System.UInt16  @idx, System.UInt16  @end, System.Char  @delim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @idx, @end, @delim};
            var ___result = RFindEndOfComponent_String_Ref_UInt16_UInt16_Char.Invoke(___genericsType, ___parameters);
			idx = (System.UInt16)___parameters[1];

            
        }




        public virtual System.Char[] GetCanonicalPath(System.Char[]  @dest, ref System.Int32  @pos, System.UriFormat  @formatAs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @pos, @formatAs};
            var ___result = RGetCanonicalPath_CharArray_Ref_Int32_UriFormat.Invoke(___genericsType, ___parameters);
			pos = (System.Int32)___parameters[1];

            return (System.Char[])___result;
        }



        public static System.Char[] Compress(System.Char[]  @dest, System.UInt16  @start, ref System.Int32  @destLength, System.UriParser  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @start, @destLength, @syntax};
            var ___result = RCompress_CharArray_UInt16_Ref_Int32_UriParser.Invoke(___genericsType, ___parameters);
			destLength = (System.Int32)___parameters[2];

            return (System.Char[])___result;
        }


        public static System.Int32 CalculateCaseInsensitiveHashCode(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RCalculateCaseInsensitiveHashCode_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.String CombineUri(System.Uri  @basePart, System.String  @relativePart, System.UriFormat  @uriFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@basePart, @relativePart, @uriFormat};
            var ___result = RCombineUri_Uri_String_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String PathDifference(System.String  @path1, System.String  @path2, System.Boolean  @compareCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path1, @path2, @compareCase};
            var ___result = RPathDifference_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean IsLWS(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsLWS_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAsciiLetter(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsAsciiLetter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAsciiLetterOrDigit(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsAsciiLetterOrDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsBidiControlCharacter(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsBidiControlCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.String MakeRelative(System.Uri  @toUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toUri};
            var ___result = RMakeRelative_Uri.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Parse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Canonicalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanonicalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Escape()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REscape.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Unescape(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RUnescape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String EscapeString(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = REscapeString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CheckSecurity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckSecurity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsReservedCharacter(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsReservedCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsExcludedCharacter(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsExcludedCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsBadFileSystemCharacter(System.Char  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character};
            var ___result = RIsBadFileSystemCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreateThis(System.String  @uri, System.Boolean  @dontEscape, System.UriKind  @uriKind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @dontEscape, @uriKind};
            var ___result = RCreateThis_String_Boolean_UriKind.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean CheckForConfigLoad(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCheckForConfigLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckForUnicode(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCheckForUnicode_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckForEscapedUnreserved(System.String  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RCheckForEscapedUnreserved_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean TryCreate(System.String  @uriString, System.UriKind  @uriKind, out System.Uri  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriString, @uriKind, @result};
            var ___result = RTryCreate_String_UriKind_Out_Uri.Invoke(___genericsType, ___parameters);
			result = (System.Uri)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryCreate(System.Uri  @baseUri, System.String  @relativeUri, out System.Uri  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri, @result};
            var ___result = RTryCreate_Uri_String_Out_Uri.Invoke(___genericsType, ___parameters);
			result = (System.Uri)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Boolean TryCreate(System.Uri  @baseUri, System.Uri  @relativeUri, out System.Uri  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri, @result};
            var ___result = RTryCreate_Uri_Uri_Out_Uri.Invoke(___genericsType, ___parameters);
			result = (System.Uri)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.String GetComponents(System.UriComponents  @components, System.UriFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@components, @format};
            var ___result = RGetComponents_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 Compare(System.Uri  @uri1, System.Uri  @uri2, System.UriComponents  @partsToCompare, System.UriFormat  @compareFormat, System.StringComparison  @comparisonType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri1, @uri2, @partsToCompare, @compareFormat, @comparisonType};
            var ___result = RCompare_Uri_Uri_UriComponents_UriFormat_StringComparison.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsWellFormedOriginalString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsWellFormedOriginalString.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWellFormedUriString(System.String  @uriString, System.UriKind  @uriKind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriString, @uriKind};
            var ___result = RIsWellFormedUriString_String_UriKind.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InternalIsWellFormedOriginalString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalIsWellFormedOriginalString.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String UnescapeDataString(System.String  @stringToUnescape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stringToUnescape};
            var ___result = RUnescapeDataString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String EscapeUriString(System.String  @stringToEscape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stringToEscape};
            var ___result = REscapeUriString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String EscapeDataString(System.String  @stringToEscape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stringToEscape};
            var ___result = REscapeDataString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String EscapeUnescapeIri(System.String  @input, System.Int32  @start, System.Int32  @end, System.UriComponents  @component)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @start, @end, @component};
            var ___result = REscapeUnescapeIri_String_Int32_Int32_UriComponents.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Uri CreateHelper(System.String  @uriString, System.Boolean  @dontEscape, System.UriKind  @uriKind, ref System.UriFormatException  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriString, @dontEscape, @uriKind, @e};
            var ___result = RCreateHelper_String_Boolean_UriKind_Ref_UriFormatException.Invoke(___genericsType, ___parameters);
			e = (System.UriFormatException)___parameters[3];

            return (System.Uri)___result;
        }


        public static System.Uri ResolveHelper(System.Uri  @baseUri, System.Uri  @relativeUri, ref System.String  @newUriString, ref System.Boolean  @userEscaped, out System.UriFormatException  @e)
        {
			e = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri, @newUriString, @userEscaped, @e};
            var ___result = RResolveHelper_Uri_Uri_Ref_String_Ref_Boolean_Out_UriFormatException.Invoke(___genericsType, ___parameters);
			newUriString = (System.String)___parameters[2];
			userEscaped = (System.Boolean)___parameters[3];
			e = (System.UriFormatException)___parameters[4];

            return (System.Uri)___result;
        }


        public virtual System.String GetRelativeSerializationString(System.UriFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RGetRelativeSerializationString_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetComponentsHelper(System.UriComponents  @uriComponents, System.UriFormat  @uriFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriComponents, @uriFormat};
            var ___result = RGetComponentsHelper_UriComponents_UriFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsBaseOf(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RIsBaseOf_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsBaseOfHelper(System.Uri  @uriLink)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uriLink};
            var ___result = RIsBaseOfHelper_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreateThisFromUri(System.Uri  @otherUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@otherUri};
            var ___result = RCreateThisFromUri_Uri.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
