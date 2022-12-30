using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.AppDomain
	/// </summary>
    public partial class RAppDomain : RMember //
    {

		/// <summary>
		/// System.IntPtr _mono_app_domain
		/// </summary>
		protected RField r__mono_app_domain;
		public virtual RField R_mono_app_domain
		{
			get
			{
				if(r__mono_app_domain == null)
				{
					r__mono_app_domain = new(this, "_mono_app_domain");
					r__mono_app_domain.SetBelong(this.instance);
				}
				return r__mono_app_domain;
			}
		}

		/// <summary>
		/// System.String _process_guid
		/// </summary>
		protected static RField r__process_guid;
		public static RField R_process_guid
		{
			get
			{
				if(r__process_guid == null)
				{
					r__process_guid = new(typeof(System.AppDomain), "_process_guid");
					r__process_guid.SetBelong(null);
				}
				return r__process_guid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] type_resolve_in_progress
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> r_type_resolve_in_progress;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> Rtype_resolve_in_progress
		{
			get
			{
				if(r_type_resolve_in_progress == null)
				{
					r_type_resolve_in_progress = new(typeof(System.AppDomain), "type_resolve_in_progress");
					r_type_resolve_in_progress.SetBelong(null);
				}
				return r_type_resolve_in_progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] assembly_resolve_in_progress
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> r_assembly_resolve_in_progress;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> Rassembly_resolve_in_progress
		{
			get
			{
				if(r_assembly_resolve_in_progress == null)
				{
					r_assembly_resolve_in_progress = new(typeof(System.AppDomain), "assembly_resolve_in_progress");
					r_assembly_resolve_in_progress.SetBelong(null);
				}
				return r_assembly_resolve_in_progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] assembly_resolve_in_progress_refonly
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> r_assembly_resolve_in_progress_refonly;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> Rassembly_resolve_in_progress_refonly
		{
			get
			{
				if(r_assembly_resolve_in_progress_refonly == null)
				{
					r_assembly_resolve_in_progress_refonly = new(typeof(System.AppDomain), "assembly_resolve_in_progress_refonly");
					r_assembly_resolve_in_progress_refonly.SetBelong(null);
				}
				return r_assembly_resolve_in_progress_refonly;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence _evidence
		/// </summary>
		protected RSystem.RSecurity.RPolicy.REvidence r__evidence;
		public virtual RSystem.RSecurity.RPolicy.REvidence R_evidence
		{
			get
			{
				if(r__evidence == null)
				{
					r__evidence = new(this, "_evidence");
					r__evidence.SetBelong(this.instance);
				}
				return r__evidence;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _granted
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__granted;
		public virtual RSystem.RSecurity.RPermissionSet R_granted
		{
			get
			{
				if(r__granted == null)
				{
					r__granted = new(this, "_granted");
					r__granted.SetBelong(this.instance);
				}
				return r__granted;
			}
		}

		/// <summary>
		/// System.Security.Principal.PrincipalPolicy _principalPolicy
		/// </summary>
		protected RField r__principalPolicy;
		public virtual RField R_principalPolicy
		{
			get
			{
				if(r__principalPolicy == null)
				{
					r__principalPolicy = new(this, "_principalPolicy");
					r__principalPolicy.SetBelong(this.instance);
				}
				return r__principalPolicy;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal _principal
		/// </summary>
		protected static RSystem.RSecurity.RPrincipal.RIPrincipal r__principal;
		public static RSystem.RSecurity.RPrincipal.RIPrincipal R_principal
		{
			get
			{
				if(r__principal == null)
				{
					r__principal = new(typeof(System.AppDomain), "_principal");
					r__principal.SetBelong(null);
				}
				return r__principal;
			}
		}

		/// <summary>
		/// System.AppDomain default_domain
		/// </summary>
		protected static RSystem.RAppDomain r_default_domain;
		public static RSystem.RAppDomain Rdefault_domain
		{
			get
			{
				if(r_default_domain == null)
				{
					r_default_domain = new(typeof(System.AppDomain), "default_domain");
					r_default_domain.SetBelong(null);
				}
				return r_default_domain;
			}
		}

		/// <summary>
		/// System.AssemblyLoadEventHandler AssemblyLoad
		/// </summary>
		protected RSystem.RAssemblyLoadEventHandler r_AssemblyLoad;
		public virtual RSystem.RAssemblyLoadEventHandler RAssemblyLoad
		{
			get
			{
				if(r_AssemblyLoad == null)
				{
					r_AssemblyLoad = new(this, "AssemblyLoad");
					r_AssemblyLoad.SetBelong(this.instance);
				}
				return r_AssemblyLoad;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler AssemblyResolve
		/// </summary>
		protected RSystem.RResolveEventHandler r_AssemblyResolve;
		public virtual RSystem.RResolveEventHandler RAssemblyResolve
		{
			get
			{
				if(r_AssemblyResolve == null)
				{
					r_AssemblyResolve = new(this, "AssemblyResolve");
					r_AssemblyResolve.SetBelong(this.instance);
				}
				return r_AssemblyResolve;
			}
		}

		/// <summary>
		/// System.EventHandler DomainUnload
		/// </summary>
		protected RSystem.REventHandler r_DomainUnload;
		public virtual RSystem.REventHandler RDomainUnload
		{
			get
			{
				if(r_DomainUnload == null)
				{
					r_DomainUnload = new(this, "DomainUnload");
					r_DomainUnload.SetBelong(this.instance);
				}
				return r_DomainUnload;
			}
		}

		/// <summary>
		/// System.EventHandler ProcessExit
		/// </summary>
		protected RSystem.REventHandler r_ProcessExit;
		public virtual RSystem.REventHandler RProcessExit
		{
			get
			{
				if(r_ProcessExit == null)
				{
					r_ProcessExit = new(this, "ProcessExit");
					r_ProcessExit.SetBelong(this.instance);
				}
				return r_ProcessExit;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ResourceResolve
		/// </summary>
		protected RSystem.RResolveEventHandler r_ResourceResolve;
		public virtual RSystem.RResolveEventHandler ResourceResolve
		{
			get
			{
				if(r_ResourceResolve == null)
				{
					r_ResourceResolve = new(this, "ResourceResolve");
					r_ResourceResolve.SetBelong(this.instance);
				}
				return r_ResourceResolve;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler TypeResolve
		/// </summary>
		protected RSystem.RResolveEventHandler r_TypeResolve;
		public virtual RSystem.RResolveEventHandler RTypeResolve
		{
			get
			{
				if(r_TypeResolve == null)
				{
					r_TypeResolve = new(this, "TypeResolve");
					r_TypeResolve.SetBelong(this.instance);
				}
				return r_TypeResolve;
			}
		}

		/// <summary>
		/// System.UnhandledExceptionEventHandler UnhandledException
		/// </summary>
		protected RSystem.RUnhandledExceptionEventHandler r_UnhandledException;
		public virtual RSystem.RUnhandledExceptionEventHandler RUnhandledException
		{
			get
			{
				if(r_UnhandledException == null)
				{
					r_UnhandledException = new(this, "UnhandledException");
					r_UnhandledException.SetBelong(this.instance);
				}
				return r_UnhandledException;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs] FirstChanceException
		/// </summary>
		protected RSystem.REventHandler<RSystem.RRuntime.RExceptionServices.RFirstChanceExceptionEventArgs> r_FirstChanceException;
		public virtual RSystem.REventHandler<RSystem.RRuntime.RExceptionServices.RFirstChanceExceptionEventArgs> RFirstChanceException
		{
			get
			{
				if(r_FirstChanceException == null)
				{
					r_FirstChanceException = new(this, "FirstChanceException");
					r_FirstChanceException.SetBelong(this.instance);
				}
				return r_FirstChanceException;
			}
		}

		/// <summary>
		/// System.AppDomainManager _domain_manager
		/// </summary>
		protected RSystem.RAppDomainManager r__domain_manager;
		public virtual RSystem.RAppDomainManager R_domain_manager
		{
			get
			{
				if(r__domain_manager == null)
				{
					r__domain_manager = new(this, "_domain_manager");
					r__domain_manager.SetBelong(this.instance);
				}
				return r__domain_manager;
			}
		}

		/// <summary>
		/// System.ResolveEventHandler ReflectionOnlyAssemblyResolve
		/// </summary>
		protected RSystem.RResolveEventHandler r_ReflectionOnlyAssemblyResolve;
		public virtual RSystem.RResolveEventHandler ReflectionOnlyAssemblyResolve
		{
			get
			{
				if(r_ReflectionOnlyAssemblyResolve == null)
				{
					r_ReflectionOnlyAssemblyResolve = new(this, "ReflectionOnlyAssemblyResolve");
					r_ReflectionOnlyAssemblyResolve.SetBelong(this.instance);
				}
				return r_ReflectionOnlyAssemblyResolve;
			}
		}

		/// <summary>
		/// System.ActivationContext _activation
		/// </summary>
		protected RSystem.RActivationContext r__activation;
		public virtual RSystem.RActivationContext R_activation
		{
			get
			{
				if(r__activation == null)
				{
					r__activation = new(this, "_activation");
					r__activation.SetBelong(this.instance);
				}
				return r__activation;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity _applicationIdentity
		/// </summary>
		protected RSystem.RApplicationIdentity r__applicationIdentity;
		public virtual RSystem.RApplicationIdentity R_applicationIdentity
		{
			get
			{
				if(r__applicationIdentity == null)
				{
					r__applicationIdentity = new(this, "_applicationIdentity");
					r__applicationIdentity.SetBelong(this.instance);
				}
				return r__applicationIdentity;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] compatibility_switch
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_compatibility_switch;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rcompatibility_switch
		{
			get
			{
				if(r_compatibility_switch == null)
				{
					r_compatibility_switch = new(this, "compatibility_switch");
					r_compatibility_switch.SetBelong(this.instance);
				}
				return r_compatibility_switch;
			}
		}

		/// <summary>
		/// System.AppDomainSetup SetupInformationNoCopy
		/// </summary>
		protected RSystem.RAppDomainSetup r_SetupInformationNoCopy;
		public virtual RSystem.RAppDomainSetup RSetupInformationNoCopy
		{
			get
			{
				if(r_SetupInformationNoCopy == null)
				{
					r_SetupInformationNoCopy = new(this, "SetupInformationNoCopy", -1);
					r_SetupInformationNoCopy.SetBelong(this.instance);
				}
				return r_SetupInformationNoCopy;
			}
		}

		/// <summary>
		/// System.AppDomainSetup SetupInformation
		/// </summary>
		protected RSystem.RAppDomainSetup r_SetupInformation;
		public virtual RSystem.RAppDomainSetup RSetupInformation
		{
			get
			{
				if(r_SetupInformation == null)
				{
					r_SetupInformation = new(this, "SetupInformation", -1);
					r_SetupInformation.SetBelong(this.instance);
				}
				return r_SetupInformation;
			}
		}

		/// <summary>
		/// System.Security.Policy.ApplicationTrust ApplicationTrust
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RApplicationTrust r_ApplicationTrust;
		public virtual RSystem.RSecurity.RPolicy.RApplicationTrust RApplicationTrust
		{
			get
			{
				if(r_ApplicationTrust == null)
				{
					r_ApplicationTrust = new(this, "ApplicationTrust", -1);
					r_ApplicationTrust.SetBelong(this.instance);
				}
				return r_ApplicationTrust;
			}
		}

		/// <summary>
		/// System.String BaseDirectory
		/// </summary>
		protected RProperty r_BaseDirectory;
		public virtual RProperty RBaseDirectory
		{
			get
			{
				if(r_BaseDirectory == null)
				{
					r_BaseDirectory = new(this, "BaseDirectory", -1);
					r_BaseDirectory.SetBelong(this.instance);
				}
				return r_BaseDirectory;
			}
		}

		/// <summary>
		/// System.String RelativeSearchPath
		/// </summary>
		protected RProperty r_RelativeSearchPath;
		public virtual RProperty RelativeSearchPath
		{
			get
			{
				if(r_RelativeSearchPath == null)
				{
					r_RelativeSearchPath = new(this, "RelativeSearchPath", -1);
					r_RelativeSearchPath.SetBelong(this.instance);
				}
				return r_RelativeSearchPath;
			}
		}

		/// <summary>
		/// System.String DynamicDirectory
		/// </summary>
		protected RProperty r_DynamicDirectory;
		public virtual RProperty RDynamicDirectory
		{
			get
			{
				if(r_DynamicDirectory == null)
				{
					r_DynamicDirectory = new(this, "DynamicDirectory", -1);
					r_DynamicDirectory.SetBelong(this.instance);
				}
				return r_DynamicDirectory;
			}
		}

		/// <summary>
		/// Boolean ShadowCopyFiles
		/// </summary>
		protected RProperty r_ShadowCopyFiles;
		public virtual RProperty RShadowCopyFiles
		{
			get
			{
				if(r_ShadowCopyFiles == null)
				{
					r_ShadowCopyFiles = new(this, "ShadowCopyFiles", -1);
					r_ShadowCopyFiles.SetBelong(this.instance);
				}
				return r_ShadowCopyFiles;
			}
		}

		/// <summary>
		/// System.String FriendlyName
		/// </summary>
		protected RProperty r_FriendlyName;
		public virtual RProperty RFriendlyName
		{
			get
			{
				if(r_FriendlyName == null)
				{
					r_FriendlyName = new(this, "FriendlyName", -1);
					r_FriendlyName.SetBelong(this.instance);
				}
				return r_FriendlyName;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence Evidence
		/// </summary>
		protected RSystem.RSecurity.RPolicy.REvidence r_Evidence;
		public virtual RSystem.RSecurity.RPolicy.REvidence REvidence
		{
			get
			{
				if(r_Evidence == null)
				{
					r_Evidence = new(this, "Evidence", -1);
					r_Evidence.SetBelong(this.instance);
				}
				return r_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal DefaultPrincipal
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIPrincipal r_DefaultPrincipal;
		public virtual RSystem.RSecurity.RPrincipal.RIPrincipal RDefaultPrincipal
		{
			get
			{
				if(r_DefaultPrincipal == null)
				{
					r_DefaultPrincipal = new(this, "DefaultPrincipal", -1);
					r_DefaultPrincipal.SetBelong(this.instance);
				}
				return r_DefaultPrincipal;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet GrantedPermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_GrantedPermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RGrantedPermissionSet
		{
			get
			{
				if(r_GrantedPermissionSet == null)
				{
					r_GrantedPermissionSet = new(this, "GrantedPermissionSet", -1);
					r_GrantedPermissionSet.SetBelong(this.instance);
				}
				return r_GrantedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet PermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_PermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RPermissionSet
		{
			get
			{
				if(r_PermissionSet == null)
				{
					r_PermissionSet = new(this, "PermissionSet", -1);
					r_PermissionSet.SetBelong(this.instance);
				}
				return r_PermissionSet;
			}
		}

		/// <summary>
		/// System.AppDomain CurrentDomain
		/// </summary>
		protected static RSystem.RAppDomain r_CurrentDomain;
		public static RSystem.RAppDomain RCurrentDomain
		{
			get
			{
				if(r_CurrentDomain == null)
				{
					r_CurrentDomain = new(typeof(System.AppDomain), "CurrentDomain", -1);
					r_CurrentDomain.SetBelong(null);
				}
				return r_CurrentDomain;
			}
		}

		/// <summary>
		/// System.AppDomain DefaultDomain
		/// </summary>
		protected static RSystem.RAppDomain r_DefaultDomain;
		public static RSystem.RAppDomain RDefaultDomain
		{
			get
			{
				if(r_DefaultDomain == null)
				{
					r_DefaultDomain = new(typeof(System.AppDomain), "DefaultDomain", -1);
					r_DefaultDomain.SetBelong(null);
				}
				return r_DefaultDomain;
			}
		}

		/// <summary>
		/// Boolean IsHomogenous
		/// </summary>
		protected RProperty r_IsHomogenous;
		public virtual RProperty RIsHomogenous
		{
			get
			{
				if(r_IsHomogenous == null)
				{
					r_IsHomogenous = new(this, "IsHomogenous", -1);
					r_IsHomogenous.SetBelong(this.instance);
				}
				return r_IsHomogenous;
			}
		}

		/// <summary>
		/// Boolean IsFullyTrusted
		/// </summary>
		protected RProperty r_IsFullyTrusted;
		public virtual RProperty RIsFullyTrusted
		{
			get
			{
				if(r_IsFullyTrusted == null)
				{
					r_IsFullyTrusted = new(this, "IsFullyTrusted", -1);
					r_IsFullyTrusted.SetBelong(this.instance);
				}
				return r_IsFullyTrusted;
			}
		}

		/// <summary>
		/// System.AppDomainManager DomainManager
		/// </summary>
		protected RSystem.RAppDomainManager r_DomainManager;
		public virtual RSystem.RAppDomainManager RDomainManager
		{
			get
			{
				if(r_DomainManager == null)
				{
					r_DomainManager = new(this, "DomainManager", -1);
					r_DomainManager.SetBelong(this.instance);
				}
				return r_DomainManager;
			}
		}

		/// <summary>
		/// System.ActivationContext ActivationContext
		/// </summary>
		protected RSystem.RActivationContext r_ActivationContext;
		public virtual RSystem.RActivationContext RActivationContext
		{
			get
			{
				if(r_ActivationContext == null)
				{
					r_ActivationContext = new(this, "ActivationContext", -1);
					r_ActivationContext.SetBelong(this.instance);
				}
				return r_ActivationContext;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected RSystem.RApplicationIdentity r_ApplicationIdentity;
		public virtual RSystem.RApplicationIdentity RApplicationIdentity
		{
			get
			{
				if(r_ApplicationIdentity == null)
				{
					r_ApplicationIdentity = new(this, "ApplicationIdentity", -1);
					r_ApplicationIdentity.SetBelong(this.instance);
				}
				return r_ApplicationIdentity;
			}
		}

		/// <summary>
		/// Int32 Id
		/// </summary>
		protected RProperty r_Id;
		public virtual RProperty RId
		{
			get
			{
				if(r_Id == null)
				{
					r_Id = new(this, "Id", -1);
					r_Id.SetBelong(this.instance);
				}
				return r_Id;
			}
		}

		/// <summary>
		/// Boolean MonitoringIsEnabled
		/// </summary>
		protected static RProperty r_MonitoringIsEnabled;
		public static RProperty RMonitoringIsEnabled
		{
			get
			{
				if(r_MonitoringIsEnabled == null)
				{
					r_MonitoringIsEnabled = new(typeof(System.AppDomain), "MonitoringIsEnabled", -1);
					r_MonitoringIsEnabled.SetBelong(null);
				}
				return r_MonitoringIsEnabled;
			}
		}

		/// <summary>
		/// Int64 MonitoringSurvivedMemorySize
		/// </summary>
		protected RProperty r_MonitoringSurvivedMemorySize;
		public virtual RProperty RMonitoringSurvivedMemorySize
		{
			get
			{
				if(r_MonitoringSurvivedMemorySize == null)
				{
					r_MonitoringSurvivedMemorySize = new(this, "MonitoringSurvivedMemorySize", -1);
					r_MonitoringSurvivedMemorySize.SetBelong(this.instance);
				}
				return r_MonitoringSurvivedMemorySize;
			}
		}

		/// <summary>
		/// Int64 MonitoringSurvivedProcessMemorySize
		/// </summary>
		protected static RProperty r_MonitoringSurvivedProcessMemorySize;
		public static RProperty RMonitoringSurvivedProcessMemorySize
		{
			get
			{
				if(r_MonitoringSurvivedProcessMemorySize == null)
				{
					r_MonitoringSurvivedProcessMemorySize = new(typeof(System.AppDomain), "MonitoringSurvivedProcessMemorySize", -1);
					r_MonitoringSurvivedProcessMemorySize.SetBelong(null);
				}
				return r_MonitoringSurvivedProcessMemorySize;
			}
		}

		/// <summary>
		/// Int64 MonitoringTotalAllocatedMemorySize
		/// </summary>
		protected RProperty r_MonitoringTotalAllocatedMemorySize;
		public virtual RProperty RMonitoringTotalAllocatedMemorySize
		{
			get
			{
				if(r_MonitoringTotalAllocatedMemorySize == null)
				{
					r_MonitoringTotalAllocatedMemorySize = new(this, "MonitoringTotalAllocatedMemorySize", -1);
					r_MonitoringTotalAllocatedMemorySize.SetBelong(this.instance);
				}
				return r_MonitoringTotalAllocatedMemorySize;
			}
		}

		/// <summary>
		/// System.TimeSpan MonitoringTotalProcessorTime
		/// </summary>
		protected RSystem.RTimeSpan r_MonitoringTotalProcessorTime;
		public virtual RSystem.RTimeSpan RMonitoringTotalProcessorTime
		{
			get
			{
				if(r_MonitoringTotalProcessorTime == null)
				{
					r_MonitoringTotalProcessorTime = new(this, "MonitoringTotalProcessorTime", -1);
					r_MonitoringTotalProcessorTime.SetBelong(this.instance);
				}
				return r_MonitoringTotalProcessorTime;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Boolean IsAppXModel()
		/// </summary>
		protected static RMethod r_RIsAppXModel;
		public static RMethod RIsAppXModel
		{
			get
			{
				if(r_RIsAppXModel == null)
				{
					r_RIsAppXModel = new(typeof(System.AppDomain), "IsAppXModel", 0);
					r_RIsAppXModel.SetBelong(null);
				}
				return r_RIsAppXModel;
			}
		}

		/// <summary>
		/// Boolean IsAppXDesignMode()
		/// </summary>
		protected static RMethod r_RIsAppXDesignMode;
		public static RMethod RIsAppXDesignMode
		{
			get
			{
				if(r_RIsAppXDesignMode == null)
				{
					r_RIsAppXDesignMode = new(typeof(System.AppDomain), "IsAppXDesignMode", 0);
					r_RIsAppXDesignMode.SetBelong(null);
				}
				return r_RIsAppXDesignMode;
			}
		}

		/// <summary>
		/// Void CheckReflectionOnlyLoadSupported()
		/// </summary>
		protected static RMethod r_RCheckReflectionOnlyLoadSupported;
		public static RMethod RCheckReflectionOnlyLoadSupported
		{
			get
			{
				if(r_RCheckReflectionOnlyLoadSupported == null)
				{
					r_RCheckReflectionOnlyLoadSupported = new(typeof(System.AppDomain), "CheckReflectionOnlyLoadSupported", 0);
					r_RCheckReflectionOnlyLoadSupported.SetBelong(null);
				}
				return r_RCheckReflectionOnlyLoadSupported;
			}
		}

		/// <summary>
		/// Void CheckLoadFromSupported()
		/// </summary>
		protected static RMethod r_RCheckLoadFromSupported;
		public static RMethod RCheckLoadFromSupported
		{
			get
			{
				if(r_RCheckLoadFromSupported == null)
				{
					r_RCheckLoadFromSupported = new(typeof(System.AppDomain), "CheckLoadFromSupported", 0);
					r_RCheckLoadFromSupported.SetBelong(null);
				}
				return r_RCheckLoadFromSupported;
			}
		}

		/// <summary>
		/// System.AppDomainSetup getSetup()
		/// </summary>
		protected RMethod r_RgetSetup;
		public virtual RMethod RgetSetup
		{
			get
			{
				if(r_RgetSetup == null)
				{
					r_RgetSetup = new(this, "getSetup", 0);
					r_RgetSetup.SetBelong(this.instance);
				}
				return r_RgetSetup;
			}
		}

		/// <summary>
		/// System.String getFriendlyName()
		/// </summary>
		protected RMethod r_RgetFriendlyName;
		public virtual RMethod RgetFriendlyName
		{
			get
			{
				if(r_RgetFriendlyName == null)
				{
					r_RgetFriendlyName = new(this, "getFriendlyName", 0);
					r_RgetFriendlyName.SetBelong(this.instance);
				}
				return r_RgetFriendlyName;
			}
		}

		/// <summary>
		/// System.AppDomain getCurDomain()
		/// </summary>
		protected static RMethod r_RgetCurDomain;
		public static RMethod RgetCurDomain
		{
			get
			{
				if(r_RgetCurDomain == null)
				{
					r_RgetCurDomain = new(typeof(System.AppDomain), "getCurDomain", 0);
					r_RgetCurDomain.SetBelong(null);
				}
				return r_RgetCurDomain;
			}
		}

		/// <summary>
		/// System.AppDomain getRootDomain()
		/// </summary>
		protected static RMethod r_RgetRootDomain;
		public static RMethod RgetRootDomain
		{
			get
			{
				if(r_RgetRootDomain == null)
				{
					r_RgetRootDomain = new(typeof(System.AppDomain), "getRootDomain", 0);
					r_RgetRootDomain.SetBelong(null);
				}
				return r_RgetRootDomain;
			}
		}

		/// <summary>
		/// Void AppendPrivatePath(System.String)
		/// </summary>
		protected RMethod r_RAppendPrivatePath_String;
		public virtual RMethod RAppendPrivatePath_String
		{
			get
			{
				if(r_RAppendPrivatePath_String == null)
				{
					r_RAppendPrivatePath_String = new(this, "AppendPrivatePath", 0, typeof(System.String));
					r_RAppendPrivatePath_String.SetBelong(this.instance);
				}
				return r_RAppendPrivatePath_String;
			}
		}

		/// <summary>
		/// Void ClearPrivatePath()
		/// </summary>
		protected RMethod r_RClearPrivatePath;
		public virtual RMethod RClearPrivatePath
		{
			get
			{
				if(r_RClearPrivatePath == null)
				{
					r_RClearPrivatePath = new(this, "ClearPrivatePath", 0);
					r_RClearPrivatePath.SetBelong(this.instance);
				}
				return r_RClearPrivatePath;
			}
		}

		/// <summary>
		/// Void ClearShadowCopyPath()
		/// </summary>
		protected RMethod r_RClearShadowCopyPath;
		public virtual RMethod RClearShadowCopyPath
		{
			get
			{
				if(r_RClearShadowCopyPath == null)
				{
					r_RClearShadowCopyPath = new(this, "ClearShadowCopyPath", 0);
					r_RClearShadowCopyPath.SetBelong(this.instance);
				}
				return r_RClearShadowCopyPath;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateComInstanceFrom_String_String;
		public virtual RMethod RCreateComInstanceFrom_String_String
		{
			get
			{
				if(r_RCreateComInstanceFrom_String_String == null)
				{
					r_RCreateComInstanceFrom_String_String = new(this, "CreateComInstanceFrom", 0, typeof(System.String), typeof(System.String));
					r_RCreateComInstanceFrom_String_String.SetBelong(this.instance);
				}
				return r_RCreateComInstanceFrom_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String, System.String, Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm = new(this, "CreateComInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
					r_RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm.SetBelong(this.instance);
				}
				return r_RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String, System.String)
		/// </summary>
		protected RMethod r_RInternalCreateInstanceWithNoSecurity_String_String;
		public virtual RMethod RInternalCreateInstanceWithNoSecurity_String_String
		{
			get
			{
				if(r_RInternalCreateInstanceWithNoSecurity_String_String == null)
				{
					r_RInternalCreateInstanceWithNoSecurity_String_String = new(this, "InternalCreateInstanceWithNoSecurity", 0, typeof(System.String), typeof(System.String));
					r_RInternalCreateInstanceWithNoSecurity_String_String.SetBelong(this.instance);
				}
				return r_RInternalCreateInstanceWithNoSecurity_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "InternalCreateInstanceWithNoSecurity", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String, System.String)
		/// </summary>
		protected RMethod r_RInternalCreateInstanceFromWithNoSecurity_String_String;
		public virtual RMethod RInternalCreateInstanceFromWithNoSecurity_String_String
		{
			get
			{
				if(r_RInternalCreateInstanceFromWithNoSecurity_String_String == null)
				{
					r_RInternalCreateInstanceFromWithNoSecurity_String_String = new(this, "InternalCreateInstanceFromWithNoSecurity", 0, typeof(System.String), typeof(System.String));
					r_RInternalCreateInstanceFromWithNoSecurity_String_String.SetBelong(this.instance);
				}
				return r_RInternalCreateInstanceFromWithNoSecurity_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "InternalCreateInstanceFromWithNoSecurity", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateInstance_String_String;
		public virtual RMethod RCreateInstance_String_String
		{
			get
			{
				if(r_RCreateInstance_String_String == null)
				{
					r_RCreateInstance_String_String = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String));
					r_RCreateInstance_String_String.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstance_String_String_ObjectArray;
		public virtual RMethod RCreateInstance_String_String_ObjectArray
		{
			get
			{
				if(r_RCreateInstance_String_String_ObjectArray == null)
				{
					r_RCreateInstance_String_String_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RCreateInstance_String_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateInstanceAndUnwrap_String_String;
		public virtual RMethod RCreateInstanceAndUnwrap_String_String
		{
			get
			{
				if(r_RCreateInstanceAndUnwrap_String_String == null)
				{
					r_RCreateInstanceAndUnwrap_String_String = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String));
					r_RCreateInstanceAndUnwrap_String_String.SetBelong(this.instance);
				}
				return r_RCreateInstanceAndUnwrap_String_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceAndUnwrap_String_String_ObjectArray;
		public virtual RMethod RCreateInstanceAndUnwrap_String_String_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceAndUnwrap_String_String_ObjectArray == null)
				{
					r_RCreateInstanceAndUnwrap_String_String_ObjectArray = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceAndUnwrap_String_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceAndUnwrap_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateInstanceFrom_String_String;
		public virtual RMethod RCreateInstanceFrom_String_String
		{
			get
			{
				if(r_RCreateInstanceFrom_String_String == null)
				{
					r_RCreateInstanceFrom_String_String = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String));
					r_RCreateInstanceFrom_String_String.SetBelong(this.instance);
				}
				return r_RCreateInstanceFrom_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceFrom_String_String_ObjectArray;
		public virtual RMethod RCreateInstanceFrom_String_String_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceFrom_String_String_ObjectArray == null)
				{
					r_RCreateInstanceFrom_String_String_ObjectArray = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceFrom_String_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceFrom_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceFrom", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String)
		/// </summary>
		protected RMethod r_RCreateInstanceFromAndUnwrap_String_String;
		public virtual RMethod RCreateInstanceFromAndUnwrap_String_String
		{
			get
			{
				if(r_RCreateInstanceFromAndUnwrap_String_String == null)
				{
					r_RCreateInstanceFromAndUnwrap_String_String = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String));
					r_RCreateInstanceFromAndUnwrap_String_String.SetBelong(this.instance);
				}
				return r_RCreateInstanceFromAndUnwrap_String_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstanceFromAndUnwrap_String_String_ObjectArray;
		public virtual RMethod RCreateInstanceFromAndUnwrap_String_String_ObjectArray
		{
			get
			{
				if(r_RCreateInstanceFromAndUnwrap_String_String_ObjectArray == null)
				{
					r_RCreateInstanceFromAndUnwrap_String_String_ObjectArray = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RCreateInstanceFromAndUnwrap_String_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstanceFromAndUnwrap_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceFromAndUnwrap(System.String, System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
		public virtual RMethod RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence
		{
			get
			{
				if(r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence == null)
				{
					r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence = new(this, "CreateInstanceFromAndUnwrap", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.SetBelong(this.instance);
				}
				return r_RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.Policy.Evidence));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, System.Security.Policy.Evidence, System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.String, Boolean, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_ = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.String), typeof(System.Boolean), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder], System.Security.SecurityContextSource)
		/// </summary>
		protected RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource;
		public virtual RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource = new(this, "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)), typeof(System.Security.SecurityContextSource));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource.SetBelong(this.instance);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineInternalDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected RMethod r_RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public virtual RMethod RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(this, "DefineInternalDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
					r_RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess.SetBelong(this.instance);
				}
				return r_RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// Void DoCallBack(System.CrossAppDomainDelegate)
		/// </summary>
		protected RMethod r_RDoCallBack_CrossAppDomainDelegate;
		public virtual RMethod RDoCallBack_CrossAppDomainDelegate
		{
			get
			{
				if(r_RDoCallBack_CrossAppDomainDelegate == null)
				{
					r_RDoCallBack_CrossAppDomainDelegate = new(this, "DoCallBack", 0, typeof(System.CrossAppDomainDelegate));
					r_RDoCallBack_CrossAppDomainDelegate.SetBelong(this.instance);
				}
				return r_RDoCallBack_CrossAppDomainDelegate;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String)
		/// </summary>
		protected RMethod r_RExecuteAssembly_String;
		public virtual RMethod RExecuteAssembly_String
		{
			get
			{
				if(r_RExecuteAssembly_String == null)
				{
					r_RExecuteAssembly_String = new(this, "ExecuteAssembly", 0, typeof(System.String));
					r_RExecuteAssembly_String.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RExecuteAssembly_String_Evidence;
		public virtual RMethod RExecuteAssembly_String_Evidence
		{
			get
			{
				if(r_RExecuteAssembly_String_Evidence == null)
				{
					r_RExecuteAssembly_String_Evidence = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RExecuteAssembly_String_Evidence.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String_Evidence;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssembly_String_Evidence_StringArray;
		public virtual RMethod RExecuteAssembly_String_Evidence_StringArray
		{
			get
			{
				if(r_RExecuteAssembly_String_Evidence_StringArray == null)
				{
					r_RExecuteAssembly_String_Evidence_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
					r_RExecuteAssembly_String_Evidence_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.Security.Policy.Evidence, System.String[], Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
					r_RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssembly_String_StringArray;
		public virtual RMethod RExecuteAssembly_String_StringArray
		{
			get
			{
				if(r_RExecuteAssembly_String_StringArray == null)
				{
					r_RExecuteAssembly_String_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_RExecuteAssembly_String_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.String, System.String[], Byte[], System.Configuration.Assemblies.AssemblyHashAlgorithm)
		/// </summary>
		protected RMethod r_RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm;
		public virtual RMethod RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm
		{
			get
			{
				if(r_RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm == null)
				{
					r_RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm = new(this, "ExecuteAssembly", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Configuration.Assemblies.AssemblyHashAlgorithm));
					r_RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyInternal(System.Reflection.Assembly, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssemblyInternal_Assembly_StringArray;
		public virtual RMethod RExecuteAssemblyInternal_Assembly_StringArray
		{
			get
			{
				if(r_RExecuteAssemblyInternal_Assembly_StringArray == null)
				{
					r_RExecuteAssemblyInternal_Assembly_StringArray = new(this, "ExecuteAssemblyInternal", 0, typeof(System.Reflection.Assembly), typeof(System.String).MakeArrayType());
					r_RExecuteAssemblyInternal_Assembly_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyInternal_Assembly_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssembly(System.Reflection.Assembly, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssembly_Assembly_StringArray;
		public virtual RMethod RExecuteAssembly_Assembly_StringArray
		{
			get
			{
				if(r_RExecuteAssembly_Assembly_StringArray == null)
				{
					r_RExecuteAssembly_Assembly_StringArray = new(this, "ExecuteAssembly", 0, typeof(System.Reflection.Assembly), typeof(System.String).MakeArrayType());
					r_RExecuteAssembly_Assembly_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssembly_Assembly_StringArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] GetAssemblies(Boolean)
		/// </summary>
		protected RMethod r_RGetAssemblies_Boolean;
		public virtual RMethod RGetAssemblies_Boolean
		{
			get
			{
				if(r_RGetAssemblies_Boolean == null)
				{
					r_RGetAssemblies_Boolean = new(this, "GetAssemblies", 0, typeof(System.Boolean));
					r_RGetAssemblies_Boolean.SetBelong(this.instance);
				}
				return r_RGetAssemblies_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] GetAssemblies()
		/// </summary>
		protected RMethod r_RGetAssemblies;
		public virtual RMethod RGetAssemblies
		{
			get
			{
				if(r_RGetAssemblies == null)
				{
					r_RGetAssemblies = new(this, "GetAssemblies", 0);
					r_RGetAssemblies.SetBelong(this.instance);
				}
				return r_RGetAssemblies;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_RGetData_String;
		public virtual RMethod RGetData_String
		{
			get
			{
				if(r_RGetData_String == null)
				{
					r_RGetData_String = new(this, "GetData", 0, typeof(System.String));
					r_RGetData_String.SetBelong(this.instance);
				}
				return r_RGetData_String;
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
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_RInitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_RInitializeLifetimeService == null)
				{
					r_RInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_RInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_RInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadAssembly(System.String, System.Security.Policy.Evidence, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark == null)
				{
					r_RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark = new(this, "LoadAssembly", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RLoadAssembly_String_Evidence_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName)
		/// </summary>
		protected RMethod r_RLoad_AssemblyName;
		public virtual RMethod RLoad_AssemblyName
		{
			get
			{
				if(r_RLoad_AssemblyName == null)
				{
					r_RLoad_AssemblyName = new(this, "Load", 0, typeof(System.Reflection.AssemblyName));
					r_RLoad_AssemblyName.SetBelong(this.instance);
				}
				return r_RLoad_AssemblyName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadSatellite(System.Reflection.AssemblyName, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark == null)
				{
					r_RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark = new(this, "LoadSatellite", 0, typeof(System.Reflection.AssemblyName), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RLoadSatellite_AssemblyName_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.Reflection.AssemblyName, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RLoad_AssemblyName_Evidence;
		public virtual RMethod RLoad_AssemblyName_Evidence
		{
			get
			{
				if(r_RLoad_AssemblyName_Evidence == null)
				{
					r_RLoad_AssemblyName_Evidence = new(this, "Load", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence));
					r_RLoad_AssemblyName_Evidence.SetBelong(this.instance);
				}
				return r_RLoad_AssemblyName_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String)
		/// </summary>
		protected RMethod r_RLoad_String;
		public virtual RMethod RLoad_String
		{
			get
			{
				if(r_RLoad_String == null)
				{
					r_RLoad_String = new(this, "Load", 0, typeof(System.String));
					r_RLoad_String.SetBelong(this.instance);
				}
				return r_RLoad_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RLoad_String_Evidence;
		public virtual RMethod RLoad_String_Evidence
		{
			get
			{
				if(r_RLoad_String_Evidence == null)
				{
					r_RLoad_String_Evidence = new(this, "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RLoad_String_Evidence.SetBelong(this.instance);
				}
				return r_RLoad_String_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(System.String, System.Security.Policy.Evidence, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RLoad_String_Evidence_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RLoad_String_Evidence_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RLoad_String_Evidence_Boolean_Ref_StackCrawlMark == null)
				{
					r_RLoad_String_Evidence_Boolean_Ref_StackCrawlMark = new(this, "Load", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RLoad_String_Evidence_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RLoad_String_Evidence_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[])
		/// </summary>
		protected RMethod r_RLoad_ByteArray;
		public virtual RMethod RLoad_ByteArray
		{
			get
			{
				if(r_RLoad_ByteArray == null)
				{
					r_RLoad_ByteArray = new(this, "Load", 0, typeof(System.Byte).MakeArrayType());
					r_RLoad_ByteArray.SetBelong(this.instance);
				}
				return r_RLoad_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[])
		/// </summary>
		protected RMethod r_RLoad_ByteArray_ByteArray;
		public virtual RMethod RLoad_ByteArray_ByteArray
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray == null)
				{
					r_RLoad_ByteArray_ByteArray = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RLoad_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RLoad_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly LoadAssemblyRaw(Byte[], Byte[], System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected RMethod r_RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean;
		public virtual RMethod RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean
		{
			get
			{
				if(r_RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean == null)
				{
					r_RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean = new(this, "LoadAssemblyRaw", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
					r_RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean.SetBelong(this.instance);
				}
				return r_RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RLoad_ByteArray_ByteArray_Evidence;
		public virtual RMethod RLoad_ByteArray_ByteArray_Evidence
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray_Evidence == null)
				{
					r_RLoad_ByteArray_ByteArray_Evidence = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence));
					r_RLoad_ByteArray_ByteArray_Evidence.SetBelong(this.instance);
				}
				return r_RLoad_ByteArray_ByteArray_Evidence;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Load(Byte[], Byte[], System.Security.Policy.Evidence, Boolean)
		/// </summary>
		protected RMethod r_RLoad_ByteArray_ByteArray_Evidence_Boolean;
		public virtual RMethod RLoad_ByteArray_ByteArray_Evidence_Boolean
		{
			get
			{
				if(r_RLoad_ByteArray_ByteArray_Evidence_Boolean == null)
				{
					r_RLoad_ByteArray_ByteArray_Evidence_Boolean = new(this, "Load", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Security.Policy.Evidence), typeof(System.Boolean));
					r_RLoad_ByteArray_ByteArray_Evidence_Boolean.SetBelong(this.instance);
				}
				return r_RLoad_ByteArray_ByteArray_Evidence_Boolean;
			}
		}

		/// <summary>
		/// Void SetAppDomainPolicy(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_RSetAppDomainPolicy_PolicyLevel;
		public virtual RMethod RSetAppDomainPolicy_PolicyLevel
		{
			get
			{
				if(r_RSetAppDomainPolicy_PolicyLevel == null)
				{
					r_RSetAppDomainPolicy_PolicyLevel = new(this, "SetAppDomainPolicy", 0, typeof(System.Security.Policy.PolicyLevel));
					r_RSetAppDomainPolicy_PolicyLevel.SetBelong(this.instance);
				}
				return r_RSetAppDomainPolicy_PolicyLevel;
			}
		}

		/// <summary>
		/// Void SetCachePath(System.String)
		/// </summary>
		protected RMethod r_RSetCachePath_String;
		public virtual RMethod RSetCachePath_String
		{
			get
			{
				if(r_RSetCachePath_String == null)
				{
					r_RSetCachePath_String = new(this, "SetCachePath", 0, typeof(System.String));
					r_RSetCachePath_String.SetBelong(this.instance);
				}
				return r_RSetCachePath_String;
			}
		}

		/// <summary>
		/// Void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy)
		/// </summary>
		protected RMethod r_RSetPrincipalPolicy_PrincipalPolicy;
		public virtual RMethod RSetPrincipalPolicy_PrincipalPolicy
		{
			get
			{
				if(r_RSetPrincipalPolicy_PrincipalPolicy == null)
				{
					r_RSetPrincipalPolicy_PrincipalPolicy = new(this, "SetPrincipalPolicy", 0, typeof(System.Security.Principal.PrincipalPolicy));
					r_RSetPrincipalPolicy_PrincipalPolicy.SetBelong(this.instance);
				}
				return r_RSetPrincipalPolicy_PrincipalPolicy;
			}
		}

		/// <summary>
		/// Void SetShadowCopyFiles()
		/// </summary>
		protected RMethod r_RSetShadowCopyFiles;
		public virtual RMethod RSetShadowCopyFiles
		{
			get
			{
				if(r_RSetShadowCopyFiles == null)
				{
					r_RSetShadowCopyFiles = new(this, "SetShadowCopyFiles", 0);
					r_RSetShadowCopyFiles.SetBelong(this.instance);
				}
				return r_RSetShadowCopyFiles;
			}
		}

		/// <summary>
		/// Void SetShadowCopyPath(System.String)
		/// </summary>
		protected RMethod r_RSetShadowCopyPath_String;
		public virtual RMethod RSetShadowCopyPath_String
		{
			get
			{
				if(r_RSetShadowCopyPath_String == null)
				{
					r_RSetShadowCopyPath_String = new(this, "SetShadowCopyPath", 0, typeof(System.String));
					r_RSetShadowCopyPath_String.SetBelong(this.instance);
				}
				return r_RSetShadowCopyPath_String;
			}
		}

		/// <summary>
		/// Void SetThreadPrincipal(System.Security.Principal.IPrincipal)
		/// </summary>
		protected RMethod r_RSetThreadPrincipal_IPrincipal;
		public virtual RMethod RSetThreadPrincipal_IPrincipal
		{
			get
			{
				if(r_RSetThreadPrincipal_IPrincipal == null)
				{
					r_RSetThreadPrincipal_IPrincipal = new(this, "SetThreadPrincipal", 0, typeof(System.Security.Principal.IPrincipal));
					r_RSetThreadPrincipal_IPrincipal.SetBelong(this.instance);
				}
				return r_RSetThreadPrincipal_IPrincipal;
			}
		}

		/// <summary>
		/// System.AppDomain InternalSetDomainByID(Int32)
		/// </summary>
		protected static RMethod r_RInternalSetDomainByID_Int32;
		public static RMethod RInternalSetDomainByID_Int32
		{
			get
			{
				if(r_RInternalSetDomainByID_Int32 == null)
				{
					r_RInternalSetDomainByID_Int32 = new(typeof(System.AppDomain), "InternalSetDomainByID", 0, typeof(System.Int32));
					r_RInternalSetDomainByID_Int32.SetBelong(null);
				}
				return r_RInternalSetDomainByID_Int32;
			}
		}

		/// <summary>
		/// System.AppDomain InternalSetDomain(System.AppDomain)
		/// </summary>
		protected static RMethod r_RInternalSetDomain_AppDomain;
		public static RMethod RInternalSetDomain_AppDomain
		{
			get
			{
				if(r_RInternalSetDomain_AppDomain == null)
				{
					r_RInternalSetDomain_AppDomain = new(typeof(System.AppDomain), "InternalSetDomain", 0, typeof(System.AppDomain));
					r_RInternalSetDomain_AppDomain.SetBelong(null);
				}
				return r_RInternalSetDomain_AppDomain;
			}
		}

		/// <summary>
		/// Void InternalPushDomainRef(System.AppDomain)
		/// </summary>
		protected static RMethod r_RInternalPushDomainRef_AppDomain;
		public static RMethod RInternalPushDomainRef_AppDomain
		{
			get
			{
				if(r_RInternalPushDomainRef_AppDomain == null)
				{
					r_RInternalPushDomainRef_AppDomain = new(typeof(System.AppDomain), "InternalPushDomainRef", 0, typeof(System.AppDomain));
					r_RInternalPushDomainRef_AppDomain.SetBelong(null);
				}
				return r_RInternalPushDomainRef_AppDomain;
			}
		}

		/// <summary>
		/// Void InternalPushDomainRefByID(Int32)
		/// </summary>
		protected static RMethod r_RInternalPushDomainRefByID_Int32;
		public static RMethod RInternalPushDomainRefByID_Int32
		{
			get
			{
				if(r_RInternalPushDomainRefByID_Int32 == null)
				{
					r_RInternalPushDomainRefByID_Int32 = new(typeof(System.AppDomain), "InternalPushDomainRefByID", 0, typeof(System.Int32));
					r_RInternalPushDomainRefByID_Int32.SetBelong(null);
				}
				return r_RInternalPushDomainRefByID_Int32;
			}
		}

		/// <summary>
		/// Void InternalPopDomainRef()
		/// </summary>
		protected static RMethod r_RInternalPopDomainRef;
		public static RMethod RInternalPopDomainRef
		{
			get
			{
				if(r_RInternalPopDomainRef == null)
				{
					r_RInternalPopDomainRef = new(typeof(System.AppDomain), "InternalPopDomainRef", 0);
					r_RInternalPopDomainRef.SetBelong(null);
				}
				return r_RInternalPopDomainRef;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected static RMethod r_RInternalSetContext_Context;
		public static RMethod RInternalSetContext_Context
		{
			get
			{
				if(r_RInternalSetContext_Context == null)
				{
					r_RInternalSetContext_Context = new(typeof(System.AppDomain), "InternalSetContext", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_RInternalSetContext_Context.SetBelong(null);
				}
				return r_RInternalSetContext_Context;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalGetContext()
		/// </summary>
		protected static RMethod r_RInternalGetContext;
		public static RMethod RInternalGetContext
		{
			get
			{
				if(r_RInternalGetContext == null)
				{
					r_RInternalGetContext = new(typeof(System.AppDomain), "InternalGetContext", 0);
					r_RInternalGetContext.SetBelong(null);
				}
				return r_RInternalGetContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext()
		/// </summary>
		protected static RMethod r_RInternalGetDefaultContext;
		public static RMethod RInternalGetDefaultContext
		{
			get
			{
				if(r_RInternalGetDefaultContext == null)
				{
					r_RInternalGetDefaultContext = new(typeof(System.AppDomain), "InternalGetDefaultContext", 0);
					r_RInternalGetDefaultContext.SetBelong(null);
				}
				return r_RInternalGetDefaultContext;
			}
		}

		/// <summary>
		/// System.String InternalGetProcessGuid(System.String)
		/// </summary>
		protected static RMethod r_RInternalGetProcessGuid_String;
		public static RMethod RInternalGetProcessGuid_String
		{
			get
			{
				if(r_RInternalGetProcessGuid_String == null)
				{
					r_RInternalGetProcessGuid_String = new(typeof(System.AppDomain), "InternalGetProcessGuid", 0, typeof(System.String));
					r_RInternalGetProcessGuid_String.SetBelong(null);
				}
				return r_RInternalGetProcessGuid_String;
			}
		}

		/// <summary>
		/// System.Object InvokeInDomain(System.AppDomain, System.Reflection.MethodInfo, System.Object, System.Object[])
		/// </summary>
		protected static RMethod r_RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray;
		public static RMethod RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray
		{
			get
			{
				if(r_RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray == null)
				{
					r_RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray = new(typeof(System.AppDomain), "InvokeInDomain", 0, typeof(System.AppDomain), typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray.SetBelong(null);
				}
				return r_RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeInDomainByID(Int32, System.Reflection.MethodInfo, System.Object, System.Object[])
		/// </summary>
		protected static RMethod r_RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray;
		public static RMethod RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray
		{
			get
			{
				if(r_RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray == null)
				{
					r_RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray = new(typeof(System.AppDomain), "InvokeInDomainByID", 0, typeof(System.Int32), typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray.SetBelong(null);
				}
				return r_RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.String GetProcessGuid()
		/// </summary>
		protected static RMethod r_RGetProcessGuid;
		public static RMethod RGetProcessGuid
		{
			get
			{
				if(r_RGetProcessGuid == null)
				{
					r_RGetProcessGuid = new(typeof(System.AppDomain), "GetProcessGuid", 0);
					r_RGetProcessGuid.SetBelong(null);
				}
				return r_RGetProcessGuid;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String)
		/// </summary>
		protected static RMethod r_RCreateDomain_String;
		public static RMethod RCreateDomain_String
		{
			get
			{
				if(r_RCreateDomain_String == null)
				{
					r_RCreateDomain_String = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String));
					r_RCreateDomain_String.SetBelong(null);
				}
				return r_RCreateDomain_String;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected static RMethod r_RCreateDomain_String_Evidence;
		public static RMethod RCreateDomain_String_Evidence
		{
			get
			{
				if(r_RCreateDomain_String_Evidence == null)
				{
					r_RCreateDomain_String_Evidence = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RCreateDomain_String_Evidence.SetBelong(null);
				}
				return r_RCreateDomain_String_Evidence;
			}
		}

		/// <summary>
		/// System.AppDomain createDomain(System.String, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_RcreateDomain_String_AppDomainSetup;
		public static RMethod RcreateDomain_String_AppDomainSetup
		{
			get
			{
				if(r_RcreateDomain_String_AppDomainSetup == null)
				{
					r_RcreateDomain_String_AppDomainSetup = new(typeof(System.AppDomain), "createDomain", 0, typeof(System.String), typeof(System.AppDomainSetup));
					r_RcreateDomain_String_AppDomainSetup.SetBelong(null);
				}
				return r_RcreateDomain_String_AppDomainSetup;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_RCreateDomain_String_Evidence_AppDomainSetup;
		public static RMethod RCreateDomain_String_Evidence_AppDomainSetup
		{
			get
			{
				if(r_RCreateDomain_String_Evidence_AppDomainSetup == null)
				{
					r_RCreateDomain_String_Evidence_AppDomainSetup = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup));
					r_RCreateDomain_String_Evidence_AppDomainSetup.SetBelong(null);
				}
				return r_RCreateDomain_String_Evidence_AppDomainSetup;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RCreateDomain_String_Evidence_String_String_Boolean;
		public static RMethod RCreateDomain_String_Evidence_String_String_Boolean
		{
			get
			{
				if(r_RCreateDomain_String_Evidence_String_String_Boolean == null)
				{
					r_RCreateDomain_String_Evidence_String_String_Boolean = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RCreateDomain_String_Evidence_String_String_Boolean.SetBelong(null);
				}
				return r_RCreateDomain_String_Evidence_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.AppDomainSetup, System.Security.PermissionSet, System.Security.Policy.StrongName[])
		/// </summary>
		protected static RMethod r_RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray;
		public static RMethod RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray
		{
			get
			{
				if(r_RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray == null)
				{
					r_RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.AppDomainSetup), typeof(System.Security.PermissionSet), typeof(System.Security.Policy.StrongName).MakeArrayType());
					r_RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray.SetBelong(null);
				}
				return r_RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray;
			}
		}

		/// <summary>
		/// System.AppDomainSetup CreateDomainSetup(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_RCreateDomainSetup_String_String_Boolean;
		public static RMethod RCreateDomainSetup_String_String_Boolean
		{
			get
			{
				if(r_RCreateDomainSetup_String_String_Boolean == null)
				{
					r_RCreateDomainSetup_String_String_Boolean = new(typeof(System.AppDomain), "CreateDomainSetup", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RCreateDomainSetup_String_String_Boolean.SetBelong(null);
				}
				return r_RCreateDomainSetup_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean InternalIsFinalizingForUnload(Int32)
		/// </summary>
		protected static RMethod r_RInternalIsFinalizingForUnload_Int32;
		public static RMethod RInternalIsFinalizingForUnload_Int32
		{
			get
			{
				if(r_RInternalIsFinalizingForUnload_Int32 == null)
				{
					r_RInternalIsFinalizingForUnload_Int32 = new(typeof(System.AppDomain), "InternalIsFinalizingForUnload", 0, typeof(System.Int32));
					r_RInternalIsFinalizingForUnload_Int32.SetBelong(null);
				}
				return r_RInternalIsFinalizingForUnload_Int32;
			}
		}

		/// <summary>
		/// Boolean IsFinalizingForUnload()
		/// </summary>
		protected RMethod r_RIsFinalizingForUnload;
		public virtual RMethod RIsFinalizingForUnload
		{
			get
			{
				if(r_RIsFinalizingForUnload == null)
				{
					r_RIsFinalizingForUnload = new(this, "IsFinalizingForUnload", 0);
					r_RIsFinalizingForUnload.SetBelong(this.instance);
				}
				return r_RIsFinalizingForUnload;
			}
		}

		/// <summary>
		/// Void InternalUnload(Int32)
		/// </summary>
		protected static RMethod r_RInternalUnload_Int32;
		public static RMethod RInternalUnload_Int32
		{
			get
			{
				if(r_RInternalUnload_Int32 == null)
				{
					r_RInternalUnload_Int32 = new(typeof(System.AppDomain), "InternalUnload", 0, typeof(System.Int32));
					r_RInternalUnload_Int32.SetBelong(null);
				}
				return r_RInternalUnload_Int32;
			}
		}

		/// <summary>
		/// Int32 getDomainID()
		/// </summary>
		protected RMethod r_RgetDomainID;
		public virtual RMethod RgetDomainID
		{
			get
			{
				if(r_RgetDomainID == null)
				{
					r_RgetDomainID = new(this, "getDomainID", 0);
					r_RgetDomainID.SetBelong(this.instance);
				}
				return r_RgetDomainID;
			}
		}

		/// <summary>
		/// Void Unload(System.AppDomain)
		/// </summary>
		protected static RMethod r_RUnload_AppDomain;
		public static RMethod RUnload_AppDomain
		{
			get
			{
				if(r_RUnload_AppDomain == null)
				{
					r_RUnload_AppDomain = new(typeof(System.AppDomain), "Unload", 0, typeof(System.AppDomain));
					r_RUnload_AppDomain.SetBelong(null);
				}
				return r_RUnload_AppDomain;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSetData_String_Object;
		public virtual RMethod RSetData_String_Object
		{
			get
			{
				if(r_RSetData_String_Object == null)
				{
					r_RSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
					r_RSetData_String_Object.SetBelong(this.instance);
				}
				return r_RSetData_String_Object;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object, System.Security.IPermission)
		/// </summary>
		protected RMethod r_RSetData_String_Object_IPermission;
		public virtual RMethod RSetData_String_Object_IPermission
		{
			get
			{
				if(r_RSetData_String_Object_IPermission == null)
				{
					r_RSetData_String_Object_IPermission = new(this, "SetData", 0, typeof(System.String), typeof(System.Object), typeof(System.Security.IPermission));
					r_RSetData_String_Object_IPermission.SetBelong(this.instance);
				}
				return r_RSetData_String_Object_IPermission;
			}
		}

		/// <summary>
		/// Void SetDynamicBase(System.String)
		/// </summary>
		protected RMethod r_RSetDynamicBase_String;
		public virtual RMethod RSetDynamicBase_String
		{
			get
			{
				if(r_RSetDynamicBase_String == null)
				{
					r_RSetDynamicBase_String = new(this, "SetDynamicBase", 0, typeof(System.String));
					r_RSetDynamicBase_String.SetBelong(this.instance);
				}
				return r_RSetDynamicBase_String;
			}
		}

		/// <summary>
		/// Int32 GetCurrentThreadId()
		/// </summary>
		protected static RMethod r_RGetCurrentThreadId;
		public static RMethod RGetCurrentThreadId
		{
			get
			{
				if(r_RGetCurrentThreadId == null)
				{
					r_RGetCurrentThreadId = new(typeof(System.AppDomain), "GetCurrentThreadId", 0);
					r_RGetCurrentThreadId.SetBelong(null);
				}
				return r_RGetCurrentThreadId;
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
		/// Void ValidateAssemblyName(System.String)
		/// </summary>
		protected static RMethod r_RValidateAssemblyName_String;
		public static RMethod RValidateAssemblyName_String
		{
			get
			{
				if(r_RValidateAssemblyName_String == null)
				{
					r_RValidateAssemblyName_String = new(typeof(System.AppDomain), "ValidateAssemblyName", 0, typeof(System.String));
					r_RValidateAssemblyName_String.SetBelong(null);
				}
				return r_RValidateAssemblyName_String;
			}
		}

		/// <summary>
		/// Void DoAssemblyLoad(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_RDoAssemblyLoad_Assembly;
		public virtual RMethod RDoAssemblyLoad_Assembly
		{
			get
			{
				if(r_RDoAssemblyLoad_Assembly == null)
				{
					r_RDoAssemblyLoad_Assembly = new(this, "DoAssemblyLoad", 0, typeof(System.Reflection.Assembly));
					r_RDoAssemblyLoad_Assembly.SetBelong(this.instance);
				}
				return r_RDoAssemblyLoad_Assembly;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoAssemblyResolve(System.String, System.Reflection.Assembly, Boolean)
		/// </summary>
		protected RMethod r_RDoAssemblyResolve_String_Assembly_Boolean;
		public virtual RMethod RDoAssemblyResolve_String_Assembly_Boolean
		{
			get
			{
				if(r_RDoAssemblyResolve_String_Assembly_Boolean == null)
				{
					r_RDoAssemblyResolve_String_Assembly_Boolean = new(this, "DoAssemblyResolve", 0, typeof(System.String), typeof(System.Reflection.Assembly), typeof(System.Boolean));
					r_RDoAssemblyResolve_String_Assembly_Boolean.SetBelong(this.instance);
				}
				return r_RDoAssemblyResolve_String_Assembly_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoTypeBuilderResolve(System.Reflection.Emit.TypeBuilder)
		/// </summary>
		protected RMethod r_RDoTypeBuilderResolve_TypeBuilder;
		public virtual RMethod RDoTypeBuilderResolve_TypeBuilder
		{
			get
			{
				if(r_RDoTypeBuilderResolve_TypeBuilder == null)
				{
					r_RDoTypeBuilderResolve_TypeBuilder = new(this, "DoTypeBuilderResolve", 0, typeof(System.Reflection.Emit.TypeBuilder));
					r_RDoTypeBuilderResolve_TypeBuilder.SetBelong(this.instance);
				}
				return r_RDoTypeBuilderResolve_TypeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoTypeResolve(System.String)
		/// </summary>
		protected RMethod r_RDoTypeResolve_String;
		public virtual RMethod RDoTypeResolve_String
		{
			get
			{
				if(r_RDoTypeResolve_String == null)
				{
					r_RDoTypeResolve_String = new(this, "DoTypeResolve", 0, typeof(System.String));
					r_RDoTypeResolve_String.SetBelong(this.instance);
				}
				return r_RDoTypeResolve_String;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly DoResourceResolve(System.String, System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_RDoResourceResolve_String_Assembly;
		public virtual RMethod RDoResourceResolve_String_Assembly
		{
			get
			{
				if(r_RDoResourceResolve_String_Assembly == null)
				{
					r_RDoResourceResolve_String_Assembly = new(this, "DoResourceResolve", 0, typeof(System.String), typeof(System.Reflection.Assembly));
					r_RDoResourceResolve_String_Assembly.SetBelong(this.instance);
				}
				return r_RDoResourceResolve_String_Assembly;
			}
		}

		/// <summary>
		/// Void DoDomainUnload()
		/// </summary>
		protected RMethod r_RDoDomainUnload;
		public virtual RMethod RDoDomainUnload
		{
			get
			{
				if(r_RDoDomainUnload == null)
				{
					r_RDoDomainUnload = new(this, "DoDomainUnload", 0);
					r_RDoDomainUnload.SetBelong(this.instance);
				}
				return r_RDoDomainUnload;
			}
		}

		/// <summary>
		/// Void DoUnhandledException(System.Exception)
		/// </summary>
		protected RMethod r_RDoUnhandledException_Exception;
		public virtual RMethod RDoUnhandledException_Exception
		{
			get
			{
				if(r_RDoUnhandledException_Exception == null)
				{
					r_RDoUnhandledException_Exception = new(this, "DoUnhandledException", 0, typeof(System.Exception));
					r_RDoUnhandledException_Exception.SetBelong(this.instance);
				}
				return r_RDoUnhandledException_Exception;
			}
		}

		/// <summary>
		/// Void DoUnhandledException(System.UnhandledExceptionEventArgs)
		/// </summary>
		protected RMethod r_RDoUnhandledException_UnhandledExceptionEventArgs;
		public virtual RMethod RDoUnhandledException_UnhandledExceptionEventArgs
		{
			get
			{
				if(r_RDoUnhandledException_UnhandledExceptionEventArgs == null)
				{
					r_RDoUnhandledException_UnhandledExceptionEventArgs = new(this, "DoUnhandledException", 0, typeof(System.UnhandledExceptionEventArgs));
					r_RDoUnhandledException_UnhandledExceptionEventArgs.SetBelong(this.instance);
				}
				return r_RDoUnhandledException_UnhandledExceptionEventArgs;
			}
		}

		/// <summary>
		/// Byte[] GetMarshalledDomainObjRef()
		/// </summary>
		protected RMethod r_RGetMarshalledDomainObjRef;
		public virtual RMethod RGetMarshalledDomainObjRef
		{
			get
			{
				if(r_RGetMarshalledDomainObjRef == null)
				{
					r_RGetMarshalledDomainObjRef = new(this, "GetMarshalledDomainObjRef", 0);
					r_RGetMarshalledDomainObjRef.SetBelong(this.instance);
				}
				return r_RGetMarshalledDomainObjRef;
			}
		}

		/// <summary>
		/// Void ProcessMessageInDomain(Byte[], System.Runtime.Remoting.Messaging.CADMethodCallMessage, Byte[] ByRef, System.Runtime.Remoting.Messaging.CADMethodReturnMessage ByRef)
		/// </summary>
		protected RMethod r_RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage;
		public virtual RMethod RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage
		{
			get
			{
				if(r_RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage == null)
				{
					r_RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage = new(this, "ProcessMessageInDomain", 0, typeof(System.Byte).MakeArrayType(),  ReleactionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodCallMessage"), typeof(System.Byte).MakeArrayType().MakeByRefType(),  ReleactionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodReturnMessage").MakeByRefType());
					r_RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage.SetBelong(this.instance);
				}
				return r_RProcessMessageInDomain_ByteArray_CADMethodCallMessage_Out_ByteArray_Out_CADMethodReturnMessage;
			}
		}

		/// <summary>
		/// System.String ApplyPolicy(System.String)
		/// </summary>
		protected RMethod r_RApplyPolicy_String;
		public virtual RMethod RApplyPolicy_String
		{
			get
			{
				if(r_RApplyPolicy_String == null)
				{
					r_RApplyPolicy_String = new(this, "ApplyPolicy", 0, typeof(System.String));
					r_RApplyPolicy_String.SetBelong(this.instance);
				}
				return r_RApplyPolicy_String;
			}
		}

		/// <summary>
		/// System.AppDomain CreateDomain(System.String, System.Security.Policy.Evidence, System.String, System.String, Boolean, System.AppDomainInitializer, System.String[])
		/// </summary>
		protected static RMethod r_RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray;
		public static RMethod RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray
		{
			get
			{
				if(r_RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray == null)
				{
					r_RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray = new(typeof(System.AppDomain), "CreateDomain", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.AppDomainInitializer), typeof(System.String).MakeArrayType());
					r_RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray.SetBelong(null);
				}
				return r_RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String)
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_String;
		public virtual RMethod RExecuteAssemblyByName_String
		{
			get
			{
				if(r_RExecuteAssemblyByName_String == null)
				{
					r_RExecuteAssemblyByName_String = new(this, "ExecuteAssemblyByName", 0, typeof(System.String));
					r_RExecuteAssemblyByName_String.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_String;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_String_Evidence;
		public virtual RMethod RExecuteAssemblyByName_String_Evidence
		{
			get
			{
				if(r_RExecuteAssemblyByName_String_Evidence == null)
				{
					r_RExecuteAssemblyByName_String_Evidence = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence));
					r_RExecuteAssemblyByName_String_Evidence.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_String_Evidence;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_String_Evidence_StringArray;
		public virtual RMethod RExecuteAssemblyByName_String_Evidence_StringArray
		{
			get
			{
				if(r_RExecuteAssemblyByName_String_Evidence_StringArray == null)
				{
					r_RExecuteAssemblyByName_String_Evidence_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
					r_RExecuteAssemblyByName_String_Evidence_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_String_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName, System.Security.Policy.Evidence, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_AssemblyName_Evidence_StringArray;
		public virtual RMethod RExecuteAssemblyByName_AssemblyName_Evidence_StringArray
		{
			get
			{
				if(r_RExecuteAssemblyByName_AssemblyName_Evidence_StringArray == null)
				{
					r_RExecuteAssemblyByName_AssemblyName_Evidence_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.Reflection.AssemblyName), typeof(System.Security.Policy.Evidence), typeof(System.String).MakeArrayType());
					r_RExecuteAssemblyByName_AssemblyName_Evidence_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_AssemblyName_Evidence_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.String, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_String_StringArray;
		public virtual RMethod RExecuteAssemblyByName_String_StringArray
		{
			get
			{
				if(r_RExecuteAssemblyByName_String_StringArray == null)
				{
					r_RExecuteAssemblyByName_String_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_RExecuteAssemblyByName_String_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_String_StringArray;
			}
		}

		/// <summary>
		/// Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName, System.String[])
		/// </summary>
		protected RMethod r_RExecuteAssemblyByName_AssemblyName_StringArray;
		public virtual RMethod RExecuteAssemblyByName_AssemblyName_StringArray
		{
			get
			{
				if(r_RExecuteAssemblyByName_AssemblyName_StringArray == null)
				{
					r_RExecuteAssemblyByName_AssemblyName_StringArray = new(this, "ExecuteAssemblyByName", 0, typeof(System.Reflection.AssemblyName), typeof(System.String).MakeArrayType());
					r_RExecuteAssemblyByName_AssemblyName_StringArray.SetBelong(this.instance);
				}
				return r_RExecuteAssemblyByName_AssemblyName_StringArray;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAppDomain()
		/// </summary>
		protected RMethod r_RIsDefaultAppDomain;
		public virtual RMethod RIsDefaultAppDomain
		{
			get
			{
				if(r_RIsDefaultAppDomain == null)
				{
					r_RIsDefaultAppDomain = new(this, "IsDefaultAppDomain", 0);
					r_RIsDefaultAppDomain.SetBelong(this.instance);
				}
				return r_RIsDefaultAppDomain;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly[] ReflectionOnlyGetAssemblies()
		/// </summary>
		protected RMethod r_RReflectionOnlyGetAssemblies;
		public virtual RMethod RReflectionOnlyGetAssemblies
		{
			get
			{
				if(r_RReflectionOnlyGetAssemblies == null)
				{
					r_RReflectionOnlyGetAssemblies = new(this, "ReflectionOnlyGetAssemblies", 0);
					r_RReflectionOnlyGetAssemblies.SetBelong(this.instance);
				}
				return r_RReflectionOnlyGetAssemblies;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System._AppDomain.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System._AppDomain.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System._AppDomain.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32 = new(this, "System._AppDomain.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System._AppDomain.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System._AppDomain.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] IsCompatibilitySwitchSet(System.String)
		/// </summary>
		protected RMethod r_RIsCompatibilitySwitchSet_String;
		public virtual RMethod RIsCompatibilitySwitchSet_String
		{
			get
			{
				if(r_RIsCompatibilitySwitchSet_String == null)
				{
					r_RIsCompatibilitySwitchSet_String = new(this, "IsCompatibilitySwitchSet", 0, typeof(System.String));
					r_RIsCompatibilitySwitchSet_String.SetBelong(this.instance);
				}
				return r_RIsCompatibilitySwitchSet_String;
			}
		}

		/// <summary>
		/// Void SetCompatibilitySwitch(System.String)
		/// </summary>
		protected RMethod r_RSetCompatibilitySwitch_String;
		public virtual RMethod RSetCompatibilitySwitch_String
		{
			get
			{
				if(r_RSetCompatibilitySwitch_String == null)
				{
					r_RSetCompatibilitySwitch_String = new(this, "SetCompatibilitySwitch", 0, typeof(System.String));
					r_RSetCompatibilitySwitch_String.SetBelong(this.instance);
				}
				return r_RSetCompatibilitySwitch_String;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_RGetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_RGetLifetimeService == null)
				{
					r_RGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_RGetLifetimeService.SetBelong(this.instance);
				}
				return r_RGetLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_RMemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_RMemberwiseClone_Boolean == null)
				{
					r_RMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_RMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_RMemberwiseClone_Boolean;
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


        public RAppDomain() : base("System.AppDomain")
        {
        }

        public RAppDomain(System.Object instance) : base("System.AppDomain")
		{
            SetInstance(instance);
		}

        public RAppDomain(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAppDomain(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsAppXModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAppXModel.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAppXDesignMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAppXDesignMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CheckReflectionOnlyLoadSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckReflectionOnlyLoadSupported.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckLoadFromSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckLoadFromSupported.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AppDomainSetup getSetup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomainSetup)___result;
        }


        public virtual System.String getFriendlyName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetFriendlyName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.AppDomain getCurDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetCurDomain.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain getRootDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetRootDomain.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual void AppendPrivatePath(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RAppendPrivatePath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPrivatePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPrivatePath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearShadowCopyPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearShadowCopyPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RCreateComInstanceFrom_String_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(System.String  @assemblyFile, System.String  @typeName, System.Byte[]  @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @hashValue, @hashAlgorithm};
            var ___result = RCreateComInstanceFrom_String_String_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RInternalCreateInstanceWithNoSecurity_String_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceWithNoSecurity(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RInternalCreateInstanceWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RInternalCreateInstanceFromWithNoSecurity_String_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle InternalCreateInstanceFromWithNoSecurity(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RInternalCreateInstanceFromWithNoSecurity_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RCreateInstance_String_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String  @assemblyName, System.String  @typeName, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RCreateInstance_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RCreateInstanceAndUnwrap_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String  @assemblyName, System.String  @typeName, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RCreateInstanceAndUnwrap_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstance_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Object CreateInstanceAndUnwrap(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstanceAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String  @assemblyFile, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String  @assemblyFile, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String  @assemblyFile, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName};
            var ___result = RCreateInstanceFrom_String_String.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String  @assemblyFile, System.String  @typeName, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @activationAttributes};
            var ___result = RCreateInstanceFrom_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.String  @assemblyFile, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RCreateInstanceFrom_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String  @assemblyName, System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName};
            var ___result = RCreateInstanceFromAndUnwrap_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String  @assemblyName, System.String  @typeName, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @activationAttributes};
            var ___result = RCreateInstanceFromAndUnwrap_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceFromAndUnwrap(System.String  @assemblyName, System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes, System.Security.Policy.Evidence  @securityAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes, @securityAttributes};
            var ___result = RCreateInstanceFromAndUnwrap_String_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @evidence};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Security.Policy.Evidence  @evidence, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_Evidence_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Security.Policy.Evidence  @evidence, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Security.Policy.Evidence  @evidence, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions, System.Boolean  @isSynchronized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions, @isSynchronized};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Security.Policy.Evidence  @evidence, System.Security.PermissionSet  @requiredPermissions, System.Security.PermissionSet  @optionalPermissions, System.Security.PermissionSet  @refusedPermissions, System.Boolean  @isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>  @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @evidence, @requiredPermissions, @optionalPermissions, @refusedPermissions, @isSynchronized, @assemblyAttributes};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Evidence_PermissionSet_PermissionSet_PermissionSet_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>  @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.String  @dir, System.Boolean  @isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>  @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @dir, @isSynchronized, @assemblyAttributes};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_String_Boolean_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>  @assemblyAttributes, System.Security.SecurityContextSource  @securityContextSource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes, @securityContextSource};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p__SecurityContextSource.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.AssemblyBuilder DefineInternalDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RDefineInternalDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual void DoCallBack(System.CrossAppDomainDelegate  @callBackDelegate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callBackDelegate};
            var ___result = RDoCallBack_CrossAppDomainDelegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile};
            var ___result = RExecuteAssembly_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity};
            var ___result = RExecuteAssembly_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile, System.Security.Policy.Evidence  @assemblySecurity, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity, @args};
            var ___result = RExecuteAssembly_String_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile, System.Security.Policy.Evidence  @assemblySecurity, System.String[]  @args, System.Byte[]  @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @assemblySecurity, @args, @hashValue, @hashAlgorithm};
            var ___result = RExecuteAssembly_String_Evidence_StringArray_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @args};
            var ___result = RExecuteAssembly_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.String  @assemblyFile, System.String[]  @args, System.Byte[]  @hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFile, @args, @hashValue, @hashAlgorithm};
            var ___result = RExecuteAssembly_String_StringArray_ByteArray_AssemblyHashAlgorithm.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyInternal(System.Reflection.Assembly  @a, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @args};
            var ___result = RExecuteAssemblyInternal_Assembly_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssembly(System.Reflection.Assembly  @a, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @args};
            var ___result = RExecuteAssembly_Assembly_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.Assembly[] GetAssemblies(System.Boolean  @refOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refOnly};
            var ___result = RGetAssemblies_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly[])___result;
        }


        public virtual System.Reflection.Assembly[] GetAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAssemblies.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly[])___result;
        }


        public virtual System.Object GetData(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName  @assemblyRef)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef};
            var ___result = RLoad_AssemblyName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }



        public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName  @assemblyRef, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyRef, @assemblySecurity};
            var ___result = RLoad_AssemblyName_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly Load(System.String  @assemblyString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString};
            var ___result = RLoad_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly Load(System.String  @assemblyString, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyString, @assemblySecurity};
            var ___result = RLoad_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }



        public virtual System.Reflection.Assembly Load(System.Byte[]  @rawAssembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly};
            var ___result = RLoad_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore};
            var ___result = RLoad_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly LoadAssemblyRaw(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore, System.Security.Policy.Evidence  @securityEvidence, System.Boolean  @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence, @refonly};
            var ___result = RLoadAssemblyRaw_ByteArray_ByteArray_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore, System.Security.Policy.Evidence  @securityEvidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence};
            var ___result = RLoad_ByteArray_ByteArray_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly Load(System.Byte[]  @rawAssembly, System.Byte[]  @rawSymbolStore, System.Security.Policy.Evidence  @securityEvidence, System.Boolean  @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawAssembly, @rawSymbolStore, @securityEvidence, @refonly};
            var ___result = RLoad_ByteArray_ByteArray_Evidence_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual void SetAppDomainPolicy(System.Security.Policy.PolicyLevel  @domainPolicy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domainPolicy};
            var ___result = RSetAppDomainPolicy_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCachePath(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RSetCachePath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy  @policy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@policy};
            var ___result = RSetPrincipalPolicy_PrincipalPolicy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowCopyFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetShadowCopyFiles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowCopyPath(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RSetShadowCopyPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetThreadPrincipal(System.Security.Principal.IPrincipal  @principal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@principal};
            var ___result = RSetThreadPrincipal_IPrincipal.Invoke(___genericsType, ___parameters);

            
        }


        public static System.AppDomain InternalSetDomainByID(System.Int32  @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RInternalSetDomainByID_Int32.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain InternalSetDomain(System.AppDomain  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RInternalSetDomain_AppDomain.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static void InternalPushDomainRef(System.AppDomain  @domain)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain};
            var ___result = RInternalPushDomainRef_AppDomain.Invoke(___genericsType, ___parameters);

            
        }


        public static void InternalPushDomainRefByID(System.Int32  @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RInternalPushDomainRefByID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void InternalPopDomainRef()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalPopDomainRef.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RInternalSetContext_Context.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context InternalGetContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetContext.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public static System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetDefaultContext.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Contexts.Context)___result;
        }


        public static System.String InternalGetProcessGuid(System.String  @newguid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newguid};
            var ___result = RInternalGetProcessGuid_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object InvokeInDomain(System.AppDomain  @domain, System.Reflection.MethodInfo  @method, System.Object  @obj, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain, @method, @obj, @args};
            var ___result = RInvokeInDomain_AppDomain_MethodInfo_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object InvokeInDomainByID(System.Int32  @domain_id, System.Reflection.MethodInfo  @method, System.Object  @obj, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id, @method, @obj, @args};
            var ___result = RInvokeInDomainByID_Int32_MethodInfo_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.String GetProcessGuid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProcessGuid.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName};
            var ___result = RCreateDomain_String.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo};
            var ___result = RCreateDomain_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain createDomain(System.String  @friendlyName, System.AppDomainSetup  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @info};
            var ___result = RcreateDomain_String_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.AppDomainSetup  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @info};
            var ___result = RCreateDomain_String_Evidence_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.String  @appBasePath, System.String  @appRelativeSearchPath, System.Boolean  @shadowCopyFiles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appBasePath, @appRelativeSearchPath, @shadowCopyFiles};
            var ___result = RCreateDomain_String_Evidence_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.AppDomainSetup  @info, System.Security.PermissionSet  @grantSet, System.Security.Policy.StrongName[]  @fullTrustAssemblies)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @info, @grantSet, @fullTrustAssemblies};
            var ___result = RCreateDomain_String_Evidence_AppDomainSetup_PermissionSet_StrongNameArray.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public static System.AppDomainSetup CreateDomainSetup(System.String  @appBasePath, System.String  @appRelativeSearchPath, System.Boolean  @shadowCopyFiles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@appBasePath, @appRelativeSearchPath, @shadowCopyFiles};
            var ___result = RCreateDomainSetup_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.AppDomainSetup)___result;
        }


        public static System.Boolean InternalIsFinalizingForUnload(System.Int32  @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RInternalIsFinalizingForUnload_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFinalizingForUnload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFinalizingForUnload.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void InternalUnload(System.Int32  @domain_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain_id};
            var ___result = RInternalUnload_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 getDomainID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetDomainID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Unload(System.AppDomain  @domain)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain};
            var ___result = RUnload_AppDomain.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData(System.String  @name, System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetData(System.String  @name, System.Object  @data, System.Security.IPermission  @permission)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data, @permission};
            var ___result = RSetData_String_Object_IPermission.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDynamicBase(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RSetDynamicBase_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetCurrentThreadId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentThreadId.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ValidateAssemblyName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RValidateAssemblyName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoAssemblyLoad(System.Reflection.Assembly  @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assembly};
            var ___result = RDoAssemblyLoad_Assembly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Assembly DoAssemblyResolve(System.String  @name, System.Reflection.Assembly  @requestingAssembly, System.Boolean  @refonly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @requestingAssembly, @refonly};
            var ___result = RDoAssemblyResolve_String_Assembly_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly DoTypeBuilderResolve(System.Reflection.Emit.TypeBuilder  @tb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb};
            var ___result = RDoTypeBuilderResolve_TypeBuilder.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly DoTypeResolve(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RDoTypeResolve_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly DoResourceResolve(System.String  @name, System.Reflection.Assembly  @requesting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @requesting};
            var ___result = RDoResourceResolve_String_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual void DoDomainUnload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoDomainUnload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoUnhandledException(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RDoUnhandledException_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoUnhandledException(System.UnhandledExceptionEventArgs  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDoUnhandledException_UnhandledExceptionEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetMarshalledDomainObjRef()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMarshalledDomainObjRef.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }



        public virtual System.String ApplyPolicy(System.String  @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RApplyPolicy_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.AppDomain CreateDomain(System.String  @friendlyName, System.Security.Policy.Evidence  @securityInfo, System.String  @appBasePath, System.String  @appRelativeSearchPath, System.Boolean  @shadowCopyFiles, System.AppDomainInitializer  @adInit, System.String[]  @adInitArgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@friendlyName, @securityInfo, @appBasePath, @appRelativeSearchPath, @shadowCopyFiles, @adInit, @adInitArgs};
            var ___result = RCreateDomain_String_Evidence_String_String_Boolean_AppDomainInitializer_StringArray.Invoke(___genericsType, ___parameters);

            return (System.AppDomain)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String  @assemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName};
            var ___result = RExecuteAssemblyByName_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String  @assemblyName, System.Security.Policy.Evidence  @assemblySecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity};
            var ___result = RExecuteAssemblyByName_String_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String  @assemblyName, System.Security.Policy.Evidence  @assemblySecurity, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity, @args};
            var ___result = RExecuteAssemblyByName_String_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName  @assemblyName, System.Security.Policy.Evidence  @assemblySecurity, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @assemblySecurity, @args};
            var ___result = RExecuteAssemblyByName_AssemblyName_Evidence_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.String  @assemblyName, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @args};
            var ___result = RExecuteAssemblyByName_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ExecuteAssemblyByName(System.Reflection.AssemblyName  @assemblyName, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyName, @args};
            var ___result = RExecuteAssemblyByName_AssemblyName_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsDefaultAppDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDefaultAppDomain.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.Assembly[] ReflectionOnlyGetAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReflectionOnlyGetAssemblies.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly[])___result;
        }


        public virtual void System__1___AppDomain__1__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__1___AppDomain__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1___AppDomain__1__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__1___AppDomain__1__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1___AppDomain__1__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__1___AppDomain__1__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__1___AppDomain__1__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__1___AppDomain__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Nullable<System.Boolean> IsCompatibilitySwitchSet(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsCompatibilitySwitchSet_String.Invoke(___genericsType, ___parameters);

            return (System.Nullable<System.Boolean>)___result;
        }


        public virtual void SetCompatibilitySwitch(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetCompatibilitySwitch_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
