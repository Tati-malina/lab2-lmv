

namespace Laboratory_work_1_2
{
    public partial class Form1 
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.buttonDefaultMessage = new System.Windows.Forms.Button();
            this.buttonClearMessage = new System.Windows.Forms.Button();
            this.comboBoxChooseProgram = new System.Windows.Forms.ComboBox();
            this.labelRunAProgram = new System.Windows.Forms.Label();
            this.buttonRunAProgram = new System.Windows.Forms.Button();
            this.groupBoxEnable = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableProgram = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMessage = new System.Windows.Forms.CheckBox();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.checkBoxShowProgram = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMessage = new System.Windows.Forms.CheckBox();
            this.buttonGet_Text = new System.Windows.Forms.Button();
            this.textBoxExtraName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtraPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxEnable.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(406, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Exit);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(44, 50);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(188, 32);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Enter a message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(258, 47);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(354, 43);
            this.textBoxMessage.TabIndex = 2;
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.AutoSize = true;
            this.buttonShowMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonShowMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowMessage.Location = new System.Drawing.Point(630, 48);
            this.buttonShowMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(182, 42);
            this.buttonShowMessage.TabIndex = 3;
            this.buttonShowMessage.Text = "Show message";
            this.buttonShowMessage.UseVisualStyleBackColor = false;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // buttonDefaultMessage
            // 
            this.buttonDefaultMessage.AutoSize = true;
            this.buttonDefaultMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDefaultMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDefaultMessage.Location = new System.Drawing.Point(110, 124);
            this.buttonDefaultMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDefaultMessage.Name = "buttonDefaultMessage";
            this.buttonDefaultMessage.Size = new System.Drawing.Size(203, 42);
            this.buttonDefaultMessage.TabIndex = 4;
            this.buttonDefaultMessage.Text = "Default Message";
            this.buttonDefaultMessage.UseVisualStyleBackColor = false;
            this.buttonDefaultMessage.Click += new System.EventHandler(this.buttonDefaultMessage_Click);
            // 
            // buttonClearMessage
            // 
            this.buttonClearMessage.AutoSize = true;
            this.buttonClearMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClearMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearMessage.Location = new System.Drawing.Point(559, 124);
            this.buttonClearMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearMessage.Name = "buttonClearMessage";
            this.buttonClearMessage.Size = new System.Drawing.Size(179, 42);
            this.buttonClearMessage.TabIndex = 5;
            this.buttonClearMessage.Text = "Clear Message";
            this.buttonClearMessage.UseVisualStyleBackColor = false;
            this.buttonClearMessage.Click += new System.EventHandler(this.buttonClearMessage_Click);
            // 
            // comboBoxChooseProgram
            // 
            this.comboBoxChooseProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseProgram.FormattingEnabled = true;
            this.comboBoxChooseProgram.Items.AddRange(new object[] {
            "Блокнот",
            "Калькулятор",
            "Paint",
            "Панель управления",
            "Командная строка"});
            this.comboBoxChooseProgram.Location = new System.Drawing.Point(258, 316);
            this.comboBoxChooseProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxChooseProgram.Name = "comboBoxChooseProgram";
            this.comboBoxChooseProgram.Size = new System.Drawing.Size(354, 39);
            this.comboBoxChooseProgram.TabIndex = 6;
            this.comboBoxChooseProgram.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProgram_SelectedIndexChanged);
            // 
            // labelRunAProgram
            // 
            this.labelRunAProgram.AutoSize = true;
            this.labelRunAProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRunAProgram.Location = new System.Drawing.Point(81, 320);
            this.labelRunAProgram.Name = "labelRunAProgram";
            this.labelRunAProgram.Size = new System.Drawing.Size(173, 32);
            this.labelRunAProgram.TabIndex = 7;
            this.labelRunAProgram.Text = "Run a program";
            this.labelRunAProgram.Click += new System.EventHandler(this.labelRunAProgram_Click);
            // 
            // buttonRunAProgram
            // 
            this.buttonRunAProgram.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRunAProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRunAProgram.Location = new System.Drawing.Point(630, 311);
            this.buttonRunAProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRunAProgram.Name = "buttonRunAProgram";
            this.buttonRunAProgram.Size = new System.Drawing.Size(184, 49);
            this.buttonRunAProgram.TabIndex = 8;
            this.buttonRunAProgram.Text = "Run a program";
            this.buttonRunAProgram.UseVisualStyleBackColor = false;
            this.buttonRunAProgram.Click += new System.EventHandler(this.buttonRunAProgram_Click);
            // 
            // groupBoxEnable
            // 
            this.groupBoxEnable.Controls.Add(this.checkBoxEnableProgram);
            this.groupBoxEnable.Controls.Add(this.checkBoxEnableMessage);
            this.groupBoxEnable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEnable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxEnable.Location = new System.Drawing.Point(139, 403);
            this.groupBoxEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEnable.Name = "groupBoxEnable";
            this.groupBoxEnable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEnable.Size = new System.Drawing.Size(233, 117);
            this.groupBoxEnable.TabIndex = 9;
            this.groupBoxEnable.TabStop = false;
            this.groupBoxEnable.Text = "Enable Actions";
            this.groupBoxEnable.Enter += new System.EventHandler(this.groupBoxEnable_Enter);
            // 
            // checkBoxEnableProgram
            // 
            this.checkBoxEnableProgram.AutoSize = true;
            this.checkBoxEnableProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnableProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableProgram.Location = new System.Drawing.Point(7, 76);
            this.checkBoxEnableProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxEnableProgram.Name = "checkBoxEnableProgram";
            this.checkBoxEnableProgram.Size = new System.Drawing.Size(235, 32);
            this.checkBoxEnableProgram.TabIndex = 1;
            this.checkBoxEnableProgram.Text = "Enable Program Action";
            this.checkBoxEnableProgram.UseVisualStyleBackColor = true;
            this.checkBoxEnableProgram.CheckedChanged += new System.EventHandler(this.checkBoxEnableProgram_CheckedChanged);
            // 
            // checkBoxEnableMessage
            // 
            this.checkBoxEnableMessage.AutoSize = true;
            this.checkBoxEnableMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnableMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableMessage.Location = new System.Drawing.Point(7, 37);
            this.checkBoxEnableMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxEnableMessage.Name = "checkBoxEnableMessage";
            this.checkBoxEnableMessage.Size = new System.Drawing.Size(235, 32);
            this.checkBoxEnableMessage.TabIndex = 0;
            this.checkBoxEnableMessage.Text = "Enable Message Action";
            this.checkBoxEnableMessage.UseVisualStyleBackColor = true;
            this.checkBoxEnableMessage.CheckedChanged += new System.EventHandler(this.checkBoxEnableMessage_CheckedChanged);
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.checkBoxShowProgram);
            this.groupBoxShow.Controls.Add(this.checkBoxShowMessage);
            this.groupBoxShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxShow.Location = new System.Drawing.Point(601, 403);
            this.groupBoxShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxShow.Size = new System.Drawing.Size(211, 117);
            this.groupBoxShow.TabIndex = 10;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Show Actions";
            this.groupBoxShow.Enter += new System.EventHandler(this.groupBoxShow_Enter);
            // 
            // checkBoxShowProgram
            // 
            this.checkBoxShowProgram.AutoSize = true;
            this.checkBoxShowProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxShowProgram.Location = new System.Drawing.Point(8, 83);
            this.checkBoxShowProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShowProgram.Name = "checkBoxShowProgram";
            this.checkBoxShowProgram.Size = new System.Drawing.Size(225, 32);
            this.checkBoxShowProgram.TabIndex = 1;
            this.checkBoxShowProgram.Text = "Show Program Action";
            this.checkBoxShowProgram.UseVisualStyleBackColor = true;
            this.checkBoxShowProgram.CheckedChanged += new System.EventHandler(this.checkBoxShowProgram_CheckedChanged);
            // 
            // checkBoxShowMessage
            // 
            this.checkBoxShowMessage.AutoSize = true;
            this.checkBoxShowMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxShowMessage.Location = new System.Drawing.Point(8, 44);
            this.checkBoxShowMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShowMessage.Name = "checkBoxShowMessage";
            this.checkBoxShowMessage.Size = new System.Drawing.Size(225, 32);
            this.checkBoxShowMessage.TabIndex = 0;
            this.checkBoxShowMessage.Text = "Show Message Action";
            this.checkBoxShowMessage.UseVisualStyleBackColor = true;
            this.checkBoxShowMessage.CheckedChanged += new System.EventHandler(this.checkBoxShowMessage_CheckedChanged);
            // 
            // buttonGet_Text
            // 
            this.buttonGet_Text.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGet_Text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGet_Text.Location = new System.Drawing.Point(367, 123);
            this.buttonGet_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGet_Text.Name = "buttonGet_Text";
            this.buttonGet_Text.Size = new System.Drawing.Size(155, 45);
            this.buttonGet_Text.TabIndex = 11;
            this.buttonGet_Text.Text = "Get text";
            this.buttonGet_Text.UseVisualStyleBackColor = false;
            this.buttonGet_Text.Click += new System.EventHandler(this.buttonGet_Text_Click);
            // 
            // textBoxExtraName
            // 
            this.textBoxExtraName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExtraName.Location = new System.Drawing.Point(188, 225);
            this.textBoxExtraName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExtraName.Multiline = true;
            this.textBoxExtraName.Name = "textBoxExtraName";
            this.textBoxExtraName.Size = new System.Drawing.Size(193, 52);
            this.textBoxExtraName.TabIndex = 12;
            this.textBoxExtraName.TextChanged += new System.EventHandler(this.textBoxExtraName_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name of the program";
            // 
            // textBoxExtraPath
            // 
            this.textBoxExtraPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExtraPath.Location = new System.Drawing.Point(483, 228);
            this.textBoxExtraPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExtraPath.Multiline = true;
            this.textBoxExtraPath.Name = "textBoxExtraPath";
            this.textBoxExtraPath.Size = new System.Drawing.Size(193, 52);
            this.textBoxExtraPath.TabIndex = 14;
            this.textBoxExtraPath.TextChanged += new System.EventHandler(this.textBoxExtraPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(406, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Path";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(694, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Run the program";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonRunExtraProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxExtraPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExtraName);
            this.Controls.Add(this.buttonGet_Text);
            this.Controls.Add(this.groupBoxEnable);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.buttonRunAProgram);
            this.Controls.Add(this.labelRunAProgram);
            this.Controls.Add(this.comboBoxChooseProgram);
            this.Controls.Add(this.buttonClearMessage);
            this.Controls.Add(this.buttonDefaultMessage);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEnable.ResumeLayout(false);
            this.groupBoxEnable.PerformLayout();
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Button buttonDefaultMessage;
        private System.Windows.Forms.Button buttonClearMessage;
        private System.Windows.Forms.ComboBox comboBoxChooseProgram;
        private System.Windows.Forms.Label labelRunAProgram;
        private System.Windows.Forms.Button buttonRunAProgram;
        private System.Windows.Forms.GroupBox groupBoxEnable;
        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.CheckBox checkBoxEnableProgram;
        private System.Windows.Forms.CheckBox checkBoxEnableMessage;
        private System.Windows.Forms.CheckBox checkBoxShowProgram;
        private System.Windows.Forms.CheckBox checkBoxShowMessage;
        private System.Windows.Forms.Button buttonGet_Text;
        private System.Windows.Forms.TextBox textBoxExtraName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtraPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

