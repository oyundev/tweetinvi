﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35317
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tweetinvi.Streams.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tweetinvi.Streams.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to https://stream.twitter.com/1.1/statuses/filter.json?.
        /// </summary>
        internal static string Stream_Filter {
            get {
                return ResourceManager.GetString("Stream_Filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot run the multiple streams at the same times.
        /// </summary>
        internal static string Stream_IllegalMultipleStreams {
            get {
                return ResourceManager.GetString("Stream_IllegalMultipleStreams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify what to do when the stream retrieves an object.
        /// </summary>
        internal static string Stream_ObjectDelegateIsNull {
            get {
                return ResourceManager.GetString("Stream_ObjectDelegateIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stream.twitter.com/1.1/statuses/sample.json?.
        /// </summary>
        internal static string Stream_Sample {
            get {
                return ResourceManager.GetString("Stream_Sample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://userstream.twitter.com/1.1/user.json?.
        /// </summary>
        internal static string Stream_UserStream {
            get {
                return ResourceManager.GetString("Stream_UserStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot change the tracks while having the stream running or on pause. The stream must be stopped before updating the tracks..
        /// </summary>
        internal static string TrackedStream_ModifyTracks_NotStoppedException_Description {
            get {
                return ResourceManager.GetString("TrackedStream_ModifyTracks_NotStoppedException_Description", resourceCulture);
            }
        }
    }
}
