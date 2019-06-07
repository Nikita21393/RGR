using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Races
{
    public partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_btn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pause_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fifth_car_btn = new Races.ButtonCompare();
            this.fourth_car_btn = new Races.ButtonCompare();
            this.third_car_btn = new Races.ButtonCompare();
            this.second_car_btn = new Races.ButtonCompare();
            this.first_car_btn = new Races.ButtonCompare();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(23, 28);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(94, 26);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Старт";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(161, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(296, 28);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(94, 26);
            this.stop_btn.TabIndex = 9;
            this.stop_btn.Text = "Стоп";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Races.Properties.Resources._3779723_asphalt_rofdgdfad_marking_top_view;
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.pause_btn);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Location = new System.Drawing.Point(162, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pause_btn
            // 
            this.pause_btn.Enabled = false;
            this.pause_btn.Location = new System.Drawing.Point(161, 28);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(94, 26);
            this.pause_btn.TabIndex = 8;
            this.pause_btn.Text = "Пауза";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Races.Properties.Resources.finish_line;
            this.pictureBox1.Location = new System.Drawing.Point(661, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // fifth_car_btn
            // 
            this.fifth_car_btn.Image = global::Races.Properties.Resources.car05;
            this.fifth_car_btn.Location = new System.Drawing.Point(12, 234);
            this.fifth_car_btn.Name = "Красная_машина";
            this.fifth_car_btn.Size = new System.Drawing.Size(94, 50);
            this.fifth_car_btn.TabIndex = 11;
            this.fifth_car_btn.UseVisualStyleBackColor = true;
            // 
            // fourth_car_btn
            // 
            this.fourth_car_btn.Image = global::Races.Properties.Resources.car04;
            this.fourth_car_btn.Location = new System.Drawing.Point(12, 178);
            this.fourth_car_btn.Name = "Желтая_машина";
            this.fourth_car_btn.Size = new System.Drawing.Size(94, 50);
            this.fourth_car_btn.TabIndex = 5;
            this.fourth_car_btn.UseVisualStyleBackColor = true;
            // 
            // third_car_btn
            // 
            this.third_car_btn.Image = global::Races.Properties.Resources.car03;
            this.third_car_btn.Location = new System.Drawing.Point(12, 122);
            this.third_car_btn.Name = "Зеленая_машина";
            this.third_car_btn.Size = new System.Drawing.Size(94, 50);
            this.third_car_btn.TabIndex = 4;
            this.third_car_btn.UseVisualStyleBackColor = true;
            // 
            // second_car_btn
            // 
            this.second_car_btn.Image = global::Races.Properties.Resources.car02;
            this.second_car_btn.Location = new System.Drawing.Point(12, 68);
            this.second_car_btn.Name = "Синяя_машина";
            this.second_car_btn.Size = new System.Drawing.Size(94, 50);
            this.second_car_btn.TabIndex = 3;
            this.second_car_btn.UseVisualStyleBackColor = true;
            // 
            // first_car_btn
            // 
            this.first_car_btn.Image = global::Races.Properties.Resources.car01;
            this.first_car_btn.Location = new System.Drawing.Point(12, 12);
            this.first_car_btn.Name = "Белая_машина";
            this.first_car_btn.Size = new System.Drawing.Size(94, 50);
            this.first_car_btn.TabIndex = 2;
            this.first_car_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Races.Properties.Resources._3779723_asphalt_road_marking_top_view;
            this.ClientSize = new System.Drawing.Size(728, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fifth_car_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fourth_car_btn);
            this.Controls.Add(this.third_car_btn);
            this.Controls.Add(this.second_car_btn);
            this.Controls.Add(this.first_car_btn);
            this.Name = "MainForm";
            this.Text = "Races";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
            static Random r = new Random();
            static void Args(string[] args){
            int z = 0;
            int[] arr = new int[z];
            for (int j = 0; j < arr.Length; j++){
            arr[j] = r.Next(-10, 10);}
            int Min = 0, Max = 0;
            int index1 = 0, index2 = 0;
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < Min){
                    Min = arr[i];
                    index2 = i;}
                if (arr[i] > Max){
                    Max = arr[i];
                    index1 = i;}}
            int x = 2000;
            int y = Write(x);
            string input = "dsg";
            char sumbol = 'c';
            int s = Sourcce(input, sumbol);}
            public static int Sourcce(string input, char sumbol){
            int ActualCount = 0;
            for (int i = 0; i < input.Length; i++){
             if (input[i].Equals(sumbol)) ActualCount++;}
            return ActualCount;}
            public static int Write(int x){
            int y = 0;
            if (x % 4 == 0){
            if (x % 100 == 0){
            if (x % 400 == 0){y = 366;}}}
            else y = 365;
            return y;}
            public static int Swap(int[] arr, int Min, int Max){
            int raznica = Min - Max;
            for (int i = 0; i < arr.Length; i++){
            if (arr[i] % 2 == 0 && arr[i] < 0) ;}
            return raznica;}
        #endregion

        private ButtonCompare first_car_btn;
        private ButtonCompare second_car_btn;
        private ButtonCompare third_car_btn;
        private ButtonCompare fourth_car_btn;
        private ButtonCompare fifth_car_btn;

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.PictureBox pictureBox1;

       
    }
}

