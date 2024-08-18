using AimBotConquer.Guna;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace AimBotConquer.Guna {
    // Token: 0x0200008D RID: 141
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    internal class Class8 : System.Windows.Forms.TextBox {
        // Token: 0x06000C8F RID: 3215 RVA: 0x000081A2 File Offset: 0x000063A2
        public Class8() {
        }

        // Token: 0x14000034 RID: 52
        // (add) Token: 0x06000C90 RID: 3216 RVA: 0x0002A808 File Offset: 0x00028A08
        // (remove) Token: 0x06000C91 RID: 3217 RVA: 0x0002A840 File Offset: 0x00028A40
        public event Class8.Delegate2 Event_0 {
            [CompilerGenerated]
            add {
                Class8.Delegate2 @delegate = this.delegate2_0;
                Class8.Delegate2 delegate2;
                do {
                    delegate2 = @delegate;
                    Class8.Delegate2 delegate3 = (Class8.Delegate2)Delegate.Combine(delegate2, value);
                    @delegate = Interlocked.CompareExchange<Class8.Delegate2>(ref this.delegate2_0, delegate3, delegate2);
                }
                while (@delegate != delegate2);
            }
            [CompilerGenerated]
            remove {
                Class8.Delegate2 @delegate = this.delegate2_0;
                Class8.Delegate2 delegate2;
                do {
                    delegate2 = @delegate;
                    Class8.Delegate2 delegate3 = (Class8.Delegate2)Delegate.Remove(delegate2, value);
                    @delegate = Interlocked.CompareExchange<Class8.Delegate2>(ref this.delegate2_0, delegate3, delegate2);
                }
                while (@delegate != delegate2);
            }
        }

        // Token: 0x06000C92 RID: 3218 RVA: 0x000081D1 File Offset: 0x000063D1
        protected virtual void vmethod_0(bool bool_3) {
            if (this.delegate2_0 != null) {
                this.delegate2_0(bool_3);
            }
        }

        // Token: 0x14000035 RID: 53
        // (add) Token: 0x06000C93 RID: 3219 RVA: 0x0002A878 File Offset: 0x00028A78
        // (remove) Token: 0x06000C94 RID: 3220 RVA: 0x0002A8B0 File Offset: 0x00028AB0
        public event Class8.Delegate3 Event_1 {
            [CompilerGenerated]
            add {
                Class8.Delegate3 @delegate = this.delegate3_0;
                Class8.Delegate3 delegate2;
                do {
                    delegate2 = @delegate;
                    Class8.Delegate3 delegate3 = (Class8.Delegate3)Delegate.Combine(delegate2, value);
                    @delegate = Interlocked.CompareExchange<Class8.Delegate3>(ref this.delegate3_0, delegate3, delegate2);
                }
                while (@delegate != delegate2);
            }
            [CompilerGenerated]
            remove {
                Class8.Delegate3 @delegate = this.delegate3_0;
                Class8.Delegate3 delegate2;
                do {
                    delegate2 = @delegate;
                    Class8.Delegate3 delegate3 = (Class8.Delegate3)Delegate.Remove(delegate2, value);
                    @delegate = Interlocked.CompareExchange<Class8.Delegate3>(ref this.delegate3_0, delegate3, delegate2);
                }
                while (@delegate != delegate2);
            }
        }

        // Token: 0x06000C95 RID: 3221 RVA: 0x000081EA File Offset: 0x000063EA
        protected virtual void vmethod_1(bool bool_3) {
            if (this.delegate3_0 != null) {
                this.delegate3_0(bool_3);
            }
        }

        // Token: 0x06000C96 RID: 3222 RVA: 0x00008203 File Offset: 0x00006403
        protected override void OnMouseDown(MouseEventArgs e) {
            this.bool_0 = true;
            this.mouseState_0 = MouseState.DOWN;
            base.OnMouseDown(e);
        }

        // Token: 0x06000C97 RID: 3223 RVA: 0x0000821A File Offset: 0x0000641A
        protected override void OnMouseUp(MouseEventArgs e) {
            this.mouseState_0 = (this.bool_0 ? MouseState.HOVER : MouseState.const_2);
            base.OnMouseUp(e);
        }

        // Token: 0x06000C98 RID: 3224 RVA: 0x00008235 File Offset: 0x00006435
        protected override void OnMouseEnter(EventArgs e) {
            this.bool_0 = true;
            this.mouseState_0 = MouseState.HOVER;
            base.OnMouseEnter(e);
        }

        // Token: 0x06000C99 RID: 3225 RVA: 0x0000824C File Offset: 0x0000644C
        protected override void OnMouseLeave(EventArgs e) {
            this.bool_0 = false;
            this.mouseState_0 = MouseState.const_2;
            base.OnMouseLeave(e);
        }

        // Token: 0x06000C9A RID: 3226 RVA: 0x00008263 File Offset: 0x00006463
        protected override void OnLostFocus(EventArgs e) {
            this.bool_0 = false;
            this.mouseState_0 = MouseState.const_2;
            base.OnLostFocus(e);
            this.vmethod_1(false);
        }

        // Token: 0x17000457 RID: 1111
        // (get) Token: 0x06000C9B RID: 3227 RVA: 0x00008281 File Offset: 0x00006481
        // (set) Token: 0x06000C9C RID: 3228 RVA: 0x00008289 File Offset: 0x00006489
        public bool Boolean_0 {
            get {
                return this.bool_1;
            }
            set {
                if (this.bool_1 != value) {
                    this.bool_1 = value;
                    this.vmethod_0(value);
                }
                if (value) {
                    this.method_0(true);
                } else {
                    this.method_0(false);
                }
            }
        }

        // Token: 0x17000458 RID: 1112
        // (get) Token: 0x06000C9D RID: 3229 RVA: 0x0002A8E8 File Offset: 0x00028AE8
        // (set) Token: 0x06000C9E RID: 3230 RVA: 0x0002A900 File Offset: 0x00028B00
        public string String_0 {
            get {
                return this.string_0;
            }
            set {
                this.string_0 = value;
                if (this.Text == "") {
                    this.Boolean_0 = false;
                    this.OnTextChanged(EventArgs.Empty);
                } else {
                    this.Boolean_0 = true;
                    this.OnTextChanged(EventArgs.Empty);
                }
            }
        }

        // Token: 0x06000C9F RID: 3231 RVA: 0x000082BA File Offset: 0x000064BA
        private void method_0(bool bool_3) {
            if (this.bool_2 != bool_3) {
                this.bool_2 = bool_3;
                base.SetStyle(ControlStyles.UserMouse, this.bool_2);
            }
        }

        // Token: 0x17000459 RID: 1113
        // (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0002A94C File Offset: 0x00028B4C
        // (set) Token: 0x06000CA1 RID: 3233 RVA: 0x000082E2 File Offset: 0x000064E2
        [Category("Options")]
        public char Char_0 {
            get {
                return this.char_0;
            }
            set {
                this.char_0 = value;
                base.PasswordChar = value;
            }
        }

        // Token: 0x06000CA2 RID: 3234 RVA: 0x000082F2 File Offset: 0x000064F2
        protected override void OnGotFocus(EventArgs e) {
            if (this.Boolean_0) {
                base.Select(0, 0);
            }
            base.OnGotFocus(e);
            this.vmethod_1(true);
        }

        // Token: 0x06000CA3 RID: 3235 RVA: 0x0002A964 File Offset: 0x00028B64
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if (this.Boolean_0 && ((e.KeyCode == Keys.Right) | (e.KeyCode == Keys.Down) | (e.KeyCode == Keys.Left) | (e.KeyCode == Keys.Delete) | (e.KeyCode == Keys.A && e.Control))) {
                this.method_0(true);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        // Token: 0x1700045A RID: 1114
        // (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0002A9D8 File Offset: 0x00028BD8
        // (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00008312 File Offset: 0x00006512
        [Browsable(false)]
        public override string Text {
            get {
                string text;
                if (this.Boolean_0) {
                    text = "";
                } else {
                    text = base.Text;
                }
                return text;
            }
            set {
                base.Text = value;
                if (this.eventHandler_0 != null) {
                    this.eventHandler_0(this, EventArgs.Empty);
                }
            }
        }

        // Token: 0x06000CA6 RID: 3238 RVA: 0x0002AA00 File Offset: 0x00028C00
        protected override void OnTextChanged(EventArgs e) {
            if (base.Text == string.Empty && this.String_0 != "") {
                this.Boolean_0 = true;
                this.Text = this.String_0;
                base.OnTextChanged(e);
            } else if (!this.Boolean_0 | (base.Text == string.Empty)) {
                base.OnTextChanged(e);
            } else if (this.String_0 == "") {
                this.Boolean_0 = false;
                base.OnTextChanged(e);
            } else if (this.Boolean_0) {
                if (base.TextLength > this.String_0.Length) {
                    this.Boolean_0 = false;
                    if (base.Text.Contains(this.String_0) && base.Text.Length > this.String_0.Length && this.String_0 != "") {
                        string text = base.Text.Replace(this.String_0, "");
                        this.Text = text;
                        base.Select(this.Text.Length, 0);
                    }
                }
                if (base.Text != this.String_0) {
                    this.Boolean_0 = false;
                }
                if (base.TextLength > this.String_0.Length) {
                    this.Boolean_0 = false;
                }
            }
        }

        // Token: 0x04000370 RID: 880
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Class8.Delegate2 delegate2_0;

        // Token: 0x04000371 RID: 881
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private Class8.Delegate3 delegate3_0;

        // Token: 0x04000372 RID: 882
        private bool bool_0 = false;

        // Token: 0x04000373 RID: 883
        internal MouseState mouseState_0 = MouseState.const_2;

        // Token: 0x04000374 RID: 884
        private bool bool_1 = true;

        // Token: 0x04000375 RID: 885
        private string string_0 = "Enter Text";

        // Token: 0x04000376 RID: 886
        private bool bool_2 = false;

        // Token: 0x04000377 RID: 887
        private char char_0;

        // Token: 0x04000378 RID: 888
        public EventHandler eventHandler_0;

        // Token: 0x0200008E RID: 142
        // (Invoke) Token: 0x06000CA8 RID: 3240
        public delegate void Delegate2(bool e);

        // Token: 0x0200008F RID: 143
        // (Invoke) Token: 0x06000CAC RID: 3244
        public delegate void Delegate3(bool e);
    }
}
