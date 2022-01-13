using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            // 간단한 텍스트 파일 쓰기
            string data = "Data 1\r\n Data 2 \r\n Data 3 \r\n";
            File.WriteAllText("test.txt", data);
            // 파일 클래스에 writealltext 라는 메소드가 있다.
            // 파일 패스는 text.txt이고 내용은 data1이다.
            //File.AppendAllText("test.txt", "data 2");
            //File.AppendAllText("test.txt", "data 3");

            // 텍스트 파일 읽기
            string data2 = File.ReadAllText("test.txt");
            MessageBox.Show(data2);
        }


        //연속적으로 데이터가 들어올때, 데이터가 많을때
        private void BtnStream_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("streamdata.txt");
            for (int i = 0; i < 100000; i++)
            {
                wr.WriteLine($"Data {i}");
 }
            wr.Close();

          
                  
            }
        }
    }

