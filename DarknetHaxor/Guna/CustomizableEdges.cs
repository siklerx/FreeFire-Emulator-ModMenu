using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AimBotConquer.Guna
{
    // Token: 0x020000ED RID: 237
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("You can choose which edges will be included when styling the border radius")]
    public class CustomizableEdges
    {
        // Token: 0x06001284 RID: 4740 RVA: 0x00057264 File Offset: 0x00055464
        public CustomizableEdges(bool A_1, bool A_2, bool A_3, bool A_4)
        {
            this.TopLeft = A_3;
            this.TopRight = A_4;
            this.BottomLeft = A_1;
            this.BottomRight = A_2;
        }

        // Token: 0x06001285 RID: 4741 RVA: 0x000572B0 File Offset: 0x000554B0
        public CustomizableEdges()
        {
        }

        // Token: 0x06001286 RID: 4742 RVA: 0x000572E0 File Offset: 0x000554E0
        private void nqysj4YvYorHGK4MnerCLAgf5c()
        {
            if (this.TwHanDGKMGVJNJSxGLvTA3SQgH != null)
			{
                this.TwHanDGKMGVJNJSxGLvTA3SQgH.Invalidate();
            }
        }

        // Token: 0x06001287 RID: 4743 RVA: 0x00057300 File Offset: 0x00055500
        public override string ToString()
        {
            return string.Concat(new string[]
            {
                this.BottomLeft.ToString(),
                ", ",
                this.BottomRight.ToString(),
                ", ",
                this.TopLeft.ToString(),
                ", ",
                this.TopRight.ToString()
            });
        }

        // Token: 0x17000583 RID: 1411
        // (get) Token: 0x06001288 RID: 4744 RVA: 0x00057374 File Offset: 0x00055574
        // (set) Token: 0x06001289 RID: 4745 RVA: 0x00057388 File Offset: 0x00055588
        [DefaultValue(true)]
        public bool TopLeft
        {
            get
            {
                return this.lpGGOlxcGU1eEyQBJJUuHDWMjd6;
            }
            set
            {
                if (this.lpGGOlxcGU1eEyQBJJUuHDWMjd6 == value)
                {
                    return;
                }
                this.lpGGOlxcGU1eEyQBJJUuHDWMjd6 = value;
                this.nqysj4YvYorHGK4MnerCLAgf5c();
            }
        }

        // Token: 0x17000584 RID: 1412
        // (get) Token: 0x0600128A RID: 4746 RVA: 0x000573AC File Offset: 0x000555AC
        // (set) Token: 0x0600128B RID: 4747 RVA: 0x000573C0 File Offset: 0x000555C0
        [DefaultValue(true)]
        public bool TopRight
        {
            get
            {
                return this.p8SSF4dTRidxnOBHCmbLPkjnR2;
            }
            set
            {
                if (this.p8SSF4dTRidxnOBHCmbLPkjnR2 == value)
				{
                    return;
                }
                this.p8SSF4dTRidxnOBHCmbLPkjnR2 = value;
                this.nqysj4YvYorHGK4MnerCLAgf5c();
            }
        }

        // Token: 0x17000585 RID: 1413
        // (get) Token: 0x0600128C RID: 4748 RVA: 0x000573E4 File Offset: 0x000555E4
        // (set) Token: 0x0600128D RID: 4749 RVA: 0x000573F8 File Offset: 0x000555F8
        [DefaultValue(true)]
        public bool BottomLeft
        {
            get
            {
                return this.Eww86ei1jXBuIdPurJ6dPLeK6Ei;
            }
            set
            {
                if (this.Eww86ei1jXBuIdPurJ6dPLeK6Ei == value)
                {
                    return;
                }
                this.Eww86ei1jXBuIdPurJ6dPLeK6Ei = value;
                this.nqysj4YvYorHGK4MnerCLAgf5c();
            }
        }

        // Token: 0x17000586 RID: 1414
        // (get) Token: 0x0600128E RID: 4750 RVA: 0x0005741C File Offset: 0x0005561C
        // (set) Token: 0x0600128F RID: 4751 RVA: 0x00057430 File Offset: 0x00055630
        [DefaultValue(true)]
        public bool BottomRight
        {
            get
            {
                return this.AbdF560AAlOb17xqEjmXBxzH53O;
            }
            set
            {
                if (this.AbdF560AAlOb17xqEjmXBxzH53O == value)
                {
                    return;
                }
                this.AbdF560AAlOb17xqEjmXBxzH53O = value;
                this.nqysj4YvYorHGK4MnerCLAgf5c();
            }
        }

        // Token: 0x06001290 RID: 4752 RVA: 0x00057454 File Offset: 0x00055654
        public static CustomizableEdges TryParse(string input)
        {
            input = input.Replace(" ", "");
            string[] array = input.Split(new char[] { ',' });
            bool flag;
            bool flag2;
            bool flag3;
            bool flag4;
            if (bool.TryParse(array[0], out flag) && bool.TryParse(array[1], out flag2) && bool.TryParse(array[2], out flag3) && bool.TryParse(array[3], out flag4))
            {
                return new CustomizableEdges(flag3, flag4, flag, flag2);
            }
            return null;
        }

        // Token: 0x04000780 RID: 1920
        internal Control TwHanDGKMGVJNJSxGLvTA3SQgH;

		// Token: 0x04000781 RID: 1921
		private bool lpGGOlxcGU1eEyQBJJUuHDWMjd6 = true;

        // Token: 0x04000782 RID: 1922
        private bool p8SSF4dTRidxnOBHCmbLPkjnR2 = true;

		// Token: 0x04000783 RID: 1923
		private bool Eww86ei1jXBuIdPurJ6dPLeK6Ei = true;

        // Token: 0x04000784 RID: 1924
        private bool AbdF560AAlOb17xqEjmXBxzH53O = true;
    }
}
