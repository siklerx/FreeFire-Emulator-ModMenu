using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace AimBotConquer.Guna
{
    public enum MouseState
    {
        // Token: 0x040003AB RID: 939
        HOVER,
        // Token: 0x040003AC RID: 940
        DOWN,
        // Token: 0x040003AD RID: 941
        const_2
    }

    // Token: 0x02000087 RID: 135
    [ToolboxItem(false)]
    [DefaultEvent("CheckedChanged")]
    public class ToggleSwitch : Control, IControl
    {
        // Token: 0x06000C01 RID: 3073 RVA: 0x00028D84 File Offset: 0x00026F84
        public ToggleSwitch()
        {
            base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            this.method_0();
        }

        // Token: 0x17000432 RID: 1074
        // (get) Token: 0x06000C02 RID: 3074 RVA: 0x00002714 File Offset: 0x00000914
        [Browsable(false)]
        [Description("Gets a value that indicates whether the Component is currently in design mode.")]
        public bool IsDesignMode
        {
            get
            {
                return base.DesignMode;
            }
        }

        // Token: 0x06000C03 RID: 3075 RVA: 0x00007AC2 File Offset: 0x00005CC2
        private void method_0()
        {
            this.animationManager_0 = new AnimationManager(true)
            {
                Increment = 0.079999998211860657,
                AnimationType = AnimationType.EaseOut
            };
            this.animationManager_0.OnAnimationProgress += this.method_1;
        }

        // Token: 0x06000C04 RID: 3076 RVA: 0x000045AA File Offset: 0x000027AA
        private void method_1(object object_0)
        {
            base.Invalidate();
        }

        // Token: 0x17000433 RID: 1075
        // (get) Token: 0x06000C05 RID: 3077 RVA: 0x00028DE4 File Offset: 0x00026FE4
        // (set) Token: 0x06000C06 RID: 3078 RVA: 0x00007AFD File Offset: 0x00005CFD
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected ToggleSwitchState DefaultCheckedState
        {
            get
            {
                if (this.toggleSwitchState_0 == null)
                {
                    this.toggleSwitchState_0 = new ToggleSwitchState
                    {
                        Parent = this
                    };
                }
                return this.toggleSwitchState_0;
            }
            set
            {
                this.toggleSwitchState_0 = value;
            }
        }

        // Token: 0x17000434 RID: 1076
        // (get) Token: 0x06000C07 RID: 3079 RVA: 0x00028E18 File Offset: 0x00027018
        // (set) Token: 0x06000C08 RID: 3080 RVA: 0x00007B06 File Offset: 0x00005D06
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected ToggleSwitchState DefaultUncheckedState
        {
            get
            {
                if (this.toggleSwitchState_1 == null)
                {
                    this.toggleSwitchState_1 = new ToggleSwitchState
                    {
                        Parent = this
                    };
                }
                return this.toggleSwitchState_1;
            }
            set
            {
                this.toggleSwitchState_1 = value;
            }
        }

        // Token: 0x17000435 RID: 1077
        // (get) Token: 0x06000C09 RID: 3081 RVA: 0x00007B0F File Offset: 0x00005D0F
        // (set) Token: 0x06000C0A RID: 3082 RVA: 0x00007B17 File Offset: 0x00005D17
        [Browsable(false)]
        protected bool DefaultAnimated
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        // Token: 0x17000436 RID: 1078
        // (get) Token: 0x06000C0B RID: 3083 RVA: 0x00028E4C File Offset: 0x0002704C
        // (set) Token: 0x06000C0C RID: 3084 RVA: 0x00007B20 File Offset: 0x00005D20
        [Browsable(false)]
        protected DashStyle DefaultBorderStyle
        {
            get
            {
                return this.dashStyle_0;
            }
            set
            {
                this.dashStyle_0 = value;
                base.Invalidate();
            }
        }

        // Token: 0x17000437 RID: 1079
        // (get) Token: 0x06000C0D RID: 3085 RVA: 0x00028E64 File Offset: 0x00027064
        // (set) Token: 0x06000C0E RID: 3086 RVA: 0x00007B2F File Offset: 0x00005D2F
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        protected ShadowDecoration DefaultShadowDecoration
        {
            get
            {
                if (this.shadowDecoration_0 == null)
                {
                    this.shadowDecoration_0 = new ShadowDecoration(this);
                }
                return this.shadowDecoration_0;
            }
            set
            {
                this.shadowDecoration_0 = value;
            }
        }

        // Token: 0x17000438 RID: 1080
        // (get) Token: 0x06000C0F RID: 3087 RVA: 0x00007B38 File Offset: 0x00005D38
        // (set) Token: 0x06000C10 RID: 3088 RVA: 0x00007B40 File Offset: 0x00005D40
        [Browsable(false)]
        protected bool DefaultChecked
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
                this.OnCheckedChanged(EventArgs.Empty);
            }
        }

        // Token: 0x06000C11 RID: 3089 RVA: 0x00007B54 File Offset: 0x00005D54
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.bool_2 = true;
            this.mouseState_0 = MouseState.DOWN;
            if (this.bool_3)
            {
                base.Invalidate();
            }
            base.OnMouseDown(e);
        }

        // Token: 0x06000C12 RID: 3090 RVA: 0x00007B79 File Offset: 0x00005D79
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.mouseState_0 = (this.bool_2 ? MouseState.HOVER : MouseState.const_2);
            if (this.bool_3)
            {
                base.Invalidate();
            }
            base.OnMouseUp(e);
        }

        // Token: 0x06000C13 RID: 3091 RVA: 0x00007BA2 File Offset: 0x00005DA2
        protected override void OnMouseEnter(EventArgs e)
        {
            this.bool_2 = true;
            this.mouseState_0 = MouseState.HOVER;
            if (this.bool_3)
            {
                base.Invalidate();
            }
            base.OnMouseEnter(e);
        }

        // Token: 0x06000C14 RID: 3092 RVA: 0x00007BC7 File Offset: 0x00005DC7
        protected override void OnMouseLeave(EventArgs e)
        {
            this.bool_2 = false;
            this.mouseState_0 = MouseState.const_2;
            if (this.bool_3)
            {
                base.Invalidate();
            }
            base.OnMouseLeave(e);
        }

        // Token: 0x06000C15 RID: 3093 RVA: 0x00007BEC File Offset: 0x00005DEC
        protected override void OnLostFocus(EventArgs e)
        {
            this.bool_2 = false;
            this.mouseState_0 = MouseState.const_2;
            if (this.bool_4)
            {
                base.Invalidate();
            }
            base.OnLostFocus(e);
        }

        // Token: 0x17000439 RID: 1081
        // (get) Token: 0x06000C16 RID: 3094 RVA: 0x00007C11 File Offset: 0x00005E11
        // (set) Token: 0x06000C17 RID: 3095 RVA: 0x00007C19 File Offset: 0x00005E19
        [Browsable(false)]
        protected bool DefaultUseTransparentBackground
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
                base.Invalidate();
            }
        }

        // Token: 0x06000C18 RID: 3096 RVA: 0x00028E90 File Offset: 0x00027090
        private void method_2(Graphics graphics_0)
        {
            if (this.bool_5)
            {
                graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics_0.CompositingQuality = CompositingQuality.GammaCorrected;
                if (base.Parent != null)
                {
                    if (this.BackColor != Color.Transparent)
                    {
                        this.BackColor = Color.Transparent;
                    }
                    int childIndex = base.Parent.Controls.GetChildIndex(this);
                    int num = base.Parent.Controls.Count - 1;
                    int num2 = childIndex + 1;
                    for (int i = num; i >= num2; i += -1)
                    {
                        Control control = base.Parent.Controls[i];
                        if (control.Bounds.IntersectsWith(base.Bounds) && control.Visible)
                        {
                            Bitmap bitmap = new Bitmap(control.Width, control.Height, graphics_0);
                            control.DrawToBitmap(bitmap, control.ClientRectangle);
                            graphics_0.TranslateTransform((float)(control.Left - base.Left), (float)(control.Top - base.Top));
                            graphics_0.DrawImageUnscaled(bitmap, Point.Empty);
                            graphics_0.TranslateTransform((float)(base.Left - control.Left), (float)(base.Top - control.Top));
                            bitmap.Dispose();
                        }
                    }
                }
            }
        }

        // Token: 0x06000C19 RID: 3097 RVA: 0x00007C28 File Offset: 0x00005E28
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            this.method_2(e.Graphics);
        }

        // Token: 0x14000030 RID: 48
        // (add) Token: 0x06000C1A RID: 3098 RVA: 0x00028FE4 File Offset: 0x000271E4
        // (remove) Token: 0x06000C1B RID: 3099 RVA: 0x0002901C File Offset: 0x0002721C
        public event EventHandler CheckedChanged
        {
            [CompilerGenerated]
            add
            {
                EventHandler eventHandler = this.eventHandler_0;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            [CompilerGenerated]
            remove
            {
                EventHandler eventHandler = this.eventHandler_0;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler eventHandler3 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler3, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }

        // Token: 0x06000C1C RID: 3100 RVA: 0x00029054 File Offset: 0x00027254
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected virtual void OnCheckedChanged(EventArgs e)
        {
            if (this.animationManager_0 != null && !base.DesignMode)
            {
                this.animationManager_0.StartNewAnimation(this.bool_1 ? AnimationDirection.In : AnimationDirection.Out, null);
            }
            base.Invalidate();
            if (this.eventHandler_0 != null)
            {
                this.eventHandler_0(this, EventArgs.Empty);
            }
        }

        // Token: 0x06000C1D RID: 3101 RVA: 0x00007C3D File Offset: 0x00005E3D
        protected override void OnClick(EventArgs e)
        {
            if (!this.bool_1)
            {
                this.DefaultChecked = true;
            }
            else
            {
                this.DefaultChecked = false;
            }
            base.OnClick(e);
        }

        // Token: 0x06000C1E RID: 3102 RVA: 0x000290B4 File Offset: 0x000272B4
        private void method_3(Graphics graphics_0, ToggleSwitchState toggleSwitchState_2)
        {
            int num = toggleSwitchState_2.BorderRadius;
            if (this.bool_0 && !base.DesignMode && base.Enabled)
            {
                Color color = smethod_23((int)(this.animationManager_0.GetProgress() * 100.0), this.DefaultUncheckedState.FillColor, this.DefaultCheckedState.FillColor);
                Color color2 = smethod_23((int)(this.animationManager_0.GetProgress() * 100.0), this.DefaultUncheckedState.BorderColor, this.DefaultCheckedState.BorderColor);
                if (num > 0)
                {
                    graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath graphicsPath = smethod_12(smethod_11(base.ClientRectangle), (float)(num * 2));
                    graphics_0.FillPath(new SolidBrush(color), graphicsPath);
                    if (toggleSwitchState_2.BorderThickness < 1)
                    {
                        graphics_0.DrawPath(new Pen(Color.FromArgb(180, color)), graphicsPath);
                    }
                    smethod_20(graphics_0, new SolidBrush(color2), base.ClientRectangle, num, toggleSwitchState_2.BorderThickness, this.dashStyle_0);
                }
                else
                {
                    graphics_0.SmoothingMode = SmoothingMode.Default;
                    graphics_0.FillRectangle(new SolidBrush(color), base.ClientRectangle);
                    smethod_22(graphics_0, new SolidBrush(color2), base.ClientRectangle, toggleSwitchState_2.BorderThickness, this.dashStyle_0);
                }
                int num2 = toggleSwitchState_2.InnerOffset + 8;
                int num3 = num2 / 2;
                num = toggleSwitchState_2.InnerBorderRadius;
                int num4 = Math.Max(num3, (int)(this.animationManager_0.GetProgress() * (double)(base.Width - (base.Height - num2 + num3))));
                color = smethod_23((int)(this.animationManager_0.GetProgress() * 100.0), this.DefaultUncheckedState.InnerColor, this.DefaultCheckedState.InnerColor);
                color2 = smethod_23((int)(this.animationManager_0.GetProgress() * 100.0), this.DefaultUncheckedState.InnerBorderColor, this.DefaultCheckedState.InnerBorderColor);
                Rectangle rectangle = new Rectangle(num4, num3, base.Height - num2, base.Height - num2);
                if (num > 0)
                {
                    graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath graphicsPath = smethod_12(smethod_11(rectangle), (float)(num * 2));
                    graphics_0.FillPath(new SolidBrush(color), graphicsPath);
                    if (toggleSwitchState_2.InnerBorderThickness < 1)
                    {
                        graphics_0.DrawPath(new Pen(Color.FromArgb(180, color)), graphicsPath);
                    }
                    smethod_20(graphics_0, new SolidBrush(color2), rectangle, num, toggleSwitchState_2.InnerBorderThickness, this.dashStyle_0);
                }
                else
                {
                    graphics_0.SmoothingMode = SmoothingMode.Default;
                    graphics_0.FillRectangle(new SolidBrush(color), rectangle);
                    smethod_22(graphics_0, new SolidBrush(color2), rectangle, toggleSwitchState_2.InnerBorderThickness, this.dashStyle_0);
                }
            }
            else
            {
                Color color = toggleSwitchState_2.FillColor;
                Color color2 = toggleSwitchState_2.BorderColor;
                if (num > 0)
                {
                    graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath graphicsPath = smethod_12(smethod_11(base.ClientRectangle), (float)(num * 2));
                    graphics_0.FillPath(new SolidBrush(color), graphicsPath);
                    if (toggleSwitchState_2.BorderThickness < 1)
                    {
                        graphics_0.DrawPath(new Pen(Color.FromArgb(180, color)), graphicsPath);
                    }
                    smethod_20(graphics_0, new SolidBrush(color2), base.ClientRectangle, num, toggleSwitchState_2.BorderThickness, this.dashStyle_0);
                }
                else
                {
                    graphics_0.SmoothingMode = SmoothingMode.Default;
                    graphics_0.FillRectangle(new SolidBrush(color), base.ClientRectangle);
                    smethod_22(graphics_0, new SolidBrush(color2), base.ClientRectangle, toggleSwitchState_2.BorderThickness, this.dashStyle_0);
                }
                int num5 = toggleSwitchState_2.InnerOffset + 8;
                int num6 = num5 / 2;
                num = toggleSwitchState_2.InnerBorderRadius;
                int num4 = (this.bool_1 ? (base.Width - (base.Height - num5 + num6)) : num6);
                color = toggleSwitchState_2.InnerColor;
                color2 = toggleSwitchState_2.InnerBorderColor;
                Rectangle rectangle2 = new Rectangle(num4, num6, base.Height - num5, base.Height - num5);
                if (num > 0)
                {
                    graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath graphicsPath = smethod_12(smethod_11(rectangle2), (float)(num * 2));
                    graphics_0.FillPath(new SolidBrush(color), graphicsPath);
                    if (toggleSwitchState_2.InnerBorderThickness < 1)
                    {
                        graphics_0.DrawPath(new Pen(Color.FromArgb(180, color)), graphicsPath);
                    }
                    smethod_20(graphics_0, new SolidBrush(color2), rectangle2, num, toggleSwitchState_2.InnerBorderThickness, this.dashStyle_0);
                }
                else
                {
                    graphics_0.SmoothingMode = SmoothingMode.Default;
                    graphics_0.FillRectangle(new SolidBrush(color), rectangle2);
                    smethod_22(graphics_0, new SolidBrush(color2), rectangle2, toggleSwitchState_2.InnerBorderThickness, this.dashStyle_0);
                }
            }
        }

        internal static RectangleF smethod_11(RectangleF rectangleF_0)
        {
            return new RectangleF(rectangleF_0.X, rectangleF_0.Y, rectangleF_0.Width - 1f, rectangleF_0.Height - 1f);
        }

        internal static GraphicsPath smethod_12(RectangleF rectangleF_0, float float_0)
        {
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

        internal static Color smethod_23(int int_0, Color color_1, Color color_2)
        {
            Color color = color_1;
            Color color2 = color_2;
            if (int_0 < 100)
            {
                if (color == Color.Transparent)
                {
                    color = Color.Empty;
                }
                if (color2 == Color.Transparent)
                {
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

        internal static void smethod_20(Graphics graphics_0, Brush brush_0, Rectangle rectangle_1, int int_0, int int_1, DashStyle dashStyle_0 = DashStyle.Solid)
        {
            if (int_1 >= 1)
            {
                GraphicsPath graphicsPath = smethod_15(rectangle_1, (float)int_0, (float)int_1);
                using (Pen pen = new Pen(brush_0, (float)int_1))
                {
                    pen.DashStyle = dashStyle_0;
                    graphics_0.DrawPath(pen, graphicsPath);
                }
            }
        }

        internal static GraphicsPath smethod_15(Rectangle rectangle_1, float float_0, float float_1)
        {
            RectangleF rectangleF = new RectangleF((float)rectangle_1.X, (float)rectangle_1.Y, (float)rectangle_1.Width, (float)rectangle_1.Height);
            rectangleF.Width -= 1f;
            rectangleF.Height -= 1f;
            GraphicsPath graphicsPath;
            if (float_1 != 1f)
            {
                float num = float_1 / 2f;
                rectangleF.X += num;
                rectangleF.Y += num;
                rectangleF.Width -= float_1;
                rectangleF.Height -= float_1;
                graphicsPath = smethod_12(rectangleF, float_0 * 2f - 1f);
            }
            else
            {
                graphicsPath = smethod_12(rectangleF, float_0 * 2f);
            }
            return graphicsPath;
        }

        internal static void smethod_22(Graphics graphics_0, Brush brush_0, Rectangle rectangle_1, int int_0, DashStyle dashStyle_0 = DashStyle.Solid)
        {
            if (int_0 >= 1)
            {
                using (Pen pen = new Pen(brush_0, (float)int_0))
                {
                    pen.DashStyle = dashStyle_0;
                    GraphicsPath graphicsPath = new GraphicsPath();
                    RectangleF rectangleF = new RectangleF((float)rectangle_1.X, (float)rectangle_1.Y, (float)rectangle_1.Width, (float)rectangle_1.Height);
                    float num = (float)int_0 / 2f;
                    if (int_0 > 1)
                    {
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

        // Token: 0x06000C1F RID: 3103 RVA: 0x0002952C File Offset: 0x0002772C
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!base.Enabled)
            {
                Bitmap bitmap = new Bitmap(base.Width, base.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                if (this.bool_1)
                {
                    this.method_3(graphics, this.DefaultCheckedState);
                }
                else
                {
                    this.method_3(graphics, this.DefaultUncheckedState);
                }
                ControlPaint.DrawImageDisabled(e.Graphics, bitmap, 0, 0, Color.White);
            }
            else if (this.bool_1)
            {
                this.method_3(e.Graphics, this.DefaultCheckedState);
            }
            else
            {
                this.method_3(e.Graphics, this.DefaultUncheckedState);
            }
            base.OnPaint(e);
        }

        // Token: 0x0400033B RID: 827
        private AnimationManager animationManager_0;

        // Token: 0x0400033C RID: 828
        private ToggleSwitchState toggleSwitchState_0;

        // Token: 0x0400033D RID: 829
        private ToggleSwitchState toggleSwitchState_1;

        // Token: 0x0400033E RID: 830
        private bool bool_0 = true;

        // Token: 0x0400033F RID: 831
        private DashStyle dashStyle_0 = DashStyle.Solid;

        // Token: 0x04000340 RID: 832
        private ShadowDecoration shadowDecoration_0;

        // Token: 0x04000341 RID: 833
        private bool bool_1 = false;

        // Token: 0x04000342 RID: 834
        private bool bool_2 = false;

        // Token: 0x04000343 RID: 835
        internal bool bool_3 = false;

        // Token: 0x04000344 RID: 836
        internal bool bool_4 = false;

        // Token: 0x04000345 RID: 837
        internal MouseState mouseState_0 = MouseState.const_2;

        // Token: 0x04000346 RID: 838
        private bool bool_5;

        // Token: 0x04000347 RID: 839
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private EventHandler eventHandler_0;
    }
}
