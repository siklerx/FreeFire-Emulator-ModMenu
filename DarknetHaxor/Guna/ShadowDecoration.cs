using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace AimBotConquer.Guna {
    // Token: 0x0200010C RID: 268
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("ShadowDecoration")]
    public class ShadowDecoration {
        // Token: 0x170005BA RID: 1466
        // (get) Token: 0x06001348 RID: 4936 RVA: 0x00059B08 File Offset: 0x00057D08
        // (set) Token: 0x06001349 RID: 4937 RVA: 0x00059B1C File Offset: 0x00057D1C
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Control Parent {
            get {
                return this.J3BnI0lbjggojq2wUZouY3aZH4f;
            }
            set {
                if (this.J3BnI0lbjggojq2wUZouY3aZH4f != value) {
                    if (this.J3BnI0lbjggojq2wUZouY3aZH4f != null) {
                        this.J3BnI0lbjggojq2wUZouY3aZH4f.VisibleChanged -= this.hV94cVaEjj2sDKgPdxobdwgXf3o;
                    }
                    this.J3BnI0lbjggojq2wUZouY3aZH4f = value;
                    if (this.J3BnI0lbjggojq2wUZouY3aZH4f != null) {
                        this.J3BnI0lbjggojq2wUZouY3aZH4f.VisibleChanged += this.hV94cVaEjj2sDKgPdxobdwgXf3o;
                    }
                }
            }
        }

        // Token: 0x0600134A RID: 4938 RVA: 0x00059B78 File Offset: 0x00057D78
        internal void Ts4yq7LqhZIiuthWW98suMWsPzg(int A_1) {
            this.DsoqPTFrGYH4iDwoVeXdSLDeXhK = A_1;
            if (this.DsoqPTFrGYH4iDwoVeXdSLDeXhK > 0 && this.Parent != null && this.OB02FP6bhYTLsbV62KURE40P9Bt && this.Parent.BackColor != Color.Transparent) {
                this.Parent.BackColor = Color.Transparent;
            }
        }

        // Token: 0x0600134B RID: 4939 RVA: 0x00059BCC File Offset: 0x00057DCC
        internal void VKyccgKSRgEEE6bWxqjAzv1oFMJ(PaintValueEventArgs A_1) {
            if (this.Enabled) {
                A_1.Graphics.FillRectangle(new SolidBrush(this.KlEnha1KiANaUxccLujJt5XaGYfA), A_1.Bounds);
            }
        }

        // Token: 0x0600134C RID: 4940 RVA: 0x00059C00 File Offset: 0x00057E00
        public ShadowDecoration(IControl A_1) {
            this.KlEnha1KiANaUxccLujJt5XaGYfA = Color.Black;
            this.XhvVDouKOZ3aw5r4RVAiHzo49IB = 30;
            this.BG8RkRXrr1keSwf4gLsoWQnX95d = new Padding(5);
            this.bnNDAe51VzPIUaemAavSNKLcfqT = 6;
            this.CLvZxCPc3oehVRPwun5pd5Dnsd = false;
            this.Parent = (Control)A_1;
            this.Parent.Invalidate();
        }

        // Token: 0x170005BB RID: 1467
        // (get) Token: 0x0600134D RID: 4941 RVA: 0x00059C64 File Offset: 0x00057E64
        // (set) Token: 0x0600134E RID: 4942 RVA: 0x00059C78 File Offset: 0x00057E78
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Style the control's border sides.")]
        public virtual CustomizableEdges CustomizableEdges {
            get {
                return this.X0WGfXDFJwYbtLhO9tQAwnN8O3;
            }
            set {
                if (this.X0WGfXDFJwYbtLhO9tQAwnN8O3 != value) {
                    this.X0WGfXDFJwYbtLhO9tQAwnN8O3 = value;
                    this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
                }
            }
        }

        // Token: 0x170005BC RID: 1468
        // (get) Token: 0x0600134F RID: 4943 RVA: 0x00059C9C File Offset: 0x00057E9C
        // (set) Token: 0x06001350 RID: 4944 RVA: 0x00059CB0 File Offset: 0x00057EB0
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Description("If true, the shadow decoration will be enabled")]
        public bool Enabled {
            get {
                return this.OB02FP6bhYTLsbV62KURE40P9Bt;
            }
            set {
                if (this.OB02FP6bhYTLsbV62KURE40P9Bt != value) {
                    this.OB02FP6bhYTLsbV62KURE40P9Bt = value;
                    if (this.DsoqPTFrGYH4iDwoVeXdSLDeXhK > 0 && this.Parent != null && this.OB02FP6bhYTLsbV62KURE40P9Bt && this.Parent.BackColor != Color.Transparent) {
                        this.Parent.BackColor = Color.Transparent;
                    }
                    if (this.GjCmpVWY14rLa9hnUbVh6kd6n0f == null) {
                        new Thread(new ThreadStart(this.eADcckhTjlvygro60ghzA7tD7lq)).Start();
                    } else {
                        this.XrQVrcOAy09VyITF6fJRbHYPWSF(this.OB02FP6bhYTLsbV62KURE40P9Bt);
                    }
                }
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x170005BD RID: 1469
        // (get) Token: 0x06001351 RID: 4945 RVA: 0x00059D40 File Offset: 0x00057F40
        // (set) Token: 0x06001352 RID: 4946 RVA: 0x00059D54 File Offset: 0x00057F54
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(ShadowMode.Custom)]
        [Description("The shadow decoration mode")]
        public ShadowMode Mode {
            get {
                return this.nd7veED6faDh1yXqsD1kGxDZRY;
            }
            set {
                this.nd7veED6faDh1yXqsD1kGxDZRY = value;
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x170005BE RID: 1470
        // (get) Token: 0x06001353 RID: 4947 RVA: 0x00059D70 File Offset: 0x00057F70
        // (set) Token: 0x06001354 RID: 4948 RVA: 0x00059D84 File Offset: 0x00057F84
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(typeof(Color), "Black")]
        [Description("The shadow decoration color")]
        public Color Color {
            get {
                return this.KlEnha1KiANaUxccLujJt5XaGYfA;
            }
            set {
                this.KlEnha1KiANaUxccLujJt5XaGYfA = value;
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x170005BF RID: 1471
        // (get) Token: 0x06001355 RID: 4949 RVA: 0x00059DA0 File Offset: 0x00057FA0
        // (set) Token: 0x06001356 RID: 4950 RVA: 0x00059DB4 File Offset: 0x00057FB4
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(30)]
        [Description("The shadow decoration depth")]
        public int Depth {
            get {
                return this.XhvVDouKOZ3aw5r4RVAiHzo49IB;
            }
            set {
                this.XhvVDouKOZ3aw5r4RVAiHzo49IB = ((value > 255) ? 255 : ((value < 0) ? 0 : value));
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x170005C0 RID: 1472
        // (get) Token: 0x06001357 RID: 4951 RVA: 0x00059DE4 File Offset: 0x00057FE4
        // (set) Token: 0x06001358 RID: 4952 RVA: 0x00059DF8 File Offset: 0x00057FF8
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(typeof(Padding), "5, 5, 5, 5")]
        [Description("The shadow decoration shadow")]
        public Padding Shadow {
            get {
                return this.BG8RkRXrr1keSwf4gLsoWQnX95d;
            }
            set {
                this.BG8RkRXrr1keSwf4gLsoWQnX95d = value;
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x170005C1 RID: 1473
        // (get) Token: 0x06001359 RID: 4953 RVA: 0x00059E14 File Offset: 0x00058014
        // (set) Token: 0x0600135A RID: 4954 RVA: 0x00059E28 File Offset: 0x00058028
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(6)]
        [Description("The shadow decoration border radius")]
        public int BorderRadius {
            get {
                return this.bnNDAe51VzPIUaemAavSNKLcfqT;
            }
            set {
                this.bnNDAe51VzPIUaemAavSNKLcfqT = ((value < 0) ? 0 : value);
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x0600135B RID: 4955 RVA: 0x00059E4C File Offset: 0x0005804C
        private void XrQVrcOAy09VyITF6fJRbHYPWSF(bool A_1) {
            if (this.lO6pp78RGPDQvzoKBF0epcdMhK()) {
                if (!A_1) {
                    this.sHNggUYK4gysOZTiSC2nXrIbRYA = 0;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.ControlRemoved -= this.xx9MWtQp348PaC0kBQADXURGlY5;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Paint -= this.OcuOJgFb1fmz8EDaARMKtpGakBQ;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Resize -= this.nxTtkik8koCCus2S6ZDff3231mw;
                    this.Parent.Resize -= this.nPZIRWrcP73ODXldSA14yj5vFc;
                } else if (this.sHNggUYK4gysOZTiSC2nXrIbRYA == 0) {
                    this.sHNggUYK4gysOZTiSC2nXrIbRYA = 1;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.ControlRemoved += this.xx9MWtQp348PaC0kBQADXURGlY5;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Paint += this.OcuOJgFb1fmz8EDaARMKtpGakBQ;
                    this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Resize += this.nxTtkik8koCCus2S6ZDff3231mw;
                    this.Parent.Resize += this.nPZIRWrcP73ODXldSA14yj5vFc;
                    return;
                }
            }
        }

        // Token: 0x0600135C RID: 4956 RVA: 0x00059F38 File Offset: 0x00058138
        private void eADcckhTjlvygro60ghzA7tD7lq() {
            while (this.Parent.Parent == null) {
                Thread.Sleep(100);
                Application.DoEvents();
            }
            this.GjCmpVWY14rLa9hnUbVh6kd6n0f = this.Parent.Parent;
            this.XrQVrcOAy09VyITF6fJRbHYPWSF(this.OB02FP6bhYTLsbV62KURE40P9Bt);
            this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
        }

        // Token: 0x0600135D RID: 4957 RVA: 0x00059F84 File Offset: 0x00058184
        private bool lO6pp78RGPDQvzoKBF0epcdMhK() {
            return !((IControl)this.Parent).IsDesignMode && this.GjCmpVWY14rLa9hnUbVh6kd6n0f != null;
        }

        // Token: 0x0600135E RID: 4958 RVA: 0x00059FB0 File Offset: 0x000581B0
        private void B7qcvNmLyrDYeFt2FY2HDYWnPqn() {
            this.CLvZxCPc3oehVRPwun5pd5Dnsd = false;
            if (this.lO6pp78RGPDQvzoKBF0epcdMhK()) {
                this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Invalidate();
            }
        }

        // Token: 0x0600135F RID: 4959 RVA: 0x000569E0 File Offset: 0x00054BE0
        public override string ToString() {
            return string.Empty;
        }

        // Token: 0x06001360 RID: 4960 RVA: 0x00059FD8 File Offset: 0x000581D8
        private Rectangle HD1rLT8zPLEcQoLD2CbetEsRcNJ() {
            return checked(new Rectangle(this.Parent.Location.X - this.Shadow.Left, this.Parent.Location.Y - this.Shadow.Top, this.Parent.Width + (this.Shadow.Left + this.Shadow.Right), this.Parent.Height + (this.Shadow.Top + this.Shadow.Bottom)));
        }

        // Token: 0x06001361 RID: 4961 RVA: 0x0005A080 File Offset: 0x00058280
        private int W1UTtfZLxzAIQq3em1L0NJPZsq() {
            int num;
            if (this.Shadow.Left < this.Shadow.Right) {
                num = this.Shadow.Right;
            } else {
                num = this.Shadow.Left;
            }
            int num2;
            if (this.Shadow.Top >= this.Shadow.Bottom) {
                num2 = this.Shadow.Left;
            } else {
                num2 = this.Shadow.Right;
            }
            int num3;
            if (num < num2) {
                num3 = num2;
            } else {
                num3 = num;
            }
            return num3;
        }

        // Token: 0x06001362 RID: 4962 RVA: 0x0005A114 File Offset: 0x00058314
        private void hV94cVaEjj2sDKgPdxobdwgXf3o(object A_1, EventArgs A_2) {
            if (this.Enabled) {
                this.XrQVrcOAy09VyITF6fJRbHYPWSF(this.Parent.Visible);
            }
            this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
        }

        // Token: 0x06001363 RID: 4963 RVA: 0x0005A140 File Offset: 0x00058340
        private void nPZIRWrcP73ODXldSA14yj5vFc(object A_1, EventArgs A_2) {
            this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
        }

        // Token: 0x06001364 RID: 4964 RVA: 0x0005A154 File Offset: 0x00058354
        private void xx9MWtQp348PaC0kBQADXURGlY5(object A_1, ControlEventArgs A_2) {
            if (A_2.Control == this.Parent) {
                this.XrQVrcOAy09VyITF6fJRbHYPWSF(false);
                this.B7qcvNmLyrDYeFt2FY2HDYWnPqn();
            }
        }

        // Token: 0x06001365 RID: 4965 RVA: 0x0005A17C File Offset: 0x0005837C
        private void nxTtkik8koCCus2S6ZDff3231mw(object A_1, EventArgs A_2) {
            this.GjCmpVWY14rLa9hnUbVh6kd6n0f.Invalidate();
        }

        // Token: 0x06001366 RID: 4966 RVA: 0x0005A194 File Offset: 0x00058394
        private void OcuOJgFb1fmz8EDaARMKtpGakBQ(object A_1, PaintEventArgs A_2) {
            try {
                if (this.Parent.Visible) {
                    if (!this.CLvZxCPc3oehVRPwun5pd5Dnsd | (this.TbHC1JkALmiUimlCrkoy4SwvW5H == null)) {
                        Bitmap bitmap = new Bitmap(this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Width / 2, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Height / 2);
                        Graphics graphics = Graphics.FromImage(bitmap);
                        if (this.nd7veED6faDh1yXqsD1kGxDZRY == ShadowMode.Custom) {
                            graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            graphics.FillPath(new SolidBrush(Color.FromArgb(this.Depth, this.Color)), GraphicsHelper.RoundRect(GraphicsHelper.o2GhHXpYDnkVMC6SZ8zjIElSiFB(new RectangleF(0f, 0f, (float)(this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Width / 2), (float)(this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Height / 2))), (float)((this.BorderRadius < 2) ? 2 : this.BorderRadius), this.CustomizableEdges));
                        } else {
                            GraphicsPath graphicsPath = new GraphicsPath();
                            graphicsPath.AddEllipse(0, 0, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Width / 2 - 1, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Height / 2 - 1);
                            graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            graphics.FillPath(new SolidBrush(Color.FromArgb(this.Depth, this.Color)), graphicsPath);
                        }
                        this.TbHC1JkALmiUimlCrkoy4SwvW5H = new Bitmap(this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Width, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Height);
                        Graphics graphics2 = Graphics.FromImage(this.TbHC1JkALmiUimlCrkoy4SwvW5H);
                        graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        int num = this.W1UTtfZLxzAIQq3em1L0NJPZsq();
                        int num2 = ((num >= 10) ? 10 : num);
                        checked {
                            for (int i = 0; i <= num2; i++) {
                                graphics2.DrawImage(bitmap, new Rectangle(i, i, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Width - i * 2, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Height - i * 2));
                            }
                            bitmap.Dispose();
                            this.CLvZxCPc3oehVRPwun5pd5Dnsd = true;
                        }
                    }
                    A_2.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    A_2.Graphics.DrawImage(this.TbHC1JkALmiUimlCrkoy4SwvW5H, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().X, this.HD1rLT8zPLEcQoLD2CbetEsRcNJ().Y);
                }
            } catch {
            }
        }

        // Token: 0x04000891 RID: 2193
        private Bitmap TbHC1JkALmiUimlCrkoy4SwvW5H;

        // Token: 0x04000892 RID: 2194
        private bool CLvZxCPc3oehVRPwun5pd5Dnsd;

        // Token: 0x04000893 RID: 2195
        private Control J3BnI0lbjggojq2wUZouY3aZH4f;

        // Token: 0x04000894 RID: 2196
        private int DsoqPTFrGYH4iDwoVeXdSLDeXhK;

        // Token: 0x04000895 RID: 2197
        private Control GjCmpVWY14rLa9hnUbVh6kd6n0f;

        // Token: 0x04000896 RID: 2198
        private CustomizableEdges X0WGfXDFJwYbtLhO9tQAwnN8O3 = new CustomizableEdges();

        // Token: 0x04000897 RID: 2199
        private bool OB02FP6bhYTLsbV62KURE40P9Bt;

        // Token: 0x04000898 RID: 2200
        private ShadowMode nd7veED6faDh1yXqsD1kGxDZRY;

        // Token: 0x04000899 RID: 2201
        private Color KlEnha1KiANaUxccLujJt5XaGYfA;

        // Token: 0x0400089A RID: 2202
        private int XhvVDouKOZ3aw5r4RVAiHzo49IB;

        // Token: 0x0400089B RID: 2203
        private Padding BG8RkRXrr1keSwf4gLsoWQnX95d;

        // Token: 0x0400089C RID: 2204
        private int bnNDAe51VzPIUaemAavSNKLcfqT;

        // Token: 0x0400089D RID: 2205
        private int sHNggUYK4gysOZTiSC2nXrIbRYA;
    }

    public enum ShadowMode {
        // Token: 0x04000A51 RID: 2641
        Custom,
        // Token: 0x04000A52 RID: 2642
        Circle
    }
}
