using SME;

namespace TCPIP
{
    public partial class DataIn
    {
        public interface WriteBus : IBus
        {
            int socket { get; set; }
            uint tcp_seq { get; set; }
            byte data { get; set; }
            bool invalidate { get; set; }
            int data_length { get; set; }
        }
   }

}
