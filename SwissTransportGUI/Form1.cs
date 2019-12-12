using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public string fromStation;
        public string toStation;
        public string date;
        public string time;

        public Form1()
        {
            InitializeComponent();
        }
        Transport SwissTrans = new Transport();

        //Adds List of Train Stations similar to User Input for Departure
        private void Cb_ConnectionFrom_TextChanged(object sender, EventArgs e)
        {
            var Stations = SwissTrans.GetStations(Cb_ConnectionFrom.Text).StationList;
            for(int n = 0; n < Stations.Count - 1; n++)
                Cb_ConnectionFrom.Items.Add(Stations[n].Name);
        }
        //Adds List of Train Stations similar to User Input for Destination
        private void Cb_ConnectionTo_TextChanged(object sender, EventArgs e)
        {
            var Stations = SwissTrans.GetStations(Cb_ConnectionTo.Text).StationList;
            for (int n = 0; n < Stations.Count - 1; n++)
                Cb_ConnectionTo.Items.Add(Stations[n].Name);
        }
        //Used for the Clock to update each Second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Uhr.Text = DateTime.Now.ToString("hh: mm:ss");
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Connections Connections;
            StationBoardRoot BoardRoot;

            Connections = SwissTrans.GetConnections(fromStation, toStation, date, time);
            BoardRoot = SwissTrans.GetStationBoard(fromStation, " ");

            for (int n = 0; n < Connections.ConnectionList.Count; n++)
            {
                string TimeLapse = Connections.ConnectionList[n].From.Departure.Remove(0, 11).Remove(5, 8) + " -> " + Connections.ConnectionList[n].To.Arrival.Remove(0, 11).Remove(5, 8);
                Lv_Connections.Items.Add(TimeLapse);

                string ConnectionName = BoardRoot.Entries[1].Category + " " + BoardRoot.Entries[n].Number;
                Lv_Connections.Items.Add(ConnectionName);

                string Duriation = Connections.ConnectionList[n].Duration.Remove(0, 3).Remove(5, 3) + " min";
                Lv_Connections.Items.Add(Duriation = Connections.ConnectionList[n].Duration.Remove(0, 3).Remove(5, 3) + " min");
            }
        }
    }
}
