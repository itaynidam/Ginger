﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GingerPACTPlugIn.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GingerPACTPlugIn.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _Add_16x16 {
            get {
                object obj = ResourceManager.GetObject("_Add_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _Compile_16x16 {
            get {
                object obj = ResourceManager.GetObject("_Compile_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _JAVAdoc_16x16 {
            get {
                object obj = ResourceManager.GetObject("_JAVAdoc_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _JSONdoc_16x16 {
            get {
                object obj = ResourceManager.GetObject("_JSONdoc_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Rule
        ///
        ///@Pact(provider=&quot;&lt;&lt;Provider&gt;&gt;&quot;, consumer=&quot;&lt;&lt;Consumer&gt;&gt;&quot;)
        ///public RequestResponsePact InteractionBuilder(PactDslWithProvider builder) 
        ///{
        ///&lt;&lt;Interactions_Data&gt;&gt;	
        ///	.toPact();
        ///}
        ///
        ///@Test
        ///@PactVerification(&quot;&quot;).
        /// </summary>
        internal static string JavaTemplate {
            get {
                return ResourceManager.GetString("JavaTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interaction: // Interaction Name
        ///	Given &quot;&quot;               
        ///	Upon Receiving &quot;&quot;
        ///		Method &quot;&quot;
        ///		Path &quot;&quot;
        ///		Headers:
        ///			|Key           |Value             |
        ///			|&quot;Content-Type&quot;|&quot;application/json&quot;|
        ///		Body:
        ///			{&quot;param&quot;:&quot;value&quot;, &quot;param&quot;:&quot;value&quot;}	
        ///	Will Respond With
        ///		Status &quot;&quot;
        ///		Headers:
        ///			|Key           |Value             |
        ///			|&quot;Content-Type&quot;|&quot;application/json&quot;|
        ///		Body:
        ///			{&quot;Param&quot;: &quot;Value&quot;}.
        /// </summary>
        internal static string NewInteractionTemplate {
            get {
                return ResourceManager.GetString("NewInteractionTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] PACTHighlighting {
            get {
                object obj = ResourceManager.GetObject("PACTHighlighting", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*PACT: PACT Name */
        ///
        ///Consumer: &quot;&quot;
        ///Provider: &quot;&quot;
        ///
        ///@Tag1 @Tag2
        ///
        ///Interaction: // Interaction Name
        ///	Given &quot;&quot;               
        ///	Upon Receiving &quot;&quot;
        ///		Method &quot;&quot;
        ///		Path &quot;&quot;
        ///		Headers:
        ///			|Key           |Value             |
        ///			|&quot;Content-Type&quot;|&quot;application/json&quot;|
        ///		Body:
        ///			{&quot;param&quot;:&quot;value&quot;, &quot;param&quot;:&quot;value&quot;}	
        ///	Will Respond With
        ///		Status &quot;&quot;
        ///		Headers:
        ///			|Key           |Value             |
        ///			|&quot;Content-Type&quot;|&quot;application/json&quot;|
        ///		Body:
        ///			{&quot;Param&quot;: &quot;Value&quot;}
        ///			
        ///
        ///
        ///Interaction: // get_alligator
        ///	 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PactTemplate {
            get {
                return ResourceManager.GetString("PactTemplate", resourceCulture);
            }
        }
    }
}
