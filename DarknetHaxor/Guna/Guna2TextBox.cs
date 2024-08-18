using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AimBotConquer.Guna
{
    // Token: 0x02000047 RID: 71
    [Description("A textbox control")]
    [DebuggerStepThrough]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(System.Windows.Forms.TextBox))]
    public class Guna2TextBox : TextBoxBase
    {
        // Token: 0x0600056B RID: 1387 RVA: 0x000146C8 File Offset: 0x000128C8
        public Guna2TextBox()
        {
            base.DefaultDisabledState.Parent = this;
            base.DefaultDisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            base.DefaultDisabledState.FillColor = Color.FromArgb(226, 226, 226);
            base.DefaultDisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            base.DefaultDisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            base.DefaultHoveredState.Parent = this;
            base.DefaultHoveredState.BorderColor = color_19;
            base.DefaultFocusedState.Parent = this;
            base.DefaultFocusedState.BorderColor = color_19;
        }

        internal static Color color_19 = Color.FromArgb(94, 148, 255);

        // Token: 0x17000224 RID: 548
        // (get) Token: 0x0600056C RID: 1388 RVA: 0x000147A0 File Offset: 0x000129A0
        // (set) Token: 0x0600056D RID: 1389 RVA: 0x00004782 File Offset: 0x00002982
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("The properties that will be applied when the cursor is over the control")]
        public TextBoxState HoveredState
        {
            get
            {
                return base.DefaultHoveredState;
            }
            set
            {
                base.DefaultHoveredState = value;
            }
        }

        // Token: 0x17000225 RID: 549
        // (get) Token: 0x0600056E RID: 1390 RVA: 0x000147B8 File Offset: 0x000129B8
        // (set) Token: 0x0600056F RID: 1391 RVA: 0x0000478B File Offset: 0x0000298B
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("The properties that will be applied when the control is focused")]
        public TextBoxState FocusedState
        {
            get
            {
                return base.DefaultFocusedState;
            }
            set
            {
                base.DefaultFocusedState = value;
            }
        }

        // Token: 0x17000226 RID: 550
        // (get) Token: 0x06000570 RID: 1392 RVA: 0x000147D0 File Offset: 0x000129D0
        // (set) Token: 0x06000571 RID: 1393 RVA: 0x00004794 File Offset: 0x00002994
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true)]
        [Description("The properties that will be applied when the cursor is in a disabled state")]
        public TextBoxState DisabledState
        {
            get
            {
                return base.DefaultDisabledState;
            }
            set
            {
                base.DefaultDisabledState = value;
            }
        }

        // Token: 0x17000227 RID: 551
        // (get) Token: 0x06000572 RID: 1394 RVA: 0x0000479D File Offset: 0x0000299D
        // (set) Token: 0x06000573 RID: 1395 RVA: 0x000047A5 File Offset: 0x000029A5
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

        // Token: 0x17000228 RID: 552
        // (get) Token: 0x06000574 RID: 1396 RVA: 0x000147E8 File Offset: 0x000129E8
        // (set) Token: 0x06000575 RID: 1397 RVA: 0x000047AE File Offset: 0x000029AE
        [DefaultValue(typeof(Point), "0, 0")]
        [Description("The control's text position")]
        public Point TextOffset
        {
            get
            {
                return base.DefaultTextOffset;
            }
            set
            {
                base.DefaultTextOffset = value;
            }
        }

        // Token: 0x17000229 RID: 553
        // (get) Token: 0x06000576 RID: 1398 RVA: 0x00014800 File Offset: 0x00012A00
        // (set) Token: 0x06000577 RID: 1399 RVA: 0x000047B7 File Offset: 0x000029B7
        [Browsable(true)]
        [Category("Options")]
        [Description("The control's placeholder text")]
        public string PlaceholderText
        {
            get
            {
                return base.DefaultPlaceholderText;
            }
            set
            {
                base.DefaultPlaceholderText = value;
            }
        }

        // Token: 0x1700022A RID: 554
        // (get) Token: 0x06000578 RID: 1400 RVA: 0x00014818 File Offset: 0x00012A18
        // (set) Token: 0x06000579 RID: 1401 RVA: 0x000047C0 File Offset: 0x000029C0
        [Browsable(true)]
        [Description("The control's placeholder text ForeColor")]
        [DefaultValue(typeof(Color), "193, 200, 207")]
        public Color PlaceholderForeColor
        {
            get
            {
                return base.DefaultPlaceholderForeColor;
            }
            set
            {
                base.DefaultPlaceholderForeColor = value;
            }
        }

        // Token: 0x1700022B RID: 555
        // (get) Token: 0x0600057A RID: 1402 RVA: 0x00014830 File Offset: 0x00012A30
        // (set) Token: 0x0600057B RID: 1403 RVA: 0x000047C9 File Offset: 0x000029C9
        [Description("Sets the TextBox's border radius.")]
        [DefaultValue(0)]
        [Browsable(true)]
        public int BorderRadius
        {
            get
            {
                return base.DefaultBorderRadius;
            }
            set
            {
                base.DefaultBorderRadius = value;
            }
        }

        // Token: 0x1700022C RID: 556
        // (get) Token: 0x0600057C RID: 1404 RVA: 0x00014848 File Offset: 0x00012A48
        // (set) Token: 0x0600057D RID: 1405 RVA: 0x000047D2 File Offset: 0x000029D2
        [Description("The control's css-like border style")]
        [DefaultValue(DashStyle.Solid)]
        [Browsable(true)]
        public new DashStyle BorderStyle
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

        // Token: 0x1700022D RID: 557
        // (get) Token: 0x0600057E RID: 1406 RVA: 0x00014860 File Offset: 0x00012A60
        // (set) Token: 0x0600057F RID: 1407 RVA: 0x000047DB File Offset: 0x000029DB
        [Description("Gets or sets the control border color.")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "213, 218, 223")]
        public Color BorderColor
        {
            get
            {
                return base.DefaultBorderColor;
            }
            set
            {
                base.DefaultBorderColor = value;
            }
        }

        // Token: 0x1700022E RID: 558
        // (get) Token: 0x06000580 RID: 1408 RVA: 0x00014878 File Offset: 0x00012A78
        // (set) Token: 0x06000581 RID: 1409 RVA: 0x000047E4 File Offset: 0x000029E4
        [DefaultValue(1)]
        [Browsable(true)]
        [Description("Gets or sets the control border size.")]
        public int BorderThickness
        {
            get
            {
                return base.DefaultBorderThickness;
            }
            set
            {
                base.DefaultBorderThickness = value;
            }
        }

        // Token: 0x1700022F RID: 559
        // (get) Token: 0x06000582 RID: 1410 RVA: 0x00014890 File Offset: 0x00012A90
        // (set) Token: 0x06000583 RID: 1411 RVA: 0x000047ED File Offset: 0x000029ED
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Shadow property of the control to add and customize a control's shadow")]
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

        // Token: 0x17000230 RID: 560
        // (get) Token: 0x06000584 RID: 1412 RVA: 0x000148A8 File Offset: 0x00012AA8
        // (set) Token: 0x06000585 RID: 1413 RVA: 0x000047F6 File Offset: 0x000029F6
        [Browsable(true)]
        [Description("Sets the TextBox's left icon.")]
        [DefaultValue(typeof(Image), "")]
        public Image IconLeft
        {
            get
            {
                return base.DefaultIconLeft;
            }
            set
            {
                base.DefaultIconLeft = value;
            }
        }

        // Token: 0x17000231 RID: 561
        // (get) Token: 0x06000586 RID: 1414 RVA: 0x000148C0 File Offset: 0x00012AC0
        // (set) Token: 0x06000587 RID: 1415 RVA: 0x000047FF File Offset: 0x000029FF
        [Browsable(true)]
        [DefaultValue(typeof(Size), "20, 20")]
        [Description("Sets TextBox's left icon size.")]
        public Size IconLeftSize
        {
            get
            {
                return base.DefaultIconLeftSize;
            }
            set
            {
                base.DefaultIconLeftSize = value;
            }
        }

        // Token: 0x17000232 RID: 562
        // (get) Token: 0x06000588 RID: 1416 RVA: 0x000148D8 File Offset: 0x00012AD8
        // (set) Token: 0x06000589 RID: 1417 RVA: 0x00004808 File Offset: 0x00002A08
        [Description("Sets TextBox's left icon cursor.")]
        [Browsable(true)]
        [DefaultValue(typeof(Cursor), "Default")]
        public Cursor IconLeftCursor
        {
            get
            {
                return base.DefaultIconLeftCursor;
            }
            set
            {
                base.DefaultIconLeftCursor = value;
            }
        }

        // Token: 0x17000233 RID: 563
        // (get) Token: 0x0600058A RID: 1418 RVA: 0x000148F0 File Offset: 0x00012AF0
        // (set) Token: 0x0600058B RID: 1419 RVA: 0x00004811 File Offset: 0x00002A11
        [Browsable(true)]
        [Description("Sets TextBox's left icon offset (Point).")]
        [DefaultValue(typeof(Point), "0, 0")]
        public Point IconLeftOffset
        {
            get
            {
                return base.DefaultIconLeftOffset;
            }
            set
            {
                base.DefaultIconLeftOffset = value;
            }
        }

        // Token: 0x17000234 RID: 564
        // (get) Token: 0x0600058C RID: 1420 RVA: 0x00014908 File Offset: 0x00012B08
        // (set) Token: 0x0600058D RID: 1421 RVA: 0x0000481A File Offset: 0x00002A1A
        [DefaultValue(typeof(Image), "")]
        [Description("Sets the TextBox's right icon.")]
        [Browsable(true)]
        public Image IconRight
        {
            get
            {
                return base.DefaultIconRight;
            }
            set
            {
                base.DefaultIconRight = value;
            }
        }

        // Token: 0x17000235 RID: 565
        // (get) Token: 0x0600058E RID: 1422 RVA: 0x00014920 File Offset: 0x00012B20
        // (set) Token: 0x0600058F RID: 1423 RVA: 0x00004823 File Offset: 0x00002A23
        [Description("Sets TextBox's right icon size.")]
        [DefaultValue(typeof(Size), "20, 20")]
        [Browsable(true)]
        public Size IconRightSize
        {
            get
            {
                return base.DefaultIconRightSize;
            }
            set
            {
                base.DefaultIconRightSize = value;
            }
        }

        // Token: 0x17000236 RID: 566
        // (get) Token: 0x06000590 RID: 1424 RVA: 0x00014938 File Offset: 0x00012B38
        // (set) Token: 0x06000591 RID: 1425 RVA: 0x0000482C File Offset: 0x00002A2C
        [Description("Sets TextBox's right icon cursor.")]
        [Browsable(true)]
        [DefaultValue(typeof(Cursor), "Default")]
        public Cursor IconRightCursor
        {
            get
            {
                return base.DefaultIconRightCursor;
            }
            set
            {
                base.DefaultIconRightCursor = value;
            }
        }

        // Token: 0x17000237 RID: 567
        // (get) Token: 0x06000592 RID: 1426 RVA: 0x00014950 File Offset: 0x00012B50
        // (set) Token: 0x06000593 RID: 1427 RVA: 0x00004835 File Offset: 0x00002A35
        [Browsable(true)]
        [DefaultValue(typeof(Point), "0, 0")]
        [Description("Sets TextBox's right icon offset (Point).")]
        public Point IconRightOffset
        {
            get
            {
                return base.DefaultIconRightOffset;
            }
            set
            {
                base.DefaultIconRightOffset = value;
            }
        }

        // Token: 0x17000238 RID: 568
        // (get) Token: 0x06000594 RID: 1428 RVA: 0x00014968 File Offset: 0x00012B68
        // (set) Token: 0x06000595 RID: 1429 RVA: 0x0000483E File Offset: 0x00002A3E
        [Browsable(true)]
        [Description("Sets the TextBox's fill color or inner-background color.")]
        [DefaultValue(typeof(Color), "White")]
        public Color FillColor
        {
            get
            {
                return base.DefaultFillColor;
            }
            set
            {
                base.DefaultFillColor = value;
            }
        }
    }
}
