//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.Runtime.ReminderService
{
    using Orleans.CodeGeneration;
    using Orleans;
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    
}
namespace Orleans.Runtime
{
    
}
namespace Orleans.Runtime.GrainDirectory
{
    
}
namespace Orleans.Runtime.MembershipService
{
    using Orleans.CodeGeneration;
    using Orleans;
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    
}
namespace Orleans.Runtime.Management
{
    using Orleans.CodeGeneration;
    using Orleans;
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    
}
namespace Orleans.Streams
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Collections;
    using System;
    using Orleans.CodeGeneration;
    using Orleans;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.Streams.Orleans.Streams.PubSubRendezvousGrain")]
    internal class PubSubRendezvousGrainState : global::Orleans.CodeGeneration.GrainState, IPubSubGrainState
    {
        

            public HashSet<PubSubPublisherState> @Producers { get; set; }

            public HashSet<PubSubSubscriptionState> @Consumers { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Producers", out value)) @Producers = (HashSet<PubSubPublisherState>) value;
                if (values.TryGetValue("Consumers", out value)) @Consumers = (HashSet<PubSubSubscriptionState>) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PubSubRendezvousGrainState( Producers={0} Consumers={1} )", @Producers, @Consumers);
            }
        
        public PubSubRendezvousGrainState() : 
                base("Orleans.Streams.PubSubRendezvousGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Producers"] = this.Producers;
            result["Consumers"] = this.Consumers;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Producers = new HashSet<PubSubPublisherState>();
            this.Consumers = new HashSet<PubSubSubscriptionState>();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PubSubRendezvousGrainState input = ((PubSubRendezvousGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PubSubRendezvousGrainState input = ((PubSubRendezvousGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PubSubRendezvousGrainState result = new PubSubRendezvousGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
