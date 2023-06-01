using System.Net;
using Newtonsoft.Json;

namespace Weather;

public partial class Form2 : Form
{
    public Form2(string s)
    {
        InitializeComponent();
        GetForecast();
        }

    public void GetForecast()
    {
        using (WebClient web = new WebClient())
        {
            string url = string.Format("https://api.open-meteo.com/v1/forecast?latitude=41.69&longitude=44.80&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FMoscow");
            var json = web.DownloadString(url);
            ForecastInfo.root info = JsonConvert.DeserializeObject<ForecastInfo.root>(json);
            maxTempLabel1.Text = Math.Round(info.daily.temperature_2m_max[0]).ToString() + "°";
            minTempLabel1.Text = Math.Round(info.daily.temperature_2m_min[0]).ToString() + "°";
            maxTempLabel2.Text = Math.Round(info.daily.temperature_2m_max[1]).ToString() + "°";
            minTempLabel2.Text = Math.Round(info.daily.temperature_2m_min[1]).ToString() + "°";
            maxTempLabel3.Text = Math.Round(info.daily.temperature_2m_max[2]).ToString() + "°";
            minTempLabel3.Text = Math.Round(info.daily.temperature_2m_min[2]).ToString() + "°";
            maxTempLabel4.Text = Math.Round(info.daily.temperature_2m_max[3]).ToString() + "°";
            minTempLabel4.Text = Math.Round(info.daily.temperature_2m_min[3]).ToString() + "°";
            maxTempLabel5.Text = Math.Round(info.daily.temperature_2m_max[4]).ToString() + "°";
            minTempLabel5.Text = Math.Round(info.daily.temperature_2m_min[4]).ToString() + "°";
            maxTempLabel6.Text = Math.Round(info.daily.temperature_2m_max[5]).ToString() + "°";
            minTempLabel6.Text = Math.Round(info.daily.temperature_2m_min[5]).ToString() + "°";
            maxTempLabel7.Text = Math.Round(info.daily.temperature_2m_max[6]).ToString() + "°";
            minTempLabel7.Text = Math.Round(info.daily.temperature_2m_min[6]).ToString() + "°";
            pictureBox1.ImageLocation = GetPath(pictureBox1);
            info.daily.weathercode.RemoveAt(0);
            pictureBox2.ImageLocation = GetPath(pictureBox2);
            info.daily.weathercode.RemoveAt(0);
            pictureBox3.ImageLocation = GetPath(pictureBox3);
            info.daily.weathercode.RemoveAt(0);
            pictureBox4.ImageLocation = GetPath(pictureBox4);
            info.daily.weathercode.RemoveAt(0);
            pictureBox5.ImageLocation = GetPath(pictureBox5);
            info.daily.weathercode.RemoveAt(0);
            pictureBox6.ImageLocation = GetPath(pictureBox6);
            info.daily.weathercode.RemoveAt(0);
            pictureBox7.ImageLocation = GetPath(pictureBox7);
            info.daily.weathercode.RemoveAt(0);

            string GetPath(PictureBox s)
            {
                foreach (var item in info.daily.weathercode)
                {
                    if (item == 0)
                    {
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\01d.png";
                    }
                        
                    else if (item == 1 | item == 2 | item == 3)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\02d.png";
                    else if (item == 45 | item == 48)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\50d.png";
                    else if (item == 51 | item == 53 | item == 55 | item == 56 | item == 57)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\10d.png";
                    else if (item == 61 | item == 63 | item == 65 | item == 66 | item == 67)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\09d.png";
                    else if (item == 71 | item == 73 | item == 75 | item == 77 | item == 85 | item == 86)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\13d.png";
                    else if (item == 80 | item == 81 | item == 82)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\09d.png";
                    else if (item == 95 | item == 96 | item == 99)
                        return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\11d.png";
                }
                return @"C:\Users\student\Desktop\gggg\sdsd\Weather\Data\sddddddd.png";
                
            }
            //for (int i = 0; i <= 7; i++)
            //{
            //    minTempLabel[i].Text = Math.Round(info.daily.temperature_2m_min[i - 0]).ToString();
            //}

        }


    }


}