using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.AssemblyBuilder
	/// </summary>
    public partial class RAssemblyBuilder : RMember //
    {

		/// <summary>
		/// System.IntPtr _mono_assembly
		/// </summary>
		protected RField r__mono_assembly;
		public virtual RField R_mono_assembly
		{
			get
			{
				if(r__mono_assembly == null)
				{
					r__mono_assembly = new(this, "_mono_assembly");
					r__mono_assembly.SetBelong(this.instance);
				}
				return r__mono_assembly;
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
		/// System.UIntPtr dynamic_assembly
		/// </summary>
		protected RField r_dynamic_assembly;
		public virtual RField Rdynamic_assembly
		{
			get
			{
				if(r_dynamic_assembly == null)
				{
					r_dynamic_assembly = new(this, "dynamic_assembly");
					r_dynamic_assembly.SetBelong(this.instance);
				}
				return r_dynamic_assembly;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo entry_point
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_entry_point;
		public virtual RSystem.RReflection.RMethodInfo Rentry_point
		{
			get
			{
				if(r_entry_point == null)
				{
					r_entry_point = new(this, "entry_point");
					r_entry_point.SetBelong(this.instance);
				}
				return r_entry_point;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder[] modules
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RModuleBuilder> r_modules;
		public virtual RFieldArray<RSystem.RReflection.REmit.RModuleBuilder> Rmodules
		{
			get
			{
				if(r_modules == null)
				{
					r_modules = new(this, "modules");
					r_modules.SetBelong(this.instance);
				}
				return r_modules;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String dir
		/// </summary>
		protected RField r_dir;
		public virtual RField Rdir
		{
			get
			{
				if(r_dir == null)
				{
					r_dir = new(this, "dir");
					r_dir.SetBelong(this.instance);
				}
				return r_dir;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> r_cattrs;
		public virtual RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> Rcattrs
		{
			get
			{
				if(r_cattrs == null)
				{
					r_cattrs = new(this, "cattrs");
					r_cattrs.SetBelong(this.instance);
				}
				return r_cattrs;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoResource[] resources
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMonoResource> r_resources;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMonoResource> Rresources
		{
			get
			{
				if(r_resources == null)
				{
					r_resources = new(this, "resources");
					r_resources.SetBelong(this.instance);
				}
				return r_resources;
			}
		}

		/// <summary>
		/// System.Byte[] public_key
		/// </summary>
		protected RFieldArray<RField> r_public_key;
		public virtual RFieldArray<RField> Rpublic_key
		{
			get
			{
				if(r_public_key == null)
				{
					r_public_key = new(this, "public_key");
					r_public_key.SetBelong(this.instance);
				}
				return r_public_key;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected RField r_version;
		public virtual RField Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version");
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// System.String culture
		/// </summary>
		protected RField r_culture;
		public virtual RField Rculture
		{
			get
			{
				if(r_culture == null)
				{
					r_culture = new(this, "culture");
					r_culture.SetBelong(this.instance);
				}
				return r_culture;
			}
		}

		/// <summary>
		/// System.UInt32 algid
		/// </summary>
		protected RField r_algid;
		public virtual RField Ralgid
		{
			get
			{
				if(r_algid == null)
				{
					r_algid = new(this, "algid");
					r_algid.SetBelong(this.instance);
				}
				return r_algid;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PEFileKinds pekind
		/// </summary>
		protected RField r_pekind;
		public virtual RField Rpekind
		{
			get
			{
				if(r_pekind == null)
				{
					r_pekind = new(this, "pekind");
					r_pekind.SetBelong(this.instance);
				}
				return r_pekind;
			}
		}

		/// <summary>
		/// System.Boolean delay_sign
		/// </summary>
		protected RField r_delay_sign;
		public virtual RField Rdelay_sign
		{
			get
			{
				if(r_delay_sign == null)
				{
					r_delay_sign = new(this, "delay_sign");
					r_delay_sign.SetBelong(this.instance);
				}
				return r_delay_sign;
			}
		}

		/// <summary>
		/// System.UInt32 access
		/// </summary>
		protected RField r_access;
		public virtual RField Raccess
		{
			get
			{
				if(r_access == null)
				{
					r_access = new(this, "access");
					r_access.SetBelong(this.instance);
				}
				return r_access;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] loaded_modules
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RModule> r_loaded_modules;
		public virtual RFieldArray<RSystem.RReflection.RModule> Rloaded_modules
		{
			get
			{
				if(r_loaded_modules == null)
				{
					r_loaded_modules = new(this, "loaded_modules");
					r_loaded_modules.SetBelong(this.instance);
				}
				return r_loaded_modules;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoWin32Resource[] win32_resources
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMonoWin32Resource> r_win32_resources;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMonoWin32Resource> Rwin32_resources
		{
			get
			{
				if(r_win32_resources == null)
				{
					r_win32_resources = new(this, "win32_resources");
					r_win32_resources.SetBelong(this.instance);
				}
				return r_win32_resources;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_minimum
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> r_permissions_minimum;
		public virtual RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> Rpermissions_minimum
		{
			get
			{
				if(r_permissions_minimum == null)
				{
					r_permissions_minimum = new(this, "permissions_minimum");
					r_permissions_minimum.SetBelong(this.instance);
				}
				return r_permissions_minimum;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_optional
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> r_permissions_optional;
		public virtual RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> Rpermissions_optional
		{
			get
			{
				if(r_permissions_optional == null)
				{
					r_permissions_optional = new(this, "permissions_optional");
					r_permissions_optional.SetBelong(this.instance);
				}
				return r_permissions_optional;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions_refused
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> r_permissions_refused;
		public virtual RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> Rpermissions_refused
		{
			get
			{
				if(r_permissions_refused == null)
				{
					r_permissions_refused = new(this, "permissions_refused");
					r_permissions_refused.SetBelong(this.instance);
				}
				return r_permissions_refused;
			}
		}

		/// <summary>
		/// System.Reflection.PortableExecutableKinds peKind
		/// </summary>
		protected RField r_peKind;
		public virtual RField RpeKind
		{
			get
			{
				if(r_peKind == null)
				{
					r_peKind = new(this, "peKind");
					r_peKind.SetBelong(this.instance);
				}
				return r_peKind;
			}
		}

		/// <summary>
		/// System.Reflection.ImageFileMachine machine
		/// </summary>
		protected RField r_machine;
		public virtual RField Rmachine
		{
			get
			{
				if(r_machine == null)
				{
					r_machine = new(this, "machine");
					r_machine.SetBelong(this.instance);
				}
				return r_machine;
			}
		}

		/// <summary>
		/// System.Boolean corlib_internal
		/// </summary>
		protected RField r_corlib_internal;
		public virtual RField Rcorlib_internal
		{
			get
			{
				if(r_corlib_internal == null)
				{
					r_corlib_internal = new(this, "corlib_internal");
					r_corlib_internal.SetBelong(this.instance);
				}
				return r_corlib_internal;
			}
		}

		/// <summary>
		/// System.Type[] type_forwarders
		/// </summary>
		protected RFieldArray<RSystem.RType> r_type_forwarders;
		public virtual RFieldArray<RSystem.RType> Rtype_forwarders
		{
			get
			{
				if(r_type_forwarders == null)
				{
					r_type_forwarders = new(this, "type_forwarders");
					r_type_forwarders.SetBelong(this.instance);
				}
				return r_type_forwarders;
			}
		}

		/// <summary>
		/// System.Byte[] pktoken
		/// </summary>
		protected RFieldArray<RField> r_pktoken;
		public virtual RFieldArray<RField> Rpktoken
		{
			get
			{
				if(r_pktoken == null)
				{
					r_pktoken = new(this, "pktoken");
					r_pktoken.SetBelong(this.instance);
				}
				return r_pktoken;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _minimum
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__minimum;
		public virtual RSystem.RSecurity.RPermissionSet R_minimum
		{
			get
			{
				if(r__minimum == null)
				{
					r__minimum = new(this, "_minimum");
					r__minimum.SetBelong(this.instance);
				}
				return r__minimum;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _optional
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__optional;
		public virtual RSystem.RSecurity.RPermissionSet R_optional
		{
			get
			{
				if(r__optional == null)
				{
					r__optional = new(this, "_optional");
					r__optional.SetBelong(this.instance);
				}
				return r__optional;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet _refuse
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__refuse;
		public virtual RSystem.RSecurity.RPermissionSet R_refuse
		{
			get
			{
				if(r__refuse == null)
				{
					r__refuse = new(this, "_refuse");
					r__refuse.SetBelong(this.instance);
				}
				return r__refuse;
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
		/// System.Security.PermissionSet _denied
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r__denied;
		public virtual RSystem.RSecurity.RPermissionSet R_denied
		{
			get
			{
				if(r__denied == null)
				{
					r__denied = new(this, "_denied");
					r__denied.SetBelong(this.instance);
				}
				return r__denied;
			}
		}

		/// <summary>
		/// System.String assemblyName
		/// </summary>
		protected RField r_assemblyName;
		public virtual RField RassemblyName
		{
			get
			{
				if(r_assemblyName == null)
				{
					r_assemblyName = new(this, "assemblyName");
					r_assemblyName.SetBelong(this.instance);
				}
				return r_assemblyName;
			}
		}

		/// <summary>
		/// System.Type corlib_object_type
		/// </summary>
		protected RSystem.RType r_corlib_object_type;
		public virtual RSystem.RType Rcorlib_object_type
		{
			get
			{
				if(r_corlib_object_type == null)
				{
					r_corlib_object_type = new(this, "corlib_object_type");
					r_corlib_object_type.SetBelong(this.instance);
				}
				return r_corlib_object_type;
			}
		}

		/// <summary>
		/// System.Type corlib_value_type
		/// </summary>
		protected RSystem.RType r_corlib_value_type;
		public virtual RSystem.RType Rcorlib_value_type
		{
			get
			{
				if(r_corlib_value_type == null)
				{
					r_corlib_value_type = new(this, "corlib_value_type");
					r_corlib_value_type.SetBelong(this.instance);
				}
				return r_corlib_value_type;
			}
		}

		/// <summary>
		/// System.Type corlib_enum_type
		/// </summary>
		protected RSystem.RType r_corlib_enum_type;
		public virtual RSystem.RType Rcorlib_enum_type
		{
			get
			{
				if(r_corlib_enum_type == null)
				{
					r_corlib_enum_type = new(this, "corlib_enum_type");
					r_corlib_enum_type.SetBelong(this.instance);
				}
				return r_corlib_enum_type;
			}
		}

		/// <summary>
		/// System.Type corlib_void_type
		/// </summary>
		protected RSystem.RType r_corlib_void_type;
		public virtual RSystem.RType Rcorlib_void_type
		{
			get
			{
				if(r_corlib_void_type == null)
				{
					r_corlib_void_type = new(this, "corlib_void_type");
					r_corlib_void_type.SetBelong(this.instance);
				}
				return r_corlib_void_type;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList resource_writers
		/// </summary>
		protected RSystem.RCollections.RArrayList r_resource_writers;
		public virtual RSystem.RCollections.RArrayList Rresource_writers
		{
			get
			{
				if(r_resource_writers == null)
				{
					r_resource_writers = new(this, "resource_writers");
					r_resource_writers.SetBelong(this.instance);
				}
				return r_resource_writers;
			}
		}

		/// <summary>
		/// System.Resources.Win32VersionResource version_res
		/// </summary>
		protected RSystem.RResources.RWin32VersionResource r_version_res;
		public virtual RSystem.RResources.RWin32VersionResource Rversion_res
		{
			get
			{
				if(r_version_res == null)
				{
					r_version_res = new(this, "version_res");
					r_version_res.SetBelong(this.instance);
				}
				return r_version_res;
			}
		}

		/// <summary>
		/// System.Boolean created
		/// </summary>
		protected RField r_created;
		public virtual RField Rcreated
		{
			get
			{
				if(r_created == null)
				{
					r_created = new(this, "created");
					r_created.SetBelong(this.instance);
				}
				return r_created;
			}
		}

		/// <summary>
		/// System.Boolean is_module_only
		/// </summary>
		protected RField r_is_module_only;
		public virtual RField Ris_module_only
		{
			get
			{
				if(r_is_module_only == null)
				{
					r_is_module_only = new(this, "is_module_only");
					r_is_module_only.SetBelong(this.instance);
				}
				return r_is_module_only;
			}
		}

		/// <summary>
		/// Mono.Security.StrongName sn
		/// </summary>
		protected RMono.RSecurity.RStrongName r_sn;
		public virtual RMono.RSecurity.RStrongName Rsn
		{
			get
			{
				if(r_sn == null)
				{
					r_sn = new(this, "sn");
					r_sn.SetBelong(this.instance);
				}
				return r_sn;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.NativeResourceType native_resource
		/// </summary>
		protected RField r_native_resource;
		public virtual RField Rnative_resource
		{
			get
			{
				if(r_native_resource == null)
				{
					r_native_resource = new(this, "native_resource");
					r_native_resource.SetBelong(this.instance);
				}
				return r_native_resource;
			}
		}

		/// <summary>
		/// System.String versioninfo_culture
		/// </summary>
		protected RField r_versioninfo_culture;
		public virtual RField Rversioninfo_culture
		{
			get
			{
				if(r_versioninfo_culture == null)
				{
					r_versioninfo_culture = new(this, "versioninfo_culture");
					r_versioninfo_culture.SetBelong(this.instance);
				}
				return r_versioninfo_culture;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilderAccess COMPILER_ACCESS
		/// </summary>
		protected static RField r_COMPILER_ACCESS;
		public static RField RCOMPILER_ACCESS
		{
			get
			{
				if(r_COMPILER_ACCESS == null)
				{
					r_COMPILER_ACCESS = new(typeof(System.Reflection.Emit.AssemblyBuilder), "COMPILER_ACCESS");
					r_COMPILER_ACCESS.SetBelong(null);
				}
				return r_COMPILER_ACCESS;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder manifest_module
		/// </summary>
		protected RSystem.RReflection.REmit.RModuleBuilder r_manifest_module;
		public virtual RSystem.RReflection.REmit.RModuleBuilder Rmanifest_module
		{
			get
			{
				if(r_manifest_module == null)
				{
					r_manifest_module = new(this, "manifest_module");
					r_manifest_module.SetBelong(this.instance);
				}
				return r_manifest_module;
			}
		}

		/// <summary>
		/// System.String CodeBase
		/// </summary>
		protected RProperty r_CodeBase;
		public virtual RProperty RCodeBase
		{
			get
			{
				if(r_CodeBase == null)
				{
					r_CodeBase = new(this, "CodeBase", -1);
					r_CodeBase.SetBelong(this.instance);
				}
				return r_CodeBase;
			}
		}

		/// <summary>
		/// System.String EscapedCodeBase
		/// </summary>
		protected RProperty r_EscapedCodeBase;
		public virtual RProperty REscapedCodeBase
		{
			get
			{
				if(r_EscapedCodeBase == null)
				{
					r_EscapedCodeBase = new(this, "EscapedCodeBase", -1);
					r_EscapedCodeBase.SetBelong(this.instance);
				}
				return r_EscapedCodeBase;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo EntryPoint
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_EntryPoint;
		public virtual RSystem.RReflection.RMethodInfo REntryPoint
		{
			get
			{
				if(r_EntryPoint == null)
				{
					r_EntryPoint = new(this, "EntryPoint", -1);
					r_EntryPoint.SetBelong(this.instance);
				}
				return r_EntryPoint;
			}
		}

		/// <summary>
		/// System.String Location
		/// </summary>
		protected RProperty r_Location;
		public virtual RProperty RLocation
		{
			get
			{
				if(r_Location == null)
				{
					r_Location = new(this, "Location", -1);
					r_Location.SetBelong(this.instance);
				}
				return r_Location;
			}
		}

		/// <summary>
		/// System.String ImageRuntimeVersion
		/// </summary>
		protected RProperty r_ImageRuntimeVersion;
		public virtual RProperty RImageRuntimeVersion
		{
			get
			{
				if(r_ImageRuntimeVersion == null)
				{
					r_ImageRuntimeVersion = new(this, "ImageRuntimeVersion", -1);
					r_ImageRuntimeVersion.SetBelong(this.instance);
				}
				return r_ImageRuntimeVersion;
			}
		}

		/// <summary>
		/// Boolean ReflectionOnly
		/// </summary>
		protected RProperty r_ReflectionOnly;
		public virtual RProperty ReflectionOnly
		{
			get
			{
				if(r_ReflectionOnly == null)
				{
					r_ReflectionOnly = new(this, "ReflectionOnly", -1);
					r_ReflectionOnly.SetBelong(this.instance);
				}
				return r_ReflectionOnly;
			}
		}

		/// <summary>
		/// Boolean IsSave
		/// </summary>
		protected RProperty r_IsSave;
		public virtual RProperty RIsSave
		{
			get
			{
				if(r_IsSave == null)
				{
					r_IsSave = new(this, "IsSave", -1);
					r_IsSave.SetBelong(this.instance);
				}
				return r_IsSave;
			}
		}

		/// <summary>
		/// Boolean IsRun
		/// </summary>
		protected RProperty r_IsRun;
		public virtual RProperty RIsRun
		{
			get
			{
				if(r_IsRun == null)
				{
					r_IsRun = new(this, "IsRun", -1);
					r_IsRun.SetBelong(this.instance);
				}
				return r_IsRun;
			}
		}

		/// <summary>
		/// System.String AssemblyDir
		/// </summary>
		protected RProperty r_AssemblyDir;
		public virtual RProperty RAssemblyDir
		{
			get
			{
				if(r_AssemblyDir == null)
				{
					r_AssemblyDir = new(this, "AssemblyDir", -1);
					r_AssemblyDir.SetBelong(this.instance);
				}
				return r_AssemblyDir;
			}
		}

		/// <summary>
		/// Boolean IsModuleOnly
		/// </summary>
		protected RProperty r_IsModuleOnly;
		public virtual RProperty RIsModuleOnly
		{
			get
			{
				if(r_IsModuleOnly == null)
				{
					r_IsModuleOnly = new(this, "IsModuleOnly", -1);
					r_IsModuleOnly.SetBelong(this.instance);
				}
				return r_IsModuleOnly;
			}
		}

		/// <summary>
		/// System.Reflection.Module ManifestModule
		/// </summary>
		protected RSystem.RReflection.RModule r_ManifestModule;
		public virtual RSystem.RReflection.RModule RManifestModule
		{
			get
			{
				if(r_ManifestModule == null)
				{
					r_ManifestModule = new(this, "ManifestModule", -1);
					r_ManifestModule.SetBelong(this.instance);
				}
				return r_ManifestModule;
			}
		}

		/// <summary>
		/// Boolean GlobalAssemblyCache
		/// </summary>
		protected RProperty r_GlobalAssemblyCache;
		public virtual RProperty RGlobalAssemblyCache
		{
			get
			{
				if(r_GlobalAssemblyCache == null)
				{
					r_GlobalAssemblyCache = new(this, "GlobalAssemblyCache", -1);
					r_GlobalAssemblyCache.SetBelong(this.instance);
				}
				return r_GlobalAssemblyCache;
			}
		}

		/// <summary>
		/// Boolean IsDynamic
		/// </summary>
		protected RProperty r_IsDynamic;
		public virtual RProperty RIsDynamic
		{
			get
			{
				if(r_IsDynamic == null)
				{
					r_IsDynamic = new(this, "IsDynamic", -1);
					r_IsDynamic.SetBelong(this.instance);
				}
				return r_IsDynamic;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected RProperty r_FullName;
		public virtual RProperty RFullName
		{
			get
			{
				if(r_FullName == null)
				{
					r_FullName = new(this, "FullName", -1);
					r_FullName.SetBelong(this.instance);
				}
				return r_FullName;
			}
		}

		/// <summary>
		/// IntPtr MonoAssembly
		/// </summary>
		protected RProperty r_MonoAssembly;
		public virtual RProperty RMonoAssembly
		{
			get
			{
				if(r_MonoAssembly == null)
				{
					r_MonoAssembly = new(this, "MonoAssembly", -1);
					r_MonoAssembly.SetBelong(this.instance);
				}
				return r_MonoAssembly;
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
		/// Boolean FromByteArray
		/// </summary>
		protected RProperty r_FromByteArray_Boolean;
		public virtual RProperty RFromByteArray_Boolean
		{
			get
			{
				if(r_FromByteArray_Boolean == null)
				{
					r_FromByteArray_Boolean = new(this, "FromByteArray", -1, typeof(System.Boolean));
					r_FromByteArray_Boolean.SetBelong(this.instance);
				}
				return r_FromByteArray_Boolean;
			}
		}

		/// <summary>
		/// Int64 HostContext
		/// </summary>
		protected RProperty r_HostContext;
		public virtual RProperty RHostContext
		{
			get
			{
				if(r_HostContext == null)
				{
					r_HostContext = new(this, "HostContext", -1);
					r_HostContext.SetBelong(this.instance);
				}
				return r_HostContext;
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
		/// System.Security.PermissionSet DeniedPermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_DeniedPermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RDeniedPermissionSet
		{
			get
			{
				if(r_DeniedPermissionSet == null)
				{
					r_DeniedPermissionSet = new(this, "DeniedPermissionSet", -1);
					r_DeniedPermissionSet.SetBelong(this.instance);
				}
				return r_DeniedPermissionSet;
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
		/// System.Security.SecurityRuleSet SecurityRuleSet
		/// </summary>
		protected RProperty r_SecurityRuleSet;
		public virtual RProperty RSecurityRuleSet
		{
			get
			{
				if(r_SecurityRuleSet == null)
				{
					r_SecurityRuleSet = new(this, "SecurityRuleSet", -1);
					r_SecurityRuleSet.SetBelong(this.instance);
				}
				return r_SecurityRuleSet;
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
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DefinedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> r_DefinedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> RDefinedTypes
		{
			get
			{
				if(r_DefinedTypes == null)
				{
					r_DefinedTypes = new(this, "DefinedTypes", -1);
					r_DefinedTypes.SetBelong(this.instance);
				}
				return r_DefinedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ExportedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_ExportedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RExportedTypes
		{
			get
			{
				if(r_ExportedTypes == null)
				{
					r_ExportedTypes = new(this, "ExportedTypes", -1);
					r_ExportedTypes.SetBelong(this.instance);
				}
				return r_ExportedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.Module] Modules
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RModule> r_Modules;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RModule> RModules
		{
			get
			{
				if(r_Modules == null)
				{
					r_Modules = new(this, "Modules", -1);
					r_Modules.SetBelong(this.instance);
				}
				return r_Modules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_CustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RCustomAttributes
		{
			get
			{
				if(r_CustomAttributes == null)
				{
					r_CustomAttributes = new(this, "CustomAttributes", -1);
					r_CustomAttributes.SetBelong(this.instance);
				}
				return r_CustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.ModuleResolveEventHandler ModuleResolve
		/// </summary>
		protected REvent r_ModuleResolve;
		public virtual REvent RModuleResolve
		{
			get
			{
				if(r_ModuleResolve == null)
				{
					r_ModuleResolve = new(this, "ModuleResolve");
					r_ModuleResolve.SetBelong(this.instance);
				}
				return r_ModuleResolve;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._AssemblyBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._AssemblyBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void basic_init(System.Reflection.Emit.AssemblyBuilder)
		/// </summary>
		protected static RMethod r_Rbasic_init_AssemblyBuilder;
		public static RMethod Rbasic_init_AssemblyBuilder
		{
			get
			{
				if(r_Rbasic_init_AssemblyBuilder == null)
				{
					r_Rbasic_init_AssemblyBuilder = new(typeof(System.Reflection.Emit.AssemblyBuilder), "basic_init", 0, typeof(System.Reflection.Emit.AssemblyBuilder));
					r_Rbasic_init_AssemblyBuilder.SetBelong(null);
				}
				return r_Rbasic_init_AssemblyBuilder;
			}
		}

		/// <summary>
		/// Void UpdateNativeCustomAttributes(System.Reflection.Emit.AssemblyBuilder)
		/// </summary>
		protected static RMethod r_RUpdateNativeCustomAttributes_AssemblyBuilder;
		public static RMethod RUpdateNativeCustomAttributes_AssemblyBuilder
		{
			get
			{
				if(r_RUpdateNativeCustomAttributes_AssemblyBuilder == null)
				{
					r_RUpdateNativeCustomAttributes_AssemblyBuilder = new(typeof(System.Reflection.Emit.AssemblyBuilder), "UpdateNativeCustomAttributes", 0, typeof(System.Reflection.Emit.AssemblyBuilder));
					r_RUpdateNativeCustomAttributes_AssemblyBuilder.SetBelong(null);
				}
				return r_RUpdateNativeCustomAttributes_AssemblyBuilder;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddResourceFile_String_String;
		public virtual RMethod RAddResourceFile_String_String
		{
			get
			{
				if(r_RAddResourceFile_String_String == null)
				{
					r_RAddResourceFile_String_String = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String));
					r_RAddResourceFile_String_String.SetBelong(this.instance);
				}
				return r_RAddResourceFile_String_String;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_RAddResourceFile_String_String_ResourceAttributes;
		public virtual RMethod RAddResourceFile_String_String_ResourceAttributes
		{
			get
			{
				if(r_RAddResourceFile_String_String_ResourceAttributes == null)
				{
					r_RAddResourceFile_String_String_ResourceAttributes = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_RAddResourceFile_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_RAddResourceFile_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void AddResourceFile(System.String, System.String, System.Reflection.ResourceAttributes, Boolean)
		/// </summary>
		protected RMethod r_RAddResourceFile_String_String_ResourceAttributes_Boolean;
		public virtual RMethod RAddResourceFile_String_String_ResourceAttributes_Boolean
		{
			get
			{
				if(r_RAddResourceFile_String_String_ResourceAttributes_Boolean == null)
				{
					r_RAddResourceFile_String_String_ResourceAttributes_Boolean = new(this, "AddResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes), typeof(System.Boolean));
					r_RAddResourceFile_String_String_ResourceAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RAddResourceFile_String_String_ResourceAttributes_Boolean;
			}
		}

		/// <summary>
		/// Void AddPermissionRequests(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet;
		public virtual RMethod RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet
		{
			get
			{
				if(r_RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet == null)
				{
					r_RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet = new(this, "AddPermissionRequests", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet));
					r_RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet.SetBelong(this.instance);
				}
				return r_RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet;
			}
		}

		/// <summary>
		/// Void EmbedResourceFile(System.String, System.String)
		/// </summary>
		protected RMethod r_REmbedResourceFile_String_String;
		public virtual RMethod REmbedResourceFile_String_String
		{
			get
			{
				if(r_REmbedResourceFile_String_String == null)
				{
					r_REmbedResourceFile_String_String = new(this, "EmbedResourceFile", 0, typeof(System.String), typeof(System.String));
					r_REmbedResourceFile_String_String.SetBelong(this.instance);
				}
				return r_REmbedResourceFile_String_String;
			}
		}

		/// <summary>
		/// Void EmbedResourceFile(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_REmbedResourceFile_String_String_ResourceAttributes;
		public virtual RMethod REmbedResourceFile_String_String_ResourceAttributes
		{
			get
			{
				if(r_REmbedResourceFile_String_String_ResourceAttributes == null)
				{
					r_REmbedResourceFile_String_String_ResourceAttributes = new(this, "EmbedResourceFile", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_REmbedResourceFile_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_REmbedResourceFile_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess)
		/// </summary>
		protected static RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
		public static RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess = new(typeof(System.Reflection.Emit.AssemblyBuilder), "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.SetBelong(null);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName, System.Reflection.Emit.AssemblyBuilderAccess, System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.CustomAttributeBuilder])
		/// </summary>
		protected static RMethod r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
		public static RMethod RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_
		{
			get
			{
				if(r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ == null)
				{
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_ = new(typeof(System.Reflection.Emit.AssemblyBuilder), "DefineDynamicAssembly", 0, typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.AssemblyBuilderAccess), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.CustomAttributeBuilder)));
					r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.SetBelong(null);
				}
				return r_RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String)
		/// </summary>
		protected RMethod r_RDefineDynamicModule_String;
		public virtual RMethod RDefineDynamicModule_String
		{
			get
			{
				if(r_RDefineDynamicModule_String == null)
				{
					r_RDefineDynamicModule_String = new(this, "DefineDynamicModule", 0, typeof(System.String));
					r_RDefineDynamicModule_String.SetBelong(this.instance);
				}
				return r_RDefineDynamicModule_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, Boolean)
		/// </summary>
		protected RMethod r_RDefineDynamicModule_String_Boolean;
		public virtual RMethod RDefineDynamicModule_String_Boolean
		{
			get
			{
				if(r_RDefineDynamicModule_String_Boolean == null)
				{
					r_RDefineDynamicModule_String_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.Boolean));
					r_RDefineDynamicModule_String_Boolean.SetBelong(this.instance);
				}
				return r_RDefineDynamicModule_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String)
		/// </summary>
		protected RMethod r_RDefineDynamicModule_String_String;
		public virtual RMethod RDefineDynamicModule_String_String
		{
			get
			{
				if(r_RDefineDynamicModule_String_String == null)
				{
					r_RDefineDynamicModule_String_String = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String));
					r_RDefineDynamicModule_String_String.SetBelong(this.instance);
				}
				return r_RDefineDynamicModule_String_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_RDefineDynamicModule_String_String_Boolean;
		public virtual RMethod RDefineDynamicModule_String_String_Boolean
		{
			get
			{
				if(r_RDefineDynamicModule_String_String_Boolean == null)
				{
					r_RDefineDynamicModule_String_String_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RDefineDynamicModule_String_String_Boolean.SetBelong(this.instance);
				}
				return r_RDefineDynamicModule_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDefineDynamicModule_String_String_Boolean_Boolean;
		public virtual RMethod RDefineDynamicModule_String_String_Boolean_Boolean
		{
			get
			{
				if(r_RDefineDynamicModule_String_String_Boolean_Boolean == null)
				{
					r_RDefineDynamicModule_String_String_Boolean_Boolean = new(this, "DefineDynamicModule", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RDefineDynamicModule_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDefineDynamicModule_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RDefineResource_String_String_String;
		public virtual RMethod RDefineResource_String_String_String
		{
			get
			{
				if(r_RDefineResource_String_String_String == null)
				{
					r_RDefineResource_String_String_String = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RDefineResource_String_String_String.SetBelong(this.instance);
				}
				return r_RDefineResource_String_String_String;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_RDefineResource_String_String_String_ResourceAttributes;
		public virtual RMethod RDefineResource_String_String_String_ResourceAttributes
		{
			get
			{
				if(r_RDefineResource_String_String_String_ResourceAttributes == null)
				{
					r_RDefineResource_String_String_String_ResourceAttributes = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_RDefineResource_String_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_RDefineResource_String_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void AddUnmanagedResource(System.Resources.Win32Resource)
		/// </summary>
		protected RMethod r_RAddUnmanagedResource_Win32Resource;
		public virtual RMethod RAddUnmanagedResource_Win32Resource
		{
			get
			{
				if(r_RAddUnmanagedResource_Win32Resource == null)
				{
					r_RAddUnmanagedResource_Win32Resource = new(this, "AddUnmanagedResource", 0,  ReleactionUtils.GetType("System.Resources.Win32Resource"));
					r_RAddUnmanagedResource_Win32Resource.SetBelong(this.instance);
				}
				return r_RAddUnmanagedResource_Win32Resource;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(Byte[])
		/// </summary>
		protected RMethod r_RDefineUnmanagedResource_ByteArray;
		public virtual RMethod RDefineUnmanagedResource_ByteArray
		{
			get
			{
				if(r_RDefineUnmanagedResource_ByteArray == null)
				{
					r_RDefineUnmanagedResource_ByteArray = new(this, "DefineUnmanagedResource", 0, typeof(System.Byte).MakeArrayType());
					r_RDefineUnmanagedResource_ByteArray.SetBelong(this.instance);
				}
				return r_RDefineUnmanagedResource_ByteArray;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(System.String)
		/// </summary>
		protected RMethod r_RDefineUnmanagedResource_String;
		public virtual RMethod RDefineUnmanagedResource_String
		{
			get
			{
				if(r_RDefineUnmanagedResource_String == null)
				{
					r_RDefineUnmanagedResource_String = new(this, "DefineUnmanagedResource", 0, typeof(System.String));
					r_RDefineUnmanagedResource_String.SetBelong(this.instance);
				}
				return r_RDefineUnmanagedResource_String;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResource()
		/// </summary>
		protected RMethod r_RDefineVersionInfoResource;
		public virtual RMethod RDefineVersionInfoResource
		{
			get
			{
				if(r_RDefineVersionInfoResource == null)
				{
					r_RDefineVersionInfoResource = new(this, "DefineVersionInfoResource", 0);
					r_RDefineVersionInfoResource.SetBelong(this.instance);
				}
				return r_RDefineVersionInfoResource;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResource(System.String, System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RDefineVersionInfoResource_String_String_String_String_String;
		public virtual RMethod RDefineVersionInfoResource_String_String_String_String_String
		{
			get
			{
				if(r_RDefineVersionInfoResource_String_String_String_String_String == null)
				{
					r_RDefineVersionInfoResource_String_String_String_String_String = new(this, "DefineVersionInfoResource", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RDefineVersionInfoResource_String_String_String_String_String.SetBelong(this.instance);
				}
				return r_RDefineVersionInfoResource_String_String_String_String_String;
			}
		}

		/// <summary>
		/// Void DefineVersionInfoResourceImpl(System.String)
		/// </summary>
		protected RMethod r_RDefineVersionInfoResourceImpl_String;
		public virtual RMethod RDefineVersionInfoResourceImpl_String
		{
			get
			{
				if(r_RDefineVersionInfoResourceImpl_String == null)
				{
					r_RDefineVersionInfoResourceImpl_String = new(this, "DefineVersionInfoResourceImpl", 0, typeof(System.String));
					r_RDefineVersionInfoResourceImpl_String.SetBelong(this.instance);
				}
				return r_RDefineVersionInfoResourceImpl_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder GetDynamicModule(System.String)
		/// </summary>
		protected RMethod r_RGetDynamicModule_String;
		public virtual RMethod RGetDynamicModule_String
		{
			get
			{
				if(r_RGetDynamicModule_String == null)
				{
					r_RGetDynamicModule_String = new(this, "GetDynamicModule", 0, typeof(System.String));
					r_RGetDynamicModule_String.SetBelong(this.instance);
				}
				return r_RGetDynamicModule_String;
			}
		}

		/// <summary>
		/// System.Type[] GetExportedTypes()
		/// </summary>
		protected RMethod r_RGetExportedTypes;
		public virtual RMethod RGetExportedTypes
		{
			get
			{
				if(r_RGetExportedTypes == null)
				{
					r_RGetExportedTypes = new(this, "GetExportedTypes", 0);
					r_RGetExportedTypes.SetBelong(this.instance);
				}
				return r_RGetExportedTypes;
			}
		}

		/// <summary>
		/// System.IO.FileStream GetFile(System.String)
		/// </summary>
		protected RMethod r_RGetFile_String;
		public virtual RMethod RGetFile_String
		{
			get
			{
				if(r_RGetFile_String == null)
				{
					r_RGetFile_String = new(this, "GetFile", 0, typeof(System.String));
					r_RGetFile_String.SetBelong(this.instance);
				}
				return r_RGetFile_String;
			}
		}

		/// <summary>
		/// System.IO.FileStream[] GetFiles(Boolean)
		/// </summary>
		protected RMethod r_RGetFiles_Boolean;
		public virtual RMethod RGetFiles_Boolean
		{
			get
			{
				if(r_RGetFiles_Boolean == null)
				{
					r_RGetFiles_Boolean = new(this, "GetFiles", 0, typeof(System.Boolean));
					r_RGetFiles_Boolean.SetBelong(this.instance);
				}
				return r_RGetFiles_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModulesInternal()
		/// </summary>
		protected RMethod r_RGetModulesInternal;
		public virtual RMethod RGetModulesInternal
		{
			get
			{
				if(r_RGetModulesInternal == null)
				{
					r_RGetModulesInternal = new(this, "GetModulesInternal", 0);
					r_RGetModulesInternal.SetBelong(this.instance);
				}
				return r_RGetModulesInternal;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes(Boolean)
		/// </summary>
		protected RMethod r_RGetTypes_Boolean;
		public virtual RMethod RGetTypes_Boolean
		{
			get
			{
				if(r_RGetTypes_Boolean == null)
				{
					r_RGetTypes_Boolean = new(this, "GetTypes", 0, typeof(System.Boolean));
					r_RGetTypes_Boolean.SetBelong(this.instance);
				}
				return r_RGetTypes_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceInfo_String;
		public virtual RMethod RGetManifestResourceInfo_String
		{
			get
			{
				if(r_RGetManifestResourceInfo_String == null)
				{
					r_RGetManifestResourceInfo_String = new(this, "GetManifestResourceInfo", 0, typeof(System.String));
					r_RGetManifestResourceInfo_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceInfo_String;
			}
		}

		/// <summary>
		/// System.String[] GetManifestResourceNames()
		/// </summary>
		protected RMethod r_RGetManifestResourceNames;
		public virtual RMethod RGetManifestResourceNames
		{
			get
			{
				if(r_RGetManifestResourceNames == null)
				{
					r_RGetManifestResourceNames = new(this, "GetManifestResourceNames", 0);
					r_RGetManifestResourceNames.SetBelong(this.instance);
				}
				return r_RGetManifestResourceNames;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_String;
		public virtual RMethod RGetManifestResourceStream_String
		{
			get
			{
				if(r_RGetManifestResourceStream_String == null)
				{
					r_RGetManifestResourceStream_String = new(this, "GetManifestResourceStream", 0, typeof(System.String));
					r_RGetManifestResourceStream_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_String;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_Type_String;
		public virtual RMethod RGetManifestResourceStream_Type_String
		{
			get
			{
				if(r_RGetManifestResourceStream_Type_String == null)
				{
					r_RGetManifestResourceStream_Type_String = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String));
					r_RGetManifestResourceStream_Type_String.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_Type_String;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetManifestModule()
		/// </summary>
		protected RMethod r_RGetManifestModule;
		public virtual RMethod RGetManifestModule
		{
			get
			{
				if(r_RGetManifestModule == null)
				{
					r_RGetManifestModule = new(this, "GetManifestModule", 0);
					r_RGetManifestModule.SetBelong(this.instance);
				}
				return r_RGetManifestModule;
			}
		}

		/// <summary>
		/// Void Save(System.String, System.Reflection.PortableExecutableKinds, System.Reflection.ImageFileMachine)
		/// </summary>
		protected RMethod r_RSave_String_PortableExecutableKinds_ImageFileMachine;
		public virtual RMethod RSave_String_PortableExecutableKinds_ImageFileMachine
		{
			get
			{
				if(r_RSave_String_PortableExecutableKinds_ImageFileMachine == null)
				{
					r_RSave_String_PortableExecutableKinds_ImageFileMachine = new(this, "Save", 0, typeof(System.String), typeof(System.Reflection.PortableExecutableKinds), typeof(System.Reflection.ImageFileMachine));
					r_RSave_String_PortableExecutableKinds_ImageFileMachine.SetBelong(this.instance);
				}
				return r_RSave_String_PortableExecutableKinds_ImageFileMachine;
			}
		}

		/// <summary>
		/// Void Save(System.String)
		/// </summary>
		protected RMethod r_RSave_String;
		public virtual RMethod RSave_String
		{
			get
			{
				if(r_RSave_String == null)
				{
					r_RSave_String = new(this, "Save", 0, typeof(System.String));
					r_RSave_String.SetBelong(this.instance);
				}
				return r_RSave_String;
			}
		}

		/// <summary>
		/// Void SetEntryPoint(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RSetEntryPoint_MethodInfo;
		public virtual RMethod RSetEntryPoint_MethodInfo
		{
			get
			{
				if(r_RSetEntryPoint_MethodInfo == null)
				{
					r_RSetEntryPoint_MethodInfo = new(this, "SetEntryPoint", 0, typeof(System.Reflection.MethodInfo));
					r_RSetEntryPoint_MethodInfo.SetBelong(this.instance);
				}
				return r_RSetEntryPoint_MethodInfo;
			}
		}

		/// <summary>
		/// Void SetEntryPoint(System.Reflection.MethodInfo, System.Reflection.Emit.PEFileKinds)
		/// </summary>
		protected RMethod r_RSetEntryPoint_MethodInfo_PEFileKinds;
		public virtual RMethod RSetEntryPoint_MethodInfo_PEFileKinds
		{
			get
			{
				if(r_RSetEntryPoint_MethodInfo_PEFileKinds == null)
				{
					r_RSetEntryPoint_MethodInfo_PEFileKinds = new(this, "SetEntryPoint", 0, typeof(System.Reflection.MethodInfo), typeof(System.Reflection.Emit.PEFileKinds));
					r_RSetEntryPoint_MethodInfo_PEFileKinds.SetBelong(this.instance);
				}
				return r_RSetEntryPoint_MethodInfo_PEFileKinds;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_RSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_RSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_RSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_RSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_RSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_RSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_RSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_RSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Rnot_supported;
		public virtual RMethod Rnot_supported
		{
			get
			{
				if(r_Rnot_supported == null)
				{
					r_Rnot_supported = new(this, "not_supported", 0);
					r_Rnot_supported.SetBelong(this.instance);
				}
				return r_Rnot_supported;
			}
		}

		/// <summary>
		/// Void check_name_and_filename(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_Rcheck_name_and_filename_String_String_Boolean;
		public virtual RMethod Rcheck_name_and_filename_String_String_Boolean
		{
			get
			{
				if(r_Rcheck_name_and_filename_String_String_Boolean == null)
				{
					r_Rcheck_name_and_filename_String_String_Boolean = new(this, "check_name_and_filename", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_Rcheck_name_and_filename_String_String_Boolean.SetBelong(this.instance);
				}
				return r_Rcheck_name_and_filename_String_String_Boolean;
			}
		}

		/// <summary>
		/// System.String create_assembly_version(System.String)
		/// </summary>
		protected RMethod r_Rcreate_assembly_version_String;
		public virtual RMethod Rcreate_assembly_version_String
		{
			get
			{
				if(r_Rcreate_assembly_version_String == null)
				{
					r_Rcreate_assembly_version_String = new(this, "create_assembly_version", 0, typeof(System.String));
					r_Rcreate_assembly_version_String.SetBelong(this.instance);
				}
				return r_Rcreate_assembly_version_String;
			}
		}

		/// <summary>
		/// System.String GetCultureString(System.String)
		/// </summary>
		protected RMethod r_RGetCultureString_String;
		public virtual RMethod RGetCultureString_String
		{
			get
			{
				if(r_RGetCultureString_String == null)
				{
					r_RGetCultureString_String = new(this, "GetCultureString", 0, typeof(System.String));
					r_RGetCultureString_String.SetBelong(this.instance);
				}
				return r_RGetCultureString_String;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RMakeGenericType_Type_TypeArray;
		public virtual RMethod RMakeGenericType_Type_TypeArray
		{
			get
			{
				if(r_RMakeGenericType_Type_TypeArray == null)
				{
					r_RMakeGenericType_Type_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RMakeGenericType_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RMakeGenericType_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean_Boolean;
		public virtual RMethod RGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean_Boolean == null)
				{
					r_RGetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetType_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule(System.String)
		/// </summary>
		protected RMethod r_RGetModule_String;
		public virtual RMethod RGetModule_String
		{
			get
			{
				if(r_RGetModule_String == null)
				{
					r_RGetModule_String = new(this, "GetModule", 0, typeof(System.String));
					r_RGetModule_String.SetBelong(this.instance);
				}
				return r_RGetModule_String;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules(Boolean)
		/// </summary>
		protected RMethod r_RGetModules_Boolean;
		public virtual RMethod RGetModules_Boolean
		{
			get
			{
				if(r_RGetModules_Boolean == null)
				{
					r_RGetModules_Boolean = new(this, "GetModules", 0, typeof(System.Boolean));
					r_RGetModules_Boolean.SetBelong(this.instance);
				}
				return r_RGetModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName(Boolean)
		/// </summary>
		protected RMethod r_RGetName_Boolean;
		public virtual RMethod RGetName_Boolean
		{
			get
			{
				if(r_RGetName_Boolean == null)
				{
					r_RGetName_Boolean = new(this, "GetName", 0, typeof(System.Boolean));
					r_RGetName_Boolean.SetBelong(this.instance);
				}
				return r_RGetName_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName[] GetReferencedAssemblies()
		/// </summary>
		protected RMethod r_RGetReferencedAssemblies;
		public virtual RMethod RGetReferencedAssemblies
		{
			get
			{
				if(r_RGetReferencedAssemblies == null)
				{
					r_RGetReferencedAssemblies = new(this, "GetReferencedAssemblies", 0);
					r_RGetReferencedAssemblies.SetBelong(this.instance);
				}
				return r_RGetReferencedAssemblies;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules(Boolean)
		/// </summary>
		protected RMethod r_RGetLoadedModules_Boolean;
		public virtual RMethod RGetLoadedModules_Boolean
		{
			get
			{
				if(r_RGetLoadedModules_Boolean == null)
				{
					r_RGetLoadedModules_Boolean = new(this, "GetLoadedModules", 0, typeof(System.Boolean));
					r_RGetLoadedModules_Boolean.SetBelong(this.instance);
				}
				return r_RGetLoadedModules_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo == null)
				{
					r_RGetSatelliteAssembly_CultureInfo = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo));
					r_RGetSatelliteAssembly_CultureInfo.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo_Version;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo_Version
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo_Version == null)
				{
					r_RGetSatelliteAssembly_CultureInfo_Version = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version));
					r_RGetSatelliteAssembly_CultureInfo_Version.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo_Version;
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
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RIsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_RIsDefined_Type_Boolean == null)
				{
					r_RIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_RIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Boolean == null)
				{
					r_RGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_RGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Type_Boolean == null)
				{
					r_RGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence UnprotectedGetEvidence()
		/// </summary>
		protected RMethod r_RUnprotectedGetEvidence;
		public virtual RMethod RUnprotectedGetEvidence
		{
			get
			{
				if(r_RUnprotectedGetEvidence == null)
				{
					r_RUnprotectedGetEvidence = new(this, "UnprotectedGetEvidence", 0);
					r_RUnprotectedGetEvidence.SetBelong(this.instance);
				}
				return r_RUnprotectedGetEvidence;
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
		/// System.IO.FileStream[] GetFiles()
		/// </summary>
		protected RMethod r_RGetFiles;
		public virtual RMethod RGetFiles
		{
			get
			{
				if(r_RGetFiles == null)
				{
					r_RGetFiles = new(this, "GetFiles", 0);
					r_RGetFiles.SetBelong(this.instance);
				}
				return r_RGetFiles;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.Type, System.String, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark == null)
				{
					r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark = new(this, "GetManifestResourceStream", 0, typeof(System.Type), typeof(System.String), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_Type_String_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.IO.Stream GetManifestResourceStream(System.String, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected RMethod r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
		public virtual RMethod RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean == null)
				{
					r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean = new(this, "GetManifestResourceStream", 0, typeof(System.String),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
					r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean.SetBelong(this.instance);
				}
				return r_RGetManifestResourceStream_String_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSimpleName()
		/// </summary>
		protected RMethod r_RGetSimpleName;
		public virtual RMethod RGetSimpleName
		{
			get
			{
				if(r_RGetSimpleName == null)
				{
					r_RGetSimpleName = new(this, "GetSimpleName", 0);
					r_RGetSimpleName.SetBelong(this.instance);
				}
				return r_RGetSimpleName;
			}
		}

		/// <summary>
		/// Byte[] GetPublicKey()
		/// </summary>
		protected RMethod r_RGetPublicKey;
		public virtual RMethod RGetPublicKey
		{
			get
			{
				if(r_RGetPublicKey == null)
				{
					r_RGetPublicKey = new(this, "GetPublicKey", 0);
					r_RGetPublicKey.SetBelong(this.instance);
				}
				return r_RGetPublicKey;
			}
		}

		/// <summary>
		/// System.Version GetVersion()
		/// </summary>
		protected RMethod r_RGetVersion;
		public virtual RMethod RGetVersion
		{
			get
			{
				if(r_RGetVersion == null)
				{
					r_RGetVersion = new(this, "GetVersion", 0);
					r_RGetVersion.SetBelong(this.instance);
				}
				return r_RGetVersion;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_RGetTypes;
		public virtual RMethod RGetTypes
		{
			get
			{
				if(r_RGetTypes == null)
				{
					r_RGetTypes = new(this, "GetTypes", 0);
					r_RGetTypes.SetBelong(this.instance);
				}
				return r_RGetTypes;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean;
		public virtual RMethod RGetType_String_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean == null)
				{
					r_RGetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetType_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_RGetType_String;
		public virtual RMethod RGetType_String
		{
			get
			{
				if(r_RGetType_String == null)
				{
					r_RGetType_String = new(this, "GetType", 0, typeof(System.String));
					r_RGetType_String.SetBelong(this.instance);
				}
				return r_RGetType_String;
			}
		}

		/// <summary>
		/// System.Type InternalGetType(System.Reflection.Module, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternalGetType_Module_String_Boolean_Boolean;
		public virtual RMethod RInternalGetType_Module_String_Boolean_Boolean
		{
			get
			{
				if(r_RInternalGetType_Module_String_Boolean_Boolean == null)
				{
					r_RInternalGetType_Module_String_Boolean_Boolean = new(this, "InternalGetType", 0, typeof(System.Reflection.Module), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternalGetType_Module_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternalGetType_Module_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.AssemblyName GetName()
		/// </summary>
		protected RMethod r_RGetName;
		public virtual RMethod RGetName
		{
			get
			{
				if(r_RGetName == null)
				{
					r_RGetName = new(this, "GetName", 0);
					r_RGetName.SetBelong(this.instance);
				}
				return r_RGetName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "GetSatelliteAssembly", 0, typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RGetSatelliteAssembly_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly InternalGetSatelliteAssembly(System.String, System.Globalization.CultureInfo, System.Version, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark == null)
				{
					r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark = new(this, "InternalGetSatelliteAssembly", 0, typeof(System.String), typeof(System.Globalization.CultureInfo), typeof(System.Version), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark.SetBelong(this.instance);
				}
				return r_RInternalGetSatelliteAssembly_String_CultureInfo_Version_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[])
		/// </summary>
		protected RMethod r_RLoadModule_String_ByteArray;
		public virtual RMethod RLoadModule_String_ByteArray
		{
			get
			{
				if(r_RLoadModule_String_ByteArray == null)
				{
					r_RLoadModule_String_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RLoadModule_String_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadModule_String_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module LoadModule(System.String, Byte[], Byte[])
		/// </summary>
		protected RMethod r_RLoadModule_String_ByteArray_ByteArray;
		public virtual RMethod RLoadModule_String_ByteArray_ByteArray
		{
			get
			{
				if(r_RLoadModule_String_ByteArray_ByteArray == null)
				{
					r_RLoadModule_String_ByteArray_ByteArray = new(this, "LoadModule", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RLoadModule_String_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadModule_String_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String)
		/// </summary>
		protected RMethod r_RCreateInstance_String;
		public virtual RMethod RCreateInstance_String
		{
			get
			{
				if(r_RCreateInstance_String == null)
				{
					r_RCreateInstance_String = new(this, "CreateInstance", 0, typeof(System.String));
					r_RCreateInstance_String.SetBelong(this.instance);
				}
				return r_RCreateInstance_String;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean)
		/// </summary>
		protected RMethod r_RCreateInstance_String_Boolean;
		public virtual RMethod RCreateInstance_String_Boolean
		{
			get
			{
				if(r_RCreateInstance_String_Boolean == null)
				{
					r_RCreateInstance_String_Boolean = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean));
					r_RCreateInstance_String_Boolean.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_Boolean;
			}
		}

		/// <summary>
		/// System.Object CreateInstance(System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "CreateInstance", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.instance);
				}
				return r_RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetLoadedModules()
		/// </summary>
		protected RMethod r_RGetLoadedModules;
		public virtual RMethod RGetLoadedModules
		{
			get
			{
				if(r_RGetLoadedModules == null)
				{
					r_RGetLoadedModules = new(this, "GetLoadedModules", 0);
					r_RGetLoadedModules.SetBelong(this.instance);
				}
				return r_RGetLoadedModules;
			}
		}

		/// <summary>
		/// System.Reflection.Module[] GetModules()
		/// </summary>
		protected RMethod r_RGetModules;
		public virtual RMethod RGetModules
		{
			get
			{
				if(r_RGetModules == null)
				{
					r_RGetModules = new(this, "GetModules", 0);
					r_RGetModules.SetBelong(this.instance);
				}
				return r_RGetModules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_RGetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_RGetCustomAttributesData == null)
				{
					r_RGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_RGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_RGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Type[] GetForwardedTypes()
		/// </summary>
		protected RMethod r_RGetForwardedTypes;
		public virtual RMethod RGetForwardedTypes
		{
			get
			{
				if(r_RGetForwardedTypes == null)
				{
					r_RGetForwardedTypes = new(this, "GetForwardedTypes", 0);
					r_RGetForwardedTypes.SetBelong(this.instance);
				}
				return r_RGetForwardedTypes;
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


        public RAssemblyBuilder() : base("System.Reflection.Emit.AssemblyBuilder")
        {
        }

        public RAssemblyBuilder(System.Object instance) : base("System.Reflection.Emit.AssemblyBuilder")
		{
            SetInstance(instance);
		}

        public RAssemblyBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssemblyBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___AssemblyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void basic_init(System.Reflection.Emit.AssemblyBuilder  @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = Rbasic_init_AssemblyBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public static void UpdateNativeCustomAttributes(System.Reflection.Emit.AssemblyBuilder  @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = RUpdateNativeCustomAttributes_AssemblyBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String  @name, System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = RAddResourceFile_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String  @name, System.String  @fileName, System.Reflection.ResourceAttributes  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute};
            var ___result = RAddResourceFile_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddResourceFile(System.String  @name, System.String  @fileName, System.Reflection.ResourceAttributes  @attribute, System.Boolean  @fileNeedsToExists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute, @fileNeedsToExists};
            var ___result = RAddResourceFile_String_String_ResourceAttributes_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPermissionRequests(System.Security.PermissionSet  @required, System.Security.PermissionSet  @optional, System.Security.PermissionSet  @refused)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@required, @optional, @refused};
            var ___result = RAddPermissionRequests_PermissionSet_PermissionSet_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmbedResourceFile(System.String  @name, System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = REmbedResourceFile_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmbedResourceFile(System.String  @name, System.String  @fileName, System.Reflection.ResourceAttributes  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @attribute};
            var ___result = REmbedResourceFile_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName  @name, System.Reflection.Emit.AssemblyBuilderAccess  @access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>  @assemblyAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @access, @assemblyAttributes};
            var ___result = RDefineDynamicAssembly_AssemblyName_AssemblyBuilderAccess_IEnumerable_d_CustomAttributeBuilder_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.AssemblyBuilder)___result;
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RDefineDynamicModule_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String  @name, System.Boolean  @emitSymbolInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @emitSymbolInfo};
            var ___result = RDefineDynamicModule_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String  @name, System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName};
            var ___result = RDefineDynamicModule_String_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String  @name, System.String  @fileName, System.Boolean  @emitSymbolInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @emitSymbolInfo};
            var ___result = RDefineDynamicModule_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Reflection.Emit.ModuleBuilder DefineDynamicModule(System.String  @name, System.String  @fileName, System.Boolean  @emitSymbolInfo, System.Boolean  @transient)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @emitSymbolInfo, @transient};
            var ___result = RDefineDynamicModule_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String  @name, System.String  @description, System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @fileName};
            var ___result = RDefineResource_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String  @name, System.String  @description, System.String  @fileName, System.Reflection.ResourceAttributes  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @fileName, @attribute};
            var ___result = RDefineResource_String_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }



        public virtual void DefineUnmanagedResource(System.Byte[]  @resource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resource};
            var ___result = RDefineUnmanagedResource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.String  @resourceFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceFileName};
            var ___result = RDefineUnmanagedResource_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDefineVersionInfoResource.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResource(System.String  @product, System.String  @productVersion, System.String  @company, System.String  @copyright, System.String  @trademark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@product, @productVersion, @company, @copyright, @trademark};
            var ___result = RDefineVersionInfoResource_String_String_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineVersionInfoResourceImpl(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RDefineVersionInfoResourceImpl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ModuleBuilder GetDynamicModule(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDynamicModule_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ModuleBuilder)___result;
        }


        public virtual System.Type[] GetExportedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExportedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.IO.FileStream GetFile(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetFile_String.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream)___result;
        }


        public virtual System.IO.FileStream[] GetFiles(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetFiles_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }


        public virtual System.Reflection.Module[] GetModulesInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModulesInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Type[] GetTypes(System.Boolean  @exportedOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exportedOnly};
            var ___result = RGetTypes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(System.String  @resourceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceName};
            var ___result = RGetManifestResourceInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ManifestResourceInfo)___result;
        }


        public virtual System.String[] GetManifestResourceNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestResourceNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetManifestResourceStream_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.IO.Stream GetManifestResourceStream(System.Type  @type, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @name};
            var ___result = RGetManifestResourceStream_Type_String.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
        }


        public virtual System.Reflection.Module GetManifestModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetManifestModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual void Save(System.String  @assemblyFileName, System.Reflection.PortableExecutableKinds  @portableExecutableKind, System.Reflection.ImageFileMachine  @imageFileMachine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFileName, @portableExecutableKind, @imageFileMachine};
            var ___result = RSave_String_PortableExecutableKinds_ImageFileMachine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save(System.String  @assemblyFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assemblyFileName};
            var ___result = RSave_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEntryPoint(System.Reflection.MethodInfo  @entryMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod};
            var ___result = RSetEntryPoint_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEntryPoint(System.Reflection.MethodInfo  @entryMethod, System.Reflection.Emit.PEFileKinds  @fileKind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod, @fileKind};
            var ___result = RSetEntryPoint_MethodInfo_PEFileKinds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder  @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo  @con, System.Byte[]  @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void check_name_and_filename(System.String  @name, System.String  @fileName, System.Boolean  @fileNeedsToExists)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @fileName, @fileNeedsToExists};
            var ___result = Rcheck_name_and_filename_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String create_assembly_version(System.String  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version};
            var ___result = Rcreate_assembly_version_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCultureString(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetCultureString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type MakeGenericType(System.Type  @gtd, System.Type[]  @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gtd, @typeArguments};
            var ___result = RMakeGenericType_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String  @name, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.Module GetModule(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetModule_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module[] GetModules(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.AssemblyName GetName(System.Boolean  @copiedName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@copiedName};
            var ___result = RGetName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }


        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetReferencedAssemblies.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName[])___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules(System.Boolean  @getResourceModules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@getResourceModules};
            var ___result = RGetLoadedModules_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RGetSatelliteAssembly_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo  @culture, System.Version  @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @version};
            var ___result = RGetSatelliteAssembly_CultureInfo_Version.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Assembly)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Security.Policy.Evidence UnprotectedGetEvidence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnprotectedGetEvidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.FileStream[] GetFiles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFiles.Invoke(___genericsType, ___parameters);

            return (System.IO.FileStream[])___result;
        }




        public virtual System.String GetSimpleName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSimpleName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] GetPublicKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPublicKey.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Version GetVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVersion.Invoke(___genericsType, ___parameters);

            return (System.Version)___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetType(System.String  @name, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @throwOnError};
            var ___result = RGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type InternalGetType(System.Reflection.Module  @module, System.String  @name, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @name, @throwOnError, @ignoreCase};
            var ___result = RInternalGetType_Module_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.AssemblyName GetName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.AssemblyName)___result;
        }




        public virtual System.Reflection.Module LoadModule(System.String  @moduleName, System.Byte[]  @rawModule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule};
            var ___result = RLoadModule_String_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Module LoadModule(System.String  @moduleName, System.Byte[]  @rawModule, System.Byte[]  @rawSymbolStore)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moduleName, @rawModule, @rawSymbolStore};
            var ___result = RLoadModule_String_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RCreateInstance_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase};
            var ___result = RCreateInstance_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstance(System.String  @typeName, System.Boolean  @ignoreCase, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Object[]  @args, System.Globalization.CultureInfo  @culture, System.Object[]  @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @ignoreCase, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RCreateInstance_String_Boolean_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Reflection.Module[] GetLoadedModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLoadedModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Reflection.Module[] GetModules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModules.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Type[] GetForwardedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetForwardedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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
