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
        public string Date;
        public string Time;

        public Form1()
        {
            InitializeComponent();
        }
        Transport SwissTrans = new Transport();

        private void ResetComboboxBackground(ComboBox comboBox)
        {
            comboBox.BackColor = SystemColors.Window;
        }
        private void AddStationNames(ComboBox comboBox)
        {
            comboBox.DroppedDown = true;
            foreach (SwissTransport.Station station in SwissTrans.GetStations(comboBox.Text).StationList)
            {
                if (station.Name != null)
                    comboBox.Items.Add(station.Name);
            }
        }
        private void ClearStationNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }
        private bool StationValid(ComboBox comboBox)
        {
            bool returnValue = true;
            if (comboBox.Text.Length <= 0 || comboBox.Text == null)
            {
                returnValue = false;
            }
            return returnValue;
        }
        private void SetCbBackgroundToRed(ComboBox comboBox)
        {
            comboBox.BackColor = Color.FromArgb(255, 92, 92);
        }

        #region Search for a Connection Tab

        //Adds List of Train Stations similar to User Input for Departure
        private void Cb_ConnectionFrom_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionFrom);
            ClearStationNames(Cb_ConnectionFrom);
            AddStationNames(Cb_ConnectionFrom);
        }
        //Adds List of Train Stations similar to User Input for Destination
        private void Cb_ConnectionTo_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionTo); 
            ClearStationNames(Cb_ConnectionTo);
            AddStationNames(Cb_ConnectionTo);
        }
        //Used for the Clock to update each Second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Uhr.Text = DateTime.Now.ToString("hh: mm:ss");
        } 
        private ListViewItem ShowConnections(Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), connection.From.Departure.ToString().Substring(11, 5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform };
            return new ListViewItem(connections);
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Lv_Connections.Items.Clear();
            if (StationValid(Cb_ConnectionFrom) && StationValid(Cb_ConnectionTo))
            {
                string date = Dtp_Date.Value.Year + "-" + Dtp_Date.Value.Month + "-" + Dtp_Date.Value.Day;
                foreach (SwissTransport.Connection connection in SwissTrans.GetConnections(Cb_ConnectionFrom.Text, Cb_ConnectionTo.Text, date, Txt_Time.Text).ConnectionList)
                {
                    Lv_Connections.Items.Add(ShowConnections(connection));
                }
            }
            if(!StationValid(Cb_ConnectionFrom))
            {
                SetCbBackgroundToRed(Cb_ConnectionFrom);
                MessageBox.Show("Please Check the Value");
            }
            if (!StationValid(Cb_ConnectionTo)) { 
                SetCbBackgroundToRed(Cb_ConnectionTo);
                MessageBox.Show("Please Check the Value");
            }
        }
        #endregion

        #region Departure Board Tab
        private ListViewItem ShowDepartures(StationBoard stationBoard)
        {
            string[] departures = { stationBoard.Stop.Departure.ToString().Substring(11, 5), stationBoard.To, stationBoard.Category + stationBoard.Number };
            return new ListViewItem(departures);
        }
        private void Cb_ConnectionsFromDepBoard_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionsFromDepBoard);
            ClearStationNames(Cb_ConnectionsFromDepBoard);
            AddStationNames(Cb_ConnectionsFromDepBoard);
        }  
        private void Btn_Search_DepBoard_Click(object sender, EventArgs e)
        {
            lv_DepartureBoard.Items.Clear();
            if(StationValid(Cb_ConnectionsFromDepBoard))
            {
                string date = Dtp_Date.Value.Year + "-" + Dtp_Date.Value.Month + "-" + Dtp_Date.Value.Day;
                foreach (StationBoard stationBoard in SwissTrans.GetStationBoard(Cb_ConnectionsFromDepBoard.Text, "").Entries)
                {
                    lv_DepartureBoard.Items.Add(ShowDepartures(stationBoard));
                }
            }
            else
            {
                SetCbBackgroundToRed(Cb_ConnectionsFromDepBoard);
                MessageBox.Show("Please Check the Value");      
            }
        }
        #endregion

    }
}