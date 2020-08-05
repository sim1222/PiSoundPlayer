using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PiSoundPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filebox.Text = Properties.Settings.Default.filepath;
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = filebox.Text;
        }
        public void filebutton_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //デフォルトファイル名
            ofd.FileName = "ピー音.wav";
            //デフォルトフォルダ名
            ofd.InitialDirectory = @"C:\";
            //ファイル拡張子指定
            ofd.Filter = "音声ファイル(*.wav;*.mp3)|*.wav;*.mp3|すべてのファイル(*.*)|*.*";
            //フィルターデフォ
            ofd.FilterIndex = 1;
            //窓タイトル
            ofd.Title = "音声ファイルを選択してください";
            //現在位置復元
            ofd.RestoreDirectory = true;

            //ダイアログ表示
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filebox.Text = ofd.FileName;
                axWindowsMediaPlayer1.settings.autoStart = false;
                axWindowsMediaPlayer1.URL = filebox.Text;
                Properties.Settings.Default.filepath = filebox.Text;
                Properties.Settings.Default.Save();
            }
        }


        private void playbutton_MouseDown(object sender, MouseEventArgs e)
        {
            //再生
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void playbutton_MouseUp(object sender, MouseEventArgs e)
        {
            //再生停止
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = filebox.Text;
        }
    }
}
