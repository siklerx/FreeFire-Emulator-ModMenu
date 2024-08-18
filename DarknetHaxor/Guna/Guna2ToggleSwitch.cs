using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace AimBotConquer.Guna
{
    // Token: 0x02000049 RID: 73
    [ToolboxItem(true)]
    [Description("A ToggleSwitch Control")]
    [DebuggerStepThrough]
    public class Guna2ToggleSwitch : ToggleSwitch
    {
        // Token: 0x06000597 RID: 1431 RVA: 0x00014980 File Offset: 0x00012B80
        public Guna2ToggleSwitch()
        {
            base.DefaultCheckedState.Parent = this;
            base.DefaultCheckedState.BorderColor = color_19;
            base.DefaultCheckedState.FillColor = color_19;
            base.DefaultCheckedState.InnerBorderColor = Color.White;
            base.DefaultCheckedState.InnerColor = Color.White;
            base.DefaultUncheckedState.Parent = this;
            base.DefaultUncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            base.DefaultUncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            base.DefaultUncheckedState.InnerBorderColor = Color.White;
            base.DefaultUncheckedState.InnerColor = Color.White;
            base.Size = new Size(35, 20);
        }

        internal static Color color_19 = Color.FromArgb(94, 148, 255);

        // Token: 0x17000239 RID: 569
        // (get) Token: 0x06000598 RID: 1432 RVA: 0x00014A54 File Offset: 0x00012C54
        // (set) Token: 0x06000599 RID: 1433 RVA: 0x0000486B File Offset: 0x00002A6B
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("The properties that will be applied when the control is in a checked state")]
        [Browsable(true)]
        public ToggleSwitchState CheckedState
        {
            get
            {
                return base.DefaultCheckedState;
            }
            set
            {
                base.DefaultCheckedState = value;
            }
        }

        // Token: 0x1700023A RID: 570
        // (get) Token: 0x0600059A RID: 1434 RVA: 0x00014A6C File Offset: 0x00012C6C
        // (set) Token: 0x0600059B RID: 1435 RVA: 0x00004874 File Offset: 0x00002A74
        [Description("The properties that will be applied when the control is in an unchecked state")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true)]
        public ToggleSwitchState UncheckedState
        {
            get
            {
                return base.DefaultUncheckedState;
            }
            set
            {
                base.DefaultUncheckedState = value;
            }
        }

        // Token: 0x1700023B RID: 571
        // (get) Token: 0x0600059C RID: 1436 RVA: 0x0000487D File Offset: 0x00002A7D
        // (set) Token: 0x0600059D RID: 1437 RVA: 0x00004885 File Offset: 0x00002A85
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Description("The toggle switch's font style")]
        [Browsable(false)]
        public new Font Font
        {
            [CompilerGenerated]
            get
            {
                return this.font_0;
            }
            [CompilerGenerated]
            set
            {
                this.font_0 = value;
            }
        }

        // Token: 0x1700023C RID: 572
        // (get) Token: 0x0600059E RID: 1438 RVA: 0x0000488E File Offset: 0x00002A8E
        // (set) Token: 0x0600059F RID: 1439 RVA: 0x00004896 File Offset: 0x00002A96
        [Browsable(false)]
        [Description("The toggle switch's text")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string Text
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        // Token: 0x1700023D RID: 573
        // (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000489F File Offset: 0x00002A9F
        // (set) Token: 0x060005A1 RID: 1441 RVA: 0x000048A7 File Offset: 0x00002AA7
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [Description("The toggle switch's ForeColor")]
        public new string ForeColor
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            set
            {
                this.string_1 = value;
            }
        }

        // Token: 0x1700023E RID: 574
        // (get) Token: 0x060005A2 RID: 1442 RVA: 0x00003DE8 File Offset: 0x00001FE8
        // (set) Token: 0x060005A3 RID: 1443 RVA: 0x00003DF0 File Offset: 0x00001FF0
        [DefaultValue(true)]
        [Browsable(true)]
        [Description("If true, the control will be animated while interacting with the mouse")]
        public bool Animated
        {
            get
            {
                return base.DefaultAnimated;
            }
            set
            {
                base.DefaultAnimated = value;
            }
        }

        // Token: 0x1700023F RID: 575
        // (get) Token: 0x060005A4 RID: 1444 RVA: 0x00014A84 File Offset: 0x00012C84
        // (set) Token: 0x060005A5 RID: 1445 RVA: 0x000048B0 File Offset: 0x00002AB0
        [Browsable(true)]
        [DefaultValue(DashStyle.Solid)]
        [Description("The css-like style of the border. You can customize the border to meet your design needs")]
        public DashStyle BorderStyle
        {
            get
            {
                return base.DefaultBorderStyle;
            }
            set
            {
                base.DefaultBorderStyle = value;
            }
        }

        // Token: 0x17000240 RID: 576
        // (get) Token: 0x060005A6 RID: 1446 RVA: 0x00014A9C File Offset: 0x00012C9C
        // (set) Token: 0x060005A7 RID: 1447 RVA: 0x000048B9 File Offset: 0x00002AB9
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Shadow property of the control to add and customize a control's shadow")]
        [Browsable(true)]
        public ShadowDecoration ShadowDecoration
        {
            get
            {
                return base.DefaultShadowDecoration;
            }
            set
            {
                base.DefaultShadowDecoration = value;
            }
        }

        // Token: 0x17000241 RID: 577
        // (get) Token: 0x060005A8 RID: 1448 RVA: 0x000048C2 File Offset: 0x00002AC2
        // (set) Token: 0x060005A9 RID: 1449 RVA: 0x000048CA File Offset: 0x00002ACA
        [Browsable(true)]
        [DefaultValue(false)]
        [Description("If true, the background will allow a transparent color")]
        public bool UseTransparentBackground
        {
            get
            {
                return base.DefaultUseTransparentBackground;
            }
            set
            {
                base.DefaultUseTransparentBackground = value;
            }
        }

        // Token: 0x17000242 RID: 578
        // (get) Token: 0x060005AA RID: 1450 RVA: 0x00003E49 File Offset: 0x00002049
        // (set) Token: 0x060005AB RID: 1451 RVA: 0x00003E51 File Offset: 0x00002051
        [Browsable(true)]
        [DefaultValue(false)]
        [Description("The properties that will be applied when the control is checked")]
        public bool Checked
        {
            get
            {
                return base.DefaultChecked;
            }
            set
            {
                base.DefaultChecked = value;
            }
        }

        // Token: 0x0400011E RID: 286
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Font font_0;

        // Token: 0x0400011F RID: 287
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private string string_0;

        // Token: 0x04000120 RID: 288
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private string string_1;
    }
}
