﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Governance.TimerJobs {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TimerJobsResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TimerJobsResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Governance.TimerJobs.TimerJobsResources", typeof(TimerJobsResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site is not existing in SharePoint anymore, hence removed from database. {0}.
        /// </summary>
        internal static string CleanUpJob_RemoveSite {
            get {
                return ResourceManager.GetString("CleanUpJob_RemoveSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get database record for {0}..
        /// </summary>
        internal static string SynchJob_GetDbRecord {
            get {
                return ResourceManager.GetString("SynchJob_GetDbRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get SharePoint site status for {0}..
        /// </summary>
        internal static string SynchJob_GetSiteStatus {
            get {
                return ResourceManager.GetString("SynchJob_GetSiteStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update database record for {0}..
        /// </summary>
        internal static string SynchJob_UpdateDbRecord {
            get {
                return ResourceManager.GetString("SynchJob_UpdateDbRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{2}] ({0}/{1}) sites completed..
        /// </summary>
        internal static string TenantJob_Progress {
            get {
                return ResourceManager.GetString("TenantJob_Progress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something wrong happened when running {0} job for site {1}..
        /// </summary>
        internal static string TenantJob_SiteError {
            get {
                return ResourceManager.GetString("TenantJob_SiteError", resourceCulture);
            }
        }
    }
}