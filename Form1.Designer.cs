namespace Ampelsteuerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbOrange = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.txbGreen = new System.Windows.Forms.TextBox();
            this.txbOrange = new System.Windows.Forms.TextBox();
            this.txbRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRedPed = new System.Windows.Forms.Panel();
            this.panelGreenPed = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPed = new System.Windows.Forms.Button();
            this.timerPrivate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGreen
            // 
            this.tbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbGreen.Location = new System.Drawing.Point(325, 41);
            this.tbGreen.Maximum = 50;
            this.tbGreen.Minimum = 10;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(211, 45);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.Value = 10;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbOrange
            // 
            this.tbOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbOrange.Location = new System.Drawing.Point(325, 92);
            this.tbOrange.Maximum = 50;
            this.tbOrange.Minimum = 1;
            this.tbOrange.Name = "tbOrange";
            this.tbOrange.Size = new System.Drawing.Size(211, 45);
            this.tbOrange.TabIndex = 4;
            this.tbOrange.TickFrequency = 5;
            this.tbOrange.Value = 1;
            this.tbOrange.Scroll += new System.EventHandler(this.tbOrange_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbRed.Location = new System.Drawing.Point(325, 143);
            this.tbRed.Maximum = 50;
            this.tbRed.Minimum = 10;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(211, 45);
            this.tbRed.TabIndex = 5;
            this.tbRed.TickFrequency = 5;
            this.tbRed.Value = 10;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // txbGreen
            // 
            this.txbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGreen.Location = new System.Drawing.Point(542, 41);
            this.txbGreen.Name = "txbGreen";
            this.txbGreen.Size = new System.Drawing.Size(105, 20);
            this.txbGreen.TabIndex = 6;
            this.txbGreen.TextChanged += new System.EventHandler(this.txbGreen_TextChanged);
            // 
            // txbOrange
            // 
            this.txbOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbOrange.Location = new System.Drawing.Point(542, 92);
            this.txbOrange.Name = "txbOrange";
            this.txbOrange.Size = new System.Drawing.Size(105, 20);
            this.txbOrange.TabIndex = 7;
            this.txbOrange.TextChanged += new System.EventHandler(this.txbOrange_TextChanged);
            // 
            // txbRed
            // 
            this.txbRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRed.Location = new System.Drawing.Point(542, 143);
            this.txbRed.Name = "txbRed";
            this.txbRed.Size = new System.Drawing.Size(105, 20);
            this.txbRed.TabIndex = 8;
            this.txbRed.TextChanged += new System.EventHandler(this.txbRed_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Green light delay";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Orange light delay";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Red light delay";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(339, 194);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // panelRed
            // 
            this.panelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRed.BackColor = System.Drawing.Color.Black;
            this.panelRed.Location = new System.Drawing.Point(12, 12);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(100, 100);
            this.panelRed.TabIndex = 13;
            // 
            // panelOrange
            // 
            this.panelOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrange.BackColor = System.Drawing.Color.Black;
            this.panelOrange.Location = new System.Drawing.Point(12, 118);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(100, 100);
            this.panelOrange.TabIndex = 14;
            // 
            // panelGreen
            // 
            this.panelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGreen.BackColor = System.Drawing.Color.Black;
            this.panelGreen.Location = new System.Drawing.Point(12, 224);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(100, 100);
            this.panelGreen.TabIndex = 14;
            // 
            // panelRedPed
            // 
            this.panelRedPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRedPed.BackColor = System.Drawing.Color.Black;
            this.panelRedPed.Location = new System.Drawing.Point(161, 12);
            this.panelRedPed.Name = "panelRedPed";
            this.panelRedPed.Size = new System.Drawing.Size(100, 100);
            this.panelRedPed.TabIndex = 14;
            // 
            // panelGreenPed
            // 
            this.panelGreenPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGreenPed.BackColor = System.Drawing.Color.Black;
            this.panelGreenPed.Location = new System.Drawing.Point(161, 118);
            this.panelGreenPed.Name = "panelGreenPed";
            this.panelGreenPed.Size = new System.Drawing.Size(100, 100);
            this.panelGreenPed.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Location = new System.Drawing.Point(510, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 41);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start color";
            // 
            // rbRed
            // 
            this.rbRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRed.AutoSize = true;
            this.rbRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRed.Location = new System.Drawing.Point(92, 15);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGreen.AutoSize = true;
            this.rbGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGreen.Location = new System.Drawing.Point(6, 15);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 0;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(338, 260);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 64);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location = new System.Drawing.Point(510, 260);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 64);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mode";
            // 
            // btnPed
            // 
            this.btnPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPed.Location = new System.Drawing.Point(161, 260);
            this.btnPed.Name = "btnPed";
            this.btnPed.Size = new System.Drawing.Size(122, 64);
            this.btnPed.TabIndex = 19;
            this.btnPed.Text = "Ped Button";
            this.btnPed.UseVisualStyleBackColor = true;
            this.btnPed.Click += new System.EventHandler(this.btnPed_Click);
            // 
            // timerPrivate
            // 
            this.timerPrivate.Interval = 1000;
            this.timerPrivate.Tick += new System.EventHandler(this.timerPrivate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 350);
            this.Controls.Add(this.btnPed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelGreenPed);
            this.Controls.Add(this.panelRedPed);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelOrange);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRed);
            this.Controls.Add(this.txbOrange);
            this.Controls.Add(this.txbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.tbOrange);
            this.Controls.Add(this.tbGreen);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Trafficlight";
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbOrange;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TextBox txbGreen;
        private System.Windows.Forms.TextBox txbOrange;
        private System.Windows.Forms.TextBox txbRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRedPed;
        private System.Windows.Forms.Panel panelGreenPed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPed;
        private System.Windows.Forms.Timer timerPrivate;
    }
}

