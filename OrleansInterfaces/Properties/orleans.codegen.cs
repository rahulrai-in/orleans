//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace OrleansInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using OrleansInterfaces;
    using Orleans;
    using Orleans.Runtime;
    using Orleans.Core;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class AggregatorGrainFactory
    {
        

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IAggregatorGrain> instead.")]
                        public static IAggregatorGrain GetGrain(System.String primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IAggregatorGrain), primaryKey));
                        }

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IAggregatorGrain> instead.")]
                        public static IAggregatorGrain GetGrain(System.String primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IAggregatorGrain), primaryKey, grainClassNamePrefix));
                        }

            public static IAggregatorGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return AggregatorGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("OrleansInterfaces.IAggregatorGrain")]
        internal class AggregatorGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, OrleansInterfaces.IAggregatorGrain
        {
            

            public static IAggregatorGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IAggregatorGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IAggregatorGrain), (global::Orleans.Runtime.GrainReference gr) => { return new AggregatorGrainReference(gr);}, grainRef, -720626290);
            }
            
            protected internal AggregatorGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal AggregatorGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -720626290;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "OrleansInterfaces.IAggregatorGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                AggregatorGrainReference input = ((AggregatorGrainReference)(original));
                return ((AggregatorGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                AggregatorGrainReference input = ((AggregatorGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return AggregatorGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1277021679));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return AggregatorGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<OrleansInterfaces.GrainInformation> OrleansInterfaces.IAggregatorGrain.GetGrainInformation(int @position)
            {

                return base.InvokeMethodAsync<OrleansInterfaces.GrainInformation>(-274381691, new object[] {@position} );
            }
            
            System.Threading.Tasks.Task OrleansInterfaces.IAggregatorGrain.SetColor(OrleansInterfaces.GrainInformation @grainInformation)
            {

                return base.InvokeMethodAsync<object>(937813785, new object[] {@grainInformation} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("OrleansInterfaces.IAggregatorGrain", -720626290)]
    internal class AggregatorGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -720626290;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -720626290:  // IAggregatorGrain
                        switch (methodId)
                        {
                            case -274381691: 
                                return ((IAggregatorGrain)grain).GetGrainInformation((Int32)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 937813785: 
                                return ((IAggregatorGrain)grain).SetColor((GrainInformation)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1277021679:  // IGrainWithStringKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -720626290:  // IAggregatorGrain
                    switch (methodId)
                    {
                        case -274381691:
                            return "GetGrainInformation";
                    case 937813785:
                            return "SetColor";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1277021679:  // IGrainWithStringKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DecodeGrainFactory
    {
        

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IDecodeGrain> instead.")]
                        public static IDecodeGrain GetGrain(System.String primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), primaryKey));
                        }

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IDecodeGrain> instead.")]
                        public static IDecodeGrain GetGrain(System.String primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), primaryKey, grainClassNamePrefix));
                        }

            public static IDecodeGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DecodeGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("OrleansInterfaces.IDecodeGrain")]
        internal class DecodeGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, OrleansInterfaces.IDecodeGrain
        {
            

            public static IDecodeGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IDecodeGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IDecodeGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DecodeGrainReference(gr);}, grainRef, -1644118904);
            }
            
            protected internal DecodeGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DecodeGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1644118904;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "OrleansInterfaces.IDecodeGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                return ((DecodeGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DecodeGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1277021679));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DecodeGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task OrleansInterfaces.IDecodeGrain.DecodeDeviceMessage(string @ipAndColorMessage)
            {

                return base.InvokeMethodAsync<object>(-1195515568, new object[] {@ipAndColorMessage} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("OrleansInterfaces.IDecodeGrain", -1644118904)]
    internal class DecodeGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1644118904;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1644118904:  // IDecodeGrain
                        switch (methodId)
                        {
                            case -1195515568: 
                                return ((IDecodeGrain)grain).DecodeDeviceMessage((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1277021679:  // IGrainWithStringKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1644118904:  // IDecodeGrain
                    switch (methodId)
                    {
                        case -1195515568:
                            return "DecodeDeviceMessage";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1277021679:  // IGrainWithStringKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DeviceGrainFactory
    {
        

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IDeviceGrain> instead.")]
                        public static IDeviceGrain GetGrain(System.String primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), primaryKey));
                        }

                        [System.Obsolete("This method has been deprecated. Please use GrainFactory.GetGrain<IDeviceGrain> instead.")]
                        public static IDeviceGrain GetGrain(System.String primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), primaryKey, grainClassNamePrefix));
                        }

            public static IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DeviceGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("OrleansInterfaces.IDeviceGrain")]
        internal class DeviceGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, OrleansInterfaces.IDeviceGrain
        {
            

            public static IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IDeviceGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IDeviceGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DeviceGrainReference(gr);}, grainRef, -2105953344);
            }
            
            protected internal DeviceGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DeviceGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -2105953344;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "OrleansInterfaces.IDeviceGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                return ((DeviceGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DeviceGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1277021679));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DeviceGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<string> OrleansInterfaces.IDeviceGrain.GetColor()
            {

                return base.InvokeMethodAsync<System.String>(1567424079, null );
            }
            
            System.Threading.Tasks.Task OrleansInterfaces.IDeviceGrain.SetColor(string @colorName)
            {

                return base.InvokeMethodAsync<object>(-1860597175, new object[] {@colorName} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("OrleansInterfaces.IDeviceGrain", -2105953344)]
    internal class DeviceGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -2105953344;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -2105953344:  // IDeviceGrain
                        switch (methodId)
                        {
                            case 1567424079: 
                                return ((IDeviceGrain)grain).GetColor().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1860597175: 
                                return ((IDeviceGrain)grain).SetColor((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1277021679:  // IGrainWithStringKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -2105953344:  // IDeviceGrain
                    switch (methodId)
                    {
                        case 1567424079:
                            return "GetColor";
                    case -1860597175:
                            return "SetColor";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1277021679:  // IGrainWithStringKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class OrleansInterfaces_GrainInformationSerialization
    {
        
        static OrleansInterfaces_GrainInformationSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            return original;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            OrleansInterfaces.GrainInformation input = ((OrleansInterfaces.GrainInformation)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.DeviceId, stream, typeof(string));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Time, stream, typeof(System.DateTime));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Value, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            OrleansInterfaces.GrainInformation result = new OrleansInterfaces.GrainInformation();
            result.DeviceId = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            result.Time = ((System.DateTime)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.DateTime), stream)));
            result.Value = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(OrleansInterfaces.GrainInformation), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
