using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MusicPlayerProject
{
    public partial class music_player : Form
    {
        public music_player()
        { 
            InitializeComponent();
            volume_bar.Value = 50;      
        }

        Random rand = new Random();
        int repeatmode = 0;
        List<Panel> listPanel = new List<Panel>();
        int page_index;
        private void music_player_Load(object sender, EventArgs e)
        {
            listPanel.Add(page_home);         
        }

        string[] paths, files;
       
        private void lb_home_Click(object sender, EventArgs e)
        {
            page_index = 0;
            listPanel[page_index].BringToFront();
        }

        private void ptb_repeat1_Click(object sender, EventArgs e)
        {
            repeatmode = 2;
            ptb_suffle.BringToFront();
        }

        private void ptb_repeat_Click(object sender, EventArgs e)
        {
            repeatmode = 1;
            ptb_repeat1.BringToFront();
        }

        private void ptb_suffle_Click(object sender, EventArgs e)
        {
            repeatmode = 0;
            ptb_repeat.BringToFront();
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                
                
                for (int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(Path.GetFileName(files[i]));
                }
            }           
        }

        private void ptb_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            wave.Enabled = true;
            ptb_pause.BringToFront();
        }

        private void ptb_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            wave.Enabled = false;
            ptb_play.BringToFront();
        }

        
        private void ptb_fastfoward_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedIndex < SongList.Items.Count - 1)
            {
                SongList.SelectedIndex = SongList.SelectedIndex + 1; 
            }
        }

        private void ptb_rewind_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedIndex > 0)
            {
                SongList.SelectedIndex = SongList.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                play_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                play_bar.Value = (int)player.Ctlcontrols.currentPosition;

  
                if (play_bar.Value >= play_bar.Maximum)
                {
                    if (repeatmode == 0)
                    {
                        if (SongList.SelectedIndex < SongList.Items.Count - 1) SongList.SelectedIndex = SongList.SelectedIndex + 1;
                        if (SongList.SelectedIndex == SongList.Items.Count - 1)
                        {
                            player.Ctlcontrols.pause();
                            wave.Enabled = false;
                            ptb_play.BringToFront();
                        }
                    }
                    if (repeatmode == 1)
                    {
                        int temp = SongList.SelectedIndex;
                        SongList.SelectedIndex = 0;
                        SongList.SelectedIndex = temp;
                    }
                    if (repeatmode == 2)
                    {
                        int temp = rand.Next(0, SongList.Items.Count - 1);
                        SongList.SelectedIndex = 0;
                        SongList.SelectedIndex = temp;
                    }
                }
            }
            

            try
            {
                lb_songstart.Text = player.Ctlcontrols.currentPositionString;
                lb_songend.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }

        }

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume_bar.Value;
        }

        private void play_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / play_bar.Width;
        }

        

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            player.URL = paths[SongList.SelectedIndex];
            player.Ctlcontrols.play();
            wave.Enabled = true;
            title_songPlaying.Text = "Playing '" + Path.GetFileName(paths[SongList.SelectedIndex]) + "'";
            ptb_pause.BringToFront();

            
        }
    }
}
