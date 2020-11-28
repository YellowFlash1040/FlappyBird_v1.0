namespace FlappyBird_v1._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startGameButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.GameOver_Label = new System.Windows.Forms.Label();
            this.Restart_button = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.GameScore_Label = new System.Windows.Forms.Label();
            this.pbWall1 = new System.Windows.Forms.PictureBox();
            this.pbWall2 = new System.Windows.Forms.PictureBox();
            this.pbWall3 = new System.Windows.Forms.PictureBox();
            this.pbWall4 = new System.Windows.Forms.PictureBox();
            this.pbWall5 = new System.Windows.Forms.PictureBox();
            this.pbWall6 = new System.Windows.Forms.PictureBox();
            this.pbWall7 = new System.Windows.Forms.PictureBox();
            this.pbWall8 = new System.Windows.Forms.PictureBox();
            this.pbWall9 = new System.Windows.Forms.PictureBox();
            this.pbWall10 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGround_FirstHalf = new System.Windows.Forms.PictureBox();
            this.pbGround_SecondHalf = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.info_button = new System.Windows.Forms.Button();
            this.Esc_continue_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.Esc_menu_background = new System.Windows.Forms.Label();
            this.info_GameControl_label = new System.Windows.Forms.Label();
            this.back_info_button = new System.Windows.Forms.Button();
            this.info_GameRules_label = new System.Windows.Forms.Label();
            this.info_GameInstructions_label = new System.Windows.Forms.Label();
            this.info_GoodLuck_label = new System.Windows.Forms.Label();
            this.GamersResults_button = new System.Windows.Forms.Button();
            this.EasyGameMode_button = new System.Windows.Forms.Button();
            this.MediumGameMode_button = new System.Windows.Forms.Button();
            this.HardGameMode_button = new System.Windows.Forms.Button();
            this.RandomGameMode_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround_FirstHalf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround_SecondHalf)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer_Wall_And_Ground_Tick);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(417, 311);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(178, 107);
            this.startGameButton.TabIndex = 22;
            this.startGameButton.Text = "Start";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 33;
            this.timer2.Tick += new System.EventHandler(this.timer_Bird_Tick);
            // 
            // GameOver_Label
            // 
            this.GameOver_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOver_Label.Location = new System.Drawing.Point(380, 340);
            this.GameOver_Label.Name = "GameOver_Label";
            this.GameOver_Label.Size = new System.Drawing.Size(272, 59);
            this.GameOver_Label.TabIndex = 37;
            this.GameOver_Label.Text = "Game Over";
            this.GameOver_Label.Visible = false;
            // 
            // Restart_button
            // 
            this.Restart_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart_button.Location = new System.Drawing.Point(471, 411);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(86, 29);
            this.Restart_button.TabIndex = 38;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            this.Restart_button.Visible = false;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // GameScore_Label
            // 
            this.GameScore_Label.BackColor = System.Drawing.Color.White;
            this.GameScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameScore_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GameScore_Label.Location = new System.Drawing.Point(7, 5);
            this.GameScore_Label.Name = "GameScore_Label";
            this.GameScore_Label.Size = new System.Drawing.Size(76, 23);
            this.GameScore_Label.TabIndex = 39;
            this.GameScore_Label.Text = "0";
            this.GameScore_Label.Visible = false;
            // 
            // pbWall1
            // 
            this.pbWall1.Image = ((System.Drawing.Image)(resources.GetObject("pbWall1.Image")));
            this.pbWall1.Location = new System.Drawing.Point(12, 0);
            this.pbWall1.Name = "pbWall1";
            this.pbWall1.Size = new System.Drawing.Size(86, 284);
            this.pbWall1.TabIndex = 15;
            this.pbWall1.TabStop = false;
            this.pbWall1.Visible = false;
            // 
            // pbWall2
            // 
            this.pbWall2.Image = ((System.Drawing.Image)(resources.GetObject("pbWall2.Image")));
            this.pbWall2.Location = new System.Drawing.Point(12, 540);
            this.pbWall2.Name = "pbWall2";
            this.pbWall2.Size = new System.Drawing.Size(86, 138);
            this.pbWall2.TabIndex = 25;
            this.pbWall2.TabStop = false;
            this.pbWall2.Visible = false;
            // 
            // pbWall3
            // 
            this.pbWall3.Image = ((System.Drawing.Image)(resources.GetObject("pbWall3.Image")));
            this.pbWall3.Location = new System.Drawing.Point(202, 0);
            this.pbWall3.Name = "pbWall3";
            this.pbWall3.Size = new System.Drawing.Size(86, 284);
            this.pbWall3.TabIndex = 29;
            this.pbWall3.TabStop = false;
            this.pbWall3.Visible = false;
            // 
            // pbWall4
            // 
            this.pbWall4.Image = ((System.Drawing.Image)(resources.GetObject("pbWall4.Image")));
            this.pbWall4.Location = new System.Drawing.Point(202, 540);
            this.pbWall4.Name = "pbWall4";
            this.pbWall4.Size = new System.Drawing.Size(86, 138);
            this.pbWall4.TabIndex = 28;
            this.pbWall4.TabStop = false;
            this.pbWall4.Visible = false;
            // 
            // pbWall5
            // 
            this.pbWall5.Image = ((System.Drawing.Image)(resources.GetObject("pbWall5.Image")));
            this.pbWall5.Location = new System.Drawing.Point(392, 0);
            this.pbWall5.Name = "pbWall5";
            this.pbWall5.Size = new System.Drawing.Size(86, 284);
            this.pbWall5.TabIndex = 31;
            this.pbWall5.TabStop = false;
            this.pbWall5.Visible = false;
            // 
            // pbWall6
            // 
            this.pbWall6.Image = ((System.Drawing.Image)(resources.GetObject("pbWall6.Image")));
            this.pbWall6.Location = new System.Drawing.Point(392, 540);
            this.pbWall6.Name = "pbWall6";
            this.pbWall6.Size = new System.Drawing.Size(86, 138);
            this.pbWall6.TabIndex = 30;
            this.pbWall6.TabStop = false;
            this.pbWall6.Visible = false;
            // 
            // pbWall7
            // 
            this.pbWall7.Image = ((System.Drawing.Image)(resources.GetObject("pbWall7.Image")));
            this.pbWall7.Location = new System.Drawing.Point(582, 0);
            this.pbWall7.Name = "pbWall7";
            this.pbWall7.Size = new System.Drawing.Size(86, 284);
            this.pbWall7.TabIndex = 24;
            this.pbWall7.TabStop = false;
            this.pbWall7.Visible = false;
            // 
            // pbWall8
            // 
            this.pbWall8.Image = ((System.Drawing.Image)(resources.GetObject("pbWall8.Image")));
            this.pbWall8.Location = new System.Drawing.Point(582, 540);
            this.pbWall8.Name = "pbWall8";
            this.pbWall8.Size = new System.Drawing.Size(86, 138);
            this.pbWall8.TabIndex = 16;
            this.pbWall8.TabStop = false;
            this.pbWall8.Visible = false;
            // 
            // pbWall9
            // 
            this.pbWall9.Image = ((System.Drawing.Image)(resources.GetObject("pbWall9.Image")));
            this.pbWall9.Location = new System.Drawing.Point(772, 0);
            this.pbWall9.Name = "pbWall9";
            this.pbWall9.Size = new System.Drawing.Size(86, 284);
            this.pbWall9.TabIndex = 33;
            this.pbWall9.TabStop = false;
            this.pbWall9.Visible = false;
            // 
            // pbWall10
            // 
            this.pbWall10.Image = ((System.Drawing.Image)(resources.GetObject("pbWall10.Image")));
            this.pbWall10.Location = new System.Drawing.Point(772, 540);
            this.pbWall10.Name = "pbWall10";
            this.pbWall10.Size = new System.Drawing.Size(86, 138);
            this.pbWall10.TabIndex = 32;
            this.pbWall10.TabStop = false;
            this.pbWall10.Visible = false;
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbBird.Image = ((System.Drawing.Image)(resources.GetObject("pbBird.Image")));
            this.pbBird.Location = new System.Drawing.Point(146, 386);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(68, 66);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 23;
            this.pbBird.TabStop = false;
            this.pbBird.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird_v1._0.Properties.Resources.BackStage_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pbGround_FirstHalf
            // 
            this.pbGround_FirstHalf.Image = global::FlappyBird_v1._0.Properties.Resources.Ground_image_FirstHalf;
            this.pbGround_FirstHalf.Location = new System.Drawing.Point(0, 678);
            this.pbGround_FirstHalf.Name = "pbGround_FirstHalf";
            this.pbGround_FirstHalf.Size = new System.Drawing.Size(1074, 114);
            this.pbGround_FirstHalf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround_FirstHalf.TabIndex = 40;
            this.pbGround_FirstHalf.TabStop = false;
            this.pbGround_FirstHalf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGround_FirstHalf_MouseDown);
            // 
            // pbGround_SecondHalf
            // 
            this.pbGround_SecondHalf.Image = global::FlappyBird_v1._0.Properties.Resources.Ground_image_FirstHalf;
            this.pbGround_SecondHalf.Location = new System.Drawing.Point(1071, 678);
            this.pbGround_SecondHalf.Name = "pbGround_SecondHalf";
            this.pbGround_SecondHalf.Size = new System.Drawing.Size(1074, 114);
            this.pbGround_SecondHalf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround_SecondHalf.TabIndex = 41;
            this.pbGround_SecondHalf.TabStop = false;
            this.pbGround_SecondHalf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGround_SecondHalf_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.Location = new System.Drawing.Point(457, 481);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(100, 27);
            this.info_button.TabIndex = 43;
            this.info_button.Text = "Rules";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // Esc_continue_button
            // 
            this.Esc_continue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Esc_continue_button.Location = new System.Drawing.Point(471, 377);
            this.Esc_continue_button.Name = "Esc_continue_button";
            this.Esc_continue_button.Size = new System.Drawing.Size(86, 29);
            this.Esc_continue_button.TabIndex = 44;
            this.Esc_continue_button.Text = "Continue";
            this.Esc_continue_button.UseVisualStyleBackColor = true;
            this.Esc_continue_button.Visible = false;
            this.Esc_continue_button.Click += new System.EventHandler(this.Esc_continue_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(471, 446);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(86, 29);
            this.exit_button.TabIndex = 45;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Visible = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Esc_menu_background
            // 
            this.Esc_menu_background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Esc_menu_background.Location = new System.Drawing.Point(457, 362);
            this.Esc_menu_background.Name = "Esc_menu_background";
            this.Esc_menu_background.Size = new System.Drawing.Size(113, 128);
            this.Esc_menu_background.TabIndex = 46;
            this.Esc_menu_background.Visible = false;
            // 
            // info_GameControl_label
            // 
            this.info_GameControl_label.Location = new System.Drawing.Point(426, 289);
            this.info_GameControl_label.Name = "info_GameControl_label";
            this.info_GameControl_label.Size = new System.Drawing.Size(178, 251);
            this.info_GameControl_label.TabIndex = 47;
            this.info_GameControl_label.Text = resources.GetString("info_GameControl_label.Text");
            this.info_GameControl_label.Visible = false;
            // 
            // back_info_button
            // 
            this.back_info_button.Location = new System.Drawing.Point(471, 601);
            this.back_info_button.Name = "back_info_button";
            this.back_info_button.Size = new System.Drawing.Size(75, 23);
            this.back_info_button.TabIndex = 48;
            this.back_info_button.Text = "Back";
            this.back_info_button.UseVisualStyleBackColor = true;
            this.back_info_button.Visible = false;
            this.back_info_button.Click += new System.EventHandler(this.back_info_button_Click);
            // 
            // info_GameRules_label
            // 
            this.info_GameRules_label.Location = new System.Drawing.Point(426, 145);
            this.info_GameRules_label.Name = "info_GameRules_label";
            this.info_GameRules_label.Size = new System.Drawing.Size(178, 132);
            this.info_GameRules_label.TabIndex = 49;
            this.info_GameRules_label.Text = "\r\nСуть игры заключается в перепрыгивании птичкой барьеров. За каждый перепрыгнуты" +
    "й барьер игрок будет получать +100 очков. Количество очков отображаеться в левом" +
    " верхнем углу.";
            this.info_GameRules_label.Visible = false;
            // 
            // info_GameInstructions_label
            // 
            this.info_GameInstructions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_GameInstructions_label.Location = new System.Drawing.Point(413, 79);
            this.info_GameInstructions_label.Name = "info_GameInstructions_label";
            this.info_GameInstructions_label.Size = new System.Drawing.Size(201, 57);
            this.info_GameInstructions_label.TabIndex = 50;
            this.info_GameInstructions_label.Text = "\r\n       Инструкции к игре        ";
            this.info_GameInstructions_label.Visible = false;
            // 
            // info_GoodLuck_label
            // 
            this.info_GoodLuck_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_GoodLuck_label.Location = new System.Drawing.Point(457, 553);
            this.info_GoodLuck_label.Name = "info_GoodLuck_label";
            this.info_GoodLuck_label.Size = new System.Drawing.Size(100, 23);
            this.info_GoodLuck_label.TabIndex = 51;
            this.info_GoodLuck_label.Text = "   Удачи!";
            this.info_GoodLuck_label.Visible = false;
            // 
            // GamersResults_button
            // 
            this.GamersResults_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamersResults_button.Location = new System.Drawing.Point(445, 446);
            this.GamersResults_button.Name = "GamersResults_button";
            this.GamersResults_button.Size = new System.Drawing.Size(125, 29);
            this.GamersResults_button.TabIndex = 52;
            this.GamersResults_button.Text = "Results  Table";
            this.GamersResults_button.UseVisualStyleBackColor = true;
            this.GamersResults_button.Click += new System.EventHandler(this.GamersResults_button_Click);
            // 
            // EasyGameMode_button
            // 
            this.EasyGameMode_button.AutoSize = true;
            this.EasyGameMode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyGameMode_button.Location = new System.Drawing.Point(464, 311);
            this.EasyGameMode_button.Name = "EasyGameMode_button";
            this.EasyGameMode_button.Size = new System.Drawing.Size(75, 30);
            this.EasyGameMode_button.TabIndex = 53;
            this.EasyGameMode_button.Text = "Easy";
            this.EasyGameMode_button.UseVisualStyleBackColor = true;
            this.EasyGameMode_button.Visible = false;
            this.EasyGameMode_button.Click += new System.EventHandler(this.EasyGameMode_button_Click);
            // 
            // MediumGameMode_button
            // 
            this.MediumGameMode_button.AutoSize = true;
            this.MediumGameMode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumGameMode_button.Location = new System.Drawing.Point(464, 347);
            this.MediumGameMode_button.Name = "MediumGameMode_button";
            this.MediumGameMode_button.Size = new System.Drawing.Size(75, 30);
            this.MediumGameMode_button.TabIndex = 54;
            this.MediumGameMode_button.Text = "Medium";
            this.MediumGameMode_button.UseVisualStyleBackColor = true;
            this.MediumGameMode_button.Visible = false;
            this.MediumGameMode_button.Click += new System.EventHandler(this.MediumGameMode_button_Click);
            // 
            // HardGameMode_button
            // 
            this.HardGameMode_button.AutoSize = true;
            this.HardGameMode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardGameMode_button.Location = new System.Drawing.Point(464, 383);
            this.HardGameMode_button.Name = "HardGameMode_button";
            this.HardGameMode_button.Size = new System.Drawing.Size(75, 30);
            this.HardGameMode_button.TabIndex = 55;
            this.HardGameMode_button.Text = "Hard";
            this.HardGameMode_button.UseVisualStyleBackColor = true;
            this.HardGameMode_button.Visible = false;
            this.HardGameMode_button.Click += new System.EventHandler(this.HardGameMode_button_Click);
            // 
            // RandomGameMode_button
            // 
            this.RandomGameMode_button.AutoSize = true;
            this.RandomGameMode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomGameMode_button.Location = new System.Drawing.Point(461, 450);
            this.RandomGameMode_button.Name = "RandomGameMode_button";
            this.RandomGameMode_button.Size = new System.Drawing.Size(81, 30);
            this.RandomGameMode_button.TabIndex = 57;
            this.RandomGameMode_button.Text = "Random";
            this.RandomGameMode_button.UseVisualStyleBackColor = true;
            this.RandomGameMode_button.Visible = false;
            this.RandomGameMode_button.Click += new System.EventHandler(this.RandomGameMode_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1058, 792);
            this.Controls.Add(this.RandomGameMode_button);
            this.Controls.Add(this.HardGameMode_button);
            this.Controls.Add(this.MediumGameMode_button);
            this.Controls.Add(this.EasyGameMode_button);
            this.Controls.Add(this.GamersResults_button);
            this.Controls.Add(this.info_GoodLuck_label);
            this.Controls.Add(this.info_GameInstructions_label);
            this.Controls.Add(this.info_GameRules_label);
            this.Controls.Add(this.back_info_button);
            this.Controls.Add(this.info_GameControl_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Esc_continue_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.pbGround_SecondHalf);
            this.Controls.Add(this.pbGround_FirstHalf);
            this.Controls.Add(this.GameScore_Label);
            this.Controls.Add(this.GameOver_Label);
            this.Controls.Add(this.Restart_button);
            this.Controls.Add(this.Esc_menu_background);
            this.Controls.Add(this.pbWall1);
            this.Controls.Add(this.pbWall2);
            this.Controls.Add(this.pbWall3);
            this.Controls.Add(this.pbWall4);
            this.Controls.Add(this.pbWall5);
            this.Controls.Add(this.pbWall6);
            this.Controls.Add(this.pbWall7);
            this.Controls.Add(this.pbWall8);
            this.Controls.Add(this.pbWall9);
            this.Controls.Add(this.pbWall10);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.pbWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround_FirstHalf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround_SecondHalf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbWall1;
        private System.Windows.Forms.PictureBox pbWall8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbWall7;
        private System.Windows.Forms.PictureBox pbWall3;
        private System.Windows.Forms.PictureBox pbWall4;
        private System.Windows.Forms.PictureBox pbWall5;
        private System.Windows.Forms.PictureBox pbWall6;
        private System.Windows.Forms.PictureBox pbWall9;
        private System.Windows.Forms.PictureBox pbWall10;
        private System.Windows.Forms.PictureBox pbWall2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label GameOver_Label;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label GameScore_Label;
        private System.Windows.Forms.PictureBox pbGround_FirstHalf;
        private System.Windows.Forms.PictureBox pbGround_SecondHalf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button Esc_continue_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label Esc_menu_background;
        private System.Windows.Forms.Label info_GameControl_label;
        private System.Windows.Forms.Button back_info_button;
        private System.Windows.Forms.Label info_GameRules_label;
        private System.Windows.Forms.Label info_GameInstructions_label;
        private System.Windows.Forms.Label info_GoodLuck_label;
        private System.Windows.Forms.Button GamersResults_button;
        private System.Windows.Forms.Button EasyGameMode_button;
        private System.Windows.Forms.Button MediumGameMode_button;
        private System.Windows.Forms.Button HardGameMode_button;
        private System.Windows.Forms.Button RandomGameMode_button;
    }
}

