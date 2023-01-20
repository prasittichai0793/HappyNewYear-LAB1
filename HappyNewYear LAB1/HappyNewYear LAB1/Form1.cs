using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyNewYear_LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Black, 3);
            Pen myPen2 = new Pen(System.Drawing.Color.LightSalmon, 3);
            Pen myPen3 = new Pen(System.Drawing.Color.Khaki, 3);
            Pen myPen4 = new Pen(System.Drawing.Color.DarkBlue, 3);

            Pen myPenRedbold2 = new Pen(System.Drawing.Color.DarkRed, 2);
            Pen myPenGreenbold4 = new Pen(System.Drawing.Color.DarkGreen, 4);
            Pen myPenGreenbold15 = new Pen(System.Drawing.Color.DarkGreen, 15);
            Pen myPenGreenbold16 = new Pen(System.Drawing.Color.DarkGreen, 16);

            SolidBrush BrownBrush = new SolidBrush(Color.Brown);
            SolidBrush BlueBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush KhakiBrush = new SolidBrush(Color.Khaki);
            SolidBrush SeaGreenBrush = new SolidBrush(Color.SeaGreen);
            SolidBrush LightSalmonBrush = new SolidBrush(Color.LightSalmon);
            SolidBrush PeruBrush = new SolidBrush(Color.Peru);

            // ตัว H
            myGraphic.FillRectangle(SeaGreenBrush, 42, 42, 17, 97);             // สี | *
            myGraphic.FillRectangle(SeaGreenBrush, 82, 42, 17, 97);             // สี | **
            myGraphic.FillRectangle(SeaGreenBrush, 59, 82, 23, 17);             // สี - *
            myGraphic.DrawLine(myPen1, 40, 40, 40, 140);                        // เส้น | *
            myGraphic.DrawLine(myPen1, 60, 40, 60, 80);                         // เส้น | **
            myGraphic.DrawLine(myPen1, 60, 100, 60, 140);                       // เส้น | ***
            myGraphic.DrawLine(myPen1, 80, 40, 80, 80);                         // เส้น | ****
            myGraphic.DrawLine(myPen1, 80, 100, 80, 140);                       // เส้น | *****
            myGraphic.DrawLine(myPen1, 100, 40, 100, 140);                      // เส้น | ******
            myGraphic.DrawLine(myPen1, 39, 40, 62, 40);                         // เส้น - *
            myGraphic.DrawLine(myPen1, 39, 140, 62, 140);                       // เส้น - **
            myGraphic.DrawLine(myPen1, 59, 80, 82, 80);                         // เส้น - ***
            myGraphic.DrawLine(myPen1, 59, 100, 82, 100);                       // เส้น - ****
            myGraphic.DrawLine(myPen1, 79, 40, 102, 40);                        // เส้น - *****
            myGraphic.DrawLine(myPen1, 79, 140, 102, 140);                      // เส้น - ******

            // ตัว N
            myGraphic.FillRectangle(KhakiBrush, 122, 42, 17, 97);               // สี | *
            myGraphic.FillRectangle(KhakiBrush, 162, 42, 17, 97);               // สี | **
            myGraphic.DrawLine(myPen3, 138, 42, 162, 114);                      // เส้น \ *
            myGraphic.DrawLine(myPen3, 138, 50, 162, 122);                      // เส้น \ **
            myGraphic.DrawLine(myPen3, 138, 58, 162, 130);                      // เส้น \ ***
            myGraphic.DrawLine(myPen3, 138, 64, 162, 136);                      // เส้น \ ***
            myGraphic.DrawLine(myPen3, 140, 50, 140, 80);                       // สี X เส้น | *
            myGraphic.DrawLine(myPen3, 160, 100, 160, 130);                     // สี X เส้น | **
            myGraphic.DrawLine(myPen1, 120, 40, 120, 140);                      // เส้น | *
            myGraphic.DrawLine(myPen1, 140, 80, 140, 140);                      // เส้น | **
            myGraphic.DrawLine(myPen1, 160, 40, 160, 100);                      // เส้น | ***
            myGraphic.DrawLine(myPen1, 180, 40, 180, 140);                      // เส้น | ****
            myGraphic.DrawLine(myPen1, 119, 40, 142, 40);                       // เส้น - *
            myGraphic.DrawLine(myPen1, 119, 140, 142, 140);                     // เส้น - **
            myGraphic.DrawLine(myPen1, 159, 40, 182, 40);                       // เส้น - ***
            myGraphic.DrawLine(myPen1, 159, 140, 182, 140);                     // เส้น - ****
            myGraphic.DrawLine(myPen1, 140, 40, 160, 100);                      // เส้น \ *
            myGraphic.DrawLine(myPen1, 140, 80, 160, 140);                      // เส้น \ **

            // ตัว Y
            myGraphic.DrawLine(myPen2, 203, 40, 223, 100);                      // สี เส้น \ *
            myGraphic.DrawLine(myPen2, 206, 40, 226, 100);                      // สี เส้น \ **
            myGraphic.DrawLine(myPen2, 209, 40, 229, 100);                      // สี เส้น \ ***
            myGraphic.DrawLine(myPen2, 212, 40, 232, 100);                      // สี เส้น \ ****
            myGraphic.DrawLine(myPen2, 215, 40, 235, 100);                      // สี เส้น \ *****
            myGraphic.DrawLine(myPen2, 217, 40, 237, 100);                      // สี เส้น \ ******
            myGraphic.DrawLine(myPen2, 243, 40, 223, 100);                      // สี เส้น / *
            myGraphic.DrawLine(myPen2, 246, 40, 226, 100);                      // สี เส้น / **
            myGraphic.DrawLine(myPen2, 249, 40, 229, 100);                      // สี เส้น / ***
            myGraphic.DrawLine(myPen2, 252, 40, 232, 100);                      // สี เส้น / ****
            myGraphic.DrawLine(myPen2, 255, 40, 235, 100);                      // สี เส้น / *****
            myGraphic.DrawLine(myPen2, 258, 40, 238, 100);                      // สี เส้น / ******
            myGraphic.FillRectangle(LightSalmonBrush, 222, 71, 17, 68);         // สี เส้น | 
            myGraphic.DrawLine(myPen1, 200, 40, 220, 100);                      // เส้น \ *
            myGraphic.DrawLine(myPen1, 220, 40, 230, 70);                       // เส้น \ **
            myGraphic.DrawLine(myPen1, 240, 40, 230, 70);                       // เส้น / *
            myGraphic.DrawLine(myPen1, 260, 40, 240, 100);                      // เส้น / **
            myGraphic.DrawLine(myPen1, 220, 100, 220, 140);                     // เส้น | *
            myGraphic.DrawLine(myPen1, 240, 100, 240, 140);                     // เส้น | **
            myGraphic.DrawLine(myPen1, 199, 40, 222, 40);                       // เส้น - *
            myGraphic.DrawLine(myPen1, 239, 40, 262, 40);                       // เส้น - **
            myGraphic.DrawLine(myPen1, 219, 140, 242, 140);                     // เส้น - ***

            // 2 023
            myGraphic.FillRectangle(BlueBrush, 340, 40, 60, 20);                // สี เส้น - *
            myGraphic.FillRectangle(BlueBrush, 340, 80, 60, 20);                // สี เส้น - **
            myGraphic.FillRectangle(BlueBrush, 340, 120, 60, 20);               // สี เส้น - ***
            myGraphic.FillRectangle(BlueBrush, 380, 40, 20, 60);                // สี เส้น | *
            myGraphic.FillRectangle(BlueBrush, 340, 80, 20, 60);                // สี เส้น | **
            myGraphic.DrawLine(myPen1, 340, 40, 340, 60);                       // เส้น | *
            myGraphic.DrawLine(myPen1, 340, 80, 340, 140);                      // เส้น | **
            myGraphic.DrawLine(myPen1, 380, 60, 380, 80);                       // เส้น | ***
            myGraphic.DrawLine(myPen1, 360, 100, 360, 120);                     // เส้น | ****
            myGraphic.DrawLine(myPen1, 400, 40, 400, 100);                      // เส้น | *****
            myGraphic.DrawLine(myPen1, 400, 120, 400, 140);                     // เส้น | ******
            myGraphic.DrawLine(myPen1, 339, 40, 402, 40);                       // เส้น - *
            myGraphic.DrawLine(myPen1, 339, 60, 382, 60);                       // เส้น - **
            myGraphic.DrawLine(myPen1, 339, 80, 382, 80);                       // เส้น - ***
            myGraphic.DrawLine(myPen1, 359, 100, 402, 100);                     // เส้น - ****
            myGraphic.DrawLine(myPen1, 359, 120, 402, 120);                     // เส้น - *****
            myGraphic.DrawLine(myPen1, 339, 140, 402, 140);                     // เส้น - ******

            // 2 0 23
            myGraphic.FillRectangle(BlueBrush, 420, 40, 20, 100);               // สี เส้น | *
            myGraphic.FillRectangle(BlueBrush, 460, 40, 20, 100);               // สี เส้น | **
            myGraphic.FillRectangle(BlueBrush, 420, 40, 60, 20);                // สี เส้น - *
            myGraphic.FillRectangle(BlueBrush, 420, 120, 60, 20);               // สี เส้น - **
            myGraphic.DrawRectangle(myPen1, 420, 40, 60, 100);                  // # นอก
            myGraphic.DrawRectangle(myPen1, 440, 60, 20, 60);                   // # ใน

            // 20 2 3
            myGraphic.FillRectangle(BlueBrush, 600, 40, 60, 20);                // สี เส้น - *
            myGraphic.FillRectangle(BlueBrush, 600, 80, 60, 20);                // สี เส้น - **
            myGraphic.FillRectangle(BlueBrush, 600, 120, 60, 20);               // สี เส้น - ***
            myGraphic.FillRectangle(BlueBrush, 640, 40, 20, 60);                // สี เส้น | *
            myGraphic.FillRectangle(BlueBrush, 600, 80, 20, 60);                // สี เส้น | **
            myGraphic.DrawLine(myPen1, 600, 40, 600, 60);                       // เส้น | *
            myGraphic.DrawLine(myPen1, 600, 80, 600, 140);                      // เส้น | **
            myGraphic.DrawLine(myPen1, 640, 60, 640, 80);                       // เส้น | ***
            myGraphic.DrawLine(myPen1, 620, 100, 620, 120);                     // เส้น | ****
            myGraphic.DrawLine(myPen1, 660, 40, 660, 100);                      // เส้น | *****
            myGraphic.DrawLine(myPen1, 660, 120, 660, 140);                     // เส้น | ******
            myGraphic.DrawLine(myPen1, 599, 40, 662, 40);                       // เส้น - *
            myGraphic.DrawLine(myPen1, 599, 60, 642, 60);                       // เส้น - **
            myGraphic.DrawLine(myPen1, 599, 80, 642, 80);                       // เส้น - ***
            myGraphic.DrawLine(myPen1, 619, 100, 662, 100);                     // เส้น - ****
            myGraphic.DrawLine(myPen1, 619, 120, 662, 120);                     // เส้น - *****
            myGraphic.DrawLine(myPen1, 599, 140, 662, 140);                     // เส้น - ******

            // 202 3
            myGraphic.FillRectangle(BlueBrush, 680, 40, 60, 20);                // สี เส้น - *
            myGraphic.FillRectangle(BlueBrush, 680, 80, 60, 20);                // สี เส้น - **
            myGraphic.FillRectangle(BlueBrush, 680, 120, 60, 20);               // สี เส้น - ***
            myGraphic.FillRectangle(BlueBrush, 720, 40, 20, 100);               // สี เส้น | ****
            myGraphic.DrawLine(myPen1, 680, 40, 680, 60);                       // เส้น | *
            myGraphic.DrawLine(myPen1, 680, 80, 680, 100);                      // เส้น | **
            myGraphic.DrawLine(myPen1, 680, 120, 680, 140);                     // เส้น | ***
            myGraphic.DrawLine(myPen1, 720, 60, 720, 80);                       // เส้น | ****
            myGraphic.DrawLine(myPen1, 720, 100, 720, 120);                     // เส้น | *****
            myGraphic.DrawLine(myPen1, 740, 40, 740, 140);                      // เส้น | ******
            myGraphic.DrawLine(myPen1, 679, 40, 742, 40);                       // เส้น - *
            myGraphic.DrawLine(myPen1, 679, 60, 722, 60);                       // เส้น - **
            myGraphic.DrawLine(myPen1, 679, 80, 722, 80);                       // เส้น - ***
            myGraphic.DrawLine(myPen1, 679, 100, 722, 100);                     // เส้น - ****
            myGraphic.DrawLine(myPen1, 679, 120, 722, 120);                     // เส้น - *****
            myGraphic.DrawLine(myPen1, 679, 140, 742, 140);                     // เส้น - ******

            // พิ้น
            myGraphic.FillRectangle(PeruBrush, 42, 282, 697, 97);               // สี
            myGraphic.DrawRectangle(myPen1, 40, 280, 700, 100);

            // กล่อง 1
            myGraphic.DrawRectangle(myPen1, 100, 180, 120, 120);                // สี่ เหลี่ยม หลัง
            myGraphic.DrawRectangle(myPen1, 80, 200, 120, 120);                 // สี่ เหลี่ยม หน้า
            myGraphic.DrawLine(myPen4, 100, 183, 219, 183);                     // สี บนกล่อง *
            myGraphic.DrawLine(myPen4, 95, 185, 214, 185);                      // สี บนกล่อง **
            myGraphic.DrawLine(myPen4, 95, 188, 214, 188);                      // สี บนกล่อง ***
            myGraphic.DrawLine(myPen4, 90, 191, 210, 191);                      // สี บนกล่อง ****
            myGraphic.DrawLine(myPen4, 85, 194, 205, 194);                      // สี บนกล่อง *****
            myGraphic.DrawLine(myPen4, 85, 197, 205, 197);                      // สี บนกล่อง ******
            myGraphic.DrawLine(myPen4, 203, 198, 203, 230);                     // สี ข้างกล่อง *
            myGraphic.DrawLine(myPen4, 206, 195, 206, 230);                     // สี ข้างกล่อง **
            myGraphic.DrawLine(myPen4, 209, 192, 209, 230);                     // สี ข้างกล่อง ***
            myGraphic.DrawLine(myPen4, 212, 189, 212, 230);                     // สี ข้างกล่อง ****
            myGraphic.DrawLine(myPen4, 215, 186, 215, 230);                     // สี ข้างกล่อง *****
            myGraphic.DrawLine(myPen4, 217, 183, 217, 230);                     // สี ข้างกล่อง ******
            myGraphic.FillRectangle(BlueBrush, 82, 202, 117, 117);              // สี หน้ากล่อง
            myGraphic.DrawLine(myPen1, 100, 180, 80, 200);                      // เส้น 1
            myGraphic.DrawLine(myPen1, 160, 180, 140, 200);                     // เส้น 2
            myGraphic.DrawLine(myPen1, 220, 180, 200, 200);                     // เส้น 3
            myGraphic.DrawLine(myPen1, 90, 190, 210, 190);                      // เส้น บน
            myGraphic.DrawLine(myPen1, 140, 200, 140, 320);                     // เส้น กลาง
            myGraphic.DrawLine(myPen1, 210, 190, 210, 230);                     // เส้น ข้าง

            // กล่อง 2
            myGraphic.DrawRectangle(myPen1, 170, 230, 80, 80);                  // สี่ เหลี่ยม หลัง
            myGraphic.DrawRectangle(myPen1, 160, 240, 80, 80);                  // สี่ เหลี่ยม หน้า
            myGraphic.DrawLine(myPen4, 168, 233, 248, 233);                     // สี บนกล่อง *
            myGraphic.DrawLine(myPen4, 163, 237, 243, 237);                     // สี บนกล่อง **
            myGraphic.DrawLine(myPen4, 243, 238, 243, 318);                     // สี ข้างกล่อง *
            myGraphic.DrawLine(myPen4, 247, 232, 247, 312);                     // สี ข้างกล่อง **
            myGraphic.FillRectangle(BlueBrush, 162, 242, 77, 77);               // สี หน้ากล่อง
            myGraphic.DrawLine(myPen1, 170, 230, 160, 240);                     // เส้น 1
            myGraphic.DrawLine(myPen1, 210, 230, 200, 240);                     // เส้น 2
            myGraphic.DrawLine(myPen1, 250, 230, 240, 240);                     // เส้น 3
            myGraphic.DrawLine(myPen1, 250, 310, 240, 320);                     // เส้น 4
            myGraphic.DrawLine(myPen1, 165, 235, 245, 235);                     // เส้น บน
            myGraphic.DrawLine(myPen1, 200, 240, 200, 320);                     // เส้น กลาง
            myGraphic.DrawLine(myPen1, 245, 235, 245, 315);                     // เส้น ข้าง

            // ต้นคริสต์มาส
            myGraphic.DrawLine(myPenGreenbold15, 455, 280, 455, 322);           // สีต้น              *
            myGraphic.DrawLine(myPenGreenbold15, 470, 260, 470, 322);           // สีต้น              **
            myGraphic.DrawLine(myPenGreenbold15, 485, 200, 485, 322);           // สีต้น              ***
            myGraphic.DrawLine(myPenGreenbold15, 500, 180, 500, 322);           // สีต้น              ****
            myGraphic.DrawLine(myPenGreenbold15, 515, 130, 515, 322);           // สีต้น              *****
            myGraphic.DrawLine(myPenGreenbold15, 525, 110, 525, 322);           // สีต้น              ******
            myGraphic.DrawLine(myPenGreenbold15, 540, 90, 540, 322);            // สีต้น              *******
            myGraphic.DrawLine(myPenGreenbold4, 540, 81, 540, 322);             // สีต้น              ********
            myGraphic.DrawLine(myPenGreenbold15, 540, 90, 540, 322);            // สีต้น              *******
            myGraphic.DrawLine(myPenGreenbold15, 555, 110, 555, 322);           // สีต้น              ******
            myGraphic.DrawLine(myPenGreenbold15, 565, 130, 565, 322);           // สีต้น              *****
            myGraphic.DrawLine(myPenGreenbold15, 580, 180, 580, 322);           // สีต้น              ****
            myGraphic.DrawLine(myPenGreenbold15, 595, 200, 595, 322);           // สีต้น              ***
            myGraphic.DrawLine(myPenGreenbold15, 610, 260, 610, 322);           // สีต้น              **
            myGraphic.DrawLine(myPenGreenbold15, 625, 280, 625, 322);           // สีต้น              *
            myGraphic.DrawLine(myPenGreenbold4, 540, 84, 484, 160);             // สี ใบต้นบน ซ้าย      *
            myGraphic.DrawLine(myPenGreenbold4, 540, 90, 488, 160);             // สี ใบต้นบน ซ้าย      **
            myGraphic.DrawLine(myPenGreenbold4, 540, 95, 492, 160);             // สี ใบต้นบน ซ้าย      ***
            myGraphic.DrawLine(myPenGreenbold4, 540, 95, 588, 160);             // สี ใบต้นบน ขวา      ***
            myGraphic.DrawLine(myPenGreenbold4, 540, 90, 592, 160);             // สี ใบต้นบน ขวา      **
            myGraphic.DrawLine(myPenGreenbold4, 540, 84, 596, 160);             // สี ใบต้นบน ขวา      *
            myGraphic.DrawLine(myPenGreenbold16, 495, 151, 590, 151);           // ปิดช่องบน
            myGraphic.DrawLine(myPenGreenbold4, 510, 164, 454, 240);            // สี ใบต้นกลาง ซ้าย     *
            myGraphic.DrawLine(myPenGreenbold4, 510, 170, 458, 240);            // สี ใบต้นกลาง ซ้าย     **
            myGraphic.DrawLine(myPenGreenbold4, 510, 175, 462, 240);            // สี ใบต้นกลาง ซ้าย     ***
            myGraphic.DrawLine(myPenGreenbold4, 570, 175, 618, 240);            // สี ใบต้นกลาง ขวา     ***
            myGraphic.DrawLine(myPenGreenbold4, 570, 170, 622, 240);            // สี ใบต้นกลาง ขวา     **
            myGraphic.DrawLine(myPenGreenbold4, 570, 164, 626, 240);            // สี ใบต้นกลาง ขวา     *
            myGraphic.DrawLine(myPenGreenbold16, 465, 231, 620, 231);           // ปิดช่องกลาง
            myGraphic.DrawLine(myPenGreenbold4, 480, 244, 424, 320);            // สี ใบต้นล่าง ซ้าย      *
            myGraphic.DrawLine(myPenGreenbold4, 480, 250, 428, 320);            // สี ใบต้นล่าง ซ้าย      **
            myGraphic.DrawLine(myPenGreenbold4, 480, 255, 432, 320);            // สี ใบต้นล่าง ซ้าย      ***
            myGraphic.DrawLine(myPenGreenbold4, 600, 255, 648, 320);            // สี ใบต้นล่าง ซ้าย      ***
            myGraphic.DrawLine(myPenGreenbold4, 600, 250, 652, 320);            // สี ใบต้นล่าง ซ้าย      **
            myGraphic.DrawLine(myPenGreenbold4, 600, 244, 656, 320);            // สี ใบต้นล่าง ขวา      *
            myGraphic.DrawLine(myPenGreenbold16, 431, 311, 650, 311);           // ปิดช่องล่าง
            myGraphic.DrawLine(myPenRedbold2, 480, 160, 570, 120);              // เส้นตัดต้น *
            myGraphic.DrawLine(myPenRedbold2, 480, 240, 600, 200);              // เส้นตัดต้น **
            myGraphic.DrawLine(myPenRedbold2, 520, 320, 630, 280);              // เส้นตัดต้น ***
            myGraphic.DrawLine(myPen1, 540, 80, 480, 160);                      // ใบต้นบน ซ้าย
            myGraphic.DrawLine(myPen1, 540, 80, 600, 160);                      // ใบต้นบน ซ้าย
            myGraphic.DrawLine(myPen1, 480, 160, 510, 160);                     // บนต้นล่าง ซ้าย
            myGraphic.DrawLine(myPen1, 570, 160, 600, 160);                     // บนต้นล่าง ขวา
            myGraphic.DrawLine(myPen1, 510, 160, 450, 240);                     // ใบต้นกลาง ซ้าย
            myGraphic.DrawLine(myPen1, 570, 160, 630, 240);                     // ใบต้นกลาง ขวา
            myGraphic.DrawLine(myPen1, 450, 240, 480, 240);                     // กลางต้นล่าง ซ้าย
            myGraphic.DrawLine(myPen1, 600, 240, 630, 240);                     // กลางต้นล่าง ขวา
            myGraphic.DrawLine(myPen1, 480, 240, 420, 320);                     // ใบต้นล่าง ซ้าย
            myGraphic.DrawLine(myPen1, 600, 240, 660, 320);                     // ใบต้นล่าง ขวา
            myGraphic.DrawLine(myPen1, 420, 320, 660, 320);                     // ใต้ต้นล่าง
            myGraphic.FillRectangle(BrownBrush, 520, 322, 40, 40);              // ขาต้น
            myGraphic.DrawRectangle(myPen1, 520, 320, 40, 40);                  // ขอบขาต้น
        }
    }
}
