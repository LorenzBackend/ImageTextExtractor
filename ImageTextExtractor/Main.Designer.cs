namespace ImageTextExtractor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOpen = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(279, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(134, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Browse Image";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.SelectImage);
            // 
            // imgPreview
            // 
            this.imgPreview.Image = global::ImageTextExtractor.Properties.Resources.image_placeholder;
            this.imgPreview.Location = new System.Drawing.Point(12, 12);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(53, 48);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 1;
            this.imgPreview.TabStop = false;
            this.imgPreview.Click += new System.EventHandler(this.SelectImage);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Image Name";
            this.lblName.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(74, 37);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(199, 16);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Image Name";
            this.lblPath.Visible = false;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(12, 77);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(401, 127);
            this.textOutput.TabIndex = 4;
            this.textOutput.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(316, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(213, 210);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(97, 26);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.DimGray;
            this.lblProgress.Location = new System.Drawing.Point(12, 214);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(144, 16);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Text = "Please Wait..";
            this.lblProgress.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 248);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageTextExtractor";
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.RichTextBox textOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lblProgress;
    }
}

