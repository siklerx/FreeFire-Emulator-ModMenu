using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace AimBotConquer.Guna {

    // Token: 0x02000069 RID: 105
    [Description("")]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [DebuggerStepThrough]
    public class TextBoxState {
        // Token: 0x0600079F RID: 1951 RVA: 0x000021C0 File Offset: 0x000003C0
        public TextBoxState() {
        }

        // Token: 0x170002DE RID: 734
        // (get) Token: 0x060007A0 RID: 1952 RVA: 0x00005602 File Offset: 0x00003802
        // (set) Token: 0x060007A1 RID: 1953 RVA: 0x0000560A File Offset: 0x0000380A
        [Browsable(false)]
        public TextBoxBase Parent {
            [CompilerGenerated]
            get {
                return this.textBox_0;
            }
            [CompilerGenerated]
            set {
                this.textBox_0 = value;
            }
        }

        // Token: 0x060007A2 RID: 1954 RVA: 0x0001A3DC File Offset: 0x000185DC
        public override string ToString() {
            return string.Empty;
        }

        // Token: 0x060007A3 RID: 1955 RVA: 0x00005613 File Offset: 0x00003813
        private void method_0() {
            if (this.Parent != null) {
                this.Parent.Invalidate();
            }
        }

        // Token: 0x170002DF RID: 735
        // (get) Token: 0x060007A4 RID: 1956 RVA: 0x0001B0A8 File Offset: 0x000192A8
        // (set) Token: 0x060007A5 RID: 1957 RVA: 0x0000562B File Offset: 0x0000382B
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(typeof(Color), "")]
        [Description("The textbox ForeColor")]
        [NotifyParentProperty(true)]
        [Browsable(true)]
        public Color ForeColor {
            get {
                return this.color_0;
            }
            set {
                this.color_0 = value;
            }
        }

        // Token: 0x170002E0 RID: 736
        // (get) Token: 0x060007A6 RID: 1958 RVA: 0x0001B0C0 File Offset: 0x000192C0
        // (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005634 File Offset: 0x00003834
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The textbox Placeholder ForeColor")]
        [DefaultValue(typeof(Color), "")]
        [NotifyParentProperty(true)]
        [Browsable(true)]
        public Color PlaceholderForeColor {
            get {
                return this.color_1;
            }
            set {
                this.color_1 = value;
            }
        }

        // Token: 0x170002E1 RID: 737
        // (get) Token: 0x060007A8 RID: 1960 RVA: 0x0001B0D8 File Offset: 0x000192D8
        // (set) Token: 0x060007A9 RID: 1961 RVA: 0x0000563D File Offset: 0x0000383D
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(typeof(Color), "")]
        [Browsable(true)]
        [NotifyParentProperty(true)]
        [Description("The textbox fill color")]
        public Color FillColor {
            get {
                return this.color_2;
            }
            set {
                this.color_2 = value;
            }
        }

        // Token: 0x170002E2 RID: 738
        // (get) Token: 0x060007AA RID: 1962 RVA: 0x0001B0F0 File Offset: 0x000192F0
        // (set) Token: 0x060007AB RID: 1963 RVA: 0x00005646 File Offset: 0x00003846
        [EditorBrowsable(EditorBrowsableState.Always)]
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Description("The textbox border color")]
        [DefaultValue(typeof(Color), "")]
        public Color BorderColor {
            get {
                return this.color_3;
            }
            set {
                this.color_3 = value;
            }
        }

        // Token: 0x040001BE RID: 446
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBoxBase textBox_0;

        // Token: 0x040001BF RID: 447
        private Color color_0;

        // Token: 0x040001C0 RID: 448
        private Color color_1;

        // Token: 0x040001C1 RID: 449
        private Color color_2;

        // Token: 0x040001C2 RID: 450
        private Color color_3;
    }
}
