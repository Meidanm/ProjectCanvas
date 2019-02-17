using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class MyCanvas
    { public const int MaxWidth = 800;
        public const int MaxHeight = 600;
        private static int buttonIndex = 0;
        private static int maxButtons = 3;
        private static MyButton[] buttons = new MyButton[maxButtons];

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (buttonIndex < maxButtons && x1 <= MaxWidth && x2 <= MaxWidth && y1 <= MaxHeight && y2 <= MaxHeight)
            {
                Point topLeft = new Point(x1, y1);
                Point bottomRight = new Point(x2, y2);
                MyButton button = new MyButton(topLeft, bottomRight);
                buttons[buttonIndex] = button;
                buttonIndex++;
                return true;
            }
            else
                return false;
        }

        public static bool MoveButton(int x, int y, int index)
        {
            if (index < buttonIndex)
            {
                if (buttons[index].GetTopLeft().GetX() + x <= MaxWidth && buttons[index].GetTopLeft().GetY() + y <= MaxHeight && buttons[index].GetBottomRight().GetX() + x <= MaxWidth && buttons[index].GetBottomRight().GetY() + y <= MaxHeight)
                {
                    Point newTop = new Point(x + buttons[index].GetTopLeft().GetX(), y + buttons[index].GetTopLeft().GetY());
                    Point newButton = new Point(x + buttons[index].GetBottomRight().GetX(), y + buttons[index].GetBottomRight().GetY());
                    buttons[index].SetTopLeft(newTop);
                    buttons[index].SetBottomRight(newButton);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public static bool DeleteLastButton()
        {
            if (buttonIndex > 0)
            {
                MyButton[] temp = new MyButton[maxButtons - 1];
                for (int i = 0; i < maxButtons - 1; i++)
                {
                    temp[i] = buttons[i];
                }
                buttons = temp;
                return true;
            }
            else
                return false;

        }

        public static void ClearAllButtons()
        {
            if (buttonIndex > 0)
            {
                buttons = null;
            }

        }
        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return maxButtons;
        }

        public static int GetMaxWidthOffAButton()
        {
            if (buttonIndex > 0)
            {
                int max = 0;
                for (int i = 0; i < buttonIndex; i++)
                {
                    if (buttons[i].GetWidth() > max)
                    {
                        max = buttons[i].GetWidth();
                    }
                }
                return max;
            }
            else
                return 0;

        }

        public static int GetMaxHeightOffAButtoon()
        {
            if (buttonIndex > 0)
            {
                int max = 0;
                for (int i = 0; i < buttonIndex; i++)
                {
                    if (buttons[i].GetHeight() > max)
                    {
                        max = buttons[i].GetHeight();
                    }
                }
                return max;
            }
            else
                return         }
    }
}    

  

