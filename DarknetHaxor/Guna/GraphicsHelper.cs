using AimBotConquer.Guna;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimBotConquer.Guna {
    internal static class GraphicsHelper {
        internal static bool jRnYsRfX4gc5oyzpmzDhJKOBjD {
            get {
                return true;
            }
        }

        internal static TextFormatFlags KC2iXYaqNKZWymcJl47SLuTZoo(ContentAlignment A_0) {
            TextFormatFlags textFormatFlags;
            if ((A_0 & GraphicsHelper.riRwod4dSZHt4S8DEl39eoddksF) != (ContentAlignment)0) {
                textFormatFlags = TextFormatFlags.Right;
            } else if ((A_0 & GraphicsHelper.ARHKx9SjM9CEjdWpPF93LQejLcD) != (ContentAlignment)0) {
                textFormatFlags = TextFormatFlags.HorizontalCenter;
            } else {
                textFormatFlags = TextFormatFlags.Default;
            }
            return textFormatFlags;
        }
        private static readonly ContentAlignment ARHKx9SjM9CEjdWpPF93LQejLcD = (ContentAlignment)546;
        private static readonly ContentAlignment riRwod4dSZHt4S8DEl39eoddksF = (ContentAlignment)1092;
        private static readonly ContentAlignment VCfHqIcCyDbMQ5nSIEKDJW4bjZDA = (ContentAlignment)1792;
        private static readonly ContentAlignment rfKXa3lWW4tOTi6T3lGSbWnM7Qe = (ContentAlignment)112;
        internal static TextFormatFlags I4zFlSR8hyJ2tFStlhL9j0zGmOe(ContentAlignment A_0) {
            TextFormatFlags textFormatFlags;
            if ((A_0 & GraphicsHelper.VCfHqIcCyDbMQ5nSIEKDJW4bjZDA) != (ContentAlignment)0) {
                textFormatFlags = TextFormatFlags.Bottom;
            } else if ((A_0 & GraphicsHelper.rfKXa3lWW4tOTi6T3lGSbWnM7Qe) != (ContentAlignment)0) {
                textFormatFlags = TextFormatFlags.VerticalCenter;
            } else {
                textFormatFlags = TextFormatFlags.Default;
            }
            return textFormatFlags;
        }

        internal static TextFormatFlags xKyybR3oGtIvNaPD4b6hUZs4s7o(ContentAlignment A_0) {
            return TextFormatFlags.Default | GraphicsHelper.I4zFlSR8hyJ2tFStlhL9j0zGmOe(A_0) | GraphicsHelper.KC2iXYaqNKZWymcJl47SLuTZoo(A_0);
        }



        internal static TextFormatFlags fjVCJWCvVYpEk7u0QAIqjJKDyKs(Control A_0, ContentAlignment A_1, bool A_2, bool A_3) {
            TextFormatFlags textFormatFlags = GraphicsHelper.xKyybR3oGtIvNaPD4b6hUZs4s7o(A_1);
            textFormatFlags |= TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak;
            if (A_2) {
                textFormatFlags |= TextFormatFlags.EndEllipsis;
            }
            if (A_0.RightToLeft == RightToLeft.Yes) {
                textFormatFlags |= TextFormatFlags.RightToLeft;
            }
            if (!A_3) {
                textFormatFlags |= TextFormatFlags.NoPrefix;
            }
            return textFormatFlags;
        }

        internal static Color vEDc49hXtskwFRIJukhgn4tcHO(Color A_0, Color A_1, int A_2) {
            if ((A_0 == Color.Transparent) | (A_0 == Color.Empty)) {
                A_0 = Color.Black;
            }
            if ((A_1 == Color.Transparent) | (A_1 == Color.Empty)) {
                A_1 = A_0;
            }
            if (!(A_0 == A_1)) {
                return GraphicsHelper.BlendColorRGB(A_0, A_1, (double)(255 - A_2 * 255 / 100));
            }
            return A_0;
        }
        public static Color BlendColorARGB(Color color1, Color color2, double blend) {
            if (blend > 255.0) {
                return color1;
            }
            double num = blend / 255.0;
            double num2 = 1.0 - num;
            int num3 = (int)((double)color2.A * num2 + (double)color1.A * num);
            int num4 = (int)((double)color2.R * num2 + (double)color1.R * num);
            int num5 = (int)((double)color2.G * num2 + (double)color1.G * num);
            int num6 = (int)((double)color2.B * num2 + (double)color1.B * num);
            return Color.FromArgb(Math.Min(255, num3), Math.Min(255, num4), Math.Min(255, num5), Math.Min(255, num6));
        }

        // Kfwdnyrbaczf7OaE8KgAoP0wSPvA
        internal static Color BlendColorARGB(Color A_0, Color A_1, int A_2) {
            if (A_0 == Color.Transparent) {
                A_0 = Color.Empty;
            }
            if (A_1 == Color.Transparent) {
                A_1 = Color.Empty;
            }
            return GraphicsHelper.BlendColorARGB(A_0, A_1, (double)(255 - A_2 * 255 / 100));
        }

        public static Color BlendColorRGB(Color color1, Color color2, double blend) {
            if (blend > 255.0) {
                return color1;
            }
            double num = blend / 255.0;
            double num2 = 1.0 - num;
            int num3 = (int)((double)color2.R * num2 + (double)color1.R * num);
            int num4 = (int)((double)color2.G * num2 + (double)color1.G * num);
            int num5 = (int)((double)color2.B * num2 + (double)color1.B * num);
            return Color.FromArgb(255, Math.Min(255, num3), Math.Min(255, num4), Math.Min(255, num5));
        }

        internal static void e8xuehByKQyOb23dHalH4cbtF9(Graphics A_0, Color A_1, Rectangle A_2, Padding A_3, int A_4, CustomizableEdges A_5) {
            checked {
                if (A_4 > 0) {
                    if (A_3.Top > 0) {
                        A_0.DrawImage(GraphicsHelper.d6mCfjK2ocIhQUFnhUvH8neojCs(A_2.Width, A_2.Height, A_2.Width, A_3.Top, GraphicsHelper.Posisition.Top, A_1, A_3, A_4, A_5), new Rectangle(A_2.X, A_2.Y, A_2.Width, A_3.Top));
                    }
                    if (A_3.Left > 0) {
                        A_0.DrawImage(GraphicsHelper.d6mCfjK2ocIhQUFnhUvH8neojCs(A_2.Width, A_2.Height, A_3.Left, A_2.Height, GraphicsHelper.Posisition.Left, A_1, A_3, A_4, A_5), new Rectangle(A_2.X, A_2.Y, A_3.Left, A_2.Height));
                    }
                    if (A_3.Right > 0) {
                        A_0.DrawImage(GraphicsHelper.d6mCfjK2ocIhQUFnhUvH8neojCs(A_2.Width, A_2.Height, A_3.Right, A_2.Height, GraphicsHelper.Posisition.Right, A_1, A_3, A_4, A_5), new Rectangle(A_2.X + (A_2.Width - A_3.Right), A_2.Y, A_3.Right, A_2.Height));
                    }
                    if (A_3.Bottom > 0) {
                        A_0.DrawImage(GraphicsHelper.d6mCfjK2ocIhQUFnhUvH8neojCs(A_2.Width, A_2.Height, A_2.Width, A_3.Bottom, GraphicsHelper.Posisition.Bottom, A_1, A_3, A_4, A_5), new Rectangle(A_2.X, A_2.Y + (A_2.Height - A_3.Bottom), A_2.Width, A_3.Bottom));
                        return;
                    }
                } else {
                    GraphicsHelper.hzqKlcu1i8tZmhJb5dc3xOciq(A_0, new SolidBrush(A_1), A_2, A_3.Top, A_3.Left, A_3.Right, A_3.Bottom);
                }
            }
        }

        private static Image d6mCfjK2ocIhQUFnhUvH8neojCs(int A_0, int A_1, int A_2, int A_3, GraphicsHelper.Posisition A_4, Color A_5, Padding A_6, int A_7, CustomizableEdges A_8) {
            Bitmap bitmap = new Bitmap(A_2, A_3);
            Rectangle rectangle = GraphicsHelper.bdU8qiet6bn3bi4uHbyiXjAoJOD;
            checked {
                switch (A_4) {
                    case GraphicsHelper.Posisition.Top:
                        rectangle = new Rectangle(0, 0, A_0 - 1, A_1 - 1);
                        break;
                    case GraphicsHelper.Posisition.Left:
                        rectangle = new Rectangle(0, 0, A_0 - 1, A_1 - 1);
                        break;
                    case GraphicsHelper.Posisition.Right:
                        rectangle = new Rectangle(0 - A_0 + A_6.Right, 0, A_0 - 1, A_1 - 1);
                        break;
                    case GraphicsHelper.Posisition.Bottom:
                        rectangle = new Rectangle(0, 0 - (A_1 - A_6.Bottom), A_0 - 1, A_1 - 1);
                        break;
                }
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                GraphicsPath graphicsPath = GraphicsHelper.RoundRect(rectangle, (float)(A_7 * 2), A_8);
                graphics.FillPath(new SolidBrush(A_5), graphicsPath);
                using (Pen pen = new Pen(A_5, 1f)) {
                    graphics.DrawPath(pen, graphicsPath);
                }
                return bitmap;
            }
        }



        public static void DrawRoundBorder(Graphics G, Brush B, Rectangle R, int BorderRadius, int witdh, DashStyle dashType = DashStyle.Solid, CustomizableEdges CustomizableEdges = null) {
            if (witdh < 1) {
                return;
            }
            GraphicsPath graphicsPath = GraphicsHelper.TOHBd5TjQXb22uTMHHYRZlGWyKH(R, (float)BorderRadius, (float)witdh, CustomizableEdges);
            using (Pen pen = new Pen(B, (float)witdh)) {
                pen.DashStyle = dashType;
                G.DrawPath(pen, graphicsPath);
            }
        }

        public static void DrawBorder(Graphics G, Brush brush, Rectangle rect, int width, DashStyle dashtype = DashStyle.Solid) {
            if (width < 1) {
                return;
            }
            using (Pen pen = new Pen(brush, (float)width)) {
                pen.DashStyle = dashtype;
                GraphicsPath graphicsPath = new GraphicsPath();
                RectangleF rectangleF = new RectangleF((float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height);
                float num = (float)width / 2f;
                if (width > 1) {
                    rectangleF.X += num;
                    rectangleF.Y += num;
                }
                rectangleF.Width -= (float)width;
                rectangleF.Height -= (float)width;
                graphicsPath.AddRectangle(rectangleF);
                G.DrawPath(pen, graphicsPath);
            }
        }

        internal static void vpjK0QtdCHmBXDIIN67oClo14K(Graphics A_0, Image A_1, ImageLayout A_2, Rectangle A_3, Rectangle A_4, Point A_5, RightToLeft A_6) {
            if (A_2 == ImageLayout.Tile) {
                using (TextureBrush textureBrush = new TextureBrush(A_1, WrapMode.Tile)) {
                    if (A_5 != Point.Empty) {
                        Matrix transform = textureBrush.Transform;
                        transform.Translate((float)A_5.X, (float)A_5.Y);
                        textureBrush.Transform = transform;
                    }
                    A_0.FillRectangle(textureBrush, A_4);
                    return;
                }
            }
            Rectangle rectangle = GraphicsHelper.XAWF12pBNSvw2GGUwxnbIH6JYrR(A_3, A_1, A_2);
            checked {
                if (A_6 == RightToLeft.Yes && A_2 == ImageLayout.None) {
                    rectangle.X += A_4.Width - rectangle.Width;
                }
                if (!A_4.Contains(rectangle)) {
                    if (A_2 != ImageLayout.Stretch) {
                        if (A_2 != ImageLayout.Zoom) {
                            if (A_2 == ImageLayout.None) {
                                rectangle.Offset(A_4.Location);
                                rectangle.Intersect(A_4);
                                Rectangle rectangle2 = new Rectangle(Point.Empty, rectangle.Size);
                                A_0.DrawImage(A_1, rectangle, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel);
                                return;
                            }
                            rectangle.Intersect(A_4);
                            Rectangle rectangle3 = new Rectangle(new Point(rectangle.X - rectangle.X, rectangle.Y - rectangle.Y), rectangle.Size);
                            A_0.DrawImage(A_1, rectangle, rectangle3.X, rectangle3.Y, rectangle3.Width, rectangle3.Height, GraphicsUnit.Pixel);
                            return;
                        }
                    }
                    rectangle.Intersect(A_4);
                    A_0.DrawImage(A_1, rectangle);
                    return;
                }
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
                A_0.DrawImage(A_1, rectangle, 0, 0, A_1.Width, A_1.Height, GraphicsUnit.Pixel, imageAttributes);
                imageAttributes.Dispose();
            }
        }



        internal static RectangleF o2GhHXpYDnkVMC6SZ8zjIElSiFB(RectangleF A_0) {
            return new RectangleF(A_0.X, A_0.Y, A_0.Width - 1f, A_0.Height - 1f);
        }

        internal static Rectangle XAWF12pBNSvw2GGUwxnbIH6JYrR(Rectangle A_0, Image A_1, ImageLayout A_2) {
            Rectangle rectangle = A_0;
            checked {
                if (A_1 != null) {
                    switch (A_2) {
                        case ImageLayout.None:
                            rectangle.Size = A_1.Size;
                            break;
                        case ImageLayout.Center: {
                                rectangle.Size = A_1.Size;
                                Size size = A_0.Size;
                                if (size.Width > rectangle.Width) {
                                    rectangle.X = (int)Math.Round((double)(size.Width - rectangle.Width) / 2.0);
                                }
                                if (size.Height > rectangle.Height) {
                                    rectangle.Y = (int)Math.Round((double)(size.Height - rectangle.Height) / 2.0);
                                }
                                break;
                            }
                        case ImageLayout.Stretch:
                            rectangle.Size = A_0.Size;
                            break;
                        case ImageLayout.Zoom: {
                                Size size2 = A_1.Size;
                                float num = (float)A_0.Width / (float)size2.Width;
                                float num2 = (float)A_0.Height / (float)size2.Height;
                                if (num < num2) {
                                    rectangle.Width = A_0.Width;
                                    rectangle.Height = (int)Math.Round(unchecked((double)((float)size2.Height * num) + 0.5));
                                    if (A_0.Y >= 0) {
                                        rectangle.Y = (int)Math.Round((double)(A_0.Height - rectangle.Height) / 2.0);
                                    }
                                } else {
                                    rectangle.Height = A_0.Height;
                                    rectangle.Width = (int)Math.Round(unchecked((double)((float)size2.Width * num2) + 0.5));
                                    if (A_0.X >= 0) {
                                        rectangle.X = (int)Math.Round((double)(A_0.Width - rectangle.Width) / 2.0);
                                    }
                                }
                                break;
                            }
                    }
                }
                return rectangle;
            }
        }

        public static Color BindColor(Color color1, Color color2) {
            int num = (int)((double)(color1.A + color2.A) / 2.0);
            int num2 = (int)((double)(color1.R + color2.R) / 2.0);
            int num3 = (int)((double)(color1.G + color2.G) / 2.0);
            int num4 = (int)((double)(color1.B + color2.B) / 2.0);
            return Color.FromArgb(Math.Min(255, num), Math.Min(255, num2), Math.Min(255, num3), Math.Min(255, num4));
        }
        internal static Color Kfwdnyrbaczf7OaE8KgAoP0wSPvA(Color A_0, Color A_1, int A_2) {
            if (A_0 == Color.Transparent) {
                A_0 = Color.Empty;
            }
            if (A_1 == Color.Transparent) {
                A_1 = Color.Empty;
            }
            return GraphicsHelper.BlendColorARGB(A_0, A_1, (double)(255 - A_2 * 255 / 100));
        }

        internal static GraphicsPath TOHBd5TjQXb22uTMHHYRZlGWyKH(Rectangle A_0, float A_1, float A_2, CustomizableEdges A_3) {
            RectangleF rectangleF = new RectangleF((float)A_0.X, (float)A_0.Y, (float)A_0.Width, (float)A_0.Height);
            rectangleF.Width -= 1f;
            rectangleF.Height -= 1f;
            if (A_2 == 1f) {
                return GraphicsHelper.RoundRect(rectangleF, A_1 * 2f, A_3);
            }
            float num = A_2 / 2f;
            rectangleF.X += num;
            rectangleF.Y += num;
            rectangleF.Width -= A_2;
            rectangleF.Height -= A_2;
            return GraphicsHelper.RoundRect(rectangleF, A_1 * 2f - 1f, A_3);
        }

        internal static void hzqKlcu1i8tZmhJb5dc3xOciq(Graphics A_0, Brush A_1, Rectangle A_2, int A_3, int A_4, int A_5, int A_6) {
            if (A_3 > 0) {
                A_0.FillRectangle(A_1, new Rectangle((A_4 > 0) ? A_4 : 0, 0, A_2.Width - ((A_5 > 0) ? A_5 : 0), A_3));
            }
            if (A_4 > 0) {
                A_0.FillRectangle(A_1, new Rectangle(0, 0, A_4, A_2.Height));
            }
            if (A_5 > 0) {
                A_0.FillRectangle(A_1, new Rectangle(A_2.Width - A_5, 0, A_5, A_2.Height));
            }
            if (A_6 > 0) {
                A_0.FillRectangle(A_1, new Rectangle((A_4 > 0) ? A_4 : 0, A_2.Height - A_6, A_2.Width - ((A_5 > 0) ? A_5 : 0), A_6));
            }
        }

        public static GraphicsPath RoundRect(RectangleF rect, float BorderRadius, CustomizableEdges CustomizableEdges) {
            GraphicsPath graphicsPath = new GraphicsPath();
            RectangleF rectangleF = rect;
            rectangleF.X -= 0.1f;
            if (CustomizableEdges == null) {
                graphicsPath.AddArc(rectangleF.X, rectangleF.Y, BorderRadius, BorderRadius, 180f, 90f);
                graphicsPath.AddArc(rectangleF.X + rectangleF.Width - BorderRadius, rectangleF.Y, BorderRadius, BorderRadius, 270f, 90f);
                graphicsPath.AddArc(rectangleF.X + rectangleF.Width - BorderRadius, rectangleF.Y + rectangleF.Height - BorderRadius, BorderRadius, BorderRadius, 0f, 90f);
                graphicsPath.AddArc(rectangleF.X, rectangleF.Y + rectangleF.Height - BorderRadius, BorderRadius, BorderRadius, 90f, 90f);
                graphicsPath.CloseAllFigures();
            } else {
                if (CustomizableEdges.TopLeft) {
                    graphicsPath.AddArc(rectangleF.X, rectangleF.Y, BorderRadius, BorderRadius, 180f, 90f);
                } else {
                    graphicsPath.AddArc(rectangleF.X, rectangleF.Y, 1f, 1f, 180f, 90f);
                }
                if (!CustomizableEdges.TopRight) {
                    graphicsPath.AddArc(rectangleF.X + rectangleF.Width - 1f, rectangleF.Y, 1f, 1f, 270f, 90f);
                } else {
                    graphicsPath.AddArc(rectangleF.X + rectangleF.Width - BorderRadius, rectangleF.Y, BorderRadius, BorderRadius, 270f, 90f);
                }
                if (!CustomizableEdges.BottomRight) {
                    graphicsPath.AddArc(rectangleF.X + rectangleF.Width - 1f, rectangleF.Y + rectangleF.Height - 1f, 1f, 1f, 0f, 90f);
                } else {
                    graphicsPath.AddArc(rectangleF.X + rectangleF.Width - BorderRadius, rectangleF.Y + rectangleF.Height - BorderRadius, BorderRadius, BorderRadius, 0f, 90f);
                }
                if (CustomizableEdges.BottomLeft) {
                    graphicsPath.AddArc(rectangleF.X, rectangleF.Y + rectangleF.Height - BorderRadius, BorderRadius, BorderRadius, 90f, 90f);
                } else {
                    graphicsPath.AddArc(rectangleF.X, rectangleF.Y + rectangleF.Height - 1f, 1f, 1f, 90f, 90f);
                }
                graphicsPath.CloseAllFigures();
            }
            return graphicsPath;
        }

        internal static Rectangle bdU8qiet6bn3bi4uHbyiXjAoJOD = new Rectangle(0, 0, 0, 0);

        public enum Posisition {
            Top,
            Left,
            Right,
            Bottom,
            None
        }
    }
}
