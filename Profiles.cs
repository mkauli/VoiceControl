﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace SendVoiceCommands {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class ApplicationProperties {
        
        private CommonSettings settingsField;
        
        private MusicNoteEvent[] eventListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CommonSettings Settings {
            get {
                return this.settingsField;
            }
            set {
                this.settingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Events", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public MusicNoteEvent[] EventList {
            get {
                return this.eventListField;
            }
            set {
                this.eventListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class CommonSettings {
        
        private string applicationNameField;
        
        private short frequenceDetectLevelField;
        
        private bool frequenceDetectLevelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicationName {
            get {
                return this.applicationNameField;
            }
            set {
                this.applicationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short FrequenceDetectLevel {
            get {
                return this.frequenceDetectLevelField;
            }
            set {
                this.frequenceDetectLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrequenceDetectLevelSpecified {
            get {
                return this.frequenceDetectLevelFieldSpecified;
            }
            set {
                this.frequenceDetectLevelFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class MusicNoteEvent {
        
        private string nameField;
        
        private short pianoKeyField;
        
        private bool pianoKeyFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short PianoKey {
            get {
                return this.pianoKeyField;
            }
            set {
                this.pianoKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PianoKeySpecified {
            get {
                return this.pianoKeyFieldSpecified;
            }
            set {
                this.pianoKeyFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.exampleURI.com/Schema1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.exampleURI.com/Schema1", IsNullable=false)]
    public partial class MusicNoteEventList {
        
        private MusicNoteEvent[] eventsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Events", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MusicNoteEvent[] Events {
            get {
                return this.eventsField;
            }
            set {
                this.eventsField = value;
            }
        }
    }
}
