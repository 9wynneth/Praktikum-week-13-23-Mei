
namespace Praktikum_week_13_23_Mei
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBox_Nama = new System.Windows.Forms.TextBox();
            this.tBox_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.DTP_birthdate = new System.Windows.Forms.DateTimePicker();
            this.cBox_team = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cBox_nationality = new System.Windows.Forms.ComboBox();
            this.numericUpDownTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_captain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_Nama
            // 
            this.tBox_Nama.Location = new System.Drawing.Point(211, 162);
            this.tBox_Nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_Nama.Name = "tBox_Nama";
            this.tBox_Nama.Size = new System.Drawing.Size(250, 26);
            this.tBox_Nama.TabIndex = 76;
            // 
            // tBox_ID
            // 
            this.tBox_ID.Location = new System.Drawing.Point(211, 122);
            this.tBox_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_ID.Name = "tBox_ID";
            this.tBox_ID.Size = new System.Drawing.Size(148, 26);
            this.tBox_ID.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Team Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Player Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Player ID";
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(398, 32);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(91, 61);
            this.btn_Last.TabIndex = 68;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(285, 32);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(91, 61);
            this.btn_Next.TabIndex = 67;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(171, 32);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(91, 61);
            this.btn_Prev.TabIndex = 66;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(58, 32);
            this.btn_First.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(91, 61);
            this.btn_First.TabIndex = 65;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(58, 377);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(204, 34);
            this.btn_Save.TabIndex = 77;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(285, 377);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(204, 34);
            this.btn_Cancel.TabIndex = 78;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DTP_birthdate
            // 
            this.DTP_birthdate.CustomFormat = "dddd, MMMMdd,  yyyy";
            this.DTP_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_birthdate.Location = new System.Drawing.Point(211, 206);
            this.DTP_birthdate.Name = "DTP_birthdate";
            this.DTP_birthdate.Size = new System.Drawing.Size(296, 26);
            this.DTP_birthdate.TabIndex = 79;
            // 
            // cBox_team
            // 
            this.cBox_team.FormattingEnabled = true;
            this.cBox_team.Location = new System.Drawing.Point(211, 286);
            this.cBox_team.Name = "cBox_team";
            this.cBox_team.Size = new System.Drawing.Size(250, 28);
            this.cBox_team.TabIndex = 82;
            this.cBox_team.SelectedIndexChanged += new System.EventHandler(this.cBox_team_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(383, 333);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 20);
            this.lbl_status.TabIndex = 83;
            // 
            // cBox_nationality
            // 
            this.cBox_nationality.FormattingEnabled = true;
            this.cBox_nationality.Location = new System.Drawing.Point(211, 246);
            this.cBox_nationality.Name = "cBox_nationality";
            this.cBox_nationality.Size = new System.Drawing.Size(250, 28);
            this.cBox_nationality.TabIndex = 84;
            // 
            // numericUpDownTeamNumber
            // 
            this.numericUpDownTeamNumber.Location = new System.Drawing.Point(211, 328);
            this.numericUpDownTeamNumber.Name = "numericUpDownTeamNumber";
            this.numericUpDownTeamNumber.Size = new System.Drawing.Size(148, 26);
            this.numericUpDownTeamNumber.TabIndex = 85;
            this.numericUpDownTeamNumber.ValueChanged += new System.EventHandler(this.numericUpDownTeamNumber_ValueChanged);
            // 
            // lbl_captain
            // 
            this.lbl_captain.AutoSize = true;
            this.lbl_captain.Location = new System.Drawing.Point(414, 127);
            this.lbl_captain.Name = "lbl_captain";
            this.lbl_captain.Size = new System.Drawing.Size(51, 20);
            this.lbl_captain.TabIndex = 86;
            this.lbl_captain.Text = "label7";
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.lbl_captain);
            this.Controls.Add(this.numericUpDownTeamNumber);
            this.Controls.Add(this.cBox_nationality);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cBox_team);
            this.Controls.Add(this.DTP_birthdate);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tBox_Nama);
            this.Controls.Add(this.tBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_Nama;
        private System.Windows.Forms.TextBox tBox_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker DTP_birthdate;
        private System.Windows.Forms.ComboBox cBox_team;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cBox_nationality;
        private System.Windows.Forms.NumericUpDown numericUpDownTeamNumber;
        private System.Windows.Forms.Label lbl_captain;
    }
}

