using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeAiProject
{
    class UnInformedSearch
    {
        Level_One one=null;
        Level_Two two = null;
        Level_Three three = null;
        Location initialState = null;
        Queue<Location> bfsQueue=null;
        Location currentNode=null;
        List<Location> Vistied=null;
        public UnInformedSearch(Parent p)
        {

                 Vistied = new List<Location>();
                 bfsQueue = new Queue<Location>();
                 currentNode = new Location();
            if (p.one !=null)
            {
                 one = p.one;
                 initialState = new Location(one.picFrame);

            }
            else if (p.Two != null)
            {
                two = p.Two;
                 initialState = new Location(two.picFrame);

            }
            else if (p.Three != null)
            {
                three = p.Three;
                 initialState = new Location(three.picFrame);

            }
        }
        

        public List<Location> BFS(bool keyCheck)
        {
            bfsQueue.Enqueue(initialState);
            Vistied.Add(initialState);
            while (bfsQueue.Count != 0)
            {
                //Remove
                currentNode = (Location)bfsQueue.Dequeue();
                if (one != null)
                {
                    one.picFrame.Top = currentNode.y;
                    one.picFrame.Left = currentNode.x;
                    var returnPic = one.Controls.Find("Goal", true);
                    if (one.picFrame.Bounds.IntersectsWith(returnPic[0].Bounds))
                    {
                        List<Location> sol = new List<Location>();
                        if (keyCheck == true)
                        {
                            while (currentNode != null)
                            {
                                sol.Insert(0, currentNode);
                                currentNode = currentNode.Parent;
                            }
                            return sol;
                        }
                        else
                        {
                            return Vistied;
                        }
                    }

                }
                else if (two != null)
                {
                    two.picFrame.Top = currentNode.y;
                    two.picFrame.Left = currentNode.x;
                    var returnPic = two.Controls.Find("Goal", true);
                    if (two.picFrame.Bounds.IntersectsWith(returnPic[0].Bounds))
                    {
                        List<Location> sol = new List<Location>();
                        if (keyCheck == true)
                        {
                            while (currentNode != null)
                            {
                                sol.Insert(0, currentNode);
                                currentNode = currentNode.Parent;
                            }
                            return sol;
                        }
                        else
                        {
                            return Vistied;
                        }
                    }
                }
                else if (three != null)
                {
                    three.picFrame.Top = currentNode.y;
                    three.picFrame.Left = currentNode.x;
                    var returnPic = three.Controls.Find("Goal", true);
                    if (three.picFrame.Bounds.IntersectsWith(returnPic[0].Bounds))
                    {
                        List<Location> sol = new List<Location>();
                        if (keyCheck == true)
                        {
                            while (currentNode != null)
                            {
                                sol.Insert(0, currentNode);
                                currentNode = currentNode.Parent;
                            }
                            return sol;
                        }
                        else
                        {
                            return Vistied;
                        }
                    }
                }

                //add Childern
                Location nextP1 = null;
                Location nextP2 = null;
                Location nextP3 = null;
                Location nextP4 = null;
                if (check(currentNode.x + 5, currentNode.y))
                {

                    nextP1 = new Location(currentNode.x + 5, currentNode.y, currentNode);
                }

                if (check(currentNode.x - 5, currentNode.y))
                {
                    nextP2 = new Location(currentNode.x - 5, currentNode.y, currentNode);
                }

                if (check(currentNode.x, currentNode.y + 5))
                {
                    nextP3 = new Location(currentNode.x, currentNode.y + 5, currentNode);
                }
                if (check(currentNode.x, currentNode.y - 5))
                {
                    nextP4 = new Location(currentNode.x, currentNode.y - 5, currentNode);

                }
                if (Search(nextP4))
                {
                    bfsQueue.Enqueue(nextP4);
                    Vistied.Add(nextP4);
                }
                if (Search(nextP1))
                {
                    bfsQueue.Enqueue(nextP1);
                    Vistied.Add(nextP1);

                }
                if (Search(nextP3))
                {
                    bfsQueue.Enqueue(nextP3);
                    Vistied.Add(nextP3);
                }
                if (Search(nextP2))
                {
                    bfsQueue.Enqueue(nextP2);
                    Vistied.Add(nextP2);
                }


            }
            return null;
        }
        public bool Search(Location current)
        {
            for (int i = 0; i < Vistied.Count; i++)
            {
                if (current == null || (current.x == Vistied[i].x && current.y == Vistied[i].y))
                {
                    return false;
                }
            }
            return true;
        }

        public bool check(int x, int y)
        {
            if (one != null)
            {

                one.picFrame.Left = x;
                one.picFrame.Top = y;
                one.Controls.Remove(one.pictureBox34);
                var returnPic = one.Controls.Find("Goal", true);
                foreach (Control c2 in one.Controls)
                {
                    if ((c2 != (one.picFrame) && c2 != (returnPic[0])) && c2 is PictureBox
                        && one.picFrame.Bounds.IntersectsWith(c2.Bounds))
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (two != null)
            {
                two.picFrame.Left = x;
                two.picFrame.Top = y;
                two.Controls.Remove(two.pictureBox34);
                var returnPic = two.Controls.Find("Goal", true);
                foreach (Control c2 in two.Controls)
                {
                    if ((c2 != (two.picFrame) && c2 != (returnPic[0])) && c2 is PictureBox
                        && two.picFrame.Bounds.IntersectsWith(c2.Bounds))
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (three != null)
            {
                three.picFrame.Left = x;
                three.picFrame.Top = y;
                three.Controls.Remove(three.pictureBox34);
                var returnPic = three.Controls.Find("Goal", true);
                foreach (Control c2 in three.Controls)
                {
                    if ((c2 != (three.picFrame) && c2 != (returnPic[0])) && c2 is PictureBox
                        && three.picFrame.Bounds.IntersectsWith(c2.Bounds))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
    }
}