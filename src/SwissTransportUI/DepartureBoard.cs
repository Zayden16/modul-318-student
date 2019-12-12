using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
namespace SwissTransportUI
{
    class DepartureBoard
    {
        public string DepartureStation { get; set; }
        public string DestinationStation { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public DepartureBoard()
        {
            DepartureStation = "0";
            DestinationStation = "0";
            Date = "0";
            Time = "0";
        }

        
    }
}
