
namespace PPOO0
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange16 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange17 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange18 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange19 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange20 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPresMin = new System.Windows.Forms.Label();
            this.lblPresMax = new System.Windows.Forms.Label();
            this.txtPresMin = new System.Windows.Forms.TextBox();
            this.txtPresMax = new System.Windows.Forms.TextBox();
            this.btnPresMin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(15, 14);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(439, 414);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Click += new System.EventHandler(this.gaugeControl1_Click);
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 427, 402);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1,
            this.arcScaleNeedleComponent2,
            this.arcScaleNeedleComponent3});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickCount = 6;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 5F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.Name = "scale1";
            arcScaleRange16.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightCoral");
            arcScaleRange16.EndThickness = 14F;
            arcScaleRange16.EndValue = 0.5F;
            arcScaleRange16.Name = "Range0";
            arcScaleRange16.ShapeOffset = 0F;
            arcScaleRange16.StartThickness = 14F;
            arcScaleRange17.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D");
            arcScaleRange17.EndThickness = 14F;
            arcScaleRange17.EndValue = 0.6F;
            arcScaleRange17.Name = "Range1";
            arcScaleRange17.ShapeOffset = 0F;
            arcScaleRange17.StartThickness = 14F;
            arcScaleRange17.StartValue = 0.5F;
            arcScaleRange18.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75");
            arcScaleRange18.EndThickness = 14F;
            arcScaleRange18.EndValue = 5F;
            arcScaleRange18.Name = "Range2";
            arcScaleRange18.ShapeOffset = 0F;
            arcScaleRange18.StartThickness = 14F;
            arcScaleRange18.StartValue = 4F;
            arcScaleRange19.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LimeGreen");
            arcScaleRange19.EndThickness = 14F;
            arcScaleRange19.EndValue = 3F;
            arcScaleRange19.Name = "Range3";
            arcScaleRange19.ShapeOffset = 0F;
            arcScaleRange19.StartThickness = 14F;
            arcScaleRange19.StartValue = 0.6F;
            arcScaleRange20.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gold");
            arcScaleRange20.EndThickness = 14F;
            arcScaleRange20.EndValue = 4F;
            arcScaleRange20.Name = "Range4";
            arcScaleRange20.ShapeOffset = 0F;
            arcScaleRange20.StartThickness = 14F;
            arcScaleRange20.StartValue = 3F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange16,
            arcScaleRange17,
            arcScaleRange18,
            arcScaleRange19,
            arcScaleRange20});
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 5F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 5F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent1.Value = 4F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent2.EndOffset = 5F;
            this.arcScaleNeedleComponent2.Name = "needleMin";
            this.arcScaleNeedleComponent2.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Lavender;Style2:LightSeaGreen]");
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10;
            this.arcScaleNeedleComponent2.Value = 1F;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent3.EndOffset = 5F;
            this.arcScaleNeedleComponent3.Name = "needleMax";
            this.arcScaleNeedleComponent3.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Lavender;Style2:#C04000]");
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10;
            this.arcScaleNeedleComponent3.Value = 2F;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(28F, 28F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(524, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "verificare LED";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPresMin
            // 
            this.lblPresMin.AutoSize = true;
            this.lblPresMin.Location = new System.Drawing.Point(503, 95);
            this.lblPresMin.Name = "lblPresMin";
            this.lblPresMin.Size = new System.Drawing.Size(116, 13);
            this.lblPresMin.TabIndex = 2;
            this.lblPresMin.Text = "Setare presiune minima";
            // 
            // lblPresMax
            // 
            this.lblPresMax.AutoSize = true;
            this.lblPresMax.Location = new System.Drawing.Point(503, 185);
            this.lblPresMax.Name = "lblPresMax";
            this.lblPresMax.Size = new System.Drawing.Size(119, 13);
            this.lblPresMax.TabIndex = 3;
            this.lblPresMax.Text = "Setare presiune maxima";
            // 
            // txtPresMin
            // 
            this.txtPresMin.Location = new System.Drawing.Point(625, 95);
            this.txtPresMin.Name = "txtPresMin";
            this.txtPresMin.Size = new System.Drawing.Size(102, 20);
            this.txtPresMin.TabIndex = 4;
            // 
            // txtPresMax
            // 
            this.txtPresMax.Location = new System.Drawing.Point(628, 182);
            this.txtPresMax.Name = "txtPresMax";
            this.txtPresMax.Size = new System.Drawing.Size(96, 20);
            this.txtPresMax.TabIndex = 5;
            // 
            // btnPresMin
            // 
            this.btnPresMin.Location = new System.Drawing.Point(506, 129);
            this.btnPresMin.Name = "btnPresMin";
            this.btnPresMin.Size = new System.Drawing.Size(221, 25);
            this.btnPresMin.TabIndex = 6;
            this.btnPresMin.Text = "Modifica presiunea minima";
            this.btnPresMin.UseVisualStyleBackColor = true;
            this.btnPresMin.Click += new System.EventHandler(this.btnPresMin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modifica presiunea maxima";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPresMin);
            this.Controls.Add(this.txtPresMax);
            this.Controls.Add(this.txtPresMin);
            this.Controls.Add(this.lblPresMax);
            this.Controls.Add(this.lblPresMin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "Proiect POO";
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPresMin;
        private System.Windows.Forms.Label lblPresMax;
        private System.Windows.Forms.TextBox txtPresMin;
        private System.Windows.Forms.TextBox txtPresMax;
        private System.Windows.Forms.Button btnPresMin;
        private System.Windows.Forms.Button button2;
    }
}

