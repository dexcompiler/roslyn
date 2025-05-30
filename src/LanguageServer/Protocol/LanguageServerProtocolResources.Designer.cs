﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.LanguageServer; 
using System;


/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal sealed class LanguageServerProtocolResources {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal LanguageServerProtocolResources() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.LanguageServer.LanguageServerProtocolResources", typeof(LanguageServerProtocolResources).Assembly);
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
    ///   Looks up a localized string similar to Unable to deserialize Uri. Unexpected value encountered: {0}.
    /// </summary>
    internal static string DocumentUriSerializationError {
        get {
            return ResourceManager.GetString("DocumentUriSerializationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize MarkupContent. Unexpected value encountered: {0}.
    /// </summary>
    internal static string MarkupContentSerializationError {
        get {
            return ResourceManager.GetString("MarkupContentSerializationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A SumType cannot have another SumType as type parameter..
    /// </summary>
    internal static string NestedSumType {
        get {
            return ResourceManager.GetString("NestedSumType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to None of the SumType type parameters could be deserialized.
    /// </summary>
    internal static string NoSumTypeMatch {
        get {
            return ResourceManager.GetString("NoSumTypeMatch", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Type {0} is missing a contructor that takes a single string as parameter..
    /// </summary>
    internal static string StringEnumMissingConstructor {
        get {
            return ResourceManager.GetString("StringEnumMissingConstructor", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize string-based enum. Unexpected data encountered: {0}.
    /// </summary>
    internal static string StringEnumSerializationError {
        get {
            return ResourceManager.GetString("StringEnumSerializationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize TextDocumentSyncOptions.  Unexpected value encountered: {0}.
    /// </summary>
    internal static string TextDocumentSyncSerializationError {
        get {
            return ResourceManager.GetString("TextDocumentSyncSerializationError", resourceCulture);
        }
    }

    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize FormattingOptions. Invalid token: {0}.
    /// </summary>
    internal static string FormattingOptionsEncounteredInvalidToken
    {
        get
        {
            return ResourceManager.GetString("FormattingOptionsEncounteredInvalidToken", resourceCulture);
        }
    }

    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize FormattingOptions as it ended unexpectedly.
    /// </summary>
    internal static string FormattingOptionsEndedUnexpectedly
    {
        get
        {
            return ResourceManager.GetString("FormattingOptionsEndedUnexpectedly", resourceCulture);
        }
    }

    /// <summary>
    ///   Looks up a localized string similar to Unable to deserialize FormattingOptions. Missing required property: {0}.
    /// </summary>
    internal static string FormattingOptionsMissingRequiredProperty
    {
        get
        {
            return ResourceManager.GetString("FormattingOptionsMissingRequiredProperty", resourceCulture);
        }
    }
}
