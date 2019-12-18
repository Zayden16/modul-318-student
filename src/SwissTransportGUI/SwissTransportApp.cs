using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class SwissTransportApp : Form
    {
        public string fromStation;
        public string toStation;
        public string Date;
        public string Time;

        public SwissTransportApp()
        {
            InitializeComponent();  
            Txt_Time.Text = DateTime.Now.ToString("HH:mm");
        }

        readonly Transport SwissTrans = new Transport();

        #region TAB: Search for Connections 
        private ListViewItem ShowConnections(Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), connection.From.Departure.ToString().Substring(11, 5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform };
            return new ListViewItem(connections);
        }

        private void Cb_ConnectionFrom_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionFrom);
            ClearStationNames(Cb_ConnectionFrom);
            AddStationNames(Cb_ConnectionFrom);
        }

        private void Cb_ConnectionTo_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionTo);
            ClearStationNames(Cb_ConnectionTo);
            AddStationNames(Cb_ConnectionTo);
        }

        //Used for the Clock Text to update each Second.
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Uhr.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Validates the Text in the time Combobox
        private bool ValidateTime(TextBox textBox)
        {
            string TimeToValidate = textBox.Text;
            bool returnValue = true;
            Match match = Regex.Match(TimeToValidate, @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$", RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                returnValue = false;
            }
            return returnValue;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Lv_Connections.Items.Clear();

            if (ValidateStations(Cb_ConnectionFrom) && ValidateStations(Cb_ConnectionTo) && ValidateTime(Txt_Time))
            {
                string Date = Dtp_Date.Value.Year + "-" + Dtp_Date.Value.Month + "-" + Dtp_Date.Value.Day; //Correct Date Format

                foreach (global::SwissTransport.Connection connection in SwissTrans.GetConnections(Cb_ConnectionFrom.Text, Cb_ConnectionTo.Text, Date, Txt_Time.Text).ConnectionList)
                {
                    Lv_Connections.Items.Add(ShowConnections(connection));
                }
            }
            if (!ValidateTime(Txt_Time))
            {
                Txt_Time.BackColor = Color.FromArgb(255, 92, 92);
                MessageBox.Show("Please Check Time Format (HH:MM)");
            }
            if (!ValidateStations(Cb_ConnectionFrom))
            {
                SetCbBackgroundToRed(Cb_ConnectionFrom);
                MessageBox.Show("Please Check the Value");
            }
            if (!ValidateStations(Cb_ConnectionTo))
            {
                SetCbBackgroundToRed(Cb_ConnectionTo);
                MessageBox.Show("Please Check the Value");
            }
        }
        private void Txt_Time_TextChanged(object sender, EventArgs e)
        {
            Txt_Time.BackColor = SystemColors.Window;
        }
        #endregion

        #region TAB: Departure Board
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
            if (ValidateStations(Cb_ConnectionsFromDepBoard))
            {
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

        #region TAB: Station Map
        // Gets the X and Y Coordinates of a Station and amalgamates it.
        private string GetStationGPSCoodrinates(string Station)
        {
            var station = SwissTrans.GetStations(Station).StationList.FirstOrDefault(x => Equals(x.Name, Station));
            if (station != null)
            {
                string x = Convert.ToString(station.Coordinate.XCoordinate);
                string y = Convert.ToString(station.Coordinate.YCoordinate);
                string amalgamatedCoordinates = x + "/" + y;
                return (amalgamatedCoordinates);
            }
            else
            {
                return ("ERROR");
            }
        }
        // Update the Browser with the actual GPS Coordinates.
        private void MoveMapToGPSCoordinates(string Coordinates)
        {
            Browser.Navigate("https://www.openstreetmap.org/#map=19/47.05010/8.31036&layers=T");
            var URL = "https://www.openstreetmap.org/#map=18/" + Coordinates + "&layers=T";
            Browser.Navigate(URL);
        }
        private void Btn_Search_Map_Click(object sender, EventArgs e)
        {
            if (ValidateStations(Cb_Station_Map))
            {
                var Coords = GetStationGPSCoodrinates(Cb_Station_Map.Text);
                MoveMapToGPSCoordinates(Coords);
            }
            else
            {
                SetCbBackgroundToRed(Cb_Station_Map);
                MessageBox.Show("Please Check the Value");
            }


        }
        private void Cb_Station_Map_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_Station_Map);
            ClearStationNames(Cb_Station_Map);
            AddStationNames(Cb_Station_Map);
        }
        #endregion

        #region TAB: Stations Near Me
        private string GetPublicIP()
        {
            using (var WebClient = new System.Net.WebClient())
            {
                string IP = WebClient.DownloadString("https://api.ipify.org");
                return IP;
            }
        }

        private string GetLocationFromIP(string IP)
        {
            using (var WebClient = new System.Net.WebClient())
            {
                string Location = WebClient.DownloadString("http://ip-api.com/json/" + IP + "?fields=lat,lon");
                // NOT IMPLEMENTED COMPLETELY //
                string xy = String.Concat(Location.Where(Char.IsDigit));
                return xy;
            }   
        }

        // Locates the User by using GetPublicIP() and GetLoctionFromIP().
        private void Btn_LocateMe_Click(object sender, EventArgs e)
        {
            var Location = GetLocationFromIP(GetPublicIP());
            textBox1.Text = Location;
        }

        #endregion

        #region Common Functions
        // Reset Combobox Color
        private void ResetComboboxBackground(ComboBox comboBox)
        {
            comboBox.BackColor = SystemColors.Window;
        }

        // Add StationNames based on User Input to a Combobox.
        private void AddStationNames(ComboBox comboBox)
        {
            try {
                comboBox.DroppedDown = true;
                foreach (global::SwissTransport.Station station in SwissTrans.GetStations(comboBox.Text).StationList)
                {
                    if (station.Name != null)
                        comboBox.Items.Add(station.Name);
                }
            }
            catch
            {
                MessageBox.Show("ERROR: No Network Connection or too many Requests were sent!", "Error");
            }
            
        }

        // Clear StationNames from the Combobox.
        private void ClearStationNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }

        // Checks if the Combobox is filled or not.
        private bool ValidateStations(ComboBox comboBox)
        {
            bool returnValue = true;
            if (comboBox.Text.Length <= 0 || comboBox.Text == null)
            {
                returnValue = false;
            }
            return returnValue;
        }

        // Sets the Combobox Background to Red to indicate that is not correct.
        private void SetCbBackgroundToRed(ComboBox comboBox)
        {
            comboBox.BackColor = Color.FromArgb(255, 92, 92);
        }
        #endregion
    }
}