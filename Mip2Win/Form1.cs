using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mip2Win
{

    public partial class Form1 : Form
    {
        static string workingDir = Directory.GetCurrentDirectory();
        static string iniFile = workingDir + "\\Mip2Win.ini";
        static string waFolder, pListFile, server, port, urlbase;
        static string parameters;
        static bool musicipOnline = false;
        TimeSpan ttime, ptime;

        static List<Genre> genreList = new List<Genre>();
        static List<string> randomGenreList = new List<string>();
        static List<TrackBar> trackBarList = new List<TrackBar>();
        static List<TextBox> multiplierList = new List<TextBox>();
        static List<string> mainSongList = new List<string>();


        public Form1()
        {
            InitializeComponent();            
            dialogInit();
            readIni();
            tooltipService();
            helpService();
            tryConnectMIP();
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    

        private void Mip2Win_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void readDialog()
        {
            ttime = TotalTimePicker.Value - new DateTime(2015, 1, 1, 0, 0, 0);
            ptime = PartialTimePicker.Value - new DateTime(2015, 1, 1, 0, 0, 0);
            waFolder = winampFolder.Text;
            pListFile = workingDir + "\\" + plName.Text;
            server = serverAddress.Text;
            port = serverPort.Text;
            urlbase = server + ":" + port + "/api/";
        }

        private void dialogInit()
        {
            ttime = new TimeSpan(12, 0, 0);
            ptime = new TimeSpan(1, 0, 0);
            seedLast.Checked = false;
            lockGenre.Checked = true;
            restrictDuplicates.Checked = true;
            noDuplicatesIn.Text = "5";
            addCount.Checked = false;
            serverAddress.Text = "http://localhost";
            serverPort.Text = "10002";
            plName.Text = "Mip2Win.m3u8";
            winampFolder.Text = @"C:\\Program Files (x86)\\Winamp\\";
            autoStart_mon.Value = new DateTime(2015, 1, 1, 7, 30, 0);
            autoStart_tue.Value = new DateTime(2015, 1, 1, 7, 30, 0);
            autoStart_wed.Value = new DateTime(2015, 1, 1, 7, 30, 0);
            autoStart_thu.Value = new DateTime(2015, 1, 1, 7, 30, 0);
            autoStart_fri.Value = new DateTime(2015, 1, 1, 7, 30, 0);
            autoStart_sat.Value = new DateTime(2015, 1, 1, 8, 30, 0);
            autoStart_sun.Value = new DateTime(2015, 1, 1, 8, 30, 0);
            autoStop_mon.Value = new DateTime(2015, 1, 1, 19, 30, 0);
            autoStop_tue.Value = new DateTime(2015, 1, 1, 19, 30, 0);
            autoStop_wed.Value = new DateTime(2015, 1, 1, 19, 30, 0);
            autoStop_thu.Value = new DateTime(2015, 1, 1, 19, 30, 0);
            autoStop_fri.Value = new DateTime(2015, 1, 1, 19, 30, 0);
            autoStop_sat.Value = new DateTime(2015, 1, 1, 18, 30, 0);
            autoStop_sun.Value = new DateTime(2015, 1, 1, 18, 30, 0);
            autoStart_mon.Checked = true;
            autoStart_tue.Checked = true;
            autoStart_wed.Checked = true;
            autoStart_thu.Checked = true;
            autoStart_fri.Checked = true;
            autoStart_sat.Checked = true;
            autoStart_sun.Checked = true;
            autoStop_mon.Checked = true;
            autoStop_tue.Checked = true;
            autoStop_wed.Checked = true;
            autoStop_thu.Checked = true;
            autoStop_fri.Checked = true;
            autoStop_sat.Checked = true;
            autoStop_sun.Checked = true;
            addCount_mon.Checked = true;
            addCount_tue.Checked = true;
            addCount_wed.Checked = true;
            addCount_thu.Checked = true;
            addCount_fri.Checked = true;
            addCount_sat.Checked = false;
            addCount_sun.Checked = false;
        }

        private void readIni()
        {
            string[] line;
            string streamLine;
            try
            {
                if (File.Exists(iniFile))
                {
                    using (StreamReader iniStream = File.OpenText(iniFile))
                    {
                        while ((streamLine = iniStream.ReadLine()) != null)
                        {
                            line = streamLine.Split('=');
                            if (line[0] == "TotalPlayTime") { ttime = TimeSpan.Parse(line[1]); }
                            else if (line[0] == "PartialPlayTime") { ptime = TimeSpan.Parse(line[1]); }
                            else if (line[0] == "seedLast") { if (line[1] == "0") seedLast.Checked = false; }
                            else if (line[0] == "lockGenre") { if (line[1] == "0") lockGenre.Checked = false; }
                            else if (line[0] == "restrictDuplicates") { if (line[1] == "0") restrictDuplicates.Checked = false; }
                            else if (line[0] == "noDuplicatesIn") { noDuplicatesIn.Text = line[1]; }
                            else if (line[0] == "addCount") { if (line[1] == "0") addCount.Checked = false; }
                            else if (line[0] == "server") { serverAddress.Text = line[1]; }
                            else if (line[0] == "port") { serverPort.Text = line[1]; }
                            else if (line[0] == "WinampFolder") { winampFolder.Text = line[1]; }
                            else if (line[0] == "plistName") { plName.Text = line[1]; }

                            else if (line[0] == "autoStart_mon") { if (line[1] == "0") autoStart_mon.Checked = false; }
                            else if (line[0] == "autoStart_tue") { if (line[1] == "0") autoStart_tue.Checked = false; }
                            else if (line[0] == "autoStart_wed") { if (line[1] == "0") autoStart_wed.Checked = false; }
                            else if (line[0] == "autoStart_thu") { if (line[1] == "0") autoStart_thu.Checked = false; }
                            else if (line[0] == "autoStart_fri") { if (line[1] == "0") autoStart_fri.Checked = false; }
                            else if (line[0] == "autoStart_sat") { if (line[1] == "0") autoStart_sat.Checked = false; }
                            else if (line[0] == "autoStart_sun") { if (line[1] == "0") autoStart_sun.Checked = false; }
                            else if (line[0] == "autoStop_mon") { if (line[1] == "0") autoStop_mon.Checked = false; }
                            else if (line[0] == "autoStop_tue") { if (line[1] == "0") autoStop_tue.Checked = false; }
                            else if (line[0] == "autoStop_wed") { if (line[1] == "0") autoStop_wed.Checked = false; }
                            else if (line[0] == "autoStop_thu") { if (line[1] == "0") autoStop_thu.Checked = false; }
                            else if (line[0] == "autoStop_fri") { if (line[1] == "0") autoStop_fri.Checked = false; }
                            else if (line[0] == "autoStop_sat") { if (line[1] == "0") autoStop_sat.Checked = false; }
                            else if (line[0] == "autoStop_sun") { if (line[1] == "0") autoStop_sun.Checked = false; }

                            else if (line[0] == "autoStartTime_tue") { autoStart_tue.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_mon") { autoStart_mon.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_wed") { autoStart_wed.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_thu") { autoStart_thu.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_fri") { autoStart_fri.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_sat") { autoStart_sat.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStartTime_sun") { autoStart_sun.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_mon") { autoStop_mon.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_tue") { autoStop_tue.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_wed") { autoStop_wed.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_thu") { autoStop_thu.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_fri") { autoStop_fri.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_sat") { autoStop_sat.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }
                            else if (line[0] == "autoStopTime_sun") { autoStop_sun.Value = DateTime.ParseExact(line[1], "HH:mm:ss", CultureInfo.InvariantCulture); }

                            else if (line[0] == "addCount_mon") { if (line[1] == "0") addCount_mon.Checked = false; }
                            else if (line[0] == "addCount_tue") { if (line[1] == "0") addCount_tue.Checked = false; }
                            else if (line[0] == "addCount_wed") { if (line[1] == "0") addCount_wed.Checked = false; }
                            else if (line[0] == "addCount_thu") { if (line[1] == "0") addCount_thu.Checked = false; }
                            else if (line[0] == "addCount_fri") { if (line[1] == "0") addCount_fri.Checked = false; }
                            else if (line[0] == "addCount_sat") { if (line[1] == "0") addCount_sat.Checked = false; }
                            else if (line[0] == "addCount_sun") { if (line[1] == "0") addCount_sun.Checked = false; }

                            else if (line[0] != "") { genreList.Add(new Genre(line[0], Int16.Parse(line[1]))); }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TotalTimePicker.Value = new DateTime(2015, 1, 1,ttime.Hours, ttime.Minutes, ttime.Seconds);
            PartialTimePicker.Value = new DateTime(2015, 1, 1, ptime.Hours, ptime.Minutes, ptime.Seconds);
            waFolder = winampFolder.Text;
            pListFile = workingDir + "\\" + plName.Text;
            server = serverAddress.Text;
            port = serverPort.Text;
            urlbase = server + ":" + port + "/api/";
            writeIni();
        }

        private void writeIni()
        {
            try
            {
                using (StreamWriter ini = new StreamWriter(iniFile))
                {
                    ini.WriteLine("TotalPlayTime=" + TotalTimePicker.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("PartialPlayTime=" + PartialTimePicker.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("seedLast=" + Convert.ToInt32(seedLast.Checked).ToString());
                    ini.WriteLine("lockGenre=" + Convert.ToInt32(lockGenre.Checked).ToString());
                    ini.WriteLine("restrictDuplicates=" + Convert.ToInt32(restrictDuplicates.Checked).ToString());
                    ini.WriteLine("noDuplicatesIn=" + noDuplicatesIn.Text);
                    ini.WriteLine("addCount=" + Convert.ToInt32(addCount.Checked).ToString());
                    ini.WriteLine("server=" + serverAddress.Text);
                    ini.WriteLine("port=" + serverPort.Text);
                    ini.WriteLine("WinampFolder=" + winampFolder.Text.Replace("\\\\", "\\"));
                    ini.WriteLine("plistName=" + plName.Text);
                    ini.WriteLine("autoStart_mon=" + Convert.ToInt32(autoStart_mon.Checked).ToString());
                    ini.WriteLine("autoStart_tue=" + Convert.ToInt32(autoStart_tue.Checked).ToString());
                    ini.WriteLine("autoStart_wed=" + Convert.ToInt32(autoStart_wed.Checked).ToString());
                    ini.WriteLine("autoStart_thu=" + Convert.ToInt32(autoStart_thu.Checked).ToString());
                    ini.WriteLine("autoStart_fri=" + Convert.ToInt32(autoStart_fri.Checked).ToString());
                    ini.WriteLine("autoStart_sat=" + Convert.ToInt32(autoStart_sat.Checked).ToString());
                    ini.WriteLine("autoStart_sun=" + Convert.ToInt32(autoStart_sun.Checked).ToString());
                    ini.WriteLine("autoStop_mon=" + Convert.ToInt32(autoStop_mon.Checked).ToString());
                    ini.WriteLine("autoStop_tue=" + Convert.ToInt32(autoStop_tue.Checked).ToString());
                    ini.WriteLine("autoStop_wed=" + Convert.ToInt32(autoStop_wed.Checked).ToString());
                    ini.WriteLine("autoStop_thu=" + Convert.ToInt32(autoStop_thu.Checked).ToString());
                    ini.WriteLine("autoStop_fri=" + Convert.ToInt32(autoStop_fri.Checked).ToString());
                    ini.WriteLine("autoStop_sat=" + Convert.ToInt32(autoStop_sat.Checked).ToString());
                    ini.WriteLine("autoStop_sun=" + Convert.ToInt32(autoStop_sun.Checked).ToString());
                    ini.WriteLine("autoStartTime_mon=" + autoStart_mon.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_tue=" + autoStart_tue.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_wed=" + autoStart_wed.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_thu=" + autoStart_thu.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_fri=" + autoStart_fri.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_sat=" + autoStart_sat.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStartTime_sun=" + autoStart_sun.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_mon=" + autoStop_mon.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_tue=" + autoStop_tue.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_wed=" + autoStop_wed.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_thu=" + autoStop_thu.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_fri=" + autoStop_fri.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_sat=" + autoStop_sat.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("autoStopTime_sun=" + autoStop_sun.Value.ToString("HH:mm:ss"));
                    ini.WriteLine("addCount_mon=" + Convert.ToInt32(addCount_mon.Checked).ToString());
                    ini.WriteLine("addCount_tue=" + Convert.ToInt32(addCount_tue.Checked).ToString());
                    ini.WriteLine("addCount_wed=" + Convert.ToInt32(addCount_wed.Checked).ToString());
                    ini.WriteLine("addCount_thu=" + Convert.ToInt32(addCount_thu.Checked).ToString());
                    ini.WriteLine("addCount_fri=" + Convert.ToInt32(addCount_fri.Checked).ToString());
                    ini.WriteLine("addCount_sat=" + Convert.ToInt32(addCount_sat.Checked).ToString());
                    ini.WriteLine("addCount_sun=" + Convert.ToInt32(addCount_sun.Checked).ToString());
                    foreach (Genre genre in genreList) { ini.WriteLine(genre.name + "=" + genre.multiplier.ToString()); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void getGenres()
        {
            parameters = "genres";
            List<string> gList = query(urlbase, parameters);
            List<Genre> tmpGenreList = new List<Genre>();

            if (gList != null)
            {
                foreach (string g in gList)
                {
                    Genre genre = genreList.Find(gen => gen.name == g);

                    if (genre == null)
                        tmpGenreList.Add(new Genre(g, 1));
                    else if (genre != null)
                        tmpGenreList.Add(new Genre(genre.name, genre.multiplier));
                }
            }
            genreList.Clear();
            genreList = new List<Genre>(tmpGenreList);
            genrePanel.Controls.Clear();
            trackBarList.Clear();
            multiplierList.Clear();
            int i = 0;
            genrePanel.Visible = false;
            genrePanel.AutoScroll = false;
            genrePanel.AutoScroll = true;
            foreach (Genre genre in genreList)
            {
                TrackBar tBar = new TrackBar();
                tBar.Value = genre.multiplier;
                tBar.AutoSize = false;
                tBar.Height = 15;
                tBar.LargeChange = 1;
                tBar.Name = "tbar_" + i.ToString();
                Label lbl_index = new Label { Text = (i + 1).ToString() };
                lbl_index.TextAlign = ContentAlignment.MiddleLeft;
                lbl_index.AutoSize = true;
                Label lbl_genre = new Label { Text = genre.name };
                lbl_genre.TextAlign = ContentAlignment.MiddleLeft;
                lbl_genre.AutoSize = true;

                TextBox txt_value = new TextBox { Text = genre.multiplier.ToString() };
                txt_value.TextAlign = HorizontalAlignment.Left;
                txt_value.Width = 20;

                genrePanel.Controls.Add(lbl_index, 0, i);
                genrePanel.Controls.Add(lbl_genre, 1, i);
                genrePanel.Controls.Add(tBar, 2, i);
                genrePanel.Controls.Add(txt_value, 3, i);
                trackBarList.Add(tBar);
                multiplierList.Add(txt_value);
                i++;
                tBar.ValueChanged += tBar_moved;
                txt_value.TextChanged += txt_value_changed;
                txt_value.KeyPress += new KeyPressEventHandler(txt_value_keypress);
            }
            genrePanel.Visible = true;            
        }

        private void buildRandomGenreList()
        {
            randomGenreList.Clear();
            for (int i = 0; i < multiplierList.Count; i++)
            {
                Genre genre = genreList[i];
                if (genre.multiplier > 0) { for (int j = 0; j < genre.multiplier; j++) { randomGenreList.Add(genre.name); } }
                else { randomGenreList.Remove(genre.name); }
            }
            Random rng = new Random();
            int n = randomGenreList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = randomGenreList[k];
                randomGenreList[k] = randomGenreList[n];
                randomGenreList[n] = value;
            }
        }

        private void buildPlaylist()
        {
            getGenres();
            writeIni();
            buildRandomGenreList();
            mainSongList.Clear();
            rtbPlayList.Clear();
            TimeSpan plTtime = ttime;
            TimeSpan plPtime = ptime;
            List<string> partialSongList = new List<string>();
            List<string> selectedGenreList = new List<string>();

            string lastSong = "";
            string size = "";

            while (randomGenreList != null && plTtime > TimeSpan.Zero)
            {
                if (plTtime < plPtime) plPtime = plTtime;
                plTtime -= plPtime;
                size = plPtime.TotalMinutes.ToString();

                int rndIndex = new Random().Next(randomGenreList.Count);
                string genre = randomGenreList[rndIndex];
                if (randomGenreList.FindAll(g => g == genre).Count > 1) { randomGenreList.RemoveAt(rndIndex); }

                buildParameters(genre, size, lastSong);

                if (selectedGenreList.Find(g => g == genre) != null && !seedLast.Checked) Thread.Sleep(1000);
                partialSongList = query(urlbase, parameters);

                if (partialSongList == null)
                {
                    buildParameters(genre, size, "");
                    partialSongList = query(urlbase, parameters);
                }

                rtbPlayList.AppendText("\"" + urlbase + parameters + "\"\n");
                foreach (string song in partialSongList)
                {
                    rtbPlayList.AppendText(song + "\n");
                }
                rtbPlayList.AppendText("\n");
                mainSongList.AddRange(partialSongList);
                selectedGenreList.Add(genre);
                lastSong = fix(partialSongList[partialSongList.Count - 1]);
                partialSongList.Clear();

            }

            using (StreamWriter pl = new StreamWriter(pListFile))
            {
                foreach (string song in mainSongList)
                {
                    pl.WriteLine(song);
                }
            }
            

        }
        private void buildParameters(string genre, string size, string lastSong)
        {
            if (seedLast.Checked && lastSong != "") { parameters = "mix?song=" + lastSong + "&filter=" + genre; }
            else { parameters = "mix?filter=" + genre; }
            parameters += "&sizetype=min&size=" + size;
            if (lockGenre.Checked) parameters += "&mixgenre=true";
            else parameters += "&mixgenre=false";
            if (restrictDuplicates.Checked) parameters += "&rejecttype=tracks&rejectsize=" + noDuplicatesIn.Text;
        }

        private List<string> query(string url, string parameters)
        {
            string sURL = url + parameters;
            string responseLine = "";
            List<string> responseList = new List<string>();
                
            HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            HttpWebRequest.DefaultCachePolicy = policy;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.CachePolicy = policy;
            request.Timeout = 10000;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader responseReader = new StreamReader(responseStream))
                        {
                            while (responseLine != null)
                            {
                                responseLine = responseReader.ReadLine();
                                if (responseLine != null) responseList.Add(responseLine);
                            }
                        }
                    }
                }
            }
            catch (TimeoutException)
            {
                AutoClosingMessageBox.Show("http query: " + sURL + "\nerror: Can not connect to MusicIP database.", "Timeout", 5000);
                responseList = null;
            }
            catch (WebException)
            {
                AutoClosingMessageBox.Show("http query: " + sURL + "\nerror: Can not connect to MusicIP database.", "Closed connection", 5000);
                responseList = null;
            }
            return responseList;
        }
        
        private void PartialTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(PartialTimePicker.Value > TotalTimePicker.Value)
            {
                TotalTimePicker.Value = PartialTimePicker.Value;
            }
                ptime = PartialTimePicker.Value - new DateTime(2015, 1, 1, 0, 0, 0);
        }
        private void TotalTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(PartialTimePicker.Value > TotalTimePicker.Value)
            {
                PartialTimePicker.Value = TotalTimePicker.Value;
            }
                ttime = TotalTimePicker.Value - new DateTime(2015, 1, 1, 0, 0, 0);

        }
        private void tBar_moved(object sender, EventArgs e)
        {
            TrackBar tBar = sender as TrackBar;
            int index = trackBarList.IndexOf(tBar);
            genreList[index].multiplier = tBar.Value;
            multiplierList[index].Text = tBar.Value.ToString();
        }
        private void txt_value_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void txt_value_changed(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            int index = multiplierList.IndexOf(txt);
            genreList[index].multiplier = Int16.Parse(txt.Text);
            trackBarList[index].Value = Int16.Parse(txt.Text);
        }
        private void getGenreList_Click(object sender, EventArgs e)
        {
            readDialog();
            tryConnectMIP();
            if (musicipOnline) getGenres();

        }
        private void build_Click(object sender, EventArgs e)
        {
            readDialog();
            tryConnectMIP();
            if (musicipOnline) buildPlaylist();
        }

        private void restrictDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            if (restrictDuplicates.Checked == true) noDuplicatesIn.Enabled = true;
            else
            {
                noDuplicatesIn.Enabled = false;
                noDuplicatesIn.Text = "";
            }
        }
        private void tooltipService()
        {
            ToolTip ttip = new ToolTip();
            ttip.SetToolTip(genrePanel, "Random Genre selection probability factors");
            ttip.SetToolTip(seedLast, "Experimental feature:\nLast song of the partial playlist will be used as a seed (to form the next partial playlist).\nSome filenames can cause trouble! If exeception occurs list is built without the seed song.");
            ttip.SetToolTip(lockGenre, "Partial playlist will be based on a fixed genre.");
            ttip.SetToolTip(addCount, "Play count of the exported songs will be incremented by one \n(in MusicIP database).");
            ttip.SetToolTip(resetCount, "Reset play count of all songs in the filter named: \" pcount \"");
            ttip.SetToolTip(feedWinamp, "Send generated play list to winamp.");
            ttip.SetToolTip(feedProgress, "Incrementing play count values in MusicIP database.");
            ttip.SetToolTip(restrictDuplicates, "Same artist will not be selected within determined number of tracks.");
        }
        private void helpService()
        {
            string content ="<html><body><span style=\"font-family: arial, helvetica, sans-serif; font-size: x-small;\">"+
                "<p><font color=\"red\">About: </font><br />Mip2Win is a tiny application that creates smart playlists using MusicIP Mixer and exports to Winamp. <br />Version: 2.0; <br />Author: Serhan BAKIR</p>" +
                "<p><font color=\"red\">Basic Info: </font><br />Automatic playlist creation can be timer controlled and song selection is based on user preferences.</p>" +
                "<p><font color=\"red\">Preferences: </font><br />By adjusting total and partial play times a playlist can be created as a single part or with multiple partial lists.</p>" +
                "<p>\"Get Genres\" button fetches the existing genres from MusicIP database and forms a table showing them as an adjustable list.</p>"+
                "<p>With the sliders next to the genre titles, probability of random selection can be factored. Given a database consisting of various genres, incrementing a factor by one adds another instance to the random selection pool. A factor of zero makes that genre not included in random selection pool.</p>"+
                "<p>&ldquo;Seed last song\"; option will use the last song of the partial playlist as a seed to the next partial list. <br />&ldquo;Lock genre\"; option locks the playlist formation based on a specific genre. This cannot be used with seed last option at the same time.<br />&ldquo;Restrict duplicates\"; option will prevent re-occurring of the same artist within determined number of tracks.</p>"+
                "<p>&ldquo;Build Playlist\"; button utilizes MusicIP api to form a list depending on user preferences and determined durations. The resultant list and queries can be viewed on playlist tab. Pressing this button will also write current configuration to the Mip2Win.ini file.</p>" +
                "<p><font color=\"red\">Settings: </font><br />\"Server\" is the network address where MusicIP is running and api is enabled. \"Port\" is the number of port MusicIP is listening." +
                "<br />\"Playlist name\" defines the temporary play list file name created in the working directory of Mip2Win." +
                "<br />\"Winamp folder\" must be provided inorder to run the application." +
                "<br />Mip2Win will try to connect on startup try to find out whether MusicIP and Winamp are running." +
                "<p><font color=\"red\">Schedule: </font><br />On this tab scheduling for autostart and autostop can be configured on a daily basis." +
                "<br />\"Add Count\" option enables adding play count to the selected songs at the MusicIP database" +
                "<p><font color=\"red\">Playlist: </font><br />Automatically or manually generated playlists can be viewed on this tab. " +
                "<br />\"Feed Winamp\" button sends the current playlist to winamp" +
                "<br />\"Add playcount\" option increments the play count of the songs of the current play list while sending to winamp" +
                "<br />\"Reset\" button will remove the play count of all songs filtered with the name \"pcount\" in the MusicIP database. Use with caution!"+
                "</span></body></html>";

            helpAbout.DocumentText = content;
        }
        private void tryConnectMIP()
        {
            parameters = "version";
            List<string> response = new List<string>();
            response = query(urlbase, parameters);
            if (response != null)
            {
                musicipRunning.Text = response[0] + " is running";
                musicipRunning.ForeColor = Color.Green;
                musicipOnline = true;
            }
            else
            {
                musicipRunning.Text = "MusicIP is not running";
                musicipRunning.ForeColor = Color.Black;
                musicipOnline = false;
            }
        }
        private string fix (string song)
        {
            return song.Replace("&", "%26").Replace("?", "%3F");        
        }
        private void feedWinamp_Click(object sender, EventArgs e)
        {
            if (mainSongList.Count > 0 ) WinampFeed(7);
            else AutoClosingMessageBox.Show("Current playlist is empty. Build then feed.", "Empty list", 4000);
        }

        private void WinampFeed(int day)
        {
            DateTime now = DateTime.Now;
            List<CheckBox> addCountCheckers = new List<CheckBox> { addCount_sun, addCount_mon, addCount_tue, addCount_wed, addCount_thu, addCount_fri, addCount_sat, addCount };
            CheckBox addcount_daily = addCountCheckers[day];
            ProcessStartInfo winamp = new ProcessStartInfo();
            winamp.FileName = "winamp.exe";
            winamp.WorkingDirectory = Path.GetDirectoryName(winampFolder.Text);
            winamp.Arguments = "\"" + pListFile + "\"";
            Process.Start(winamp);
            writeIni();
            if (addcount_daily.Checked)
            {
                feedProgress.Visible = true;
                feedProgress.Maximum = mainSongList.Count;
                feedProgress.Step = 1;
                for (int i = 0; i < mainSongList.Count; i++ )
                {
                    parameters = "incrementPlayCount?song=" + fix(mainSongList[i]);
                    query(urlbase, parameters);
                    feedProgress.PerformStep();
                    //Thread.Sleep(10);
                }
                feedProgress.Visible = false;
            }

        }



        private void stopWinamp()
        {
            var winamp = new WinampControl();
            winamp.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_time.Text = now.ToString("dddd HH:mm:ss");
            List<DateTimePicker> startpickers = new List<DateTimePicker> { autoStart_sun, autoStart_mon, autoStart_tue, autoStart_wed, autoStart_thu, autoStart_fri, autoStart_sat };
            List<DateTimePicker> stoppickers = new List<DateTimePicker> { autoStop_sun, autoStop_mon, autoStop_tue, autoStop_wed, autoStop_thu, autoStop_fri, autoStop_sat };
            var day = (int)now.DayOfWeek;
            var start = startpickers[day];
            var starthour = start.Value.Hour;
            var startmin = start.Value.Minute;
            var startsec = start.Value.Second;
            var startcheck = start.Checked;

            var stop = stoppickers[day];
            var stophour = stop.Value.Hour;
            var stopmin = stop.Value.Minute;
            var stopsec = stop.Value.Second;
            var stopcheck = stop.Checked;

            if (now.Hour == starthour && now.Minute == startmin && now.Second == startsec && startcheck == true)
            {
                build_Click(null, null);
                if (musicipOnline) WinampFeed(day);
            }
            else if (now.Hour == stophour && now.Minute == stopmin && now.Second == stopsec && stopcheck == true)
            {
                stopWinamp();
            }

            if (Process.GetProcessesByName("winamp").Length == 1)
            {
                winampRunning.Text = "Winamp is running.";
                winampRunning.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                winampRunning.Text = "Winamp is not running.";
                winampRunning.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void resetCount_Click(object sender, EventArgs e)
        {
            readDialog();
            tryConnectMIP();
            if (musicipOnline)
            {
                List<string> filteredSongList = new List<string>();
                parameters = "songs?filter=pcount";
                filteredSongList = query(urlbase, parameters);
                foreach (string song in filteredSongList)
                {
                    parameters = "setPlayCount?count=0&force=1&song=" + fix(song);
                    query(urlbase, parameters);
                }
            }
            //else AutoClosingMessageBox.Show("\nerror: Can not connect to MusicIP database.", "Closed connection", 4000);

        }

        private void seedLast_CheckedChanged(object sender, EventArgs e)
        {
            if (seedLast.Checked)
            {
                lockGenre.Enabled = false;
                lockGenre.Checked = false;
            }
            else
                lockGenre.Enabled = true;
        }
    }

    public class Genre
    {
        public string name;
        public int multiplier;
        public Genre(string Name, int Multiplier)
        {
            this.name = Name;
            this.multiplier = Multiplier;
        }
    }
}
