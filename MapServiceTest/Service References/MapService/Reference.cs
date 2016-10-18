﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapServiceTest.MapService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponse", Namespace="http://schemas.datacontract.org/2004/07/MapService.CommandObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MapServiceTest.MapService.GetDetailedMapByPixelLocationResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MapServiceTest.MapService.GetMapThumbnailResponse))]
    public partial class BaseResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDetailedMapByPixelLocationResponse", Namespace="http://schemas.datacontract.org/2004/07/MapService.CommandObjects")]
    [System.SerializableAttribute()]
    public partial class GetDetailedMapByPixelLocationResponse : MapServiceTest.MapService.BaseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailedImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MapNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DetailedImage {
            get {
                return this.DetailedImageField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailedImageField, value) != true)) {
                    this.DetailedImageField = value;
                    this.RaisePropertyChanged("DetailedImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MapName {
            get {
                return this.MapNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MapNameField, value) != true)) {
                    this.MapNameField = value;
                    this.RaisePropertyChanged("MapName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMapThumbnailResponse", Namespace="http://schemas.datacontract.org/2004/07/MapService.CommandObjects")]
    [System.SerializableAttribute()]
    public partial class GetMapThumbnailResponse : MapServiceTest.MapService.BaseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LatitudeMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LatitudeMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LongitudeMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LongitudeMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MapNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThumbnailField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LatitudeMax {
            get {
                return this.LatitudeMaxField;
            }
            set {
                if ((this.LatitudeMaxField.Equals(value) != true)) {
                    this.LatitudeMaxField = value;
                    this.RaisePropertyChanged("LatitudeMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LatitudeMin {
            get {
                return this.LatitudeMinField;
            }
            set {
                if ((this.LatitudeMinField.Equals(value) != true)) {
                    this.LatitudeMinField = value;
                    this.RaisePropertyChanged("LatitudeMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LongitudeMax {
            get {
                return this.LongitudeMaxField;
            }
            set {
                if ((this.LongitudeMaxField.Equals(value) != true)) {
                    this.LongitudeMaxField = value;
                    this.RaisePropertyChanged("LongitudeMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LongitudeMin {
            get {
                return this.LongitudeMinField;
            }
            set {
                if ((this.LongitudeMinField.Equals(value) != true)) {
                    this.LongitudeMinField = value;
                    this.RaisePropertyChanged("LongitudeMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MapName {
            get {
                return this.MapNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MapNameField, value) != true)) {
                    this.MapNameField = value;
                    this.RaisePropertyChanged("MapName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Thumbnail {
            get {
                return this.ThumbnailField;
            }
            set {
                if ((object.ReferenceEquals(this.ThumbnailField, value) != true)) {
                    this.ThumbnailField = value;
                    this.RaisePropertyChanged("Thumbnail");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://stm.eti.gda.pl/stm", ConfigurationName="MapService.IMapService")]
    public interface IMapService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetMapThumbnail", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetMapThumbnailResponse")]
        MapServiceTest.MapService.GetMapThumbnailResponse GetMapThumbnail(string mapName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetMapThumbnail", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetMapThumbnailResponse")]
        System.Threading.Tasks.Task<MapServiceTest.MapService.GetMapThumbnailResponse> GetMapThumbnailAsync(string mapName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByPixelLocation", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByPixelLocationResponse")]
        MapServiceTest.MapService.GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(string mapName, int x1, int y1, int x2, int y2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByPixelLocation", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByPixelLocationResponse")]
        System.Threading.Tasks.Task<MapServiceTest.MapService.GetDetailedMapByPixelLocationResponse> GetDetailedMapByPixelLocationAsync(string mapName, int x1, int y1, int x2, int y2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByCoordinates", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByCoordinatesResponse")]
        bool GetDetailedMapByCoordinates(string mapName, double latitude, double longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByCoordinates", ReplyAction="http://stm.eti.gda.pl/stm/IMapService/GetDetailedMapByCoordinatesResponse")]
        System.Threading.Tasks.Task<bool> GetDetailedMapByCoordinatesAsync(string mapName, double latitude, double longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMapServiceChannel : MapServiceTest.MapService.IMapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MapServiceClient : System.ServiceModel.ClientBase<MapServiceTest.MapService.IMapService>, MapServiceTest.MapService.IMapService {
        
        public MapServiceClient() {
        }
        
        public MapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MapServiceTest.MapService.GetMapThumbnailResponse GetMapThumbnail(string mapName) {
            return base.Channel.GetMapThumbnail(mapName);
        }
        
        public System.Threading.Tasks.Task<MapServiceTest.MapService.GetMapThumbnailResponse> GetMapThumbnailAsync(string mapName) {
            return base.Channel.GetMapThumbnailAsync(mapName);
        }
        
        public MapServiceTest.MapService.GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(string mapName, int x1, int y1, int x2, int y2) {
            return base.Channel.GetDetailedMapByPixelLocation(mapName, x1, y1, x2, y2);
        }
        
        public System.Threading.Tasks.Task<MapServiceTest.MapService.GetDetailedMapByPixelLocationResponse> GetDetailedMapByPixelLocationAsync(string mapName, int x1, int y1, int x2, int y2) {
            return base.Channel.GetDetailedMapByPixelLocationAsync(mapName, x1, y1, x2, y2);
        }
        
        public bool GetDetailedMapByCoordinates(string mapName, double latitude, double longitude) {
            return base.Channel.GetDetailedMapByCoordinates(mapName, latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<bool> GetDetailedMapByCoordinatesAsync(string mapName, double latitude, double longitude) {
            return base.Channel.GetDetailedMapByCoordinatesAsync(mapName, latitude, longitude);
        }
    }
}
