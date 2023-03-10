//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VarelagerProjekt.DVIService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://dvimonitor.azurewebsites.net/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/", ConfigurationName="DVIService.monitorSoap")]
    public interface monitorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        double StockTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        double StockHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockHumidityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        double OutdoorTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        double OutdoorHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorHumidityAsync();
        
        // CODEGEN: Generating message contract since element name StockItemsUnderMinResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        VarelagerProjekt.DVIService.StockItemsUnderMinResponse StockItemsUnderMin(VarelagerProjekt.DVIService.StockItemsUnderMinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync(VarelagerProjekt.DVIService.StockItemsUnderMinRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsOverMaxResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        VarelagerProjekt.DVIService.StockItemsOverMaxResponse StockItemsOverMax(VarelagerProjekt.DVIService.StockItemsOverMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync(VarelagerProjekt.DVIService.StockItemsOverMaxRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsMostSoldResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        VarelagerProjekt.DVIService.StockItemsMostSoldResponse StockItemsMostSold(VarelagerProjekt.DVIService.StockItemsMostSoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync(VarelagerProjekt.DVIService.StockItemsMostSoldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMin", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsUnderMinRequestBody Body;
        
        public StockItemsUnderMinRequest() {
        }
        
        public StockItemsUnderMinRequest(VarelagerProjekt.DVIService.StockItemsUnderMinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsUnderMinRequestBody {
        
        public StockItemsUnderMinRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMinResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsUnderMinResponseBody Body;
        
        public StockItemsUnderMinResponse() {
        }
        
        public StockItemsUnderMinResponse(VarelagerProjekt.DVIService.StockItemsUnderMinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsUnderMinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsUnderMinResult;
        
        public StockItemsUnderMinResponseBody() {
        }
        
        public StockItemsUnderMinResponseBody(VarelagerProjekt.DVIService.ArrayOfString StockItemsUnderMinResult) {
            this.StockItemsUnderMinResult = StockItemsUnderMinResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMax", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsOverMaxRequestBody Body;
        
        public StockItemsOverMaxRequest() {
        }
        
        public StockItemsOverMaxRequest(VarelagerProjekt.DVIService.StockItemsOverMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsOverMaxRequestBody {
        
        public StockItemsOverMaxRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMaxResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsOverMaxResponseBody Body;
        
        public StockItemsOverMaxResponse() {
        }
        
        public StockItemsOverMaxResponse(VarelagerProjekt.DVIService.StockItemsOverMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsOverMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsOverMaxResult;
        
        public StockItemsOverMaxResponseBody() {
        }
        
        public StockItemsOverMaxResponseBody(VarelagerProjekt.DVIService.ArrayOfString StockItemsOverMaxResult) {
            this.StockItemsOverMaxResult = StockItemsOverMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSold", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsMostSoldRequestBody Body;
        
        public StockItemsMostSoldRequest() {
        }
        
        public StockItemsMostSoldRequest(VarelagerProjekt.DVIService.StockItemsMostSoldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsMostSoldRequestBody {
        
        public StockItemsMostSoldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSoldResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public VarelagerProjekt.DVIService.StockItemsMostSoldResponseBody Body;
        
        public StockItemsMostSoldResponse() {
        }
        
        public StockItemsMostSoldResponse(VarelagerProjekt.DVIService.StockItemsMostSoldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsMostSoldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsMostSoldResult;
        
        public StockItemsMostSoldResponseBody() {
        }
        
        public StockItemsMostSoldResponseBody(VarelagerProjekt.DVIService.ArrayOfString StockItemsMostSoldResult) {
            this.StockItemsMostSoldResult = StockItemsMostSoldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface monitorSoapChannel : VarelagerProjekt.DVIService.monitorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class monitorSoapClient : System.ServiceModel.ClientBase<VarelagerProjekt.DVIService.monitorSoap>, VarelagerProjekt.DVIService.monitorSoap {
        
        public monitorSoapClient() {
        }
        
        public monitorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double StockTemp() {
            return base.Channel.StockTemp();
        }
        
        public System.Threading.Tasks.Task<double> StockTempAsync() {
            return base.Channel.StockTempAsync();
        }
        
        public double StockHumidity() {
            return base.Channel.StockHumidity();
        }
        
        public System.Threading.Tasks.Task<double> StockHumidityAsync() {
            return base.Channel.StockHumidityAsync();
        }
        
        public double OutdoorTemp() {
            return base.Channel.OutdoorTemp();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorTempAsync() {
            return base.Channel.OutdoorTempAsync();
        }
        
        public double OutdoorHumidity() {
            return base.Channel.OutdoorHumidity();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorHumidityAsync() {
            return base.Channel.OutdoorHumidityAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VarelagerProjekt.DVIService.StockItemsUnderMinResponse VarelagerProjekt.DVIService.monitorSoap.StockItemsUnderMin(VarelagerProjekt.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMin(request);
        }
        
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsUnderMin() {
            VarelagerProjekt.DVIService.StockItemsUnderMinRequest inValue = new VarelagerProjekt.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsUnderMinRequestBody();
            VarelagerProjekt.DVIService.StockItemsUnderMinResponse retVal = ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsUnderMin(inValue);
            return retVal.Body.StockItemsUnderMinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsUnderMinResponse> VarelagerProjekt.DVIService.monitorSoap.StockItemsUnderMinAsync(VarelagerProjekt.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMinAsync(request);
        }
        
        public System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync() {
            VarelagerProjekt.DVIService.StockItemsUnderMinRequest inValue = new VarelagerProjekt.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsUnderMinRequestBody();
            return ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsUnderMinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VarelagerProjekt.DVIService.StockItemsOverMaxResponse VarelagerProjekt.DVIService.monitorSoap.StockItemsOverMax(VarelagerProjekt.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMax(request);
        }
        
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsOverMax() {
            VarelagerProjekt.DVIService.StockItemsOverMaxRequest inValue = new VarelagerProjekt.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsOverMaxRequestBody();
            VarelagerProjekt.DVIService.StockItemsOverMaxResponse retVal = ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsOverMax(inValue);
            return retVal.Body.StockItemsOverMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsOverMaxResponse> VarelagerProjekt.DVIService.monitorSoap.StockItemsOverMaxAsync(VarelagerProjekt.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync() {
            VarelagerProjekt.DVIService.StockItemsOverMaxRequest inValue = new VarelagerProjekt.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsOverMaxRequestBody();
            return ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsOverMaxAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VarelagerProjekt.DVIService.StockItemsMostSoldResponse VarelagerProjekt.DVIService.monitorSoap.StockItemsMostSold(VarelagerProjekt.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSold(request);
        }
        
        public VarelagerProjekt.DVIService.ArrayOfString StockItemsMostSold() {
            VarelagerProjekt.DVIService.StockItemsMostSoldRequest inValue = new VarelagerProjekt.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsMostSoldRequestBody();
            VarelagerProjekt.DVIService.StockItemsMostSoldResponse retVal = ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsMostSold(inValue);
            return retVal.Body.StockItemsMostSoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsMostSoldResponse> VarelagerProjekt.DVIService.monitorSoap.StockItemsMostSoldAsync(VarelagerProjekt.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<VarelagerProjekt.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync() {
            VarelagerProjekt.DVIService.StockItemsMostSoldRequest inValue = new VarelagerProjekt.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new VarelagerProjekt.DVIService.StockItemsMostSoldRequestBody();
            return ((VarelagerProjekt.DVIService.monitorSoap)(this)).StockItemsMostSoldAsync(inValue);
        }
    }
}
