using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VectorCreater
{
    
    class Shape //базовый класс с виртуальными методами
    {
        protected Color clr;
        virtual public void draw(PictureBox sender, Bitmap bmp, Graphics g)
        {
        }
        virtual public bool isChecked(MouseEventArgs e)
        {
            return false;
        }
        virtual public void move(PictureBox sender,int _x,int _y) 
        {
        }
        virtual public void resize(PictureBox sender,int _d) 
        {
        }
        virtual public void changeColor(Color _clr)
        {
            clr = _clr;
        }
        virtual public bool getF()
        {
            return false;
        }
        virtual public void slect1()
        {
        }
        virtual public void slect2()
        {
        }

    }

    class CSquare : Shape
    {
        private int x,y,l;
        private bool f;
        public CSquare(int _x,int _y,int _l) 
        {
            x = _x;
            y = _y;
            l = _l;          
            f = true;
            clr = Color.Black;
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Rectangle rect = new Rectangle(x-l/2, y-l/2, l, l);
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            g.DrawRectangle(pen, rect);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender)
        {
            if ((x + l/2 > sender.Location.X + sender.Size.Width) || x - l/2 < sender.Location.X)
            {
                return false;
            }
            else if ((y + l/2 > sender.Location.Y + sender.Size.Height) || y - l/2 < sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender,int _x, int _y)
        {
            x = x + _x;
            y = y + _y;
            if(locationCheck(sender) == false) 
            {
                x = x - _x;
                y = y - _y;
            }
        }
        public override void resize(PictureBox sender,int _d)
        {
            l = l + _d/2;
            if (locationCheck(sender) == false)
            {
                l = l - _d / 2;
            }
        }


        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            if (e.X >= x - l/2 && e.Y >= y - l/2 && e.X <= x + l/2 && e.Y <= y + l/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }
    }
    class CTriangle : Shape 
    {
        private Point a, b, c;
        private bool f;
        public CTriangle(int x1,int x2,int y1,int y2,int z1,int z2) 
        {
            a = new Point(x1, x2);
            b = new Point(y1, y2);
            c = new Point(z1, z2);
            f = true;
            clr = Color.Black;
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
            }
            Point[] CurvePoints = { a, b, c };
            g.DrawPolygon(pen, CurvePoints);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender) 
        {
            if((b.X > sender.Location.X + sender.Size.Width) || c.X < sender.Location.X) 
            {
                return false;
            } 
            else if((b.Y > sender.Location.Y + sender.Size.Height) || a.Y < sender.Location.Y) 
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender,int _x, int _y)
        {
            a.X += _x;
            a.Y += _y;
            b.X += _x;
            b.Y += _y;
            c.X += _x;
            c.Y += _y;
            if(locationCheck(sender) == false) 
            {
                a.X -= _x;
                a.Y -= _y;
                b.X -= _x;
                b.Y -= _y;
                c.X -= _x;
                c.Y -= _y;
            }
        }
        public override void resize(PictureBox sender,int _d)
        {
            a.Y = a.Y - _d/2;
            b.X = b.X + _d/2;
            b.Y = b.Y + _d/2;
            c.X = c.X - _d/2;
            c.Y = c.Y + _d/2;
            if(locationCheck(sender) == false) 
            {
                a.Y = a.Y + _d / 2;
                b.X = b.X - _d / 2;
                b.Y = b.Y - _d / 2;
                c.X = c.X + _d / 2;
                c.Y = c.Y - _d / 2;
            }
        }
        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            int p1 = (a.X - e.X) * (b.Y - a.Y) - (b.X - a.X) * (a.Y - e.Y);
            int p2 = (b.X - e.X) * (c.Y - b.Y) - (c.X - b.X) * (b.Y - e.Y);
            int p3 = (c.X - e.X) * (a.Y - c.Y) - (a.X - c.X) * (c.Y - e.Y);
            if ((p1 >= 0 && p2 >= 0 && p3 >= 0) || (p1 <= 0 && p2<= 0 && p3 <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }



    }
    class CCircle : Shape //класс окружности, унаследованный от базового класса
    {
        private int x, y, r; //координаты и радиус
        private bool f; //булевая переменная, показывающая, "выделен" объект или нет
        public CCircle(int _x, int _y, int _r) //констурктор с параметрами
        {
            x = _x;
            y = _y;
            r = _r;
            f = true;
            clr = Color.Black;
        }
        override public void draw(PictureBox sender, Bitmap bmp, Graphics g) //метод для рисования на pictureBox
        {
            Rectangle rect = new Rectangle(x - r, y - r, r * 2, r * 2);
            Pen pen = new Pen(clr);
            if (f == true) //проверка на то, "выделен" ли объект или нет
            {
                pen.Width = 2; //выделение объекта толтсой линией
                //pen.Width = 2;
            }
            g.DrawEllipse(pen, rect);
            sender.Image = bmp;
        }
        private bool locationCheck(PictureBox sender)
        {
            if ((x+r > sender.Location.X + sender.Size.Width) || x-r < sender.Location.X)
            {
                return false;
            }
            else if ((y+r > sender.Location.Y + sender.Size.Height) || y-r < sender.Location.Y)
            {
                return false;
            }
            return true;
        }
        public override void move(PictureBox sender,int _x,int _y)
        {
            x = x + _x;
            y = y + _y;
            if(locationCheck(sender) == false) 
            {
                x = x - _x;
                y = y - _y;
            }
        }
        public override void resize(PictureBox sender,int _d)
        {
            r = r + _d/2;
            if(locationCheck(sender) == false) 
            {
                r = r - _d / 2;
            }
        }
        override public bool isChecked(MouseEventArgs e) //проверка на то, нажат ли объект мышкой
        {
            if (((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)) <= (r * r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override public bool getF() //получение значения " выделенный/не выделенный" у объекта
        {
            return f;
        }
        override public void slect1() //изменение значения f на true
        {
            f = true;
        }
        override public void slect2() //изменение значения f на false
        {
            f = false;
        }
    }
    class Storage
    {
        private int _maxcount;
        private int _count;
        private Shape[] _storage;
        //public System.EventHandler observers;
        public Storage(int maxcount)
        {
            _maxcount = maxcount; _count = 0;
            _storage = new Shape[_maxcount];
            for (int i = 0; i < _maxcount; i++)
                _storage[i] = null;
        }
        public void addObj(Shape obj) //добавление объекта
        {
            if (_count >= _maxcount)
            {
                Array.Resize(ref _storage, _count + 1);
                _storage[_count] = obj;
                _count++;
                _maxcount++;
            }
            else if (_count == 0)
            {
                _count++;
                _storage[_count - 1] = obj;

            }
            else
            {
                _count++;
                _storage[_count - 1] = obj;
                for (int i = 0; i < _count - 1; i++)
                {
                    _storage[i].slect2();
                }
            }
        }
        public void deleteObj(int index)
        {
            _storage[index] = null;
            for (int i = index + 1; i < _count; i++)
            {
                _storage[i - 1] = _storage[i];
            }
            _storage[_count - 1] = null;
            _count--;
        }
        public void methodObj(PictureBox sender, int index, Bitmap bmp, Graphics g) //вызов draw у объекта по индексу
        {
            if (_storage[index] != null)
            {
                _storage[index].draw(sender, bmp, g);
            }
        }
        public void moveObj(PictureBox sender,int _x, int _y)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {                        
                        _storage[i].move(sender,_x, _y);
                    }
                }
            }
        }
        public void resizeObj(PictureBox sender,int _d)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].resize(sender,_d);
                    }
                }
            }
            //observers.Invoke(this, null);
        }
        public void changeObjColor(Color _clr)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].changeColor(_clr);
                    }
                }
            }
        }
        public int getCount() //получение количества объектов в хранилище (на форме)
        {
            return _count;
        }
        public void allObjFalse()  //все объекты перестают быть выделенными
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        _storage[i].slect2();
                    }
                }

            }
        }
        public void deleteWhenDel() //удаление выделенных объектов при нажатии кнопки Delete
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].getF() == true)
                    {
                        deleteObj(i);
                    }
                }
            }
        }
        public bool checkInfo1(MouseEventArgs e) //проверка того, нажат ли объект на форме, если клавиша Ctrl не нажата
        {
            for (int i = 0; i < getCount(); i++)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].isChecked(e) == true)
                    {
                        allObjFalse();
                        _storage[i].slect1();
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        public bool checkInfo2(MouseEventArgs e) //проверка того, нажат ли объект на форме, если клавиша Ctrl нажата
        {
            for (int i = 0; i < getCount(); i++)
            {
                if (_storage[i] != null)
                {
                    if (_storage[i].isChecked(e) == true)
                    {
                        _storage[i].slect1();
                        return true;
                        break;
                    }
                }
            }
            return false;
        }

    }
    class Command 
    {
        virtual public void execute(PictureBox sender, Shape _selection) 
        {
        }
        virtual public void unexecute() 
        {
        }      
    }
    class MoveCommand : Command
    {
        Shape selection;
        int _x; int _y;
        public MoveCommand(int dx, int dy)
        {
            
            _x = dx;
            _y = dy;
            selection = null;
        }
        override public void execute(PictureBox sender,Shape _selection)
        {          
            _selection = selection;
            if (_selection != null)
            {
                _selection.move(sender,_x, _y);
            }
        }
    }

}