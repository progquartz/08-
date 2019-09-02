namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblpct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(272, 111);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(219, 83);
            this.btncopy.TabIndex = 0;
            this.btncopy.Text = "파일 복사 시작";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(109, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(552, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblpct
            // 
            this.lblpct.AutoSize = true;
            this.lblpct.Location = new System.Drawing.Point(358, 413);
            this.lblpct.Name = "lblpct";
            this.lblpct.Size = new System.Drawing.Size(26, 15);
            this.lblpct.TabIndex = 2;
            this.lblpct.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 525);
            this.Controls.Add(this.lblpct);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btncopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncopy;
        internal System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.Label lblpct;
    }
}

