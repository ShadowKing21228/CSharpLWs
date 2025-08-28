using NAudio.Wave;

namespace LR14;

public partial class Form1 : Form
{
    private AudioFileReader audioFile;
    private WaveOutEvent outputDevice;

    public Form1()
    {
        InitializeComponent();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "Audio Files|*.mp3;*.wav";
        dialog.Title = "Выберите аудиофайл";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            lblFileName.Text = "Файл: " + dialog.SafeFileName;

            outputDevice?.Dispose();
            audioFile?.Dispose();

            audioFile = new AudioFileReader(dialog.FileName);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
        }
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        outputDevice?.Play();
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        outputDevice?.Pause();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        if (outputDevice != null)
        {
            outputDevice.Stop();
            audioFile.Position = 0;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}