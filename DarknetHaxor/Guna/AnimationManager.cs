using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace AimBotConquer.Guna {

    // Token: 0x020000BB RID: 187
    public class AnimationManager {
        // Token: 0x06000D30 RID: 3376 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
        public AnimationManager(bool singular = true) {
            this.list_0 = new List<double>();
            this.list_1 = new List<Point>();
            this.list_2 = new List<AnimationDirection>();
            this.list_3 = new List<object[]>();
            this.Increment = 0.03;
            this.SecondaryIncrement = 0.03;
            this.AnimationType = AnimationType.Linear;
            this.InterruptAnimation = true;
            this.Singular = singular;
            if (this.Singular) {
                this.list_0.Add(0.0);
                this.list_1.Add(new Point(0, 0));
                this.list_2.Add(AnimationDirection.In);
            }
            this.timer_0.Tick += this.timer_0_Tick;
        }

        // Token: 0x1700045F RID: 1119
        // (get) Token: 0x06000D31 RID: 3377 RVA: 0x00008625 File Offset: 0x00006825
        // (set) Token: 0x06000D32 RID: 3378 RVA: 0x0000862D File Offset: 0x0000682D
        public bool InterruptAnimation {
            [CompilerGenerated]
            get {
                return this.bool_0;
            }
            [CompilerGenerated]
            set {
                this.bool_0 = value;
            }
        }

        // Token: 0x17000460 RID: 1120
        // (get) Token: 0x06000D33 RID: 3379 RVA: 0x00008636 File Offset: 0x00006836
        // (set) Token: 0x06000D34 RID: 3380 RVA: 0x0000863E File Offset: 0x0000683E
        public double Increment {
            [CompilerGenerated]
            get {
                return this.double_0;
            }
            [CompilerGenerated]
            set {
                this.double_0 = value;
            }
        }

        // Token: 0x17000461 RID: 1121
        // (get) Token: 0x06000D35 RID: 3381 RVA: 0x00008647 File Offset: 0x00006847
        // (set) Token: 0x06000D36 RID: 3382 RVA: 0x0000864F File Offset: 0x0000684F
        public double SecondaryIncrement {
            [CompilerGenerated]
            get {
                return this.double_1;
            }
            [CompilerGenerated]
            set {
                this.double_1 = value;
            }
        }

        // Token: 0x17000462 RID: 1122
        // (get) Token: 0x06000D37 RID: 3383 RVA: 0x00008658 File Offset: 0x00006858
        // (set) Token: 0x06000D38 RID: 3384 RVA: 0x00008660 File Offset: 0x00006860
        public AnimationType AnimationType {
            [CompilerGenerated]
            get {
                return this.animationType_0;
            }
            [CompilerGenerated]
            set {
                this.animationType_0 = value;
            }
        }

        // Token: 0x17000463 RID: 1123
        // (get) Token: 0x06000D39 RID: 3385 RVA: 0x00008669 File Offset: 0x00006869
        // (set) Token: 0x06000D3A RID: 3386 RVA: 0x00008671 File Offset: 0x00006871
        public bool Singular {
            [CompilerGenerated]
            get {
                return this.bool_1;
            }
            [CompilerGenerated]
            set {
                this.bool_1 = value;
            }
        }

        // Token: 0x14000039 RID: 57
        // (add) Token: 0x06000D3B RID: 3387 RVA: 0x0002C684 File Offset: 0x0002A884
        // (remove) Token: 0x06000D3C RID: 3388 RVA: 0x0002C6BC File Offset: 0x0002A8BC
        public event AnimationManager.AnimationFinished OnAnimationFinished {
            [CompilerGenerated]
            add {
                AnimationManager.AnimationFinished animationFinished = this.animationFinished_0;
                AnimationManager.AnimationFinished animationFinished2;
                do {
                    animationFinished2 = animationFinished;
                    AnimationManager.AnimationFinished animationFinished3 = (AnimationManager.AnimationFinished)Delegate.Combine(animationFinished2, value);
                    animationFinished = Interlocked.CompareExchange<AnimationManager.AnimationFinished>(ref this.animationFinished_0, animationFinished3, animationFinished2);
                }
                while (animationFinished != animationFinished2);
            }
            [CompilerGenerated]
            remove {
                AnimationManager.AnimationFinished animationFinished = this.animationFinished_0;
                AnimationManager.AnimationFinished animationFinished2;
                do {
                    animationFinished2 = animationFinished;
                    AnimationManager.AnimationFinished animationFinished3 = (AnimationManager.AnimationFinished)Delegate.Remove(animationFinished2, value);
                    animationFinished = Interlocked.CompareExchange<AnimationManager.AnimationFinished>(ref this.animationFinished_0, animationFinished3, animationFinished2);
                }
                while (animationFinished != animationFinished2);
            }
        }

        // Token: 0x1400003A RID: 58
        // (add) Token: 0x06000D3D RID: 3389 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
        // (remove) Token: 0x06000D3E RID: 3390 RVA: 0x0002C72C File Offset: 0x0002A92C
        public event AnimationManager.AnimationProgress OnAnimationProgress {
            [CompilerGenerated]
            add {
                AnimationManager.AnimationProgress animationProgress = this.animationProgress_0;
                AnimationManager.AnimationProgress animationProgress2;
                do {
                    animationProgress2 = animationProgress;
                    AnimationManager.AnimationProgress animationProgress3 = (AnimationManager.AnimationProgress)Delegate.Combine(animationProgress2, value);
                    animationProgress = Interlocked.CompareExchange<AnimationManager.AnimationProgress>(ref this.animationProgress_0, animationProgress3, animationProgress2);
                }
                while (animationProgress != animationProgress2);
            }
            [CompilerGenerated]
            remove {
                AnimationManager.AnimationProgress animationProgress = this.animationProgress_0;
                AnimationManager.AnimationProgress animationProgress2;
                do {
                    animationProgress2 = animationProgress;
                    AnimationManager.AnimationProgress animationProgress3 = (AnimationManager.AnimationProgress)Delegate.Remove(animationProgress2, value);
                    animationProgress = Interlocked.CompareExchange<AnimationManager.AnimationProgress>(ref this.animationProgress_0, animationProgress3, animationProgress2);
                }
                while (animationProgress != animationProgress2);
            }
        }

        // Token: 0x06000D3F RID: 3391 RVA: 0x0002C764 File Offset: 0x0002A964
        private void timer_0_Tick(object sender, EventArgs e) {
            for (int i = 0; i < this.list_0.Count; i++) {
                this.UpdateProgress(i);
                if (!this.Singular) {
                    if (this.list_2[i] == AnimationDirection.InOutIn && this.list_0[i] == 1.0) {
                        this.list_2[i] = AnimationDirection.InOutOut;
                    } else if (this.list_2[i] == AnimationDirection.InOutRepeatingIn && this.list_0[i] == 0.0) {
                        this.list_2[i] = AnimationDirection.InOutRepeatingOut;
                    } else {
                        if (this.list_2[i] != AnimationDirection.InOutRepeatingOut || this.list_0[i] != 0.0) {
                            if (this.list_2[i] == AnimationDirection.In && this.list_0[i] == 1.0) {
                                goto IL_120;
                            }
                            if (this.list_2[i] == AnimationDirection.Out) {
                                if (this.list_0[i] == 0.0) {
                                    goto IL_120;
                                }
                            }
                            bool flag = this.list_2[i] == AnimationDirection.InOutOut && this.list_0[i] == 0.0;
                        IL_14C:
                            if (flag) {
                                this.list_0.RemoveAt(i);
                                this.list_1.RemoveAt(i);
                                this.list_2.RemoveAt(i);
                                this.list_3.RemoveAt(i);
                                goto IL_232;
                            }
                            goto IL_232;
                        IL_120:
                            flag = true;
                            goto IL_14C;
                        }
                        this.list_2[i] = AnimationDirection.InOutRepeatingIn;
                    }
                } else if (this.list_2[i] == AnimationDirection.InOutIn && this.list_0[i] == 1.0) {
                    this.list_2[i] = AnimationDirection.InOutOut;
                } else if (this.list_2[i] == AnimationDirection.InOutRepeatingIn && this.list_0[i] == 1.0) {
                    this.list_2[i] = AnimationDirection.InOutRepeatingOut;
                } else if (this.list_2[i] == AnimationDirection.InOutRepeatingOut && this.list_0[i] == 0.0) {
                    this.list_2[i] = AnimationDirection.InOutRepeatingIn;
                }
            IL_232:;
            }
            AnimationManager.AnimationProgress animationProgress = this.animationProgress_0;
            if (animationProgress != null) {
                animationProgress(this);
            }
        }

        // Token: 0x06000D40 RID: 3392 RVA: 0x0000867A File Offset: 0x0000687A
        public bool IsAnimating() {
            return this.timer_0.Enabled;
        }

        // Token: 0x06000D41 RID: 3393 RVA: 0x00008687 File Offset: 0x00006887
        public void StartNewAnimation(AnimationDirection animationDirection, object[] data = null) {
            this.StartNewAnimation(animationDirection, new Point(0, 0), data);
        }

        // Token: 0x06000D42 RID: 3394 RVA: 0x0002C9CC File Offset: 0x0002ABCC
        public void StartNewAnimation(AnimationDirection animationDirection, Point animationSource, object[] data = null) {
            if (!this.IsAnimating() || this.InterruptAnimation) {
                if (this.Singular && this.list_2.Count > 0) {
                    this.list_2[0] = animationDirection;
                } else {
                    this.list_2.Add(animationDirection);
                }
                if (this.Singular && this.list_1.Count > 0) {
                    this.list_1[0] = animationSource;
                } else {
                    this.list_1.Add(animationSource);
                }
                if (!this.Singular || this.list_0.Count <= 0) {
                    switch (this.list_2[this.list_2.Count - 1]) {
                        case AnimationDirection.In:
                        case AnimationDirection.InOutIn:
                        case AnimationDirection.InOutRepeatingIn:
                            this.list_0.Add(0.0);
                            break;
                        case AnimationDirection.Out:
                        case AnimationDirection.InOutOut:
                        case AnimationDirection.InOutRepeatingOut:
                            this.list_0.Add(1.0);
                            break;
                        default:
                            throw new Exception("Invalid AnimationDirection");
                    }
                }
                if (this.Singular && this.list_3.Count > 0) {
                    this.list_3[0] = data ?? new object[0];
                } else {
                    this.list_3.Add(data ?? new object[0]);
                }
            }
            this.timer_0.Start();
        }

        // Token: 0x06000D43 RID: 3395 RVA: 0x0002CB3C File Offset: 0x0002AD3C
        public void UpdateProgress(int index) {
            switch (this.list_2[index]) {
                case AnimationDirection.In:
                case AnimationDirection.InOutIn:
                case AnimationDirection.InOutRepeatingIn:
                    this.method_0(index);
                    break;
                case AnimationDirection.Out:
                case AnimationDirection.InOutOut:
                case AnimationDirection.InOutRepeatingOut:
                    this.method_1(index);
                    break;
                default:
                    throw new Exception("No AnimationDirection has been set");
            }
        }

        // Token: 0x06000D44 RID: 3396 RVA: 0x0002CB90 File Offset: 0x0002AD90
        private void method_0(int int_0) {
            List<double> list = this.list_0;
            list[int_0] += this.Increment;
            if (this.list_0[int_0] > 1.0) {
                this.list_0[int_0] = 1.0;
                for (int i = 0; i < this.GetAnimationCount(); i++) {
                    if (this.list_2[i] == AnimationDirection.InOutIn || this.list_2[i] == AnimationDirection.InOutRepeatingIn || this.list_2[i] == AnimationDirection.InOutRepeatingOut || (this.list_2[i] == AnimationDirection.InOutOut && this.list_0[i] != 1.0) || (this.list_2[i] == AnimationDirection.In && this.list_0[i] != 1.0)) {
                        return;
                    }
                }
                this.timer_0.Stop();
                AnimationManager.AnimationFinished animationFinished = this.animationFinished_0;
                if (animationFinished != null) {
                    animationFinished(this);
                }
            }
        }

        // Token: 0x06000D45 RID: 3397 RVA: 0x0002CCBC File Offset: 0x0002AEBC
        private void method_1(int int_0) {
            List<double> list = this.list_0;
            list[int_0] -= ((this.list_2[int_0] == AnimationDirection.InOutOut || this.list_2[int_0] == AnimationDirection.InOutRepeatingOut) ? this.SecondaryIncrement : this.Increment);
            if (this.list_0[int_0] < 0.0) {
                this.list_0[int_0] = 0.0;
                for (int i = 0; i < this.GetAnimationCount(); i++) {
                    if (this.list_2[i] == AnimationDirection.InOutIn || this.list_2[i] == AnimationDirection.InOutRepeatingIn || this.list_2[i] == AnimationDirection.InOutRepeatingOut || (this.list_2[i] == AnimationDirection.InOutOut && this.list_0[i] != 0.0) || (this.list_2[i] == AnimationDirection.Out && this.list_0[i] != 0.0)) {
                        return;
                    }
                }
                this.timer_0.Stop();
                AnimationManager.AnimationFinished animationFinished = this.animationFinished_0;
                if (animationFinished != null) {
                    animationFinished(this);
                }
            }
        }

        // Token: 0x06000D46 RID: 3398 RVA: 0x0002CE0C File Offset: 0x0002B00C
        public double GetProgress() {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_0.Count == 0) {
                throw new Exception("Invalid animation");
            }
            return this.GetProgress(0);
        }

        // Token: 0x06000D47 RID: 3399 RVA: 0x0002CE54 File Offset: 0x0002B054
        public double GetProgress(int index) {
            if (index >= this.GetAnimationCount()) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }
            double num;
            switch (this.AnimationType) {
                case AnimationType.Linear:
                    num = AnimationLinear.CalculateProgress(this.list_0[index]);
                    break;
                case AnimationType.EaseInOut:
                    num = AnimationEaseInOut.CalculateProgress(this.list_0[index]);
                    break;
                case AnimationType.EaseOut:
                    num = AnimationEaseOut.CalculateProgress(this.list_0[index]);
                    break;
                case AnimationType.CustomQuadratic:
                    num = AnimationCustomQuadratic.CalculateProgress(this.list_0[index]);
                    break;
                default:
                    throw new NotImplementedException("The given AnimationType is not implemented");
            }
            return num;
        }

        // Token: 0x06000D48 RID: 3400 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
        public Point GetSource(int index) {
            if (index >= this.GetAnimationCount()) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }
            return this.list_1[index];
        }

        // Token: 0x06000D49 RID: 3401 RVA: 0x0002CF28 File Offset: 0x0002B128
        public Point GetSource() {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_1.Count == 0) {
                throw new Exception("Invalid animation");
            }
            return this.list_1[0];
        }

        // Token: 0x06000D4A RID: 3402 RVA: 0x0002CF74 File Offset: 0x0002B174
        public AnimationDirection GetDirection() {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_2.Count == 0) {
                throw new Exception("Invalid animation");
            }
            return this.list_2[0];
        }

        // Token: 0x06000D4B RID: 3403 RVA: 0x0002CFC0 File Offset: 0x0002B1C0
        public AnimationDirection GetDirection(int index) {
            if (index >= this.list_2.Count) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }
            return this.list_2[index];
        }

        // Token: 0x06000D4C RID: 3404 RVA: 0x0002CFFC File Offset: 0x0002B1FC
        public object[] GetData() {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_3.Count == 0) {
                throw new Exception("Invalid animation");
            }
            return this.list_3[0];
        }

        // Token: 0x06000D4D RID: 3405 RVA: 0x0002D048 File Offset: 0x0002B248
        public object[] GetData(int index) {
            if (index >= this.list_3.Count) {
                throw new IndexOutOfRangeException("Invalid animation index");
            }
            return this.list_3[index];
        }

        // Token: 0x06000D4E RID: 3406 RVA: 0x0002D084 File Offset: 0x0002B284
        public int GetAnimationCount() {
            return this.list_0.Count;
        }

        // Token: 0x06000D4F RID: 3407 RVA: 0x00008698 File Offset: 0x00006898
        public void SetProgress(double progress) {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_0.Count == 0) {
                throw new Exception("Invalid animation");
            }
            this.list_0[0] = progress;
        }

        // Token: 0x06000D50 RID: 3408 RVA: 0x000086D8 File Offset: 0x000068D8
        public void SetDirection(AnimationDirection direction) {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_0.Count == 0) {
                throw new Exception("Invalid animation");
            }
            this.list_2[0] = direction;
        }

        // Token: 0x06000D51 RID: 3409 RVA: 0x00008718 File Offset: 0x00006918
        public void SetData(object[] data) {
            if (!this.Singular) {
                throw new Exception("Animation is not set to Singular.");
            }
            if (this.list_3.Count == 0) {
                throw new Exception("Invalid animation");
            }
            this.list_3[0] = data;
        }

        // Token: 0x04000535 RID: 1333
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool bool_0;

        // Token: 0x04000536 RID: 1334
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private double double_0;

        // Token: 0x04000537 RID: 1335
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private double double_1;

        // Token: 0x04000538 RID: 1336
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AnimationType animationType_0;

        // Token: 0x04000539 RID: 1337
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool bool_1;

        // Token: 0x0400053A RID: 1338
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private AnimationManager.AnimationFinished animationFinished_0;

        // Token: 0x0400053B RID: 1339
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AnimationManager.AnimationProgress animationProgress_0;

        // Token: 0x0400053C RID: 1340
        private readonly List<double> list_0;

        // Token: 0x0400053D RID: 1341
        private readonly List<Point> list_1;

        // Token: 0x0400053E RID: 1342
        private readonly List<AnimationDirection> list_2;

        // Token: 0x0400053F RID: 1343
        private readonly List<object[]> list_3;

        // Token: 0x04000540 RID: 1344
        private const double double_2 = 0.0;

        // Token: 0x04000541 RID: 1345
        private const double double_3 = 1.0;

        // Token: 0x04000542 RID: 1346
        private readonly System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer {
            Interval = 5,
            Enabled = false
        };

        // Token: 0x020000BC RID: 188
        // (Invoke) Token: 0x06000D53 RID: 3411
        public delegate void AnimationFinished(object sender);

        // Token: 0x020000BD RID: 189
        // (Invoke) Token: 0x06000D57 RID: 3415
        public delegate void AnimationProgress(object sender);
    }

    // Token: 0x020000B9 RID: 185
    public enum AnimationDirection {
        // Token: 0x0400052F RID: 1327
        In,
        // Token: 0x04000530 RID: 1328
        Out,
        // Token: 0x04000531 RID: 1329
        InOutIn,
        // Token: 0x04000532 RID: 1330
        InOutOut,
        // Token: 0x04000533 RID: 1331
        InOutRepeatingIn,
        // Token: 0x04000534 RID: 1332
        InOutRepeatingOut
    }

    public enum AnimationType {
        // Token: 0x04000546 RID: 1350
        Linear,
        // Token: 0x04000547 RID: 1351
        EaseInOut,
        // Token: 0x04000548 RID: 1352
        EaseOut,
        // Token: 0x04000549 RID: 1353
        CustomQuadratic
    }

    public static class AnimationLinear {
        // Token: 0x06000D2F RID: 3375 RVA: 0x0002C598 File Offset: 0x0002A798
        public static double CalculateProgress(double progress) {
            return progress;
        }
    }

    public static class AnimationEaseOut {
        // Token: 0x06000D5D RID: 3421 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
        public static double CalculateProgress(double progress) {
            return -1.0 * progress * (progress - 2.0);
        }
    }

    public static class AnimationCustomQuadratic {
        // Token: 0x06000D5E RID: 3422 RVA: 0x0002D118 File Offset: 0x0002B318
        public static double CalculateProgress(double progress) {
            double num = 0.6;
            return 1.0 - Math.Cos((Math.Max(progress, num) - num) * 3.1415926535897931 / 0.8);
        }
    }

    public static class AnimationEaseInOut {
        // Token: 0x06000D5A RID: 3418 RVA: 0x00008758 File Offset: 0x00006958
        // Note: this type is marked as 'beforefieldinit'.
        static AnimationEaseInOut() {
        }

        // Token: 0x06000D5B RID: 3419 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
        public static double CalculateProgress(double progress) {
            return AnimationEaseInOut.smethod_0(progress);
        }

        // Token: 0x06000D5C RID: 3420 RVA: 0x0002D0B8 File Offset: 0x0002B2B8
        private static double smethod_0(double double_1) {
            return double_1 - Math.Sin(double_1 * 2.0 * AnimationEaseInOut.double_0) / (2.0 * AnimationEaseInOut.double_0);
        }

        // Token: 0x04000543 RID: 1347
        public static double double_0 = 3.1415926535897931;

        // Token: 0x04000544 RID: 1348
        public static double PI_HALF = 1.5707963267948966;
    }
}
