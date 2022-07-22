namespace pseudocolor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binFileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지프로세싱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그레이ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.하얀색선긋기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.알고리즘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모폴로지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도형검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코너검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenValToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobLabelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직선검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.캐니엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.김중환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엣지확장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halconOCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halconBlobDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baumerImageToMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cogDisplay2 = new Cognex.VisionPro.Display.CogDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_contourArea = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MinDistance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_HufThreshold = new System.Windows.Forms.TextBox();
            this.textBox_HistogramValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_CircleLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ErodeKernnelValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ErodeChangeValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_DilatateKernnelValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_DilatateChangeValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_MaxThreshold = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_MinThreshold = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_HoughLineAllowInterval = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_HoughThreshold = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_HoughLineMinLength = new System.Windows.Forms.TextBox();
            this.checkBox_LastDraw = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_BlobMinArea = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_MinWidthBlob = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_MinHeightBlob = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBoxIpl3 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label_BlobAngle = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_BlurParam = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_BinParam = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_CutCnt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl4 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_binThreshold = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_bnMaxValue = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBoxIpl2.Location = new System.Drawing.Point(822, 57);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxIpl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl2.TabIndex = 2;
            this.pictureBoxIpl2.TabStop = false;
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBoxIpl1.Location = new System.Drawing.Point(416, 57);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 11;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem,
            this.이미지프로세싱ToolStripMenuItem,
            this.알고리즘ToolStripMenuItem,
            this.도형검출ToolStripMenuItem,
            this.baumerImageToMatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageOpenToolStripMenuItem,
            this.imageSaveToolStripMenuItem,
            this.binFileOpenToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileOpenToolStripMenuItem.Text = "File";
            // 
            // imageOpenToolStripMenuItem
            // 
            this.imageOpenToolStripMenuItem.Name = "imageOpenToolStripMenuItem";
            this.imageOpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.imageOpenToolStripMenuItem.Text = "Image Open";
            this.imageOpenToolStripMenuItem.Click += new System.EventHandler(this.imageOpenToolStripMenuItem_Click);
            // 
            // imageSaveToolStripMenuItem
            // 
            this.imageSaveToolStripMenuItem.Name = "imageSaveToolStripMenuItem";
            this.imageSaveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.imageSaveToolStripMenuItem.Text = "Image Save";
            this.imageSaveToolStripMenuItem.Click += new System.EventHandler(this.imageSaveToolStripMenuItem_Click);
            // 
            // binFileOpenToolStripMenuItem
            // 
            this.binFileOpenToolStripMenuItem.Name = "binFileOpenToolStripMenuItem";
            this.binFileOpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.binFileOpenToolStripMenuItem.Text = "Bin File Open";
            this.binFileOpenToolStripMenuItem.Click += new System.EventHandler(this.binFileOpenToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.종료ToolStripMenuItem.Text = "Exit";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 이미지프로세싱ToolStripMenuItem
            // 
            this.이미지프로세싱ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그레이ToolStripMenuItem,
            this.흑백반전ToolStripMenuItem,
            this.하얀색선긋기ToolStripMenuItem});
            this.이미지프로세싱ToolStripMenuItem.Name = "이미지프로세싱ToolStripMenuItem";
            this.이미지프로세싱ToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.이미지프로세싱ToolStripMenuItem.Text = "이미지 프로세싱";
            // 
            // 그레이ToolStripMenuItem
            // 
            this.그레이ToolStripMenuItem.Name = "그레이ToolStripMenuItem";
            this.그레이ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.그레이ToolStripMenuItem.Text = "그레이";
            this.그레이ToolStripMenuItem.Click += new System.EventHandler(this.그레이ToolStripMenuItem_Click);
            // 
            // 흑백반전ToolStripMenuItem
            // 
            this.흑백반전ToolStripMenuItem.Name = "흑백반전ToolStripMenuItem";
            this.흑백반전ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.흑백반전ToolStripMenuItem.Text = "흑백반전";
            this.흑백반전ToolStripMenuItem.Click += new System.EventHandler(this.흑백반전ToolStripMenuItem_Click);
            // 
            // 하얀색선긋기ToolStripMenuItem
            // 
            this.하얀색선긋기ToolStripMenuItem.Name = "하얀색선긋기ToolStripMenuItem";
            this.하얀색선긋기ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.하얀색선긋기ToolStripMenuItem.Text = "하얀색 선 긋기";
            this.하얀색선긋기ToolStripMenuItem.Click += new System.EventHandler(this.하얀색선긋기ToolStripMenuItem_Click);
            // 
            // 알고리즘ToolStripMenuItem
            // 
            this.알고리즘ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모폴로지ToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.이진화ToolStripMenuItem});
            this.알고리즘ToolStripMenuItem.Name = "알고리즘ToolStripMenuItem";
            this.알고리즘ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.알고리즘ToolStripMenuItem.Text = "전처리";
            // 
            // 모폴로지ToolStripMenuItem
            // 
            this.모폴로지ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialteToolStripMenuItem,
            this.erodeToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradientToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem,
            this.연결ToolStripMenuItem});
            this.모폴로지ToolStripMenuItem.Name = "모폴로지ToolStripMenuItem";
            this.모폴로지ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.모폴로지ToolStripMenuItem.Text = "모폴로지";
            // 
            // dialteToolStripMenuItem
            // 
            this.dialteToolStripMenuItem.Name = "dialteToolStripMenuItem";
            this.dialteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.dialteToolStripMenuItem.Text = "Dialte";
            this.dialteToolStripMenuItem.Click += new System.EventHandler(this.dialteToolStripMenuItem_Click);
            // 
            // erodeToolStripMenuItem
            // 
            this.erodeToolStripMenuItem.Name = "erodeToolStripMenuItem";
            this.erodeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.erodeToolStripMenuItem.Text = "Erode";
            this.erodeToolStripMenuItem.Click += new System.EventHandler(this.erodeToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.gradientToolStripMenuItem.Text = "Gradient";
            this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.topHatToolStripMenuItem.Text = "TopHat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // blackHatToolStripMenuItem
            // 
            this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.blackHatToolStripMenuItem.Text = "BlackHat";
            this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
            // 
            // 연결ToolStripMenuItem
            // 
            this.연결ToolStripMenuItem.Name = "연결ToolStripMenuItem";
            this.연결ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.연결ToolStripMenuItem.Text = "연결";
            this.연결ToolStripMenuItem.Click += new System.EventHandler(this.연결ToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.이진화ToolStripMenuItem.Text = "이진화";
            this.이진화ToolStripMenuItem.Click += new System.EventHandler(this.이진화ToolStripMenuItem_Click);
            // 
            // 도형검출ToolStripMenuItem
            // 
            this.도형검출ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사각형검출ToolStripMenuItem,
            this.코너검출ToolStripMenuItem,
            this.blobLabelingToolStripMenuItem,
            this.원검출ToolStripMenuItem,
            this.직선검출ToolStripMenuItem,
            this.캐니엣지ToolStripMenuItem,
            this.사각형만들기ToolStripMenuItem,
            this.김중환ToolStripMenuItem,
            this.엣지확장ToolStripMenuItem,
            this.textDetectionToolStripMenuItem,
            this.halconOCRToolStripMenuItem,
            this.halconBlobDetectionToolStripMenuItem});
            this.도형검출ToolStripMenuItem.Name = "도형검출ToolStripMenuItem";
            this.도형검출ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.도형검출ToolStripMenuItem.Text = "알고리즘";
            // 
            // 사각형검출ToolStripMenuItem
            // 
            this.사각형검출ToolStripMenuItem.Name = "사각형검출ToolStripMenuItem";
            this.사각형검출ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.사각형검출ToolStripMenuItem.Text = "사각형 검출";
            this.사각형검출ToolStripMenuItem.Click += new System.EventHandler(this.사각형검출ToolStripMenuItem_Click);
            // 
            // 코너검출ToolStripMenuItem
            // 
            this.코너검출ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eigenValToolStripMenuItem,
            this.harrisToolStripMenuItem});
            this.코너검출ToolStripMenuItem.Name = "코너검출ToolStripMenuItem";
            this.코너검출ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.코너검출ToolStripMenuItem.Text = "코너 검출";
            // 
            // eigenValToolStripMenuItem
            // 
            this.eigenValToolStripMenuItem.Name = "eigenValToolStripMenuItem";
            this.eigenValToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.eigenValToolStripMenuItem.Text = "EigenVal";
            // 
            // harrisToolStripMenuItem
            // 
            this.harrisToolStripMenuItem.Name = "harrisToolStripMenuItem";
            this.harrisToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.harrisToolStripMenuItem.Text = "Harris";
            this.harrisToolStripMenuItem.Click += new System.EventHandler(this.harrisToolStripMenuItem_Click);
            // 
            // blobLabelingToolStripMenuItem
            // 
            this.blobLabelingToolStripMenuItem.Name = "blobLabelingToolStripMenuItem";
            this.blobLabelingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.blobLabelingToolStripMenuItem.Text = "Blob Labeling";
            this.blobLabelingToolStripMenuItem.Click += new System.EventHandler(this.blobLabelingToolStripMenuItem_Click);
            // 
            // 원검출ToolStripMenuItem
            // 
            this.원검출ToolStripMenuItem.Name = "원검출ToolStripMenuItem";
            this.원검출ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.원검출ToolStripMenuItem.Text = "원 검출";
            this.원검출ToolStripMenuItem.Click += new System.EventHandler(this.원검출ToolStripMenuItem_Click);
            // 
            // 직선검출ToolStripMenuItem
            // 
            this.직선검출ToolStripMenuItem.Name = "직선검출ToolStripMenuItem";
            this.직선검출ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.직선검출ToolStripMenuItem.Text = "직선 검출 - P";
            this.직선검출ToolStripMenuItem.Click += new System.EventHandler(this.직선검출ToolStripMenuItem_Click);
            // 
            // 캐니엣지ToolStripMenuItem
            // 
            this.캐니엣지ToolStripMenuItem.Name = "캐니엣지ToolStripMenuItem";
            this.캐니엣지ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.캐니엣지ToolStripMenuItem.Text = "캐니엣지";
            this.캐니엣지ToolStripMenuItem.Click += new System.EventHandler(this.캐니엣지ToolStripMenuItem_Click);
            // 
            // 사각형만들기ToolStripMenuItem
            // 
            this.사각형만들기ToolStripMenuItem.Name = "사각형만들기ToolStripMenuItem";
            this.사각형만들기ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.사각형만들기ToolStripMenuItem.Text = "사각형 만들기";
            this.사각형만들기ToolStripMenuItem.Click += new System.EventHandler(this.사각형만들기ToolStripMenuItem_Click);
            // 
            // 김중환ToolStripMenuItem
            // 
            this.김중환ToolStripMenuItem.Name = "김중환ToolStripMenuItem";
            this.김중환ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.김중환ToolStripMenuItem.Text = "김중환CJ";
            this.김중환ToolStripMenuItem.Click += new System.EventHandler(this.김중환ToolStripMenuItem_Click);
            // 
            // 엣지확장ToolStripMenuItem
            // 
            this.엣지확장ToolStripMenuItem.Name = "엣지확장ToolStripMenuItem";
            this.엣지확장ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.엣지확장ToolStripMenuItem.Text = "엣지 확장";
            this.엣지확장ToolStripMenuItem.Click += new System.EventHandler(this.엣지확장ToolStripMenuItem_Click);
            // 
            // textDetectionToolStripMenuItem
            // 
            this.textDetectionToolStripMenuItem.Name = "textDetectionToolStripMenuItem";
            this.textDetectionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.textDetectionToolStripMenuItem.Text = "Text Detection";
            this.textDetectionToolStripMenuItem.Click += new System.EventHandler(this.textDetectionToolStripMenuItem_Click);
            // 
            // halconOCRToolStripMenuItem
            // 
            this.halconOCRToolStripMenuItem.Name = "halconOCRToolStripMenuItem";
            this.halconOCRToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.halconOCRToolStripMenuItem.Text = "Halcon OCR";
            this.halconOCRToolStripMenuItem.Click += new System.EventHandler(this.halconOCRToolStripMenuItem_Click);
            // 
            // halconBlobDetectionToolStripMenuItem
            // 
            this.halconBlobDetectionToolStripMenuItem.Name = "halconBlobDetectionToolStripMenuItem";
            this.halconBlobDetectionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.halconBlobDetectionToolStripMenuItem.Text = "Halcon Blob Detection";
            this.halconBlobDetectionToolStripMenuItem.Click += new System.EventHandler(this.halconBlobDetectionToolStripMenuItem_Click);
            // 
            // baumerImageToMatToolStripMenuItem
            // 
            this.baumerImageToMatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem});
            this.baumerImageToMatToolStripMenuItem.Name = "baumerImageToMatToolStripMenuItem";
            this.baumerImageToMatToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.baumerImageToMatToolStripMenuItem.Text = "Baumer Image to Mat";
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.convertToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";
            // 
            // cogDisplay2
            // 
            this.cogDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay2.Location = new System.Drawing.Point(10, 57);
            this.cogDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay2.MouseWheelSensitivity = 1D;
            this.cogDisplay2.Name = "cogDisplay2";
            this.cogDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay2.OcxState")));
            this.cogDisplay2.Size = new System.Drawing.Size(400, 400);
            this.cogDisplay2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "입력 이미지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(576, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "입력 이미지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(980, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "출력 이미지";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 1014);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1224, 544);
            this.listBox1.TabIndex = 19;
            // 
            // textBox_contourArea
            // 
            this.textBox_contourArea.Location = new System.Drawing.Point(148, 17);
            this.textBox_contourArea.Name = "textBox_contourArea";
            this.textBox_contourArea.Size = new System.Drawing.Size(88, 21);
            this.textBox_contourArea.TabIndex = 20;
            this.textBox_contourArea.Text = "50000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 21);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0.02";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "원의 중심과 최소 거리";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MinDistance
            // 
            this.textBox_MinDistance.Location = new System.Drawing.Point(148, 18);
            this.textBox_MinDistance.Name = "textBox_MinDistance";
            this.textBox_MinDistance.Size = new System.Drawing.Size(88, 21);
            this.textBox_MinDistance.TabIndex = 23;
            this.textBox_MinDistance.Text = "15";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(49, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "허프 변환 임계값";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_HufThreshold
            // 
            this.textBox_HufThreshold.Location = new System.Drawing.Point(148, 44);
            this.textBox_HufThreshold.Name = "textBox_HufThreshold";
            this.textBox_HufThreshold.Size = new System.Drawing.Size(88, 21);
            this.textBox_HufThreshold.TabIndex = 25;
            this.textBox_HufThreshold.Text = "100";
            // 
            // textBox_HistogramValue
            // 
            this.textBox_HistogramValue.Location = new System.Drawing.Point(148, 71);
            this.textBox_HistogramValue.Name = "textBox_HistogramValue";
            this.textBox_HistogramValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_HistogramValue.TabIndex = 27;
            this.textBox_HistogramValue.Text = "12";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(77, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "중심 임계값";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_CircleLength
            // 
            this.textBox_CircleLength.Location = new System.Drawing.Point(148, 98);
            this.textBox_CircleLength.Name = "textBox_CircleLength";
            this.textBox_CircleLength.Size = new System.Drawing.Size(88, 21);
            this.textBox_CircleLength.TabIndex = 29;
            this.textBox_CircleLength.Text = "50";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(105, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "반지름";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ErodeKernnelValue
            // 
            this.textBox_ErodeKernnelValue.Location = new System.Drawing.Point(148, 44);
            this.textBox_ErodeKernnelValue.Name = "textBox_ErodeKernnelValue";
            this.textBox_ErodeKernnelValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_ErodeKernnelValue.TabIndex = 33;
            this.textBox_ErodeKernnelValue.Text = "2";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "Erode(침식) 커널 크기";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ErodeChangeValue
            // 
            this.textBox_ErodeChangeValue.Location = new System.Drawing.Point(148, 17);
            this.textBox_ErodeChangeValue.Name = "textBox_ErodeChangeValue";
            this.textBox_ErodeChangeValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_ErodeChangeValue.TabIndex = 31;
            this.textBox_ErodeChangeValue.Text = "15";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Erode(침식) 보정 변수";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DilatateKernnelValue
            // 
            this.textBox_DilatateKernnelValue.Location = new System.Drawing.Point(148, 42);
            this.textBox_DilatateKernnelValue.Name = "textBox_DilatateKernnelValue";
            this.textBox_DilatateKernnelValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_DilatateKernnelValue.TabIndex = 37;
            this.textBox_DilatateKernnelValue.Text = "2";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "Dilatate(팽창) 커널 크기";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DilatateChangeValue
            // 
            this.textBox_DilatateChangeValue.Location = new System.Drawing.Point(148, 15);
            this.textBox_DilatateChangeValue.Name = "textBox_DilatateChangeValue";
            this.textBox_DilatateChangeValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_DilatateChangeValue.TabIndex = 35;
            this.textBox_DilatateChangeValue.Text = "15";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(10, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Dilatate(팽창) 보정 변수";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "찾을 사각형 최소 영역";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox_MaxThreshold);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox_MinThreshold);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_contourArea);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1648, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 129);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canny Edge 관련 값";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(21, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 12);
            this.label18.TabIndex = 43;
            this.label18.Text = "최대 Threshold";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaxThreshold
            // 
            this.textBox_MaxThreshold.Location = new System.Drawing.Point(148, 98);
            this.textBox_MaxThreshold.Name = "textBox_MaxThreshold";
            this.textBox_MaxThreshold.Size = new System.Drawing.Size(88, 21);
            this.textBox_MaxThreshold.TabIndex = 42;
            this.textBox_MaxThreshold.Text = "200";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(21, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "최소 Threshold";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MinThreshold
            // 
            this.textBox_MinThreshold.Location = new System.Drawing.Point(148, 71);
            this.textBox_MinThreshold.Name = "textBox_MinThreshold";
            this.textBox_MinThreshold.Size = new System.Drawing.Size(88, 21);
            this.textBox_MinThreshold.TabIndex = 40;
            this.textBox_MinThreshold.Text = "75";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(21, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 39;
            this.label13.Text = "Canny 변수";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_MinDistance);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_HufThreshold);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_HistogramValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_CircleLength);
            this.groupBox2.Location = new System.Drawing.Point(1648, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 129);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "원형 찾기 관련 Param";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_DilatateChangeValue);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_DilatateKernnelValue);
            this.groupBox3.Location = new System.Drawing.Point(1648, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 70);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "모폴로지(팽창) 연산";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_ErodeChangeValue);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_ErodeKernnelValue);
            this.groupBox4.Location = new System.Drawing.Point(1648, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 70);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "모폴로지(침식) 연산";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBox_HoughLineAllowInterval);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox_HoughThreshold);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox_HoughLineMinLength);
            this.groupBox5.Location = new System.Drawing.Point(1648, 456);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 101);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HoughLineP Param";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(18, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "선의 허용간격";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_HoughLineAllowInterval
            // 
            this.textBox_HoughLineAllowInterval.Location = new System.Drawing.Point(148, 71);
            this.textBox_HoughLineAllowInterval.Name = "textBox_HoughLineAllowInterval";
            this.textBox_HoughLineAllowInterval.Size = new System.Drawing.Size(88, 21);
            this.textBox_HoughLineAllowInterval.TabIndex = 35;
            this.textBox_HoughLineAllowInterval.Text = "250";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(18, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "Threshold";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_HoughThreshold
            // 
            this.textBox_HoughThreshold.Location = new System.Drawing.Point(148, 17);
            this.textBox_HoughThreshold.Name = "textBox_HoughThreshold";
            this.textBox_HoughThreshold.Size = new System.Drawing.Size(88, 21);
            this.textBox_HoughThreshold.TabIndex = 31;
            this.textBox_HoughThreshold.Text = "40";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(18, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "최소 선의 길이";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_HoughLineMinLength
            // 
            this.textBox_HoughLineMinLength.Location = new System.Drawing.Point(148, 44);
            this.textBox_HoughLineMinLength.Name = "textBox_HoughLineMinLength";
            this.textBox_HoughLineMinLength.Size = new System.Drawing.Size(88, 21);
            this.textBox_HoughLineMinLength.TabIndex = 33;
            this.textBox_HoughLineMinLength.Text = "20";
            // 
            // checkBox_LastDraw
            // 
            this.checkBox_LastDraw.AutoSize = true;
            this.checkBox_LastDraw.Location = new System.Drawing.Point(10, 18);
            this.checkBox_LastDraw.Name = "checkBox_LastDraw";
            this.checkBox_LastDraw.Size = new System.Drawing.Size(100, 16);
            this.checkBox_LastDraw.TabIndex = 45;
            this.checkBox_LastDraw.Text = "마지막 그리기";
            this.checkBox_LastDraw.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(18, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 12);
            this.label19.TabIndex = 47;
            this.label19.Text = "찾을 Blob 최소 영역";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_BlobMinArea
            // 
            this.textBox_BlobMinArea.Location = new System.Drawing.Point(148, 41);
            this.textBox_BlobMinArea.Name = "textBox_BlobMinArea";
            this.textBox_BlobMinArea.Size = new System.Drawing.Size(88, 21);
            this.textBox_BlobMinArea.TabIndex = 46;
            this.textBox_BlobMinArea.Text = "200";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(18, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 12);
            this.label20.TabIndex = 49;
            this.label20.Text = "Blob 최소 Length";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MinWidthBlob
            // 
            this.textBox_MinWidthBlob.Location = new System.Drawing.Point(148, 68);
            this.textBox_MinWidthBlob.Name = "textBox_MinWidthBlob";
            this.textBox_MinWidthBlob.Size = new System.Drawing.Size(88, 21);
            this.textBox_MinWidthBlob.TabIndex = 48;
            this.textBox_MinWidthBlob.Text = "100";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(18, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 12);
            this.label21.TabIndex = 51;
            this.label21.Text = "Blob 최소 Width";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MinHeightBlob
            // 
            this.textBox_MinHeightBlob.Location = new System.Drawing.Point(148, 95);
            this.textBox_MinHeightBlob.Name = "textBox_MinHeightBlob";
            this.textBox_MinHeightBlob.Size = new System.Drawing.Size(88, 21);
            this.textBox_MinHeightBlob.TabIndex = 50;
            this.textBox_MinHeightBlob.Text = "100";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(1386, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 19);
            this.label22.TabIndex = 53;
            this.label22.Text = "Blob 이미지";
            // 
            // pictureBoxIpl3
            // 
            this.pictureBoxIpl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBoxIpl3.Location = new System.Drawing.Point(1228, 57);
            this.pictureBoxIpl3.Name = "pictureBoxIpl3";
            this.pictureBoxIpl3.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxIpl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl3.TabIndex = 52;
            this.pictureBoxIpl3.TabStop = false;
            // 
            // label_BlobAngle
            // 
            this.label_BlobAngle.AutoSize = true;
            this.label_BlobAngle.Location = new System.Drawing.Point(30, 131);
            this.label_BlobAngle.Name = "label_BlobAngle";
            this.label_BlobAngle.Size = new System.Drawing.Size(57, 12);
            this.label_BlobAngle.TabIndex = 54;
            this.label_BlobAngle.Text = "blob 각도";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(18, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 12);
            this.label23.TabIndex = 56;
            this.label23.Text = "Blur 파라미터";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_BlurParam
            // 
            this.textBox_BlurParam.Location = new System.Drawing.Point(148, 20);
            this.textBox_BlurParam.Name = "textBox_BlurParam";
            this.textBox_BlurParam.Size = new System.Drawing.Size(88, 21);
            this.textBox_BlurParam.TabIndex = 55;
            this.textBox_BlurParam.Text = "15";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(18, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 12);
            this.label24.TabIndex = 58;
            this.label24.Text = "Bin 파라미터";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_BinParam
            // 
            this.textBox_BinParam.Location = new System.Drawing.Point(148, 18);
            this.textBox_BinParam.Name = "textBox_BinParam";
            this.textBox_BinParam.Size = new System.Drawing.Size(88, 21);
            this.textBox_BinParam.TabIndex = 57;
            this.textBox_BinParam.Text = "1160942000";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(18, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 12);
            this.label25.TabIndex = 60;
            this.label25.Text = "Cut Count";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_CutCnt
            // 
            this.textBox_CutCnt.Location = new System.Drawing.Point(148, 45);
            this.textBox_CutCnt.Name = "textBox_CutCnt";
            this.textBox_CutCnt.Size = new System.Drawing.Size(88, 21);
            this.textBox_CutCnt.TabIndex = 59;
            this.textBox_CutCnt.Text = "300";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.checkBox_LastDraw);
            this.groupBox6.Controls.Add(this.textBox_BlobMinArea);
            this.groupBox6.Controls.Add(this.textBox_MinWidthBlob);
            this.groupBox6.Controls.Add(this.label_BlobAngle);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBox_MinHeightBlob);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Location = new System.Drawing.Point(1648, 562);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(244, 151);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBox_BinParam);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.textBox_CutCnt);
            this.groupBox7.Location = new System.Drawing.Point(1648, 719);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(244, 73);
            this.groupBox7.TabIndex = 62;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox_BlurParam);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Location = new System.Drawing.Point(1648, 798);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(244, 56);
            this.groupBox8.TabIndex = 63;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // pictureBoxIpl4
            // 
            this.pictureBoxIpl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBoxIpl4.Location = new System.Drawing.Point(10, 463);
            this.pictureBoxIpl4.Name = "pictureBoxIpl4";
            this.pictureBoxIpl4.Size = new System.Drawing.Size(1212, 545);
            this.pictureBoxIpl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl4.TabIndex = 64;
            this.pictureBoxIpl4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.pictureBox1.Location = new System.Drawing.Point(1228, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.textBox_binThreshold);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.textBox_bnMaxValue);
            this.groupBox9.Location = new System.Drawing.Point(1648, 860);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(244, 73);
            this.groupBox9.TabIndex = 66;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "이진화 Threshold";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(18, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 12);
            this.label26.TabIndex = 58;
            this.label26.Text = "Threshold";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_binThreshold
            // 
            this.textBox_binThreshold.Location = new System.Drawing.Point(148, 18);
            this.textBox_binThreshold.Name = "textBox_binThreshold";
            this.textBox_binThreshold.Size = new System.Drawing.Size(88, 21);
            this.textBox_binThreshold.TabIndex = 57;
            this.textBox_binThreshold.Text = "100";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(18, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 12);
            this.label27.TabIndex = 60;
            this.label27.Text = "Max Value";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_bnMaxValue
            // 
            this.textBox_bnMaxValue.Location = new System.Drawing.Point(148, 45);
            this.textBox_bnMaxValue.Name = "textBox_bnMaxValue";
            this.textBox_bnMaxValue.Size = new System.Drawing.Size(88, 21);
            this.textBox_bnMaxValue.TabIndex = 59;
            this.textBox_bnMaxValue.Text = "255";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1240, 1038);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(495, 45);
            this.trackBar1.TabIndex = 68;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1417, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 27);
            this.button1.TabIndex = 69;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1419, 791);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 31);
            this.button2.TabIndex = 70;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1904, 1561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxIpl4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBoxIpl3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cogDisplay2);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpencvTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay2;
        private System.Windows.Forms.ToolStripMenuItem 알고리즘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모폴로지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도형검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지프로세싱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그레이ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_contourArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 코너검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenValToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobLabelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원검출ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MinDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_HufThreshold;
        private System.Windows.Forms.TextBox textBox_HistogramValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CircleLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ErodeKernnelValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ErodeChangeValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_DilatateKernnelValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_DilatateChangeValue;
        private System.Windows.Forms.Label label11;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem 직선검출ToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_HoughLineAllowInterval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_HoughThreshold;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_HoughLineMinLength;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_MaxThreshold;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_MinThreshold;
        private System.Windows.Forms.ToolStripMenuItem 캐니엣지ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_LastDraw;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_BlobMinArea;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_MinWidthBlob;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_MinHeightBlob;
        private System.Windows.Forms.Label label22;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl3;
        private System.Windows.Forms.Label label_BlobAngle;
        private System.Windows.Forms.ToolStripMenuItem 하얀색선긋기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형만들기ToolStripMenuItem;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_BlurParam;
        private System.Windows.Forms.ToolStripMenuItem 김중환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엣지확장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binFileOpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_BinParam;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_CutCnt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl4;
        private System.Windows.Forms.ToolStripMenuItem textDetectionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem halconOCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halconBlobDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_binThreshold;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_bnMaxValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem baumerImageToMatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

