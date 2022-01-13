namespace WindowsFormsApp8
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 29F);
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. 텍스트 파일 처리";
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(59, 85);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(148, 103);
            this.BtnFile.TabIndex = 1;
            this.BtnFile.Text = "File 클래스";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // BtnStream
            // 
            this.BtnStream.Location = new System.Drawing.Point(59, 222);
            this.BtnStream.Name = "BtnStream";
            this.BtnStream.Size = new System.Drawing.Size(148, 108);
            this.BtnStream.TabIndex = 2;
            this.BtnStream.Text = "StreamReader, StreamWriter 클래스";
            this.BtnStream.UseVisualStyleBackColor = true;
            this.BtnStream.Click += new System.EventHandler(this.BtnStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStream);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtnStream;
    }
}

