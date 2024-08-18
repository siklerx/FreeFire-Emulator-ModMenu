using AimBotConquer.Guna;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AimBotConquer.Guna {
    // Token: 0x02000086 RID: 134
    [DefaultEvent("TextChanged")]
    [ToolboxItem(false)]
    public class TextBoxBase : UserControl, IControl {
        // Token: 0x06000B68 RID: 2920 RVA: 0x000279FC File Offset: 0x00025BFC
        public TextBoxBase() {
            base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            this.method_0();
            this.InitializeComponent();
        }

        // Token: 0x170003FF RID: 1023
        // (get) Token: 0x06000B69 RID: 2921 RVA: 0x00002714 File Offset: 0x00000914
        [Description("Gets a value that indicates whether the Component is currently in design mode.")]
        [Browsable(false)]
        public bool IsDesignMode {
            get {
                return base.DesignMode;
            }
        }

        // Token: 0x06000B6A RID: 2922 RVA: 0x000074E8 File Offset: 0x000056E8
        protected override void Dispose(bool disposing) {
            if (disposing && this.icontainer_0 != null) {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000B6B RID: 2923 RVA: 0x00027AEC File Offset: 0x00025CEC
        private void InitializeComponent() {
            this.Owner = new Class8();
            base.SuspendLayout();
            this.Owner.BackColor = Color.White;
            this.Owner.BorderStyle = BorderStyle.None;
            this.Owner.Font = new Font("Segoe UI", 9f);
            this.Owner.ForeColor = Color.FromArgb(125, 137, 149);
            this.Owner.Location = new Point(9, 10);
            this.Owner.Name = "Owner";
            this.Owner.Boolean_0 = false;
            this.Owner.String_0 = "";
            this.Owner.Size = new Size(182, 16);
            this.Owner.TabIndex = 0;
            this.Owner.Event_0 += this.method_9;
            this.Owner.Event_1 += this.method_10;
            this.Owner.TextChanged += this.Owner_TextChanged;
            this.Owner.KeyDown += this.Owner_KeyDown;
            this.Owner.KeyPress += this.Owner_KeyPress;
            this.Owner.KeyUp += this.Owner_KeyUp;
            this.Owner.MouseDown += this.Owner_MouseDown;
            this.Owner.MouseEnter += this.Owner_MouseEnter;
            this.Owner.MouseLeave += this.Owner_MouseLeave;
            this.Owner.MouseUp += this.Owner_MouseUp;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(this.Owner);
            this.Cursor = Cursors.IBeam;
            this.ForeColor = Color.FromArgb(125, 137, 149);
            base.Name = "TextBoxWithIcon";
            base.Size = new Size(200, 36);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x06000B6C RID: 2924 RVA: 0x00027D20 File Offset: 0x00025F20
        private void method_0() {
            this.animationManager_0 = new AnimationManager(true) {
                Increment = 0.070000000298023224,
                AnimationType = AnimationType.Linear
            };
            this.animationManager_0.OnAnimationProgress += this.method_2;
            this.animationManager_1 = new AnimationManager(true) {
                Increment = 0.070000000298023224,
                AnimationType = AnimationType.Linear
            };
            this.animationManager_1.OnAnimationProgress += this.method_1;
        }

        // Token: 0x06000B6D RID: 2925 RVA: 0x000045AA File Offset: 0x000027AA
        private void method_1(object object_0) {
            base.Invalidate();
        }

        // Token: 0x06000B6E RID: 2926 RVA: 0x000045AA File Offset: 0x000027AA
        private void method_2(object object_0) {
            base.Invalidate();
        }

        // Token: 0x1400002D RID: 45
        // (add) Token: 0x06000B6F RID: 2927 RVA: 0x00027DA0 File Offset: 0x00025FA0
        // (remove) Token: 0x06000B70 RID: 2928 RVA: 0x00027DD8 File Offset: 0x00025FD8
        [Browsable(true)]
        [Description("Occurs when the property 'Text' changes.")]
        public new event EventHandler TextChanged {
            [CompilerGenerated]
            add {
                EventHandler eventHandler = this.eventHandler_0;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            [CompilerGenerated]
            remove {
                EventHandler eventHandler = this.eventHandler_0;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }

        // Token: 0x06000B71 RID: 2929 RVA: 0x0000750D File Offset: 0x0000570D
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected new virtual void OnTextChanged(EventArgs e) {
            if (this.eventHandler_0 != null) {
                this.eventHandler_0(this, EventArgs.Empty);
            }
        }

        // Token: 0x1400002E RID: 46
        // (add) Token: 0x06000B72 RID: 2930 RVA: 0x00027E10 File Offset: 0x00026010
        // (remove) Token: 0x06000B73 RID: 2931 RVA: 0x00027E48 File Offset: 0x00026048
        public event EventHandler IconLeftClick {
            [CompilerGenerated]
            add {
                EventHandler eventHandler = this.eventHandler_1;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            [CompilerGenerated]
            remove {
                EventHandler eventHandler = this.eventHandler_1;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }

        // Token: 0x06000B74 RID: 2932 RVA: 0x0000752B File Offset: 0x0000572B
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected virtual void OnIconLeftClick(EventArgs e) {
            if (this.eventHandler_1 != null) {
                this.eventHandler_1(this, EventArgs.Empty);
            }
        }

        // Token: 0x1400002F RID: 47
        // (add) Token: 0x06000B75 RID: 2933 RVA: 0x00027E80 File Offset: 0x00026080
        // (remove) Token: 0x06000B76 RID: 2934 RVA: 0x00027EB8 File Offset: 0x000260B8
        public event EventHandler IconRightClick {
            [CompilerGenerated]
            add {
                EventHandler eventHandler = this.eventHandler_2;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            [CompilerGenerated]
            remove {
                EventHandler eventHandler = this.eventHandler_2;
                EventHandler eventHandler2;
                do {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }

        // Token: 0x06000B77 RID: 2935 RVA: 0x00007549 File Offset: 0x00005749
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected virtual void OnIconRightClick(EventArgs e) {
            if (this.eventHandler_2 != null) {
                this.eventHandler_2(this, EventArgs.Empty);
            }
        }

        // Token: 0x06000B78 RID: 2936 RVA: 0x00027EF0 File Offset: 0x000260F0
        protected override void OnClick(EventArgs e) {
            if (this.image_0 != null && this.method_3(this.point_3)) {
                this.OnIconLeftClick(EventArgs.Empty);
            }
            if (this.image_1 != null && this.method_4(this.point_3)) {
                this.OnIconRightClick(EventArgs.Empty);
            }
            base.OnClick(e);
        }

        // Token: 0x17000400 RID: 1024
        // (get) Token: 0x06000B79 RID: 2937 RVA: 0x00027F4C File Offset: 0x0002614C
        // (set) Token: 0x06000B7A RID: 2938 RVA: 0x00007567 File Offset: 0x00005767
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected TextBoxState DefaultHoveredState {
            get {
                if (this.textBoxState_0 == null) {
                    this.textBoxState_0 = new TextBoxState {
                        Parent = this
                    };
                }
                return this.textBoxState_0;
            }
            set {
                this.textBoxState_0 = value;
            }
        }

        // Token: 0x17000401 RID: 1025
        // (get) Token: 0x06000B7B RID: 2939 RVA: 0x00027F80 File Offset: 0x00026180
        // (set) Token: 0x06000B7C RID: 2940 RVA: 0x00007570 File Offset: 0x00005770
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected TextBoxState DefaultFocusedState {
            get {
                if (this.textBoxState_1 == null) {
                    this.textBoxState_1 = new TextBoxState {
                        Parent = this
                    };
                }
                return this.textBoxState_1;
            }
            set {
                this.textBoxState_1 = value;
            }
        }

        // Token: 0x17000402 RID: 1026
        // (get) Token: 0x06000B7D RID: 2941 RVA: 0x00027FB4 File Offset: 0x000261B4
        // (set) Token: 0x06000B7E RID: 2942 RVA: 0x00007579 File Offset: 0x00005779
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected TextBoxState DefaultDisabledState {
            get {
                if (this.textBoxState_2 == null) {
                    this.textBoxState_2 = new TextBoxState {
                        Parent = this
                    };
                }
                return this.textBoxState_2;
            }
            set {
                this.textBoxState_2 = value;
            }
        }

        // Token: 0x17000403 RID: 1027
        // (get) Token: 0x06000B7F RID: 2943 RVA: 0x00007582 File Offset: 0x00005782
        // (set) Token: 0x06000B80 RID: 2944 RVA: 0x0000758A File Offset: 0x0000578A
        [Browsable(false)]
        protected bool DefaultAnimated {
            get {
                return this.bool_0;
            }
            set {
                this.bool_0 = value;
            }
        }

        // Token: 0x17000404 RID: 1028
        // (get) Token: 0x06000B81 RID: 2945 RVA: 0x00027FE8 File Offset: 0x000261E8
        // (set) Token: 0x06000B82 RID: 2946 RVA: 0x00007593 File Offset: 0x00005793
        [Browsable(false)]
        protected TextBoxStyle DefaultStyle {
            get {
                return this.textBoxStyle_0;
            }
            set {
                this.textBoxStyle_0 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000405 RID: 1029
        // (get) Token: 0x06000B83 RID: 2947 RVA: 0x00028000 File Offset: 0x00026200
        // (set) Token: 0x06000B84 RID: 2948 RVA: 0x000075A2 File Offset: 0x000057A2
        [Browsable(false)]
        protected Point DefaultTextOffset {
            get {
                return this.point_0;
            }
            set {
                this.point_0 = value;
                this.method_7();
                base.Invalidate();
            }
        }

        // Token: 0x17000406 RID: 1030
        // (get) Token: 0x06000B85 RID: 2949 RVA: 0x00028018 File Offset: 0x00026218
        // (set) Token: 0x06000B86 RID: 2950 RVA: 0x000075B7 File Offset: 0x000057B7
        [Browsable(false)]
        protected string DefaultPlaceholderText {
            get {
                return this.Owner.String_0;
            }
            set {
                this.Owner.String_0 = value;
            }
        }

        // Token: 0x17000407 RID: 1031
        // (get) Token: 0x06000B87 RID: 2951 RVA: 0x00028034 File Offset: 0x00026234
        // (set) Token: 0x06000B88 RID: 2952 RVA: 0x000075C5 File Offset: 0x000057C5
        [Browsable(false)]
        protected Color DefaultPlaceholderForeColor {
            get {
                return this.color_0;
            }
            set {
                this.color_0 = value;
                this.method_9(this.Owner.Boolean_0);
            }
        }

        // Token: 0x17000408 RID: 1032
        // (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002804C File Offset: 0x0002624C
        // (set) Token: 0x06000B8A RID: 2954 RVA: 0x000075DF File Offset: 0x000057DF
        [Browsable(false)]
        protected int DefaultBorderRadius {
            get {
                return this.int_0;
            }
            set {
                this.int_0 = ((value < 0) ? 0 : value);
                base.Invalidate();
            }
        }

        // Token: 0x17000409 RID: 1033
        // (get) Token: 0x06000B8B RID: 2955 RVA: 0x00028064 File Offset: 0x00026264
        // (set) Token: 0x06000B8C RID: 2956 RVA: 0x000075F5 File Offset: 0x000057F5
        [Browsable(false)]
        protected DashStyle DefaultBorderStyle {
            get {
                return this.dashStyle_0;
            }
            set {
                this.dashStyle_0 = value;
                base.Invalidate();
            }
        }

        // Token: 0x1700040A RID: 1034
        // (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002807C File Offset: 0x0002627C
        // (set) Token: 0x06000B8E RID: 2958 RVA: 0x00007604 File Offset: 0x00005804
        [Browsable(false)]
        protected Color DefaultBorderColor {
            get {
                return this.color_1;
            }
            set {
                this.color_1 = value;
                base.Invalidate();
            }
        }

        // Token: 0x1700040B RID: 1035
        // (get) Token: 0x06000B8F RID: 2959 RVA: 0x00028094 File Offset: 0x00026294
        // (set) Token: 0x06000B90 RID: 2960 RVA: 0x00007613 File Offset: 0x00005813
        [Browsable(false)]
        protected int DefaultBorderThickness {
            get {
                return this.int_1;
            }
            set {
                this.int_1 = value;
                base.Invalidate();
            }
        }

        // Token: 0x1700040C RID: 1036
        // (get) Token: 0x06000B91 RID: 2961 RVA: 0x000280AC File Offset: 0x000262AC
        // (set) Token: 0x06000B92 RID: 2962 RVA: 0x00007622 File Offset: 0x00005822
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        protected ShadowDecoration DefaultShadowDecoration {
            get {
                if (this.shadowDecoration_0 == null) {
                    this.shadowDecoration_0 = new ShadowDecoration(this);
                }
                return this.shadowDecoration_0;
            }
            set {
                this.shadowDecoration_0 = value;
            }
        }

        // Token: 0x1700040D RID: 1037
        // (get) Token: 0x06000B93 RID: 2963 RVA: 0x000280D8 File Offset: 0x000262D8
        // (set) Token: 0x06000B94 RID: 2964 RVA: 0x0000762B File Offset: 0x0000582B
        [Browsable(false)]
        protected Image DefaultIconLeft {
            get {
                return this.image_0;
            }
            set {
                this.image_0 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x1700040E RID: 1038
        // (get) Token: 0x06000B95 RID: 2965 RVA: 0x000280F0 File Offset: 0x000262F0
        // (set) Token: 0x06000B96 RID: 2966 RVA: 0x0000763A File Offset: 0x0000583A
        [Browsable(false)]
        protected Size DefaultIconLeftSize {
            get {
                return this.size_0;
            }
            set {
                this.size_0 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x1700040F RID: 1039
        // (get) Token: 0x06000B97 RID: 2967 RVA: 0x00028108 File Offset: 0x00026308
        // (set) Token: 0x06000B98 RID: 2968 RVA: 0x00007649 File Offset: 0x00005849
        [Browsable(false)]
        protected Cursor DefaultIconLeftCursor {
            get {
                return this.cursor_0;
            }
            set {
                this.cursor_0 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000410 RID: 1040
        // (get) Token: 0x06000B99 RID: 2969 RVA: 0x00028120 File Offset: 0x00026320
        // (set) Token: 0x06000B9A RID: 2970 RVA: 0x00007658 File Offset: 0x00005858
        [Browsable(false)]
        protected Point DefaultIconLeftOffset {
            get {
                return this.point_1;
            }
            set {
                this.point_1 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000411 RID: 1041
        // (get) Token: 0x06000B9B RID: 2971 RVA: 0x00028138 File Offset: 0x00026338
        // (set) Token: 0x06000B9C RID: 2972 RVA: 0x00007667 File Offset: 0x00005867
        [Browsable(false)]
        protected Image DefaultIconRight {
            get {
                return this.image_1;
            }
            set {
                this.image_1 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000412 RID: 1042
        // (get) Token: 0x06000B9D RID: 2973 RVA: 0x00028150 File Offset: 0x00026350
        // (set) Token: 0x06000B9E RID: 2974 RVA: 0x00007676 File Offset: 0x00005876
        [Browsable(false)]
        protected Size DefaultIconRightSize {
            get {
                return this.size_1;
            }
            set {
                this.size_1 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000413 RID: 1043
        // (get) Token: 0x06000B9F RID: 2975 RVA: 0x00028168 File Offset: 0x00026368
        // (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00007685 File Offset: 0x00005885
        [Browsable(false)]
        protected Cursor DefaultIconRightCursor {
            get {
                return this.cursor_1;
            }
            set {
                this.cursor_1 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000414 RID: 1044
        // (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00028180 File Offset: 0x00026380
        // (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00007694 File Offset: 0x00005894
        [Browsable(false)]
        protected Point DefaultIconRightOffset {
            get {
                return this.point_2;
            }
            set {
                this.point_2 = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000415 RID: 1045
        // (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00028198 File Offset: 0x00026398
        // (set) Token: 0x06000BA4 RID: 2980 RVA: 0x000076A3 File Offset: 0x000058A3
        [Browsable(false)]
        protected Color DefaultFillColor {
            get {
                return this.color_2;
            }
            set {
                this.color_2 = value;
                base.Invalidate();
            }
        }

        // Token: 0x17000416 RID: 1046
        // (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000281B0 File Offset: 0x000263B0
        // (set) Token: 0x06000BA6 RID: 2982 RVA: 0x000076B2 File Offset: 0x000058B2
        [Browsable(false)]
        [Description("Gets or sets the text associated with this control.")]
        public virtual string Text {
            get {
                return this.Owner.Text;
            }
            set {
                this.Owner.Text = value;
            }
        }

        // Token: 0x17000417 RID: 1047
        // (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000281B0 File Offset: 0x000263B0
        // (set) Token: 0x06000BA8 RID: 2984 RVA: 0x000076B2 File Offset: 0x000058B2
        [DisplayName("Text")]
        [Description("Sets the text input.")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        public virtual string DefaultText {
            get {
                return this.Owner.Text;
            }
            set {
                this.Owner.Text = value;
            }
        }

        // Token: 0x06000BA9 RID: 2985 RVA: 0x000281CC File Offset: 0x000263CC
        private bool method_3(Point point_4) {
            return point_4.X < 5 + this.point_1.X + this.size_0.Width;
        }

        // Token: 0x06000BAA RID: 2986 RVA: 0x00028204 File Offset: 0x00026404
        private bool method_4(Point point_4) {
            return point_4.X > base.Width - (5 + this.point_2.X + this.size_1.Width);
        }

        // Token: 0x06000BAB RID: 2987 RVA: 0x00028244 File Offset: 0x00026444
        protected override void OnMouseMove(MouseEventArgs e) {
            this.point_3 = e.Location;
            if (this.method_3(e.Location) && this.image_0 != null) {
                if (this.Cursor != this.cursor_0) {
                    this.Cursor = this.cursor_0;
                }
            } else if (this.method_4(e.Location) && this.image_1 != null) {
                if (this.Cursor != this.cursor_1) {
                    this.Cursor = this.cursor_1;
                }
            } else if (this.Cursor != Cursors.IBeam) {
                this.Cursor = Cursors.IBeam;
            }
            base.OnMouseMove(e);
        }

        // Token: 0x06000BAC RID: 2988 RVA: 0x000076C0 File Offset: 0x000058C0
        protected override void OnMouseDown(MouseEventArgs e) {
            this.bool_1 = true;
            this.mouseState_0 = MouseState.DOWN;
            base.OnMouseDown(e);
        }

        // Token: 0x06000BAD RID: 2989 RVA: 0x000076D7 File Offset: 0x000058D7
        protected override void OnMouseUp(MouseEventArgs e) {
            this.mouseState_0 = (this.bool_1 ? MouseState.HOVER : MouseState.const_2);
            base.OnMouseUp(e);
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000BAE RID: 2990 RVA: 0x000282FC File Offset: 0x000264FC
        private void method_5(MouseState mouseState_1, MouseState mouseState_2) {
            if ((mouseState_1 == MouseState.HOVER) | (mouseState_2 == MouseState.HOVER)) {
                if (!this.bool_0) {
                    base.Invalidate();
                } else if (!base.DesignMode) {
                    this.animationManager_0.StartNewAnimation(AnimationDirection.In, null);
                }
            }
            if (mouseState_1 == MouseState.const_2 && mouseState_2 == MouseState.const_2) {
                if (!this.bool_0) {
                    base.Invalidate();
                } else if (!base.DesignMode) {
                    this.animationManager_0.StartNewAnimation(AnimationDirection.Out, null);
                }
            }
        }

        // Token: 0x06000BAF RID: 2991 RVA: 0x00028378 File Offset: 0x00026578
        private void method_6(bool bool_2, bool bool_3) {
            if (bool_2 || bool_3) {
                if (!this.bool_0) {
                    base.Invalidate();
                } else if (!base.DesignMode) {
                    this.animationManager_1.StartNewAnimation(AnimationDirection.In, null);
                }
            }
            if (!bool_2 && !bool_3) {
                if (!this.bool_0) {
                    base.Invalidate();
                } else if (!base.DesignMode) {
                    this.animationManager_1.StartNewAnimation(AnimationDirection.Out, null);
                }
            }
        }

        // Token: 0x06000BB0 RID: 2992 RVA: 0x00007709 File Offset: 0x00005909
        protected override void OnMouseEnter(EventArgs e) {
            this.bool_1 = true;
            this.mouseState_0 = MouseState.HOVER;
            base.OnMouseEnter(e);
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000BB1 RID: 2993 RVA: 0x00007737 File Offset: 0x00005937
        protected override void OnMouseLeave(EventArgs e) {
            this.bool_1 = false;
            this.mouseState_0 = MouseState.const_2;
            base.OnMouseLeave(e);
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000BB2 RID: 2994 RVA: 0x00007765 File Offset: 0x00005965
        protected override void OnLostFocus(EventArgs e) {
            this.bool_1 = false;
            this.mouseState_0 = MouseState.const_2;
            base.OnLostFocus(e);
            this.method_6(base.Focused, this.Owner.Focused);
        }

        // Token: 0x06000BB3 RID: 2995 RVA: 0x000283EC File Offset: 0x000265EC
        protected override void OnGotFocus(EventArgs e) {
            this.Owner.Focus();
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
            base.OnGotFocus(e);
            this.method_6(base.Focused, this.Owner.Focused);
        }

        // Token: 0x06000BB4 RID: 2996 RVA: 0x00007793 File Offset: 0x00005993
        public void AppendText(string text) {
            this.Owner.AppendText(text);
        }

        // Token: 0x06000BB5 RID: 2997 RVA: 0x000077A1 File Offset: 0x000059A1
        public void Clear() {
            this.Owner.Clear();
        }

        // Token: 0x06000BB6 RID: 2998 RVA: 0x000077AE File Offset: 0x000059AE
        public void ClearUndo() {
            this.Owner.ClearUndo();
        }

        // Token: 0x06000BB7 RID: 2999 RVA: 0x000077BB File Offset: 0x000059BB
        public void Cut() {
            this.Owner.Cut();
        }

        // Token: 0x06000BB8 RID: 3000 RVA: 0x000077C8 File Offset: 0x000059C8
        public void DeselectAll() {
            this.Owner.DeselectAll();
        }

        // Token: 0x06000BB9 RID: 3001 RVA: 0x000077D5 File Offset: 0x000059D5
        public void SelectAll() {
            this.Owner.SelectAll();
        }

        // Token: 0x06000BBA RID: 3002 RVA: 0x000077E2 File Offset: 0x000059E2
        public void Paste() {
            this.Owner.Paste();
        }

        // Token: 0x06000BBB RID: 3003 RVA: 0x000077EF File Offset: 0x000059EF
        public new void Focus() {
            this.Owner.Focus();
        }

        // Token: 0x06000BBC RID: 3004 RVA: 0x000077FD File Offset: 0x000059FD
        public new void Select() {
            this.Owner.Select();
        }

        // Token: 0x06000BBD RID: 3005 RVA: 0x0000780A File Offset: 0x00005A0A
        public override void ResetText() {
            this.Owner.ResetText();
        }

        // Token: 0x06000BBE RID: 3006 RVA: 0x00007817 File Offset: 0x00005A17
        public void ScrollToCaret() {
            this.Owner.ScrollToCaret();
        }

        // Token: 0x06000BBF RID: 3007 RVA: 0x00007824 File Offset: 0x00005A24
        public void Select(int start, int length) {
            this.Owner.Select(start, length);
        }

        // Token: 0x06000BC0 RID: 3008 RVA: 0x0002843C File Offset: 0x0002663C
        public override string ToString() {
            return this.Owner.ToString();
        }

        // Token: 0x06000BC1 RID: 3009 RVA: 0x00007833 File Offset: 0x00005A33
        public void Undo() {
            this.Owner.Undo();
        }

        // Token: 0x17000418 RID: 1048
        // (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00007840 File Offset: 0x00005A40
        // (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000784D File Offset: 0x00005A4D
        [Category("Behavior")]
        [Description("Gets or sets a value indicating whether pressing ENTER in a multiline TextBox control creates a new line of text in the control or activates the default button for the form.")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool AcceptsReturn {
            get {
                return this.Owner.AcceptsReturn;
            }
            set {
                this.Owner.AcceptsReturn = value;
            }
        }

        // Token: 0x17000419 RID: 1049
        // (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000785B File Offset: 0x00005A5B
        // (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00007868 File Offset: 0x00005A68
        [Category("Behavior")]
        [Description("Gets or sets a value indicating whether pressing the TAB key in a multiline text box control types a TAB character in the control instead of moving the focus to the next control in the tab order.")]
        [DefaultValue(false)]
        [Browsable(true)]
        public bool AcceptsTab {
            get {
                return this.Owner.AcceptsTab;
            }
            set {
                this.Owner.AcceptsTab = value;
            }
        }

        // Token: 0x1700041A RID: 1050
        // (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00028458 File Offset: 0x00026658
        // (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00007876 File Offset: 0x00005A76
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Gets or sets a custom System.Collections.Specialized.StringCollection to use when the AutoCompleteSource property is set to CustomSource.")]
        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get {
                return this.Owner.AutoCompleteCustomSource;
            }
            set {
                this.Owner.AutoCompleteCustomSource = value;
            }
        }

        // Token: 0x1700041B RID: 1051
        // (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00028474 File Offset: 0x00026674
        // (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00007884 File Offset: 0x00005A84
        [Description("Gets or sets an option that controls how automatic completion works for the TextBox.")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        public AutoCompleteMode AutoCompleteMode {
            get {
                return this.Owner.AutoCompleteMode;
            }
            set {
                this.Owner.AutoCompleteMode = value;
            }
        }

        // Token: 0x1700041C RID: 1052
        // (get) Token: 0x06000BCA RID: 3018 RVA: 0x00028490 File Offset: 0x00026690
        // (set) Token: 0x06000BCB RID: 3019 RVA: 0x00007892 File Offset: 0x00005A92
        [Browsable(true)]
        [Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")]
        [DefaultValue(AutoCompleteSource.None)]
        public AutoCompleteSource AutoCompleteSource {
            get {
                return this.Owner.AutoCompleteSource;
            }
            set {
                this.Owner.AutoCompleteSource = value;
            }
        }

        // Token: 0x1700041D RID: 1053
        // (get) Token: 0x06000BCC RID: 3020 RVA: 0x000078A0 File Offset: 0x00005AA0
        [Browsable(false)]
        [Description("Gets a value indicating whether the user can undo the previous operation in a text box control.")]
        public bool CanUndo {
            get {
                return this.Owner.CanUndo;
            }
        }

        // Token: 0x1700041E RID: 1054
        // (get) Token: 0x06000BCD RID: 3021 RVA: 0x0000B2E0 File Offset: 0x000094E0
        // (set) Token: 0x06000BCE RID: 3022 RVA: 0x000078AD File Offset: 0x00005AAD
        [Category("Options")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "125, 137, 149")]
        [Description("Sets the TextBox's foreground color.")]
        public new Color ForeColor {
            get {
                return base.ForeColor;
            }
            set {
                base.ForeColor = value;
                this.method_9(this.Owner.Boolean_0);
            }
        }

        // Token: 0x1700041F RID: 1055
        // (get) Token: 0x06000BCF RID: 3023 RVA: 0x000284AC File Offset: 0x000266AC
        // (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000078C7 File Offset: 0x00005AC7
        [DefaultValue(CharacterCasing.Normal)]
        [Category("Behavior")]
        [Description("Gets or sets whether the TextBox control modifies the case of characters as they are typed.")]
        [Browsable(true)]
        public CharacterCasing CharacterCasing {
            get {
                return this.Owner.CharacterCasing;
            }
            set {
                this.Owner.CharacterCasing = value;
            }
        }

        // Token: 0x17000420 RID: 1056
        // (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000284C8 File Offset: 0x000266C8
        // (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000078D5 File Offset: 0x00005AD5
        [Description("Gets or sets the font of the text displayed by the control.")]
        public new Font Font {
            get {
                return this.Owner.Font;
            }
            set {
                this.Owner.Font = value;
                this.UpdateBaseTextBoxPosition();
            }
        }

        // Token: 0x17000421 RID: 1057
        // (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000078E9 File Offset: 0x00005AE9
        [Description("Gets a value indicating whether the control has input focus")]
        public new bool Focused {
            get {
                return this.Owner.Focused | base.Focused;
            }
        }

        // Token: 0x17000422 RID: 1058
        // (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000078FD File Offset: 0x00005AFD
        // (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0000790A File Offset: 0x00005B0A
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("Gets or sets a value indicating whether the selected text in the text box control remains highlighted when the control loses focus.")]
        [Browsable(true)]
        public bool HideSelection {
            get {
                return this.Owner.HideSelection;
            }
            set {
                this.Owner.HideSelection = value;
            }
        }

        // Token: 0x17000423 RID: 1059
        // (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000284E4 File Offset: 0x000266E4
        // (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00007918 File Offset: 0x00005B18
        [Category("Appearance")]
        [MergableProperty(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        [Localizable(true)]
        [Description("Gets or sets the lines of text in a text box control.")]
        [Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string[] Lines {
            get {
                return this.Owner.Lines;
            }
            set {
                this.Owner.Lines = value;
            }
        }

        // Token: 0x17000424 RID: 1060
        // (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00028500 File Offset: 0x00026700
        // (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00007926 File Offset: 0x00005B26
        [Description("Gets or sets the maximum number of characters the user can type or paste into the text box control.")]
        [Category("Behavior")]
        [Browsable(true)]
        [DefaultValue(32767)]
        public int MaxLength {
            get {
                return this.Owner.MaxLength;
            }
            set {
                this.Owner.MaxLength = value;
            }
        }

        // Token: 0x17000425 RID: 1061
        // (get) Token: 0x06000BDA RID: 3034 RVA: 0x00007934 File Offset: 0x00005B34
        // (set) Token: 0x06000BDB RID: 3035 RVA: 0x00007941 File Offset: 0x00005B41
        [Category("Behavior")]
        [DefaultValue(false)]
        [Browsable(true)]
        [Description("Gets or sets a value that indicates that the text box control has been modified by the user since the control was created or its contents were last set.")]
        public bool Modified {
            get {
                return this.Owner.Modified;
            }
            set {
                this.Owner.Modified = value;
            }
        }

        // Token: 0x17000426 RID: 1062
        // (get) Token: 0x06000BDC RID: 3036 RVA: 0x0000794F File Offset: 0x00005B4F
        // (set) Token: 0x06000BDD RID: 3037 RVA: 0x0000795C File Offset: 0x00005B5C
        [Description("Gets or sets a value indicating whether this is a multiline TextBox control.")]
        [DefaultValue(false)]
        [Browsable(true)]
        [Category("Behavior")]
        public bool Multiline {
            get {
                return this.Owner.Multiline;
            }
            set {
                this.Owner.Multiline = value;
                this.method_7();
            }
        }

        // Token: 0x17000427 RID: 1063
        // (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002851C File Offset: 0x0002671C
        // (set) Token: 0x06000BDF RID: 3039 RVA: 0x00007970 File Offset: 0x00005B70
        [Description("Gets or sets the character used to mask characters of a password in a single-line TextBox control.")]
        [Category("Behavior")]
        [Browsable(true)]
        public char PasswordChar {
            get {
                return this.Owner.Char_0;
            }
            set {
                this.Owner.Char_0 = value;
            }
        }

        // Token: 0x17000428 RID: 1064
        // (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00028538 File Offset: 0x00026738
        [Browsable(false)]
        [Description("Gets the preferred height for a text box.")]
        [Category("Behavior")]
        public int PreferredHeight {
            get {
                return this.Owner.PreferredHeight;
            }
        }

        // Token: 0x17000429 RID: 1065
        // (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0000797E File Offset: 0x00005B7E
        // (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0000798B File Offset: 0x00005B8B
        [Category("Behavior")]
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating whether text in the text box is read-only.")]
        [Browsable(true)]
        public bool ReadOnly {
            get {
                return this.Owner.ReadOnly;
            }
            set {
                this.Owner.ReadOnly = value;
            }
        }

        // Token: 0x1700042A RID: 1066
        // (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00028554 File Offset: 0x00026754
        // (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00007999 File Offset: 0x00005B99
        [Browsable(true)]
        [Description("Gets or sets a value indicating the currently selected text in the control.")]
        [Category("Behavior")]
        public string SelectedText {
            get {
                return this.Owner.SelectedText;
            }
            set {
                this.Owner.SelectedText = value;
            }
        }

        // Token: 0x1700042B RID: 1067
        // (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00028570 File Offset: 0x00026770
        // (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000079A7 File Offset: 0x00005BA7
        [Browsable(true)]
        [DefaultValue(0)]
        [Category("Behavior")]
        [Description("Gets or sets the number of characters selected in the text box.")]
        public int SelectionLength {
            get {
                return this.Owner.SelectionLength;
            }
            set {
                this.Owner.SelectionLength = value;
            }
        }

        // Token: 0x1700042C RID: 1068
        // (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0002858C File Offset: 0x0002678C
        // (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000079B5 File Offset: 0x00005BB5
        [Browsable(true)]
        [DefaultValue(0)]
        [Description("Gets or sets the starting point of text selected in the text box.")]
        [Category("Behavior")]
        public int SelectionStart {
            get {
                return this.Owner.SelectionStart;
            }
            set {
                this.Owner.SelectionStart = value;
            }
        }

        // Token: 0x1700042D RID: 1069
        // (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000079C3 File Offset: 0x00005BC3
        // (set) Token: 0x06000BEA RID: 3050 RVA: 0x000079D0 File Offset: 0x00005BD0
        [DefaultValue(true)]
        [Browsable(true)]
        [Category("Behavior")]
        [Description("Gets or sets a value indicating whether the defined shortcuts are enabled.")]
        public bool ShortcutsEnabled {
            get {
                return this.Owner.ShortcutsEnabled;
            }
            set {
                this.Owner.ShortcutsEnabled = value;
            }
        }

        // Token: 0x1700042E RID: 1070
        // (get) Token: 0x06000BEB RID: 3051 RVA: 0x000285A8 File Offset: 0x000267A8
        // (set) Token: 0x06000BEC RID: 3052 RVA: 0x000079DE File Offset: 0x00005BDE
        [Browsable(true)]
        [Description("Gets or sets how text is aligned in a TextBox control.")]
        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign {
            get {
                return this.Owner.TextAlign;
            }
            set {
                this.Owner.TextAlign = value;
            }
        }

        // Token: 0x1700042F RID: 1071
        // (get) Token: 0x06000BED RID: 3053 RVA: 0x000285C4 File Offset: 0x000267C4
        [Category("Behavior")]
        [Description("Gets the length of text in the control.")]
        [Browsable(false)]
        public int TextLength {
            get {
                return this.Owner.TextLength;
            }
        }

        // Token: 0x17000430 RID: 1072
        // (get) Token: 0x06000BEE RID: 3054 RVA: 0x000079EC File Offset: 0x00005BEC
        // (set) Token: 0x06000BEF RID: 3055 RVA: 0x000079F9 File Offset: 0x00005BF9
        [Category("Behavior")]
        [DefaultValue(false)]
        [Browsable(true)]
        [Description("Gets or sets a value indicating whether the text in the TextBox control should appear as the default password character.")]
        public bool UseSystemPasswordChar {
            get {
                return this.Owner.UseSystemPasswordChar;
            }
            set {
                this.Owner.UseSystemPasswordChar = value;
            }
        }

        // Token: 0x17000431 RID: 1073
        // (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00007A07 File Offset: 0x00005C07
        // (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007A14 File Offset: 0x00005C14
        [DefaultValue(true)]
        [Description("Indicates whether a multiline text box control automatically wraps words to the beginning of the next line when necessary.")]
        [Browsable(true)]
        [Category("Behavior")]
        public bool WordWrap {
            get {
                return this.Owner.WordWrap;
            }
            set {
                this.Owner.WordWrap = value;
            }
        }

        // Token: 0x06000BF2 RID: 3058 RVA: 0x00007A22 File Offset: 0x00005C22
        protected override void OnResize(EventArgs e) {
            this.method_7();
            base.Invalidate();
            base.OnResize(e);
        }

        // Token: 0x06000BF3 RID: 3059 RVA: 0x00007A37 File Offset: 0x00005C37
        protected void UpdateBaseTextBoxPosition() {
            this.method_7();
            base.Invalidate();
        }

        // Token: 0x06000BF4 RID: 3060 RVA: 0x000285E0 File Offset: 0x000267E0
        private void method_7() {
            if (this.Owner != null) {
                Padding padding = this.padding_0;
                padding.Left += this.point_0.X;
                padding.Right += this.point_0.X;
                Rectangle clientRectangle = base.ClientRectangle;
                Rectangle clientRectangle2 = this.Owner.ClientRectangle;
                clientRectangle2.X = 0;
                clientRectangle2.Y = 0;
                if (!this.Owner.Multiline) {
                    clientRectangle2.Y = base.Height / 2 - clientRectangle2.Height / 2;
                    clientRectangle2.Y += this.point_0.Y;
                } else {
                    clientRectangle2.Y = padding.Top;
                    clientRectangle2.Y += this.point_0.Y;
                }
                if (this.image_0 != null) {
                    clientRectangle2.X = padding.Left + this.point_1.X + this.size_0.Width;
                    clientRectangle.Width -= clientRectangle2.X + padding.Right;
                } else {
                    clientRectangle2.X = padding.Left;
                    clientRectangle.Width -= padding.Left + padding.Right;
                }
                if (this.image_1 != null) {
                    clientRectangle.Width -= this.size_1.Width + this.point_2.X;
                }
                if (this.Owner.Multiline) {
                    clientRectangle2.Height = clientRectangle.Height - (padding.Bottom + padding.Top);
                    if (this.Owner.Height != clientRectangle2.Width) {
                        this.Owner.Height = clientRectangle2.Height;
                    }
                }
                if (this.Owner.Width != clientRectangle.Width) {
                    this.Owner.Width = clientRectangle.Width;
                }
                if (this.Owner.Left != clientRectangle2.Left) {
                    this.Owner.Left = clientRectangle2.Left;
                }
                if (this.Owner.Top != clientRectangle2.Top) {
                    this.Owner.Top = clientRectangle2.Top;
                }
            }
        }

        // Token: 0x06000BF5 RID: 3061 RVA: 0x00007A45 File Offset: 0x00005C45
        protected override void OnPaint(PaintEventArgs e) {
            this.method_8(e.Graphics);
            base.OnPaint(e);
        }

        // Token: 0x06000BF6 RID: 3062 RVA: 0x00028844 File Offset: 0x00026A44
        private void method_8(Graphics graphics_0) {
            Color color = this.color_1;
            Color color2 = this.ForeColor;
            Color color3 = this.color_2;
            Color color4 = this.color_0;
            int num = 0;
            int num2 = 0;
            Image image = this.image_0;
            Image image2 = this.image_1;
            if (base.Enabled) {
                if (this.bool_0 && !base.DesignMode) {
                    num = (int)(this.animationManager_0.GetProgress() * 100.0);
                    num2 = (int)(this.animationManager_1.GetProgress() * 100.0);
                } else if (this.Owner.Focused | base.Focused) {
                    num2 = 100;
                } else if ((this.mouseState_0 == MouseState.HOVER) | (this.Owner.mouseState_0 == MouseState.HOVER) | (this.mouseState_0 == MouseState.DOWN) | (this.Owner.mouseState_0 == MouseState.DOWN)) {
                    num = 100;
                }
            } else {
                color = smethod_24(100, color, this.DefaultDisabledState.BorderColor);
                color2 = smethod_24(100, this.ForeColor, this.DefaultDisabledState.ForeColor);
                color3 = smethod_24(100, this.color_2, this.DefaultDisabledState.FillColor);
                color4 = smethod_24(100, this.color_0, this.DefaultDisabledState.PlaceholderForeColor);
            }
            color = smethod_24(num, color, this.DefaultHoveredState.BorderColor);
            color2 = smethod_24(num, color2, this.DefaultHoveredState.ForeColor);
            color3 = smethod_24(num, color3, this.DefaultHoveredState.FillColor);
            color4 = smethod_23(num, color4, this.DefaultHoveredState.PlaceholderForeColor);
            if (this.DefaultStyle == TextBoxStyle.Default) {
                color = smethod_24(num2, color, this.DefaultFocusedState.BorderColor);
            }
            color2 = smethod_24(num2, color2, this.DefaultFocusedState.ForeColor);
            color3 = smethod_24(num2, color3, this.DefaultFocusedState.FillColor);
            color4 = smethod_23(num2, color4, this.DefaultFocusedState.PlaceholderForeColor);
            if (this.DefaultStyle == TextBoxStyle.Default) {
                if (this.int_0 > 0) {
                    graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath graphicsPath = smethod_12(smethod_11(base.ClientRectangle), (float)(checked(this.int_0 * 2)));
                    graphics_0.FillPath(new SolidBrush(color3), graphicsPath);
                    graphics_0.SmoothingMode = SmoothingMode.HighQuality;
                    if (this.int_1 > 0) {
                        smethod_20(graphics_0, new SolidBrush(color), base.ClientRectangle, this.int_0, this.int_1, this.dashStyle_0);
                    }
                } else {
                    graphics_0.FillRectangle(new SolidBrush(color3), base.ClientRectangle);
                    smethod_22(graphics_0, new SolidBrush(color), base.ClientRectangle, this.int_1, this.dashStyle_0);
                }
            } else {
                int num3 = this.int_1;
                if (num3 < 1) {
                    num3 = 1;
                }
                num3 = ((this.Owner.Focused || this.Focused) ? (num3 + 1) : num3);
                graphics_0.FillRectangle(new SolidBrush(color3), base.ClientRectangle);
                Color color5 = ((this.DefaultFocusedState.BorderColor == Color.Empty) ? ((this.DefaultHoveredState.BorderColor == Color.Empty) ? this.color_1 : this.DefaultHoveredState.BorderColor) : this.DefaultFocusedState.BorderColor);
                if (!this.animationManager_1.IsAnimating()) {
                    graphics_0.FillRectangle(this.Owner.Focused ? new SolidBrush(color5) : new SolidBrush(color), 0, base.Height - num3, base.Width, num3);
                } else {
                    int num4 = (int)((double)base.Width * this.animationManager_1.GetProgress());
                    int num5 = num4 / 2;
                    int num6 = base.Width / 2;
                    int num7 = base.Height - this.int_1;
                    graphics_0.FillRectangle(new SolidBrush(color), 0, num7, base.Width, this.int_1);
                    num7 = base.Height - num3;
                    graphics_0.FillRectangle(new SolidBrush(color5), num6 - num5, num7, num4, num3);
                }
            }
            if (image != null) {
                graphics_0.DrawImage(image, new Rectangle(5 + this.point_1.X, base.Height / 2 - this.size_0.Height / 2 + this.point_1.Y, this.size_0.Width, this.size_0.Height));
            }
            if (image2 != null) {
                graphics_0.DrawImage(image2, new Rectangle(base.Width - (this.size_1.Width + 5 + this.point_2.X), base.Height / 2 - this.size_0.Height / 2 + this.point_2.Y, this.size_1.Width, this.size_1.Height));
            }
            if (this.Owner.BackColor != color3) {
                this.Owner.BackColor = color3;
            }
            if (this.Owner.Boolean_0) {
                if (this.Owner.ForeColor != this.color_0) {
                    this.Owner.ForeColor = this.color_0;
                }
            } else if (this.Owner.ForeColor != color2) {
                this.Owner.ForeColor = color2;
            }
        }

        internal static void smethod_20(Graphics graphics_0, Brush brush_0, Rectangle rectangle_1, int int_0, int int_1, DashStyle dashStyle_0 = DashStyle.Solid) {
            if (int_1 >= 1) {
                GraphicsPath graphicsPath = smethod_15(rectangle_1, (float)int_0, (float)int_1);
                using (Pen pen = new Pen(brush_0, (float)int_1)) {
                    pen.DashStyle = dashStyle_0;
                    graphics_0.DrawPath(pen, graphicsPath);
                }
            }
        }

        internal static GraphicsPath smethod_15(Rectangle rectangle_1, float float_0, float float_1) {
            RectangleF rectangleF = new RectangleF((float)rectangle_1.X, (float)rectangle_1.Y, (float)rectangle_1.Width, (float)rectangle_1.Height);
            rectangleF.Width -= 1f;
            rectangleF.Height -= 1f;
            GraphicsPath graphicsPath;
            if (float_1 != 1f) {
                float num = float_1 / 2f;
                rectangleF.X += num;
                rectangleF.Y += num;
                rectangleF.Width -= float_1;
                rectangleF.Height -= float_1;
                graphicsPath = smethod_12(rectangleF, float_0 * 2f - 1f);
            } else {
                graphicsPath = smethod_12(rectangleF, float_0 * 2f);
            }
            return graphicsPath;
        }

        internal static RectangleF smethod_11(RectangleF rectangleF_0) {
            return new RectangleF(rectangleF_0.X, rectangleF_0.Y, rectangleF_0.Width - 1f, rectangleF_0.Height - 1f);
        }

        // Token: 0x06000649 RID: 1609 RVA: 0x00016740 File Offset: 0x00014940
        internal static GraphicsPath smethod_12(RectangleF rectangleF_0, float float_0) {
            RectangleF rectangleF = rectangleF_0;
            rectangleF.X -= 0.1f;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rectangleF.X, rectangleF.Y, float_0, float_0, 180f, 90f);
            graphicsPath.AddArc(rectangleF.X + rectangleF.Width - float_0, rectangleF.Y, float_0, float_0, 270f, 90f);
            graphicsPath.AddArc(rectangleF.X + rectangleF.Width - float_0, rectangleF.Y + rectangleF.Height - float_0, float_0, float_0, 0f, 90f);
            graphicsPath.AddArc(rectangleF.X, rectangleF.Y + rectangleF.Height - float_0, float_0, float_0, 90f, 90f);
            graphicsPath.CloseAllFigures();
            return graphicsPath;
        }


        internal static void smethod_22(Graphics graphics_0, Brush brush_0, Rectangle rectangle_1, int int_0, DashStyle dashStyle_0 = DashStyle.Solid) {
            if (int_0 >= 1) {
                using (Pen pen = new Pen(brush_0, (float)int_0)) {
                    pen.DashStyle = dashStyle_0;
                    GraphicsPath graphicsPath = new GraphicsPath();
                    RectangleF rectangleF = new RectangleF((float)rectangle_1.X, (float)rectangle_1.Y, (float)rectangle_1.Width, (float)rectangle_1.Height);
                    float num = (float)int_0 / 2f;
                    if (int_0 > 1) {
                        rectangleF.X += num;
                        rectangleF.Y += num;
                    }
                    rectangleF.Width -= (float)int_0;
                    rectangleF.Height -= (float)int_0;
                    graphicsPath.AddRectangle(rectangleF);
                    graphics_0.DrawPath(pen, graphicsPath);
                }
            }
        }
        internal static Color smethod_23(int int_0, Color color_1, Color color_2) {
            Color color = color_1;
            Color color2 = color_2;
            if (int_0 < 100) {
                if (color == Color.Transparent) {
                    color = Color.Empty;
                }
                if (color2 == Color.Transparent) {
                    color2 = Color.Empty;
                }
            }
            int a = (int)color.A;
            int r = (int)color.R;
            int g = (int)color.G;
            int b = (int)color.B;
            int a2 = (int)color2.A;
            int r2 = (int)color2.R;
            int g2 = (int)color2.G;
            int b2 = (int)color2.B;
            double num = Math.Round((double)a + (double)(checked((a2 - a) * int_0)) * 0.01, 0);
            double num2 = Math.Round((double)r + (double)(checked((r2 - r) * int_0)) * 0.01);
            double num3 = Math.Round((double)g + (double)(checked((g2 - g) * int_0)) * 0.01, 0);
            double num4 = Math.Round((double)b + (double)(checked((b2 - b) * int_0)) * 0.01);
            return Color.FromArgb((int)num, (int)num2, (int)num3, (int)num4);
        }

        internal static Color smethod_24(int int_0, Color color_1, Color color_2) {
            Color color = color_1;
            Color color2 = color_2;
            if ((color == Color.Transparent) | (color == Color.Empty)) {
                color = Color.Black;
            }
            if ((color2 == Color.Transparent) | (color2 == Color.Empty)) {
                color2 = color;
            }
            Color color3;
            if (color == color2) {
                color3 = color;
            } else {
                int r = (int)color.R;
                int g = (int)color.G;
                int b = (int)color.B;
                int r2 = (int)color2.R;
                int g2 = (int)color2.G;
                int b2 = (int)color2.B;
                double num = Math.Round((double)r + (double)(checked((r2 - r) * int_0)) * 0.01, 0);
                double num2 = Math.Round((double)g + (double)(checked((g2 - g) * int_0)) * 0.01, 0);
                double num3 = Math.Round((double)b + (double)(checked((b2 - b) * int_0)) * 0.01, 0);
                color3 = Color.FromArgb(255, (int)num, (int)num2, (int)num3);
            }
            return color3;
        }

        // Token: 0x06000BF7 RID: 3063 RVA: 0x00007A5A File Offset: 0x00005C5A
        private void method_9(bool bool_2) {
            if (bool_2) {
                this.Owner.ForeColor = this.color_0;
            }
        }

        // Token: 0x06000BF8 RID: 3064 RVA: 0x00007A70 File Offset: 0x00005C70
        private void Owner_TextChanged(object sender, EventArgs e) {
            base.Invalidate();
            this.OnTextChanged(e);
        }

        // Token: 0x06000BF9 RID: 3065 RVA: 0x00007A7F File Offset: 0x00005C7F
        private void Owner_KeyDown(object sender, KeyEventArgs e) {
            base.OnKeyDown(e);
        }

        // Token: 0x06000BFA RID: 3066 RVA: 0x00007A88 File Offset: 0x00005C88
        private void Owner_KeyPress(object sender, KeyPressEventArgs e) {
            base.OnKeyPress(e);
        }

        // Token: 0x06000BFB RID: 3067 RVA: 0x00007A91 File Offset: 0x00005C91
        private void Owner_KeyUp(object sender, KeyEventArgs e) {
            base.OnKeyUp(e);
        }

        // Token: 0x06000BFC RID: 3068 RVA: 0x00007A9A File Offset: 0x00005C9A
        private void Owner_MouseLeave(object sender, EventArgs e) {
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000BFD RID: 3069 RVA: 0x00007A9A File Offset: 0x00005C9A
        private void Owner_MouseEnter(object sender, EventArgs e) {
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000BFE RID: 3070 RVA: 0x0000526F File Offset: 0x0000346F
        private void Owner_MouseDown(object sender, MouseEventArgs e) {
        }

        // Token: 0x06000BFF RID: 3071 RVA: 0x00007A9A File Offset: 0x00005C9A
        private void Owner_MouseUp(object sender, MouseEventArgs e) {
            this.method_5(this.mouseState_0, this.Owner.mouseState_0);
        }

        // Token: 0x06000C00 RID: 3072 RVA: 0x00007AB3 File Offset: 0x00005CB3
        private void method_10(bool bool_2) {
            this.method_6(base.Focused, bool_2);
        }

        // Token: 0x0400031B RID: 795
        private IContainer icontainer_0 = null;

        // Token: 0x0400031C RID: 796
        private Class8 Owner;

        // Token: 0x0400031D RID: 797
        private AnimationManager animationManager_0;

        // Token: 0x0400031E RID: 798
        private AnimationManager animationManager_1;

        // Token: 0x0400031F RID: 799
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private EventHandler eventHandler_0;

        // Token: 0x04000320 RID: 800
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EventHandler eventHandler_1;

        // Token: 0x04000321 RID: 801
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private EventHandler eventHandler_2;

        // Token: 0x04000322 RID: 802
        private TextBoxState textBoxState_0;

        // Token: 0x04000323 RID: 803
        private TextBoxState textBoxState_1;

        // Token: 0x04000324 RID: 804
        private TextBoxState textBoxState_2;

        // Token: 0x04000325 RID: 805
        private bool bool_0 = true;

        // Token: 0x04000326 RID: 806
        private TextBoxStyle textBoxStyle_0 = TextBoxStyle.Default;

        // Token: 0x04000327 RID: 807
        private Point point_0;

        // Token: 0x04000328 RID: 808
        private Color color_0 = Color.FromArgb(193, 200, 207);

        // Token: 0x04000329 RID: 809
        private int int_0 = 0;

        // Token: 0x0400032A RID: 810
        private DashStyle dashStyle_0 = DashStyle.Solid;

        // Token: 0x0400032B RID: 811
        private Color color_1 = Color.FromArgb(213, 218, 223);

        // Token: 0x0400032C RID: 812
        private int int_1 = 1;

        // Token: 0x0400032D RID: 813
        private ShadowDecoration shadowDecoration_0;

        // Token: 0x0400032E RID: 814
        private Image image_0;

        // Token: 0x0400032F RID: 815
        private Size size_0 = new Size(20, 20);

        // Token: 0x04000330 RID: 816
        private Cursor cursor_0 = Cursors.Default;

        // Token: 0x04000331 RID: 817
        private Point point_1;

        // Token: 0x04000332 RID: 818
        private Image image_1;

        // Token: 0x04000333 RID: 819
        private Size size_1 = new Size(20, 20);

        // Token: 0x04000334 RID: 820
        private Cursor cursor_1 = Cursors.Default;

        // Token: 0x04000335 RID: 821
        private Point point_2;

        // Token: 0x04000336 RID: 822
        private Color color_2 = Color.White;

        // Token: 0x04000337 RID: 823
        private Point point_3;

        // Token: 0x04000338 RID: 824
        private bool bool_1 = false;

        // Token: 0x04000339 RID: 825
        internal MouseState mouseState_0 = MouseState.const_2;

        // Token: 0x0400033A RID: 826
        private Padding padding_0 = new Padding(9, 9, 9, 9);
    }

    public enum TextBoxStyle {
        // Token: 0x040003D5 RID: 981
        Default,
        // Token: 0x040003D6 RID: 982
        Material
    }
}
