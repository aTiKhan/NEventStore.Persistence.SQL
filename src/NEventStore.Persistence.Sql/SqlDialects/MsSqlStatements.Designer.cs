﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEventStore.Persistence.Sql.SqlDialects {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MsSqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MsSqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NEventStore.Persistence.Sql.SqlDialects.MsSqlStatements", typeof(MsSqlStatements).Assembly);
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
        ///   Looks up a localized string similar to IF EXISTS(SELECT * FROM sysobjects WHERE name=&apos;Commits&apos; AND xtype = &apos;U&apos;) RETURN;
        ///CREATE TABLE [dbo].[Commits]
        ///(
        ///       [BucketId] [varchar](40) NOT NULL,
        ///       [StreamId] [char](40) NOT NULL,
        ///       [StreamIdOriginal] [nvarchar](1000) NOT NULL,
        ///       [StreamRevision] [int] NOT NULL CHECK ([StreamRevision] &gt; 0),
        ///       [Items] [tinyint] NOT NULL CHECK ([Items] &gt; 0),
        ///       [CommitId] [uniqueidentifier] NOT NULL CHECK ([CommitId] != 0x0),
        ///       [CommitSequence] [int] NOT NULL CHECK ([CommitSequenc [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitializeStorage {
            get {
                return ResourceManager.GetString("InitializeStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH [cte] AS
        ///   ( {0}, ROW_NUMBER() OVER ({1}) AS [row] {2} )
        ///
        ///SELECT *
        ///  FROM [cte]
        /// WHERE [row] BETWEEN @Skip + 1
        ///                 AND @Limit + @Skip;.
        /// </summary>
        internal static string PagedQueryFormat {
            get {
                return ResourceManager.GetString("PagedQueryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO Commits
        ///     ( BucketId, StreamId, StreamIdOriginal, CommitId, CommitSequence, StreamRevision, Items, CommitStamp, Headers, Payload )
        ///OUTPUT INSERTED.CheckpointNumber
        ///VALUES (@BucketId, @StreamId, @StreamIdOriginal, @CommitId, @CommitSequence, @StreamRevision, @Items, @CommitStamp, @Headers, @Payload);.
        /// </summary>
        internal static string PersistCommits {
            get {
                return ResourceManager.GetString("PersistCommits", resourceCulture);
            }
        }
    }
}
