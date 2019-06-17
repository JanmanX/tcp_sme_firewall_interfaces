using SME;

namespace TCPIP
{
    public partial class PacketIn
    {
        public interface WriteBus  : IBus
        {
            [InitialValue(0x00)]
            byte protocol { get; set; }

            [InitialValue(0x00)]
            ulong ip_dst_addr_0 { get; set; }

            [InitialValue(0x00)]
            ulong ip_dst_addr_1 { get; set; }

            [InitialValue(0x00)]
            ulong ip_src_addr_0 { get; set; }

            [InitialValue(0x00)]
            ulong ip_src_addr_1 { get; set; }

            [InitialValue(0x00)]
            uint ip_id { get; set; }

            [InitialValue(0x00)]
            uint fragment_offset { get; set; }

            [InitialValue(0x00)]
            int data_length { get; set; }

            [InitialValue(0x00)]
            byte data { get; set; }

            [InitialValue(-1)]
            int addr { get; set; }
        }
    }
}
