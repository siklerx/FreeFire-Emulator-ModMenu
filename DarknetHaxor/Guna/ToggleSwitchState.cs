
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace AimBotConquer.Guna
{
    // Token: 0x0200006A RID: 106
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [DebuggerStepThrough]
    [Description("ToggleSwitchState")]
    public class ToggleSwitchState
    {
        // Token: 0x060007AC RID: 1964 RVA: 0x0000564F File Offset: 0x0000384F
        public ToggleSwitchState()
        {
        }

        // Token: 0x170002E3 RID: 739
        // (get) Token: 0x060007AD RID: 1965 RVA: 0x00005666 File Offset: 0x00003866
        // (set) Token: 0x060007AE RID: 1966 RVA: 0x0000566E File Offset: 0x0000386E
        [Browsable(false)]
        public ToggleSwitch Parent
        {
            [CompilerGenerated]
            get
            {
                return this.toggleSwitch_0;
            }
            [CompilerGenerated]
            set
            {
                this.toggleSwitch_0 = value;
            }
        }

        // Token: 0x060007AF RID: 1967 RVA: 0x00005677 File Offset: 0x00003877
        private void method_0()
        {
            if (this.Parent != null)
            {
                this.Parent.Invalidate();
            }
        }

        // Token: 0x060007B0 RID: 1968 RVA: 0x0001A3DC File Offset: 0x000185DC
        public override string ToString()
        {
            return string.Empty;
        }

        // Token: 0x170002E4 RID: 740
        // (get) Token: 0x060007B1 RID: 1969 RVA: 0x0001B108 File Offset: 0x00019308
        // (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000568F File Offset: 0x0000388F
        [DefaultValue(typeof(Color), "")]
        [Description("The toggle switch fill color")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [NotifyParentProperty(true)]
        public Color FillColor
        {
            get
            {
                return this.color_0;
            }
            set
            {
                this.color_0 = value;
                this.method_0();
            }
        }

        // Token: 0x170002E5 RID: 741
        // (get) Token: 0x060007B3 RID: 1971 RVA: 0x0001B120 File Offset: 0x00019320
        // (set) Token: 0x060007B4 RID: 1972 RVA: 0x0000569E File Offset: 0x0000389E
        [Browsable(true)]
        [Description("The toggle switch border color")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [NotifyParentProperty(true)]
        [DefaultValue(typeof(Color), "")]
        public Color BorderColor
        {
            get
            {
                return this.color_1;
            }
            set
            {
                this.color_1 = value;
                this.method_0();
            }
        }

        // Token: 0x170002E6 RID: 742
        // (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001B138 File Offset: 0x00019338
        // (set) Token: 0x060007B6 RID: 1974 RVA: 0x000056AD File Offset: 0x000038AD
        [Description("The toggle switch inner color")]
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [DefaultValue(typeof(Color), "")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Color InnerColor
        {
            get
            {
                return this.color_2;
            }
            set
            {
                this.color_2 = value;
                this.method_0();
            }
        }

        // Token: 0x170002E7 RID: 743
        // (get) Token: 0x060007B7 RID: 1975 RVA: 0x0001B150 File Offset: 0x00019350
        // (set) Token: 0x060007B8 RID: 1976 RVA: 0x000056BC File Offset: 0x000038BC
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Description("The toggle switch inner border color")]
        [DefaultValue(typeof(Color), "")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Color InnerBorderColor
        {
            get
            {
                return this.color_3;
            }
            set
            {
                this.color_3 = value;
                this.method_0();
            }
        }

        // Token: 0x170002E8 RID: 744
        // (get) Token: 0x060007B9 RID: 1977 RVA: 0x0001B168 File Offset: 0x00019368
        // (set) Token: 0x060007BA RID: 1978 RVA: 0x000056CB File Offset: 0x000038CB
        [Browsable(true)]
        [Description("The toggle switch border radius")]
        [DefaultValue(9)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public int BorderRadius
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
                this.method_0();
            }
        }

        // Token: 0x170002E9 RID: 745
        // (get) Token: 0x060007BB RID: 1979 RVA: 0x0001B180 File Offset: 0x00019380
        // (set) Token: 0x060007BC RID: 1980 RVA: 0x000056DA File Offset: 0x000038DA
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [Description("The toggle switch border thickness")]
        [DefaultValue(0)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public int BorderThickness
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
                this.method_0();
            }
        }

        // Token: 0x170002EA RID: 746
        // (get) Token: 0x060007BD RID: 1981 RVA: 0x0001B198 File Offset: 0x00019398
        // (set) Token: 0x060007BE RID: 1982 RVA: 0x000056E9 File Offset: 0x000038E9
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The toggle switch innder border radius")]
        [DefaultValue(5)]
        public int InnerBorderRadius
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
                this.method_0();
            }
        }

        // Token: 0x170002EB RID: 747
        // (get) Token: 0x060007BF RID: 1983 RVA: 0x0001B1B0 File Offset: 0x000193B0
        // (set) Token: 0x060007C0 RID: 1984 RVA: 0x000056F8 File Offset: 0x000038F8
        [Description("The toggle switch innder border thickness")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        public int InnerBorderThickness
        {
            get
            {
                return this.int_3;
            }
            set
            {
                this.int_3 = value;
                this.method_0();
            }
        }

        // Token: 0x170002EC RID: 748
        // (get) Token: 0x060007C1 RID: 1985 RVA: 0x0001B1C8 File Offset: 0x000193C8
        // (set) Token: 0x060007C2 RID: 1986 RVA: 0x00005707 File Offset: 0x00003907
        [Browsable(true)]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The toggle switch inner offset")]
        public int InnerOffset
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
                this.method_0();
            }
        }

        // Token: 0x040001C3 RID: 451
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private ToggleSwitch toggleSwitch_0;

        // Token: 0x040001C4 RID: 452
        private Color color_0;

        // Token: 0x040001C5 RID: 453
        private Color color_1;

        // Token: 0x040001C6 RID: 454
        private Color color_2;

        // Token: 0x040001C7 RID: 455
        private Color color_3;

        // Token: 0x040001C8 RID: 456
        private int int_0 = 9;

        // Token: 0x040001C9 RID: 457
        private int int_1;

        // Token: 0x040001CA RID: 458
        private int int_2 = 5;

        // Token: 0x040001CB RID: 459
        private int int_3;

        // Token: 0x040001CC RID: 460
        private int int_4;
    }
}
