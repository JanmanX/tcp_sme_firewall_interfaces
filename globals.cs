using System;

using SME;
using SME.VHDL;

namespace TCPIP
{
    // CONSUMERS
    public interface ConsumerControlBus : IBus
    {
        [InitialValue(false)]
        bool ready { get; set; }
    }

    // PRODUCERS
    public interface ComputeProducerControlBus : IBus
    {
        [InitialValue(false)]
        bool available { get; set; }

        [InitialValue(false)]
        bool valid { get; set; }

        // Optional
        [InitialValue(0)]
        uint bytes_left { get; set; }
    }

    public interface BufferProducerControlBus : IBus
    {
        [InitialValue(false)]
        bool available { get; set; }

        [InitialValue(false)]
        bool valid { get; set; }

        [InitialValue(0)]
        uint bytes_left { get; set; }
    }
}
