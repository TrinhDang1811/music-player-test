namespace MusicPlayerProject
{
    partial class music_player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_player));
            this.pn_sidebar = new System.Windows.Forms.Panel();
            this.lb_help = new System.Windows.Forms.Label();
            this.lb_settings = new System.Windows.Forms.Label();
            this.lb_favorite = new System.Windows.Forms.Label();
            this.lb_playlist = new System.Windows.Forms.Label();
            this.lb_home = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pn_playmusic = new System.Windows.Forms.Panel();
            this.play_bar = new System.Windows.Forms.ProgressBar();
            this.lb_songstart = new System.Windows.Forms.Label();
            this.lb_songend = new System.Windows.Forms.Label();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.page_home = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.title_songPlaying = new System.Windows.Forms.TextBox();
            this.SongList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptb_volume_down = new System.Windows.Forms.PictureBox();
            this.ptb_fastfoward = new System.Windows.Forms.PictureBox();
            this.ptb_rewind = new System.Windows.Forms.PictureBox();
            this.ptb_volume_up = new System.Windows.Forms.PictureBox();
            this.ptb_play = new System.Windows.Forms.PictureBox();
            this.ptb_pause = new System.Windows.Forms.PictureBox();
            this.ptb_repeat = new System.Windows.Forms.PictureBox();
            this.wave = new System.Windows.Forms.PictureBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ptb_repeat1 = new System.Windows.Forms.PictureBox();
            this.ptb_suffle = new System.Windows.Forms.PictureBox();
            this.lb_SongList = new System.Windows.Forms.Label();
            this.pn_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.pn_playmusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            this.page_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fastfoward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_rewind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_repeat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_suffle)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_sidebar
            // 
            this.pn_sidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_sidebar.Controls.Add(this.lb_help);
            this.pn_sidebar.Controls.Add(this.lb_settings);
            this.pn_sidebar.Controls.Add(this.lb_favorite);
            this.pn_sidebar.Controls.Add(this.lb_playlist);
            this.pn_sidebar.Controls.Add(this.lb_home);
            this.pn_sidebar.Controls.Add(this.ptb_logo);
            this.pn_sidebar.Controls.Add(this.player);
            this.pn_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_sidebar.ForeColor = System.Drawing.SystemColors.Control;
            this.pn_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pn_sidebar.Name = "pn_sidebar";
            this.pn_sidebar.Size = new System.Drawing.Size(253, 756);
            this.pn_sidebar.TabIndex = 0;
            // 
            // lb_help
            // 
            this.lb_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_help.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_help.ForeColor = System.Drawing.Color.Gray;
            this.lb_help.Location = new System.Drawing.Point(85, 658);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(110, 39);
            this.lb_help.TabIndex = 6;
            this.lb_help.Text = "Help";
            this.lb_help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_settings
            // 
            this.lb_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_settings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_settings.ForeColor = System.Drawing.Color.Gray;
            this.lb_settings.Location = new System.Drawing.Point(85, 619);
            this.lb_settings.Name = "lb_settings";
            this.lb_settings.Size = new System.Drawing.Size(110, 39);
            this.lb_settings.TabIndex = 5;
            this.lb_settings.Text = "Settings";
            this.lb_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_favorite
            // 
            this.lb_favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_favorite.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_favorite.ForeColor = System.Drawing.Color.Gray;
            this.lb_favorite.Location = new System.Drawing.Point(85, 336);
            this.lb_favorite.Name = "lb_favorite";
            this.lb_favorite.Size = new System.Drawing.Size(110, 39);
            this.lb_favorite.TabIndex = 4;
            this.lb_favorite.Text = "Favorite";
            this.lb_favorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_playlist
            // 
            this.lb_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_playlist.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playlist.ForeColor = System.Drawing.Color.Gray;
            this.lb_playlist.Location = new System.Drawing.Point(85, 284);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(110, 39);
            this.lb_playlist.TabIndex = 3;
            this.lb_playlist.Text = "Playlists";
            this.lb_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_home
            // 
            this.lb_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_home.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.Gray;
            this.lb_home.Location = new System.Drawing.Point(85, 235);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(110, 39);
            this.lb_home.TabIndex = 2;
            this.lb_home.Text = "Home";
            this.lb_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_home.Click += new System.EventHandler(this.lb_home_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(78, 459);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(0, 0);
            this.player.TabIndex = 4;
            // 
            // pn_playmusic
            // 
            this.pn_playmusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pn_playmusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_playmusic.Controls.Add(this.play_bar);
            this.pn_playmusic.Controls.Add(this.lb_songstart);
            this.pn_playmusic.Controls.Add(this.ptb_volume_down);
            this.pn_playmusic.Controls.Add(this.lb_songend);
            this.pn_playmusic.Controls.Add(this.ptb_fastfoward);
            this.pn_playmusic.Controls.Add(this.ptb_rewind);
            this.pn_playmusic.Controls.Add(this.ptb_volume_up);
            this.pn_playmusic.Controls.Add(this.volume_bar);
            this.pn_playmusic.Controls.Add(this.ptb_play);
            this.pn_playmusic.Controls.Add(this.ptb_pause);
            this.pn_playmusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_playmusic.ForeColor = System.Drawing.SystemColors.Control;
            this.pn_playmusic.Location = new System.Drawing.Point(253, 695);
            this.pn_playmusic.Name = "pn_playmusic";
            this.pn_playmusic.Size = new System.Drawing.Size(1173, 61);
            this.pn_playmusic.TabIndex = 2;
            // 
            // play_bar
            // 
            this.play_bar.Cursor = System.Windows.Forms.Cursors.Default;
            this.play_bar.Location = new System.Drawing.Point(240, 26);
            this.play_bar.Name = "play_bar";
            this.play_bar.Size = new System.Drawing.Size(633, 10);
            this.play_bar.TabIndex = 0;
            this.play_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.play_bar_MouseDown);
            // 
            // lb_songstart
            // 
            this.lb_songstart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_songstart.ForeColor = System.Drawing.Color.White;
            this.lb_songstart.Location = new System.Drawing.Point(176, 17);
            this.lb_songstart.Name = "lb_songstart";
            this.lb_songstart.Size = new System.Drawing.Size(67, 23);
            this.lb_songstart.TabIndex = 9;
            this.lb_songstart.Text = "00:00";
            this.lb_songstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_songend
            // 
            this.lb_songend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lb_songend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_songend.ForeColor = System.Drawing.Color.White;
            this.lb_songend.Location = new System.Drawing.Point(871, 10);
            this.lb_songend.Name = "lb_songend";
            this.lb_songend.Size = new System.Drawing.Size(68, 39);
            this.lb_songend.TabIndex = 7;
            this.lb_songend.Text = "00:00";
            this.lb_songend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume_bar
            // 
            this.volume_bar.Cursor = System.Windows.Forms.Cursors.Default;
            this.volume_bar.Location = new System.Drawing.Point(966, 17);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(160, 56);
            this.volume_bar.TabIndex = 1;
            this.volume_bar.TabStop = false;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // page_home
            // 
            this.page_home.Controls.Add(this.lb_SongList);
            this.page_home.Controls.Add(this.ptb_repeat);
            this.page_home.Controls.Add(this.ptb_repeat1);
            this.page_home.Controls.Add(this.ptb_suffle);
            this.page_home.Controls.Add(this.wave);
            this.page_home.Controls.Add(this.btn_Import);
            this.page_home.Controls.Add(this.title_songPlaying);
            this.page_home.Controls.Add(this.SongList);
            this.page_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_home.Location = new System.Drawing.Point(253, 0);
            this.page_home.Name = "page_home";
            this.page_home.Size = new System.Drawing.Size(1173, 756);
            this.page_home.TabIndex = 3;
            // 
            // btn_Import
            // 
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Import.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(967, 224);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(178, 38);
            this.btn_Import.TabIndex = 3;
            this.btn_Import.Text = "IMPORT MUSIC";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // title_songPlaying
            // 
            this.title_songPlaying.BackColor = System.Drawing.SystemColors.Control;
            this.title_songPlaying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_songPlaying.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_songPlaying.ForeColor = System.Drawing.Color.DarkGray;
            this.title_songPlaying.Location = new System.Drawing.Point(28, 12);
            this.title_songPlaying.Multiline = true;
            this.title_songPlaying.Name = "title_songPlaying";
            this.title_songPlaying.Size = new System.Drawing.Size(1133, 84);
            this.title_songPlaying.TabIndex = 0;
            this.title_songPlaying.Text = "Song Title - Playing";
            // 
            // SongList
            // 
            this.SongList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 23;
            this.SongList.Location = new System.Drawing.Point(28, 287);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(1117, 372);
            this.SongList.TabIndex = 2;
            this.SongList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptb_volume_down
            // 
            this.ptb_volume_down.Image = global::MusicPlayerProject.Properties.Resources.volume_down;
            this.ptb_volume_down.Location = new System.Drawing.Point(938, 17);
            this.ptb_volume_down.Name = "ptb_volume_down";
            this.ptb_volume_down.Size = new System.Drawing.Size(29, 26);
            this.ptb_volume_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_volume_down.TabIndex = 2;
            this.ptb_volume_down.TabStop = false;
            // 
            // ptb_fastfoward
            // 
            this.ptb_fastfoward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_fastfoward.Image = global::MusicPlayerProject.Properties.Resources.fast_forward;
            this.ptb_fastfoward.Location = new System.Drawing.Point(129, 16);
            this.ptb_fastfoward.Name = "ptb_fastfoward";
            this.ptb_fastfoward.Size = new System.Drawing.Size(32, 31);
            this.ptb_fastfoward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_fastfoward.TabIndex = 5;
            this.ptb_fastfoward.TabStop = false;
            this.ptb_fastfoward.Click += new System.EventHandler(this.ptb_fastfoward_Click);
            // 
            // ptb_rewind
            // 
            this.ptb_rewind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_rewind.Image = global::MusicPlayerProject.Properties.Resources.rewind;
            this.ptb_rewind.Location = new System.Drawing.Point(16, 16);
            this.ptb_rewind.Name = "ptb_rewind";
            this.ptb_rewind.Size = new System.Drawing.Size(32, 31);
            this.ptb_rewind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_rewind.TabIndex = 4;
            this.ptb_rewind.TabStop = false;
            this.ptb_rewind.Click += new System.EventHandler(this.ptb_rewind_Click);
            // 
            // ptb_volume_up
            // 
            this.ptb_volume_up.Image = global::MusicPlayerProject.Properties.Resources.high_volume;
            this.ptb_volume_up.Location = new System.Drawing.Point(1124, 17);
            this.ptb_volume_up.Name = "ptb_volume_up";
            this.ptb_volume_up.Size = new System.Drawing.Size(29, 26);
            this.ptb_volume_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_volume_up.TabIndex = 3;
            this.ptb_volume_up.TabStop = false;
            // 
            // ptb_play
            // 
            this.ptb_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_play.Image = global::MusicPlayerProject.Properties.Resources.play_button2;
            this.ptb_play.Location = new System.Drawing.Point(65, 10);
            this.ptb_play.Name = "ptb_play";
            this.ptb_play.Size = new System.Drawing.Size(46, 46);
            this.ptb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_play.TabIndex = 6;
            this.ptb_play.TabStop = false;
            this.ptb_play.Click += new System.EventHandler(this.ptb_play_Click);
            // 
            // ptb_pause
            // 
            this.ptb_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_pause.Image = global::MusicPlayerProject.Properties.Resources.pause;
            this.ptb_pause.Location = new System.Drawing.Point(65, 9);
            this.ptb_pause.Name = "ptb_pause";
            this.ptb_pause.Size = new System.Drawing.Size(46, 46);
            this.ptb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_pause.TabIndex = 8;
            this.ptb_pause.TabStop = false;
            this.ptb_pause.Click += new System.EventHandler(this.ptb_pause_Click);
            // 
            // ptb_repeat
            // 
            this.ptb_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_repeat.Image = global::MusicPlayerProject.Properties.Resources._4634534_arrow_looping_music_repeat_icon;
            this.ptb_repeat.Location = new System.Drawing.Point(427, 236);
            this.ptb_repeat.Name = "ptb_repeat";
            this.ptb_repeat.Size = new System.Drawing.Size(46, 46);
            this.ptb_repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_repeat.TabIndex = 10;
            this.ptb_repeat.TabStop = false;
            this.ptb_repeat.Click += new System.EventHandler(this.ptb_repeat_Click);
            // 
            // wave
            // 
            this.wave.Enabled = false;
            this.wave.Image = global::MusicPlayerProject.Properties.Resources.Waveform;
            this.wave.Location = new System.Drawing.Point(38, 53);
            this.wave.Name = "wave";
            this.wave.Size = new System.Drawing.Size(345, 173);
            this.wave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wave.TabIndex = 0;
            this.wave.TabStop = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Image = global::MusicPlayerProject.Properties.Resources.toppng_com_music_player_icon_png_512x512;
            this.ptb_logo.Location = new System.Drawing.Point(59, 37);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(136, 128);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // ptb_repeat1
            // 
            this.ptb_repeat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_repeat1.Image = global::MusicPlayerProject.Properties.Resources._4634535_looping_music_once_repeat_repeat_once_icon;
            this.ptb_repeat1.Location = new System.Drawing.Point(427, 234);
            this.ptb_repeat1.Name = "ptb_repeat1";
            this.ptb_repeat1.Size = new System.Drawing.Size(46, 46);
            this.ptb_repeat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_repeat1.TabIndex = 11;
            this.ptb_repeat1.TabStop = false;
            this.ptb_repeat1.Click += new System.EventHandler(this.ptb_repeat1_Click);
            // 
            // ptb_suffle
            // 
            this.ptb_suffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_suffle.Image = global::MusicPlayerProject.Properties.Resources.shuffle;
            this.ptb_suffle.Location = new System.Drawing.Point(429, 237);
            this.ptb_suffle.Name = "ptb_suffle";
            this.ptb_suffle.Size = new System.Drawing.Size(42, 42);
            this.ptb_suffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_suffle.TabIndex = 12;
            this.ptb_suffle.TabStop = false;
            this.ptb_suffle.Click += new System.EventHandler(this.ptb_suffle_Click);
            // 
            // lb_SongList
            // 
            this.lb_SongList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_SongList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SongList.ForeColor = System.Drawing.Color.Black;
            this.lb_SongList.Location = new System.Drawing.Point(27, 245);
            this.lb_SongList.Name = "lb_SongList";
            this.lb_SongList.Size = new System.Drawing.Size(110, 39);
            this.lb_SongList.TabIndex = 7;
            this.lb_SongList.Text = "SongList:";
            this.lb_SongList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // music_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 756);
            this.Controls.Add(this.pn_playmusic);
            this.Controls.Add(this.page_home);
            this.Controls.Add(this.pn_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "music_player";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.music_player_Load);
            this.pn_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.pn_playmusic.ResumeLayout(false);
            this.pn_playmusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            this.page_home.ResumeLayout(false);
            this.page_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fastfoward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_rewind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_repeat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_suffle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_sidebar;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label lb_favorite;
        private System.Windows.Forms.Label lb_playlist;
        private System.Windows.Forms.Label lb_help;
        private System.Windows.Forms.Label lb_settings;
        private System.Windows.Forms.Panel pn_playmusic;
        private System.Windows.Forms.Panel page_home;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox ptb_volume_down;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.ProgressBar play_bar;
        private System.Windows.Forms.PictureBox ptb_volume_up;
        private System.Windows.Forms.PictureBox ptb_rewind;
        private System.Windows.Forms.PictureBox ptb_fastfoward;
        private System.Windows.Forms.PictureBox ptb_play;
        private System.Windows.Forms.PictureBox wave;
        private System.Windows.Forms.Label lb_songend;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.ListBox SongList;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TextBox title_songPlaying;
        private System.Windows.Forms.PictureBox ptb_pause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_songstart;
        private System.Windows.Forms.PictureBox ptb_repeat;
        private System.Windows.Forms.PictureBox ptb_repeat1;
        private System.Windows.Forms.PictureBox ptb_suffle;
        private System.Windows.Forms.Label lb_SongList;
    }
}

