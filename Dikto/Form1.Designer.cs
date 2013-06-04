namespace Dikto
{
    partial class form_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_rec = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_file = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label_time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_rec);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_play);
            this.groupBox1.Location = new System.Drawing.Point(4, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete.BackgroundImage")));
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.Location = new System.Drawing.Point(143, 12);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(32, 32);
            this.button_delete.TabIndex = 12;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_rec
            // 
            this.button_rec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rec.BackgroundImage")));
            this.button_rec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rec.Location = new System.Drawing.Point(5, 12);
            this.button_rec.Name = "button_rec";
            this.button_rec.Size = new System.Drawing.Size(32, 32);
            this.button_rec.TabIndex = 11;
            this.button_rec.UseVisualStyleBackColor = true;
            this.button_rec.Click += new System.EventHandler(this.button_rec_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_stop.BackgroundImage")));
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(81, 12);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(32, 32);
            this.button_stop.TabIndex = 10;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_play
            // 
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Location = new System.Drawing.Point(43, 12);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(32, 32);
            this.button_play.TabIndex = 9;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_file);
            this.groupBox2.Controls.Add(this.numeric);
            this.groupBox2.Controls.Add(this.label_time);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 69);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_file.Location = new System.Drawing.Point(82, 15);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(54, 20);
            this.label_file.TabIndex = 13;
            this.label_file.Text = "Пусто";
            // 
            // numeric
            // 
            this.numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric.Location = new System.Drawing.Point(9, 13);
            this.numeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(67, 26);
            this.numeric.TabIndex = 12;
            this.numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.Click += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(127, 47);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(48, 18);
            this.label_time.TabIndex = 14;
            this.label_time.Text = "00:00";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(207, 162);
            this.MinimumSize = new System.Drawing.Size(207, 162);
            this.Name = "form_main";
            this.Text = "Диктофон";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_rec;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Label label_time;
    }
}

