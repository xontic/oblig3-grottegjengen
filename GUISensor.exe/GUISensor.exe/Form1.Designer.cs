namespace GUISensor.exe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNyTemperatur = new Button();
            btnNyTrykkmaaler = new Button();
            btnNyMaaling = new Button();
            btnSlettMaaling = new Button();
            txtTekstboks = new TextBox();
            comboxSensor = new ComboBox();
            menuStrip1 = new MenuStrip();
            handlingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuLagre = new ToolStripMenuItem();
            toolStripMenuLes = new ToolStripMenuItem();
            toolStripMenuAvslutt = new ToolStripMenuItem();
            toolStripMenuFjern = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNyTemperatur
            // 
            btnNyTemperatur.Location = new Point(10, 258);
            btnNyTemperatur.Margin = new Padding(3, 2, 3, 2);
            btnNyTemperatur.Name = "btnNyTemperatur";
            btnNyTemperatur.Size = new Size(184, 22);
            btnNyTemperatur.TabIndex = 0;
            btnNyTemperatur.Text = "Ny Temperaturmåler";
            btnNyTemperatur.UseVisualStyleBackColor = true;
            btnNyTemperatur.Click += btnNyTemperatur_Click;
            // 
            // btnNyTrykkmaaler
            // 
            btnNyTrykkmaaler.Location = new Point(200, 258);
            btnNyTrykkmaaler.Margin = new Padding(3, 2, 3, 2);
            btnNyTrykkmaaler.Name = "btnNyTrykkmaaler";
            btnNyTrykkmaaler.Size = new Size(197, 22);
            btnNyTrykkmaaler.TabIndex = 1;
            btnNyTrykkmaaler.Text = "Ny Trykkmåler";
            btnNyTrykkmaaler.UseVisualStyleBackColor = true;
            btnNyTrykkmaaler.Click += btnNyTrykkmaaler_Click;
            // 
            // btnNyMaaling
            // 
            btnNyMaaling.Location = new Point(410, 258);
            btnNyMaaling.Margin = new Padding(3, 2, 3, 2);
            btnNyMaaling.Name = "btnNyMaaling";
            btnNyMaaling.Size = new Size(201, 22);
            btnNyMaaling.TabIndex = 2;
            btnNyMaaling.Text = "Ny Måling";
            btnNyMaaling.UseVisualStyleBackColor = true;
            btnNyMaaling.Click += btnNyMaaling_Click;
            // 
            // btnSlettMaaling
            // 
            btnSlettMaaling.Location = new Point(616, 258);
            btnSlettMaaling.Margin = new Padding(3, 2, 3, 2);
            btnSlettMaaling.Name = "btnSlettMaaling";
            btnSlettMaaling.Size = new Size(172, 22);
            btnSlettMaaling.TabIndex = 3;
            btnSlettMaaling.Text = "Slett Sensor";
            btnSlettMaaling.UseVisualStyleBackColor = true;
            btnSlettMaaling.Click += btnSlettMaaling_Click;
            // 
            // txtTekstboks
            // 
            txtTekstboks.Location = new Point(10, 40);
            txtTekstboks.Margin = new Padding(3, 2, 3, 2);
            txtTekstboks.Multiline = true;
            txtTekstboks.Name = "txtTekstboks";
            txtTekstboks.Size = new Size(779, 215);
            txtTekstboks.TabIndex = 5;
            // 
            // comboxSensor
            // 
            comboxSensor.FormattingEnabled = true;
            comboxSensor.Location = new Point(10, 292);
            comboxSensor.Margin = new Padding(3, 2, 3, 2);
            comboxSensor.Name = "comboxSensor";
            comboxSensor.Size = new Size(778, 23);
            comboxSensor.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { handlingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // handlingToolStripMenuItem
            // 
            handlingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuLagre, toolStripMenuLes, toolStripMenuAvslutt, toolStripMenuFjern });
            handlingToolStripMenuItem.Name = "handlingToolStripMenuItem";
            handlingToolStripMenuItem.Size = new Size(68, 20);
            handlingToolStripMenuItem.Text = "Handling";
            // 
            // toolStripMenuLagre
            // 
            toolStripMenuLagre.Name = "toolStripMenuLagre";
            toolStripMenuLagre.Size = new Size(171, 22);
            toolStripMenuLagre.Text = "Lagre Til Fil";
            toolStripMenuLagre.Click += toolStripMenuLagre_Click;
            // 
            // toolStripMenuLes
            // 
            toolStripMenuLes.Name = "toolStripMenuLes";
            toolStripMenuLes.Size = new Size(171, 22);
            toolStripMenuLes.Text = "Les Fra Fil";
            toolStripMenuLes.Click += toolStripMenuLes_Click;
            // 
            // toolStripMenuAvslutt
            // 
            toolStripMenuAvslutt.Name = "toolStripMenuAvslutt";
            toolStripMenuAvslutt.Size = new Size(171, 22);
            toolStripMenuAvslutt.Text = "Avslutt";
            toolStripMenuAvslutt.Click += toolStripMenuAvslutt_Click;
            // 
            // toolStripMenuFjern
            // 
            toolStripMenuFjern.Name = "toolStripMenuFjern";
            toolStripMenuFjern.Size = new Size(171, 22);
            toolStripMenuFjern.Text = "Fjern Alle Sensorer";
            toolStripMenuFjern.Click += toolStripMenuFjern_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 382);
            Controls.Add(comboxSensor);
            Controls.Add(txtTekstboks);
            Controls.Add(btnSlettMaaling);
            Controls.Add(btnNyMaaling);
            Controls.Add(btnNyTrykkmaaler);
            Controls.Add(btnNyTemperatur);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "GUI Sensorer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNyTemperatur;
        private Button btnNyTrykkmaaler;
        private Button btnNyMaaling;
        private Button btnSlettMaaling;
        private TextBox txtTekstboks;
        private ComboBox comboxSensor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem handlingToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuLagre;
        private ToolStripMenuItem toolStripMenuLes;
        private ToolStripMenuItem toolStripMenuAvslutt;
        private ToolStripMenuItem toolStripMenuFjern;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}