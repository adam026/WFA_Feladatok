﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoldseges.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Zoldseges.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] _01_Feladat14sz {
            get {
                object obj = ResourceManager.GetObject("_01_Feladat14sz", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ***CREATE DATABASE Zoldseges_Gyak;
        ///***USE Zoldseges_Gyak;
        ///
        ///CREATE TABLE Zoldseg(
        ///Id INT PRIMARY KEY IDENTITY,
        ///Nev VARCHAR(50),
        ///EgysegAr INT);
        ///
        ///CREATE TABLE Eladas(
        ///Id INT PRIMARY KEY IDENTITY,
        ///Datum DATE,
        ///Zoldseg INT FOREIGN KEY REFERENCES Zoldseg(Id),
        ///Mennyiseg INT);
        ///
        ///INSERT INTO Zoldseg VALUES
        ///(&apos;eper&apos;, 2600),
        ///(&apos;bab&apos;, 1000),
        ///(&apos;dinnye&apos;, 120),
        ///(&apos;cékla&apos;, 250);
        ///
        ///INSERT INTO Eladas VALUES
        ///(&apos;2019-12-20&apos;, 1, 1),
        ///(&apos;2019-12-21&apos;, 2, 3),
        ///(&apos;2019-12-23&apos;, 2, 6),
        ///(&apos;2019-12-23&apos;, 2, 4),
        ///(&apos;2020-01-0 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DBCreator {
            get {
                return ResourceManager.GetString("DBCreator", resourceCulture);
            }
        }
    }
}
