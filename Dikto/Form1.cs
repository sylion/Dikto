using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Использование свободной библиотеки с открытым исходным кодом для работы со звуком в C#.NET http://naudio.codeplex.com/
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;


namespace Dikto
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        
        WaveIn waveIn; //WaveIn - поток для записи
        WaveFileWriter writer; //Класс для записи в файл
        string outputFilename; //Имя файла для записи

        int ind = 0; //Переключатель для кнопки стоп (запись\воспроизведение) 
        
        //Декларация необходимых для воспроизведения потока переменных
        IWavePlayer waveOutDevice;
        WaveStream mainOutputStream;
        WaveChannel32 volumeStream;

        //Создание потока, проверка возможности воспроизведения файла
        private WaveStream CreateInputStream(string fileName)
        {
            WaveChannel32 inputStream;
            if (fileName.EndsWith(".wav"))
            {
                WaveStream WaveReader = new WaveFileReader(fileName);
                inputStream = new WaveChannel32(WaveReader);
            }
            else
            {
                throw new InvalidOperationException("Unsupported extension");
            }
            volumeStream = inputStream;
            return volumeStream;
        }

        //Получение данных из входного буфера и обработка полученных с микрофона данных
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
            }
            else
            {
                //Записываем данные из буфера в файл
                writer.WriteData(e.Buffer, 0, e.BytesRecorded);
            }
        }

        //Остановка записи и удаление потока
        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
            }
            else
            {
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer = null;
            }
        }

        //Кнопка "Плей"
        private void button_play_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = true;
            timer.Start();
            ind = 2;
            waveOutDevice = new WaveOut();
            mainOutputStream = CreateInputStream(outputFilename);
            waveOutDevice.Init(mainOutputStream);
            waveOutDevice.Play();
            button_play.Enabled = false;
            button_rec.Enabled = false;
            numeric.Enabled = false;
        }

        //Кнопка "Стоп"
        private void button_stop_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            min = 0; 
            sec = 0;
            timer.Stop();
            label_time.Text = "00:00";
            button_play.Enabled = true;
            button_rec.Enabled = true;
            numeric.Enabled = true;
            label_file.Text = numeric.Value + ".wav";
            button_delete.Enabled = true;
            if (ind == 1)
            {
                if (waveIn != null)
                {
                    waveIn.StopRecording();
                }
            }
            if (ind == 2)
            {
                if (waveOutDevice != null)
                {
                    waveOutDevice.Stop();               
                }
                if (mainOutputStream != null)
                {
                    //закрытие файла и устройства
                    volumeStream.Close();
                    volumeStream = null;
                    mainOutputStream.Close();
                    mainOutputStream = null;
                }
                if (waveOutDevice != null)
                {
                    waveOutDevice.Dispose();
                    waveOutDevice = null;
                }
            }
        }
        //Кнопка "Запись"
        private void button_rec_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = true;
            timer.Start();
            ind = 1;
            try
            {
                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;//Дефолтное устройство для записи (если оно имеется)
                waveIn.DataAvailable += waveIn_DataAvailable;//Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                waveIn.RecordingStopped += waveIn_RecordingStopped;//Прикрепляем обработчик завершения записи
                waveIn.WaveFormat = new WaveFormat(8000, 1);//Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);//Инициализируем объект WaveFileWriter
                waveIn.StartRecording();//Начало записи
                button_play.Enabled = false;
                button_rec.Enabled = false;
                numeric.Enabled = false;
            }
            catch (Exception ex)
            {
                button_play.Enabled = true;
                button_rec.Enabled = true;
                numeric.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }
        //Отобоажение первой ячейки памяти при запуске программы
        private void form_main_Load(object sender, EventArgs e)
        {
            if (File.Exists("Records\\" + numeric.Value + ".wav"))
            {
                label_file.Text = numeric.Value + ".wav";
                button_delete.Enabled = true;
                button_play.Enabled = true;
            }
            else
            {
                label_file.Text = "Пусто";
                button_delete.Enabled = false;
                button_play.Enabled = false;
            }
            outputFilename = "Records\\" + numeric.Value + ".wav";
        }
        //Отображение ячеек памяти по номеру
        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (File.Exists("Records\\" + numeric.Value + ".wav"))
            {
                label_file.Text = numeric.Value + ".wav";
                button_delete.Enabled = true;
                button_play.Enabled = true;
            }
            else
            {
                label_file.Text = "Пусто";
                button_delete.Enabled = false;
                button_play.Enabled = false;
            }
            outputFilename = "Records\\" + numeric.Value + ".wav";
        }
        //Переменные для отображения таймера
        int min = 0, sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
            }
            else
            {
                min++;
                sec = 0;
            }
            label_time.Text = min + ":" + sec;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            File.Delete("Records\\" + numeric.Value + ".wav");
            label_file.Text = "Пусто";
            button_delete.Enabled = false;
            button_play.Enabled = false;
        }
    }
}