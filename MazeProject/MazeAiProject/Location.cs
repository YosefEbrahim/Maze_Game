using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeAiProject
{
    public class Location
    {

        public int x { get; set; }
        public int y { get; set; }
        public Location Parent { get; set; }
        public int PathCost { get; set; }
        public Location()
        {

        }
        public Location(PictureBox pic)
        {
            this.x = pic.Location.X;
            this.y = pic.Location.Y;
            this.Parent = new Location(0, 0);
            this.PathCost = 0;

        }
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Location(int x, int y, Location parent)
        {
            this.x = x;
            this.y = y;
            this.Parent = parent;
            this.PathCost = parent.PathCost + 5;

        }
    }

}
