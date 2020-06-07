namespace Students
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.IdStudent = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ProfilePhoto = new System.Windows.Forms.GroupBox();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelStudentInfo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBoxSerch = new System.Windows.Forms.TextBox();
            this.labelSerch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ProfilePhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.pictureLogo);
            this.groupBox1.Controls.Add(this.labelHeader);
            this.groupBox1.Location = new System.Drawing.Point(-1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.White;
            this.pictureLogo.Image = global::Students.Properties.Resources.universidades;
            this.pictureLogo.Location = new System.Drawing.Point(23, 15);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(65, 65);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(296, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(239, 34);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Student System";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.IdStudent);
            this.groupBox2.Controls.Add(this.TextBoxLastName);
            this.groupBox2.Controls.Add(this.TextBoxName);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.ProfilePhoto);
            this.groupBox2.Controls.Add(this.labelStudentInfo);
            this.groupBox2.Location = new System.Drawing.Point(-1, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Navy;
            this.buttonCancel.BackgroundImage = global::Students.Properties.Resources.baseline_clear_white_24dp;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(230, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Navy;
            this.buttonDelete.BackgroundImage = global::Students.Properties.Resources.baseline_remove_white_24dp;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(126, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 30);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::Students.Properties.Resources.baseline_add_white_24dp;
            this.buttonAdd.Location = new System.Drawing.Point(23, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 30);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Navy;
            this.labelEmail.Location = new System.Drawing.Point(176, 231);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(178, 250);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(145, 23);
            this.Email.TabIndex = 5;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_KeyPress);
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Navy;
            this.labelId.Location = new System.Drawing.Point(15, 187);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(88, 18);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "Student Id";
            this.labelId.Click += new System.EventHandler(this.label7_Click);
            // 
            // IdStudent
            // 
            this.IdStudent.Location = new System.Drawing.Point(18, 208);
            this.IdStudent.Multiline = true;
            this.IdStudent.Name = "IdStudent";
            this.IdStudent.Size = new System.Drawing.Size(145, 23);
            this.IdStudent.TabIndex = 2;
            this.IdStudent.TextChanged += new System.EventHandler(this.IdStudent_TextChanged);
            this.IdStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdStudent_KeyPress);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLastName.Location = new System.Drawing.Point(18, 250);
            this.TextBoxLastName.Multiline = true;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(145, 23);
            this.TextBoxLastName.TabIndex = 4;
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            this.TextBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLastName_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(178, 208);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(145, 23);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.Navy;
            this.labelLastName.Location = new System.Drawing.Point(15, 231);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 18);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Navy;
            this.labelName.Location = new System.Drawing.Point(176, 189);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 18);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // ProfilePhoto
            // 
            this.ProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePhoto.Controls.Add(this.PictureBoxPhoto);
            this.ProfilePhoto.Location = new System.Drawing.Point(93, 31);
            this.ProfilePhoto.Name = "ProfilePhoto";
            this.ProfilePhoto.Size = new System.Drawing.Size(157, 157);
            this.ProfilePhoto.TabIndex = 1;
            this.ProfilePhoto.TabStop = false;
            this.ProfilePhoto.Enter += new System.EventHandler(this.ProfilePhoto_Enter);
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Image = global::Students.Properties.Resources.llama_animal;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(14, 15);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(130, 130);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPhoto.TabIndex = 0;
            this.PictureBoxPhoto.TabStop = false;
            this.PictureBoxPhoto.Click += new System.EventHandler(this.PictureBoxPhoto_Click);
            // 
            // labelStudentInfo
            // 
            this.labelStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentInfo.AutoSize = true;
            this.labelStudentInfo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentInfo.ForeColor = System.Drawing.Color.Navy;
            this.labelStudentInfo.Location = new System.Drawing.Point(91, 10);
            this.labelStudentInfo.Name = "labelStudentInfo";
            this.labelStudentInfo.Size = new System.Drawing.Size(160, 18);
            this.labelStudentInfo.TabIndex = 0;
            this.labelStudentInfo.Text = "Student Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.labelStudentList);
            this.groupBox3.Location = new System.Drawing.Point(346, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 383);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // labelStudentList
            // 
            this.labelStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentList.ForeColor = System.Drawing.Color.Navy;
            this.labelStudentList.Location = new System.Drawing.Point(199, 10);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(104, 18);
            this.labelStudentList.TabIndex = 1;
            this.labelStudentList.Text = "Student List";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.TextBoxSerch);
            this.groupBox4.Controls.Add(this.labelSerch);
            this.groupBox4.Location = new System.Drawing.Point(-1, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(846, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // TextBoxSerch
            // 
            this.TextBoxSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSerch.Location = new System.Drawing.Point(499, 19);
            this.TextBoxSerch.Multiline = true;
            this.TextBoxSerch.Name = "TextBoxSerch";
            this.TextBoxSerch.Size = new System.Drawing.Size(208, 23);
            this.TextBoxSerch.TabIndex = 1;
            this.TextBoxSerch.TextChanged += new System.EventHandler(this.TextBoxSerch_TextChanged);
            this.TextBoxSerch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSerch_KeyPress);
            // 
            // labelSerch
            // 
            this.labelSerch.AutoSize = true;
            this.labelSerch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerch.ForeColor = System.Drawing.Color.Navy;
            this.labelSerch.Location = new System.Drawing.Point(433, 20);
            this.labelSerch.Name = "labelSerch";
            this.labelSerch.Size = new System.Drawing.Size(60, 22);
            this.labelSerch.TabIndex = 0;
            this.labelSerch.Text = "Serch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student systems";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ProfilePhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSerch;
        private System.Windows.Forms.Label labelStudentInfo;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.GroupBox ProfilePhoto;
        private System.Windows.Forms.TextBox TextBoxSerch;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox IdStudent;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox PictureBoxPhoto;
    }
}
